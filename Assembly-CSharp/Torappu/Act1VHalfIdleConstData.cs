using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C9E RID: 3230
	[Token(Token = "0x2000C9E")]
	public class Act1VHalfIdleConstData
	{
		// Token: 0x0600697A RID: 27002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600697A")]
		[Address(RVA = "0x1FF2D70", Offset = "0x1FF1970", VA = "0x181FF2D70")]
		public Act1VHalfIdleConstData()
		{
		}

		// Token: 0x040041DB RID: 16859
		[Token(Token = "0x40041DB")]
		[FieldOffset(Offset = "0x10")]
		public List<string> incomeProductionItems;

		// Token: 0x040041DC RID: 16860
		[Token(Token = "0x40041DC")]
		[FieldOffset(Offset = "0x18")]
		public string milestoneId;

		// Token: 0x040041DD RID: 16861
		[Token(Token = "0x40041DD")]
		[FieldOffset(Offset = "0x20")]
		public int[] discount;

		// Token: 0x040041DE RID: 16862
		[Token(Token = "0x40041DE")]
		[FieldOffset(Offset = "0x28")]
		public List<int> skillLevels;

		// Token: 0x040041DF RID: 16863
		[Token(Token = "0x40041DF")]
		[FieldOffset(Offset = "0x30")]
		public string levelExpItemId;

		// Token: 0x040041E0 RID: 16864
		[Token(Token = "0x40041E0")]
		[FieldOffset(Offset = "0x38")]
		public string skillExpItemId;

		// Token: 0x040041E1 RID: 16865
		[Token(Token = "0x40041E1")]
		[FieldOffset(Offset = "0x40")]
		public List<string> normalStageIds;

		// Token: 0x040041E2 RID: 16866
		[Token(Token = "0x40041E2")]
		[FieldOffset(Offset = "0x48")]
		public List<string> hardStageIds;

		// Token: 0x040041E3 RID: 16867
		[Token(Token = "0x40041E3")]
		[FieldOffset(Offset = "0x50")]
		public string techCostItemId;

		// Token: 0x040041E4 RID: 16868
		[Token(Token = "0x40041E4")]
		[FieldOffset(Offset = "0x58")]
		public int assistBaseNum;

		// Token: 0x040041E5 RID: 16869
		[Token(Token = "0x40041E5")]
		[FieldOffset(Offset = "0x60")]
		public List<Act1VHalfIdleEnemyPreloadMeta> preloadEnemy;

		// Token: 0x040041E6 RID: 16870
		[Token(Token = "0x40041E6")]
		[FieldOffset(Offset = "0x68")]
		public List<string> preloadTrap;

		// Token: 0x040041E7 RID: 16871
		[Token(Token = "0x40041E7")]
		[FieldOffset(Offset = "0x70")]
		public int defaultMaxDiscountSkillLevel;

		// Token: 0x040041E8 RID: 16872
		[Token(Token = "0x40041E8")]
		[FieldOffset(Offset = "0x74")]
		public int npcMaxDiscountSkillLevel;

		// Token: 0x040041E9 RID: 16873
		[Token(Token = "0x40041E9")]
		[FieldOffset(Offset = "0x78")]
		public List<string> forbiddenAssistCharIds;

		// Token: 0x040041EA RID: 16874
		[Token(Token = "0x40041EA")]
		[FieldOffset(Offset = "0x80")]
		public int maxEvolvePhase;

		// Token: 0x040041EB RID: 16875
		[Token(Token = "0x40041EB")]
		[FieldOffset(Offset = "0x84")]
		public int maxSafeEnemyDuration;

		// Token: 0x040041EC RID: 16876
		[Token(Token = "0x40041EC")]
		[FieldOffset(Offset = "0x88")]
		public int overloadLoseLifePoint;

		// Token: 0x040041ED RID: 16877
		[Token(Token = "0x40041ED")]
		[FieldOffset(Offset = "0x8C")]
		public int trapModifyBossTriggerTime;

		// Token: 0x040041EE RID: 16878
		[Token(Token = "0x40041EE")]
		[FieldOffset(Offset = "0x90")]
		public int normalEnemyOverloadCnt;

		// Token: 0x040041EF RID: 16879
		[Token(Token = "0x40041EF")]
		[FieldOffset(Offset = "0x94")]
		public int eliteEnemyOverloadCnt;

		// Token: 0x040041F0 RID: 16880
		[Token(Token = "0x40041F0")]
		[FieldOffset(Offset = "0x98")]
		public int bossEnemyOverloadCnt;

		// Token: 0x040041F1 RID: 16881
		[Token(Token = "0x40041F1")]
		[FieldOffset(Offset = "0x9C")]
		public int maxEquipNumInBag;

		// Token: 0x040041F2 RID: 16882
		[Token(Token = "0x40041F2")]
		[FieldOffset(Offset = "0xA0")]
		public string bossBranchName;

		// Token: 0x040041F3 RID: 16883
		[Token(Token = "0x40041F3")]
		[FieldOffset(Offset = "0xA8")]
		public string bossPreviewBranchName;

		// Token: 0x040041F4 RID: 16884
		[Token(Token = "0x40041F4")]
		[FieldOffset(Offset = "0xB0")]
		public List<string> enemyCapacityIdWhiteList;

		// Token: 0x040041F5 RID: 16885
		[Token(Token = "0x40041F5")]
		[FieldOffset(Offset = "0xB8")]
		public string unlockStageId;

		// Token: 0x040041F6 RID: 16886
		[Token(Token = "0x40041F6")]
		[FieldOffset(Offset = "0xC0")]
		public List<Act1VHalfIdleConstData.ProfessionDesc> professionDesc;

		// Token: 0x040041F7 RID: 16887
		[Token(Token = "0x40041F7")]
		[FieldOffset(Offset = "0xC8")]
		public ListDict<string, int> productMaxEfficiencyDict;

		// Token: 0x040041F8 RID: 16888
		[Token(Token = "0x40041F8")]
		[FieldOffset(Offset = "0xD0")]
		public int efficiencyDurationMax;

		// Token: 0x040041F9 RID: 16889
		[Token(Token = "0x40041F9")]
		[FieldOffset(Offset = "0xD4")]
		public int produceCd;

		// Token: 0x040041FA RID: 16890
		[Token(Token = "0x40041FA")]
		[FieldOffset(Offset = "0xD8")]
		public int harvestHintThresholdTime;

		// Token: 0x040041FB RID: 16891
		[Token(Token = "0x40041FB")]
		[FieldOffset(Offset = "0xE0")]
		public List<RuneTable.PackedRuneData> constRuneDatas;

		// Token: 0x040041FC RID: 16892
		[Token(Token = "0x40041FC")]
		[FieldOffset(Offset = "0xE8")]
		public string milestoneTrackId;

		// Token: 0x040041FD RID: 16893
		[Token(Token = "0x40041FD")]
		[FieldOffset(Offset = "0xF0")]
		public int maxDeckCardNum;

		// Token: 0x040041FE RID: 16894
		[Token(Token = "0x40041FE")]
		[FieldOffset(Offset = "0xF8")]
		public string tutorialStageId;

		// Token: 0x040041FF RID: 16895
		[Token(Token = "0x40041FF")]
		[FieldOffset(Offset = "0x100")]
		public List<string> predefinedPlotIds;

		// Token: 0x04004200 RID: 16896
		[Token(Token = "0x4004200")]
		[FieldOffset(Offset = "0x108")]
		public List<string> predefinedCharIds;

		// Token: 0x04004201 RID: 16897
		[Token(Token = "0x4004201")]
		[FieldOffset(Offset = "0x110")]
		public float enemyOverloadWarningRatio;

		// Token: 0x04004202 RID: 16898
		[Token(Token = "0x4004202")]
		[FieldOffset(Offset = "0x114")]
		public int battleFinishWarningTime;

		// Token: 0x04004203 RID: 16899
		[Token(Token = "0x4004203")]
		[FieldOffset(Offset = "0x118")]
		public int gachaNumMax;

		// Token: 0x04004204 RID: 16900
		[Token(Token = "0x4004204")]
		[FieldOffset(Offset = "0x120")]
		public string battleCustomTileHighlightColor;

		// Token: 0x04004205 RID: 16901
		[Token(Token = "0x4004205")]
		[FieldOffset(Offset = "0x128")]
		public string battleCustomTileEmissionColor;

		// Token: 0x04004206 RID: 16902
		[Token(Token = "0x4004206")]
		[FieldOffset(Offset = "0x130")]
		public List<string> battleEquipLevelColors;

		// Token: 0x04004207 RID: 16903
		[Token(Token = "0x4004207")]
		[FieldOffset(Offset = "0x138")]
		public List<string> battleFailHintStr;

		// Token: 0x04004208 RID: 16904
		[Token(Token = "0x4004208")]
		[FieldOffset(Offset = "0x140")]
		public int trapDropWeightStep;

		// Token: 0x04004209 RID: 16905
		[Token(Token = "0x4004209")]
		[FieldOffset(Offset = "0x148")]
		public List<string> unlockSpecialPlot;

		// Token: 0x0400420A RID: 16906
		[Token(Token = "0x400420A")]
		[FieldOffset(Offset = "0x150")]
		public string bossEnterBgmKey;

		// Token: 0x02000C9F RID: 3231
		[Token(Token = "0x2000C9F")]
		public class ProfessionDesc
		{
			// Token: 0x0600697B RID: 27003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600697B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ProfessionDesc()
			{
			}

			// Token: 0x0400420B RID: 16907
			[Token(Token = "0x400420B")]
			[FieldOffset(Offset = "0x10")]
			public ProfessionCategory profession;

			// Token: 0x0400420C RID: 16908
			[Token(Token = "0x400420C")]
			[FieldOffset(Offset = "0x18")]
			public string desc;
		}
	}
}
