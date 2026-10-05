using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.Network;
using Torappu.Resource;
using Torappu.UI.AgeTips;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A57 RID: 19031
	[Token(Token = "0x2004A57")]
	public class HotUpdateViewController : MonoBehaviour, IHotfixable, HotUpdateWorkflow.IContext
	{
		// Token: 0x0601C9A8 RID: 117160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9A8")]
		[Address(RVA = "0x160E6B0", Offset = "0x160D2B0", VA = "0x18160E6B0")]
		private void Start()
		{
		}

		// Token: 0x0601C9A9 RID: 117161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9A9")]
		[Address(RVA = "0x160DFA0", Offset = "0x160CBA0", VA = "0x18160DFA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601C9AA RID: 117162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9AA")]
		[Address(RVA = "0x160E3C0", Offset = "0x160CFC0", VA = "0x18160E3C0")]
		public void OnPlayPvEnd()
		{
		}

		// Token: 0x0601C9AB RID: 117163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9AB")]
		[Address(RVA = "0x160E640", Offset = "0x160D240", VA = "0x18160E640")]
		public void OnStartPlayPV()
		{
		}

		// Token: 0x0601C9AC RID: 117164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9AC")]
		[Address(RVA = "0x160E2E0", Offset = "0x160CEE0", VA = "0x18160E2E0")]
		public void OnNextPic()
		{
		}

		// Token: 0x0601C9AD RID: 117165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9AD")]
		[Address(RVA = "0x160E350", Offset = "0x160CF50", VA = "0x18160E350")]
		public void OnPanelFinishClick()
		{
		}

		// Token: 0x0601C9AE RID: 117166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9AE")]
		[Address(RVA = "0x160DA70", Offset = "0x160C670", VA = "0x18160DA70")]
		public void EventOnRecordClick()
		{
		}

		// Token: 0x0601C9AF RID: 117167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9AF")]
		[Address(RVA = "0x160DED0", Offset = "0x160CAD0", VA = "0x18160DED0")]
		public void OnDeleteCachedFilesClick()
		{
		}

		// Token: 0x0601C9B0 RID: 117168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9B0")]
		[Address(RVA = "0x160E0B0", Offset = "0x160CCB0", VA = "0x18160E0B0")]
		public void OnFloatPanalDismissClick()
		{
		}

		// Token: 0x0601C9B1 RID: 117169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9B1")]
		[Address(RVA = "0x160DC90", Offset = "0x160C890", VA = "0x18160DC90")]
		public void OnClearCacheBtnClick()
		{
		}

		// Token: 0x0601C9B2 RID: 117170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9B2")]
		[Address(RVA = "0x160E430", Offset = "0x160D030", VA = "0x18160E430")]
		public void OnResourceFixBtnClick()
		{
		}

		// Token: 0x0601C9B3 RID: 117171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9B3")]
		[Address(RVA = "0x160E160", Offset = "0x160CD60", VA = "0x18160E160")]
		public void OnNetCheckClicked()
		{
		}

		// Token: 0x0601C9B4 RID: 117172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9B4")]
		[Address(RVA = "0x160DA10", Offset = "0x160C610", VA = "0x18160DA10")]
		public void EventOnHGSDKV2Clicked()
		{
		}

		// Token: 0x0601C9B5 RID: 117173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C9B5")]
		[Address(RVA = "0x1610A30", Offset = "0x160F630", VA = "0x181610A30")]
		private IEnumerator _OnStartCoroutine()
		{
			return null;
		}

		// Token: 0x0601C9B6 RID: 117174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9B6")]
		[Address(RVA = "0x1610B60", Offset = "0x160F760", VA = "0x181610B60")]
		private void _SetupHintLabelContent()
		{
		}

		// Token: 0x0601C9B7 RID: 117175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9B7")]
		[Address(RVA = "0x160F310", Offset = "0x160DF10", VA = "0x18160F310")]
		private void _CheckCrossThisBundleVersionToDeleteAllCachedFiles()
		{
		}

		// Token: 0x0601C9B8 RID: 117176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9B8")]
		[Address(RVA = "0x160F4F0", Offset = "0x160E0F0", VA = "0x18160F4F0")]
		private static void _ConfirmNetworkConfig()
		{
		}

		// Token: 0x0601C9B9 RID: 117177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9B9")]
		[Address(RVA = "0x160F830", Offset = "0x160E430", VA = "0x18160F830")]
		private static void _ConfirmNetworkConfig(NetworkRouterConfig.Content content, NetworkRouterConfig.Config config)
		{
		}

		// Token: 0x0601C9BA RID: 117178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9BA")]
		[Address(RVA = "0x1610870", Offset = "0x160F470", VA = "0x181610870")]
		private void _NotifyRemoteConfigReady()
		{
		}

		// Token: 0x0601C9BB RID: 117179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9BB")]
		[Address(RVA = "0x1610160", Offset = "0x160ED60", VA = "0x181610160")]
		private void _DeleteAllLocalResAndReload()
		{
		}

		// Token: 0x0601C9BC RID: 117180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9BC")]
		[Address(RVA = "0x16102F0", Offset = "0x160EEF0", VA = "0x1816102F0")]
		private void _DeletePersistentInfoAndReload()
		{
		}

		// Token: 0x0601C9BD RID: 117181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9BD")]
		[Address(RVA = "0x1610AE0", Offset = "0x160F6E0", VA = "0x181610AE0")]
		private void _ResumeBGM()
		{
		}

		// Token: 0x0601C9BE RID: 117182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9BE")]
		[Address(RVA = "0x160EDF0", Offset = "0x160D9F0", VA = "0x18160EDF0")]
		private void Update()
		{
		}

		// Token: 0x0601C9BF RID: 117183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9BF")]
		[Address(RVA = "0x1610480", Offset = "0x160F080", VA = "0x181610480")]
		private void _InitAgeTips()
		{
		}

		// Token: 0x0601C9C0 RID: 117184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9C0")]
		[Address(RVA = "0x16106F0", Offset = "0x160F2F0", VA = "0x1816106F0")]
		private void _InstantiateAgeTips(GameObject prefab)
		{
		}

		// Token: 0x0601C9C1 RID: 117185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C9C1")]
		[Address(RVA = "0x160F160", Offset = "0x160DD60", VA = "0x18160F160")]
		private NetworkErrorDisplayer _AlertNetworkErrorWithNetCheck(string errorMsg, Action callback)
		{
			return null;
		}

		// Token: 0x0601C9C2 RID: 117186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9C2")]
		[Address(RVA = "0x160EF70", Offset = "0x160DB70", VA = "0x18160EF70")]
		private void _AlertNetworkErrorWithNetCheckIgnoreRet(string errorMsg, Action callback)
		{
		}

		// Token: 0x0601C9C3 RID: 117187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C9C3")]
		[Address(RVA = "0x160D910", Offset = "0x160C510", VA = "0x18160D910")]
		public IEnumerator AlertNetworkErrorWithNetCheckRoutine(string errorMsg, [Optional] Action callback)
		{
			return null;
		}

		// Token: 0x0601C9C4 RID: 117188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9C4")]
		[Address(RVA = "0x1610C20", Offset = "0x160F820", VA = "0x181610C20")]
		private void _ShowNetCheckPanel()
		{
		}

		// Token: 0x0601C9C5 RID: 117189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C9C5")]
		[Address(RVA = "0x160FBC0", Offset = "0x160E7C0", VA = "0x18160FBC0")]
		private static List<HotUpdateWorkflow.Node> _CreateWorkflowNodes()
		{
			return null;
		}

		// Token: 0x0601C9C6 RID: 117190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C9C6")]
		[Address(RVA = "0x160DC30", Offset = "0x160C830", VA = "0x18160DC30", Slot = "6")]
		public HotUpdateViewProp GetViewProp()
		{
			return null;
		}

		// Token: 0x0601C9C7 RID: 117191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C9C7")]
		[Address(RVA = "0x160DBD0", Offset = "0x160C7D0", VA = "0x18160DBD0", Slot = "7")]
		public HotUpdateViewController GetViewCtrl()
		{
			return null;
		}

		// Token: 0x0601C9C8 RID: 117192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C9C8")]
		[Address(RVA = "0x160DB70", Offset = "0x160C770", VA = "0x18160DB70")]
		public HotUpdatePreMainTicker GetPreMainTicker()
		{
			return null;
		}

		// Token: 0x0601C9C9 RID: 117193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9C9")]
		[Address(RVA = "0x160EB60", Offset = "0x160D760", VA = "0x18160EB60", Slot = "5")]
		public void StopCoroutineNested(IEnumerator routine)
		{
		}

		// Token: 0x0601C9CA RID: 117194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9CA")]
		[Address(RVA = "0x1610D60", Offset = "0x160F960", VA = "0x181610D60")]
		private void _StartWorkflow()
		{
		}

		// Token: 0x0601C9CB RID: 117195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9CB")]
		[Address(RVA = "0x1610E80", Offset = "0x160FA80", VA = "0x181610E80")]
		public HotUpdateViewController()
		{
		}

		// Token: 0x0601C9CC RID: 117196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C9CC")]
		[Address(RVA = "0x160EBE0", Offset = "0x160D7E0", VA = "0x18160EBE0", Slot = "4")]
		private Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		// Token: 0x040258E3 RID: 153827
		[Token(Token = "0x40258E3")]
		private const float FADEIN_TIME = 0.3f;

		// Token: 0x040258E4 RID: 153828
		[Token(Token = "0x40258E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HotUpdater _hotUpdater;

		// Token: 0x040258E5 RID: 153829
		[Token(Token = "0x40258E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _blackMask;

		// Token: 0x040258E6 RID: 153830
		[Token(Token = "0x40258E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelMenu;

		// Token: 0x040258E7 RID: 153831
		[Token(Token = "0x40258E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x040258E8 RID: 153832
		[Token(Token = "0x40258E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HotUpdateTipController _tipController;

		// Token: 0x040258E9 RID: 153833
		[Token(Token = "0x40258E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HotUpdateViewController.RetryPolicy _retryPolicy;

		// Token: 0x040258EA RID: 153834
		[Token(Token = "0x40258EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _refreshTipPeriodTime;

		// Token: 0x040258EB RID: 153835
		[Token(Token = "0x40258EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textVersion;

		// Token: 0x040258EC RID: 153836
		[Token(Token = "0x40258EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIFadeFloatPanel _fadeFloatPanel;

		// Token: 0x040258ED RID: 153837
		[Token(Token = "0x40258ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("AgeTips")]
		private RectTransform _ageTipsHolder;

		// Token: 0x040258EE RID: 153838
		[Token(Token = "0x40258EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("AgeTips")]
		private UIAgeTipsEntry _ageTipsPrefab;

		// Token: 0x040258EF RID: 153839
		[Token(Token = "0x40258EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("VoicePref")]
		private RectTransform _voicePrefHolder;

		// Token: 0x040258F0 RID: 153840
		[Token(Token = "0x40258F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("VoicePref")]
		private HotUpdateVoicePrefView _voicePrefPrefab;

		// Token: 0x040258F1 RID: 153841
		[Token(Token = "0x40258F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("NetCheck")]
		private HotUpdateNetCheckView _netCheckPrefab;

		// Token: 0x040258F2 RID: 153842
		[Token(Token = "0x40258F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("NetCheck")]
		private HotUpdateNetErrorAlert _netErrorAlertPrefab;

		// Token: 0x040258F3 RID: 153843
		[Token(Token = "0x40258F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("NetCheck")]
		private GameObject _btnNetCheck;

		// Token: 0x040258F4 RID: 153844
		[Token(Token = "0x40258F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("NetCheck")]
		private Text _textBtnNetCheck;

		// Token: 0x040258F5 RID: 153845
		[Token(Token = "0x40258F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("DevConfig")]
		private GameObject _HGSDKV2Button;

		// Token: 0x040258F6 RID: 153846
		[Token(Token = "0x40258F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _recordNumberText;

		// Token: 0x040258F7 RID: 153847
		[Token(Token = "0x40258F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private HotUpdateProgressPanel _progressPanel;

		// Token: 0x040258F8 RID: 153848
		[Token(Token = "0x40258F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private HotUpdatePreMainInstHolder _preMainViewInst;

		// Token: 0x040258F9 RID: 153849
		[Token(Token = "0x40258F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private PeriodicTimer m_refreshTipTimer;

		// Token: 0x040258FA RID: 153850
		[Token(Token = "0x40258FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private NetworkRouter.ConfigHandler m_networkRouterHandler;

		// Token: 0x040258FB RID: 153851
		[Token(Token = "0x40258FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private HotUpdatePreMainTicker m_preMainTicker;

		// Token: 0x040258FC RID: 153852
		[Token(Token = "0x40258FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private HotUpdateViewController.AgeTipsInst m_ageTips;

		// Token: 0x040258FD RID: 153853
		[Token(Token = "0x40258FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private UIAgeTipsEntry m_ageTipsEntry;

		// Token: 0x040258FE RID: 153854
		[Token(Token = "0x40258FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private HotUpdateViewProp m_viewProp;

		// Token: 0x040258FF RID: 153855
		[Token(Token = "0x40258FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HotUpdateWorkflow m_workflow;

		// Token: 0x04025900 RID: 153856
		[Token(Token = "0x4025900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04025901 RID: 153857
		[Token(Token = "0x4025901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04025902 RID: 153858
		[Token(Token = "0x4025902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayPvEnd;

		// Token: 0x04025903 RID: 153859
		[Token(Token = "0x4025903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStartPlayPV;

		// Token: 0x04025904 RID: 153860
		[Token(Token = "0x4025904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnNextPic;

		// Token: 0x04025905 RID: 153861
		[Token(Token = "0x4025905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPanelFinishClick;

		// Token: 0x04025906 RID: 153862
		[Token(Token = "0x4025906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnRecordClick;

		// Token: 0x04025907 RID: 153863
		[Token(Token = "0x4025907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDeleteCachedFilesClick;

		// Token: 0x04025908 RID: 153864
		[Token(Token = "0x4025908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnFloatPanalDismissClick;

		// Token: 0x04025909 RID: 153865
		[Token(Token = "0x4025909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnClearCacheBtnClick;

		// Token: 0x0402590A RID: 153866
		[Token(Token = "0x402590A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnResourceFixBtnClick;

		// Token: 0x0402590B RID: 153867
		[Token(Token = "0x402590B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnNetCheckClicked;

		// Token: 0x0402590C RID: 153868
		[Token(Token = "0x402590C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnHGSDKV2Clicked;

		// Token: 0x0402590D RID: 153869
		[Token(Token = "0x402590D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnStartCoroutine;

		// Token: 0x0402590E RID: 153870
		[Token(Token = "0x402590E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetupHintLabelContent;

		// Token: 0x0402590F RID: 153871
		[Token(Token = "0x402590F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckCrossThisBundleVersionToDeleteAllCachedFiles;

		// Token: 0x04025910 RID: 153872
		[Token(Token = "0x4025910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ConfirmNetworkConfig;

		// Token: 0x04025911 RID: 153873
		[Token(Token = "0x4025911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1__ConfirmNetworkConfig;

		// Token: 0x04025912 RID: 153874
		[Token(Token = "0x4025912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__NotifyRemoteConfigReady;

		// Token: 0x04025913 RID: 153875
		[Token(Token = "0x4025913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__DeleteAllLocalResAndReload;

		// Token: 0x04025914 RID: 153876
		[Token(Token = "0x4025914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__DeletePersistentInfoAndReload;

		// Token: 0x04025915 RID: 153877
		[Token(Token = "0x4025915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ResumeBGM;

		// Token: 0x04025916 RID: 153878
		[Token(Token = "0x4025916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04025917 RID: 153879
		[Token(Token = "0x4025917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__InitAgeTips;

		// Token: 0x04025918 RID: 153880
		[Token(Token = "0x4025918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__InstantiateAgeTips;

		// Token: 0x04025919 RID: 153881
		[Token(Token = "0x4025919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__AlertNetworkErrorWithNetCheck;

		// Token: 0x0402591A RID: 153882
		[Token(Token = "0x402591A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__AlertNetworkErrorWithNetCheckIgnoreRet;

		// Token: 0x0402591B RID: 153883
		[Token(Token = "0x402591B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_AlertNetworkErrorWithNetCheckRoutine;

		// Token: 0x0402591C RID: 153884
		[Token(Token = "0x402591C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ShowNetCheckPanel;

		// Token: 0x0402591D RID: 153885
		[Token(Token = "0x402591D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CreateWorkflowNodes;

		// Token: 0x0402591E RID: 153886
		[Token(Token = "0x402591E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GetViewProp;

		// Token: 0x0402591F RID: 153887
		[Token(Token = "0x402591F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetViewCtrl;

		// Token: 0x04025920 RID: 153888
		[Token(Token = "0x4025920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetPreMainTicker;

		// Token: 0x04025921 RID: 153889
		[Token(Token = "0x4025921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_StopCoroutineNested;

		// Token: 0x04025922 RID: 153890
		[Token(Token = "0x4025922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__StartWorkflow;

		// Token: 0x04025923 RID: 153891
		[Token(Token = "0x4025923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04025924 RID: 153892
		[Token(Token = "0x4025924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge StartCoroutine;

		// Token: 0x02004A58 RID: 19032
		[Token(Token = "0x2004A58")]
		[Serializable]
		private class RetryPolicy
		{
			// Token: 0x17004379 RID: 17273
			// (get) Token: 0x0601C9CE RID: 117198 RVA: 0x000A8C18 File Offset: 0x000A6E18
			[Token(Token = "0x17004379")]
			public float initRetryDelay
			{
				[Token(Token = "0x601C9CE")]
				[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0601C9CF RID: 117199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9CF")]
			[Address(RVA = "0x161D150", Offset = "0x161BD50", VA = "0x18161D150")]
			public void Reset()
			{
			}

			// Token: 0x0601C9D0 RID: 117200 RVA: 0x000A8C30 File Offset: 0x000A6E30
			[Token(Token = "0x601C9D0")]
			[Address(RVA = "0x161D170", Offset = "0x161BD70", VA = "0x18161D170")]
			public bool TryGetNextDelay(bool isTrivialError, out float delay)
			{
				return default(bool);
			}

			// Token: 0x0601C9D1 RID: 117201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9D1")]
			[Address(RVA = "0x161D1E0", Offset = "0x161BDE0", VA = "0x18161D1E0")]
			private void _InitIfNot()
			{
			}

			// Token: 0x0601C9D2 RID: 117202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9D2")]
			[Address(RVA = "0x161D200", Offset = "0x161BE00", VA = "0x18161D200")]
			public RetryPolicy()
			{
			}

			// Token: 0x04025925 RID: 153893
			[Token(Token = "0x4025925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private float _initRetryDelay;

			// Token: 0x04025926 RID: 153894
			[Token(Token = "0x4025926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			private float _maxRetryCnt;

			// Token: 0x04025927 RID: 153895
			[Token(Token = "0x4025927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private float _maxRetryDelay;

			// Token: 0x04025928 RID: 153896
			[Token(Token = "0x4025928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private int _retryCntToDoubleDelay;

			// Token: 0x04025929 RID: 153897
			[Token(Token = "0x4025929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool m_inited;

			// Token: 0x0402592A RID: 153898
			[Token(Token = "0x402592A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float m_curDelay;

			// Token: 0x0402592B RID: 153899
			[Token(Token = "0x402592B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int m_curRetryCnt;
		}

		// Token: 0x02004A59 RID: 19033
		[Token(Token = "0x2004A59")]
		[Serializable]
		private struct HotUpdatePanel
		{
			// Token: 0x0402592C RID: 153900
			[Token(Token = "0x402592C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public HotUpdater.UpdateState state;

			// Token: 0x0402592D RID: 153901
			[Token(Token = "0x402592D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject panel;
		}

		// Token: 0x02004A5A RID: 19034
		[Token(Token = "0x2004A5A")]
		private class SceneParam : ISceneParam
		{
			// Token: 0x0601C9D3 RID: 117203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9D3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SceneParam()
			{
			}

			// Token: 0x0402592E RID: 153902
			[Token(Token = "0x402592E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool hasDeletedPersistentRes;
		}

		// Token: 0x02004A5B RID: 19035
		[Token(Token = "0x2004A5B")]
		private struct AgeTipsInst : IDisposable
		{
			// Token: 0x0601C9D4 RID: 117204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9D4")]
			[Address(RVA = "0x1609470", Offset = "0x1608070", VA = "0x181609470", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0402592F RID: 153903
			[Token(Token = "0x402592F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UIAgeTipsEntry nullableEntry;

			// Token: 0x04025930 RID: 153904
			[Token(Token = "0x4025930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject gameObject;
		}

		// Token: 0x02004A5C RID: 19036
		[Token(Token = "0x2004A5C")]
		private abstract class CheckResNode : HotUpdateWorkflow.Node
		{
			// Token: 0x0601C9D5 RID: 117205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C9D5")]
			[Address(RVA = "0x1609870", Offset = "0x1608470", VA = "0x181609870", Slot = "5")]
			public override CustomYieldInstruction Work()
			{
				return null;
			}

			// Token: 0x0601C9D6 RID: 117206 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C9D6")]
			[Address(RVA = "0x1609B10", Offset = "0x1608710", VA = "0x181609B10")]
			private IEnumerator _CheckCoroutine()
			{
				return null;
			}

			// Token: 0x0601C9D7 RID: 117207 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C9D7")]
			[Address(RVA = "0x1609A60", Offset = "0x1608660", VA = "0x181609A60")]
			private IEnumerator _CheckCoroutineImpl()
			{
				return null;
			}

			// Token: 0x0601C9D8 RID: 117208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9D8")]
			[Address(RVA = "0x16096D0", Offset = "0x16082D0", VA = "0x1816096D0", Slot = "9")]
			public override void OnDispose()
			{
			}

			// Token: 0x0601C9D9 RID: 117209
			[Token(Token = "0x601C9D9")]
			protected abstract IEnumerator OnCheckPassed(PersistentResInfo persistentResInfo);

			// Token: 0x0601C9DA RID: 117210
			[Token(Token = "0x601C9DA")]
			protected abstract bool UseAsyncCheck();

			// Token: 0x0601C9DB RID: 117211
			[Token(Token = "0x601C9DB")]
			protected abstract ConsistencyChecker.CheckType GetCheckType();

			// Token: 0x0601C9DC RID: 117212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9DC")]
			[Address(RVA = "0x1609BC0", Offset = "0x16087C0", VA = "0x181609BC0")]
			protected CheckResNode()
			{
			}

			// Token: 0x0601C9DD RID: 117213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9DD")]
			[Address(RVA = "0x1609860", Offset = "0x1608460", VA = "0x181609860")]
			private void <>xLuaBaseProxy_OnDispose()
			{
			}

			// Token: 0x04025931 RID: 153905
			[Token(Token = "0x4025931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private IEnumerator m_checkRoutine;

			// Token: 0x04025932 RID: 153906
			[Token(Token = "0x4025932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ConsistencyChecker.Cancellation m_cancellation;

			// Token: 0x04025933 RID: 153907
			[Token(Token = "0x4025933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Work;

			// Token: 0x04025934 RID: 153908
			[Token(Token = "0x4025934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__CheckCoroutine;

			// Token: 0x04025935 RID: 153909
			[Token(Token = "0x4025935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__CheckCoroutineImpl;

			// Token: 0x04025936 RID: 153910
			[Token(Token = "0x4025936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnDispose;

			// Token: 0x04025937 RID: 153911
			[Token(Token = "0x4025937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A5F RID: 19039
		[Token(Token = "0x2004A5F")]
		private class InitialCheckResNode : HotUpdateViewController.CheckResNode
		{
			// Token: 0x0601C9EA RID: 117226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9EA")]
			[Address(RVA = "0x161C040", Offset = "0x161AC40", VA = "0x18161C040")]
			public static void MarkInitialBundleDirty()
			{
			}

			// Token: 0x1700437E RID: 17278
			// (get) Token: 0x0601C9EB RID: 117227 RVA: 0x000A8C78 File Offset: 0x000A6E78
			[Token(Token = "0x1700437E")]
			public override HotUpdateWorkflow.ENode type
			{
				[Token(Token = "0x601C9EB")]
				[Address(RVA = "0x161C240", Offset = "0x161AE40", VA = "0x18161C240", Slot = "4")]
				get
				{
					return HotUpdateWorkflow.ENode.NONE;
				}
			}

			// Token: 0x0601C9EC RID: 117228 RVA: 0x000A8C90 File Offset: 0x000A6E90
			[Token(Token = "0x601C9EC")]
			[Address(RVA = "0x161BFE0", Offset = "0x161ABE0", VA = "0x18161BFE0", Slot = "13")]
			protected override ConsistencyChecker.CheckType GetCheckType()
			{
				return ConsistencyChecker.CheckType.ALL;
			}

			// Token: 0x0601C9ED RID: 117229 RVA: 0x000A8CA8 File Offset: 0x000A6EA8
			[Token(Token = "0x601C9ED")]
			[Address(RVA = "0x161C140", Offset = "0x161AD40", VA = "0x18161C140", Slot = "12")]
			protected override bool UseAsyncCheck()
			{
				return default(bool);
			}

			// Token: 0x0601C9EE RID: 117230 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C9EE")]
			[Address(RVA = "0x161C090", Offset = "0x161AC90", VA = "0x18161C090", Slot = "11")]
			protected override IEnumerator OnCheckPassed(PersistentResInfo persistentResInfo)
			{
				return null;
			}

			// Token: 0x0601C9EF RID: 117231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9EF")]
			[Address(RVA = "0x161C1A0", Offset = "0x161ADA0", VA = "0x18161C1A0")]
			public InitialCheckResNode()
			{
			}

			// Token: 0x04025943 RID: 153923
			[Token(Token = "0x4025943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static bool s_initialBundleDirty;

			// Token: 0x04025944 RID: 153924
			[Token(Token = "0x4025944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_MarkInitialBundleDirty;

			// Token: 0x04025945 RID: 153925
			[Token(Token = "0x4025945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_type;

			// Token: 0x04025946 RID: 153926
			[Token(Token = "0x4025946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetCheckType;

			// Token: 0x04025947 RID: 153927
			[Token(Token = "0x4025947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UseAsyncCheck;

			// Token: 0x04025948 RID: 153928
			[Token(Token = "0x4025948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnCheckPassed;

			// Token: 0x04025949 RID: 153929
			[Token(Token = "0x4025949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A61 RID: 19041
		[Token(Token = "0x2004A61")]
		private class MainCheckResNode : HotUpdateViewController.CheckResNode
		{
			// Token: 0x17004381 RID: 17281
			// (get) Token: 0x0601C9F6 RID: 117238 RVA: 0x000A8CD8 File Offset: 0x000A6ED8
			[Token(Token = "0x17004381")]
			public override HotUpdateWorkflow.ENode type
			{
				[Token(Token = "0x601C9F6")]
				[Address(RVA = "0x161CBF0", Offset = "0x161B7F0", VA = "0x18161CBF0", Slot = "4")]
				get
				{
					return HotUpdateWorkflow.ENode.NONE;
				}
			}

			// Token: 0x0601C9F7 RID: 117239 RVA: 0x000A8CF0 File Offset: 0x000A6EF0
			[Token(Token = "0x601C9F7")]
			[Address(RVA = "0x161C610", Offset = "0x161B210", VA = "0x18161C610", Slot = "13")]
			protected override ConsistencyChecker.CheckType GetCheckType()
			{
				return ConsistencyChecker.CheckType.ALL;
			}

			// Token: 0x0601C9F8 RID: 117240 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C9F8")]
			[Address(RVA = "0x161C670", Offset = "0x161B270", VA = "0x18161C670", Slot = "11")]
			protected override IEnumerator OnCheckPassed(PersistentResInfo persistentResInfo)
			{
				return null;
			}

			// Token: 0x0601C9F9 RID: 117241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9F9")]
			[Address(RVA = "0x161C7A0", Offset = "0x161B3A0", VA = "0x18161C7A0")]
			private void _DeleteUnusedFiles(PersistentResInfo persistentResInfo)
			{
			}

			// Token: 0x0601C9FA RID: 117242 RVA: 0x000A8D08 File Offset: 0x000A6F08
			[Token(Token = "0x601C9FA")]
			[Address(RVA = "0x161C740", Offset = "0x161B340", VA = "0x18161C740", Slot = "12")]
			protected override bool UseAsyncCheck()
			{
				return default(bool);
			}

			// Token: 0x0601C9FB RID: 117243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9FB")]
			[Address(RVA = "0x161CAF0", Offset = "0x161B6F0", VA = "0x18161CAF0")]
			[Conditional("DEVELOPMENT_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void _DevOnlyCheckPersistentItems(PersistentResInfo persistentResInfo)
			{
			}

			// Token: 0x0601C9FC RID: 117244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C9FC")]
			[Address(RVA = "0x161CB50", Offset = "0x161B750", VA = "0x18161CB50")]
			public MainCheckResNode()
			{
			}

			// Token: 0x0402594D RID: 153933
			[Token(Token = "0x402594D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_type;

			// Token: 0x0402594E RID: 153934
			[Token(Token = "0x402594E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetCheckType;

			// Token: 0x0402594F RID: 153935
			[Token(Token = "0x402594F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnCheckPassed;

			// Token: 0x04025950 RID: 153936
			[Token(Token = "0x4025950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__DeleteUnusedFiles;

			// Token: 0x04025951 RID: 153937
			[Token(Token = "0x4025951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UseAsyncCheck;

			// Token: 0x04025952 RID: 153938
			[Token(Token = "0x4025952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__DevOnlyCheckPersistentItems;

			// Token: 0x04025953 RID: 153939
			[Token(Token = "0x4025953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A63 RID: 19043
		[Token(Token = "0x2004A63")]
		private class DownloadInstruction : CustomYieldInstruction, IDisposable
		{
			// Token: 0x17004384 RID: 17284
			// (get) Token: 0x0601CA03 RID: 117251 RVA: 0x000A8D38 File Offset: 0x000A6F38
			[Token(Token = "0x17004384")]
			public override bool keepWaiting
			{
				[Token(Token = "0x601CA03")]
				[Address(RVA = "0x160BEE0", Offset = "0x160AAE0", VA = "0x18160BEE0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601CA04 RID: 117252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA04")]
			[Address(RVA = "0x160AC20", Offset = "0x1609820", VA = "0x18160AC20", Slot = "9")]
			public void Dispose()
			{
			}

			// Token: 0x0601CA05 RID: 117253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA05")]
			[Address(RVA = "0x160AE70", Offset = "0x1609A70", VA = "0x18160AE70")]
			private void _DisposeProgress()
			{
			}

			// Token: 0x0601CA06 RID: 117254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA06")]
			[Address(RVA = "0x160BA30", Offset = "0x160A630", VA = "0x18160BA30")]
			public DownloadInstruction(HotUpdateViewController viewCtrl, HotUpdateWorkflow workflow, HotUpdateWorkflow.ENode nodeType)
			{
			}

			// Token: 0x0601CA07 RID: 117255 RVA: 0x000A8D50 File Offset: 0x000A6F50
			[Token(Token = "0x601CA07")]
			[Address(RVA = "0x160AE50", Offset = "0x1609A50", VA = "0x18160AE50")]
			private bool _AchieveFinishLock()
			{
				return default(bool);
			}

			// Token: 0x0601CA08 RID: 117256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA08")]
			[Address(RVA = "0x160AFD0", Offset = "0x1609BD0", VA = "0x18160AFD0")]
			private void _HandleErrorUpdateState(HotUpdater.UpdateState prevState, HotUpdater.UpdateState curState)
			{
			}

			// Token: 0x0601CA09 RID: 117257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA09")]
			[Address(RVA = "0x160B900", Offset = "0x160A500", VA = "0x18160B900")]
			private void _RetryNodeDelayed(HotUpdateWorkflow.ENode node, float delay)
			{
			}

			// Token: 0x0601CA0A RID: 117258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA0A")]
			[Address(RVA = "0x160BA00", Offset = "0x160A600", VA = "0x18160BA00")]
			private void _RetryNode(HotUpdateWorkflow.ENode node)
			{
			}

			// Token: 0x0601CA0B RID: 117259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA0B")]
			[Address(RVA = "0x160B400", Offset = "0x160A000", VA = "0x18160B400")]
			private void _OnHotUpdateStateChange(HotUpdater.UpdateState prevState, HotUpdater.UpdateState curState)
			{
			}

			// Token: 0x0601CA0C RID: 117260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA0C")]
			[Address(RVA = "0x160B2C0", Offset = "0x1609EC0", VA = "0x18160B2C0")]
			private void _OnDownloadStart()
			{
			}

			// Token: 0x0601CA0D RID: 117261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA0D")]
			[Address(RVA = "0x160B750", Offset = "0x160A350", VA = "0x18160B750")]
			private void _OnUnZipStart()
			{
			}

			// Token: 0x0601CA0E RID: 117262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA0E")]
			[Address(RVA = "0x160B210", Offset = "0x1609E10", VA = "0x18160B210")]
			private void _OnDownloadProgress(long curSize, long totalSize)
			{
			}

			// Token: 0x0601CA0F RID: 117263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA0F")]
			[Address(RVA = "0x160B870", Offset = "0x160A470", VA = "0x18160B870")]
			private void _OnUnzipProgress(float progress)
			{
			}

			// Token: 0x0601CA10 RID: 117264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA10")]
			[Address(RVA = "0x160B670", Offset = "0x160A270", VA = "0x18160B670")]
			private void _OnRecoverPersistResInfoPrg(int curCount, int totalCount)
			{
			}

			// Token: 0x04025958 RID: 153944
			[Token(Token = "0x4025958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool m_isFinished;

			// Token: 0x04025959 RID: 153945
			[Token(Token = "0x4025959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool m_isAboutToFinish;

			// Token: 0x0402595A RID: 153946
			[Token(Token = "0x402595A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private HotUpdateWorkflow m_workflow;

			// Token: 0x0402595B RID: 153947
			[Token(Token = "0x402595B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private HotUpdateViewController m_viewCtrl;

			// Token: 0x0402595C RID: 153948
			[Token(Token = "0x402595C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private HotUpdater m_updater;

			// Token: 0x0402595D RID: 153949
			[Token(Token = "0x402595D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private HotUpdateViewController.RetryPolicy m_retryPolicy;

			// Token: 0x0402595E RID: 153950
			[Token(Token = "0x402595E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HotUpdater.DownloadPartEnum m_partEnum;

			// Token: 0x0402595F RID: 153951
			[Token(Token = "0x402595F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private HotUpdateWorkflow.ENode m_nodeType;

			// Token: 0x04025960 RID: 153952
			[Token(Token = "0x4025960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HotUpdateProgressModel.DownloadProgress m_downloadProg;

			// Token: 0x04025961 RID: 153953
			[Token(Token = "0x4025961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private HotUpdateProgressModel.SimpleProgress m_unzipProg;

			// Token: 0x04025962 RID: 153954
			[Token(Token = "0x4025962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private HotUpdateViewController.DownloadInstruction.ResRecoverProgress m_resRecoverProg;

			// Token: 0x02004A64 RID: 19044
			[Token(Token = "0x2004A64")]
			private class ResRecoverProgress : HotUpdateProgressModel.Progress
			{
				// Token: 0x0601CA12 RID: 117266 RVA: 0x000A8D68 File Offset: 0x000A6F68
				[Token(Token = "0x601CA12")]
				[Address(RVA = "0x161CFE0", Offset = "0x161BBE0", VA = "0x18161CFE0", Slot = "5")]
				public override double GetCurrent()
				{
					return 0.0;
				}

				// Token: 0x0601CA13 RID: 117267 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x601CA13")]
				[Address(RVA = "0x161CFF0", Offset = "0x161BBF0", VA = "0x18161CFF0", Slot = "4")]
				public override string GetInfo()
				{
					return null;
				}

				// Token: 0x0601CA14 RID: 117268 RVA: 0x000A8D80 File Offset: 0x000A6F80
				[Token(Token = "0x601CA14")]
				[Address(RVA = "0x161D0F0", Offset = "0x161BCF0", VA = "0x18161D0F0", Slot = "6")]
				public override double GetTotal()
				{
					return 0.0;
				}

				// Token: 0x0601CA15 RID: 117269 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601CA15")]
				[Address(RVA = "0x161D100", Offset = "0x161BD00", VA = "0x18161D100")]
				public void Set(int cur, int total)
				{
				}

				// Token: 0x0601CA16 RID: 117270 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601CA16")]
				[Address(RVA = "0x161CFD0", Offset = "0x161BBD0", VA = "0x18161CFD0")]
				public ResRecoverProgress()
				{
				}

				// Token: 0x04025963 RID: 153955
				[Token(Token = "0x4025963")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private int m_cur;

				// Token: 0x04025964 RID: 153956
				[Token(Token = "0x4025964")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private int m_total;

				// Token: 0x04025965 RID: 153957
				[Token(Token = "0x4025965")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private string m_info;
			}
		}

		// Token: 0x02004A66 RID: 19046
		[Token(Token = "0x2004A66")]
		private abstract class AbstractDownloadNode : HotUpdateWorkflow.Node
		{
			// Token: 0x0601CA19 RID: 117273 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA19")]
			[Address(RVA = "0x16090E0", Offset = "0x1607CE0", VA = "0x1816090E0", Slot = "5")]
			public override CustomYieldInstruction Work()
			{
				return null;
			}

			// Token: 0x0601CA1A RID: 117274 RVA: 0x000A8D98 File Offset: 0x000A6F98
			[Token(Token = "0x601CA1A")]
			[Address(RVA = "0x1609020", Offset = "0x1607C20", VA = "0x181609020")]
			public static bool CheckIfToUseLocalResMode()
			{
				return default(bool);
			}

			// Token: 0x0601CA1B RID: 117275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA1B")]
			[Address(RVA = "0x1609410", Offset = "0x1608010", VA = "0x181609410")]
			protected AbstractDownloadNode()
			{
			}

			// Token: 0x04025968 RID: 153960
			[Token(Token = "0x4025968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Work;

			// Token: 0x04025969 RID: 153961
			[Token(Token = "0x4025969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CheckIfToUseLocalResMode;

			// Token: 0x0402596A RID: 153962
			[Token(Token = "0x402596A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A68 RID: 19048
		[Token(Token = "0x2004A68")]
		private class DownloadInitNode : HotUpdateViewController.AbstractDownloadNode
		{
			// Token: 0x17004385 RID: 17285
			// (get) Token: 0x0601CA1E RID: 117278 RVA: 0x000A8DC8 File Offset: 0x000A6FC8
			[Token(Token = "0x17004385")]
			public override HotUpdateWorkflow.ENode type
			{
				[Token(Token = "0x601CA1E")]
				[Address(RVA = "0x160ABC0", Offset = "0x16097C0", VA = "0x18160ABC0", Slot = "4")]
				get
				{
					return HotUpdateWorkflow.ENode.NONE;
				}
			}

			// Token: 0x0601CA1F RID: 117279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA1F")]
			[Address(RVA = "0x160AB20", Offset = "0x1609720", VA = "0x18160AB20")]
			public DownloadInitNode()
			{
			}

			// Token: 0x0402596D RID: 153965
			[Token(Token = "0x402596D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_type;

			// Token: 0x0402596E RID: 153966
			[Token(Token = "0x402596E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A69 RID: 19049
		[Token(Token = "0x2004A69")]
		private class DownloadMainNode : HotUpdateViewController.AbstractDownloadNode
		{
			// Token: 0x17004386 RID: 17286
			// (get) Token: 0x0601CA20 RID: 117280 RVA: 0x000A8DE0 File Offset: 0x000A6FE0
			[Token(Token = "0x17004386")]
			public override HotUpdateWorkflow.ENode type
			{
				[Token(Token = "0x601CA20")]
				[Address(RVA = "0x160C050", Offset = "0x160AC50", VA = "0x18160C050", Slot = "4")]
				get
				{
					return HotUpdateWorkflow.ENode.NONE;
				}
			}

			// Token: 0x0601CA21 RID: 117281 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA21")]
			[Address(RVA = "0x160BF00", Offset = "0x160AB00", VA = "0x18160BF00", Slot = "5")]
			public override CustomYieldInstruction Work()
			{
				return null;
			}

			// Token: 0x0601CA22 RID: 117282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA22")]
			[Address(RVA = "0x160BFB0", Offset = "0x160ABB0", VA = "0x18160BFB0")]
			public DownloadMainNode()
			{
			}

			// Token: 0x0601CA23 RID: 117283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA23")]
			[Address(RVA = "0x160BEF0", Offset = "0x160AAF0", VA = "0x18160BEF0")]
			private CustomYieldInstruction <>xLuaBaseProxy_Work()
			{
				return null;
			}

			// Token: 0x0402596F RID: 153967
			[Token(Token = "0x402596F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_type;

			// Token: 0x04025970 RID: 153968
			[Token(Token = "0x4025970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Work;

			// Token: 0x04025971 RID: 153969
			[Token(Token = "0x4025971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A6A RID: 19050
		[Token(Token = "0x2004A6A")]
		private class LocalResInstruction : CustomYieldInstruction
		{
			// Token: 0x17004387 RID: 17287
			// (get) Token: 0x0601CA24 RID: 117284 RVA: 0x000A8DF8 File Offset: 0x000A6FF8
			[Token(Token = "0x17004387")]
			public override bool keepWaiting
			{
				[Token(Token = "0x601CA24")]
				[Address(RVA = "0x160BEE0", Offset = "0x160AAE0", VA = "0x18160BEE0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601CA25 RID: 117285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA25")]
			[Address(RVA = "0x161C5D0", Offset = "0x161B1D0", VA = "0x18161C5D0")]
			public LocalResInstruction(HotUpdateViewController viewCtrl, HotUpdateWorkflow workflow)
			{
			}

			// Token: 0x0601CA26 RID: 117286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA26")]
			[Address(RVA = "0x161C360", Offset = "0x161AF60", VA = "0x18161C360")]
			private void _GeneratePersistentInfo()
			{
			}

			// Token: 0x0601CA27 RID: 117287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA27")]
			[Address(RVA = "0x161C2D0", Offset = "0x161AED0", VA = "0x18161C2D0")]
			private void _ErrorAlertAndMarkFinished(string errorInfo)
			{
			}

			// Token: 0x0601CA28 RID: 117288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA28")]
			[Address(RVA = "0x161C590", Offset = "0x161B190", VA = "0x18161C590")]
			private void _MarkFinished(bool suc)
			{
			}

			// Token: 0x04025972 RID: 153970
			[Token(Token = "0x4025972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool m_isFinished;

			// Token: 0x04025973 RID: 153971
			[Token(Token = "0x4025973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private HotUpdateWorkflow m_workflow;
		}

		// Token: 0x02004A6B RID: 19051
		[Token(Token = "0x2004A6B")]
		private class GameUpdateSDKNode : HotUpdateWorkflow.Node
		{
			// Token: 0x17004388 RID: 17288
			// (get) Token: 0x0601CA2A RID: 117290 RVA: 0x000A8E10 File Offset: 0x000A7010
			[Token(Token = "0x17004388")]
			public override HotUpdateWorkflow.ENode type
			{
				[Token(Token = "0x601CA2A")]
				[Address(RVA = "0x160C850", Offset = "0x160B450", VA = "0x18160C850", Slot = "4")]
				get
				{
					return HotUpdateWorkflow.ENode.NONE;
				}
			}

			// Token: 0x0601CA2B RID: 117291 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA2B")]
			[Address(RVA = "0x160C740", Offset = "0x160B340", VA = "0x18160C740")]
			private IEnumerator _WorkCoroutine()
			{
				return null;
			}

			// Token: 0x0601CA2C RID: 117292 RVA: 0x000A8E28 File Offset: 0x000A7028
			[Token(Token = "0x601CA2C")]
			[Address(RVA = "0x160C6A0", Offset = "0x160B2A0", VA = "0x18160C6A0")]
			private bool _UseGameUpdateWebApiVersion()
			{
				return default(bool);
			}

			// Token: 0x0601CA2D RID: 117293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA2D")]
			[Address(RVA = "0x160C540", Offset = "0x160B140", VA = "0x18160C540")]
			private void _OnDownloadStart()
			{
			}

			// Token: 0x0601CA2E RID: 117294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA2E")]
			[Address(RVA = "0x160C490", Offset = "0x160B090", VA = "0x18160C490")]
			private void _OnDownloadProgress(long curSize, long totalSize)
			{
			}

			// Token: 0x0601CA2F RID: 117295 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA2F")]
			[Address(RVA = "0x160C300", Offset = "0x160AF00", VA = "0x18160C300", Slot = "5")]
			public override CustomYieldInstruction Work()
			{
				return null;
			}

			// Token: 0x0601CA30 RID: 117296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA30")]
			[Address(RVA = "0x160C7F0", Offset = "0x160B3F0", VA = "0x18160C7F0")]
			public GameUpdateSDKNode()
			{
			}

			// Token: 0x04025974 RID: 153972
			[Token(Token = "0x4025974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private IGameUpdate m_sdk;

			// Token: 0x04025975 RID: 153973
			[Token(Token = "0x4025975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private HotUpdater.NetUsagePolicy m_netUsagePolicy;

			// Token: 0x04025976 RID: 153974
			[Token(Token = "0x4025976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private HotUpdateProgressModel.DownloadProgress m_downloadPrg;

			// Token: 0x04025977 RID: 153975
			[Token(Token = "0x4025977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_type;

			// Token: 0x04025978 RID: 153976
			[Token(Token = "0x4025978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__WorkCoroutine;

			// Token: 0x04025979 RID: 153977
			[Token(Token = "0x4025979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__UseGameUpdateWebApiVersion;

			// Token: 0x0402597A RID: 153978
			[Token(Token = "0x402597A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__OnDownloadStart;

			// Token: 0x0402597B RID: 153979
			[Token(Token = "0x402597B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__OnDownloadProgress;

			// Token: 0x0402597C RID: 153980
			[Token(Token = "0x402597C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Work;

			// Token: 0x0402597D RID: 153981
			[Token(Token = "0x402597D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A6D RID: 19053
		[Token(Token = "0x2004A6D")]
		private abstract class BasePanelCtrl : PlainClassDataBinder<HotUpdateViewProp>
		{
			// Token: 0x0601CA38 RID: 117304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA38")]
			[Address(RVA = "0x1609500", Offset = "0x1608100", VA = "0x181609500")]
			public void Init(HotUpdateWorkflow.IContext pContext)
			{
			}

			// Token: 0x0601CA39 RID: 117305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA39")]
			[Address(RVA = "0x1609600", Offset = "0x1608200", VA = "0x181609600", Slot = "6")]
			protected virtual void OnInit()
			{
			}

			// Token: 0x0601CA3A RID: 117306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA3A")]
			[Address(RVA = "0x1609660", Offset = "0x1608260", VA = "0x181609660")]
			protected BasePanelCtrl()
			{
			}

			// Token: 0x04025982 RID: 153986
			[Token(Token = "0x4025982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			protected HotUpdateWorkflow.IContext context;

			// Token: 0x04025983 RID: 153987
			[Token(Token = "0x4025983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04025984 RID: 153988
			[Token(Token = "0x4025984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x04025985 RID: 153989
			[Token(Token = "0x4025985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A6E RID: 19054
		[Token(Token = "0x2004A6E")]
		private class MenuPanelCtrl : HotUpdateViewController.BasePanelCtrl
		{
			// Token: 0x0601CA3B RID: 117307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA3B")]
			[Address(RVA = "0x161CC50", Offset = "0x161B850", VA = "0x18161CC50", Slot = "6")]
			protected override void OnInit()
			{
			}

			// Token: 0x0601CA3C RID: 117308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA3C")]
			[Address(RVA = "0x161CD20", Offset = "0x161B920", VA = "0x18161CD20", Slot = "5")]
			public override void OnValueChanged(HotUpdateViewProp property)
			{
			}

			// Token: 0x0601CA3D RID: 117309 RVA: 0x000A8E58 File Offset: 0x000A7058
			[Token(Token = "0x601CA3D")]
			[Address(RVA = "0x161CE80", Offset = "0x161BA80", VA = "0x18161CE80")]
			private static bool _CheckIfShowMenu(HotUpdateViewModel model)
			{
				return default(bool);
			}

			// Token: 0x0601CA3E RID: 117310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA3E")]
			[Address(RVA = "0x161CF20", Offset = "0x161BB20", VA = "0x18161CF20")]
			public MenuPanelCtrl()
			{
			}

			// Token: 0x0601CA3F RID: 117311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA3F")]
			[Address(RVA = "0x1609600", Offset = "0x1608200", VA = "0x181609600")]
			private void <>xLuaBaseProxy_OnInit()
			{
			}

			// Token: 0x04025986 RID: 153990
			[Token(Token = "0x4025986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private GameObject m_panelMenu;

			// Token: 0x04025987 RID: 153991
			[Token(Token = "0x4025987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x04025988 RID: 153992
			[Token(Token = "0x4025988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnValueChanged;

			// Token: 0x04025989 RID: 153993
			[Token(Token = "0x4025989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__CheckIfShowMenu;

			// Token: 0x0402598A RID: 153994
			[Token(Token = "0x402598A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A6F RID: 19055
		[Token(Token = "0x2004A6F")]
		private class CompletePanelCtrl : HotUpdateViewController.BasePanelCtrl
		{
			// Token: 0x0601CA40 RID: 117312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA40")]
			[Address(RVA = "0x160A5D0", Offset = "0x16091D0", VA = "0x18160A5D0", Slot = "6")]
			protected override void OnInit()
			{
			}

			// Token: 0x0601CA41 RID: 117313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA41")]
			[Address(RVA = "0x160A6A0", Offset = "0x16092A0", VA = "0x18160A6A0", Slot = "5")]
			public override void OnValueChanged(HotUpdateViewProp property)
			{
			}

			// Token: 0x0601CA42 RID: 117314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA42")]
			[Address(RVA = "0x160A7A0", Offset = "0x16093A0", VA = "0x18160A7A0")]
			public CompletePanelCtrl()
			{
			}

			// Token: 0x0601CA43 RID: 117315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA43")]
			[Address(RVA = "0x1609600", Offset = "0x1608200", VA = "0x181609600")]
			private void <>xLuaBaseProxy_OnInit()
			{
			}

			// Token: 0x0402598B RID: 153995
			[Token(Token = "0x402598B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private GameObject m_panelComplete;

			// Token: 0x0402598C RID: 153996
			[Token(Token = "0x402598C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x0402598D RID: 153997
			[Token(Token = "0x402598D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnValueChanged;

			// Token: 0x0402598E RID: 153998
			[Token(Token = "0x402598E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A70 RID: 19056
		[Token(Token = "0x2004A70")]
		private class ClientUpgradeNode : HotUpdateWorkflow.Node
		{
			// Token: 0x1700438B RID: 17291
			// (get) Token: 0x0601CA44 RID: 117316 RVA: 0x000A8E70 File Offset: 0x000A7070
			[Token(Token = "0x1700438B")]
			public override HotUpdateWorkflow.ENode type
			{
				[Token(Token = "0x601CA44")]
				[Address(RVA = "0x160A570", Offset = "0x1609170", VA = "0x18160A570", Slot = "4")]
				get
				{
					return HotUpdateWorkflow.ENode.NONE;
				}
			}

			// Token: 0x0601CA45 RID: 117317 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA45")]
			[Address(RVA = "0x1609F10", Offset = "0x1608B10", VA = "0x181609F10", Slot = "5")]
			public override CustomYieldInstruction Work()
			{
				return null;
			}

			// Token: 0x0601CA46 RID: 117318 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA46")]
			[Address(RVA = "0x160A460", Offset = "0x1609060", VA = "0x18160A460")]
			private IEnumerator _UpgradeClientVersionRoutine()
			{
				return null;
			}

			// Token: 0x0601CA47 RID: 117319 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA47")]
			[Address(RVA = "0x160A0E0", Offset = "0x1608CE0", VA = "0x18160A0E0")]
			private static IEnumerator _GameUpgradeProcess(NetworkRouterConfig.Content reason)
			{
				return null;
			}

			// Token: 0x0601CA48 RID: 117320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA48")]
			[Address(RVA = "0x160A280", Offset = "0x1608E80", VA = "0x18160A280")]
			private static void _TryUpgradeGameVersion(Networker.Configuration networkConfig)
			{
			}

			// Token: 0x0601CA49 RID: 117321 RVA: 0x000A8E88 File Offset: 0x000A7088
			[Token(Token = "0x601CA49")]
			[Address(RVA = "0x160A190", Offset = "0x1608D90", VA = "0x18160A190")]
			private static bool _OverrideGameUpgrading()
			{
				return default(bool);
			}

			// Token: 0x0601CA4A RID: 117322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA4A")]
			[Address(RVA = "0x160A510", Offset = "0x1609110", VA = "0x18160A510")]
			public ClientUpgradeNode()
			{
			}

			// Token: 0x0402598F RID: 153999
			[Token(Token = "0x402598F")]
			private const float ALERT_COOLDOWN = 0.5f;

			// Token: 0x04025990 RID: 154000
			[Token(Token = "0x4025990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private NetworkRouterConfig.Content m_reason;

			// Token: 0x04025991 RID: 154001
			[Token(Token = "0x4025991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool m_isUpgradeFinished;

			// Token: 0x04025992 RID: 154002
			[Token(Token = "0x4025992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_type;

			// Token: 0x04025993 RID: 154003
			[Token(Token = "0x4025993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Work;

			// Token: 0x04025994 RID: 154004
			[Token(Token = "0x4025994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__UpgradeClientVersionRoutine;

			// Token: 0x04025995 RID: 154005
			[Token(Token = "0x4025995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__GameUpgradeProcess;

			// Token: 0x04025996 RID: 154006
			[Token(Token = "0x4025996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__TryUpgradeGameVersion;

			// Token: 0x04025997 RID: 154007
			[Token(Token = "0x4025997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__OverrideGameUpgrading;

			// Token: 0x04025998 RID: 154008
			[Token(Token = "0x4025998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A74 RID: 19060
		[Token(Token = "0x2004A74")]
		private class ConfigNode : HotUpdateWorkflow.Node
		{
			// Token: 0x17004390 RID: 17296
			// (get) Token: 0x0601CA59 RID: 117337 RVA: 0x000A8ED0 File Offset: 0x000A70D0
			[Token(Token = "0x17004390")]
			public override HotUpdateWorkflow.ENode type
			{
				[Token(Token = "0x601CA59")]
				[Address(RVA = "0x16212C0", Offset = "0x161FEC0", VA = "0x1816212C0", Slot = "4")]
				get
				{
					return HotUpdateWorkflow.ENode.NONE;
				}
			}

			// Token: 0x0601CA5A RID: 117338 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA5A")]
			[Address(RVA = "0x16208C0", Offset = "0x161F4C0", VA = "0x1816208C0", Slot = "5")]
			public override CustomYieldInstruction Work()
			{
				return null;
			}

			// Token: 0x0601CA5B RID: 117339 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA5B")]
			[Address(RVA = "0x1620B80", Offset = "0x161F780", VA = "0x181620B80")]
			private IEnumerator _FetchConfigsCoroutine()
			{
				return null;
			}

			// Token: 0x0601CA5C RID: 117340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA5C")]
			[Address(RVA = "0x1620CE0", Offset = "0x161F8E0", VA = "0x181620CE0")]
			private IEnumerator _FetchNetworkConfigRoutine()
			{
				return null;
			}

			// Token: 0x0601CA5D RID: 117341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA5D")]
			[Address(RVA = "0x1620C30", Offset = "0x161F830", VA = "0x181620C30")]
			private IEnumerator _FetchNetworkConfigFromGameConfig()
			{
				return null;
			}

			// Token: 0x0601CA5E RID: 117342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA5E")]
			[Address(RVA = "0x1620EF0", Offset = "0x161FAF0", VA = "0x181620EF0")]
			private void _FetchSetAuditModeRoutine()
			{
			}

			// Token: 0x0601CA5F RID: 117343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA5F")]
			[Address(RVA = "0x1620D90", Offset = "0x161F990", VA = "0x181620D90")]
			private IEnumerator _FetchRemoteConfigRoutine()
			{
				return null;
			}

			// Token: 0x0601CA60 RID: 117344 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA60")]
			[Address(RVA = "0x1620E40", Offset = "0x161FA40", VA = "0x181620E40")]
			private IEnumerator _FetchResVersionRoutine()
			{
				return null;
			}

			// Token: 0x0601CA61 RID: 117345 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA61")]
			[Address(RVA = "0x1620FA0", Offset = "0x161FBA0", VA = "0x181620FA0")]
			private static NetworkRouterConfig.Content _MakeNotOverrideRouterForClientUpgrade()
			{
				return null;
			}

			// Token: 0x0601CA62 RID: 117346 RVA: 0x000A8EE8 File Offset: 0x000A70E8
			[Token(Token = "0x601CA62")]
			[Address(RVA = "0x1621170", Offset = "0x161FD70", VA = "0x181621170")]
			private bool _ValidateClientVersion(string requiredClientVersion)
			{
				return default(bool);
			}

			// Token: 0x0601CA63 RID: 117347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA63")]
			[Address(RVA = "0x1620710", Offset = "0x161F310", VA = "0x181620710", Slot = "9")]
			public override void OnDispose()
			{
			}

			// Token: 0x0601CA64 RID: 117348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA64")]
			[Address(RVA = "0x1621220", Offset = "0x161FE20", VA = "0x181621220")]
			public ConfigNode()
			{
			}

			// Token: 0x0601CA65 RID: 117349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA65")]
			[Address(RVA = "0x1620860", Offset = "0x161F460", VA = "0x181620860")]
			private void <>xLuaBaseProxy_OnDispose()
			{
			}

			// Token: 0x040259A2 RID: 154018
			[Token(Token = "0x40259A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private NetworkRouter.ConfigHandler m_networkRouterHandler;

			// Token: 0x040259A3 RID: 154019
			[Token(Token = "0x40259A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private IEnumerator m_fetchRoutine;

			// Token: 0x040259A4 RID: 154020
			[Token(Token = "0x40259A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_type;

			// Token: 0x040259A5 RID: 154021
			[Token(Token = "0x40259A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Work;

			// Token: 0x040259A6 RID: 154022
			[Token(Token = "0x40259A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__FetchConfigsCoroutine;

			// Token: 0x040259A7 RID: 154023
			[Token(Token = "0x40259A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__FetchNetworkConfigRoutine;

			// Token: 0x040259A8 RID: 154024
			[Token(Token = "0x40259A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__FetchNetworkConfigFromGameConfig;

			// Token: 0x040259A9 RID: 154025
			[Token(Token = "0x40259A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__FetchSetAuditModeRoutine;

			// Token: 0x040259AA RID: 154026
			[Token(Token = "0x40259AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__FetchRemoteConfigRoutine;

			// Token: 0x040259AB RID: 154027
			[Token(Token = "0x40259AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__FetchResVersionRoutine;

			// Token: 0x040259AC RID: 154028
			[Token(Token = "0x40259AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__MakeNotOverrideRouterForClientUpgrade;

			// Token: 0x040259AD RID: 154029
			[Token(Token = "0x40259AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__ValidateClientVersion;

			// Token: 0x040259AE RID: 154030
			[Token(Token = "0x40259AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_OnDispose;

			// Token: 0x040259AF RID: 154031
			[Token(Token = "0x40259AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A7A RID: 19066
		[Token(Token = "0x2004A7A")]
		private class ReadyToLoginNode : HotUpdateWorkflow.Node
		{
			// Token: 0x1700439B RID: 17307
			// (get) Token: 0x0601CA84 RID: 117380 RVA: 0x000A8F78 File Offset: 0x000A7178
			[Token(Token = "0x1700439B")]
			public override HotUpdateWorkflow.ENode type
			{
				[Token(Token = "0x601CA84")]
				[Address(RVA = "0x16301C0", Offset = "0x162EDC0", VA = "0x1816301C0", Slot = "4")]
				get
				{
					return HotUpdateWorkflow.ENode.NONE;
				}
			}

			// Token: 0x0601CA85 RID: 117381 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA85")]
			[Address(RVA = "0x162FA40", Offset = "0x162E640", VA = "0x18162FA40", Slot = "5")]
			public override CustomYieldInstruction Work()
			{
				return null;
			}

			// Token: 0x0601CA86 RID: 117382 RVA: 0x000A8F90 File Offset: 0x000A7190
			[Token(Token = "0x601CA86")]
			[Address(RVA = "0x162F940", Offset = "0x162E540", VA = "0x18162F940", Slot = "10")]
			public override bool OnEvent(ViewEvent evt, ValueBundle param)
			{
				return default(bool);
			}

			// Token: 0x0601CA87 RID: 117383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA87")]
			[Address(RVA = "0x162FC30", Offset = "0x162E830", VA = "0x18162FC30")]
			private void _InitVoicePrefIfNecessary()
			{
			}

			// Token: 0x0601CA88 RID: 117384 RVA: 0x000A8FA8 File Offset: 0x000A71A8
			[Token(Token = "0x601CA88")]
			[Address(RVA = "0x162FDF0", Offset = "0x162E9F0", VA = "0x18162FDF0")]
			private bool _ShowVoicePrefSelectPanelIfNecessary()
			{
				return default(bool);
			}

			// Token: 0x0601CA89 RID: 117385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA89")]
			[Address(RVA = "0x1630120", Offset = "0x162ED20", VA = "0x181630120")]
			public ReadyToLoginNode()
			{
			}

			// Token: 0x0601CA8B RID: 117387 RVA: 0x000A8FD8 File Offset: 0x000A71D8
			[Token(Token = "0x601CA8B")]
			[Address(RVA = "0x162F620", Offset = "0x162E220", VA = "0x18162F620")]
			private bool <>xLuaBaseProxy_OnEvent(ViewEvent P0, ValueBundle P1)
			{
				return default(bool);
			}

			// Token: 0x040259C4 RID: 154052
			[Token(Token = "0x40259C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool m_isVoicePrefReady;

			// Token: 0x040259C5 RID: 154053
			[Token(Token = "0x40259C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			private bool m_isBtnEnterClicked;

			// Token: 0x040259C6 RID: 154054
			[Token(Token = "0x40259C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private HotUpdateVoicePrefView.Controller m_voicePrefController;

			// Token: 0x040259C7 RID: 154055
			[Token(Token = "0x40259C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_type;

			// Token: 0x040259C8 RID: 154056
			[Token(Token = "0x40259C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Work;

			// Token: 0x040259C9 RID: 154057
			[Token(Token = "0x40259C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnEvent;

			// Token: 0x040259CA RID: 154058
			[Token(Token = "0x40259CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__InitVoicePrefIfNecessary;

			// Token: 0x040259CB RID: 154059
			[Token(Token = "0x40259CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__ShowVoicePrefSelectPanelIfNecessary;

			// Token: 0x040259CC RID: 154060
			[Token(Token = "0x40259CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004A7B RID: 19067
		[Token(Token = "0x2004A7B")]
		private class FinishNode : HotUpdateWorkflow.Node
		{
			// Token: 0x1700439C RID: 17308
			// (get) Token: 0x0601CA8C RID: 117388 RVA: 0x000A8FF0 File Offset: 0x000A71F0
			[Token(Token = "0x1700439C")]
			public override HotUpdateWorkflow.ENode type
			{
				[Token(Token = "0x601CA8C")]
				[Address(RVA = "0x1621970", Offset = "0x1620570", VA = "0x181621970", Slot = "4")]
				get
				{
					return HotUpdateWorkflow.ENode.NONE;
				}
			}

			// Token: 0x0601CA8D RID: 117389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CA8D")]
			[Address(RVA = "0x16217D0", Offset = "0x16203D0", VA = "0x1816217D0", Slot = "5")]
			public override CustomYieldInstruction Work()
			{
				return null;
			}

			// Token: 0x0601CA8E RID: 117390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CA8E")]
			[Address(RVA = "0x16218D0", Offset = "0x16204D0", VA = "0x1816218D0")]
			public FinishNode()
			{
			}

			// Token: 0x040259CD RID: 154061
			[Token(Token = "0x40259CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_type;

			// Token: 0x040259CE RID: 154062
			[Token(Token = "0x40259CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Work;

			// Token: 0x040259CF RID: 154063
			[Token(Token = "0x40259CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
