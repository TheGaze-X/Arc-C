using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064B5 RID: 25781
	[Token(Token = "0x20064B5")]
	public class AutoChessBattleEffectChooseDraftModel : IHotfixable
	{
		// Token: 0x060250FA RID: 151802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250FA")]
		[Address(RVA = "0x1FE00E0", Offset = "0x1FDECE0", VA = "0x181FE00E0")]
		public void LoadData(ActAutoChessData actData, AutoChessEffectChooseDataModel dataModel, ActAutoChessData.ActAutoChessEffectChoiceInfoData effectChooseData)
		{
		}

		// Token: 0x060250FB RID: 151803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250FB")]
		[Address(RVA = "0x1FE02D0", Offset = "0x1FDEED0", VA = "0x181FE02D0")]
		public void UpdateData(AutoChessBattleUIViewModel uiModel)
		{
		}

		// Token: 0x060250FC RID: 151804 RVA: 0x000C6558 File Offset: 0x000C4758
		[Token(Token = "0x60250FC")]
		[Address(RVA = "0x1FE0000", Offset = "0x1FDEC00", VA = "0x181FE0000")]
		public int FindFirstAvailItemSlotId()
		{
			return 0;
		}

		// Token: 0x060250FD RID: 151805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250FD")]
		[Address(RVA = "0x1FE03C0", Offset = "0x1FDEFC0", VA = "0x181FE03C0")]
		public AutoChessBattleEffectChooseDraftModel()
		{
		}

		// Token: 0x04033E47 RID: 212551
		[Token(Token = "0x4033E47")]
		[FieldOffset(Offset = "0x10")]
		public List<AutoChessBattleEffectChooseDraftItemModel> draftItems;

		// Token: 0x04033E48 RID: 212552
		[Token(Token = "0x4033E48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033E49 RID: 212553
		[Token(Token = "0x4033E49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04033E4A RID: 212554
		[Token(Token = "0x4033E4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FindFirstAvailItemSlotId;

		// Token: 0x04033E4B RID: 212555
		[Token(Token = "0x4033E4B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
