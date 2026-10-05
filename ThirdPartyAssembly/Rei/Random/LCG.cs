using System;
using Il2CppDummyDll;

namespace Rei.Random
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public class LCG : RandomBase
	{
		// Token: 0x06000277 RID: 631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x52F9300", Offset = "0x52F7F00", VA = "0x1852F9300")]
		public LCG()
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x52F92C0", Offset = "0x52F7EC0", VA = "0x1852F92C0")]
		public LCG(int seed)
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x52F9340", Offset = "0x52F7F40", VA = "0x1852F9340")]
		public LCG(int seed, uint paramA, uint paramC)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x52F92B0", Offset = "0x52F7EB0", VA = "0x1852F92B0", Slot = "4")]
		public override uint NextUInt32()
		{
			return 0U;
		}

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x10")]
		protected uint A;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x14")]
		protected uint C;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x18")]
		protected uint x;
	}
}
