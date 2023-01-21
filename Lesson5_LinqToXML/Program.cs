using System;
using System.Linq;
using System.Xml.Linq;



// CreateXmlDocument();
ReadXmlDocument();

Console.Write("Press Enter to exit");
Console.ReadLine();



void CreateXmlDocument()
{
    XDocument xmldoc = new XDocument(
        new XElement("computers",
            new XElement("computer", "This is not expensive and reliable computer",
                new XAttribute("Price", "800"),
                new XAttribute("Warranty", "2 years"),
                new XElement("CPU",
                    new XAttribute("Name", "Intel Core i7-6700K"),
                    new XAttribute("GHz", 2.5)
                    ),
                new XElement("HDD",
                    new XAttribute("Name", "Samsung 850 PRO"),
                    new XAttribute("Size", 1.0)
                )
            ),
            new XElement("computer",
                new XAttribute("Price", "900"),
                new XAttribute("Warranty", "2 years"),
                new XElement("CPU",
                    new XAttribute("Name", "AMD A10-5800K"),
                    new XAttribute("GHz", 2.5)
                    ),
                new XElement("HDD",
                    new XAttribute("Name", "Transcend ESD400"),
                    new XAttribute("Size", 1.0)
                )
            )
        )
    );


    // Console.WriteLine(xmldoc);
    string xmlFilePath = @"example.xml";
    xmldoc.Save(xmlFilePath);
}


void ReadXmlDocument()
{
    string xmlFilePath = @"example.xml";
    XDocument xmldoc = XDocument.Load(xmlFilePath);



    var result = from c in xmldoc.Descendants(XName.Get("computer"))
                 where Convert.ToInt32(c.Attribute(XName.Get("Price")).Value) < 850
                 select c;


    //var result = xmldoc.Descendants(XName.Get("computer"))
    //       .Where(c => Convert.ToInt32(c.Attribute(XName.Get("Price")).Value) < 850);



    foreach (var item in result)
        Console.WriteLine(item);
}