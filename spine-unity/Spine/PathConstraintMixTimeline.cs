using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class PathConstraintMixTimeline : CurveTimeline
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x4E48E10", Offset = "0x4E47A10", VA = "0x184E48E10")]
		public PathConstraintMixTimeline(int frameCount)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x17000038")]
		public override int PropertyId
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x4E48E70", Offset = "0x4E47A70", VA = "0x184E48E70", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000248C File Offset: 0x0000068C
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000039")]
		public int PathConstraintIndex
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x4E48E80", Offset = "0x4E47A80", VA = "0x184E48E80")]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700003A")]
		public float[] Frames
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x4E48DB0", Offset = "0x4E479B0", VA = "0x184E48DB0")]
		public void SetFrame(int frameIndex, float time, float rotateMix, float translateMix)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x4E48AD0", Offset = "0x4E476D0", VA = "0x184E48AD0", Slot = "6")]
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		public const int ENTRIES = 3;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		private const int PREV_TIME = -3;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		private const int PREV_ROTATE = -2;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		private const int PREV_TRANSLATE = -1;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		private const int ROTATE = 1;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		private const int TRANSLATE = 2;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x18")]
		internal int pathConstraintIndex;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x20")]
		internal float[] frames;
	}
}
