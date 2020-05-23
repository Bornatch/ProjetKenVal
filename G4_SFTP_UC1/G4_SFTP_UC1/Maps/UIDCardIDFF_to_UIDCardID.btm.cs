namespace G4_SFTP_UC1.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G4_SFTP_UC1.Schemas.UIDCardID_FFschema", typeof(global::G4_SFTP_UC1.Schemas.UIDCardID_FFschema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G4_SFTP_UC1.Schemas.UIDCardID_Schema", typeof(global::G4_SFTP_UC1.Schemas.UIDCardID_Schema))]
    public sealed class UIDCardIDFF_to_UIDCardID : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://G4_SFTP_UC1.Schemas.UIDCardID_FFschema"" xmlns:ns0=""http://G4_SFTP_UC1.Schemas.UIDCardID_Schema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Root>
      <UID>
        <xsl:value-of select=""cardData/UID/text()"" />
      </UID>
      <CardID>
        <xsl:value-of select=""cardData/CardID/text()"" />
      </CardID>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"G4_SFTP_UC1.Schemas.UIDCardID_FFschema";
        
        private const global::G4_SFTP_UC1.Schemas.UIDCardID_FFschema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"G4_SFTP_UC1.Schemas.UIDCardID_Schema";
        
        private const global::G4_SFTP_UC1.Schemas.UIDCardID_Schema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"G4_SFTP_UC1.Schemas.UIDCardID_FFschema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"G4_SFTP_UC1.Schemas.UIDCardID_Schema";
                return _TrgSchemas;
            }
        }
    }
}
