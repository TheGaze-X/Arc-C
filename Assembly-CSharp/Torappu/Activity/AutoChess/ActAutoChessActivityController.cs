using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.AutoChess;
using Torappu.UI.TemplateMission;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070DC RID: 28892
	[Token(Token = "0x20070DC")]
	public class ActAutoChessActivityController : TemplateActivityController, ICompDialogCallBack
	{
		// Token: 0x17006155 RID: 24917
		// (get) Token: 0x0602910F RID: 168207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006155")]
		public ActAutoChessInitMeta initMetaObj
		{
			[Token(Token = "0x602910F")]
			[Address(RVA = "0x246FFD0", Offset = "0x246EBD0", VA = "0x18246FFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029110 RID: 168208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029110")]
		[Address(RVA = "0x246C990", Offset = "0x246B590", VA = "0x18246C990", Slot = "10")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x06029111 RID: 168209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029111")]
		[Address(RVA = "0x246BD20", Offset = "0x246A920", VA = "0x18246BD20", Slot = "34")]
		protected override void AfterEntryAnimPlay()
		{
		}

		// Token: 0x06029112 RID: 168210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029112")]
		[Address(RVA = "0x246C3E0", Offset = "0x246AFE0", VA = "0x18246C3E0", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x06029113 RID: 168211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029113")]
		[Address(RVA = "0x246CEA0", Offset = "0x246BAA0", VA = "0x18246CEA0", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x06029114 RID: 168212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029114")]
		[Address(RVA = "0x246CD70", Offset = "0x246B970", VA = "0x18246CD70", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x06029115 RID: 168213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029115")]
		[Address(RVA = "0x246C8E0", Offset = "0x246B4E0", VA = "0x18246C8E0", Slot = "9")]
		public override IEnumerator LoadCoroutine()
		{
			return null;
		}

		// Token: 0x06029116 RID: 168214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029116")]
		[Address(RVA = "0x246D1E0", Offset = "0x246BDE0", VA = "0x18246D1E0", Slot = "15")]
		protected override IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06029117 RID: 168215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029117")]
		[Address(RVA = "0x246BF60", Offset = "0x246AB60", VA = "0x18246BF60", Slot = "36")]
		public override string GetTutorialCustomOperationKey()
		{
			return null;
		}

		// Token: 0x06029118 RID: 168216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029118")]
		[Address(RVA = "0x246BEB0", Offset = "0x246AAB0", VA = "0x18246BEB0", Slot = "37")]
		public override string GetTutorialCustomOperationKeyOnResume(string fromPage)
		{
			return null;
		}

		// Token: 0x06029119 RID: 168217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029119")]
		[Address(RVA = "0x246F810", Offset = "0x246E410", VA = "0x18246F810")]
		private string _TryGetTrainingTutorialKey()
		{
			return null;
		}

		// Token: 0x0602911A RID: 168218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602911A")]
		[Address(RVA = "0x246F6A0", Offset = "0x246E2A0", VA = "0x18246F6A0")]
		private string _TryGetShopTutorialKey(bool needCheckModeId = true)
		{
			return null;
		}

		// Token: 0x0602911B RID: 168219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602911B")]
		[Address(RVA = "0x246DF90", Offset = "0x246CB90", VA = "0x18246DF90")]
		private ActAutoChessData _GetData()
		{
			return null;
		}

		// Token: 0x0602911C RID: 168220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602911C")]
		[Address(RVA = "0x246E120", Offset = "0x246CD20", VA = "0x18246E120")]
		private PlayerActivity.PlayerActAutoChessActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x0602911D RID: 168221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602911D")]
		[Address(RVA = "0x246D410", Offset = "0x246C010", VA = "0x18246D410")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602911E RID: 168222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602911E")]
		[Address(RVA = "0x246D330", Offset = "0x246BF30", VA = "0x18246D330")]
		private ActAutoChessEntryViewModel _GenAutoChessEntryViewModel()
		{
			return null;
		}

		// Token: 0x0602911F RID: 168223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602911F")]
		[Address(RVA = "0x246D520", Offset = "0x246C120", VA = "0x18246D520")]
		private TemplateActivityMedalViewModel _GenMedalViewModel()
		{
			return null;
		}

		// Token: 0x06029120 RID: 168224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029120")]
		[Address(RVA = "0x246D640", Offset = "0x246C240", VA = "0x18246D640")]
		private TemplateActivityMilestoneGroupViewModel _GenMilestoneViewModel()
		{
			return null;
		}

		// Token: 0x06029121 RID: 168225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029121")]
		[Address(RVA = "0x246DD70", Offset = "0x246C970", VA = "0x18246DD70")]
		private TemplateActivityMissionViewModel _GenTemplateMissionViewModel()
		{
			return null;
		}

		// Token: 0x06029122 RID: 168226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029122")]
		[Address(RVA = "0x246FD00", Offset = "0x246E900", VA = "0x18246FD00")]
		private void _UpdateViewModel()
		{
		}

		// Token: 0x06029123 RID: 168227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029123")]
		[Address(RVA = "0x246F9B0", Offset = "0x246E5B0", VA = "0x18246F9B0")]
		private void _UpdateAutoChessEntryModel()
		{
		}

		// Token: 0x06029124 RID: 168228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029124")]
		[Address(RVA = "0x246FAC0", Offset = "0x246E6C0", VA = "0x18246FAC0")]
		private void _UpdateMilestoneModel()
		{
		}

		// Token: 0x06029125 RID: 168229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029125")]
		[Address(RVA = "0x246FBD0", Offset = "0x246E7D0", VA = "0x18246FBD0")]
		private void _UpdateViewModelWithResponse(ActAutoChessSyncInfoResponse response)
		{
		}

		// Token: 0x06029126 RID: 168230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029126")]
		[Address(RVA = "0x246ED20", Offset = "0x246D920", VA = "0x18246ED20")]
		private UISender.ResultHandler<ActAutoChessSyncInfoResponse> _SendSyncInfoRequest()
		{
			return null;
		}

		// Token: 0x06029127 RID: 168231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029127")]
		[Address(RVA = "0x246E7F0", Offset = "0x246D3F0", VA = "0x18246E7F0")]
		private void _HandleSyncInfoResponse(ActAutoChessSyncInfoResponse response)
		{
		}

		// Token: 0x06029128 RID: 168232 RVA: 0x000D4640 File Offset: 0x000D2840
		[Token(Token = "0x6029128")]
		[Address(RVA = "0x246DED0", Offset = "0x246CAD0", VA = "0x18246DED0")]
		private int _GetCoinCount()
		{
			return 0;
		}

		// Token: 0x06029129 RID: 168233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029129")]
		[Address(RVA = "0x246F5F0", Offset = "0x246E1F0", VA = "0x18246F5F0")]
		private void _TryConsumeGuidebook()
		{
		}

		// Token: 0x0602912A RID: 168234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602912A")]
		[Address(RVA = "0x246EF40", Offset = "0x246DB40", VA = "0x18246EF40")]
		private void _ShowAlerts()
		{
		}

		// Token: 0x0602912B RID: 168235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602912B")]
		[Address(RVA = "0x246FE60", Offset = "0x246EA60", VA = "0x18246FE60")]
		private IEnumerator _WaitToPopAlertsCoroutine()
		{
			return null;
		}

		// Token: 0x0602912C RID: 168236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602912C")]
		[Address(RVA = "0x246F0E0", Offset = "0x246DCE0", VA = "0x18246F0E0")]
		private void _ShowChessShopChangeAlertDlg()
		{
		}

		// Token: 0x0602912D RID: 168237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602912D")]
		[Address(RVA = "0x246D960", Offset = "0x246C560", VA = "0x18246D960")]
		private string _GenShopChessChangeInfo(List<string> shopChessChangedList)
		{
			return null;
		}

		// Token: 0x0602912E RID: 168238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602912E")]
		[Address(RVA = "0x246F380", Offset = "0x246DF80", VA = "0x18246F380")]
		private void _ShowMultiMatchBanAlertDlg()
		{
		}

		// Token: 0x0602912F RID: 168239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602912F")]
		[Address(RVA = "0x246CF10", Offset = "0x246BB10", VA = "0x18246CF10")]
		public void OpenInviteDialog()
		{
		}

		// Token: 0x06029130 RID: 168240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029130")]
		[Address(RVA = "0x246D020", Offset = "0x246BC20", VA = "0x18246D020")]
		public void OpenSingleGiveUpDialog()
		{
		}

		// Token: 0x06029131 RID: 168241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029131")]
		[Address(RVA = "0x246CA80", Offset = "0x246B680", VA = "0x18246CA80")]
		public void OnSingleGameSettle()
		{
		}

		// Token: 0x06029132 RID: 168242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029132")]
		[Address(RVA = "0x246C000", Offset = "0x246AC00", VA = "0x18246C000", Slot = "38")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06029133 RID: 168243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029133")]
		[Address(RVA = "0x246E190", Offset = "0x246CD90", VA = "0x18246E190")]
		private void _HandleInviteDialogCallback(ValueBundle outputBundle)
		{
		}

		// Token: 0x06029134 RID: 168244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029134")]
		[Address(RVA = "0x246E590", Offset = "0x246D190", VA = "0x18246E590")]
		private void _HandleShopChessChangeDlgCallback(ValueBundle outputBundle)
		{
		}

		// Token: 0x06029135 RID: 168245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029135")]
		[Address(RVA = "0x246E470", Offset = "0x246D070", VA = "0x18246E470")]
		private void _HandleMatchBannedDlgCallback(ValueBundle outputBundle)
		{
		}

		// Token: 0x06029136 RID: 168246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029136")]
		[Address(RVA = "0x246E6F0", Offset = "0x246D2F0", VA = "0x18246E6F0")]
		private void _HandleSingleGiveUpDlgCallback(ValueBundle outputBundle)
		{
		}

		// Token: 0x06029137 RID: 168247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029137")]
		[Address(RVA = "0x246EB10", Offset = "0x246D710", VA = "0x18246EB10")]
		private void _OnQuitSingleGameProceed(AutoChessQuitSingleGameResponse resp)
		{
		}

		// Token: 0x06029138 RID: 168248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029138")]
		[Address(RVA = "0x246BDB0", Offset = "0x246A9B0", VA = "0x18246BDB0")]
		public static string CreateStageInitMeta(string modeId)
		{
			return null;
		}

		// Token: 0x06029139 RID: 168249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029139")]
		[Address(RVA = "0x246FF10", Offset = "0x246EB10", VA = "0x18246FF10")]
		public ActAutoChessActivityController()
		{
		}

		// Token: 0x0602913C RID: 168252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602913C")]
		[Address(RVA = "0x246D2D0", Offset = "0x246BED0", VA = "0x18246D2D0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0602913D RID: 168253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602913D")]
		[Address(RVA = "0x24643F0", Offset = "0x2462FF0", VA = "0x1824643F0")]
		private void <>xLuaBaseProxy_AfterEntryAnimPlay()
		{
		}

		// Token: 0x0602913E RID: 168254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602913E")]
		[Address(RVA = "0x246D320", Offset = "0x246BF20", VA = "0x18246D320")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x0602913F RID: 168255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602913F")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x06029140 RID: 168256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029140")]
		[Address(RVA = "0x246D290", Offset = "0x246BE90", VA = "0x18246D290")]
		private IEnumerator <>xLuaBaseProxy_LoadCoroutine()
		{
			return null;
		}

		// Token: 0x06029141 RID: 168257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029141")]
		[Address(RVA = "0x246D2A0", Offset = "0x246BEA0", VA = "0x18246D2A0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06029142 RID: 168258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029142")]
		[Address(RVA = "0x246D2C0", Offset = "0x246BEC0", VA = "0x18246D2C0")]
		private string <>xLuaBaseProxy_GetTutorialCustomOperationKey()
		{
			return null;
		}

		// Token: 0x06029143 RID: 168259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029143")]
		[Address(RVA = "0x246D2B0", Offset = "0x246BEB0", VA = "0x18246D2B0")]
		private string <>xLuaBaseProxy_GetTutorialCustomOperationKeyOnResume(string P0)
		{
			return null;
		}

		// Token: 0x0403A9CE RID: 240078
		[Token(Token = "0x403A9CE")]
		[NonSerialized]
		public const string AUTO_CHESS_PARAM = "auto_chess";

		// Token: 0x0403A9CF RID: 240079
		[Token(Token = "0x403A9CF")]
		private const string GUIDEBOOK_SUB_SIGNAL = "home";

		// Token: 0x0403A9D0 RID: 240080
		[Token(Token = "0x403A9D0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0403A9D1 RID: 240081
		[Token(Token = "0x403A9D1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private int _chessCharChangeInfoThreshold;

		// Token: 0x0403A9D2 RID: 240082
		[Token(Token = "0x403A9D2")]
		[FieldOffset(Offset = "0x90")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0403A9D3 RID: 240083
		[Token(Token = "0x403A9D3")]
		[FieldOffset(Offset = "0x98")]
		private int m_inviteDlgInstId;

		// Token: 0x0403A9D4 RID: 240084
		[Token(Token = "0x403A9D4")]
		[FieldOffset(Offset = "0x9C")]
		private int m_singleGiveUpDlgInstId;

		// Token: 0x0403A9D5 RID: 240085
		[Token(Token = "0x403A9D5")]
		[FieldOffset(Offset = "0xA0")]
		private int m_shopChessChangeDlgInstId;

		// Token: 0x0403A9D6 RID: 240086
		[Token(Token = "0x403A9D6")]
		[FieldOffset(Offset = "0xA4")]
		private int m_matchBannedDlgInstId;

		// Token: 0x0403A9D7 RID: 240087
		[Token(Token = "0x403A9D7")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<string, long> m_invitedCache;

		// Token: 0x0403A9D8 RID: 240088
		[Token(Token = "0x403A9D8")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_canShowAlert;

		// Token: 0x0403A9D9 RID: 240089
		[Token(Token = "0x403A9D9")]
		[FieldOffset(Offset = "0xB8")]
		private Coroutine m_popAlertsCoroutine;

		// Token: 0x0403A9DA RID: 240090
		[Token(Token = "0x403A9DA")]
		[FieldOffset(Offset = "0xC0")]
		private ActAutoChessInitMeta m_initMetaObj;

		// Token: 0x0403A9DB RID: 240091
		[Token(Token = "0x403A9DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_initMetaObj;

		// Token: 0x0403A9DC RID: 240092
		[Token(Token = "0x403A9DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403A9DD RID: 240093
		[Token(Token = "0x403A9DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AfterEntryAnimPlay;

		// Token: 0x0403A9DE RID: 240094
		[Token(Token = "0x403A9DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403A9DF RID: 240095
		[Token(Token = "0x403A9DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403A9E0 RID: 240096
		[Token(Token = "0x403A9E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403A9E1 RID: 240097
		[Token(Token = "0x403A9E1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadCoroutine;

		// Token: 0x0403A9E2 RID: 240098
		[Token(Token = "0x403A9E2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403A9E3 RID: 240099
		[Token(Token = "0x403A9E3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetTutorialCustomOperationKey;

		// Token: 0x0403A9E4 RID: 240100
		[Token(Token = "0x403A9E4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetTutorialCustomOperationKeyOnResume;

		// Token: 0x0403A9E5 RID: 240101
		[Token(Token = "0x403A9E5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryGetTrainingTutorialKey;

		// Token: 0x0403A9E6 RID: 240102
		[Token(Token = "0x403A9E6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryGetShopTutorialKey;

		// Token: 0x0403A9E7 RID: 240103
		[Token(Token = "0x403A9E7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetData;

		// Token: 0x0403A9E8 RID: 240104
		[Token(Token = "0x403A9E8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403A9E9 RID: 240105
		[Token(Token = "0x403A9E9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403A9EA RID: 240106
		[Token(Token = "0x403A9EA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenAutoChessEntryViewModel;

		// Token: 0x0403A9EB RID: 240107
		[Token(Token = "0x403A9EB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GenMedalViewModel;

		// Token: 0x0403A9EC RID: 240108
		[Token(Token = "0x403A9EC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GenMilestoneViewModel;

		// Token: 0x0403A9ED RID: 240109
		[Token(Token = "0x403A9ED")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GenTemplateMissionViewModel;

		// Token: 0x0403A9EE RID: 240110
		[Token(Token = "0x403A9EE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__UpdateViewModel;

		// Token: 0x0403A9EF RID: 240111
		[Token(Token = "0x403A9EF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateAutoChessEntryModel;

		// Token: 0x0403A9F0 RID: 240112
		[Token(Token = "0x403A9F0")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__UpdateMilestoneModel;

		// Token: 0x0403A9F1 RID: 240113
		[Token(Token = "0x403A9F1")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UpdateViewModelWithResponse;

		// Token: 0x0403A9F2 RID: 240114
		[Token(Token = "0x403A9F2")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SendSyncInfoRequest;

		// Token: 0x0403A9F3 RID: 240115
		[Token(Token = "0x403A9F3")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__HandleSyncInfoResponse;

		// Token: 0x0403A9F4 RID: 240116
		[Token(Token = "0x403A9F4")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__GetCoinCount;

		// Token: 0x0403A9F5 RID: 240117
		[Token(Token = "0x403A9F5")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x0403A9F6 RID: 240118
		[Token(Token = "0x403A9F6")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ShowAlerts;

		// Token: 0x0403A9F7 RID: 240119
		[Token(Token = "0x403A9F7")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__WaitToPopAlertsCoroutine;

		// Token: 0x0403A9F8 RID: 240120
		[Token(Token = "0x403A9F8")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ShowChessShopChangeAlertDlg;

		// Token: 0x0403A9F9 RID: 240121
		[Token(Token = "0x403A9F9")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__GenShopChessChangeInfo;

		// Token: 0x0403A9FA RID: 240122
		[Token(Token = "0x403A9FA")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__ShowMultiMatchBanAlertDlg;

		// Token: 0x0403A9FB RID: 240123
		[Token(Token = "0x403A9FB")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OpenInviteDialog;

		// Token: 0x0403A9FC RID: 240124
		[Token(Token = "0x403A9FC")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OpenSingleGiveUpDialog;

		// Token: 0x0403A9FD RID: 240125
		[Token(Token = "0x403A9FD")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnSingleGameSettle;

		// Token: 0x0403A9FE RID: 240126
		[Token(Token = "0x403A9FE")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403A9FF RID: 240127
		[Token(Token = "0x403A9FF")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__HandleInviteDialogCallback;

		// Token: 0x0403AA00 RID: 240128
		[Token(Token = "0x403AA00")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__HandleShopChessChangeDlgCallback;

		// Token: 0x0403AA01 RID: 240129
		[Token(Token = "0x403AA01")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__HandleMatchBannedDlgCallback;

		// Token: 0x0403AA02 RID: 240130
		[Token(Token = "0x403AA02")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__HandleSingleGiveUpDlgCallback;

		// Token: 0x0403AA03 RID: 240131
		[Token(Token = "0x403AA03")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__OnQuitSingleGameProceed;

		// Token: 0x0403AA04 RID: 240132
		[Token(Token = "0x403AA04")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_CreateStageInitMeta;

		// Token: 0x0403AA05 RID: 240133
		[Token(Token = "0x403AA05")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020070DD RID: 28893
		[Token(Token = "0x20070DD")]
		private class MilestonePlugin : ITemplateActivityMilestonePlugin, IHotfixable
		{
			// Token: 0x06029144 RID: 168260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029144")]
			[Address(RVA = "0x2479E70", Offset = "0x2478A70", VA = "0x182479E70", Slot = "4")]
			public void InitMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
			{
			}

			// Token: 0x06029145 RID: 168261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029145")]
			[Address(RVA = "0x247A4C0", Offset = "0x24790C0", VA = "0x18247A4C0", Slot = "5")]
			public void UpdateMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
			{
			}

			// Token: 0x06029146 RID: 168262 RVA: 0x000D4658 File Offset: 0x000D2858
			[Token(Token = "0x6029146")]
			[Address(RVA = "0x247A310", Offset = "0x2478F10", VA = "0x18247A310", Slot = "6")]
			public int SortMilestoneItem(TemplateActivityMileStoneItemModel m1, TemplateActivityMileStoneItemModel m2)
			{
				return 0;
			}

			// Token: 0x06029147 RID: 168263 RVA: 0x000D4670 File Offset: 0x000D2870
			[Token(Token = "0x6029147")]
			[Address(RVA = "0x247A1A0", Offset = "0x2478DA0", VA = "0x18247A1A0", Slot = "7")]
			public bool IsItemShow(TemplateActivityMileStoneItemModel itemModel)
			{
				return default(bool);
			}

			// Token: 0x06029148 RID: 168264 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029148")]
			[Address(RVA = "0x2479D40", Offset = "0x2478940", VA = "0x182479D40", Slot = "8")]
			public string GetMilestoneId(string actId)
			{
				return null;
			}

			// Token: 0x06029149 RID: 168265 RVA: 0x000D4688 File Offset: 0x000D2888
			[Token(Token = "0x6029149")]
			[Address(RVA = "0x247A3F0", Offset = "0x2478FF0", VA = "0x18247A3F0", Slot = "9")]
			public int UpdateMilestoneCount(string actId)
			{
				return 0;
			}

			// Token: 0x0602914A RID: 168266 RVA: 0x000D46A0 File Offset: 0x000D28A0
			[Token(Token = "0x602914A")]
			[Address(RVA = "0x247A2B0", Offset = "0x2478EB0", VA = "0x18247A2B0", Slot = "10")]
			public bool NeedFocusToIdx()
			{
				return default(bool);
			}

			// Token: 0x0602914B RID: 168267 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602914B")]
			[Address(RVA = "0x2479BD0", Offset = "0x24787D0", VA = "0x182479BD0", Slot = "11")]
			public IMilestoneServiceConfig GenOneMilConfig(string actId, string milestoneId, Action<List<RewardItemModel>> onProceed)
			{
				return null;
			}

			// Token: 0x0602914C RID: 168268 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602914C")]
			[Address(RVA = "0x2479B10", Offset = "0x2478710", VA = "0x182479B10", Slot = "12")]
			public IMilestoneServiceConfig GenAllMilConfig(string actId, List<TemplateActivityMileStoneItemModel> milestoneList, Action<List<RewardItemModel>> onProceed)
			{
				return null;
			}

			// Token: 0x0602914D RID: 168269 RVA: 0x000D46B8 File Offset: 0x000D28B8
			[Token(Token = "0x602914D")]
			[Address(RVA = "0x247A240", Offset = "0x2478E40", VA = "0x18247A240", Slot = "13")]
			public bool IsMilestoneUnlock(string actId)
			{
				return default(bool);
			}

			// Token: 0x0602914E RID: 168270 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602914E")]
			[Address(RVA = "0x2479DE0", Offset = "0x24789E0", VA = "0x182479DE0", Slot = "14")]
			public string GetMilestoneLockedToastDesc(string actId)
			{
				return null;
			}

			// Token: 0x0602914F RID: 168271 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602914F")]
			[Address(RVA = "0x2479CA0", Offset = "0x24788A0", VA = "0x182479CA0", Slot = "15")]
			public string GetMilestoneExpandTrackGroup(string actId)
			{
				return null;
			}

			// Token: 0x06029150 RID: 168272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029150")]
			[Address(RVA = "0x247A770", Offset = "0x2479370", VA = "0x18247A770")]
			public MilestonePlugin()
			{
			}

			// Token: 0x0403AA06 RID: 240134
			[Token(Token = "0x403AA06")]
			[FieldOffset(Offset = "0x10")]
			private readonly List<TemplateActivityMileStoneItemModel> m_hiddenItems;

			// Token: 0x0403AA07 RID: 240135
			[Token(Token = "0x403AA07")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitMilestoneList;

			// Token: 0x0403AA08 RID: 240136
			[Token(Token = "0x403AA08")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateMilestoneList;

			// Token: 0x0403AA09 RID: 240137
			[Token(Token = "0x403AA09")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SortMilestoneItem;

			// Token: 0x0403AA0A RID: 240138
			[Token(Token = "0x403AA0A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_IsItemShow;

			// Token: 0x0403AA0B RID: 240139
			[Token(Token = "0x403AA0B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetMilestoneId;

			// Token: 0x0403AA0C RID: 240140
			[Token(Token = "0x403AA0C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateMilestoneCount;

			// Token: 0x0403AA0D RID: 240141
			[Token(Token = "0x403AA0D")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_NeedFocusToIdx;

			// Token: 0x0403AA0E RID: 240142
			[Token(Token = "0x403AA0E")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GenOneMilConfig;

			// Token: 0x0403AA0F RID: 240143
			[Token(Token = "0x403AA0F")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_GenAllMilConfig;

			// Token: 0x0403AA10 RID: 240144
			[Token(Token = "0x403AA10")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_IsMilestoneUnlock;

			// Token: 0x0403AA11 RID: 240145
			[Token(Token = "0x403AA11")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_GetMilestoneLockedToastDesc;

			// Token: 0x0403AA12 RID: 240146
			[Token(Token = "0x403AA12")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_GetMilestoneExpandTrackGroup;

			// Token: 0x0403AA13 RID: 240147
			[Token(Token = "0x403AA13")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
