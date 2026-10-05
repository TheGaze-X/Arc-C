using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001C01 RID: 7169
	[Token(Token = "0x2001C01")]
	public interface IWorkshopSession
	{
		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x0600B2AC RID: 45740
		[Token(Token = "0x17001570")]
		string slotId { [Token(Token = "0x600B2AC")] get; }

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x0600B2AD RID: 45741
		[Token(Token = "0x17001571")]
		IBasicRoomModel basicRoomModel { [Token(Token = "0x600B2AD")] get; }

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x0600B2AE RID: 45742
		[Token(Token = "0x17001572")]
		IEnumerable<IWorkshopFormula> formulas { [Token(Token = "0x600B2AE")] get; }

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x0600B2AF RID: 45743
		// (set) Token: 0x0600B2B0 RID: 45744
		[Token(Token = "0x17001573")]
		IWorkshopFormula currentFormula { [Token(Token = "0x600B2AF")] get; [Token(Token = "0x600B2B0")] set; }

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x0600B2B1 RID: 45745
		[Token(Token = "0x17001574")]
		IWorkshopStationaryCharacter stationaryCharacter { [Token(Token = "0x600B2B1")] get; }

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x0600B2B2 RID: 45746
		[Token(Token = "0x17001575")]
		int extraOutcomeProbPercent { [Token(Token = "0x600B2B2")] get; }

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x0600B2B3 RID: 45747
		[Token(Token = "0x17001576")]
		float additionalExtraOutcomeProbPercent { [Token(Token = "0x600B2B3")] get; }

		// Token: 0x0600B2B4 RID: 45748
		[Token(Token = "0x600B2B4")]
		int MaxWorkCount(int curSelectCount, out MaxCountLimitReason limitReason);

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x0600B2B5 RID: 45749
		// (set) Token: 0x0600B2B6 RID: 45750
		[Token(Token = "0x17001577")]
		bool itemProtection { [Token(Token = "0x600B2B5")] get; [Token(Token = "0x600B2B6")] set; }

		// Token: 0x0600B2B7 RID: 45751
		[Token(Token = "0x600B2B7")]
		int GetMoodCostByCount(int count, out bool overload);

		// Token: 0x0600B2B8 RID: 45752
		[Token(Token = "0x600B2B8")]
		int GetGoldCostByCount(int count);

		// Token: 0x0600B2B9 RID: 45753
		[Token(Token = "0x600B2B9")]
		WorkshopCheckResult CheckAsFormula(IWorkshopFormula formula, int count, IWorkshopStationaryCharacter character);

		// Token: 0x0600B2BA RID: 45754
		[Token(Token = "0x600B2BA")]
		void WorkAsFormula(IWorkshopFormula formula, int count, IWorkshopStationaryCharacter character, Action<WorkResult> resultHandler);

		// Token: 0x0600B2BB RID: 45755
		[Token(Token = "0x600B2BB")]
		void ClearFormulaCache();

		// Token: 0x0600B2BC RID: 45756
		[Token(Token = "0x600B2BC")]
		void ClearTargetItemInfoAndRebuildTree();
	}
}
