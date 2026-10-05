using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006380 RID: 25472
	[Token(Token = "0x2006380")]
	public class AutoChessShopLevelTrapGroupItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170056C2 RID: 22210
		// (get) Token: 0x06024BEE RID: 150510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056C2")]
		public GridLayoutGroup gridLayout
		{
			[Token(Token = "0x6024BEE")]
			[Address(RVA = "0x1FA0810", Offset = "0x1F9F410", VA = "0x181FA0810")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024BEF RID: 150511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BEF")]
		[Address(RVA = "0x1FA0350", Offset = "0x1F9EF50", VA = "0x181FA0350")]
		public void Render(AutoChessShopTrapListRecycleAdapter.TrapGroupViewParams viewParams)
		{
		}

		// Token: 0x06024BF0 RID: 150512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BF0")]
		[Address(RVA = "0x1FA0620", Offset = "0x1F9F220", VA = "0x181FA0620")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024BF1 RID: 150513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BF1")]
		[Address(RVA = "0x1FA07A0", Offset = "0x1F9F3A0", VA = "0x181FA07A0")]
		public AutoChessShopLevelTrapGroupItemView()
		{
		}

		// Token: 0x04033551 RID: 210257
		[Token(Token = "0x4033551")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _rectLevelTagViewContainer;

		// Token: 0x04033552 RID: 210258
		[Token(Token = "0x4033552")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessShopLevelTagView _levelTagViewPrefab;

		// Token: 0x04033553 RID: 210259
		[Token(Token = "0x4033553")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _trapList;

		// Token: 0x04033554 RID: 210260
		[Token(Token = "0x4033554")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GridLayoutGroup _gridLayout;

		// Token: 0x04033555 RID: 210261
		[Token(Token = "0x4033555")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04033556 RID: 210262
		[Token(Token = "0x4033556")]
		[FieldOffset(Offset = "0x3C")]
		private int m_cachedIndex;

		// Token: 0x04033557 RID: 210263
		[Token(Token = "0x4033557")]
		[FieldOffset(Offset = "0x40")]
		private AutoChessShopLevelTagView m_levelTagView;

		// Token: 0x04033558 RID: 210264
		[Token(Token = "0x4033558")]
		[FieldOffset(Offset = "0x48")]
		private List<AutoChessShopTrapCardViewModel> m_cachedLevelTrapItemCardViewModelList;

		// Token: 0x04033559 RID: 210265
		[Token(Token = "0x4033559")]
		[FieldOffset(Offset = "0x50")]
		private AutoChessShopLevelTrapGroupItemView.TrapListAdapter m_adapter;

		// Token: 0x0403355A RID: 210266
		[Token(Token = "0x403355A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gridLayout;

		// Token: 0x0403355B RID: 210267
		[Token(Token = "0x403355B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403355C RID: 210268
		[Token(Token = "0x403355C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403355D RID: 210269
		[Token(Token = "0x403355D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006381 RID: 25473
		[Token(Token = "0x2006381")]
		private class TrapListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06024BF2 RID: 150514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BF2")]
			[Address(RVA = "0x1FAD890", Offset = "0x1FAC490", VA = "0x181FAD890")]
			public TrapListAdapter(AutoChessShopLevelTrapGroupItemView closure)
			{
			}

			// Token: 0x170056C3 RID: 22211
			// (get) Token: 0x06024BF3 RID: 150515 RVA: 0x000C55F8 File Offset: 0x000C37F8
			[Token(Token = "0x170056C3")]
			public override int count
			{
				[Token(Token = "0x6024BF3")]
				[Address(RVA = "0x1FAD910", Offset = "0x1FAC510", VA = "0x181FAD910", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024BF4 RID: 150516 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024BF4")]
			[Address(RVA = "0x1FAD6E0", Offset = "0x1FAC2E0", VA = "0x181FAD6E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403355E RID: 210270
			[Token(Token = "0x403355E")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessShopLevelTrapGroupItemView m_closure;

			// Token: 0x0403355F RID: 210271
			[Token(Token = "0x403355F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033560 RID: 210272
			[Token(Token = "0x4033560")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04033561 RID: 210273
			[Token(Token = "0x4033561")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
