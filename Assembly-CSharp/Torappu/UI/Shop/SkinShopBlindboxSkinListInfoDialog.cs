using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A66 RID: 23142
	[Token(Token = "0x2005A66")]
	public class SkinShopBlindboxSkinListInfoDialog : UICompDialog<SkinShopBlindboxSkinListInfoDialog.Options>, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x06021ACB RID: 137931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ACB")]
		[Address(RVA = "0x1C28CA0", Offset = "0x1C278A0", VA = "0x181C28CA0")]
		private void _EventOnClickSkinItem(string skinId)
		{
		}

		// Token: 0x06021ACC RID: 137932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ACC")]
		[Address(RVA = "0x1C29120", Offset = "0x1C27D20", VA = "0x181C29120")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021ACD RID: 137933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ACD")]
		[Address(RVA = "0x1C28900", Offset = "0x1C27500", VA = "0x181C28900", Slot = "18")]
		protected override void OnRender(SkinShopBlindboxSkinListInfoDialog.Options input)
		{
		}

		// Token: 0x06021ACE RID: 137934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021ACE")]
		[Address(RVA = "0x1C28740", Offset = "0x1C27340", VA = "0x181C28740", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06021ACF RID: 137935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ACF")]
		[Address(RVA = "0x1C28830", Offset = "0x1C27430", VA = "0x181C28830", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06021AD0 RID: 137936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AD0")]
		[Address(RVA = "0x1C28400", Offset = "0x1C27000", VA = "0x181C28400")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x06021AD1 RID: 137937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AD1")]
		[Address(RVA = "0x1C284C0", Offset = "0x1C270C0", VA = "0x181C284C0")]
		public void EventOnRuleBtnClicked()
		{
		}

		// Token: 0x06021AD2 RID: 137938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AD2")]
		[Address(RVA = "0x1C287A0", Offset = "0x1C273A0", VA = "0x181C287A0", Slot = "20")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06021AD3 RID: 137939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AD3")]
		[Address(RVA = "0x1C292A0", Offset = "0x1C27EA0", VA = "0x181C292A0")]
		public SkinShopBlindboxSkinListInfoDialog()
		{
		}

		// Token: 0x06021AD4 RID: 137940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021AD4")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0402E096 RID: 188566
		[Token(Token = "0x402E096")]
		[NonSerialized]
		public const int ROUTE_TO_SKIN_DETAIL = 0;

		// Token: 0x0402E097 RID: 188567
		[Token(Token = "0x402E097")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0402E098 RID: 188568
		[Token(Token = "0x402E098")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SkinShopBlindboxSkinListRowView _rowViewPrefab;

		// Token: 0x0402E099 RID: 188569
		[Token(Token = "0x402E099")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _layout;

		// Token: 0x0402E09A RID: 188570
		[Token(Token = "0x402E09A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _ruleText;

		// Token: 0x0402E09B RID: 188571
		[Token(Token = "0x402E09B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0402E09C RID: 188572
		[Token(Token = "0x402E09C")]
		[FieldOffset(Offset = "0x98")]
		private SkinShopBlindboxSkinListViewModel m_cachedViewModel;

		// Token: 0x0402E09D RID: 188573
		[Token(Token = "0x402E09D")]
		[FieldOffset(Offset = "0xA0")]
		private SkinShopBlindboxSkinListInfoDialog.SkinListAdapter m_adapter;

		// Token: 0x0402E09E RID: 188574
		[Token(Token = "0x402E09E")]
		[FieldOffset(Offset = "0xA8")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0402E09F RID: 188575
		[Token(Token = "0x402E09F")]
		[FieldOffset(Offset = "0xB0")]
		private int m_infoDialogInst;

		// Token: 0x0402E0A0 RID: 188576
		[Token(Token = "0x402E0A0")]
		[FieldOffset(Offset = "0xB8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402E0A1 RID: 188577
		[Token(Token = "0x402E0A1")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_hasInited;

		// Token: 0x0402E0A2 RID: 188578
		[Token(Token = "0x402E0A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EventOnClickSkinItem;

		// Token: 0x0402E0A3 RID: 188579
		[Token(Token = "0x402E0A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E0A4 RID: 188580
		[Token(Token = "0x402E0A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402E0A5 RID: 188581
		[Token(Token = "0x402E0A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402E0A6 RID: 188582
		[Token(Token = "0x402E0A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402E0A7 RID: 188583
		[Token(Token = "0x402E0A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x0402E0A8 RID: 188584
		[Token(Token = "0x402E0A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnRuleBtnClicked;

		// Token: 0x0402E0A9 RID: 188585
		[Token(Token = "0x402E0A9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0402E0AA RID: 188586
		[Token(Token = "0x402E0AA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A67 RID: 23143
		[Token(Token = "0x2005A67")]
		public class Options
		{
			// Token: 0x06021AD5 RID: 137941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021AD5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0402E0AB RID: 188587
			[Token(Token = "0x402E0AB")]
			[FieldOffset(Offset = "0x10")]
			public string voucherName;

			// Token: 0x0402E0AC RID: 188588
			[Token(Token = "0x402E0AC")]
			[FieldOffset(Offset = "0x18")]
			public string voucherRuleDetail;

			// Token: 0x0402E0AD RID: 188589
			[Token(Token = "0x402E0AD")]
			[FieldOffset(Offset = "0x20")]
			public SkinShopBlindboxSkinListViewModel dialogViewModel;
		}

		// Token: 0x02005A68 RID: 23144
		[Token(Token = "0x2005A68")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<SkinShopBlindboxSkinListRowView>
		{
			// Token: 0x06021AD6 RID: 137942 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021AD6")]
			[Address(RVA = "0x1C2F140", Offset = "0x1C2DD40", VA = "0x181C2F140", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06021AD7 RID: 137943 RVA: 0x000BB110 File Offset: 0x000B9310
			[Token(Token = "0x6021AD7")]
			[Address(RVA = "0x1C2F1A0", Offset = "0x1C2DDA0", VA = "0x181C2F1A0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06021AD8 RID: 137944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021AD8")]
			[Address(RVA = "0x1C2F210", Offset = "0x1C2DE10", VA = "0x181C2F210", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06021AD9 RID: 137945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021AD9")]
			[Address(RVA = "0x1C2F410", Offset = "0x1C2E010", VA = "0x181C2F410", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06021ADA RID: 137946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021ADA")]
			[Address(RVA = "0x1C2F470", Offset = "0x1C2E070", VA = "0x181C2F470")]
			public VirtualView()
			{
			}

			// Token: 0x0402E0AE RID: 188590
			[Token(Token = "0x402E0AE")]
			private const float PREFER_SIZE_WITH_DESCRIPTION = 398f;

			// Token: 0x0402E0AF RID: 188591
			[Token(Token = "0x402E0AF")]
			private const float PREFER_SIZE_WITHOUT_DESCRIPTION = 310f;

			// Token: 0x0402E0B0 RID: 188592
			[Token(Token = "0x402E0B0")]
			[FieldOffset(Offset = "0x20")]
			public GameObject rowPrefab;

			// Token: 0x0402E0B1 RID: 188593
			[Token(Token = "0x402E0B1")]
			[FieldOffset(Offset = "0x28")]
			public bool isFirstRow;

			// Token: 0x0402E0B2 RID: 188594
			[Token(Token = "0x402E0B2")]
			[FieldOffset(Offset = "0x29")]
			public bool isAchievedSkinView;

			// Token: 0x0402E0B3 RID: 188595
			[Token(Token = "0x402E0B3")]
			[FieldOffset(Offset = "0x30")]
			public ListDict<string, SkinShopBlindboxSkinListItemViewModel> skins;

			// Token: 0x0402E0B4 RID: 188596
			[Token(Token = "0x402E0B4")]
			[FieldOffset(Offset = "0x38")]
			public SkinShopBlindboxSkinListViewModel dialogViewModel;

			// Token: 0x0402E0B5 RID: 188597
			[Token(Token = "0x402E0B5")]
			[FieldOffset(Offset = "0x40")]
			public int startIndex;

			// Token: 0x0402E0B6 RID: 188598
			[Token(Token = "0x402E0B6")]
			[FieldOffset(Offset = "0x44")]
			public int count;

			// Token: 0x0402E0B7 RID: 188599
			[Token(Token = "0x402E0B7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402E0B8 RID: 188600
			[Token(Token = "0x402E0B8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402E0B9 RID: 188601
			[Token(Token = "0x402E0B9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402E0BA RID: 188602
			[Token(Token = "0x402E0BA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402E0BB RID: 188603
			[Token(Token = "0x402E0BB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005A69 RID: 23145
		[Token(Token = "0x2005A69")]
		public class SkinListAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x06021ADB RID: 137947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021ADB")]
			[Address(RVA = "0x1C27B00", Offset = "0x1C26700", VA = "0x181C27B00")]
			public SkinListAdapter(SkinShopBlindboxSkinListInfoDialog closure)
			{
			}

			// Token: 0x06021ADC RID: 137948 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021ADC")]
			[Address(RVA = "0x1C27430", Offset = "0x1C26030", VA = "0x181C27430", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x06021ADD RID: 137949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021ADD")]
			[Address(RVA = "0x1C27600", Offset = "0x1C26200", VA = "0x181C27600")]
			public void RebuildList()
			{
			}

			// Token: 0x06021ADE RID: 137950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021ADE")]
			[Address(RVA = "0x1C27720", Offset = "0x1C26320", VA = "0x181C27720")]
			private void _GenerateViewsInSkinGroup(SkinShopBlindboxSkinListSkinGroupViewModel skinGroupViewModel, IList<UIRecycleLayoutAdapter.IVirtualView> res)
			{
			}

			// Token: 0x0402E0BC RID: 188604
			[Token(Token = "0x402E0BC")]
			private const int COLUMNS_PER_ROW = 7;

			// Token: 0x0402E0BD RID: 188605
			[Token(Token = "0x402E0BD")]
			[FieldOffset(Offset = "0x18")]
			private SkinShopBlindboxSkinListInfoDialog m_closure;

			// Token: 0x0402E0BE RID: 188606
			[Token(Token = "0x402E0BE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402E0BF RID: 188607
			[Token(Token = "0x402E0BF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0402E0C0 RID: 188608
			[Token(Token = "0x402E0C0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildList;

			// Token: 0x0402E0C1 RID: 188609
			[Token(Token = "0x402E0C1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__GenerateViewsInSkinGroup;
		}
	}
}
