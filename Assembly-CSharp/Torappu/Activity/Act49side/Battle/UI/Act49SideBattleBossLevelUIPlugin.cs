using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.UI;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act49side.Battle.UI
{
	// Token: 0x02007297 RID: 29335
	[Token(Token = "0x2007297")]
	public class Act49SideBattleBossLevelUIPlugin : UIController.Plugin
	{
		// Token: 0x0602988E RID: 170126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602988E")]
		[Address(RVA = "0x24D9120", Offset = "0x24D7D20", VA = "0x1824D9120", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x0602988F RID: 170127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602988F")]
		[Address(RVA = "0x24D8E80", Offset = "0x24D7A80", VA = "0x1824D8E80", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x06029890 RID: 170128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029890")]
		[Address(RVA = "0x24D8D40", Offset = "0x24D7940", VA = "0x1824D8D40", Slot = "19")]
		public override void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x06029891 RID: 170129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029891")]
		[Address(RVA = "0x24D92A0", Offset = "0x24D7EA0", VA = "0x1824D92A0", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x06029892 RID: 170130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029892")]
		[Address(RVA = "0x24DA7D0", Offset = "0x24D93D0", VA = "0x1824DA7D0")]
		private void _UpdateSlider()
		{
		}

		// Token: 0x06029893 RID: 170131 RVA: 0x000D5DF8 File Offset: 0x000D3FF8
		[Token(Token = "0x6029893")]
		[Address(RVA = "0x24D9AC0", Offset = "0x24D86C0", VA = "0x1824D9AC0")]
		private Act49SideBattleBossLevelUIPlugin.PrintStage _GetCurPrintStage()
		{
			return Act49SideBattleBossLevelUIPlugin.PrintStage.None;
		}

		// Token: 0x06029894 RID: 170132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029894")]
		[Address(RVA = "0x24D99F0", Offset = "0x24D85F0", VA = "0x1824D99F0")]
		private void _EnterMainBattleStage(Act49SideBattleBossLevelUIPlugin.Act49SideBossLevelUIState curBossLevelState)
		{
		}

		// Token: 0x06029895 RID: 170133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029895")]
		[Address(RVA = "0x24DA4E0", Offset = "0x24D90E0", VA = "0x1824DA4E0")]
		private void _ShowSlider(RectTransform recTrans)
		{
		}

		// Token: 0x06029896 RID: 170134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029896")]
		[Address(RVA = "0x24DA000", Offset = "0x24D8C00", VA = "0x1824DA000")]
		private void _HideStage(CanvasGroup canvas)
		{
		}

		// Token: 0x06029897 RID: 170135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029897")]
		[Address(RVA = "0x24D9D30", Offset = "0x24D8930", VA = "0x1824D9D30")]
		private void _HideSlider(RectTransform recTrans)
		{
		}

		// Token: 0x06029898 RID: 170136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029898")]
		[Address(RVA = "0x24DA3C0", Offset = "0x24D8FC0", VA = "0x1824DA3C0")]
		private void _SetScaleX(RectTransform recTrans, float newScaleX)
		{
		}

		// Token: 0x06029899 RID: 170137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029899")]
		[Address(RVA = "0x24DA2D0", Offset = "0x24D8ED0", VA = "0x1824DA2D0")]
		private void _SetCanvasAlpha(CanvasGroup canvas, float newAlpha)
		{
		}

		// Token: 0x0602989A RID: 170138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602989A")]
		[Address(RVA = "0x24DAB20", Offset = "0x24D9720", VA = "0x1824DAB20")]
		public Act49SideBattleBossLevelUIPlugin()
		{
		}

		// Token: 0x0602989C RID: 170140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602989C")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x0602989D RID: 170141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602989D")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x0602989E RID: 170142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602989E")]
		[Address(RVA = "0x7D24A0", Offset = "0x7D10A0", VA = "0x1807D24A0")]
		private void <>xLuaBaseProxy_OnGameOver(BattleController.GameResult P0)
		{
		}

		// Token: 0x0602989F RID: 170143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602989F")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x0403B5C2 RID: 243138
		[Token(Token = "0x403B5C2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum UI_STATE_MOVE_CAMERA;

		// Token: 0x0403B5C3 RID: 243139
		[Token(Token = "0x403B5C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x0403B5C4 RID: 243140
		[Token(Token = "0x403B5C4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("printCountDown")]
		private RectTransform _transPrintCountDown;

		// Token: 0x0403B5C5 RID: 243141
		[Token(Token = "0x403B5C5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("printCountDown")]
		private GameObject _goPrintCountDown;

		// Token: 0x0403B5C6 RID: 243142
		[Token(Token = "0x403B5C6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("printCountDown")]
		private Slider _sliderPrint;

		// Token: 0x0403B5C7 RID: 243143
		[Token(Token = "0x403B5C7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("printCountDown")]
		private Image _fillArea;

		// Token: 0x0403B5C8 RID: 243144
		[Token(Token = "0x403B5C8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("printCountDown")]
		private float _stage1bound;

		// Token: 0x0403B5C9 RID: 243145
		[Token(Token = "0x403B5C9")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Group("printCountDown")]
		private float _stage2bound;

		// Token: 0x0403B5CA RID: 243146
		[Token(Token = "0x403B5CA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("printCountDown")]
		private UIAnimationLocation _animationS1ToS2;

		// Token: 0x0403B5CB RID: 243147
		[Token(Token = "0x403B5CB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("printCountDown")]
		private UIAnimationLocation _animationS2ToS3;

		// Token: 0x0403B5CC RID: 243148
		[Token(Token = "0x403B5CC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("printCountDown")]
		private UIAnimationLocation _animationS3ToS4;

		// Token: 0x0403B5CD RID: 243149
		[Token(Token = "0x403B5CD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("printCountDown")]
		private Image _imgDecoBackGround;

		// Token: 0x0403B5CE RID: 243150
		[Token(Token = "0x403B5CE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("printCountDown")]
		private CanvasGroup _cgDecoWarning;

		// Token: 0x0403B5CF RID: 243151
		[Token(Token = "0x403B5CF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("printCountDown")]
		private CanvasGroup _cgGlow;

		// Token: 0x0403B5D0 RID: 243152
		[Token(Token = "0x403B5D0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("printCountDown")]
		private Image _imgGlow;

		// Token: 0x0403B5D1 RID: 243153
		[Token(Token = "0x403B5D1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("printCountDown")]
		private Color _initialColorGlow;

		// Token: 0x0403B5D2 RID: 243154
		[Token(Token = "0x403B5D2")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("printCountDown")]
		private Color _initialColorBg;

		// Token: 0x0403B5D3 RID: 243155
		[Token(Token = "0x403B5D3")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("printCountDown")]
		private GameObject[] _goToBeSetActiveWhenGameStart;

		// Token: 0x0403B5D4 RID: 243156
		[Token(Token = "0x403B5D4")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("bossStage")]
		private CanvasGroup _bossStageCanvas;

		// Token: 0x0403B5D5 RID: 243157
		[Token(Token = "0x403B5D5")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("bossStage")]
		private GameObject _goBossStage;

		// Token: 0x0403B5D6 RID: 243158
		[Token(Token = "0x403B5D6")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("bossStage")]
		private GameObject _bossDeco;

		// Token: 0x0403B5D7 RID: 243159
		[Token(Token = "0x403B5D7")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("bossStage")]
		private GameObject _goBossSealCountDown;

		// Token: 0x0403B5D8 RID: 243160
		[Token(Token = "0x403B5D8")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("bossStage")]
		private Text _textBossSealCountDownNormal;

		// Token: 0x0403B5D9 RID: 243161
		[Token(Token = "0x403B5D9")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("bossStage")]
		private GameObject _goBossSealCountDownRed;

		// Token: 0x0403B5DA RID: 243162
		[Token(Token = "0x403B5DA")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("bossStage")]
		private Text _textBossSealCountDownRed;

		// Token: 0x0403B5DB RID: 243163
		[Token(Token = "0x403B5DB")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("bossStage")]
		private float _bossSealCountDownTurnRedFloor;

		// Token: 0x0403B5DC RID: 243164
		[Token(Token = "0x403B5DC")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("bossStageHead")]
		private UIAnimationLocation _animationSealHead;

		// Token: 0x0403B5DD RID: 243165
		[Token(Token = "0x403B5DD")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("bossStageHead")]
		private GameObject _headComplete;

		// Token: 0x0403B5DE RID: 243166
		[Token(Token = "0x403B5DE")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("bossStageHead")]
		private GameObject _headCurrent;

		// Token: 0x0403B5DF RID: 243167
		[Token(Token = "0x403B5DF")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("bossStageHead")]
		private GameObject _headNormal;

		// Token: 0x0403B5E0 RID: 243168
		[Token(Token = "0x403B5E0")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("bossStageTail")]
		private UIAnimationLocation _animationSealTail;

		// Token: 0x0403B5E1 RID: 243169
		[Token(Token = "0x403B5E1")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("bossStageTail")]
		private GameObject _tailComplete;

		// Token: 0x0403B5E2 RID: 243170
		[Token(Token = "0x403B5E2")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("bossStageTail")]
		private GameObject _tailCurrent;

		// Token: 0x0403B5E3 RID: 243171
		[Token(Token = "0x403B5E3")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("bossStageTail")]
		private GameObject _tailNormal;

		// Token: 0x0403B5E4 RID: 243172
		[Token(Token = "0x403B5E4")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("bossStageLeftHand")]
		private UIAnimationLocation _animationSealLeftHand;

		// Token: 0x0403B5E5 RID: 243173
		[Token(Token = "0x403B5E5")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("bossStageLeftHand")]
		private GameObject _leftHandComplete;

		// Token: 0x0403B5E6 RID: 243174
		[Token(Token = "0x403B5E6")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("bossStageLeftHand")]
		private GameObject _leftHandCurrent;

		// Token: 0x0403B5E7 RID: 243175
		[Token(Token = "0x403B5E7")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("bossStageLeftHand")]
		private GameObject _leftHandNormal;

		// Token: 0x0403B5E8 RID: 243176
		[Token(Token = "0x403B5E8")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("bossStageRightHand")]
		private UIAnimationLocation _animationSealRightHand;

		// Token: 0x0403B5E9 RID: 243177
		[Token(Token = "0x403B5E9")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Group("bossStageRightHand")]
		private GameObject _rightHandComplete;

		// Token: 0x0403B5EA RID: 243178
		[Token(Token = "0x403B5EA")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Group("bossStageRightHand")]
		private GameObject _rightHandCurrent;

		// Token: 0x0403B5EB RID: 243179
		[Token(Token = "0x403B5EB")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		[Group("bossStageRightHand")]
		private GameObject _rightHandNormal;

		// Token: 0x0403B5EC RID: 243180
		[Token(Token = "0x403B5EC")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		[Group("bossHP")]
		private RectTransform _transBossHPSlider;

		// Token: 0x0403B5ED RID: 243181
		[Token(Token = "0x403B5ED")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		[Group("bossHP")]
		private GameObject _goBossHPSlider;

		// Token: 0x0403B5EE RID: 243182
		[Token(Token = "0x403B5EE")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		[Group("bossHP")]
		private Slider _bossHPSlider;

		// Token: 0x0403B5EF RID: 243183
		[Token(Token = "0x403B5EF")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		[Group("tween")]
		private float _animationDuration;

		// Token: 0x0403B5F0 RID: 243184
		[Token(Token = "0x403B5F0")]
		[FieldOffset(Offset = "0x1CC")]
		[SerializeField]
		[Group("tween")]
		private Ease _easeType;

		// Token: 0x0403B5F1 RID: 243185
		[Token(Token = "0x403B5F1")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Group("tween")]
		private Ease _easeTypeReverse;

		// Token: 0x0403B5F2 RID: 243186
		[Token(Token = "0x403B5F2")]
		[FieldOffset(Offset = "0x1D4")]
		[SerializeField]
		[Group("tween")]
		private float _startScaleX;

		// Token: 0x0403B5F3 RID: 243187
		[Token(Token = "0x403B5F3")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("tween")]
		private float _endScaleX;

		// Token: 0x0403B5F4 RID: 243188
		[Token(Token = "0x403B5F4")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[Group("Audio")]
		private string _sealBossAudio;

		// Token: 0x0403B5F5 RID: 243189
		[Token(Token = "0x403B5F5")]
		[FieldOffset(Offset = "0x1E8")]
		private Act49SideLevelBossManager m_envSysManagerBoss;

		// Token: 0x0403B5F6 RID: 243190
		[Token(Token = "0x403B5F6")]
		[FieldOffset(Offset = "0x1F0")]
		private Act49SidePrintingManager m_envSysManager;

		// Token: 0x0403B5F7 RID: 243191
		[Token(Token = "0x403B5F7")]
		[FieldOffset(Offset = "0x1F8")]
		private Act49SideBattleBossLevelUIPlugin.Act49SideBossLevelUIState m_cachedBossLevelState;

		// Token: 0x0403B5F8 RID: 243192
		[Token(Token = "0x403B5F8")]
		[FieldOffset(Offset = "0x218")]
		private Act49SideBattleBossLevelUIPlugin.PrintStage m_cachedStage;

		// Token: 0x0403B5F9 RID: 243193
		[Token(Token = "0x403B5F9")]
		[FieldOffset(Offset = "0x220")]
		private Tween m_sliderTween;

		// Token: 0x0403B5FA RID: 243194
		[Token(Token = "0x403B5FA")]
		[FieldOffset(Offset = "0x228")]
		private Tween m_stageTween;

		// Token: 0x0403B5FB RID: 243195
		[Token(Token = "0x403B5FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x0403B5FC RID: 243196
		[Token(Token = "0x403B5FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0403B5FD RID: 243197
		[Token(Token = "0x403B5FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x0403B5FE RID: 243198
		[Token(Token = "0x403B5FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0403B5FF RID: 243199
		[Token(Token = "0x403B5FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateSlider;

		// Token: 0x0403B600 RID: 243200
		[Token(Token = "0x403B600")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetCurPrintStage;

		// Token: 0x0403B601 RID: 243201
		[Token(Token = "0x403B601")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EnterMainBattleStage;

		// Token: 0x0403B602 RID: 243202
		[Token(Token = "0x403B602")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowSlider;

		// Token: 0x0403B603 RID: 243203
		[Token(Token = "0x403B603")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HideStage;

		// Token: 0x0403B604 RID: 243204
		[Token(Token = "0x403B604")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__HideSlider;

		// Token: 0x0403B605 RID: 243205
		[Token(Token = "0x403B605")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetScaleX;

		// Token: 0x0403B606 RID: 243206
		[Token(Token = "0x403B606")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SetCanvasAlpha;

		// Token: 0x0403B607 RID: 243207
		[Token(Token = "0x403B607")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007298 RID: 29336
		[Token(Token = "0x2007298")]
		private enum PrintStage
		{
			// Token: 0x0403B609 RID: 243209
			[Token(Token = "0x403B609")]
			None,
			// Token: 0x0403B60A RID: 243210
			[Token(Token = "0x403B60A")]
			Stage1,
			// Token: 0x0403B60B RID: 243211
			[Token(Token = "0x403B60B")]
			Stage2,
			// Token: 0x0403B60C RID: 243212
			[Token(Token = "0x403B60C")]
			Stage3,
			// Token: 0x0403B60D RID: 243213
			[Token(Token = "0x403B60D")]
			Stage4
		}

		// Token: 0x02007299 RID: 29337
		[Token(Token = "0x2007299")]
		public struct Act49SideBossLevelUIState
		{
			// Token: 0x0403B60E RID: 243214
			[Token(Token = "0x403B60E")]
			[FieldOffset(Offset = "0x0")]
			public bool isInMainBattle;

			// Token: 0x0403B60F RID: 243215
			[Token(Token = "0x403B60F")]
			[FieldOffset(Offset = "0x1")]
			public bool isHeadSealed;

			// Token: 0x0403B610 RID: 243216
			[Token(Token = "0x403B610")]
			[FieldOffset(Offset = "0x2")]
			public bool isTailSealed;

			// Token: 0x0403B611 RID: 243217
			[Token(Token = "0x403B611")]
			[FieldOffset(Offset = "0x3")]
			public bool isLeftHandSealed;

			// Token: 0x0403B612 RID: 243218
			[Token(Token = "0x403B612")]
			[FieldOffset(Offset = "0x4")]
			public bool isRightHandSealed;

			// Token: 0x0403B613 RID: 243219
			[Token(Token = "0x403B613")]
			[FieldOffset(Offset = "0x5")]
			public bool headRoomFinished;

			// Token: 0x0403B614 RID: 243220
			[Token(Token = "0x403B614")]
			[FieldOffset(Offset = "0x6")]
			public bool tailRoomFinished;

			// Token: 0x0403B615 RID: 243221
			[Token(Token = "0x403B615")]
			[FieldOffset(Offset = "0x7")]
			public bool leftHandRoomFinished;

			// Token: 0x0403B616 RID: 243222
			[Token(Token = "0x403B616")]
			[FieldOffset(Offset = "0x8")]
			public bool rightHandRoomFinished;

			// Token: 0x0403B617 RID: 243223
			[Token(Token = "0x403B617")]
			[FieldOffset(Offset = "0xC")]
			public int bossSealCountDown;

			// Token: 0x0403B618 RID: 243224
			[Token(Token = "0x403B618")]
			[FieldOffset(Offset = "0x10")]
			public float bossSealCountRatio;

			// Token: 0x0403B619 RID: 243225
			[Token(Token = "0x403B619")]
			[FieldOffset(Offset = "0x14")]
			public bool isInPrintingRoom;

			// Token: 0x0403B61A RID: 243226
			[Token(Token = "0x403B61A")]
			[FieldOffset(Offset = "0x15")]
			public bool forceHidePrintingSlider;

			// Token: 0x0403B61B RID: 243227
			[Token(Token = "0x403B61B")]
			[FieldOffset(Offset = "0x18")]
			public float bossHPRatio;

			// Token: 0x0403B61C RID: 243228
			[Token(Token = "0x403B61C")]
			[FieldOffset(Offset = "0x1C")]
			public float printProgress;
		}
	}
}
