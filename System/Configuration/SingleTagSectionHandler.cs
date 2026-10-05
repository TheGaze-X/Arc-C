using System;
using System.Xml;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	public class SingleTagSectionHandler : IConfigurationSectionHandler
	{
		// Token: 0x06001CA5 RID: 7333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x50C05F0", Offset = "0x50BF1F0", VA = "0x1850C05F0")]
		public SingleTagSectionHandler()
		{
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x50C05C0", Offset = "0x50BF1C0", VA = "0x1850C05C0", Slot = "5")]
		public virtual object Create(object parent, object context, XmlNode section)
		{
			return null;
		}
	}
}
