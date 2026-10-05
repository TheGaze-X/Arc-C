using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000123 RID: 291
	[Token(Token = "0x2000123")]
	public class Random
	{
		// Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x4CF7170", Offset = "0x4CF5D70", VA = "0x184CF7170")]
		public Random()
		{
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x4CF71D0", Offset = "0x4CF5DD0", VA = "0x184CF71D0")]
		public Random(int Seed)
		{
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x4CF70C0", Offset = "0x4CF5CC0", VA = "0x184CF70C0", Slot = "4")]
		protected virtual double Sample()
		{
			return 0.0;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00009600 File Offset: 0x00007800
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x4CF6CB0", Offset = "0x4CF58B0", VA = "0x184CF6CB0")]
		private int InternalSample()
		{
			return 0;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00009618 File Offset: 0x00007818
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x4CF6A50", Offset = "0x4CF5650", VA = "0x184CF6A50")]
		private static int GenerateSeed()
		{
			return 0;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00009630 File Offset: 0x00007830
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x4CD7AD0", Offset = "0x4CD66D0", VA = "0x184CD7AD0")]
		private static int GenerateGlobalSeed()
		{
			return 0;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00009648 File Offset: 0x00007848
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x4CF70B0", Offset = "0x4CF5CB0", VA = "0x184CF70B0", Slot = "5")]
		public virtual int Next()
		{
			return 0;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00009660 File Offset: 0x00007860
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x4CF6C50", Offset = "0x4CF5850", VA = "0x184CF6C50")]
		private double GetSampleForLargeRange()
		{
			return 0.0;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00009678 File Offset: 0x00007878
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x4CF6E60", Offset = "0x4CF5A60", VA = "0x184CF6E60", Slot = "6")]
		public virtual int Next(int minValue, int maxValue)
		{
			return 0;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00009690 File Offset: 0x00007890
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x4CF6FD0", Offset = "0x4CF5BD0", VA = "0x184CF6FD0", Slot = "7")]
		public virtual int Next(int maxValue)
		{
			return 0;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x000096A8 File Offset: 0x000078A8
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x4568380", Offset = "0x4566F80", VA = "0x184568380", Slot = "8")]
		public virtual double NextDouble()
		{
			return 0.0;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x4CF6D40", Offset = "0x4CF5940", VA = "0x184CF6D40", Slot = "9")]
		public virtual void NextBytes(byte[] buffer)
		{
		}

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		private const int MBIG = 2147483647;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		private const int MSEED = 161803398;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		private const int MZ = 0;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x10")]
		private int _inext;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x14")]
		private int _inextp;

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x18")]
		private int[] _seedArray;

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		[System.ThreadStatic]
		private static System.Random t_threadRandom;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x0")]
		private static readonly System.Random s_globalRandom;
	}
}
