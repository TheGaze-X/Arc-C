using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DC8 RID: 15816
	[Token(Token = "0x2003DC8")]
	public class SquadFriendAssistState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601899E RID: 100766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601899E")]
		[Address(RVA = "0x11262E0", Offset = "0x1124EE0", VA = "0x1811262E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601899F RID: 100767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601899F")]
		[Address(RVA = "0x1124C80", Offset = "0x1123880", VA = "0x181124C80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060189A0 RID: 100768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189A0")]
		[Address(RVA = "0x1124680", Offset = "0x1123280", VA = "0x181124680")]
		public void EventOnApplyAssist(SquadAssistData friendApplied, bool isFriend)
		{
		}

		// Token: 0x060189A1 RID: 100769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189A1")]
		[Address(RVA = "0x1124CE0", Offset = "0x11238E0", VA = "0x181124CE0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060189A2 RID: 100770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189A2")]
		[Address(RVA = "0x1127BB0", Offset = "0x11267B0", VA = "0x181127BB0")]
		private void _UpdateTip()
		{
		}

		// Token: 0x060189A3 RID: 100771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189A3")]
		[Address(RVA = "0x1125970", Offset = "0x1124570", VA = "0x181125970", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060189A4 RID: 100772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189A4")]
		[Address(RVA = "0x1125230", Offset = "0x1123E30", VA = "0x181125230", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x060189A5 RID: 100773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189A5")]
		[Address(RVA = "0x11273B0", Offset = "0x1125FB0", VA = "0x1811273B0")]
		private void _SendAssistCharListRequest(ProfessionCategory profession, bool refreshFlag)
		{
		}

		// Token: 0x060189A6 RID: 100774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189A6")]
		[Address(RVA = "0x1126500", Offset = "0x1125100", VA = "0x181126500")]
		private void _OnChangeProfessionTab(ProfessionCategory profession)
		{
		}

		// Token: 0x060189A7 RID: 100775 RVA: 0x0009AE78 File Offset: 0x00099078
		[Token(Token = "0x60189A7")]
		[Address(RVA = "0x1127A50", Offset = "0x1126650", VA = "0x181127A50")]
		private bool _TryGetNameCardData(string uid, out FriendDataWithNameCard data)
		{
			return default(bool);
		}

		// Token: 0x060189A8 RID: 100776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189A8")]
		[Address(RVA = "0x1125F30", Offset = "0x1124B30", VA = "0x181125F30")]
		private void _CacheNameCardData(string uid, FriendDataWithNameCard data)
		{
		}

		// Token: 0x060189A9 RID: 100777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189A9")]
		[Address(RVA = "0x1125BB0", Offset = "0x11247B0", VA = "0x181125BB0")]
		private void _ApplyAssistImpl(SquadAssistData friendApplied, bool isFriend, FriendDataWithNameCard nameCardData)
		{
		}

		// Token: 0x060189AA RID: 100778 RVA: 0x0009AE90 File Offset: 0x00099090
		[Token(Token = "0x60189AA")]
		[Address(RVA = "0x1126460", Offset = "0x1125060", VA = "0x181126460")]
		private bool _IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x060189AB RID: 100779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189AB")]
		[Address(RVA = "0x11259E0", Offset = "0x11245E0", VA = "0x1811259E0")]
		public void RefreshSquadAssist()
		{
		}

		// Token: 0x060189AC RID: 100780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189AC")]
		[Address(RVA = "0x1125360", Offset = "0x1123F60", VA = "0x181125360", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060189AD RID: 100781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189AD")]
		[Address(RVA = "0x1126660", Offset = "0x1125260", VA = "0x181126660")]
		private void _OnFriendAvatarClick(string uid)
		{
		}

		// Token: 0x060189AE RID: 100782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189AE")]
		[Address(RVA = "0x1126970", Offset = "0x1125570", VA = "0x181126970")]
		private void _OnGetNameCardSuc(GetOtherPlayerNameCardResponse response)
		{
		}

		// Token: 0x060189AF RID: 100783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189AF")]
		[Address(RVA = "0x1126FD0", Offset = "0x1125BD0", VA = "0x181126FD0")]
		private void _OpenNameCardDisplayPage(FriendDataWithNameCard friendData)
		{
		}

		// Token: 0x060189B0 RID: 100784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189B0")]
		[Address(RVA = "0x1127240", Offset = "0x1125E40", VA = "0x181127240")]
		private void _SelectAssistSkill(int index)
		{
		}

		// Token: 0x060189B1 RID: 100785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189B1")]
		[Address(RVA = "0x11270F0", Offset = "0x1125CF0", VA = "0x1811270F0")]
		private void _SelectAssistEquip(string equipId)
		{
		}

		// Token: 0x060189B2 RID: 100786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189B2")]
		[Address(RVA = "0x1126080", Offset = "0x1124C80", VA = "0x181126080")]
		private void _CloseAssistDetail()
		{
		}

		// Token: 0x060189B3 RID: 100787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189B3")]
		[Address(RVA = "0x11261A0", Offset = "0x1124DA0", VA = "0x1811261A0")]
		private void _ConfirmAssistChar()
		{
		}

		// Token: 0x060189B4 RID: 100788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189B4")]
		[Address(RVA = "0x11277D0", Offset = "0x11263D0", VA = "0x1811277D0")]
		private void _SendFriendRequest(string uid)
		{
		}

		// Token: 0x060189B5 RID: 100789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189B5")]
		[Address(RVA = "0x1126A10", Offset = "0x1125610", VA = "0x181126A10")]
		private void _OnSendFriendReqSuc(string uid)
		{
		}

		// Token: 0x060189B6 RID: 100790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189B6")]
		[Address(RVA = "0x1126D60", Offset = "0x1125960", VA = "0x181126D60")]
		private void _OpenCharShowPage()
		{
		}

		// Token: 0x060189B7 RID: 100791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189B7")]
		[Address(RVA = "0x1126BD0", Offset = "0x11257D0", VA = "0x181126BD0")]
		private void _OnStarFriendTabClick(bool prevState)
		{
		}

		// Token: 0x060189B8 RID: 100792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189B8")]
		[Address(RVA = "0x1127C10", Offset = "0x1126810", VA = "0x181127C10")]
		public SquadFriendAssistState()
		{
		}

		// Token: 0x060189BB RID: 100795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189BB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060189BC RID: 100796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189BC")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060189BD RID: 100797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60189BD")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0401E287 RID: 123527
		[Token(Token = "0x401E287")]
		private const string IGNORE_SQUAD_WEIGHT_SQUAD_ID = "-1";

		// Token: 0x0401E288 RID: 123528
		[Token(Token = "0x401E288")]
		[NonSerialized]
		public const int ON_FRIEND_AVATAR_CLICK = 0;

		// Token: 0x0401E289 RID: 123529
		[Token(Token = "0x401E289")]
		[NonSerialized]
		public const int ON_DETAIL_SKILL_CLICK = 1;

		// Token: 0x0401E28A RID: 123530
		[Token(Token = "0x401E28A")]
		[NonSerialized]
		public const int ON_DETAIL_EQUIP_CLICK = 2;

		// Token: 0x0401E28B RID: 123531
		[Token(Token = "0x401E28B")]
		[NonSerialized]
		public const int CLOSE_DETAIL_VIEW = 3;

		// Token: 0x0401E28C RID: 123532
		[Token(Token = "0x401E28C")]
		[NonSerialized]
		public const int CONFIRM_ASSIST_CHAR = 4;

		// Token: 0x0401E28D RID: 123533
		[Token(Token = "0x401E28D")]
		[NonSerialized]
		public const int SEND_FRIEND_REQUEST = 5;

		// Token: 0x0401E28E RID: 123534
		[Token(Token = "0x401E28E")]
		[NonSerialized]
		public const int OPEN_CHAR_SHOW_PAGE = 6;

		// Token: 0x0401E28F RID: 123535
		[Token(Token = "0x401E28F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401E290 RID: 123536
		[Token(Token = "0x401E290")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SquadFriendView _friendView;

		// Token: 0x0401E291 RID: 123537
		[Token(Token = "0x401E291")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SquadFriendDetailView _detailView;

		// Token: 0x0401E292 RID: 123538
		[Token(Token = "0x401E292")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textTips;

		// Token: 0x0401E293 RID: 123539
		[Token(Token = "0x401E293")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelTip;

		// Token: 0x0401E294 RID: 123540
		[Token(Token = "0x401E294")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SquadStarFriendTabView _starFriendTabView;

		// Token: 0x0401E295 RID: 123541
		[Token(Token = "0x401E295")]
		[FieldOffset(Offset = "0xA0")]
		private SquadFriendAssistStateBean m_stateBean;

		// Token: 0x0401E296 RID: 123542
		[Token(Token = "0x401E296")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x0401E297 RID: 123543
		[Token(Token = "0x401E297")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E298 RID: 123544
		[Token(Token = "0x401E298")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401E299 RID: 123545
		[Token(Token = "0x401E299")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnApplyAssist;

		// Token: 0x0401E29A RID: 123546
		[Token(Token = "0x401E29A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401E29B RID: 123547
		[Token(Token = "0x401E29B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateTip;

		// Token: 0x0401E29C RID: 123548
		[Token(Token = "0x401E29C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401E29D RID: 123549
		[Token(Token = "0x401E29D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401E29E RID: 123550
		[Token(Token = "0x401E29E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SendAssistCharListRequest;

		// Token: 0x0401E29F RID: 123551
		[Token(Token = "0x401E29F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnChangeProfessionTab;

		// Token: 0x0401E2A0 RID: 123552
		[Token(Token = "0x401E2A0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryGetNameCardData;

		// Token: 0x0401E2A1 RID: 123553
		[Token(Token = "0x401E2A1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CacheNameCardData;

		// Token: 0x0401E2A2 RID: 123554
		[Token(Token = "0x401E2A2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ApplyAssistImpl;

		// Token: 0x0401E2A3 RID: 123555
		[Token(Token = "0x401E2A3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__IsStateStable;

		// Token: 0x0401E2A4 RID: 123556
		[Token(Token = "0x401E2A4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RefreshSquadAssist;

		// Token: 0x0401E2A5 RID: 123557
		[Token(Token = "0x401E2A5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401E2A6 RID: 123558
		[Token(Token = "0x401E2A6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnFriendAvatarClick;

		// Token: 0x0401E2A7 RID: 123559
		[Token(Token = "0x401E2A7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnGetNameCardSuc;

		// Token: 0x0401E2A8 RID: 123560
		[Token(Token = "0x401E2A8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OpenNameCardDisplayPage;

		// Token: 0x0401E2A9 RID: 123561
		[Token(Token = "0x401E2A9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SelectAssistSkill;

		// Token: 0x0401E2AA RID: 123562
		[Token(Token = "0x401E2AA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SelectAssistEquip;

		// Token: 0x0401E2AB RID: 123563
		[Token(Token = "0x401E2AB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CloseAssistDetail;

		// Token: 0x0401E2AC RID: 123564
		[Token(Token = "0x401E2AC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ConfirmAssistChar;

		// Token: 0x0401E2AD RID: 123565
		[Token(Token = "0x401E2AD")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SendFriendRequest;

		// Token: 0x0401E2AE RID: 123566
		[Token(Token = "0x401E2AE")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnSendFriendReqSuc;

		// Token: 0x0401E2AF RID: 123567
		[Token(Token = "0x401E2AF")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OpenCharShowPage;

		// Token: 0x0401E2B0 RID: 123568
		[Token(Token = "0x401E2B0")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnStarFriendTabClick;

		// Token: 0x0401E2B1 RID: 123569
		[Token(Token = "0x401E2B1")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003DC9 RID: 15817
		[Token(Token = "0x2003DC9")]
		public interface IPlugin
		{
			// Token: 0x060189BE RID: 100798
			[Token(Token = "0x60189BE")]
			void OnInit(SquadFriendAssistStateBean stateBean, object context);

			// Token: 0x060189BF RID: 100799
			[Token(Token = "0x60189BF")]
			object GetContext();

			// Token: 0x060189C0 RID: 100800
			[Token(Token = "0x60189C0")]
			bool CheckIfCharValid(CharQuery charQuery, ref SquadFriendListItem.LockedStyle lockStyleConfig);

			// Token: 0x060189C1 RID: 100801
			[Token(Token = "0x60189C1")]
			SpriteRenderData LoadCrisisV2SeasonIcon(string seasonId);
		}

		// Token: 0x02003DCA RID: 15818
		[Token(Token = "0x2003DCA")]
		public abstract class Plugin<Context> : SquadFriendAssistState.IPlugin
		{
			// Token: 0x060189C2 RID: 100802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60189C2")]
			public virtual void OnInit(SquadFriendAssistStateBean stateBean, object context)
			{
			}

			// Token: 0x060189C3 RID: 100803
			[Token(Token = "0x60189C3")]
			public abstract bool CheckIfCharValid(CharQuery charQuery, ref SquadFriendListItem.LockedStyle lockStyleConfig);

			// Token: 0x17003AAB RID: 15019
			// (get) Token: 0x060189C4 RID: 100804 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003AAB")]
			protected Context context
			{
				[Token(Token = "0x60189C4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060189C5 RID: 100805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60189C5")]
			public object GetContext()
			{
				return null;
			}

			// Token: 0x060189C6 RID: 100806 RVA: 0x0009AEA8 File Offset: 0x000990A8
			[Token(Token = "0x60189C6")]
			public virtual SpriteRenderData LoadCrisisV2SeasonIcon(string seasonId)
			{
				return default(SpriteRenderData);
			}

			// Token: 0x060189C7 RID: 100807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60189C7")]
			protected Plugin()
			{
			}

			// Token: 0x0401E2B2 RID: 123570
			[Token(Token = "0x401E2B2")]
			[FieldOffset(Offset = "0x0")]
			private Context m_context;

			// Token: 0x0401E2B3 RID: 123571
			[Token(Token = "0x401E2B3")]
			[FieldOffset(Offset = "0x0")]
			public SquadFriendAssistStateBean squadAssistBean;
		}
	}
}
