using System;
using Il2CppDummyDll;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000336 RID: 822
	[Token(Token = "0x2000336")]
	internal class DESTransform : SymmetricTransform
	{
		// Token: 0x06001B37 RID: 6967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0x4B5D240", Offset = "0x4B5BE40", VA = "0x184B5D240")]
		internal DESTransform(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv)
		{
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00012690 File Offset: 0x00010890
		[Token(Token = "0x6001B38")]
		[Address(RVA = "0x4B5BFC0", Offset = "0x4B5ABC0", VA = "0x184B5BFC0")]
		private uint CipherFunct(uint r, int n)
		{
			return 0U;
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B39")]
		[Address(RVA = "0x4B5C3E0", Offset = "0x4B5AFE0", VA = "0x184B5C3E0")]
		internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap)
		{
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3A")]
		[Address(RVA = "0x4B5BF10", Offset = "0x4B5AB10", VA = "0x184B5BF10")]
		private static void BSwap(byte[] byteBuff)
		{
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0x4B5CBB0", Offset = "0x4B5B7B0", VA = "0x184B5CBB0")]
		internal void SetKey(byte[] key)
		{
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0x4B5C7F0", Offset = "0x4B5B3F0", VA = "0x184B5C7F0")]
		public void ProcessBlock(byte[] input, byte[] output)
		{
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x4B5C240", Offset = "0x4B5AE40", VA = "0x184B5C240", Slot = "17")]
		protected override void ECB(byte[] input, byte[] output)
		{
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B3E")]
		[Address(RVA = "0x4B5C310", Offset = "0x4B5AF10", VA = "0x184B5C310")]
		internal static byte[] GetStrongKey()
		{
			return null;
		}

		// Token: 0x04000EA9 RID: 3753
		[Token(Token = "0x4000EA9")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int KEY_BIT_SIZE;

		// Token: 0x04000EAA RID: 3754
		[Token(Token = "0x4000EAA")]
		[FieldOffset(Offset = "0x4")]
		internal static readonly int KEY_BYTE_SIZE;

		// Token: 0x04000EAB RID: 3755
		[Token(Token = "0x4000EAB")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int BLOCK_BIT_SIZE;

		// Token: 0x04000EAC RID: 3756
		[Token(Token = "0x4000EAC")]
		[FieldOffset(Offset = "0xC")]
		internal static readonly int BLOCK_BYTE_SIZE;

		// Token: 0x04000EAD RID: 3757
		[Token(Token = "0x4000EAD")]
		[FieldOffset(Offset = "0x58")]
		private byte[] keySchedule;

		// Token: 0x04000EAE RID: 3758
		[Token(Token = "0x4000EAE")]
		[FieldOffset(Offset = "0x60")]
		private byte[] byteBuff;

		// Token: 0x04000EAF RID: 3759
		[Token(Token = "0x4000EAF")]
		[FieldOffset(Offset = "0x68")]
		private uint[] dwordBuff;

		// Token: 0x04000EB0 RID: 3760
		[Token(Token = "0x4000EB0")]
		[FieldOffset(Offset = "0x10")]
		private static readonly uint[] spBoxes;

		// Token: 0x04000EB1 RID: 3761
		[Token(Token = "0x4000EB1")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] PC1;

		// Token: 0x04000EB2 RID: 3762
		[Token(Token = "0x4000EB2")]
		[FieldOffset(Offset = "0x20")]
		private static readonly byte[] leftRotTotal;

		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0x28")]
		private static readonly byte[] PC2;

		// Token: 0x04000EB4 RID: 3764
		[Token(Token = "0x4000EB4")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly uint[] ipTab;

		// Token: 0x04000EB5 RID: 3765
		[Token(Token = "0x4000EB5")]
		[FieldOffset(Offset = "0x38")]
		internal static readonly uint[] fpTab;
	}
}
