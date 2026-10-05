using System;
using System.Xml;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000425 RID: 1061
	[Token(Token = "0x2000425")]
	public class DictionarySectionHandler : IConfigurationSectionHandler
	{
		// Token: 0x06001C59 RID: 7257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C59")]
		[Address(RVA = "0x50BBF70", Offset = "0x50BAB70", VA = "0x1850BBF70")]
		public DictionarySectionHandler()
		{
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000688")]
		protected virtual string KeyAttributeName
		{
			[Token(Token = "0x6001C5A")]
			[Address(RVA = "0x50BBFA0", Offset = "0x50BABA0", VA = "0x1850BBFA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000689")]
		protected virtual string ValueAttributeName
		{
			[Token(Token = "0x6001C5B")]
			[Address(RVA = "0x50BBFD0", Offset = "0x50BABD0", VA = "0x1850BBFD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C5C")]
		[Address(RVA = "0x50BBF40", Offset = "0x50BAB40", VA = "0x1850BBF40", Slot = "7")]
		public virtual object Create(object parent, object context, XmlNode section)
		{
			return null;
		}
	}
}
