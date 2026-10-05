using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public abstract class CurveTimeline : Timeline
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x1700000C")]
		public int FrameCount
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x4E44130", Offset = "0x4E42D30", VA = "0x184E44130")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x4E44070", Offset = "0x4E42C70", VA = "0x184E44070")]
		public CurveTimeline(int frameCount)
		{
		}

		// Token: 0x06000032 RID: 50
		[Token(Token = "0x6000032")]
		public abstract void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction);

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000033 RID: 51
		[Token(Token = "0x1700000D")]
		public abstract int PropertyId { [Token(Token = "0x6000033")] get; }

		// Token: 0x06000034 RID: 52 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x4E43FF0", Offset = "0x4E42BF0", VA = "0x184E43FF0")]
		public void SetLinear(int frameIndex)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x4E44030", Offset = "0x4E42C30", VA = "0x184E44030")]
		public void SetStepped(int frameIndex)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x4E43DE0", Offset = "0x4E429E0", VA = "0x184E43DE0")]
		public float GetCurveType(int frameIndex)
		{
			return 0f;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x4E43E40", Offset = "0x4E42A40", VA = "0x184E43E40")]
		public void SetCurve(int frameIndex, float cx1, float cy1, float cx2, float cy2)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x4E43C40", Offset = "0x4E42840", VA = "0x184E43C40")]
		public float GetCurvePercent(int frameIndex, float percent)
		{
			return 0f;
		}

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		protected const float LINEAR = 0f;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		protected const float STEPPED = 1f;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		protected const float BEZIER = 2f;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		protected const int BEZIER_SIZE = 19;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x10")]
		internal float[] curves;
	}
}
