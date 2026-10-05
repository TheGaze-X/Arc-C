using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.SocketNetwork.SvrCom;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063E1 RID: 25569
	[Token(Token = "0x20063E1")]
	public class AutoChessServiceBattlePhase : AutoChessServicePhase, IServerStepModeHost, IAutoChessServiceStepReceiver
	{
		// Token: 0x1700571E RID: 22302
		// (get) Token: 0x06024DF4 RID: 151028 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024DF5 RID: 151029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700571E")]
		private IAutoChessServiceCore serviceCore
		{
			[Token(Token = "0x6024DF4")]
			[Address(RVA = "0x1FBE760", Offset = "0x1FBD360", VA = "0x181FBE760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024DF5")]
			[Address(RVA = "0x1FBE7C0", Offset = "0x1FBD3C0", VA = "0x181FBE7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700571F RID: 22303
		// (get) Token: 0x06024DF6 RID: 151030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700571F")]
		private AutoChessGameManager gameManager
		{
			[Token(Token = "0x6024DF6")]
			[Address(RVA = "0x1FBE6C0", Offset = "0x1FBD2C0", VA = "0x181FBE6C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024DF7 RID: 151031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DF7")]
		[Address(RVA = "0x1FBDAD0", Offset = "0x1FBC6D0", VA = "0x181FBDAD0", Slot = "4")]
		public override void Enter(IAutoChessServiceCore core)
		{
		}

		// Token: 0x06024DF8 RID: 151032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DF8")]
		[Address(RVA = "0x1FBDFA0", Offset = "0x1FBCBA0", VA = "0x181FBDFA0", Slot = "5")]
		public override void Leave()
		{
		}

		// Token: 0x06024DF9 RID: 151033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DF9")]
		[Address(RVA = "0x1FBDD80", Offset = "0x1FBC980", VA = "0x181FBDD80", Slot = "6")]
		public override void FixedUpdate()
		{
		}

		// Token: 0x06024DFA RID: 151034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DFA")]
		[Address(RVA = "0x1FBE2B0", Offset = "0x1FBCEB0", VA = "0x181FBE2B0", Slot = "14")]
		public void RevStep(AutoChessBattleStepData step)
		{
		}

		// Token: 0x06024DFB RID: 151035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DFB")]
		[Address(RVA = "0x1FBE250", Offset = "0x1FBCE50", VA = "0x181FBE250", Slot = "15")]
		public void ResetStep()
		{
		}

		// Token: 0x06024DFC RID: 151036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024DFC")]
		[Address(RVA = "0x1FBE5A0", Offset = "0x1FBD1A0", VA = "0x181FBE5A0")]
		private void _ClearCachedSteps()
		{
		}

		// Token: 0x06024DFD RID: 151037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024DFD")]
		[Address(RVA = "0x1FBDF40", Offset = "0x1FBCB40", VA = "0x181FBDF40", Slot = "8")]
		public ServerStepModeHelper.SettingData GetSetting()
		{
			return null;
		}

		// Token: 0x06024DFE RID: 151038 RVA: 0x000C5BC8 File Offset: 0x000C3DC8
		[Token(Token = "0x6024DFE")]
		[Address(RVA = "0x1FBDE40", Offset = "0x1FBCA40", VA = "0x181FBDE40", Slot = "9")]
		public float GetPing()
		{
			return 0f;
		}

		// Token: 0x06024DFF RID: 151039 RVA: 0x000C5BE0 File Offset: 0x000C3DE0
		[Token(Token = "0x6024DFF")]
		[Address(RVA = "0x1FBE000", Offset = "0x1FBCC00", VA = "0x181FBE000", Slot = "10")]
		public bool NextFrame(bool additional)
		{
			return default(bool);
		}

		// Token: 0x06024E00 RID: 151040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E00")]
		[Address(RVA = "0x1FBE390", Offset = "0x1FBCF90", VA = "0x181FBE390", Slot = "11")]
		public void UpdateStep(ServerStepModeHelper.IStepData stepData)
		{
		}

		// Token: 0x06024E01 RID: 151041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E01")]
		[Address(RVA = "0x1FBE110", Offset = "0x1FBCD10", VA = "0x181FBE110", Slot = "12")]
		public void ReleaseStepData(ServerStepModeHelper.IStepData stepData)
		{
		}

		// Token: 0x06024E02 RID: 151042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E02")]
		[Address(RVA = "0x1FBE090", Offset = "0x1FBCC90", VA = "0x181FBE090", Slot = "13")]
		public void OnRefreshSpeed(float currentSpeed, float curDelayTime)
		{
		}

		// Token: 0x06024E03 RID: 151043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E03")]
		[Address(RVA = "0x1FBE620", Offset = "0x1FBD220", VA = "0x181FBE620")]
		public AutoChessServiceBattlePhase()
		{
		}

		// Token: 0x06024E04 RID: 151044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E04")]
		[Address(RVA = "0x1FBE330", Offset = "0x1FBCF30", VA = "0x181FBE330")]
		private void <>xLuaBaseProxy_FixedUpdate()
		{
		}

		// Token: 0x0403389D RID: 211101
		[Token(Token = "0x403389D")]
		[FieldOffset(Offset = "0x18")]
		private ServerStepModeHelper.SettingData m_settingData;

		// Token: 0x0403389E RID: 211102
		[Token(Token = "0x403389E")]
		[FieldOffset(Offset = "0x20")]
		private AutoChessGameManager m_gameManager;

		// Token: 0x0403389F RID: 211103
		[Token(Token = "0x403389F")]
		[FieldOffset(Offset = "0x28")]
		private ServerStepModeHelper m_serverStepModeHelper;

		// Token: 0x040338A0 RID: 211104
		[Token(Token = "0x40338A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCore;

		// Token: 0x040338A1 RID: 211105
		[Token(Token = "0x40338A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_serviceCore;

		// Token: 0x040338A2 RID: 211106
		[Token(Token = "0x40338A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_gameManager;

		// Token: 0x040338A3 RID: 211107
		[Token(Token = "0x40338A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Enter;

		// Token: 0x040338A4 RID: 211108
		[Token(Token = "0x40338A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Leave;

		// Token: 0x040338A5 RID: 211109
		[Token(Token = "0x40338A5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x040338A6 RID: 211110
		[Token(Token = "0x40338A6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RevStep;

		// Token: 0x040338A7 RID: 211111
		[Token(Token = "0x40338A7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetStep;

		// Token: 0x040338A8 RID: 211112
		[Token(Token = "0x40338A8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearCachedSteps;

		// Token: 0x040338A9 RID: 211113
		[Token(Token = "0x40338A9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetSetting;

		// Token: 0x040338AA RID: 211114
		[Token(Token = "0x40338AA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetPing;

		// Token: 0x040338AB RID: 211115
		[Token(Token = "0x40338AB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_NextFrame;

		// Token: 0x040338AC RID: 211116
		[Token(Token = "0x40338AC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateStep;

		// Token: 0x040338AD RID: 211117
		[Token(Token = "0x40338AD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ReleaseStepData;

		// Token: 0x040338AE RID: 211118
		[Token(Token = "0x40338AE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnRefreshSpeed;

		// Token: 0x040338AF RID: 211119
		[Token(Token = "0x40338AF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
