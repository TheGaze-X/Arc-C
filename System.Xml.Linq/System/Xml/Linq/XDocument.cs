using System;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public class XDocument : XContainer
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public XDocument()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4F8A840", Offset = "0x4F89440", VA = "0x184F8A840")]
		public XDocument(XDocument other)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000E")]
		public XDeclaration Declaration
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x1700000F")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x54AFD0", Offset = "0x549BD0", VA = "0x18054AFD0", Slot = "4")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public XElement Root
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x4F8A900", Offset = "0x4F89500", VA = "0x184F8A900")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4F8A6E0", Offset = "0x4F892E0", VA = "0x184F8A6E0", Slot = "5")]
		public override void WriteTo(XmlWriter writer)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4F8A0B0", Offset = "0x4F88CB0", VA = "0x184F8A0B0", Slot = "8")]
		internal override void AddAttribute(XAttribute a)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4F8A050", Offset = "0x4F88C50", VA = "0x184F8A050", Slot = "9")]
		internal override void AddAttributeSkipNotify(XAttribute a)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4F8A110", Offset = "0x4F88D10", VA = "0x184F8A110", Slot = "7")]
		internal override XNode CloneNode()
		{
			return null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		private T GetFirstNode<T>() where T : XNode
		{
			return null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x4F8A210", Offset = "0x4F88E10", VA = "0x184F8A210")]
		internal static bool IsWhitespace(string s)
		{
			return default(bool);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x4F8A3F0", Offset = "0x4F88FF0", VA = "0x184F8A3F0", Slot = "10")]
		internal override void ValidateNode(XNode node, XNode previous)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x4F8A290", Offset = "0x4F88E90", VA = "0x184F8A290")]
		private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x4F8A620", Offset = "0x4F89220", VA = "0x184F8A620", Slot = "11")]
		internal override void ValidateString(string s)
		{
		}

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x30")]
		private XDeclaration _declaration;
	}
}
