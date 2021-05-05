using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkConnetivityTest.Data
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class V
    {
        public string l { get; set; }
        public string id { get; set; }
        public string s { get; set; }
        public List<object> i { get; set; }
    }

    public class D
    {
        public string l { get; set; }
        public string id { get; set; }
        public string s { get; set; }
        public int y { get; set; }
        public string q { get; set; }
        public int vt { get; set; }
        public List<object> i { get; set; }
        public List<V> v { get; set; }
        public string yr { get; set; }
    }

    public class OpenDataITunes
    {
        public int v { get; set; }
        public string q { get; set; }
        public List<D> d { get; set; }
    }
}
