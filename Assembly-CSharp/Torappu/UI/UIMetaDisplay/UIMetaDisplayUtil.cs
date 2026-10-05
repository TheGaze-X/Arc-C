using System;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.UI.UIMetaDisplay
{
	// Token: 0x02005A46 RID: 23110
	[Token(Token = "0x2005A46")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class UIMetaDisplayUtil
	{
		// Token: 0x06021A53 RID: 137811 RVA: 0x000BAFC0 File Offset: 0x000B91C0
		[Token(Token = "0x6021A53")]
		[Address(RVA = "0x1C2E230", Offset = "0x1C2CE30", VA = "0x181C2E230")]
		private static bool _CheckRandomRate(float percent)
		{
			return default(bool);
		}

		// Token: 0x06021A54 RID: 137812 RVA: 0x000BAFD8 File Offset: 0x000B91D8
		[Token(Token = "0x6021A54")]
		[Address(RVA = "0x1C2D540", Offset = "0x1C2C140", VA = "0x181C2D540")]
		public static bool CheckCommonAvail(CommonAvailCheck availCheck, long currentTs)
		{
			return default(bool);
		}

		// Token: 0x06021A55 RID: 137813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021A55")]
		[Address(RVA = "0x1C2E0C0", Offset = "0x1C2CCC0", VA = "0x181C2E0C0")]
		public static TipsMetaDisplayItem GetTipsMetaDisplayItem(string stageId)
		{
			return null;
		}

		// Token: 0x06021A56 RID: 137814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021A56")]
		[Address(RVA = "0x1C2DB40", Offset = "0x1C2C740", VA = "0x181C2DB40")]
		public static BattleLoadingDisplayMetaItem GetBattleLoadingItem(string stageId)
		{
			return null;
		}

		// Token: 0x06021A57 RID: 137815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021A57")]
		[Address(RVA = "0x1C2DF50", Offset = "0x1C2CB50", VA = "0x181C2DF50")]
		public static MapPreviewDisplayMetaItem GetMapPreviewDisplayItem(string zoneId, string stageId)
		{
			return null;
		}

		// Token: 0x06021A58 RID: 137816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021A58")]
		[Address(RVA = "0x1C2DDE0", Offset = "0x1C2C9E0", VA = "0x181C2DDE0")]
		public static FlashAlertAfterStageDisplayMetaItem GetFlashAlertItem(string stageId)
		{
			return null;
		}

		// Token: 0x06021A59 RID: 137817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021A59")]
		[Address(RVA = "0x1C2DCB0", Offset = "0x1C2C8B0", VA = "0x181C2DCB0")]
		public static FlashAlertAfterStageDisplayMetaItem GetFlashAlertItemById(string flashAlertId)
		{
			return null;
		}

		// Token: 0x06021A5A RID: 137818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021A5A")]
		[Address(RVA = "0x1C2D9B0", Offset = "0x1C2C5B0", VA = "0x181C2D9B0")]
		public static BattleFinishDisplayMetaItem GetBattleFinishDisplayMetaItem(string stageId)
		{
			return null;
		}

		// Token: 0x06021A5B RID: 137819 RVA: 0x000BAFF0 File Offset: 0x000B91F0
		[Token(Token = "0x6021A5B")]
		[Address(RVA = "0x1C2D700", Offset = "0x1C2C300", VA = "0x181C2D700")]
		public static DisplayMeta GenDisplayMetaInfo(SquadPage.Params param)
		{
			return default(DisplayMeta);
		}

		// Token: 0x0402E011 RID: 188433
		[Token(Token = "0x402E011")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CheckRandomRate;

		// Token: 0x0402E012 RID: 188434
		[Token(Token = "0x402E012")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckCommonAvail;

		// Token: 0x0402E013 RID: 188435
		[Token(Token = "0x402E013")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTipsMetaDisplayItem;

		// Token: 0x0402E014 RID: 188436
		[Token(Token = "0x402E014")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBattleLoadingItem;

		// Token: 0x0402E015 RID: 188437
		[Token(Token = "0x402E015")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetMapPreviewDisplayItem;

		// Token: 0x0402E016 RID: 188438
		[Token(Token = "0x402E016")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetFlashAlertItem;

		// Token: 0x0402E017 RID: 188439
		[Token(Token = "0x402E017")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetFlashAlertItemById;

		// Token: 0x0402E018 RID: 188440
		[Token(Token = "0x402E018")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetBattleFinishDisplayMetaItem;

		// Token: 0x0402E019 RID: 188441
		[Token(Token = "0x402E019")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GenDisplayMetaInfo;
	}
}
