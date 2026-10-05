using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Network;
using Torappu.UI.ActivityStage.Extern;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006D05 RID: 27909
	[Token(Token = "0x2006D05")]
	[ExecuteInEditMode]
	public abstract class ActivityStageController : MonoBehaviour, IPageProvider, IHotfixable
	{
		// Token: 0x17005E0B RID: 24075
		// (get) Token: 0x06027CA3 RID: 162979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E0B")]
		public ActivityStageController.Core frameworkOnlyCore
		{
			[Token(Token = "0x6027CA3")]
			[Address(RVA = "0x22F5E60", Offset = "0x22F4A60", VA = "0x1822F5E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E0C RID: 24076
		// (get) Token: 0x06027CA4 RID: 162980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E0C")]
		public ActivityStageSingleComponent mapDecor
		{
			[Token(Token = "0x6027CA4")]
			[Address(RVA = "0x22F60B0", Offset = "0x22F4CB0", VA = "0x1822F60B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E0D RID: 24077
		// (get) Token: 0x06027CA5 RID: 162981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E0D")]
		public ActivityStageSingleComponent entry
		{
			[Token(Token = "0x6027CA5")]
			[Address(RVA = "0x22F5D30", Offset = "0x22F4930", VA = "0x1822F5D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E0E RID: 24078
		// (get) Token: 0x06027CA6 RID: 162982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E0E")]
		public ActivityStageSingleComponent floatPanel
		{
			[Token(Token = "0x6027CA6")]
			[Address(RVA = "0x22F5E00", Offset = "0x22F4A00", VA = "0x1822F5E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E0F RID: 24079
		// (get) Token: 0x06027CA7 RID: 162983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E0F")]
		public ActivityStageSingleComponent stagePreviewPanel
		{
			[Token(Token = "0x6027CA7")]
			[Address(RVA = "0x22F6200", Offset = "0x22F4E00", VA = "0x1822F6200")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E10 RID: 24080
		// (get) Token: 0x06027CA8 RID: 162984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E10")]
		public UIPage page
		{
			[Token(Token = "0x6027CA8")]
			[Address(RVA = "0x22F6190", Offset = "0x22F4D90", VA = "0x1822F6190", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E11 RID: 24081
		// (get) Token: 0x06027CA9 RID: 162985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E11")]
		public string activityId
		{
			[Token(Token = "0x6027CA9")]
			[Address(RVA = "0x22F5A80", Offset = "0x22F4680", VA = "0x1822F5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E12 RID: 24082
		// (get) Token: 0x06027CAA RID: 162986 RVA: 0x000CF720 File Offset: 0x000CD920
		[Token(Token = "0x17005E12")]
		public ActivityStageController.ActivityMetaWrapper initMetaWrapper
		{
			[Token(Token = "0x6027CAA")]
			[Address(RVA = "0x22F6020", Offset = "0x22F4C20", VA = "0x1822F6020")]
			get
			{
				return default(ActivityStageController.ActivityMetaWrapper);
			}
		}

		// Token: 0x17005E13 RID: 24083
		// (get) Token: 0x06027CAB RID: 162987 RVA: 0x000CF738 File Offset: 0x000CD938
		[Token(Token = "0x17005E13")]
		public ActivityStageController.ActivityControllerTransitionContext transitionContext
		{
			[Token(Token = "0x6027CAB")]
			[Address(RVA = "0x22F6260", Offset = "0x22F4E60", VA = "0x1822F6260")]
			get
			{
				return default(ActivityStageController.ActivityControllerTransitionContext);
			}
		}

		// Token: 0x17005E14 RID: 24084
		// (get) Token: 0x06027CAC RID: 162988 RVA: 0x000CF750 File Offset: 0x000CD950
		[Token(Token = "0x17005E14")]
		public ActivityBasicInfo basicInfo
		{
			[Token(Token = "0x6027CAC")]
			[Address(RVA = "0x22F5B00", Offset = "0x22F4700", VA = "0x1822F5B00")]
			get
			{
				return default(ActivityBasicInfo);
			}
		}

		// Token: 0x17005E15 RID: 24085
		// (get) Token: 0x06027CAD RID: 162989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E15")]
		public static StaticOutlinks outlinks
		{
			[Token(Token = "0x6027CAD")]
			[Address(RVA = "0x22F6110", Offset = "0x22F4D10", VA = "0x1822F6110")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027CAE RID: 162990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CAE")]
		public UISender.ResultHandler<ResType> SendRequest<ResType>(Request request) where ResType : class
		{
			return null;
		}

		// Token: 0x06027CAF RID: 162991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CAF")]
		[Address(RVA = "0x22F41A0", Offset = "0x22F2DA0", VA = "0x1822F41A0")]
		public ActivityStageBridge GetBridge()
		{
			return null;
		}

		// Token: 0x06027CB0 RID: 162992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CB0")]
		public static T SingleComponent<T>() where T : ActivityStageSingleComponent
		{
			return null;
		}

		// Token: 0x06027CB1 RID: 162993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CB1")]
		[Address(RVA = "0x22F4AC0", Offset = "0x22F36C0", VA = "0x1822F4AC0")]
		public static ActivityStageSingleComponent SingleComponent(Type type)
		{
			return null;
		}

		// Token: 0x06027CB2 RID: 162994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CB2")]
		[Address(RVA = "0x22F4380", Offset = "0x22F2F80", VA = "0x1822F4380")]
		public ActivityStageSingleComponent InstSingleComponent(Type type)
		{
			return null;
		}

		// Token: 0x06027CB3 RID: 162995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CB3")]
		public T InstSingleComponent<T>() where T : ActivityStageSingleComponent
		{
			return null;
		}

		// Token: 0x06027CB4 RID: 162996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CB4")]
		[Address(RVA = "0x22F3EE0", Offset = "0x22F2AE0", VA = "0x1822F3EE0")]
		public static ActivityStageController FindInstanceInPage()
		{
			return null;
		}

		// Token: 0x06027CB5 RID: 162997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CB5")]
		[Address(RVA = "0x22F3E20", Offset = "0x22F2A20", VA = "0x1822F3E20")]
		public static ActivityStageBridge FindActiveBridge()
		{
			return null;
		}

		// Token: 0x06027CB6 RID: 162998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CB6")]
		[Address(RVA = "0x22F5420", Offset = "0x22F4020", VA = "0x1822F5420")]
		private UIAssetLoader.Assets _EnsureAssets()
		{
			return null;
		}

		// Token: 0x06027CB7 RID: 162999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CB7")]
		public static T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06027CB8 RID: 163000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CB8")]
		public T LoadAssetImpl<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06027CB9 RID: 163001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CB9")]
		[Address(RVA = "0x22F5970", Offset = "0x22F4570", VA = "0x1822F5970")]
		private void _UnloadAssetImpl()
		{
		}

		// Token: 0x06027CBA RID: 163002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CBA")]
		[Address(RVA = "0x22F48B0", Offset = "0x22F34B0", VA = "0x1822F48B0")]
		public static string SerializeInitMeta(object initMeta)
		{
			return null;
		}

		// Token: 0x06027CBB RID: 163003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CBB")]
		public static MetaType DeserializeInitMeta<MetaType>(string initMeta)
		{
			return null;
		}

		// Token: 0x06027CBC RID: 163004
		[Token(Token = "0x6027CBC")]
		protected abstract ActivityStageBridge CreateBridge();

		// Token: 0x17005E16 RID: 24086
		// (get) Token: 0x06027CBD RID: 163005 RVA: 0x000CF768 File Offset: 0x000CD968
		[Token(Token = "0x17005E16")]
		public virtual bool disableStageEntryPartical
		{
			[Token(Token = "0x6027CBD")]
			[Address(RVA = "0x22F5C20", Offset = "0x22F4820", VA = "0x1822F5C20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005E17 RID: 24087
		// (get) Token: 0x06027CBE RID: 163006 RVA: 0x000CF780 File Offset: 0x000CD980
		[Token(Token = "0x17005E17")]
		protected ActivityStageController.EntryTweenInType entryInType
		{
			[Token(Token = "0x6027CBE")]
			[Address(RVA = "0x22F5C80", Offset = "0x22F4880", VA = "0x1822F5C80")]
			get
			{
				return ActivityStageController.EntryTweenInType.FADE;
			}
		}

		// Token: 0x06027CBF RID: 163007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CBF")]
		[Address(RVA = "0x22F4000", Offset = "0x22F2C00", VA = "0x1822F4000", Slot = "7")]
		protected virtual string GetBGMSignal()
		{
			return null;
		}

		// Token: 0x06027CC0 RID: 163008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CC0")]
		[Address(RVA = "0x22F4320", Offset = "0x22F2F20", VA = "0x1822F4320", Slot = "8")]
		public virtual void InitController()
		{
		}

		// Token: 0x06027CC1 RID: 163009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CC1")]
		[Address(RVA = "0x22F44B0", Offset = "0x22F30B0", VA = "0x1822F44B0", Slot = "9")]
		public virtual IEnumerator LoadCoroutine()
		{
			return null;
		}

		// Token: 0x06027CC2 RID: 163010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CC2")]
		[Address(RVA = "0x22F45D0", Offset = "0x22F31D0", VA = "0x1822F45D0", Slot = "10")]
		protected virtual void OnLoaded()
		{
		}

		// Token: 0x06027CC3 RID: 163011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CC3")]
		[Address(RVA = "0x22F4D50", Offset = "0x22F3950", VA = "0x1822F4D50", Slot = "11")]
		protected virtual void TriggerActivityLoadedAVG()
		{
		}

		// Token: 0x06027CC4 RID: 163012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CC4")]
		[Address(RVA = "0x22F3970", Offset = "0x22F2570", VA = "0x1822F3970", Slot = "12")]
		protected virtual void BeforeUnload()
		{
		}

		// Token: 0x06027CC5 RID: 163013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CC5")]
		[Address(RVA = "0x22F4790", Offset = "0x22F3390", VA = "0x1822F4790", Slot = "13")]
		protected virtual void OnStageTimeout()
		{
		}

		// Token: 0x06027CC6 RID: 163014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CC6")]
		[Address(RVA = "0x22F4650", Offset = "0x22F3250", VA = "0x1822F4650", Slot = "14")]
		protected virtual void OnRewardTimeout()
		{
		}

		// Token: 0x06027CC7 RID: 163015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CC7")]
		[Address(RVA = "0x22F4A10", Offset = "0x22F3610", VA = "0x1822F4A10", Slot = "15")]
		protected virtual IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06027CC8 RID: 163016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CC8")]
		[Address(RVA = "0x22F4270", Offset = "0x22F2E70", VA = "0x1822F4270", Slot = "16")]
		protected virtual IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x06027CC9 RID: 163017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CC9")]
		[Address(RVA = "0x22F4710", Offset = "0x22F3310", VA = "0x1822F4710", Slot = "17")]
		protected virtual void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x06027CCA RID: 163018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CCA")]
		[Address(RVA = "0x22F46B0", Offset = "0x22F32B0", VA = "0x1822F46B0", Slot = "18")]
		protected virtual void OnStagePageHideEffect()
		{
		}

		// Token: 0x06027CCB RID: 163019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CCB")]
		[Address(RVA = "0x22F47F0", Offset = "0x22F33F0", VA = "0x1822F47F0", Slot = "19")]
		protected virtual void OnStageZoneSelectStateSetEffect(bool enable)
		{
		}

		// Token: 0x06027CCC RID: 163020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CCC")]
		[Address(RVA = "0x22F4210", Offset = "0x22F2E10", VA = "0x1822F4210", Slot = "20")]
		public virtual IEnumerator GetReadySignalForStagePage()
		{
			return null;
		}

		// Token: 0x06027CCD RID: 163021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CCD")]
		[Address(RVA = "0x22F4560", Offset = "0x22F3160", VA = "0x1822F4560", Slot = "21")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06027CCE RID: 163022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CCE")]
		[Address(RVA = "0x22F5000", Offset = "0x22F3C00", VA = "0x1822F5000")]
		public IEnumerator TriggerShowCoroutine()
		{
			return null;
		}

		// Token: 0x06027CCF RID: 163023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CCF")]
		[Address(RVA = "0x22F4F50", Offset = "0x22F3B50", VA = "0x1822F4F50")]
		public IEnumerator TriggerHideCoroutine()
		{
			return null;
		}

		// Token: 0x06027CD0 RID: 163024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CD0")]
		[Address(RVA = "0x22F4130", Offset = "0x22F2D30", VA = "0x1822F4130")]
		public string GetBgmInstIdAlias()
		{
			return null;
		}

		// Token: 0x06027CD1 RID: 163025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CD1")]
		[Address(RVA = "0x22F4850", Offset = "0x22F3450", VA = "0x1822F4850", Slot = "22")]
		public virtual ActivityStageController.OnStageFogUnlock OverrideStageFogUnlock()
		{
			return null;
		}

		// Token: 0x06027CD2 RID: 163026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CD2")]
		[Address(RVA = "0x22F4EF0", Offset = "0x22F3AF0", VA = "0x1822F4EF0")]
		protected void TriggerBGMSignalManually()
		{
		}

		// Token: 0x06027CD3 RID: 163027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CD3")]
		[Address(RVA = "0x22F3D70", Offset = "0x22F2970", VA = "0x1822F3D70")]
		protected IEnumerator FadeInShowEffect()
		{
			return null;
		}

		// Token: 0x06027CD4 RID: 163028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CD4")]
		[Address(RVA = "0x22F39E0", Offset = "0x22F25E0", VA = "0x1822F39E0")]
		protected IEnumerator BlackInShowEffect([Optional] IEnumerator actionWhileLoading)
		{
			return null;
		}

		// Token: 0x06027CD5 RID: 163029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CD5")]
		[Address(RVA = "0x22F3CC0", Offset = "0x22F28C0", VA = "0x1822F3CC0")]
		protected IEnumerator DefaultShowEffect()
		{
			return null;
		}

		// Token: 0x06027CD6 RID: 163030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CD6")]
		[Address(RVA = "0x22F3C10", Offset = "0x22F2810", VA = "0x1822F3C10")]
		protected IEnumerator DefaultHideEffect()
		{
			return null;
		}

		// Token: 0x06027CD7 RID: 163031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CD7")]
		[Address(RVA = "0x22F3B60", Offset = "0x22F2760", VA = "0x1822F3B60")]
		protected IEnumerator BlackMaskFadeShowEffect()
		{
			return null;
		}

		// Token: 0x06027CD8 RID: 163032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CD8")]
		[Address(RVA = "0x22F3AB0", Offset = "0x22F26B0", VA = "0x1822F3AB0")]
		protected IEnumerator BlackMaskFadeHideEffect()
		{
			return null;
		}

		// Token: 0x06027CD9 RID: 163033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CD9")]
		[Address(RVA = "0x22F54B0", Offset = "0x22F40B0", VA = "0x1822F54B0")]
		private static CanvasGroup _EnsureCanvasGroup(MonoBehaviour obj)
		{
			return null;
		}

		// Token: 0x06027CDA RID: 163034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CDA")]
		[Address(RVA = "0x22F56D0", Offset = "0x22F42D0", VA = "0x1822F56D0")]
		private void _TriggerBGMSignal()
		{
		}

		// Token: 0x06027CDB RID: 163035 RVA: 0x000CF798 File Offset: 0x000CD998
		[Token(Token = "0x6027CDB")]
		[Address(RVA = "0x22F4C80", Offset = "0x22F3880", VA = "0x1822F4C80")]
		protected static bool TestBGMSubSignal(string subSignal)
		{
			return default(bool);
		}

		// Token: 0x06027CDC RID: 163036 RVA: 0x000CF7B0 File Offset: 0x000CD9B0
		[Token(Token = "0x6027CDC")]
		[Address(RVA = "0x22F5340", Offset = "0x22F3F40", VA = "0x1822F5340")]
		private static UIMusicManager.ChunkConfig _CreateActMusicChunk(string subSignal)
		{
			return default(UIMusicManager.ChunkConfig);
		}

		// Token: 0x06027CDD RID: 163037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CDD")]
		[Address(RVA = "0x22F5220", Offset = "0x22F3E20", VA = "0x1822F5220")]
		private void _ClearBGM()
		{
		}

		// Token: 0x06027CDE RID: 163038 RVA: 0x000CF7C8 File Offset: 0x000CD9C8
		[Token(Token = "0x6027CDE")]
		[Address(RVA = "0x22F50B0", Offset = "0x22F3CB0", VA = "0x1822F50B0")]
		private long _BGMInstId()
		{
			return 0L;
		}

		// Token: 0x06027CDF RID: 163039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CDF")]
		[Address(RVA = "0x22F5190", Offset = "0x22F3D90", VA = "0x1822F5190")]
		private void _BlockRaycast()
		{
		}

		// Token: 0x06027CE0 RID: 163040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CE0")]
		[Address(RVA = "0x22F52C0", Offset = "0x22F3EC0", VA = "0x1822F52C0")]
		private void _ClearRaycastBlocker()
		{
		}

		// Token: 0x06027CE1 RID: 163041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027CE1")]
		[Address(RVA = "0x22F5600", Offset = "0x22F4200", VA = "0x1822F5600")]
		private IEnumerator _ShowBlackLoadingMaskAndHide(bool fadeIn)
		{
			return null;
		}

		// Token: 0x06027CE2 RID: 163042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027CE2")]
		[Address(RVA = "0x22F59E0", Offset = "0x22F45E0", VA = "0x1822F59E0")]
		protected ActivityStageController()
		{
		}

		// Token: 0x040386DE RID: 231134
		[Token(Token = "0x40386DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private List<ActivityStageComponent> _components;

		// Token: 0x040386DF RID: 231135
		[Token(Token = "0x40386DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActivityStageSingleComponent _mapDecor;

		// Token: 0x040386E0 RID: 231136
		[Token(Token = "0x40386E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActivityStageSingleComponent _entry;

		// Token: 0x040386E1 RID: 231137
		[Token(Token = "0x40386E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActivityStageSingleComponent _float;

		// Token: 0x040386E2 RID: 231138
		[Token(Token = "0x40386E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ActivityStageSingleComponent _stagePreview;

		// Token: 0x040386E3 RID: 231139
		[Token(Token = "0x40386E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ActivityStageController.EntryTweenInType _entryInType;

		// Token: 0x040386E4 RID: 231140
		[Token(Token = "0x40386E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private StageZoneSelectBlackLoadingManager.BlackLoadingType _entryTransitionType;

		// Token: 0x040386E5 RID: 231141
		[Token(Token = "0x40386E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UIPopupWindow.UIBlocker m_uiBlocker;

		// Token: 0x040386E6 RID: 231142
		[Token(Token = "0x40386E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UIAssetLoader.Assets m_assets;

		// Token: 0x040386E7 RID: 231143
		[Token(Token = "0x40386E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ActivityStageController.Core m_core;

		// Token: 0x040386E8 RID: 231144
		[Token(Token = "0x40386E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_frameworkOnlyCore;

		// Token: 0x040386E9 RID: 231145
		[Token(Token = "0x40386E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_mapDecor;

		// Token: 0x040386EA RID: 231146
		[Token(Token = "0x40386EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_entry;

		// Token: 0x040386EB RID: 231147
		[Token(Token = "0x40386EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_floatPanel;

		// Token: 0x040386EC RID: 231148
		[Token(Token = "0x40386EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stagePreviewPanel;

		// Token: 0x040386ED RID: 231149
		[Token(Token = "0x40386ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x040386EE RID: 231150
		[Token(Token = "0x40386EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x040386EF RID: 231151
		[Token(Token = "0x40386EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_initMetaWrapper;

		// Token: 0x040386F0 RID: 231152
		[Token(Token = "0x40386F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_transitionContext;

		// Token: 0x040386F1 RID: 231153
		[Token(Token = "0x40386F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_basicInfo;

		// Token: 0x040386F2 RID: 231154
		[Token(Token = "0x40386F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_outlinks;

		// Token: 0x040386F3 RID: 231155
		[Token(Token = "0x40386F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x040386F4 RID: 231156
		[Token(Token = "0x40386F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetBridge;

		// Token: 0x040386F5 RID: 231157
		[Token(Token = "0x40386F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SingleComponent;

		// Token: 0x040386F6 RID: 231158
		[Token(Token = "0x40386F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_SingleComponent;

		// Token: 0x040386F7 RID: 231159
		[Token(Token = "0x40386F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_InstSingleComponent;

		// Token: 0x040386F8 RID: 231160
		[Token(Token = "0x40386F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1_InstSingleComponent;

		// Token: 0x040386F9 RID: 231161
		[Token(Token = "0x40386F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_FindInstanceInPage;

		// Token: 0x040386FA RID: 231162
		[Token(Token = "0x40386FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_FindActiveBridge;

		// Token: 0x040386FB RID: 231163
		[Token(Token = "0x40386FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__EnsureAssets;

		// Token: 0x040386FC RID: 231164
		[Token(Token = "0x40386FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x040386FD RID: 231165
		[Token(Token = "0x40386FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadAssetImpl;

		// Token: 0x040386FE RID: 231166
		[Token(Token = "0x40386FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UnloadAssetImpl;

		// Token: 0x040386FF RID: 231167
		[Token(Token = "0x40386FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SerializeInitMeta;

		// Token: 0x04038700 RID: 231168
		[Token(Token = "0x4038700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_DeserializeInitMeta;

		// Token: 0x04038701 RID: 231169
		[Token(Token = "0x4038701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_disableStageEntryPartical;

		// Token: 0x04038702 RID: 231170
		[Token(Token = "0x4038702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_entryInType;

		// Token: 0x04038703 RID: 231171
		[Token(Token = "0x4038703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetBGMSignal;

		// Token: 0x04038704 RID: 231172
		[Token(Token = "0x4038704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_InitController;

		// Token: 0x04038705 RID: 231173
		[Token(Token = "0x4038705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_LoadCoroutine;

		// Token: 0x04038706 RID: 231174
		[Token(Token = "0x4038706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x04038707 RID: 231175
		[Token(Token = "0x4038707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_TriggerActivityLoadedAVG;

		// Token: 0x04038708 RID: 231176
		[Token(Token = "0x4038708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_BeforeUnload;

		// Token: 0x04038709 RID: 231177
		[Token(Token = "0x4038709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403870A RID: 231178
		[Token(Token = "0x403870A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnRewardTimeout;

		// Token: 0x0403870B RID: 231179
		[Token(Token = "0x403870B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403870C RID: 231180
		[Token(Token = "0x403870C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403870D RID: 231181
		[Token(Token = "0x403870D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403870E RID: 231182
		[Token(Token = "0x403870E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnStagePageHideEffect;

		// Token: 0x0403870F RID: 231183
		[Token(Token = "0x403870F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_OnStageZoneSelectStateSetEffect;

		// Token: 0x04038710 RID: 231184
		[Token(Token = "0x4038710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GetReadySignalForStagePage;

		// Token: 0x04038711 RID: 231185
		[Token(Token = "0x4038711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04038712 RID: 231186
		[Token(Token = "0x4038712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_TriggerShowCoroutine;

		// Token: 0x04038713 RID: 231187
		[Token(Token = "0x4038713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_TriggerHideCoroutine;

		// Token: 0x04038714 RID: 231188
		[Token(Token = "0x4038714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_GetBgmInstIdAlias;

		// Token: 0x04038715 RID: 231189
		[Token(Token = "0x4038715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_OverrideStageFogUnlock;

		// Token: 0x04038716 RID: 231190
		[Token(Token = "0x4038716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_TriggerBGMSignalManually;

		// Token: 0x04038717 RID: 231191
		[Token(Token = "0x4038717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_FadeInShowEffect;

		// Token: 0x04038718 RID: 231192
		[Token(Token = "0x4038718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_BlackInShowEffect;

		// Token: 0x04038719 RID: 231193
		[Token(Token = "0x4038719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_DefaultShowEffect;

		// Token: 0x0403871A RID: 231194
		[Token(Token = "0x403871A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_DefaultHideEffect;

		// Token: 0x0403871B RID: 231195
		[Token(Token = "0x403871B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_BlackMaskFadeShowEffect;

		// Token: 0x0403871C RID: 231196
		[Token(Token = "0x403871C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_BlackMaskFadeHideEffect;

		// Token: 0x0403871D RID: 231197
		[Token(Token = "0x403871D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__EnsureCanvasGroup;

		// Token: 0x0403871E RID: 231198
		[Token(Token = "0x403871E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__TriggerBGMSignal;

		// Token: 0x0403871F RID: 231199
		[Token(Token = "0x403871F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_TestBGMSubSignal;

		// Token: 0x04038720 RID: 231200
		[Token(Token = "0x4038720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__CreateActMusicChunk;

		// Token: 0x04038721 RID: 231201
		[Token(Token = "0x4038721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x04038722 RID: 231202
		[Token(Token = "0x4038722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__BGMInstId;

		// Token: 0x04038723 RID: 231203
		[Token(Token = "0x4038723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__BlockRaycast;

		// Token: 0x04038724 RID: 231204
		[Token(Token = "0x4038724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__ClearRaycastBlocker;

		// Token: 0x04038725 RID: 231205
		[Token(Token = "0x4038725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__ShowBlackLoadingMaskAndHide;

		// Token: 0x04038726 RID: 231206
		[Token(Token = "0x4038726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006D06 RID: 27910
		[Token(Token = "0x2006D06")]
		public struct Param
		{
			// Token: 0x04038727 RID: 231207
			[Token(Token = "0x4038727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string dynEntryId;

			// Token: 0x04038728 RID: 231208
			[Token(Token = "0x4038728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ActivityStageDynEntry dynEntryPrefab;
		}

		// Token: 0x02006D07 RID: 27911
		[Token(Token = "0x2006D07")]
		public class Core
		{
			// Token: 0x17005E18 RID: 24088
			// (get) Token: 0x06027CE3 RID: 163043 RVA: 0x000CF7E0 File Offset: 0x000CD9E0
			// (set) Token: 0x06027CE4 RID: 163044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E18")]
			public ActivityStageController.ActivityMetaWrapper initMetaWrapper
			{
				[Token(Token = "0x6027CE3")]
				[Address(RVA = "0x22F8860", Offset = "0x22F7460", VA = "0x1822F8860")]
				[CompilerGenerated]
				get
				{
					return default(ActivityStageController.ActivityMetaWrapper);
				}
				[Token(Token = "0x6027CE4")]
				[Address(RVA = "0x22F7B90", Offset = "0x22F6790", VA = "0x1822F7B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17005E19 RID: 24089
			// (get) Token: 0x06027CE5 RID: 163045 RVA: 0x000CF7F8 File Offset: 0x000CD9F8
			// (set) Token: 0x06027CE6 RID: 163046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E19")]
			public ActivityStageController.ActivityControllerTransitionContext transitionContext
			{
				[Token(Token = "0x6027CE5")]
				[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
				[CompilerGenerated]
				get
				{
					return default(ActivityStageController.ActivityControllerTransitionContext);
				}
				[Token(Token = "0x6027CE6")]
				[Address(RVA = "0x22F7BB0", Offset = "0x22F67B0", VA = "0x1822F7BB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17005E1A RID: 24090
			// (get) Token: 0x06027CE7 RID: 163047 RVA: 0x000CF810 File Offset: 0x000CDA10
			// (set) Token: 0x06027CE8 RID: 163048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E1A")]
			public ActivityBasicInfo basicInfo
			{
				[Token(Token = "0x6027CE7")]
				[Address(RVA = "0x22F8700", Offset = "0x22F7300", VA = "0x1822F8700")]
				[CompilerGenerated]
				get
				{
					return default(ActivityBasicInfo);
				}
				[Token(Token = "0x6027CE8")]
				[Address(RVA = "0x22F89E0", Offset = "0x22F75E0", VA = "0x1822F89E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17005E1B RID: 24091
			// (get) Token: 0x06027CE9 RID: 163049 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027CEA RID: 163050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E1B")]
			public UIPage page
			{
				[Token(Token = "0x6027CE9")]
				[Address(RVA = "0x22F8880", Offset = "0x22F7480", VA = "0x1822F8880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6027CEA")]
				[Address(RVA = "0x22F8A90", Offset = "0x22F7690", VA = "0x1822F8A90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17005E1C RID: 24092
			// (get) Token: 0x06027CEB RID: 163051 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027CEC RID: 163052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E1C")]
			public ActivityStageSingleComponent dynEntry
			{
				[Token(Token = "0x6027CEB")]
				[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6027CEC")]
				[Address(RVA = "0x22F8A40", Offset = "0x22F7640", VA = "0x1822F8A40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06027CED RID: 163053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027CED")]
			[Address(RVA = "0x22F8560", Offset = "0x22F7160", VA = "0x1822F8560")]
			public Core(ActivityStageController closure)
			{
			}

			// Token: 0x17005E1D RID: 24093
			// (get) Token: 0x06027CEE RID: 163054 RVA: 0x000CF828 File Offset: 0x000CDA28
			[Token(Token = "0x17005E1D")]
			public bool isInited
			{
				[Token(Token = "0x6027CEE")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005E1E RID: 24094
			// (get) Token: 0x06027CEF RID: 163055 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027CF0 RID: 163056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005E1E")]
			public string dynEntryId
			{
				[Token(Token = "0x6027CEF")]
				[Address(RVA = "0x22F8830", Offset = "0x22F7430", VA = "0x1822F8830")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6027CF0")]
				[Address(RVA = "0x22F8A30", Offset = "0x22F7630", VA = "0x1822F8A30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17005E1F RID: 24095
			// (get) Token: 0x06027CF1 RID: 163057 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005E1F")]
			public string bgmInstIdAlias
			{
				[Token(Token = "0x6027CF1")]
				[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06027CF2 RID: 163058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027CF2")]
			[Address(RVA = "0x22F7410", Offset = "0x22F6010", VA = "0x1822F7410")]
			public void Init(ActivityBasicInfo basicInfo, UIPage page, ActivityStageController.Param param)
			{
			}

			// Token: 0x17005E20 RID: 24096
			// (get) Token: 0x06027CF3 RID: 163059 RVA: 0x000CF840 File Offset: 0x000CDA40
			[Token(Token = "0x17005E20")]
			public int assetGroupId
			{
				[Token(Token = "0x6027CF3")]
				[Address(RVA = "0x22F8690", Offset = "0x22F7290", VA = "0x1822F8690")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17005E21 RID: 24097
			// (get) Token: 0x06027CF4 RID: 163060 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005E21")]
			public UIDisposableSender actSender
			{
				[Token(Token = "0x6027CF4")]
				[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
				get
				{
					return null;
				}
			}

			// Token: 0x06027CF5 RID: 163061 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027CF5")]
			[Address(RVA = "0x22F7B90", Offset = "0x22F6790", VA = "0x1822F7B90")]
			public void SetInitMeta(ActivityStageController.ActivityMetaWrapper initWrapper)
			{
			}

			// Token: 0x06027CF6 RID: 163062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027CF6")]
			[Address(RVA = "0x22F7BB0", Offset = "0x22F67B0", VA = "0x1822F7BB0")]
			public void SetTransitionContext(ActivityStageController.ActivityControllerTransitionContext transitionContext)
			{
			}

			// Token: 0x06027CF7 RID: 163063 RVA: 0x000CF858 File Offset: 0x000CDA58
			[Token(Token = "0x6027CF7")]
			[Address(RVA = "0x22F7ED0", Offset = "0x22F6AD0", VA = "0x1822F7ED0")]
			private bool _CheckIfInited()
			{
				return default(bool);
			}

			// Token: 0x17005E22 RID: 24098
			// (get) Token: 0x06027CF8 RID: 163064 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005E22")]
			public ActivityStageBridge bridge
			{
				[Token(Token = "0x6027CF8")]
				[Address(RVA = "0x22F8760", Offset = "0x22F7360", VA = "0x1822F8760")]
				get
				{
					return null;
				}
			}

			// Token: 0x06027CF9 RID: 163065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027CF9")]
			[Address(RVA = "0x22F73B0", Offset = "0x22F5FB0", VA = "0x1822F73B0")]
			public void ClearBridge()
			{
			}

			// Token: 0x06027CFA RID: 163066 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027CFA")]
			[Address(RVA = "0x22F7BC0", Offset = "0x22F67C0", VA = "0x1822F7BC0")]
			public ActivityStageSingleComponent SingleComponent(Type type)
			{
				return null;
			}

			// Token: 0x17005E23 RID: 24099
			// (get) Token: 0x06027CFB RID: 163067 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005E23")]
			public List<ActivityStageComponent> components
			{
				[Token(Token = "0x6027CFB")]
				[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
				get
				{
					return null;
				}
			}

			// Token: 0x06027CFC RID: 163068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027CFC")]
			[Address(RVA = "0x22F7D20", Offset = "0x22F6920", VA = "0x1822F7D20")]
			public void TriggerLoaded()
			{
			}

			// Token: 0x06027CFD RID: 163069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027CFD")]
			[Address(RVA = "0x22F7CC0", Offset = "0x22F68C0", VA = "0x1822F7CC0")]
			public void TriggerBeforeUnload()
			{
			}

			// Token: 0x06027CFE RID: 163070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027CFE")]
			[Address(RVA = "0x22F7E10", Offset = "0x22F6A10", VA = "0x1822F7E10")]
			public void TriggerStagePageResumed(UIPageTransContext context)
			{
			}

			// Token: 0x06027CFF RID: 163071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027CFF")]
			[Address(RVA = "0x22F7DD0", Offset = "0x22F69D0", VA = "0x1822F7DD0")]
			public void TriggerStagePageHideEffect()
			{
			}

			// Token: 0x06027D00 RID: 163072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027D00")]
			[Address(RVA = "0x22F7E80", Offset = "0x22F6A80", VA = "0x1822F7E80")]
			public void TriggerStageZoneSelectStateSetEffectEnable(bool enable)
			{
			}

			// Token: 0x06027D01 RID: 163073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027D01")]
			[Address(RVA = "0x22F7C80", Offset = "0x22F6880", VA = "0x1822F7C80")]
			public void Tick()
			{
			}

			// Token: 0x06027D02 RID: 163074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027D02")]
			[Address(RVA = "0x22F8290", Offset = "0x22F6E90", VA = "0x1822F8290")]
			private void _UpdateStageCountDown()
			{
			}

			// Token: 0x06027D03 RID: 163075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027D03")]
			[Address(RVA = "0x22F8070", Offset = "0x22F6C70", VA = "0x1822F8070")]
			private void _UpdateRewardCountDown()
			{
			}

			// Token: 0x06027D04 RID: 163076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027D04")]
			[Address(RVA = "0x22F8010", Offset = "0x22F6C10", VA = "0x1822F8010")]
			private void _OnStageTimeout()
			{
			}

			// Token: 0x06027D05 RID: 163077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027D05")]
			[Address(RVA = "0x22F7FB0", Offset = "0x22F6BB0", VA = "0x1822F7FB0")]
			private void _OnRewardTimeout()
			{
			}

			// Token: 0x04038729 RID: 231209
			[Token(Token = "0x4038729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool m_isInited;

			// Token: 0x0403872A RID: 231210
			[Token(Token = "0x403872A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private ActivityStageController m_closure;

			// Token: 0x0403872B RID: 231211
			[Token(Token = "0x403872B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Dictionary<Type, ActivityStageSingleComponent> m_singleInstSearchTable;

			// Token: 0x0403872C RID: 231212
			[Token(Token = "0x403872C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ActivityStageBridge m_bridge;

			// Token: 0x0403872D RID: 231213
			[Token(Token = "0x403872D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int m_assetGroupId;

			// Token: 0x0403872E RID: 231214
			[Token(Token = "0x403872E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private CountDownTask m_stageCountDown;

			// Token: 0x0403872F RID: 231215
			[Token(Token = "0x403872F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private CountDownTask m_rewardCountDown;

			// Token: 0x04038730 RID: 231216
			[Token(Token = "0x4038730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UIDisposableSender m_actSender;

			// Token: 0x04038731 RID: 231217
			[Token(Token = "0x4038731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private List<ActivityStageComponent> m_components;

			// Token: 0x04038732 RID: 231218
			[Token(Token = "0x4038732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private string m_bgmInstIdAlias;
		}

		// Token: 0x02006D08 RID: 27912
		[Token(Token = "0x2006D08")]
		public struct ActivityMetaWrapper
		{
			// Token: 0x04038739 RID: 231225
			[Token(Token = "0x4038739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string metaContent;

			// Token: 0x0403873A RID: 231226
			[Token(Token = "0x403873A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string targetZoneId;

			// Token: 0x0403873B RID: 231227
			[Token(Token = "0x403873B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string targetStageId;

			// Token: 0x0403873C RID: 231228
			[Token(Token = "0x403873C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool forceSkipEnterAnim;
		}

		// Token: 0x02006D09 RID: 27913
		[Token(Token = "0x2006D09")]
		public struct ActivityControllerTransitionContext
		{
			// Token: 0x0403873D RID: 231229
			[Token(Token = "0x403873D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ActivityStageController.ActivityControllerTransitionType transitionType;

			// Token: 0x0403873E RID: 231230
			[Token(Token = "0x403873E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public ActivityStageController.ActivityControllerTransitionReason transitionReason;
		}

		// Token: 0x02006D0A RID: 27914
		[Token(Token = "0x2006D0A")]
		public enum ActivityControllerTransitionType
		{
			// Token: 0x04038740 RID: 231232
			[Token(Token = "0x4038740")]
			NONE,
			// Token: 0x04038741 RID: 231233
			[Token(Token = "0x4038741")]
			TRANSITION_IN,
			// Token: 0x04038742 RID: 231234
			[Token(Token = "0x4038742")]
			TRANSITION_OUT
		}

		// Token: 0x02006D0B RID: 27915
		[Token(Token = "0x2006D0B")]
		public enum ActivityControllerTransitionReason
		{
			// Token: 0x04038744 RID: 231236
			[Token(Token = "0x4038744")]
			NONE,
			// Token: 0x04038745 RID: 231237
			[Token(Token = "0x4038745")]
			DYN_ENTRY_REPLACE
		}

		// Token: 0x02006D0C RID: 27916
		[Token(Token = "0x2006D0C")]
		protected enum EntryTweenInType
		{
			// Token: 0x04038747 RID: 231239
			[Token(Token = "0x4038747")]
			FADE,
			// Token: 0x04038748 RID: 231240
			[Token(Token = "0x4038748")]
			BLACK
		}

		// Token: 0x02006D0D RID: 27917
		// (Invoke) Token: 0x06027D07 RID: 163079
		[Token(Token = "0x2006D0D")]
		public delegate void OnStageFogUnlock(StageData stageData, StageFogInfo stageFogInfo, Action onConfirmed);
	}
}
