XML Document Viewer and Base64 Decoder.
=============
Base64 Viewer is C# desktop application used to display XML files containing base64 encoded documents. This application was developed out of need from a work flow were XML data streams were passing base64 encoded PDFs, and needed to be occasionally decoded and viewed.


Detail
------
The XML files being passed through the data transmission server were files compliant with the ACORD data schemas. As such, these files contained specific structure and typically contained base64 encoded PDFs or TIFs. It was necessary on occasion to intercept these XML transmissions and inspect the contents as part of error troubleshooting. The application requires that the input XML conform to the ACORD schema standard.

The application will accept multiple XML input files. Each XML file contains a unique, TransRefID, or GUID, which is used to list and identify the individual file, in the list of files. As the list of input XML files is populated, key data elements from within the XML content are retrieved and displayed to aid in identifying the desired file/structure location. Additionally, a green check mark next to a file listed in the file list indicates a successful identification of a base64 encoded string. Selecting the XML file from the list of files will automatically populate a sub list of available base64 encoded files. Selecting any of the base64 encoded sub files will result in the file being decoded, and displayed in the main window. Individual base64 encoded documents can be exported or otherwise used. In addition to accepting local file input, the application can accept a URL and attempt to download the document content.


Running the Program
-------------------
This project was created in VisualStudio and this repository contains the VS folder and file structure. Therefore you will either need to have VisualStudio to open the solution file, or have alternative means of compiling the .cs files.


Contact
-------
For more information visit [robertclark.io](http://robertclark.io)