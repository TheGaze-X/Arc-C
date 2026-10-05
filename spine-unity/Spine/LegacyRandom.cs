using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[ComVisible(true)]
	[Serializable]
	public class LegacyRandom : Random
	{
		// Token: 0x060002EA RID: 746 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x4E505A0", Offset = "0x4E4F1A0", VA = "0x184E505A0")]
		public LegacyRandom()
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x4E50380", Offset = "0x4E4EF80", VA = "0x184E50380")]
		public LegacyRandom(int Seed)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000341C File Offset: 0x0000161C
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x4E50300", Offset = "0x4E4EF00", VA = "0x184E50300", Slot = "4")]
		protected override double Sample()
		{
			return 0.0;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00003434 File Offset: 0x00001634
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x4E502B0", Offset = "0x4E4EEB0", VA = "0x184E502B0", Slot = "5")]
		public override int Next()
		{
			return 0;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000344C File Offset: 0x0000164C
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x4E50200", Offset = "0x4E4EE00", VA = "0x184E50200", Slot = "7")]
		public override int Next(int maxValue)
		{
			return 0;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00003464 File Offset: 0x00001664
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x4E50100", Offset = "0x4E4ED00", VA = "0x184E50100", Slot = "6")]
		public override int Next(int minValue, int maxValue)
		{
			return 0;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x4E50010", Offset = "0x4E4EC10", VA = "0x184E50010", Slot = "9")]
		public override void NextBytes(byte[] buffer)
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000347C File Offset: 0x0000167C
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x4568380", Offset = "0x4566F80", VA = "0x184568380", Slot = "8")]
		public override double NextDouble()
		{
			return 0.0;
		}

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		private const int MBIG = 2147483647;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		private const int MSEED = 161803398;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		private const int MZ = 0;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int inext;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int inextp;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int[] SeedArray;
	}
}
