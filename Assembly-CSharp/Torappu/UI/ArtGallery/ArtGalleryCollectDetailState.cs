using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065D3 RID: 26067
	[Token(Token = "0x20065D3")]
	public class ArtGalleryCollectDetailState : PopupFadeState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x0602576C RID: 153452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602576C")]
		[Address(RVA = "0x2058D60", Offset = "0x2057960", VA = "0x182058D60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602576D RID: 153453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602576D")]
		[Address(RVA = "0x2058DC0", Offset = "0x20579C0", VA = "0x182058DC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602576E RID: 153454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602576E")]
		[Address(RVA = "0x20595D0", Offset = "0x20581D0", VA = "0x1820595D0", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0602576F RID: 153455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602576F")]
		[Address(RVA = "0x20597E0", Offset = "0x20583E0", VA = "0x1820597E0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06025770 RID: 153456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025770")]
		[Address(RVA = "0x2059940", Offset = "0x2058540", VA = "0x182059940", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06025771 RID: 153457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025771")]
		[Address(RVA = "0x2058F00", Offset = "0x2057B00", VA = "0x182058F00", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06025772 RID: 153458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025772")]
		[Address(RVA = "0x2059C40", Offset = "0x2058840", VA = "0x182059C40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025773 RID: 153459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025773")]
		[Address(RVA = "0x2059B10", Offset = "0x2058710", VA = "0x182059B10")]
		private void _InitData()
		{
		}

		// Token: 0x06025774 RID: 153460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025774")]
		[Address(RVA = "0x205A790", Offset = "0x2059390", VA = "0x18205A790")]
		private void _UpdateData()
		{
		}

		// Token: 0x06025775 RID: 153461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025775")]
		[Address(RVA = "0x205A480", Offset = "0x2059080", VA = "0x18205A480")]
		private void _OnExitClick()
		{
		}

		// Token: 0x06025776 RID: 153462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025776")]
		[Address(RVA = "0x205A6B0", Offset = "0x20592B0", VA = "0x18205A6B0")]
		private void _ToPlayerAvatarDisplayState(IStateBean stateBean)
		{
		}

		// Token: 0x06025777 RID: 153463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025777")]
		[Address(RVA = "0x205A510", Offset = "0x2059110", VA = "0x18205A510")]
		private void _ToDetailMissionState(IStateBean stateBean)
		{
		}

		// Token: 0x06025778 RID: 153464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025778")]
		[Address(RVA = "0x205A270", Offset = "0x2058E70", VA = "0x18205A270")]
		private void _OnClickHomeTheme(string themeId)
		{
		}

		// Token: 0x06025779 RID: 153465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025779")]
		[Address(RVA = "0x205A100", Offset = "0x2058D00", VA = "0x18205A100")]
		private void _OnClickHomeBackground(string bgId)
		{
		}

		// Token: 0x0602577A RID: 153466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602577A")]
		[Address(RVA = "0x2059D40", Offset = "0x2058940", VA = "0x182059D40")]
		private void _OnClickAvatar(string avatarId)
		{
		}

		// Token: 0x0602577B RID: 153467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602577B")]
		[Address(RVA = "0x205A3E0", Offset = "0x2058FE0", VA = "0x18205A3E0")]
		private void _OnClickNameCard(string nameCardId)
		{
		}

		// Token: 0x0602577C RID: 153468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602577C")]
		[Address(RVA = "0x2059E90", Offset = "0x2058A90", VA = "0x182059E90")]
		private void _OnClickCharSkin(string skinId)
		{
		}

		// Token: 0x0602577D RID: 153469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602577D")]
		[Address(RVA = "0x2059FF0", Offset = "0x2058BF0", VA = "0x182059FF0")]
		private void _OnClickClaimRewardPreview()
		{
		}

		// Token: 0x0602577E RID: 153470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602577E")]
		[Address(RVA = "0x205A840", Offset = "0x2059440", VA = "0x18205A840")]
		public ArtGalleryCollectDetailState()
		{
		}

		// Token: 0x0602577F RID: 153471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602577F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06025780 RID: 153472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025780")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06025781 RID: 153473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025781")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06025782 RID: 153474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025782")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04034943 RID: 215363
		[Token(Token = "0x4034943")]
		public const int MSG_HOME_THEME_CLICK = 1;

		// Token: 0x04034944 RID: 215364
		[Token(Token = "0x4034944")]
		public const int MSG_HOME_BACKGROUND_CLICK = 2;

		// Token: 0x04034945 RID: 215365
		[Token(Token = "0x4034945")]
		public const int MSG_NAMECARD_CLICK = 3;

		// Token: 0x04034946 RID: 215366
		[Token(Token = "0x4034946")]
		public const int MSG_AVATAR_CLICK = 4;

		// Token: 0x04034947 RID: 215367
		[Token(Token = "0x4034947")]
		public const int MSG_CHAR_SKIN_CLICK = 5;

		// Token: 0x04034948 RID: 215368
		[Token(Token = "0x4034948")]
		public const int MSG_OPEN_CLAIM_REWARD_PREVIEW = 6;

		// Token: 0x04034949 RID: 215369
		[Token(Token = "0x4034949")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _topMenuContainer;

		// Token: 0x0403494A RID: 215370
		[Token(Token = "0x403494A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ArtGalleryCollectDetailView _view;

		// Token: 0x0403494B RID: 215371
		[Token(Token = "0x403494B")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403494C RID: 215372
		[Token(Token = "0x403494C")]
		[FieldOffset(Offset = "0x90")]
		private ArtGalleryCollectDetailProperty m_prop;

		// Token: 0x0403494D RID: 215373
		[Token(Token = "0x403494D")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0403494E RID: 215374
		[Token(Token = "0x403494E")]
		[FieldOffset(Offset = "0xA0")]
		private UIItemViewModel m_cachedJumpItemViewModel;

		// Token: 0x0403494F RID: 215375
		[Token(Token = "0x403494F")]
		[FieldOffset(Offset = "0xA8")]
		private HashSet<string> m_cachedOnShowSkinIds;

		// Token: 0x04034950 RID: 215376
		[Token(Token = "0x4034950")]
		[FieldOffset(Offset = "0xB0")]
		private List<ShopSkinItemViewModel> m_cachedShopSkinViewModels;

		// Token: 0x04034951 RID: 215377
		[Token(Token = "0x4034951")]
		[FieldOffset(Offset = "0xB8")]
		private ArtGalleryCollectDetailStateBean m_stateBean;

		// Token: 0x04034952 RID: 215378
		[Token(Token = "0x4034952")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04034953 RID: 215379
		[Token(Token = "0x4034953")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04034954 RID: 215380
		[Token(Token = "0x4034954")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04034955 RID: 215381
		[Token(Token = "0x4034955")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04034956 RID: 215382
		[Token(Token = "0x4034956")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04034957 RID: 215383
		[Token(Token = "0x4034957")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04034958 RID: 215384
		[Token(Token = "0x4034958")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034959 RID: 215385
		[Token(Token = "0x4034959")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0403495A RID: 215386
		[Token(Token = "0x403495A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x0403495B RID: 215387
		[Token(Token = "0x403495B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnExitClick;

		// Token: 0x0403495C RID: 215388
		[Token(Token = "0x403495C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ToPlayerAvatarDisplayState;

		// Token: 0x0403495D RID: 215389
		[Token(Token = "0x403495D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ToDetailMissionState;

		// Token: 0x0403495E RID: 215390
		[Token(Token = "0x403495E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnClickHomeTheme;

		// Token: 0x0403495F RID: 215391
		[Token(Token = "0x403495F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnClickHomeBackground;

		// Token: 0x04034960 RID: 215392
		[Token(Token = "0x4034960")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnClickAvatar;

		// Token: 0x04034961 RID: 215393
		[Token(Token = "0x4034961")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnClickNameCard;

		// Token: 0x04034962 RID: 215394
		[Token(Token = "0x4034962")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnClickCharSkin;

		// Token: 0x04034963 RID: 215395
		[Token(Token = "0x4034963")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnClickClaimRewardPreview;

		// Token: 0x04034964 RID: 215396
		[Token(Token = "0x4034964")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
