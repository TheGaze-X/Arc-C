using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200540E RID: 21518
	[Token(Token = "0x200540E")]
	public class RoguelikeRewardItemViewModel
	{
		// Token: 0x0601FA7B RID: 129659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA7B")]
		[Address(RVA = "0x19594B0", Offset = "0x19580B0", VA = "0x1819594B0")]
		public RoguelikeRewardItemViewModel()
		{
		}

		// Token: 0x0402AAD2 RID: 174802
		[Token(Token = "0x402AAD2")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x0402AAD3 RID: 174803
		[Token(Token = "0x402AAD3")]
		[FieldOffset(Offset = "0x14")]
		public RoguelikeRewardShowType showType;

		// Token: 0x0402AAD4 RID: 174804
		[Token(Token = "0x402AAD4")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeSortItemViewStruct> rogueLikeItem;

		// Token: 0x0402AAD5 RID: 174805
		[Token(Token = "0x402AAD5")]
		[FieldOffset(Offset = "0x20")]
		public bool alreadyGetFlag;

		// Token: 0x0402AAD6 RID: 174806
		[Token(Token = "0x402AAD6")]
		[FieldOffset(Offset = "0x21")]
		public bool isExDrop;

		// Token: 0x0402AAD7 RID: 174807
		[Token(Token = "0x402AAD7")]
		[FieldOffset(Offset = "0x24")]
		public RogueLikeRewardItemExDropSrc exDropSrc;

		// Token: 0x0402AAD8 RID: 174808
		[Token(Token = "0x402AAD8")]
		[FieldOffset(Offset = "0x28")]
		public bool showReceiptBtn;

		// Token: 0x0402AAD9 RID: 174809
		[Token(Token = "0x402AAD9")]
		[FieldOffset(Offset = "0x29")]
		public bool showStoreInfo;
	}
}
