using System;
using System.Xml;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x0200042E RID: 1070
	[Token(Token = "0x200042E")]
	public class NameValueSectionHandler : IConfigurationSectionHandler
	{
		// Token: 0x06001C7C RID: 7292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x50BD060", Offset = "0x50BBC60", VA = "0x1850BD060")]
		public NameValueSectionHandler()
		{
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000691")]
		protected virtual string KeyAttributeName
		{
			[Token(Token = "0x6001C7D")]
			[Address(RVA = "0x50BD090", Offset = "0x50BBC90", VA = "0x1850BD090", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000692")]
		protected virtual string ValueAttributeName
		{
			[Token(Token = "0x6001C7E")]
			[Address(RVA = "0x50BD0C0", Offset = "0x50BBCC0", VA = "0x1850BD0C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C7F")]
		[Address(RVA = "0x50BD030", Offset = "0x50BBC30", VA = "0x1850BD030", Slot = "4")]
		public object Create(object parent, object context, XmlNode section)
		{
			return null;
		}
	}
}
