using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Network;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200331C RID: 13084
	[Token(Token = "0x200331C")]
	public class UIBattleFinishServiceState : UIStateNode, IFinishBattleServiceSender
	{
		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x06014CB9 RID: 85177 RVA: 0x000887E8 File Offset: 0x000869E8
		[Token(Token = "0x1700313E")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014CB9")]
			[Address(RVA = "0xD3A690", Offset = "0xD39290", VA = "0x180D3A690", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x06014CBA RID: 85178 RVA: 0x00088800 File Offset: 0x00086A00
		[Token(Token = "0x1700313F")]
		public override bool enablePause
		{
			[Token(Token = "0x6014CBA")]
			[Address(RVA = "0xD3A570", Offset = "0xD39170", VA = "0x180D3A570", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x06014CBB RID: 85179 RVA: 0x00088818 File Offset: 0x00086A18
		[Token(Token = "0x17003140")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6014CBB")]
			[Address(RVA = "0xD3A5D0", Offset = "0xD391D0", VA = "0x180D3A5D0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x06014CBC RID: 85180 RVA: 0x00088830 File Offset: 0x00086A30
		[Token(Token = "0x17003141")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6014CBC")]
			[Address(RVA = "0xD3A630", Offset = "0xD39230", VA = "0x180D3A630", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014CBD RID: 85181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CBD")]
		[Address(RVA = "0xD393D0", Offset = "0xD37FD0", VA = "0x180D393D0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014CBE RID: 85182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CBE")]
		[Address(RVA = "0xD395A0", Offset = "0xD381A0", VA = "0x180D395A0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06014CBF RID: 85183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CBF")]
		[Address(RVA = "0xD396E0", Offset = "0xD382E0", VA = "0x180D396E0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014CC0 RID: 85184 RVA: 0x00088848 File Offset: 0x00086A48
		[Token(Token = "0x6014CC0")]
		[Address(RVA = "0xD39360", Offset = "0xD37F60", VA = "0x180D39360", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06014CC1 RID: 85185 RVA: 0x00088860 File Offset: 0x00086A60
		[Token(Token = "0x6014CC1")]
		[Address(RVA = "0xD39E70", Offset = "0xD38A70", VA = "0x180D39E70")]
		private bool _OnFinishBattleServiceFailed(ResponseError respError)
		{
			return default(bool);
		}

		// Token: 0x06014CC2 RID: 85186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CC2")]
		private void _OnFinishBattleServiceSuc<T>(T response) where T : CommonFinishBattleResponse
		{
		}

		// Token: 0x06014CC3 RID: 85187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CC3")]
		private void _OnContinueBattleServiceSuc<T>(T response) where T : CommonFinishBattleResponse
		{
		}

		// Token: 0x06014CC4 RID: 85188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CC4")]
		[Address(RVA = "0xD39BE0", Offset = "0xD387E0", VA = "0x180D39BE0")]
		private static void _LogBattleInfoToGameAnalytics(BattleInOut battleInOut)
		{
		}

		// Token: 0x06014CC5 RID: 85189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014CC5")]
		[Address(RVA = "0xD3A140", Offset = "0xD38D40", VA = "0x180D3A140")]
		private IEnumerator _SendBattleService(bool isRetry)
		{
			return null;
		}

		// Token: 0x06014CC6 RID: 85190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CC6")]
		public void SendFinishBattleService<TRequest, TResponse>(string serviceCode, TRequest request, bool isRetry) where TRequest : CommonFinishBattleRequest, new() where TResponse : CommonFinishBattleResponse
		{
		}

		// Token: 0x06014CC7 RID: 85191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014CC7")]
		public TRequest ParseCommonFinishBattleRequest<TRequest>() where TRequest : CommonFinishBattleRequest, new()
		{
			return null;
		}

		// Token: 0x06014CC8 RID: 85192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CC8")]
		private void _DoSendFinishBattleService<TRequest, TResponse>(string serviceCode, TRequest request, bool isRetry) where TRequest : CommonFinishBattleRequest where TResponse : CommonFinishBattleResponse
		{
		}

		// Token: 0x06014CC9 RID: 85193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CC9")]
		private void _DoSendBattleServiceImpl<TRequest, TResponse>(string serviceCode, TRequest request, bool isRetry, Action<TResponse> callback) where TRequest : CommonFinishBattleRequest where TResponse : CommonFinishBattleResponse
		{
		}

		// Token: 0x06014CCA RID: 85194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CCA")]
		[Address(RVA = "0xD3A200", Offset = "0xD38E00", VA = "0x180D3A200")]
		private void _ShowRetryDialog(ResponseError errorInfo)
		{
		}

		// Token: 0x06014CCB RID: 85195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CCB")]
		[Address(RVA = "0xD399D0", Offset = "0xD385D0", VA = "0x180D399D0")]
		private void _ConfirmServiceFail()
		{
		}

		// Token: 0x06014CCC RID: 85196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014CCC")]
		private T _ParseCommonFinishBattleRequest<T>() where T : CommonFinishBattleRequest, new()
		{
			return null;
		}

		// Token: 0x06014CCD RID: 85197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014CCD")]
		[Address(RVA = "0xD3A0D0", Offset = "0xD38CD0", VA = "0x180D3A0D0")]
		private DefaultFinishBattleRequest _ParseDefaultFinishBattleRequest()
		{
			return null;
		}

		// Token: 0x06014CCE RID: 85198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014CCE")]
		[Address(RVA = "0xD3A060", Offset = "0xD38C60", VA = "0x180D3A060")]
		private CampaignFinishBattleRequest _ParseCampaignFinishBattleRequest()
		{
			return null;
		}

		// Token: 0x06014CCF RID: 85199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014CCF")]
		[Address(RVA = "0xD397B0", Offset = "0xD383B0", VA = "0x180D397B0")]
		private string _AchieveBattleLog()
		{
			return null;
		}

		// Token: 0x06014CD0 RID: 85200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CD0")]
		[Address(RVA = "0xD3A500", Offset = "0xD39100", VA = "0x180D3A500")]
		public UIBattleFinishServiceState()
		{
		}

		// Token: 0x06014CD2 RID: 85202 RVA: 0x00088878 File Offset: 0x00086A78
		[Token(Token = "0x6014CD2")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06014CD3 RID: 85203 RVA: 0x00088890 File Offset: 0x00086A90
		[Token(Token = "0x6014CD3")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06014CD4 RID: 85204 RVA: 0x000888A8 File Offset: 0x00086AA8
		[Token(Token = "0x6014CD4")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014CD5 RID: 85205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CD5")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014CD6 RID: 85206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CD6")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x06014CD7 RID: 85207 RVA: 0x000888C0 File Offset: 0x00086AC0
		[Token(Token = "0x6014CD7")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x04018BCA RID: 101322
		[Token(Token = "0x4018BCA")]
		private const int MAX_RETRY_COUNT = 3;

		// Token: 0x04018BCB RID: 101323
		[Token(Token = "0x4018BCB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _raycastBlocker;

		// Token: 0x04018BCC RID: 101324
		[Token(Token = "0x4018BCC")]
		[FieldOffset(Offset = "0x28")]
		private BattleFinishServiceStateParam m_stateParam;

		// Token: 0x04018BCD RID: 101325
		[Token(Token = "0x4018BCD")]
		[FieldOffset(Offset = "0x2C")]
		private int m_retryCount;

		// Token: 0x04018BCE RID: 101326
		[Token(Token = "0x4018BCE")]
		[FieldOffset(Offset = "0x30")]
		private int m_maxRetryCount;

		// Token: 0x04018BCF RID: 101327
		[Token(Token = "0x4018BCF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018BD0 RID: 101328
		[Token(Token = "0x4018BD0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04018BD1 RID: 101329
		[Token(Token = "0x4018BD1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04018BD2 RID: 101330
		[Token(Token = "0x4018BD2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018BD3 RID: 101331
		[Token(Token = "0x4018BD3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018BD4 RID: 101332
		[Token(Token = "0x4018BD4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04018BD5 RID: 101333
		[Token(Token = "0x4018BD5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018BD6 RID: 101334
		[Token(Token = "0x4018BD6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x04018BD7 RID: 101335
		[Token(Token = "0x4018BD7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnFinishBattleServiceFailed;

		// Token: 0x04018BD8 RID: 101336
		[Token(Token = "0x4018BD8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnFinishBattleServiceSuc;

		// Token: 0x04018BD9 RID: 101337
		[Token(Token = "0x4018BD9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnContinueBattleServiceSuc;

		// Token: 0x04018BDA RID: 101338
		[Token(Token = "0x4018BDA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LogBattleInfoToGameAnalytics;

		// Token: 0x04018BDB RID: 101339
		[Token(Token = "0x4018BDB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SendBattleService;

		// Token: 0x04018BDC RID: 101340
		[Token(Token = "0x4018BDC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SendFinishBattleService;

		// Token: 0x04018BDD RID: 101341
		[Token(Token = "0x4018BDD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ParseCommonFinishBattleRequest;

		// Token: 0x04018BDE RID: 101342
		[Token(Token = "0x4018BDE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__DoSendFinishBattleService;

		// Token: 0x04018BDF RID: 101343
		[Token(Token = "0x4018BDF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DoSendBattleServiceImpl;

		// Token: 0x04018BE0 RID: 101344
		[Token(Token = "0x4018BE0")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ShowRetryDialog;

		// Token: 0x04018BE1 RID: 101345
		[Token(Token = "0x4018BE1")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ConfirmServiceFail;

		// Token: 0x04018BE2 RID: 101346
		[Token(Token = "0x4018BE2")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ParseCommonFinishBattleRequest;

		// Token: 0x04018BE3 RID: 101347
		[Token(Token = "0x4018BE3")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ParseDefaultFinishBattleRequest;

		// Token: 0x04018BE4 RID: 101348
		[Token(Token = "0x4018BE4")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ParseCampaignFinishBattleRequest;

		// Token: 0x04018BE5 RID: 101349
		[Token(Token = "0x4018BE5")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__AchieveBattleLog;

		// Token: 0x04018BE6 RID: 101350
		[Token(Token = "0x4018BE6")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
