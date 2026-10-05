using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013A3 RID: 5027
	[Token(Token = "0x20013A3")]
	[Serializable]
	public class ActArchiveComponentData
	{
		// Token: 0x0600737F RID: 29567 RVA: 0x00033528 File Offset: 0x00031728
		[Token(Token = "0x600737F")]
		[Address(RVA = "0x1028420", Offset = "0x1027020", VA = "0x181028420", Slot = "4")]
		public virtual bool ShouldSerializetimeline()
		{
			return default(bool);
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x00033540 File Offset: 0x00031740
		[Token(Token = "0x6007380")]
		[Address(RVA = "0x142F770", Offset = "0x142E370", VA = "0x18142F770", Slot = "5")]
		public virtual bool ShouldSerializemusic()
		{
			return default(bool);
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x00033558 File Offset: 0x00031758
		[Token(Token = "0x6007381")]
		[Address(RVA = "0x926F60", Offset = "0x925B60", VA = "0x180926F60", Slot = "6")]
		public virtual bool ShouldSerializepic()
		{
			return default(bool);
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x00033570 File Offset: 0x00031770
		[Token(Token = "0x6007382")]
		[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0", Slot = "7")]
		public virtual bool ShouldSerializestory()
		{
			return default(bool);
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x00033588 File Offset: 0x00031788
		[Token(Token = "0x6007383")]
		[Address(RVA = "0x1FF9050", Offset = "0x1FF7C50", VA = "0x181FF9050", Slot = "8")]
		public virtual bool ShouldSerializeavg()
		{
			return default(bool);
		}

		// Token: 0x06007384 RID: 29572 RVA: 0x000335A0 File Offset: 0x000317A0
		[Token(Token = "0x6007384")]
		[Address(RVA = "0x1FF9020", Offset = "0x1FF7C20", VA = "0x181FF9020", Slot = "9")]
		public virtual bool ShouldSerializenews()
		{
			return default(bool);
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x000335B8 File Offset: 0x000317B8
		[Token(Token = "0x6007385")]
		[Address(RVA = "0x1FF9060", Offset = "0x1FF7C60", VA = "0x181FF9060", Slot = "10")]
		public virtual bool ShouldSerializelog()
		{
			return default(bool);
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x000335D0 File Offset: 0x000317D0
		[Token(Token = "0x6007386")]
		[Address(RVA = "0x1FF9030", Offset = "0x1FF7C30", VA = "0x181FF9030", Slot = "11")]
		public virtual bool ShouldSerializelandmark()
		{
			return default(bool);
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x000335E8 File Offset: 0x000317E8
		[Token(Token = "0x6007387")]
		[Address(RVA = "0x1FF9040", Offset = "0x1FF7C40", VA = "0x181FF9040", Slot = "12")]
		public virtual bool ShouldSerializechallengeBook()
		{
			return default(bool);
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007388")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveComponentData()
		{
		}

		// Token: 0x04006F8A RID: 28554
		[Token(Token = "0x4006F8A")]
		[FieldOffset(Offset = "0x10")]
		public ActArchiveTimelineData timeline;

		// Token: 0x04006F8B RID: 28555
		[Token(Token = "0x4006F8B")]
		[FieldOffset(Offset = "0x18")]
		public ActArchiveMusicData music;

		// Token: 0x04006F8C RID: 28556
		[Token(Token = "0x4006F8C")]
		[FieldOffset(Offset = "0x20")]
		public ActArchivePicData pic;

		// Token: 0x04006F8D RID: 28557
		[Token(Token = "0x4006F8D")]
		[FieldOffset(Offset = "0x28")]
		public ActArchiveStoryData story;

		// Token: 0x04006F8E RID: 28558
		[Token(Token = "0x4006F8E")]
		[FieldOffset(Offset = "0x30")]
		public ActArchiveAvgData avg;

		// Token: 0x04006F8F RID: 28559
		[Token(Token = "0x4006F8F")]
		[FieldOffset(Offset = "0x38")]
		public ActArchiveNewsData news;

		// Token: 0x04006F90 RID: 28560
		[Token(Token = "0x4006F90")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, ActArchiveLandmarkItemData> landmark;

		// Token: 0x04006F91 RID: 28561
		[Token(Token = "0x4006F91")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, ActArchiveChapterLogData> log;

		// Token: 0x04006F92 RID: 28562
		[Token(Token = "0x4006F92")]
		[FieldOffset(Offset = "0x50")]
		public ActArchiveChallengeBookData challengeBook;
	}
}
