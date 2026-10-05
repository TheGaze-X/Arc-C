using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.Fragment
{
	// Token: 0x020057F4 RID: 22516
	[Token(Token = "0x20057F4")]
	public interface IRoguelikeFragmentItemModel : IHotfixable, IComparable
	{
		// Token: 0x17004D47 RID: 19783
		// (get) Token: 0x06020EAE RID: 134830
		[Token(Token = "0x17004D47")]
		string instId { [Token(Token = "0x6020EAE")] get; }

		// Token: 0x17004D48 RID: 19784
		// (get) Token: 0x06020EAF RID: 134831
		[Token(Token = "0x17004D48")]
		RoguelikeFragmentType type { [Token(Token = "0x6020EAF")] get; }

		// Token: 0x17004D49 RID: 19785
		// (get) Token: 0x06020EB0 RID: 134832
		[Token(Token = "0x17004D49")]
		int weight { [Token(Token = "0x6020EB0")] get; }

		// Token: 0x17004D4A RID: 19786
		// (get) Token: 0x06020EB1 RID: 134833
		[Token(Token = "0x17004D4A")]
		int value { [Token(Token = "0x6020EB1")] get; }

		// Token: 0x17004D4B RID: 19787
		// (get) Token: 0x06020EB2 RID: 134834
		[Token(Token = "0x17004D4B")]
		string name { [Token(Token = "0x6020EB2")] get; }

		// Token: 0x17004D4C RID: 19788
		// (get) Token: 0x06020EB3 RID: 134835
		[Token(Token = "0x17004D4C")]
		string iconId { [Token(Token = "0x6020EB3")] get; }

		// Token: 0x17004D4D RID: 19789
		// (get) Token: 0x06020EB4 RID: 134836
		[Token(Token = "0x17004D4D")]
		string desc { [Token(Token = "0x6020EB4")] get; }

		// Token: 0x17004D4E RID: 19790
		// (get) Token: 0x06020EB5 RID: 134837
		[Token(Token = "0x17004D4E")]
		string usage { [Token(Token = "0x6020EB5")] get; }

		// Token: 0x17004D4F RID: 19791
		// (get) Token: 0x06020EB6 RID: 134838
		[Token(Token = "0x17004D4F")]
		bool isSelected { [Token(Token = "0x6020EB6")] get; }
	}
}
