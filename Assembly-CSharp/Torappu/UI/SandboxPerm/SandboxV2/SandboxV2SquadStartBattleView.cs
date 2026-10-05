using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004442 RID: 17474
	[Token(Token = "0x2004442")]
	public class SandboxV2SquadStartBattleView : DataBinder<SandboxV2SquadGroupProp>
	{
		// Token: 0x0601AB3C RID: 109372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB3C")]
		[Address(RVA = "0x13D1100", Offset = "0x13CFD00", VA = "0x1813D1100", Slot = "7")]
		public override void OnValueChanged(SandboxV2SquadGroupProp property)
		{
		}

		// Token: 0x0601AB3D RID: 109373 RVA: 0x000A3068 File Offset: 0x000A1268
		[Token(Token = "0x601AB3D")]
		[Address(RVA = "0x13D1AF0", Offset = "0x13D06F0", VA = "0x1813D1AF0")]
		private Color _GetBarColor(bool isActive)
		{
			return default(Color);
		}

		// Token: 0x0601AB3E RID: 109374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB3E")]
		[Address(RVA = "0x13D1C80", Offset = "0x13D0880", VA = "0x1813D1C80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AB3F RID: 109375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB3F")]
		[Address(RVA = "0x13D1DF0", Offset = "0x13D09F0", VA = "0x1813D1DF0")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x0601AB40 RID: 109376 RVA: 0x000A3080 File Offset: 0x000A1280
		[Token(Token = "0x601AB40")]
		[Address(RVA = "0x13D1BB0", Offset = "0x13D07B0", VA = "0x1813D1BB0")]
		private Color _GetSlotColor(SandboxV2SlotStatus slotStatus)
		{
			return default(Color);
		}

		// Token: 0x0601AB41 RID: 109377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB41")]
		[Address(RVA = "0x13D1070", Offset = "0x13CFC70", VA = "0x1813D1070")]
		public void EventOnBtnStart()
		{
		}

		// Token: 0x0601AB42 RID: 109378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB42")]
		[Address(RVA = "0x13D0FE0", Offset = "0x13CFBE0", VA = "0x1813D0FE0")]
		public void EventOnBtnMakeDrink()
		{
		}

		// Token: 0x0601AB43 RID: 109379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB43")]
		[Address(RVA = "0x13D1F10", Offset = "0x13D0B10", VA = "0x1813D1F10")]
		public SandboxV2SquadStartBattleView()
		{
		}

		// Token: 0x0402216B RID: 139627
		[Token(Token = "0x402216B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage[] _iconSlotList;

		// Token: 0x0402216C RID: 139628
		[Token(Token = "0x402216C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgMiniSquadBar;

		// Token: 0x0402216D RID: 139629
		[Token(Token = "0x402216D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgLargeSquadBar;

		// Token: 0x0402216E RID: 139630
		[Token(Token = "0x402216E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorSlotEmpty;

		// Token: 0x0402216F RID: 139631
		[Token(Token = "0x402216F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorSlotUsed;

		// Token: 0x04022170 RID: 139632
		[Token(Token = "0x4022170")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colorSlotNormal;

		// Token: 0x04022171 RID: 139633
		[Token(Token = "0x4022171")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _colorBarEnable;

		// Token: 0x04022172 RID: 139634
		[Token(Token = "0x4022172")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorBarDisable;

		// Token: 0x04022173 RID: 139635
		[Token(Token = "0x4022173")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textDrinkCost;

		// Token: 0x04022174 RID: 139636
		[Token(Token = "0x4022174")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textDrinkTotal;

		// Token: 0x04022175 RID: 139637
		[Token(Token = "0x4022175")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _drinkCostBgNormalGo;

		// Token: 0x04022176 RID: 139638
		[Token(Token = "0x4022176")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _drinkCostBgLackGo;

		// Token: 0x04022177 RID: 139639
		[Token(Token = "0x4022177")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _imgDrinkIcon;

		// Token: 0x04022178 RID: 139640
		[Token(Token = "0x4022178")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _drinkCostGo;

		// Token: 0x04022179 RID: 139641
		[Token(Token = "0x4022179")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _btnStartBattleGo;

		// Token: 0x0402217A RID: 139642
		[Token(Token = "0x402217A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Month")]
		private GameObject _panelMonthTips;

		// Token: 0x0402217B RID: 139643
		[Token(Token = "0x402217B")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Month")]
		private GameObject _panelDrink;

		// Token: 0x0402217C RID: 139644
		[Token(Token = "0x402217C")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Month")]
		private GameObject _panelApCost;

		// Token: 0x0402217D RID: 139645
		[Token(Token = "0x402217D")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Month")]
		private GameObject _panelNormalBtnStartBattle;

		// Token: 0x0402217E RID: 139646
		[Token(Token = "0x402217E")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Month")]
		private GameObject _panelMonthBtnStartBattle;

		// Token: 0x0402217F RID: 139647
		[Token(Token = "0x402217F")]
		[FieldOffset(Offset = "0xE8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04022180 RID: 139648
		[Token(Token = "0x4022180")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_hasInit;

		// Token: 0x04022181 RID: 139649
		[Token(Token = "0x4022181")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04022182 RID: 139650
		[Token(Token = "0x4022182")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetBarColor;

		// Token: 0x04022183 RID: 139651
		[Token(Token = "0x4022183")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022184 RID: 139652
		[Token(Token = "0x4022184")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x04022185 RID: 139653
		[Token(Token = "0x4022185")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetSlotColor;

		// Token: 0x04022186 RID: 139654
		[Token(Token = "0x4022186")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBtnStart;

		// Token: 0x04022187 RID: 139655
		[Token(Token = "0x4022187")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBtnMakeDrink;

		// Token: 0x04022188 RID: 139656
		[Token(Token = "0x4022188")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
