using System;
using Il2CppDummyDll;

namespace Rei.Random
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public class CompatilizedRandom : Random
	{
		// Token: 0x06000271 RID: 625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x52F68D0", Offset = "0x52F54D0", VA = "0x1852F68D0")]
		public CompatilizedRandom(RandomBase rand)
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x52F6820", Offset = "0x52F5420", VA = "0x1852F6820", Slot = "5")]
		public override int Next()
		{
			return 0;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x52F66E0", Offset = "0x52F52E0", VA = "0x1852F66E0", Slot = "7")]
		public override int Next(int maxValue)
		{
			return 0;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x52F6730", Offset = "0x52F5330", VA = "0x1852F6730", Slot = "6")]
		public override int Next(int minValue, int maxValue)
		{
			return 0;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x52F6880", Offset = "0x52F5480", VA = "0x1852F6880", Slot = "4")]
		protected override double Sample()
		{
			return 0.0;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x52F6690", Offset = "0x52F5290", VA = "0x1852F6690", Slot = "9")]
		public override void NextBytes(byte[] buffer)
		{
		}

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x20")]
		private RandomBase original;
	}
}
