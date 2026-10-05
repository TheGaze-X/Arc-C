using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	internal class PkzipClassicEncryptCryptoTransform : PkzipClassicCryptoBase, ICryptoTransform, IDisposable
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x4A40F50", Offset = "0x4A3FB50", VA = "0x184A40F50")]
		internal PkzipClassicEncryptCryptoTransform(byte[] keyBlock)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x4A41060", Offset = "0x4A3FC60", VA = "0x184A41060", Slot = "9")]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x4A40F80", Offset = "0x4A3FB80", VA = "0x184A40F80", Slot = "8")]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x17000023")]
		public bool CanReuseTransform
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x17000024")]
		public int InputBlockSize
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x17000025")]
		public int OutputBlockSize
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x17000026")]
		public bool CanTransformMultipleBlocks
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x4A40A10", Offset = "0x4A3F610", VA = "0x184A40A10", Slot = "10")]
		public void Dispose()
		{
		}
	}
}
