using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000219 RID: 537
	[Token(Token = "0x2000219")]
	public interface IBlockCipher
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600130B RID: 4875
		[Token(Token = "0x170002A4")]
		string AlgorithmName { [Token(Token = "0x600130B")] get; }

		// Token: 0x0600130C RID: 4876
		[Token(Token = "0x600130C")]
		void Init(bool forEncryption, ICipherParameters parameters);

		// Token: 0x0600130D RID: 4877
		[Token(Token = "0x600130D")]
		int GetBlockSize();

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600130E RID: 4878
		[Token(Token = "0x170002A5")]
		bool IsPartialBlockOkay { [Token(Token = "0x600130E")] get; }

		// Token: 0x0600130F RID: 4879
		[Token(Token = "0x600130F")]
		int ProcessBlock(byte[] inBuf, int inOff, byte[] outBuf, int outOff);

		// Token: 0x06001310 RID: 4880
		[Token(Token = "0x6001310")]
		void Reset();
	}
}
