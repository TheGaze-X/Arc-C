using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200592E RID: 22830
	[Token(Token = "0x200592E")]
	public class CrisisV2SettleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004E04 RID: 19972
		// (get) Token: 0x06021416 RID: 136214 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021417 RID: 136215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E04")]
		public Action onCloseClicked
		{
			[Token(Token = "0x6021416")]
			[Address(RVA = "0x1B97190", Offset = "0x1B95D90", VA = "0x181B97190")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6021417")]
			[Address(RVA = "0x1B972F0", Offset = "0x1B95EF0", VA = "0x181B972F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004E05 RID: 19973
		// (get) Token: 0x06021418 RID: 136216 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021419 RID: 136217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E05")]
		public ILoadAsset assetLoader
		{
			[Token(Token = "0x6021418")]
			[Address(RVA = "0x1B970D0", Offset = "0x1B95CD0", VA = "0x181B970D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6021419")]
			[Address(RVA = "0x1B971F0", Offset = "0x1B95DF0", VA = "0x181B971F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004E06 RID: 19974
		// (get) Token: 0x0602141A RID: 136218 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602141B RID: 136219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E06")]
		public UICharacterIllustLoader illustLoader
		{
			[Token(Token = "0x602141A")]
			[Address(RVA = "0x1B97130", Offset = "0x1B95D30", VA = "0x181B97130")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602141B")]
			[Address(RVA = "0x1B97270", Offset = "0x1B95E70", VA = "0x181B97270")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602141C RID: 136220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602141C")]
		[Address(RVA = "0x1B960F0", Offset = "0x1B94CF0", VA = "0x181B960F0")]
		public void Render(CrisisV2SettleViewModel viewModel)
		{
		}

		// Token: 0x0602141D RID: 136221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602141D")]
		[Address(RVA = "0x1B96620", Offset = "0x1B95220", VA = "0x181B96620")]
		public void StartAnimation()
		{
		}

		// Token: 0x0602141E RID: 136222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602141E")]
		[Address(RVA = "0x1B96750", Offset = "0x1B95350", VA = "0x181B96750")]
		public void StopAnimation()
		{
		}

		// Token: 0x0602141F RID: 136223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602141F")]
		[Address(RVA = "0x1B96990", Offset = "0x1B95590", VA = "0x181B96990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021420 RID: 136224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021420")]
		[Address(RVA = "0x1B96F70", Offset = "0x1B95B70", VA = "0x181B96F70")]
		private IEnumerator _UpdateStateCoroutine()
		{
			return null;
		}

		// Token: 0x06021421 RID: 136225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021421")]
		[Address(RVA = "0x1B96CB0", Offset = "0x1B958B0", VA = "0x181B96CB0")]
		private static void _PlayAnim(UIAnimationLocation anim, ref Tween tween, [Optional] TweenCallback onComplete)
		{
		}

		// Token: 0x06021422 RID: 136226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021422")]
		[Address(RVA = "0x1B96E80", Offset = "0x1B95A80", VA = "0x181B96E80")]
		private static IEnumerator _PlayAudioCoroutine(float delayTime, string signal, [Optional] string subSignal)
		{
			return null;
		}

		// Token: 0x06021423 RID: 136227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021423")]
		[Address(RVA = "0x1B96B70", Offset = "0x1B95770", VA = "0x181B96B70")]
		private void _OnScoreEnterAnimPlayFinish()
		{
		}

		// Token: 0x06021424 RID: 136228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021424")]
		[Address(RVA = "0x1B96BF0", Offset = "0x1B957F0", VA = "0x181B96BF0")]
		private void _OnScoreNewAnimPlayFinish()
		{
		}

		// Token: 0x06021425 RID: 136229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021425")]
		[Address(RVA = "0x1B96C50", Offset = "0x1B95850", VA = "0x181B96C50")]
		private void _OnScoreResultAnimPlayFinish()
		{
		}

		// Token: 0x06021426 RID: 136230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021426")]
		[Address(RVA = "0x1B96AB0", Offset = "0x1B956B0", VA = "0x181B96AB0")]
		private void _OnNewCompleteAnimPlayFinish()
		{
		}

		// Token: 0x06021427 RID: 136231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021427")]
		[Address(RVA = "0x1B96B10", Offset = "0x1B95710", VA = "0x181B96B10")]
		private void _OnResultEnterAnimPlayFinish()
		{
		}

		// Token: 0x06021428 RID: 136232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021428")]
		[Address(RVA = "0x1B96880", Offset = "0x1B95480", VA = "0x181B96880")]
		private void _CloseView()
		{
		}

		// Token: 0x06021429 RID: 136233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021429")]
		[Address(RVA = "0x1B96090", Offset = "0x1B94C90", VA = "0x181B96090")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602142A RID: 136234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602142A")]
		[Address(RVA = "0x1B95D50", Offset = "0x1B94950", VA = "0x181B95D50")]
		public void EventOnPageClicked()
		{
		}

		// Token: 0x0602142B RID: 136235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602142B")]
		[Address(RVA = "0x1B97020", Offset = "0x1B95C20", VA = "0x181B97020")]
		public CrisisV2SettleView()
		{
		}

		// Token: 0x0402D500 RID: 185600
		[Token(Token = "0x402D500")]
		private const float SETTLEMENT_REWARD_APPEAR = 0.8333333f;

		// Token: 0x0402D501 RID: 185601
		[Token(Token = "0x402D501")]
		private const float SETTLEMENT_NEW_COMPLETE_ITEM = 1.0833334f;

		// Token: 0x0402D502 RID: 185602
		[Token(Token = "0x402D502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgSeasonBg;

		// Token: 0x0402D503 RID: 185603
		[Token(Token = "0x402D503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrisisV2SettleView.ScorePanel _scorePanel;

		// Token: 0x0402D504 RID: 185604
		[Token(Token = "0x402D504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CrisisV2SettleView.NewCompletePanel _newCompletePanel;

		// Token: 0x0402D505 RID: 185605
		[Token(Token = "0x402D505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CrisisV2SettleView.ResultPanel _resultPanel;

		// Token: 0x0402D506 RID: 185606
		[Token(Token = "0x402D506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Inspect]
		[NonSerialized]
		private CrisisV2SettleView.InternalState m_state;

		// Token: 0x0402D507 RID: 185607
		[Token(Token = "0x402D507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrisisV2SettleViewModel m_viewModel;

		// Token: 0x0402D508 RID: 185608
		[Token(Token = "0x402D508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine m_updateStateCoroutine;

		// Token: 0x0402D509 RID: 185609
		[Token(Token = "0x402D509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Coroutine m_settleEnterSoundCoroutine;

		// Token: 0x0402D50A RID: 185610
		[Token(Token = "0x402D50A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine m_newCompleteItemSoundCoroutine;

		// Token: 0x0402D50B RID: 185611
		[Token(Token = "0x402D50B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0402D50F RID: 185615
		[Token(Token = "0x402D50F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCloseClicked;

		// Token: 0x0402D510 RID: 185616
		[Token(Token = "0x402D510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCloseClicked;

		// Token: 0x0402D511 RID: 185617
		[Token(Token = "0x402D511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x0402D512 RID: 185618
		[Token(Token = "0x402D512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_assetLoader;

		// Token: 0x0402D513 RID: 185619
		[Token(Token = "0x402D513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_illustLoader;

		// Token: 0x0402D514 RID: 185620
		[Token(Token = "0x402D514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_illustLoader;

		// Token: 0x0402D515 RID: 185621
		[Token(Token = "0x402D515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D516 RID: 185622
		[Token(Token = "0x402D516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_StartAnimation;

		// Token: 0x0402D517 RID: 185623
		[Token(Token = "0x402D517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_StopAnimation;

		// Token: 0x0402D518 RID: 185624
		[Token(Token = "0x402D518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D519 RID: 185625
		[Token(Token = "0x402D519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateStateCoroutine;

		// Token: 0x0402D51A RID: 185626
		[Token(Token = "0x402D51A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0402D51B RID: 185627
		[Token(Token = "0x402D51B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__PlayAudioCoroutine;

		// Token: 0x0402D51C RID: 185628
		[Token(Token = "0x402D51C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnScoreEnterAnimPlayFinish;

		// Token: 0x0402D51D RID: 185629
		[Token(Token = "0x402D51D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnScoreNewAnimPlayFinish;

		// Token: 0x0402D51E RID: 185630
		[Token(Token = "0x402D51E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnScoreResultAnimPlayFinish;

		// Token: 0x0402D51F RID: 185631
		[Token(Token = "0x402D51F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnNewCompleteAnimPlayFinish;

		// Token: 0x0402D520 RID: 185632
		[Token(Token = "0x402D520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnResultEnterAnimPlayFinish;

		// Token: 0x0402D521 RID: 185633
		[Token(Token = "0x402D521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CloseView;

		// Token: 0x0402D522 RID: 185634
		[Token(Token = "0x402D522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402D523 RID: 185635
		[Token(Token = "0x402D523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnPageClicked;

		// Token: 0x0402D524 RID: 185636
		[Token(Token = "0x402D524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200592F RID: 22831
		[Token(Token = "0x200592F")]
		private enum InternalState
		{
			// Token: 0x0402D526 RID: 185638
			[Token(Token = "0x402D526")]
			NONE,
			// Token: 0x0402D527 RID: 185639
			[Token(Token = "0x402D527")]
			IDLE_WAIT_PLAY_ANIM,
			// Token: 0x0402D528 RID: 185640
			[Token(Token = "0x402D528")]
			SHOW_SCORE,
			// Token: 0x0402D529 RID: 185641
			[Token(Token = "0x402D529")]
			SHOW_SCORE_NEW,
			// Token: 0x0402D52A RID: 185642
			[Token(Token = "0x402D52A")]
			SHOW_SCORE_RESULT,
			// Token: 0x0402D52B RID: 185643
			[Token(Token = "0x402D52B")]
			SHOW_SCORE_RESULT_DONE,
			// Token: 0x0402D52C RID: 185644
			[Token(Token = "0x402D52C")]
			SHOW_COMPLETE_NEW,
			// Token: 0x0402D52D RID: 185645
			[Token(Token = "0x402D52D")]
			SHOWING_COMPLETE_NEW,
			// Token: 0x0402D52E RID: 185646
			[Token(Token = "0x402D52E")]
			SHOW_COMPLETE_NEW_DONE,
			// Token: 0x0402D52F RID: 185647
			[Token(Token = "0x402D52F")]
			SHOW_RESULT,
			// Token: 0x0402D530 RID: 185648
			[Token(Token = "0x402D530")]
			END
		}

		// Token: 0x02005930 RID: 22832
		[Token(Token = "0x2005930")]
		[Serializable]
		private class ScorePanel : IHotfixable
		{
			// Token: 0x0602142C RID: 136236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602142C")]
			[Address(RVA = "0x1B9D6D0", Offset = "0x1B9C2D0", VA = "0x181B9D6D0")]
			public void Render(CrisisV2SettleViewModel viewModel, ILoadAsset loader)
			{
			}

			// Token: 0x0602142D RID: 136237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602142D")]
			[Address(RVA = "0x1B9D550", Offset = "0x1B9C150", VA = "0x181B9D550")]
			public void RenderNewScoreDiagram(CrisisV2SettleViewModel viewModel)
			{
			}

			// Token: 0x0602142E RID: 136238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602142E")]
			[Address(RVA = "0x1B9D270", Offset = "0x1B9BE70", VA = "0x181B9D270")]
			public void HidePanel()
			{
			}

			// Token: 0x0602142F RID: 136239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602142F")]
			[Address(RVA = "0x1B9D2D0", Offset = "0x1B9BED0", VA = "0x181B9D2D0")]
			public void PlayScoreEnterAnim([Optional] TweenCallback onScoreEnterPlayFinish)
			{
			}

			// Token: 0x06021430 RID: 136240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021430")]
			[Address(RVA = "0x1B9D3D0", Offset = "0x1B9BFD0", VA = "0x181B9D3D0")]
			public void PlayScoreNewAnim([Optional] TweenCallback onScoreNewPlayFinish)
			{
			}

			// Token: 0x06021431 RID: 136241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021431")]
			[Address(RVA = "0x1B9D4D0", Offset = "0x1B9C0D0", VA = "0x181B9D4D0")]
			public void PlayScoreResultAnim([Optional] TweenCallback onScoreResultPlayFinish)
			{
			}

			// Token: 0x06021432 RID: 136242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021432")]
			[Address(RVA = "0x1B9DBB0", Offset = "0x1B9C7B0", VA = "0x181B9DBB0")]
			public void Reset()
			{
			}

			// Token: 0x06021433 RID: 136243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021433")]
			[Address(RVA = "0x1B9DCB0", Offset = "0x1B9C8B0", VA = "0x181B9DCB0")]
			private void _InitIfNot()
			{
			}

			// Token: 0x06021434 RID: 136244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021434")]
			[Address(RVA = "0x1B9DE70", Offset = "0x1B9CA70", VA = "0x181B9DE70")]
			private void _SetPanelObjVisable(bool show)
			{
			}

			// Token: 0x06021435 RID: 136245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021435")]
			[Address(RVA = "0x1B9DF60", Offset = "0x1B9CB60", VA = "0x181B9DF60")]
			public ScorePanel()
			{
			}

			// Token: 0x0402D531 RID: 185649
			[Token(Token = "0x402D531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[Group("Dimension Part")]
			private CrisisV2DiagramView _diagramItemPrefab;

			// Token: 0x0402D532 RID: 185650
			[Token(Token = "0x402D532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[Group("Dimension Part")]
			private Transform _diagramHolder;

			// Token: 0x0402D533 RID: 185651
			[Token(Token = "0x402D533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Group("Score Part")]
			private Text _txtScore;

			// Token: 0x0402D534 RID: 185652
			[Token(Token = "0x402D534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			[Group("Score Part")]
			private Image _imgAppraise;

			// Token: 0x0402D535 RID: 185653
			[Token(Token = "0x402D535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			[Group("Score Part")]
			private GameObject _objNewScoreTag;

			// Token: 0x0402D536 RID: 185654
			[Token(Token = "0x402D536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[SerializeField]
			[Group("Comment Part")]
			private GameObject _objCommentParent;

			// Token: 0x0402D537 RID: 185655
			[Token(Token = "0x402D537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[SerializeField]
			[Group("Comment Part")]
			private SimpleLayoutContent _commentLayoutLeft;

			// Token: 0x0402D538 RID: 185656
			[Token(Token = "0x402D538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[SerializeField]
			[Group("Comment Part")]
			private SimpleLayoutContent _commentLayoutRight;

			// Token: 0x0402D539 RID: 185657
			[Token(Token = "0x402D539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[SerializeField]
			[Group("Anim")]
			private UIAnimationLocation _animScoreEnter;

			// Token: 0x0402D53A RID: 185658
			[Token(Token = "0x402D53A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[SerializeField]
			[Group("Anim")]
			private UIAnimationLocation _animScoreNew;

			// Token: 0x0402D53B RID: 185659
			[Token(Token = "0x402D53B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[SerializeField]
			[Group("Anim")]
			private UIAnimationLocation _animScoreResult;

			// Token: 0x0402D53C RID: 185660
			[Token(Token = "0x402D53C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[SerializeField]
			[Group("Obj")]
			private List<GameObject> _objScores;

			// Token: 0x0402D53D RID: 185661
			[Token(Token = "0x402D53D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private CrisisV2SettleView.ScorePanel.CommentAdapter m_adapterLeft;

			// Token: 0x0402D53E RID: 185662
			[Token(Token = "0x402D53E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private CrisisV2SettleView.ScorePanel.CommentAdapter m_adapterRight;

			// Token: 0x0402D53F RID: 185663
			[Token(Token = "0x402D53F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Tween m_tweener;

			// Token: 0x0402D540 RID: 185664
			[Token(Token = "0x402D540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private CrisisV2DiagramView m_diagramItem;

			// Token: 0x0402D541 RID: 185665
			[Token(Token = "0x402D541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private bool m_hasInited;

			// Token: 0x0402D542 RID: 185666
			[Token(Token = "0x402D542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402D543 RID: 185667
			[Token(Token = "0x402D543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderNewScoreDiagram;

			// Token: 0x0402D544 RID: 185668
			[Token(Token = "0x402D544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_HidePanel;

			// Token: 0x0402D545 RID: 185669
			[Token(Token = "0x402D545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_PlayScoreEnterAnim;

			// Token: 0x0402D546 RID: 185670
			[Token(Token = "0x402D546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_PlayScoreNewAnim;

			// Token: 0x0402D547 RID: 185671
			[Token(Token = "0x402D547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_PlayScoreResultAnim;

			// Token: 0x0402D548 RID: 185672
			[Token(Token = "0x402D548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x0402D549 RID: 185673
			[Token(Token = "0x402D549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__InitIfNot;

			// Token: 0x0402D54A RID: 185674
			[Token(Token = "0x402D54A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__SetPanelObjVisable;

			// Token: 0x0402D54B RID: 185675
			[Token(Token = "0x402D54B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02005931 RID: 22833
			[Token(Token = "0x2005931")]
			private class CommentAdapter : SimpleLayoutAdapter
			{
				// Token: 0x17004E07 RID: 19975
				// (get) Token: 0x06021436 RID: 136246 RVA: 0x000B9250 File Offset: 0x000B7450
				[Token(Token = "0x17004E07")]
				public override int count
				{
					[Token(Token = "0x6021436")]
					[Address(RVA = "0x1B88040", Offset = "0x1B86C40", VA = "0x181B88040", Slot = "4")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06021437 RID: 136247 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6021437")]
				[Address(RVA = "0x1B87D10", Offset = "0x1B86910", VA = "0x181B87D10", Slot = "5")]
				public override GameObject RenderView(int position, GameObject prefab, Transform parent)
				{
					return null;
				}

				// Token: 0x06021438 RID: 136248 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6021438")]
				[Address(RVA = "0x1B87FE0", Offset = "0x1B86BE0", VA = "0x181B87FE0")]
				public CommentAdapter()
				{
				}

				// Token: 0x0402D54C RID: 185676
				[Token(Token = "0x402D54C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public List<CrisisV2SettleCommentItemViewModel> dataList;

				// Token: 0x0402D54D RID: 185677
				[Token(Token = "0x402D54D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_count;

				// Token: 0x0402D54E RID: 185678
				[Token(Token = "0x402D54E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_RenderView;

				// Token: 0x0402D54F RID: 185679
				[Token(Token = "0x402D54F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}

		// Token: 0x02005932 RID: 22834
		[Token(Token = "0x2005932")]
		[Serializable]
		private class NewCompletePanel : IHotfixable
		{
			// Token: 0x06021439 RID: 136249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021439")]
			[Address(RVA = "0x1B9C060", Offset = "0x1B9AC60", VA = "0x181B9C060")]
			public void Render(CrisisV2SettleViewModel viewModel)
			{
			}

			// Token: 0x0602143A RID: 136250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602143A")]
			[Address(RVA = "0x1B9BE70", Offset = "0x1B9AA70", VA = "0x181B9BE70")]
			public void HidePanel()
			{
			}

			// Token: 0x0602143B RID: 136251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602143B")]
			[Address(RVA = "0x1B9BFE0", Offset = "0x1B9ABE0", VA = "0x181B9BFE0")]
			public void PlayNewCompleteEnterAnim([Optional] TweenCallback onNewCompleteAnimPlayFinish)
			{
			}

			// Token: 0x0602143C RID: 136252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602143C")]
			[Address(RVA = "0x1B9BEF0", Offset = "0x1B9AAF0", VA = "0x181B9BEF0")]
			public void JumpToNewCompleteEnterAnimLastFrame([Optional] Coroutine coroutineWithTimeTracer)
			{
			}

			// Token: 0x0602143D RID: 136253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602143D")]
			[Address(RVA = "0x1B9C160", Offset = "0x1B9AD60", VA = "0x181B9C160")]
			public NewCompletePanel()
			{
			}

			// Token: 0x0402D550 RID: 185680
			[Token(Token = "0x402D550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private UIBlurFloatPanel _blurBkg;

			// Token: 0x0402D551 RID: 185681
			[Token(Token = "0x402D551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _txtBefore;

			// Token: 0x0402D552 RID: 185682
			[Token(Token = "0x402D552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _txtAfter;

			// Token: 0x0402D553 RID: 185683
			[Token(Token = "0x402D553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private float _itemScaleFactor;

			// Token: 0x0402D554 RID: 185684
			[Token(Token = "0x402D554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			[Group("Anim")]
			private UIAnimationLocation _animNewCompleteEnter;

			// Token: 0x0402D555 RID: 185685
			[Token(Token = "0x402D555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[SerializeField]
			private GameObject _objNewCompletePanel;

			// Token: 0x0402D556 RID: 185686
			[Token(Token = "0x402D556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Tween m_tweener;

			// Token: 0x0402D557 RID: 185687
			[Token(Token = "0x402D557")]
			private const string NEW_COMPLETE_ANIM = "crisis_v2_battle_finish_new_complete";

			// Token: 0x0402D558 RID: 185688
			[Token(Token = "0x402D558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402D559 RID: 185689
			[Token(Token = "0x402D559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_HidePanel;

			// Token: 0x0402D55A RID: 185690
			[Token(Token = "0x402D55A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_PlayNewCompleteEnterAnim;

			// Token: 0x0402D55B RID: 185691
			[Token(Token = "0x402D55B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_JumpToNewCompleteEnterAnimLastFrame;

			// Token: 0x0402D55C RID: 185692
			[Token(Token = "0x402D55C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005933 RID: 22835
		[Token(Token = "0x2005933")]
		[Serializable]
		private class ResultPanel : IHotfixable
		{
			// Token: 0x0602143E RID: 136254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602143E")]
			[Address(RVA = "0x1B9C740", Offset = "0x1B9B340", VA = "0x181B9C740")]
			public void Render(CrisisV2SettleViewModel viewModel, UICharacterIllustLoader illustLoader, ILoadAsset assetLoader)
			{
			}

			// Token: 0x0602143F RID: 136255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602143F")]
			[Address(RVA = "0x1B9C470", Offset = "0x1B9B070", VA = "0x181B9C470")]
			public void PlayIllustVoice()
			{
			}

			// Token: 0x06021440 RID: 136256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021440")]
			[Address(RVA = "0x1B9C6B0", Offset = "0x1B9B2B0", VA = "0x181B9C6B0")]
			public void PlayResultEnterAnim([Optional] TweenCallback onNewCompleteAnimPlayFinish)
			{
			}

			// Token: 0x06021441 RID: 136257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021441")]
			[Address(RVA = "0x1B9C410", Offset = "0x1B9B010", VA = "0x181B9C410")]
			public void HidePanel()
			{
			}

			// Token: 0x06021442 RID: 136258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021442")]
			[Address(RVA = "0x1B9D210", Offset = "0x1B9BE10", VA = "0x181B9D210")]
			public ResultPanel()
			{
			}

			// Token: 0x0402D55D RID: 185693
			[Token(Token = "0x402D55D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[Group("Right Up")]
			private CrisisV2DiagramView _diagramItemPrefab;

			// Token: 0x0402D55E RID: 185694
			[Token(Token = "0x402D55E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[Group("Right Up")]
			private Transform _diagramHolder;

			// Token: 0x0402D55F RID: 185695
			[Token(Token = "0x402D55F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Group("Right Up")]
			private Text _txtScore;

			// Token: 0x0402D560 RID: 185696
			[Token(Token = "0x402D560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			[Group("Right Up")]
			private Image _imgAppraise;

			// Token: 0x0402D561 RID: 185697
			[Token(Token = "0x402D561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			[Group("Right Center")]
			private CrisisV2SettleRuneListAdapter _runeListAdapter;

			// Token: 0x0402D562 RID: 185698
			[Token(Token = "0x402D562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[SerializeField]
			[Group("Right Center")]
			private GameObject _objRuneMoreTips;

			// Token: 0x0402D563 RID: 185699
			[Token(Token = "0x402D563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[SerializeField]
			[Group("Right Down")]
			private GameObject _panelHp;

			// Token: 0x0402D564 RID: 185700
			[Token(Token = "0x402D564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[SerializeField]
			[Group("Right Down")]
			private Text _txtHp;

			// Token: 0x0402D565 RID: 185701
			[Token(Token = "0x402D565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[SerializeField]
			[Group("Right Down")]
			private Text _txtTimestamp;

			// Token: 0x0402D566 RID: 185702
			[Token(Token = "0x402D566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[SerializeField]
			[Group("Right Down")]
			private Text _txtPlayerName;

			// Token: 0x0402D567 RID: 185703
			[Token(Token = "0x402D567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[SerializeField]
			[Group("Right Down")]
			private Text _txtMapName;

			// Token: 0x0402D568 RID: 185704
			[Token(Token = "0x402D568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[SerializeField]
			[Group("Right Down")]
			private Text _txtMapCode;

			// Token: 0x0402D569 RID: 185705
			[Token(Token = "0x402D569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[SerializeField]
			[Group("Center")]
			private Transform _illustTrans;

			// Token: 0x0402D56A RID: 185706
			[Token(Token = "0x402D56A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[SerializeField]
			[Group("Left")]
			private List<CrisisV2SettleCardViewHolder> _cardHolderList;

			// Token: 0x0402D56B RID: 185707
			[Token(Token = "0x402D56B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[SerializeField]
			[Group("Left")]
			private CrisisV2SettleCardViewHolder _assistCardHolder;

			// Token: 0x0402D56C RID: 185708
			[Token(Token = "0x402D56C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[SerializeField]
			[Group("Left")]
			private CrisisV2SettleCardView _cardViewPrefab;

			// Token: 0x0402D56D RID: 185709
			[Token(Token = "0x402D56D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[SerializeField]
			[Group("Anim")]
			private UIAnimationLocation _animResultEnter;

			// Token: 0x0402D56E RID: 185710
			[Token(Token = "0x402D56E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[SerializeField]
			[Group("Obj")]
			private GameObject _objResultPanel;

			// Token: 0x0402D56F RID: 185711
			[Token(Token = "0x402D56F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private CharUISkinStruct m_randomIllust;

			// Token: 0x0402D570 RID: 185712
			[Token(Token = "0x402D570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private bool m_playHardModeVoice;

			// Token: 0x0402D571 RID: 185713
			[Token(Token = "0x402D571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private Tween m_tweener;

			// Token: 0x0402D572 RID: 185714
			[Token(Token = "0x402D572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private CrisisV2DiagramView m_diagramItem;

			// Token: 0x0402D573 RID: 185715
			[Token(Token = "0x402D573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private UICharacterIllust m_cacheIllust;

			// Token: 0x0402D574 RID: 185716
			[Token(Token = "0x402D574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402D575 RID: 185717
			[Token(Token = "0x402D575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_PlayIllustVoice;

			// Token: 0x0402D576 RID: 185718
			[Token(Token = "0x402D576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_PlayResultEnterAnim;

			// Token: 0x0402D577 RID: 185719
			[Token(Token = "0x402D577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_HidePanel;

			// Token: 0x0402D578 RID: 185720
			[Token(Token = "0x402D578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
