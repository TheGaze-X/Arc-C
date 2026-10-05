using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000342 RID: 834
	[Token(Token = "0x2000342")]
	public class RijndaelEngine : IBlockCipher
	{
		// Token: 0x06001C3A RID: 7226 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		[Token(Token = "0x6001C3A")]
		[Address(RVA = "0x52CDC00", Offset = "0x52CC800", VA = "0x1852CDC00")]
		private byte Mul0x2(int b)
		{
			return 0;
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		[Token(Token = "0x6001C3B")]
		[Address(RVA = "0x52CDCA0", Offset = "0x52CC8A0", VA = "0x1852CDCA0")]
		private byte Mul0x3(int b)
		{
			return 0;
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0000DB00 File Offset: 0x0000BD00
		[Token(Token = "0x6001C3C")]
		[Address(RVA = "0x52CDD40", Offset = "0x52CC940", VA = "0x1852CDD40")]
		private byte Mul0x9(int b)
		{
			return 0;
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x0000DB18 File Offset: 0x0000BD18
		[Token(Token = "0x6001C3D")]
		[Address(RVA = "0x52CDDD0", Offset = "0x52CC9D0", VA = "0x1852CDDD0")]
		private byte Mul0xb(int b)
		{
			return 0;
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0000DB30 File Offset: 0x0000BD30
		[Token(Token = "0x6001C3E")]
		[Address(RVA = "0x52CDE50", Offset = "0x52CCA50", VA = "0x1852CDE50")]
		private byte Mul0xd(int b)
		{
			return 0;
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0000DB48 File Offset: 0x0000BD48
		[Token(Token = "0x6001C3F")]
		[Address(RVA = "0x52CDEE0", Offset = "0x52CCAE0", VA = "0x1852CDEE0")]
		private byte Mul0xe(int b)
		{
			return 0;
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C40")]
		[Address(RVA = "0x52CD5E0", Offset = "0x52CC1E0", VA = "0x1852CD5E0")]
		private void KeyAddition(long[] rk)
		{
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0000DB60 File Offset: 0x0000BD60
		[Token(Token = "0x6001C41")]
		[Address(RVA = "0x52CE3D0", Offset = "0x52CCFD0", VA = "0x1852CE3D0")]
		private long Shift(long r, int shift)
		{
			return 0L;
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C42")]
		[Address(RVA = "0x52CE2E0", Offset = "0x52CCEE0", VA = "0x1852CE2E0")]
		private void ShiftRow(byte[] shiftsSC)
		{
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x0000DB78 File Offset: 0x0000BD78
		[Token(Token = "0x6001C43")]
		[Address(RVA = "0x52CBE80", Offset = "0x52CAA80", VA = "0x1852CBE80")]
		private long ApplyS(long r, byte[] box)
		{
			return 0L;
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x52CE400", Offset = "0x52CD000", VA = "0x1852CE400")]
		private void Substitution(byte[] box)
		{
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x52CD650", Offset = "0x52CC250", VA = "0x1852CD650")]
		private void MixColumn()
		{
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C46")]
		[Address(RVA = "0x52CD200", Offset = "0x52CBE00", VA = "0x1852CD200")]
		private void InvMixColumn()
		{
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C47")]
		[Address(RVA = "0x52CC710", Offset = "0x52CB310", VA = "0x1852CC710")]
		private long[][] GenerateWorkingKey(byte[] key)
		{
			return null;
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C48")]
		[Address(RVA = "0x52CEE10", Offset = "0x52CDA10", VA = "0x1852CEE10")]
		public RijndaelEngine()
		{
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C49")]
		[Address(RVA = "0x52CEE20", Offset = "0x52CDA20", VA = "0x1852CEE20")]
		public RijndaelEngine(int blockBits)
		{
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4A")]
		[Address(RVA = "0x52CCFA0", Offset = "0x52CBBA0", VA = "0x1852CCFA0", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E7")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001C4B")]
			[Address(RVA = "0x52CF1D0", Offset = "0x52CDDD0", VA = "0x1852CF1D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x0000DB90 File Offset: 0x0000BD90
		[Token(Token = "0x170003E8")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001C4C")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0x52CCF90", Offset = "0x52CBB90", VA = "0x1852CCF90", Slot = "13")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x52CE010", Offset = "0x52CCC10", VA = "0x1852CE010", Slot = "14")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x52CE560", Offset = "0x52CD160", VA = "0x1852CE560")]
		private void UnPackBlock(byte[] bytes, int off)
		{
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C51")]
		[Address(RVA = "0x52CDF70", Offset = "0x52CCB70", VA = "0x1852CDF70")]
		private void PackBlock(byte[] bytes, int off)
		{
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C52")]
		[Address(RVA = "0x52CC250", Offset = "0x52CAE50", VA = "0x1852CC250")]
		private void EncryptBlock(long[][] rk)
		{
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C53")]
		[Address(RVA = "0x52CBEE0", Offset = "0x52CAAE0", VA = "0x1852CBEE0")]
		private void DecryptBlock(long[][] rk)
		{
		}

		// Token: 0x04000F31 RID: 3889
		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int MAXROUNDS;

		// Token: 0x04000F32 RID: 3890
		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int MAXKC;

		// Token: 0x04000F33 RID: 3891
		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] Logtable;

		// Token: 0x04000F34 RID: 3892
		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] Alogtable;

		// Token: 0x04000F35 RID: 3893
		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] S;

		// Token: 0x04000F36 RID: 3894
		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x20")]
		private static readonly byte[] Si;

		// Token: 0x04000F37 RID: 3895
		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0x28")]
		private static readonly byte[] rcon;

		// Token: 0x04000F38 RID: 3896
		[Token(Token = "0x4000F38")]
		[FieldOffset(Offset = "0x30")]
		private static readonly byte[][] shifts0;

		// Token: 0x04000F39 RID: 3897
		[Token(Token = "0x4000F39")]
		[FieldOffset(Offset = "0x38")]
		private static readonly byte[][] shifts1;

		// Token: 0x04000F3A RID: 3898
		[Token(Token = "0x4000F3A")]
		[FieldOffset(Offset = "0x10")]
		private int BC;

		// Token: 0x04000F3B RID: 3899
		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x18")]
		private long BC_MASK;

		// Token: 0x04000F3C RID: 3900
		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x20")]
		private int ROUNDS;

		// Token: 0x04000F3D RID: 3901
		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x24")]
		private int blockBits;

		// Token: 0x04000F3E RID: 3902
		[Token(Token = "0x4000F3E")]
		[FieldOffset(Offset = "0x28")]
		private long[][] workingKey;

		// Token: 0x04000F3F RID: 3903
		[Token(Token = "0x4000F3F")]
		[FieldOffset(Offset = "0x30")]
		private long A0;

		// Token: 0x04000F40 RID: 3904
		[Token(Token = "0x4000F40")]
		[FieldOffset(Offset = "0x38")]
		private long A1;

		// Token: 0x04000F41 RID: 3905
		[Token(Token = "0x4000F41")]
		[FieldOffset(Offset = "0x40")]
		private long A2;

		// Token: 0x04000F42 RID: 3906
		[Token(Token = "0x4000F42")]
		[FieldOffset(Offset = "0x48")]
		private long A3;

		// Token: 0x04000F43 RID: 3907
		[Token(Token = "0x4000F43")]
		[FieldOffset(Offset = "0x50")]
		private bool forEncryption;

		// Token: 0x04000F44 RID: 3908
		[Token(Token = "0x4000F44")]
		[FieldOffset(Offset = "0x58")]
		private byte[] shifts0SC;

		// Token: 0x04000F45 RID: 3909
		[Token(Token = "0x4000F45")]
		[FieldOffset(Offset = "0x60")]
		private byte[] shifts1SC;
	}
}
