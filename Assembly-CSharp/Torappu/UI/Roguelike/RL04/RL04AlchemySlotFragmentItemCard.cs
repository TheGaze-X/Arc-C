using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005680 RID: 22144
	[Token(Token = "0x2005680")]
	public class RL04AlchemySlotFragmentItemCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004C21 RID: 19489
		// (get) Token: 0x060207D7 RID: 133079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004C21")]
		public Graphic graphic
		{
			[Token(Token = "0x60207D7")]
			[Address(RVA = "0x1A9F450", Offset = "0x1A9E050", VA = "0x181A9F450")]
			get
			{
				return null;
			}
		}

		// Token: 0x060207D8 RID: 133080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207D8")]
		[Address(RVA = "0x1A9EF60", Offset = "0x1A9DB60", VA = "0x181A9EF60")]
		public void Render(IRoguelikeFragmentItemModel viewModel)
		{
		}

		// Token: 0x060207D9 RID: 133081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207D9")]
		[Address(RVA = "0x1A9F2C0", Offset = "0x1A9DEC0", VA = "0x181A9F2C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060207DA RID: 133082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207DA")]
		[Address(RVA = "0x1A9F3E0", Offset = "0x1A9DFE0", VA = "0x181A9F3E0")]
		public RL04AlchemySlotFragmentItemCard()
		{
		}

		// Token: 0x0402C061 RID: 180321
		[Token(Token = "0x402C061")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402C062 RID: 180322
		[Token(Token = "0x402C062")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402C063 RID: 180323
		[Token(Token = "0x402C063")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIColorGraphic _graphic;

		// Token: 0x0402C064 RID: 180324
		[Token(Token = "0x402C064")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _scale;

		// Token: 0x0402C065 RID: 180325
		[Token(Token = "0x402C065")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIScaler _scaler;

		// Token: 0x0402C066 RID: 180326
		[Token(Token = "0x402C066")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0402C067 RID: 180327
		[Token(Token = "0x402C067")]
		[FieldOffset(Offset = "0x48")]
		private RL04AlchemySlotFragmentItemCard.Adapter m_adapter;

		// Token: 0x0402C068 RID: 180328
		[Token(Token = "0x402C068")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedValue;

		// Token: 0x0402C069 RID: 180329
		[Token(Token = "0x402C069")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402C06A RID: 180330
		[Token(Token = "0x402C06A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0402C06B RID: 180331
		[Token(Token = "0x402C06B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C06C RID: 180332
		[Token(Token = "0x402C06C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C06D RID: 180333
		[Token(Token = "0x402C06D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005681 RID: 22145
		[Token(Token = "0x2005681")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060207DB RID: 133083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207DB")]
			[Address(RVA = "0x1A8B320", Offset = "0x1A89F20", VA = "0x181A8B320")]
			public Adapter(RL04AlchemySlotFragmentItemCard closure)
			{
			}

			// Token: 0x17004C22 RID: 19490
			// (get) Token: 0x060207DC RID: 133084 RVA: 0x000B6250 File Offset: 0x000B4450
			[Token(Token = "0x17004C22")]
			public override int count
			{
				[Token(Token = "0x60207DC")]
				[Address(RVA = "0x1A8B420", Offset = "0x1A8A020", VA = "0x181A8B420", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060207DD RID: 133085 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60207DD")]
			[Address(RVA = "0x1A8B180", Offset = "0x1A89D80", VA = "0x181A8B180", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C06E RID: 180334
			[Token(Token = "0x402C06E")]
			[FieldOffset(Offset = "0x20")]
			private RL04AlchemySlotFragmentItemCard m_closure;

			// Token: 0x0402C06F RID: 180335
			[Token(Token = "0x402C06F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C070 RID: 180336
			[Token(Token = "0x402C070")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C071 RID: 180337
			[Token(Token = "0x402C071")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
