using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064B8 RID: 25784
	[Token(Token = "0x20064B8")]
	public class AutoChessBattleEffectChooseDraftEnemyItemModel : AutoChessBattleEffectChooseDraftItemModel
	{
		// Token: 0x0602510A RID: 151818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602510A")]
		[Address(RVA = "0x1FDDD40", Offset = "0x1FDC940", VA = "0x181FDDD40", Slot = "4")]
		public override void LoadData(ActAutoChessData actData, ActAutoChessData.ActAutoChessEffectChoiceInfoData effectChooseData, ChooseStateSlot spSlot)
		{
		}

		// Token: 0x0602510B RID: 151819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602510B")]
		[Address(RVA = "0x1FDDF90", Offset = "0x1FDCB90", VA = "0x181FDDF90")]
		public AutoChessBattleEffectChooseDraftEnemyItemModel()
		{
		}

		// Token: 0x0602510C RID: 151820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602510C")]
		[Address(RVA = "0x1FDDC20", Offset = "0x1FDC820", VA = "0x181FDDC20")]
		private void <>xLuaBaseProxy_LoadData(ActAutoChessData P0, ActAutoChessData.ActAutoChessEffectChoiceInfoData P1, ChooseStateSlot P2)
		{
		}

		// Token: 0x04033E62 RID: 212578
		[Token(Token = "0x4033E62")]
		[FieldOffset(Offset = "0x28")]
		public string effectId;

		// Token: 0x04033E63 RID: 212579
		[Token(Token = "0x4033E63")]
		[FieldOffset(Offset = "0x30")]
		public string enemyId;

		// Token: 0x04033E64 RID: 212580
		[Token(Token = "0x4033E64")]
		[FieldOffset(Offset = "0x38")]
		public string name;

		// Token: 0x04033E65 RID: 212581
		[Token(Token = "0x4033E65")]
		[FieldOffset(Offset = "0x40")]
		public int bounty;

		// Token: 0x04033E66 RID: 212582
		[Token(Token = "0x4033E66")]
		[FieldOffset(Offset = "0x48")]
		public string skillDesc;

		// Token: 0x04033E67 RID: 212583
		[Token(Token = "0x4033E67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033E68 RID: 212584
		[Token(Token = "0x4033E68")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
