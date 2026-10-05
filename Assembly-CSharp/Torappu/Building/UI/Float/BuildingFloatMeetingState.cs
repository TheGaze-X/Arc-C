using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.UI.Meeting;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DD4 RID: 7636
	[Token(Token = "0x2001DD4")]
	public class BuildingFloatMeetingState : BuildingFloatVaultInfoState
	{
		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x0600BC54 RID: 48212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016C7")]
		private IMeetingSession meetingSession
		{
			[Token(Token = "0x600BC54")]
			[Address(RVA = "0x338A680", Offset = "0x3389280", VA = "0x18338A680")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x0600BC55 RID: 48213 RVA: 0x00046218 File Offset: 0x00044418
		[Token(Token = "0x170016C8")]
		protected override FloatState state
		{
			[Token(Token = "0x600BC55")]
			[Address(RVA = "0x338A6F0", Offset = "0x33892F0", VA = "0x18338A6F0", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BC56 RID: 48214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC56")]
		[Address(RVA = "0x338A420", Offset = "0x3389020", VA = "0x18338A420")]
		private void _UpdateTransferringPanel()
		{
		}

		// Token: 0x0600BC57 RID: 48215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC57")]
		[Address(RVA = "0x3389E30", Offset = "0x3388A30", VA = "0x183389E30")]
		private void _RewardsHandler(List<ItemBundle> rewards)
		{
		}

		// Token: 0x0600BC58 RID: 48216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC58")]
		[Address(RVA = "0x33898A0", Offset = "0x33884A0", VA = "0x1833898A0", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600BC59 RID: 48217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC59")]
		[Address(RVA = "0x3389740", Offset = "0x3388340", VA = "0x183389740", Slot = "6")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600BC5A RID: 48218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC5A")]
		[Address(RVA = "0x3389C70", Offset = "0x3388870", VA = "0x183389C70", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BC5B RID: 48219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC5B")]
		[Address(RVA = "0x3389B40", Offset = "0x3388740", VA = "0x183389B40", Slot = "15")]
		protected override void OnPlayerDataChanged(object args)
		{
		}

		// Token: 0x0600BC5C RID: 48220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC5C")]
		[Address(RVA = "0x3389060", Offset = "0x3387C60", VA = "0x183389060")]
		public void EventOnDIYClick()
		{
		}

		// Token: 0x0600BC5D RID: 48221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC5D")]
		[Address(RVA = "0x3388FC0", Offset = "0x3387BC0", VA = "0x183388FC0")]
		public void EventOnBtnFriendClicked()
		{
		}

		// Token: 0x0600BC5E RID: 48222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC5E")]
		[Address(RVA = "0x3389100", Offset = "0x3387D00", VA = "0x183389100")]
		public void EventOnSettleCreditClicked()
		{
		}

		// Token: 0x0600BC5F RID: 48223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC5F")]
		[Address(RVA = "0x338A0F0", Offset = "0x3388CF0", VA = "0x18338A0F0")]
		private void _SendUpdateTransferServiceIfNeeded()
		{
		}

		// Token: 0x0600BC60 RID: 48224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC60")]
		[Address(RVA = "0x3389D70", Offset = "0x3388970", VA = "0x183389D70")]
		private void _RefreshState()
		{
		}

		// Token: 0x0600BC61 RID: 48225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC61")]
		[Address(RVA = "0x338A1D0", Offset = "0x3388DD0", VA = "0x18338A1D0")]
		private void _TryShowTransferResult()
		{
		}

		// Token: 0x0600BC62 RID: 48226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC62")]
		[Address(RVA = "0x338A5B0", Offset = "0x33891B0", VA = "0x18338A5B0")]
		public BuildingFloatMeetingState()
		{
		}

		// Token: 0x0600BC64 RID: 48228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC64")]
		[Address(RVA = "0x3389D30", Offset = "0x3388930", VA = "0x183389D30")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600BC65 RID: 48229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC65")]
		[Address(RVA = "0x3389D20", Offset = "0x3388920", VA = "0x183389D20")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600BC66 RID: 48230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC66")]
		[Address(RVA = "0x3387830", Offset = "0x3386430", VA = "0x183387830")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0600BC67 RID: 48231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC67")]
		[Address(RVA = "0x3387820", Offset = "0x3386420", VA = "0x183387820")]
		private void <>xLuaBaseProxy_OnPlayerDataChanged(object P0)
		{
		}

		// Token: 0x0400BC5B RID: 48219
		[Token(Token = "0x400BC5B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _settleAnchor;

		// Token: 0x0400BC5C RID: 48220
		[Token(Token = "0x400BC5C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private MeetingTransferStateView _transferStateView;

		// Token: 0x0400BC5D RID: 48221
		[Token(Token = "0x400BC5D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private MeetingFloatStateCornerView _cornerView;

		// Token: 0x0400BC5E RID: 48222
		[Token(Token = "0x400BC5E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform _trackPointContainer;

		// Token: 0x0400BC5F RID: 48223
		[Token(Token = "0x400BC5F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _trackPointPrefab;

		// Token: 0x0400BC60 RID: 48224
		[Token(Token = "0x400BC60")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private BuildingTwoContentNotify _socialNotify;

		// Token: 0x0400BC61 RID: 48225
		[Token(Token = "0x400BC61")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private BuildingTwoContentNotify _cashNotify;

		// Token: 0x0400BC62 RID: 48226
		[Token(Token = "0x400BC62")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_transferVisitNumServiceSent;

		// Token: 0x0400BC63 RID: 48227
		[Token(Token = "0x400BC63")]
		[FieldOffset(Offset = "0xE0")]
		private MeetingViewModel m_viewModel;

		// Token: 0x0400BC64 RID: 48228
		[Token(Token = "0x400BC64")]
		[FieldOffset(Offset = "0xE8")]
		private BuildingMeetingSession m_meetingSession;

		// Token: 0x0400BC65 RID: 48229
		[Token(Token = "0x400BC65")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_visitNumberAvailable;

		// Token: 0x0400BC66 RID: 48230
		[Token(Token = "0x400BC66")]
		[FieldOffset(Offset = "0x0")]
		public static IMeetingSession s_meetingSession;

		// Token: 0x0400BC67 RID: 48231
		[Token(Token = "0x400BC67")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_meetingSession;

		// Token: 0x0400BC68 RID: 48232
		[Token(Token = "0x400BC68")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BC69 RID: 48233
		[Token(Token = "0x400BC69")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateTransferringPanel;

		// Token: 0x0400BC6A RID: 48234
		[Token(Token = "0x400BC6A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RewardsHandler;

		// Token: 0x0400BC6B RID: 48235
		[Token(Token = "0x400BC6B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400BC6C RID: 48236
		[Token(Token = "0x400BC6C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400BC6D RID: 48237
		[Token(Token = "0x400BC6D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BC6E RID: 48238
		[Token(Token = "0x400BC6E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400BC6F RID: 48239
		[Token(Token = "0x400BC6F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnDIYClick;

		// Token: 0x0400BC70 RID: 48240
		[Token(Token = "0x400BC70")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnBtnFriendClicked;

		// Token: 0x0400BC71 RID: 48241
		[Token(Token = "0x400BC71")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnSettleCreditClicked;

		// Token: 0x0400BC72 RID: 48242
		[Token(Token = "0x400BC72")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SendUpdateTransferServiceIfNeeded;

		// Token: 0x0400BC73 RID: 48243
		[Token(Token = "0x400BC73")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RefreshState;

		// Token: 0x0400BC74 RID: 48244
		[Token(Token = "0x400BC74")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryShowTransferResult;

		// Token: 0x0400BC75 RID: 48245
		[Token(Token = "0x400BC75")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
