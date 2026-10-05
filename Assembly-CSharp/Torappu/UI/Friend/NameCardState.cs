using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D6A RID: 19818
	[Token(Token = "0x2004D6A")]
	public class NameCardState : State, IValueMsgReceiver
	{
		// Token: 0x0601DA81 RID: 121473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DA81")]
		[Address(RVA = "0x1737550", Offset = "0x1736150", VA = "0x181737550", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601DA82 RID: 121474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA82")]
		[Address(RVA = "0x17375B0", Offset = "0x17361B0", VA = "0x1817375B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601DA83 RID: 121475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA83")]
		[Address(RVA = "0x1738090", Offset = "0x1736C90", VA = "0x181738090", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0601DA84 RID: 121476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA84")]
		[Address(RVA = "0x17376E0", Offset = "0x17362E0", VA = "0x1817376E0", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601DA85 RID: 121477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA85")]
		[Address(RVA = "0x1738E20", Offset = "0x1737A20", VA = "0x181738E20")]
		private void _OpenAvatarPage()
		{
		}

		// Token: 0x0601DA86 RID: 121478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA86")]
		[Address(RVA = "0x1738F40", Offset = "0x1737B40", VA = "0x181738F40")]
		private void _OpenMedalSettings()
		{
		}

		// Token: 0x0601DA87 RID: 121479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA87")]
		[Address(RVA = "0x17392F0", Offset = "0x1737EF0", VA = "0x1817392F0")]
		private void _SwitchOperatorCountStyle(string moduleId)
		{
		}

		// Token: 0x0601DA88 RID: 121480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA88")]
		[Address(RVA = "0x1739110", Offset = "0x1737D10", VA = "0x181739110")]
		private void _SwitchAssistModuleStyle(string moduleId)
		{
		}

		// Token: 0x0601DA89 RID: 121481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA89")]
		[Address(RVA = "0x1739200", Offset = "0x1737E00", VA = "0x181739200")]
		private void _SwitchEquipModuleStyle(string moduleId)
		{
		}

		// Token: 0x0601DA8A RID: 121482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA8A")]
		[Address(RVA = "0x1739540", Offset = "0x1738140", VA = "0x181739540")]
		private void _ToChangeSkin()
		{
		}

		// Token: 0x0601DA8B RID: 121483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA8B")]
		[Address(RVA = "0x17393E0", Offset = "0x1737FE0", VA = "0x1817393E0")]
		private void _ToCardAlbum(FriendDataWithNameCard friendData)
		{
		}

		// Token: 0x0601DA8C RID: 121484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA8C")]
		[Address(RVA = "0x1738D50", Offset = "0x1737950", VA = "0x181738D50")]
		private void _OpenAssistState()
		{
		}

		// Token: 0x0601DA8D RID: 121485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA8D")]
		[Address(RVA = "0x1738BC0", Offset = "0x17377C0", VA = "0x181738BC0")]
		private void _OnStartChangeResume()
		{
		}

		// Token: 0x0601DA8E RID: 121486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA8E")]
		[Address(RVA = "0x1738A90", Offset = "0x1737690", VA = "0x181738A90")]
		private void _OnEditResumeFinished(bool isConfirmed)
		{
		}

		// Token: 0x0601DA8F RID: 121487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA8F")]
		[Address(RVA = "0x1738250", Offset = "0x1736E50", VA = "0x181738250")]
		private void _CrossAppShare(string skinId, int skinTmpl, bool isDetail)
		{
		}

		// Token: 0x0601DA90 RID: 121488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA90")]
		[Address(RVA = "0x1738570", Offset = "0x1737170", VA = "0x181738570")]
		private void _ExtendNameCard(bool isExtend)
		{
		}

		// Token: 0x0601DA91 RID: 121489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA91")]
		[Address(RVA = "0x1738FE0", Offset = "0x1737BE0", VA = "0x181738FE0")]
		private void _OpenNameCardEditState()
		{
		}

		// Token: 0x0601DA92 RID: 121490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA92")]
		[Address(RVA = "0x1738EA0", Offset = "0x1737AA0", VA = "0x181738EA0")]
		private void _OpenMagazineCoverPage()
		{
		}

		// Token: 0x0601DA93 RID: 121491 RVA: 0x000AC2A8 File Offset: 0x000AA4A8
		[Token(Token = "0x601DA93")]
		[Address(RVA = "0x17389F0", Offset = "0x17375F0", VA = "0x1817389F0")]
		private bool _IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601DA94 RID: 121492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA94")]
		[Address(RVA = "0x17387C0", Offset = "0x17373C0", VA = "0x1817387C0")]
		private void _InitNameCardIfNot()
		{
		}

		// Token: 0x0601DA95 RID: 121493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA95")]
		[Address(RVA = "0x17381A0", Offset = "0x1736DA0", VA = "0x1817381A0")]
		public void OpenLarge()
		{
		}

		// Token: 0x0601DA96 RID: 121494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA96")]
		[Address(RVA = "0x1739650", Offset = "0x1738250", VA = "0x181739650")]
		public NameCardState()
		{
		}

		// Token: 0x0601DA97 RID: 121495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA97")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601DA98 RID: 121496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA98")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x040272D7 RID: 160471
		[Token(Token = "0x40272D7")]
		[NonSerialized]
		public const int OPEN_AVATAR_PAGE = 0;

		// Token: 0x040272D8 RID: 160472
		[Token(Token = "0x40272D8")]
		[NonSerialized]
		public const int OPEN_FRIEND_MEDAL_STATE = 1;

		// Token: 0x040272D9 RID: 160473
		[Token(Token = "0x40272D9")]
		[NonSerialized]
		public const int SWITCH_OPERATOR_COUNT_STYLE = 2;

		// Token: 0x040272DA RID: 160474
		[Token(Token = "0x40272DA")]
		[NonSerialized]
		public const int SWITCH_ASSIST_MODULE_STYLE = 3;

		// Token: 0x040272DB RID: 160475
		[Token(Token = "0x40272DB")]
		[NonSerialized]
		public const int OPEN_ASSIST_STATE = 4;

		// Token: 0x040272DC RID: 160476
		[Token(Token = "0x40272DC")]
		[NonSerialized]
		public const int START_CHANGE_RESUME = 5;

		// Token: 0x040272DD RID: 160477
		[Token(Token = "0x40272DD")]
		[NonSerialized]
		public const int CROSS_APP_SHARE = 6;

		// Token: 0x040272DE RID: 160478
		[Token(Token = "0x40272DE")]
		[NonSerialized]
		public const int CROSS_APP_SHARE_SIMPLE = 7;

		// Token: 0x040272DF RID: 160479
		[Token(Token = "0x40272DF")]
		[NonSerialized]
		public const int EXTEND_NAMECARD = 8;

		// Token: 0x040272E0 RID: 160480
		[Token(Token = "0x40272E0")]
		[NonSerialized]
		public const int OPEN_EDIT_STATE = 9;

		// Token: 0x040272E1 RID: 160481
		[Token(Token = "0x40272E1")]
		[NonSerialized]
		public const int SWITCH_EQUIP_MODULE_STYLE = 10;

		// Token: 0x040272E2 RID: 160482
		[Token(Token = "0x40272E2")]
		[NonSerialized]
		public const int TO_SKIN_CHANGE = 11;

		// Token: 0x040272E3 RID: 160483
		[Token(Token = "0x40272E3")]
		[NonSerialized]
		public const int TO_CARD_ALBUM = 12;

		// Token: 0x040272E4 RID: 160484
		[Token(Token = "0x40272E4")]
		[NonSerialized]
		public const int OPEN_MAGAZINE_COVER_PAGE = 13;

		// Token: 0x040272E5 RID: 160485
		[Token(Token = "0x40272E5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x040272E6 RID: 160486
		[Token(Token = "0x40272E6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private NameCardV2ChangeSkinButtonView _changeSkinButtonView;

		// Token: 0x040272E7 RID: 160487
		[Token(Token = "0x40272E7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private NameCardV2EditButtonView _editButtonView;

		// Token: 0x040272E8 RID: 160488
		[Token(Token = "0x40272E8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private NameCardV2MagazineButtonView _magazineButtonView;

		// Token: 0x040272E9 RID: 160489
		[Token(Token = "0x40272E9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FriendStateControl _stateControl;

		// Token: 0x040272EA RID: 160490
		[Token(Token = "0x40272EA")]
		[FieldOffset(Offset = "0x78")]
		private NameCardV2StateBean m_stateBean;

		// Token: 0x040272EB RID: 160491
		[Token(Token = "0x40272EB")]
		[FieldOffset(Offset = "0x80")]
		private NameCardV2View m_nameCardView;

		// Token: 0x040272EC RID: 160492
		[Token(Token = "0x40272EC")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasNameCardInited;

		// Token: 0x040272ED RID: 160493
		[Token(Token = "0x40272ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040272EE RID: 160494
		[Token(Token = "0x40272EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040272EF RID: 160495
		[Token(Token = "0x40272EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x040272F0 RID: 160496
		[Token(Token = "0x40272F0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040272F1 RID: 160497
		[Token(Token = "0x40272F1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OpenAvatarPage;

		// Token: 0x040272F2 RID: 160498
		[Token(Token = "0x40272F2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OpenMedalSettings;

		// Token: 0x040272F3 RID: 160499
		[Token(Token = "0x40272F3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SwitchOperatorCountStyle;

		// Token: 0x040272F4 RID: 160500
		[Token(Token = "0x40272F4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SwitchAssistModuleStyle;

		// Token: 0x040272F5 RID: 160501
		[Token(Token = "0x40272F5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SwitchEquipModuleStyle;

		// Token: 0x040272F6 RID: 160502
		[Token(Token = "0x40272F6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ToChangeSkin;

		// Token: 0x040272F7 RID: 160503
		[Token(Token = "0x40272F7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ToCardAlbum;

		// Token: 0x040272F8 RID: 160504
		[Token(Token = "0x40272F8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OpenAssistState;

		// Token: 0x040272F9 RID: 160505
		[Token(Token = "0x40272F9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnStartChangeResume;

		// Token: 0x040272FA RID: 160506
		[Token(Token = "0x40272FA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnEditResumeFinished;

		// Token: 0x040272FB RID: 160507
		[Token(Token = "0x40272FB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CrossAppShare;

		// Token: 0x040272FC RID: 160508
		[Token(Token = "0x40272FC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ExtendNameCard;

		// Token: 0x040272FD RID: 160509
		[Token(Token = "0x40272FD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OpenNameCardEditState;

		// Token: 0x040272FE RID: 160510
		[Token(Token = "0x40272FE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OpenMagazineCoverPage;

		// Token: 0x040272FF RID: 160511
		[Token(Token = "0x40272FF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__IsStateStable;

		// Token: 0x04027300 RID: 160512
		[Token(Token = "0x4027300")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__InitNameCardIfNot;

		// Token: 0x04027301 RID: 160513
		[Token(Token = "0x4027301")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OpenLarge;

		// Token: 0x04027302 RID: 160514
		[Token(Token = "0x4027302")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
