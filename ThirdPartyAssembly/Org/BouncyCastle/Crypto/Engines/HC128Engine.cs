using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000335 RID: 821
	[Token(Token = "0x2000335")]
	public class HC128Engine : IStreamCipher
	{
		// Token: 0x06001BA1 RID: 7073 RVA: 0x0000D518 File Offset: 0x0000B718
		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x52BE9D0", Offset = "0x52BD5D0", VA = "0x1852BE9D0")]
		private static uint F1(uint x)
		{
			return 0U;
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0000D530 File Offset: 0x0000B730
		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x52BEA00", Offset = "0x52BD600", VA = "0x1852BEA00")]
		private static uint F2(uint x)
		{
			return 0U;
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0000D548 File Offset: 0x0000B748
		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x52BEA30", Offset = "0x52BD630", VA = "0x1852BEA30")]
		private uint G1(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0000D560 File Offset: 0x0000B760
		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x52BEA60", Offset = "0x52BD660", VA = "0x1852BEA60")]
		private uint G2(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0000D578 File Offset: 0x0000B778
		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x4CD7DD0", Offset = "0x4CD69D0", VA = "0x184CD7DD0")]
		private static uint RotateLeft(uint x, int bits)
		{
			return 0U;
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0000D590 File Offset: 0x0000B790
		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x4B4A670", Offset = "0x4B49270", VA = "0x184B4A670")]
		private static uint RotateRight(uint x, int bits)
		{
			return 0U;
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x52BEAF0", Offset = "0x52BD6F0", VA = "0x1852BEAF0")]
		private uint H1(uint x)
		{
			return 0U;
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x52BEB40", Offset = "0x52BD740", VA = "0x1852BEB40")]
		private uint H2(uint x)
		{
			return 0U;
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		[Token(Token = "0x6001BA9")]
		[Address(RVA = "0x52BF390", Offset = "0x52BDF90", VA = "0x1852BF390")]
		private static uint Mod1024(uint x)
		{
			return 0U;
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		[Token(Token = "0x6001BAA")]
		[Address(RVA = "0x52BF3A0", Offset = "0x52BDFA0", VA = "0x1852BF3A0")]
		private static uint Mod512(uint x)
		{
			return 0U;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0000D608 File Offset: 0x0000B808
		[Token(Token = "0x6001BAB")]
		[Address(RVA = "0x52BE9C0", Offset = "0x52BD5C0", VA = "0x1852BE9C0")]
		private static uint Dim(uint x, uint y)
		{
			return 0U;
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0000D620 File Offset: 0x0000B820
		[Token(Token = "0x6001BAC")]
		[Address(RVA = "0x52BF610", Offset = "0x52BE210", VA = "0x1852BF610")]
		private uint Step()
		{
			return 0U;
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAD")]
		[Address(RVA = "0x52BEB90", Offset = "0x52BD790", VA = "0x1852BEB90")]
		private void Init()
		{
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D5")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001BAE")]
			[Address(RVA = "0x52BF8C0", Offset = "0x52BE4C0", VA = "0x1852BF8C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x52BEF10", Offset = "0x52BDB10", VA = "0x1852BEF10", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0000D638 File Offset: 0x0000B838
		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0x52BEA90", Offset = "0x52BD690", VA = "0x1852BEA90")]
		private byte GetByte()
		{
			return 0;
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0x52BF3B0", Offset = "0x52BDFB0", VA = "0x1852BF3B0", Slot = "11")]
		public virtual void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB2")]
		[Address(RVA = "0x52BF590", Offset = "0x52BE190", VA = "0x1852BF590", Slot = "12")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0000D650 File Offset: 0x0000B850
		[Token(Token = "0x6001BB3")]
		[Address(RVA = "0x52BF5A0", Offset = "0x52BE1A0", VA = "0x1852BF5A0", Slot = "13")]
		public virtual byte ReturnByte(byte input)
		{
			return 0;
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0x52BF820", Offset = "0x52BE420", VA = "0x1852BF820")]
		public HC128Engine()
		{
		}

		// Token: 0x04000EDE RID: 3806
		[Token(Token = "0x4000EDE")]
		[FieldOffset(Offset = "0x10")]
		private uint[] p;

		// Token: 0x04000EDF RID: 3807
		[Token(Token = "0x4000EDF")]
		[FieldOffset(Offset = "0x18")]
		private uint[] q;

		// Token: 0x04000EE0 RID: 3808
		[Token(Token = "0x4000EE0")]
		[FieldOffset(Offset = "0x20")]
		private uint cnt;

		// Token: 0x04000EE1 RID: 3809
		[Token(Token = "0x4000EE1")]
		[FieldOffset(Offset = "0x28")]
		private byte[] key;

		// Token: 0x04000EE2 RID: 3810
		[Token(Token = "0x4000EE2")]
		[FieldOffset(Offset = "0x30")]
		private byte[] iv;

		// Token: 0x04000EE3 RID: 3811
		[Token(Token = "0x4000EE3")]
		[FieldOffset(Offset = "0x38")]
		private bool initialised;

		// Token: 0x04000EE4 RID: 3812
		[Token(Token = "0x4000EE4")]
		[FieldOffset(Offset = "0x40")]
		private byte[] buf;

		// Token: 0x04000EE5 RID: 3813
		[Token(Token = "0x4000EE5")]
		[FieldOffset(Offset = "0x48")]
		private int idx;
	}
}
