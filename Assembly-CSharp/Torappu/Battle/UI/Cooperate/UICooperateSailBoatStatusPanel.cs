using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033E9 RID: 13289
	[Token(Token = "0x20033E9")]
	public class UICooperateSailBoatStatusPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x06015351 RID: 86865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700324E")]
		public Text scoreText
		{
			[Token(Token = "0x6015351")]
			[Address(RVA = "0xDA8B00", Offset = "0xDA7700", VA = "0x180DA8B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015352 RID: 86866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015352")]
		[Address(RVA = "0xDA7670", Offset = "0xDA6270", VA = "0x180DA7670")]
		public void OnRealStart()
		{
		}

		// Token: 0x06015353 RID: 86867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015353")]
		[Address(RVA = "0xDA7320", Offset = "0xDA5F20", VA = "0x180DA7320")]
		public void OnFinishGame()
		{
		}

		// Token: 0x06015354 RID: 86868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015354")]
		[Address(RVA = "0xDA79F0", Offset = "0xDA65F0", VA = "0x180DA79F0")]
		public void OnScoreChanged(int score)
		{
		}

		// Token: 0x06015355 RID: 86869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015355")]
		[Address(RVA = "0xDA76D0", Offset = "0xDA62D0", VA = "0x180DA76D0")]
		public void OnSailBoatTransitionArea(bool isInTransitionRegion)
		{
		}

		// Token: 0x06015356 RID: 86870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015356")]
		[Address(RVA = "0xDA7950", Offset = "0xDA6550", VA = "0x180DA7950")]
		public void OnSailBoatWaterForceChanged(int level, BoatDirection waterDir)
		{
		}

		// Token: 0x06015357 RID: 86871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015357")]
		[Address(RVA = "0xDA7FA0", Offset = "0xDA6BA0", VA = "0x180DA7FA0")]
		public void _OnSailBoatWaterWaveStart(int waveCount)
		{
		}

		// Token: 0x06015358 RID: 86872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015358")]
		[Address(RVA = "0xDA8630", Offset = "0xDA7230", VA = "0x180DA8630")]
		private void _ShowGoalAnim()
		{
		}

		// Token: 0x06015359 RID: 86873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015359")]
		[Address(RVA = "0xDA73D0", Offset = "0xDA5FD0", VA = "0x180DA73D0")]
		public void OnGameReady(List<int> scoreGoals, int totalTime, int extraTime)
		{
		}

		// Token: 0x0601535A RID: 86874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601535A")]
		[Address(RVA = "0xDA7BF0", Offset = "0xDA67F0", VA = "0x180DA7BF0")]
		public void UpdateRemainingTime(FP deltaTime)
		{
		}

		// Token: 0x0601535B RID: 86875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601535B")]
		[Address(RVA = "0xDA8130", Offset = "0xDA6D30", VA = "0x180DA8130")]
		private void _PlayReachAllGoal()
		{
		}

		// Token: 0x0601535C RID: 86876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601535C")]
		[Address(RVA = "0xDA8480", Offset = "0xDA7080", VA = "0x180DA8480")]
		private void _PlayTimeOutAnim()
		{
		}

		// Token: 0x0601535D RID: 86877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601535D")]
		[Address(RVA = "0xDA7220", Offset = "0xDA5E20", VA = "0x180DA7220")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601535E RID: 86878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601535E")]
		[Address(RVA = "0xDA8A40", Offset = "0xDA7640", VA = "0x180DA8A40")]
		public UICooperateSailBoatStatusPanel()
		{
		}

		// Token: 0x04019526 RID: 103718
		[Token(Token = "0x4019526")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _progressText;

		// Token: 0x04019527 RID: 103719
		[Token(Token = "0x4019527")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Score")]
		private Text _scoreText;

		// Token: 0x04019528 RID: 103720
		[Token(Token = "0x4019528")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Score")]
		private UIAnimationLocation _scoreAddAnim;

		// Token: 0x04019529 RID: 103721
		[Token(Token = "0x4019529")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Score")]
		private UIAnimationLocation _scoreReduceAnim;

		// Token: 0x0401952A RID: 103722
		[Token(Token = "0x401952A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Score")]
		private List<UICooperateSailBoatScoreItem> _scoreItems;

		// Token: 0x0401952B RID: 103723
		[Token(Token = "0x401952B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _completeAnim;

		// Token: 0x0401952C RID: 103724
		[Token(Token = "0x401952C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Tips")]
		private Text _timeText;

		// Token: 0x0401952D RID: 103725
		[Token(Token = "0x401952D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Tips")]
		private UIAnimationLocation _timeOutTips;

		// Token: 0x0401952E RID: 103726
		[Token(Token = "0x401952E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Tips")]
		private GameObject _continueTipsObj;

		// Token: 0x0401952F RID: 103727
		[Token(Token = "0x401952F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Tips")]
		private GameObject _areaTipsObj;

		// Token: 0x04019530 RID: 103728
		[Token(Token = "0x4019530")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Tips")]
		private UIAnimationLocation _continueInTips;

		// Token: 0x04019531 RID: 103729
		[Token(Token = "0x4019531")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Tips")]
		private UIAnimationLocation _continueOutTips;

		// Token: 0x04019532 RID: 103730
		[Token(Token = "0x4019532")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Tips")]
		private UIAnimationLocation _areaInTips;

		// Token: 0x04019533 RID: 103731
		[Token(Token = "0x4019533")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Tips")]
		private UIAnimationLocation _areaOutTips;

		// Token: 0x04019534 RID: 103732
		[Token(Token = "0x4019534")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UICooperateSailBoatWaterFlowPanel _waterFlowPanel;

		// Token: 0x04019535 RID: 103733
		[Token(Token = "0x4019535")]
		private const int MAX_CHECK_CNT = 3;

		// Token: 0x04019536 RID: 103734
		[Token(Token = "0x4019536")]
		private const int TIME_OUT_NUM = 30;

		// Token: 0x04019537 RID: 103735
		[Token(Token = "0x4019537")]
		[FieldOffset(Offset = "0xD0")]
		private int m_curScore;

		// Token: 0x04019538 RID: 103736
		[Token(Token = "0x4019538")]
		[FieldOffset(Offset = "0xD4")]
		private int m_curGoalIndex;

		// Token: 0x04019539 RID: 103737
		[Token(Token = "0x4019539")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_timeOutPlaying;

		// Token: 0x0401953A RID: 103738
		[Token(Token = "0x401953A")]
		[FieldOffset(Offset = "0xD9")]
		private bool m_firstReachAllGoal;

		// Token: 0x0401953B RID: 103739
		[Token(Token = "0x401953B")]
		[FieldOffset(Offset = "0xDA")]
		private bool m_firstGetScore;

		// Token: 0x0401953C RID: 103740
		[Token(Token = "0x401953C")]
		[FieldOffset(Offset = "0xE0")]
		private Sequence m_reachAllGoalTween;

		// Token: 0x0401953D RID: 103741
		[Token(Token = "0x401953D")]
		[FieldOffset(Offset = "0xE8")]
		private List<int> m_scoreGoalList;

		// Token: 0x0401953E RID: 103742
		[Token(Token = "0x401953E")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_timeTween;

		// Token: 0x0401953F RID: 103743
		[Token(Token = "0x401953F")]
		[FieldOffset(Offset = "0xF8")]
		private Tween m_areaInTween;

		// Token: 0x04019540 RID: 103744
		[Token(Token = "0x4019540")]
		[FieldOffset(Offset = "0x100")]
		private float m_totalTime;

		// Token: 0x04019541 RID: 103745
		[Token(Token = "0x4019541")]
		[FieldOffset(Offset = "0x104")]
		private int m_extraTime;

		// Token: 0x04019542 RID: 103746
		[Token(Token = "0x4019542")]
		[FieldOffset(Offset = "0x108")]
		private bool m_startTimer;

		// Token: 0x04019543 RID: 103747
		[Token(Token = "0x4019543")]
		[FieldOffset(Offset = "0x10C")]
		private int m_curTimeSec;

		// Token: 0x04019544 RID: 103748
		[Token(Token = "0x4019544")]
		private const string COMMON_GRAY_STRING = "8e8e8e";

		// Token: 0x04019545 RID: 103749
		[Token(Token = "0x4019545")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_scoreText;

		// Token: 0x04019546 RID: 103750
		[Token(Token = "0x4019546")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRealStart;

		// Token: 0x04019547 RID: 103751
		[Token(Token = "0x4019547")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinishGame;

		// Token: 0x04019548 RID: 103752
		[Token(Token = "0x4019548")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnScoreChanged;

		// Token: 0x04019549 RID: 103753
		[Token(Token = "0x4019549")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSailBoatTransitionArea;

		// Token: 0x0401954A RID: 103754
		[Token(Token = "0x401954A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSailBoatWaterForceChanged;

		// Token: 0x0401954B RID: 103755
		[Token(Token = "0x401954B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnSailBoatWaterWaveStart;

		// Token: 0x0401954C RID: 103756
		[Token(Token = "0x401954C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowGoalAnim;

		// Token: 0x0401954D RID: 103757
		[Token(Token = "0x401954D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0401954E RID: 103758
		[Token(Token = "0x401954E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateRemainingTime;

		// Token: 0x0401954F RID: 103759
		[Token(Token = "0x401954F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PlayReachAllGoal;

		// Token: 0x04019550 RID: 103760
		[Token(Token = "0x4019550")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayTimeOutAnim;

		// Token: 0x04019551 RID: 103761
		[Token(Token = "0x4019551")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04019552 RID: 103762
		[Token(Token = "0x4019552")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
