using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020002C0 RID: 704
	[Token(Token = "0x20002C0")]
	public interface IRandomGenerator
	{
		// Token: 0x06001831 RID: 6193
		[Token(Token = "0x6001831")]
		void AddSeedMaterial(byte[] seed);

		// Token: 0x06001832 RID: 6194
		[Token(Token = "0x6001832")]
		void AddSeedMaterial(long seed);

		// Token: 0x06001833 RID: 6195
		[Token(Token = "0x6001833")]
		void NextBytes(byte[] bytes);

		// Token: 0x06001834 RID: 6196
		[Token(Token = "0x6001834")]
		void NextBytes(byte[] bytes, int start, int len);
	}
}
