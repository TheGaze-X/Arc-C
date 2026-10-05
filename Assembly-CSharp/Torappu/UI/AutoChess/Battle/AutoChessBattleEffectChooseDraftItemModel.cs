using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064B6 RID: 25782
	[Token(Token = "0x20064B6")]
	public abstract class AutoChessBattleEffectChooseDraftItemModel : IHotfixable
	{
		// Token: 0x060250FE RID: 151806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250FE")]
		[Address(RVA = "0x1FDDC20", Offset = "0x1FDC820", VA = "0x181FDDC20", Slot = "4")]
		public virtual void LoadData(ActAutoChessData actData, ActAutoChessData.ActAutoChessEffectChoiceInfoData effectChooseData, ChooseStateSlot spSlot)
		{
		}

		// Token: 0x060250FF RID: 151807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250FF")]
		[Address(RVA = "0x1FDE660", Offset = "0x1FDD260", VA = "0x181FDE660", Slot = "5")]
		public virtual void UpdateData(AutoChessBattleUIViewModel uiModel)
		{
		}

		// Token: 0x06025100 RID: 151808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025100")]
		[Address(RVA = "0x1FDE840", Offset = "0x1FDD440", VA = "0x181FDE840")]
		protected void _ClearStatus()
		{
		}

		// Token: 0x06025101 RID: 151809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025101")]
		[Address(RVA = "0x1FDE450", Offset = "0x1FDD050", VA = "0x181FDE450")]
		public static AutoChessBattleEffectChooseDraftItemModel Create(ActAutoChessData actData, ActAutoChessData.ActAutoChessEffectChoiceInfoData effectChooseData, ChooseStateSlot spSlot)
		{
			return null;
		}

		// Token: 0x06025102 RID: 151810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025102")]
		[Address(RVA = "0x1FDE8E0", Offset = "0x1FDD4E0", VA = "0x181FDE8E0")]
		protected AutoChessBattleEffectChooseDraftItemModel()
		{
		}

		// Token: 0x04033E4C RID: 212556
		[Token(Token = "0x4033E4C")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessEffectChoiceType choiceType;

		// Token: 0x04033E4D RID: 212557
		[Token(Token = "0x4033E4D")]
		[FieldOffset(Offset = "0x14")]
		public AutoChessEffectType effectType;

		// Token: 0x04033E4E RID: 212558
		[Token(Token = "0x4033E4E")]
		[FieldOffset(Offset = "0x18")]
		public int slotId;

		// Token: 0x04033E4F RID: 212559
		[Token(Token = "0x4033E4F")]
		[FieldOffset(Offset = "0x1C")]
		public bool isServerSelected;

		// Token: 0x04033E50 RID: 212560
		[Token(Token = "0x4033E50")]
		[FieldOffset(Offset = "0x20")]
		public List<AutoChessBattleSpPreparePlayerModel> selectedPlayers;

		// Token: 0x04033E51 RID: 212561
		[Token(Token = "0x4033E51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033E52 RID: 212562
		[Token(Token = "0x4033E52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04033E53 RID: 212563
		[Token(Token = "0x4033E53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ClearStatus;

		// Token: 0x04033E54 RID: 212564
		[Token(Token = "0x4033E54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04033E55 RID: 212565
		[Token(Token = "0x4033E55")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
