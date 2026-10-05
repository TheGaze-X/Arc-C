using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public class XmlNotation : XmlNode
	{
		// Token: 0x060005FF RID: 1535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x4FD6BA0", Offset = "0x4FD57A0", VA = "0x184FD6BA0")]
		internal XmlNotation(string name, string publicId, string systemId, XmlDocument doc)
		{
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018E")]
		public override string Name
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018F")]
		public override string LocalName
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x17000190")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x21127B0", Offset = "0x21113B0", VA = "0x1821127B0", Slot = "9")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x4FD6B30", Offset = "0x4FD5730", VA = "0x184FD6B30", Slot = "27")]
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x17000191")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000192 RID: 402
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000192")]
		public override string InnerXml
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x4FD6CE0", Offset = "0x4FD58E0", VA = "0x184FD6CE0", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x18")]
		private string publicId;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x20")]
		private string systemId;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x28")]
		private string name;
	}
}
