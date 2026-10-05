using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C49 RID: 3145
	[Token(Token = "0x2000C49")]
	public class ActArchiveTimelineItemData
	{
		// Token: 0x06006929 RID: 26921 RVA: 0x00030C00 File Offset: 0x0002EE00
		[Token(Token = "0x6006929")]
		[Address(RVA = "0x1FF9050", Offset = "0x1FF7C50", VA = "0x181FF9050", Slot = "4")]
		public virtual bool ShouldSerializepicIdList()
		{
			return default(bool);
		}

		// Token: 0x0600692A RID: 26922 RVA: 0x00030C18 File Offset: 0x0002EE18
		[Token(Token = "0x600692A")]
		[Address(RVA = "0x1FF9020", Offset = "0x1FF7C20", VA = "0x181FF9020", Slot = "5")]
		public virtual bool ShouldSerializeaudioIdList()
		{
			return default(bool);
		}

		// Token: 0x0600692B RID: 26923 RVA: 0x00030C30 File Offset: 0x0002EE30
		[Token(Token = "0x600692B")]
		[Address(RVA = "0x1FF9030", Offset = "0x1FF7C30", VA = "0x181FF9030", Slot = "6")]
		public virtual bool ShouldSerializeavgIdList()
		{
			return default(bool);
		}

		// Token: 0x0600692C RID: 26924 RVA: 0x00030C48 File Offset: 0x0002EE48
		[Token(Token = "0x600692C")]
		[Address(RVA = "0x1FF9060", Offset = "0x1FF7C60", VA = "0x181FF9060", Slot = "7")]
		public virtual bool ShouldSerializestoryIdList()
		{
			return default(bool);
		}

		// Token: 0x0600692D RID: 26925 RVA: 0x00030C60 File Offset: 0x0002EE60
		[Token(Token = "0x600692D")]
		[Address(RVA = "0x1FF9040", Offset = "0x1FF7C40", VA = "0x181FF9040", Slot = "8")]
		public virtual bool ShouldSerializenewsIdList()
		{
			return default(bool);
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600692E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveTimelineItemData()
		{
		}

		// Token: 0x0400401A RID: 16410
		[Token(Token = "0x400401A")]
		[FieldOffset(Offset = "0x10")]
		public string timelineId;

		// Token: 0x0400401B RID: 16411
		[Token(Token = "0x400401B")]
		[FieldOffset(Offset = "0x18")]
		public int timelineSortId;

		// Token: 0x0400401C RID: 16412
		[Token(Token = "0x400401C")]
		[FieldOffset(Offset = "0x20")]
		public string timelineTitle;

		// Token: 0x0400401D RID: 16413
		[Token(Token = "0x400401D")]
		[FieldOffset(Offset = "0x28")]
		public string timelineDes;

		// Token: 0x0400401E RID: 16414
		[Token(Token = "0x400401E")]
		[FieldOffset(Offset = "0x30")]
		public List<string> picIdList;

		// Token: 0x0400401F RID: 16415
		[Token(Token = "0x400401F")]
		[FieldOffset(Offset = "0x38")]
		public List<string> audioIdList;

		// Token: 0x04004020 RID: 16416
		[Token(Token = "0x4004020")]
		[FieldOffset(Offset = "0x40")]
		public List<string> avgIdList;

		// Token: 0x04004021 RID: 16417
		[Token(Token = "0x4004021")]
		[FieldOffset(Offset = "0x48")]
		public List<string> storyIdList;

		// Token: 0x04004022 RID: 16418
		[Token(Token = "0x4004022")]
		[FieldOffset(Offset = "0x50")]
		public List<string> newsIdList;
	}
}
