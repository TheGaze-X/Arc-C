using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064B7 RID: 25783
	[Token(Token = "0x20064B7")]
	public class AutoChessBattleEffectChooseDraftEquipItemModel : AutoChessBattleEffectChooseDraftItemModel
	{
		// Token: 0x17005775 RID: 22389
		// (get) Token: 0x06025103 RID: 151811 RVA: 0x000C6570 File Offset: 0x000C4770
		[Token(Token = "0x17005775")]
		public bool coinEnough
		{
			[Token(Token = "0x6025103")]
			[Address(RVA = "0x1FDE3F0", Offset = "0x1FDCFF0", VA = "0x181FDE3F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025104 RID: 151812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025104")]
		[Address(RVA = "0x1FDDFF0", Offset = "0x1FDCBF0", VA = "0x181FDDFF0", Slot = "4")]
		public override void LoadData(ActAutoChessData actData, ActAutoChessData.ActAutoChessEffectChoiceInfoData effectChooseData, ChooseStateSlot spSlot)
		{
		}

		// Token: 0x06025105 RID: 151813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025105")]
		[Address(RVA = "0x1FDE240", Offset = "0x1FDCE40", VA = "0x181FDE240", Slot = "5")]
		public override void UpdateData(AutoChessBattleUIViewModel uiModel)
		{
		}

		// Token: 0x06025106 RID: 151814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025106")]
		[Address(RVA = "0x1FDE2E0", Offset = "0x1FDCEE0", VA = "0x181FDE2E0")]
		private SkillData _GetChessSkillData(ActAutoChessData actData, string chessId)
		{
			return null;
		}

		// Token: 0x06025107 RID: 151815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025107")]
		[Address(RVA = "0x1FDE390", Offset = "0x1FDCF90", VA = "0x181FDE390")]
		public AutoChessBattleEffectChooseDraftEquipItemModel()
		{
		}

		// Token: 0x06025108 RID: 151816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025108")]
		[Address(RVA = "0x1FDDC20", Offset = "0x1FDC820", VA = "0x181FDDC20")]
		private void <>xLuaBaseProxy_LoadData(ActAutoChessData P0, ActAutoChessData.ActAutoChessEffectChoiceInfoData P1, ChooseStateSlot P2)
		{
		}

		// Token: 0x06025109 RID: 151817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025109")]
		[Address(RVA = "0x1FDE230", Offset = "0x1FDCE30", VA = "0x181FDE230")]
		private void <>xLuaBaseProxy_UpdateData(AutoChessBattleUIViewModel P0)
		{
		}

		// Token: 0x04033E56 RID: 212566
		[Token(Token = "0x4033E56")]
		[FieldOffset(Offset = "0x28")]
		public string itemId;

		// Token: 0x04033E57 RID: 212567
		[Token(Token = "0x4033E57")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x04033E58 RID: 212568
		[Token(Token = "0x4033E58")]
		[FieldOffset(Offset = "0x38")]
		public int price;

		// Token: 0x04033E59 RID: 212569
		[Token(Token = "0x4033E59")]
		[FieldOffset(Offset = "0x3C")]
		public int itemLevel;

		// Token: 0x04033E5A RID: 212570
		[Token(Token = "0x4033E5A")]
		[FieldOffset(Offset = "0x40")]
		public string effectDesc;

		// Token: 0x04033E5B RID: 212571
		[Token(Token = "0x4033E5B")]
		[FieldOffset(Offset = "0x48")]
		public string iconId;

		// Token: 0x04033E5C RID: 212572
		[Token(Token = "0x4033E5C")]
		[FieldOffset(Offset = "0x50")]
		public int currentCoin;

		// Token: 0x04033E5D RID: 212573
		[Token(Token = "0x4033E5D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_coinEnough;

		// Token: 0x04033E5E RID: 212574
		[Token(Token = "0x4033E5E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033E5F RID: 212575
		[Token(Token = "0x4033E5F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04033E60 RID: 212576
		[Token(Token = "0x4033E60")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetChessSkillData;

		// Token: 0x04033E61 RID: 212577
		[Token(Token = "0x4033E61")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
