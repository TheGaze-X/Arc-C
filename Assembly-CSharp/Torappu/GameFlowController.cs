using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;

namespace Torappu
{
	// Token: 0x020004DF RID: 1247
	[Token(Token = "0x20004DF")]
	public class GameFlowController : SingletonMonoBehaviour<GameFlowController>, ISingletonNotAutoCreate
	{
		// Token: 0x06004DF7 RID: 19959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF7")]
		[Address(RVA = "0x18831D0", Offset = "0x1881DD0", VA = "0x1818831D0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004DF8 RID: 19960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF8")]
		[Address(RVA = "0x1883080", Offset = "0x1881C80", VA = "0x181883080", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06004DF9 RID: 19961 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004DFA RID: 19962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002A")]
		public static event Action<string, string> beforeSceneTransition
		{
			[Token(Token = "0x6004DF9")]
			[Address(RVA = "0x1885F40", Offset = "0x1884B40", VA = "0x181885F40")]
			add
			{
			}
			[Token(Token = "0x6004DFA")]
			[Address(RVA = "0x1886600", Offset = "0x1885200", VA = "0x181886600")]
			remove
			{
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06004DFB RID: 19963 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004DFC RID: 19964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002B")]
		public static event Action<string, string> beforeSceneLoadingStart
		{
			[Token(Token = "0x6004DFB")]
			[Address(RVA = "0x1885E40", Offset = "0x1884A40", VA = "0x181885E40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004DFC")]
			[Address(RVA = "0x1886500", Offset = "0x1885100", VA = "0x181886500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06004DFD RID: 19965 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004DFE RID: 19966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002C")]
		public static event Action<Scene, LoadSceneMode> onSceneLoaded
		{
			[Token(Token = "0x6004DFD")]
			[Address(RVA = "0x1885FC0", Offset = "0x1884BC0", VA = "0x181885FC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004DFE")]
			[Address(RVA = "0x1886680", Offset = "0x1885280", VA = "0x181886680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06004DFF RID: 19967 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06004E00 RID: 19968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002D")]
		public static event Action<Scene> onSceneUnloaded
		{
			[Token(Token = "0x6004DFF")]
			[Address(RVA = "0x18860C0", Offset = "0x1884CC0", VA = "0x1818860C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004E00")]
			[Address(RVA = "0x1886780", Offset = "0x1885380", VA = "0x181886780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004E01 RID: 19969 RVA: 0x0002DD80 File Offset: 0x0002BF80
		[Token(Token = "0x6004E01")]
		[Address(RVA = "0x1882D60", Offset = "0x1881960", VA = "0x181882D60")]
		public static GameFlowController.RecentLoadSceneMode GetRecentLoadSceneMode(Scene scene)
		{
			return GameFlowController.RecentLoadSceneMode.NONE;
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x0002DD98 File Offset: 0x0002BF98
		[Token(Token = "0x6004E02")]
		[Address(RVA = "0x1882F80", Offset = "0x1881B80", VA = "0x181882F80")]
		public static bool IsMainScene(Scene scene)
		{
			return default(bool);
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06004E03 RID: 19971 RVA: 0x0002DDB0 File Offset: 0x0002BFB0
		[Token(Token = "0x1700020E")]
		public static bool isTransiting
		{
			[Token(Token = "0x6004E03")]
			[Address(RVA = "0x1886440", Offset = "0x1885040", VA = "0x181886440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x0002DDC8 File Offset: 0x0002BFC8
		[Token(Token = "0x6004E04")]
		[Address(RVA = "0x18835F0", Offset = "0x18821F0", VA = "0x1818835F0")]
		public static bool StartScene(string sceneName, GameFlowController.Options options)
		{
			return default(bool);
		}

		// Token: 0x06004E05 RID: 19973 RVA: 0x0002DDE0 File Offset: 0x0002BFE0
		[Token(Token = "0x6004E05")]
		[Address(RVA = "0x18836D0", Offset = "0x18822D0", VA = "0x1818836D0")]
		public static bool StartScene(string sceneName)
		{
			return default(bool);
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x0002DDF8 File Offset: 0x0002BFF8
		[Token(Token = "0x6004E06")]
		[Address(RVA = "0x18829E0", Offset = "0x18815E0", VA = "0x1818829E0")]
		public static bool AddScene(string sceneName)
		{
			return default(bool);
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x0002DE10 File Offset: 0x0002C010
		[Token(Token = "0x6004E07")]
		[Address(RVA = "0x18827B0", Offset = "0x18813B0", VA = "0x1818827B0")]
		public static bool AddAdditiveBattleScene(IAddtiveBattleScene battleScene)
		{
			return default(bool);
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x0002DE28 File Offset: 0x0002C028
		[Token(Token = "0x6004E08")]
		[Address(RVA = "0x1883350", Offset = "0x1881F50", VA = "0x181883350")]
		public static bool RemoveAdditiveBattleScene()
		{
			return default(bool);
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E09")]
		[Address(RVA = "0x1882FE0", Offset = "0x1881BE0", VA = "0x181882FE0")]
		protected AsyncOperation LoadAdditiveSceneAsync(string sceneName, LoadSceneMode mode)
		{
			return null;
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E0A")]
		[Address(RVA = "0x1883450", Offset = "0x1882050", VA = "0x181883450")]
		public static void StartSceneAnyway(string sceneName)
		{
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E0B")]
		[Address(RVA = "0x1883510", Offset = "0x1882110", VA = "0x181883510")]
		public static void StartSceneAnyway(string sceneName, GameFlowController.Options options)
		{
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06004E0C RID: 19980 RVA: 0x0002DE40 File Offset: 0x0002C040
		[Token(Token = "0x1700020F")]
		public static SceneBundle currentSceneBundle
		{
			[Token(Token = "0x6004E0C")]
			[Address(RVA = "0x1886310", Offset = "0x1884F10", VA = "0x181886310")]
			get
			{
				return default(SceneBundle);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06004E0D RID: 19981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000210")]
		public static string currentScene
		{
			[Token(Token = "0x6004E0D")]
			[Address(RVA = "0x18863C0", Offset = "0x1884FC0", VA = "0x1818863C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06004E0E RID: 19982 RVA: 0x0002DE58 File Offset: 0x0002C058
		[Token(Token = "0x17000211")]
		public static SceneBundle currentAddingSceneBundle
		{
			[Token(Token = "0x6004E0E")]
			[Address(RVA = "0x1886260", Offset = "0x1884E60", VA = "0x181886260")]
			get
			{
				return default(SceneBundle);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06004E0F RID: 19983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000212")]
		public static IAddtiveBattleScene currAddtiveBattleScene
		{
			[Token(Token = "0x6004E0F")]
			[Address(RVA = "0x18861C0", Offset = "0x1884DC0", VA = "0x1818861C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x0002DE70 File Offset: 0x0002C070
		[Token(Token = "0x6004E10")]
		[Address(RVA = "0x18837F0", Offset = "0x18823F0", VA = "0x1818837F0")]
		public static GameFlowController.WaitForSceneLoaded StartWaitForSceneLoaded(string sceneName)
		{
			return default(GameFlowController.WaitForSceneLoaded);
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x0002DE88 File Offset: 0x0002C088
		[Token(Token = "0x6004E11")]
		[Address(RVA = "0x1885150", Offset = "0x1883D50", VA = "0x181885150")]
		private bool _StartScene(string sceneName, GameFlowController.Options options)
		{
			return default(bool);
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x0002DEA0 File Offset: 0x0002C0A0
		[Token(Token = "0x6004E12")]
		[Address(RVA = "0x1885490", Offset = "0x1884090", VA = "0x181885490")]
		private bool _StartScene(string sceneName)
		{
			return default(bool);
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E13")]
		[Address(RVA = "0x1884FA0", Offset = "0x1883BA0", VA = "0x181884FA0")]
		private void _StartSceneAnyway(string sceneName, GameFlowController.Options options)
		{
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E14")]
		[Address(RVA = "0x1885540", Offset = "0x1884140", VA = "0x181885540")]
		private IEnumerator _TransitSceneCoroutine(string sceneName, GameFlowController.Options options)
		{
			return null;
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E15")]
		[Address(RVA = "0x1884780", Offset = "0x1883380", VA = "0x181884780")]
		private IEnumerator _LoadEmptySceneToClear(GameFlowController.Options options)
		{
			return null;
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E16")]
		[Address(RVA = "0x1884340", Offset = "0x1882F40", VA = "0x181884340")]
		private IEnumerator _DoCommonClearLogic(GameFlowController.Options options)
		{
			return null;
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E17")]
		[Address(RVA = "0x1884B40", Offset = "0x1883740", VA = "0x181884B40")]
		private void _OnSceneLoaded(string sceneName)
		{
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E18")]
		[Address(RVA = "0x1884E20", Offset = "0x1883A20", VA = "0x181884E20")]
		private IEnumerator _ShowBlackLoading()
		{
			return null;
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E19")]
		[Address(RVA = "0x18844E0", Offset = "0x18830E0", VA = "0x1818844E0")]
		private IEnumerator _HideBlackLoading()
		{
			return null;
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1A")]
		[Address(RVA = "0x1884ED0", Offset = "0x1883AD0", VA = "0x181884ED0")]
		private IEnumerator _ShowSceneLoading(string illustId)
		{
			return null;
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1B")]
		[Address(RVA = "0x1884590", Offset = "0x1883190", VA = "0x181884590")]
		private IEnumerator _HideSceneLoading()
		{
			return null;
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1C")]
		[Address(RVA = "0x1884430", Offset = "0x1883030", VA = "0x181884430")]
		private IEnumerator _HideBlackAndSceneLoading()
		{
			return null;
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1D")]
		[Address(RVA = "0x1884C20", Offset = "0x1883820", VA = "0x181884C20")]
		private IEnumerator _PrepareLoadingsBeforeTransition()
		{
			return null;
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1E")]
		[Address(RVA = "0x1884640", Offset = "0x1883240", VA = "0x181884640")]
		private IEnumerator _LiteLoadBattleFinish(string sceneName, GameFlowController.Options options)
		{
			return null;
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x0002DEB8 File Offset: 0x0002C0B8
		[Token(Token = "0x6004E1F")]
		[Address(RVA = "0x1883DE0", Offset = "0x18829E0", VA = "0x181883DE0")]
		private bool _AddScene(string name)
		{
			return default(bool);
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E20")]
		[Address(RVA = "0x1883D10", Offset = "0x1882910", VA = "0x181883D10")]
		private IEnumerator _AddSceneCoroutine(string name)
		{
			return null;
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x0002DED0 File Offset: 0x0002C0D0
		[Token(Token = "0x6004E21")]
		[Address(RVA = "0x1883B40", Offset = "0x1882740", VA = "0x181883B40")]
		private bool _AddAdditiveBattleScene(IAddtiveBattleScene battleScene)
		{
			return default(bool);
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E22")]
		[Address(RVA = "0x1883A90", Offset = "0x1882690", VA = "0x181883A90")]
		private IEnumerator _AddAdditiveBattleSceneCoroutine()
		{
			return null;
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x0002DEE8 File Offset: 0x0002C0E8
		[Token(Token = "0x6004E23")]
		[Address(RVA = "0x1884DA0", Offset = "0x18839A0", VA = "0x181884DA0")]
		private bool _RemoveAdditiveBattleScene()
		{
			return default(bool);
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E24")]
		[Address(RVA = "0x1884CD0", Offset = "0x18838D0", VA = "0x181884CD0")]
		private IEnumerator _RemoveAdditiveBattleSceneCoroutine(bool bySceneTrans)
		{
			return null;
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E25")]
		[Address(RVA = "0x18842E0", Offset = "0x1882EE0", VA = "0x1818842E0")]
		private static void _DeletePersistentRes()
		{
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E26")]
		[Address(RVA = "0x1882CD0", Offset = "0x18818D0", VA = "0x181882CD0")]
		public static void DeleteAllPlayerPrefs()
		{
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E27")]
		[Address(RVA = "0x1884080", Offset = "0x1882C80", VA = "0x181884080")]
		private static void _DeleleAllPlayerPrefs()
		{
		}

		// Token: 0x06004E28 RID: 20008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E28")]
		[Address(RVA = "0x1884A70", Offset = "0x1883670", VA = "0x181884A70")]
		private void _MayOverrideNextScene(string fromScene, string toScene, ref GameFlowController.Options options)
		{
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x0002DF00 File Offset: 0x0002C100
		[Token(Token = "0x6004E29")]
		[Address(RVA = "0x1885680", Offset = "0x1884280", VA = "0x181885680")]
		private bool _TryHookStoryScene(string fromScene, string toScene, ref GameFlowController.Options options)
		{
			return default(bool);
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2A")]
		[Address(RVA = "0x1884990", Offset = "0x1883590", VA = "0x181884990")]
		private static IEnumerator _LoadTargetSceneAsync(string sceneName, GameFlowController.Options options)
		{
			return null;
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2B")]
		[Address(RVA = "0x1884890", Offset = "0x1883490", VA = "0x181884890")]
		private static IEnumerator _LoadTargetSceneAsyncFastMode(string sceneName, GameFlowController.Options options, [Optional] LatchUtils.InvokeWhenUnlock activeSceneLatch)
		{
			return null;
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2C")]
		[Address(RVA = "0x1883F80", Offset = "0x1882B80", VA = "0x181883F80")]
		private static void _BeforeSceneLoadingStart()
		{
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x0002DF18 File Offset: 0x0002C118
		[Token(Token = "0x6004E2D")]
		[Address(RVA = "0x1882BF0", Offset = "0x18817F0", VA = "0x181882BF0")]
		public static bool CheckIsInBattleScene()
		{
			return default(bool);
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x0002DF30 File Offset: 0x0002C130
		[Token(Token = "0x6004E2E")]
		[Address(RVA = "0x1882C60", Offset = "0x1881860", VA = "0x181882C60")]
		public static bool CheckIsInStoryScene()
		{
			return default(bool);
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2F")]
		[Address(RVA = "0x1885C40", Offset = "0x1884840", VA = "0x181885C40")]
		public GameFlowController()
		{
		}

		// Token: 0x04001218 RID: 4632
		[Token(Token = "0x4001218")]
		private const float ASYNC_SCENE_LOAD_MAX_PROGRESS = 0.8f;

		// Token: 0x04001219 RID: 4633
		[Token(Token = "0x4001219")]
		private const float LOADING_MODE_MIN_WAITING_TIME = 0.5f;

		// Token: 0x0400121A RID: 4634
		[Token(Token = "0x400121A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ListSet<string> m_addingScenes;

		// Token: 0x0400121B RID: 4635
		[Token(Token = "0x400121B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_isTransiting;

		// Token: 0x0400121C RID: 4636
		[Token(Token = "0x400121C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SceneBundle m_sceneBundle;

		// Token: 0x0400121D RID: 4637
		[Token(Token = "0x400121D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SceneBundle m_addingSceneBundle;

		// Token: 0x0400121E RID: 4638
		[Token(Token = "0x400121E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IAddtiveBattleScene m_addtiveBattleScene;

		// Token: 0x0400121F RID: 4639
		[Token(Token = "0x400121F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isAdditiveUnloading;

		// Token: 0x04001220 RID: 4640
		[Token(Token = "0x4001220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameFlowController.LoadSceneInfoManager m_loadSceneInfoMgr;

		// Token: 0x04001224 RID: 4644
		[Token(Token = "0x4001224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_isShowBlackLoading;

		// Token: 0x04001225 RID: 4645
		[Token(Token = "0x4001225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_isShowSceneLoading;

		// Token: 0x04001226 RID: 4646
		[Token(Token = "0x4001226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04001227 RID: 4647
		[Token(Token = "0x4001227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04001228 RID: 4648
		[Token(Token = "0x4001228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_add_beforeSceneTransition;

		// Token: 0x04001229 RID: 4649
		[Token(Token = "0x4001229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_remove_beforeSceneTransition;

		// Token: 0x0400122A RID: 4650
		[Token(Token = "0x400122A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_add_beforeSceneLoadingStart;

		// Token: 0x0400122B RID: 4651
		[Token(Token = "0x400122B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_remove_beforeSceneLoadingStart;

		// Token: 0x0400122C RID: 4652
		[Token(Token = "0x400122C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_add_onSceneLoaded;

		// Token: 0x0400122D RID: 4653
		[Token(Token = "0x400122D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_remove_onSceneLoaded;

		// Token: 0x0400122E RID: 4654
		[Token(Token = "0x400122E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_add_onSceneUnloaded;

		// Token: 0x0400122F RID: 4655
		[Token(Token = "0x400122F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_remove_onSceneUnloaded;

		// Token: 0x04001230 RID: 4656
		[Token(Token = "0x4001230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetRecentLoadSceneMode;

		// Token: 0x04001231 RID: 4657
		[Token(Token = "0x4001231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_IsMainScene;

		// Token: 0x04001232 RID: 4658
		[Token(Token = "0x4001232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_isTransiting;

		// Token: 0x04001233 RID: 4659
		[Token(Token = "0x4001233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_StartScene;

		// Token: 0x04001234 RID: 4660
		[Token(Token = "0x4001234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1_StartScene;

		// Token: 0x04001235 RID: 4661
		[Token(Token = "0x4001235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_AddScene;

		// Token: 0x04001236 RID: 4662
		[Token(Token = "0x4001236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_AddAdditiveBattleScene;

		// Token: 0x04001237 RID: 4663
		[Token(Token = "0x4001237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_RemoveAdditiveBattleScene;

		// Token: 0x04001238 RID: 4664
		[Token(Token = "0x4001238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadAdditiveSceneAsync;

		// Token: 0x04001239 RID: 4665
		[Token(Token = "0x4001239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_StartSceneAnyway;

		// Token: 0x0400123A RID: 4666
		[Token(Token = "0x400123A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix1_StartSceneAnyway;

		// Token: 0x0400123B RID: 4667
		[Token(Token = "0x400123B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_currentSceneBundle;

		// Token: 0x0400123C RID: 4668
		[Token(Token = "0x400123C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_currentScene;

		// Token: 0x0400123D RID: 4669
		[Token(Token = "0x400123D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_currentAddingSceneBundle;

		// Token: 0x0400123E RID: 4670
		[Token(Token = "0x400123E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_currAddtiveBattleScene;

		// Token: 0x0400123F RID: 4671
		[Token(Token = "0x400123F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_StartWaitForSceneLoaded;

		// Token: 0x04001240 RID: 4672
		[Token(Token = "0x4001240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__StartScene;

		// Token: 0x04001241 RID: 4673
		[Token(Token = "0x4001241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix1__StartScene;

		// Token: 0x04001242 RID: 4674
		[Token(Token = "0x4001242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__StartSceneAnyway;

		// Token: 0x04001243 RID: 4675
		[Token(Token = "0x4001243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__TransitSceneCoroutine;

		// Token: 0x04001244 RID: 4676
		[Token(Token = "0x4001244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__LoadEmptySceneToClear;

		// Token: 0x04001245 RID: 4677
		[Token(Token = "0x4001245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__DoCommonClearLogic;

		// Token: 0x04001246 RID: 4678
		[Token(Token = "0x4001246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OnSceneLoaded;

		// Token: 0x04001247 RID: 4679
		[Token(Token = "0x4001247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__ShowBlackLoading;

		// Token: 0x04001248 RID: 4680
		[Token(Token = "0x4001248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__HideBlackLoading;

		// Token: 0x04001249 RID: 4681
		[Token(Token = "0x4001249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__ShowSceneLoading;

		// Token: 0x0400124A RID: 4682
		[Token(Token = "0x400124A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__HideSceneLoading;

		// Token: 0x0400124B RID: 4683
		[Token(Token = "0x400124B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__HideBlackAndSceneLoading;

		// Token: 0x0400124C RID: 4684
		[Token(Token = "0x400124C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__PrepareLoadingsBeforeTransition;

		// Token: 0x0400124D RID: 4685
		[Token(Token = "0x400124D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__LiteLoadBattleFinish;

		// Token: 0x0400124E RID: 4686
		[Token(Token = "0x400124E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__AddScene;

		// Token: 0x0400124F RID: 4687
		[Token(Token = "0x400124F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__AddSceneCoroutine;

		// Token: 0x04001250 RID: 4688
		[Token(Token = "0x4001250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__AddAdditiveBattleScene;

		// Token: 0x04001251 RID: 4689
		[Token(Token = "0x4001251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__AddAdditiveBattleSceneCoroutine;

		// Token: 0x04001252 RID: 4690
		[Token(Token = "0x4001252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__RemoveAdditiveBattleScene;

		// Token: 0x04001253 RID: 4691
		[Token(Token = "0x4001253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__RemoveAdditiveBattleSceneCoroutine;

		// Token: 0x04001254 RID: 4692
		[Token(Token = "0x4001254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__DeletePersistentRes;

		// Token: 0x04001255 RID: 4693
		[Token(Token = "0x4001255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_DeleteAllPlayerPrefs;

		// Token: 0x04001256 RID: 4694
		[Token(Token = "0x4001256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__DeleleAllPlayerPrefs;

		// Token: 0x04001257 RID: 4695
		[Token(Token = "0x4001257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__MayOverrideNextScene;

		// Token: 0x04001258 RID: 4696
		[Token(Token = "0x4001258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__TryHookStoryScene;

		// Token: 0x04001259 RID: 4697
		[Token(Token = "0x4001259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__LoadTargetSceneAsync;

		// Token: 0x0400125A RID: 4698
		[Token(Token = "0x400125A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__LoadTargetSceneAsyncFastMode;

		// Token: 0x0400125B RID: 4699
		[Token(Token = "0x400125B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__BeforeSceneLoadingStart;

		// Token: 0x0400125C RID: 4700
		[Token(Token = "0x400125C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_CheckIsInBattleScene;

		// Token: 0x0400125D RID: 4701
		[Token(Token = "0x400125D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_CheckIsInStoryScene;

		// Token: 0x0400125E RID: 4702
		[Token(Token = "0x400125E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020004E0 RID: 1248
		[Token(Token = "0x20004E0")]
		public struct Options
		{
			// Token: 0x0400125F RID: 4703
			[Token(Token = "0x400125F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly GameFlowController.Options DEFAULT;

			// Token: 0x04001260 RID: 4704
			[Token(Token = "0x4001260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static readonly GameFlowController.Options FAST_MODE;

			// Token: 0x04001261 RID: 4705
			[Token(Token = "0x4001261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static readonly GameFlowController.Options LOADING_MODE;

			// Token: 0x04001262 RID: 4706
			[Token(Token = "0x4001262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static readonly GameFlowController.Options FAST_LOADING_MODE;

			// Token: 0x04001263 RID: 4707
			[Token(Token = "0x4001263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ISceneParam param;

			// Token: 0x04001264 RID: 4708
			[Token(Token = "0x4001264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool unloadAllAssets;

			// Token: 0x04001265 RID: 4709
			[Token(Token = "0x4001265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public bool reloadAllAssets;

			// Token: 0x04001266 RID: 4710
			[Token(Token = "0x4001266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public bool stopMusic;

			// Token: 0x04001267 RID: 4711
			[Token(Token = "0x4001267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			public bool notUseEmptySceneToClear;

			// Token: 0x04001268 RID: 4712
			[Token(Token = "0x4001268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool dontResetTimeScale;

			// Token: 0x04001269 RID: 4713
			[Token(Token = "0x4001269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string loadingIllust;

			// Token: 0x0400126A RID: 4714
			[Token(Token = "0x400126A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameFlowController.Options.Mode mode;

			// Token: 0x0400126B RID: 4715
			[Token(Token = "0x400126B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public UIMaskType maskType;

			// Token: 0x0400126C RID: 4716
			[Token(Token = "0x400126C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool deletePersistentRes;

			// Token: 0x0400126D RID: 4717
			[Token(Token = "0x400126D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool enableForceUnloading;

			// Token: 0x020004E1 RID: 1249
			[Token(Token = "0x20004E1")]
			public enum Mode
			{
				// Token: 0x0400126F RID: 4719
				[Token(Token = "0x400126F")]
				DEFAULT,
				// Token: 0x04001270 RID: 4720
				[Token(Token = "0x4001270")]
				FAST_MODE,
				// Token: 0x04001271 RID: 4721
				[Token(Token = "0x4001271")]
				LOADING_MODE,
				// Token: 0x04001272 RID: 4722
				[Token(Token = "0x4001272")]
				LITE_BATTLE_FINISH
			}
		}

		// Token: 0x020004E2 RID: 1250
		[Token(Token = "0x20004E2")]
		public enum RecentLoadSceneMode
		{
			// Token: 0x04001274 RID: 4724
			[Token(Token = "0x4001274")]
			NONE,
			// Token: 0x04001275 RID: 4725
			[Token(Token = "0x4001275")]
			SINGLE,
			// Token: 0x04001276 RID: 4726
			[Token(Token = "0x4001276")]
			ADDITIVE
		}

		// Token: 0x020004E3 RID: 1251
		[Token(Token = "0x20004E3")]
		public struct WaitForSceneLoaded
		{
			// Token: 0x06004E33 RID: 20019 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E33")]
			[Address(RVA = "0x1896DE0", Offset = "0x18959E0", VA = "0x181896DE0")]
			public WaitForSceneLoaded(string key, uint seqnum, Func<string, uint, bool> keepWaitingFunc)
			{
			}

			// Token: 0x06004E34 RID: 20020 RVA: 0x0002DF78 File Offset: 0x0002C178
			[Token(Token = "0x6004E34")]
			[Address(RVA = "0x1896DB0", Offset = "0x18959B0", VA = "0x181896DB0")]
			public bool KeepWaiting()
			{
				return default(bool);
			}

			// Token: 0x04001277 RID: 4727
			[Token(Token = "0x4001277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string m_key;

			// Token: 0x04001278 RID: 4728
			[Token(Token = "0x4001278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private uint m_seqnum;

			// Token: 0x04001279 RID: 4729
			[Token(Token = "0x4001279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Func<string, uint, bool> m_keepWaitingFunc;
		}

		// Token: 0x020004E4 RID: 1252
		[Token(Token = "0x20004E4")]
		private class LoadSceneMeta
		{
			// Token: 0x06004E35 RID: 20021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E35")]
			[Address(RVA = "0x188A370", Offset = "0x1888F70", VA = "0x18188A370")]
			public void Load(Scene scene, LoadSceneMode loadMode, uint seqnum)
			{
			}

			// Token: 0x06004E36 RID: 20022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E36")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LoadSceneMeta()
			{
			}

			// Token: 0x0400127A RID: 4730
			[Token(Token = "0x400127A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LoadSceneMode loadMode;

			// Token: 0x0400127B RID: 4731
			[Token(Token = "0x400127B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint seqnum;
		}

		// Token: 0x020004E5 RID: 1253
		[Token(Token = "0x20004E5")]
		private class LoadSceneInfoManager : IHotfixable
		{
			// Token: 0x06004E37 RID: 20023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E37")]
			[Address(RVA = "0x1889CF0", Offset = "0x18888F0", VA = "0x181889CF0")]
			public void OnSceneLoaded(Scene scene, LoadSceneMode loadMode)
			{
			}

			// Token: 0x06004E38 RID: 20024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E38")]
			[Address(RVA = "0x1889E70", Offset = "0x1888A70", VA = "0x181889E70")]
			public void OnSceneUnloaded(Scene scene)
			{
			}

			// Token: 0x06004E39 RID: 20025 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E39")]
			[Address(RVA = "0x1889BF0", Offset = "0x18887F0", VA = "0x181889BF0")]
			public GameFlowController.LoadSceneMeta GetLoadSceneMeta(Scene scene)
			{
				return null;
			}

			// Token: 0x06004E3A RID: 20026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E3A")]
			[Address(RVA = "0x1889AF0", Offset = "0x18886F0", VA = "0x181889AF0")]
			public GameFlowController.LoadSceneMeta GetLoadSceneMeta(string sceneName)
			{
				return null;
			}

			// Token: 0x06004E3B RID: 20027 RVA: 0x0002DF90 File Offset: 0x0002C190
			[Token(Token = "0x6004E3B")]
			[Address(RVA = "0x1889FA0", Offset = "0x1888BA0", VA = "0x181889FA0")]
			public GameFlowController.WaitForSceneLoaded WaitForSceneLoaded(string sceneName)
			{
				return default(GameFlowController.WaitForSceneLoaded);
			}

			// Token: 0x06004E3C RID: 20028 RVA: 0x0002DFA8 File Offset: 0x0002C1A8
			[Token(Token = "0x6004E3C")]
			[Address(RVA = "0x188A190", Offset = "0x1888D90", VA = "0x18188A190")]
			private bool _KeepWaitingForSceneLoaded(string sceneName, uint lastSeqNum)
			{
				return default(bool);
			}

			// Token: 0x06004E3D RID: 20029 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E3D")]
			[Address(RVA = "0x188A100", Offset = "0x1888D00", VA = "0x18188A100")]
			private static string _GetSceneKey(Scene scene)
			{
				return null;
			}

			// Token: 0x06004E3E RID: 20030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E3E")]
			[Address(RVA = "0x188A260", Offset = "0x1888E60", VA = "0x18188A260")]
			public LoadSceneInfoManager()
			{
			}

			// Token: 0x0400127C RID: 4732
			[Token(Token = "0x400127C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Dictionary<string, GameFlowController.LoadSceneMeta> m_loadSceneInfo;

			// Token: 0x0400127D RID: 4733
			[Token(Token = "0x400127D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private LocalGenericPool<GameFlowController.LoadSceneMeta> m_metaPool;

			// Token: 0x0400127E RID: 4734
			[Token(Token = "0x400127E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private uint m_sceneLoadSeqNum;

			// Token: 0x0400127F RID: 4735
			[Token(Token = "0x400127F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnSceneLoaded;

			// Token: 0x04001280 RID: 4736
			[Token(Token = "0x4001280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnSceneUnloaded;

			// Token: 0x04001281 RID: 4737
			[Token(Token = "0x4001281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetLoadSceneMeta;

			// Token: 0x04001282 RID: 4738
			[Token(Token = "0x4001282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix1_GetLoadSceneMeta;

			// Token: 0x04001283 RID: 4739
			[Token(Token = "0x4001283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_WaitForSceneLoaded;

			// Token: 0x04001284 RID: 4740
			[Token(Token = "0x4001284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__KeepWaitingForSceneLoaded;

			// Token: 0x04001285 RID: 4741
			[Token(Token = "0x4001285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__GetSceneKey;

			// Token: 0x04001286 RID: 4742
			[Token(Token = "0x4001286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
