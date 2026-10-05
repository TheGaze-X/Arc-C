using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	internal class XmlUnspecifiedAttribute : XmlAttribute
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x4FD77F0", Offset = "0x4FD63F0", VA = "0x184FD77F0")]
		protected internal XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc)
		{
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x170001A5")]
		public override bool Specified
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0", Slot = "46")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x4FD75E0", Offset = "0x4FD61E0", VA = "0x184FD75E0", Slot = "27")]
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		// Token: 0x170001A6 RID: 422
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A6")]
		public override string InnerText
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x4FD7800", Offset = "0x4FD6400", VA = "0x184FD7800", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x4FD77D0", Offset = "0x4FD63D0", VA = "0x184FD77D0", Slot = "21")]
		public override XmlNode RemoveChild(XmlNode oldChild)
		{
			return null;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x4FD75C0", Offset = "0x4FD61C0", VA = "0x184FD75C0", Slot = "22")]
		public override XmlNode AppendChild(XmlNode newChild)
		{
			return null;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
		internal void SetSpecified(bool f)
		{
		}

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x28")]
		private bool fSpecified;
	}
}
