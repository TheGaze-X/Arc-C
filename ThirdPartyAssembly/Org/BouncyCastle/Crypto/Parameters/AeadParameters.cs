using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002C1 RID: 705
	[Token(Token = "0x20002C1")]
	public class AeadParameters : ICipherParameters
	{
		// Token: 0x06001835 RID: 6197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001835")]
		[Address(RVA = "0x527E6B0", Offset = "0x527D2B0", VA = "0x18527E6B0")]
		public AeadParameters(KeyParameter key, int macSize, byte[] nonce)
		{
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001836")]
		[Address(RVA = "0x527E640", Offset = "0x527D240", VA = "0x18527E640")]
		public AeadParameters(KeyParameter key, int macSize, byte[] nonce, byte[] associatedText)
		{
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000341")]
		public virtual KeyParameter Key
		{
			[Token(Token = "0x6001837")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		[Token(Token = "0x17000342")]
		public virtual int MacSize
		{
			[Token(Token = "0x6001838")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001839")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
		public virtual byte[] GetAssociatedText()
		{
			return null;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183A")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "7")]
		public virtual byte[] GetNonce()
		{
			return null;
		}

		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] associatedText;

		// Token: 0x04000CEE RID: 3310
		[Token(Token = "0x4000CEE")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] nonce;

		// Token: 0x04000CEF RID: 3311
		[Token(Token = "0x4000CEF")]
		[FieldOffset(Offset = "0x20")]
		private readonly KeyParameter key;

		// Token: 0x04000CF0 RID: 3312
		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x28")]
		private readonly int macSize;
	}
}
