using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public abstract class XmlLinkedNode : XmlNode
	{
		// Token: 0x06000572 RID: 1394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x4FCCAD0", Offset = "0x4FCB6D0", VA = "0x184FCCAD0")]
		internal XmlLinkedNode(XmlDocument doc)
		{
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015B")]
		public override XmlNode PreviousSibling
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x4FCCC20", Offset = "0x4FCB820", VA = "0x184FCCC20", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015C")]
		public override XmlNode NextSibling
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x4FCCB80", Offset = "0x4FCB780", VA = "0x184FCCB80", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x18")]
		internal XmlLinkedNode next;
	}
}
