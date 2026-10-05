using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200032C RID: 812
	[Token(Token = "0x200032C")]
	public class Cast5Engine : IBlockCipher
	{
		// Token: 0x06001B48 RID: 6984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B48")]
		[Address(RVA = "0x52B7B60", Offset = "0x52B6760", VA = "0x1852B7B60")]
		public Cast5Engine()
		{
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B49")]
		[Address(RVA = "0x52B2B30", Offset = "0x52B1730", VA = "0x1852B2B30", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C8")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001B4A")]
			[Address(RVA = "0x52B7C20", Offset = "0x52B6820", VA = "0x1852B7C20", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		[Token(Token = "0x170003C9")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001B4B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		[Token(Token = "0x6001B4C")]
		[Address(RVA = "0x52B2E10", Offset = "0x52B1A10", VA = "0x1852B2E10", Slot = "13")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		[Token(Token = "0x6001B4E")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "15")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4F")]
		[Address(RVA = "0x52B2F90", Offset = "0x52B1B90", VA = "0x1852B2F90", Slot = "16")]
		internal virtual void SetKey(byte[] key)
		{
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[Token(Token = "0x6001B50")]
		[Address(RVA = "0x52B2730", Offset = "0x52B1330", VA = "0x1852B2730", Slot = "17")]
		internal virtual int EncryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
			return 0;
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0000D308 File Offset: 0x0000B508
		[Token(Token = "0x6001B51")]
		[Address(RVA = "0x52B2630", Offset = "0x52B1230", VA = "0x1852B2630", Slot = "18")]
		internal virtual int DecryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
			return 0;
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0000D320 File Offset: 0x0000B520
		[Token(Token = "0x6001B52")]
		[Address(RVA = "0x52B2830", Offset = "0x52B1430", VA = "0x1852B2830")]
		internal static uint F1(uint D, uint Kmi, int Kri)
		{
			return 0U;
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0000D338 File Offset: 0x0000B538
		[Token(Token = "0x6001B53")]
		[Address(RVA = "0x52B2930", Offset = "0x52B1530", VA = "0x1852B2930")]
		internal static uint F2(uint D, uint Kmi, int Kri)
		{
			return 0U;
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0000D350 File Offset: 0x0000B550
		[Token(Token = "0x6001B54")]
		[Address(RVA = "0x52B2A30", Offset = "0x52B1630", VA = "0x1852B2A30")]
		internal static uint F3(uint D, uint Kmi, int Kri)
		{
			return 0U;
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B55")]
		[Address(RVA = "0x52B23E0", Offset = "0x52B0FE0", VA = "0x1852B23E0")]
		internal void CAST_Encipher(uint L0, uint R0, uint[] result)
		{
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B56")]
		[Address(RVA = "0x52B2190", Offset = "0x52B0D90", VA = "0x1852B2190")]
		internal void CAST_Decipher(uint L16, uint R16, uint[] result)
		{
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B57")]
		[Address(RVA = "0x52B2120", Offset = "0x52B0D20", VA = "0x1852B2120")]
		internal static void Bits32ToInts(uint inData, int[] b, int offset)
		{
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0000D368 File Offset: 0x0000B568
		[Token(Token = "0x6001B58")]
		[Address(RVA = "0x52B2DA0", Offset = "0x52B19A0", VA = "0x1852B2DA0")]
		internal static uint IntsTo32bits(int[] b, int i)
		{
			return 0U;
		}

		// Token: 0x04000E9B RID: 3739
		[Token(Token = "0x4000E9B")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly uint[] S1;

		// Token: 0x04000E9C RID: 3740
		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly uint[] S2;

		// Token: 0x04000E9D RID: 3741
		[Token(Token = "0x4000E9D")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly uint[] S3;

		// Token: 0x04000E9E RID: 3742
		[Token(Token = "0x4000E9E")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly uint[] S4;

		// Token: 0x04000E9F RID: 3743
		[Token(Token = "0x4000E9F")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly uint[] S5;

		// Token: 0x04000EA0 RID: 3744
		[Token(Token = "0x4000EA0")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly uint[] S6;

		// Token: 0x04000EA1 RID: 3745
		[Token(Token = "0x4000EA1")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly uint[] S7;

		// Token: 0x04000EA2 RID: 3746
		[Token(Token = "0x4000EA2")]
		[FieldOffset(Offset = "0x38")]
		internal static readonly uint[] S8;

		// Token: 0x04000EA3 RID: 3747
		[Token(Token = "0x4000EA3")]
		[FieldOffset(Offset = "0x40")]
		internal static readonly int MAX_ROUNDS;

		// Token: 0x04000EA4 RID: 3748
		[Token(Token = "0x4000EA4")]
		[FieldOffset(Offset = "0x44")]
		internal static readonly int RED_ROUNDS;

		// Token: 0x04000EA5 RID: 3749
		[Token(Token = "0x4000EA5")]
		private const int BLOCK_SIZE = 8;

		// Token: 0x04000EA6 RID: 3750
		[Token(Token = "0x4000EA6")]
		[FieldOffset(Offset = "0x10")]
		private int[] _Kr;

		// Token: 0x04000EA7 RID: 3751
		[Token(Token = "0x4000EA7")]
		[FieldOffset(Offset = "0x18")]
		private uint[] _Km;

		// Token: 0x04000EA8 RID: 3752
		[Token(Token = "0x4000EA8")]
		[FieldOffset(Offset = "0x20")]
		private bool _encrypting;

		// Token: 0x04000EA9 RID: 3753
		[Token(Token = "0x4000EA9")]
		[FieldOffset(Offset = "0x28")]
		private byte[] _workingKey;

		// Token: 0x04000EAA RID: 3754
		[Token(Token = "0x4000EAA")]
		[FieldOffset(Offset = "0x30")]
		private int _rounds;
	}
}
