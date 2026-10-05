using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E32 RID: 7730
	[Token(Token = "0x2001E32")]
	public class AVGController : SingletonMonoBehaviour<AVGController>, ISingletonNotAutoCreate, ILoadAsset, ISafeAreaListener
	{
		// Token: 0x0600BEEA RID: 48874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BEEA")]
		[Address(RVA = "0x33BB0F0", Offset = "0x33B9CF0", VA = "0x1833BB0F0")]
		private AVGController.AVGCompBridge _EnsureCompBridge()
		{
			return null;
		}

		// Token: 0x0600BEEB RID: 48875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BEEB")]
		[Address(RVA = "0x33BB5B0", Offset = "0x33BA1B0", VA = "0x1833BB5B0")]
		private AVGSceneEffectManager _GetOrCreateSceneEffectMgr()
		{
			return null;
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x0600BEEC RID: 48876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001702")]
		public string storyId
		{
			[Token(Token = "0x600BEEC")]
			[Address(RVA = "0x33BED10", Offset = "0x33BD910", VA = "0x1833BED10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x0600BEED RID: 48877 RVA: 0x00046740 File Offset: 0x00044940
		[Token(Token = "0x17001703")]
		public AVGStoryCache storyCache
		{
			[Token(Token = "0x600BEED")]
			[Address(RVA = "0x33BEC60", Offset = "0x33BD860", VA = "0x1833BEC60")]
			get
			{
				return default(AVGStoryCache);
			}
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x0600BEEE RID: 48878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001704")]
		public Dictionary<int, AVGCommandContext> contextDict
		{
			[Token(Token = "0x600BEEE")]
			[Address(RVA = "0x33BDDB0", Offset = "0x33BC9B0", VA = "0x1833BDDB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BEEF RID: 48879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BEEF")]
		[Address(RVA = "0x33B3E40", Offset = "0x33B2A40", VA = "0x1833B3E40")]
		public List<Command> GetContextCommandsByLineNumber(int lineNumber)
		{
			return null;
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x0600BEF0 RID: 48880 RVA: 0x00046758 File Offset: 0x00044958
		[Token(Token = "0x17001705")]
		public bool toastQuickPlay
		{
			[Token(Token = "0x600BEF0")]
			[Address(RVA = "0x33BEF00", Offset = "0x33BDB00", VA = "0x1833BEF00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x0600BEF1 RID: 48881 RVA: 0x00046770 File Offset: 0x00044970
		[Token(Token = "0x17001706")]
		public bool isSkippable
		{
			[Token(Token = "0x600BEF1")]
			[Address(RVA = "0x33BE3C0", Offset = "0x33BCFC0", VA = "0x1833BE3C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x0600BEF2 RID: 48882 RVA: 0x00046788 File Offset: 0x00044988
		// (set) Token: 0x0600BEF3 RID: 48883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001707")]
		public AVGStoryCache.AVGAutoMode autoPlayMode
		{
			[Token(Token = "0x600BEF2")]
			[Address(RVA = "0x33BD9D0", Offset = "0x33BC5D0", VA = "0x1833BD9D0")]
			get
			{
				return AVGStoryCache.AVGAutoMode.DEFAULT;
			}
			[Token(Token = "0x600BEF3")]
			[Address(RVA = "0x33BF2E0", Offset = "0x33BDEE0", VA = "0x1833BF2E0")]
			set
			{
			}
		}

		// Token: 0x0600BEF4 RID: 48884 RVA: 0x000467A0 File Offset: 0x000449A0
		[Token(Token = "0x600BEF4")]
		[Address(RVA = "0x33BBB40", Offset = "0x33BA740", VA = "0x1833BBB40")]
		private bool _IsReaderOrPureMode()
		{
			return default(bool);
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x0600BEF5 RID: 48885 RVA: 0x000467B8 File Offset: 0x000449B8
		[Token(Token = "0x17001708")]
		public float autoWaitBaseTime
		{
			[Token(Token = "0x600BEF5")]
			[Address(RVA = "0x33BDA50", Offset = "0x33BC650", VA = "0x1833BDA50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x0600BEF6 RID: 48886 RVA: 0x000467D0 File Offset: 0x000449D0
		[Token(Token = "0x17001709")]
		public float autoWaitTimePerText
		{
			[Token(Token = "0x600BEF6")]
			[Address(RVA = "0x33BDBD0", Offset = "0x33BC7D0", VA = "0x1833BDBD0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x0600BEF7 RID: 48887 RVA: 0x000467E8 File Offset: 0x000449E8
		[Token(Token = "0x1700170A")]
		public float typeWriterDelay
		{
			[Token(Token = "0x600BEF7")]
			[Address(RVA = "0x33BF160", Offset = "0x33BDD60", VA = "0x1833BF160")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x0600BEF8 RID: 48888 RVA: 0x00046800 File Offset: 0x00044A00
		[Token(Token = "0x1700170B")]
		public float animateRatio
		{
			[Token(Token = "0x600BEF8")]
			[Address(RVA = "0x33BD7F0", Offset = "0x33BC3F0", VA = "0x1833BD7F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x0600BEF9 RID: 48889 RVA: 0x00046818 File Offset: 0x00044A18
		[Token(Token = "0x1700170C")]
		public bool isTheaterMode
		{
			[Token(Token = "0x600BEF9")]
			[Address(RVA = "0x33BE550", Offset = "0x33BD150", VA = "0x1833BE550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x0600BEFA RID: 48890 RVA: 0x00046830 File Offset: 0x00044A30
		[Token(Token = "0x1700170D")]
		public bool isAutoClickRaised
		{
			[Token(Token = "0x600BEFA")]
			[Address(RVA = "0x33BE220", Offset = "0x33BCE20", VA = "0x1833BE220")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x0600BEFB RID: 48891 RVA: 0x00046848 File Offset: 0x00044A48
		[Token(Token = "0x1700170E")]
		public bool isRunning
		{
			[Token(Token = "0x600BEFB")]
			[Address(RVA = "0x33BE360", Offset = "0x33BCF60", VA = "0x1833BE360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x0600BEFC RID: 48892 RVA: 0x00046860 File Offset: 0x00044A60
		[Token(Token = "0x1700170F")]
		public bool isRunningTutorial
		{
			[Token(Token = "0x600BEFC")]
			[Address(RVA = "0x33BE2F0", Offset = "0x33BCEF0", VA = "0x1833BE2F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x0600BEFD RID: 48893 RVA: 0x00046878 File Offset: 0x00044A78
		// (set) Token: 0x0600BEFE RID: 48894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001710")]
		public int decisionIndex
		{
			[Token(Token = "0x600BEFD")]
			[Address(RVA = "0x33BDE10", Offset = "0x33BCA10", VA = "0x1833BDE10")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600BEFE")]
			[Address(RVA = "0x33BF450", Offset = "0x33BE050", VA = "0x1833BF450")]
			set
			{
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x0600BEFF RID: 48895 RVA: 0x00046890 File Offset: 0x00044A90
		[Token(Token = "0x17001711")]
		public bool isAutoable
		{
			[Token(Token = "0x600BEFF")]
			[Address(RVA = "0x33BE280", Offset = "0x33BCE80", VA = "0x1833BE280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x0600BF00 RID: 48896 RVA: 0x000468A8 File Offset: 0x00044AA8
		[Token(Token = "0x17001712")]
		public float storyProgress
		{
			[Token(Token = "0x600BF00")]
			[Address(RVA = "0x33BEE50", Offset = "0x33BDA50", VA = "0x1833BEE50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x0600BF01 RID: 48897 RVA: 0x000468C0 File Offset: 0x00044AC0
		[Token(Token = "0x17001713")]
		public Story.StoryParam storyParam
		{
			[Token(Token = "0x600BF01")]
			[Address(RVA = "0x33BEDA0", Offset = "0x33BD9A0", VA = "0x1833BEDA0")]
			get
			{
				return default(Story.StoryParam);
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x0600BF02 RID: 48898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001714")]
		public DecisionCommandPredicator sharedDecisionPredicator
		{
			[Token(Token = "0x600BF02")]
			[Address(RVA = "0x33BEC00", Offset = "0x33BD800", VA = "0x1833BEC00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BF03 RID: 48899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF03")]
		[Address(RVA = "0x33B8BF0", Offset = "0x33B77F0", VA = "0x1833B8BF0")]
		public void SetCommandPredicator(ICommandPredicator pred)
		{
		}

		// Token: 0x0600BF04 RID: 48900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF04")]
		[Address(RVA = "0x33B8B70", Offset = "0x33B7770", VA = "0x1833B8B70")]
		public void SetCommandFlowController(AVGController.ICommandFlowController controller)
		{
		}

		// Token: 0x0600BF05 RID: 48901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF05")]
		[Address(RVA = "0x33B8C70", Offset = "0x33B7870", VA = "0x1833B8C70")]
		public void SetCommandSkipController(AVGController.ICommandSkipController controller)
		{
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x0600BF06 RID: 48902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001715")]
		public AVGCanvasLayerHolder canvasHolder
		{
			[Token(Token = "0x600BF06")]
			[Address(RVA = "0x33BDD50", Offset = "0x33BC950", VA = "0x1833BDD50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x0600BF07 RID: 48903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001716")]
		public ILoadAsset assetLoader
		{
			[Token(Token = "0x600BF07")]
			[Address(RVA = "0x33BD970", Offset = "0x33BC570", VA = "0x1833BD970")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x0600BF08 RID: 48904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001717")]
		public EventPool<AVGController.Event> eventPool
		{
			[Token(Token = "0x600BF08")]
			[Address(RVA = "0x33BE080", Offset = "0x33BCC80", VA = "0x1833BE080")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x0600BF09 RID: 48905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001718")]
		public ResourceRouter router
		{
			[Token(Token = "0x600BF09")]
			[Address(RVA = "0x33BE9A0", Offset = "0x33BD5A0", VA = "0x1833BE9A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x0600BF0A RID: 48906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001719")]
		public Camera sceneCamera
		{
			[Token(Token = "0x600BF0A")]
			[Address(RVA = "0x33BEA00", Offset = "0x33BD600", VA = "0x1833BEA00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BF0B RID: 48907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF0B")]
		[Address(RVA = "0x33B8340", Offset = "0x33B6F40", VA = "0x1833B8340")]
		public void RunStory(Story story)
		{
		}

		// Token: 0x0600BF0C RID: 48908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF0C")]
		[Address(RVA = "0x33B9840", Offset = "0x33B8440", VA = "0x1833B9840")]
		public void StopStory(string errorMsg, bool isInterrupt = false)
		{
		}

		// Token: 0x0600BF0D RID: 48909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF0D")]
		[Address(RVA = "0x33B91E0", Offset = "0x33B7DE0", VA = "0x1833B91E0")]
		protected void SkipStory()
		{
		}

		// Token: 0x0600BF0E RID: 48910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF0E")]
		[Address(RVA = "0x33B3A20", Offset = "0x33B2620", VA = "0x1833B3A20")]
		protected void EndStory(string errorMsg, bool isInterrupt = false)
		{
		}

		// Token: 0x0600BF0F RID: 48911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF0F")]
		[Address(RVA = "0x33B6360", Offset = "0x33B4F60", VA = "0x1833B6360")]
		protected void OnStoryCommitted(bool isOk, Story.StoryOutPut outPut)
		{
		}

		// Token: 0x0600BF10 RID: 48912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF10")]
		[Address(RVA = "0x33B8F50", Offset = "0x33B7B50", VA = "0x1833B8F50")]
		public void SetQuickSpeed(int speed)
		{
		}

		// Token: 0x0600BF11 RID: 48913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF11")]
		[Address(RVA = "0x33B6A90", Offset = "0x33B5690", VA = "0x1833B6A90")]
		public void RaiseAutoClick(int messageLength)
		{
		}

		// Token: 0x0600BF12 RID: 48914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF12")]
		[Address(RVA = "0x33B6F00", Offset = "0x33B5B00", VA = "0x1833B6F00")]
		public void RaiseAutoClick(float delay)
		{
		}

		// Token: 0x0600BF13 RID: 48915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF13")]
		[Address(RVA = "0x33B7340", Offset = "0x33B5F40", VA = "0x1833B7340")]
		public void RaiseSignal(string command, string signal = "any")
		{
		}

		// Token: 0x0600BF14 RID: 48916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF14")]
		[Address(RVA = "0x33B7080", Offset = "0x33B5C80", VA = "0x1833B7080")]
		public void RaiseSignal(Command command)
		{
		}

		// Token: 0x0600BF15 RID: 48917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF15")]
		[Address(RVA = "0x33B7F90", Offset = "0x33B6B90", VA = "0x1833B7F90")]
		public void RegisterExecutor(ICommandExecutor executor)
		{
		}

		// Token: 0x0600BF16 RID: 48918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF16")]
		[Address(RVA = "0x33BA530", Offset = "0x33B9130", VA = "0x1833BA530")]
		public void UnregisterExecutor(ICommandExecutor executor)
		{
		}

		// Token: 0x0600BF17 RID: 48919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF17")]
		[Address(RVA = "0x33B7AE0", Offset = "0x33B66E0", VA = "0x1833B7AE0")]
		public void RegisterComponent(AVGComponent component)
		{
		}

		// Token: 0x0600BF18 RID: 48920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF18")]
		[Address(RVA = "0x33BA210", Offset = "0x33B8E10", VA = "0x1833BA210")]
		public void UnregisterComponent(AVGComponent component)
		{
		}

		// Token: 0x0600BF19 RID: 48921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF19")]
		[Address(RVA = "0x33B7920", Offset = "0x33B6520", VA = "0x1833B7920")]
		public void RegisterCommandPostChecker(ICommandPostChecker checker)
		{
		}

		// Token: 0x0600BF1A RID: 48922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF1A")]
		[Address(RVA = "0x33BA0D0", Offset = "0x33B8CD0", VA = "0x1833BA0D0")]
		public void UnregisterCommandPostChecker(ICommandPostChecker checker)
		{
		}

		// Token: 0x0600BF1B RID: 48923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF1B")]
		public T GetAVGComponentOrNull<T>() where T : AVGComponent
		{
			return null;
		}

		// Token: 0x0600BF1C RID: 48924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF1C")]
		[Address(RVA = "0x33B3620", Offset = "0x33B2220", VA = "0x1833B3620")]
		public Dictionary<int, AVGCommandContext> BuildTextCommandContexts(List<Command> commands)
		{
			return null;
		}

		// Token: 0x0600BF1D RID: 48925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF1D")]
		[Address(RVA = "0x33B8120", Offset = "0x33B6D20", VA = "0x1833B8120")]
		public void RegisterExtraGameObject(string name, GameObject go)
		{
		}

		// Token: 0x0600BF1E RID: 48926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF1E")]
		[Address(RVA = "0x33BA630", Offset = "0x33B9230", VA = "0x1833BA630")]
		public void UnregisterExtraGameObject(string name)
		{
		}

		// Token: 0x0600BF1F RID: 48927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF1F")]
		[Address(RVA = "0x33B3F00", Offset = "0x33B2B00", VA = "0x1833B3F00")]
		public GameObject GetExtraGameObject(string name)
		{
			return null;
		}

		// Token: 0x0600BF20 RID: 48928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF20")]
		public TComponent GetExtraGameObject<TComponent>(string name) where TComponent : Component
		{
			return null;
		}

		// Token: 0x0600BF21 RID: 48929 RVA: 0x000468D8 File Offset: 0x00044AD8
		[Token(Token = "0x600BF21")]
		[Address(RVA = "0x33B9BC0", Offset = "0x33B87C0", VA = "0x1833B9BC0")]
		public bool TryGetCharSortType(out CharacterSortType charSortType)
		{
			return default(bool);
		}

		// Token: 0x0600BF22 RID: 48930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF22")]
		[Address(RVA = "0x33BCF50", Offset = "0x33BBB50", VA = "0x1833BCF50")]
		private void _TryShowQuickPlayTip()
		{
		}

		// Token: 0x0600BF23 RID: 48931 RVA: 0x000468F0 File Offset: 0x00044AF0
		[Token(Token = "0x600BF23")]
		[Address(RVA = "0x33B4190", Offset = "0x33B2D90", VA = "0x1833B4190")]
		public bool IsTutorialWaitSignalMatchedStringParam(string waitSignal, string paramKey, string targetValue)
		{
			return default(bool);
		}

		// Token: 0x0600BF24 RID: 48932 RVA: 0x00046908 File Offset: 0x00044B08
		[Token(Token = "0x600BF24")]
		[Address(RVA = "0x33BBBC0", Offset = "0x33BA7C0", VA = "0x1833BBBC0")]
		protected bool _IsTutorialAndWaitSignal(string waitSignal, out Command command)
		{
			return default(bool);
		}

		// Token: 0x0600BF25 RID: 48933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF25")]
		[Address(RVA = "0x33B3870", Offset = "0x33B2470", VA = "0x1833B3870")]
		protected IEnumerator DoExecuteCommands()
		{
			return null;
		}

		// Token: 0x0600BF26 RID: 48934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF26")]
		[Address(RVA = "0x33B3800", Offset = "0x33B2400", VA = "0x1833B3800")]
		protected void DoEndStory()
		{
		}

		// Token: 0x0600BF27 RID: 48935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF27")]
		[Address(RVA = "0x33B3740", Offset = "0x33B2340", VA = "0x1833B3740")]
		protected IEnumerator DoAutoClick(float delay)
		{
			return null;
		}

		// Token: 0x0600BF28 RID: 48936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF28")]
		[Address(RVA = "0x33BB430", Offset = "0x33BA030", VA = "0x1833BB430")]
		private HashSet<ICommandExecutor> _GetCommandExecutors(string command)
		{
			return null;
		}

		// Token: 0x0600BF29 RID: 48937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF29")]
		[Address(RVA = "0x33BB2A0", Offset = "0x33B9EA0", VA = "0x1833BB2A0")]
		private void _ExecuteExecutor(ICommandExecutor executor, Command command)
		{
		}

		// Token: 0x0600BF2A RID: 48938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF2A")]
		[Address(RVA = "0x33BB4F0", Offset = "0x33BA0F0", VA = "0x1833BB4F0")]
		private HashSet<ICommandPostChecker> _GetCommandPostCheckers(string command)
		{
			return null;
		}

		// Token: 0x0600BF2B RID: 48939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF2B")]
		[Address(RVA = "0x33BC070", Offset = "0x33BAC70", VA = "0x1833BC070")]
		private void _PreprocessCommands(IList<Command> commands)
		{
		}

		// Token: 0x0600BF2C RID: 48940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF2C")]
		[Address(RVA = "0x33BB9B0", Offset = "0x33BA5B0", VA = "0x1833BB9B0")]
		private void _InitExecutors()
		{
		}

		// Token: 0x0600BF2D RID: 48941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF2D")]
		[Address(RVA = "0x33BB730", Offset = "0x33BA330", VA = "0x1833BB730")]
		private void _InitContextStateService()
		{
		}

		// Token: 0x0600BF2E RID: 48942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF2E")]
		[Address(RVA = "0x33BCEC0", Offset = "0x33BBAC0", VA = "0x1833BCEC0")]
		private void _StopAutoClick()
		{
		}

		// Token: 0x0600BF2F RID: 48943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF2F")]
		[Address(RVA = "0x33BC230", Offset = "0x33BAE30", VA = "0x1833BC230")]
		private void _ResetCache()
		{
		}

		// Token: 0x0600BF30 RID: 48944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF30")]
		[Address(RVA = "0x33BAAB0", Offset = "0x33B96B0", VA = "0x1833BAAB0")]
		private void _CacheOriginSizeDeltaOfFitTargetsIfNot()
		{
		}

		// Token: 0x0600BF31 RID: 48945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF31")]
		[Address(RVA = "0x33BC700", Offset = "0x33BB300", VA = "0x1833BC700")]
		private void _SetupFitMode(AVGController.FitMode fitMode)
		{
		}

		// Token: 0x0600BF32 RID: 48946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF32")]
		[Address(RVA = "0x33B4A80", Offset = "0x33B3680", VA = "0x1833B4A80")]
		protected void OnCommandFinishedCallback(ICommandExecutor executor)
		{
		}

		// Token: 0x0600BF33 RID: 48947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF33")]
		[Address(RVA = "0x33B81E0", Offset = "0x33B6DE0", VA = "0x1833B81E0")]
		private void ResetDecisionCache()
		{
		}

		// Token: 0x0600BF34 RID: 48948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF34")]
		[Address(RVA = "0x33B4B20", Offset = "0x33B3720", VA = "0x1833B4B20")]
		public void OnDecisionSelected(int decisionValue, int decisionIndex)
		{
		}

		// Token: 0x0600BF35 RID: 48949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF35")]
		[Address(RVA = "0x33B6070", Offset = "0x33B4C70", VA = "0x1833B6070")]
		protected void OnStoryBegin(Story story)
		{
		}

		// Token: 0x0600BF36 RID: 48950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF36")]
		[Address(RVA = "0x33B65D0", Offset = "0x33B51D0", VA = "0x1833B65D0")]
		protected void OnStoryEnd(bool isCommitOk, Story story, bool needUnloadAssets)
		{
		}

		// Token: 0x0600BF37 RID: 48951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF37")]
		[Address(RVA = "0x33BD0A0", Offset = "0x33BBCA0", VA = "0x1833BD0A0")]
		private void _UnloadUnusedAssets(Story story)
		{
		}

		// Token: 0x0600BF38 RID: 48952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF38")]
		[Address(RVA = "0x33B5AD0", Offset = "0x33B46D0", VA = "0x1833B5AD0")]
		protected void OnReset()
		{
		}

		// Token: 0x0600BF39 RID: 48953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF39")]
		[Address(RVA = "0x33B5E80", Offset = "0x33B4A80", VA = "0x1833B5E80")]
		public void OnSkipBtnClicked()
		{
		}

		// Token: 0x0600BF3A RID: 48954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF3A")]
		[Address(RVA = "0x33B4800", Offset = "0x33B3400", VA = "0x1833B4800")]
		public void OnAutoBtnClicked()
		{
		}

		// Token: 0x0600BF3B RID: 48955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF3B")]
		[Address(RVA = "0x33B5F20", Offset = "0x33B4B20", VA = "0x1833B5F20")]
		public void OnSpeedBtnClicked()
		{
		}

		// Token: 0x0600BF3C RID: 48956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF3C")]
		[Address(RVA = "0x33B5A00", Offset = "0x33B4600", VA = "0x1833B5A00")]
		public void OnPlaybackBtnClicked()
		{
		}

		// Token: 0x0600BF3D RID: 48957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF3D")]
		[Address(RVA = "0x33B5DA0", Offset = "0x33B49A0", VA = "0x1833B5DA0")]
		public void OnSettingBtnClicked()
		{
		}

		// Token: 0x0600BF3E RID: 48958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF3E")]
		[Address(RVA = "0x33B4890", Offset = "0x33B3490", VA = "0x1833B4890")]
		public void OnClickPress()
		{
		}

		// Token: 0x0600BF3F RID: 48959 RVA: 0x00046920 File Offset: 0x00044B20
		[Token(Token = "0x600BF3F")]
		[Address(RVA = "0x33BAC50", Offset = "0x33B9850", VA = "0x1833BAC50")]
		private NotifyViewOptions<QuickPlayKnownNotifyView, QuickPlayKnownNotifyView.Param> _CreateQuickPlayNotifyOptions(float duration, bool isShowBtn)
		{
			return default(NotifyViewOptions<QuickPlayKnownNotifyView, QuickPlayKnownNotifyView.Param>);
		}

		// Token: 0x0600BF40 RID: 48960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF40")]
		[Address(RVA = "0x33B5860", Offset = "0x33B4460", VA = "0x1833B5860")]
		public void OnLongPress(Vector2 pos)
		{
		}

		// Token: 0x0600BF41 RID: 48961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF41")]
		[Address(RVA = "0x33B8FF0", Offset = "0x33B7BF0", VA = "0x1833B8FF0")]
		public void SetTheaterMode(bool value)
		{
		}

		// Token: 0x0600BF42 RID: 48962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF42")]
		[Address(RVA = "0x33B9CB0", Offset = "0x33B88B0", VA = "0x1833B9CB0")]
		public string TryGetStoryBriefContent(string storyInfoId)
		{
			return null;
		}

		// Token: 0x0600BF43 RID: 48963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF43")]
		[Address(RVA = "0x33BC4C0", Offset = "0x33BB0C0", VA = "0x1833BC4C0")]
		private void _SetTheaterModeStatus()
		{
		}

		// Token: 0x0600BF44 RID: 48964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF44")]
		[Address(RVA = "0x33BC400", Offset = "0x33BB000", VA = "0x1833BC400")]
		private void _SaveAutoStatus()
		{
		}

		// Token: 0x0600BF45 RID: 48965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF45")]
		[Address(RVA = "0x33BBEB0", Offset = "0x33BAAB0", VA = "0x1833BBEB0")]
		private void _OnUIInputCommandEnter()
		{
		}

		// Token: 0x0600BF46 RID: 48966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF46")]
		[Address(RVA = "0x33BBF40", Offset = "0x33BAB40", VA = "0x1833BBF40")]
		private void _OnUIInputCommandExit()
		{
		}

		// Token: 0x0600BF47 RID: 48967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF47")]
		[Address(RVA = "0x33BBDD0", Offset = "0x33BA9D0", VA = "0x1833BBDD0")]
		private void _LoadAutoStatus()
		{
		}

		// Token: 0x0600BF48 RID: 48968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF48")]
		[Address(RVA = "0x33BA820", Offset = "0x33B9420", VA = "0x1833BA820")]
		private void _ApplyReaderModeEligibilityAtStoryStart()
		{
		}

		// Token: 0x0600BF49 RID: 48969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF49")]
		[Address(RVA = "0x33BC310", Offset = "0x33BAF10", VA = "0x1833BC310")]
		private void _RestoreExecuteModeAfterStoryEndIfNeeded()
		{
		}

		// Token: 0x0600BF4A RID: 48970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF4A")]
		[Address(RVA = "0x33BA770", Offset = "0x33B9370", VA = "0x1833BA770")]
		public void UpdateStorySkipMode(SkipNodeLabel node)
		{
		}

		// Token: 0x0600BF4B RID: 48971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF4B")]
		[Address(RVA = "0x33BD190", Offset = "0x33BBD90", VA = "0x1833BD190")]
		private void _UpdateSkipStatus()
		{
		}

		// Token: 0x0600BF4C RID: 48972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF4C")]
		[Address(RVA = "0x33BCC20", Offset = "0x33BB820", VA = "0x1833BCC20")]
		private void _ShowBriefPanel(string storyId)
		{
		}

		// Token: 0x0600BF4D RID: 48973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF4D")]
		[Address(RVA = "0x33BBFD0", Offset = "0x33BABD0", VA = "0x1833BBFD0")]
		private void _PauseAuto()
		{
		}

		// Token: 0x0600BF4E RID: 48974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF4E")]
		[Address(RVA = "0x33B8290", Offset = "0x33B6E90", VA = "0x1833B8290")]
		public void ResumeAuto()
		{
		}

		// Token: 0x0600BF4F RID: 48975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF4F")]
		[Address(RVA = "0x33B50B0", Offset = "0x33B3CB0", VA = "0x1833B50B0")]
		public void OnHideuiBtnClicked()
		{
		}

		// Token: 0x0600BF50 RID: 48976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF50")]
		[Address(RVA = "0x33B5250", Offset = "0x33B3E50", VA = "0x1833B5250")]
		public void OnHideuiResumeClicked()
		{
		}

		// Token: 0x0600BF51 RID: 48977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF51")]
		[Address(RVA = "0x33BAE10", Offset = "0x33B9A10", VA = "0x1833BAE10")]
		private void _DoCacheOriginActiveStates()
		{
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x0600BF52 RID: 48978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700171A")]
		public AVGShaderProfile shaderProfile
		{
			[Token(Token = "0x600BF52")]
			[Address(RVA = "0x33BEA60", Offset = "0x33BD660", VA = "0x1833BEA60")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BF53 RID: 48979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF53")]
		[Address(RVA = "0x33B5350", Offset = "0x33B3F50", VA = "0x1833B5350", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600BF54 RID: 48980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF54")]
		[Address(RVA = "0x33B4FE0", Offset = "0x33B3BE0", VA = "0x1833B4FE0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600BF55 RID: 48981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF55")]
		[Address(RVA = "0x33B4EB0", Offset = "0x33B3AB0", VA = "0x1833B4EB0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600BF56 RID: 48982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF56")]
		[Address(RVA = "0x33B4E10", Offset = "0x33B3A10", VA = "0x1833B4E10", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600BF57 RID: 48983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF57")]
		[Address(RVA = "0x33B9A70", Offset = "0x33B8670", VA = "0x1833B9A70")]
		public static void TryFetchAndAddCameras(List<Camera> cameras)
		{
		}

		// Token: 0x0600BF58 RID: 48984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF58")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600BF59 RID: 48985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF59")]
		[Address(RVA = "0x33B4290", Offset = "0x33B2E90", VA = "0x1833B4290", Slot = "9")]
		public UnityEngine.Object LoadAsset(string path)
		{
			return null;
		}

		// Token: 0x0600BF5A RID: 48986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF5A")]
		[Address(RVA = "0x33B9FF0", Offset = "0x33B8BF0", VA = "0x1833B9FF0", Slot = "10")]
		public void UnloadAsset(UnityEngine.Object asset)
		{
		}

		// Token: 0x0600BF5B RID: 48987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF5B")]
		[Address(RVA = "0x33B5D10", Offset = "0x33B4910", VA = "0x1833B5D10", Slot = "11")]
		public void OnSafeRectUpdated(SafeRect rect)
		{
		}

		// Token: 0x0600BF5C RID: 48988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF5C")]
		[Address(RVA = "0x33B4020", Offset = "0x33B2C20", VA = "0x1833B4020")]
		public void InitStateEngine(AVGUIStateEngineController stateController)
		{
		}

		// Token: 0x0600BF5D RID: 48989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF5D")]
		[Address(RVA = "0x33B3FC0", Offset = "0x33B2BC0", VA = "0x1833B3FC0")]
		public AVGUIStateEngineController GetStateEngineController()
		{
			return null;
		}

		// Token: 0x0600BF5E RID: 48990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF5E")]
		[Address(RVA = "0x33B9970", Offset = "0x33B8570", VA = "0x1833B9970")]
		public void SubscribeStoryCache(IAVGDataSubscriber<AVGStoryCache> subscriber, bool pushNow = true)
		{
		}

		// Token: 0x0600BF5F RID: 48991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF5F")]
		[Address(RVA = "0x33BA6D0", Offset = "0x33B92D0", VA = "0x1833BA6D0")]
		public void UnsubscribeStoryCache(IAVGDataSubscriber<AVGStoryCache> subscriber)
		{
		}

		// Token: 0x0600BF60 RID: 48992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF60")]
		[Address(RVA = "0x33BA9C0", Offset = "0x33B95C0", VA = "0x1833BA9C0")]
		private void _BroadcastStoryCache()
		{
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x0600BF61 RID: 48993 RVA: 0x00046938 File Offset: 0x00044B38
		// (set) Token: 0x0600BF62 RID: 48994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700171B")]
		public AVGExecuteMode executeMode
		{
			[Token(Token = "0x600BF61")]
			[Address(RVA = "0x33BE0E0", Offset = "0x33BCCE0", VA = "0x1833BE0E0")]
			get
			{
				return AVGExecuteMode.Normal;
			}
			[Token(Token = "0x600BF62")]
			[Address(RVA = "0x33BF6A0", Offset = "0x33BE2A0", VA = "0x1833BF6A0")]
			set
			{
			}
		}

		// Token: 0x0600BF63 RID: 48995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF63")]
		[Address(RVA = "0x33BB1B0", Offset = "0x33B9DB0", VA = "0x1833BB1B0")]
		private void _EnterReaderModeInternal()
		{
		}

		// Token: 0x0600BF64 RID: 48996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF64")]
		[Address(RVA = "0x33BC3A0", Offset = "0x33BAFA0", VA = "0x1833BC3A0")]
		private void _ResumeFromReaderModeInternal()
		{
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x0600BF65 RID: 48997 RVA: 0x00046950 File Offset: 0x00044B50
		// (set) Token: 0x0600BF66 RID: 48998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700171C")]
		public bool pureMode
		{
			[Token(Token = "0x600BF65")]
			[Address(RVA = "0x33BE5B0", Offset = "0x33BD1B0", VA = "0x1833BE5B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600BF66")]
			[Address(RVA = "0x33BF890", Offset = "0x33BE490", VA = "0x1833BF890")]
			set
			{
			}
		}

		// Token: 0x0600BF67 RID: 48999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BF67")]
		[Address(RVA = "0x33B4430", Offset = "0x33B3030", VA = "0x1833B4430")]
		public Sprite LoadSpriteWithController(string path)
		{
			return null;
		}

		// Token: 0x0600BF68 RID: 49000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF68")]
		[Address(RVA = "0x33B45F0", Offset = "0x33B31F0", VA = "0x1833B45F0")]
		public void NormalModeFontSetting(AVGFontPreset preset)
		{
		}

		// Token: 0x0600BF69 RID: 49001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF69")]
		[Address(RVA = "0x33B8EA0", Offset = "0x33B7AA0", VA = "0x1833B8EA0")]
		public void SetDialogPreset(int presetId, bool notify = true)
		{
		}

		// Token: 0x0600BF6A RID: 49002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF6A")]
		[Address(RVA = "0x33B8CF0", Offset = "0x33B78F0", VA = "0x1833B8CF0")]
		public void SetDialogFontSetting(int fontSize, int fontSizeIndex, bool notify = true)
		{
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x0600BF6B RID: 49003 RVA: 0x00046968 File Offset: 0x00044B68
		// (set) Token: 0x0600BF6C RID: 49004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700171D")]
		public int dialogFontSize
		{
			[Token(Token = "0x600BF6B")]
			[Address(RVA = "0x33BDF00", Offset = "0x33BCB00", VA = "0x1833BDF00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600BF6C")]
			[Address(RVA = "0x33BF560", Offset = "0x33BE160", VA = "0x1833BF560")]
			set
			{
			}
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x0600BF6D RID: 49005 RVA: 0x00046980 File Offset: 0x00044B80
		// (set) Token: 0x0600BF6E RID: 49006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700171E")]
		public int dialogFontSizeIndex
		{
			[Token(Token = "0x600BF6D")]
			[Address(RVA = "0x33BDE70", Offset = "0x33BCA70", VA = "0x1833BDE70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600BF6E")]
			[Address(RVA = "0x33BF4C0", Offset = "0x33BE0C0", VA = "0x1833BF4C0")]
			set
			{
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x0600BF6F RID: 49007 RVA: 0x00046998 File Offset: 0x00044B98
		// (set) Token: 0x0600BF70 RID: 49008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700171F")]
		public int dialogPresetId
		{
			[Token(Token = "0x600BF6F")]
			[Address(RVA = "0x33BDF90", Offset = "0x33BCB90", VA = "0x1833BDF90")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600BF70")]
			[Address(RVA = "0x33BF600", Offset = "0x33BE200", VA = "0x1833BF600")]
			set
			{
			}
		}

		// Token: 0x0600BF71 RID: 49009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF71")]
		[Address(RVA = "0x33B7600", Offset = "0x33B6200", VA = "0x1833B7600")]
		public void ReaderModeSetFont(AVGFontPreset preset)
		{
		}

		// Token: 0x0600BF72 RID: 49010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF72")]
		[Address(RVA = "0x33B7790", Offset = "0x33B6390", VA = "0x1833B7790")]
		public void ReaderModeSetLineSpace(AVGReaderLineSpacePreset preset)
		{
		}

		// Token: 0x0600BF73 RID: 49011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF73")]
		[Address(RVA = "0x33B7460", Offset = "0x33B6060", VA = "0x1833B7460")]
		public void ReaderModeSetAlpha(AVGReaderAlphaPreset preset)
		{
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x0600BF74 RID: 49012 RVA: 0x000469B0 File Offset: 0x00044BB0
		// (set) Token: 0x0600BF75 RID: 49013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001720")]
		public int readerFontSize
		{
			[Token(Token = "0x600BF74")]
			[Address(RVA = "0x33BE7F0", Offset = "0x33BD3F0", VA = "0x1833BE7F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600BF75")]
			[Address(RVA = "0x33BFB10", Offset = "0x33BE710", VA = "0x1833BFB10")]
			set
			{
			}
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x0600BF76 RID: 49014 RVA: 0x000469C8 File Offset: 0x00044BC8
		// (set) Token: 0x0600BF77 RID: 49015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001721")]
		public int readerLineSpace
		{
			[Token(Token = "0x600BF76")]
			[Address(RVA = "0x33BE910", Offset = "0x33BD510", VA = "0x1833BE910")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600BF77")]
			[Address(RVA = "0x33BFC50", Offset = "0x33BE850", VA = "0x1833BFC50")]
			set
			{
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x0600BF78 RID: 49016 RVA: 0x000469E0 File Offset: 0x00044BE0
		// (set) Token: 0x0600BF79 RID: 49017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001722")]
		public int readerFontSizeIndex
		{
			[Token(Token = "0x600BF78")]
			[Address(RVA = "0x33BE760", Offset = "0x33BD360", VA = "0x1833BE760")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600BF79")]
			[Address(RVA = "0x33BFA70", Offset = "0x33BE670", VA = "0x1833BFA70")]
			set
			{
			}
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x0600BF7A RID: 49018 RVA: 0x000469F8 File Offset: 0x00044BF8
		// (set) Token: 0x0600BF7B RID: 49019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001723")]
		public int readerLineSpaceIndex
		{
			[Token(Token = "0x600BF7A")]
			[Address(RVA = "0x33BE880", Offset = "0x33BD480", VA = "0x1833BE880")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600BF7B")]
			[Address(RVA = "0x33BFBB0", Offset = "0x33BE7B0", VA = "0x1833BFBB0")]
			set
			{
			}
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x0600BF7C RID: 49020 RVA: 0x00046A10 File Offset: 0x00044C10
		// (set) Token: 0x0600BF7D RID: 49021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001724")]
		public float readerBgAlpha
		{
			[Token(Token = "0x600BF7C")]
			[Address(RVA = "0x33BE6D0", Offset = "0x33BD2D0", VA = "0x1833BE6D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600BF7D")]
			[Address(RVA = "0x33BF9D0", Offset = "0x33BE5D0", VA = "0x1833BF9D0")]
			set
			{
			}
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x0600BF7E RID: 49022 RVA: 0x00046A28 File Offset: 0x00044C28
		// (set) Token: 0x0600BF7F RID: 49023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001725")]
		public int readerBgAlphaIndex
		{
			[Token(Token = "0x600BF7E")]
			[Address(RVA = "0x33BE640", Offset = "0x33BD240", VA = "0x1833BE640")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600BF7F")]
			[Address(RVA = "0x33BF930", Offset = "0x33BE530", VA = "0x1833BF930")]
			set
			{
			}
		}

		// Token: 0x0600BF80 RID: 49024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF80")]
		[Address(RVA = "0x33B39A0", Offset = "0x33B25A0", VA = "0x1833B39A0")]
		[Conditional("UNITY_EDITOR")]
		public void EditorOnlySetAVGEvents(IAVGEvents avgEvents)
		{
		}

		// Token: 0x0600BF81 RID: 49025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF81")]
		[Address(RVA = "0x33BAFC0", Offset = "0x33B9BC0", VA = "0x1833BAFC0")]
		[Conditional("UNITY_EDITOR")]
		private void _EditorOnlyNotifyCommandExecuted(Command cmd)
		{
		}

		// Token: 0x0600BF82 RID: 49026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF82")]
		[Address(RVA = "0x33BB050", Offset = "0x33B9C50", VA = "0x1833BB050")]
		[Conditional("UNITY_EDITOR")]
		private void _EditorOnlyNotifyCommandFinished(Command cmd)
		{
		}

		// Token: 0x0600BF83 RID: 49027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF83")]
		[Address(RVA = "0x33B3920", Offset = "0x33B2520", VA = "0x1833B3920")]
		[Conditional("UNITY_EDITOR")]
		public void EditorOnlyAbortRemaineCommands()
		{
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x0600BF84 RID: 49028 RVA: 0x00046A40 File Offset: 0x00044C40
		[Token(Token = "0x17001726")]
		public bool enableReader
		{
			[Token(Token = "0x600BF84")]
			[Address(RVA = "0x33BE020", Offset = "0x33BCC20", VA = "0x1833BE020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600BF85 RID: 49029 RVA: 0x00046A58 File Offset: 0x00044C58
		[Token(Token = "0x600BF85")]
		[Address(RVA = "0x33B90C0", Offset = "0x33B7CC0", VA = "0x1833B90C0")]
		public bool ShouldEnableReaderMode()
		{
			return default(bool);
		}

		// Token: 0x0600BF86 RID: 49030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF86")]
		[Address(RVA = "0x33BBA90", Offset = "0x33BA690", VA = "0x1833BBA90")]
		private void _InitReaderModeSwitch()
		{
		}

		// Token: 0x0600BF87 RID: 49031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF87")]
		[Address(RVA = "0x33BD280", Offset = "0x33BBE80", VA = "0x1833BD280")]
		public AVGController()
		{
		}

		// Token: 0x0400BFCA RID: 49098
		[Token(Token = "0x400BFCA")]
		private const int SCENECAMERA_DEPTH = 50;

		// Token: 0x0400BFCB RID: 49099
		[Token(Token = "0x400BFCB")]
		private const int UICAMERA_DEPTH = 51;

		// Token: 0x0400BFCC RID: 49100
		[Token(Token = "0x400BFCC")]
		private const float FINISH_STORY_DELAY = 0.2f;

		// Token: 0x0400BFCD RID: 49101
		[Token(Token = "0x400BFCD")]
		private const int MIN_ASSETS_CNT_TO_UNLOAD_ALL = 5;

		// Token: 0x0400BFCE RID: 49102
		[Token(Token = "0x400BFCE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera _avgSceneCamera;

		// Token: 0x0400BFCF RID: 49103
		[Token(Token = "0x400BFCF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _avgUICamera;

		// Token: 0x0400BFD0 RID: 49104
		[Token(Token = "0x400BFD0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _skipBtn;

		// Token: 0x0400BFD1 RID: 49105
		[Token(Token = "0x400BFD1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AVGAutoButton _autoBtn;

		// Token: 0x0400BFD2 RID: 49106
		[Token(Token = "0x400BFD2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _speedBtn;

		// Token: 0x0400BFD3 RID: 49107
		[Token(Token = "0x400BFD3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _playbackBtn;

		// Token: 0x0400BFD4 RID: 49108
		[Token(Token = "0x400BFD4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _hideuiBtn;

		// Token: 0x0400BFD5 RID: 49109
		[Token(Token = "0x400BFD5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _settingBtn;

		// Token: 0x0400BFD6 RID: 49110
		[Token(Token = "0x400BFD6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private PlaybackPanel _playbackPanel;

		// Token: 0x0400BFD7 RID: 49111
		[Token(Token = "0x400BFD7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _hideUiMask;

		// Token: 0x0400BFD8 RID: 49112
		[Token(Token = "0x400BFD8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject[] _hideObjects;

		// Token: 0x0400BFD9 RID: 49113
		[Token(Token = "0x400BFD9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _dialogPanel;

		// Token: 0x0400BFDA RID: 49114
		[Token(Token = "0x400BFDA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SkipBriefPanel _briefPanel;

		// Token: 0x0400BFDB RID: 49115
		[Token(Token = "0x400BFDB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AVGSettingView _settingView;

		// Token: 0x0400BFDC RID: 49116
		[Token(Token = "0x400BFDC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AVGButton _clickBtn;

		// Token: 0x0400BFDD RID: 49117
		[Token(Token = "0x400BFDD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("AutoSpeed")]
		private AutoSpeed _dialogDefaultSpeed;

		// Token: 0x0400BFDE RID: 49118
		[Token(Token = "0x400BFDE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("AutoSpeed")]
		private AutoSpeed[] _btnAutoSpeed;

		// Token: 0x0400BFDF RID: 49119
		[Token(Token = "0x400BFDF")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("AutoSpeed")]
		private AutoSpeed[] _quickAutoSpeed;

		// Token: 0x0400BFE0 RID: 49120
		[Token(Token = "0x400BFE0")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Adaptation")]
		private RectTransform _cullMask;

		// Token: 0x0400BFE1 RID: 49121
		[Token(Token = "0x400BFE1")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Adaptation")]
		private RectTransform[] _fitTargets;

		// Token: 0x0400BFE2 RID: 49122
		[Token(Token = "0x400BFE2")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("QuickPlay")]
		private AVGQuickPlay _quickPlayPanel;

		// Token: 0x0400BFE3 RID: 49123
		[Token(Token = "0x400BFE3")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("QuickPlay")]
		[Tooltip("Millsecs")]
		private int _toastHoldOnInterval;

		// Token: 0x0400BFE4 RID: 49124
		[Token(Token = "0x400BFE4")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[Group("QuickPlay")]
		[Tooltip("Millsecs")]
		private int _clickToastHoldOnInterval;

		// Token: 0x0400BFE5 RID: 49125
		[Token(Token = "0x400BFE5")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("QuickPlay")]
		private int _tipClickTimes;

		// Token: 0x0400BFE6 RID: 49126
		[Token(Token = "0x400BFE6")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[Group("QuickPlay")]
		[Tooltip("Millsecs")]
		private int _tipPerClickInterval;

		// Token: 0x0400BFE7 RID: 49127
		[Token(Token = "0x400BFE7")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("QuickPlay")]
		[Tooltip("Seconds")]
		private int _tipClickTotalInterval;

		// Token: 0x0400BFE8 RID: 49128
		[Token(Token = "0x400BFE8")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("QuickPlay")]
		private QuickPlayKnownNotifyView _quickPlayKnownNotifyPrefab;

		// Token: 0x0400BFE9 RID: 49129
		[Token(Token = "0x400BFE9")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("CanvasHolder")]
		private AVGCanvasLayerHolder _canvasHolder;

		// Token: 0x0400BFEA RID: 49130
		[Token(Token = "0x400BFEA")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("UI Panel View")]
		private AVGUIPanelView _uiPanelView;

		// Token: 0x0400BFEB RID: 49131
		[Token(Token = "0x400BFEB")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private int _readerModeBoostSpeed;

		// Token: 0x0400BFEC RID: 49132
		[Token(Token = "0x400BFEC")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _avgStageEngineContainer;

		// Token: 0x0400BFED RID: 49133
		[Token(Token = "0x400BFED")]
		[FieldOffset(Offset = "0x110")]
		private Vector2[] m_originSizeDeltaOfFitTargets;

		// Token: 0x0400BFEE RID: 49134
		[Token(Token = "0x400BFEE")]
		[FieldOffset(Offset = "0x118")]
		private int m_skipToIndex;

		// Token: 0x0400BFEF RID: 49135
		[Token(Token = "0x400BFEF")]
		[FieldOffset(Offset = "0x120")]
		private AVGComponent[] m_components;

		// Token: 0x0400BFF0 RID: 49136
		[Token(Token = "0x400BFF0")]
		[FieldOffset(Offset = "0x128")]
		private AVGContextStateService m_contextStateService;

		// Token: 0x0400BFF1 RID: 49137
		[Token(Token = "0x400BFF1")]
		[FieldOffset(Offset = "0x130")]
		private EventPool<AVGController.Event> m_eventPool;

		// Token: 0x0400BFF2 RID: 49138
		[Token(Token = "0x400BFF2")]
		[FieldOffset(Offset = "0x138")]
		private ResourceRouter m_router;

		// Token: 0x0400BFF3 RID: 49139
		[Token(Token = "0x400BFF3")]
		[FieldOffset(Offset = "0x140")]
		private Story m_story;

		// Token: 0x0400BFF4 RID: 49140
		[Token(Token = "0x400BFF4")]
		[FieldOffset(Offset = "0x148")]
		private Dictionary<string, HashSet<ICommandExecutor>> m_commandExecutorsMap;

		// Token: 0x0400BFF5 RID: 49141
		[Token(Token = "0x400BFF5")]
		[FieldOffset(Offset = "0x150")]
		private int m_executeIndex;

		// Token: 0x0400BFF6 RID: 49142
		[Token(Token = "0x400BFF6")]
		[FieldOffset(Offset = "0x158")]
		private List<ICommandExecutor> m_blockingExecutors;

		// Token: 0x0400BFF7 RID: 49143
		[Token(Token = "0x400BFF7")]
		[FieldOffset(Offset = "0x160")]
		private readonly List<ICommandPostChecker> m_activeCheckers;

		// Token: 0x0400BFF8 RID: 49144
		[Token(Token = "0x400BFF8")]
		[FieldOffset(Offset = "0x168")]
		private List<ICommandExecutor> m_decisionExecutors;

		// Token: 0x0400BFF9 RID: 49145
		[Token(Token = "0x400BFF9")]
		[FieldOffset(Offset = "0x170")]
		private Command m_currentDecisionCommand;

		// Token: 0x0400BFFA RID: 49146
		[Token(Token = "0x400BFFA")]
		[FieldOffset(Offset = "0x178")]
		private Dictionary<string, HashSet<ICommandPostChecker>> m_commandPostCheckerMap;

		// Token: 0x0400BFFB RID: 49147
		[Token(Token = "0x400BFFB")]
		[FieldOffset(Offset = "0x180")]
		private Coroutine m_coroutine;

		// Token: 0x0400BFFC RID: 49148
		[Token(Token = "0x400BFFC")]
		[FieldOffset(Offset = "0x188")]
		private Coroutine m_autoPlayingCoroutine;

		// Token: 0x0400BFFD RID: 49149
		[Token(Token = "0x400BFFD")]
		[FieldOffset(Offset = "0x190")]
		private AVGAssetLoader m_assetLoader;

		// Token: 0x0400BFFE RID: 49150
		[Token(Token = "0x400BFFE")]
		[FieldOffset(Offset = "0x198")]
		private int m_decisionValue;

		// Token: 0x0400BFFF RID: 49151
		[Token(Token = "0x400BFFF")]
		[FieldOffset(Offset = "0x19C")]
		private bool m_needResumeAuto;

		// Token: 0x0400C000 RID: 49152
		[Token(Token = "0x400C000")]
		[FieldOffset(Offset = "0x19D")]
		private bool m_needResumeAutoStatus;

		// Token: 0x0400C001 RID: 49153
		[Token(Token = "0x400C001")]
		[FieldOffset(Offset = "0x19E")]
		private bool m_shouldRestoreExecuteModeAfterStoryEnd;

		// Token: 0x0400C002 RID: 49154
		[Token(Token = "0x400C002")]
		[FieldOffset(Offset = "0x1A0")]
		private AVGExecuteMode m_cachedExecuteModeForStory;

		// Token: 0x0400C003 RID: 49155
		[Token(Token = "0x400C003")]
		[FieldOffset(Offset = "0x1A4")]
		public AVGStoryCache.AVGAutoMode autoPlayModeCache;

		// Token: 0x0400C004 RID: 49156
		[Token(Token = "0x400C004")]
		[FieldOffset(Offset = "0x1A8")]
		public int btnAutoModeCache;

		// Token: 0x0400C005 RID: 49157
		[Token(Token = "0x400C005")]
		[FieldOffset(Offset = "0x1B0")]
		private Dictionary<string, GameObject> m_gameObjectPool;

		// Token: 0x0400C006 RID: 49158
		[Token(Token = "0x400C006")]
		[FieldOffset(Offset = "0x1B8")]
		private bool[] m_prevActiveStates;

		// Token: 0x0400C007 RID: 49159
		[Token(Token = "0x400C007")]
		[FieldOffset(Offset = "0x1C0")]
		private bool[] m_originActiveStates;

		// Token: 0x0400C008 RID: 49160
		[Token(Token = "0x400C008")]
		[FieldOffset(Offset = "0x1C8")]
		private AVGStoryCache m_storyCache;

		// Token: 0x0400C009 RID: 49161
		[Token(Token = "0x400C009")]
		[FieldOffset(Offset = "0x208")]
		private Dictionary<int, AVGCommandContext> m_contextDict;

		// Token: 0x0400C00A RID: 49162
		[Token(Token = "0x400C00A")]
		[FieldOffset(Offset = "0x210")]
		private AVGController.AVGCompBridge m_compBridge;

		// Token: 0x0400C00B RID: 49163
		[Token(Token = "0x400C00B")]
		[FieldOffset(Offset = "0x218")]
		private IAVGEvents m_avgEvents;

		// Token: 0x0400C00C RID: 49164
		[Token(Token = "0x400C00C")]
		[FieldOffset(Offset = "0x220")]
		private AVGDataDriver<AVGStoryCache> m_storyCacheDriver;

		// Token: 0x0400C00D RID: 49165
		[Token(Token = "0x400C00D")]
		[FieldOffset(Offset = "0x228")]
		private LatchUtils.InvokeWhenUnlock m_storyCacheReadyLock;

		// Token: 0x0400C00E RID: 49166
		[Token(Token = "0x400C00E")]
		[FieldOffset(Offset = "0x230")]
		private Action m_storyCacheBroadcastFunc;

		// Token: 0x0400C00F RID: 49167
		[Token(Token = "0x400C00F")]
		[FieldOffset(Offset = "0x238")]
		private AVGSceneEffectManager m_sceneEffectMgr;

		// Token: 0x0400C010 RID: 49168
		[Token(Token = "0x400C010")]
		[FieldOffset(Offset = "0x240")]
		private ICommandPredicator m_commandPredicator;

		// Token: 0x0400C011 RID: 49169
		[Token(Token = "0x400C011")]
		[FieldOffset(Offset = "0x248")]
		private DecisionCommandPredicator m_sharedDecisionPredicator;

		// Token: 0x0400C012 RID: 49170
		[Token(Token = "0x400C012")]
		[FieldOffset(Offset = "0x250")]
		private AVGController.ICommandFlowController m_commandFlowController;

		// Token: 0x0400C013 RID: 49171
		[Token(Token = "0x400C013")]
		[FieldOffset(Offset = "0x258")]
		private AVGController.ICommandSkipController m_commandSkipController;

		// Token: 0x0400C014 RID: 49172
		[Token(Token = "0x400C014")]
		[FieldOffset(Offset = "0x260")]
		private AVGUIStateEngineController m_uiStateController;

		// Token: 0x0400C015 RID: 49173
		[Token(Token = "0x400C015")]
		[FieldOffset(Offset = "0x268")]
		private bool m_enableReaderMode;

		// Token: 0x0400C016 RID: 49174
		[Token(Token = "0x400C016")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureCompBridge;

		// Token: 0x0400C017 RID: 49175
		[Token(Token = "0x400C017")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetOrCreateSceneEffectMgr;

		// Token: 0x0400C018 RID: 49176
		[Token(Token = "0x400C018")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_storyId;

		// Token: 0x0400C019 RID: 49177
		[Token(Token = "0x400C019")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_storyCache;

		// Token: 0x0400C01A RID: 49178
		[Token(Token = "0x400C01A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_contextDict;

		// Token: 0x0400C01B RID: 49179
		[Token(Token = "0x400C01B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetContextCommandsByLineNumber;

		// Token: 0x0400C01C RID: 49180
		[Token(Token = "0x400C01C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_toastQuickPlay;

		// Token: 0x0400C01D RID: 49181
		[Token(Token = "0x400C01D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isSkippable;

		// Token: 0x0400C01E RID: 49182
		[Token(Token = "0x400C01E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_autoPlayMode;

		// Token: 0x0400C01F RID: 49183
		[Token(Token = "0x400C01F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_autoPlayMode;

		// Token: 0x0400C020 RID: 49184
		[Token(Token = "0x400C020")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__IsReaderOrPureMode;

		// Token: 0x0400C021 RID: 49185
		[Token(Token = "0x400C021")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_autoWaitBaseTime;

		// Token: 0x0400C022 RID: 49186
		[Token(Token = "0x400C022")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_autoWaitTimePerText;

		// Token: 0x0400C023 RID: 49187
		[Token(Token = "0x400C023")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_typeWriterDelay;

		// Token: 0x0400C024 RID: 49188
		[Token(Token = "0x400C024")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_animateRatio;

		// Token: 0x0400C025 RID: 49189
		[Token(Token = "0x400C025")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_isTheaterMode;

		// Token: 0x0400C026 RID: 49190
		[Token(Token = "0x400C026")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isAutoClickRaised;

		// Token: 0x0400C027 RID: 49191
		[Token(Token = "0x400C027")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_isRunning;

		// Token: 0x0400C028 RID: 49192
		[Token(Token = "0x400C028")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_isRunningTutorial;

		// Token: 0x0400C029 RID: 49193
		[Token(Token = "0x400C029")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_decisionIndex;

		// Token: 0x0400C02A RID: 49194
		[Token(Token = "0x400C02A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_decisionIndex;

		// Token: 0x0400C02B RID: 49195
		[Token(Token = "0x400C02B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_isAutoable;

		// Token: 0x0400C02C RID: 49196
		[Token(Token = "0x400C02C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_storyProgress;

		// Token: 0x0400C02D RID: 49197
		[Token(Token = "0x400C02D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_storyParam;

		// Token: 0x0400C02E RID: 49198
		[Token(Token = "0x400C02E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_sharedDecisionPredicator;

		// Token: 0x0400C02F RID: 49199
		[Token(Token = "0x400C02F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_SetCommandPredicator;

		// Token: 0x0400C030 RID: 49200
		[Token(Token = "0x400C030")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_SetCommandFlowController;

		// Token: 0x0400C031 RID: 49201
		[Token(Token = "0x400C031")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_SetCommandSkipController;

		// Token: 0x0400C032 RID: 49202
		[Token(Token = "0x400C032")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_canvasHolder;

		// Token: 0x0400C033 RID: 49203
		[Token(Token = "0x400C033")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x0400C034 RID: 49204
		[Token(Token = "0x400C034")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x0400C035 RID: 49205
		[Token(Token = "0x400C035")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_router;

		// Token: 0x0400C036 RID: 49206
		[Token(Token = "0x400C036")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_sceneCamera;

		// Token: 0x0400C037 RID: 49207
		[Token(Token = "0x400C037")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_RunStory;

		// Token: 0x0400C038 RID: 49208
		[Token(Token = "0x400C038")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_StopStory;

		// Token: 0x0400C039 RID: 49209
		[Token(Token = "0x400C039")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_SkipStory;

		// Token: 0x0400C03A RID: 49210
		[Token(Token = "0x400C03A")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_EndStory;

		// Token: 0x0400C03B RID: 49211
		[Token(Token = "0x400C03B")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnStoryCommitted;

		// Token: 0x0400C03C RID: 49212
		[Token(Token = "0x400C03C")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_SetQuickSpeed;

		// Token: 0x0400C03D RID: 49213
		[Token(Token = "0x400C03D")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_RaiseAutoClick;

		// Token: 0x0400C03E RID: 49214
		[Token(Token = "0x400C03E")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix1_RaiseAutoClick;

		// Token: 0x0400C03F RID: 49215
		[Token(Token = "0x400C03F")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_RaiseSignal;

		// Token: 0x0400C040 RID: 49216
		[Token(Token = "0x400C040")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix1_RaiseSignal;

		// Token: 0x0400C041 RID: 49217
		[Token(Token = "0x400C041")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_RegisterExecutor;

		// Token: 0x0400C042 RID: 49218
		[Token(Token = "0x400C042")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_UnregisterExecutor;

		// Token: 0x0400C043 RID: 49219
		[Token(Token = "0x400C043")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_RegisterComponent;

		// Token: 0x0400C044 RID: 49220
		[Token(Token = "0x400C044")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_UnregisterComponent;

		// Token: 0x0400C045 RID: 49221
		[Token(Token = "0x400C045")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_RegisterCommandPostChecker;

		// Token: 0x0400C046 RID: 49222
		[Token(Token = "0x400C046")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_UnregisterCommandPostChecker;

		// Token: 0x0400C047 RID: 49223
		[Token(Token = "0x400C047")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_GetAVGComponentOrNull;

		// Token: 0x0400C048 RID: 49224
		[Token(Token = "0x400C048")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_BuildTextCommandContexts;

		// Token: 0x0400C049 RID: 49225
		[Token(Token = "0x400C049")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_RegisterExtraGameObject;

		// Token: 0x0400C04A RID: 49226
		[Token(Token = "0x400C04A")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_UnregisterExtraGameObject;

		// Token: 0x0400C04B RID: 49227
		[Token(Token = "0x400C04B")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_GetExtraGameObject;

		// Token: 0x0400C04C RID: 49228
		[Token(Token = "0x400C04C")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix1_GetExtraGameObject;

		// Token: 0x0400C04D RID: 49229
		[Token(Token = "0x400C04D")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_TryGetCharSortType;

		// Token: 0x0400C04E RID: 49230
		[Token(Token = "0x400C04E")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__TryShowQuickPlayTip;

		// Token: 0x0400C04F RID: 49231
		[Token(Token = "0x400C04F")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_IsTutorialWaitSignalMatchedStringParam;

		// Token: 0x0400C050 RID: 49232
		[Token(Token = "0x400C050")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__IsTutorialAndWaitSignal;

		// Token: 0x0400C051 RID: 49233
		[Token(Token = "0x400C051")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_DoExecuteCommands;

		// Token: 0x0400C052 RID: 49234
		[Token(Token = "0x400C052")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_DoEndStory;

		// Token: 0x0400C053 RID: 49235
		[Token(Token = "0x400C053")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_DoAutoClick;

		// Token: 0x0400C054 RID: 49236
		[Token(Token = "0x400C054")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__GetCommandExecutors;

		// Token: 0x0400C055 RID: 49237
		[Token(Token = "0x400C055")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__ExecuteExecutor;

		// Token: 0x0400C056 RID: 49238
		[Token(Token = "0x400C056")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__GetCommandPostCheckers;

		// Token: 0x0400C057 RID: 49239
		[Token(Token = "0x400C057")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__PreprocessCommands;

		// Token: 0x0400C058 RID: 49240
		[Token(Token = "0x400C058")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__InitExecutors;

		// Token: 0x0400C059 RID: 49241
		[Token(Token = "0x400C059")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__InitContextStateService;

		// Token: 0x0400C05A RID: 49242
		[Token(Token = "0x400C05A")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__StopAutoClick;

		// Token: 0x0400C05B RID: 49243
		[Token(Token = "0x400C05B")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__ResetCache;

		// Token: 0x0400C05C RID: 49244
		[Token(Token = "0x400C05C")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__CacheOriginSizeDeltaOfFitTargetsIfNot;

		// Token: 0x0400C05D RID: 49245
		[Token(Token = "0x400C05D")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0__SetupFitMode;

		// Token: 0x0400C05E RID: 49246
		[Token(Token = "0x400C05E")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_OnCommandFinishedCallback;

		// Token: 0x0400C05F RID: 49247
		[Token(Token = "0x400C05F")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_ResetDecisionCache;

		// Token: 0x0400C060 RID: 49248
		[Token(Token = "0x400C060")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_OnDecisionSelected;

		// Token: 0x0400C061 RID: 49249
		[Token(Token = "0x400C061")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_OnStoryBegin;

		// Token: 0x0400C062 RID: 49250
		[Token(Token = "0x400C062")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_OnStoryEnd;

		// Token: 0x0400C063 RID: 49251
		[Token(Token = "0x400C063")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0__UnloadUnusedAssets;

		// Token: 0x0400C064 RID: 49252
		[Token(Token = "0x400C064")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C065 RID: 49253
		[Token(Token = "0x400C065")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_OnSkipBtnClicked;

		// Token: 0x0400C066 RID: 49254
		[Token(Token = "0x400C066")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_OnAutoBtnClicked;

		// Token: 0x0400C067 RID: 49255
		[Token(Token = "0x400C067")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_OnSpeedBtnClicked;

		// Token: 0x0400C068 RID: 49256
		[Token(Token = "0x400C068")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_OnPlaybackBtnClicked;

		// Token: 0x0400C069 RID: 49257
		[Token(Token = "0x400C069")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_OnSettingBtnClicked;

		// Token: 0x0400C06A RID: 49258
		[Token(Token = "0x400C06A")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_OnClickPress;

		// Token: 0x0400C06B RID: 49259
		[Token(Token = "0x400C06B")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0__CreateQuickPlayNotifyOptions;

		// Token: 0x0400C06C RID: 49260
		[Token(Token = "0x400C06C")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_OnLongPress;

		// Token: 0x0400C06D RID: 49261
		[Token(Token = "0x400C06D")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_SetTheaterMode;

		// Token: 0x0400C06E RID: 49262
		[Token(Token = "0x400C06E")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_TryGetStoryBriefContent;

		// Token: 0x0400C06F RID: 49263
		[Token(Token = "0x400C06F")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0__SetTheaterModeStatus;

		// Token: 0x0400C070 RID: 49264
		[Token(Token = "0x400C070")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0__SaveAutoStatus;

		// Token: 0x0400C071 RID: 49265
		[Token(Token = "0x400C071")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0__OnUIInputCommandEnter;

		// Token: 0x0400C072 RID: 49266
		[Token(Token = "0x400C072")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0__OnUIInputCommandExit;

		// Token: 0x0400C073 RID: 49267
		[Token(Token = "0x400C073")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0__LoadAutoStatus;

		// Token: 0x0400C074 RID: 49268
		[Token(Token = "0x400C074")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0__ApplyReaderModeEligibilityAtStoryStart;

		// Token: 0x0400C075 RID: 49269
		[Token(Token = "0x400C075")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0__RestoreExecuteModeAfterStoryEndIfNeeded;

		// Token: 0x0400C076 RID: 49270
		[Token(Token = "0x400C076")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_UpdateStorySkipMode;

		// Token: 0x0400C077 RID: 49271
		[Token(Token = "0x400C077")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0__UpdateSkipStatus;

		// Token: 0x0400C078 RID: 49272
		[Token(Token = "0x400C078")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0__ShowBriefPanel;

		// Token: 0x0400C079 RID: 49273
		[Token(Token = "0x400C079")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0__PauseAuto;

		// Token: 0x0400C07A RID: 49274
		[Token(Token = "0x400C07A")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_ResumeAuto;

		// Token: 0x0400C07B RID: 49275
		[Token(Token = "0x400C07B")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_OnHideuiBtnClicked;

		// Token: 0x0400C07C RID: 49276
		[Token(Token = "0x400C07C")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_OnHideuiResumeClicked;

		// Token: 0x0400C07D RID: 49277
		[Token(Token = "0x400C07D")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0__DoCacheOriginActiveStates;

		// Token: 0x0400C07E RID: 49278
		[Token(Token = "0x400C07E")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_get_shaderProfile;

		// Token: 0x0400C07F RID: 49279
		[Token(Token = "0x400C07F")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400C080 RID: 49280
		[Token(Token = "0x400C080")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400C081 RID: 49281
		[Token(Token = "0x400C081")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400C082 RID: 49282
		[Token(Token = "0x400C082")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400C083 RID: 49283
		[Token(Token = "0x400C083")]
		[FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_TryFetchAndAddCameras;

		// Token: 0x0400C084 RID: 49284
		[Token(Token = "0x400C084")]
		[FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x0400C085 RID: 49285
		[Token(Token = "0x400C085")]
		[FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix1_LoadAsset;

		// Token: 0x0400C086 RID: 49286
		[Token(Token = "0x400C086")]
		[FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_UnloadAsset;

		// Token: 0x0400C087 RID: 49287
		[Token(Token = "0x400C087")]
		[FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_OnSafeRectUpdated;

		// Token: 0x0400C088 RID: 49288
		[Token(Token = "0x400C088")]
		[FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0400C089 RID: 49289
		[Token(Token = "0x400C089")]
		[FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_GetStateEngineController;

		// Token: 0x0400C08A RID: 49290
		[Token(Token = "0x400C08A")]
		[FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_SubscribeStoryCache;

		// Token: 0x0400C08B RID: 49291
		[Token(Token = "0x400C08B")]
		[FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_UnsubscribeStoryCache;

		// Token: 0x0400C08C RID: 49292
		[Token(Token = "0x400C08C")]
		[FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0__BroadcastStoryCache;

		// Token: 0x0400C08D RID: 49293
		[Token(Token = "0x400C08D")]
		[FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_get_executeMode;

		// Token: 0x0400C08E RID: 49294
		[Token(Token = "0x400C08E")]
		[FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_set_executeMode;

		// Token: 0x0400C08F RID: 49295
		[Token(Token = "0x400C08F")]
		[FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0__EnterReaderModeInternal;

		// Token: 0x0400C090 RID: 49296
		[Token(Token = "0x400C090")]
		[FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0__ResumeFromReaderModeInternal;

		// Token: 0x0400C091 RID: 49297
		[Token(Token = "0x400C091")]
		[FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_get_pureMode;

		// Token: 0x0400C092 RID: 49298
		[Token(Token = "0x400C092")]
		[FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_set_pureMode;

		// Token: 0x0400C093 RID: 49299
		[Token(Token = "0x400C093")]
		[FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_LoadSpriteWithController;

		// Token: 0x0400C094 RID: 49300
		[Token(Token = "0x400C094")]
		[FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_NormalModeFontSetting;

		// Token: 0x0400C095 RID: 49301
		[Token(Token = "0x400C095")]
		[FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_SetDialogPreset;

		// Token: 0x0400C096 RID: 49302
		[Token(Token = "0x400C096")]
		[FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_SetDialogFontSetting;

		// Token: 0x0400C097 RID: 49303
		[Token(Token = "0x400C097")]
		[FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_get_dialogFontSize;

		// Token: 0x0400C098 RID: 49304
		[Token(Token = "0x400C098")]
		[FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_set_dialogFontSize;

		// Token: 0x0400C099 RID: 49305
		[Token(Token = "0x400C099")]
		[FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_get_dialogFontSizeIndex;

		// Token: 0x0400C09A RID: 49306
		[Token(Token = "0x400C09A")]
		[FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0_set_dialogFontSizeIndex;

		// Token: 0x0400C09B RID: 49307
		[Token(Token = "0x400C09B")]
		[FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_get_dialogPresetId;

		// Token: 0x0400C09C RID: 49308
		[Token(Token = "0x400C09C")]
		[FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_set_dialogPresetId;

		// Token: 0x0400C09D RID: 49309
		[Token(Token = "0x400C09D")]
		[FieldOffset(Offset = "0x438")]
		private static DelegateBridge __Hotfix0_ReaderModeSetFont;

		// Token: 0x0400C09E RID: 49310
		[Token(Token = "0x400C09E")]
		[FieldOffset(Offset = "0x440")]
		private static DelegateBridge __Hotfix0_ReaderModeSetLineSpace;

		// Token: 0x0400C09F RID: 49311
		[Token(Token = "0x400C09F")]
		[FieldOffset(Offset = "0x448")]
		private static DelegateBridge __Hotfix0_ReaderModeSetAlpha;

		// Token: 0x0400C0A0 RID: 49312
		[Token(Token = "0x400C0A0")]
		[FieldOffset(Offset = "0x450")]
		private static DelegateBridge __Hotfix0_get_readerFontSize;

		// Token: 0x0400C0A1 RID: 49313
		[Token(Token = "0x400C0A1")]
		[FieldOffset(Offset = "0x458")]
		private static DelegateBridge __Hotfix0_set_readerFontSize;

		// Token: 0x0400C0A2 RID: 49314
		[Token(Token = "0x400C0A2")]
		[FieldOffset(Offset = "0x460")]
		private static DelegateBridge __Hotfix0_get_readerLineSpace;

		// Token: 0x0400C0A3 RID: 49315
		[Token(Token = "0x400C0A3")]
		[FieldOffset(Offset = "0x468")]
		private static DelegateBridge __Hotfix0_set_readerLineSpace;

		// Token: 0x0400C0A4 RID: 49316
		[Token(Token = "0x400C0A4")]
		[FieldOffset(Offset = "0x470")]
		private static DelegateBridge __Hotfix0_get_readerFontSizeIndex;

		// Token: 0x0400C0A5 RID: 49317
		[Token(Token = "0x400C0A5")]
		[FieldOffset(Offset = "0x478")]
		private static DelegateBridge __Hotfix0_set_readerFontSizeIndex;

		// Token: 0x0400C0A6 RID: 49318
		[Token(Token = "0x400C0A6")]
		[FieldOffset(Offset = "0x480")]
		private static DelegateBridge __Hotfix0_get_readerLineSpaceIndex;

		// Token: 0x0400C0A7 RID: 49319
		[Token(Token = "0x400C0A7")]
		[FieldOffset(Offset = "0x488")]
		private static DelegateBridge __Hotfix0_set_readerLineSpaceIndex;

		// Token: 0x0400C0A8 RID: 49320
		[Token(Token = "0x400C0A8")]
		[FieldOffset(Offset = "0x490")]
		private static DelegateBridge __Hotfix0_get_readerBgAlpha;

		// Token: 0x0400C0A9 RID: 49321
		[Token(Token = "0x400C0A9")]
		[FieldOffset(Offset = "0x498")]
		private static DelegateBridge __Hotfix0_set_readerBgAlpha;

		// Token: 0x0400C0AA RID: 49322
		[Token(Token = "0x400C0AA")]
		[FieldOffset(Offset = "0x4A0")]
		private static DelegateBridge __Hotfix0_get_readerBgAlphaIndex;

		// Token: 0x0400C0AB RID: 49323
		[Token(Token = "0x400C0AB")]
		[FieldOffset(Offset = "0x4A8")]
		private static DelegateBridge __Hotfix0_set_readerBgAlphaIndex;

		// Token: 0x0400C0AC RID: 49324
		[Token(Token = "0x400C0AC")]
		[FieldOffset(Offset = "0x4B0")]
		private static DelegateBridge __Hotfix0_EditorOnlySetAVGEvents;

		// Token: 0x0400C0AD RID: 49325
		[Token(Token = "0x400C0AD")]
		[FieldOffset(Offset = "0x4B8")]
		private static DelegateBridge __Hotfix0__EditorOnlyNotifyCommandExecuted;

		// Token: 0x0400C0AE RID: 49326
		[Token(Token = "0x400C0AE")]
		[FieldOffset(Offset = "0x4C0")]
		private static DelegateBridge __Hotfix0__EditorOnlyNotifyCommandFinished;

		// Token: 0x0400C0AF RID: 49327
		[Token(Token = "0x400C0AF")]
		[FieldOffset(Offset = "0x4C8")]
		private static DelegateBridge __Hotfix0_EditorOnlyAbortRemaineCommands;

		// Token: 0x0400C0B0 RID: 49328
		[Token(Token = "0x400C0B0")]
		[FieldOffset(Offset = "0x4D0")]
		private static DelegateBridge __Hotfix0_get_enableReader;

		// Token: 0x0400C0B1 RID: 49329
		[Token(Token = "0x400C0B1")]
		[FieldOffset(Offset = "0x4D8")]
		private static DelegateBridge __Hotfix0_ShouldEnableReaderMode;

		// Token: 0x0400C0B2 RID: 49330
		[Token(Token = "0x400C0B2")]
		[FieldOffset(Offset = "0x4E0")]
		private static DelegateBridge __Hotfix0__InitReaderModeSwitch;

		// Token: 0x0400C0B3 RID: 49331
		[Token(Token = "0x400C0B3")]
		[FieldOffset(Offset = "0x4E8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E33 RID: 7731
		[Token(Token = "0x2001E33")]
		public enum FitMode
		{
			// Token: 0x0400C0B5 RID: 49333
			[Token(Token = "0x400C0B5")]
			DEFAULT,
			// Token: 0x0400C0B6 RID: 49334
			[Token(Token = "0x400C0B6")]
			BLACK_MASK
		}

		// Token: 0x02001E34 RID: 7732
		[Token(Token = "0x2001E34")]
		public enum Event
		{
			// Token: 0x0400C0B8 RID: 49336
			[Token(Token = "0x400C0B8")]
			ON_BEGIN,
			// Token: 0x0400C0B9 RID: 49337
			[Token(Token = "0x400C0B9")]
			ON_END_SUCCEED,
			// Token: 0x0400C0BA RID: 49338
			[Token(Token = "0x400C0BA")]
			ON_END_FAILED,
			// Token: 0x0400C0BB RID: 49339
			[Token(Token = "0x400C0BB")]
			ON_RESET,
			// Token: 0x0400C0BC RID: 49340
			[Token(Token = "0x400C0BC")]
			ON_CLICK,
			// Token: 0x0400C0BD RID: 49341
			[Token(Token = "0x400C0BD")]
			ON_SPEED_SET,
			// Token: 0x0400C0BE RID: 49342
			[Token(Token = "0x400C0BE")]
			ON_PRE_END
		}

		// Token: 0x02001E35 RID: 7733
		[Token(Token = "0x2001E35")]
		public interface ICommandFlowController
		{
			// Token: 0x0600BF8D RID: 49037
			[Token(Token = "0x600BF8D")]
			void Reset();

			// Token: 0x0600BF8E RID: 49038
			[Token(Token = "0x600BF8E")]
			void PreprocessCommands(List<Command> commands);

			// Token: 0x0600BF8F RID: 49039
			[Token(Token = "0x600BF8F")]
			int GotoCommandIndex();
		}

		// Token: 0x02001E36 RID: 7734
		[Token(Token = "0x2001E36")]
		public interface ICommandSkipController
		{
			// Token: 0x0600BF90 RID: 49040
			[Token(Token = "0x600BF90")]
			void Reset();

			// Token: 0x0600BF91 RID: 49041
			[Token(Token = "0x600BF91")]
			void PreprocessCommands(List<Command> commands);
		}

		// Token: 0x02001E37 RID: 7735
		[Token(Token = "0x2001E37")]
		public class AVGCompBridge : IHotfixable
		{
			// Token: 0x0600BF92 RID: 49042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BF92")]
			[Address(RVA = "0x33D8200", Offset = "0x33D6E00", VA = "0x1833D8200")]
			public AVGCompBridge(AVGController context)
			{
			}

			// Token: 0x0600BF93 RID: 49043 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600BF93")]
			[Address(RVA = "0x33D8190", Offset = "0x33D6D90", VA = "0x1833D8190")]
			public AVGSceneEffectManager TryGetSceneEffectMgr()
			{
				return null;
			}

			// Token: 0x0600BF94 RID: 49044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BF94")]
			[Address(RVA = "0x33D80F0", Offset = "0x33D6CF0", VA = "0x1833D80F0")]
			public void AbortRemainingCommands()
			{
			}

			// Token: 0x0400C0BF RID: 49343
			[Token(Token = "0x400C0BF")]
			[FieldOffset(Offset = "0x10")]
			private AVGController m_context;

			// Token: 0x0400C0C0 RID: 49344
			[Token(Token = "0x400C0C0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400C0C1 RID: 49345
			[Token(Token = "0x400C0C1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_TryGetSceneEffectMgr;

			// Token: 0x0400C0C2 RID: 49346
			[Token(Token = "0x400C0C2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_AbortRemainingCommands;
		}
	}
}
