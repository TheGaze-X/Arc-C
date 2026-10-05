using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	internal class ContentValidator
	{
		// Token: 0x0600084F RID: 2127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x4FD89A0", Offset = "0x4FD75A0", VA = "0x184FD89A0")]
		public ContentValidator(XmlSchemaContentType contentType)
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x4FD89D0", Offset = "0x4FD75D0", VA = "0x184FD89D0")]
		protected ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
		{
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x17000206")]
		public XmlSchemaContentType ContentType
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return XmlSchemaContentType.TextOnly;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x17000207")]
		public bool IsOpen
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x4FD8A20", Offset = "0x4FD7620", VA = "0x184FD8A20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x10")]
		private XmlSchemaContentType contentType;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x14")]
		private bool isOpen;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x15")]
		private bool isEmptiable;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ContentValidator Empty;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ContentValidator TextOnly;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ContentValidator Mixed;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ContentValidator Any;
	}
}
