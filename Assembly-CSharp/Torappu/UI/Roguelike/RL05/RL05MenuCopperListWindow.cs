using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055E6 RID: 21990
	[Token(Token = "0x20055E6")]
	public class RL05MenuCopperListWindow : RoguelikeMenuWindow<RL05MenuCopperListViewModel>
	{
		// Token: 0x0602048A RID: 132234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602048A")]
		[Address(RVA = "0x1A63210", Offset = "0x1A61E10", VA = "0x181A63210")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17004BA3 RID: 19363
		// (get) Token: 0x0602048B RID: 132235 RVA: 0x000B5338 File Offset: 0x000B3538
		[Token(Token = "0x17004BA3")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x602048B")]
			[Address(RVA = "0x1A635D0", Offset = "0x1A621D0", VA = "0x181A635D0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0602048C RID: 132236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602048C")]
		[Address(RVA = "0x1A62F00", Offset = "0x1A61B00", VA = "0x181A62F00", Slot = "10")]
		public override void Render(RL05MenuCopperListViewModel viewModel)
		{
		}

		// Token: 0x0602048D RID: 132237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602048D")]
		[Address(RVA = "0x1A63270", Offset = "0x1A61E70", VA = "0x181A63270")]
		private void _UpdateDetailViews(RL05MenuCopperListViewModel viewModel, ILoadAsset loader)
		{
		}

		// Token: 0x0602048E RID: 132238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602048E")]
		[Address(RVA = "0x1A630A0", Offset = "0x1A61CA0", VA = "0x181A630A0")]
		private void _ClearAllDetailViews()
		{
		}

		// Token: 0x0602048F RID: 132239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602048F")]
		[Address(RVA = "0x1A62DF0", Offset = "0x1A619F0", VA = "0x181A62DF0", Slot = "9")]
		protected override UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x06020490 RID: 132240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020490")]
		[Address(RVA = "0x1A63500", Offset = "0x1A62100", VA = "0x181A63500")]
		public RL05MenuCopperListWindow()
		{
		}

		// Token: 0x06020491 RID: 132241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020491")]
		[Address(RVA = "0x19153C0", Offset = "0x1913FC0", VA = "0x1819153C0")]
		private UISwitchTween <>xLuaBaseProxy_GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0402BAE4 RID: 178916
		[Token(Token = "0x402BAE4")]
		private const float ANIM_DURATION = 0.16f;

		// Token: 0x0402BAE5 RID: 178917
		[Token(Token = "0x402BAE5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDrawnCount;

		// Token: 0x0402BAE6 RID: 178918
		[Token(Token = "0x402BAE6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _detailsContainer;

		// Token: 0x0402BAE7 RID: 178919
		[Token(Token = "0x402BAE7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _detailViewPrefab;

		// Token: 0x0402BAE8 RID: 178920
		[Token(Token = "0x402BAE8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _displayRootNotEmpty;

		// Token: 0x0402BAE9 RID: 178921
		[Token(Token = "0x402BAE9")]
		[FieldOffset(Offset = "0x48")]
		private string m_topicId;

		// Token: 0x0402BAEA RID: 178922
		[Token(Token = "0x402BAEA")]
		[FieldOffset(Offset = "0x50")]
		private RL05MenuCopperListViewModel m_cachedModel;

		// Token: 0x0402BAEB RID: 178923
		[Token(Token = "0x402BAEB")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BAEC RID: 178924
		[Token(Token = "0x402BAEC")]
		[FieldOffset(Offset = "0x68")]
		private List<RL05MenuCopperListWindowCopperView> m_detailViews;

		// Token: 0x0402BAED RID: 178925
		[Token(Token = "0x402BAED")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x0402BAEE RID: 178926
		[Token(Token = "0x402BAEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402BAEF RID: 178927
		[Token(Token = "0x402BAEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402BAF0 RID: 178928
		[Token(Token = "0x402BAF0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BAF1 RID: 178929
		[Token(Token = "0x402BAF1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateDetailViews;

		// Token: 0x0402BAF2 RID: 178930
		[Token(Token = "0x402BAF2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearAllDetailViews;

		// Token: 0x0402BAF3 RID: 178931
		[Token(Token = "0x402BAF3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402BAF4 RID: 178932
		[Token(Token = "0x402BAF4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055E7 RID: 21991
		[Token(Token = "0x20055E7")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06020492 RID: 132242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020492")]
			[Address(RVA = "0x1A5E090", Offset = "0x1A5CC90", VA = "0x181A5E090")]
			public Adapter(RL05MenuCopperListWindow closure)
			{
			}

			// Token: 0x17004BA4 RID: 19364
			// (get) Token: 0x06020493 RID: 132243 RVA: 0x000B5350 File Offset: 0x000B3550
			[Token(Token = "0x17004BA4")]
			public override int count
			{
				[Token(Token = "0x6020493")]
				[Address(RVA = "0x1A5E110", Offset = "0x1A5CD10", VA = "0x181A5E110", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020494 RID: 132244 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020494")]
			[Address(RVA = "0x1A5DE80", Offset = "0x1A5CA80", VA = "0x181A5DE80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402BAF5 RID: 178933
			[Token(Token = "0x402BAF5")]
			[FieldOffset(Offset = "0x20")]
			private RL05MenuCopperListWindow m_closure;

			// Token: 0x0402BAF6 RID: 178934
			[Token(Token = "0x402BAF6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402BAF7 RID: 178935
			[Token(Token = "0x402BAF7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402BAF8 RID: 178936
			[Token(Token = "0x402BAF8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
