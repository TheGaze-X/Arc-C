using System;
using Il2CppDummyDll;

namespace Rei.Random
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public class SFMT : RandomBase
	{
		// Token: 0x0600028C RID: 652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x52FCBB0", Offset = "0x52FB7B0", VA = "0x1852FCBB0")]
		public SFMT()
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x52FCC60", Offset = "0x52FB860", VA = "0x1852FCC60")]
		public SFMT(int seed)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x52FCC50", Offset = "0x52FB850", VA = "0x1852FCC50")]
		public SFMT(int seed, MTPeriodType period)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x52FC780", Offset = "0x52FB380", VA = "0x1852FC780")]
		public SFMT(int seed, int mexp)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x52FC710", Offset = "0x52FB310", VA = "0x1852FC710", Slot = "4")]
		public override uint NextUInt32()
		{
			return 0U;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x52FD460", Offset = "0x52FC060", VA = "0x1852FD460")]
		protected void init_gen_rand(int seed)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x52FD6B0", Offset = "0x52FC2B0", VA = "0x1852FD6B0")]
		protected void period_certification()
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x52FD020", Offset = "0x52FBC20", VA = "0x1852FD020", Slot = "10")]
		protected virtual void gen_rand_all()
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x52FCCF0", Offset = "0x52FB8F0", VA = "0x1852FCCF0")]
		private void gen_rand_all_19937()
		{
		}

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x10")]
		protected int MEXP;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x14")]
		protected int POS1;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x18")]
		protected int SL1;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x1C")]
		protected int SL2;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x20")]
		protected int SR1;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x24")]
		protected int SR2;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x28")]
		protected uint MSK1;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x2C")]
		protected uint MSK2;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x30")]
		protected uint MSK3;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x34")]
		protected uint MSK4;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x38")]
		protected uint PARITY1;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x3C")]
		protected uint PARITY2;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x40")]
		protected uint PARITY3;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x44")]
		protected uint PARITY4;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x48")]
		protected int N;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x4C")]
		protected int N32;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x50")]
		protected int SL2_x8;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x54")]
		protected int SR2_x8;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x58")]
		protected int SL2_ix8;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x5C")]
		protected int SR2_ix8;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x60")]
		protected uint[] sfmt;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x68")]
		protected int idx;
	}
}
