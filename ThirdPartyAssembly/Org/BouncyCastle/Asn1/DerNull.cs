using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003BF RID: 959
	[Token(Token = "0x20003BF")]
	public class DerNull : Asn1Null
	{
		// Token: 0x06002073 RID: 8307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002073")]
		[Address(RVA = "0x53326F0", Offset = "0x53312F0", VA = "0x1853326F0")]
		[Obsolete("Use static Instance object")]
		public DerNull()
		{
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002074")]
		[Address(RVA = "0x5332690", Offset = "0x5331290", VA = "0x185332690")]
		protected internal DerNull(int dummy)
		{
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002075")]
		[Address(RVA = "0x5332530", Offset = "0x5331130", VA = "0x185332530", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x0000F438 File Offset: 0x0000D638
		[Token(Token = "0x6002076")]
		[Address(RVA = "0x53324A0", Offset = "0x53310A0", VA = "0x1853324A0", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x0000F450 File Offset: 0x0000D650
		[Token(Token = "0x6002077")]
		[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400113D RID: 4413
		[Token(Token = "0x400113D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DerNull Instance;

		// Token: 0x0400113E RID: 4414
		[Token(Token = "0x400113E")]
		[FieldOffset(Offset = "0x10")]
		private byte[] zeroBytes;
	}
}
