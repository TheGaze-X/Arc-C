using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Engines;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000210 RID: 528
	[Token(Token = "0x2000210")]
	public class BufferedIesCipher : BufferedCipherBase
	{
		// Token: 0x060012D8 RID: 4824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D8")]
		[Address(RVA = "0x5222360", Offset = "0x5220F60", VA = "0x185222360")]
		public BufferedIesCipher(IesEngine engine)
		{
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A0")]
		public override string AlgorithmName
		{
			[Token(Token = "0x60012D9")]
			[Address(RVA = "0x5222470", Offset = "0x5221070", VA = "0x185222470", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x5222070", Offset = "0x5220C70", VA = "0x185222070", Slot = "23")]
		public override void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0000A6B0 File Offset: 0x000088B0
		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "24")]
		public override int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x0000A6C8 File Offset: 0x000088C8
		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x5221F90", Offset = "0x5220B90", VA = "0x185221F90", Slot = "25")]
		public override int GetOutputSize(int inputLen)
		{
			return 0;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x60012DD")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "26")]
		public override int GetUpdateOutputSize(int inputLen)
		{
			return 0;
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x52220C0", Offset = "0x5220CC0", VA = "0x1852220C0", Slot = "27")]
		public override byte[] ProcessByte(byte input)
		{
			return null;
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x5222120", Offset = "0x5220D20", VA = "0x185222120", Slot = "30")]
		public override byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x5221EC0", Offset = "0x5220AC0", VA = "0x185221EC0", Slot = "33")]
		public override byte[] DoFinal()
		{
			return null;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x5220180", Offset = "0x521ED80", VA = "0x185220180", Slot = "35")]
		public override byte[] DoFinal(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E2")]
		[Address(RVA = "0x5222310", Offset = "0x5220F10", VA = "0x185222310", Slot = "39")]
		public override void Reset()
		{
		}

		// Token: 0x04000958 RID: 2392
		[Token(Token = "0x4000958")]
		[FieldOffset(Offset = "0x10")]
		private readonly IesEngine engine;

		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x4000959")]
		[FieldOffset(Offset = "0x18")]
		private bool forEncryption;

		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		[FieldOffset(Offset = "0x20")]
		private MemoryStream buffer;
	}
}
