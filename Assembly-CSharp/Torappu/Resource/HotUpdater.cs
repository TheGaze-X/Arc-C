using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using Torappu.Network;
using Torappu.Resource.HGDownload;
using Torappu.UI.HotUpdate;
using UnityEngine;
using XLua;

namespace Torappu.Resource
{
	// Token: 0x0200170B RID: 5899
	[Token(Token = "0x200170B")]
	public class HotUpdater : MonoBehaviour, ITimeWatcher, IHotfixable
	{
		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x0600950C RID: 38156 RVA: 0x0003A2C0 File Offset: 0x000384C0
		[Token(Token = "0x17000FEE")]
		public static bool ENABLED
		{
			[Token(Token = "0x600950C")]
			[Address(RVA = "0x31115C0", Offset = "0x31101C0", VA = "0x1831115C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600950D RID: 38157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600950D")]
		[Address(RVA = "0x310A120", Offset = "0x3108D20", VA = "0x18310A120")]
		private void Start()
		{
		}

		// Token: 0x0600950E RID: 38158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600950E")]
		[Address(RVA = "0x3109DE0", Offset = "0x31089E0", VA = "0x183109DE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600950F RID: 38159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600950F")]
		[Address(RVA = "0x3109620", Offset = "0x3108220", VA = "0x183109620")]
		public static string GenerateZipNameFromAssetOrBundleName(string inputName)
		{
			return null;
		}

		// Token: 0x06009510 RID: 38160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009510")]
		[Address(RVA = "0x31092D0", Offset = "0x3107ED0", VA = "0x1831092D0")]
		public static void DeletePersistentRes()
		{
		}

		// Token: 0x06009511 RID: 38161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009511")]
		[Address(RVA = "0x3109D60", Offset = "0x3108960", VA = "0x183109D60")]
		public static void MarkUpdateResInvalid()
		{
		}

		// Token: 0x06009512 RID: 38162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009512")]
		[Address(RVA = "0x3109820", Offset = "0x3108420", VA = "0x183109820")]
		public void InterruptDownload(Action<bool> cb)
		{
		}

		// Token: 0x06009513 RID: 38163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009513")]
		[Address(RVA = "0x3109C40", Offset = "0x3108840", VA = "0x183109C40")]
		public static HotUpdateInfo LoadLocalUpdateInfo()
		{
			return null;
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009514")]
		[Address(RVA = "0x3109CA0", Offset = "0x31088A0", VA = "0x183109CA0")]
		public static void MarkUpdateResInvalidNoThrow()
		{
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06009515 RID: 38165 RVA: 0x0003A2D8 File Offset: 0x000384D8
		// (set) Token: 0x06009516 RID: 38166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FEF")]
		public static HotUpdater.VersionInfo onlineVersionInfo
		{
			[Token(Token = "0x6009515")]
			[Address(RVA = "0x3111610", Offset = "0x3110210", VA = "0x183111610")]
			[CompilerGenerated]
			get
			{
				return default(HotUpdater.VersionInfo);
			}
			[Token(Token = "0x6009516")]
			[Address(RVA = "0x31116E0", Offset = "0x31102E0", VA = "0x1831116E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06009517 RID: 38167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009517")]
		[Address(RVA = "0x3109220", Offset = "0x3107E20", VA = "0x183109220")]
		public static void ConfirmOnlineVersionInfo(HotUpdater.VersionInfo info)
		{
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06009518 RID: 38168 RVA: 0x0003A2F0 File Offset: 0x000384F0
		// (set) Token: 0x06009519 RID: 38169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FF0")]
		public HotUpdater.UpdateState updateState
		{
			[Token(Token = "0x6009518")]
			[Address(RVA = "0x3111680", Offset = "0x3110280", VA = "0x183111680")]
			get
			{
				return HotUpdater.UpdateState.NONE;
			}
			[Token(Token = "0x6009519")]
			[Address(RVA = "0x3111760", Offset = "0x3110360", VA = "0x183111760")]
			private set
			{
			}
		}

		// Token: 0x0600951A RID: 38170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600951A")]
		[Address(RVA = "0x3109EA0", Offset = "0x3108AA0", VA = "0x183109EA0")]
		public void StartHotUpdate(HotUpdater.Options options)
		{
		}

		// Token: 0x0600951B RID: 38171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600951B")]
		[Address(RVA = "0x310E370", Offset = "0x310CF70", VA = "0x18310E370")]
		private IEnumerator _InitSDKCoroutine(Action nextStep)
		{
			return null;
		}

		// Token: 0x0600951C RID: 38172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600951C")]
		[Address(RVA = "0x310A280", Offset = "0x3108E80", VA = "0x18310A280", Slot = "4")]
		public void UpdateTime(float timeDetla)
		{
		}

		// Token: 0x0600951D RID: 38173 RVA: 0x0003A308 File Offset: 0x00038508
		[Token(Token = "0x600951D")]
		[Address(RVA = "0x3109110", Offset = "0x3107D10", VA = "0x183109110")]
		public bool CanInterrupt()
		{
			return default(bool);
		}

		// Token: 0x0600951E RID: 38174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600951E")]
		[Address(RVA = "0x310FBF0", Offset = "0x310E7F0", VA = "0x18310FBF0")]
		private void _OnUpdateInfoDownloaded(FileDownloader.Options options, bool isSuc)
		{
		}

		// Token: 0x0600951F RID: 38175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600951F")]
		[Address(RVA = "0x310ED30", Offset = "0x310D930", VA = "0x18310ED30")]
		private void _OnNewUpdateInfoAchieved(HotUpdateInfo updateInfo)
		{
		}

		// Token: 0x06009520 RID: 38176 RVA: 0x0003A320 File Offset: 0x00038520
		[Token(Token = "0x6009520")]
		[Address(RVA = "0x31112A0", Offset = "0x310FEA0", VA = "0x1831112A0")]
		private static bool _UsePCFullResourceMode()
		{
			return default(bool);
		}

		// Token: 0x06009521 RID: 38177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009521")]
		[Address(RVA = "0x310DEE0", Offset = "0x310CAE0", VA = "0x18310DEE0")]
		private void _HandleResOnFullResource(HotUpdateInfo updateInfo, HotUpdater.CalcResult calcResult)
		{
		}

		// Token: 0x06009522 RID: 38178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009522")]
		[Address(RVA = "0x310DFD0", Offset = "0x310CBD0", VA = "0x18310DFD0")]
		private void _HandleResSelection(HotUpdateInfo updateInfo, HotUpdater.CalcResult calcResult)
		{
		}

		// Token: 0x06009523 RID: 38179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009523")]
		[Address(RVA = "0x310EBD0", Offset = "0x310D7D0", VA = "0x18310EBD0")]
		private void _OnExtraResPrefSelected(HotUpdateInfo updateInfo, HotUpdater.CalcResult calcResult, bool isFull)
		{
		}

		// Token: 0x06009524 RID: 38180 RVA: 0x0003A338 File Offset: 0x00038538
		[Token(Token = "0x6009524")]
		[Address(RVA = "0x310C170", Offset = "0x310AD70", VA = "0x18310C170")]
		private static bool _CheckIfShowVoiceResPrefDialog(HotUpdater.CalcResult calcResult)
		{
			return default(bool);
		}

		// Token: 0x06009525 RID: 38181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009525")]
		[Address(RVA = "0x31105C0", Offset = "0x310F1C0", VA = "0x1831105C0")]
		private void _TryShowVoiceResPrefDialog(HotUpdater.CalcResult calcResult, Action nextStep)
		{
		}

		// Token: 0x06009526 RID: 38182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009526")]
		[Address(RVA = "0x310CED0", Offset = "0x310BAD0", VA = "0x18310CED0")]
		private HotUpdater.DownloadInterface _EnsureDownloadInterface()
		{
			return null;
		}

		// Token: 0x06009527 RID: 38183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009527")]
		[Address(RVA = "0x310F110", Offset = "0x310DD10", VA = "0x18310F110")]
		private void _OnPreferenceStepFinished(HotUpdateInfo updateInfo, HotUpdater.CalcResult calcResult, HotUpdater.ResPrefContext prefContext)
		{
		}

		// Token: 0x06009528 RID: 38184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009528")]
		[Address(RVA = "0x310D620", Offset = "0x310C220", VA = "0x18310D620")]
		private static void _FillUpdateListWithCalcResult(HotUpdater.CalcResult calcResult, HotUpdater.ResPrefContext prefContext, out List<HotUpdateInfo.ABInfo> updateResList, out List<HotUpdateInfo.ABInfo> removeResList)
		{
		}

		// Token: 0x06009529 RID: 38185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009529")]
		[Address(RVA = "0x310E960", Offset = "0x310D560", VA = "0x18310E960")]
		private void _OnDownloadAllowed(HotUpdateInfo updateInfo, List<HotUpdateInfo.ABInfo> downloadResList)
		{
		}

		// Token: 0x0600952A RID: 38186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600952A")]
		[Address(RVA = "0x310E850", Offset = "0x310D450", VA = "0x18310E850")]
		private void _OnABDownloadSizeChange(long curSize, long totalSize)
		{
		}

		// Token: 0x0600952B RID: 38187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600952B")]
		[Address(RVA = "0x310EF90", Offset = "0x310DB90", VA = "0x18310EF90")]
		private void _OnPausedByMobileDataPolicy(long remainDownloadSize)
		{
		}

		// Token: 0x0600952C RID: 38188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600952C")]
		[Address(RVA = "0x310E5E0", Offset = "0x310D1E0", VA = "0x18310E5E0")]
		private void _OnABDownloadError(HotUpdater.DownloadInterface.DownloadError errorInfo)
		{
		}

		// Token: 0x0600952D RID: 38189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600952D")]
		[Address(RVA = "0x310FA60", Offset = "0x310E660", VA = "0x18310FA60")]
		private void _OnResourceDownloadFinish()
		{
		}

		// Token: 0x0600952E RID: 38190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600952E")]
		[Address(RVA = "0x310E8F0", Offset = "0x310D4F0", VA = "0x18310E8F0")]
		private void _OnConfirmError()
		{
		}

		// Token: 0x0600952F RID: 38191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600952F")]
		[Address(RVA = "0x310FB80", Offset = "0x310E780", VA = "0x18310FB80")]
		private void _OnTrivialError()
		{
		}

		// Token: 0x06009530 RID: 38192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009530")]
		[Address(RVA = "0x31093F0", Offset = "0x3107FF0", VA = "0x1831093F0")]
		public static string GenerateVersionFileUrl()
		{
			return null;
		}

		// Token: 0x06009531 RID: 38193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009531")]
		[Address(RVA = "0x310DA40", Offset = "0x310C640", VA = "0x18310DA40")]
		private static string _GenAssetsFolderUrl(string versionId, string lastUrlPart)
		{
			return null;
		}

		// Token: 0x06009532 RID: 38194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009532")]
		[Address(RVA = "0x310DD80", Offset = "0x310C980", VA = "0x18310DD80")]
		private static string _GenUpdateInfoUrl(string versionId)
		{
			return null;
		}

		// Token: 0x06009533 RID: 38195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009533")]
		[Address(RVA = "0x3109730", Offset = "0x3108330", VA = "0x183109730")]
		public static string GetUpdateInfoPath()
		{
			return null;
		}

		// Token: 0x06009534 RID: 38196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009534")]
		[Address(RVA = "0x310DDF0", Offset = "0x310C9F0", VA = "0x18310DDF0")]
		private static string _GetUpdateInfoCachePath()
		{
			return null;
		}

		// Token: 0x06009535 RID: 38197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009535")]
		[Address(RVA = "0x310DD00", Offset = "0x310C900", VA = "0x18310DD00")]
		private static string _GenResZipUrl(string resName, string versionId)
		{
			return null;
		}

		// Token: 0x06009536 RID: 38198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009536")]
		[Address(RVA = "0x310E440", Offset = "0x310D040", VA = "0x18310E440")]
		private static HotUpdateInfo _LoadUpdateInfoFromFile(string path, HotUpdateInfo.Source source)
		{
			return null;
		}

		// Token: 0x06009537 RID: 38199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009537")]
		[Address(RVA = "0x3111370", Offset = "0x310FF70", VA = "0x183111370")]
		private IEnumerator _WaitForResourceUpdateStop(Action<bool> cb)
		{
			return null;
		}

		// Token: 0x06009538 RID: 38200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009538")]
		[Address(RVA = "0x31104D0", Offset = "0x310F0D0", VA = "0x1831104D0")]
		private void _StopBackgroundTasks()
		{
		}

		// Token: 0x06009539 RID: 38201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009539")]
		[Address(RVA = "0x310D990", Offset = "0x310C590", VA = "0x18310D990")]
		private IEnumerator _FinishResourceUpdate()
		{
			return null;
		}

		// Token: 0x0600953A RID: 38202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600953A")]
		[Address(RVA = "0x310C330", Offset = "0x310AF30", VA = "0x18310C330")]
		private void _CompleteCurrentHotUpdate(bool hasNothingChanged)
		{
		}

		// Token: 0x0600953B RID: 38203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600953B")]
		[Address(RVA = "0x310FDE0", Offset = "0x310E9E0", VA = "0x18310FDE0")]
		private void _OverwriteHotUpdateInfoWithCache()
		{
		}

		// Token: 0x0600953C RID: 38204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600953C")]
		[Address(RVA = "0x310C650", Offset = "0x310B250", VA = "0x18310C650")]
		private void _DeleteLocalPersistentResInfoNoThrow()
		{
		}

		// Token: 0x0600953D RID: 38205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600953D")]
		[Address(RVA = "0x310C700", Offset = "0x310B300", VA = "0x18310C700")]
		private static void _DeleteUnusedFiles(PersistentResInfo persistentResInfo, List<HotUpdateInfo.ABInfo> removeResList)
		{
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600953E")]
		[Address(RVA = "0x310AF90", Offset = "0x3109B90", VA = "0x18310AF90")]
		private static HotUpdater.CalcResult _CalcUpdateResParams(HotUpdateInfo newUpdateInfo, PersistentResInfo persistentResInfo, HotUpdater.DownloadPartEnum downloadPart)
		{
			return null;
		}

		// Token: 0x0600953F RID: 38207 RVA: 0x0003A350 File Offset: 0x00038550
		[Token(Token = "0x600953F")]
		[Address(RVA = "0x31103B0", Offset = "0x310EFB0", VA = "0x1831103B0")]
		private static bool _ResCategoryMatched(ResLifetimeCategory category, HotUpdater.DownloadPartEnum downloadPart)
		{
			return default(bool);
		}

		// Token: 0x06009540 RID: 38208 RVA: 0x0003A368 File Offset: 0x00038568
		[Token(Token = "0x6009540")]
		[Address(RVA = "0x310BEC0", Offset = "0x310AAC0", VA = "0x18310BEC0")]
		private static bool _CheckIfAssetDirty(HotUpdateInfo.ABInfo abInfo, Dictionary<string, string> oldHashMap, Dictionary<string, string> oldMD5Map, Dictionary<string, string> oldTypeMap)
		{
			return default(bool);
		}

		// Token: 0x06009541 RID: 38209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009541")]
		[Address(RVA = "0x310C9F0", Offset = "0x310B5F0", VA = "0x18310C9F0")]
		private static void _DoLargePackExtension(HotUpdateInfo hotupdateInfo, HotUpdater.CalcResult calcRet)
		{
		}

		// Token: 0x06009542 RID: 38210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009542")]
		[Address(RVA = "0x3110890", Offset = "0x310F490", VA = "0x183110890")]
		private static void _TryUseLargePackForList(Dictionary<string, HotUpdater.PackWrapper> packMap, List<HotUpdateInfo.ABInfo> updateList, Dictionary<string, HotUpdater.PackWrapper> packsToDownload, out long downloadSize)
		{
		}

		// Token: 0x06009543 RID: 38211 RVA: 0x0003A380 File Offset: 0x00038580
		[Token(Token = "0x6009543")]
		[Address(RVA = "0x310C080", Offset = "0x310AC80", VA = "0x18310C080")]
		private static bool _CheckIfShowPreferencePanel(HotUpdater.CalcResult calcRet)
		{
			return default(bool);
		}

		// Token: 0x06009544 RID: 38212 RVA: 0x0003A398 File Offset: 0x00038598
		[Token(Token = "0x6009544")]
		[Address(RVA = "0x310AD20", Offset = "0x3109920", VA = "0x18310AD20")]
		private static long _CalcResListDownloadSize(IList<HotUpdateInfo.ABInfo> updateResList)
		{
			return 0L;
		}

		// Token: 0x06009545 RID: 38213 RVA: 0x0003A3B0 File Offset: 0x000385B0
		[Token(Token = "0x6009545")]
		[Address(RVA = "0x310A520", Offset = "0x3109120", VA = "0x18310A520")]
		private static bool _CalcAndStoreNewPersistentResInfoToCacheFolder(HotUpdateInfo hotUpdateInfo, PersistentResInfo oldPersistentInfo, List<HotUpdateInfo.ABInfo> updateResList, List<HotUpdateInfo.ABInfo> removeResList, Dictionary<string, HotUpdateInfo.ABInfo> updatedABInfos)
		{
			return default(bool);
		}

		// Token: 0x06009546 RID: 38214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009546")]
		[Address(RVA = "0x3110440", Offset = "0x310F040", VA = "0x183110440")]
		private void _SetUnzipProgress(float progress)
		{
		}

		// Token: 0x06009547 RID: 38215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009547")]
		[Address(RVA = "0x31100A0", Offset = "0x310ECA0", VA = "0x1831100A0")]
		private void _QuitGame()
		{
		}

		// Token: 0x06009548 RID: 38216 RVA: 0x0003A3C8 File Offset: 0x000385C8
		[Token(Token = "0x6009548")]
		[Address(RVA = "0x310C2D0", Offset = "0x310AED0", VA = "0x18310C2D0")]
		private bool _CheckIfToRecoverPersistResInfo()
		{
			return default(bool);
		}

		// Token: 0x06009549 RID: 38217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009549")]
		[Address(RVA = "0x3110120", Offset = "0x310ED20", VA = "0x183110120")]
		private void _RecoverPersistResInfoImpl(Action nextStep)
		{
		}

		// Token: 0x0600954A RID: 38218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600954A")]
		[Address(RVA = "0x310D320", Offset = "0x310BF20", VA = "0x18310D320")]
		private void _FetchVersion()
		{
		}

		// Token: 0x0600954B RID: 38219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600954B")]
		[Address(RVA = "0x3111130", Offset = "0x310FD30", VA = "0x183111130")]
		private void _UpdateWithVersion(string newVersion, HotUpdateInfo localUpdateInfo)
		{
		}

		// Token: 0x0600954C RID: 38220 RVA: 0x0003A3E0 File Offset: 0x000385E0
		[Token(Token = "0x600954C")]
		[Address(RVA = "0x310FE90", Offset = "0x310EA90", VA = "0x18310FE90")]
		private bool _PrepareResCacheDirectory(string newVersion, out HotUpdateInfo validInfoInResCache)
		{
			return default(bool);
		}

		// Token: 0x0600954D RID: 38221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600954D")]
		[Address(RVA = "0x3110D50", Offset = "0x310F950", VA = "0x183110D50")]
		private void _UpdateHotUpdateInfo(string versionId, Action<HotUpdateInfo> callback)
		{
		}

		// Token: 0x0600954E RID: 38222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600954E")]
		[Address(RVA = "0x310A460", Offset = "0x3109060", VA = "0x18310A460")]
		private void _AlertNetworkError(string errorInfo, Action nextStep)
		{
		}

		// Token: 0x0600954F RID: 38223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600954F")]
		[Address(RVA = "0x3109AD0", Offset = "0x31086D0", VA = "0x183109AD0")]
		public static HotUpdater.LocalResStatus LoadLocalResStatus(PersistentResInfo persistResInfo)
		{
			return null;
		}

		// Token: 0x06009550 RID: 38224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009550")]
		[Address(RVA = "0x310D170", Offset = "0x310BD70", VA = "0x18310D170")]
		private HotUpdater.NetUsagePolicy _EnsureNetUsagePolicy()
		{
			return null;
		}

		// Token: 0x06009551 RID: 38225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009551")]
		[Address(RVA = "0x3111440", Offset = "0x3110040", VA = "0x183111440")]
		public HotUpdater()
		{
		}

		// Token: 0x04008B2D RID: 35629
		[Token(Token = "0x4008B2D")]
		private const float PERCENT_THRESHOLD_TO_DOWNLOAD_LARGE_PACK = 0.8f;

		// Token: 0x04008B2E RID: 35630
		[Token(Token = "0x4008B2E")]
		public const long MIN_BYTES_SIZE_TO_NOTIFY_IF_NOT_WIFI = 104857600L;

		// Token: 0x04008B2F RID: 35631
		[Token(Token = "0x4008B2F")]
		private const float MIN_DELTA_OF_TRIVIAL_ERROR = 5f;

		// Token: 0x04008B30 RID: 35632
		[Token(Token = "0x4008B30")]
		[FieldOffset(Offset = "0x18")]
		private HotUpdater.Options m_options;

		// Token: 0x04008B31 RID: 35633
		[Token(Token = "0x4008B31")]
		[FieldOffset(Offset = "0x60")]
		private HotUpdater.UpdateState m_updateState;

		// Token: 0x04008B32 RID: 35634
		[Token(Token = "0x4008B32")]
		[FieldOffset(Offset = "0x68")]
		private PersistentResRecover m_persistResRecover;

		// Token: 0x04008B33 RID: 35635
		[Token(Token = "0x4008B33")]
		[FieldOffset(Offset = "0x70")]
		private Queue<FileDownloader.IDownloadMessage> m_updateInfoQueue;

		// Token: 0x04008B34 RID: 35636
		[Token(Token = "0x4008B34")]
		[FieldOffset(Offset = "0x78")]
		private HotUpdateInfo m_newUpdateInfoCache;

		// Token: 0x04008B35 RID: 35637
		[Token(Token = "0x4008B35")]
		[FieldOffset(Offset = "0x80")]
		private Action<HotUpdateInfo> m_onFinishUpdateHotInfo;

		// Token: 0x04008B36 RID: 35638
		[Token(Token = "0x4008B36")]
		[FieldOffset(Offset = "0x88")]
		private List<HotUpdateInfo.ABInfo> m_updateResList;

		// Token: 0x04008B37 RID: 35639
		[Token(Token = "0x4008B37")]
		[FieldOffset(Offset = "0x90")]
		private List<HotUpdateInfo.ABInfo> m_removeResList;

		// Token: 0x04008B38 RID: 35640
		[Token(Token = "0x4008B38")]
		[FieldOffset(Offset = "0x98")]
		private int m_countOfTypedResInUpdateList;

		// Token: 0x04008B39 RID: 35641
		[Token(Token = "0x4008B39")]
		[FieldOffset(Offset = "0xA0")]
		private FileDownloader m_updateInfoDownloader;

		// Token: 0x04008B3A RID: 35642
		[Token(Token = "0x4008B3A")]
		[FieldOffset(Offset = "0xA8")]
		private HotUpdater.DownloadInterface m_downloadInterface;

		// Token: 0x04008B3B RID: 35643
		[Token(Token = "0x4008B3B")]
		[FieldOffset(Offset = "0xB0")]
		private float m_startTime;

		// Token: 0x04008B3C RID: 35644
		[Token(Token = "0x4008B3C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIHotUpdatePreferencePanel _hotupdatePrefPanel;

		// Token: 0x04008B3E RID: 35646
		[Token(Token = "0x4008B3E")]
		[FieldOffset(Offset = "0xC0")]
		private Coroutine m_initSDKCoroutine;

		// Token: 0x04008B3F RID: 35647
		[Token(Token = "0x4008B3F")]
		[FieldOffset(Offset = "0x10")]
		private static string s_updateInfoPath;

		// Token: 0x04008B40 RID: 35648
		[Token(Token = "0x4008B40")]
		[FieldOffset(Offset = "0x18")]
		private static string s_updateInfoPathInCacheDir;

		// Token: 0x04008B41 RID: 35649
		[Token(Token = "0x4008B41")]
		[FieldOffset(Offset = "0xC8")]
		private HotUpdater.NetUsagePolicy m_nullableNetUsagePolicy;

		// Token: 0x04008B42 RID: 35650
		[Token(Token = "0x4008B42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ENABLED;

		// Token: 0x04008B43 RID: 35651
		[Token(Token = "0x4008B43")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04008B44 RID: 35652
		[Token(Token = "0x4008B44")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04008B45 RID: 35653
		[Token(Token = "0x4008B45")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GenerateZipNameFromAssetOrBundleName;

		// Token: 0x04008B46 RID: 35654
		[Token(Token = "0x4008B46")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DeletePersistentRes;

		// Token: 0x04008B47 RID: 35655
		[Token(Token = "0x4008B47")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_MarkUpdateResInvalid;

		// Token: 0x04008B48 RID: 35656
		[Token(Token = "0x4008B48")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_InterruptDownload;

		// Token: 0x04008B49 RID: 35657
		[Token(Token = "0x4008B49")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadLocalUpdateInfo;

		// Token: 0x04008B4A RID: 35658
		[Token(Token = "0x4008B4A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_MarkUpdateResInvalidNoThrow;

		// Token: 0x04008B4B RID: 35659
		[Token(Token = "0x4008B4B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_onlineVersionInfo;

		// Token: 0x04008B4C RID: 35660
		[Token(Token = "0x4008B4C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_onlineVersionInfo;

		// Token: 0x04008B4D RID: 35661
		[Token(Token = "0x4008B4D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ConfirmOnlineVersionInfo;

		// Token: 0x04008B4E RID: 35662
		[Token(Token = "0x4008B4E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_updateState;

		// Token: 0x04008B4F RID: 35663
		[Token(Token = "0x4008B4F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_updateState;

		// Token: 0x04008B50 RID: 35664
		[Token(Token = "0x4008B50")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_StartHotUpdate;

		// Token: 0x04008B51 RID: 35665
		[Token(Token = "0x4008B51")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__InitSDKCoroutine;

		// Token: 0x04008B52 RID: 35666
		[Token(Token = "0x4008B52")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x04008B53 RID: 35667
		[Token(Token = "0x4008B53")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CanInterrupt;

		// Token: 0x04008B54 RID: 35668
		[Token(Token = "0x4008B54")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnUpdateInfoDownloaded;

		// Token: 0x04008B55 RID: 35669
		[Token(Token = "0x4008B55")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnNewUpdateInfoAchieved;

		// Token: 0x04008B56 RID: 35670
		[Token(Token = "0x4008B56")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UsePCFullResourceMode;

		// Token: 0x04008B57 RID: 35671
		[Token(Token = "0x4008B57")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__HandleResOnFullResource;

		// Token: 0x04008B58 RID: 35672
		[Token(Token = "0x4008B58")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__HandleResSelection;

		// Token: 0x04008B59 RID: 35673
		[Token(Token = "0x4008B59")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnExtraResPrefSelected;

		// Token: 0x04008B5A RID: 35674
		[Token(Token = "0x4008B5A")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CheckIfShowVoiceResPrefDialog;

		// Token: 0x04008B5B RID: 35675
		[Token(Token = "0x4008B5B")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__TryShowVoiceResPrefDialog;

		// Token: 0x04008B5C RID: 35676
		[Token(Token = "0x4008B5C")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__EnsureDownloadInterface;

		// Token: 0x04008B5D RID: 35677
		[Token(Token = "0x4008B5D")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnPreferenceStepFinished;

		// Token: 0x04008B5E RID: 35678
		[Token(Token = "0x4008B5E")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__FillUpdateListWithCalcResult;

		// Token: 0x04008B5F RID: 35679
		[Token(Token = "0x4008B5F")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnDownloadAllowed;

		// Token: 0x04008B60 RID: 35680
		[Token(Token = "0x4008B60")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__OnABDownloadSizeChange;

		// Token: 0x04008B61 RID: 35681
		[Token(Token = "0x4008B61")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OnPausedByMobileDataPolicy;

		// Token: 0x04008B62 RID: 35682
		[Token(Token = "0x4008B62")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__OnABDownloadError;

		// Token: 0x04008B63 RID: 35683
		[Token(Token = "0x4008B63")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__OnResourceDownloadFinish;

		// Token: 0x04008B64 RID: 35684
		[Token(Token = "0x4008B64")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__OnConfirmError;

		// Token: 0x04008B65 RID: 35685
		[Token(Token = "0x4008B65")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__OnTrivialError;

		// Token: 0x04008B66 RID: 35686
		[Token(Token = "0x4008B66")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GenerateVersionFileUrl;

		// Token: 0x04008B67 RID: 35687
		[Token(Token = "0x4008B67")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__GenAssetsFolderUrl;

		// Token: 0x04008B68 RID: 35688
		[Token(Token = "0x4008B68")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__GenUpdateInfoUrl;

		// Token: 0x04008B69 RID: 35689
		[Token(Token = "0x4008B69")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_GetUpdateInfoPath;

		// Token: 0x04008B6A RID: 35690
		[Token(Token = "0x4008B6A")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__GetUpdateInfoCachePath;

		// Token: 0x04008B6B RID: 35691
		[Token(Token = "0x4008B6B")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__GenResZipUrl;

		// Token: 0x04008B6C RID: 35692
		[Token(Token = "0x4008B6C")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__LoadUpdateInfoFromFile;

		// Token: 0x04008B6D RID: 35693
		[Token(Token = "0x4008B6D")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__WaitForResourceUpdateStop;

		// Token: 0x04008B6E RID: 35694
		[Token(Token = "0x4008B6E")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__StopBackgroundTasks;

		// Token: 0x04008B6F RID: 35695
		[Token(Token = "0x4008B6F")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__FinishResourceUpdate;

		// Token: 0x04008B70 RID: 35696
		[Token(Token = "0x4008B70")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__CompleteCurrentHotUpdate;

		// Token: 0x04008B71 RID: 35697
		[Token(Token = "0x4008B71")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__OverwriteHotUpdateInfoWithCache;

		// Token: 0x04008B72 RID: 35698
		[Token(Token = "0x4008B72")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__DeleteLocalPersistentResInfoNoThrow;

		// Token: 0x04008B73 RID: 35699
		[Token(Token = "0x4008B73")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__DeleteUnusedFiles;

		// Token: 0x04008B74 RID: 35700
		[Token(Token = "0x4008B74")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__CalcUpdateResParams;

		// Token: 0x04008B75 RID: 35701
		[Token(Token = "0x4008B75")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__ResCategoryMatched;

		// Token: 0x04008B76 RID: 35702
		[Token(Token = "0x4008B76")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__CheckIfAssetDirty;

		// Token: 0x04008B77 RID: 35703
		[Token(Token = "0x4008B77")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__DoLargePackExtension;

		// Token: 0x04008B78 RID: 35704
		[Token(Token = "0x4008B78")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__TryUseLargePackForList;

		// Token: 0x04008B79 RID: 35705
		[Token(Token = "0x4008B79")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__CheckIfShowPreferencePanel;

		// Token: 0x04008B7A RID: 35706
		[Token(Token = "0x4008B7A")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__CalcResListDownloadSize;

		// Token: 0x04008B7B RID: 35707
		[Token(Token = "0x4008B7B")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__CalcAndStoreNewPersistentResInfoToCacheFolder;

		// Token: 0x04008B7C RID: 35708
		[Token(Token = "0x4008B7C")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__SetUnzipProgress;

		// Token: 0x04008B7D RID: 35709
		[Token(Token = "0x4008B7D")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__QuitGame;

		// Token: 0x04008B7E RID: 35710
		[Token(Token = "0x4008B7E")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__CheckIfToRecoverPersistResInfo;

		// Token: 0x04008B7F RID: 35711
		[Token(Token = "0x4008B7F")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__RecoverPersistResInfoImpl;

		// Token: 0x04008B80 RID: 35712
		[Token(Token = "0x4008B80")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__FetchVersion;

		// Token: 0x04008B81 RID: 35713
		[Token(Token = "0x4008B81")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__UpdateWithVersion;

		// Token: 0x04008B82 RID: 35714
		[Token(Token = "0x4008B82")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__PrepareResCacheDirectory;

		// Token: 0x04008B83 RID: 35715
		[Token(Token = "0x4008B83")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__UpdateHotUpdateInfo;

		// Token: 0x04008B84 RID: 35716
		[Token(Token = "0x4008B84")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__AlertNetworkError;

		// Token: 0x04008B85 RID: 35717
		[Token(Token = "0x4008B85")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_LoadLocalResStatus;

		// Token: 0x04008B86 RID: 35718
		[Token(Token = "0x4008B86")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0__EnsureNetUsagePolicy;

		// Token: 0x04008B87 RID: 35719
		[Token(Token = "0x4008B87")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200170C RID: 5900
		[Token(Token = "0x200170C")]
		private class HGDownloadAdapter : HGDownloader.Adapter
		{
			// Token: 0x06009553 RID: 38227 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009553")]
			[Address(RVA = "0x31066D0", Offset = "0x31052D0", VA = "0x1831066D0", Slot = "4")]
			public override string ConfigToJson(HGConfig config)
			{
				return null;
			}

			// Token: 0x06009554 RID: 38228 RVA: 0x0003A3F8 File Offset: 0x000385F8
			[Token(Token = "0x6009554")]
			[Address(RVA = "0x3106A40", Offset = "0x3105640", VA = "0x183106A40", Slot = "7")]
			public override HGDownloadTaskInfo JsonToTaskInfo(string json)
			{
				return default(HGDownloadTaskInfo);
			}

			// Token: 0x06009555 RID: 38229 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009555")]
			[Address(RVA = "0x3106740", Offset = "0x3105340", VA = "0x183106740", Slot = "5")]
			public override string FileListToJson(IList<HGFileInfo> files)
			{
				return null;
			}

			// Token: 0x06009556 RID: 38230 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009556")]
			[Address(RVA = "0x3106920", Offset = "0x3105520", VA = "0x183106920", Slot = "9")]
			public override string GetDecompressFolder()
			{
				return null;
			}

			// Token: 0x06009557 RID: 38231 RVA: 0x0003A410 File Offset: 0x00038610
			[Token(Token = "0x6009557")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
			public override bool NeedDecompress()
			{
				return default(bool);
			}

			// Token: 0x06009558 RID: 38232 RVA: 0x0003A428 File Offset: 0x00038628
			[Token(Token = "0x6009558")]
			[Address(RVA = "0x3106930", Offset = "0x3105530", VA = "0x183106930", Slot = "10")]
			public override HGDownloadLanType GetLanguageType()
			{
				return HGDownloadLanType.CN;
			}

			// Token: 0x06009559 RID: 38233 RVA: 0x0003A440 File Offset: 0x00038640
			[Token(Token = "0x6009559")]
			[Address(RVA = "0x31069C0", Offset = "0x31055C0", VA = "0x1831069C0", Slot = "11")]
			public override HGNotificationTitle GetNotificationTitle()
			{
				return default(HGNotificationTitle);
			}

			// Token: 0x0600955A RID: 38234 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600955A")]
			[Address(RVA = "0x3106BD0", Offset = "0x31057D0", VA = "0x183106BD0", Slot = "6")]
			public override string NotificationTitleToJson(HGNotificationTitle titleConfig)
			{
				return null;
			}

			// Token: 0x0600955B RID: 38235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600955B")]
			[Address(RVA = "0x3106C50", Offset = "0x3105850", VA = "0x183106C50", Slot = "13")]
			public override void OnSDKInternalError(int errorCode)
			{
			}

			// Token: 0x0600955C RID: 38236 RVA: 0x0003A458 File Offset: 0x00038658
			[Token(Token = "0x600955C")]
			[Address(RVA = "0x3106E50", Offset = "0x3105A50", VA = "0x183106E50", Slot = "14")]
			public override bool UsePatchMode(out string patchPath)
			{
				return default(bool);
			}

			// Token: 0x0600955D RID: 38237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600955D")]
			[Address(RVA = "0x3106B80", Offset = "0x3105780", VA = "0x183106B80", Slot = "12")]
			public override void LogError(string errorInfo)
			{
			}

			// Token: 0x0600955E RID: 38238 RVA: 0x0003A470 File Offset: 0x00038670
			[Token(Token = "0x600955E")]
			[Address(RVA = "0x3106EA0", Offset = "0x3105AA0", VA = "0x183106EA0", Slot = "15")]
			public override bool ValidatePause(HGDownloader.PauseReason reason)
			{
				return default(bool);
			}

			// Token: 0x0600955F RID: 38239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600955F")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public HGDownloadAdapter()
			{
			}
		}

		// Token: 0x0200170E RID: 5902
		[Token(Token = "0x200170E")]
		private class HGDownloadInterface : HotUpdater.DownloadInterface
		{
			// Token: 0x06009563 RID: 38243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009563")]
			[Address(RVA = "0x3107FF0", Offset = "0x3106BF0", VA = "0x183107FF0")]
			private HGDownloadInterface(HotUpdater.DownloadOptions options)
			{
			}

			// Token: 0x06009564 RID: 38244 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009564")]
			[Address(RVA = "0x3107090", Offset = "0x3105C90", VA = "0x183107090")]
			public static HotUpdater.HGDownloadInterface DownloadInterfaceOnly_Create(HotUpdater.DownloadOptions options)
			{
				return null;
			}

			// Token: 0x06009565 RID: 38245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009565")]
			[Address(RVA = "0x3106FC0", Offset = "0x3105BC0", VA = "0x183106FC0")]
			public static void CleanWorkspaceIfInited()
			{
			}

			// Token: 0x06009566 RID: 38246 RVA: 0x0003A488 File Offset: 0x00038688
			[Token(Token = "0x6009566")]
			[Address(RVA = "0x3106ED0", Offset = "0x3105AD0", VA = "0x183106ED0", Slot = "7")]
			public override long CalculateTotalDownloadSize(string versionId, IList<HotUpdateInfo.ABInfo> updateResList)
			{
				return 0L;
			}

			// Token: 0x06009567 RID: 38247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009567")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
			public override void ClearUnzipThread()
			{
			}

			// Token: 0x06009568 RID: 38248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009568")]
			[Address(RVA = "0x31071D0", Offset = "0x3105DD0", VA = "0x1831071D0", Slot = "10")]
			protected override void OnDispose()
			{
			}

			// Token: 0x06009569 RID: 38249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009569")]
			[Address(RVA = "0x31071A0", Offset = "0x3105DA0", VA = "0x1831071A0", Slot = "8")]
			public override void InterruptAllDownloading()
			{
			}

			// Token: 0x0600956A RID: 38250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600956A")]
			[Address(RVA = "0x3107200", Offset = "0x3105E00", VA = "0x183107200", Slot = "13")]
			public override void StartDownload(HotUpdater.DownloadInterface.DownloadParam param)
			{
			}

			// Token: 0x0600956B RID: 38251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600956B")]
			[Address(RVA = "0x3107480", Offset = "0x3106080", VA = "0x183107480", Slot = "12")]
			public override void Tick()
			{
			}

			// Token: 0x0600956C RID: 38252 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600956C")]
			[Address(RVA = "0x31074F0", Offset = "0x31060F0", VA = "0x1831074F0", Slot = "9")]
			public override IEnumerator WaitForDownloadingStop()
			{
				return null;
			}

			// Token: 0x0600956D RID: 38253 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600956D")]
			[Address(RVA = "0x3107550", Offset = "0x3106150", VA = "0x183107550", Slot = "5")]
			public override IEnumerator WaitForInitFinish()
			{
				return null;
			}

			// Token: 0x0600956E RID: 38254 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600956E")]
			[Address(RVA = "0x3107000", Offset = "0x3105C00", VA = "0x183107000", Slot = "11")]
			public override HotUpdater.DownloadInterface.IUnzipInterface CreateCurrentUnzipInterface()
			{
				return null;
			}

			// Token: 0x0600956F RID: 38255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600956F")]
			[Address(RVA = "0x3107170", Offset = "0x3105D70", VA = "0x183107170", Slot = "14")]
			public override void EnableMobileData()
			{
			}

			// Token: 0x06009570 RID: 38256 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009570")]
			[Address(RVA = "0x31075B0", Offset = "0x31061B0", VA = "0x1831075B0")]
			private static List<HGFileInfo> _ConvertToHGFiles(string versionId, IList<HotUpdateInfo.ABInfo> abInfoList)
			{
				return null;
			}

			// Token: 0x06009571 RID: 38257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009571")]
			[Address(RVA = "0x3107AE0", Offset = "0x31066E0", VA = "0x183107AE0")]
			private void _CreateEmptyTaskAndApply()
			{
			}

			// Token: 0x06009572 RID: 38258 RVA: 0x0003A4A0 File Offset: 0x000386A0
			[Token(Token = "0x6009572")]
			[Address(RVA = "0x3107970", Offset = "0x3106570", VA = "0x183107970")]
			private HotUpdater.DownloadInterface.UnzipError _CreateCurrentUnzipError(HGRetCodeType type, int errorCode)
			{
				return default(HotUpdater.DownloadInterface.UnzipError);
			}

			// Token: 0x06009573 RID: 38259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6009573")]
			[Address(RVA = "0x3107B50", Offset = "0x3106750", VA = "0x183107B50")]
			private string _CreateErrorAlertFromCode(HGRetCodeType type, int errorCode)
			{
				return null;
			}

			// Token: 0x06009574 RID: 38260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009574")]
			[Address(RVA = "0x3107C40", Offset = "0x3106840", VA = "0x183107C40")]
			private void _OnHGDownloadFinish()
			{
			}

			// Token: 0x06009575 RID: 38261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009575")]
			[Address(RVA = "0x3107D00", Offset = "0x3106900", VA = "0x183107D00")]
			private void _OnHGError(HGRetCodeType codeType, int errorCode)
			{
			}

			// Token: 0x06009576 RID: 38262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009576")]
			[Address(RVA = "0x3107C80", Offset = "0x3106880", VA = "0x183107C80")]
			private void _OnHGDownloadPaused(HGDownloader.PauseReason reason)
			{
			}

			// Token: 0x04008B8A RID: 35722
			[Token(Token = "0x4008B8A")]
			[FieldOffset(Offset = "0x38")]
			private HotUpdater.HGDownloadInterface.UnzipHandler m_unzipHandler;

			// Token: 0x04008B8B RID: 35723
			[Token(Token = "0x4008B8B")]
			[FieldOffset(Offset = "0x40")]
			private HGDownloader.TaskHandler m_task;

			// Token: 0x04008B8C RID: 35724
			[Token(Token = "0x4008B8C")]
			[FieldOffset(Offset = "0x48")]
			private HotUpdater.HGDownloadInterface.InternalState m_state;

			// Token: 0x0200170F RID: 5903
			[Token(Token = "0x200170F")]
			private enum InternalState
			{
				// Token: 0x04008B8E RID: 35726
				[Token(Token = "0x4008B8E")]
				NONE,
				// Token: 0x04008B8F RID: 35727
				[Token(Token = "0x4008B8F")]
				DOWNLOAD,
				// Token: 0x04008B90 RID: 35728
				[Token(Token = "0x4008B90")]
				UNZIP
			}

			// Token: 0x02001710 RID: 5904
			[Token(Token = "0x2001710")]
			private class UnzipHandler : HotUpdater.DownloadInterface.IUnzipInterface
			{
				// Token: 0x06009577 RID: 38263 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6009577")]
				[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
				public UnzipHandler(HotUpdater.HGDownloadInterface closure)
				{
				}

				// Token: 0x06009578 RID: 38264 RVA: 0x0003A4B8 File Offset: 0x000386B8
				[Token(Token = "0x6009578")]
				[Address(RVA = "0x15F2880", Offset = "0x15F1480", VA = "0x1815F2880", Slot = "6")]
				public HotUpdater.DownloadInterface.UnzipError GetErrorInfo()
				{
					return default(HotUpdater.DownloadInterface.UnzipError);
				}

				// Token: 0x06009579 RID: 38265 RVA: 0x0003A4D0 File Offset: 0x000386D0
				[Token(Token = "0x6009579")]
				[Address(RVA = "0x3116B10", Offset = "0x3115710", VA = "0x183116B10", Slot = "4")]
				public float GetProgress()
				{
					return 0f;
				}

				// Token: 0x0600957A RID: 38266 RVA: 0x0003A4E8 File Offset: 0x000386E8
				[Token(Token = "0x600957A")]
				[Address(RVA = "0x3116B40", Offset = "0x3115740", VA = "0x183116B40", Slot = "5")]
				public bool IsWorking()
				{
					return default(bool);
				}

				// Token: 0x0600957B RID: 38267 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600957B")]
				[Address(RVA = "0x3116AF0", Offset = "0x31156F0", VA = "0x183116AF0")]
				public void ClosureOnly_SetErrorMsg(HotUpdater.DownloadInterface.UnzipError error)
				{
				}

				// Token: 0x04008B91 RID: 35729
				[Token(Token = "0x4008B91")]
				[FieldOffset(Offset = "0x10")]
				private HotUpdater.HGDownloadInterface m_closure;

				// Token: 0x04008B92 RID: 35730
				[Token(Token = "0x4008B92")]
				[FieldOffset(Offset = "0x18")]
				private HotUpdater.DownloadInterface.UnzipError m_error;
			}
		}

		// Token: 0x02001713 RID: 5907
		[Token(Token = "0x2001713")]
		protected struct DownloadOptions
		{
			// Token: 0x06009588 RID: 38280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009588")]
			[Address(RVA = "0x3104B80", Offset = "0x3103780", VA = "0x183104B80")]
			public void TriggerDownloadProgressCallback(long curSize, long totalSize)
			{
			}

			// Token: 0x06009589 RID: 38281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009589")]
			[Address(RVA = "0x3104B60", Offset = "0x3103760", VA = "0x183104B60")]
			public void TriggerDownloadFinishCallback()
			{
			}

			// Token: 0x0600958A RID: 38282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600958A")]
			[Address(RVA = "0x3104BA0", Offset = "0x31037A0", VA = "0x183104BA0")]
			public void TriggerMobileDataPaused(long remainSize)
			{
			}

			// Token: 0x0600958B RID: 38283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600958B")]
			[Address(RVA = "0x3104B30", Offset = "0x3103730", VA = "0x183104B30")]
			public void TriggerABDownloadError(HotUpdater.DownloadInterface.DownloadError errorInfo)
			{
			}

			// Token: 0x04008B99 RID: 35737
			[Token(Token = "0x4008B99")]
			[FieldOffset(Offset = "0x0")]
			public Action<long, long> onDownloadProgress;

			// Token: 0x04008B9A RID: 35738
			[Token(Token = "0x4008B9A")]
			[FieldOffset(Offset = "0x8")]
			public Action onAllDownloadFinished;

			// Token: 0x04008B9B RID: 35739
			[Token(Token = "0x4008B9B")]
			[FieldOffset(Offset = "0x10")]
			public Action onPreMainDownloadFinished;

			// Token: 0x04008B9C RID: 35740
			[Token(Token = "0x4008B9C")]
			[FieldOffset(Offset = "0x18")]
			public Action<long> onMobileDataPaused;

			// Token: 0x04008B9D RID: 35741
			[Token(Token = "0x4008B9D")]
			[FieldOffset(Offset = "0x20")]
			public Action<HotUpdater.DownloadInterface.DownloadError> onABDownloadError;
		}

		// Token: 0x02001714 RID: 5908
		[Token(Token = "0x2001714")]
		protected abstract class DownloadInterface : IDisposable
		{
			// Token: 0x0600958C RID: 38284 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600958C")]
			[Address(RVA = "0x3104700", Offset = "0x3103300", VA = "0x183104700")]
			public static HotUpdater.DownloadInterface CreateProperInstance(HotUpdater.DownloadOptions options)
			{
				return null;
			}

			// Token: 0x17000FF5 RID: 4085
			// (get) Token: 0x0600958D RID: 38285 RVA: 0x0003A530 File Offset: 0x00038730
			// (set) Token: 0x0600958E RID: 38286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000FF5")]
			private protected HotUpdater.DownloadOptions options
			{
				[Token(Token = "0x600958D")]
				[Address(RVA = "0x3104AE0", Offset = "0x31036E0", VA = "0x183104AE0")]
				[CompilerGenerated]
				protected get
				{
					return default(HotUpdater.DownloadOptions);
				}
				[Token(Token = "0x600958E")]
				[Address(RVA = "0x3104B00", Offset = "0x3103700", VA = "0x183104B00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600958F RID: 38287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600958F")]
			[Address(RVA = "0x3104A90", Offset = "0x3103690", VA = "0x183104A90")]
			protected DownloadInterface(HotUpdater.DownloadOptions options)
			{
			}

			// Token: 0x06009590 RID: 38288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009590")]
			[Address(RVA = "0x3104960", Offset = "0x3103560", VA = "0x183104960")]
			public void CreateWorkspaceFolder()
			{
			}

			// Token: 0x06009591 RID: 38289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009591")]
			[Address(RVA = "0x3104A50", Offset = "0x3103650", VA = "0x183104A50", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06009592 RID: 38290
			[Token(Token = "0x6009592")]
			public abstract IEnumerator WaitForInitFinish();

			// Token: 0x06009593 RID: 38291
			[Token(Token = "0x6009593")]
			public abstract void ClearUnzipThread();

			// Token: 0x06009594 RID: 38292
			[Token(Token = "0x6009594")]
			public abstract long CalculateTotalDownloadSize(string versionId, IList<HotUpdateInfo.ABInfo> updateResList);

			// Token: 0x06009595 RID: 38293
			[Token(Token = "0x6009595")]
			public abstract void InterruptAllDownloading();

			// Token: 0x06009596 RID: 38294
			[Token(Token = "0x6009596")]
			public abstract IEnumerator WaitForDownloadingStop();

			// Token: 0x06009597 RID: 38295
			[Token(Token = "0x6009597")]
			protected abstract void OnDispose();

			// Token: 0x06009598 RID: 38296
			[Token(Token = "0x6009598")]
			public abstract HotUpdater.DownloadInterface.IUnzipInterface CreateCurrentUnzipInterface();

			// Token: 0x06009599 RID: 38297
			[Token(Token = "0x6009599")]
			public abstract void Tick();

			// Token: 0x0600959A RID: 38298
			[Token(Token = "0x600959A")]
			public abstract void StartDownload(HotUpdater.DownloadInterface.DownloadParam param);

			// Token: 0x0600959B RID: 38299
			[Token(Token = "0x600959B")]
			public abstract void EnableMobileData();

			// Token: 0x02001715 RID: 5909
			[Token(Token = "0x2001715")]
			public struct UnzipError
			{
				// Token: 0x04008B9F RID: 35743
				[Token(Token = "0x4008B9F")]
				[FieldOffset(Offset = "0x0")]
				public bool isError;

				// Token: 0x04008BA0 RID: 35744
				[Token(Token = "0x4008BA0")]
				[FieldOffset(Offset = "0x8")]
				public string errorMessage;

				// Token: 0x04008BA1 RID: 35745
				[Token(Token = "0x4008BA1")]
				[FieldOffset(Offset = "0x10")]
				public string alertContent;
			}

			// Token: 0x02001716 RID: 5910
			[Token(Token = "0x2001716")]
			public struct DownloadError
			{
				// Token: 0x04008BA2 RID: 35746
				[Token(Token = "0x4008BA2")]
				[FieldOffset(Offset = "0x0")]
				public string alertContent;

				// Token: 0x04008BA3 RID: 35747
				[Token(Token = "0x4008BA3")]
				[FieldOffset(Offset = "0x8")]
				public bool enableTrivialErrorPolicy;
			}

			// Token: 0x02001717 RID: 5911
			[Token(Token = "0x2001717")]
			public interface IUnzipInterface
			{
				// Token: 0x0600959C RID: 38300
				[Token(Token = "0x600959C")]
				float GetProgress();

				// Token: 0x0600959D RID: 38301
				[Token(Token = "0x600959D")]
				bool IsWorking();

				// Token: 0x0600959E RID: 38302
				[Token(Token = "0x600959E")]
				HotUpdater.DownloadInterface.UnzipError GetErrorInfo();
			}

			// Token: 0x02001718 RID: 5912
			[Token(Token = "0x2001718")]
			public struct DownloadParam
			{
				// Token: 0x04008BA4 RID: 35748
				[Token(Token = "0x4008BA4")]
				[FieldOffset(Offset = "0x0")]
				public HotUpdateInfo updateInfo;

				// Token: 0x04008BA5 RID: 35749
				[Token(Token = "0x4008BA5")]
				[FieldOffset(Offset = "0x8")]
				public IList<HotUpdateInfo.ABInfo> updateResList;

				// Token: 0x04008BA6 RID: 35750
				[Token(Token = "0x4008BA6")]
				[FieldOffset(Offset = "0x10")]
				public bool useMobileData;
			}
		}

		// Token: 0x02001719 RID: 5913
		[Token(Token = "0x2001719")]
		private class BuildinDownloadInterface : HotUpdater.DownloadInterface
		{
			// Token: 0x17000FF6 RID: 4086
			// (get) Token: 0x0600959F RID: 38303 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000FF6")]
			protected string resCacheDir
			{
				[Token(Token = "0x600959F")]
				[Address(RVA = "0x3101160", Offset = "0x30FFD60", VA = "0x183101160")]
				get
				{
					return null;
				}
			}

			// Token: 0x060095A0 RID: 38304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095A0")]
			[Address(RVA = "0x3101020", Offset = "0x30FFC20", VA = "0x183101020")]
			private BuildinDownloadInterface(HotUpdater.DownloadOptions options)
			{
			}

			// Token: 0x060095A1 RID: 38305 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60095A1")]
			[Address(RVA = "0x3100040", Offset = "0x30FEC40", VA = "0x183100040")]
			public static HotUpdater.BuildinDownloadInterface DownloadInterfaceOnly_Create(HotUpdater.DownloadOptions options)
			{
				return null;
			}

			// Token: 0x060095A2 RID: 38306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095A2")]
			[Address(RVA = "0x30FFF90", Offset = "0x30FEB90", VA = "0x1830FFF90", Slot = "6")]
			public override void ClearUnzipThread()
			{
			}

			// Token: 0x060095A3 RID: 38307 RVA: 0x0003A548 File Offset: 0x00038748
			[Token(Token = "0x60095A3")]
			[Address(RVA = "0x30FFDB0", Offset = "0x30FE9B0", VA = "0x1830FFDB0", Slot = "7")]
			public override long CalculateTotalDownloadSize(string versionId, IList<HotUpdateInfo.ABInfo> updateResList)
			{
				return 0L;
			}

			// Token: 0x060095A4 RID: 38308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095A4")]
			[Address(RVA = "0x31001C0", Offset = "0x30FEDC0", VA = "0x1831001C0", Slot = "8")]
			public override void InterruptAllDownloading()
			{
			}

			// Token: 0x060095A5 RID: 38309 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60095A5")]
			[Address(RVA = "0x3100D70", Offset = "0x30FF970", VA = "0x183100D70", Slot = "5")]
			public override IEnumerator WaitForInitFinish()
			{
				return null;
			}

			// Token: 0x060095A6 RID: 38310 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60095A6")]
			[Address(RVA = "0x3100CF0", Offset = "0x30FF8F0", VA = "0x183100CF0", Slot = "9")]
			public override IEnumerator WaitForDownloadingStop()
			{
				return null;
			}

			// Token: 0x060095A7 RID: 38311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095A7")]
			[Address(RVA = "0x3100260", Offset = "0x30FEE60", VA = "0x183100260", Slot = "10")]
			protected override void OnDispose()
			{
			}

			// Token: 0x060095A8 RID: 38312 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60095A8")]
			[Address(RVA = "0x30FFFD0", Offset = "0x30FEBD0", VA = "0x1830FFFD0", Slot = "11")]
			public override HotUpdater.DownloadInterface.IUnzipInterface CreateCurrentUnzipInterface()
			{
				return null;
			}

			// Token: 0x060095A9 RID: 38313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095A9")]
			[Address(RVA = "0x3100AB0", Offset = "0x30FF6B0", VA = "0x183100AB0", Slot = "12")]
			public override void Tick()
			{
			}

			// Token: 0x060095AA RID: 38314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095AA")]
			[Address(RVA = "0x31002B0", Offset = "0x30FEEB0", VA = "0x1831002B0", Slot = "13")]
			public override void StartDownload(HotUpdater.DownloadInterface.DownloadParam param)
			{
			}

			// Token: 0x060095AB RID: 38315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095AB")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
			public override void EnableMobileData()
			{
			}

			// Token: 0x060095AC RID: 38316 RVA: 0x0003A560 File Offset: 0x00038760
			[Token(Token = "0x60095AC")]
			[Address(RVA = "0x3100DD0", Offset = "0x30FF9D0", VA = "0x183100DD0")]
			private HotUpdater.UnzipTaskThread.Options _GenerateUnzipOptions()
			{
				return default(HotUpdater.UnzipTaskThread.Options);
			}

			// Token: 0x060095AD RID: 38317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095AD")]
			[Address(RVA = "0x3100F90", Offset = "0x30FFB90", VA = "0x183100F90")]
			private void _OnABDownloadSizeChange(int index, long size)
			{
			}

			// Token: 0x060095AE RID: 38318 RVA: 0x0003A578 File Offset: 0x00038778
			[Token(Token = "0x60095AE")]
			[Address(RVA = "0x3100E20", Offset = "0x30FFA20", VA = "0x183100E20")]
			private bool _OnABDownloadFinish(bool isSuc, FileDownloader.Options options)
			{
				return default(bool);
			}

			// Token: 0x04008BA7 RID: 35751
			[Token(Token = "0x4008BA7")]
			[FieldOffset(Offset = "0x38")]
			private bool m_isDisposed;

			// Token: 0x04008BA8 RID: 35752
			[Token(Token = "0x4008BA8")]
			[FieldOffset(Offset = "0x40")]
			private long m_curResSize;

			// Token: 0x04008BA9 RID: 35753
			[Token(Token = "0x4008BA9")]
			[FieldOffset(Offset = "0x48")]
			private long m_totalResSize;

			// Token: 0x04008BAA RID: 35754
			[Token(Token = "0x4008BAA")]
			[FieldOffset(Offset = "0x50")]
			private HotUpdater.UnzipTaskThread m_unzipThread;

			// Token: 0x04008BAB RID: 35755
			[Token(Token = "0x4008BAB")]
			[FieldOffset(Offset = "0x58")]
			private List<HotUpdater.BuildinDownloadInterface.ABDownloadInfo> m_filesToDownload;

			// Token: 0x04008BAC RID: 35756
			[Token(Token = "0x4008BAC")]
			[FieldOffset(Offset = "0x60")]
			private int m_downloadFinishCount;

			// Token: 0x04008BAD RID: 35757
			[Token(Token = "0x4008BAD")]
			[FieldOffset(Offset = "0x68")]
			private Queue<FileDownloader.IDownloadMessage> m_downloadMsgQueue;

			// Token: 0x04008BAE RID: 35758
			[Token(Token = "0x4008BAE")]
			[FieldOffset(Offset = "0x70")]
			private FileDownloader m_downloader;

			// Token: 0x04008BAF RID: 35759
			[Token(Token = "0x4008BAF")]
			[FieldOffset(Offset = "0x78")]
			private FileDownloader.CancelletionInfo m_lastStopDownloadInfo;

			// Token: 0x04008BB0 RID: 35760
			[Token(Token = "0x4008BB0")]
			[FieldOffset(Offset = "0x80")]
			private string m_internalResCacheDir;

			// Token: 0x0200171A RID: 5914
			[Token(Token = "0x200171A")]
			private class ABDownloadInfo
			{
				// Token: 0x060095AF RID: 38319 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60095AF")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ABDownloadInfo()
				{
				}

				// Token: 0x04008BB1 RID: 35761
				[Token(Token = "0x4008BB1")]
				[FieldOffset(Offset = "0x10")]
				public long downloadSize;

				// Token: 0x04008BB2 RID: 35762
				[Token(Token = "0x4008BB2")]
				[FieldOffset(Offset = "0x18")]
				public string resFileName;

				// Token: 0x04008BB3 RID: 35763
				[Token(Token = "0x4008BB3")]
				[FieldOffset(Offset = "0x20")]
				public HotUpdateInfo.ABInfo abInfo;
			}

			// Token: 0x0200171B RID: 5915
			[Token(Token = "0x200171B")]
			private class UnzipInterface : HotUpdater.DownloadInterface.IUnzipInterface
			{
				// Token: 0x060095B0 RID: 38320 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60095B0")]
				[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
				public UnzipInterface(HotUpdater.BuildinDownloadInterface closure)
				{
				}

				// Token: 0x060095B1 RID: 38321 RVA: 0x0003A590 File Offset: 0x00038790
				[Token(Token = "0x60095B1")]
				[Address(RVA = "0x3116D70", Offset = "0x3115970", VA = "0x183116D70", Slot = "4")]
				public float GetProgress()
				{
					return 0f;
				}

				// Token: 0x060095B2 RID: 38322 RVA: 0x0003A5A8 File Offset: 0x000387A8
				[Token(Token = "0x60095B2")]
				[Address(RVA = "0x3116DA0", Offset = "0x31159A0", VA = "0x183116DA0", Slot = "5")]
				public bool IsWorking()
				{
					return default(bool);
				}

				// Token: 0x060095B3 RID: 38323 RVA: 0x0003A5C0 File Offset: 0x000387C0
				[Token(Token = "0x60095B3")]
				[Address(RVA = "0x3116B90", Offset = "0x3115790", VA = "0x183116B90", Slot = "6")]
				public HotUpdater.DownloadInterface.UnzipError GetErrorInfo()
				{
					return default(HotUpdater.DownloadInterface.UnzipError);
				}

				// Token: 0x04008BB4 RID: 35764
				[Token(Token = "0x4008BB4")]
				[FieldOffset(Offset = "0x10")]
				private HotUpdater.BuildinDownloadInterface m_closure;
			}
		}

		// Token: 0x0200171E RID: 5918
		[Token(Token = "0x200171E")]
		public enum UpdateState
		{
			// Token: 0x04008BBB RID: 35771
			[Token(Token = "0x4008BBB")]
			NONE,
			// Token: 0x04008BBC RID: 35772
			[Token(Token = "0x4008BBC")]
			VERSION,
			// Token: 0x04008BBD RID: 35773
			[Token(Token = "0x4008BBD")]
			DOWNLOAD_INFO,
			// Token: 0x04008BBE RID: 35774
			[Token(Token = "0x4008BBE")]
			DOWNLOAD_UPZIP_RES,
			// Token: 0x04008BBF RID: 35775
			[Token(Token = "0x4008BBF")]
			UNZIPPING_RES,
			// Token: 0x04008BC0 RID: 35776
			[Token(Token = "0x4008BC0")]
			COMPLETE,
			// Token: 0x04008BC1 RID: 35777
			[Token(Token = "0x4008BC1")]
			ERROR,
			// Token: 0x04008BC2 RID: 35778
			[Token(Token = "0x4008BC2")]
			TRIVIAL_ERROR,
			// Token: 0x04008BC3 RID: 35779
			[Token(Token = "0x4008BC3")]
			CONSISTENCY_CHECK = 9,
			// Token: 0x04008BC4 RID: 35780
			[Token(Token = "0x4008BC4")]
			RECOVER_PERSIST_INFO
		}

		// Token: 0x0200171F RID: 5919
		[Token(Token = "0x200171F")]
		public enum LogTraceErrorCode
		{
			// Token: 0x04008BC6 RID: 35782
			[Token(Token = "0x4008BC6")]
			ERROR_FOUND_HOTUPDATE_INCONSISTENCY,
			// Token: 0x04008BC7 RID: 35783
			[Token(Token = "0x4008BC7")]
			ERROR_FAILED_TO_LOCAL_RES,
			// Token: 0x04008BC8 RID: 35784
			[Token(Token = "0x4008BC8")]
			ERROR_FAILED_CALC_UPDATE_RES_LIST,
			// Token: 0x04008BC9 RID: 35785
			[Token(Token = "0x4008BC9")]
			ERROR_IO_EXCEPTION_DURING_HOT_UPDATE,
			// Token: 0x04008BCA RID: 35786
			[Token(Token = "0x4008BCA")]
			ERROR_LOAD_HOTUPDATE_INFO_FAILED,
			// Token: 0x04008BCB RID: 35787
			[Token(Token = "0x4008BCB")]
			ERROR_UNZIP_RES_FAILED,
			// Token: 0x04008BCC RID: 35788
			[Token(Token = "0x4008BCC")]
			ERROR_PLAYER_INTERRUPT,
			// Token: 0x04008BCD RID: 35789
			[Token(Token = "0x4008BCD")]
			ERROR_NETWORK,
			// Token: 0x04008BCE RID: 35790
			[Token(Token = "0x4008BCE")]
			ERROR_DOWNLOAD,
			// Token: 0x04008BCF RID: 35791
			[Token(Token = "0x4008BCF")]
			ERROR_VERSION
		}

		// Token: 0x02001720 RID: 5920
		[Token(Token = "0x2001720")]
		public enum DownloadPartEnum
		{
			// Token: 0x04008BD1 RID: 35793
			[Token(Token = "0x4008BD1")]
			INIT,
			// Token: 0x04008BD2 RID: 35794
			[Token(Token = "0x4008BD2")]
			MAIN
		}

		// Token: 0x02001721 RID: 5921
		[Token(Token = "0x2001721")]
		public struct Options
		{
			// Token: 0x04008BD3 RID: 35795
			[Token(Token = "0x4008BD3")]
			[FieldOffset(Offset = "0x0")]
			public Action<HotUpdater.UpdateState, HotUpdater.UpdateState> onStateChange;

			// Token: 0x04008BD4 RID: 35796
			[Token(Token = "0x4008BD4")]
			[FieldOffset(Offset = "0x8")]
			public Action<long, long> onDownloadProgress;

			// Token: 0x04008BD5 RID: 35797
			[Token(Token = "0x4008BD5")]
			[FieldOffset(Offset = "0x10")]
			public Action<float> onUnzipProgress;

			// Token: 0x04008BD6 RID: 35798
			[Token(Token = "0x4008BD6")]
			[FieldOffset(Offset = "0x18")]
			public Action<int> onCheckConsistencyFailed;

			// Token: 0x04008BD7 RID: 35799
			[Token(Token = "0x4008BD7")]
			[FieldOffset(Offset = "0x20")]
			public Action<int, int> onRecoverPersistInfoProgress;

			// Token: 0x04008BD8 RID: 35800
			[Token(Token = "0x4008BD8")]
			[FieldOffset(Offset = "0x28")]
			public Action<string, Action> alertWithNetCheck;

			// Token: 0x04008BD9 RID: 35801
			[Token(Token = "0x4008BD9")]
			[FieldOffset(Offset = "0x30")]
			public Action onDownloadStart;

			// Token: 0x04008BDA RID: 35802
			[Token(Token = "0x4008BDA")]
			[FieldOffset(Offset = "0x38")]
			public Action onUnzipStart;

			// Token: 0x04008BDB RID: 35803
			[Token(Token = "0x4008BDB")]
			[FieldOffset(Offset = "0x40")]
			public HotUpdater.DownloadPartEnum partEnum;
		}

		// Token: 0x02001722 RID: 5922
		[Token(Token = "0x2001722")]
		public struct VersionInfo
		{
			// Token: 0x04008BDC RID: 35804
			[Token(Token = "0x4008BDC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly HotUpdater.VersionInfo EMPTY;

			// Token: 0x04008BDD RID: 35805
			[Token(Token = "0x4008BDD")]
			[FieldOffset(Offset = "0x0")]
			public string resVersion;

			// Token: 0x04008BDE RID: 35806
			[Token(Token = "0x4008BDE")]
			[FieldOffset(Offset = "0x8")]
			public string clientVersion;
		}

		// Token: 0x02001723 RID: 5923
		[Token(Token = "0x2001723")]
		public struct CarrierDownloadCache
		{
			// Token: 0x04008BDF RID: 35807
			[Token(Token = "0x4008BDF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly HotUpdater.CarrierDownloadCache EMPTY;

			// Token: 0x04008BE0 RID: 35808
			[Token(Token = "0x4008BE0")]
			[FieldOffset(Offset = "0x0")]
			public long size;

			// Token: 0x04008BE1 RID: 35809
			[Token(Token = "0x4008BE1")]
			[FieldOffset(Offset = "0x8")]
			public bool isAllowed;
		}

		// Token: 0x02001724 RID: 5924
		[Token(Token = "0x2001724")]
		private class UnzipTaskThread : IDisposable
		{
			// Token: 0x060095C2 RID: 38338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095C2")]
			[Address(RVA = "0x3117570", Offset = "0x3116170", VA = "0x183117570")]
			public UnzipTaskThread(HotUpdater.UnzipTaskThread.Options options)
			{
			}

			// Token: 0x060095C3 RID: 38339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095C3")]
			[Address(RVA = "0x3116DE0", Offset = "0x31159E0", VA = "0x183116DE0")]
			public void AddTask(HotUpdater.UnzipTaskThread.Task task)
			{
			}

			// Token: 0x17000FFB RID: 4091
			// (get) Token: 0x060095C4 RID: 38340 RVA: 0x0003A608 File Offset: 0x00038808
			[Token(Token = "0x17000FFB")]
			public int pendingTaskCount
			{
				[Token(Token = "0x60095C4")]
				[Address(RVA = "0x3117910", Offset = "0x3116510", VA = "0x183117910")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000FFC RID: 4092
			// (get) Token: 0x060095C5 RID: 38341 RVA: 0x0003A620 File Offset: 0x00038820
			[Token(Token = "0x17000FFC")]
			public bool isError
			{
				[Token(Token = "0x60095C5")]
				[Address(RVA = "0x3117780", Offset = "0x3116380", VA = "0x183117780")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000FFD RID: 4093
			// (get) Token: 0x060095C6 RID: 38342 RVA: 0x0003A638 File Offset: 0x00038838
			[Token(Token = "0x17000FFD")]
			public HotUpdater.UnzipTaskThread.ErrorInfo lastError
			{
				[Token(Token = "0x60095C6")]
				[Address(RVA = "0x3117860", Offset = "0x3116460", VA = "0x183117860")]
				get
				{
					return default(HotUpdater.UnzipTaskThread.ErrorInfo);
				}
			}

			// Token: 0x17000FFE RID: 4094
			// (get) Token: 0x060095C7 RID: 38343 RVA: 0x0003A650 File Offset: 0x00038850
			[Token(Token = "0x17000FFE")]
			public bool isCompleted
			{
				[Token(Token = "0x60095C7")]
				[Address(RVA = "0x31176E0", Offset = "0x31162E0", VA = "0x1831176E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000FFF RID: 4095
			// (get) Token: 0x060095C8 RID: 38344 RVA: 0x0003A668 File Offset: 0x00038868
			[Token(Token = "0x17000FFF")]
			public bool isWorking
			{
				[Token(Token = "0x60095C8")]
				[Address(RVA = "0x31177A0", Offset = "0x31163A0", VA = "0x1831177A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001000 RID: 4096
			// (get) Token: 0x060095C9 RID: 38345 RVA: 0x0003A680 File Offset: 0x00038880
			[Token(Token = "0x17001000")]
			public float progress
			{
				[Token(Token = "0x60095C9")]
				[Address(RVA = "0x3117960", Offset = "0x3116560", VA = "0x183117960")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060095CA RID: 38346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095CA")]
			[Address(RVA = "0x3116FC0", Offset = "0x3115BC0", VA = "0x183116FC0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060095CB RID: 38347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095CB")]
			[Address(RVA = "0x31170C0", Offset = "0x3115CC0", VA = "0x1831170C0")]
			protected void Run()
			{
			}

			// Token: 0x04008BE2 RID: 35810
			[Token(Token = "0x4008BE2")]
			[FieldOffset(Offset = "0x10")]
			private ThreadSafeQueue<HotUpdater.UnzipTaskThread.Task> m_pendingTasks;

			// Token: 0x04008BE3 RID: 35811
			[Token(Token = "0x4008BE3")]
			[FieldOffset(Offset = "0x18")]
			private Thread m_workThread;

			// Token: 0x04008BE4 RID: 35812
			[Token(Token = "0x4008BE4")]
			[FieldOffset(Offset = "0x20")]
			private bool m_isDisposed;

			// Token: 0x04008BE5 RID: 35813
			[Token(Token = "0x4008BE5")]
			[FieldOffset(Offset = "0x28")]
			private ZipUtils.UnzipThreadContext m_context;

			// Token: 0x04008BE6 RID: 35814
			[Token(Token = "0x4008BE6")]
			[FieldOffset(Offset = "0x30")]
			private HotUpdater.UnzipTaskThread.Options m_options;

			// Token: 0x04008BE7 RID: 35815
			[Token(Token = "0x4008BE7")]
			[FieldOffset(Offset = "0x34")]
			private int m_totalTaskCnt;

			// Token: 0x04008BE8 RID: 35816
			[Token(Token = "0x4008BE8")]
			[FieldOffset(Offset = "0x38")]
			private long m_totalSize;

			// Token: 0x04008BE9 RID: 35817
			[Token(Token = "0x4008BE9")]
			[FieldOffset(Offset = "0x40")]
			private int m_completeTaskCnt;

			// Token: 0x04008BEA RID: 35818
			[Token(Token = "0x4008BEA")]
			[FieldOffset(Offset = "0x48")]
			private long m_completeSize;

			// Token: 0x04008BEB RID: 35819
			[Token(Token = "0x4008BEB")]
			[FieldOffset(Offset = "0x50")]
			private long m_curFileSize;

			// Token: 0x04008BEC RID: 35820
			[Token(Token = "0x4008BEC")]
			[FieldOffset(Offset = "0x58")]
			private HotUpdater.UnzipTaskThread.ErrorInfo m_lastError;

			// Token: 0x04008BED RID: 35821
			[Token(Token = "0x4008BED")]
			[FieldOffset(Offset = "0x78")]
			private bool m_isError;

			// Token: 0x02001725 RID: 5925
			[Token(Token = "0x2001725")]
			public struct ErrorInfo
			{
				// Token: 0x04008BEE RID: 35822
				[Token(Token = "0x4008BEE")]
				[FieldOffset(Offset = "0x0")]
				public HotUpdater.UnzipTaskThread.Task failedTask;

				// Token: 0x04008BEF RID: 35823
				[Token(Token = "0x4008BEF")]
				[FieldOffset(Offset = "0x18")]
				public Exception exception;
			}

			// Token: 0x02001726 RID: 5926
			[Token(Token = "0x2001726")]
			public struct Options
			{
				// Token: 0x04008BF0 RID: 35824
				[Token(Token = "0x4008BF0")]
				[FieldOffset(Offset = "0x0")]
				public bool haltIfError;
			}

			// Token: 0x02001727 RID: 5927
			[Token(Token = "0x2001727")]
			public struct Task
			{
				// Token: 0x04008BF1 RID: 35825
				[Token(Token = "0x4008BF1")]
				[FieldOffset(Offset = "0x0")]
				public string zipPath;

				// Token: 0x04008BF2 RID: 35826
				[Token(Token = "0x4008BF2")]
				[FieldOffset(Offset = "0x8")]
				public string targetDir;

				// Token: 0x04008BF3 RID: 35827
				[Token(Token = "0x4008BF3")]
				[FieldOffset(Offset = "0x10")]
				public int taskCode;
			}
		}

		// Token: 0x02001728 RID: 5928
		[Token(Token = "0x2001728")]
		public enum UpdatePreferenceType
		{
			// Token: 0x04008BF5 RID: 35829
			[Token(Token = "0x4008BF5")]
			BASE,
			// Token: 0x04008BF6 RID: 35830
			[Token(Token = "0x4008BF6")]
			FULL
		}

		// Token: 0x02001729 RID: 5929
		[Token(Token = "0x2001729")]
		private class HotUpdateInfoBundle
		{
			// Token: 0x060095CC RID: 38348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095CC")]
			[Address(RVA = "0x31080A0", Offset = "0x3106CA0", VA = "0x1831080A0")]
			public HotUpdateInfoBundle()
			{
			}

			// Token: 0x04008BF7 RID: 35831
			[Token(Token = "0x4008BF7")]
			[FieldOffset(Offset = "0x10")]
			public List<HotUpdateInfo.ABInfo> list;

			// Token: 0x04008BF8 RID: 35832
			[Token(Token = "0x4008BF8")]
			[FieldOffset(Offset = "0x18")]
			public long totalSize;
		}

		// Token: 0x0200172A RID: 5930
		[Token(Token = "0x200172A")]
		private class CalcResult : IHotfixable
		{
			// Token: 0x060095CD RID: 38349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095CD")]
			[Address(RVA = "0x31011A0", Offset = "0x30FFDA0", VA = "0x1831011A0")]
			public void AddExtraVoiceRes(HotUpdateInfo.ABInfo abInfo)
			{
			}

			// Token: 0x060095CE RID: 38350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60095CE")]
			[Address(RVA = "0x31013E0", Offset = "0x30FFFE0", VA = "0x1831013E0")]
			public Dictionary<string, HotUpdateVoicePackItemData> GenerateVoicePackItemInfo()
			{
				return null;
			}

			// Token: 0x060095CF RID: 38351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095CF")]
			[Address(RVA = "0x3101600", Offset = "0x3100200", VA = "0x183101600")]
			public CalcResult()
			{
			}

			// Token: 0x04008BF9 RID: 35833
			[Token(Token = "0x4008BF9")]
			[FieldOffset(Offset = "0x10")]
			public HotUpdater.DownloadPartEnum downloadPart;

			// Token: 0x04008BFA RID: 35834
			[Token(Token = "0x4008BFA")]
			[FieldOffset(Offset = "0x18")]
			public List<HotUpdateInfo.ABInfo> updateResList;

			// Token: 0x04008BFB RID: 35835
			[Token(Token = "0x4008BFB")]
			[FieldOffset(Offset = "0x20")]
			public long baseDownloadSize;

			// Token: 0x04008BFC RID: 35836
			[Token(Token = "0x4008BFC")]
			[FieldOffset(Offset = "0x28")]
			public List<HotUpdateInfo.ABInfo> extraResList;

			// Token: 0x04008BFD RID: 35837
			[Token(Token = "0x4008BFD")]
			[FieldOffset(Offset = "0x30")]
			public long extraDownloadSize;

			// Token: 0x04008BFE RID: 35838
			[Token(Token = "0x4008BFE")]
			[FieldOffset(Offset = "0x38")]
			public List<HotUpdateInfo.ABInfo> removeResList;

			// Token: 0x04008BFF RID: 35839
			[Token(Token = "0x4008BFF")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, HotUpdater.HotUpdateInfoBundle> extraVoiceRes;

			// Token: 0x04008C00 RID: 35840
			[Token(Token = "0x4008C00")]
			[FieldOffset(Offset = "0x48")]
			public Dictionary<string, HotUpdater.PackWrapper> packInfo;

			// Token: 0x04008C01 RID: 35841
			[Token(Token = "0x4008C01")]
			[FieldOffset(Offset = "0x50")]
			public HashSet<string> extraTypeHashSet;

			// Token: 0x04008C02 RID: 35842
			[Token(Token = "0x4008C02")]
			[FieldOffset(Offset = "0x58")]
			public Dictionary<string, HotUpdateInfo.ABInfo> updatedNewABInfos;

			// Token: 0x04008C03 RID: 35843
			[Token(Token = "0x4008C03")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_AddExtraVoiceRes;

			// Token: 0x04008C04 RID: 35844
			[Token(Token = "0x4008C04")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateVoicePackItemInfo;

			// Token: 0x04008C05 RID: 35845
			[Token(Token = "0x4008C05")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200172B RID: 5931
		[Token(Token = "0x200172B")]
		private class PackWrapper
		{
			// Token: 0x060095D0 RID: 38352 RVA: 0x0003A698 File Offset: 0x00038898
			[Token(Token = "0x60095D0")]
			[Address(RVA = "0x3111E20", Offset = "0x3110A20", VA = "0x183111E20")]
			public bool CheckIfToUsePack()
			{
				return default(bool);
			}

			// Token: 0x060095D1 RID: 38353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095D1")]
			[Address(RVA = "0x3111E50", Offset = "0x3110A50", VA = "0x183111E50")]
			public PackWrapper()
			{
			}

			// Token: 0x04008C06 RID: 35846
			[Token(Token = "0x4008C06")]
			[FieldOffset(Offset = "0x10")]
			public HotUpdateInfo.ABInfo pack;

			// Token: 0x04008C07 RID: 35847
			[Token(Token = "0x4008C07")]
			[FieldOffset(Offset = "0x60")]
			public List<HotUpdateInfo.ABInfo> abList;

			// Token: 0x04008C08 RID: 35848
			[Token(Token = "0x4008C08")]
			[FieldOffset(Offset = "0x68")]
			public long updateResSize;
		}

		// Token: 0x0200172C RID: 5932
		[Token(Token = "0x200172C")]
		private struct ResPrefContext
		{
			// Token: 0x04008C09 RID: 35849
			[Token(Token = "0x4008C09")]
			[FieldOffset(Offset = "0x0")]
			public bool useExtraRes;
		}

		// Token: 0x0200172D RID: 5933
		[Token(Token = "0x200172D")]
		public class LocalResStatus : IHotfixable
		{
			// Token: 0x060095D2 RID: 38354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095D2")]
			[Address(RVA = "0x31117F0", Offset = "0x31103F0", VA = "0x1831117F0")]
			public LocalResStatus()
			{
			}

			// Token: 0x04008C0A RID: 35850
			[Token(Token = "0x4008C0A")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, HotUpdateVoicePackItemData> undownloadedVoices;

			// Token: 0x04008C0B RID: 35851
			[Token(Token = "0x4008C0B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200172E RID: 5934
		[Token(Token = "0x200172E")]
		public static class Alert
		{
			// Token: 0x060095D3 RID: 38355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60095D3")]
			[Address(RVA = "0x30FF8B0", Offset = "0x30FE4B0", VA = "0x1830FF8B0")]
			public static IEnumerator YieldErrorAlert(string alert)
			{
				return null;
			}

			// Token: 0x060095D4 RID: 38356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095D4")]
			[Address(RVA = "0x30FF6D0", Offset = "0x30FE2D0", VA = "0x1830FF6D0")]
			public static void ErrorAlert(string alert, Action onConfirm)
			{
			}

			// Token: 0x060095D5 RID: 38357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095D5")]
			[Address(RVA = "0x30FF6F0", Offset = "0x30FE2F0", VA = "0x1830FF6F0")]
			public static void PauseJudge(string desc, Action onSuc, Action onFail)
			{
			}

			// Token: 0x060095D6 RID: 38358 RVA: 0x0003A6B0 File Offset: 0x000388B0
			[Token(Token = "0x60095D6")]
			[Address(RVA = "0x30FF930", Offset = "0x30FE530", VA = "0x1830FF930")]
			private static bool _Alert(uint weight, string alert, Action callback)
			{
				return default(bool);
			}

			// Token: 0x060095D7 RID: 38359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095D7")]
			[Address(RVA = "0x30FFAE0", Offset = "0x30FE6E0", VA = "0x1830FFAE0")]
			private static void _Judge(uint weight, string desc, Action onSuc, Action onFail)
			{
			}

			// Token: 0x04008C0C RID: 35852
			[Token(Token = "0x4008C0C")]
			private const string KEY = "HOT_UPDATE_ALERT";

			// Token: 0x04008C0D RID: 35853
			[Token(Token = "0x4008C0D")]
			private const uint ON_ERROR = 100U;

			// Token: 0x04008C0E RID: 35854
			[Token(Token = "0x4008C0E")]
			private const uint ON_PAUSE = 50U;
		}

		// Token: 0x02001731 RID: 5937
		[Token(Token = "0x2001731")]
		public class NetUsagePolicy : IHotfixable
		{
			// Token: 0x060095E0 RID: 38368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095E0")]
			[Address(RVA = "0x3111D60", Offset = "0x3110960", VA = "0x183111D60")]
			public NetUsagePolicy(HotUpdater.NetUsagePolicy.Options options)
			{
			}

			// Token: 0x060095E1 RID: 38369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095E1")]
			[Address(RVA = "0x31118C0", Offset = "0x31104C0", VA = "0x1831118C0")]
			public void CheckIfAllowDownload(long downloadSize, Action onAllowed, Action onRejected)
			{
			}

			// Token: 0x060095E2 RID: 38370 RVA: 0x0003A6E0 File Offset: 0x000388E0
			[Token(Token = "0x60095E2")]
			[Address(RVA = "0x3111850", Offset = "0x3110450", VA = "0x183111850")]
			public bool AllowMobileDataInLastCheck()
			{
				return default(bool);
			}

			// Token: 0x060095E3 RID: 38371 RVA: 0x0003A6F8 File Offset: 0x000388F8
			[Token(Token = "0x60095E3")]
			[Address(RVA = "0x3111CB0", Offset = "0x31108B0", VA = "0x183111CB0")]
			public bool ExplictAllowedInLastCheck()
			{
				return default(bool);
			}

			// Token: 0x060095E4 RID: 38372 RVA: 0x0003A710 File Offset: 0x00038910
			[Token(Token = "0x60095E4")]
			[Address(RVA = "0x3111D10", Offset = "0x3110910", VA = "0x183111D10")]
			private static NetworkReachability _GetNetworkReachability()
			{
				return NetworkReachability.NotReachable;
			}

			// Token: 0x04008C14 RID: 35860
			[Token(Token = "0x4008C14")]
			[FieldOffset(Offset = "0x10")]
			private HotUpdater.CarrierDownloadCache m_mobileDataCache;

			// Token: 0x04008C15 RID: 35861
			[Token(Token = "0x4008C15")]
			[FieldOffset(Offset = "0x20")]
			private NetworkReachability m_lastNetworkState;

			// Token: 0x04008C16 RID: 35862
			[Token(Token = "0x4008C16")]
			[FieldOffset(Offset = "0x24")]
			private bool m_lastExplictAllowed;

			// Token: 0x04008C17 RID: 35863
			[Token(Token = "0x4008C17")]
			[FieldOffset(Offset = "0x28")]
			private HotUpdater.NetUsagePolicy.Options m_options;

			// Token: 0x04008C18 RID: 35864
			[Token(Token = "0x4008C18")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04008C19 RID: 35865
			[Token(Token = "0x4008C19")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CheckIfAllowDownload;

			// Token: 0x04008C1A RID: 35866
			[Token(Token = "0x4008C1A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_AllowMobileDataInLastCheck;

			// Token: 0x04008C1B RID: 35867
			[Token(Token = "0x4008C1B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ExplictAllowedInLastCheck;

			// Token: 0x04008C1C RID: 35868
			[Token(Token = "0x4008C1C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GetNetworkReachability;

			// Token: 0x02001732 RID: 5938
			[Token(Token = "0x2001732")]
			public struct Options
			{
				// Token: 0x04008C1D RID: 35869
				[Token(Token = "0x4008C1D")]
				[FieldOffset(Offset = "0x0")]
				public string alertCarrierNetwork;

				// Token: 0x04008C1E RID: 35870
				[Token(Token = "0x4008C1E")]
				[FieldOffset(Offset = "0x8")]
				public long minBytesToNotifyCarrier;
			}
		}
	}
}
