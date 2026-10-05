using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act29sign.View
{
	// Token: 0x020074A7 RID: 29863
	[Token(Token = "0x20074A7")]
	public class Act29signSpecialCheckinItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A1E2 RID: 172514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1E2")]
		[Address(RVA = "0x25BC6C0", Offset = "0x25BB2C0", VA = "0x1825BC6C0")]
		public void RenderItemView(Act29signSpecialCheckinItemViewModel viewModel)
		{
		}

		// Token: 0x0602A1E3 RID: 172515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1E3")]
		[Address(RVA = "0x25BCB70", Offset = "0x25BB770", VA = "0x1825BCB70")]
		private void _RenderCardSubObjList(int order, List<ItemBundle> itemList, bool isClickable)
		{
		}

		// Token: 0x0602A1E4 RID: 172516 RVA: 0x000D7790 File Offset: 0x000D5990
		[Token(Token = "0x602A1E4")]
		[Address(RVA = "0x25BCA40", Offset = "0x25BB640", VA = "0x1825BCA40")]
		private ActivityCheckinCardSubObjListTool.ItemObjConfig _GetItemObjConfig(int count)
		{
			return default(ActivityCheckinCardSubObjListTool.ItemObjConfig);
		}

		// Token: 0x0602A1E5 RID: 172517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1E5")]
		[Address(RVA = "0x25BC650", Offset = "0x25BB250", VA = "0x1825BC650")]
		public void OnReceive()
		{
		}

		// Token: 0x0602A1E6 RID: 172518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1E6")]
		[Address(RVA = "0x25BCE40", Offset = "0x25BBA40", VA = "0x1825BCE40")]
		public Act29signSpecialCheckinItem()
		{
		}

		// Token: 0x0403C7B2 RID: 247730
		[Token(Token = "0x403C7B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("General")]
		private UIAtlasImage _specialNormalBg;

		// Token: 0x0403C7B3 RID: 247731
		[Token(Token = "0x403C7B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("General")]
		private Image _orderIndexIcon;

		// Token: 0x0403C7B4 RID: 247732
		[Token(Token = "0x403C7B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("General")]
		private Text _progressText;

		// Token: 0x0403C7B5 RID: 247733
		[Token(Token = "0x403C7B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("General")]
		private GameObject _hotSpot;

		// Token: 0x0403C7B6 RID: 247734
		[Token(Token = "0x403C7B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("General")]
		private ActivityCheckinCardSubObjListTool.ItemObjConfig[] _cardSubObjConfigs;

		// Token: 0x0403C7B7 RID: 247735
		[Token(Token = "0x403C7B7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("General")]
		private UIAtlasImage _toBeDeterminedIcon;

		// Token: 0x0403C7B8 RID: 247736
		[Token(Token = "0x403C7B8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("General")]
		private SimpleLayoutContent _subItemListContainer;

		// Token: 0x0403C7B9 RID: 247737
		[Token(Token = "0x403C7B9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Already Get Image")]
		private Image _alreadyGetMask;

		// Token: 0x0403C7BA RID: 247738
		[Token(Token = "0x403C7BA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Already Get Image")]
		private Image _alreadyGetImg;

		// Token: 0x0403C7BB RID: 247739
		[Token(Token = "0x403C7BB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Already Get Image")]
		private Image _alreadyGetLabel;

		// Token: 0x0403C7BC RID: 247740
		[Token(Token = "0x403C7BC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Already Get Image")]
		private UIAtlasImage _specialAlreadyGetLabel;

		// Token: 0x0403C7BD RID: 247741
		[Token(Token = "0x403C7BD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Already Get Image")]
		private Text _specialAlreadyGetText;

		// Token: 0x0403C7BE RID: 247742
		[Token(Token = "0x403C7BE")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public UnityEvent clickEvent;

		// Token: 0x0403C7BF RID: 247743
		[Token(Token = "0x403C7BF")]
		[FieldOffset(Offset = "0x80")]
		private int m_order;

		// Token: 0x0403C7C0 RID: 247744
		[Token(Token = "0x403C7C0")]
		[FieldOffset(Offset = "0x84")]
		private bool m_isClickable;

		// Token: 0x0403C7C1 RID: 247745
		[Token(Token = "0x403C7C1")]
		[FieldOffset(Offset = "0x88")]
		private ActivityCheckinCardSubObjListTool m_activityCheckinCardSubObjListTool;

		// Token: 0x0403C7C2 RID: 247746
		[Token(Token = "0x403C7C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderItemView;

		// Token: 0x0403C7C3 RID: 247747
		[Token(Token = "0x403C7C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCardSubObjList;

		// Token: 0x0403C7C4 RID: 247748
		[Token(Token = "0x403C7C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetItemObjConfig;

		// Token: 0x0403C7C5 RID: 247749
		[Token(Token = "0x403C7C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnReceive;

		// Token: 0x0403C7C6 RID: 247750
		[Token(Token = "0x403C7C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
