using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public class TransformConstraintTimeline : CurveTimeline
	{
		// Token: 0x06000090 RID: 144 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x4E4B340", Offset = "0x4E49F40", VA = "0x184E4B340")]
		public TransformConstraintTimeline(int frameCount)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x17000031")]
		public override int PropertyId
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x4E4B3A0", Offset = "0x4E49FA0", VA = "0x184E4B3A0", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002414 File Offset: 0x00000614
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000032")]
		public int TransformConstraintIndex
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x4E4B3B0", Offset = "0x4E49FB0", VA = "0x184E4B3B0")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000033")]
		public float[] Frames
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x4E43AE0", Offset = "0x4E426E0", VA = "0x184E43AE0")]
		public void SetFrame(int frameIndex, float time, float rotateMix, float translateMix, float scaleMix, float shearMix)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x4E4AF20", Offset = "0x4E49B20", VA = "0x184E4AF20", Slot = "6")]
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		public const int ENTRIES = 5;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		private const int PREV_TIME = -5;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		private const int PREV_ROTATE = -4;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		private const int PREV_TRANSLATE = -3;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		private const int PREV_SCALE = -2;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		private const int PREV_SHEAR = -1;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		private const int ROTATE = 1;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		private const int TRANSLATE = 2;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		private const int SCALE = 3;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		private const int SHEAR = 4;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x18")]
		internal int transformConstraintIndex;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x20")]
		internal float[] frames;
	}
}
