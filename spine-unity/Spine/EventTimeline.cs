using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class EventTimeline : Timeline
	{
		// Token: 0x06000076 RID: 118 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4E461A0", Offset = "0x4E44DA0", VA = "0x184E461A0")]
		public EventTimeline(int frameCount)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x17000026")]
		public int PropertyId
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x4E46230", Offset = "0x4E44E30", VA = "0x184E46230", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x17000027")]
		public int FrameCount
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x27047E0", Offset = "0x27033E0", VA = "0x1827047E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000028")]
		public float[] Frames
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000029")]
		public Event[] Events
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x4E46100", Offset = "0x4E44D00", VA = "0x184E46100")]
		public void SetFrame(int frameIndex, Event e)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x4E45F00", Offset = "0x4E44B00", VA = "0x184E45F00", Slot = "4")]
		public void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x10")]
		internal float[] frames;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x18")]
		private Event[] events;
	}
}
