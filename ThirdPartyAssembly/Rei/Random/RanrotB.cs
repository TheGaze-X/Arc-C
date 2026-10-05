using System;
using Il2CppDummyDll;

namespace Rei.Random
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public class RanrotB : RandomBase
	{
		// Token: 0x06000289 RID: 649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x52FC520", Offset = "0x52FB120", VA = "0x1852FC520")]
		public RanrotB()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x52FC620", Offset = "0x52FB220", VA = "0x1852FC620")]
		public RanrotB(int seed)
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x52FC480", Offset = "0x52FB080", VA = "0x1852FC480", Slot = "4")]
		public override uint NextUInt32()
		{
			return 0U;
		}

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		protected const int KK = 17;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		protected const int JJ = 10;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		protected const int R1 = 13;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		protected const int R2 = 9;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x10")]
		protected uint[] randbuffer;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x18")]
		protected int p1;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x1C")]
		protected int p2;
	}
}
