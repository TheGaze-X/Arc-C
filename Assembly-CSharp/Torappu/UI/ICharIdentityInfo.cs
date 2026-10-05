using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003590 RID: 13712
	[Token(Token = "0x2003590")]
	public interface ICharIdentityInfo : ICharacterInfo, IHotfixable
	{
		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x06015CF1 RID: 89329
		[Token(Token = "0x170033F9")]
		int instId { [Token(Token = "0x6015CF1")] get; }

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x06015CF2 RID: 89330
		[Token(Token = "0x170033FA")]
		bool instAble { [Token(Token = "0x6015CF2")] get; }

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x06015CF3 RID: 89331
		[Token(Token = "0x170033FB")]
		string charId { [Token(Token = "0x6015CF3")] get; }

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x06015CF4 RID: 89332
		[Token(Token = "0x170033FC")]
		string tmplId { [Token(Token = "0x6015CF4")] get; }

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x06015CF5 RID: 89333
		[Token(Token = "0x170033FD")]
		int sortIndex { [Token(Token = "0x6015CF5")] get; }

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x06015CF6 RID: 89334
		[Token(Token = "0x170033FE")]
		string name { [Token(Token = "0x6015CF6")] get; }

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x06015CF7 RID: 89335
		[Token(Token = "0x170033FF")]
		RarityRank rarity { [Token(Token = "0x6015CF7")] get; }

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x06015CF8 RID: 89336
		[Token(Token = "0x17003400")]
		ProfessionCategory profession { [Token(Token = "0x6015CF8")] get; }

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x06015CF9 RID: 89337
		[Token(Token = "0x17003401")]
		EvolvePhase evolvePhase { [Token(Token = "0x6015CF9")] get; }

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x06015CFA RID: 89338
		[Token(Token = "0x17003402")]
		int level { [Token(Token = "0x6015CFA")] get; }

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x06015CFB RID: 89339
		[Token(Token = "0x17003403")]
		int potentialRank { [Token(Token = "0x6015CFB")] get; }

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x06015CFC RID: 89340
		[Token(Token = "0x17003404")]
		int favorPoint { [Token(Token = "0x6015CFC")] get; }
	}
}
