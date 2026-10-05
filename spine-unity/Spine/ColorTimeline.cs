using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class ColorTimeline : CurveTimeline, ISlotTimeline
	{
		// Token: 0x0600004F RID: 79 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4E43B60", Offset = "0x4E42760", VA = "0x184E43B60")]
		public ColorTimeline(int frameCount)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x17000016")]
		public override int PropertyId
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x4E43BC0", Offset = "0x4E427C0", VA = "0x184E43BC0", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000022AC File Offset: 0x000004AC
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000017")]
		public int SlotIndex
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x4E43BD0", Offset = "0x4E427D0", VA = "0x184E43BD0")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000018")]
		public float[] Frames
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x4E43AE0", Offset = "0x4E426E0", VA = "0x184E43AE0")]
		public void SetFrame(int frameIndex, float time, float r, float g, float b, float a)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x4E436E0", Offset = "0x4E422E0", VA = "0x184E436E0", Slot = "6")]
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		public const int ENTRIES = 5;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		protected const int PREV_TIME = -5;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		protected const int PREV_R = -4;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		protected const int PREV_G = -3;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		protected const int PREV_B = -2;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		protected const int PREV_A = -1;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		protected const int R = 1;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		protected const int G = 2;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		protected const int B = 3;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		protected const int A = 4;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x18")]
		internal int slotIndex;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x20")]
		internal float[] frames;
	}
}
