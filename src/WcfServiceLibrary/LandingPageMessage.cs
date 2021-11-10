using System.Configuration;
using System.ServiceModel.Channels;
using System.Xml;
using HtmlAgilityPack;

namespace WcfServiceLibrary
{
    public class LandingPageMessage : Message
    {
        private readonly MessageHeaders _headers;
        private readonly MessageProperties _properties;

        public LandingPageMessage()
        {
            this._headers = new MessageHeaders(MessageVersion.None);
            this._properties = new MessageProperties();
        }

        public override MessageHeaders Headers
        {
            get { return this._headers; }
        }

        public override MessageProperties Properties
        {
            get { return this._properties; }
        }

        public override MessageVersion Version
        {
            get { return this._headers.MessageVersion; }
        }

        protected override void OnWriteBodyContents(XmlDictionaryWriter writer)
        {
            var document = new HtmlDocument();
            document.Load(ConfigurationManager.AppSettings["customHelpPage"]);

            var bodyNode = document.DocumentNode.SelectSingleNode("//html");
            writer.WriteStartElement("HTML");
            writer.WriteRaw(bodyNode.InnerHtml);
            writer.WriteEndElement();
        }
    }
}
