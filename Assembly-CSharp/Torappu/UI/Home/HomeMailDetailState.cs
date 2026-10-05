using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B1B RID: 19227
	[Token(Token = "0x2004B1B")]
	public class HomeMailDetailState : PopupFloatState
	{
		// Token: 0x0601CEA0 RID: 118432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEA0")]
		[Address(RVA = "0x1659E20", Offset = "0x1658A20", VA = "0x181659E20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CEA1 RID: 118433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEA1")]
		[Address(RVA = "0x16597E0", Offset = "0x16583E0", VA = "0x1816597E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CEA2 RID: 118434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CEA2")]
		[Address(RVA = "0x1659A00", Offset = "0x1658600", VA = "0x181659A00", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CEA3 RID: 118435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEA3")]
		[Address(RVA = "0x16594F0", Offset = "0x16580F0", VA = "0x1816594F0")]
		public void EventOnMailClick()
		{
		}

		// Token: 0x0601CEA4 RID: 118436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEA4")]
		[Address(RVA = "0x1659F40", Offset = "0x1658B40", VA = "0x181659F40")]
		private void _OnEnsureSurveyState()
		{
		}

		// Token: 0x0601CEA5 RID: 118437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEA5")]
		[Address(RVA = "0x16595C0", Offset = "0x16581C0", VA = "0x1816595C0")]
		public void EventOnSurveyClick()
		{
		}

		// Token: 0x0601CEA6 RID: 118438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEA6")]
		[Address(RVA = "0x165A680", Offset = "0x1659280", VA = "0x18165A680")]
		private void _SendReceiveMailService(MailItemViewModel targetMail)
		{
		}

		// Token: 0x0601CEA7 RID: 118439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEA7")]
		[Address(RVA = "0x165A870", Offset = "0x1659470", VA = "0x18165A870")]
		private void _SendReceiveSurveyService(MailItemViewModel targetMail)
		{
		}

		// Token: 0x0601CEA8 RID: 118440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEA8")]
		[Address(RVA = "0x165A4D0", Offset = "0x16590D0", VA = "0x18165A4D0")]
		private void _OnReceiveSurveyUrlSucceed(StartSurveyResponse response)
		{
		}

		// Token: 0x0601CEA9 RID: 118441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEA9")]
		[Address(RVA = "0x165AAC0", Offset = "0x16596C0", VA = "0x18165AAC0")]
		private void _SurveyWebCallback(UIWebWindow.MiniWebRet ret, int i)
		{
		}

		// Token: 0x0601CEAA RID: 118442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEAA")]
		[Address(RVA = "0x165A620", Offset = "0x1659220", VA = "0x18165A620")]
		private void _ReturnAndRefresh()
		{
		}

		// Token: 0x0601CEAB RID: 118443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEAB")]
		[Address(RVA = "0x16596C0", Offset = "0x16582C0", VA = "0x1816596C0")]
		public void JumpToMonthlySub()
		{
		}

		// Token: 0x0601CEAC RID: 118444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEAC")]
		[Address(RVA = "0x165A290", Offset = "0x1658E90", VA = "0x18165A290")]
		private void _OnReceiveItemSucceed(ReceiveMailResponse response)
		{
		}

		// Token: 0x0601CEAD RID: 118445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CEAD")]
		[Address(RVA = "0x1659660", Offset = "0x1658260", VA = "0x181659660", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CEAE RID: 118446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEAE")]
		[Address(RVA = "0x1659280", Offset = "0x1657E80", VA = "0x181659280")]
		public void DismissSelfWithRefreshMetaInfo()
		{
		}

		// Token: 0x0601CEAF RID: 118447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEAF")]
		[Address(RVA = "0x165ABA0", Offset = "0x16597A0", VA = "0x18165ABA0")]
		public HomeMailDetailState()
		{
		}

		// Token: 0x0601CEB3 RID: 118451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEB3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CEB4 RID: 118452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CEB4")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04025F02 RID: 155394
		[Token(Token = "0x4025F02")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HomeMailDetailView _view;

		// Token: 0x04025F03 RID: 155395
		[Token(Token = "0x4025F03")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HomeMailDetailStateBean _stateBean;

		// Token: 0x04025F04 RID: 155396
		[Token(Token = "0x4025F04")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public bool hasSendSurvey;

		// Token: 0x04025F05 RID: 155397
		[Token(Token = "0x4025F05")]
		[FieldOffset(Offset = "0x81")]
		private bool m_isInited;

		// Token: 0x04025F06 RID: 155398
		[Token(Token = "0x4025F06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025F07 RID: 155399
		[Token(Token = "0x4025F07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025F08 RID: 155400
		[Token(Token = "0x4025F08")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04025F09 RID: 155401
		[Token(Token = "0x4025F09")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnMailClick;

		// Token: 0x04025F0A RID: 155402
		[Token(Token = "0x4025F0A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnEnsureSurveyState;

		// Token: 0x04025F0B RID: 155403
		[Token(Token = "0x4025F0B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnSurveyClick;

		// Token: 0x04025F0C RID: 155404
		[Token(Token = "0x4025F0C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SendReceiveMailService;

		// Token: 0x04025F0D RID: 155405
		[Token(Token = "0x4025F0D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SendReceiveSurveyService;

		// Token: 0x04025F0E RID: 155406
		[Token(Token = "0x4025F0E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnReceiveSurveyUrlSucceed;

		// Token: 0x04025F0F RID: 155407
		[Token(Token = "0x4025F0F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SurveyWebCallback;

		// Token: 0x04025F10 RID: 155408
		[Token(Token = "0x4025F10")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ReturnAndRefresh;

		// Token: 0x04025F11 RID: 155409
		[Token(Token = "0x4025F11")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_JumpToMonthlySub;

		// Token: 0x04025F12 RID: 155410
		[Token(Token = "0x4025F12")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnReceiveItemSucceed;

		// Token: 0x04025F13 RID: 155411
		[Token(Token = "0x4025F13")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025F14 RID: 155412
		[Token(Token = "0x4025F14")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DismissSelfWithRefreshMetaInfo;

		// Token: 0x04025F15 RID: 155413
		[Token(Token = "0x4025F15")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
