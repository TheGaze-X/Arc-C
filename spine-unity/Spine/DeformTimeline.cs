using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class DeformTimeline : CurveTimeline, ISlotTimeline
	{
		// Token: 0x0600006A RID: 106 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x4E44D80", Offset = "0x4E43980", VA = "0x184E44D80")]
		public DeformTimeline(int frameCount)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x17000021")]
		public override int PropertyId
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x4E44E10", Offset = "0x4E43A10", VA = "0x184E44E10", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002354 File Offset: 0x00000554
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000022")]
		public int SlotIndex
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x4E44E40", Offset = "0x4E43A40", VA = "0x184E44E40")]
			set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000023")]
		public VertexAttachment Attachment
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000024")]
		public float[] Frames
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000025")]
		public float[][] Vertices
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x4E44CE0", Offset = "0x4E438E0", VA = "0x184E44CE0")]
		public void SetFrame(int frameIndex, float time, float[] vertices)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4E44160", Offset = "0x4E42D60", VA = "0x184E44160", Slot = "6")]
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x18")]
		internal int slotIndex;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x20")]
		internal VertexAttachment attachment;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x28")]
		internal float[] frames;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x30")]
		internal float[][] frameVertices;
	}
}
