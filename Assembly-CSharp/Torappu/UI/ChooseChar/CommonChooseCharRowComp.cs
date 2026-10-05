using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A1C RID: 23068
	[Token(Token = "0x2005A1C")]
	public class CommonChooseCharRowComp : MonoBehaviour, IHotfixable
	{
		// Token: 0x060219A4 RID: 137636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219A4")]
		[Address(RVA = "0x1C02810", Offset = "0x1C01410", VA = "0x181C02810")]
		public void Render(CommonChooseCharRowComp.ViewModel viewModel)
		{
		}

		// Token: 0x060219A5 RID: 137637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219A5")]
		[Address(RVA = "0x1C02AB0", Offset = "0x1C016B0", VA = "0x181C02AB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060219A6 RID: 137638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219A6")]
		[Address(RVA = "0x1C02BC0", Offset = "0x1C017C0", VA = "0x181C02BC0")]
		public CommonChooseCharRowComp()
		{
		}

		// Token: 0x0402DEEE RID: 188142
		[Token(Token = "0x402DEEE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _baseHeight;

		// Token: 0x0402DEEF RID: 188143
		[Token(Token = "0x402DEEF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _ownTagHeight;

		// Token: 0x0402DEF0 RID: 188144
		[Token(Token = "0x402DEF0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _simpleLayout;

		// Token: 0x0402DEF1 RID: 188145
		[Token(Token = "0x402DEF1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _ownedPanel;

		// Token: 0x0402DEF2 RID: 188146
		[Token(Token = "0x402DEF2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _notOwnedPanel;

		// Token: 0x0402DEF3 RID: 188147
		[Token(Token = "0x402DEF3")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0402DEF4 RID: 188148
		[Token(Token = "0x402DEF4")]
		[FieldOffset(Offset = "0x40")]
		private CommonChooseCharRowComp.CharCardAdapter m_adapter;

		// Token: 0x0402DEF5 RID: 188149
		[Token(Token = "0x402DEF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DEF6 RID: 188150
		[Token(Token = "0x402DEF6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DEF7 RID: 188151
		[Token(Token = "0x402DEF7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A1D RID: 23069
		[Token(Token = "0x2005A1D")]
		public enum OwnTagStatus
		{
			// Token: 0x0402DEF9 RID: 188153
			[Token(Token = "0x402DEF9")]
			NONE,
			// Token: 0x0402DEFA RID: 188154
			[Token(Token = "0x402DEFA")]
			OWNED,
			// Token: 0x0402DEFB RID: 188155
			[Token(Token = "0x402DEFB")]
			NOT_OWNED
		}

		// Token: 0x02005A1E RID: 23070
		[Token(Token = "0x2005A1E")]
		public struct ViewModel
		{
			// Token: 0x0402DEFC RID: 188156
			[Token(Token = "0x402DEFC")]
			[FieldOffset(Offset = "0x0")]
			public CommonChooseCharRowComp prefab;

			// Token: 0x0402DEFD RID: 188157
			[Token(Token = "0x402DEFD")]
			[FieldOffset(Offset = "0x8")]
			public List<ICommonChooseCharCardViewModel> charItemViewModels;

			// Token: 0x0402DEFE RID: 188158
			[Token(Token = "0x402DEFE")]
			[FieldOffset(Offset = "0x10")]
			public CommonChooseCharRowComp.OwnTagStatus ownTagStatus;

			// Token: 0x0402DEFF RID: 188159
			[Token(Token = "0x402DEFF")]
			[FieldOffset(Offset = "0x18")]
			public Action<string> onItemClick;

			// Token: 0x0402DF00 RID: 188160
			[Token(Token = "0x402DF00")]
			[FieldOffset(Offset = "0x20")]
			public CommonSingleChooseCharGroupView.AbstractViewBuilder viewBuilder;
		}

		// Token: 0x02005A1F RID: 23071
		[Token(Token = "0x2005A1F")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<CommonChooseCharRowComp>
		{
			// Token: 0x060219A7 RID: 137639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219A7")]
			[Address(RVA = "0x1C16530", Offset = "0x1C15130", VA = "0x181C16530")]
			public VirtualView(CommonChooseCharRowComp.ViewModel viewModel)
			{
			}

			// Token: 0x060219A8 RID: 137640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219A8")]
			[Address(RVA = "0x1C16420", Offset = "0x1C15020", VA = "0x181C16420", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x060219A9 RID: 137641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219A9")]
			[Address(RVA = "0x1C164D0", Offset = "0x1C150D0", VA = "0x181C164D0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x060219AA RID: 137642 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60219AA")]
			[Address(RVA = "0x1C16320", Offset = "0x1C14F20", VA = "0x181C16320", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x060219AB RID: 137643 RVA: 0x000BADC8 File Offset: 0x000B8FC8
			[Token(Token = "0x60219AB")]
			[Address(RVA = "0x1C16390", Offset = "0x1C14F90", VA = "0x181C16390", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402DF01 RID: 188161
			[Token(Token = "0x402DF01")]
			[FieldOffset(Offset = "0x20")]
			private CommonChooseCharRowComp.ViewModel m_viewModel;

			// Token: 0x0402DF02 RID: 188162
			[Token(Token = "0x402DF02")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DF03 RID: 188163
			[Token(Token = "0x402DF03")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402DF04 RID: 188164
			[Token(Token = "0x402DF04")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402DF05 RID: 188165
			[Token(Token = "0x402DF05")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402DF06 RID: 188166
			[Token(Token = "0x402DF06")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}

		// Token: 0x02005A20 RID: 23072
		[Token(Token = "0x2005A20")]
		private class CharCardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004EE9 RID: 20201
			// (get) Token: 0x060219AC RID: 137644 RVA: 0x000BADE0 File Offset: 0x000B8FE0
			[Token(Token = "0x17004EE9")]
			public override int count
			{
				[Token(Token = "0x60219AC")]
				[Address(RVA = "0x1C02740", Offset = "0x1C01340", VA = "0x181C02740", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060219AD RID: 137645 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60219AD")]
			[Address(RVA = "0x1C02410", Offset = "0x1C01010", VA = "0x181C02410", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060219AE RID: 137646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219AE")]
			[Address(RVA = "0x1C026E0", Offset = "0x1C012E0", VA = "0x181C026E0")]
			public CharCardAdapter()
			{
			}

			// Token: 0x0402DF07 RID: 188167
			[Token(Token = "0x402DF07")]
			[FieldOffset(Offset = "0x20")]
			public List<ICommonChooseCharCardViewModel> charItemViewModels;

			// Token: 0x0402DF08 RID: 188168
			[Token(Token = "0x402DF08")]
			[FieldOffset(Offset = "0x28")]
			public Action<string> onCardClick;

			// Token: 0x0402DF09 RID: 188169
			[Token(Token = "0x402DF09")]
			[FieldOffset(Offset = "0x30")]
			public CommonSingleChooseCharGroupView.AbstractViewBuilder viewBuilder;

			// Token: 0x0402DF0A RID: 188170
			[Token(Token = "0x402DF0A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402DF0B RID: 188171
			[Token(Token = "0x402DF0B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402DF0C RID: 188172
			[Token(Token = "0x402DF0C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
