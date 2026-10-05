using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200636D RID: 25453
	[Token(Token = "0x200636D")]
	public class AutoChessShopQuickAssistOnlyItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024B92 RID: 150418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B92")]
		[Address(RVA = "0x1FA15E0", Offset = "0x1FA01E0", VA = "0x181FA15E0")]
		public void Render(AutoChessShopQuickAssistListOnlyItemViewModel viewModel)
		{
		}

		// Token: 0x06024B93 RID: 150419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B93")]
		[Address(RVA = "0x1FA1770", Offset = "0x1FA0370", VA = "0x181FA1770")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024B94 RID: 150420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B94")]
		[Address(RVA = "0x1FA1850", Offset = "0x1FA0450", VA = "0x181FA1850")]
		public AutoChessShopQuickAssistOnlyItemView()
		{
		}

		// Token: 0x0403348E RID: 210062
		[Token(Token = "0x403348E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _preferSize;

		// Token: 0x0403348F RID: 210063
		[Token(Token = "0x403348F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessShopQuickAssistItemView _itemViewPrefab;

		// Token: 0x04033490 RID: 210064
		[Token(Token = "0x4033490")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x04033491 RID: 210065
		[Token(Token = "0x4033491")]
		[FieldOffset(Offset = "0x30")]
		private AutoChessShopQuickAssistItemView m_itemView;

		// Token: 0x04033492 RID: 210066
		[Token(Token = "0x4033492")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033493 RID: 210067
		[Token(Token = "0x4033493")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033494 RID: 210068
		[Token(Token = "0x4033494")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200636E RID: 25454
		[Token(Token = "0x200636E")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<AutoChessShopQuickAssistOnlyItemView>
		{
			// Token: 0x06024B95 RID: 150421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B95")]
			[Address(RVA = "0x1FAECB0", Offset = "0x1FAD8B0", VA = "0x181FAECB0")]
			public VirtualView(AutoChessShopQuickAssistOnlyItemView prefab, AutoChessShopQuickAssistListOnlyItemViewModel viewModel)
			{
			}

			// Token: 0x06024B96 RID: 150422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024B96")]
			[Address(RVA = "0x1FAE730", Offset = "0x1FAD330", VA = "0x181FAE730", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06024B97 RID: 150423 RVA: 0x000C5520 File Offset: 0x000C3720
			[Token(Token = "0x6024B97")]
			[Address(RVA = "0x1FAE880", Offset = "0x1FAD480", VA = "0x181FAE880", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06024B98 RID: 150424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B98")]
			[Address(RVA = "0x1FAEA10", Offset = "0x1FAD610", VA = "0x181FAEA10", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06024B99 RID: 150425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B99")]
			[Address(RVA = "0x1FAE8F0", Offset = "0x1FAD4F0", VA = "0x181FAE8F0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06024B9A RID: 150426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B9A")]
			[Address(RVA = "0x1FAEAD0", Offset = "0x1FAD6D0", VA = "0x181FAEAD0")]
			public void TryRefreshAssistItemView(AutoChessShopQuickAssistListOnlyItemViewModel viewModel)
			{
			}

			// Token: 0x04033495 RID: 210069
			[Token(Token = "0x4033495")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessShopQuickAssistOnlyItemView m_prefab;

			// Token: 0x04033496 RID: 210070
			[Token(Token = "0x4033496")]
			[FieldOffset(Offset = "0x28")]
			private AutoChessShopQuickAssistListOnlyItemViewModel m_viewModel;

			// Token: 0x04033497 RID: 210071
			[Token(Token = "0x4033497")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033498 RID: 210072
			[Token(Token = "0x4033498")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04033499 RID: 210073
			[Token(Token = "0x4033499")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0403349A RID: 210074
			[Token(Token = "0x403349A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0403349B RID: 210075
			[Token(Token = "0x403349B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0403349C RID: 210076
			[Token(Token = "0x403349C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_TryRefreshAssistItemView;
		}
	}
}
