using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068FA RID: 26874
	[Token(Token = "0x20068FA")]
	public class StageUseApItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060267FB RID: 157691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267FB")]
		[Address(RVA = "0x21A2350", Offset = "0x21A0F50", VA = "0x1821A2350")]
		public void ClickItem(int selectIndex)
		{
		}

		// Token: 0x060267FC RID: 157692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267FC")]
		[Address(RVA = "0x21A2CA0", Offset = "0x21A18A0", VA = "0x1821A2CA0")]
		private void _InitData()
		{
		}

		// Token: 0x060267FD RID: 157693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267FD")]
		[Address(RVA = "0x21A24D0", Offset = "0x21A10D0", VA = "0x1821A24D0")]
		public void RenderCurrentItem(string itemId)
		{
		}

		// Token: 0x060267FE RID: 157694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267FE")]
		[Address(RVA = "0x21A2D70", Offset = "0x21A1970", VA = "0x1821A2D70")]
		private void _InitItemCard()
		{
		}

		// Token: 0x060267FF RID: 157695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267FF")]
		[Address(RVA = "0x21A2750", Offset = "0x21A1350", VA = "0x1821A2750")]
		public void Render()
		{
		}

		// Token: 0x06026800 RID: 157696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026800")]
		[Address(RVA = "0x21A2450", Offset = "0x21A1050", VA = "0x1821A2450")]
		public void RefreshInfo(int position)
		{
		}

		// Token: 0x06026801 RID: 157697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026801")]
		[Address(RVA = "0x21A2EF0", Offset = "0x21A1AF0", VA = "0x1821A2EF0")]
		public StageUseApItemView()
		{
		}

		// Token: 0x040363EC RID: 222188
		[Token(Token = "0x40363EC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040363ED RID: 222189
		[Token(Token = "0x40363ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIItemCard _itemCard;

		// Token: 0x040363EE RID: 222190
		[Token(Token = "0x40363EE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x040363EF RID: 222191
		[Token(Token = "0x40363EF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _restoreAP;

		// Token: 0x040363F0 RID: 222192
		[Token(Token = "0x40363F0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _itemLayout;

		// Token: 0x040363F1 RID: 222193
		[Token(Token = "0x40363F1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _scaleFactor;

		// Token: 0x040363F2 RID: 222194
		[Token(Token = "0x40363F2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEvent _refreshEvent;

		// Token: 0x040363F3 RID: 222195
		[Token(Token = "0x40363F3")]
		[FieldOffset(Offset = "0x50")]
		private StageUseApItemView.APItemAdapter m_itemAdapter;

		// Token: 0x040363F4 RID: 222196
		[Token(Token = "0x40363F4")]
		[FieldOffset(Offset = "0x58")]
		private List<UIItemViewModel> m_viewModelList;

		// Token: 0x040363F5 RID: 222197
		[Token(Token = "0x40363F5")]
		[FieldOffset(Offset = "0x60")]
		private UIItemCard m_itemCard;

		// Token: 0x040363F6 RID: 222198
		[Token(Token = "0x40363F6")]
		[FieldOffset(Offset = "0x68")]
		private bool m_initCardFlag;

		// Token: 0x040363F7 RID: 222199
		[Token(Token = "0x40363F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ClickItem;

		// Token: 0x040363F8 RID: 222200
		[Token(Token = "0x40363F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x040363F9 RID: 222201
		[Token(Token = "0x40363F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderCurrentItem;

		// Token: 0x040363FA RID: 222202
		[Token(Token = "0x40363FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitItemCard;

		// Token: 0x040363FB RID: 222203
		[Token(Token = "0x40363FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040363FC RID: 222204
		[Token(Token = "0x40363FC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshInfo;

		// Token: 0x040363FD RID: 222205
		[Token(Token = "0x40363FD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020068FB RID: 26875
		[Token(Token = "0x20068FB")]
		public class APItemInfo
		{
			// Token: 0x06026802 RID: 157698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026802")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public APItemInfo()
			{
			}

			// Token: 0x040363FE RID: 222206
			[Token(Token = "0x40363FE")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x040363FF RID: 222207
			[Token(Token = "0x40363FF")]
			[FieldOffset(Offset = "0x18")]
			public long outTimeTs;

			// Token: 0x04036400 RID: 222208
			[Token(Token = "0x4036400")]
			[FieldOffset(Offset = "0x20")]
			public int count;
		}

		// Token: 0x020068FC RID: 26876
		[Token(Token = "0x20068FC")]
		private class APItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005AE8 RID: 23272
			// (get) Token: 0x06026803 RID: 157699 RVA: 0x000CB5B0 File Offset: 0x000C97B0
			[Token(Token = "0x17005AE8")]
			public override int count
			{
				[Token(Token = "0x6026803")]
				[Address(RVA = "0x2190730", Offset = "0x218F330", VA = "0x182190730", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026804 RID: 157700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026804")]
			[Address(RVA = "0x2190250", Offset = "0x218EE50", VA = "0x182190250")]
			public void InitSelect()
			{
			}

			// Token: 0x06026805 RID: 157701 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026805")]
			[Address(RVA = "0x2190350", Offset = "0x218EF50", VA = "0x182190350", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06026806 RID: 157702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026806")]
			[Address(RVA = "0x21906D0", Offset = "0x218F2D0", VA = "0x1821906D0")]
			public APItemAdapter()
			{
			}

			// Token: 0x04036401 RID: 222209
			[Token(Token = "0x4036401")]
			[FieldOffset(Offset = "0x20")]
			public List<UIItemViewModel> itemInfo;

			// Token: 0x04036402 RID: 222210
			[Token(Token = "0x4036402")]
			[FieldOffset(Offset = "0x28")]
			public int selectIndex;

			// Token: 0x04036403 RID: 222211
			[Token(Token = "0x4036403")]
			[FieldOffset(Offset = "0x2C")]
			public float scaleFactor;

			// Token: 0x04036404 RID: 222212
			[Token(Token = "0x4036404")]
			[FieldOffset(Offset = "0x30")]
			public Action<int> clickEvent;

			// Token: 0x04036405 RID: 222213
			[Token(Token = "0x4036405")]
			[FieldOffset(Offset = "0x38")]
			public Action<int> refreshEvent;

			// Token: 0x04036406 RID: 222214
			[Token(Token = "0x4036406")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04036407 RID: 222215
			[Token(Token = "0x4036407")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_InitSelect;

			// Token: 0x04036408 RID: 222216
			[Token(Token = "0x4036408")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04036409 RID: 222217
			[Token(Token = "0x4036409")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
