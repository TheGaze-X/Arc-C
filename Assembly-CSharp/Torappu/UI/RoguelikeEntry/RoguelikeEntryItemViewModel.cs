using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeEntry
{
	// Token: 0x02004470 RID: 17520
	[Token(Token = "0x2004470")]
	public class RoguelikeEntryItemViewModel : IComparable, IHotfixable
	{
		// Token: 0x0601AC7F RID: 109695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC7F")]
		[Address(RVA = "0x13EDBA0", Offset = "0x13EC7A0", VA = "0x1813EDBA0")]
		public RoguelikeEntryItemViewModel()
		{
		}

		// Token: 0x0601AC80 RID: 109696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC80")]
		[Address(RVA = "0x13EDA40", Offset = "0x13EC640", VA = "0x1813EDA40")]
		public RoguelikeEntryItemViewModel(RoguelikeTopicBasicData basicData, long currTs)
		{
		}

		// Token: 0x0601AC81 RID: 109697 RVA: 0x000A3500 File Offset: 0x000A1700
		[Token(Token = "0x601AC81")]
		[Address(RVA = "0x13ED950", Offset = "0x13EC550", VA = "0x1813ED950", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x040223D6 RID: 140246
		[Token(Token = "0x40223D6")]
		[FieldOffset(Offset = "0x10")]
		public bool isEmpty;

		// Token: 0x040223D7 RID: 140247
		[Token(Token = "0x40223D7")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x040223D8 RID: 140248
		[Token(Token = "0x40223D8")]
		[FieldOffset(Offset = "0x20")]
		public string bpName;

		// Token: 0x040223D9 RID: 140249
		[Token(Token = "0x40223D9")]
		[FieldOffset(Offset = "0x28")]
		public int bpLevel;

		// Token: 0x040223DA RID: 140250
		[Token(Token = "0x40223DA")]
		[FieldOffset(Offset = "0x2C")]
		public bool isBpMax;

		// Token: 0x040223DB RID: 140251
		[Token(Token = "0x40223DB")]
		[FieldOffset(Offset = "0x2D")]
		public bool isFullStored;

		// Token: 0x040223DC RID: 140252
		[Token(Token = "0x40223DC")]
		[FieldOffset(Offset = "0x2E")]
		public bool isInDLCAct;

		// Token: 0x040223DD RID: 140253
		[Token(Token = "0x40223DD")]
		[FieldOffset(Offset = "0x2F")]
		public bool isInReviewAct;

		// Token: 0x040223DE RID: 140254
		[Token(Token = "0x40223DE")]
		[FieldOffset(Offset = "0x30")]
		public bool isPinActive;

		// Token: 0x040223DF RID: 140255
		[Token(Token = "0x40223DF")]
		[FieldOffset(Offset = "0x38")]
		public string description;

		// Token: 0x040223E0 RID: 140256
		[Token(Token = "0x40223E0")]
		[FieldOffset(Offset = "0x40")]
		public bool isOnBattle;

		// Token: 0x040223E1 RID: 140257
		[Token(Token = "0x40223E1")]
		[FieldOffset(Offset = "0x41")]
		public bool isEntryAccess;

		// Token: 0x040223E2 RID: 140258
		[Token(Token = "0x40223E2")]
		[FieldOffset(Offset = "0x48")]
		public string mainMedalId;

		// Token: 0x040223E3 RID: 140259
		[Token(Token = "0x40223E3")]
		[FieldOffset(Offset = "0x50")]
		public bool isMedalCollected;

		// Token: 0x040223E4 RID: 140260
		[Token(Token = "0x40223E4")]
		[FieldOffset(Offset = "0x51")]
		public bool showDLCUpdateTag;

		// Token: 0x040223E5 RID: 140261
		[Token(Token = "0x40223E5")]
		[FieldOffset(Offset = "0x52")]
		public bool showReviewUpdateTag;

		// Token: 0x040223E6 RID: 140262
		[Token(Token = "0x40223E6")]
		[FieldOffset(Offset = "0x58")]
		public long startTs;

		// Token: 0x040223E7 RID: 140263
		[Token(Token = "0x40223E7")]
		[FieldOffset(Offset = "0x60")]
		public int sortId;

		// Token: 0x040223E8 RID: 140264
		[Token(Token = "0x40223E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040223E9 RID: 140265
		[Token(Token = "0x40223E9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x040223EA RID: 140266
		[Token(Token = "0x40223EA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CompareTo;
	}
}
