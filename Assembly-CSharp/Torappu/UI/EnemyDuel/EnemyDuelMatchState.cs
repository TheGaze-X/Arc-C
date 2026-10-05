using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Network;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005032 RID: 20530
	[Token(Token = "0x2005032")]
	public class EnemyDuelMatchState : UIPopupState, IPopupCustomActive
	{
		// Token: 0x0601E727 RID: 124711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E727")]
		[Address(RVA = "0x1823C10", Offset = "0x1822810", VA = "0x181823C10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E728 RID: 124712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E728")]
		[Address(RVA = "0x1822AD0", Offset = "0x18216D0", VA = "0x181822AD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E729 RID: 124713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E729")]
		[Address(RVA = "0x1822D60", Offset = "0x1821960", VA = "0x181822D60", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E72A RID: 124714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E72A")]
		[Address(RVA = "0x1822B30", Offset = "0x1821730", VA = "0x181822B30", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601E72B RID: 124715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E72B")]
		[Address(RVA = "0x1822C70", Offset = "0x1821870", VA = "0x181822C70", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601E72C RID: 124716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E72C")]
		[Address(RVA = "0x18233F0", Offset = "0x1821FF0", VA = "0x1818233F0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601E72D RID: 124717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E72D")]
		[Address(RVA = "0x1823530", Offset = "0x1822130", VA = "0x181823530", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601E72E RID: 124718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E72E")]
		[Address(RVA = "0x1823290", Offset = "0x1821E90", VA = "0x181823290", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601E72F RID: 124719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E72F")]
		[Address(RVA = "0x1824350", Offset = "0x1822F50", VA = "0x181824350")]
		private void _PassDataToWaitConnectState(IStateBean stateBean)
		{
		}

		// Token: 0x0601E730 RID: 124720 RVA: 0x000AE750 File Offset: 0x000AC950
		[Token(Token = "0x601E730")]
		[Address(RVA = "0x1822910", Offset = "0x1821510", VA = "0x181822910", Slot = "29")]
		public bool CustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x0601E731 RID: 124721 RVA: 0x000AE768 File Offset: 0x000AC968
		[Token(Token = "0x601E731")]
		[Address(RVA = "0x18236B0", Offset = "0x18222B0", VA = "0x1818236B0")]
		private bool _CreateInitRequest(out Request request, out UISenderRequestParam requestParam)
		{
			return default(bool);
		}

		// Token: 0x0601E732 RID: 124722 RVA: 0x000AE780 File Offset: 0x000AC980
		[Token(Token = "0x601E732")]
		[Address(RVA = "0x1823DF0", Offset = "0x18229F0", VA = "0x181823DF0")]
		private bool _OnInitMatchResponse(EnemyDuelStartMatchResponse response)
		{
			return default(bool);
		}

		// Token: 0x0601E733 RID: 124723 RVA: 0x000AE798 File Offset: 0x000AC998
		[Token(Token = "0x601E733")]
		[Address(RVA = "0x1823920", Offset = "0x1822520", VA = "0x181823920")]
		private bool _CreateMatchQueryRequest(bool isCancel, out Request request, out UISenderRequestParam requestParam)
		{
			return default(bool);
		}

		// Token: 0x0601E734 RID: 124724 RVA: 0x000AE7B0 File Offset: 0x000AC9B0
		[Token(Token = "0x601E734")]
		[Address(RVA = "0x1823620", Offset = "0x1822220", VA = "0x181823620")]
		private bool _CreateCancelRequest(out Request request, out UISenderRequestParam requestParam)
		{
			return default(bool);
		}

		// Token: 0x0601E735 RID: 124725 RVA: 0x000AE7C8 File Offset: 0x000AC9C8
		[Token(Token = "0x601E735")]
		[Address(RVA = "0x1823B80", Offset = "0x1822780", VA = "0x181823B80")]
		private bool _CreateQueryRequest(out Request request, out UISenderRequestParam requestParam)
		{
			return default(bool);
		}

		// Token: 0x0601E736 RID: 124726 RVA: 0x000AE7E0 File Offset: 0x000AC9E0
		[Token(Token = "0x601E736")]
		[Address(RVA = "0x18240A0", Offset = "0x1822CA0", VA = "0x1818240A0")]
		private bool _OnQueryMatchResponse(EnemyDuelQueryMatchResponse response)
		{
			return default(bool);
		}

		// Token: 0x0601E737 RID: 124727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E737")]
		[Address(RVA = "0x1823F70", Offset = "0x1822B70", VA = "0x181823F70")]
		private void _OnLoopSenderTick(float waitSec)
		{
		}

		// Token: 0x0601E738 RID: 124728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E738")]
		[Address(RVA = "0x1822980", Offset = "0x1821580", VA = "0x181822980")]
		public void EventOnCancelMatchClick()
		{
		}

		// Token: 0x0601E739 RID: 124729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E739")]
		[Address(RVA = "0x1824490", Offset = "0x1823090", VA = "0x181824490")]
		public EnemyDuelMatchState()
		{
		}

		// Token: 0x0601E73A RID: 124730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E73A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601E73B RID: 124731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E73B")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04028BFD RID: 166909
		[Token(Token = "0x4028BFD")]
		private const int QUERY_REQUEST_INTERVAL = 5;

		// Token: 0x04028BFE RID: 166910
		[Token(Token = "0x4028BFE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private EnemyDuelMatchView _view;

		// Token: 0x04028BFF RID: 166911
		[Token(Token = "0x4028BFF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _backBtnRect;

		// Token: 0x04028C00 RID: 166912
		[Token(Token = "0x4028C00")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04028C01 RID: 166913
		[Token(Token = "0x4028C01")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _loopAnim;

		// Token: 0x04028C02 RID: 166914
		[Token(Token = "0x4028C02")]
		[FieldOffset(Offset = "0x90")]
		private AnimationSwitchTween m_enterAnimSwitchTween;

		// Token: 0x04028C03 RID: 166915
		[Token(Token = "0x4028C03")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x04028C04 RID: 166916
		[Token(Token = "0x4028C04")]
		[FieldOffset(Offset = "0xA0")]
		private EnemyDuelMatchStateBean m_stateBean;

		// Token: 0x04028C05 RID: 166917
		[Token(Token = "0x4028C05")]
		[FieldOffset(Offset = "0xA8")]
		private LoopRequestSender m_loopSender;

		// Token: 0x04028C06 RID: 166918
		[Token(Token = "0x4028C06")]
		[FieldOffset(Offset = "0xB0")]
		private EnemyDuelTeamInfo m_cacheTeamInst;

		// Token: 0x04028C07 RID: 166919
		[Token(Token = "0x4028C07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028C08 RID: 166920
		[Token(Token = "0x4028C08")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04028C09 RID: 166921
		[Token(Token = "0x4028C09")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04028C0A RID: 166922
		[Token(Token = "0x4028C0A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04028C0B RID: 166923
		[Token(Token = "0x4028C0B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04028C0C RID: 166924
		[Token(Token = "0x4028C0C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04028C0D RID: 166925
		[Token(Token = "0x4028C0D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04028C0E RID: 166926
		[Token(Token = "0x4028C0E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04028C0F RID: 166927
		[Token(Token = "0x4028C0F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PassDataToWaitConnectState;

		// Token: 0x04028C10 RID: 166928
		[Token(Token = "0x4028C10")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CustomSetActive;

		// Token: 0x04028C11 RID: 166929
		[Token(Token = "0x4028C11")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CreateInitRequest;

		// Token: 0x04028C12 RID: 166930
		[Token(Token = "0x4028C12")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnInitMatchResponse;

		// Token: 0x04028C13 RID: 166931
		[Token(Token = "0x4028C13")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CreateMatchQueryRequest;

		// Token: 0x04028C14 RID: 166932
		[Token(Token = "0x4028C14")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CreateCancelRequest;

		// Token: 0x04028C15 RID: 166933
		[Token(Token = "0x4028C15")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CreateQueryRequest;

		// Token: 0x04028C16 RID: 166934
		[Token(Token = "0x4028C16")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnQueryMatchResponse;

		// Token: 0x04028C17 RID: 166935
		[Token(Token = "0x4028C17")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnLoopSenderTick;

		// Token: 0x04028C18 RID: 166936
		[Token(Token = "0x4028C18")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnCancelMatchClick;

		// Token: 0x04028C19 RID: 166937
		[Token(Token = "0x4028C19")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
