using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ItemRepo;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BD6 RID: 19414
	[Token(Token = "0x2004BD6")]
	public class HomeAPUseApItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D2E2 RID: 119522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2E2")]
		[Address(RVA = "0x16BACC0", Offset = "0x16B98C0", VA = "0x1816BACC0")]
		public void ClickItem(int selectIndex)
		{
		}

		// Token: 0x0601D2E3 RID: 119523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2E3")]
		[Address(RVA = "0x16BABE0", Offset = "0x16B97E0", VA = "0x1816BABE0")]
		public void CleanItem(int selectIndex)
		{
		}

		// Token: 0x0601D2E4 RID: 119524 RVA: 0x000AAD30 File Offset: 0x000A8F30
		[Token(Token = "0x601D2E4")]
		[Address(RVA = "0x16BAE30", Offset = "0x16B9A30", VA = "0x1816BAE30")]
		public bool LongPress(int selectIndex)
		{
			return default(bool);
		}

		// Token: 0x0601D2E5 RID: 119525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2E5")]
		[Address(RVA = "0x16BAAD0", Offset = "0x16B96D0", VA = "0x1816BAAD0")]
		public void CleanAll()
		{
		}

		// Token: 0x0601D2E6 RID: 119526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2E6")]
		[Address(RVA = "0x16BB760", Offset = "0x16BA360", VA = "0x1816BB760")]
		public void SendUseAPItem()
		{
		}

		// Token: 0x0601D2E7 RID: 119527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2E7")]
		[Address(RVA = "0x16BBA10", Offset = "0x16BA610", VA = "0x1816BBA10")]
		private void _InitData()
		{
		}

		// Token: 0x0601D2E8 RID: 119528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2E8")]
		[Address(RVA = "0x16BB090", Offset = "0x16B9C90", VA = "0x1816BB090")]
		public void RenderCurrentItem()
		{
		}

		// Token: 0x0601D2E9 RID: 119529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2E9")]
		[Address(RVA = "0x16BB350", Offset = "0x16B9F50", VA = "0x1816BB350")]
		public void Render(int requireAp = 0)
		{
		}

		// Token: 0x0601D2EA RID: 119530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2EA")]
		[Address(RVA = "0x16BB010", Offset = "0x16B9C10", VA = "0x1816BB010")]
		public void RefreshInfo(int position)
		{
		}

		// Token: 0x0601D2EB RID: 119531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2EB")]
		[Address(RVA = "0x16BBAE0", Offset = "0x16BA6E0", VA = "0x1816BBAE0")]
		public HomeAPUseApItemView()
		{
		}

		// Token: 0x040264BC RID: 156860
		[Token(Token = "0x40264BC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x040264BD RID: 156861
		[Token(Token = "0x40264BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _restoreAP;

		// Token: 0x040264BE RID: 156862
		[Token(Token = "0x40264BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _itemLayout;

		// Token: 0x040264BF RID: 156863
		[Token(Token = "0x40264BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _scaleFactor;

		// Token: 0x040264C0 RID: 156864
		[Token(Token = "0x40264C0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent _refreshEvent;

		// Token: 0x040264C1 RID: 156865
		[Token(Token = "0x40264C1")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public ItemRepoActionPointViewModelWithBuyApCount apProperty;

		// Token: 0x040264C2 RID: 156866
		[Token(Token = "0x40264C2")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<List<UIItemViewModel>> onClick;

		// Token: 0x040264C3 RID: 156867
		[Token(Token = "0x40264C3")]
		[FieldOffset(Offset = "0x50")]
		private HomeAPUseApItemView.APItemAdapter m_itemAdapter;

		// Token: 0x040264C4 RID: 156868
		[Token(Token = "0x40264C4")]
		[FieldOffset(Offset = "0x58")]
		private List<UIItemViewModel> m_viewModelList;

		// Token: 0x040264C5 RID: 156869
		[Token(Token = "0x40264C5")]
		[FieldOffset(Offset = "0x60")]
		private UIItemCard m_itemCard;

		// Token: 0x040264C6 RID: 156870
		[Token(Token = "0x40264C6")]
		[FieldOffset(Offset = "0x68")]
		private bool m_initCardFlag;

		// Token: 0x040264C7 RID: 156871
		[Token(Token = "0x40264C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ClickItem;

		// Token: 0x040264C8 RID: 156872
		[Token(Token = "0x40264C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CleanItem;

		// Token: 0x040264C9 RID: 156873
		[Token(Token = "0x40264C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LongPress;

		// Token: 0x040264CA RID: 156874
		[Token(Token = "0x40264CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CleanAll;

		// Token: 0x040264CB RID: 156875
		[Token(Token = "0x40264CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SendUseAPItem;

		// Token: 0x040264CC RID: 156876
		[Token(Token = "0x40264CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x040264CD RID: 156877
		[Token(Token = "0x40264CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RenderCurrentItem;

		// Token: 0x040264CE RID: 156878
		[Token(Token = "0x40264CE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040264CF RID: 156879
		[Token(Token = "0x40264CF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshInfo;

		// Token: 0x040264D0 RID: 156880
		[Token(Token = "0x40264D0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BD7 RID: 19415
		[Token(Token = "0x2004BD7")]
		public class APItemInfo
		{
			// Token: 0x0601D2EC RID: 119532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D2EC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public APItemInfo()
			{
			}

			// Token: 0x040264D1 RID: 156881
			[Token(Token = "0x40264D1")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x040264D2 RID: 156882
			[Token(Token = "0x40264D2")]
			[FieldOffset(Offset = "0x18")]
			public long outTimeTs;

			// Token: 0x040264D3 RID: 156883
			[Token(Token = "0x40264D3")]
			[FieldOffset(Offset = "0x20")]
			public int count;
		}

		// Token: 0x02004BD8 RID: 19416
		[Token(Token = "0x2004BD8")]
		public class APItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170044A6 RID: 17574
			// (get) Token: 0x0601D2ED RID: 119533 RVA: 0x000AAD48 File Offset: 0x000A8F48
			[Token(Token = "0x170044A6")]
			public override int count
			{
				[Token(Token = "0x601D2ED")]
				[Address(RVA = "0x16B0810", Offset = "0x16AF410", VA = "0x1816B0810", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D2EE RID: 119534 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D2EE")]
			[Address(RVA = "0x16B03A0", Offset = "0x16AEFA0", VA = "0x1816B03A0")]
			public void InitSelect(int requireAP)
			{
			}

			// Token: 0x0601D2EF RID: 119535 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D2EF")]
			[Address(RVA = "0x16B0450", Offset = "0x16AF050", VA = "0x1816B0450", Slot = "5")]
			public override GameObject RenderView(int position, GameObject _, Transform parent)
			{
				return null;
			}

			// Token: 0x0601D2F0 RID: 119536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D2F0")]
			[Address(RVA = "0x16B07B0", Offset = "0x16AF3B0", VA = "0x1816B07B0")]
			public APItemAdapter()
			{
			}

			// Token: 0x040264D4 RID: 156884
			[Token(Token = "0x40264D4")]
			[FieldOffset(Offset = "0x20")]
			public List<UIItemViewModel> itemInfo;

			// Token: 0x040264D5 RID: 156885
			[Token(Token = "0x40264D5")]
			[FieldOffset(Offset = "0x28")]
			public List<int> selectCount;

			// Token: 0x040264D6 RID: 156886
			[Token(Token = "0x40264D6")]
			[FieldOffset(Offset = "0x30")]
			public float scaleFactor;

			// Token: 0x040264D7 RID: 156887
			[Token(Token = "0x40264D7")]
			[FieldOffset(Offset = "0x38")]
			public Action<int> clickEvent;

			// Token: 0x040264D8 RID: 156888
			[Token(Token = "0x40264D8")]
			[FieldOffset(Offset = "0x40")]
			public Action<int> cleanEvent;

			// Token: 0x040264D9 RID: 156889
			[Token(Token = "0x40264D9")]
			[FieldOffset(Offset = "0x48")]
			public Func<int, bool> longpressEvent;

			// Token: 0x040264DA RID: 156890
			[Token(Token = "0x40264DA")]
			[FieldOffset(Offset = "0x50")]
			private HomeAPUseApItemObj m_prefab;

			// Token: 0x040264DB RID: 156891
			[Token(Token = "0x40264DB")]
			[FieldOffset(Offset = "0x58")]
			public Action<int> refreshEvent;

			// Token: 0x040264DC RID: 156892
			[Token(Token = "0x40264DC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040264DD RID: 156893
			[Token(Token = "0x40264DD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_InitSelect;

			// Token: 0x040264DE RID: 156894
			[Token(Token = "0x40264DE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040264DF RID: 156895
			[Token(Token = "0x40264DF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
