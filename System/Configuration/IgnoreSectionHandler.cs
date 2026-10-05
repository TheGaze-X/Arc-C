using System;
using System.Xml;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000428 RID: 1064
	[Token(Token = "0x2000428")]
	public class IgnoreSectionHandler : IConfigurationSectionHandler
	{
		// Token: 0x06001C63 RID: 7267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C63")]
		[Address(RVA = "0x50BC9D0", Offset = "0x50BB5D0", VA = "0x1850BC9D0")]
		public IgnoreSectionHandler()
		{
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C64")]
		[Address(RVA = "0x50BC9A0", Offset = "0x50BB5A0", VA = "0x1850BC9A0", Slot = "5")]
		public virtual object Create(object parent, object configContext, XmlNode section)
		{
			return null;
		}
	}
}
