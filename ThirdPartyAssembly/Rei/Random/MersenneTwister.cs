using System;
using Il2CppDummyDll;

namespace Rei.Random
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public class MersenneTwister : RandomBase
	{
		// Token: 0x0600027B RID: 635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x52F9900", Offset = "0x52F8500", VA = "0x1852F9900")]
		public MersenneTwister()
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x52F9A20", Offset = "0x52F8620", VA = "0x1852F9A20")]
		public MersenneTwister(int seed)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x52F9880", Offset = "0x52F8480", VA = "0x1852F9880", Slot = "4")]
		public override uint NextUInt32()
		{
			return 0U;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x52F9B30", Offset = "0x52F8730", VA = "0x1852F9B30")]
		protected void gen_rand_all()
		{
		}

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		protected const int N = 624;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		protected const int M = 397;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		protected const uint MATRIX_A = 2567483615U;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		protected const uint UPPER_MASK = 2147483648U;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		protected const uint LOWER_MASK = 2147483647U;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		protected const uint TEMPER1 = 2636928640U;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		protected const uint TEMPER2 = 4022730752U;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		protected const int TEMPER3 = 11;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		protected const int TEMPER4 = 7;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		protected const int TEMPER5 = 15;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		protected const int TEMPER6 = 18;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x10")]
		protected uint[] mt;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x18")]
		protected int mti;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x20")]
		private uint[] mag01;
	}
}
