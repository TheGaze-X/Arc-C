using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200586C RID: 22636
	[Token(Token = "0x200586C")]
	public class RL03TotemListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060210F7 RID: 135415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210F7")]
		[Address(RVA = "0x1B6AB60", Offset = "0x1B69760", VA = "0x181B6AB60")]
		public void Render(RL03TotemListItemView.RL03TotemListItemVirtualViewStruct viewStruct)
		{
		}

		// Token: 0x060210F8 RID: 135416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210F8")]
		[Address(RVA = "0x1B6AEF0", Offset = "0x1B69AF0", VA = "0x181B6AEF0")]
		public void UpdateSelectStatus(RL03TotemListItemViewModel viewModel, List<bool> groupSelectStatusList, int viewIndex)
		{
		}

		// Token: 0x060210F9 RID: 135417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210F9")]
		[Address(RVA = "0x1B6AAB0", Offset = "0x1B696B0", VA = "0x181B6AAB0")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x060210FA RID: 135418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210FA")]
		[Address(RVA = "0x1B6B0A0", Offset = "0x1B69CA0", VA = "0x181B6B0A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060210FB RID: 135419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210FB")]
		[Address(RVA = "0x1B6B1C0", Offset = "0x1B69DC0", VA = "0x181B6B1C0")]
		private void _RenderBaseInfo(RL03TotemListItemViewModel itemViewModel)
		{
		}

		// Token: 0x060210FC RID: 135420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210FC")]
		[Address(RVA = "0x1B6B7A0", Offset = "0x1B6A3A0", VA = "0x181B6B7A0")]
		public RL03TotemListItemView()
		{
		}

		// Token: 0x0402CFDA RID: 184282
		[Token(Token = "0x402CFDA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0402CFDB RID: 184283
		[Token(Token = "0x402CFDB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelItem;

		// Token: 0x0402CFDC RID: 184284
		[Token(Token = "0x402CFDC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtTotemName;

		// Token: 0x0402CFDD RID: 184285
		[Token(Token = "0x402CFDD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgTotemIcon;

		// Token: 0x0402CFDE RID: 184286
		[Token(Token = "0x402CFDE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgTotemBg;

		// Token: 0x0402CFDF RID: 184287
		[Token(Token = "0x402CFDF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelTotemOutline;

		// Token: 0x0402CFE0 RID: 184288
		[Token(Token = "0x402CFE0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Graphic[] _graphicsWithColor;

		// Token: 0x0402CFE1 RID: 184289
		[Token(Token = "0x402CFE1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Sub Buff")]
		private GameObject _panelSubBuff;

		// Token: 0x0402CFE2 RID: 184290
		[Token(Token = "0x402CFE2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Sub Buff")]
		private UIAtlasImage _imgSubBuff;

		// Token: 0x0402CFE3 RID: 184291
		[Token(Token = "0x402CFE3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Divination")]
		private GameObject _panelDivinationBkg;

		// Token: 0x0402CFE4 RID: 184292
		[Token(Token = "0x402CFE4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Divination")]
		private GameObject _panelDivination;

		// Token: 0x0402CFE5 RID: 184293
		[Token(Token = "0x402CFE5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _txtTotemDesc;

		// Token: 0x0402CFE6 RID: 184294
		[Token(Token = "0x402CFE6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelUnselectable;

		// Token: 0x0402CFE7 RID: 184295
		[Token(Token = "0x402CFE7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _btnItem;

		// Token: 0x0402CFE8 RID: 184296
		[Token(Token = "0x402CFE8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasObject _uiAtlasObject;

		// Token: 0x0402CFE9 RID: 184297
		[Token(Token = "0x402CFE9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0402CFEA RID: 184298
		[Token(Token = "0x402CFEA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _preferSize;

		// Token: 0x0402CFEB RID: 184299
		[Token(Token = "0x402CFEB")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_isInited;

		// Token: 0x0402CFEC RID: 184300
		[Token(Token = "0x402CFEC")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402CFED RID: 184301
		[Token(Token = "0x402CFED")]
		[FieldOffset(Offset = "0xB8")]
		private AnimationSwitchTween m_selectSwitchTween;

		// Token: 0x0402CFEE RID: 184302
		[Token(Token = "0x402CFEE")]
		[FieldOffset(Offset = "0xC0")]
		private Action<string, string> m_onclick;

		// Token: 0x0402CFEF RID: 184303
		[Token(Token = "0x402CFEF")]
		[FieldOffset(Offset = "0xC8")]
		private List<bool> m_groupSelectStatusList;

		// Token: 0x0402CFF0 RID: 184304
		[Token(Token = "0x402CFF0")]
		[FieldOffset(Offset = "0xD0")]
		private RL03TotemListItemViewModel m_itemViewModel;

		// Token: 0x0402CFF1 RID: 184305
		[Token(Token = "0x402CFF1")]
		[FieldOffset(Offset = "0xD8")]
		private int m_cacheIndex;

		// Token: 0x0402CFF2 RID: 184306
		[Token(Token = "0x402CFF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CFF3 RID: 184307
		[Token(Token = "0x402CFF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateSelectStatus;

		// Token: 0x0402CFF4 RID: 184308
		[Token(Token = "0x402CFF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x0402CFF5 RID: 184309
		[Token(Token = "0x402CFF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402CFF6 RID: 184310
		[Token(Token = "0x402CFF6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderBaseInfo;

		// Token: 0x0402CFF7 RID: 184311
		[Token(Token = "0x402CFF7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200586D RID: 22637
		[Token(Token = "0x200586D")]
		public struct RL03TotemListItemVirtualViewStruct
		{
			// Token: 0x0402CFF8 RID: 184312
			[Token(Token = "0x402CFF8")]
			[FieldOffset(Offset = "0x0")]
			public RL03TotemListItemView prefab;

			// Token: 0x0402CFF9 RID: 184313
			[Token(Token = "0x402CFF9")]
			[FieldOffset(Offset = "0x8")]
			public RL03TotemListItemViewModel viewModel;

			// Token: 0x0402CFFA RID: 184314
			[Token(Token = "0x402CFFA")]
			[FieldOffset(Offset = "0x10")]
			public Action<string, string> onClick;

			// Token: 0x0402CFFB RID: 184315
			[Token(Token = "0x402CFFB")]
			[FieldOffset(Offset = "0x18")]
			public List<bool> groupSelectStatusList;

			// Token: 0x0402CFFC RID: 184316
			[Token(Token = "0x402CFFC")]
			[FieldOffset(Offset = "0x20")]
			public int viewIndex;
		}

		// Token: 0x0200586E RID: 22638
		[Token(Token = "0x200586E")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RL03TotemListItemView>
		{
			// Token: 0x060210FD RID: 135421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60210FD")]
			[Address(RVA = "0x1B70460", Offset = "0x1B6F060", VA = "0x181B70460")]
			public VirtualView(RL03TotemListItemView.RL03TotemListItemVirtualViewStruct viewStruct)
			{
			}

			// Token: 0x060210FE RID: 135422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60210FE")]
			[Address(RVA = "0x1B6FE10", Offset = "0x1B6EA10", VA = "0x181B6FE10", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x060210FF RID: 135423 RVA: 0x000B8620 File Offset: 0x000B6820
			[Token(Token = "0x60210FF")]
			[Address(RVA = "0x1B6FE80", Offset = "0x1B6EA80", VA = "0x181B6FE80", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06021100 RID: 135424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021100")]
			[Address(RVA = "0x1B70180", Offset = "0x1B6ED80", VA = "0x181B70180", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06021101 RID: 135425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021101")]
			[Address(RVA = "0x1B70070", Offset = "0x1B6EC70", VA = "0x181B70070", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06021102 RID: 135426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021102")]
			[Address(RVA = "0x1B701E0", Offset = "0x1B6EDE0", VA = "0x181B701E0")]
			public void UpdateSelectStatus(RL03TotemListItemViewModel viewModel, List<bool> groupSelectStatusList, int viewIndex)
			{
			}

			// Token: 0x0402CFFD RID: 184317
			[Token(Token = "0x402CFFD")]
			[FieldOffset(Offset = "0x20")]
			private RL03TotemListItemView.RL03TotemListItemVirtualViewStruct m_viewStruct;

			// Token: 0x0402CFFE RID: 184318
			[Token(Token = "0x402CFFE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402CFFF RID: 184319
			[Token(Token = "0x402CFFF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402D000 RID: 184320
			[Token(Token = "0x402D000")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402D001 RID: 184321
			[Token(Token = "0x402D001")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402D002 RID: 184322
			[Token(Token = "0x402D002")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402D003 RID: 184323
			[Token(Token = "0x402D003")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateSelectStatus;
		}
	}
}
