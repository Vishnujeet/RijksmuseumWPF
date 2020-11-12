using System;
using System.Collections.Generic;

namespace RM.Common
{
   

    public class Links
    {
        public string self { get; set; }
        public string web { get; set; }
    }

    public class WebImage
    {
        public string guid { get; set; }
        public int offsetPercentageX { get; set; }
        public int offsetPercentageY { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class HeaderImage
    {
        public string guid { get; set; }
        public int offsetPercentageX { get; set; }
        public int offsetPercentageY { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class ArtObject
    {
        public Links links { get; set; }
        public string id { get; set; }
        public string priref { get; set; }
        public string objectNumber { get; set; }
        public string language { get; set; }
        public string title { get; set; }
        public object copyrightHolder { get; set; }
        public WebImage webImage { get; set; }
   
        public List<string> titles { get; set; }
        public string description { get; set; }
        public object labelText { get; set; }
        public List<string> objectTypes { get; set; }
        public List<string> objectCollection { get; set; }
        public List<object> makers { get; set; }
        public object plaqueDescriptionDutch { get; set; }
        public object plaqueDescriptionEnglish { get; set; }
        public string principalMaker { get; set; }
        public object artistRole { get; set; }
        public List<object> associations { get; set; }
        public List<object> exhibitions { get; set; }
        public List<string> materials { get; set; }
        public List<object> techniques { get; set; }
        public List<string> productionPlaces { get; set; }
        
        public bool hasImage { get; set; }
        public List<string> historicalPersons { get; set; }
        public List<object> inscriptions { get; set; }
        public List<object> documentation { get; set; }
        public List<object> catRefRPK { get; set; }
        public string principalOrFirstMaker { get; set; }
        public List<object> physicalProperties { get; set; }
        public string physicalMedium { get; set; }
        public string longTitle { get; set; }
        public string subTitle { get; set; }
        public string scLabelLine { get; set; }
        public bool showImage { get; set; }
        public string location { get; set; }
    }


   
    public class Root
    {
        public IEnumerable<ArtObject> artObjects { get; set; }
    }

    public class SingleArt
    {
        public int elapsedMilliseconds { get; set; }
        public ArtObject artObject { get; set; }
    }

}
