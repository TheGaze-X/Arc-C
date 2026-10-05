using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F62 RID: 24418
	[Token(Token = "0x2005F62")]
	public class CharacterLvlupItemCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700538E RID: 21390
		// (get) Token: 0x060235AA RID: 144810 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060235AB RID: 144811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700538E")]
		public Action<int, int> onModifyingCardNum
		{
			[Token(Token = "0x60235AA")]
			[Address(RVA = "0x1E0C560", Offset = "0x1E0B160", VA = "0x181E0C560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60235AB")]
			[Address(RVA = "0x1E0C5C0", Offset = "0x1E0B1C0", VA = "0x181E0C5C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060235AC RID: 144812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235AC")]
		[Address(RVA = "0x1E0BA10", Offset = "0x1E0A610", VA = "0x181E0BA10")]
		public void Render(int index, CharacterLvlupItemCardViewModel viewModel)
		{
		}

		// Token: 0x060235AD RID: 144813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235AD")]
		[Address(RVA = "0x1E0B930", Offset = "0x1E0A530", VA = "0x181E0B930")]
		public void EventOnReduceBtnClick()
		{
		}

		// Token: 0x060235AE RID: 144814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235AE")]
		[Address(RVA = "0x1E0C290", Offset = "0x1E0AE90", VA = "0x181E0C290")]
		private void _OnItemClicked(int index)
		{
		}

		// Token: 0x060235AF RID: 144815 RVA: 0x000C0A08 File Offset: 0x000BEC08
		[Token(Token = "0x60235AF")]
		[Address(RVA = "0x1E0C340", Offset = "0x1E0AF40", VA = "0x181E0C340")]
		private bool _OnItemLongPressed(int index)
		{
			return default(bool);
		}

		// Token: 0x060235B0 RID: 144816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235B0")]
		[Address(RVA = "0x1E0C3E0", Offset = "0x1E0AFE0", VA = "0x181E0C3E0")]
		private void _ShowItemDesc()
		{
		}

		// Token: 0x060235B1 RID: 144817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235B1")]
		[Address(RVA = "0x1E0C0C0", Offset = "0x1E0ACC0", VA = "0x181E0C0C0")]
		private void _CallbackIncreaseWithSound(int index, int count)
		{
		}

		// Token: 0x060235B2 RID: 144818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235B2")]
		[Address(RVA = "0x1E0C4D0", Offset = "0x1E0B0D0", VA = "0x181E0C4D0")]
		public CharacterLvlupItemCard()
		{
		}

		// Token: 0x04030CE4 RID: 199908
		[Token(Token = "0x4030CE4")]
		private const int LONG_PRESS_ADD_STEP = 4;

		// Token: 0x04030CE5 RID: 199909
		[Token(Token = "0x4030CE5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04030CE6 RID: 199910
		[Token(Token = "0x4030CE6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x04030CE7 RID: 199911
		[Token(Token = "0x4030CE7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _panelSelected;

		// Token: 0x04030CE8 RID: 199912
		[Token(Token = "0x4030CE8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgSelectedCountBkg;

		// Token: 0x04030CE9 RID: 199913
		[Token(Token = "0x4030CE9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtSelectedCount;

		// Token: 0x04030CEA RID: 199914
		[Token(Token = "0x4030CEA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelDisplay;

		// Token: 0x04030CEB RID: 199915
		[Token(Token = "0x4030CEB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgDisplayCountBkg;

		// Token: 0x04030CEC RID: 199916
		[Token(Token = "0x4030CEC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtDisplayCount;

		// Token: 0x04030CED RID: 199917
		[Token(Token = "0x4030CED")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelCounting;

		// Token: 0x04030CEE RID: 199918
		[Token(Token = "0x4030CEE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorNormalCount;

		// Token: 0x04030CEF RID: 199919
		[Token(Token = "0x4030CEF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colorExceedCount;

		// Token: 0x04030CF0 RID: 199920
		[Token(Token = "0x4030CF0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _colorEmptyItem;

		// Token: 0x04030CF2 RID: 199922
		[Token(Token = "0x4030CF2")]
		[FieldOffset(Offset = "0x98")]
		private int m_itemIndexCache;

		// Token: 0x04030CF3 RID: 199923
		[Token(Token = "0x4030CF3")]
		[FieldOffset(Offset = "0xA0")]
		private long m_selectedCountCache;

		// Token: 0x04030CF4 RID: 199924
		[Token(Token = "0x4030CF4")]
		[FieldOffset(Offset = "0xA8")]
		private CharacterLvlupItemCardViewModel.Mode m_mode;

		// Token: 0x04030CF5 RID: 199925
		[Token(Token = "0x4030CF5")]
		[FieldOffset(Offset = "0xB0")]
		private UIItemCard m_itemCard;

		// Token: 0x04030CF6 RID: 199926
		[Token(Token = "0x4030CF6")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_needDescOnly;

		// Token: 0x04030CF7 RID: 199927
		[Token(Token = "0x4030CF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onModifyingCardNum;

		// Token: 0x04030CF8 RID: 199928
		[Token(Token = "0x4030CF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onModifyingCardNum;

		// Token: 0x04030CF9 RID: 199929
		[Token(Token = "0x4030CF9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030CFA RID: 199930
		[Token(Token = "0x4030CFA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnReduceBtnClick;

		// Token: 0x04030CFB RID: 199931
		[Token(Token = "0x4030CFB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x04030CFC RID: 199932
		[Token(Token = "0x4030CFC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnItemLongPressed;

		// Token: 0x04030CFD RID: 199933
		[Token(Token = "0x4030CFD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShowItemDesc;

		// Token: 0x04030CFE RID: 199934
		[Token(Token = "0x4030CFE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CallbackIncreaseWithSound;

		// Token: 0x04030CFF RID: 199935
		[Token(Token = "0x4030CFF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
