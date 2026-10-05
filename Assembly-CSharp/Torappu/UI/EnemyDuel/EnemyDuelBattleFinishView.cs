using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.BattleFinish;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F4D RID: 20301
	[Token(Token = "0x2004F4D")]
	public class EnemyDuelBattleFinishView : DynBattleFinishView, IHotfixable, ITimeWatcher
	{
		// Token: 0x0601E3A2 RID: 123810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3A2")]
		[Address(RVA = "0x17E40B0", Offset = "0x17E2CB0", VA = "0x1817E40B0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601E3A3 RID: 123811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E3A3")]
		[Address(RVA = "0x17E45F0", Offset = "0x17E31F0", VA = "0x1817E45F0", Slot = "7")]
		public override IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0601E3A4 RID: 123812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3A4")]
		[Address(RVA = "0x17E46A0", Offset = "0x17E32A0", VA = "0x1817E46A0")]
		private void Start()
		{
		}

		// Token: 0x0601E3A5 RID: 123813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3A5")]
		[Address(RVA = "0x17E4050", Offset = "0x17E2C50", VA = "0x1817E4050")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601E3A6 RID: 123814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3A6")]
		[Address(RVA = "0x17E4960", Offset = "0x17E3560", VA = "0x1817E4960", Slot = "8")]
		public void UpdateTime(float timeDelta)
		{
		}

		// Token: 0x0601E3A7 RID: 123815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3A7")]
		[Address(RVA = "0x17E68E0", Offset = "0x17E54E0", VA = "0x1817E68E0")]
		private void _RenderView(EnemyDuelBattleFinishViewModel model)
		{
		}

		// Token: 0x0601E3A8 RID: 123816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3A8")]
		[Address(RVA = "0x17E4BE0", Offset = "0x17E37E0", VA = "0x1817E4BE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E3A9 RID: 123817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3A9")]
		[Address(RVA = "0x17E6790", Offset = "0x17E5390", VA = "0x1817E6790")]
		private void _RenderRankList(List<SettlementRankItemModel> rankList, int selfIndex)
		{
		}

		// Token: 0x0601E3AA RID: 123818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3AA")]
		[Address(RVA = "0x17E5700", Offset = "0x17E4300", VA = "0x1817E5700")]
		private void _PlayEntryAnim()
		{
		}

		// Token: 0x0601E3AB RID: 123819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3AB")]
		[Address(RVA = "0x17E5890", Offset = "0x17E4490", VA = "0x1817E5890")]
		private void _PlayNumberTween(Text roundText, int round)
		{
		}

		// Token: 0x0601E3AC RID: 123820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3AC")]
		[Address(RVA = "0x17E47C0", Offset = "0x17E33C0", VA = "0x1817E47C0")]
		private void _OnShowTopRankDance()
		{
		}

		// Token: 0x0601E3AD RID: 123821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3AD")]
		[Address(RVA = "0x17E6530", Offset = "0x17E5130", VA = "0x1817E6530")]
		private void _RenderOperationRoundBar(ChoiceCntInfo info)
		{
		}

		// Token: 0x0601E3AE RID: 123822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E3AE")]
		[Address(RVA = "0x17E4AC0", Offset = "0x17E36C0", VA = "0x1817E4AC0")]
		private Sprite _GetRandomBkgSprite(string actId, int picNum)
		{
			return null;
		}

		// Token: 0x0601E3AF RID: 123823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3AF")]
		[Address(RVA = "0x17E61B0", Offset = "0x17E4DB0", VA = "0x1817E61B0")]
		private void _RenderDailyMission(EnemyDuelBattleFinishViewModel model)
		{
		}

		// Token: 0x0601E3B0 RID: 123824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E3B0")]
		[Address(RVA = "0x17E5180", Offset = "0x17E3D80", VA = "0x1817E5180")]
		private Tween _PlayBpAnim(EnemyDuelBattleFinishViewModel model)
		{
			return null;
		}

		// Token: 0x0601E3B1 RID: 123825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3B1")]
		[Address(RVA = "0x17E5DA0", Offset = "0x17E49A0", VA = "0x1817E5DA0")]
		private void _RenderBpOnce(MileStoneInfo info)
		{
		}

		// Token: 0x0601E3B2 RID: 123826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3B2")]
		[Address(RVA = "0x17E5B20", Offset = "0x17E4720", VA = "0x1817E5B20")]
		private void _RenderBpOnceWithMaxAnim(MileStoneInfo info)
		{
		}

		// Token: 0x0601E3B3 RID: 123827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3B3")]
		[Address(RVA = "0x17E6050", Offset = "0x17E4C50", VA = "0x1817E6050")]
		private void _RenderBtns(EnemyDuelBattleFinishViewModel model)
		{
		}

		// Token: 0x0601E3B4 RID: 123828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3B4")]
		[Address(RVA = "0x17E7210", Offset = "0x17E5E10", VA = "0x1817E7210")]
		private void _UpdateCountdown()
		{
		}

		// Token: 0x0601E3B5 RID: 123829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3B5")]
		[Address(RVA = "0x17E4A30", Offset = "0x17E3630", VA = "0x1817E4A30")]
		private void _DoFocusAction(int index)
		{
		}

		// Token: 0x0601E3B6 RID: 123830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3B6")]
		[Address(RVA = "0x17E3C90", Offset = "0x17E2890", VA = "0x1817E3C90")]
		public void OnBackToEntryBtnClicked()
		{
		}

		// Token: 0x0601E3B7 RID: 123831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3B7")]
		[Address(RVA = "0x17E4240", Offset = "0x17E2E40", VA = "0x1817E4240")]
		public void OnNextClicked()
		{
		}

		// Token: 0x0601E3B8 RID: 123832 RVA: 0x000ADF28 File Offset: 0x000AC128
		[Token(Token = "0x601E3B8")]
		[Address(RVA = "0x17E49D0", Offset = "0x17E35D0", VA = "0x1817E49D0")]
		private bool _CheckIfRoomEnded()
		{
			return default(bool);
		}

		// Token: 0x0601E3B9 RID: 123833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3B9")]
		[Address(RVA = "0x17E4D40", Offset = "0x17E3940", VA = "0x1817E4D40")]
		private void _OnBackToEntry()
		{
		}

		// Token: 0x0601E3BA RID: 123834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3BA")]
		[Address(RVA = "0x17E4F70", Offset = "0x17E3B70", VA = "0x1817E4F70")]
		private void _OnBackToPrepare()
		{
		}

		// Token: 0x0601E3BB RID: 123835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3BB")]
		[Address(RVA = "0x17E7420", Offset = "0x17E6020", VA = "0x1817E7420")]
		public EnemyDuelBattleFinishView()
		{
		}

		// Token: 0x0601E3BE RID: 123838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E3BE")]
		[Address(RVA = "0x17E4700", Offset = "0x17E3300", VA = "0x1817E4700")]
		private IEnumerator <>xLuaBaseProxy_ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x040284CC RID: 165068
		[Token(Token = "0x40284CC")]
		private const string NAME_FORMAT = "{0}#{1}";

		// Token: 0x040284CD RID: 165069
		[Token(Token = "0x40284CD")]
		private const string BKG_ID_FORMAT = "{0}_settlement_bg_{1}";

		// Token: 0x040284CE RID: 165070
		[Token(Token = "0x40284CE")]
		private const float BASE_LENGTH = 150f;

		// Token: 0x040284CF RID: 165071
		[Token(Token = "0x40284CF")]
		private const float LENGTH_PER_ROUND = 30f;

		// Token: 0x040284D0 RID: 165072
		[Token(Token = "0x40284D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Top Part")]
		private Image _imageBkg;

		// Token: 0x040284D1 RID: 165073
		[Token(Token = "0x40284D1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Top Part")]
		private Text _title;

		// Token: 0x040284D2 RID: 165074
		[Token(Token = "0x40284D2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Top Part")]
		private TwoStateToggle _toggleTag;

		// Token: 0x040284D3 RID: 165075
		[Token(Token = "0x40284D3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Player Info")]
		private TwoStateToggle _toggleNumTitle;

		// Token: 0x040284D4 RID: 165076
		[Token(Token = "0x40284D4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Player Info")]
		private GameObject _barOperation;

		// Token: 0x040284D5 RID: 165077
		[Token(Token = "0x40284D5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Player Info")]
		private GameObject _roundChar;

		// Token: 0x040284D6 RID: 165078
		[Token(Token = "0x40284D6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Player Info")]
		private GameObject _panelBest;

		// Token: 0x040284D7 RID: 165079
		[Token(Token = "0x40284D7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Player Info")]
		private Text _name;

		// Token: 0x040284D8 RID: 165080
		[Token(Token = "0x40284D8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Player Info")]
		private GameObject _comment;

		// Token: 0x040284D9 RID: 165081
		[Token(Token = "0x40284D9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Player Info")]
		private Text _commentText;

		// Token: 0x040284DA RID: 165082
		[Token(Token = "0x40284DA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Player Info")]
		private Text _num;

		// Token: 0x040284DB RID: 165083
		[Token(Token = "0x40284DB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Player Info")]
		private Text _rankText;

		// Token: 0x040284DC RID: 165084
		[Token(Token = "0x40284DC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Player Info")]
		private GameObject _panelTopRank;

		// Token: 0x040284DD RID: 165085
		[Token(Token = "0x40284DD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Player Info")]
		private Transform _avatarContainer;

		// Token: 0x040284DE RID: 165086
		[Token(Token = "0x40284DE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Player Info")]
		private float _avatarScale;

		// Token: 0x040284DF RID: 165087
		[Token(Token = "0x40284DF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Round Num Anim")]
		private LayoutElement _rectAllIn;

		// Token: 0x040284E0 RID: 165088
		[Token(Token = "0x40284E0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Round Num Anim")]
		private LayoutElement _rectNormal;

		// Token: 0x040284E1 RID: 165089
		[Token(Token = "0x40284E1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Round Num Anim")]
		private LayoutElement _rectSkip;

		// Token: 0x040284E2 RID: 165090
		[Token(Token = "0x40284E2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Round Num Anim")]
		private Text _textAllIn;

		// Token: 0x040284E3 RID: 165091
		[Token(Token = "0x40284E3")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Round Num Anim")]
		private Text _textNormal;

		// Token: 0x040284E4 RID: 165092
		[Token(Token = "0x40284E4")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Round Num Anim")]
		private Text _textSkip;

		// Token: 0x040284E5 RID: 165093
		[Token(Token = "0x40284E5")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Rank List")]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x040284E6 RID: 165094
		[Token(Token = "0x40284E6")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Rank List")]
		private EnemyDuelBattleFinishRankAdapter _adapter;

		// Token: 0x040284E7 RID: 165095
		[Token(Token = "0x40284E7")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Rank List")]
		private UILayoutDimensionListener _listener;

		// Token: 0x040284E8 RID: 165096
		[Token(Token = "0x40284E8")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Rank List")]
		private GridLayoutGroup _layout;

		// Token: 0x040284E9 RID: 165097
		[Token(Token = "0x40284E9")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Bottom Bar")]
		private Text _rewardBp;

		// Token: 0x040284EA RID: 165098
		[Token(Token = "0x40284EA")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Bottom Bar")]
		private Text _bpDailyMissionComplete;

		// Token: 0x040284EB RID: 165099
		[Token(Token = "0x40284EB")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Bottom Bar")]
		private GameObject _dailyPanel;

		// Token: 0x040284EC RID: 165100
		[Token(Token = "0x40284EC")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Bottom Bar")]
		private GameObject _dailyCompletePanel;

		// Token: 0x040284ED RID: 165101
		[Token(Token = "0x40284ED")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Bottom Bar")]
		private Text _dailyCurrPoint;

		// Token: 0x040284EE RID: 165102
		[Token(Token = "0x40284EE")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Bottom Bar")]
		private Text _dailyFullPoint;

		// Token: 0x040284EF RID: 165103
		[Token(Token = "0x40284EF")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Bottom Bar")]
		private Slider _sliderDaily;

		// Token: 0x040284F0 RID: 165104
		[Token(Token = "0x40284F0")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Bottom Bar")]
		private Text _bpLevel;

		// Token: 0x040284F1 RID: 165105
		[Token(Token = "0x40284F1")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Bottom Bar")]
		private GameObject _bpMax;

		// Token: 0x040284F2 RID: 165106
		[Token(Token = "0x40284F2")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Bottom Bar")]
		private GameObject _bpNum;

		// Token: 0x040284F3 RID: 165107
		[Token(Token = "0x40284F3")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Bottom Bar")]
		private Text _bpCurrPoint;

		// Token: 0x040284F4 RID: 165108
		[Token(Token = "0x40284F4")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Bottom Bar")]
		private Text _bpFullPoint;

		// Token: 0x040284F5 RID: 165109
		[Token(Token = "0x40284F5")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("Bottom Bar")]
		private Slider _sliderBp;

		// Token: 0x040284F6 RID: 165110
		[Token(Token = "0x40284F6")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("Bottom Bar")]
		private GameObject _bpEffect;

		// Token: 0x040284F7 RID: 165111
		[Token(Token = "0x40284F7")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("Buttons")]
		private TwoStateToggle _btnToggle;

		// Token: 0x040284F8 RID: 165112
		[Token(Token = "0x40284F8")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("Buttons")]
		private TwoStateToggle _nextBtnToggle;

		// Token: 0x040284F9 RID: 165113
		[Token(Token = "0x40284F9")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("Buttons")]
		private Text _countDownText;

		// Token: 0x040284FA RID: 165114
		[Token(Token = "0x40284FA")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("Buttons")]
		private Slider _countDownSlider;

		// Token: 0x040284FB RID: 165115
		[Token(Token = "0x40284FB")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _entryAnim;

		// Token: 0x040284FC RID: 165116
		[Token(Token = "0x40284FC")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _topRankEntry;

		// Token: 0x040284FD RID: 165117
		[Token(Token = "0x40284FD")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _topRankLoop;

		// Token: 0x040284FE RID: 165118
		[Token(Token = "0x40284FE")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _dailyComplete;

		// Token: 0x040284FF RID: 165119
		[Token(Token = "0x40284FF")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _bpMaxAnim;

		// Token: 0x04028500 RID: 165120
		[Token(Token = "0x4028500")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _bpEffectAnim;

		// Token: 0x04028501 RID: 165121
		[Token(Token = "0x4028501")]
		[FieldOffset(Offset = "0x1D8")]
		private bool m_hasInited;

		// Token: 0x04028502 RID: 165122
		[Token(Token = "0x4028502")]
		[FieldOffset(Offset = "0x1D9")]
		private bool m_isTopRank;

		// Token: 0x04028503 RID: 165123
		[Token(Token = "0x4028503")]
		[FieldOffset(Offset = "0x1E0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028504 RID: 165124
		[Token(Token = "0x4028504")]
		[FieldOffset(Offset = "0x1F0")]
		private Tween m_entryTween;

		// Token: 0x04028505 RID: 165125
		[Token(Token = "0x4028505")]
		[FieldOffset(Offset = "0x1F8")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x04028506 RID: 165126
		[Token(Token = "0x4028506")]
		[FieldOffset(Offset = "0x200")]
		private EnemyDuelBattleFinishViewModel m_viewModel;

		// Token: 0x04028507 RID: 165127
		[Token(Token = "0x4028507")]
		[FieldOffset(Offset = "0x208")]
		private ScaledStopwatch m_stopWatch;

		// Token: 0x04028508 RID: 165128
		[Token(Token = "0x4028508")]
		[FieldOffset(Offset = "0x218")]
		private long m_countDownTotalTime;

		// Token: 0x04028509 RID: 165129
		[Token(Token = "0x4028509")]
		[FieldOffset(Offset = "0x220")]
		private bool m_isCountingDown;

		// Token: 0x0402850A RID: 165130
		[Token(Token = "0x402850A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402850B RID: 165131
		[Token(Token = "0x402850B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x0402850C RID: 165132
		[Token(Token = "0x402850C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0402850D RID: 165133
		[Token(Token = "0x402850D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402850E RID: 165134
		[Token(Token = "0x402850E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0402850F RID: 165135
		[Token(Token = "0x402850F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x04028510 RID: 165136
		[Token(Token = "0x4028510")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028511 RID: 165137
		[Token(Token = "0x4028511")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderRankList;

		// Token: 0x04028512 RID: 165138
		[Token(Token = "0x4028512")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x04028513 RID: 165139
		[Token(Token = "0x4028513")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayNumberTween;

		// Token: 0x04028514 RID: 165140
		[Token(Token = "0x4028514")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnShowTopRankDance;

		// Token: 0x04028515 RID: 165141
		[Token(Token = "0x4028515")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderOperationRoundBar;

		// Token: 0x04028516 RID: 165142
		[Token(Token = "0x4028516")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetRandomBkgSprite;

		// Token: 0x04028517 RID: 165143
		[Token(Token = "0x4028517")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderDailyMission;

		// Token: 0x04028518 RID: 165144
		[Token(Token = "0x4028518")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__PlayBpAnim;

		// Token: 0x04028519 RID: 165145
		[Token(Token = "0x4028519")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RenderBpOnce;

		// Token: 0x0402851A RID: 165146
		[Token(Token = "0x402851A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RenderBpOnceWithMaxAnim;

		// Token: 0x0402851B RID: 165147
		[Token(Token = "0x402851B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RenderBtns;

		// Token: 0x0402851C RID: 165148
		[Token(Token = "0x402851C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateCountdown;

		// Token: 0x0402851D RID: 165149
		[Token(Token = "0x402851D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__DoFocusAction;

		// Token: 0x0402851E RID: 165150
		[Token(Token = "0x402851E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnBackToEntryBtnClicked;

		// Token: 0x0402851F RID: 165151
		[Token(Token = "0x402851F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnNextClicked;

		// Token: 0x04028520 RID: 165152
		[Token(Token = "0x4028520")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CheckIfRoomEnded;

		// Token: 0x04028521 RID: 165153
		[Token(Token = "0x4028521")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnBackToEntry;

		// Token: 0x04028522 RID: 165154
		[Token(Token = "0x4028522")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnBackToPrepare;

		// Token: 0x04028523 RID: 165155
		[Token(Token = "0x4028523")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F4E RID: 20302
		[Token(Token = "0x2004F4E")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x0601E3BF RID: 123839 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E3BF")]
			[Address(RVA = "0x13D53A0", Offset = "0x13D3FA0", VA = "0x1813D53A0")]
			public OnPostLayoutAction(EnemyDuelBattleFinishView closure, int focusIdx)
			{
			}

			// Token: 0x0601E3C0 RID: 123840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E3C0")]
			[Address(RVA = "0x17F4AA0", Offset = "0x17F36A0", VA = "0x1817F4AA0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x04028524 RID: 165156
			[Token(Token = "0x4028524")]
			[FieldOffset(Offset = "0x10")]
			private EnemyDuelBattleFinishView m_closure;

			// Token: 0x04028525 RID: 165157
			[Token(Token = "0x4028525")]
			[FieldOffset(Offset = "0x18")]
			private int m_focusIdx;
		}
	}
}
