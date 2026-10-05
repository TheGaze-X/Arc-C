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

namespace Torappu.Activity.Act38side.Battle.UI
{
	// Token: 0x0200743C RID: 29756
	[Token(Token = "0x200743C")]
	public class Act38sideUIPlugin : UIController.Plugin
	{
		// Token: 0x1700631B RID: 25371
		// (get) Token: 0x06029FDD RID: 171997 RVA: 0x000D7250 File Offset: 0x000D5450
		[Token(Token = "0x1700631B")]
		private int allyKillCnt
		{
			[Token(Token = "0x6029FDD")]
			[Address(RVA = "0x25AA930", Offset = "0x25A9530", VA = "0x1825AA930")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700631C RID: 25372
		// (get) Token: 0x06029FDE RID: 171998 RVA: 0x000D7268 File Offset: 0x000D5468
		[Token(Token = "0x1700631C")]
		private int bossKillCnt
		{
			[Token(Token = "0x6029FDE")]
			[Address(RVA = "0x25AA9A0", Offset = "0x25A95A0", VA = "0x1825AA9A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06029FDF RID: 171999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FDF")]
		[Address(RVA = "0x25A9060", Offset = "0x25A7C60", VA = "0x1825A9060", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x06029FE0 RID: 172000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FE0")]
		[Address(RVA = "0x25A9540", Offset = "0x25A8140", VA = "0x1825A9540", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x06029FE1 RID: 172001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FE1")]
		[Address(RVA = "0x25A8FA0", Offset = "0x25A7BA0", VA = "0x1825A8FA0", Slot = "19")]
		public override void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x06029FE2 RID: 172002 RVA: 0x000D7280 File Offset: 0x000D5480
		[Token(Token = "0x6029FE2")]
		[Address(RVA = "0x25A9770", Offset = "0x25A8370", VA = "0x1825A9770")]
		private bool _CheckAllResourcesValid()
		{
			return default(bool);
		}

		// Token: 0x06029FE3 RID: 172003 RVA: 0x000D7298 File Offset: 0x000D5498
		[Token(Token = "0x6029FE3")]
		[Address(RVA = "0x25A98F0", Offset = "0x25A84F0", VA = "0x1825A98F0")]
		private bool _InitAllMembers()
		{
			return default(bool);
		}

		// Token: 0x06029FE4 RID: 172004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FE4")]
		[Address(RVA = "0x25AA1C0", Offset = "0x25A8DC0", VA = "0x1825AA1C0")]
		private void _OnCarnivalStateChanged()
		{
		}

		// Token: 0x06029FE5 RID: 172005 RVA: 0x000D72B0 File Offset: 0x000D54B0
		[Token(Token = "0x6029FE5")]
		[Address(RVA = "0x25AA290", Offset = "0x25A8E90", VA = "0x1825AA290")]
		private bool _SwitchState(Act38sideUIPlugin.Act38sideUIPluginStateEnum nextState)
		{
			return default(bool);
		}

		// Token: 0x06029FE6 RID: 172006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FE6")]
		[Address(RVA = "0x25AA090", Offset = "0x25A8C90", VA = "0x1825AA090")]
		private void _OnCarnivalStart()
		{
		}

		// Token: 0x06029FE7 RID: 172007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FE7")]
		[Address(RVA = "0x25A9A90", Offset = "0x25A8690", VA = "0x1825A9A90")]
		private void _OnAllyWin()
		{
		}

		// Token: 0x06029FE8 RID: 172008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FE8")]
		[Address(RVA = "0x25A9D90", Offset = "0x25A8990", VA = "0x1825A9D90")]
		private void _OnBossWin()
		{
		}

		// Token: 0x06029FE9 RID: 172009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FE9")]
		[Address(RVA = "0x25A9C10", Offset = "0x25A8810", VA = "0x1825A9C10")]
		private void _OnBossKilled()
		{
		}

		// Token: 0x06029FEA RID: 172010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FEA")]
		[Address(RVA = "0x25AA840", Offset = "0x25A9440", VA = "0x1825AA840")]
		private void _SwitchToEndState()
		{
		}

		// Token: 0x06029FEB RID: 172011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FEB")]
		[Address(RVA = "0x25A9F10", Offset = "0x25A8B10", VA = "0x1825A9F10")]
		private void _OnCarnivalEnd()
		{
		}

		// Token: 0x06029FEC RID: 172012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FEC")]
		[Address(RVA = "0x25AA8A0", Offset = "0x25A94A0", VA = "0x1825AA8A0")]
		public Act38sideUIPlugin()
		{
		}

		// Token: 0x06029FF1 RID: 172017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FF1")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x06029FF2 RID: 172018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FF2")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x06029FF3 RID: 172019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FF3")]
		[Address(RVA = "0x7D24A0", Offset = "0x7D10A0", VA = "0x1807D24A0")]
		private void <>xLuaBaseProxy_OnGameOver(BattleController.GameResult P0)
		{
		}

		// Token: 0x0403C380 RID: 246656
		[Token(Token = "0x403C380")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _envSystemKey;

		// Token: 0x0403C381 RID: 246657
		[Token(Token = "0x403C381")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _carnivalPanel;

		// Token: 0x0403C382 RID: 246658
		[Token(Token = "0x403C382")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _allyKillCnt;

		// Token: 0x0403C383 RID: 246659
		[Token(Token = "0x403C383")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIParticle _allyParticle;

		// Token: 0x0403C384 RID: 246660
		[Token(Token = "0x403C384")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _bossKillCnt;

		// Token: 0x0403C385 RID: 246661
		[Token(Token = "0x403C385")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIParticle _bossParticle;

		// Token: 0x0403C386 RID: 246662
		[Token(Token = "0x403C386")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _keepTime;

		// Token: 0x0403C387 RID: 246663
		[Token(Token = "0x403C387")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403C388 RID: 246664
		[Token(Token = "0x403C388")]
		[FieldOffset(Offset = "0x68")]
		private Act38SideBattleManager m_envManager;

		// Token: 0x0403C389 RID: 246665
		[Token(Token = "0x403C389")]
		[FieldOffset(Offset = "0x70")]
		[Inspect]
		[ReadOnly]
		private Act38sideUIPlugin.Act38sideUIPluginStateEnum m_state;

		// Token: 0x0403C38A RID: 246666
		[Token(Token = "0x403C38A")]
		[FieldOffset(Offset = "0x74")]
		private bool m_isDuringCarnival;

		// Token: 0x0403C38B RID: 246667
		[Token(Token = "0x403C38B")]
		[FieldOffset(Offset = "0x75")]
		private bool m_hasGameStarted;

		// Token: 0x0403C38C RID: 246668
		[Token(Token = "0x403C38C")]
		[FieldOffset(Offset = "0x76")]
		private bool m_isValid;

		// Token: 0x0403C38D RID: 246669
		[Token(Token = "0x403C38D")]
		[FieldOffset(Offset = "0x78")]
		private int m_allyCnt;

		// Token: 0x0403C38E RID: 246670
		[Token(Token = "0x403C38E")]
		[FieldOffset(Offset = "0x7C")]
		private int m_bossCnt;

		// Token: 0x0403C38F RID: 246671
		[Token(Token = "0x403C38F")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_animTween;

		// Token: 0x0403C390 RID: 246672
		[Token(Token = "0x403C390")]
		private const string START_ANIM = "act38side_fireworks_battle_ui_in";

		// Token: 0x0403C391 RID: 246673
		[Token(Token = "0x403C391")]
		private const string BOSS_WIN_ANIM = "act38side_fireworks_battle_ui_enemy_win";

		// Token: 0x0403C392 RID: 246674
		[Token(Token = "0x403C392")]
		private const string ALLY_WIN_ANIM = "act38side_fireworks_battle_ui_mine_win";

		// Token: 0x0403C393 RID: 246675
		[Token(Token = "0x403C393")]
		private const string BOSS_KILLED_ANIM = "act38side_fireworks_battle_ui_kill_win";

		// Token: 0x0403C394 RID: 246676
		[Token(Token = "0x403C394")]
		private const string END_ANIM = "act38side_fireworks_battle_ui_out";

		// Token: 0x0403C395 RID: 246677
		[Token(Token = "0x403C395")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_allyKillCnt;

		// Token: 0x0403C396 RID: 246678
		[Token(Token = "0x403C396")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_bossKillCnt;

		// Token: 0x0403C397 RID: 246679
		[Token(Token = "0x403C397")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0403C398 RID: 246680
		[Token(Token = "0x403C398")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0403C399 RID: 246681
		[Token(Token = "0x403C399")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x0403C39A RID: 246682
		[Token(Token = "0x403C39A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckAllResourcesValid;

		// Token: 0x0403C39B RID: 246683
		[Token(Token = "0x403C39B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitAllMembers;

		// Token: 0x0403C39C RID: 246684
		[Token(Token = "0x403C39C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnCarnivalStateChanged;

		// Token: 0x0403C39D RID: 246685
		[Token(Token = "0x403C39D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SwitchState;

		// Token: 0x0403C39E RID: 246686
		[Token(Token = "0x403C39E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnCarnivalStart;

		// Token: 0x0403C39F RID: 246687
		[Token(Token = "0x403C39F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnAllyWin;

		// Token: 0x0403C3A0 RID: 246688
		[Token(Token = "0x403C3A0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnBossWin;

		// Token: 0x0403C3A1 RID: 246689
		[Token(Token = "0x403C3A1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnBossKilled;

		// Token: 0x0403C3A2 RID: 246690
		[Token(Token = "0x403C3A2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SwitchToEndState;

		// Token: 0x0403C3A3 RID: 246691
		[Token(Token = "0x403C3A3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnCarnivalEnd;

		// Token: 0x0403C3A4 RID: 246692
		[Token(Token = "0x403C3A4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200743D RID: 29757
		[Token(Token = "0x200743D")]
		private enum Act38sideUIPluginStateEnum
		{
			// Token: 0x0403C3A6 RID: 246694
			[Token(Token = "0x403C3A6")]
			OFF,
			// Token: 0x0403C3A7 RID: 246695
			[Token(Token = "0x403C3A7")]
			START,
			// Token: 0x0403C3A8 RID: 246696
			[Token(Token = "0x403C3A8")]
			END,
			// Token: 0x0403C3A9 RID: 246697
			[Token(Token = "0x403C3A9")]
			NO_LOOP,
			// Token: 0x0403C3AA RID: 246698
			[Token(Token = "0x403C3AA")]
			ALLY_WIN,
			// Token: 0x0403C3AB RID: 246699
			[Token(Token = "0x403C3AB")]
			BOSS_WIN,
			// Token: 0x0403C3AC RID: 246700
			[Token(Token = "0x403C3AC")]
			BOSS_KILLED
		}
	}
}
