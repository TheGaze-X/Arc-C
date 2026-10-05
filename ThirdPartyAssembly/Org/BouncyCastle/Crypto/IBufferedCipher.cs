using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200021B RID: 539
	[Token(Token = "0x200021B")]
	public interface IBufferedCipher
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06001313 RID: 4883
		[Token(Token = "0x170002A6")]
		string AlgorithmName { [Token(Token = "0x6001313")] get; }

		// Token: 0x06001314 RID: 4884
		[Token(Token = "0x6001314")]
		void Init(bool forEncryption, ICipherParameters parameters);

		// Token: 0x06001315 RID: 4885
		[Token(Token = "0x6001315")]
		int GetBlockSize();

		// Token: 0x06001316 RID: 4886
		[Token(Token = "0x6001316")]
		int GetOutputSize(int inputLen);

		// Token: 0x06001317 RID: 4887
		[Token(Token = "0x6001317")]
		int GetUpdateOutputSize(int inputLen);

		// Token: 0x06001318 RID: 4888
		[Token(Token = "0x6001318")]
		byte[] ProcessByte(byte input);

		// Token: 0x06001319 RID: 4889
		[Token(Token = "0x6001319")]
		int ProcessByte(byte input, byte[] output, int outOff);

		// Token: 0x0600131A RID: 4890
		[Token(Token = "0x600131A")]
		byte[] ProcessBytes(byte[] input);

		// Token: 0x0600131B RID: 4891
		[Token(Token = "0x600131B")]
		byte[] ProcessBytes(byte[] input, int inOff, int length);

		// Token: 0x0600131C RID: 4892
		[Token(Token = "0x600131C")]
		int ProcessBytes(byte[] input, byte[] output, int outOff);

		// Token: 0x0600131D RID: 4893
		[Token(Token = "0x600131D")]
		int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff);

		// Token: 0x0600131E RID: 4894
		[Token(Token = "0x600131E")]
		byte[] DoFinal();

		// Token: 0x0600131F RID: 4895
		[Token(Token = "0x600131F")]
		byte[] DoFinal(byte[] input);

		// Token: 0x06001320 RID: 4896
		[Token(Token = "0x6001320")]
		byte[] DoFinal(byte[] input, int inOff, int length);

		// Token: 0x06001321 RID: 4897
		[Token(Token = "0x6001321")]
		int DoFinal(byte[] output, int outOff);

		// Token: 0x06001322 RID: 4898
		[Token(Token = "0x6001322")]
		int DoFinal(byte[] input, byte[] output, int outOff);

		// Token: 0x06001323 RID: 4899
		[Token(Token = "0x6001323")]
		int DoFinal(byte[] input, int inOff, int length, byte[] output, int outOff);

		// Token: 0x06001324 RID: 4900
		[Token(Token = "0x6001324")]
		void Reset();
	}
}
