using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000D5A RID: 3418
	[Token(Token = "0x2000D5A")]
	public class Act45SideData
	{
		// Token: 0x06006A2D RID: 27181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A2D")]
		[Address(RVA = "0x1FF69F0", Offset = "0x1FF55F0", VA = "0x181FF69F0")]
		public Act45SideData()
		{
		}

		// Token: 0x04004657 RID: 18007
		[Token(Token = "0x4004657")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, Act45SideData.Act45SideCharData> charData;

		// Token: 0x04004658 RID: 18008
		[Token(Token = "0x4004658")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, Act45SideData.Act45SideMailData> mailData;

		// Token: 0x04004659 RID: 18009
		[Token(Token = "0x4004659")]
		[FieldOffset(Offset = "0x20")]
		public Act45SideData.Act45SideConstData constData;

		// Token: 0x0400465A RID: 18010
		[Token(Token = "0x400465A")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act45SideData.Act45SideZoneAdditionData> zoneAdditionDataMap;

		// Token: 0x02000D5B RID: 3419
		[Token(Token = "0x2000D5B")]
		public class Act45SideCharData
		{
			// Token: 0x06006A2E RID: 27182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A2E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act45SideCharData()
			{
			}

			// Token: 0x0400465B RID: 18011
			[Token(Token = "0x400465B")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x0400465C RID: 18012
			[Token(Token = "0x400465C")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x0400465D RID: 18013
			[Token(Token = "0x400465D")]
			[FieldOffset(Offset = "0x20")]
			public string charIllustId;

			// Token: 0x0400465E RID: 18014
			[Token(Token = "0x400465E")]
			[FieldOffset(Offset = "0x28")]
			public string charCardId;

			// Token: 0x0400465F RID: 18015
			[Token(Token = "0x400465F")]
			[FieldOffset(Offset = "0x30")]
			public string charName;

			// Token: 0x04004660 RID: 18016
			[Token(Token = "0x4004660")]
			[FieldOffset(Offset = "0x38")]
			public string unlockStageId;
		}

		// Token: 0x02000D5C RID: 3420
		[Token(Token = "0x2000D5C")]
		public class Act45SideMailData
		{
			// Token: 0x06006A2F RID: 27183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A2F")]
			[Address(RVA = "0x1FF6B50", Offset = "0x1FF5750", VA = "0x181FF6B50")]
			public Act45SideMailData()
			{
			}

			// Token: 0x04004661 RID: 18017
			[Token(Token = "0x4004661")]
			[FieldOffset(Offset = "0x10")]
			public string mailId;

			// Token: 0x04004662 RID: 18018
			[Token(Token = "0x4004662")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004663 RID: 18019
			[Token(Token = "0x4004663")]
			[FieldOffset(Offset = "0x20")]
			public string charName;

			// Token: 0x04004664 RID: 18020
			[Token(Token = "0x4004664")]
			[FieldOffset(Offset = "0x28")]
			public string picId;

			// Token: 0x04004665 RID: 18021
			[Token(Token = "0x4004665")]
			[FieldOffset(Offset = "0x30")]
			public string mailTitle;

			// Token: 0x04004666 RID: 18022
			[Token(Token = "0x4004666")]
			[FieldOffset(Offset = "0x38")]
			public string mailContent;

			// Token: 0x04004667 RID: 18023
			[Token(Token = "0x4004667")]
			[FieldOffset(Offset = "0x40")]
			public long sendTime;

			// Token: 0x04004668 RID: 18024
			[Token(Token = "0x4004668")]
			[FieldOffset(Offset = "0x48")]
			public List<ItemBundle> rewards;
		}

		// Token: 0x02000D5D RID: 3421
		[Token(Token = "0x2000D5D")]
		public class Act45SideZoneAdditionData
		{
			// Token: 0x06006A30 RID: 27184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A30")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act45SideZoneAdditionData()
			{
			}

			// Token: 0x04004669 RID: 18025
			[Token(Token = "0x4004669")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x0400466A RID: 18026
			[Token(Token = "0x400466A")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;
		}

		// Token: 0x02000D5E RID: 3422
		[Token(Token = "0x2000D5E")]
		public class Act45SideConstData
		{
			// Token: 0x06006A31 RID: 27185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A31")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act45SideConstData()
			{
			}

			// Token: 0x0400466B RID: 18027
			[Token(Token = "0x400466B")]
			[FieldOffset(Offset = "0x10")]
			public string entryStageId;

			// Token: 0x0400466C RID: 18028
			[Token(Token = "0x400466C")]
			[FieldOffset(Offset = "0x18")]
			public string toastCharUnlock;

			// Token: 0x0400466D RID: 18029
			[Token(Token = "0x400466D")]
			[FieldOffset(Offset = "0x20")]
			public string toastLivePageUnlock;

			// Token: 0x0400466E RID: 18030
			[Token(Token = "0x400466E")]
			[FieldOffset(Offset = "0x28")]
			public string toastLivePageLocked;

			// Token: 0x0400466F RID: 18031
			[Token(Token = "0x400466F")]
			[FieldOffset(Offset = "0x30")]
			public string textCharLocked;

			// Token: 0x04004670 RID: 18032
			[Token(Token = "0x4004670")]
			[FieldOffset(Offset = "0x38")]
			public string textMailTime;

			// Token: 0x04004671 RID: 18033
			[Token(Token = "0x4004671")]
			[FieldOffset(Offset = "0x40")]
			public string textBtnMailTime;

			// Token: 0x04004672 RID: 18034
			[Token(Token = "0x4004672")]
			[FieldOffset(Offset = "0x48")]
			public string gameTVSizeMusicId;

			// Token: 0x04004673 RID: 18035
			[Token(Token = "0x4004673")]
			[FieldOffset(Offset = "0x50")]
			public string gameFullSizeMusicId;

			// Token: 0x04004674 RID: 18036
			[Token(Token = "0x4004674")]
			[FieldOffset(Offset = "0x58")]
			public string entryMusicId;
		}
	}
}
