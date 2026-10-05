using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.GameMode;
using Torappu.Multiplayer.Servers;
using Torappu.SocketNetwork.Connections;
using XLua;

namespace Torappu.Multiplayer
{
	// Token: 0x0200152C RID: 5420
	[Token(Token = "0x200152C")]
	public class BattlePhase : MultiBattlePhase
	{
		// Token: 0x06007C66 RID: 31846 RVA: 0x000374E8 File Offset: 0x000356E8
		[Token(Token = "0x6007C66")]
		[Address(RVA = "0x27378C0", Offset = "0x27364C0", VA = "0x1827378C0")]
		private float _GetWaiteFrameTime()
		{
			return 0f;
		}

		// Token: 0x06007C67 RID: 31847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C67")]
		[Address(RVA = "0x2735EE0", Offset = "0x2734AE0", VA = "0x182735EE0", Slot = "5")]
		public override void Enter()
		{
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C68")]
		[Address(RVA = "0x2737A30", Offset = "0x2736630", VA = "0x182737A30")]
		private void _RealBattleStart(StageData stageData, MultiplayerInput multiplayerInput, BattleStageInfo overrideStageInfo, MultiplayerActParam actParam, BattleInfo battle, GameModeMeta gameModeMeta)
		{
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C69")]
		[Address(RVA = "0x2738380", Offset = "0x2736F80", VA = "0x182738380")]
		private void _ReplayBattleStart(StageData stageData, BattleStageInfo stageInfo, MultiplayerActParam actParam, GameModeMeta gameModeMeta)
		{
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C6A")]
		[Address(RVA = "0x2736F20", Offset = "0x2735B20", VA = "0x182736F20", Slot = "6")]
		public override void Leave()
		{
		}

		// Token: 0x06007C6B RID: 31851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C6B")]
		[Address(RVA = "0x27375B0", Offset = "0x27361B0", VA = "0x1827375B0")]
		private List<RuneTable.PackedRuneData> _CreatePackedRuneData(MultiplayerInput multiplayerInput, MultiplayerActParam actParam)
		{
			return null;
		}

		// Token: 0x06007C6C RID: 31852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C6C")]
		[Address(RVA = "0x2738A20", Offset = "0x2737620", VA = "0x182738A20")]
		private MultiplayerSquadData _TryParsePlayerData(BattleProtocol.SceneJoinRet.UserInfo player)
		{
			return null;
		}

		// Token: 0x06007C6D RID: 31853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C6D")]
		[Address(RVA = "0x2737930", Offset = "0x2736530", VA = "0x182737930")]
		private void _NotifyLoadComplete()
		{
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C6E")]
		[Address(RVA = "0x27368F0", Offset = "0x27354F0", VA = "0x1827368F0", Slot = "4")]
		public override void FixedUpdate()
		{
		}

		// Token: 0x06007C6F RID: 31855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C6F")]
		[Address(RVA = "0x2737030", Offset = "0x2735C30", VA = "0x182737030", Slot = "8")]
		public override void OnNetStateChanged(ConnectionState state)
		{
		}

		// Token: 0x06007C70 RID: 31856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C70")]
		[Address(RVA = "0x27370A0", Offset = "0x2735CA0", VA = "0x1827370A0")]
		public void RevStepDate(StepData step)
		{
		}

		// Token: 0x06007C71 RID: 31857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C71")]
		[Address(RVA = "0x27379B0", Offset = "0x27365B0", VA = "0x1827379B0")]
		private void _PreserveTo(int frameCount)
		{
		}

		// Token: 0x06007C72 RID: 31858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C72")]
		[Address(RVA = "0x2737440", Offset = "0x2736040", VA = "0x182737440")]
		private void _ChangeStatus(GameBattleStatus cur)
		{
		}

		// Token: 0x06007C73 RID: 31859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C73")]
		[Address(RVA = "0x27371D0", Offset = "0x2735DD0", VA = "0x1827371D0")]
		private void _AdjustPlaySpeed(float speed)
		{
		}

		// Token: 0x06007C74 RID: 31860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C74")]
		[Address(RVA = "0x2738110", Offset = "0x2736D10", VA = "0x182738110")]
		private void _RefreshPlaySpeed()
		{
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x00037500 File Offset: 0x00035700
		[Token(Token = "0x6007C75")]
		[Address(RVA = "0x27373C0", Offset = "0x2735FC0", VA = "0x1827373C0")]
		private int _CalculateRemainFrame()
		{
			return 0;
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C76")]
		[Address(RVA = "0x2737260", Offset = "0x2735E60", VA = "0x182737260")]
		private void _ApplyStepSetting(StepData step)
		{
		}

		// Token: 0x06007C77 RID: 31863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C77")]
		[Address(RVA = "0x2738DF0", Offset = "0x27379F0", VA = "0x182738DF0")]
		public BattlePhase()
		{
		}

		// Token: 0x06007C78 RID: 31864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C78")]
		[Address(RVA = "0x27371B0", Offset = "0x2735DB0", VA = "0x1827371B0")]
		private void <>xLuaBaseProxy_FixedUpdate()
		{
		}

		// Token: 0x06007C79 RID: 31865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C79")]
		[Address(RVA = "0x27371C0", Offset = "0x2735DC0", VA = "0x1827371C0")]
		private void <>xLuaBaseProxy_OnNetStateChanged(ConnectionState P0)
		{
		}

		// Token: 0x04007C48 RID: 31816
		[Token(Token = "0x4007C48")]
		private const int INITIAL_PRESERVE_CNT = 2;

		// Token: 0x04007C49 RID: 31817
		[Token(Token = "0x4007C49")]
		[FieldOffset(Offset = "0x10")]
		private Queue<StepData> m_cachedSteps;

		// Token: 0x04007C4A RID: 31818
		[Token(Token = "0x4007C4A")]
		[FieldOffset(Offset = "0x18")]
		private int m_preserveCnt;

		// Token: 0x04007C4B RID: 31819
		[Token(Token = "0x4007C4B")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_receivedStep;

		// Token: 0x04007C4C RID: 31820
		[Token(Token = "0x4007C4C")]
		[FieldOffset(Offset = "0x20")]
		private uint m_receivedStepNotified;

		// Token: 0x04007C4D RID: 31821
		[Token(Token = "0x4007C4D")]
		[FieldOffset(Offset = "0x24")]
		private float m_playSpeed;

		// Token: 0x04007C4E RID: 31822
		[Token(Token = "0x4007C4E")]
		[FieldOffset(Offset = "0x28")]
		private float m_playFramesOnce;

		// Token: 0x04007C4F RID: 31823
		[Token(Token = "0x4007C4F")]
		[FieldOffset(Offset = "0x2C")]
		private int m_stride;

		// Token: 0x04007C50 RID: 31824
		[Token(Token = "0x4007C50")]
		[FieldOffset(Offset = "0x30")]
		private int m_leftFrameInStep;

		// Token: 0x04007C51 RID: 31825
		[Token(Token = "0x4007C51")]
		[FieldOffset(Offset = "0x34")]
		private int m_leftFrameInStepInFast;

		// Token: 0x04007C52 RID: 31826
		[Token(Token = "0x4007C52")]
		[FieldOffset(Offset = "0x38")]
		private float m_idleStartTime;

		// Token: 0x04007C53 RID: 31827
		[Token(Token = "0x4007C53")]
		[FieldOffset(Offset = "0x40")]
		private MultiplayerActParam.MultiplayerSetting m_setting;

		// Token: 0x04007C54 RID: 31828
		[Token(Token = "0x4007C54")]
		[FieldOffset(Offset = "0x60")]
		private IMultiplayerGameMode m_gameMode;

		// Token: 0x04007C55 RID: 31829
		[Token(Token = "0x4007C55")]
		[FieldOffset(Offset = "0x68")]
		private GameModeFactory.CooperateGameMode m_coopGameMode;

		// Token: 0x04007C56 RID: 31830
		[Token(Token = "0x4007C56")]
		[FieldOffset(Offset = "0x70")]
		private GameBattleStatus m_status;

		// Token: 0x04007C57 RID: 31831
		[Token(Token = "0x4007C57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetWaiteFrameTime;

		// Token: 0x04007C58 RID: 31832
		[Token(Token = "0x4007C58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Enter;

		// Token: 0x04007C59 RID: 31833
		[Token(Token = "0x4007C59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RealBattleStart;

		// Token: 0x04007C5A RID: 31834
		[Token(Token = "0x4007C5A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ReplayBattleStart;

		// Token: 0x04007C5B RID: 31835
		[Token(Token = "0x4007C5B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Leave;

		// Token: 0x04007C5C RID: 31836
		[Token(Token = "0x4007C5C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreatePackedRuneData;

		// Token: 0x04007C5D RID: 31837
		[Token(Token = "0x4007C5D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryParsePlayerData;

		// Token: 0x04007C5E RID: 31838
		[Token(Token = "0x4007C5E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__NotifyLoadComplete;

		// Token: 0x04007C5F RID: 31839
		[Token(Token = "0x4007C5F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x04007C60 RID: 31840
		[Token(Token = "0x4007C60")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnNetStateChanged;

		// Token: 0x04007C61 RID: 31841
		[Token(Token = "0x4007C61")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RevStepDate;

		// Token: 0x04007C62 RID: 31842
		[Token(Token = "0x4007C62")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PreserveTo;

		// Token: 0x04007C63 RID: 31843
		[Token(Token = "0x4007C63")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ChangeStatus;

		// Token: 0x04007C64 RID: 31844
		[Token(Token = "0x4007C64")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__AdjustPlaySpeed;

		// Token: 0x04007C65 RID: 31845
		[Token(Token = "0x4007C65")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RefreshPlaySpeed;

		// Token: 0x04007C66 RID: 31846
		[Token(Token = "0x4007C66")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CalculateRemainFrame;

		// Token: 0x04007C67 RID: 31847
		[Token(Token = "0x4007C67")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ApplyStepSetting;

		// Token: 0x04007C68 RID: 31848
		[Token(Token = "0x4007C68")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
