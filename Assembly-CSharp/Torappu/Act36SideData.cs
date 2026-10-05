using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000D1F RID: 3359
	[Token(Token = "0x2000D1F")]
	public class Act36SideData
	{
		// Token: 0x060069F8 RID: 27128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F8")]
		[Address(RVA = "0x1FF58A0", Offset = "0x1FF44A0", VA = "0x181FF58A0")]
		public Act36SideData()
		{
		}

		// Token: 0x0400451A RID: 17690
		[Token(Token = "0x400451A")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act36SideData.Act36SideZoneAdditionData> zoneAdditionData;

		// Token: 0x0400451B RID: 17691
		[Token(Token = "0x400451B")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act36SideData.Act36SideEnemyHandbookData> enemyHandbookData;

		// Token: 0x0400451C RID: 17692
		[Token(Token = "0x400451C")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act36SideData.Act36SideTokenHandbookData> tokenHandbookData;

		// Token: 0x0400451D RID: 17693
		[Token(Token = "0x400451D")]
		[FieldOffset(Offset = "0x28")]
		public Act36SideData.Act36SideConstData constData;

		// Token: 0x02000D20 RID: 3360
		[Token(Token = "0x2000D20")]
		public class Act36SideZoneAdditionData
		{
			// Token: 0x060069F9 RID: 27129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069F9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act36SideZoneAdditionData()
			{
			}

			// Token: 0x0400451E RID: 17694
			[Token(Token = "0x400451E")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x0400451F RID: 17695
			[Token(Token = "0x400451F")]
			[FieldOffset(Offset = "0x18")]
			public string zoneIconId;

			// Token: 0x04004520 RID: 17696
			[Token(Token = "0x4004520")]
			[FieldOffset(Offset = "0x20")]
			public string unlockText;

			// Token: 0x04004521 RID: 17697
			[Token(Token = "0x4004521")]
			[FieldOffset(Offset = "0x28")]
			public long displayTime;
		}

		// Token: 0x02000D21 RID: 3361
		[Token(Token = "0x2000D21")]
		public class Act36SideEnemyHandbookData
		{
			// Token: 0x060069FA RID: 27130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069FA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act36SideEnemyHandbookData()
			{
			}

			// Token: 0x04004522 RID: 17698
			[Token(Token = "0x4004522")]
			[FieldOffset(Offset = "0x10")]
			public string enemyHandbookId;

			// Token: 0x04004523 RID: 17699
			[Token(Token = "0x4004523")]
			[FieldOffset(Offset = "0x18")]
			public string spriteId;

			// Token: 0x04004524 RID: 17700
			[Token(Token = "0x4004524")]
			[FieldOffset(Offset = "0x20")]
			public int sortId;

			// Token: 0x04004525 RID: 17701
			[Token(Token = "0x4004525")]
			[FieldOffset(Offset = "0x28")]
			public string foodTypeId;

			// Token: 0x04004526 RID: 17702
			[Token(Token = "0x4004526")]
			[FieldOffset(Offset = "0x30")]
			public string foodAmountId;
		}

		// Token: 0x02000D22 RID: 3362
		[Token(Token = "0x2000D22")]
		public class Act36SideTokenHandbookData
		{
			// Token: 0x060069FB RID: 27131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069FB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act36SideTokenHandbookData()
			{
			}

			// Token: 0x04004527 RID: 17703
			[Token(Token = "0x4004527")]
			[FieldOffset(Offset = "0x10")]
			public string tokenHandbookId;

			// Token: 0x04004528 RID: 17704
			[Token(Token = "0x4004528")]
			[FieldOffset(Offset = "0x18")]
			public string spriteId;

			// Token: 0x04004529 RID: 17705
			[Token(Token = "0x4004529")]
			[FieldOffset(Offset = "0x20")]
			public int sortId;

			// Token: 0x0400452A RID: 17706
			[Token(Token = "0x400452A")]
			[FieldOffset(Offset = "0x28")]
			public string tokenAbility;

			// Token: 0x0400452B RID: 17707
			[Token(Token = "0x400452B")]
			[FieldOffset(Offset = "0x30")]
			public string tokenDescrption;
		}

		// Token: 0x02000D23 RID: 3363
		[Token(Token = "0x2000D23")]
		public class Act36SideConstData
		{
			// Token: 0x060069FC RID: 27132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069FC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act36SideConstData()
			{
			}

			// Token: 0x0400452C RID: 17708
			[Token(Token = "0x400452C")]
			[FieldOffset(Offset = "0x10")]
			public string rewardFailed;

			// Token: 0x0400452D RID: 17709
			[Token(Token = "0x400452D")]
			[FieldOffset(Offset = "0x18")]
			public int rewardReceiveNumber;
		}
	}
}
