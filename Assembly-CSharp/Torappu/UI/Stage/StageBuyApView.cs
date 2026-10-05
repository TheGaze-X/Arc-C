using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Home;
using Torappu.UI.ItemRepo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068F6 RID: 26870
	[Token(Token = "0x20068F6")]
	public class StageBuyApView : PageSingleComponent, ITimeWatcher, IHotfixable
	{
		// Token: 0x17005AE5 RID: 23269
		// (get) Token: 0x060267D9 RID: 157657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AE5")]
		public ActionPointViewModel apViewModel
		{
			[Token(Token = "0x60267D9")]
			[Address(RVA = "0x21975D0", Offset = "0x21961D0", VA = "0x1821975D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060267DA RID: 157658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267DA")]
		[Address(RVA = "0x21957C0", Offset = "0x21943C0", VA = "0x1821957C0")]
		public static void InitRender(UIPageFinder.Interface pageInterface, int needAp)
		{
		}

		// Token: 0x060267DB RID: 157659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267DB")]
		[Address(RVA = "0x2197040", Offset = "0x2195C40", VA = "0x182197040")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060267DC RID: 157660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267DC")]
		[Address(RVA = "0x2197320", Offset = "0x2195F20", VA = "0x182197320")]
		private void _RefreshView(int needAp)
		{
		}

		// Token: 0x060267DD RID: 157661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267DD")]
		[Address(RVA = "0x2195F80", Offset = "0x2194B80", VA = "0x182195F80")]
		public static void RefreshViewOnResume()
		{
		}

		// Token: 0x060267DE RID: 157662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267DE")]
		[Address(RVA = "0x2196050", Offset = "0x2194C50", VA = "0x182196050")]
		public void Refresh()
		{
		}

		// Token: 0x060267DF RID: 157663 RVA: 0x000CB568 File Offset: 0x000C9768
		[Token(Token = "0x60267DF")]
		[Address(RVA = "0x2196F20", Offset = "0x2195B20", VA = "0x182196F20")]
		private bool _CheckHaveApItem()
		{
			return default(bool);
		}

		// Token: 0x060267E0 RID: 157664 RVA: 0x000CB580 File Offset: 0x000C9780
		[Token(Token = "0x60267E0")]
		[Address(RVA = "0x2196FA0", Offset = "0x2195BA0", VA = "0x182196FA0")]
		private bool _CheckHaveDiamond()
		{
			return default(bool);
		}

		// Token: 0x060267E1 RID: 157665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267E1")]
		[Address(RVA = "0x2195BD0", Offset = "0x21947D0", VA = "0x182195BD0")]
		public void RefreshState(bool isApItem)
		{
		}

		// Token: 0x060267E2 RID: 157666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267E2")]
		[Address(RVA = "0x2195C50", Offset = "0x2194850", VA = "0x182195C50")]
		public void RefreshState(bool isApItem, int needAp = 0)
		{
		}

		// Token: 0x060267E3 RID: 157667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267E3")]
		[Address(RVA = "0x2196200", Offset = "0x2194E00", VA = "0x182196200")]
		private void RenderDiamond()
		{
		}

		// Token: 0x060267E4 RID: 157668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267E4")]
		[Address(RVA = "0x2195670", Offset = "0x2194270", VA = "0x182195670")]
		private void CleanDiamond()
		{
		}

		// Token: 0x060267E5 RID: 157669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267E5")]
		[Address(RVA = "0x21960B0", Offset = "0x2194CB0", VA = "0x1821960B0")]
		private void RenderApItem(int needAp)
		{
		}

		// Token: 0x060267E6 RID: 157670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267E6")]
		[Address(RVA = "0x21955D0", Offset = "0x21941D0", VA = "0x1821955D0")]
		private void CleanApItem()
		{
		}

		// Token: 0x060267E7 RID: 157671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267E7")]
		[Address(RVA = "0x2195720", Offset = "0x2194320", VA = "0x182195720")]
		public void Dismiss()
		{
		}

		// Token: 0x060267E8 RID: 157672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267E8")]
		[Address(RVA = "0x21963B0", Offset = "0x2194FB0", VA = "0x1821963B0")]
		public void SendBuyApService()
		{
		}

		// Token: 0x060267E9 RID: 157673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267E9")]
		[Address(RVA = "0x21971E0", Offset = "0x2195DE0", VA = "0x1821971E0")]
		private void _OnBuyApSuccess(BuyApResponse response)
		{
		}

		// Token: 0x060267EA RID: 157674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267EA")]
		[Address(RVA = "0x2196720", Offset = "0x2195320", VA = "0x182196720")]
		public void SendUseApItemService(List<UIItemViewModel> itemViewModelList)
		{
		}

		// Token: 0x060267EB RID: 157675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60267EB")]
		[Address(RVA = "0x2195B20", Offset = "0x2194720", VA = "0x182195B20")]
		public static IEnumerator ReceiveItemsCoroutine(List<ItemGet> items)
		{
			return null;
		}

		// Token: 0x060267EC RID: 157676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267EC")]
		[Address(RVA = "0x2196C60", Offset = "0x2195860", VA = "0x182196C60", Slot = "12")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x060267ED RID: 157677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267ED")]
		[Address(RVA = "0x2195AA0", Offset = "0x21946A0", VA = "0x182195AA0")]
		public void OpenShopPage()
		{
		}

		// Token: 0x060267EE RID: 157678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60267EE")]
		[Address(RVA = "0x2197520", Offset = "0x2196120", VA = "0x182197520")]
		public StageBuyApView()
		{
		}

		// Token: 0x040363B0 RID: 222128
		[Token(Token = "0x40363B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _useDiamondState;

		// Token: 0x040363B1 RID: 222129
		[Token(Token = "0x40363B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _useApItemState;

		// Token: 0x040363B2 RID: 222130
		[Token(Token = "0x40363B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _allContainer;

		// Token: 0x040363B3 RID: 222131
		[Token(Token = "0x40363B3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _noTimesView;

		// Token: 0x040363B4 RID: 222132
		[Token(Token = "0x40363B4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StageNoDiamondView _noDiamondView;

		// Token: 0x040363B5 RID: 222133
		[Token(Token = "0x40363B5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private HomeAPUseApItemView _useApItemView;

		// Token: 0x040363B6 RID: 222134
		[Token(Token = "0x40363B6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private StageUseDiamondView _useDiamondView;

		// Token: 0x040363B7 RID: 222135
		[Token(Token = "0x40363B7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _noApItemView;

		// Token: 0x040363B8 RID: 222136
		[Token(Token = "0x40363B8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIBlurFloatPanel _backImage;

		// Token: 0x040363B9 RID: 222137
		[Token(Token = "0x40363B9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textApCountDown;

		// Token: 0x040363BA RID: 222138
		[Token(Token = "0x40363BA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _countDownDesc;

		// Token: 0x040363BB RID: 222139
		[Token(Token = "0x40363BB")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040363BC RID: 222140
		[Token(Token = "0x40363BC")]
		[FieldOffset(Offset = "0x88")]
		private ActionPointViewModel m_apViewModel;

		// Token: 0x040363BD RID: 222141
		[Token(Token = "0x40363BD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text[] _textsByDiamond;

		// Token: 0x040363BE RID: 222142
		[Token(Token = "0x40363BE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ItemRepoActionPointViewModelWithBuyApCount _apProperty;

		// Token: 0x040363BF RID: 222143
		[Token(Token = "0x40363BF")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isApItemFlag;

		// Token: 0x040363C0 RID: 222144
		[Token(Token = "0x40363C0")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageListener m_pageListener;

		// Token: 0x040363C1 RID: 222145
		[Token(Token = "0x40363C1")]
		[FieldOffset(Offset = "0xB0")]
		private long m_remainSeconds;

		// Token: 0x040363C2 RID: 222146
		[Token(Token = "0x40363C2")]
		[FieldOffset(Offset = "0xB8")]
		private float m_timeAccum;

		// Token: 0x040363C3 RID: 222147
		[Token(Token = "0x40363C3")]
		[FieldOffset(Offset = "0xC0")]
		private ActionPointViewModel m_apModel;

		// Token: 0x040363C4 RID: 222148
		[Token(Token = "0x40363C4")]
		[FieldOffset(Offset = "0xC8")]
		private int m_cacheNeedCount;

		// Token: 0x040363C5 RID: 222149
		[Token(Token = "0x40363C5")]
		[FieldOffset(Offset = "0xCC")]
		private bool m_isInited;

		// Token: 0x040363C6 RID: 222150
		[Token(Token = "0x40363C6")]
		[FieldOffset(Offset = "0xCD")]
		private bool m_isOpen;

		// Token: 0x040363C7 RID: 222151
		[Token(Token = "0x40363C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_apViewModel;

		// Token: 0x040363C8 RID: 222152
		[Token(Token = "0x40363C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitRender;

		// Token: 0x040363C9 RID: 222153
		[Token(Token = "0x40363C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040363CA RID: 222154
		[Token(Token = "0x40363CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x040363CB RID: 222155
		[Token(Token = "0x40363CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshViewOnResume;

		// Token: 0x040363CC RID: 222156
		[Token(Token = "0x40363CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x040363CD RID: 222157
		[Token(Token = "0x40363CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckHaveApItem;

		// Token: 0x040363CE RID: 222158
		[Token(Token = "0x40363CE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckHaveDiamond;

		// Token: 0x040363CF RID: 222159
		[Token(Token = "0x40363CF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshState;

		// Token: 0x040363D0 RID: 222160
		[Token(Token = "0x40363D0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_RefreshState;

		// Token: 0x040363D1 RID: 222161
		[Token(Token = "0x40363D1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RenderDiamond;

		// Token: 0x040363D2 RID: 222162
		[Token(Token = "0x40363D2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CleanDiamond;

		// Token: 0x040363D3 RID: 222163
		[Token(Token = "0x40363D3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RenderApItem;

		// Token: 0x040363D4 RID: 222164
		[Token(Token = "0x40363D4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CleanApItem;

		// Token: 0x040363D5 RID: 222165
		[Token(Token = "0x40363D5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Dismiss;

		// Token: 0x040363D6 RID: 222166
		[Token(Token = "0x40363D6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SendBuyApService;

		// Token: 0x040363D7 RID: 222167
		[Token(Token = "0x40363D7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnBuyApSuccess;

		// Token: 0x040363D8 RID: 222168
		[Token(Token = "0x40363D8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SendUseApItemService;

		// Token: 0x040363D9 RID: 222169
		[Token(Token = "0x40363D9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ReceiveItemsCoroutine;

		// Token: 0x040363DA RID: 222170
		[Token(Token = "0x40363DA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x040363DB RID: 222171
		[Token(Token = "0x40363DB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OpenShopPage;

		// Token: 0x040363DC RID: 222172
		[Token(Token = "0x40363DC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
