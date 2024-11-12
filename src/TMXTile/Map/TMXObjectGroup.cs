using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TMXTile
{
    [XmlRoot(ElementName = "objectgroup")]
    public class TMXObjectgroup
    {
        [XmlAttribute(AttributeName = "color")]
        public string ColorString
        {
            get => Color?.ToString();
            set => Color = TMXColor.FromString(value);
        }

        [XmlIgnore()]
        public TMXColor Color { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "object")]
        public List<TMXObject> Objects { get; set; }

        [XmlIgnore()]
        public bool Visible { get; set; }

        [XmlAttribute(AttributeName = "visible")]
        internal int VisibleAsInt {
            get => (Visible ? 1 : 0);
            set => Visible = value == 1;
        }

        [XmlIgnore()]
        public bool Locked { get; set; }

        [XmlAttribute(AttributeName = "locked")]
        internal int LockedAsInt {
            get => (Locked ? 1 : 0);
            set => Locked = value == 1;
        }        
    }
}
