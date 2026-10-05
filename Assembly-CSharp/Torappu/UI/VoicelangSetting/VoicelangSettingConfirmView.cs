using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BBF RID: 15295
	[Token(Token = "0x2003BBF")]
	public class VoicelangSettingConfirmView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017F31 RID: 98097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F31")]
		[Address(RVA = "0x1070450", Offset = "0x106F050", VA = "0x181070450")]
		public void Render(VoicelangSettingConfirmViewModel model)
		{
		}

		// Token: 0x06017F32 RID: 98098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F32")]
		[Address(RVA = "0x106FEE0", Offset = "0x106EAE0", VA = "0x18106FEE0")]
		public void Init(UnityEvent onConfirm, UnityEvent onCancel, UISelectLangTypeEvent onSelect)
		{
		}

		// Token: 0x06017F33 RID: 98099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F33")]
		[Address(RVA = "0x1070D50", Offset = "0x106F950", VA = "0x181070D50")]
		private void _OpenWithTween()
		{
		}

		// Token: 0x06017F34 RID: 98100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F34")]
		[Address(RVA = "0x1070B20", Offset = "0x106F720", VA = "0x181070B20")]
		private void _CloseWithTween()
		{
		}

		// Token: 0x06017F35 RID: 98101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F35")]
		[Address(RVA = "0x1070C20", Offset = "0x106F820", VA = "0x181070C20")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x06017F36 RID: 98102 RVA: 0x00098C10 File Offset: 0x00096E10
		[Token(Token = "0x6017F36")]
		[Address(RVA = "0x1070B90", Offset = "0x106F790", VA = "0x181070B90")]
		private static VoiceLangType _FilterDisplayLangType(VoiceLangType voiceLang)
		{
			return VoiceLangType.NONE;
		}

		// Token: 0x06017F37 RID: 98103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F37")]
		[Address(RVA = "0x10703E0", Offset = "0x106EFE0", VA = "0x1810703E0")]
		public void OnConfirm()
		{
		}

		// Token: 0x06017F38 RID: 98104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F38")]
		[Address(RVA = "0x1070370", Offset = "0x106EF70", VA = "0x181070370")]
		public void OnCancel()
		{
		}

		// Token: 0x06017F39 RID: 98105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F39")]
		[Address(RVA = "0x1070DC0", Offset = "0x106F9C0", VA = "0x181070DC0")]
		public VoicelangSettingConfirmView()
		{
		}

		// Token: 0x0401CF8C RID: 118668
		[Token(Token = "0x401CF8C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_goTitleSingle;

		// Token: 0x0401CF8D RID: 118669
		[Token(Token = "0x401CF8D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_goTitleBatch;

		// Token: 0x0401CF8E RID: 118670
		[Token(Token = "0x401CF8E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VoicelangTypeItemView m_prefabLangItem;

		// Token: 0x0401CF8F RID: 118671
		[Token(Token = "0x401CF8F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform m_langItemRoot;

		// Token: 0x0401CF90 RID: 118672
		[Token(Token = "0x401CF90")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button m_btnConfirm;

		// Token: 0x0401CF91 RID: 118673
		[Token(Token = "0x401CF91")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image m_bgConfirm;

		// Token: 0x0401CF92 RID: 118674
		[Token(Token = "0x401CF92")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject m_goConfirmMask;

		// Token: 0x0401CF93 RID: 118675
		[Token(Token = "0x401CF93")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color m_bgConfirmNormalColor;

		// Token: 0x0401CF94 RID: 118676
		[Token(Token = "0x401CF94")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color m_bgConfirmDisableColor;

		// Token: 0x0401CF95 RID: 118677
		[Token(Token = "0x401CF95")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text m_lbHint;

		// Token: 0x0401CF96 RID: 118678
		[Token(Token = "0x401CF96")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform m_rectTransRoot;

		// Token: 0x0401CF97 RID: 118679
		[Token(Token = "0x401CF97")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float m_panelMoveDuration;

		// Token: 0x0401CF98 RID: 118680
		[Token(Token = "0x401CF98")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject m_block;

		// Token: 0x0401CF99 RID: 118681
		[Token(Token = "0x401CF99")]
		[FieldOffset(Offset = "0x90")]
		private UnityEvent m_onConfirm;

		// Token: 0x0401CF9A RID: 118682
		[Token(Token = "0x401CF9A")]
		[FieldOffset(Offset = "0x98")]
		private UnityEvent m_onCancel;

		// Token: 0x0401CF9B RID: 118683
		[Token(Token = "0x401CF9B")]
		[FieldOffset(Offset = "0xA0")]
		private List<VoicelangTypeItemView> m_itemList;

		// Token: 0x0401CF9C RID: 118684
		[Token(Token = "0x401CF9C")]
		[FieldOffset(Offset = "0xA8")]
		private UISelectLangTypeEvent m_onSelectLangType;

		// Token: 0x0401CF9D RID: 118685
		[Token(Token = "0x401CF9D")]
		[FieldOffset(Offset = "0xB0")]
		private ConfirmViewState m_lastState;

		// Token: 0x0401CF9E RID: 118686
		[Token(Token = "0x401CF9E")]
		[FieldOffset(Offset = "0xB8")]
		private VoicelangSettingConfirmView.VoiceConfirmSwitchTween m_switchTween;

		// Token: 0x0401CF9F RID: 118687
		[Token(Token = "0x401CF9F")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x0401CFA0 RID: 118688
		[Token(Token = "0x401CFA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401CFA1 RID: 118689
		[Token(Token = "0x401CFA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401CFA2 RID: 118690
		[Token(Token = "0x401CFA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OpenWithTween;

		// Token: 0x0401CFA3 RID: 118691
		[Token(Token = "0x401CFA3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CloseWithTween;

		// Token: 0x0401CFA4 RID: 118692
		[Token(Token = "0x401CFA4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x0401CFA5 RID: 118693
		[Token(Token = "0x401CFA5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FilterDisplayLangType;

		// Token: 0x0401CFA6 RID: 118694
		[Token(Token = "0x401CFA6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnConfirm;

		// Token: 0x0401CFA7 RID: 118695
		[Token(Token = "0x401CFA7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0401CFA8 RID: 118696
		[Token(Token = "0x401CFA8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BC0 RID: 15296
		[Token(Token = "0x2003BC0")]
		private class VoiceConfirmSwitchTween : UISwitchTween
		{
			// Token: 0x06017F3B RID: 98107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F3B")]
			[Address(RVA = "0x106A460", Offset = "0x1069060", VA = "0x18106A460")]
			public VoiceConfirmSwitchTween(VoicelangSettingConfirmView confirmView)
			{
			}

			// Token: 0x06017F3C RID: 98108 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017F3C")]
			[Address(RVA = "0x106A270", Offset = "0x1068E70", VA = "0x18106A270", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06017F3D RID: 98109 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017F3D")]
			[Address(RVA = "0x106A160", Offset = "0x1068D60", VA = "0x18106A160", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06017F3E RID: 98110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F3E")]
			[Address(RVA = "0x106A060", Offset = "0x1068C60", VA = "0x18106A060", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06017F3F RID: 98111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F3F")]
			[Address(RVA = "0x106A0E0", Offset = "0x1068CE0", VA = "0x18106A0E0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06017F40 RID: 98112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F40")]
			[Address(RVA = "0x106A390", Offset = "0x1068F90", VA = "0x18106A390", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06017F41 RID: 98113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F41")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x06017F42 RID: 98114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F42")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06017F43 RID: 98115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017F43")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0401CFA9 RID: 118697
			[Token(Token = "0x401CFA9")]
			[FieldOffset(Offset = "0x48")]
			private VoicelangSettingConfirmView m_closure;

			// Token: 0x0401CFAA RID: 118698
			[Token(Token = "0x401CFAA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401CFAB RID: 118699
			[Token(Token = "0x401CFAB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0401CFAC RID: 118700
			[Token(Token = "0x401CFAC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0401CFAD RID: 118701
			[Token(Token = "0x401CFAD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0401CFAE RID: 118702
			[Token(Token = "0x401CFAE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0401CFAF RID: 118703
			[Token(Token = "0x401CFAF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
