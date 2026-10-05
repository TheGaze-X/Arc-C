using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004AFF RID: 19199
	[Token(Token = "0x2004AFF")]
	public class HomeAnnounceState : PopupFloatState
	{
		// Token: 0x0601CD5D RID: 118109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD5D")]
		[Address(RVA = "0x163A3D0", Offset = "0x1638FD0", VA = "0x18163A3D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CD5E RID: 118110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD5E")]
		[Address(RVA = "0x1638570", Offset = "0x1637170", VA = "0x181638570", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CD5F RID: 118111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD5F")]
		[Address(RVA = "0x1638870", Offset = "0x1637470", VA = "0x181638870", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CD60 RID: 118112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD60")]
		[Address(RVA = "0x16385D0", Offset = "0x16371D0", VA = "0x1816385D0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601CD61 RID: 118113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD61")]
		[Address(RVA = "0x1638720", Offset = "0x1637320", VA = "0x181638720", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601CD62 RID: 118114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD62")]
		[Address(RVA = "0x163A170", Offset = "0x1638D70", VA = "0x18163A170")]
		private void _InitData()
		{
		}

		// Token: 0x0601CD63 RID: 118115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD63")]
		[Address(RVA = "0x163B0B0", Offset = "0x1639CB0", VA = "0x18163B0B0")]
		private void _SetDefaultAnnounce(AnnounceSinglePageData announceData)
		{
		}

		// Token: 0x0601CD64 RID: 118116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD64")]
		[Address(RVA = "0x1638A00", Offset = "0x1637600", VA = "0x181638A00")]
		public void OnSelectActivityGroup()
		{
		}

		// Token: 0x0601CD65 RID: 118117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD65")]
		[Address(RVA = "0x1638A70", Offset = "0x1637670", VA = "0x181638A70")]
		public void OnSelectSystemGroup()
		{
		}

		// Token: 0x0601CD66 RID: 118118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD66")]
		[Address(RVA = "0x1638AE0", Offset = "0x16376E0", VA = "0x181638AE0")]
		public void OnSelectTab(int index)
		{
		}

		// Token: 0x0601CD67 RID: 118119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD67")]
		[Address(RVA = "0x163ABF0", Offset = "0x16397F0", VA = "0x18163ABF0")]
		private void _OnSelectTab(int index, bool unusedIsInit)
		{
		}

		// Token: 0x0601CD68 RID: 118120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD68")]
		[Address(RVA = "0x163AF00", Offset = "0x1639B00", VA = "0x18163AF00")]
		private void _OnSelectTab(AnnounceSinglePageData data, bool isInit)
		{
		}

		// Token: 0x0601CD69 RID: 118121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD69")]
		[Address(RVA = "0x1638F10", Offset = "0x1637B10", VA = "0x181638F10")]
		private List<AnnounceSinglePageData> _GetAnnounceDataByAnnounceGroup(AnnounceGroup group)
		{
			return null;
		}

		// Token: 0x0601CD6A RID: 118122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD6A")]
		[Address(RVA = "0x163A750", Offset = "0x1639350", VA = "0x18163A750")]
		private void _OnSelectGroup(AnnounceGroup groupType, AnnounceSinglePageData pageData, bool isInit)
		{
		}

		// Token: 0x0601CD6B RID: 118123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD6B")]
		[Address(RVA = "0x163B000", Offset = "0x1639C00", VA = "0x18163B000")]
		private void _OpenWebView(AnnounceSinglePageData data)
		{
		}

		// Token: 0x0601CD6C RID: 118124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD6C")]
		[Address(RVA = "0x163A4F0", Offset = "0x16390F0", VA = "0x18163A4F0")]
		private static string _InjectGameInfoToUrl(string url)
		{
			return null;
		}

		// Token: 0x0601CD6D RID: 118125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD6D")]
		[Address(RVA = "0x16390F0", Offset = "0x1637CF0", VA = "0x1816390F0")]
		private static string _GetGameInfoFromTag(string tag)
		{
			return null;
		}

		// Token: 0x0601CD6E RID: 118126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD6E")]
		[Address(RVA = "0x16399C0", Offset = "0x16385C0", VA = "0x1816399C0")]
		private void _HandleWebViewMessage(UniWebViewMessage msg)
		{
		}

		// Token: 0x0601CD6F RID: 118127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD6F")]
		[Address(RVA = "0x1639500", Offset = "0x1638100", VA = "0x181639500")]
		private void _HandleJumpingCharRepoMessage(UniWebViewMessage msg)
		{
		}

		// Token: 0x0601CD70 RID: 118128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD70")]
		[Address(RVA = "0x1639680", Offset = "0x1638280", VA = "0x181639680")]
		private void _HandleJumpingShopMessage(UniWebViewMessage msg)
		{
		}

		// Token: 0x0601CD71 RID: 118129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD71")]
		[Address(RVA = "0x16384F0", Offset = "0x16370F0", VA = "0x1816384F0")]
		public void EventOnBtnBackClick()
		{
		}

		// Token: 0x0601CD72 RID: 118130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD72")]
		[Address(RVA = "0x1639240", Offset = "0x1637E40", VA = "0x181639240")]
		private void _HandleJumpToActivityStageMessage(UniWebViewMessage msg)
		{
		}

		// Token: 0x0601CD73 RID: 118131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD73")]
		[Address(RVA = "0x163B140", Offset = "0x1639D40", VA = "0x18163B140")]
		public HomeAnnounceState()
		{
		}

		// Token: 0x0601CD76 RID: 118134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD76")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CD77 RID: 118135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CD77")]
		[Address(RVA = "0x15A4170", Offset = "0x15A2D70", VA = "0x1815A4170")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601CD78 RID: 118136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD78")]
		[Address(RVA = "0x15A41A0", Offset = "0x15A2DA0", VA = "0x1815A41A0")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x04025D66 RID: 154982
		[Token(Token = "0x4025D66")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HomeMainStateBean _stateBean;

		// Token: 0x04025D67 RID: 154983
		[Token(Token = "0x4025D67")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIUniWebView _webView;

		// Token: 0x04025D68 RID: 154984
		[Token(Token = "0x4025D68")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _prefabContainer;

		// Token: 0x04025D69 RID: 154985
		[Token(Token = "0x4025D69")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _tabContainer;

		// Token: 0x04025D6A RID: 154986
		[Token(Token = "0x4025D6A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private List<TwoStateToggle> _tagList;

		// Token: 0x04025D6B RID: 154987
		[Token(Token = "0x4025D6B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private HomeAnnounceTab _announceTab;

		// Token: 0x04025D6C RID: 154988
		[Token(Token = "0x4025D6C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ScrollRectSoftMask _softMask;

		// Token: 0x04025D6D RID: 154989
		[Token(Token = "0x4025D6D")]
		[FieldOffset(Offset = "0xA8")]
		private List<HomeAnnounceTab> m_announceTabList;

		// Token: 0x04025D6E RID: 154990
		[Token(Token = "0x4025D6E")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x04025D6F RID: 154991
		[Token(Token = "0x4025D6F")]
		[FieldOffset(Offset = "0xB8")]
		private AnnounceData m_database;

		// Token: 0x04025D70 RID: 154992
		[Token(Token = "0x4025D70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025D71 RID: 154993
		[Token(Token = "0x4025D71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025D72 RID: 154994
		[Token(Token = "0x4025D72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025D73 RID: 154995
		[Token(Token = "0x4025D73")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04025D74 RID: 154996
		[Token(Token = "0x4025D74")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04025D75 RID: 154997
		[Token(Token = "0x4025D75")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x04025D76 RID: 154998
		[Token(Token = "0x4025D76")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetDefaultAnnounce;

		// Token: 0x04025D77 RID: 154999
		[Token(Token = "0x4025D77")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSelectActivityGroup;

		// Token: 0x04025D78 RID: 155000
		[Token(Token = "0x4025D78")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnSelectSystemGroup;

		// Token: 0x04025D79 RID: 155001
		[Token(Token = "0x4025D79")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnSelectTab;

		// Token: 0x04025D7A RID: 155002
		[Token(Token = "0x4025D7A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSelectTab;

		// Token: 0x04025D7B RID: 155003
		[Token(Token = "0x4025D7B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix1__OnSelectTab;

		// Token: 0x04025D7C RID: 155004
		[Token(Token = "0x4025D7C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetAnnounceDataByAnnounceGroup;

		// Token: 0x04025D7D RID: 155005
		[Token(Token = "0x4025D7D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnSelectGroup;

		// Token: 0x04025D7E RID: 155006
		[Token(Token = "0x4025D7E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OpenWebView;

		// Token: 0x04025D7F RID: 155007
		[Token(Token = "0x4025D7F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InjectGameInfoToUrl;

		// Token: 0x04025D80 RID: 155008
		[Token(Token = "0x4025D80")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetGameInfoFromTag;

		// Token: 0x04025D81 RID: 155009
		[Token(Token = "0x4025D81")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandleWebViewMessage;

		// Token: 0x04025D82 RID: 155010
		[Token(Token = "0x4025D82")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandleJumpingCharRepoMessage;

		// Token: 0x04025D83 RID: 155011
		[Token(Token = "0x4025D83")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__HandleJumpingShopMessage;

		// Token: 0x04025D84 RID: 155012
		[Token(Token = "0x4025D84")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnBtnBackClick;

		// Token: 0x04025D85 RID: 155013
		[Token(Token = "0x4025D85")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__HandleJumpToActivityStageMessage;

		// Token: 0x04025D86 RID: 155014
		[Token(Token = "0x4025D86")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
