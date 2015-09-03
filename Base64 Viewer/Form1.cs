using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Xsl;
using System.Diagnostics;

namespace Base64_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //GLOBAL VARIABLES
        string fileNameGlobal;
        int panel_URL_count = 0;
        int panel_URL_DR_count = 0;

        //FORM LOAD & CLOSE
        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Value = 5;
            Directory.Delete("temp", true);
        }

        //FUNCTIONS
        private void clearWeb()
        {
            webBrowser_previewer.Navigate("about:blank");
            webBrowser_previewer.Refresh(WebBrowserRefreshOption.Completely);
            trackBar1.Value = 5;
            toolStripLabel_zoom.Text = "100%";
        }
        private string timeString()
        {
            string time = string.Empty;

            string YY = DateTime.Now.Year.ToString("D2");
            string MM = DateTime.Now.Month.ToString("D2");
            string dd = DateTime.Now.Day.ToString("D2");
            string HH = DateTime.Now.Hour.ToString("D2");
            string mm = DateTime.Now.Minute.ToString("D2");
            string ss = DateTime.Now.Second.ToString("D2");
            string sss = DateTime.Now.Millisecond.ToString("D3");
            time = YY + MM + dd + HH + mm + ss + sss;

            return time;
        }

        //BASE64 FUNCTIONS
        private void createFileFromBase(string base64String, string extension)
        {
            string extensionNew = extension.ToLower();

            fileNameGlobal = timeString() + "." + extensionNew;
            Directory.CreateDirectory("temp");

            //BINARY COPY
            File.WriteAllText("temp\\" + fileNameGlobal.Split('.')[0] + "_64", base64String);

            byte[] bytes = Convert.FromBase64String(base64String);

            FileStream stream = new FileStream("temp\\" + fileNameGlobal, FileMode.CreateNew);
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(bytes, 0, bytes.Length);
            writer.Close();
        }
        private string getACORDBaseString(int[] pathArray)
        {
            string baseString = string.Empty;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(listBox_files.Items[pathArray[0]].ToString());

                XmlNamespaceManager nsMgr = new XmlNamespaceManager(xmlDoc.NameTable);
                nsMgr.AddNamespace("AC", "http://ACORD.org/Standards/Life/2");

                string newPath = "//AC:TXLifeRequest[" + (pathArray[1] + 1).ToString() + "]/AC:OLifE/AC:FormInstance[" + (pathArray[2] + 1).ToString() + "]/AC:Attachment/AC:AttachmentData";
                baseString = xmlDoc.SelectSingleNode(newPath, nsMgr).InnerText;
            }
            catch { }

            return baseString;
        }
        private string getACORDBaseType(int[] pathArray)
        {
            string baseType = string.Empty;


            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(listBox_files.Items[pathArray[0]].ToString());

            XmlNamespaceManager nsMgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsMgr.AddNamespace("AC", "http://ACORD.org/Standards/Life/2");

            string newPath = "//AC:TXLifeRequest[" + (pathArray[1] + 1).ToString() + "]/AC:OLifE/AC:FormInstance[" + (pathArray[2] + 1).ToString() + "]/AC:Attachment/AC:ImageType";
            if (xmlDoc.SelectSingleNode(newPath, nsMgr) != null)
            {
                baseType = xmlDoc.SelectSingleNode(newPath, nsMgr).InnerText;
            }
            else
            {
                baseType = "pdf";
            }

            return baseType;
        }
        private string getCOSSBaseString(int[] pathArray)
        {
            string baseString = string.Empty;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(listBox_files.Items[pathArray[0]].ToString());

            string newPath = "//Data[starts-with(@Name,'PDF_IMAGE')][" + (pathArray[2] + 1).ToString() + "]";
            baseString = xmlDoc.SelectSingleNode(newPath).InnerText;

            return baseString;
        }
        private void toolStripComboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //clearWeb();
                string type = toolStripComboBox_type.Text.ToLower();
                createFileFromBase(File.ReadAllText("temp\\" + fileNameGlobal.Split('.')[0] + "_64"), type);

                if (type == "TIF" || type == "tif" || type == "jpg" || type == "png" || type == "bmp")
                {
                    try
                    {
                        string path = Directory.GetCurrentDirectory().ToString() + "\\temp\\" + fileNameGlobal;
                        webBrowser_previewer.Navigate("about:<html><body scroll=no><img src ='" + path + "'></img></body></html>");
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        string path = "temp\\" + fileNameGlobal;
                        webBrowser_previewer.Navigate(path);
                    }
                    catch { }
                }
            }
            catch { }
        }

        //ADDING FILES
        #region
        private void toolStripButton_add_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] files = openFileDialog1.FileNames;
            foreach (string file in files)
            {
                listBox_files.Items.Add(file);
            }
            generateTree();
            //treeView_files.Focus();
        }
        private void toolStripButton_remove_Click(object sender, EventArgs e)
        {
            try
            {
                listBox_files.Items.RemoveAt(listBox_files.SelectedIndex);
            }
            catch { }
            generateTree();
        }
        private void toolStripButton_removeAll_Click(object sender, EventArgs e)
        {

            listBox_files.Items.Clear();
            treeView_files.Nodes.Clear();
            try
            {
                clearWeb();
            }
            catch { }

        }
        private void toolStripButton_URL_Click(object sender, EventArgs e)
        {
            if (panel_URL_count == 0)
            {
                panel_URL.Visible = true;
                panel_URL_count = 1;

                label_payID.Visible = false;
                label_Server.Visible = false;
                textBox_PayID.Visible = false;
                comboBox_server.Visible = false;
                panel_URL_DR_count = 0;
            }
            else if (panel_URL_count == 1)
            {
                panel_URL.Visible = false;
                panel_URL_count = 0;

                label_payID.Visible = false;
                label_Server.Visible = false;
                textBox_PayID.Visible = false;
                comboBox_server.Visible = false;
                panel_URL_DR_count = 0;
            }
        }
        private void linkLabel_DR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel_URL_DR_count == 0)
            {
                label_payID.Visible = true;
                label_Server.Visible = true;
                textBox_PayID.Visible = true;
                comboBox_server.Visible = true;

                panel_URL_DR_count = 1;
            }
            else if (panel_URL_DR_count == 1)
            {
                label_payID.Visible = false;
                label_Server.Visible = false;
                textBox_PayID.Visible = false;
                comboBox_server.Visible = false;

                panel_URL_DR_count = 0;
            }
        }
        private void textBox_PayID_TextChanged(object sender, EventArgs e)
        {
            textBox_URL.Clear();
            textBox_URL.Text = comboBox_server.Text + "\\" + textBox_PayID.Text;
        }
        private void comboBox_server_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_URL.Clear();
            textBox_URL.Text = comboBox_server.Text + "\\" + textBox_PayID.Text;
        }
        private void generateTree()
        {
            treeView_files.Nodes.Clear();

            foreach (object item in listBox_files.Items)
            {
                string determineFile = determineFileType(item.ToString());
                if (determineFile == "ACORD")
                {
                    try
                    {
                        //Start the parent tree node
                        string name = Path.GetFileName(item.ToString());
                        TreeNode parent = new TreeNode();
                        parent.Text = name;
                        treeView_files.Nodes.Add(parent);

                        //Load the XML and define namespace
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(item.ToString());
                        XmlNamespaceManager nsMgr = new XmlNamespaceManager(xmlDoc.NameTable);
                        nsMgr.AddNamespace("AC", "http://ACORD.org/Standards/Life/2");

                        //Find TXLife or TXLifeRequest
                        // EITHER OR: XmlNodeList itemNodes = xmlDoc.SelectNodes("//AC:TXLife", nsMgr);
                        XmlNodeList itemNodes = xmlDoc.SelectNodes("//AC:TXLifeRequest", nsMgr);
                        foreach (XmlNode itemNode in itemNodes)
                        {
                            try
                            {

                                //Find TransRefGUID
                                //XmlNode textValue1 = itemNode.SelectSingleNode("AC:TXLifeRequest", nsMgr);
                                XmlNode textValue2;
                                string header;

                                if (itemNode.SelectSingleNode("AC:TransRefGUID", nsMgr) != null)
                                {
                                    // EITHER OR: textValue2 = textValue1.SelectSingleNode("AC:TransRefGUID", nsMgr);
                                    textValue2 = itemNode.SelectSingleNode("AC:TransRefGUID", nsMgr);
                                    header = textValue2.InnerText;
                                }
                                else
                                {
                                    header = "TXLife";
                                }

                                TreeNode child_Lvl1 = new TreeNode();
                                child_Lvl1.Text = header;
                                parent.Nodes.Add(child_Lvl1);

                                //Find Forminstances
                                // EITHER OR: XmlNode textValue3 = textValue1.SelectSingleNode("AC:OLifE", nsMgr);
                                XmlNodeList itemNodes2 = itemNode.SelectNodes("AC:OLifE/AC:FormInstance", nsMgr);
                                foreach (XmlNode itemNode2 in itemNodes2)
                                {
                                    try
                                    {

                                        XmlNode textValue4;
                                        string innerText;

                                        if (itemNode2.SelectSingleNode("AC:FormName", nsMgr) != null)
                                        {
                                            textValue4 = itemNode2.SelectSingleNode("AC:FormName", nsMgr);
                                            innerText = textValue4.InnerText;
                                        }
                                        else if (itemNode2.SelectSingleNode("AC:ProviderFormNumber", nsMgr) != null)
                                        {
                                            textValue4 = itemNode2.SelectSingleNode("AC:ProviderFormNumber", nsMgr);
                                            innerText = textValue4.InnerText;
                                        }
                                        else
                                        {
                                            innerText = "FormInstance";
                                        }

                                        TreeNode child_Lvl2 = new TreeNode();
                                        child_Lvl2.Text = innerText;
                                        if (itemNode2.SelectSingleNode("AC:Attachment/AC:AttachmentData", nsMgr) != null)
                                        {
                                            child_Lvl2.ImageIndex = 1;
                                            child_Lvl2.SelectedImageIndex = 1;
                                        }
                                        child_Lvl1.Nodes.Add(child_Lvl2);
                                    }
                                    catch (Exception error)
                                    {
                                        MessageBox.Show("ACORD LOAD LEVEL 3:\r\n" + error.ToString());
                                    }
                                }
                            }
                            catch (Exception error)
                            {
                                MessageBox.Show("ACORD LOAD LEVEL 2:\r\n" + error.ToString());
                            }

                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("ACORD LOAD LEVEL 1:\r\n" + error.ToString());
                    }
                }
                else if (determineFile == "Base64")
                {
                    //Start the parent tree node
                    string name = Path.GetFileName(item.ToString());
                    TreeNode parent = new TreeNode();
                    parent.Text = name;
                    parent.ImageIndex = 1;
                    parent.SelectedImageIndex = 1;
                    treeView_files.Nodes.Add(parent);
                }
                else if (determineFile == "CossData")
                {
                    try
                    {

                        //Start the parent tree node
                        string name = Path.GetFileName(item.ToString());
                        TreeNode parent = new TreeNode();
                        parent.Text = name;
                        treeView_files.Nodes.Add(parent);

                        //Load the XML and define namespace
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(item.ToString());
                        XmlNamespaceManager nsMgr = new XmlNamespaceManager(xmlDoc.NameTable);

                        //Find submitted GUID
                        XmlNode subGUID;
                        TreeNode child1 = new TreeNode();
                        if (xmlDoc.SelectSingleNode("//Data[@Name='Submitted_Guid']") != null)
                        {
                            subGUID = xmlDoc.SelectSingleNode("//Data[@Name='Submitted_Guid']");
                            child1.Text = subGUID.InnerText;
                        }
                        else
                        {
                            child1.Text = "No GUID";
                            
                        }
                        parent.Nodes.Add(child1);
                        

                        //Find TXLife or TXLifeRequest
                        XmlNodeList itemNodes = xmlDoc.SelectNodes("//Data[starts-with(@Name,'PDF_IMAGE')]");
                        foreach (XmlNode itemNode in itemNodes)
                        {

                            TreeNode child2 = new TreeNode();
                            child2.Text = itemNode.Attributes["Name"].Value;
                            if (itemNode != null)
                            {
                                child2.ImageIndex = 1;
                                child2.SelectedImageIndex = 1;
                            }
                            child1.Nodes.Add(child2);

                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("COSS LOAD ERROR:\r\n" + error.ToString());
                    }
                }
                else
                {
                    //Start the parent tree node
                    string name = Path.GetFileName(item.ToString());
                    TreeNode parent = new TreeNode();
                    parent.Text = name;
                    treeView_files.Nodes.Add(parent);
                }
            }
        }
        //private string determineFileType(string path)
        //{
        //    string type = string.Empty;

        //    string[] linesArray = File.ReadAllLines(path);
        //    string linesAll = File.ReadAllText(path);

        //    if (linesArray[0].Contains("TXLife") == true)
        //    {
        //        type = "ACORD";
        //    }
        //    else if (1 < linesArray.Length && linesArray[1].Contains("TXLife") == true)
        //    {
        //        type = "ACORD";
        //    }
        //    else if (2 < linesArray.Length && linesArray[2].Contains("TXLife") == true)
        //    {
        //        type = "ACORD";
        //    }
        //    else if (3 < linesArray.Length && linesArray[3].Contains("DataTransmissionPackage") == true)
        //    {
        //        type = "iGOTransLog";
        //    }
        //    //else if (Regex.Match(linesAll, "<Contents>(.*)</Contents>", RegexOptions.Singleline).Success == true && Regex.Match(linesAll, "The new package is '(.*)</TXLife>", RegexOptions.Singleline).Success == true)
        //    //{
        //    //    type = "iGOTransLog";
        //    //}
        //    else if (Regex.IsMatch(linesAll, "^([A-Za-z0-9+/]{4})*([A-Za-z0-9+/]{4}|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{2}==)$") == true && linesAll.Length % 4 == 0)
        //    {
        //        type = "Base64";
        //    }
        //    //else if (Regex.Match(linesAll, "<Contents>(.*)</Contents>", RegexOptions.Singleline).Success == true)
        //    //{
        //    //    type = "CossData";
        //    //}
        //    else if (linesArray[0].Contains("Contents") && linesArray[0].Contains("EntityData"))
        //    {
        //        type = "CossData";
        //    }
        //    else if (2 < linesArray.Length && linesArray[0].Contains("Contents") && linesArray[2].Contains("EntityData"))
        //    {
        //        type = "CossData";
        //    }
        //    //else if (Regex.Match(linesAll, "'<TXLife>(.*)</TXLife>", RegexOptions.Singleline).Success == true)
        //    //{
        //    //    type = "Other ACORD";
        //    //}
        //    else
        //    {
        //        type = "Other";
        //    }

        //    MessageBox.Show(type);

        //    return type;
        //}
        private string determineFileType(string path)
        {
            string returnString = string.Empty;
            int[] type = new int[4] { 0, 0, 0, 0 };

            string allLines = File.ReadAllText(path);

            if (Regex.IsMatch(allLines, "^([A-Za-z0-9+/]{4})*([A-Za-z0-9+/]{4}|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{2}==)$") && allLines.Length % 4 == 0)
            {
                type[0] = 1;
            }
            if (Regex.IsMatch(allLines, "<Contents(.*)</Contents>", RegexOptions.Singleline))
            {
                type[1] = 1;
            }
            if (Regex.IsMatch(allLines, "The new package is '(.*)</TXLife>", RegexOptions.Singleline))
            {
                type[2] = 1;
            }
            if (Regex.IsMatch(allLines, "<TXLife(.*)</TXLife>", RegexOptions.Singleline))
            {
                type[3] = 1;
            }

            if (type[0] == 0 && type[1] == 0 && type[2] == 0 && type[3] == 1)
            {
                returnString = "ACORD";
            }
            else if (type[0] == 0 && type[1] == 1 && type[2] == 0 && type[3] == 0)
            {
                returnString = "CossData";
            }
            else if (type[0] == 0 && type[1] == 1 && type[3] == 1)
            {
                returnString = "iGOTransLog";
            }
            else if (type[0] == 1)
            {
                returnString = "Base64";
            }

            MessageBox.Show(returnString);

            return returnString;
        }
        #endregion

        //TREEVIEW FUNCTIONS
        #region
        private void treeView_files_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView_details.Items.Clear();
            trackBar1.Value = 5;
            toolStripLabel_zoom.Text = "100%";
            toolStripComboBox_type.Text = "File Type";

            //LEVEL 1 SELECTION
            if (treeView_files.SelectedNode.Level == 0)
            {
                string determineFile = determineFileType(listBox_files.Items[treeView_files.SelectedNode.Index].ToString());

                if (toolStripButton_preview.Checked == true && (determineFile == "ACORD" || determineFile == "CossData"))
                {
                    //POPULATE DETAILS
                    string name = Path.GetFileName(listBox_files.Items[treeView_files.SelectedNode.Index].ToString());
                    ListViewItem fileName = new ListViewItem(new[] { "File", name });
                    listView_details.Items.Add(fileName);

                    //POPULATE ACORD XML
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(listBox_files.Items[treeView_files.SelectedNode.Index].ToString());
                    try
                    {
                        /// Trasform Xml to Html
                        XslCompiledTransform objTransform = new XslCompiledTransform();
                        StringWriter objStream = new StringWriter();
                        // load xml default style sheet
                        objTransform.Load("xml-pretty-print.xsl");
                        objTransform.Transform(xmlDoc, null, objStream);
                        string html = objStream.ToString();
                        // load html page                       
                        webBrowser_previewer.DocumentText = html;
                    }
                    catch { }
                }
                else if (toolStripButton_preview.Checked == true && determineFile == "Base64")
                {
                    try
                    {
                        createFileFromBase(File.ReadAllText(listBox_files.Items[treeView_files.SelectedNode.Index].ToString()), "pdf");
                        string path = Directory.GetCurrentDirectory().ToString() + "\\temp\\" + fileNameGlobal;
                        webBrowser_previewer.Navigate(path);
                    }
                    catch { }
                }

            }

            //LEVEL 3 SELECTION
            else if (treeView_files.SelectedNode.Level == 2)
            {
                int[] pathArray = buildPathArray(treeView_files.SelectedNode);
                string determineFile = determineFileType(listBox_files.Items[pathArray[0]].ToString());

                //ACORD DETAILS
                if (determineFile == "ACORD")
                {
                    string[] formDetails = formInstanceDetails(pathArray);

                    //POPULATE DETAILS BOX FROM FORM SELECTION
                    string transRefGUID = getTransRefGUID(pathArray);

                    //POPULATE FILE NAME
                    string name = Path.GetFileName(listBox_files.Items[pathArray[0]].ToString());
                    ListViewItem fileName = new ListViewItem(new[] { "File", name });
                    listView_details.Items.Add(fileName);

                    //POPULATE TRANSREFGUID
                    ListViewItem detailTRGUID = new ListViewItem(new[] { "TransRefGUID", transRefGUID });
                    listView_details.Items.Add(detailTRGUID);

                    //POPULATE FORMINSTANCE DETAILS
                    foreach (string detail in formDetails)
                    {
                        if (detail != null)
                        {
                            ListViewItem newDetail = new ListViewItem(new[] { detail.Split(',')[0], detail.Split(',')[1] });
                            listView_details.Items.Add(newDetail);
                        }
                    }
                }
                //ACORD FILE PREVIEW
                if (toolStripButton_preview.Checked == true && treeView_files.SelectedNode.SelectedImageIndex == 1 && determineFile == "ACORD")
                {
                    
                    //GATHER INFO
                    string type = getACORDBaseType(pathArray);

                    //CREATE FILE FROM BASE64
                    try
                    {
                        createFileFromBase(getACORDBaseString(pathArray), type);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Base64 Decoding Error (ACORD): \r\n" + error);
                    }

                    //DISPLAY FILE
                    if (type == "TIF" || type == "tif" || type == "jpg" || type == "png" || type == "bmp")
                    {
                        string path = Directory.GetCurrentDirectory().ToString() + "\\temp\\" + fileNameGlobal;
                        webBrowser_previewer.Navigate("about:<html><body scroll=no><img src ='" + path + "'></img></body></html>");
                    }
                    else if (type == "PDF" || type == "pdf")
                    {
                        string path = Directory.GetCurrentDirectory().ToString() + "\\temp\\" + fileNameGlobal;
                        webBrowser_previewer.Navigate(path);
                    }

                }

                //COSS FILE PREVIEW
                if (toolStripButton_preview.Checked == true && treeView_files.SelectedNode.SelectedImageIndex == 1 && determineFile == "CossData")
                {
                    string type = treeView_files.SelectedNode.Text.Substring(0, 3).ToLower();

                    try
                    {
                        createFileFromBase(getCOSSBaseString(pathArray), type);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Base64 Decoding Error (COSS): \r\n" + error);
                    }

                    //DISPLAY FILE
                    if (type == "TIF" || type == "tif")
                    {
                        string path = Directory.GetCurrentDirectory().ToString() + "\\temp\\" + fileNameGlobal;
                        webBrowser_previewer.Navigate("about:<html><body scroll=no><img src ='" + path + "'></img></body></html>");
                    }
                    else if (type == "PDF" || type == "pdf")
                    {
                        string path = Directory.GetCurrentDirectory().ToString() + "\\temp\\" + fileNameGlobal;
                        webBrowser_previewer.Navigate(path);
                    }
                }
            }
        }
        private int[] buildPathArray(TreeNode treeNode)
        {
            treeNode = treeView_files.SelectedNode;
            int[] array = new int[3];
            int m = 2;

            while (treeNode != null)
            {
                array[m] = (treeNode.Index);
                treeNode = treeNode.Parent;
                m--;
            }
            return array;
        }
        private string getTransRefGUID(int[] pathArray)
        {
            string transRefGUID = string.Empty;
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(listBox_files.Items[pathArray[0]].ToString());

                XmlNamespaceManager nsMgr = new XmlNamespaceManager(xmlDoc.NameTable);
                nsMgr.AddNamespace("AC", "http://ACORD.org/Standards/Life/2");

                string newPath = "//AC:TXLifeRequest[" + (pathArray[1] + 1).ToString() + "]/AC:TransRefGUID";
                transRefGUID = xmlDoc.SelectSingleNode(newPath, nsMgr).InnerText;
            }
            catch { }

            return transRefGUID;
        }
        private string[] formInstanceDetails(int[] pathArray)
        {
            string[] array = new string[4];

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(listBox_files.Items[pathArray[0]].ToString());

                XmlNamespaceManager nsMgr = new XmlNamespaceManager(xmlDoc.NameTable);
                nsMgr.AddNamespace("AC", "http://ACORD.org/Standards/Life/2");

                string newPath = "//AC:TXLifeRequest[" + (pathArray[1] + 1).ToString() + "]/AC:OLifE/AC:FormInstance[" + (pathArray[2] + 1).ToString() + "]";
                XmlNode formInstanceNode = xmlDoc.SelectSingleNode(newPath, nsMgr);

                if (formInstanceNode.SelectSingleNode("AC:FormName", nsMgr) != null)
                {
                    array[0] = "FormName," + formInstanceNode.SelectSingleNode("AC:FormName", nsMgr).InnerText;
                }
                if (formInstanceNode.SelectSingleNode("AC:ProviderFormNumber", nsMgr) != null)
                {
                    array[1] = "ProviderFormNumber," + formInstanceNode.SelectSingleNode("AC:ProviderFormNumber", nsMgr).InnerText;
                }
                if (formInstanceNode.SelectSingleNode("AC:Attachment/AC:Description", nsMgr) != null)
                {
                    array[2] = "Description," + formInstanceNode.SelectSingleNode("AC:Attachment/AC:Description", nsMgr).InnerText;
                }
                if (formInstanceNode.SelectSingleNode("AC:Attachment/AC:ImageType", nsMgr) != null)
                {
                    array[3] = "ImageType," + formInstanceNode.SelectSingleNode("AC:Attachment/AC:ImageType", nsMgr).InnerText;
                }
            }
            catch { }

            return array;
        }
        private void toolStripButton_expand_Click(object sender, EventArgs e)
        {
            treeView_files.ExpandAll();
        }
        private void toolStripButton_collapse_Click(object sender, EventArgs e)
        {
            treeView_files.CollapseAll();
        }
        #endregion

        //OTHER MENU BUTTONS
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int zoom = 100;

            switch (trackBar1.Value)
            {
                case 0:
                    zoom = 20;
                    break;
                case 1:
                    zoom = 25;
                    break;
                case 2:
                    zoom = 33;
                    break;
                case 3:
                    zoom = 50;
                    break;
                case 4:
                    zoom = 75;
                    break;
                case 5:
                    zoom = 100;
                    break;
                case 6:
                    zoom = 125;
                    break;
                case 7:
                    zoom = 150;
                    break;
                case 8:
                    zoom = 200;
                    break;
                case 9:
                    zoom = 300;
                    break;
                case 10:
                    zoom = 500;
                    break;
            }
            try
            {
                toolStripLabel_zoom.Text = zoom.ToString("D3") + "%";
                webBrowser_previewer.Document.Body.Style = "zoom:" + zoom.ToString() + "%;";
            }
            catch { }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void toolStripButton_preview_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripButton_preview.Checked == true)
            {
                try
                {
                    treeView_files_AfterSelect(null, null);
                }
                catch { }
            }
            else if (toolStripButton_preview.Checked == false)
            {
                try
                {
                    clearWeb();
                }
                catch { }
            }
        }
        private void toolStripButton_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = saveFileDialog1.FileName;
            File.Copy("temp\\" + fileNameGlobal, filePath);
        }
        private void runningDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory());
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Base64 Viewer v1.1\r\n" +
                "\r\n" + "This tool is intended for use by iPipeline employees only.\r\n"
                + "©Copyright Robert Clark, 2015");
        }
        private void toolStripComboBox_type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                toolStripComboBox_type_SelectedIndexChanged(null, null);
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_add_Click(null, null);
        }



    }
}
