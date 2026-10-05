using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020002BE RID: 702
	[Token(Token = "0x20002BE")]
	public class CryptoApiRandomGenerator : IRandomGenerator
	{
		// Token: 0x06001821 RID: 6177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001821")]
		[Address(RVA = "0x5281F70", Offset = "0x5280B70", VA = "0x185281F70")]
		public CryptoApiRandomGenerator()
		{
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001822")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public CryptoApiRandomGenerator(RandomNumberGenerator rng)
		{
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001823")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public virtual void AddSeedMaterial(byte[] seed)
		{
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001824")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public virtual void AddSeedMaterial(long seed)
		{
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001825")]
		[Address(RVA = "0x3DD2A80", Offset = "0x3DD1680", VA = "0x183DD2A80", Slot = "10")]
		public virtual void NextBytes(byte[] bytes)
		{
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001826")]
		[Address(RVA = "0x5281DE0", Offset = "0x52809E0", VA = "0x185281DE0", Slot = "11")]
		public virtual void NextBytes(byte[] bytes, int start, int len)
		{
		}

		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x10")]
		private readonly RandomNumberGenerator rndProv;
	}
}
