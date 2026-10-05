using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005462 RID: 21602
	[Token(Token = "0x2005462")]
	public interface IRoguelikeSacrifice
	{
		// Token: 0x17004A84 RID: 19076
		// (get) Token: 0x0601FCBF RID: 130239
		[Token(Token = "0x17004A84")]
		string topicId { [Token(Token = "0x601FCBF")] get; }

		// Token: 0x17004A85 RID: 19077
		// (get) Token: 0x0601FCC0 RID: 130240
		[Token(Token = "0x17004A85")]
		RoguelikeGameItemType itemType { [Token(Token = "0x601FCC0")] get; }

		// Token: 0x17004A86 RID: 19078
		// (get) Token: 0x0601FCC1 RID: 130241
		[Token(Token = "0x17004A86")]
		string itemId { [Token(Token = "0x601FCC1")] get; }

		// Token: 0x17004A87 RID: 19079
		// (get) Token: 0x0601FCC2 RID: 130242
		[Token(Token = "0x17004A87")]
		string instId { [Token(Token = "0x601FCC2")] get; }

		// Token: 0x17004A88 RID: 19080
		// (get) Token: 0x0601FCC3 RID: 130243
		[Token(Token = "0x17004A88")]
		long ts { [Token(Token = "0x601FCC3")] get; }

		// Token: 0x17004A89 RID: 19081
		// (get) Token: 0x0601FCC4 RID: 130244
		[Token(Token = "0x17004A89")]
		string name { [Token(Token = "0x601FCC4")] get; }

		// Token: 0x17004A8A RID: 19082
		// (get) Token: 0x0601FCC5 RID: 130245
		[Token(Token = "0x17004A8A")]
		string usage { [Token(Token = "0x601FCC5")] get; }
	}
}
