using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200137E RID: 4990
	[Token(Token = "0x200137E")]
	[Serializable]
	public class StorylineStorySetData
	{
		// Token: 0x06007351 RID: 29521 RVA: 0x000333A8 File Offset: 0x000315A8
		[Token(Token = "0x6007351")]
		[Address(RVA = "0x1FFE4B0", Offset = "0x1FFD0B0", VA = "0x181FFE4B0")]
		public bool ShouldSerializekvImageId()
		{
			return default(bool);
		}

		// Token: 0x06007352 RID: 29522 RVA: 0x000333C0 File Offset: 0x000315C0
		[Token(Token = "0x6007352")]
		[Address(RVA = "0x1FFE4D0", Offset = "0x1FFD0D0", VA = "0x181FFE4D0")]
		public bool ShouldSerializetitleImageId()
		{
			return default(bool);
		}

		// Token: 0x06007353 RID: 29523 RVA: 0x000333D8 File Offset: 0x000315D8
		[Token(Token = "0x6007353")]
		[Address(RVA = "0x1FFA6F0", Offset = "0x1FF92F0", VA = "0x181FFA6F0")]
		public bool ShouldSerializebackgroundId()
		{
			return default(bool);
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x000333F0 File Offset: 0x000315F0
		[Token(Token = "0x6007354")]
		[Address(RVA = "0x2215950", Offset = "0x2214550", VA = "0x182215950")]
		public bool ShouldSerializecoreRewardType()
		{
			return default(bool);
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x00033408 File Offset: 0x00031608
		[Token(Token = "0x6007355")]
		[Address(RVA = "0x1FF9C40", Offset = "0x1FF8840", VA = "0x181FF9C40")]
		public bool ShouldSerializecoreRewardId()
		{
			return default(bool);
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x00033420 File Offset: 0x00031620
		[Token(Token = "0x6007356")]
		[Address(RVA = "0x2111A60", Offset = "0x2110660", VA = "0x182111A60")]
		public bool ShouldSerializerelevantActivityId()
		{
			return default(bool);
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x00033438 File Offset: 0x00031638
		[Token(Token = "0x6007357")]
		[Address(RVA = "0x2215960", Offset = "0x2214560", VA = "0x182215960")]
		public bool ShouldSerializemainlineData()
		{
			return default(bool);
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x00033450 File Offset: 0x00031650
		[Token(Token = "0x6007358")]
		[Address(RVA = "0x2215970", Offset = "0x2214570", VA = "0x182215970")]
		public bool ShouldSerializessData()
		{
			return default(bool);
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x00033468 File Offset: 0x00031668
		[Token(Token = "0x6007359")]
		[Address(RVA = "0x2215940", Offset = "0x2214540", VA = "0x182215940")]
		public bool ShouldSerializecollectData()
		{
			return default(bool);
		}

		// Token: 0x0600735A RID: 29530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600735A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StorylineStorySetData()
		{
		}

		// Token: 0x04006EB6 RID: 28342
		[Token(Token = "0x4006EB6")]
		[FieldOffset(Offset = "0x10")]
		public string storySetId;

		// Token: 0x04006EB7 RID: 28343
		[Token(Token = "0x4006EB7")]
		[FieldOffset(Offset = "0x18")]
		public StorylineStorySetType storySetType;

		// Token: 0x04006EB8 RID: 28344
		[Token(Token = "0x4006EB8")]
		[FieldOffset(Offset = "0x1C")]
		public int sortByYear;

		// Token: 0x04006EB9 RID: 28345
		[Token(Token = "0x4006EB9")]
		[FieldOffset(Offset = "0x20")]
		public int sortWithinYear;

		// Token: 0x04006EBA RID: 28346
		[Token(Token = "0x4006EBA")]
		[FieldOffset(Offset = "0x28")]
		public string kvImageId;

		// Token: 0x04006EBB RID: 28347
		[Token(Token = "0x4006EBB")]
		[FieldOffset(Offset = "0x30")]
		public string titleImageId;

		// Token: 0x04006EBC RID: 28348
		[Token(Token = "0x4006EBC")]
		[FieldOffset(Offset = "0x38")]
		public bool haveVideoToPlay;

		// Token: 0x04006EBD RID: 28349
		[Token(Token = "0x4006EBD")]
		[FieldOffset(Offset = "0x40")]
		public string backgroundId;

		// Token: 0x04006EBE RID: 28350
		[Token(Token = "0x4006EBE")]
		[FieldOffset(Offset = "0x48")]
		public string gameMusicId;

		// Token: 0x04006EBF RID: 28351
		[Token(Token = "0x4006EBF")]
		[FieldOffset(Offset = "0x50")]
		public ItemType coreRewardType;

		// Token: 0x04006EC0 RID: 28352
		[Token(Token = "0x4006EC0")]
		[FieldOffset(Offset = "0x58")]
		public string coreRewardId;

		// Token: 0x04006EC1 RID: 28353
		[Token(Token = "0x4006EC1")]
		[FieldOffset(Offset = "0x60")]
		public string relevantActivityId;

		// Token: 0x04006EC2 RID: 28354
		[Token(Token = "0x4006EC2")]
		[FieldOffset(Offset = "0x68")]
		public StorylineMainlineData mainlineData;

		// Token: 0x04006EC3 RID: 28355
		[Token(Token = "0x4006EC3")]
		[FieldOffset(Offset = "0x70")]
		public StorylineSSData ssData;

		// Token: 0x04006EC4 RID: 28356
		[Token(Token = "0x4006EC4")]
		[FieldOffset(Offset = "0x78")]
		public StorylineCollectData collectData;
	}
}
