using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class TwoColorTimeline : CurveTimeline, ISlotTimeline
	{
		// Token: 0x06000057 RID: 87 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x4E4BEC0", Offset = "0x4E4AAC0", VA = "0x184E4BEC0")]
		public TwoColorTimeline(int frameCount)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x17000019")]
		public override int PropertyId
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x4E4BF30", Offset = "0x4E4AB30", VA = "0x184E4BF30", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000022DC File Offset: 0x000004DC
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001A")]
		public int SlotIndex
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x4E4BF40", Offset = "0x4E4AB40", VA = "0x184E4BF40")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700001B")]
		public float[] Frames
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x4E4BDF0", Offset = "0x4E4A9F0", VA = "0x184E4BDF0")]
		public void SetFrame(int frameIndex, float time, float r, float g, float b, float a, float r2, float g2, float b2)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x4E4B7B0", Offset = "0x4E4A3B0", VA = "0x184E4B7B0", Slot = "6")]
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		public const int ENTRIES = 8;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		protected const int PREV_TIME = -8;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		protected const int PREV_R = -7;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		protected const int PREV_G = -6;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		protected const int PREV_B = -5;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		protected const int PREV_A = -4;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		protected const int PREV_R2 = -3;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		protected const int PREV_G2 = -2;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		protected const int PREV_B2 = -1;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		protected const int R = 1;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		protected const int G = 2;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		protected const int B = 3;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		protected const int A = 4;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		protected const int R2 = 5;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		protected const int G2 = 6;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		protected const int B2 = 7;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x18")]
		internal int slotIndex;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x20")]
		internal float[] frames;
	}
}
