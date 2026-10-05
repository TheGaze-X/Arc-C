using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A21 RID: 23073
	[Token(Token = "0x2005A21")]
	public class CommonSingleChooseCharGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060219AF RID: 137647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60219AF")]
		public T GetBuilder<T>() where T : CommonSingleChooseCharGroupView.AbstractViewBuilder, new()
		{
			return null;
		}

		// Token: 0x060219B0 RID: 137648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219B0")]
		[Address(RVA = "0x1C02C20", Offset = "0x1C01820", VA = "0x181C02C20")]
		public void Render(CommonSingleChooseCharGroupView.AbstractViewBuilder viewBuilder)
		{
		}

		// Token: 0x060219B1 RID: 137649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219B1")]
		[Address(RVA = "0x1C03010", Offset = "0x1C01C10", VA = "0x181C03010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060219B2 RID: 137650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219B2")]
		[Address(RVA = "0x1C03180", Offset = "0x1C01D80", VA = "0x181C03180")]
		public CommonSingleChooseCharGroupView()
		{
		}

		// Token: 0x0402DF0D RID: 188173
		[Token(Token = "0x402DF0D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtTitle;

		// Token: 0x0402DF0E RID: 188174
		[Token(Token = "0x402DF0E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _recycleLayout;

		// Token: 0x0402DF0F RID: 188175
		[Token(Token = "0x402DF0F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402DF10 RID: 188176
		[Token(Token = "0x402DF10")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CancelDragIfFits _cancelDragIfFits;

		// Token: 0x0402DF11 RID: 188177
		[Token(Token = "0x402DF11")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CommonChooseCharCardView _cardViewPrefab;

		// Token: 0x0402DF12 RID: 188178
		[Token(Token = "0x402DF12")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0402DF13 RID: 188179
		[Token(Token = "0x402DF13")]
		[FieldOffset(Offset = "0x48")]
		private CommonSingleChooseCharGroupView.Adapter m_adapter;

		// Token: 0x0402DF14 RID: 188180
		[Token(Token = "0x402DF14")]
		[FieldOffset(Offset = "0x50")]
		private IList<UIRecycleLayoutAdapter.IVirtualView> m_views;

		// Token: 0x0402DF15 RID: 188181
		[Token(Token = "0x402DF15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBuilder;

		// Token: 0x0402DF16 RID: 188182
		[Token(Token = "0x402DF16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DF17 RID: 188183
		[Token(Token = "0x402DF17")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DF18 RID: 188184
		[Token(Token = "0x402DF18")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A22 RID: 23074
		[Token(Token = "0x2005A22")]
		public abstract class AbstractViewBuilder : IHotfixable
		{
			// Token: 0x060219B4 RID: 137652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219B4")]
			[Address(RVA = "0x1C01740", Offset = "0x1C00340", VA = "0x181C01740")]
			public void BindView(CommonSingleChooseCharGroupView closure)
			{
			}

			// Token: 0x060219B5 RID: 137653
			[Token(Token = "0x60219B5")]
			public abstract string GetTitleText();

			// Token: 0x060219B6 RID: 137654
			[Token(Token = "0x60219B6")]
			public abstract IList<UIRecycleLayoutAdapter.IVirtualView> GetVirtualViews();

			// Token: 0x060219B7 RID: 137655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60219B7")]
			[Address(RVA = "0x1C017C0", Offset = "0x1C003C0", VA = "0x181C017C0")]
			public CommonChooseCharCardView InstantiateCard(CommonChooseCharCardView prefab, Transform transform)
			{
				return null;
			}

			// Token: 0x060219B8 RID: 137656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219B8")]
			[Address(RVA = "0x1C018C0", Offset = "0x1C004C0", VA = "0x181C018C0")]
			protected AbstractViewBuilder()
			{
			}

			// Token: 0x0402DF19 RID: 188185
			[Token(Token = "0x402DF19")]
			[FieldOffset(Offset = "0x10")]
			private CommonSingleChooseCharGroupView m_closure;

			// Token: 0x0402DF1A RID: 188186
			[Token(Token = "0x402DF1A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_BindView;

			// Token: 0x0402DF1B RID: 188187
			[Token(Token = "0x402DF1B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_InstantiateCard;

			// Token: 0x0402DF1C RID: 188188
			[Token(Token = "0x402DF1C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005A23 RID: 23075
		[Token(Token = "0x2005A23")]
		private class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x060219B9 RID: 137657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219B9")]
			[Address(RVA = "0x1C02150", Offset = "0x1C00D50", VA = "0x181C02150")]
			public Adapter(CommonSingleChooseCharGroupView closure)
			{
			}

			// Token: 0x060219BA RID: 137658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60219BA")]
			[Address(RVA = "0x1C019F0", Offset = "0x1C005F0", VA = "0x181C019F0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x060219BB RID: 137659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219BB")]
			[Address(RVA = "0x1C01AD0", Offset = "0x1C006D0", VA = "0x181C01AD0")]
			public void NotifyRebuild()
			{
			}

			// Token: 0x0402DF1D RID: 188189
			[Token(Token = "0x402DF1D")]
			[FieldOffset(Offset = "0x18")]
			private readonly CommonSingleChooseCharGroupView m_closure;

			// Token: 0x0402DF1E RID: 188190
			[Token(Token = "0x402DF1E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DF1F RID: 188191
			[Token(Token = "0x402DF1F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0402DF20 RID: 188192
			[Token(Token = "0x402DF20")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_NotifyRebuild;
		}
	}
}
