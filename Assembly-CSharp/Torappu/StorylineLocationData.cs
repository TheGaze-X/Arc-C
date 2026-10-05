using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200137B RID: 4987
	[Token(Token = "0x200137B")]
	[Serializable]
	public class StorylineLocationData
	{
		// Token: 0x0600734B RID: 29515 RVA: 0x00033348 File Offset: 0x00031548
		[Token(Token = "0x600734B")]
		[Address(RVA = "0x1FFE4B0", Offset = "0x1FFD0B0", VA = "0x181FFE4B0")]
		public bool ShouldSerializepresentStageId()
		{
			return default(bool);
		}

		// Token: 0x0600734C RID: 29516 RVA: 0x00033360 File Offset: 0x00031560
		[Token(Token = "0x600734C")]
		[Address(RVA = "0x1FFE4D0", Offset = "0x1FFD0D0", VA = "0x181FFE4D0")]
		public bool ShouldSerializeunlockStageId()
		{
			return default(bool);
		}

		// Token: 0x0600734D RID: 29517 RVA: 0x00033378 File Offset: 0x00031578
		[Token(Token = "0x600734D")]
		[Address(RVA = "0x1FF9BF0", Offset = "0x1FF87F0", VA = "0x181FF9BF0")]
		public bool ShouldSerializerelevantStorySetId()
		{
			return default(bool);
		}

		// Token: 0x0600734E RID: 29518 RVA: 0x00033390 File Offset: 0x00031590
		[Token(Token = "0x600734E")]
		[Address(RVA = "0x1FF9030", Offset = "0x1FF7C30", VA = "0x181FF9030")]
		public bool ShouldSerializemainlineSplitData()
		{
			return default(bool);
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StorylineLocationData()
		{
		}

		// Token: 0x04006EA8 RID: 28328
		[Token(Token = "0x4006EA8")]
		[FieldOffset(Offset = "0x10")]
		public string locationId;

		// Token: 0x04006EA9 RID: 28329
		[Token(Token = "0x4006EA9")]
		[FieldOffset(Offset = "0x18")]
		public StorylineLocationType locationType;

		// Token: 0x04006EAA RID: 28330
		[Token(Token = "0x4006EAA")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x04006EAB RID: 28331
		[Token(Token = "0x4006EAB")]
		[FieldOffset(Offset = "0x20")]
		public long startTime;

		// Token: 0x04006EAC RID: 28332
		[Token(Token = "0x4006EAC")]
		[FieldOffset(Offset = "0x28")]
		public string presentStageId;

		// Token: 0x04006EAD RID: 28333
		[Token(Token = "0x4006EAD")]
		[FieldOffset(Offset = "0x30")]
		public string unlockStageId;

		// Token: 0x04006EAE RID: 28334
		[Token(Token = "0x4006EAE")]
		[FieldOffset(Offset = "0x38")]
		public string relevantStorySetId;

		// Token: 0x04006EAF RID: 28335
		[Token(Token = "0x4006EAF")]
		[FieldOffset(Offset = "0x40")]
		public StorylineMainlineSplitData mainlineSplitData;
	}
}
