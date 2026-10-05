using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI.Popup;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x02003414 RID: 13332
	[Token(Token = "0x2003414")]
	public class UICooperateBattleTopBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x060154BE RID: 87230 RVA: 0x0008B350 File Offset: 0x00089550
		[Token(Token = "0x1700327C")]
		public Vector3 sailBoatPos
		{
			[Token(Token = "0x60154BE")]
			[Address(RVA = "0xDB8E00", Offset = "0xDB7A00", VA = "0x180DB8E00")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060154BF RID: 87231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154BF")]
		[Address(RVA = "0xDB4C80", Offset = "0xDB3880", VA = "0x180DB4C80")]
		public void OnCreate()
		{
		}

		// Token: 0x060154C0 RID: 87232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154C0")]
		[Address(RVA = "0xDB4F20", Offset = "0xDB3B20", VA = "0x180DB4F20")]
		public void OnGameInit(CooperateUIPlugin plugin, GameModeFactory.CooperateGameMode gameMode)
		{
		}

		// Token: 0x060154C1 RID: 87233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154C1")]
		[Address(RVA = "0xDB5220", Offset = "0xDB3E20", VA = "0x180DB5220")]
		public void OnGameReady()
		{
		}

		// Token: 0x060154C2 RID: 87234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154C2")]
		[Address(RVA = "0xDB51B0", Offset = "0xDB3DB0", VA = "0x180DB51B0")]
		public void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x060154C3 RID: 87235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154C3")]
		[Address(RVA = "0xDB5710", Offset = "0xDB4310", VA = "0x180DB5710")]
		public void OnGetFinishGame()
		{
		}

		// Token: 0x060154C4 RID: 87236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154C4")]
		[Address(RVA = "0xDB6800", Offset = "0xDB5400", VA = "0x180DB6800")]
		public void SetStageTimer(FP time)
		{
		}

		// Token: 0x060154C5 RID: 87237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154C5")]
		[Address(RVA = "0xDB6AE0", Offset = "0xDB56E0", VA = "0x180DB6AE0")]
		public void StopTimerAnim()
		{
		}

		// Token: 0x060154C6 RID: 87238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154C6")]
		[Address(RVA = "0xDB6A00", Offset = "0xDB5600", VA = "0x180DB6A00")]
		public void StageEndAnim()
		{
		}

		// Token: 0x060154C7 RID: 87239 RVA: 0x0008B368 File Offset: 0x00089568
		[Token(Token = "0x60154C7")]
		[Address(RVA = "0xDB60F0", Offset = "0xDB4CF0", VA = "0x180DB60F0")]
		public bool RegistTask(ObjectPtr<Buff> buff, CoopStageType type)
		{
			return default(bool);
		}

		// Token: 0x060154C8 RID: 87240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154C8")]
		[Address(RVA = "0xDB4500", Offset = "0xDB3100", VA = "0x180DB4500")]
		public void AddResultNormalTarget(TargetInfo target)
		{
		}

		// Token: 0x060154C9 RID: 87241 RVA: 0x0008B380 File Offset: 0x00089580
		[Token(Token = "0x60154C9")]
		[Address(RVA = "0xDB6FF0", Offset = "0xDB5BF0", VA = "0x180DB6FF0")]
		public bool UpdateProgressBuff(ObjectPtr<Buff> buff)
		{
			return default(bool);
		}

		// Token: 0x060154CA RID: 87242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154CA")]
		[Address(RVA = "0xDB4630", Offset = "0xDB3230", VA = "0x180DB4630")]
		public void GetProgress(int curScore)
		{
		}

		// Token: 0x060154CB RID: 87243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154CB")]
		[Address(RVA = "0xDB5E10", Offset = "0xDB4A10", VA = "0x180DB5E10")]
		public void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x060154CC RID: 87244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154CC")]
		[Address(RVA = "0xDB4CF0", Offset = "0xDB38F0", VA = "0x180DB4CF0")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x060154CD RID: 87245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154CD")]
		[Address(RVA = "0xDB6C70", Offset = "0xDB5870", VA = "0x180DB6C70")]
		public void UpdateGameInfo()
		{
		}

		// Token: 0x060154CE RID: 87246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154CE")]
		[Address(RVA = "0xDB6BC0", Offset = "0xDB57C0", VA = "0x180DB6BC0")]
		public void UpdateDisableMask(BattleFunctionDisableMask mask)
		{
		}

		// Token: 0x060154CF RID: 87247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154CF")]
		[Address(RVA = "0xDB5FA0", Offset = "0xDB4BA0", VA = "0x180DB5FA0")]
		public void OpenPauseConfirmPanel()
		{
		}

		// Token: 0x060154D0 RID: 87248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154D0")]
		[Address(RVA = "0xDB45B0", Offset = "0xDB31B0", VA = "0x180DB45B0")]
		public void ClosePauseConfirmPanel()
		{
		}

		// Token: 0x060154D1 RID: 87249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154D1")]
		[Address(RVA = "0xDB6690", Offset = "0xDB5290", VA = "0x180DB6690")]
		public void SetPauseButtonActive(bool isActive)
		{
		}

		// Token: 0x060154D2 RID: 87250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154D2")]
		[Address(RVA = "0xDB6750", Offset = "0xDB5350", VA = "0x180DB6750")]
		public void SetSpeedColor(bool speedUp, bool mateSpeedUp)
		{
		}

		// Token: 0x060154D3 RID: 87251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154D3")]
		[Address(RVA = "0xDB4760", Offset = "0xDB3360", VA = "0x180DB4760")]
		public void InitLayout()
		{
		}

		// Token: 0x060154D4 RID: 87252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154D4")]
		[Address(RVA = "0xDB4AE0", Offset = "0xDB36E0", VA = "0x180DB4AE0")]
		public void NextFrameInPause()
		{
		}

		// Token: 0x060154D5 RID: 87253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154D5")]
		[Address(RVA = "0xDB5A50", Offset = "0xDB4650", VA = "0x180DB5A50")]
		public void OnRealPaused()
		{
		}

		// Token: 0x060154D6 RID: 87254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154D6")]
		[Address(RVA = "0xDB5B30", Offset = "0xDB4730", VA = "0x180DB5B30")]
		public void OnRealResume()
		{
		}

		// Token: 0x060154D7 RID: 87255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154D7")]
		[Address(RVA = "0xDB4920", Offset = "0xDB3520", VA = "0x180DB4920")]
		public void MarkPauseWaitInvalid(bool reject, PlayerSide side)
		{
		}

		// Token: 0x060154D8 RID: 87256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154D8")]
		[Address(RVA = "0xDB63D0", Offset = "0xDB4FD0", VA = "0x180DB63D0")]
		public void ResetPauseWaitTimer(PlayerSide side)
		{
		}

		// Token: 0x060154D9 RID: 87257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154D9")]
		[Address(RVA = "0xDB6510", Offset = "0xDB5110", VA = "0x180DB6510")]
		public void ResetResumeTimer()
		{
		}

		// Token: 0x060154DA RID: 87258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154DA")]
		[Address(RVA = "0xDB5890", Offset = "0xDB4490", VA = "0x180DB5890")]
		public void OnPlayerDie(PlayerSide side)
		{
		}

		// Token: 0x060154DB RID: 87259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154DB")]
		[Address(RVA = "0xDB5970", Offset = "0xDB4570", VA = "0x180DB5970")]
		public void OnPlayerRevive(PlayerSide side)
		{
		}

		// Token: 0x060154DC RID: 87260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154DC")]
		[Address(RVA = "0xDB57A0", Offset = "0xDB43A0", VA = "0x180DB57A0")]
		public void OnMultiPlayerPauseButtonClicked()
		{
		}

		// Token: 0x060154DD RID: 87261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154DD")]
		[Address(RVA = "0xDB5CF0", Offset = "0xDB48F0", VA = "0x180DB5CF0")]
		public void OnSystemMenuClicked()
		{
		}

		// Token: 0x060154DE RID: 87262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154DE")]
		[Address(RVA = "0xDB5800", Offset = "0xDB4400", VA = "0x180DB5800")]
		public void OnPauseResponseClicked(int param)
		{
		}

		// Token: 0x060154DF RID: 87263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154DF")]
		[Address(RVA = "0xDB5BA0", Offset = "0xDB47A0", VA = "0x180DB5BA0")]
		public void OnSpeedUpClicked()
		{
		}

		// Token: 0x060154E0 RID: 87264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60154E0")]
		[Address(RVA = "0xDB8910", Offset = "0xDB7510", VA = "0x180DB8910")]
		private string _TimeToShow(FP time)
		{
			return null;
		}

		// Token: 0x060154E1 RID: 87265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154E1")]
		[Address(RVA = "0xDB72A0", Offset = "0xDB5EA0", VA = "0x180DB72A0")]
		private void _OnMultiPauseButtonClicked()
		{
		}

		// Token: 0x060154E2 RID: 87266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154E2")]
		[Address(RVA = "0xDB87E0", Offset = "0xDB73E0", VA = "0x180DB87E0")]
		private void _ResetPauseCoolDown()
		{
		}

		// Token: 0x060154E3 RID: 87267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154E3")]
		[Address(RVA = "0xDB7170", Offset = "0xDB5D70", VA = "0x180DB7170")]
		private void _ChangeButtonIcon(bool isPause)
		{
		}

		// Token: 0x060154E4 RID: 87268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154E4")]
		[Address(RVA = "0xDB8040", Offset = "0xDB6C40", VA = "0x180DB8040")]
		private void _OnScoreAGoal(object arg)
		{
		}

		// Token: 0x060154E5 RID: 87269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154E5")]
		[Address(RVA = "0xDB7C20", Offset = "0xDB6820", VA = "0x180DB7C20")]
		private void _OnSailBoatRealStart(object arg)
		{
		}

		// Token: 0x060154E6 RID: 87270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154E6")]
		[Address(RVA = "0xDB7CB0", Offset = "0xDB68B0", VA = "0x180DB7CB0")]
		private void _OnSailBoatScoreChanged(object arg)
		{
		}

		// Token: 0x060154E7 RID: 87271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154E7")]
		[Address(RVA = "0xDB7D80", Offset = "0xDB6980", VA = "0x180DB7D80")]
		private void _OnSailBoatTransitionArea(object arg)
		{
		}

		// Token: 0x060154E8 RID: 87272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154E8")]
		[Address(RVA = "0xDB7E50", Offset = "0xDB6A50", VA = "0x180DB7E50")]
		private void _OnSailBoatWaterForceChanged(object arg)
		{
		}

		// Token: 0x060154E9 RID: 87273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154E9")]
		[Address(RVA = "0xDB7F70", Offset = "0xDB6B70", VA = "0x180DB7F70")]
		private void _OnSailBoatWaterWaveStart(object arg)
		{
		}

		// Token: 0x060154EA RID: 87274 RVA: 0x0008B398 File Offset: 0x00089598
		[Token(Token = "0x60154EA")]
		[Address(RVA = "0xDB8170", Offset = "0xDB6D70", VA = "0x180DB8170")]
		private bool _PauseWaitingTimerUpdate(FP deltaTime)
		{
			return default(bool);
		}

		// Token: 0x060154EB RID: 87275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154EB")]
		[Address(RVA = "0xDB74E0", Offset = "0xDB60E0", VA = "0x180DB74E0")]
		private void _OnPlayerDying(object arg)
		{
		}

		// Token: 0x060154EC RID: 87276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154EC")]
		[Address(RVA = "0xDB7970", Offset = "0xDB6570", VA = "0x180DB7970")]
		private void _OnPlayerRevive(object arg)
		{
		}

		// Token: 0x060154ED RID: 87277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154ED")]
		[Address(RVA = "0xDB84A0", Offset = "0xDB70A0", VA = "0x180DB84A0")]
		private void _RegisterMultiplayerListener()
		{
		}

		// Token: 0x060154EE RID: 87278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154EE")]
		[Address(RVA = "0xDB8A50", Offset = "0xDB7650", VA = "0x180DB8A50")]
		private void _UnRegisterMultiplayerListener()
		{
		}

		// Token: 0x060154EF RID: 87279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154EF")]
		[Address(RVA = "0xDB8D90", Offset = "0xDB7990", VA = "0x180DB8D90")]
		public UICooperateBattleTopBar()
		{
		}

		// Token: 0x04019737 RID: 104247
		[Token(Token = "0x4019737")]
		private const string TIME_FORMAT = "{0}:{1}";

		// Token: 0x04019738 RID: 104248
		[Token(Token = "0x4019738")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICooperateBattlePauseConfirmPanel _pauseConfirmPanel;

		// Token: 0x04019739 RID: 104249
		[Token(Token = "0x4019739")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _multiPlayerPauseButton;

		// Token: 0x0401973A RID: 104250
		[Token(Token = "0x401973A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic _pauseImg;

		// Token: 0x0401973B RID: 104251
		[Token(Token = "0x401973B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Graphic _resumeImg;

		// Token: 0x0401973C RID: 104252
		[Token(Token = "0x401973C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UITopBar.BasicStatus _basicStatus;

		// Token: 0x0401973D RID: 104253
		[Token(Token = "0x401973D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UITopBar.BasicStatus _footballStatus;

		// Token: 0x0401973E RID: 104254
		[Token(Token = "0x401973E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UITopBar.BasicStatus _sailBoatStatus;

		// Token: 0x0401973F RID: 104255
		[Token(Token = "0x401973F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICooperateBattleTopBar.ExtraStatus _extraStatus;

		// Token: 0x04019740 RID: 104256
		[Token(Token = "0x4019740")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _multiSystemButton;

		// Token: 0x04019741 RID: 104257
		[Token(Token = "0x4019741")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _multiSpeedUpButton;

		// Token: 0x04019742 RID: 104258
		[Token(Token = "0x4019742")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Slider _pauseResumeSlider;

		// Token: 0x04019743 RID: 104259
		[Token(Token = "0x4019743")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Slider _pauseRequestSlider;

		// Token: 0x04019744 RID: 104260
		[Token(Token = "0x4019744")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UICooperateBattleSpeedPanel _speedPanel;

		// Token: 0x04019745 RID: 104261
		[Token(Token = "0x4019745")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("footballBar")]
		private UICooperateScoreStatusPanel _cooperateScoreStatusPanel;

		// Token: 0x04019746 RID: 104262
		[Token(Token = "0x4019746")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("sailBoatBar")]
		private UICooperateSailBoatStatusPanel _cooperateSailBoatStatusPanel;

		// Token: 0x04019747 RID: 104263
		[Token(Token = "0x4019747")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UICooperateTaskView _taskView;

		// Token: 0x04019748 RID: 104264
		[Token(Token = "0x4019748")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Task")]
		private Text _footballTimer;

		// Token: 0x04019749 RID: 104265
		[Token(Token = "0x4019749")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Task")]
		private List<UICooperateTaskPanel> _taskPanels;

		// Token: 0x0401974A RID: 104266
		[Token(Token = "0x401974A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UICooperateTaskFortressPanel _fortressTaskPanel;

		// Token: 0x0401974B RID: 104267
		[Token(Token = "0x401974B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UICooperateTaskFortressLastWavePanel _fortressTaskLastWavePanel;

		// Token: 0x0401974C RID: 104268
		[Token(Token = "0x401974C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _reviveTimerSelf;

		// Token: 0x0401974D RID: 104269
		[Token(Token = "0x401974D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _reviveTimerOpposite;

		// Token: 0x0401974E RID: 104270
		[Token(Token = "0x401974E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIAnimationLocation _reviveTimerEnterSelf;

		// Token: 0x0401974F RID: 104271
		[Token(Token = "0x401974F")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIAnimationLocation _reviveTimerEnterOppo;

		// Token: 0x04019750 RID: 104272
		[Token(Token = "0x4019750")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIAnimationLocation _lifePointEnterSelf;

		// Token: 0x04019751 RID: 104273
		[Token(Token = "0x4019751")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIAnimationLocation _lifePointEnterOppo;

		// Token: 0x04019752 RID: 104274
		[Token(Token = "0x4019752")]
		[FieldOffset(Offset = "0x108")]
		private CooperateUIPlugin m_plugin;

		// Token: 0x04019753 RID: 104275
		[Token(Token = "0x4019753")]
		[FieldOffset(Offset = "0x110")]
		private GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x04019754 RID: 104276
		[Token(Token = "0x4019754")]
		[FieldOffset(Offset = "0x118")]
		private PeriodicTimer m_pauseWaitingTimer;

		// Token: 0x04019755 RID: 104277
		[Token(Token = "0x4019755")]
		[FieldOffset(Offset = "0x120")]
		private PeriodicTimer m_pauseResumeTimer;

		// Token: 0x04019756 RID: 104278
		[Token(Token = "0x4019756")]
		[FieldOffset(Offset = "0x128")]
		private PeriodicTimer m_pauseCooldownTimer;

		// Token: 0x04019757 RID: 104279
		[Token(Token = "0x4019757")]
		[FieldOffset(Offset = "0x130")]
		private int m_mateIgnorePauseTime;

		// Token: 0x04019758 RID: 104280
		[Token(Token = "0x4019758")]
		[FieldOffset(Offset = "0x134")]
		private bool m_pausebuttonIsOnLocal;

		// Token: 0x04019759 RID: 104281
		[Token(Token = "0x4019759")]
		[FieldOffset(Offset = "0x138")]
		private PlayerSide m_pauseRequestSide;

		// Token: 0x0401975A RID: 104282
		[Token(Token = "0x401975A")]
		[FieldOffset(Offset = "0x13C")]
		private bool m_isPauseButtonInteractive;

		// Token: 0x0401975B RID: 104283
		[Token(Token = "0x401975B")]
		[FieldOffset(Offset = "0x140")]
		private UICooperateTaskPanel m_curPanel;

		// Token: 0x0401975C RID: 104284
		[Token(Token = "0x401975C")]
		[FieldOffset(Offset = "0x148")]
		private bool m_isPlayerDead;

		// Token: 0x0401975D RID: 104285
		[Token(Token = "0x401975D")]
		[FieldOffset(Offset = "0x14C")]
		private PlayerSide m_deadPlayerSide;

		// Token: 0x0401975E RID: 104286
		[Token(Token = "0x401975E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sailBoatPos;

		// Token: 0x0401975F RID: 104287
		[Token(Token = "0x401975F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04019760 RID: 104288
		[Token(Token = "0x4019760")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04019761 RID: 104289
		[Token(Token = "0x4019761")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x04019762 RID: 104290
		[Token(Token = "0x4019762")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x04019763 RID: 104291
		[Token(Token = "0x4019763")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnGetFinishGame;

		// Token: 0x04019764 RID: 104292
		[Token(Token = "0x4019764")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetStageTimer;

		// Token: 0x04019765 RID: 104293
		[Token(Token = "0x4019765")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_StopTimerAnim;

		// Token: 0x04019766 RID: 104294
		[Token(Token = "0x4019766")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_StageEndAnim;

		// Token: 0x04019767 RID: 104295
		[Token(Token = "0x4019767")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RegistTask;

		// Token: 0x04019768 RID: 104296
		[Token(Token = "0x4019768")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_AddResultNormalTarget;

		// Token: 0x04019769 RID: 104297
		[Token(Token = "0x4019769")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateProgressBuff;

		// Token: 0x0401976A RID: 104298
		[Token(Token = "0x401976A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetProgress;

		// Token: 0x0401976B RID: 104299
		[Token(Token = "0x401976B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x0401976C RID: 104300
		[Token(Token = "0x401976C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x0401976D RID: 104301
		[Token(Token = "0x401976D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0401976E RID: 104302
		[Token(Token = "0x401976E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UpdateDisableMask;

		// Token: 0x0401976F RID: 104303
		[Token(Token = "0x401976F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OpenPauseConfirmPanel;

		// Token: 0x04019770 RID: 104304
		[Token(Token = "0x4019770")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ClosePauseConfirmPanel;

		// Token: 0x04019771 RID: 104305
		[Token(Token = "0x4019771")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SetPauseButtonActive;

		// Token: 0x04019772 RID: 104306
		[Token(Token = "0x4019772")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetSpeedColor;

		// Token: 0x04019773 RID: 104307
		[Token(Token = "0x4019773")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_InitLayout;

		// Token: 0x04019774 RID: 104308
		[Token(Token = "0x4019774")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_NextFrameInPause;

		// Token: 0x04019775 RID: 104309
		[Token(Token = "0x4019775")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnRealPaused;

		// Token: 0x04019776 RID: 104310
		[Token(Token = "0x4019776")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnRealResume;

		// Token: 0x04019777 RID: 104311
		[Token(Token = "0x4019777")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_MarkPauseWaitInvalid;

		// Token: 0x04019778 RID: 104312
		[Token(Token = "0x4019778")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ResetPauseWaitTimer;

		// Token: 0x04019779 RID: 104313
		[Token(Token = "0x4019779")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_ResetResumeTimer;

		// Token: 0x0401977A RID: 104314
		[Token(Token = "0x401977A")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnPlayerDie;

		// Token: 0x0401977B RID: 104315
		[Token(Token = "0x401977B")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnPlayerRevive;

		// Token: 0x0401977C RID: 104316
		[Token(Token = "0x401977C")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnMultiPlayerPauseButtonClicked;

		// Token: 0x0401977D RID: 104317
		[Token(Token = "0x401977D")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnSystemMenuClicked;

		// Token: 0x0401977E RID: 104318
		[Token(Token = "0x401977E")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnPauseResponseClicked;

		// Token: 0x0401977F RID: 104319
		[Token(Token = "0x401977F")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnSpeedUpClicked;

		// Token: 0x04019780 RID: 104320
		[Token(Token = "0x4019780")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__TimeToShow;

		// Token: 0x04019781 RID: 104321
		[Token(Token = "0x4019781")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OnMultiPauseButtonClicked;

		// Token: 0x04019782 RID: 104322
		[Token(Token = "0x4019782")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__ResetPauseCoolDown;

		// Token: 0x04019783 RID: 104323
		[Token(Token = "0x4019783")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__ChangeButtonIcon;

		// Token: 0x04019784 RID: 104324
		[Token(Token = "0x4019784")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__OnScoreAGoal;

		// Token: 0x04019785 RID: 104325
		[Token(Token = "0x4019785")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__OnSailBoatRealStart;

		// Token: 0x04019786 RID: 104326
		[Token(Token = "0x4019786")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__OnSailBoatScoreChanged;

		// Token: 0x04019787 RID: 104327
		[Token(Token = "0x4019787")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__OnSailBoatTransitionArea;

		// Token: 0x04019788 RID: 104328
		[Token(Token = "0x4019788")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__OnSailBoatWaterForceChanged;

		// Token: 0x04019789 RID: 104329
		[Token(Token = "0x4019789")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__OnSailBoatWaterWaveStart;

		// Token: 0x0401978A RID: 104330
		[Token(Token = "0x401978A")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__PauseWaitingTimerUpdate;

		// Token: 0x0401978B RID: 104331
		[Token(Token = "0x401978B")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__OnPlayerDying;

		// Token: 0x0401978C RID: 104332
		[Token(Token = "0x401978C")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__OnPlayerRevive;

		// Token: 0x0401978D RID: 104333
		[Token(Token = "0x401978D")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__RegisterMultiplayerListener;

		// Token: 0x0401978E RID: 104334
		[Token(Token = "0x401978E")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__UnRegisterMultiplayerListener;

		// Token: 0x0401978F RID: 104335
		[Token(Token = "0x401978F")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003415 RID: 13333
		[Token(Token = "0x2003415")]
		[Serializable]
		private class ExtraStatus
		{
			// Token: 0x060154F0 RID: 87280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154F0")]
			[Address(RVA = "0xDCD280", Offset = "0xDCBE80", VA = "0x180DCD280")]
			public void InitData()
			{
			}

			// Token: 0x060154F1 RID: 87281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154F1")]
			[Address(RVA = "0xDCD3F0", Offset = "0xDCBFF0", VA = "0x180DCD3F0")]
			public void OnCreate()
			{
			}

			// Token: 0x060154F2 RID: 87282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154F2")]
			[Address(RVA = "0xDCD580", Offset = "0xDCC180", VA = "0x180DCD580")]
			public void UpdateData()
			{
			}

			// Token: 0x060154F3 RID: 87283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154F3")]
			[Address(RVA = "0xD594B0", Offset = "0xD580B0", VA = "0x180D594B0")]
			public void HideMateHPInfo()
			{
			}

			// Token: 0x060154F4 RID: 87284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154F4")]
			[Address(RVA = "0xDCD550", Offset = "0xDCC150", VA = "0x180DCD550")]
			public void RestoreMateHPInfo()
			{
			}

			// Token: 0x060154F5 RID: 87285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154F5")]
			[Address(RVA = "0xDCD990", Offset = "0xDCC590", VA = "0x180DCD990")]
			private void _UpdateTopBar(bool force = false)
			{
			}

			// Token: 0x060154F6 RID: 87286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154F6")]
			[Address(RVA = "0xDCD7A0", Offset = "0xDCC3A0", VA = "0x180DCD7A0")]
			private void _UpdateBattleEndTime()
			{
			}

			// Token: 0x060154F7 RID: 87287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154F7")]
			[Address(RVA = "0xDCD910", Offset = "0xDCC510", VA = "0x180DCD910")]
			private void _UpdateLagDisplay()
			{
			}

			// Token: 0x060154F8 RID: 87288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154F8")]
			[Address(RVA = "0xDCDA50", Offset = "0xDCC650", VA = "0x180DCDA50")]
			public ExtraStatus()
			{
			}

			// Token: 0x04019790 RID: 104336
			[Token(Token = "0x4019790")]
			private const float TICK_INTERVAL = 0.5f;

			// Token: 0x04019791 RID: 104337
			[Token(Token = "0x4019791")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Text _battleEndTimeText;

			// Token: 0x04019792 RID: 104338
			[Token(Token = "0x4019792")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private UICooperateLagDisplay _lagDisplay;

			// Token: 0x04019793 RID: 104339
			[Token(Token = "0x4019793")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private UILifePoint _mateLifePoint;

			// Token: 0x04019794 RID: 104340
			[Token(Token = "0x4019794")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private UILifeLostGroup _mateLifeLostGroup;

			// Token: 0x04019795 RID: 104341
			[Token(Token = "0x4019795")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private UIInfoToastPanel _toastPanel;

			// Token: 0x04019796 RID: 104342
			[Token(Token = "0x4019796")]
			[FieldOffset(Offset = "0x38")]
			private float m_ticker;

			// Token: 0x04019797 RID: 104343
			[Token(Token = "0x4019797")]
			[FieldOffset(Offset = "0x40")]
			private long m_forceEndTimestamp;

			// Token: 0x04019798 RID: 104344
			[Token(Token = "0x4019798")]
			[FieldOffset(Offset = "0x48")]
			private UIInfoToastPanel m_toastPanel;

			// Token: 0x04019799 RID: 104345
			[Token(Token = "0x4019799")]
			[FieldOffset(Offset = "0x50")]
			private PlayerSide m_mateSide;
		}
	}
}
