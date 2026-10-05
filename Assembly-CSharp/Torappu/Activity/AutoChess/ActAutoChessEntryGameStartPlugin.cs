using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070EA RID: 28906
	[Token(Token = "0x20070EA")]
	public class ActAutoChessEntryGameStartPlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x06029171 RID: 168305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029171")]
		[Address(RVA = "0x247ED70", Offset = "0x247D970", VA = "0x18247ED70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06029172 RID: 168306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029172")]
		[Address(RVA = "0x247EE10", Offset = "0x247DA10", VA = "0x18247EE10", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06029173 RID: 168307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029173")]
		[Address(RVA = "0x247F5F0", Offset = "0x247E1F0", VA = "0x18247F5F0")]
		private ActAutoChessEntryViewModel _GetActViewModel()
		{
			return null;
		}

		// Token: 0x06029174 RID: 168308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029174")]
		[Address(RVA = "0x247F860", Offset = "0x247E460", VA = "0x18247F860")]
		private void _RefreshButtonStatus(ActAutoChessEntryViewModel model)
		{
		}

		// Token: 0x06029175 RID: 168309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029175")]
		[Address(RVA = "0x247F7F0", Offset = "0x247E3F0", VA = "0x18247F7F0")]
		private void _OnTimerTick()
		{
		}

		// Token: 0x06029176 RID: 168310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029176")]
		[Address(RVA = "0x247FFE0", Offset = "0x247EBE0", VA = "0x18247FFE0")]
		private static void _UpdateBannedStatus(bool isUnlock, long remainTs, GameObject panelBanned, Text textRemain)
		{
		}

		// Token: 0x06029177 RID: 168311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029177")]
		[Address(RVA = "0x2480180", Offset = "0x247ED80", VA = "0x182480180")]
		private static void _UpdateSingleSettleStatus(bool isUnlock, long remainTs, Text textRemain)
		{
		}

		// Token: 0x06029178 RID: 168312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029178")]
		[Address(RVA = "0x247F710", Offset = "0x247E310", VA = "0x18247F710")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029179 RID: 168313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029179")]
		[Address(RVA = "0x247FE80", Offset = "0x247EA80", VA = "0x18247FE80")]
		private void _RenderInvitePanel(ActAutoChessEntryViewModel model)
		{
		}

		// Token: 0x0602917A RID: 168314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602917A")]
		[Address(RVA = "0x247EB60", Offset = "0x247D760", VA = "0x18247EB60")]
		public void EventOnSingleClicked()
		{
		}

		// Token: 0x0602917B RID: 168315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602917B")]
		[Address(RVA = "0x247E2D0", Offset = "0x247CED0", VA = "0x18247E2D0")]
		public void EventOnMultiMatchClicked()
		{
		}

		// Token: 0x0602917C RID: 168316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602917C")]
		[Address(RVA = "0x247E490", Offset = "0x247D090", VA = "0x18247E490")]
		public void EventOnMultiTeamClicked()
		{
		}

		// Token: 0x0602917D RID: 168317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602917D")]
		[Address(RVA = "0x247E120", Offset = "0x247CD20", VA = "0x18247E120")]
		public void EventOnInviteClicked()
		{
		}

		// Token: 0x0602917E RID: 168318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602917E")]
		[Address(RVA = "0x247E6A0", Offset = "0x247D2A0", VA = "0x18247E6A0")]
		public void EventOnRetryClicked()
		{
		}

		// Token: 0x0602917F RID: 168319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602917F")]
		[Address(RVA = "0x247E8C0", Offset = "0x247D4C0", VA = "0x18247E8C0")]
		public void EventOnSingeModeGiveUpClicked()
		{
		}

		// Token: 0x06029180 RID: 168320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029180")]
		[Address(RVA = "0x247EA10", Offset = "0x247D610", VA = "0x18247EA10")]
		public void EventOnSingeModeSettleClicked()
		{
		}

		// Token: 0x06029181 RID: 168321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029181")]
		[Address(RVA = "0x24803A0", Offset = "0x247EFA0", VA = "0x1824803A0")]
		public ActAutoChessEntryGameStartPlugin()
		{
		}

		// Token: 0x0403AA42 RID: 240194
		[Token(Token = "0x403AA42")]
		private const string REMAIN_FORMAT = "{0:D2}:{1:D2}";

		// Token: 0x0403AA43 RID: 240195
		[Token(Token = "0x403AA43")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Retry")]
		private GameObject _panelNormal;

		// Token: 0x0403AA44 RID: 240196
		[Token(Token = "0x403AA44")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Retry")]
		private GameObject _panelRetry;

		// Token: 0x0403AA45 RID: 240197
		[Token(Token = "0x403AA45")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Retry")]
		private GameObject _panelRetryEnd;

		// Token: 0x0403AA46 RID: 240198
		[Token(Token = "0x403AA46")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("SingleMode")]
		private GameObject _panelSingleContinue;

		// Token: 0x0403AA47 RID: 240199
		[Token(Token = "0x403AA47")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("SingleMode")]
		private GameObject _panelSingleEnd;

		// Token: 0x0403AA48 RID: 240200
		[Token(Token = "0x403AA48")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("SingleMode")]
		private Text _textCurRound;

		// Token: 0x0403AA49 RID: 240201
		[Token(Token = "0x403AA49")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("SingleMode")]
		private Text _textSettleRemainTime;

		// Token: 0x0403AA4A RID: 240202
		[Token(Token = "0x403AA4A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Single Mode")]
		private GameObject _panelSingleLocked;

		// Token: 0x0403AA4B RID: 240203
		[Token(Token = "0x403AA4B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Single Mode")]
		private UIActTrackPoint _trackPointSingle;

		// Token: 0x0403AA4C RID: 240204
		[Token(Token = "0x403AA4C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Single Mode")]
		private GameObject _panelSingleBanned;

		// Token: 0x0403AA4D RID: 240205
		[Token(Token = "0x403AA4D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Single Mode")]
		private Text _textSingleCoolDown;

		// Token: 0x0403AA4E RID: 240206
		[Token(Token = "0x403AA4E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Multi Mode")]
		private GameObject _panelTeamLocked;

		// Token: 0x0403AA4F RID: 240207
		[Token(Token = "0x403AA4F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Multi Mode")]
		private UIActTrackPoint _trackPointMatch;

		// Token: 0x0403AA50 RID: 240208
		[Token(Token = "0x403AA50")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Multi Mode")]
		private GameObject _panelMultiBanned;

		// Token: 0x0403AA51 RID: 240209
		[Token(Token = "0x403AA51")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Multi Mode")]
		private Text _textMultiCoolDown;

		// Token: 0x0403AA52 RID: 240210
		[Token(Token = "0x403AA52")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _panelEnd;

		// Token: 0x0403AA53 RID: 240211
		[Token(Token = "0x403AA53")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Invite")]
		private GameObject _panelInviteNormal;

		// Token: 0x0403AA54 RID: 240212
		[Token(Token = "0x403AA54")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Invite")]
		private GameObject _panelInviteLocked;

		// Token: 0x0403AA55 RID: 240213
		[Token(Token = "0x403AA55")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Invite")]
		private GameObject _panelInviteBanned;

		// Token: 0x0403AA56 RID: 240214
		[Token(Token = "0x403AA56")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Invite")]
		private GameObject _panelInviteEnd;

		// Token: 0x0403AA57 RID: 240215
		[Token(Token = "0x403AA57")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Invite")]
		private GameObject _panelInviteLost;

		// Token: 0x0403AA58 RID: 240216
		[Token(Token = "0x403AA58")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Invite")]
		private UIActTrackPoint _trackPointInvited;

		// Token: 0x0403AA59 RID: 240217
		[Token(Token = "0x403AA59")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_hasInited;

		// Token: 0x0403AA5A RID: 240218
		[Token(Token = "0x403AA5A")]
		[FieldOffset(Offset = "0xE0")]
		private TrackPointViewProperty m_matchTrackPoint;

		// Token: 0x0403AA5B RID: 240219
		[Token(Token = "0x403AA5B")]
		[FieldOffset(Offset = "0xE8")]
		private TrackPointViewProperty m_singleTrackPoint;

		// Token: 0x0403AA5C RID: 240220
		[Token(Token = "0x403AA5C")]
		[FieldOffset(Offset = "0xF0")]
		private TrackPointViewProperty m_invitedTrackPoint;

		// Token: 0x0403AA5D RID: 240221
		[Token(Token = "0x403AA5D")]
		[FieldOffset(Offset = "0xF8")]
		private int m_timerId;

		// Token: 0x0403AA5E RID: 240222
		[Token(Token = "0x403AA5E")]
		[FieldOffset(Offset = "0x100")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403AA5F RID: 240223
		[Token(Token = "0x403AA5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403AA60 RID: 240224
		[Token(Token = "0x403AA60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403AA61 RID: 240225
		[Token(Token = "0x403AA61")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetActViewModel;

		// Token: 0x0403AA62 RID: 240226
		[Token(Token = "0x403AA62")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshButtonStatus;

		// Token: 0x0403AA63 RID: 240227
		[Token(Token = "0x403AA63")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnTimerTick;

		// Token: 0x0403AA64 RID: 240228
		[Token(Token = "0x403AA64")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateBannedStatus;

		// Token: 0x0403AA65 RID: 240229
		[Token(Token = "0x403AA65")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateSingleSettleStatus;

		// Token: 0x0403AA66 RID: 240230
		[Token(Token = "0x403AA66")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AA67 RID: 240231
		[Token(Token = "0x403AA67")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderInvitePanel;

		// Token: 0x0403AA68 RID: 240232
		[Token(Token = "0x403AA68")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnSingleClicked;

		// Token: 0x0403AA69 RID: 240233
		[Token(Token = "0x403AA69")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnMultiMatchClicked;

		// Token: 0x0403AA6A RID: 240234
		[Token(Token = "0x403AA6A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnMultiTeamClicked;

		// Token: 0x0403AA6B RID: 240235
		[Token(Token = "0x403AA6B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnInviteClicked;

		// Token: 0x0403AA6C RID: 240236
		[Token(Token = "0x403AA6C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnRetryClicked;

		// Token: 0x0403AA6D RID: 240237
		[Token(Token = "0x403AA6D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnSingeModeGiveUpClicked;

		// Token: 0x0403AA6E RID: 240238
		[Token(Token = "0x403AA6E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnSingeModeSettleClicked;

		// Token: 0x0403AA6F RID: 240239
		[Token(Token = "0x403AA6F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020070EB RID: 28907
		[Token(Token = "0x20070EB")]
		private class TrackPointInput
		{
			// Token: 0x06029182 RID: 168322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029182")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TrackPointInput()
			{
			}

			// Token: 0x0403AA70 RID: 240240
			[Token(Token = "0x403AA70")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403AA71 RID: 240241
			[Token(Token = "0x403AA71")]
			[FieldOffset(Offset = "0x18")]
			public bool isBanned;

			// Token: 0x0403AA72 RID: 240242
			[Token(Token = "0x403AA72")]
			[FieldOffset(Offset = "0x19")]
			public bool isEnd;
		}

		// Token: 0x020070EC RID: 28908
		[Token(Token = "0x20070EC")]
		private class SingleModeTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700615C RID: 24924
			// (get) Token: 0x06029183 RID: 168323 RVA: 0x000D4718 File Offset: 0x000D2918
			// (set) Token: 0x06029184 RID: 168324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700615C")]
			public bool isShow
			{
				[Token(Token = "0x6029183")]
				[Address(RVA = "0x2490F80", Offset = "0x248FB80", VA = "0x182490F80", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6029184")]
				[Address(RVA = "0x2490FE0", Offset = "0x248FBE0", VA = "0x182490FE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06029185 RID: 168325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029185")]
			[Address(RVA = "0x2490DD0", Offset = "0x248F9D0", VA = "0x182490DD0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x06029186 RID: 168326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029186")]
			[Address(RVA = "0x2490F20", Offset = "0x248FB20", VA = "0x182490F20")]
			public SingleModeTrackPointModel()
			{
			}

			// Token: 0x0403AA74 RID: 240244
			[Token(Token = "0x403AA74")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403AA75 RID: 240245
			[Token(Token = "0x403AA75")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x0403AA76 RID: 240246
			[Token(Token = "0x403AA76")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403AA77 RID: 240247
			[Token(Token = "0x403AA77")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020070ED RID: 28909
		[Token(Token = "0x20070ED")]
		private class MultiModeTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700615D RID: 24925
			// (get) Token: 0x06029187 RID: 168327 RVA: 0x000D4730 File Offset: 0x000D2930
			// (set) Token: 0x06029188 RID: 168328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700615D")]
			public bool isShow
			{
				[Token(Token = "0x6029187")]
				[Address(RVA = "0x2490A90", Offset = "0x248F690", VA = "0x182490A90", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6029188")]
				[Address(RVA = "0x2490AF0", Offset = "0x248F6F0", VA = "0x182490AF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06029189 RID: 168329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029189")]
			[Address(RVA = "0x24908E0", Offset = "0x248F4E0", VA = "0x1824908E0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602918A RID: 168330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602918A")]
			[Address(RVA = "0x2490A30", Offset = "0x248F630", VA = "0x182490A30")]
			public MultiModeTrackPointModel()
			{
			}

			// Token: 0x0403AA79 RID: 240249
			[Token(Token = "0x403AA79")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403AA7A RID: 240250
			[Token(Token = "0x403AA7A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x0403AA7B RID: 240251
			[Token(Token = "0x403AA7B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403AA7C RID: 240252
			[Token(Token = "0x403AA7C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020070EE RID: 28910
		[Token(Token = "0x20070EE")]
		private class InvitedTrackModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x0602918B RID: 168331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602918B")]
			[Address(RVA = "0x2490290", Offset = "0x248EE90", VA = "0x182490290", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x1700615E RID: 24926
			// (get) Token: 0x0602918C RID: 168332 RVA: 0x000D4748 File Offset: 0x000D2948
			// (set) Token: 0x0602918D RID: 168333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700615E")]
			public bool isShow
			{
				[Token(Token = "0x602918C")]
				[Address(RVA = "0x2490430", Offset = "0x248F030", VA = "0x182490430", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x602918D")]
				[Address(RVA = "0x2490490", Offset = "0x248F090", VA = "0x182490490")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0602918E RID: 168334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602918E")]
			[Address(RVA = "0x24903D0", Offset = "0x248EFD0", VA = "0x1824903D0")]
			public InvitedTrackModel()
			{
			}

			// Token: 0x0403AA7E RID: 240254
			[Token(Token = "0x403AA7E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403AA7F RID: 240255
			[Token(Token = "0x403AA7F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403AA80 RID: 240256
			[Token(Token = "0x403AA80")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x0403AA81 RID: 240257
			[Token(Token = "0x403AA81")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
