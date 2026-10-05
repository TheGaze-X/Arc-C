using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E9E RID: 24222
	[Token(Token = "0x2005E9E")]
	public class ItemRepoIssueVoucherItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005320 RID: 21280
		// (get) Token: 0x06023163 RID: 143715 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023164 RID: 143716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005320")]
		public Func<int, int, bool> onSelectItem
		{
			[Token(Token = "0x6023163")]
			[Address(RVA = "0x1D95B20", Offset = "0x1D94720", VA = "0x181D95B20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6023164")]
			[Address(RVA = "0x1D95B80", Offset = "0x1D94780", VA = "0x181D95B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023165 RID: 143717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023165")]
		[Address(RVA = "0x1D94E30", Offset = "0x1D93A30", VA = "0x181D94E30")]
		public void Render(int index, ItemRepoIssueVoucherItemViewModel viewModel, bool selectable)
		{
		}

		// Token: 0x06023166 RID: 143718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023166")]
		[Address(RVA = "0x1D95410", Offset = "0x1D94010", VA = "0x181D95410")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023167 RID: 143719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023167")]
		[Address(RVA = "0x1D95800", Offset = "0x1D94400", VA = "0x181D95800")]
		private void _SelectItem(int index)
		{
		}

		// Token: 0x06023168 RID: 143720 RVA: 0x000BFE68 File Offset: 0x000BE068
		[Token(Token = "0x6023168")]
		[Address(RVA = "0x1D95630", Offset = "0x1D94230", VA = "0x181D95630")]
		private bool _SelectItemLongPress(int index)
		{
			return default(bool);
		}

		// Token: 0x06023169 RID: 143721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023169")]
		[Address(RVA = "0x1D952F0", Offset = "0x1D93EF0", VA = "0x181D952F0")]
		private void _DeselectItem()
		{
		}

		// Token: 0x0602316A RID: 143722 RVA: 0x000BFE80 File Offset: 0x000BE080
		[Token(Token = "0x602316A")]
		[Address(RVA = "0x1D951D0", Offset = "0x1D93DD0", VA = "0x181D951D0")]
		private bool _DeselectItemLongPress()
		{
			return default(bool);
		}

		// Token: 0x0602316B RID: 143723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602316B")]
		[Address(RVA = "0x1D959C0", Offset = "0x1D945C0", VA = "0x181D959C0")]
		private void _ShowItemDesc(int _)
		{
		}

		// Token: 0x0602316C RID: 143724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602316C")]
		[Address(RVA = "0x1D95AB0", Offset = "0x1D946B0", VA = "0x181D95AB0")]
		public ItemRepoIssueVoucherItemView()
		{
		}

		// Token: 0x04030553 RID: 197971
		[Token(Token = "0x4030553")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x04030554 RID: 197972
		[Token(Token = "0x4030554")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectedDownPanel;

		// Token: 0x04030555 RID: 197973
		[Token(Token = "0x4030555")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedUpPanel;

		// Token: 0x04030556 RID: 197974
		[Token(Token = "0x4030556")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _selectedCountText;

		// Token: 0x04030557 RID: 197975
		[Token(Token = "0x4030557")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UILongPressButtonEx _deselectButton;

		// Token: 0x04030558 RID: 197976
		[Token(Token = "0x4030558")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _possessPanel;

		// Token: 0x04030559 RID: 197977
		[Token(Token = "0x4030559")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _possessText;

		// Token: 0x0403055A RID: 197978
		[Token(Token = "0x403055A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _outputPanel;

		// Token: 0x0403055B RID: 197979
		[Token(Token = "0x403055B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _outputCountText;

		// Token: 0x0403055C RID: 197980
		[Token(Token = "0x403055C")]
		[FieldOffset(Offset = "0x60")]
		private float m_itemCardScale;

		// Token: 0x0403055D RID: 197981
		[Token(Token = "0x403055D")]
		[FieldOffset(Offset = "0x64")]
		private int m_longPressCount;

		// Token: 0x0403055E RID: 197982
		[Token(Token = "0x403055E")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0403055F RID: 197983
		[Token(Token = "0x403055F")]
		[FieldOffset(Offset = "0x70")]
		private UIItemCard m_itemCard;

		// Token: 0x04030560 RID: 197984
		[Token(Token = "0x4030560")]
		[FieldOffset(Offset = "0x78")]
		private int m_cachedIndex;

		// Token: 0x04030561 RID: 197985
		[Token(Token = "0x4030561")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_finder;

		// Token: 0x04030563 RID: 197987
		[Token(Token = "0x4030563")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSelectItem;

		// Token: 0x04030564 RID: 197988
		[Token(Token = "0x4030564")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSelectItem;

		// Token: 0x04030565 RID: 197989
		[Token(Token = "0x4030565")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030566 RID: 197990
		[Token(Token = "0x4030566")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030567 RID: 197991
		[Token(Token = "0x4030567")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SelectItem;

		// Token: 0x04030568 RID: 197992
		[Token(Token = "0x4030568")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SelectItemLongPress;

		// Token: 0x04030569 RID: 197993
		[Token(Token = "0x4030569")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DeselectItem;

		// Token: 0x0403056A RID: 197994
		[Token(Token = "0x403056A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DeselectItemLongPress;

		// Token: 0x0403056B RID: 197995
		[Token(Token = "0x403056B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowItemDesc;

		// Token: 0x0403056C RID: 197996
		[Token(Token = "0x403056C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
