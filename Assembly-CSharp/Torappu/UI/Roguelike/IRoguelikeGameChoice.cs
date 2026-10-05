using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051BF RID: 20927
	[Token(Token = "0x20051BF")]
	public interface IRoguelikeGameChoice
	{
		// Token: 0x17004815 RID: 18453
		// (get) Token: 0x0601EE87 RID: 126599
		[Token(Token = "0x17004815")]
		RoguelikeGameChoiceData choiceData { [Token(Token = "0x601EE87")] get; }

		// Token: 0x17004816 RID: 18454
		// (get) Token: 0x0601EE88 RID: 126600
		[Token(Token = "0x17004816")]
		PlayerRoguelikePendingEvent.ChoiceAddition playerAdditionData { [Token(Token = "0x601EE88")] get; }

		// Token: 0x17004817 RID: 18455
		// (get) Token: 0x0601EE89 RID: 126601
		[Token(Token = "0x17004817")]
		string choiceTitle { [Token(Token = "0x601EE89")] get; }

		// Token: 0x17004818 RID: 18456
		// (get) Token: 0x0601EE8A RID: 126602
		[Token(Token = "0x17004818")]
		string choiceContent { [Token(Token = "0x601EE8A")] get; }

		// Token: 0x17004819 RID: 18457
		// (get) Token: 0x0601EE8B RID: 126603
		[Token(Token = "0x17004819")]
		string itemName { [Token(Token = "0x601EE8B")] get; }

		// Token: 0x1700481A RID: 18458
		// (get) Token: 0x0601EE8C RID: 126604
		[Token(Token = "0x1700481A")]
		string itemDesc { [Token(Token = "0x601EE8C")] get; }

		// Token: 0x1700481B RID: 18459
		// (get) Token: 0x0601EE8D RID: 126605
		[Token(Token = "0x1700481B")]
		string choiceHint { [Token(Token = "0x601EE8D")] get; }

		// Token: 0x1700481C RID: 18460
		// (get) Token: 0x0601EE8E RID: 126606
		[Token(Token = "0x1700481C")]
		string funcIconName { [Token(Token = "0x601EE8E")] get; }

		// Token: 0x1700481D RID: 18461
		// (get) Token: 0x0601EE8F RID: 126607
		[Token(Token = "0x1700481D")]
		string itemId { [Token(Token = "0x601EE8F")] get; }

		// Token: 0x1700481E RID: 18462
		// (get) Token: 0x0601EE90 RID: 126608
		[Token(Token = "0x1700481E")]
		RoguelikeGameItemType itemType { [Token(Token = "0x601EE90")] get; }

		// Token: 0x1700481F RID: 18463
		// (get) Token: 0x0601EE91 RID: 126609
		[Token(Token = "0x1700481F")]
		bool enabled { [Token(Token = "0x601EE91")] get; }

		// Token: 0x17004820 RID: 18464
		// (get) Token: 0x0601EE92 RID: 126610
		[Token(Token = "0x17004820")]
		bool isLeave { [Token(Token = "0x601EE92")] get; }

		// Token: 0x17004821 RID: 18465
		// (get) Token: 0x0601EE93 RID: 126611
		[Token(Token = "0x17004821")]
		RoguelikeChoiceLeftDecoType leftDecoType { [Token(Token = "0x601EE93")] get; }
	}
}
