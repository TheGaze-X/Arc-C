using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public class XmlComment : XmlCharacterData
	{
		// Token: 0x060004AD RID: 1197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x4FA84A0", Offset = "0x4FA70A0", VA = "0x184FA84A0")]
		protected internal XmlComment(string comment, XmlDocument doc)
		{
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000101")]
		public override string Name
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x4FA8D40", Offset = "0x4FA7940", VA = "0x184FA8D40", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000102")]
		public override string LocalName
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x4FA8D40", Offset = "0x4FA7940", VA = "0x184FA8D40", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x17000103")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "9")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x4FA8C90", Offset = "0x4FA7890", VA = "0x184FA8C90", Slot = "27")]
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}
	}
}
