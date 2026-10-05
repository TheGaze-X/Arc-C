using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public class IkConstraintTimeline : CurveTimeline
	{
		// Token: 0x06000088 RID: 136 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x4E467D0", Offset = "0x4E453D0", VA = "0x184E467D0")]
		public IkConstraintTimeline(int frameCount)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x1700002E")]
		public override int PropertyId
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x4E46840", Offset = "0x4E45440", VA = "0x184E46840", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000023E4 File Offset: 0x000005E4
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700002F")]
		public int IkConstraintIndex
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x4E46850", Offset = "0x4E45450", VA = "0x184E46850")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000030")]
		public float[] Frames
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x4E46720", Offset = "0x4E45320", VA = "0x184E46720")]
		public void SetFrame(int frameIndex, float time, float mix, float softness, int bendDirection, bool compress, bool stretch)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x4E46240", Offset = "0x4E44E40", VA = "0x184E46240", Slot = "6")]
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		public const int ENTRIES = 6;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		private const int PREV_TIME = -6;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		private const int PREV_MIX = -5;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		private const int PREV_SOFTNESS = -4;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		private const int PREV_BEND_DIRECTION = -3;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		private const int PREV_COMPRESS = -2;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		private const int PREV_STRETCH = -1;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		private const int MIX = 1;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		private const int SOFTNESS = 2;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		private const int BEND_DIRECTION = 3;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		private const int COMPRESS = 4;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		private const int STRETCH = 5;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x18")]
		internal int ikConstraintIndex;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x20")]
		internal float[] frames;
	}
}
