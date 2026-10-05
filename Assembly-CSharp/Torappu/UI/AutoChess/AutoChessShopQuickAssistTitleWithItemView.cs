using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200636F RID: 25455
	[Token(Token = "0x200636F")]
	public class AutoChessShopQuickAssistTitleWithItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024B9B RID: 150427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B9B")]
		[Address(RVA = "0x1FA18B0", Offset = "0x1FA04B0", VA = "0x181FA18B0")]
		public void Render(AutoChessShopQuickAssistListTitleWithItemViewModel viewModel)
		{
		}

		// Token: 0x06024B9C RID: 150428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B9C")]
		[Address(RVA = "0x1FA1AB0", Offset = "0x1FA06B0", VA = "0x181FA1AB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024B9D RID: 150429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B9D")]
		[Address(RVA = "0x1FA1BC0", Offset = "0x1FA07C0", VA = "0x181FA1BC0")]
		public AutoChessShopQuickAssistTitleWithItemView()
		{
		}

		// Token: 0x0403349D RID: 210077
		[Token(Token = "0x403349D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _preferSize;

		// Token: 0x0403349E RID: 210078
		[Token(Token = "0x403349E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _transTagHolder;

		// Token: 0x0403349F RID: 210079
		[Token(Token = "0x403349F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AutoChessShopLevelTagView _tagViewPrefab;

		// Token: 0x040334A0 RID: 210080
		[Token(Token = "0x40334A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _transItemHolder;

		// Token: 0x040334A1 RID: 210081
		[Token(Token = "0x40334A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AutoChessShopQuickAssistItemView _itemViewPrefab;

		// Token: 0x040334A2 RID: 210082
		[Token(Token = "0x40334A2")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x040334A3 RID: 210083
		[Token(Token = "0x40334A3")]
		[FieldOffset(Offset = "0x48")]
		private AutoChessShopLevelTagView m_tagView;

		// Token: 0x040334A4 RID: 210084
		[Token(Token = "0x40334A4")]
		[FieldOffset(Offset = "0x50")]
		private AutoChessShopQuickAssistItemView m_itemView;

		// Token: 0x040334A5 RID: 210085
		[Token(Token = "0x40334A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040334A6 RID: 210086
		[Token(Token = "0x40334A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040334A7 RID: 210087
		[Token(Token = "0x40334A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006370 RID: 25456
		[Token(Token = "0x2006370")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<AutoChessShopQuickAssistTitleWithItemView>
		{
			// Token: 0x06024B9E RID: 150430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B9E")]
			[Address(RVA = "0x1FAED60", Offset = "0x1FAD960", VA = "0x181FAED60")]
			public VirtualView(AutoChessShopQuickAssistTitleWithItemView prefab, AutoChessShopQuickAssistListTitleWithItemViewModel viewModel)
			{
			}

			// Token: 0x06024B9F RID: 150431 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024B9F")]
			[Address(RVA = "0x1FAE7A0", Offset = "0x1FAD3A0", VA = "0x181FAE7A0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06024BA0 RID: 150432 RVA: 0x000C5538 File Offset: 0x000C3738
			[Token(Token = "0x6024BA0")]
			[Address(RVA = "0x1FAE810", Offset = "0x1FAD410", VA = "0x181FAE810", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06024BA1 RID: 150433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BA1")]
			[Address(RVA = "0x1FAEA70", Offset = "0x1FAD670", VA = "0x181FAEA70", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06024BA2 RID: 150434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BA2")]
			[Address(RVA = "0x1FAE980", Offset = "0x1FAD580", VA = "0x181FAE980", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06024BA3 RID: 150435 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BA3")]
			[Address(RVA = "0x1FAEBC0", Offset = "0x1FAD7C0", VA = "0x181FAEBC0")]
			public void TryRefreshAssistItemView(AutoChessShopQuickAssistListTitleWithItemViewModel viewModel)
			{
			}

			// Token: 0x040334A8 RID: 210088
			[Token(Token = "0x40334A8")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessShopQuickAssistTitleWithItemView m_prefab;

			// Token: 0x040334A9 RID: 210089
			[Token(Token = "0x40334A9")]
			[FieldOffset(Offset = "0x28")]
			private AutoChessShopQuickAssistListTitleWithItemViewModel m_viewModel;

			// Token: 0x040334AA RID: 210090
			[Token(Token = "0x40334AA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040334AB RID: 210091
			[Token(Token = "0x40334AB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x040334AC RID: 210092
			[Token(Token = "0x40334AC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x040334AD RID: 210093
			[Token(Token = "0x40334AD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x040334AE RID: 210094
			[Token(Token = "0x40334AE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x040334AF RID: 210095
			[Token(Token = "0x40334AF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_TryRefreshAssistItemView;
		}
	}
}
