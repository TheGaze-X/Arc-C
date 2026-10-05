using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.GameMode;
using Torappu.SocketNetwork.Connections;
using XLua;

namespace Torappu.UI.EnemyDuel.Service.Phase
{
	// Token: 0x02005099 RID: 20633
	[Token(Token = "0x2005099")]
	public class EnemyDuelServiceBattlePhase : EnemyDuelServicePhase
	{
		// Token: 0x17004755 RID: 18261
		// (get) Token: 0x0601E8AB RID: 125099 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E8AC RID: 125100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004755")]
		private IEnemyDuelServiceCore serviceCore
		{
			[Token(Token = "0x601E8AB")]
			[Address(RVA = "0x1842F00", Offset = "0x1841B00", VA = "0x181842F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601E8AC")]
			[Address(RVA = "0x1842F60", Offset = "0x1841B60", VA = "0x181842F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004756 RID: 18262
		// (get) Token: 0x0601E8AD RID: 125101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004756")]
		private GameModeFactory.EnemyDuelGameMode gameMode
		{
			[Token(Token = "0x601E8AD")]
			[Address(RVA = "0x1842DB0", Offset = "0x18419B0", VA = "0x181842DB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E8AE RID: 125102 RVA: 0x000AEC90 File Offset: 0x000ACE90
		[Token(Token = "0x601E8AE")]
		[Address(RVA = "0x18425F0", Offset = "0x18411F0", VA = "0x1818425F0")]
		private float _GetWaiteFrameTime()
		{
			return 0f;
		}

		// Token: 0x0601E8AF RID: 125103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8AF")]
		[Address(RVA = "0x1840C00", Offset = "0x183F800", VA = "0x181840C00", Slot = "4")]
		public override void Enter(IEnemyDuelServiceCore core)
		{
		}

		// Token: 0x0601E8B0 RID: 125104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8B0")]
		[Address(RVA = "0x1842660", Offset = "0x1841260", VA = "0x181842660")]
		private void _HandleRoundChanged(object args)
		{
		}

		// Token: 0x0601E8B1 RID: 125105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8B1")]
		[Address(RVA = "0x18427B0", Offset = "0x18413B0", VA = "0x1818427B0")]
		private void _HandleStateChanged(object args)
		{
		}

		// Token: 0x0601E8B2 RID: 125106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8B2")]
		[Address(RVA = "0x1841740", Offset = "0x1840340", VA = "0x181841740", Slot = "5")]
		public override void Leave()
		{
		}

		// Token: 0x0601E8B3 RID: 125107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8B3")]
		[Address(RVA = "0x1841DB0", Offset = "0x18409B0", VA = "0x181841DB0")]
		private void _ClearCachedSteps()
		{
		}

		// Token: 0x0601E8B4 RID: 125108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8B4")]
		[Address(RVA = "0x18428F0", Offset = "0x18414F0", VA = "0x1818428F0")]
		private void _NotifyLoadComplete()
		{
		}

		// Token: 0x0601E8B5 RID: 125109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8B5")]
		[Address(RVA = "0x18411F0", Offset = "0x183FDF0", VA = "0x1818411F0", Slot = "6")]
		public override void FixedUpdate()
		{
		}

		// Token: 0x0601E8B6 RID: 125110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8B6")]
		[Address(RVA = "0x1841850", Offset = "0x1840450", VA = "0x181841850", Slot = "8")]
		public override void OnNetStateChanged(ConnectionState state)
		{
		}

		// Token: 0x0601E8B7 RID: 125111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8B7")]
		[Address(RVA = "0x18418C0", Offset = "0x18404C0", VA = "0x1818418C0")]
		public void RevStepDate(EnemyDuelServiceStepData step)
		{
		}

		// Token: 0x0601E8B8 RID: 125112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8B8")]
		[Address(RVA = "0x1842A20", Offset = "0x1841620", VA = "0x181842A20")]
		private void _PreserveTo(int frameCount)
		{
		}

		// Token: 0x0601E8B9 RID: 125113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8B9")]
		[Address(RVA = "0x1841CA0", Offset = "0x18408A0", VA = "0x181841CA0")]
		private void _ChangeStatus(EnemyDuelServiceBattleNetState cur)
		{
		}

		// Token: 0x0601E8BA RID: 125114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8BA")]
		[Address(RVA = "0x1841B00", Offset = "0x1840700", VA = "0x181841B00")]
		private void _AdjustPlaySpeed(float speed)
		{
		}

		// Token: 0x0601E8BB RID: 125115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8BB")]
		[Address(RVA = "0x1842AA0", Offset = "0x18416A0", VA = "0x181842AA0")]
		private void _RefreshPlaySpeed()
		{
		}

		// Token: 0x0601E8BC RID: 125116 RVA: 0x000AECA8 File Offset: 0x000ACEA8
		[Token(Token = "0x601E8BC")]
		[Address(RVA = "0x1841C20", Offset = "0x1840820", VA = "0x181841C20")]
		private int _CalculateRemainFrame()
		{
			return 0;
		}

		// Token: 0x0601E8BD RID: 125117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8BD")]
		[Address(RVA = "0x1841B90", Offset = "0x1840790", VA = "0x181841B90")]
		private void _ApplyStepSetting(EnemyDuelServiceStepData step)
		{
		}

		// Token: 0x0601E8BE RID: 125118 RVA: 0x000AECC0 File Offset: 0x000ACEC0
		[Token(Token = "0x601E8BE")]
		[Address(RVA = "0x1841F40", Offset = "0x1840B40", VA = "0x181841F40")]
		private bool _DoBattleStart(StageData stageData, BattleStageInfo overrideStageInfo, EnemyDuelServiceParam actParam, EnemyDuelServiceBattleInfo battle, GameModeMeta gameModeMeta, bool isMulti)
		{
			return default(bool);
		}

		// Token: 0x0601E8BF RID: 125119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8BF")]
		[Address(RVA = "0x1842CF0", Offset = "0x18418F0", VA = "0x181842CF0")]
		public EnemyDuelServiceBattlePhase()
		{
		}

		// Token: 0x0601E8C0 RID: 125120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8C0")]
		[Address(RVA = "0x1841A40", Offset = "0x1840640", VA = "0x181841A40")]
		private void <>xLuaBaseProxy_FixedUpdate()
		{
		}

		// Token: 0x0601E8C1 RID: 125121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8C1")]
		[Address(RVA = "0x1841AA0", Offset = "0x18406A0", VA = "0x181841AA0")]
		private void <>xLuaBaseProxy_OnNetStateChanged(ConnectionState P0)
		{
		}

		// Token: 0x04028EC6 RID: 167622
		[Token(Token = "0x4028EC6")]
		private const int INITIAL_PRESERVE_CNT = 2;

		// Token: 0x04028EC7 RID: 167623
		[Token(Token = "0x4028EC7")]
		[FieldOffset(Offset = "0x10")]
		private Queue<EnemyDuelServiceStepData> m_cachedSteps;

		// Token: 0x04028EC8 RID: 167624
		[Token(Token = "0x4028EC8")]
		[FieldOffset(Offset = "0x18")]
		private int m_preserveCnt;

		// Token: 0x04028EC9 RID: 167625
		[Token(Token = "0x4028EC9")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_receivedStep;

		// Token: 0x04028ECA RID: 167626
		[Token(Token = "0x4028ECA")]
		[FieldOffset(Offset = "0x20")]
		private uint m_receivedStepNotified;

		// Token: 0x04028ECB RID: 167627
		[Token(Token = "0x4028ECB")]
		[FieldOffset(Offset = "0x24")]
		private float m_playSpeed;

		// Token: 0x04028ECC RID: 167628
		[Token(Token = "0x4028ECC")]
		[FieldOffset(Offset = "0x28")]
		private float m_playFramesPerTime;

		// Token: 0x04028ECD RID: 167629
		[Token(Token = "0x4028ECD")]
		[FieldOffset(Offset = "0x2C")]
		private int m_stride;

		// Token: 0x04028ECE RID: 167630
		[Token(Token = "0x4028ECE")]
		[FieldOffset(Offset = "0x30")]
		private int m_leftFrameInStep;

		// Token: 0x04028ECF RID: 167631
		[Token(Token = "0x4028ECF")]
		[FieldOffset(Offset = "0x34")]
		private int m_leftFrameInStepInFast;

		// Token: 0x04028ED0 RID: 167632
		[Token(Token = "0x4028ED0")]
		[FieldOffset(Offset = "0x38")]
		private float m_idleStartTime;

		// Token: 0x04028ED2 RID: 167634
		[Token(Token = "0x4028ED2")]
		[FieldOffset(Offset = "0x48")]
		private EnemyDuelService.Setting m_setting;

		// Token: 0x04028ED3 RID: 167635
		[Token(Token = "0x4028ED3")]
		[FieldOffset(Offset = "0x68")]
		private EnemyDuelServiceBattleNetState m_battleNetState;

		// Token: 0x04028ED4 RID: 167636
		[Token(Token = "0x4028ED4")]
		[FieldOffset(Offset = "0x70")]
		private GameModeFactory.EnemyDuelGameMode m_gameMode;

		// Token: 0x04028ED5 RID: 167637
		[Token(Token = "0x4028ED5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCore;

		// Token: 0x04028ED6 RID: 167638
		[Token(Token = "0x4028ED6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_serviceCore;

		// Token: 0x04028ED7 RID: 167639
		[Token(Token = "0x4028ED7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x04028ED8 RID: 167640
		[Token(Token = "0x4028ED8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetWaiteFrameTime;

		// Token: 0x04028ED9 RID: 167641
		[Token(Token = "0x4028ED9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Enter;

		// Token: 0x04028EDA RID: 167642
		[Token(Token = "0x4028EDA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HandleRoundChanged;

		// Token: 0x04028EDB RID: 167643
		[Token(Token = "0x4028EDB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleStateChanged;

		// Token: 0x04028EDC RID: 167644
		[Token(Token = "0x4028EDC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Leave;

		// Token: 0x04028EDD RID: 167645
		[Token(Token = "0x4028EDD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearCachedSteps;

		// Token: 0x04028EDE RID: 167646
		[Token(Token = "0x4028EDE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__NotifyLoadComplete;

		// Token: 0x04028EDF RID: 167647
		[Token(Token = "0x4028EDF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x04028EE0 RID: 167648
		[Token(Token = "0x4028EE0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnNetStateChanged;

		// Token: 0x04028EE1 RID: 167649
		[Token(Token = "0x4028EE1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RevStepDate;

		// Token: 0x04028EE2 RID: 167650
		[Token(Token = "0x4028EE2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PreserveTo;

		// Token: 0x04028EE3 RID: 167651
		[Token(Token = "0x4028EE3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ChangeStatus;

		// Token: 0x04028EE4 RID: 167652
		[Token(Token = "0x4028EE4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__AdjustPlaySpeed;

		// Token: 0x04028EE5 RID: 167653
		[Token(Token = "0x4028EE5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RefreshPlaySpeed;

		// Token: 0x04028EE6 RID: 167654
		[Token(Token = "0x4028EE6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CalculateRemainFrame;

		// Token: 0x04028EE7 RID: 167655
		[Token(Token = "0x4028EE7")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ApplyStepSetting;

		// Token: 0x04028EE8 RID: 167656
		[Token(Token = "0x4028EE8")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__DoBattleStart;

		// Token: 0x04028EE9 RID: 167657
		[Token(Token = "0x4028EE9")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
