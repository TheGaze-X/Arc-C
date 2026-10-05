using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using Torappu.Battle.GameMode;
using Torappu.Multiplayer.Servers;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x0200340C RID: 13324
	[Token(Token = "0x200340C")]
	public class UICooperateBattleMenuSystemPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060154A4 RID: 87204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154A4")]
		[Address(RVA = "0xDB2770", Offset = "0xDB1370", VA = "0x180DB2770")]
		public void OnGameInit(CooperateUIPlugin plugin, GameModeFactory.CooperateGameMode gameMode)
		{
		}

		// Token: 0x060154A5 RID: 87205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154A5")]
		[Address(RVA = "0xDB29A0", Offset = "0xDB15A0", VA = "0x180DB29A0")]
		public void OnGameReady()
		{
		}

		// Token: 0x060154A6 RID: 87206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154A6")]
		[Address(RVA = "0xDB2470", Offset = "0xDB1070", VA = "0x180DB2470")]
		public void InitLayout()
		{
		}

		// Token: 0x060154A7 RID: 87207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154A7")]
		[Address(RVA = "0xDB2E80", Offset = "0xDB1A80", VA = "0x180DB2E80")]
		public void Show()
		{
		}

		// Token: 0x060154A8 RID: 87208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154A8")]
		[Address(RVA = "0xDB2D90", Offset = "0xDB1990", VA = "0x180DB2D90")]
		public void SetPunishInfo(bool punish)
		{
		}

		// Token: 0x060154A9 RID: 87209 RVA: 0x0008B338 File Offset: 0x00089538
		[Token(Token = "0x60154A9")]
		[Address(RVA = "0xDB1E10", Offset = "0xDB0A10", VA = "0x180DB1E10")]
		public bool HookOnBattleFinishServiceStateEnter()
		{
			return default(bool);
		}

		// Token: 0x060154AA RID: 87210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154AA")]
		[Address(RVA = "0xDB1CE0", Offset = "0xDB08E0", VA = "0x180DB1CE0")]
		public void AddResultNormalTarget(TargetInfo target)
		{
		}

		// Token: 0x060154AB RID: 87211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154AB")]
		[Address(RVA = "0xDB2EF0", Offset = "0xDB1AF0", VA = "0x180DB2EF0")]
		private void _HandleBattleEnd(object arg)
		{
		}

		// Token: 0x060154AC RID: 87212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154AC")]
		[Address(RVA = "0xDB3100", Offset = "0xDB1D00", VA = "0x180DB3100")]
		private void _OnBattleFinishSend(BattleProtocol.GameSettleInfo settleInfo)
		{
		}

		// Token: 0x060154AD RID: 87213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154AD")]
		[Address(RVA = "0xDB2540", Offset = "0xDB1140", VA = "0x180DB2540")]
		public void OnAbnormalExitClicked()
		{
		}

		// Token: 0x060154AE RID: 87214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154AE")]
		[Address(RVA = "0xDB2BD0", Offset = "0xDB17D0", VA = "0x180DB2BD0")]
		public void OnGiveUpClicked()
		{
		}

		// Token: 0x060154AF RID: 87215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154AF")]
		[Address(RVA = "0xDB2600", Offset = "0xDB1200", VA = "0x180DB2600")]
		public void OnCancelGiveUpClicked()
		{
		}

		// Token: 0x060154B0 RID: 87216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154B0")]
		[Address(RVA = "0xDB2670", Offset = "0xDB1270", VA = "0x180DB2670")]
		public void OnDestroy()
		{
		}

		// Token: 0x060154B1 RID: 87217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154B1")]
		[Address(RVA = "0xDB3420", Offset = "0xDB2020", VA = "0x180DB3420")]
		public UICooperateBattleMenuSystemPanel()
		{
		}

		// Token: 0x04019705 RID: 104197
		[Token(Token = "0x4019705")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _systemPanelAbnormal;

		// Token: 0x04019706 RID: 104198
		[Token(Token = "0x4019706")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _systemPanelAbnormalText;

		// Token: 0x04019707 RID: 104199
		[Token(Token = "0x4019707")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _systemPanelAbnormalInfoText;

		// Token: 0x04019708 RID: 104200
		[Token(Token = "0x4019708")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _systemPanelAbnormalInfoWaringText;

		// Token: 0x04019709 RID: 104201
		[Token(Token = "0x4019709")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _exitInfoUnpunish;

		// Token: 0x0401970A RID: 104202
		[Token(Token = "0x401970A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _exitInfoPunish;

		// Token: 0x0401970B RID: 104203
		[Token(Token = "0x401970B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _exitInfoInTraining;

		// Token: 0x0401970C RID: 104204
		[Token(Token = "0x401970C")]
		[FieldOffset(Offset = "0x50")]
		private GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x0401970D RID: 104205
		[Token(Token = "0x401970D")]
		[FieldOffset(Offset = "0x58")]
		private CooperateUIPlugin m_plugin;

		// Token: 0x0401970E RID: 104206
		[Token(Token = "0x401970E")]
		[FieldOffset(Offset = "0x60")]
		private int m_gameAbnormalParam;

		// Token: 0x0401970F RID: 104207
		[Token(Token = "0x401970F")]
		[FieldOffset(Offset = "0x64")]
		private bool m_isAbnormalExit;

		// Token: 0x04019710 RID: 104208
		[Token(Token = "0x4019710")]
		[FieldOffset(Offset = "0x65")]
		private bool m_isShowNetWorkMask;

		// Token: 0x04019711 RID: 104209
		[Token(Token = "0x4019711")]
		[FieldOffset(Offset = "0x68")]
		private UICooperateBattleMenuSystemPanel.ResultInfoBasic m_result;

		// Token: 0x04019712 RID: 104210
		[Token(Token = "0x4019712")]
		[FieldOffset(Offset = "0x70")]
		private BattleProtocol.GameSettleInfo m_cachedSettle;

		// Token: 0x04019713 RID: 104211
		[Token(Token = "0x4019713")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04019714 RID: 104212
		[Token(Token = "0x4019714")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x04019715 RID: 104213
		[Token(Token = "0x4019715")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitLayout;

		// Token: 0x04019716 RID: 104214
		[Token(Token = "0x4019716")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04019717 RID: 104215
		[Token(Token = "0x4019717")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetPunishInfo;

		// Token: 0x04019718 RID: 104216
		[Token(Token = "0x4019718")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HookOnBattleFinishServiceStateEnter;

		// Token: 0x04019719 RID: 104217
		[Token(Token = "0x4019719")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AddResultNormalTarget;

		// Token: 0x0401971A RID: 104218
		[Token(Token = "0x401971A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HandleBattleEnd;

		// Token: 0x0401971B RID: 104219
		[Token(Token = "0x401971B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBattleFinishSend;

		// Token: 0x0401971C RID: 104220
		[Token(Token = "0x401971C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnAbnormalExitClicked;

		// Token: 0x0401971D RID: 104221
		[Token(Token = "0x401971D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnGiveUpClicked;

		// Token: 0x0401971E RID: 104222
		[Token(Token = "0x401971E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnCancelGiveUpClicked;

		// Token: 0x0401971F RID: 104223
		[Token(Token = "0x401971F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04019720 RID: 104224
		[Token(Token = "0x4019720")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200340D RID: 13325
		[Token(Token = "0x200340D")]
		private class ResultInfoBasic
		{
			// Token: 0x060154B2 RID: 87218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154B2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ResultInfoBasic()
			{
			}
		}

		// Token: 0x0200340E RID: 13326
		[Token(Token = "0x200340E")]
		private class ResultInfoFootball : UICooperateBattleMenuSystemPanel.ResultInfoBasic
		{
			// Token: 0x060154B3 RID: 87219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154B3")]
			[Address(RVA = "0xDAE3B0", Offset = "0xDACFB0", VA = "0x180DAE3B0")]
			public ResultInfoFootball()
			{
			}

			// Token: 0x04019721 RID: 104225
			[Token(Token = "0x4019721")]
			[FieldOffset(Offset = "0x10")]
			public List<int> goal;
		}

		// Token: 0x0200340F RID: 13327
		[Token(Token = "0x200340F")]
		private class ResultInfoFortress : UICooperateBattleMenuSystemPanel.ResultInfoBasic
		{
			// Token: 0x060154B4 RID: 87220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154B4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ResultInfoFortress()
			{
			}

			// Token: 0x04019722 RID: 104226
			[Token(Token = "0x4019722")]
			[FieldOffset(Offset = "0x10")]
			public int wave;

			// Token: 0x04019723 RID: 104227
			[Token(Token = "0x4019723")]
			[FieldOffset(Offset = "0x14")]
			public int damage;

			// Token: 0x04019724 RID: 104228
			[Token(Token = "0x4019724")]
			[FieldOffset(Offset = "0x18")]
			public int damagePct;

			// Token: 0x04019725 RID: 104229
			[Token(Token = "0x4019725")]
			[FieldOffset(Offset = "0x1C")]
			public bool bossKill;
		}

		// Token: 0x02003410 RID: 13328
		[Token(Token = "0x2003410")]
		private class ResultInfoNormal : UICooperateBattleMenuSystemPanel.ResultInfoBasic
		{
			// Token: 0x060154B5 RID: 87221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154B5")]
			[Address(RVA = "0xDAE440", Offset = "0xDAD040", VA = "0x180DAE440")]
			public ResultInfoNormal()
			{
			}

			// Token: 0x04019726 RID: 104230
			[Token(Token = "0x4019726")]
			[FieldOffset(Offset = "0x10")]
			public int fail;

			// Token: 0x04019727 RID: 104231
			[Token(Token = "0x4019727")]
			[FieldOffset(Offset = "0x18")]
			public List<TargetInfo> targets;
		}

		// Token: 0x02003411 RID: 13329
		[Token(Token = "0x2003411")]
		private class ResultInfoRaft : UICooperateBattleMenuSystemPanel.ResultInfoBasic
		{
			// Token: 0x060154B6 RID: 87222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60154B6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ResultInfoRaft()
			{
			}

			// Token: 0x04019728 RID: 104232
			[Token(Token = "0x4019728")]
			[FieldOffset(Offset = "0x10")]
			public int score;
		}
	}
}
