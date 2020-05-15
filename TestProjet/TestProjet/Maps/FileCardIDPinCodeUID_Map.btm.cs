namespace TestProjet.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TestProjet.Schema.FileUIDCardID_Schema", typeof(global::TestProjet.Schema.FileUIDCardID_Schema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TestProjet.FilePinCodeUID_Schema", typeof(global::TestProjet.FilePinCodeUID_Schema))]
    public sealed class FileCardIDPinCodeUID : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://TestProjet.Schema.FileUIDCardID_Schema"" xmlns:ns0=""http://TestProjet.FilePinCodeUID_Schema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Root>
      <xsl:variable name=""var:v1"" select=""userCSharp:MyConcat(&quot;pincode&quot;)"" />
      <PinCode>
        <xsl:value-of select=""$var:v1"" />
      </PinCode>
      <UID>
        <xsl:value-of select=""UID/text()"" />
      </UID>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string MyConcat(string param)
{
Random rand = new Random();
param = rand.Next(1000,99999).ToString();

	return param ;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"TestProjet.Schema.FileUIDCardID_Schema";
        
        private const global::TestProjet.Schema.FileUIDCardID_Schema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"TestProjet.FilePinCodeUID_Schema";
        
        private const global::TestProjet.FilePinCodeUID_Schema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"TestProjet.Schema.FileUIDCardID_Schema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"TestProjet.FilePinCodeUID_Schema";
                return _TrgSchemas;
            }
        }
    }
}
