using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011EC RID: 4588
	[Token(Token = "0x20011EC")]
	public class RoguelikeTopicBPGrandPrize
	{
		// Token: 0x06006FDA RID: 28634 RVA: 0x00032928 File Offset: 0x00030B28
		[Token(Token = "0x6006FDA")]
		[Address(RVA = "0x1FF9040", Offset = "0x1FF7C40", VA = "0x181FF9040")]
		public bool ShouldSerializeitemBundle()
		{
			return default(bool);
		}

		// Token: 0x06006FDB RID: 28635 RVA: 0x00032940 File Offset: 0x00030B40
		[Token(Token = "0x6006FDB")]
		[Address(RVA = "0x1FF9C40", Offset = "0x1FF8840", VA = "0x181FF9C40")]
		public bool ShouldSerializedetailAnnounceTime()
		{
			return default(bool);
		}

		// Token: 0x06006FDC RID: 28636 RVA: 0x00032958 File Offset: 0x00030B58
		[Token(Token = "0x6006FDC")]
		[Address(RVA = "0x2111A60", Offset = "0x2110660", VA = "0x182111A60")]
		public bool ShouldSerializepicIdAftrerUnlock()
		{
			return default(bool);
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FDD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicBPGrandPrize()
		{
		}

		// Token: 0x04006291 RID: 25233
		[Token(Token = "0x4006291")]
		[FieldOffset(Offset = "0x10")]
		public string grandPrizeDisplayId;

		// Token: 0x04006292 RID: 25234
		[Token(Token = "0x4006292")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04006293 RID: 25235
		[Token(Token = "0x4006293")]
		[FieldOffset(Offset = "0x1C")]
		public int displayUnlockYear;

		// Token: 0x04006294 RID: 25236
		[Token(Token = "0x4006294")]
		[FieldOffset(Offset = "0x20")]
		public int displayUnlockMonth;

		// Token: 0x04006295 RID: 25237
		[Token(Token = "0x4006295")]
		[FieldOffset(Offset = "0x28")]
		public string acquireTitle;

		// Token: 0x04006296 RID: 25238
		[Token(Token = "0x4006296")]
		[FieldOffset(Offset = "0x30")]
		public string purchaseTitle;

		// Token: 0x04006297 RID: 25239
		[Token(Token = "0x4006297")]
		[FieldOffset(Offset = "0x38")]
		public string displayName;

		// Token: 0x04006298 RID: 25240
		[Token(Token = "0x4006298")]
		[FieldOffset(Offset = "0x40")]
		public string displayDiscription;

		// Token: 0x04006299 RID: 25241
		[Token(Token = "0x4006299")]
		[FieldOffset(Offset = "0x48")]
		public string bpLevelId;

		// Token: 0x0400629A RID: 25242
		[Token(Token = "0x400629A")]
		[FieldOffset(Offset = "0x50")]
		public ItemBundle itemBundle;

		// Token: 0x0400629B RID: 25243
		[Token(Token = "0x400629B")]
		[FieldOffset(Offset = "0x58")]
		public string detailAnnounceTime;

		// Token: 0x0400629C RID: 25244
		[Token(Token = "0x400629C")]
		[FieldOffset(Offset = "0x60")]
		public string picIdAftrerUnlock;
	}
}
