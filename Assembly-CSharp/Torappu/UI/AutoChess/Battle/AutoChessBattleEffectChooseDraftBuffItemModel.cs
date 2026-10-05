using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064B9 RID: 25785
	[Token(Token = "0x20064B9")]
	public class AutoChessBattleEffectChooseDraftBuffItemModel : AutoChessBattleEffectChooseDraftItemModel
	{
		// Token: 0x0602510D RID: 151821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602510D")]
		[Address(RVA = "0x1FDD9D0", Offset = "0x1FDC5D0", VA = "0x181FDD9D0", Slot = "4")]
		public override void LoadData(ActAutoChessData actData, ActAutoChessData.ActAutoChessEffectChoiceInfoData effectChooseData, ChooseStateSlot spSlot)
		{
		}

		// Token: 0x0602510E RID: 151822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602510E")]
		[Address(RVA = "0x1FDDCE0", Offset = "0x1FDC8E0", VA = "0x181FDDCE0")]
		public AutoChessBattleEffectChooseDraftBuffItemModel()
		{
		}

		// Token: 0x0602510F RID: 151823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602510F")]
		[Address(RVA = "0x1FDDC20", Offset = "0x1FDC820", VA = "0x181FDDC20")]
		private void <>xLuaBaseProxy_LoadData(ActAutoChessData P0, ActAutoChessData.ActAutoChessEffectChoiceInfoData P1, ChooseStateSlot P2)
		{
		}

		// Token: 0x04033E69 RID: 212585
		[Token(Token = "0x4033E69")]
		[FieldOffset(Offset = "0x28")]
		public string effectId;

		// Token: 0x04033E6A RID: 212586
		[Token(Token = "0x4033E6A")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x04033E6B RID: 212587
		[Token(Token = "0x4033E6B")]
		[FieldOffset(Offset = "0x38")]
		public string effectIconId;

		// Token: 0x04033E6C RID: 212588
		[Token(Token = "0x4033E6C")]
		[FieldOffset(Offset = "0x40")]
		public string buffDesc;

		// Token: 0x04033E6D RID: 212589
		[Token(Token = "0x4033E6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033E6E RID: 212590
		[Token(Token = "0x4033E6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
