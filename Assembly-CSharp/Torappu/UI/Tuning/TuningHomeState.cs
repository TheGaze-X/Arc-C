using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CA7 RID: 15527
	[Token(Token = "0x2003CA7")]
	public class TuningHomeState : PopupFadeState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x060183B6 RID: 99254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183B6")]
		[Address(RVA = "0x10BF730", Offset = "0x10BE330", VA = "0x1810BF730", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060183B7 RID: 99255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183B7")]
		[Address(RVA = "0x10BFE80", Offset = "0x10BEA80", VA = "0x1810BFE80", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060183B8 RID: 99256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60183B8")]
		[Address(RVA = "0x10BF6D0", Offset = "0x10BE2D0", VA = "0x1810BF6D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060183B9 RID: 99257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60183B9")]
		[Address(RVA = "0x10BFFD0", Offset = "0x10BEBD0", VA = "0x1810BFFD0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060183BA RID: 99258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183BA")]
		[Address(RVA = "0x10C0550", Offset = "0x10BF150", VA = "0x1810C0550")]
		private void _OnJumpToChatState(IStateBean sb)
		{
		}

		// Token: 0x060183BB RID: 99259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183BB")]
		[Address(RVA = "0x10BFC00", Offset = "0x10BE800", VA = "0x1810BFC00", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060183BC RID: 99260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183BC")]
		[Address(RVA = "0x10C06E0", Offset = "0x10BF2E0", VA = "0x1810C06E0")]
		private void _OnProductBtnClicked()
		{
		}

		// Token: 0x060183BD RID: 99261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183BD")]
		[Address(RVA = "0x10C0790", Offset = "0x10BF390", VA = "0x1810C0790")]
		private void _OnStartInvestBtnClicked(ValueBundle msg)
		{
		}

		// Token: 0x060183BE RID: 99262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183BE")]
		[Address(RVA = "0x10C0AA0", Offset = "0x10BF6A0", VA = "0x1810C0AA0")]
		private void _OnUnlockInvestBtnClicked()
		{
		}

		// Token: 0x060183BF RID: 99263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183BF")]
		[Address(RVA = "0x10C0290", Offset = "0x10BEE90", VA = "0x1810C0290")]
		private void _OnArchiveBtnClicked()
		{
		}

		// Token: 0x060183C0 RID: 99264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183C0")]
		[Address(RVA = "0x10C0630", Offset = "0x10BF230", VA = "0x1810C0630")]
		private void _OnMajorInvestDetailBtnClicked()
		{
		}

		// Token: 0x060183C1 RID: 99265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183C1")]
		[Address(RVA = "0x10C0130", Offset = "0x10BED30", VA = "0x1810C0130")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060183C2 RID: 99266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183C2")]
		[Address(RVA = "0x10C04A0", Offset = "0x10BF0A0", VA = "0x1810C04A0")]
		private void _OnBackBtnPressed()
		{
		}

		// Token: 0x060183C3 RID: 99267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183C3")]
		[Address(RVA = "0x10C0E10", Offset = "0x10BFA10", VA = "0x1810C0E10")]
		private void _PlayEntryAnim()
		{
		}

		// Token: 0x060183C4 RID: 99268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183C4")]
		[Address(RVA = "0x10C0D00", Offset = "0x10BF900", VA = "0x1810C0D00")]
		private void _OnUnlockMajorInvestProceed(TuningStartMajorInvestResponse response)
		{
		}

		// Token: 0x060183C5 RID: 99269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183C5")]
		[Address(RVA = "0x10C0FD0", Offset = "0x10BFBD0", VA = "0x1810C0FD0")]
		private void _TryConsumeGuidebook()
		{
		}

		// Token: 0x060183C6 RID: 99270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183C6")]
		[Address(RVA = "0x10C1050", Offset = "0x10BFC50", VA = "0x1810C1050")]
		public TuningHomeState()
		{
		}

		// Token: 0x060183C7 RID: 99271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183C7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060183C8 RID: 99272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183C8")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060183C9 RID: 99273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60183C9")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0401D8A1 RID: 120993
		[Token(Token = "0x401D8A1")]
		private const string ENTRY_ANIM_NAME = "tuning_home_entry_anim";

		// Token: 0x0401D8A2 RID: 120994
		[Token(Token = "0x401D8A2")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "home";

		// Token: 0x0401D8A3 RID: 120995
		[Token(Token = "0x401D8A3")]
		[NonSerialized]
		public const int ON_PRODUCT_BTN_CLICKED = 0;

		// Token: 0x0401D8A4 RID: 120996
		[Token(Token = "0x401D8A4")]
		[NonSerialized]
		public const int ON_START_INVEST_BTN_CLICKED = 1;

		// Token: 0x0401D8A5 RID: 120997
		[Token(Token = "0x401D8A5")]
		[NonSerialized]
		public const int ON_UNLOCK_MAJOR_INVEST_BTN_CLICKED = 2;

		// Token: 0x0401D8A6 RID: 120998
		[Token(Token = "0x401D8A6")]
		[NonSerialized]
		public const int ON_ARCHIVE_BTN_CLICKED = 3;

		// Token: 0x0401D8A7 RID: 120999
		[Token(Token = "0x401D8A7")]
		[NonSerialized]
		public const int ON_MAJOR_INVEST_DETAIL_BTN_CLICKED = 4;

		// Token: 0x0401D8A8 RID: 121000
		[Token(Token = "0x401D8A8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TuningHomeFragGroupView _fragGroupView;

		// Token: 0x0401D8A9 RID: 121001
		[Token(Token = "0x401D8A9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TuningHomeInvestGroupView _investView;

		// Token: 0x0401D8AA RID: 121002
		[Token(Token = "0x401D8AA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0401D8AB RID: 121003
		[Token(Token = "0x401D8AB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0401D8AC RID: 121004
		[Token(Token = "0x401D8AC")]
		[FieldOffset(Offset = "0x90")]
		private TuningHomeStateBean m_stateBean;

		// Token: 0x0401D8AD RID: 121005
		[Token(Token = "0x401D8AD")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0401D8AE RID: 121006
		[Token(Token = "0x401D8AE")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_entryAnim;

		// Token: 0x0401D8AF RID: 121007
		[Token(Token = "0x401D8AF")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cachedInvestId;

		// Token: 0x0401D8B0 RID: 121008
		[Token(Token = "0x401D8B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401D8B1 RID: 121009
		[Token(Token = "0x401D8B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401D8B2 RID: 121010
		[Token(Token = "0x401D8B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D8B3 RID: 121011
		[Token(Token = "0x401D8B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401D8B4 RID: 121012
		[Token(Token = "0x401D8B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToChatState;

		// Token: 0x0401D8B5 RID: 121013
		[Token(Token = "0x401D8B5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401D8B6 RID: 121014
		[Token(Token = "0x401D8B6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnProductBtnClicked;

		// Token: 0x0401D8B7 RID: 121015
		[Token(Token = "0x401D8B7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnStartInvestBtnClicked;

		// Token: 0x0401D8B8 RID: 121016
		[Token(Token = "0x401D8B8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnUnlockInvestBtnClicked;

		// Token: 0x0401D8B9 RID: 121017
		[Token(Token = "0x401D8B9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnArchiveBtnClicked;

		// Token: 0x0401D8BA RID: 121018
		[Token(Token = "0x401D8BA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnMajorInvestDetailBtnClicked;

		// Token: 0x0401D8BB RID: 121019
		[Token(Token = "0x401D8BB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D8BC RID: 121020
		[Token(Token = "0x401D8BC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnBackBtnPressed;

		// Token: 0x0401D8BD RID: 121021
		[Token(Token = "0x401D8BD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0401D8BE RID: 121022
		[Token(Token = "0x401D8BE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnUnlockMajorInvestProceed;

		// Token: 0x0401D8BF RID: 121023
		[Token(Token = "0x401D8BF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x0401D8C0 RID: 121024
		[Token(Token = "0x401D8C0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CA8 RID: 15528
		[Token(Token = "0x2003CA8")]
		public class StartInvestParam
		{
			// Token: 0x060183CA RID: 99274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60183CA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StartInvestParam()
			{
			}

			// Token: 0x0401D8C1 RID: 121025
			[Token(Token = "0x401D8C1")]
			[FieldOffset(Offset = "0x10")]
			public TuningInvestType type;

			// Token: 0x0401D8C2 RID: 121026
			[Token(Token = "0x401D8C2")]
			[FieldOffset(Offset = "0x18")]
			public string investId;
		}
	}
}
