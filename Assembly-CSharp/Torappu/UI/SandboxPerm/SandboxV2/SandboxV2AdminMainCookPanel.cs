using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004094 RID: 16532
	[Token(Token = "0x2004094")]
	public class SandboxV2AdminMainCookPanel : SandboxV2AdminMainTabPanel
	{
		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x06019936 RID: 104758 RVA: 0x0009EAC0 File Offset: 0x0009CCC0
		[Token(Token = "0x17003D0A")]
		public override SandboxV2AdminMainPanelType panelType
		{
			[Token(Token = "0x6019936")]
			[Address(RVA = "0x1248920", Offset = "0x1247520", VA = "0x181248920", Slot = "9")]
			get
			{
				return SandboxV2AdminMainPanelType.NONE;
			}
		}

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x06019937 RID: 104759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003D0B")]
		public override string topTitle
		{
			[Token(Token = "0x6019937")]
			[Address(RVA = "0x1248980", Offset = "0x1247580", VA = "0x181248980", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019938 RID: 104760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019938")]
		[Address(RVA = "0x1245770", Offset = "0x1244370", VA = "0x181245770", Slot = "8")]
		protected override void OnUpdate(SandboxV2AdminMainTabPanelUpdateCase updateCase)
		{
		}

		// Token: 0x06019939 RID: 104761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019939")]
		[Address(RVA = "0x1247B90", Offset = "0x1246790", VA = "0x181247B90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601993A RID: 104762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601993A")]
		[Address(RVA = "0x1247270", Offset = "0x1245E70", VA = "0x181247270")]
		private void _InitDrinkEvents()
		{
		}

		// Token: 0x0601993B RID: 104763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601993B")]
		[Address(RVA = "0x1247620", Offset = "0x1246220", VA = "0x181247620")]
		private void _InitFoodListEvents()
		{
		}

		// Token: 0x0601993C RID: 104764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601993C")]
		[Address(RVA = "0x1247750", Offset = "0x1246350", VA = "0x181247750")]
		private void _InitFreeCookEvents()
		{
		}

		// Token: 0x0601993D RID: 104765 RVA: 0x0009EAD8 File Offset: 0x0009CCD8
		[Token(Token = "0x601993D")]
		[Address(RVA = "0x1245850", Offset = "0x1244450", VA = "0x181245850")]
		private bool _CheckDrinkPanelInvalid(SandboxV2AdminMainCookPanelModel model)
		{
			return default(bool);
		}

		// Token: 0x0601993E RID: 104766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601993E")]
		[Address(RVA = "0x1246490", Offset = "0x1245090", VA = "0x181246490")]
		private void _DrinkSwitchModeEvent()
		{
		}

		// Token: 0x0601993F RID: 104767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601993F")]
		[Address(RVA = "0x1245B80", Offset = "0x1244780", VA = "0x181245B80")]
		private void _DrinkClearEvent()
		{
		}

		// Token: 0x06019940 RID: 104768 RVA: 0x0009EAF0 File Offset: 0x0009CCF0
		[Token(Token = "0x6019940")]
		[Address(RVA = "0x12463B0", Offset = "0x1244FB0", VA = "0x1812463B0")]
		private bool _DrinkSelectMaterialsToFillOneBottleEvent()
		{
			return default(bool);
		}

		// Token: 0x06019941 RID: 104769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019941")]
		[Address(RVA = "0x1245D60", Offset = "0x1244960", VA = "0x181245D60")]
		private void _DrinkMakeEvent()
		{
		}

		// Token: 0x06019942 RID: 104770 RVA: 0x0009EB08 File Offset: 0x0009CD08
		[Token(Token = "0x6019942")]
		[Address(RVA = "0x1245C50", Offset = "0x1244850", VA = "0x181245C50")]
		private bool _DrinkItemSelectEvent(int index, int count)
		{
			return default(bool);
		}

		// Token: 0x06019943 RID: 104771 RVA: 0x0009EB20 File Offset: 0x0009CD20
		[Token(Token = "0x6019943")]
		[Address(RVA = "0x1245960", Offset = "0x1244560", VA = "0x181245960")]
		private bool _CheckFoodListPanelInvalid(SandboxV2AdminMainCookPanelModel model)
		{
			return default(bool);
		}

		// Token: 0x06019944 RID: 104772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019944")]
		[Address(RVA = "0x1246570", Offset = "0x1245170", VA = "0x181246570")]
		private void _FoodListSelectItemEvent(int index)
		{
		}

		// Token: 0x06019945 RID: 104773 RVA: 0x0009EB38 File Offset: 0x0009CD38
		[Token(Token = "0x6019945")]
		[Address(RVA = "0x1245A70", Offset = "0x1244670", VA = "0x181245A70")]
		private bool _CheckFreeCookPanelInvalid(SandboxV2AdminMainCookPanelModel model)
		{
			return default(bool);
		}

		// Token: 0x06019946 RID: 104774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019946")]
		[Address(RVA = "0x1246F40", Offset = "0x1245B40", VA = "0x181246F40")]
		private void _FreeCookSelectMainMatEvent(int index)
		{
		}

		// Token: 0x06019947 RID: 104775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019947")]
		[Address(RVA = "0x1246890", Offset = "0x1245490", VA = "0x181246890")]
		private void _FreeCookDeselectMainMatEvent(int index)
		{
		}

		// Token: 0x06019948 RID: 104776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019948")]
		[Address(RVA = "0x1247180", Offset = "0x1245D80", VA = "0x181247180")]
		private void _FreeCookSelectSubMatEvent(int index)
		{
		}

		// Token: 0x06019949 RID: 104777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019949")]
		[Address(RVA = "0x1246980", Offset = "0x1245580", VA = "0x181246980")]
		private void _FreeCookDeselectSubMatEvent(int index)
		{
		}

		// Token: 0x0601994A RID: 104778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601994A")]
		[Address(RVA = "0x12467C0", Offset = "0x12453C0", VA = "0x1812467C0")]
		private void _FreeCookClearMatEvent()
		{
		}

		// Token: 0x0601994B RID: 104779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601994B")]
		[Address(RVA = "0x1246A70", Offset = "0x1245670", VA = "0x181246A70")]
		private void _FreeCookMakeEvent()
		{
		}

		// Token: 0x0601994C RID: 104780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601994C")]
		[Address(RVA = "0x1247F30", Offset = "0x1246B30", VA = "0x181247F30")]
		private void _OnCookDrinkRespond(SandboxV2CookDrinkResponse response)
		{
		}

		// Token: 0x0601994D RID: 104781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601994D")]
		[Address(RVA = "0x12481A0", Offset = "0x1246DA0", VA = "0x1812481A0")]
		private void _OnCookFoodRespond(SandboxV2CookFoodResponse response)
		{
		}

		// Token: 0x0601994E RID: 104782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601994E")]
		[Address(RVA = "0x12485B0", Offset = "0x12471B0", VA = "0x1812485B0")]
		private void _RefreshIfCan()
		{
		}

		// Token: 0x0601994F RID: 104783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601994F")]
		[Address(RVA = "0x12486B0", Offset = "0x12472B0", VA = "0x1812486B0")]
		private void _TutorialOnly_RegisterObject()
		{
		}

		// Token: 0x06019950 RID: 104784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019950")]
		[Address(RVA = "0x12488C0", Offset = "0x12474C0", VA = "0x1812488C0")]
		public SandboxV2AdminMainCookPanel()
		{
		}

		// Token: 0x0401FEDB RID: 130779
		[Token(Token = "0x401FEDB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SandboxV2AdminMainCookTypeSelectorView _leftTypeView;

		// Token: 0x0401FEDC RID: 130780
		[Token(Token = "0x401FEDC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SandboxV2CookDrinkView _drinkView;

		// Token: 0x0401FEDD RID: 130781
		[Token(Token = "0x401FEDD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2CookFoodListView _foodListView;

		// Token: 0x0401FEDE RID: 130782
		[Token(Token = "0x401FEDE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SandboxV2CookFreeCookView _freeCookView;

		// Token: 0x0401FEDF RID: 130783
		[Token(Token = "0x401FEDF")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2AdminMainCookPanelModelProperty m_prop;

		// Token: 0x0401FEE0 RID: 130784
		[Token(Token = "0x401FEE0")]
		[FieldOffset(Offset = "0x88")]
		private int m_dialogInstId;

		// Token: 0x0401FEE1 RID: 130785
		[Token(Token = "0x401FEE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0401FEE2 RID: 130786
		[Token(Token = "0x401FEE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_topTitle;

		// Token: 0x0401FEE3 RID: 130787
		[Token(Token = "0x401FEE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0401FEE4 RID: 130788
		[Token(Token = "0x401FEE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FEE5 RID: 130789
		[Token(Token = "0x401FEE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitDrinkEvents;

		// Token: 0x0401FEE6 RID: 130790
		[Token(Token = "0x401FEE6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitFoodListEvents;

		// Token: 0x0401FEE7 RID: 130791
		[Token(Token = "0x401FEE7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitFreeCookEvents;

		// Token: 0x0401FEE8 RID: 130792
		[Token(Token = "0x401FEE8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckDrinkPanelInvalid;

		// Token: 0x0401FEE9 RID: 130793
		[Token(Token = "0x401FEE9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DrinkSwitchModeEvent;

		// Token: 0x0401FEEA RID: 130794
		[Token(Token = "0x401FEEA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DrinkClearEvent;

		// Token: 0x0401FEEB RID: 130795
		[Token(Token = "0x401FEEB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DrinkSelectMaterialsToFillOneBottleEvent;

		// Token: 0x0401FEEC RID: 130796
		[Token(Token = "0x401FEEC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DrinkMakeEvent;

		// Token: 0x0401FEED RID: 130797
		[Token(Token = "0x401FEED")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DrinkItemSelectEvent;

		// Token: 0x0401FEEE RID: 130798
		[Token(Token = "0x401FEEE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckFoodListPanelInvalid;

		// Token: 0x0401FEEF RID: 130799
		[Token(Token = "0x401FEEF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__FoodListSelectItemEvent;

		// Token: 0x0401FEF0 RID: 130800
		[Token(Token = "0x401FEF0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckFreeCookPanelInvalid;

		// Token: 0x0401FEF1 RID: 130801
		[Token(Token = "0x401FEF1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__FreeCookSelectMainMatEvent;

		// Token: 0x0401FEF2 RID: 130802
		[Token(Token = "0x401FEF2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__FreeCookDeselectMainMatEvent;

		// Token: 0x0401FEF3 RID: 130803
		[Token(Token = "0x401FEF3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__FreeCookSelectSubMatEvent;

		// Token: 0x0401FEF4 RID: 130804
		[Token(Token = "0x401FEF4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__FreeCookDeselectSubMatEvent;

		// Token: 0x0401FEF5 RID: 130805
		[Token(Token = "0x401FEF5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__FreeCookClearMatEvent;

		// Token: 0x0401FEF6 RID: 130806
		[Token(Token = "0x401FEF6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__FreeCookMakeEvent;

		// Token: 0x0401FEF7 RID: 130807
		[Token(Token = "0x401FEF7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnCookDrinkRespond;

		// Token: 0x0401FEF8 RID: 130808
		[Token(Token = "0x401FEF8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnCookFoodRespond;

		// Token: 0x0401FEF9 RID: 130809
		[Token(Token = "0x401FEF9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RefreshIfCan;

		// Token: 0x0401FEFA RID: 130810
		[Token(Token = "0x401FEFA")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__TutorialOnly_RegisterObject;

		// Token: 0x0401FEFB RID: 130811
		[Token(Token = "0x401FEFB")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
