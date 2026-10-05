using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000349 RID: 841
	[Token(Token = "0x2000349")]
	public abstract class SerpentEngineBase : IBlockCipher
	{
		// Token: 0x06001C8D RID: 7309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected SerpentEngineBase()
		{
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8E")]
		[Address(RVA = "0x52D2A70", Offset = "0x52D1670", VA = "0x1852D2A70", Slot = "10")]
		public virtual void Init(bool encrypting, ICipherParameters parameters)
		{
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003EE")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001C8F")]
			[Address(RVA = "0x52D33C0", Offset = "0x52D1FC0", VA = "0x1852D33C0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		[Token(Token = "0x170003EF")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001C90")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		[Token(Token = "0x6001C91")]
		[Address(RVA = "0x52D26C0", Offset = "0x52D12C0", VA = "0x1852D26C0", Slot = "13")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0000DE00 File Offset: 0x0000C000
		[Token(Token = "0x6001C92")]
		[Address(RVA = "0x52D2E90", Offset = "0x52D1A90", VA = "0x1852D2E90", Slot = "8")]
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C93")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0000DE18 File Offset: 0x0000C018
		[Token(Token = "0x6001C94")]
		[Address(RVA = "0x4CD7DD0", Offset = "0x4CD69D0", VA = "0x184CD7DD0")]
		protected static int RotateLeft(int x, int bits)
		{
			return 0;
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0000DE30 File Offset: 0x0000C030
		[Token(Token = "0x6001C95")]
		[Address(RVA = "0x4B4A670", Offset = "0x4B49270", VA = "0x184B4A670")]
		private static int RotateRight(int x, int bits)
		{
			return 0;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C96")]
		[Address(RVA = "0x52D3040", Offset = "0x52D1C40", VA = "0x1852D3040")]
		protected void Sb0(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C97")]
		[Address(RVA = "0x52D2710", Offset = "0x52D1310", VA = "0x1852D2710")]
		protected void Ib0(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x52D30A0", Offset = "0x52D1CA0", VA = "0x1852D30A0")]
		protected void Sb1(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C99")]
		[Address(RVA = "0x52D2770", Offset = "0x52D1370", VA = "0x1852D2770")]
		protected void Ib1(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x52D3100", Offset = "0x52D1D00", VA = "0x1852D3100")]
		protected void Sb2(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x52D27D0", Offset = "0x52D13D0", VA = "0x1852D27D0")]
		protected void Ib2(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x52D3180", Offset = "0x52D1D80", VA = "0x1852D3180")]
		protected void Sb3(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9D")]
		[Address(RVA = "0x52D2840", Offset = "0x52D1440", VA = "0x1852D2840")]
		protected void Ib3(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x52D3200", Offset = "0x52D1E00", VA = "0x1852D3200")]
		protected void Sb4(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0x52D28A0", Offset = "0x52D14A0", VA = "0x1852D28A0")]
		protected void Ib4(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x52D3260", Offset = "0x52D1E60", VA = "0x1852D3260")]
		protected void Sb5(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x52D2900", Offset = "0x52D1500", VA = "0x1852D2900")]
		protected void Ib5(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x52D32C0", Offset = "0x52D1EC0", VA = "0x1852D32C0")]
		protected void Sb6(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x52D2980", Offset = "0x52D1580", VA = "0x1852D2980")]
		protected void Ib6(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0x52D3310", Offset = "0x52D1F10", VA = "0x1852D3310")]
		protected void Sb7(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x52D29F0", Offset = "0x52D15F0", VA = "0x1852D29F0")]
		protected void Ib7(int a, int b, int c, int d)
		{
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x52D2DC0", Offset = "0x52D19C0", VA = "0x1852D2DC0")]
		protected void LT()
		{
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x52D2CE0", Offset = "0x52D18E0", VA = "0x1852D2CE0")]
		protected void InverseLT()
		{
		}

		// Token: 0x06001CA8 RID: 7336
		[Token(Token = "0x6001CA8")]
		protected abstract int[] MakeWorkingKey(byte[] key);

		// Token: 0x06001CA9 RID: 7337
		[Token(Token = "0x6001CA9")]
		protected abstract void EncryptBlock(byte[] input, int inOff, byte[] output, int outOff);

		// Token: 0x06001CAA RID: 7338
		[Token(Token = "0x6001CAA")]
		protected abstract void DecryptBlock(byte[] input, int inOff, byte[] output, int outOff);

		// Token: 0x04000F62 RID: 3938
		[Token(Token = "0x4000F62")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly int BlockSize;

		// Token: 0x04000F63 RID: 3939
		[Token(Token = "0x4000F63")]
		internal const int ROUNDS = 32;

		// Token: 0x04000F64 RID: 3940
		[Token(Token = "0x4000F64")]
		internal const int PHI = -1640531527;

		// Token: 0x04000F65 RID: 3941
		[Token(Token = "0x4000F65")]
		[FieldOffset(Offset = "0x10")]
		protected bool encrypting;

		// Token: 0x04000F66 RID: 3942
		[Token(Token = "0x4000F66")]
		[FieldOffset(Offset = "0x18")]
		protected int[] wKey;

		// Token: 0x04000F67 RID: 3943
		[Token(Token = "0x4000F67")]
		[FieldOffset(Offset = "0x20")]
		protected int X0;

		// Token: 0x04000F68 RID: 3944
		[Token(Token = "0x4000F68")]
		[FieldOffset(Offset = "0x24")]
		protected int X1;

		// Token: 0x04000F69 RID: 3945
		[Token(Token = "0x4000F69")]
		[FieldOffset(Offset = "0x28")]
		protected int X2;

		// Token: 0x04000F6A RID: 3946
		[Token(Token = "0x4000F6A")]
		[FieldOffset(Offset = "0x2C")]
		protected int X3;
	}
}
