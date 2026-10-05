using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public class XmlCDataSection : XmlCharacterData
	{
		// Token: 0x06000495 RID: 1173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x4FA84A0", Offset = "0x4FA70A0", VA = "0x184FA84A0")]
		protected internal XmlCDataSection(string data, XmlDocument doc)
		{
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F6")]
		public override string Name
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x4FA84E0", Offset = "0x4FA70E0", VA = "0x184FA84E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F7")]
		public override string LocalName
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x4FA84E0", Offset = "0x4FA70E0", VA = "0x184FA84E0", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x170000F8")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "9")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F9")]
		public override XmlNode ParentNode
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x4FA8530", Offset = "0x4FA7130", VA = "0x184FA8530", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x4FA83F0", Offset = "0x4FA6FF0", VA = "0x184FA83F0", Slot = "27")]
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x170000FA")]
		internal override bool IsText
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "45")]
			get
			{
				return default(bool);
			}
		}
	}
}
