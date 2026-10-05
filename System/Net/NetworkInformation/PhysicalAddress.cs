using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200036B RID: 875
	[Token(Token = "0x200036B")]
	public class PhysicalAddress
	{
		// Token: 0x06001849 RID: 6217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x50A1D50", Offset = "0x50A0950", VA = "0x1850A1D50")]
		public PhysicalAddress(byte[] address)
		{
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0000AF38 File Offset: 0x00009138
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x50A1A80", Offset = "0x50A0680", VA = "0x1850A1A80", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0000AF50 File Offset: 0x00009150
		[Token(Token = "0x600184B")]
		[Address(RVA = "0x50A1990", Offset = "0x50A0590", VA = "0x1850A1990", Slot = "0")]
		public override bool Equals(object comparand)
		{
			return default(bool);
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184C")]
		[Address(RVA = "0x50A1B80", Offset = "0x50A0780", VA = "0x1850A1B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000E70 RID: 3696
		[Token(Token = "0x4000E70")]
		[FieldOffset(Offset = "0x10")]
		private byte[] address;

		// Token: 0x04000E71 RID: 3697
		[Token(Token = "0x4000E71")]
		[FieldOffset(Offset = "0x18")]
		private bool changed;

		// Token: 0x04000E72 RID: 3698
		[Token(Token = "0x4000E72")]
		[FieldOffset(Offset = "0x1C")]
		private int hash;

		// Token: 0x04000E73 RID: 3699
		[Token(Token = "0x4000E73")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PhysicalAddress None;
	}
}
