using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E9F RID: 24223
	[Token(Token = "0x2005E9F")]
	public class ItemRepoIssueVoucherView : DataBinder<ItemRepoIssueVoucherViewProperty>
	{
		// Token: 0x17005321 RID: 21281
		// (get) Token: 0x0602316D RID: 143725 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602316E RID: 143726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005321")]
		public Func<int, int, bool> onSelectItem
		{
			[Token(Token = "0x602316D")]
			[Address(RVA = "0x1D98920", Offset = "0x1D97520", VA = "0x181D98920")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602316E")]
			[Address(RVA = "0x1D98980", Offset = "0x1D97580", VA = "0x181D98980")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602316F RID: 143727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602316F")]
		[Address(RVA = "0x1D97920", Offset = "0x1D96520", VA = "0x181D97920")]
		public void OnChooseConfirm()
		{
		}

		// Token: 0x06023170 RID: 143728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023170")]
		[Address(RVA = "0x1D979C0", Offset = "0x1D965C0", VA = "0x181D979C0")]
		public void OnOutputCancel()
		{
		}

		// Token: 0x06023171 RID: 143729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023171")]
		[Address(RVA = "0x1D97A60", Offset = "0x1D96660", VA = "0x181D97A60")]
		public void OnOutputConfirm()
		{
		}

		// Token: 0x06023172 RID: 143730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023172")]
		[Address(RVA = "0x1D97B00", Offset = "0x1D96700", VA = "0x181D97B00", Slot = "7")]
		public override void OnValueChanged(ItemRepoIssueVoucherViewProperty property)
		{
		}

		// Token: 0x06023173 RID: 143731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023173")]
		[Address(RVA = "0x1D98370", Offset = "0x1D96F70", VA = "0x181D98370")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023174 RID: 143732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023174")]
		[Address(RVA = "0x1D987A0", Offset = "0x1D973A0", VA = "0x181D987A0")]
		private void _ShowItemDesc(int _)
		{
		}

		// Token: 0x06023175 RID: 143733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023175")]
		[Address(RVA = "0x1D988A0", Offset = "0x1D974A0", VA = "0x181D988A0")]
		public ItemRepoIssueVoucherView()
		{
		}

		// Token: 0x0403056D RID: 197997
		[Token(Token = "0x403056D")]
		private const float TWEEN_DUR = 0.2f;

		// Token: 0x0403056E RID: 197998
		[Token(Token = "0x403056E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _chooseGroup;

		// Token: 0x0403056F RID: 197999
		[Token(Token = "0x403056F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _consume0Text;

		// Token: 0x04030570 RID: 198000
		[Token(Token = "0x4030570")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _possessCountText;

		// Token: 0x04030571 RID: 198001
		[Token(Token = "0x4030571")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LoopScrollRect _chooseScrollRect;

		// Token: 0x04030572 RID: 198002
		[Token(Token = "0x4030572")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ItemRepoIssueVoucherItemListAdapter _chooseAdapter;

		// Token: 0x04030573 RID: 198003
		[Token(Token = "0x4030573")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _confirmValidPanel;

		// Token: 0x04030574 RID: 198004
		[Token(Token = "0x4030574")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _confirmInvalidPanel;

		// Token: 0x04030575 RID: 198005
		[Token(Token = "0x4030575")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _outputGroup;

		// Token: 0x04030576 RID: 198006
		[Token(Token = "0x4030576")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _consume1Text;

		// Token: 0x04030577 RID: 198007
		[Token(Token = "0x4030577")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _inputHolder;

		// Token: 0x04030578 RID: 198008
		[Token(Token = "0x4030578")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _inputCountText;

		// Token: 0x04030579 RID: 198009
		[Token(Token = "0x4030579")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ScrollRect _outputScrollRect;

		// Token: 0x0403057A RID: 198010
		[Token(Token = "0x403057A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _outputContent;

		// Token: 0x0403057B RID: 198011
		[Token(Token = "0x403057B")]
		[FieldOffset(Offset = "0x88")]
		private float m_itemCardScale;

		// Token: 0x0403057C RID: 198012
		[Token(Token = "0x403057C")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_hasInited;

		// Token: 0x0403057D RID: 198013
		[Token(Token = "0x403057D")]
		[FieldOffset(Offset = "0x90")]
		private UIItemCard m_inputItemCard;

		// Token: 0x0403057E RID: 198014
		[Token(Token = "0x403057E")]
		[FieldOffset(Offset = "0x98")]
		private ItemRepoIssueVoucherView.OutputAdapter m_outputAdapter;

		// Token: 0x0403057F RID: 198015
		[Token(Token = "0x403057F")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_finder;

		// Token: 0x04030580 RID: 198016
		[Token(Token = "0x4030580")]
		[FieldOffset(Offset = "0xB0")]
		private FadeSwitchTween m_choosePanelShowTween;

		// Token: 0x04030581 RID: 198017
		[Token(Token = "0x4030581")]
		[FieldOffset(Offset = "0xB8")]
		private FadeSwitchTween m_outputPanelShowTween;

		// Token: 0x04030582 RID: 198018
		[Token(Token = "0x4030582")]
		[FieldOffset(Offset = "0xC0")]
		private List<ItemRepoIssueVoucherItemViewModel> m_cachedOutputItems;

		// Token: 0x04030583 RID: 198019
		[Token(Token = "0x4030583")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_cachedIsChoosing;

		// Token: 0x04030585 RID: 198021
		[Token(Token = "0x4030585")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSelectItem;

		// Token: 0x04030586 RID: 198022
		[Token(Token = "0x4030586")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSelectItem;

		// Token: 0x04030587 RID: 198023
		[Token(Token = "0x4030587")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnChooseConfirm;

		// Token: 0x04030588 RID: 198024
		[Token(Token = "0x4030588")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnOutputCancel;

		// Token: 0x04030589 RID: 198025
		[Token(Token = "0x4030589")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnOutputConfirm;

		// Token: 0x0403058A RID: 198026
		[Token(Token = "0x403058A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403058B RID: 198027
		[Token(Token = "0x403058B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403058C RID: 198028
		[Token(Token = "0x403058C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowItemDesc;

		// Token: 0x0403058D RID: 198029
		[Token(Token = "0x403058D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005EA0 RID: 24224
		[Token(Token = "0x2005EA0")]
		private class OutputAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005322 RID: 21282
			// (get) Token: 0x06023176 RID: 143734 RVA: 0x000BFE98 File Offset: 0x000BE098
			[Token(Token = "0x17005322")]
			public override int count
			{
				[Token(Token = "0x6023176")]
				[Address(RVA = "0x1DA55B0", Offset = "0x1DA41B0", VA = "0x181DA55B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023177 RID: 143735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023177")]
			[Address(RVA = "0x1DA5530", Offset = "0x1DA4130", VA = "0x181DA5530")]
			public OutputAdapter(ItemRepoIssueVoucherView closure)
			{
			}

			// Token: 0x06023178 RID: 143736 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023178")]
			[Address(RVA = "0x1DA5370", Offset = "0x1DA3F70", VA = "0x181DA5370", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403058E RID: 198030
			[Token(Token = "0x403058E")]
			[FieldOffset(Offset = "0x20")]
			private ItemRepoIssueVoucherView m_closure;

			// Token: 0x0403058F RID: 198031
			[Token(Token = "0x403058F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030590 RID: 198032
			[Token(Token = "0x4030590")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04030591 RID: 198033
			[Token(Token = "0x4030591")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
