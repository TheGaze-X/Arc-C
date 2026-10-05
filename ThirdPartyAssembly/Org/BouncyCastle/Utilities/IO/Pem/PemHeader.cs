using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	public class PemHeader
	{
		// Token: 0x06000785 RID: 1925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public PemHeader(string name, string val)
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C9")]
		public virtual string Name
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CA")]
		public virtual string Value
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000055E0 File Offset: 0x000037E0
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x54671D0", Offset = "0x5465DD0", VA = "0x1854671D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000055F8 File Offset: 0x000037F8
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x5467030", Offset = "0x5465C30", VA = "0x185467030", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00005610 File Offset: 0x00003810
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x5467180", Offset = "0x5465D80", VA = "0x185467180")]
		private int GetHashCode(string s)
		{
			return 0;
		}

		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x40007BA")]
		[FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		[FieldOffset(Offset = "0x18")]
		private string val;
	}
}
