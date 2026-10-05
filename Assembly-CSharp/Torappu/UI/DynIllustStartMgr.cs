using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034D3 RID: 13523
	[Token(Token = "0x20034D3")]
	public class DynIllustStartMgr : SingletonMonoBehaviour<DynIllustStartMgr>, ISingletonNotAutoCreate
	{
		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x060158E1 RID: 88289 RVA: 0x0008C958 File Offset: 0x0008AB58
		[Token(Token = "0x170032F8")]
		public bool isPlaying
		{
			[Token(Token = "0x60158E1")]
			[Address(RVA = "0xE035C0", Offset = "0xE021C0", VA = "0x180E035C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060158E2 RID: 88290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158E2")]
		[Address(RVA = "0xE024B0", Offset = "0xE010B0", VA = "0x180E024B0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060158E3 RID: 88291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158E3")]
		[Address(RVA = "0xE02430", Offset = "0xE01030", VA = "0x180E02430", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060158E4 RID: 88292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60158E4")]
		[Address(RVA = "0xE03390", Offset = "0xE01F90", VA = "0x180E03390")]
		private IEnumerator _ShowBlackMask(bool fastMode, Color color)
		{
			return null;
		}

		// Token: 0x060158E5 RID: 88293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158E5")]
		[Address(RVA = "0xE02FA0", Offset = "0xE01BA0", VA = "0x180E02FA0")]
		private void _HideBlackMask([Optional] Action onComplete)
		{
		}

		// Token: 0x060158E6 RID: 88294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158E6")]
		[Address(RVA = "0xE03100", Offset = "0xE01D00", VA = "0x180E03100")]
		private void _InitSwitchTween()
		{
		}

		// Token: 0x060158E7 RID: 88295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60158E7")]
		[Address(RVA = "0xE02600", Offset = "0xE01200", VA = "0x180E02600")]
		public Coroutine PlayDynEntrance(DynIllustStartMgr.Param param)
		{
			return null;
		}

		// Token: 0x060158E8 RID: 88296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60158E8")]
		[Address(RVA = "0xE031F0", Offset = "0xE01DF0", VA = "0x180E031F0")]
		private IEnumerator _PlayDynEntranceCoroutine(DynIllustStartMgr.Param param)
		{
			return null;
		}

		// Token: 0x060158E9 RID: 88297 RVA: 0x0008C970 File Offset: 0x0008AB70
		[Token(Token = "0x60158E9")]
		[Address(RVA = "0xE02860", Offset = "0xE01460", VA = "0x180E02860")]
		public bool TryFetchAndAddCameras(List<Camera> cameras)
		{
			return default(bool);
		}

		// Token: 0x060158EA RID: 88298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158EA")]
		[Address(RVA = "0xE02A30", Offset = "0xE01630", VA = "0x180E02A30")]
		private void _ClearDynEntrance()
		{
		}

		// Token: 0x060158EB RID: 88299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158EB")]
		[Address(RVA = "0xE02BA0", Offset = "0xE017A0", VA = "0x180E02BA0")]
		private void _DefaultPlayCharVoice(CharUISkinStruct skin)
		{
		}

		// Token: 0x060158EC RID: 88300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158EC")]
		[Address(RVA = "0xE02D60", Offset = "0xE01960", VA = "0x180E02D60")]
		private void _DefaultPlayDynIllustStart(CharUISkinStruct skin)
		{
		}

		// Token: 0x060158ED RID: 88301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158ED")]
		[Address(RVA = "0xE03480", Offset = "0xE02080", VA = "0x180E03480")]
		private void _StopBGM()
		{
		}

		// Token: 0x060158EE RID: 88302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158EE")]
		[Address(RVA = "0xE032C0", Offset = "0xE01EC0", VA = "0x180E032C0")]
		private void _ResumeBGM()
		{
		}

		// Token: 0x060158EF RID: 88303 RVA: 0x0008C988 File Offset: 0x0008AB88
		[Token(Token = "0x60158EF")]
		[Address(RVA = "0xE02F40", Offset = "0xE01B40", VA = "0x180E02F40")]
		private int _GetBGMInstId()
		{
			return 0;
		}

		// Token: 0x060158F0 RID: 88304 RVA: 0x0008C9A0 File Offset: 0x0008ABA0
		[Token(Token = "0x60158F0")]
		[Address(RVA = "0xE02720", Offset = "0xE01320", VA = "0x180E02720")]
		public static DynIllustStartMgr.CheckPlayDynEntranceRes SkinShopOnlyCheckPlayDynEntrance()
		{
			return DynIllustStartMgr.CheckPlayDynEntranceRes.OK;
		}

		// Token: 0x060158F1 RID: 88305 RVA: 0x0008C9B8 File Offset: 0x0008ABB8
		[Token(Token = "0x60158F1")]
		[Address(RVA = "0xE01F00", Offset = "0xE00B00", VA = "0x180E01F00")]
		public static DynIllustStartMgr.CheckPlayDynEntranceRes CheckPlayDynEntrance(bool passive, bool isHomePage)
		{
			return DynIllustStartMgr.CheckPlayDynEntranceRes.OK;
		}

		// Token: 0x060158F2 RID: 88306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60158F2")]
		[Address(RVA = "0xE02120", Offset = "0xE00D20", VA = "0x180E02120")]
		public static string GetPlayDynEntranceErrMsg(DynIllustStartMgr.CheckPlayDynEntranceRes errocde)
		{
			return null;
		}

		// Token: 0x060158F3 RID: 88307 RVA: 0x0008C9D0 File Offset: 0x0008ABD0
		[Token(Token = "0x60158F3")]
		[Address(RVA = "0xE01D30", Offset = "0xE00930", VA = "0x180E01D30")]
		public static bool CheckPlayDynEntranceForLogin(string dynIllustId)
		{
			return default(bool);
		}

		// Token: 0x060158F4 RID: 88308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158F4")]
		[Address(RVA = "0xE021F0", Offset = "0xE00DF0", VA = "0x180E021F0")]
		public static void MarkHomePageRouted()
		{
		}

		// Token: 0x060158F5 RID: 88309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158F5")]
		[Address(RVA = "0xE02280", Offset = "0xE00E80", VA = "0x180E02280")]
		public static void MarkPlayDynEntranceForLogin(string dynIllustId)
		{
		}

		// Token: 0x060158F6 RID: 88310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158F6")]
		[Address(RVA = "0xE02340", Offset = "0xE00F40", VA = "0x180E02340")]
		public void OnBtnSkipClicked()
		{
		}

		// Token: 0x060158F7 RID: 88311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158F7")]
		[Address(RVA = "0xE02510", Offset = "0xE01110", VA = "0x180E02510")]
		public void OnScreenClicked()
		{
		}

		// Token: 0x060158F8 RID: 88312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60158F8")]
		[Address(RVA = "0xE03550", Offset = "0xE02150", VA = "0x180E03550")]
		public DynIllustStartMgr()
		{
		}

		// Token: 0x04019D72 RID: 105842
		[Token(Token = "0x4019D72")]
		private const float DYN_ENTRANCE_INSTANCE_INIT_POS_Z = -200f;

		// Token: 0x04019D73 RID: 105843
		[Token(Token = "0x4019D73")]
		private const float DYN_ENTRANCE_MASK_TWEEN_DURATION = 0.16f;

		// Token: 0x04019D74 RID: 105844
		[Token(Token = "0x4019D74")]
		private const float DYN_ENTRANCE_AUDIO_FADE_TIME = 1.5f;

		// Token: 0x04019D75 RID: 105845
		[Token(Token = "0x4019D75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint s_loginKey;

		// Token: 0x04019D76 RID: 105846
		[Token(Token = "0x4019D76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera _cameraUI;

		// Token: 0x04019D77 RID: 105847
		[Token(Token = "0x4019D77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _cameraBack;

		// Token: 0x04019D78 RID: 105848
		[Token(Token = "0x4019D78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _btnSkipGacha;

		// Token: 0x04019D79 RID: 105849
		[Token(Token = "0x4019D79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _btnSkipNormal;

		// Token: 0x04019D7A RID: 105850
		[Token(Token = "0x4019D7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSkip;

		// Token: 0x04019D7B RID: 105851
		[Token(Token = "0x4019D7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _raycastBlocker;

		// Token: 0x04019D7C RID: 105852
		[Token(Token = "0x4019D7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasMask;

		// Token: 0x04019D7D RID: 105853
		[Token(Token = "0x4019D7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgMask;

		// Token: 0x04019D7E RID: 105854
		[Token(Token = "0x4019D7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _instHolder;

		// Token: 0x04019D7F RID: 105855
		[Token(Token = "0x4019D7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private DynIllustStartPlay m_activeInst;

		// Token: 0x04019D80 RID: 105856
		[Token(Token = "0x4019D80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private DynIllustStartPlay m_activeRes;

		// Token: 0x04019D81 RID: 105857
		[Token(Token = "0x4019D81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_isPlaying;

		// Token: 0x04019D82 RID: 105858
		[Token(Token = "0x4019D82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_isSkipped;

		// Token: 0x04019D83 RID: 105859
		[Token(Token = "0x4019D83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DynIllustStartMgr.SkipManager m_skipManager;

		// Token: 0x04019D84 RID: 105860
		[Token(Token = "0x4019D84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DynIllustStartMgr.CharVoiceManager m_charVoiceManager;

		// Token: 0x04019D85 RID: 105861
		[Token(Token = "0x4019D85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UISwitchTween m_switchTweenSkip;

		// Token: 0x04019D86 RID: 105862
		[Token(Token = "0x4019D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isPlaying;

		// Token: 0x04019D87 RID: 105863
		[Token(Token = "0x4019D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04019D88 RID: 105864
		[Token(Token = "0x4019D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04019D89 RID: 105865
		[Token(Token = "0x4019D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowBlackMask;

		// Token: 0x04019D8A RID: 105866
		[Token(Token = "0x4019D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HideBlackMask;

		// Token: 0x04019D8B RID: 105867
		[Token(Token = "0x4019D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitSwitchTween;

		// Token: 0x04019D8C RID: 105868
		[Token(Token = "0x4019D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PlayDynEntrance;

		// Token: 0x04019D8D RID: 105869
		[Token(Token = "0x4019D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayDynEntranceCoroutine;

		// Token: 0x04019D8E RID: 105870
		[Token(Token = "0x4019D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryFetchAndAddCameras;

		// Token: 0x04019D8F RID: 105871
		[Token(Token = "0x4019D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ClearDynEntrance;

		// Token: 0x04019D90 RID: 105872
		[Token(Token = "0x4019D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DefaultPlayCharVoice;

		// Token: 0x04019D91 RID: 105873
		[Token(Token = "0x4019D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DefaultPlayDynIllustStart;

		// Token: 0x04019D92 RID: 105874
		[Token(Token = "0x4019D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__StopBGM;

		// Token: 0x04019D93 RID: 105875
		[Token(Token = "0x4019D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ResumeBGM;

		// Token: 0x04019D94 RID: 105876
		[Token(Token = "0x4019D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetBGMInstId;

		// Token: 0x04019D95 RID: 105877
		[Token(Token = "0x4019D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SkinShopOnlyCheckPlayDynEntrance;

		// Token: 0x04019D96 RID: 105878
		[Token(Token = "0x4019D96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckPlayDynEntrance;

		// Token: 0x04019D97 RID: 105879
		[Token(Token = "0x4019D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetPlayDynEntranceErrMsg;

		// Token: 0x04019D98 RID: 105880
		[Token(Token = "0x4019D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CheckPlayDynEntranceForLogin;

		// Token: 0x04019D99 RID: 105881
		[Token(Token = "0x4019D99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_MarkHomePageRouted;

		// Token: 0x04019D9A RID: 105882
		[Token(Token = "0x4019D9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_MarkPlayDynEntranceForLogin;

		// Token: 0x04019D9B RID: 105883
		[Token(Token = "0x4019D9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnBtnSkipClicked;

		// Token: 0x04019D9C RID: 105884
		[Token(Token = "0x4019D9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnScreenClicked;

		// Token: 0x04019D9D RID: 105885
		[Token(Token = "0x4019D9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034D4 RID: 13524
		[Token(Token = "0x20034D4")]
		public enum CheckPlayDynEntranceRes
		{
			// Token: 0x04019D9F RID: 105887
			[Token(Token = "0x4019D9F")]
			OK,
			// Token: 0x04019DA0 RID: 105888
			[Token(Token = "0x4019DA0")]
			NO_RES,
			// Token: 0x04019DA1 RID: 105889
			[Token(Token = "0x4019DA1")]
			DISABLED_BY_PARENT,
			// Token: 0x04019DA2 RID: 105890
			[Token(Token = "0x4019DA2")]
			UNKNOWN_ERROR
		}

		// Token: 0x020034D5 RID: 13525
		[Token(Token = "0x20034D5")]
		public enum LoginPlayStrategy
		{
			// Token: 0x04019DA4 RID: 105892
			[Token(Token = "0x4019DA4")]
			EVERY_TIME,
			// Token: 0x04019DA5 RID: 105893
			[Token(Token = "0x4019DA5")]
			FIRST_TIME_IN_DAY,
			// Token: 0x04019DA6 RID: 105894
			[Token(Token = "0x4019DA6")]
			DISABLED
		}

		// Token: 0x020034D6 RID: 13526
		[Token(Token = "0x20034D6")]
		public class Param
		{
			// Token: 0x060158FA RID: 88314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158FA")]
			[Address(RVA = "0xE05A40", Offset = "0xE04640", VA = "0x180E05A40")]
			public Param()
			{
			}

			// Token: 0x04019DA7 RID: 105895
			[Token(Token = "0x4019DA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CharUISkinStruct skin;

			// Token: 0x04019DA8 RID: 105896
			[Token(Token = "0x4019DA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isGacha;

			// Token: 0x04019DA9 RID: 105897
			[Token(Token = "0x4019DA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool fastModeShow;

			// Token: 0x04019DAA RID: 105898
			[Token(Token = "0x4019DAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action onStart;

			// Token: 0x04019DAB RID: 105899
			[Token(Token = "0x4019DAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action onFinish;

			// Token: 0x04019DAC RID: 105900
			[Token(Token = "0x4019DAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<CharUISkinStruct> onPlayDynIllustStart;

			// Token: 0x04019DAD RID: 105901
			[Token(Token = "0x4019DAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action<CharUISkinStruct> onPlayCharVoice;
		}

		// Token: 0x020034D7 RID: 13527
		[Token(Token = "0x20034D7")]
		public class DynIllustLocalCache
		{
			// Token: 0x060158FB RID: 88315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158FB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DynIllustLocalCache()
			{
			}

			// Token: 0x04019DAE RID: 105902
			[Token(Token = "0x4019DAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long lastUpdateTs;

			// Token: 0x04019DAF RID: 105903
			[Token(Token = "0x4019DAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<string> playedEntranceIds;
		}

		// Token: 0x020034D8 RID: 13528
		[Token(Token = "0x20034D8")]
		private abstract class SkipManager : IHotfixable
		{
			// Token: 0x170032F9 RID: 13049
			// (get) Token: 0x060158FC RID: 88316 RVA: 0x0008C9E8 File Offset: 0x0008ABE8
			[Token(Token = "0x170032F9")]
			public bool enabled
			{
				[Token(Token = "0x60158FC")]
				[Address(RVA = "0xE05F60", Offset = "0xE04B60", VA = "0x180E05F60")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060158FD RID: 88317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158FD")]
			[Address(RVA = "0xE05EE0", Offset = "0xE04AE0", VA = "0x180E05EE0")]
			public SkipManager(DynIllustStartMgr closure)
			{
			}

			// Token: 0x060158FE RID: 88318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158FE")]
			[Address(RVA = "0xE05E60", Offset = "0xE04A60", VA = "0x180E05E60", Slot = "4")]
			public virtual void Reset()
			{
			}

			// Token: 0x060158FF RID: 88319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60158FF")]
			[Address(RVA = "0xE054B0", Offset = "0xE040B0", VA = "0x180E054B0", Slot = "5")]
			public virtual void OnEnable()
			{
			}

			// Token: 0x06015900 RID: 88320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015900")]
			[Address(RVA = "0xE05DE0", Offset = "0xE049E0", VA = "0x180E05DE0", Slot = "6")]
			public virtual void OnDisable()
			{
			}

			// Token: 0x06015901 RID: 88321
			[Token(Token = "0x6015901")]
			public abstract void OnScreenClicked();

			// Token: 0x06015902 RID: 88322
			[Token(Token = "0x6015902")]
			public abstract void OnSkipBtnClicked();

			// Token: 0x04019DB0 RID: 105904
			[Token(Token = "0x4019DB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			protected DynIllustStartMgr m_closure;

			// Token: 0x04019DB1 RID: 105905
			[Token(Token = "0x4019DB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			protected bool m_enabled;

			// Token: 0x04019DB2 RID: 105906
			[Token(Token = "0x4019DB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_enabled;

			// Token: 0x04019DB3 RID: 105907
			[Token(Token = "0x4019DB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04019DB4 RID: 105908
			[Token(Token = "0x4019DB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x04019DB5 RID: 105909
			[Token(Token = "0x4019DB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnEnable;

			// Token: 0x04019DB6 RID: 105910
			[Token(Token = "0x4019DB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnDisable;
		}

		// Token: 0x020034D9 RID: 13529
		[Token(Token = "0x20034D9")]
		private class NormalSkipMananger : DynIllustStartMgr.SkipManager
		{
			// Token: 0x06015903 RID: 88323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015903")]
			[Address(RVA = "0xE059D0", Offset = "0xE045D0", VA = "0x180E059D0")]
			public NormalSkipMananger(DynIllustStartMgr closure)
			{
			}

			// Token: 0x06015904 RID: 88324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015904")]
			[Address(RVA = "0xE05940", Offset = "0xE04540", VA = "0x180E05940", Slot = "4")]
			public override void Reset()
			{
			}

			// Token: 0x06015905 RID: 88325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015905")]
			[Address(RVA = "0xE05850", Offset = "0xE04450", VA = "0x180E05850", Slot = "7")]
			public override void OnScreenClicked()
			{
			}

			// Token: 0x06015906 RID: 88326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015906")]
			[Address(RVA = "0xE058D0", Offset = "0xE044D0", VA = "0x180E058D0", Slot = "8")]
			public override void OnSkipBtnClicked()
			{
			}

			// Token: 0x06015907 RID: 88327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015907")]
			[Address(RVA = "0xE05510", Offset = "0xE04110", VA = "0x180E05510")]
			private void <>xLuaBaseProxy_Reset()
			{
			}

			// Token: 0x04019DB7 RID: 105911
			[Token(Token = "0x4019DB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04019DB8 RID: 105912
			[Token(Token = "0x4019DB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x04019DB9 RID: 105913
			[Token(Token = "0x4019DB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnScreenClicked;

			// Token: 0x04019DBA RID: 105914
			[Token(Token = "0x4019DBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnSkipBtnClicked;
		}

		// Token: 0x020034DA RID: 13530
		[Token(Token = "0x20034DA")]
		private class GachaSkipMananger : DynIllustStartMgr.SkipManager
		{
			// Token: 0x06015908 RID: 88328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015908")]
			[Address(RVA = "0xE05520", Offset = "0xE04120", VA = "0x180E05520")]
			public GachaSkipMananger(DynIllustStartMgr closure)
			{
			}

			// Token: 0x06015909 RID: 88329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015909")]
			[Address(RVA = "0xE05420", Offset = "0xE04020", VA = "0x180E05420", Slot = "4")]
			public override void Reset()
			{
			}

			// Token: 0x0601590A RID: 88330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601590A")]
			[Address(RVA = "0xE05290", Offset = "0xE03E90", VA = "0x180E05290", Slot = "5")]
			public override void OnEnable()
			{
			}

			// Token: 0x0601590B RID: 88331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601590B")]
			[Address(RVA = "0xE05350", Offset = "0xE03F50", VA = "0x180E05350", Slot = "7")]
			public override void OnScreenClicked()
			{
			}

			// Token: 0x0601590C RID: 88332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601590C")]
			[Address(RVA = "0xE053B0", Offset = "0xE03FB0", VA = "0x180E053B0", Slot = "8")]
			public override void OnSkipBtnClicked()
			{
			}

			// Token: 0x0601590D RID: 88333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601590D")]
			[Address(RVA = "0xE05510", Offset = "0xE04110", VA = "0x180E05510")]
			private void <>xLuaBaseProxy_Reset()
			{
			}

			// Token: 0x0601590E RID: 88334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601590E")]
			[Address(RVA = "0xE054B0", Offset = "0xE040B0", VA = "0x180E054B0")]
			private void <>xLuaBaseProxy_OnEnable()
			{
			}

			// Token: 0x04019DBB RID: 105915
			[Token(Token = "0x4019DBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04019DBC RID: 105916
			[Token(Token = "0x4019DBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x04019DBD RID: 105917
			[Token(Token = "0x4019DBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnEnable;

			// Token: 0x04019DBE RID: 105918
			[Token(Token = "0x4019DBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnScreenClicked;

			// Token: 0x04019DBF RID: 105919
			[Token(Token = "0x4019DBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnSkipBtnClicked;
		}

		// Token: 0x020034DB RID: 13531
		[Token(Token = "0x20034DB")]
		private class CharVoiceManager : IHotfixable
		{
			// Token: 0x0601590F RID: 88335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601590F")]
			[Address(RVA = "0xDFA3C0", Offset = "0xDF8FC0", VA = "0x180DFA3C0")]
			public void Init(float offset, DynIllustStartMgr.Param param)
			{
			}

			// Token: 0x06015910 RID: 88336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015910")]
			[Address(RVA = "0xDFA520", Offset = "0xDF9120", VA = "0x180DFA520")]
			public void Update()
			{
			}

			// Token: 0x06015911 RID: 88337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015911")]
			[Address(RVA = "0xDFA470", Offset = "0xDF9070", VA = "0x180DFA470")]
			public void Trigger()
			{
			}

			// Token: 0x06015912 RID: 88338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015912")]
			[Address(RVA = "0xDFA5A0", Offset = "0xDF91A0", VA = "0x180DFA5A0")]
			public CharVoiceManager()
			{
			}

			// Token: 0x04019DC0 RID: 105920
			[Token(Token = "0x4019DC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private DynIllustStartMgr.CharVoiceManager.State m_state;

			// Token: 0x04019DC1 RID: 105921
			[Token(Token = "0x4019DC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float m_playTime;

			// Token: 0x04019DC2 RID: 105922
			[Token(Token = "0x4019DC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private DynIllustStartMgr.Param m_param;

			// Token: 0x04019DC3 RID: 105923
			[Token(Token = "0x4019DC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x04019DC4 RID: 105924
			[Token(Token = "0x4019DC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Update;

			// Token: 0x04019DC5 RID: 105925
			[Token(Token = "0x4019DC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Trigger;

			// Token: 0x04019DC6 RID: 105926
			[Token(Token = "0x4019DC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020034DC RID: 13532
			[Token(Token = "0x20034DC")]
			public enum State
			{
				// Token: 0x04019DC8 RID: 105928
				[Token(Token = "0x4019DC8")]
				STATE_NOT_INITED,
				// Token: 0x04019DC9 RID: 105929
				[Token(Token = "0x4019DC9")]
				STATE_INITED,
				// Token: 0x04019DCA RID: 105930
				[Token(Token = "0x4019DCA")]
				STATE_TRIGGERD
			}
		}
	}
}
