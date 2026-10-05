using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	[ComVisible(true)]
	[Serializable]
	public class LegacyRandom : Random
	{
		// Token: 0x0600029C RID: 668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x52F9850", Offset = "0x52F8450", VA = "0x1852F9850")]
		public LegacyRandom()
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x52F9630", Offset = "0x52F8230", VA = "0x1852F9630")]
		public LegacyRandom(int Seed)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x4E50300", Offset = "0x4E4EF00", VA = "0x184E50300", Slot = "4")]
		protected override double Sample()
		{
			return 0.0;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x4E502B0", Offset = "0x4E4EEB0", VA = "0x184E502B0", Slot = "5")]
		public override int Next()
		{
			return 0;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x52F9580", Offset = "0x52F8180", VA = "0x1852F9580", Slot = "7")]
		public override int Next(int maxValue)
		{
			return 0;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x52F9480", Offset = "0x52F8080", VA = "0x1852F9480", Slot = "6")]
		public override int Next(int minValue, int maxValue)
		{
			return 0;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x52F9390", Offset = "0x52F7F90", VA = "0x1852F9390", Slot = "9")]
		public override void NextBytes(byte[] buffer)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x4568380", Offset = "0x4566F80", VA = "0x184568380", Slot = "8")]
		public override double NextDouble()
		{
			return 0.0;
		}

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		private const int MBIG = 2147483647;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		private const int MSEED = 161803398;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		private const int MZ = 0;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int inext;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int inextp;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int[] SeedArray;
	}
}
