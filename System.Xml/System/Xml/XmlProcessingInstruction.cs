using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public class XmlProcessingInstruction : XmlLinkedNode
	{
		// Token: 0x06000606 RID: 1542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x4FD6DE0", Offset = "0x4FD59E0", VA = "0x184FD6DE0")]
		protected internal XmlProcessingInstruction(string target, string data, XmlDocument doc)
		{
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000193")]
		public override string Name
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x4FD6EC0", Offset = "0x4FD5AC0", VA = "0x184FD6EC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000194")]
		public override string LocalName
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x4FA9390", Offset = "0x4FA7F90", VA = "0x184FA9390", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000195")]
		public override string Value
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x4FD7040", Offset = "0x4FD5C40", VA = "0x184FD7040", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000196 RID: 406
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000196")]
		public string Data
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x4FD6F10", Offset = "0x4FD5B10", VA = "0x184FD6F10")]
			set
			{
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000197")]
		public override string InnerText
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "33")]
			get
			{
				return null;
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x4FD7040", Offset = "0x4FD5C40", VA = "0x184FD7040", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x17000198")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x54AC30", Offset = "0x549830", VA = "0x18054AC30", Slot = "9")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x4FD6D50", Offset = "0x4FD5950", VA = "0x184FD6D50", Slot = "27")]
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x20")]
		private string target;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x28")]
		private string data;
	}
}
