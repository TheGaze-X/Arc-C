using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000314 RID: 788
	[Token(Token = "0x2000314")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class RijndaelManagedTransform : ICryptoTransform, System.IDisposable
	{
		// Token: 0x060019CE RID: 6606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CE")]
		[Address(RVA = "0x4B36920", Offset = "0x4B35520", VA = "0x184B36920")]
		internal RijndaelManagedTransform(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode)
		{
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CF")]
		[Address(RVA = "0x4B33730", Offset = "0x4B32330", VA = "0x184B33730", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D0")]
		[Address(RVA = "0x4B33730", Offset = "0x4B32330", VA = "0x184B33730")]
		public void Clear()
		{
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D1")]
		[Address(RVA = "0x4B34780", Offset = "0x4B33380", VA = "0x184B34780")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x00011D60 File Offset: 0x0000FF60
		[Token(Token = "0x170002C5")]
		public int BlockSizeValue
		{
			[Token(Token = "0x60019D2")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x00011D78 File Offset: 0x0000FF78
		[Token(Token = "0x170002C6")]
		public int InputBlockSize
		{
			[Token(Token = "0x60019D3")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x00011D90 File Offset: 0x0000FF90
		[Token(Token = "0x170002C7")]
		public int OutputBlockSize
		{
			[Token(Token = "0x60019D4")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x00011DA8 File Offset: 0x0000FFA8
		[Token(Token = "0x170002C8")]
		public bool CanTransformMultipleBlocks
		{
			[Token(Token = "0x60019D5")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		[Token(Token = "0x170002C9")]
		public bool CanReuseTransform
		{
			[Token(Token = "0x60019D6")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		[Token(Token = "0x60019D7")]
		[Address(RVA = "0x4B35E30", Offset = "0x4B34A30", VA = "0x184B35E30", Slot = "8")]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019D8")]
		[Address(RVA = "0x4B36290", Offset = "0x4B34E90", VA = "0x184B36290", Slot = "9")]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D9")]
		[Address(RVA = "0x4B35CE0", Offset = "0x4B348E0", VA = "0x184B35CE0")]
		public void Reset()
		{
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		[Token(Token = "0x60019DA")]
		[Address(RVA = "0x4B34A80", Offset = "0x4B33680", VA = "0x184B34A80")]
		private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast)
		{
			return 0;
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00011E08 File Offset: 0x00010008
		[Token(Token = "0x60019DB")]
		[Address(RVA = "0x4B33960", Offset = "0x4B32560", VA = "0x184B33960")]
		private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast)
		{
			return 0;
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019DC")]
		[Address(RVA = "0x4B34890", Offset = "0x4B33490", VA = "0x184B34890")]
		private unsafe void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp)
		{
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019DD")]
		[Address(RVA = "0x4B33740", Offset = "0x4B32340", VA = "0x184B33740")]
		private unsafe void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp)
		{
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019DE")]
		[Address(RVA = "0x4B356B0", Offset = "0x4B342B0", VA = "0x184B356B0")]
		private void GenerateKeyExpansion(byte[] rgbKey)
		{
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00011E20 File Offset: 0x00010020
		[Token(Token = "0x60019DF")]
		[Address(RVA = "0x4B36FC0", Offset = "0x4B35BC0", VA = "0x184B36FC0")]
		private static int rot1(int val)
		{
			return 0;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00011E38 File Offset: 0x00010038
		[Token(Token = "0x60019E0")]
		[Address(RVA = "0x4B36FD0", Offset = "0x4B35BD0", VA = "0x184B36FD0")]
		private static int rot2(int val)
		{
			return 0;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00011E50 File Offset: 0x00010050
		[Token(Token = "0x60019E1")]
		[Address(RVA = "0x4B36FE0", Offset = "0x4B35BE0", VA = "0x184B36FE0")]
		private static int rot3(int val)
		{
			return 0;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00011E68 File Offset: 0x00010068
		[Token(Token = "0x60019E2")]
		[Address(RVA = "0x4B35D60", Offset = "0x4B34960", VA = "0x184B35D60")]
		private static int SubWord(int a)
		{
			return 0;
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00011E80 File Offset: 0x00010080
		[Token(Token = "0x60019E3")]
		[Address(RVA = "0x4B35CB0", Offset = "0x4B348B0", VA = "0x184B35CB0")]
		private static int MulX(int x)
		{
			return 0;
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019E5")]
		[Address(RVA = "0x4B368F0", Offset = "0x4B354F0", VA = "0x184B368F0")]
		internal RijndaelManagedTransform()
		{
		}

		// Token: 0x04000DFD RID: 3581
		[Token(Token = "0x4000DFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CipherMode m_cipherMode;

		// Token: 0x04000DFE RID: 3582
		[Token(Token = "0x4000DFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private PaddingMode m_paddingValue;

		// Token: 0x04000DFF RID: 3583
		[Token(Token = "0x4000DFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RijndaelManagedTransformMode m_transformMode;

		// Token: 0x04000E00 RID: 3584
		[Token(Token = "0x4000E00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_blockSizeBits;

		// Token: 0x04000E01 RID: 3585
		[Token(Token = "0x4000E01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_blockSizeBytes;

		// Token: 0x04000E02 RID: 3586
		[Token(Token = "0x4000E02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int m_inputBlockSize;

		// Token: 0x04000E03 RID: 3587
		[Token(Token = "0x4000E03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_outputBlockSize;

		// Token: 0x04000E04 RID: 3588
		[Token(Token = "0x4000E04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int[] m_encryptKeyExpansion;

		// Token: 0x04000E05 RID: 3589
		[Token(Token = "0x4000E05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int[] m_decryptKeyExpansion;

		// Token: 0x04000E06 RID: 3590
		[Token(Token = "0x4000E06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_Nr;

		// Token: 0x04000E07 RID: 3591
		[Token(Token = "0x4000E07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_Nb;

		// Token: 0x04000E08 RID: 3592
		[Token(Token = "0x4000E08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_Nk;

		// Token: 0x04000E09 RID: 3593
		[Token(Token = "0x4000E09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int[] m_encryptindex;

		// Token: 0x04000E0A RID: 3594
		[Token(Token = "0x4000E0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int[] m_decryptindex;

		// Token: 0x04000E0B RID: 3595
		[Token(Token = "0x4000E0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int[] m_IV;

		// Token: 0x04000E0C RID: 3596
		[Token(Token = "0x4000E0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int[] m_lastBlockBuffer;

		// Token: 0x04000E0D RID: 3597
		[Token(Token = "0x4000E0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private byte[] m_depadBuffer;

		// Token: 0x04000E0E RID: 3598
		[Token(Token = "0x4000E0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private byte[] m_shiftRegister;

		// Token: 0x04000E0F RID: 3599
		[Token(Token = "0x4000E0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly byte[] s_Sbox;

		// Token: 0x04000E10 RID: 3600
		[Token(Token = "0x4000E10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] s_Rcon;

		// Token: 0x04000E11 RID: 3601
		[Token(Token = "0x4000E11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int[] s_T;

		// Token: 0x04000E12 RID: 3602
		[Token(Token = "0x4000E12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int[] s_TF;

		// Token: 0x04000E13 RID: 3603
		[Token(Token = "0x4000E13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int[] s_iT;

		// Token: 0x04000E14 RID: 3604
		[Token(Token = "0x4000E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int[] s_iTF;
	}
}
