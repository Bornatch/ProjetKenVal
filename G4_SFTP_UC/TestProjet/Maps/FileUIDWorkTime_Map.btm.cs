namespace TestProjet.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TestProjet.Schema.FileUIDInputOutput_Schema", typeof(global::TestProjet.Schema.FileUIDInputOutput_Schema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TestProjet.Schema.FileUIDMinutes_Schema", typeof(global::TestProjet.Schema.FileUIDMinutes_Schema))]
    public sealed class FileUIDWorkTime_Map : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://TestProjet.Schema.FileUIDMinutes_Schema"" xmlns:s0=""http://TestProjet.Schema.FileUIDInputOutput"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Root>
      <UID>
        <xsl:value-of select=""UID/text()"" />
      </UID>
      <xsl:variable name=""var:v1"" select=""userCSharp:WorkTimeCalculator(string(InputDateTime/text()) , string(OutputDataTime/text()))"" />
      <MinutesInt>
        <xsl:value-of select=""$var:v1"" />
      </MinutesInt>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string WorkTimeCalculator(string inTime, string outTime)
{
DateTime parsedIn = DateTime.Parse(inTime);
DateTime parsedOut = DateTime.Parse(outTime);

TimeSpan workTime = parsedOut - parsedIn ;


	return workTime.TotalMinutes.ToString() ;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"TestProjet.Schema.FileUIDInputOutput_Schema";
        
        private const global::TestProjet.Schema.FileUIDInputOutput_Schema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"TestProjet.Schema.FileUIDMinutes_Schema";
        
        private const global::TestProjet.Schema.FileUIDMinutes_Schema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"TestProjet.Schema.FileUIDInputOutput_Schema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"TestProjet.Schema.FileUIDMinutes_Schema";
                return _TrgSchemas;
            }
        }
    }
}
