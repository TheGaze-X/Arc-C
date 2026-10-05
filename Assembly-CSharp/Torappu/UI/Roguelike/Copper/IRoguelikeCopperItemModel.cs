using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.Copper
{
	// Token: 0x02005897 RID: 22679
	[Token(Token = "0x2005897")]
	public interface IRoguelikeCopperItemModel : IHotfixable, IComparable
	{
		// Token: 0x17004DA9 RID: 19881
		// (get) Token: 0x060211AA RID: 135594
		[Token(Token = "0x17004DA9")]
		string topicId { [Token(Token = "0x60211AA")] get; }

		// Token: 0x17004DAA RID: 19882
		// (get) Token: 0x060211AB RID: 135595
		[Token(Token = "0x17004DAA")]
		string itemId { [Token(Token = "0x60211AB")] get; }

		// Token: 0x17004DAB RID: 19883
		// (get) Token: 0x060211AC RID: 135596
		[Token(Token = "0x17004DAB")]
		string gildIconId { [Token(Token = "0x60211AC")] get; }

		// Token: 0x17004DAC RID: 19884
		// (get) Token: 0x060211AD RID: 135597
		[Token(Token = "0x17004DAC")]
		RoguelikeCopperLuckyLevel luckyLevel { [Token(Token = "0x60211AD")] get; }

		// Token: 0x17004DAD RID: 19885
		// (get) Token: 0x060211AE RID: 135598
		[Token(Token = "0x17004DAD")]
		int sortId { [Token(Token = "0x60211AE")] get; }

		// Token: 0x17004DAE RID: 19886
		// (get) Token: 0x060211AF RID: 135599
		[Token(Token = "0x17004DAE")]
		string desc { [Token(Token = "0x60211AF")] get; }

		// Token: 0x17004DAF RID: 19887
		// (get) Token: 0x060211B0 RID: 135600
		[Token(Token = "0x17004DAF")]
		string usage { [Token(Token = "0x60211B0")] get; }

		// Token: 0x17004DB0 RID: 19888
		// (get) Token: 0x060211B1 RID: 135601
		[Token(Token = "0x17004DB0")]
		string name { [Token(Token = "0x60211B1")] get; }
	}
}
