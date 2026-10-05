using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x0200480A RID: 18442
	[Token(Token = "0x200480A")]
	public class MonopolyMissionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BE33 RID: 114227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE33")]
		[Address(RVA = "0x15472C0", Offset = "0x1545EC0", VA = "0x1815472C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BE34 RID: 114228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE34")]
		[Address(RVA = "0x15475F0", Offset = "0x15461F0", VA = "0x1815475F0")]
		private void _PlayScoreRankUpEffect(ref Tween tween, UIAnimationLocation anim, float delay, bool fastMode, string audioSignal)
		{
		}

		// Token: 0x0601BE35 RID: 114229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE35")]
		[Address(RVA = "0x15473E0", Offset = "0x1545FE0", VA = "0x1815473E0")]
		private void _PlayScoreNumTween(int lastScore, int currScore, float delay, bool fastMode)
		{
		}

		// Token: 0x0601BE36 RID: 114230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE36")]
		[Address(RVA = "0x1546A80", Offset = "0x1545680", VA = "0x181546A80")]
		public void Render(MonopolyGameDetailViewModel gameModel)
		{
		}

		// Token: 0x0601BE37 RID: 114231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE37")]
		[Address(RVA = "0x15469E0", Offset = "0x15455E0", VA = "0x1815469E0")]
		public void RegisterMissionTutorialGo()
		{
		}

		// Token: 0x0601BE38 RID: 114232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE38")]
		[Address(RVA = "0x1547870", Offset = "0x1546470", VA = "0x181547870")]
		public MonopolyMissionView()
		{
		}

		// Token: 0x0402456B RID: 148843
		[Token(Token = "0x402456B")]
		private const string TOTAL_SCORE_FORMAT = "/{0}";

		// Token: 0x0402456C RID: 148844
		[Token(Token = "0x402456C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textGoalDesc;

		// Token: 0x0402456D RID: 148845
		[Token(Token = "0x402456D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCurrScore;

		// Token: 0x0402456E RID: 148846
		[Token(Token = "0x402456E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTotalScore;

		// Token: 0x0402456F RID: 148847
		[Token(Token = "0x402456F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _missionProgressStage1Notice;

		// Token: 0x04024570 RID: 148848
		[Token(Token = "0x4024570")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _missionProgressStage2Notice;

		// Token: 0x04024571 RID: 148849
		[Token(Token = "0x4024571")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _layoutMission;

		// Token: 0x04024572 RID: 148850
		[Token(Token = "0x4024572")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _scoreNumTweenDuration;

		// Token: 0x04024573 RID: 148851
		[Token(Token = "0x4024573")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _missionPanelTutorialGo;

		// Token: 0x04024574 RID: 148852
		[Token(Token = "0x4024574")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x04024575 RID: 148853
		[Token(Token = "0x4024575")]
		[FieldOffset(Offset = "0x70")]
		private MonopolyMissionView.Adapter m_adapter;

		// Token: 0x04024576 RID: 148854
		[Token(Token = "0x4024576")]
		[FieldOffset(Offset = "0x78")]
		private MonopolyMissionViewModel m_cachedViewModel;

		// Token: 0x04024577 RID: 148855
		[Token(Token = "0x4024577")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedScore;

		// Token: 0x04024578 RID: 148856
		[Token(Token = "0x4024578")]
		[FieldOffset(Offset = "0x84")]
		private int m_cachedTargetScore;

		// Token: 0x04024579 RID: 148857
		[Token(Token = "0x4024579")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_scoreRankUp1Tween;

		// Token: 0x0402457A RID: 148858
		[Token(Token = "0x402457A")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_scoreRankUp2Tween;

		// Token: 0x0402457B RID: 148859
		[Token(Token = "0x402457B")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_scoreNumTween;

		// Token: 0x0402457C RID: 148860
		[Token(Token = "0x402457C")]
		[FieldOffset(Offset = "0xA0")]
		private int m_cachedMissionCompleteSeqNum;

		// Token: 0x0402457D RID: 148861
		[Token(Token = "0x402457D")]
		[FieldOffset(Offset = "0xA4")]
		private int m_cachedGameActionSeqNum;

		// Token: 0x0402457E RID: 148862
		[Token(Token = "0x402457E")]
		[FieldOffset(Offset = "0xA8")]
		private int m_cachedInitSeq;

		// Token: 0x0402457F RID: 148863
		[Token(Token = "0x402457F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024580 RID: 148864
		[Token(Token = "0x4024580")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayScoreRankUpEffect;

		// Token: 0x04024581 RID: 148865
		[Token(Token = "0x4024581")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayScoreNumTween;

		// Token: 0x04024582 RID: 148866
		[Token(Token = "0x4024582")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024583 RID: 148867
		[Token(Token = "0x4024583")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterMissionTutorialGo;

		// Token: 0x04024584 RID: 148868
		[Token(Token = "0x4024584")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200480B RID: 18443
		[Token(Token = "0x200480B")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601BE39 RID: 114233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BE39")]
			[Address(RVA = "0x1536F90", Offset = "0x1535B90", VA = "0x181536F90")]
			public Adapter(MonopolyMissionView closure)
			{
			}

			// Token: 0x17004245 RID: 16965
			// (set) Token: 0x0601BE3A RID: 114234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004245")]
			public bool fastMode
			{
				[Token(Token = "0x601BE3A")]
				[Address(RVA = "0x15370E0", Offset = "0x1535CE0", VA = "0x1815370E0")]
				set
				{
				}
			}

			// Token: 0x17004246 RID: 16966
			// (set) Token: 0x0601BE3B RID: 114235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004246")]
			public bool isGameAction
			{
				[Token(Token = "0x601BE3B")]
				[Address(RVA = "0x15371C0", Offset = "0x1535DC0", VA = "0x1815371C0")]
				set
				{
				}
			}

			// Token: 0x17004247 RID: 16967
			// (set) Token: 0x0601BE3C RID: 114236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004247")]
			public MonopolyEventType gameActionType
			{
				[Token(Token = "0x601BE3C")]
				[Address(RVA = "0x1537150", Offset = "0x1535D50", VA = "0x181537150")]
				set
				{
				}
			}

			// Token: 0x17004248 RID: 16968
			// (get) Token: 0x0601BE3D RID: 114237 RVA: 0x000A68D8 File Offset: 0x000A4AD8
			[Token(Token = "0x17004248")]
			public override int count
			{
				[Token(Token = "0x601BE3D")]
				[Address(RVA = "0x1537010", Offset = "0x1535C10", VA = "0x181537010", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601BE3E RID: 114238 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BE3E")]
			[Address(RVA = "0x1536DC0", Offset = "0x15359C0", VA = "0x181536DC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04024585 RID: 148869
			[Token(Token = "0x4024585")]
			[FieldOffset(Offset = "0x20")]
			private MonopolyMissionView m_closure;

			// Token: 0x04024586 RID: 148870
			[Token(Token = "0x4024586")]
			[FieldOffset(Offset = "0x28")]
			private bool m_fastMode;

			// Token: 0x04024587 RID: 148871
			[Token(Token = "0x4024587")]
			[FieldOffset(Offset = "0x29")]
			private bool m_isGameAction;

			// Token: 0x04024588 RID: 148872
			[Token(Token = "0x4024588")]
			[FieldOffset(Offset = "0x2C")]
			private MonopolyEventType m_gameActionType;

			// Token: 0x04024589 RID: 148873
			[Token(Token = "0x4024589")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402458A RID: 148874
			[Token(Token = "0x402458A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_fastMode;

			// Token: 0x0402458B RID: 148875
			[Token(Token = "0x402458B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_isGameAction;

			// Token: 0x0402458C RID: 148876
			[Token(Token = "0x402458C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_gameActionType;

			// Token: 0x0402458D RID: 148877
			[Token(Token = "0x402458D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402458E RID: 148878
			[Token(Token = "0x402458E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
