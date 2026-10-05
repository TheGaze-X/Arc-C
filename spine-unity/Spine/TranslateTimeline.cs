using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class TranslateTimeline : CurveTimeline, IBoneTimeline
	{
		// Token: 0x06000041 RID: 65 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4E49F00", Offset = "0x4E48B00", VA = "0x184E49F00")]
		public TranslateTimeline(int frameCount)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x17000011")]
		public override int PropertyId
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x4E4B730", Offset = "0x4E4A330", VA = "0x184E4B730", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000224C File Offset: 0x0000044C
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000012")]
		public int BoneIndex
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x4E4B740", Offset = "0x4E4A340", VA = "0x184E4B740")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000013")]
		public float[] Frames
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4E48DB0", Offset = "0x4E479B0", VA = "0x184E48DB0")]
		public void SetFrame(int frameIndex, float time, float x, float y)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4E4B420", Offset = "0x4E4A020", VA = "0x184E4B420", Slot = "6")]
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		public const int ENTRIES = 3;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		protected const int PREV_TIME = -3;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		protected const int PREV_X = -2;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		protected const int PREV_Y = -1;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		protected const int X = 1;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		protected const int Y = 2;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x18")]
		internal int boneIndex;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x20")]
		internal float[] frames;
	}
}
