using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.SDK;
using U8.SDK;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Login
{
	// Token: 0x020049DF RID: 18911
	[Token(Token = "0x20049DF")]
	public class LoginViewController : SingletonMonoBehaviour<LoginViewController>, ISingletonNotAutoCreate, IHotfixable
	{
		// Token: 0x17004361 RID: 17249
		// (get) Token: 0x0601C78F RID: 116623 RVA: 0x000A87F8 File Offset: 0x000A69F8
		// (set) Token: 0x0601C790 RID: 116624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004361")]
		[Inspect(InspectorLevel.Debug)]
		public bool isSdkControlled
		{
			[Token(Token = "0x601C78F")]
			[Address(RVA = "0x1606DC0", Offset = "0x16059C0", VA = "0x181606DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601C790")]
			[Address(RVA = "0x1606E20", Offset = "0x1605A20", VA = "0x181606E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601C791 RID: 116625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C791")]
		[Address(RVA = "0x1602910", Offset = "0x1601510", VA = "0x181602910")]
		public void AlertResourceVersionError()
		{
		}

		// Token: 0x0601C792 RID: 116626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C792")]
		[Address(RVA = "0x1602A00", Offset = "0x1601600", VA = "0x181602A00")]
		public void DoSDKLogin(Action nextStep)
		{
		}

		// Token: 0x0601C793 RID: 116627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C793")]
		[Address(RVA = "0x1603330", Offset = "0x1601F30", VA = "0x181603330")]
		public void StartMainLoginProcess([Optional] LoginViewController.LoginListener listener)
		{
		}

		// Token: 0x0601C794 RID: 116628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C794")]
		[Address(RVA = "0x1602B20", Offset = "0x1601720", VA = "0x181602B20")]
		public void EventOnLoginFinished()
		{
		}

		// Token: 0x0601C795 RID: 116629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C795")]
		[Address(RVA = "0x1602C50", Offset = "0x1601850", VA = "0x181602C50")]
		public void EventOnNamed(string nickname)
		{
		}

		// Token: 0x0601C796 RID: 116630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C796")]
		[Address(RVA = "0x1602EB0", Offset = "0x1601AB0", VA = "0x181602EB0")]
		public void EventOnServiceLicenseAgreed()
		{
		}

		// Token: 0x0601C797 RID: 116631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C797")]
		[Address(RVA = "0x16031B0", Offset = "0x1601DB0", VA = "0x1816031B0")]
		public void SDKSwitchToPhase1()
		{
		}

		// Token: 0x0601C798 RID: 116632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C798")]
		[Address(RVA = "0x1603270", Offset = "0x1601E70", VA = "0x181603270")]
		public void SDKSwitchToPhase2()
		{
		}

		// Token: 0x0601C799 RID: 116633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C799")]
		[Address(RVA = "0x1602F80", Offset = "0x1601B80", VA = "0x181602F80")]
		public void OnSDKLoginFinished()
		{
		}

		// Token: 0x0601C79A RID: 116634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C79A")]
		[Address(RVA = "0x1603040", Offset = "0x1601C40", VA = "0x181603040")]
		public void SDKClearAccount()
		{
		}

		// Token: 0x0601C79B RID: 116635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C79B")]
		[Address(RVA = "0x16030A0", Offset = "0x1601CA0", VA = "0x1816030A0")]
		public void SDKExitGameDialog(Action onDismiss)
		{
		}

		// Token: 0x0601C79C RID: 116636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C79C")]
		[Address(RVA = "0x16033F0", Offset = "0x1601FF0", VA = "0x1816033F0")]
		private void Start()
		{
		}

		// Token: 0x0601C79D RID: 116637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C79D")]
		[Address(RVA = "0x1602F10", Offset = "0x1601B10", VA = "0x181602F10", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0601C79E RID: 116638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C79E")]
		[Address(RVA = "0x1605530", Offset = "0x1604130", VA = "0x181605530")]
		private IEnumerator _OnStartCoroutine()
		{
			return null;
		}

		// Token: 0x0601C79F RID: 116639 RVA: 0x000A8810 File Offset: 0x000A6A10
		[Token(Token = "0x601C79F")]
		[Address(RVA = "0x16059D0", Offset = "0x16045D0", VA = "0x1816059D0")]
		private bool _PredicateExitGameBackPressEvent()
		{
			return default(bool);
		}

		// Token: 0x0601C7A0 RID: 116640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7A0")]
		[Address(RVA = "0x1605070", Offset = "0x1603C70", VA = "0x181605070")]
		private void _OnLoginProcessInterrupted()
		{
		}

		// Token: 0x0601C7A1 RID: 116641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7A1")]
		[Address(RVA = "0x16054C0", Offset = "0x16040C0", VA = "0x1816054C0")]
		private void _OnResourceOrClientVersionError()
		{
		}

		// Token: 0x0601C7A2 RID: 116642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7A2")]
		[Address(RVA = "0x1605270", Offset = "0x1603E70", VA = "0x181605270")]
		private void _OnNetworkConfigVersionError()
		{
		}

		// Token: 0x0601C7A3 RID: 116643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7A3")]
		[Address(RVA = "0x1606650", Offset = "0x1605250", VA = "0x181606650")]
		private void _UpdateSDKIdAndLogin(string uid, string token)
		{
		}

		// Token: 0x0601C7A4 RID: 116644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7A4")]
		[Address(RVA = "0x1605930", Offset = "0x1604530", VA = "0x181605930")]
		private static void _PostProcessLoginRequest(LoginRequest loginRequest)
		{
		}

		// Token: 0x0601C7A5 RID: 116645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7A5")]
		[Address(RVA = "0x1604760", Offset = "0x1603360", VA = "0x181604760")]
		private void _LoginServiceSuccess(LoginResponse resBody)
		{
		}

		// Token: 0x0601C7A6 RID: 116646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7A6")]
		[Address(RVA = "0x1606230", Offset = "0x1604E30", VA = "0x181606230")]
		private void _SyncDataServiceSuccess(SyncDataResponse response)
		{
		}

		// Token: 0x0601C7A7 RID: 116647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7A7")]
		[Address(RVA = "0x1603B30", Offset = "0x1602730", VA = "0x181603B30")]
		private void _BindNickNameServiceSuccess(BindNickNameResponse response)
		{
		}

		// Token: 0x0601C7A8 RID: 116648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7A8")]
		[Address(RVA = "0x1604D90", Offset = "0x1603990", VA = "0x181604D90")]
		private void _OnBindNickNameSucc()
		{
		}

		// Token: 0x0601C7A9 RID: 116649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7A9")]
		[Address(RVA = "0x1606BB0", Offset = "0x16057B0", VA = "0x181606BB0")]
		private void _UpdateSDKUID(string uid)
		{
		}

		// Token: 0x0601C7AA RID: 116650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7AA")]
		[Address(RVA = "0x16052E0", Offset = "0x1603EE0", VA = "0x1816052E0")]
		private void _OnPlayerInfoReadyToEnterGame(bool isCreateRoleProcess)
		{
		}

		// Token: 0x0601C7AB RID: 116651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7AB")]
		[Address(RVA = "0x16040A0", Offset = "0x1602CA0", VA = "0x1816040A0")]
		private void _InitPlayerVoiceLangPrefs(Action nextStep)
		{
		}

		// Token: 0x0601C7AC RID: 116652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7AC")]
		[Address(RVA = "0x1603DD0", Offset = "0x16029D0", VA = "0x181603DD0")]
		private void _GoToHomeScene()
		{
		}

		// Token: 0x0601C7AD RID: 116653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7AD")]
		private void _EnsureNextState<StateType>(bool isReplaceTop) where StateType : State
		{
		}

		// Token: 0x0601C7AE RID: 116654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C7AE")]
		private IEnumerator _DoEnsureNextState<StateType>(bool isReplaceTop) where StateType : State
		{
			return null;
		}

		// Token: 0x0601C7AF RID: 116655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7AF")]
		[Address(RVA = "0x1604540", Offset = "0x1603140", VA = "0x181604540")]
		private void _InvokeU8Auth(string captcha)
		{
		}

		// Token: 0x0601C7B0 RID: 116656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7B0")]
		[Address(RVA = "0x1605680", Offset = "0x1604280", VA = "0x181605680")]
		private void _OnU8AuthRejected(object rawRejectInfo)
		{
		}

		// Token: 0x0601C7B1 RID: 116657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7B1")]
		[Address(RVA = "0x16043D0", Offset = "0x1602FD0", VA = "0x1816043D0")]
		private void _InvokeCaptchaForU8Auth(U8LoginRejectInfo rejectInfo)
		{
		}

		// Token: 0x0601C7B2 RID: 116658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7B2")]
		[Address(RVA = "0x16055E0", Offset = "0x16041E0", VA = "0x1816055E0")]
		private void _OnU8AuthCaptchaFetched(SDKExtraInfoHandler.GT3Message message)
		{
		}

		// Token: 0x0601C7B3 RID: 116659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7B3")]
		[Address(RVA = "0x1603C00", Offset = "0x1602800", VA = "0x181603C00")]
		private void _FetchExtraDataAfterAuth(Action nextStep)
		{
		}

		// Token: 0x0601C7B4 RID: 116660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7B4")]
		[Address(RVA = "0x1605120", Offset = "0x1603D20", VA = "0x181605120")]
		private void _OnNativeLicenseFailed(LoginNativeLicense.Failure reason)
		{
		}

		// Token: 0x0601C7B5 RID: 116661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C7B5")]
		[Address(RVA = "0x16046B0", Offset = "0x16032B0", VA = "0x1816046B0")]
		private IEnumerator _LoginFinishCoroutine()
		{
			return null;
		}

		// Token: 0x0601C7B6 RID: 116662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7B6")]
		[Address(RVA = "0x1605D20", Offset = "0x1604920", VA = "0x181605D20")]
		private void _SDKLoginImpl(Action nextStep)
		{
		}

		// Token: 0x0601C7B7 RID: 116663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C7B7")]
		[Address(RVA = "0x1605AC0", Offset = "0x16046C0", VA = "0x181605AC0")]
		private IEnumerator _PreparePlayerInfoToEnterGame()
		{
			return null;
		}

		// Token: 0x0601C7B8 RID: 116664 RVA: 0x000A8828 File Offset: 0x000A6A28
		[Token(Token = "0x601C7B8")]
		[Address(RVA = "0x1606500", Offset = "0x1605100", VA = "0x181606500")]
		private bool _TryToShowInGameLicense()
		{
			return default(bool);
		}

		// Token: 0x0601C7B9 RID: 116665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7B9")]
		[Address(RVA = "0x1604CB0", Offset = "0x16038B0", VA = "0x181604CB0")]
		private void _LoginTrace()
		{
		}

		// Token: 0x0601C7BA RID: 116666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7BA")]
		[Address(RVA = "0x1605F70", Offset = "0x1604B70", VA = "0x181605F70")]
		private static void _ShowExitGameDialog([Optional] Action onDismiss)
		{
		}

		// Token: 0x0601C7BB RID: 116667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7BB")]
		[Address(RVA = "0x1605B70", Offset = "0x1604770", VA = "0x181605B70")]
		private static void _ProcessDataBeforeEnteringMainGame()
		{
		}

		// Token: 0x0601C7BC RID: 116668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7BC")]
		[Address(RVA = "0x1605BF0", Offset = "0x16047F0", VA = "0x181605BF0")]
		private static void _ResetBeforeLoginStart()
		{
		}

		// Token: 0x0601C7BD RID: 116669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7BD")]
		[Address(RVA = "0x1606CE0", Offset = "0x16058E0", VA = "0x181606CE0")]
		public LoginViewController()
		{
		}

		// Token: 0x040254EA RID: 152810
		[Token(Token = "0x40254EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string testUid;

		// Token: 0x040254EB RID: 152811
		[Token(Token = "0x40254EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x040254EC RID: 152812
		[Token(Token = "0x40254EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _uidText;

		// Token: 0x040254ED RID: 152813
		[Token(Token = "0x40254ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _versionText;

		// Token: 0x040254EE RID: 152814
		[Token(Token = "0x40254EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _debugNamingState;

		// Token: 0x040254EF RID: 152815
		[Token(Token = "0x40254EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _hintConnectingText;

		// Token: 0x040254F0 RID: 152816
		[Token(Token = "0x40254F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _hintNicknameText;

		// Token: 0x040254F1 RID: 152817
		[Token(Token = "0x40254F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _hintNicknameRuleText;

		// Token: 0x040254F2 RID: 152818
		[Token(Token = "0x40254F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("DevInfo")]
		private GameObject _devInfoPanel;

		// Token: 0x040254F3 RID: 152819
		[Token(Token = "0x40254F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("DevInfo")]
		private Text _devInfoText;

		// Token: 0x040254F4 RID: 152820
		[Token(Token = "0x40254F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("DevInfo")]
		private GameObject _devInfoDialog;

		// Token: 0x040254F5 RID: 152821
		[Token(Token = "0x40254F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Coroutine m_nextStateCoroutine;

		// Token: 0x040254F6 RID: 152822
		[Token(Token = "0x40254F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private LoginViewController.LoginListener m_loginListener;

		// Token: 0x040254F7 RID: 152823
		[Token(Token = "0x40254F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Coroutine m_loginFinishCoroutine;

		// Token: 0x040254F8 RID: 152824
		[Token(Token = "0x40254F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private LatchUtils.InvokeWhenUnlock m_loginLatch;

		// Token: 0x040254FA RID: 152826
		[Token(Token = "0x40254FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isSdkControlled;

		// Token: 0x040254FB RID: 152827
		[Token(Token = "0x40254FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isSdkControlled;

		// Token: 0x040254FC RID: 152828
		[Token(Token = "0x40254FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AlertResourceVersionError;

		// Token: 0x040254FD RID: 152829
		[Token(Token = "0x40254FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoSDKLogin;

		// Token: 0x040254FE RID: 152830
		[Token(Token = "0x40254FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StartMainLoginProcess;

		// Token: 0x040254FF RID: 152831
		[Token(Token = "0x40254FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnLoginFinished;

		// Token: 0x04025500 RID: 152832
		[Token(Token = "0x4025500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnNamed;

		// Token: 0x04025501 RID: 152833
		[Token(Token = "0x4025501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnServiceLicenseAgreed;

		// Token: 0x04025502 RID: 152834
		[Token(Token = "0x4025502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SDKSwitchToPhase1;

		// Token: 0x04025503 RID: 152835
		[Token(Token = "0x4025503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SDKSwitchToPhase2;

		// Token: 0x04025504 RID: 152836
		[Token(Token = "0x4025504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnSDKLoginFinished;

		// Token: 0x04025505 RID: 152837
		[Token(Token = "0x4025505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SDKClearAccount;

		// Token: 0x04025506 RID: 152838
		[Token(Token = "0x4025506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SDKExitGameDialog;

		// Token: 0x04025507 RID: 152839
		[Token(Token = "0x4025507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04025508 RID: 152840
		[Token(Token = "0x4025508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04025509 RID: 152841
		[Token(Token = "0x4025509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnStartCoroutine;

		// Token: 0x0402550A RID: 152842
		[Token(Token = "0x402550A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__PredicateExitGameBackPressEvent;

		// Token: 0x0402550B RID: 152843
		[Token(Token = "0x402550B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnLoginProcessInterrupted;

		// Token: 0x0402550C RID: 152844
		[Token(Token = "0x402550C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnResourceOrClientVersionError;

		// Token: 0x0402550D RID: 152845
		[Token(Token = "0x402550D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnNetworkConfigVersionError;

		// Token: 0x0402550E RID: 152846
		[Token(Token = "0x402550E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateSDKIdAndLogin;

		// Token: 0x0402550F RID: 152847
		[Token(Token = "0x402550F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__PostProcessLoginRequest;

		// Token: 0x04025510 RID: 152848
		[Token(Token = "0x4025510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__LoginServiceSuccess;

		// Token: 0x04025511 RID: 152849
		[Token(Token = "0x4025511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SyncDataServiceSuccess;

		// Token: 0x04025512 RID: 152850
		[Token(Token = "0x4025512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__BindNickNameServiceSuccess;

		// Token: 0x04025513 RID: 152851
		[Token(Token = "0x4025513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnBindNickNameSucc;

		// Token: 0x04025514 RID: 152852
		[Token(Token = "0x4025514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UpdateSDKUID;

		// Token: 0x04025515 RID: 152853
		[Token(Token = "0x4025515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnPlayerInfoReadyToEnterGame;

		// Token: 0x04025516 RID: 152854
		[Token(Token = "0x4025516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__InitPlayerVoiceLangPrefs;

		// Token: 0x04025517 RID: 152855
		[Token(Token = "0x4025517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__GoToHomeScene;

		// Token: 0x04025518 RID: 152856
		[Token(Token = "0x4025518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__EnsureNextState;

		// Token: 0x04025519 RID: 152857
		[Token(Token = "0x4025519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__DoEnsureNextState;

		// Token: 0x0402551A RID: 152858
		[Token(Token = "0x402551A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__InvokeU8Auth;

		// Token: 0x0402551B RID: 152859
		[Token(Token = "0x402551B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnU8AuthRejected;

		// Token: 0x0402551C RID: 152860
		[Token(Token = "0x402551C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__InvokeCaptchaForU8Auth;

		// Token: 0x0402551D RID: 152861
		[Token(Token = "0x402551D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OnU8AuthCaptchaFetched;

		// Token: 0x0402551E RID: 152862
		[Token(Token = "0x402551E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__FetchExtraDataAfterAuth;

		// Token: 0x0402551F RID: 152863
		[Token(Token = "0x402551F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__OnNativeLicenseFailed;

		// Token: 0x04025520 RID: 152864
		[Token(Token = "0x4025520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__LoginFinishCoroutine;

		// Token: 0x04025521 RID: 152865
		[Token(Token = "0x4025521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__SDKLoginImpl;

		// Token: 0x04025522 RID: 152866
		[Token(Token = "0x4025522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__PreparePlayerInfoToEnterGame;

		// Token: 0x04025523 RID: 152867
		[Token(Token = "0x4025523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__TryToShowInGameLicense;

		// Token: 0x04025524 RID: 152868
		[Token(Token = "0x4025524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__LoginTrace;

		// Token: 0x04025525 RID: 152869
		[Token(Token = "0x4025525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__ShowExitGameDialog;

		// Token: 0x04025526 RID: 152870
		[Token(Token = "0x4025526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__ProcessDataBeforeEnteringMainGame;

		// Token: 0x04025527 RID: 152871
		[Token(Token = "0x4025527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__ResetBeforeLoginStart;

		// Token: 0x04025528 RID: 152872
		[Token(Token = "0x4025528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020049E0 RID: 18912
		[Token(Token = "0x20049E0")]
		public class LoginListener
		{
			// Token: 0x0601C7C3 RID: 116675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C7C3")]
			[Address(RVA = "0x16028F0", Offset = "0x16014F0", VA = "0x1816028F0")]
			public static void TriggerProgress(LoginViewController.LoginListener inst, float progress)
			{
			}

			// Token: 0x0601C7C4 RID: 116676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C7C4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LoginListener()
			{
			}

			// Token: 0x04025529 RID: 152873
			[Token(Token = "0x4025529")]
			public const float PROG_START = 0.1f;

			// Token: 0x0402552A RID: 152874
			[Token(Token = "0x402552A")]
			public const float PROG_SDK_LOGIN = 0.3f;

			// Token: 0x0402552B RID: 152875
			[Token(Token = "0x402552B")]
			public const float PROG_LOGIN = 0.5f;

			// Token: 0x0402552C RID: 152876
			[Token(Token = "0x402552C")]
			public const float PROG_START_SYNC_DATA = 0.6f;

			// Token: 0x0402552D RID: 152877
			[Token(Token = "0x402552D")]
			public const float PROG_START_CONFIRM_ORDER = 0.9f;

			// Token: 0x0402552E RID: 152878
			[Token(Token = "0x402552E")]
			public const float PROG_FINISH_CONFIRM_ORDER = 1f;

			// Token: 0x0402552F RID: 152879
			[Token(Token = "0x402552F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<float> onProgress;
		}
	}
}
