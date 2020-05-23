namespace G4_SFTP_UC1.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G4_SFTP_UC1.Schemas.UIDInputOutput_FF_schema", typeof(global::G4_SFTP_UC1.Schemas.UIDInputOutput_FF_schema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G4_SFTP_UC1.Schemas.UIDInputDoorOutputDoorWorktime_FF_schema", typeof(global::G4_SFTP_UC1.Schemas.UIDInputDoorOutputDoorWorktime_FF_schema))]
    public sealed class UIDInputOutputFF_to_UIDInputDoorOutputDoorWorktime : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://G4_SFTP_UC1.Schemas.UIDInputDoorOutputDoorWorktime_FF_schema"" xmlns:s0=""http://G4_SFTP_UC1.Schemas.UIDInputOutput_FF_schema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Root>
      <WorktimeInfo>
        <UID>
          <xsl:value-of select=""InOutData/UID/text()"" />
        </UID>
        <InputDoor>
          <xsl:value-of select=""InOutData/inputDoor/text()"" />
        </InputDoor>
        <OutputDoor>
          <xsl:value-of select=""InOutData/OutputDoor/text()"" />
        </OutputDoor>
        <xsl:variable name=""var:v1"" select=""userCSharp:WorkTimeCalculator(string(InOutData/InputDateTime/text()) , string(InOutData/OutputDateTime/text()))"" />
        <WorkTime>
          <xsl:value-of select=""$var:v1"" />
        </WorkTime>
      </WorktimeInfo>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public int WorkTimeCalculator(string inTime, string outTime)
{
	DateTime parsedIn = DateTime.Parse(inTime);
DateTime parsedOut = DateTime.Parse(outTime);

TimeSpan workTime = parsedOut - parsedIn ;

return (int) workTime.TotalMinutes ;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"G4_SFTP_UC1.Schemas.UIDInputOutput_FF_schema";
        
        private const global::G4_SFTP_UC1.Schemas.UIDInputOutput_FF_schema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"G4_SFTP_UC1.Schemas.UIDInputDoorOutputDoorWorktime_FF_schema";
        
        private const global::G4_SFTP_UC1.Schemas.UIDInputDoorOutputDoorWorktime_FF_schema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"G4_SFTP_UC1.Schemas.UIDInputOutput_FF_schema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"G4_SFTP_UC1.Schemas.UIDInputDoorOutputDoorWorktime_FF_schema";
                return _TrgSchemas;
            }
        }
    }
}
