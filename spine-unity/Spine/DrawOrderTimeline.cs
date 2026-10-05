using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public class DrawOrderTimeline : Timeline
	{
		// Token: 0x0600007F RID: 127 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x4E45160", Offset = "0x4E43D60", VA = "0x184E45160")]
		public DrawOrderTimeline(int frameCount)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x1700002A")]
		public int PropertyId
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x4E451F0", Offset = "0x4E43DF0", VA = "0x184E451F0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x1700002B")]
		public int FrameCount
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x27047E0", Offset = "0x27033E0", VA = "0x1827047E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700002C")]
		public float[] Frames
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700002D")]
		public int[][] DrawOrders
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x4E450C0", Offset = "0x4E43CC0", VA = "0x184E450C0")]
		public void SetFrame(int frameIndex, float time, int[] drawOrder)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x4E44EB0", Offset = "0x4E43AB0", VA = "0x184E44EB0", Slot = "4")]
		public void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x10")]
		internal float[] frames;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x18")]
		private int[][] drawOrders;
	}
}
