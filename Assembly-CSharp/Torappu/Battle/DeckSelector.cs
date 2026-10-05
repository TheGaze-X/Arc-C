using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020021ED RID: 8685
	[Token(Token = "0x20021ED")]
	[Serializable]
	public struct DeckSelector : IDeckSelector
	{
		// Token: 0x0600D952 RID: 55634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D952")]
		[Address(RVA = "0x35E0F10", Offset = "0x35DFB10", VA = "0x1835E0F10")]
		public DeckSelector(ProfessionCategory categoryMask, string filterTag, string subprofessionTag, bool onlySelectMe, bool excludeMe, List<string> mapTags, bool enableOverride, bool excludeNotInHand, bool excludeNotShowInCardList, bool excludeHiddenByCardState)
		{
		}

		// Token: 0x0600D953 RID: 55635 RVA: 0x0004EEA0 File Offset: 0x0004D0A0
		[Token(Token = "0x600D953")]
		[Address(RVA = "0x35E0D30", Offset = "0x35DF930", VA = "0x1835E0D30", Slot = "4")]
		public bool Verify(Deck.Card candidateCard, Deck.Card sourceCard)
		{
			return default(bool);
		}

		// Token: 0x0400EA50 RID: 59984
		[Token(Token = "0x400EA50")]
		[FieldOffset(Offset = "0x0")]
		[Enum(true, EnumDisplay.Checkbox)]
		public ProfessionCategory categoryMask;

		// Token: 0x0400EA51 RID: 59985
		[Token(Token = "0x400EA51")]
		[FieldOffset(Offset = "0x8")]
		public string filterTag;

		// Token: 0x0400EA52 RID: 59986
		[Token(Token = "0x400EA52")]
		[FieldOffset(Offset = "0x10")]
		public string subprofessionTag;

		// Token: 0x0400EA53 RID: 59987
		[Token(Token = "0x400EA53")]
		[FieldOffset(Offset = "0x18")]
		public bool onlySelectMe;

		// Token: 0x0400EA54 RID: 59988
		[Token(Token = "0x400EA54")]
		[FieldOffset(Offset = "0x19")]
		public bool excludeMe;

		// Token: 0x0400EA55 RID: 59989
		[Token(Token = "0x400EA55")]
		[FieldOffset(Offset = "0x20")]
		public string[] mapTags;

		// Token: 0x0400EA56 RID: 59990
		[Token(Token = "0x400EA56")]
		[FieldOffset(Offset = "0x28")]
		public bool enableOverride;

		// Token: 0x0400EA57 RID: 59991
		[Token(Token = "0x400EA57")]
		[FieldOffset(Offset = "0x29")]
		public bool excludeNotInHand;

		// Token: 0x0400EA58 RID: 59992
		[Token(Token = "0x400EA58")]
		[FieldOffset(Offset = "0x2A")]
		public bool excludeNotShowInCardList;

		// Token: 0x0400EA59 RID: 59993
		[Token(Token = "0x400EA59")]
		[FieldOffset(Offset = "0x2B")]
		public bool excludeHiddenByCardState;
	}
}
