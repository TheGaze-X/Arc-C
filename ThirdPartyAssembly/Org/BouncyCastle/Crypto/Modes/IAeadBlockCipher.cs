using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2000309")]
	public interface IAeadBlockCipher
	{
		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060019FB RID: 6651
		[Token(Token = "0x170003AD")]
		string AlgorithmName { [Token(Token = "0x60019FB")] get; }

		// Token: 0x060019FC RID: 6652
		[Token(Token = "0x60019FC")]
		IBlockCipher GetUnderlyingCipher();

		// Token: 0x060019FD RID: 6653
		[Token(Token = "0x60019FD")]
		void Init(bool forEncryption, ICipherParameters parameters);

		// Token: 0x060019FE RID: 6654
		[Token(Token = "0x60019FE")]
		int GetBlockSize();

		// Token: 0x060019FF RID: 6655
		[Token(Token = "0x60019FF")]
		void ProcessAadByte(byte input);

		// Token: 0x06001A00 RID: 6656
		[Token(Token = "0x6001A00")]
		void ProcessAadBytes(byte[] inBytes, int inOff, int len);

		// Token: 0x06001A01 RID: 6657
		[Token(Token = "0x6001A01")]
		int ProcessByte(byte input, byte[] outBytes, int outOff);

		// Token: 0x06001A02 RID: 6658
		[Token(Token = "0x6001A02")]
		int ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff);

		// Token: 0x06001A03 RID: 6659
		[Token(Token = "0x6001A03")]
		int DoFinal(byte[] outBytes, int outOff);

		// Token: 0x06001A04 RID: 6660
		[Token(Token = "0x6001A04")]
		byte[] GetMac();

		// Token: 0x06001A05 RID: 6661
		[Token(Token = "0x6001A05")]
		int GetUpdateOutputSize(int len);

		// Token: 0x06001A06 RID: 6662
		[Token(Token = "0x6001A06")]
		int GetOutputSize(int len);

		// Token: 0x06001A07 RID: 6663
		[Token(Token = "0x6001A07")]
		void Reset();
	}
}
