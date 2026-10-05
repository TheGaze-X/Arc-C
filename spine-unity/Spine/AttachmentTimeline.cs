using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class AttachmentTimeline : Timeline, ISlotTimeline
	{
		// Token: 0x0600005E RID: 94 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x4E43300", Offset = "0x4E41F00", VA = "0x184E43300")]
		public AttachmentTimeline(int frameCount)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x1700001C")]
		public int PropertyId
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x4E43390", Offset = "0x4E41F90", VA = "0x184E43390", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x1700001D")]
		public int FrameCount
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x4BA9410", Offset = "0x4BA8010", VA = "0x184BA9410")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002324 File Offset: 0x00000524
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001E")]
		public int SlotIndex
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x4E433A0", Offset = "0x4E41FA0", VA = "0x184E433A0")]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700001F")]
		public float[] Frames
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000020")]
		public string[] AttachmentNames
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x4E43260", Offset = "0x4E41E60", VA = "0x184E43260")]
		public void SetFrame(int frameIndex, float time, string attachmentName)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x4E43080", Offset = "0x4E41C80", VA = "0x184E43080", Slot = "4")]
		public void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x4E43210", Offset = "0x4E41E10", VA = "0x184E43210")]
		private void SetAttachment(Skeleton skeleton, Slot slot, string attachmentName)
		{
		}

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x10")]
		internal int slotIndex;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x18")]
		internal float[] frames;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x20")]
		internal string[] attachmentNames;
	}
}
