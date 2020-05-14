namespace TestProjet.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TestProjet.Schema.FileUIDInputOutput", typeof(global::TestProjet.Schema.FileUIDInputOutput))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TestProjet.Schema.FileUIDInputOutput", typeof(global::TestProjet.Schema.FileUIDInputOutput))]
    public sealed class FileCardIDAccessRightUID_Map : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://TestProjet.Schema.FileUIDInputOutput"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Root"" />
  </xsl:template>
  <xsl:template match=""/ns0:Root"">
    <ns0:Root>
      <UID>
        <xsl:value-of select=""UID/text()"" />
      </UID>
      <InputDoor>
        <xsl:value-of select=""InputDoor/text()"" />
      </InputDoor>
      <InputDateTime>
        <xsl:value-of select=""InputDateTime/text()"" />
      </InputDateTime>
      <OutputDoor>
        <xsl:value-of select=""OutputDoor/text()"" />
      </OutputDoor>
      <OutputDataTime>
        <xsl:value-of select=""OutputDataTime/text()"" />
      </OutputDataTime>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"TestProjet.Schema.FileUIDInputOutput";
        
        private const global::TestProjet.Schema.FileUIDInputOutput _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"TestProjet.Schema.FileUIDInputOutput";
        
        private const global::TestProjet.Schema.FileUIDInputOutput _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"TestProjet.Schema.FileUIDInputOutput";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"TestProjet.Schema.FileUIDInputOutput";
                return _TrgSchemas;
            }
        }
    }
}
