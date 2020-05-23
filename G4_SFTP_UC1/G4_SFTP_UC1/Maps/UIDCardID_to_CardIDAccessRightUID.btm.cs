namespace G4_SFTP_UC1.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G4_SFTP_UC1.Schemas.UIDCardID_FFschema", typeof(global::G4_SFTP_UC1.Schemas.UIDCardID_FFschema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G4_SFTP_UC1.Schemas.CardIDAccessRightUID_FF_schema", typeof(global::G4_SFTP_UC1.Schemas.CardIDAccessRightUID_FF_schema))]
    public sealed class UIDCardID_to_CardIDAccessRightUID : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://G4_SFTP_UC1.Schemas.CardIDAccessRightUID_FF_schema"" xmlns:s0=""http://G4_SFTP_UC1.Schemas.UIDCardID_FFschema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Root>
      <AccessRight>
        <CardID>
          <xsl:value-of select=""cardData/CardID/text()"" />
        </CardID>
        <xsl:variable name=""var:v1"" select=""userCSharp:MyFantasticDoor(&quot;group&quot;)"" />
        <AccessRight>
          <xsl:value-of select=""$var:v1"" />
        </AccessRight>
        <UID>
          <xsl:value-of select=""cardData/UID/text()"" />
        </UID>
      </AccessRight>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string MyFantasticDoor(string param1)
{
Random rand = new Random();
String groupNo = rand.Next(1,4).ToString();

	return param1+groupNo;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"G4_SFTP_UC1.Schemas.UIDCardID_FFschema";
        
        private const global::G4_SFTP_UC1.Schemas.UIDCardID_FFschema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"G4_SFTP_UC1.Schemas.CardIDAccessRightUID_FF_schema";
        
        private const global::G4_SFTP_UC1.Schemas.CardIDAccessRightUID_FF_schema _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"G4_SFTP_UC1.Schemas.CardIDAccessRightUID_FF_schema";
                return _TrgSchemas;
            }
        }
    }
}
