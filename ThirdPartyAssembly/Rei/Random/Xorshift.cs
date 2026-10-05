using System;
using Il2CppDummyDll;

namespace Rei.Random
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	public class Xorshift : RandomBase
	{
		// Token: 0x06000298 RID: 664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x5303010", Offset = "0x5301C10", VA = "0x185303010")]
		public Xorshift()
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x5302FD0", Offset = "0x5301BD0", VA = "0x185302FD0")]
		public Xorshift(int seed)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x319E910", Offset = "0x319D510", VA = "0x18319E910")]
		public Xorshift(uint seed1, uint seed2, uint seed3, uint seed4)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x52F8F20", Offset = "0x52F7B20", VA = "0x1852F8F20", Slot = "4")]
		public override uint NextUInt32()
		{
			return 0U;
		}

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x10")]
		protected uint x;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x14")]
		protected uint y;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x18")]
		protected uint z;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x1C")]
		protected uint w;
	}
}
