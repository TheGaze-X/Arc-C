using System;
using System.Configuration;
using System.Xml;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000413 RID: 1043
	[Token(Token = "0x2000413")]
	[Obsolete("This class has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public class DiagnosticsConfigurationHandler : IConfigurationSectionHandler
	{
		// Token: 0x06001BF8 RID: 7160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF8")]
		[Address(RVA = "0x50BBF10", Offset = "0x50BAB10", VA = "0x1850BBF10")]
		public DiagnosticsConfigurationHandler()
		{
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF9")]
		[Address(RVA = "0x50BBEE0", Offset = "0x50BAAE0", VA = "0x1850BBEE0", Slot = "5")]
		public virtual object Create(object parent, object configContext, XmlNode section)
		{
			return null;
		}
	}
}
