using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public class XmlImplementation
	{
		// Token: 0x0600056E RID: 1390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x4FCCA10", Offset = "0x4FCB610", VA = "0x184FCCA10")]
		public XmlImplementation()
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public XmlImplementation(XmlNameTable nt)
		{
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x4FCC9B0", Offset = "0x4FCB5B0", VA = "0x184FCC9B0", Slot = "4")]
		public virtual XmlDocument CreateDocument()
		{
			return null;
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015A")]
		internal XmlNameTable NameTable
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x10")]
		private XmlNameTable nameTable;
	}
}
