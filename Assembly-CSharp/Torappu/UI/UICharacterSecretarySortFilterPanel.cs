using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200353F RID: 13631
	[Token(Token = "0x200353F")]
	public class UICharacterSecretarySortFilterPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015BA5 RID: 88997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BA5")]
		[Address(RVA = "0xE50F10", Offset = "0xE4FB10", VA = "0x180E50F10")]
		public void Render(CharacterFilterViewModel filter)
		{
		}

		// Token: 0x06015BA6 RID: 88998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BA6")]
		[Address(RVA = "0xE50E90", Offset = "0xE4FA90", VA = "0x180E50E90")]
		public void EventOnBackClick()
		{
		}

		// Token: 0x06015BA7 RID: 88999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BA7")]
		[Address(RVA = "0xE51340", Offset = "0xE4FF40", VA = "0x180E51340")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015BA8 RID: 89000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BA8")]
		[Address(RVA = "0xE51500", Offset = "0xE50100", VA = "0x180E51500")]
		private void _OnToggleClick(TwoStateToggle.State state)
		{
		}

		// Token: 0x06015BA9 RID: 89001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BA9")]
		[Address(RVA = "0xE51660", Offset = "0xE50260", VA = "0x180E51660")]
		private void _UpdateProfessionStr(CharacterFilterViewModel viewModel)
		{
		}

		// Token: 0x06015BAA RID: 89002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BAA")]
		[Address(RVA = "0xE51290", Offset = "0xE4FE90", VA = "0x180E51290")]
		private void _EventOnFilterClick(CharacterFilterViewModel viewModel)
		{
		}

		// Token: 0x06015BAB RID: 89003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BAB")]
		[Address(RVA = "0xE511B0", Offset = "0xE4FDB0", VA = "0x180E511B0")]
		private void _EventOnFadeOutFilter()
		{
		}

		// Token: 0x06015BAC RID: 89004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BAC")]
		[Address(RVA = "0xE510D0", Offset = "0xE4FCD0", VA = "0x180E510D0")]
		private void _EventOnFadeInFilter()
		{
		}

		// Token: 0x06015BAD RID: 89005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BAD")]
		[Address(RVA = "0xE517C0", Offset = "0xE503C0", VA = "0x180E517C0")]
		public UICharacterSecretarySortFilterPanel()
		{
		}

		// Token: 0x0401A1A6 RID: 106918
		[Token(Token = "0x401A1A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objFilterAll;

		// Token: 0x0401A1A7 RID: 106919
		[Token(Token = "0x401A1A7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objFilterOther;

		// Token: 0x0401A1A8 RID: 106920
		[Token(Token = "0x401A1A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtFilterOther;

		// Token: 0x0401A1A9 RID: 106921
		[Token(Token = "0x401A1A9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _toggleCurFilter;

		// Token: 0x0401A1AA RID: 106922
		[Token(Token = "0x401A1AA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("the filter panel")]
		private UICharacterFilterGroupOnFloat _filterGroup;

		// Token: 0x0401A1AB RID: 106923
		[Token(Token = "0x401A1AB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _filterPanel;

		// Token: 0x0401A1AC RID: 106924
		[Token(Token = "0x401A1AC")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<CharacterFilterViewModel> eventOnFilterClick;

		// Token: 0x0401A1AD RID: 106925
		[Token(Token = "0x401A1AD")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action eventOnFilterFadeIn;

		// Token: 0x0401A1AE RID: 106926
		[Token(Token = "0x401A1AE")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action eventOnFilterFadeOut;

		// Token: 0x0401A1AF RID: 106927
		[Token(Token = "0x401A1AF")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0401A1B0 RID: 106928
		[Token(Token = "0x401A1B0")]
		[FieldOffset(Offset = "0x68")]
		private Tweener m_fadeIn;

		// Token: 0x0401A1B1 RID: 106929
		[Token(Token = "0x401A1B1")]
		[FieldOffset(Offset = "0x70")]
		private Tweener m_fadeOut;

		// Token: 0x0401A1B2 RID: 106930
		[Token(Token = "0x401A1B2")]
		[FieldOffset(Offset = "0x78")]
		private bool m_filterShowing;

		// Token: 0x0401A1B3 RID: 106931
		[Token(Token = "0x401A1B3")]
		private const float FAST_TWEEN_DUR = 0.16f;

		// Token: 0x0401A1B4 RID: 106932
		[Token(Token = "0x401A1B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401A1B5 RID: 106933
		[Token(Token = "0x401A1B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBackClick;

		// Token: 0x0401A1B6 RID: 106934
		[Token(Token = "0x401A1B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A1B7 RID: 106935
		[Token(Token = "0x401A1B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnToggleClick;

		// Token: 0x0401A1B8 RID: 106936
		[Token(Token = "0x401A1B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateProfessionStr;

		// Token: 0x0401A1B9 RID: 106937
		[Token(Token = "0x401A1B9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnFilterClick;

		// Token: 0x0401A1BA RID: 106938
		[Token(Token = "0x401A1BA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnFadeOutFilter;

		// Token: 0x0401A1BB RID: 106939
		[Token(Token = "0x401A1BB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnFadeInFilter;

		// Token: 0x0401A1BC RID: 106940
		[Token(Token = "0x401A1BC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003540 RID: 13632
		[Token(Token = "0x2003540")]
		[Serializable]
		public class CharacterFilterMessage : UnityEvent<CharacterFilterViewModel>
		{
			// Token: 0x06015BAE RID: 89006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015BAE")]
			[Address(RVA = "0xE438A0", Offset = "0xE424A0", VA = "0x180E438A0")]
			public CharacterFilterMessage()
			{
			}
		}
	}
}
