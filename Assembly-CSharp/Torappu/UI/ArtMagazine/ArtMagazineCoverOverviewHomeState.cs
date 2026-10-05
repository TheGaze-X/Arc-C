using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006535 RID: 25909
	[Token(Token = "0x2006535")]
	public class ArtMagazineCoverOverviewHomeState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x060253CF RID: 152527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60253CF")]
		[Address(RVA = "0x202FA80", Offset = "0x202E680", VA = "0x18202FA80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060253D0 RID: 152528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253D0")]
		[Address(RVA = "0x202FAE0", Offset = "0x202E6E0", VA = "0x18202FAE0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060253D1 RID: 152529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253D1")]
		[Address(RVA = "0x20301B0", Offset = "0x202EDB0", VA = "0x1820301B0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060253D2 RID: 152530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253D2")]
		[Address(RVA = "0x202FD10", Offset = "0x202E910", VA = "0x18202FD10", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060253D3 RID: 152531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253D3")]
		[Address(RVA = "0x2030490", Offset = "0x202F090", VA = "0x182030490")]
		private void _OnLeafItemClick(string leafId)
		{
		}

		// Token: 0x060253D4 RID: 152532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253D4")]
		[Address(RVA = "0x2030C00", Offset = "0x202F800", VA = "0x182030C00")]
		private void _SwitchViewDisplayType()
		{
		}

		// Token: 0x060253D5 RID: 152533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253D5")]
		[Address(RVA = "0x2030D70", Offset = "0x202F970", VA = "0x182030D70")]
		private void _TransToLeft()
		{
		}

		// Token: 0x060253D6 RID: 152534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253D6")]
		[Address(RVA = "0x2030EE0", Offset = "0x202FAE0", VA = "0x182030EE0")]
		private void _TransToRight()
		{
		}

		// Token: 0x060253D7 RID: 152535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253D7")]
		[Address(RVA = "0x20309C0", Offset = "0x202F5C0", VA = "0x1820309C0")]
		private void _RequestLeafThumbnailUrls(List<string> leafIds)
		{
		}

		// Token: 0x060253D8 RID: 152536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253D8")]
		[Address(RVA = "0x2030750", Offset = "0x202F350", VA = "0x182030750")]
		private void _OnRequestLeafThumbnailUrlsSuc(ArtMagazineGetThumbnailUrlResponse response)
		{
		}

		// Token: 0x060253D9 RID: 152537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253D9")]
		[Address(RVA = "0x2030400", Offset = "0x202F000", VA = "0x182030400")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060253DA RID: 152538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253DA")]
		[Address(RVA = "0x2031060", Offset = "0x202FC60", VA = "0x182031060")]
		public ArtMagazineCoverOverviewHomeState()
		{
		}

		// Token: 0x060253DB RID: 152539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253DB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060253DC RID: 152540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253DC")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040343D9 RID: 213977
		[Token(Token = "0x40343D9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ArtMagazineCoverOverviewHomeView _view;

		// Token: 0x040343DA RID: 213978
		[Token(Token = "0x40343DA")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x040343DB RID: 213979
		[Token(Token = "0x40343DB")]
		[FieldOffset(Offset = "0x80")]
		private ArtMagazineCoverOverviewHomeViewModelProperty m_property;

		// Token: 0x040343DC RID: 213980
		[Token(Token = "0x40343DC")]
		[NonSerialized]
		public const int EVENT_ON_LEAF_ITEM_CLICK = 0;

		// Token: 0x040343DD RID: 213981
		[Token(Token = "0x40343DD")]
		[NonSerialized]
		public const int EVENT_ON_ARROW_LEFT_CLICK = 1;

		// Token: 0x040343DE RID: 213982
		[Token(Token = "0x40343DE")]
		[NonSerialized]
		public const int EVENT_ON_ARROW_RIGHT_CLICK = 2;

		// Token: 0x040343DF RID: 213983
		[Token(Token = "0x40343DF")]
		[NonSerialized]
		public const int EVENT_ON_DISPLAY_BTN_CLICK = 3;

		// Token: 0x040343E0 RID: 213984
		[Token(Token = "0x40343E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040343E1 RID: 213985
		[Token(Token = "0x40343E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040343E2 RID: 213986
		[Token(Token = "0x40343E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040343E3 RID: 213987
		[Token(Token = "0x40343E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040343E4 RID: 213988
		[Token(Token = "0x40343E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnLeafItemClick;

		// Token: 0x040343E5 RID: 213989
		[Token(Token = "0x40343E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SwitchViewDisplayType;

		// Token: 0x040343E6 RID: 213990
		[Token(Token = "0x40343E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TransToLeft;

		// Token: 0x040343E7 RID: 213991
		[Token(Token = "0x40343E7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TransToRight;

		// Token: 0x040343E8 RID: 213992
		[Token(Token = "0x40343E8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RequestLeafThumbnailUrls;

		// Token: 0x040343E9 RID: 213993
		[Token(Token = "0x40343E9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnRequestLeafThumbnailUrlsSuc;

		// Token: 0x040343EA RID: 213994
		[Token(Token = "0x40343EA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040343EB RID: 213995
		[Token(Token = "0x40343EB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
