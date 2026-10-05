using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C3B RID: 19515
	[Token(Token = "0x2004C3B")]
	public class HomeMailArchiveItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D4CE RID: 120014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4CE")]
		[Address(RVA = "0x16D08C0", Offset = "0x16CF4C0", VA = "0x1816D08C0")]
		public void Render(HomeMailArchiveItemViewModel model)
		{
		}

		// Token: 0x0601D4CF RID: 120015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4CF")]
		[Address(RVA = "0x16D07C0", Offset = "0x16CF3C0", VA = "0x1816D07C0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0601D4D0 RID: 120016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4D0")]
		[Address(RVA = "0x16D0AD0", Offset = "0x16CF6D0", VA = "0x1816D0AD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D4D1 RID: 120017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4D1")]
		[Address(RVA = "0x16D0CD0", Offset = "0x16CF8D0", VA = "0x1816D0CD0")]
		private void _OnItemCardClick(int _)
		{
		}

		// Token: 0x0601D4D2 RID: 120018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4D2")]
		[Address(RVA = "0x16D0DC0", Offset = "0x16CF9C0", VA = "0x1816D0DC0")]
		public HomeMailArchiveItemView()
		{
		}

		// Token: 0x040268C5 RID: 157893
		[Token(Token = "0x40268C5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Title")]
		private GameObject _panelTitle;

		// Token: 0x040268C6 RID: 157894
		[Token(Token = "0x40268C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Title")]
		private Text _textYear;

		// Token: 0x040268C7 RID: 157895
		[Token(Token = "0x40268C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Item")]
		private GameObject _panelItem;

		// Token: 0x040268C8 RID: 157896
		[Token(Token = "0x40268C8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Item")]
		private Image _imgAvatar;

		// Token: 0x040268C9 RID: 157897
		[Token(Token = "0x40268C9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Item")]
		private Text _textTitle;

		// Token: 0x040268CA RID: 157898
		[Token(Token = "0x40268CA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Item")]
		private Text _textSender;

		// Token: 0x040268CB RID: 157899
		[Token(Token = "0x40268CB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Item")]
		private Text _textReceiveDate;

		// Token: 0x040268CC RID: 157900
		[Token(Token = "0x40268CC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Item")]
		private RectTransform _itemCardContainer;

		// Token: 0x040268CD RID: 157901
		[Token(Token = "0x40268CD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Item")]
		private float _itemCardScale;

		// Token: 0x040268CE RID: 157902
		[Token(Token = "0x40268CE")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_hasInited;

		// Token: 0x040268CF RID: 157903
		[Token(Token = "0x40268CF")]
		[FieldOffset(Offset = "0x60")]
		private UIItemCard m_itemCard;

		// Token: 0x040268D0 RID: 157904
		[Token(Token = "0x40268D0")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040268D1 RID: 157905
		[Token(Token = "0x40268D1")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedItemId;

		// Token: 0x040268D2 RID: 157906
		[Token(Token = "0x40268D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040268D3 RID: 157907
		[Token(Token = "0x40268D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x040268D4 RID: 157908
		[Token(Token = "0x40268D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040268D5 RID: 157909
		[Token(Token = "0x40268D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemCardClick;

		// Token: 0x040268D6 RID: 157910
		[Token(Token = "0x40268D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
