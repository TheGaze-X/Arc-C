using System;
using Il2CppDummyDll;

namespace Rei.Random
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	public class Well : RandomBase
	{
		// Token: 0x06000295 RID: 661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x5302EF0", Offset = "0x5301AF0", VA = "0x185302EF0")]
		public Well()
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x5302E10", Offset = "0x5301A10", VA = "0x185302E10")]
		public Well(int seed)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x5302C50", Offset = "0x5301850", VA = "0x185302C50", Slot = "4")]
		public override uint NextUInt32()
		{
			return 0U;
		}

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		protected const int W = 32;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		protected const int R = 624;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		protected const int P = 31;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		protected const uint MASKU = 2147483647U;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		protected const uint MASKL = 2147483648U;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		protected const int M1 = 70;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		protected const int M2 = 179;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		protected const int M3 = 449;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		protected const uint TEMPERB = 305419896U;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		protected const uint TEMPERC = 2271560481U;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x10")]
		protected uint[] state;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x18")]
		protected int state_i;
	}
}
