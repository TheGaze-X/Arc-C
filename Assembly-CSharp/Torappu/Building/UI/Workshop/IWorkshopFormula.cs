using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BFE RID: 7166
	[Token(Token = "0x2001BFE")]
	public interface IWorkshopFormula
	{
		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x0600B297 RID: 45719
		[Token(Token = "0x1700155B")]
		int id { [Token(Token = "0x600B297")] get; }

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x0600B298 RID: 45720
		[Token(Token = "0x1700155C")]
		IFormulaItem outcome { [Token(Token = "0x600B298")] get; }

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x0600B299 RID: 45721
		[Token(Token = "0x1700155D")]
		IFormulaItem ingredient1 { [Token(Token = "0x600B299")] get; }

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x0600B29A RID: 45722
		[Token(Token = "0x1700155E")]
		IFormulaItem ingredient2 { [Token(Token = "0x600B29A")] get; }

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x0600B29B RID: 45723
		[Token(Token = "0x1700155F")]
		IFormulaItem ingredient3 { [Token(Token = "0x600B29B")] get; }

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x0600B29C RID: 45724
		[Token(Token = "0x17001560")]
		int costGoldCount { [Token(Token = "0x600B29C")] get; }

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x0600B29D RID: 45725
		[Token(Token = "0x17001561")]
		bool canBeProtected { [Token(Token = "0x600B29D")] get; }

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x0600B29E RID: 45726
		[Token(Token = "0x17001562")]
		int filterIndex { [Token(Token = "0x600B29E")] get; }

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x0600B29F RID: 45727
		[Token(Token = "0x17001563")]
		bool unlocked { [Token(Token = "0x600B29F")] get; }

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x0600B2A0 RID: 45728
		[Token(Token = "0x17001564")]
		string unlockMessage { [Token(Token = "0x600B2A0")] get; }

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x0600B2A1 RID: 45729
		[Token(Token = "0x17001565")]
		int apCost { [Token(Token = "0x600B2A1")] get; }

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x0600B2A2 RID: 45730
		[Token(Token = "0x17001566")]
		int sortId { [Token(Token = "0x600B2A2")] get; }
	}
}
