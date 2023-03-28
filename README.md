# Ericsson-XML-Dump-Parser
Via the Parser it's possible to read Ericsson Mobile network Dump file exported in XML format and make it possible to extract needed data and work with it.

**_Important: Currently only LTE part is ready!!!_**

A sample XML file is included in the repository for test purposes.

# Sample Usage
```C#
// Open XML file from local PC
var openFileDialog = new OpenFileDialog();
var filename = openFileDialog.GetFileName();

// If XML file is selected then Serialize it
if (filename != "")
{
    // Open file strem to read the selected file
    using (var fileStream = new FileStream(filename, FileMode.Open))
    {
        // Deserialize XML file
        var xmlDocument = Serialization.DeserializeXML(fileStream);

        // Example of getting data
        var lte = xmlDocument.configData.SubNetwork.SubNetworks.FirstOrDefault(n => n.Id == "LTE");
    }
}
```
