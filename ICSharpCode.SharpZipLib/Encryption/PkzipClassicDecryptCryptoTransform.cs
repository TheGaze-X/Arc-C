using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	internal class PkzipClassicDecryptCryptoTransform : PkzipClassicCryptoBase, ICryptoTransform, IDisposable
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x4A40F50", Offset = "0x4A3FB50", VA = "0x184A40F50")]
		internal PkzipClassicDecryptCryptoTransform(byte[] keyBlock)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x4A40E60", Offset = "0x4A3FA60", VA = "0x184A40E60", Slot = "9")]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x4A40D90", Offset = "0x4A3F990", VA = "0x184A40D90", Slot = "8")]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x17000027")]
		public bool CanReuseTransform
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x17000028")]
		public int InputBlockSize
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x17000029")]
		public int OutputBlockSize
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x1700002A")]
		public bool CanTransformMultipleBlocks
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x4A40A10", Offset = "0x4A3F610", VA = "0x184A40A10", Slot = "10")]
		public void Dispose()
		{
		}
	}
}
