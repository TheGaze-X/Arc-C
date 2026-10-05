using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200034C RID: 844
	[Token(Token = "0x200034C")]
	public sealed class TwofishEngine : IBlockCipher
	{
		// Token: 0x06001CC2 RID: 7362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC2")]
		[Address(RVA = "0x52EF2B0", Offset = "0x52EDEB0", VA = "0x1852EF2B0")]
		public TwofishEngine()
		{
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC3")]
		[Address(RVA = "0x52EE0E0", Offset = "0x52ECCE0", VA = "0x1852EE0E0", Slot = "5")]
		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F4")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001CC4")]
			[Address(RVA = "0x52EF6C0", Offset = "0x52EE2C0", VA = "0x1852EF6C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x0000DF68 File Offset: 0x0000C168
		[Token(Token = "0x170003F5")]
		public bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001CC5")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0000DF80 File Offset: 0x0000C180
		[Token(Token = "0x6001CC6")]
		[Address(RVA = "0x52EE420", Offset = "0x52ED020", VA = "0x1852EE420", Slot = "8")]
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC7")]
		[Address(RVA = "0x52EE670", Offset = "0x52ED270", VA = "0x1852EE670", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x0000DF98 File Offset: 0x0000C198
		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "6")]
		public int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC9")]
		[Address(RVA = "0x52EE690", Offset = "0x52ED290", VA = "0x1852EE690")]
		private void SetKey(byte[] key)
		{
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCA")]
		[Address(RVA = "0x52ED400", Offset = "0x52EC000", VA = "0x1852ED400")]
		private void EncryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x52ECD80", Offset = "0x52EB980", VA = "0x1852ECD80")]
		private void DecryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x52EDA80", Offset = "0x52EC680", VA = "0x1852EDA80")]
		private int F32(int x, int[] k32)
		{
			return 0;
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x52EE550", Offset = "0x52ED150", VA = "0x1852EE550")]
		private int RS_MDS_Encode(int k0, int k1)
		{
			return 0;
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		[Token(Token = "0x6001CCE")]
		[Address(RVA = "0x52EE620", Offset = "0x52ED220", VA = "0x1852EE620")]
		private int RS_rem(int x)
		{
			return 0;
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		[Token(Token = "0x6001CCF")]
		[Address(RVA = "0x52EE330", Offset = "0x52ECF30", VA = "0x1852EE330")]
		private int LFSR1(int x)
		{
			return 0;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0000E010 File Offset: 0x0000C210
		[Token(Token = "0x6001CD0")]
		[Address(RVA = "0x52EE350", Offset = "0x52ECF50", VA = "0x1852EE350")]
		private int LFSR2(int x)
		{
			return 0;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x0000E028 File Offset: 0x0000C228
		[Token(Token = "0x6001CD1")]
		[Address(RVA = "0x52EE3B0", Offset = "0x52ECFB0", VA = "0x1852EE3B0")]
		private int Mx_X(int x)
		{
			return 0;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0000E040 File Offset: 0x0000C240
		[Token(Token = "0x6001CD2")]
		[Address(RVA = "0x52EE3E0", Offset = "0x52ECFE0", VA = "0x1852EE3E0")]
		private int Mx_Y(int x)
		{
			return 0;
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0000E058 File Offset: 0x0000C258
		[Token(Token = "0x6001CD3")]
		[Address(RVA = "0x1AE63D0", Offset = "0x1AE4FD0", VA = "0x181AE63D0")]
		private int M_b0(int x)
		{
			return 0;
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0000E070 File Offset: 0x0000C270
		[Token(Token = "0x6001CD4")]
		[Address(RVA = "0x52EE380", Offset = "0x52ECF80", VA = "0x1852EE380")]
		private int M_b1(int x)
		{
			return 0;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0000E088 File Offset: 0x0000C288
		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0x52EE390", Offset = "0x52ECF90", VA = "0x1852EE390")]
		private int M_b2(int x)
		{
			return 0;
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		[Token(Token = "0x6001CD6")]
		[Address(RVA = "0x52EE3A0", Offset = "0x52ECFA0", VA = "0x1852EE3A0")]
		private int M_b3(int x)
		{
			return 0;
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[Token(Token = "0x6001CD7")]
		[Address(RVA = "0x52EDFE0", Offset = "0x52ECBE0", VA = "0x1852EDFE0")]
		private int Fe32_0(int x)
		{
			return 0;
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0x52EE060", Offset = "0x52ECC60", VA = "0x1852EE060")]
		private int Fe32_3(int x)
		{
			return 0;
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		[Token(Token = "0x6001CD9")]
		[Address(RVA = "0x52C6E30", Offset = "0x52C5A30", VA = "0x1852C6E30")]
		private int BytesTo32Bits(byte[] b, int p)
		{
			return 0;
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CDA")]
		[Address(RVA = "0x52C79C0", Offset = "0x52C65C0", VA = "0x1852C79C0")]
		private void Bits32ToBytes(int inData, byte[] b, int offset)
		{
		}

		// Token: 0x04000F7C RID: 3964
		[Token(Token = "0x4000F7C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[,] P;

		// Token: 0x04000F7D RID: 3965
		[Token(Token = "0x4000F7D")]
		private const int P_00 = 1;

		// Token: 0x04000F7E RID: 3966
		[Token(Token = "0x4000F7E")]
		private const int P_01 = 0;

		// Token: 0x04000F7F RID: 3967
		[Token(Token = "0x4000F7F")]
		private const int P_02 = 0;

		// Token: 0x04000F80 RID: 3968
		[Token(Token = "0x4000F80")]
		private const int P_03 = 1;

		// Token: 0x04000F81 RID: 3969
		[Token(Token = "0x4000F81")]
		private const int P_04 = 1;

		// Token: 0x04000F82 RID: 3970
		[Token(Token = "0x4000F82")]
		private const int P_10 = 0;

		// Token: 0x04000F83 RID: 3971
		[Token(Token = "0x4000F83")]
		private const int P_11 = 0;

		// Token: 0x04000F84 RID: 3972
		[Token(Token = "0x4000F84")]
		private const int P_12 = 1;

		// Token: 0x04000F85 RID: 3973
		[Token(Token = "0x4000F85")]
		private const int P_13 = 1;

		// Token: 0x04000F86 RID: 3974
		[Token(Token = "0x4000F86")]
		private const int P_14 = 0;

		// Token: 0x04000F87 RID: 3975
		[Token(Token = "0x4000F87")]
		private const int P_20 = 1;

		// Token: 0x04000F88 RID: 3976
		[Token(Token = "0x4000F88")]
		private const int P_21 = 1;

		// Token: 0x04000F89 RID: 3977
		[Token(Token = "0x4000F89")]
		private const int P_22 = 0;

		// Token: 0x04000F8A RID: 3978
		[Token(Token = "0x4000F8A")]
		private const int P_23 = 0;

		// Token: 0x04000F8B RID: 3979
		[Token(Token = "0x4000F8B")]
		private const int P_24 = 0;

		// Token: 0x04000F8C RID: 3980
		[Token(Token = "0x4000F8C")]
		private const int P_30 = 0;

		// Token: 0x04000F8D RID: 3981
		[Token(Token = "0x4000F8D")]
		private const int P_31 = 1;

		// Token: 0x04000F8E RID: 3982
		[Token(Token = "0x4000F8E")]
		private const int P_32 = 1;

		// Token: 0x04000F8F RID: 3983
		[Token(Token = "0x4000F8F")]
		private const int P_33 = 0;

		// Token: 0x04000F90 RID: 3984
		[Token(Token = "0x4000F90")]
		private const int P_34 = 1;

		// Token: 0x04000F91 RID: 3985
		[Token(Token = "0x4000F91")]
		private const int GF256_FDBK = 361;

		// Token: 0x04000F92 RID: 3986
		[Token(Token = "0x4000F92")]
		private const int GF256_FDBK_2 = 180;

		// Token: 0x04000F93 RID: 3987
		[Token(Token = "0x4000F93")]
		private const int GF256_FDBK_4 = 90;

		// Token: 0x04000F94 RID: 3988
		[Token(Token = "0x4000F94")]
		private const int RS_GF_FDBK = 333;

		// Token: 0x04000F95 RID: 3989
		[Token(Token = "0x4000F95")]
		private const int ROUNDS = 16;

		// Token: 0x04000F96 RID: 3990
		[Token(Token = "0x4000F96")]
		private const int MAX_ROUNDS = 16;

		// Token: 0x04000F97 RID: 3991
		[Token(Token = "0x4000F97")]
		private const int BLOCK_SIZE = 16;

		// Token: 0x04000F98 RID: 3992
		[Token(Token = "0x4000F98")]
		private const int MAX_KEY_BITS = 256;

		// Token: 0x04000F99 RID: 3993
		[Token(Token = "0x4000F99")]
		private const int INPUT_WHITEN = 0;

		// Token: 0x04000F9A RID: 3994
		[Token(Token = "0x4000F9A")]
		private const int OUTPUT_WHITEN = 4;

		// Token: 0x04000F9B RID: 3995
		[Token(Token = "0x4000F9B")]
		private const int ROUND_SUBKEYS = 8;

		// Token: 0x04000F9C RID: 3996
		[Token(Token = "0x4000F9C")]
		private const int TOTAL_SUBKEYS = 40;

		// Token: 0x04000F9D RID: 3997
		[Token(Token = "0x4000F9D")]
		private const int SK_STEP = 33686018;

		// Token: 0x04000F9E RID: 3998
		[Token(Token = "0x4000F9E")]
		private const int SK_BUMP = 16843009;

		// Token: 0x04000F9F RID: 3999
		[Token(Token = "0x4000F9F")]
		private const int SK_ROTL = 9;

		// Token: 0x04000FA0 RID: 4000
		[Token(Token = "0x4000FA0")]
		[FieldOffset(Offset = "0x10")]
		private bool encrypting;

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0x18")]
		private int[] gMDS0;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0x20")]
		private int[] gMDS1;

		// Token: 0x04000FA3 RID: 4003
		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0x28")]
		private int[] gMDS2;

		// Token: 0x04000FA4 RID: 4004
		[Token(Token = "0x4000FA4")]
		[FieldOffset(Offset = "0x30")]
		private int[] gMDS3;

		// Token: 0x04000FA5 RID: 4005
		[Token(Token = "0x4000FA5")]
		[FieldOffset(Offset = "0x38")]
		private int[] gSubKeys;

		// Token: 0x04000FA6 RID: 4006
		[Token(Token = "0x4000FA6")]
		[FieldOffset(Offset = "0x40")]
		private int[] gSBox;

		// Token: 0x04000FA7 RID: 4007
		[Token(Token = "0x4000FA7")]
		[FieldOffset(Offset = "0x48")]
		private int k64Cnt;

		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4000FA8")]
		[FieldOffset(Offset = "0x50")]
		private byte[] workingKey;
	}
}
