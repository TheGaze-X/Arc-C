using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class RotateTimeline : CurveTimeline, IBoneTimeline
	{
		// Token: 0x06000039 RID: 57 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x4E497C0", Offset = "0x4E483C0", VA = "0x184E497C0")]
		public RotateTimeline(int frameCount)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x1700000E")]
		public override int PropertyId
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000221C File Offset: 0x0000041C
		// (set) Token: 0x0600003B RID: 59 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700000F")]
		public int BoneIndex
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x4E49820", Offset = "0x4E48420", VA = "0x184E49820")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000010")]
		public float[] Frames
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4E49100", Offset = "0x4E47D00", VA = "0x184E49100")]
		public void SetFrame(int frameIndex, float time, float degrees)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4E49440", Offset = "0x4E48040", VA = "0x184E49440", Slot = "6")]
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		public const int ENTRIES = 2;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		internal const int PREV_TIME = -2;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		internal const int PREV_ROTATION = -1;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		internal const int ROTATION = 1;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		internal int boneIndex;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x20")]
		internal float[] frames;
	}
}
