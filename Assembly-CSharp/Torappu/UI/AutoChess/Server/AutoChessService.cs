using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork.ServerBase;
using Torappu.SocketNetwork.SvrCom;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063CD RID: 25549
	[Token(Token = "0x20063CD")]
	public class AutoChessService : ServiceBase<AutoChessService, AutoChessServiceEvent>
	{
		// Token: 0x06024D64 RID: 150884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D64")]
		[Address(RVA = "0x1FC1D60", Offset = "0x1FC0960", VA = "0x181FC1D60")]
		public static void Start(CommonJoinEntry entry, AutoChessServiceParam param)
		{
		}

		// Token: 0x06024D65 RID: 150885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D65")]
		[Address(RVA = "0x1FC1B60", Offset = "0x1FC0760", VA = "0x181FC1B60")]
		public static void StartTraining(AutoChessServiceParam param, Action<bool> onJoinDone)
		{
		}

		// Token: 0x06024D66 RID: 150886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D66")]
		[Address(RVA = "0x1FC1990", Offset = "0x1FC0590", VA = "0x181FC1990")]
		public static void StartReconnectBattle(CommonJoinEntry entry, AutoChessServiceParam param)
		{
		}

		// Token: 0x06024D67 RID: 150887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D67")]
		[Address(RVA = "0x1FC16A0", Offset = "0x1FC02A0", VA = "0x181FC16A0")]
		public static void SendRequest(RequestHandler request)
		{
		}

		// Token: 0x06024D68 RID: 150888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D68")]
		[Address(RVA = "0x1FC1830", Offset = "0x1FC0430", VA = "0x181FC1830")]
		public static void SendRequest(AutoChessServiceRequest request)
		{
		}

		// Token: 0x06024D69 RID: 150889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024D69")]
		public static TRequest RentRequestForSend<TRequest>() where TRequest : AutoChessServiceRequest, new()
		{
			return null;
		}

		// Token: 0x170056FC RID: 22268
		// (get) Token: 0x06024D6A RID: 150890 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024D6B RID: 150891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056FC")]
		public AutoChessServiceParam param
		{
			[Token(Token = "0x6024D6A")]
			[Address(RVA = "0x1FC22C0", Offset = "0x1FC0EC0", VA = "0x181FC22C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024D6B")]
			[Address(RVA = "0x1FC24F0", Offset = "0x1FC10F0", VA = "0x181FC24F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170056FD RID: 22269
		// (get) Token: 0x06024D6C RID: 150892 RVA: 0x000C59D0 File Offset: 0x000C3BD0
		[Token(Token = "0x170056FD")]
		public AutoChessService.Setting setting
		{
			[Token(Token = "0x6024D6C")]
			[Address(RVA = "0x1FC23A0", Offset = "0x1FC0FA0", VA = "0x181FC23A0")]
			get
			{
				return default(AutoChessService.Setting);
			}
		}

		// Token: 0x170056FE RID: 22270
		// (get) Token: 0x06024D6D RID: 150893 RVA: 0x000C59E8 File Offset: 0x000C3BE8
		[Token(Token = "0x170056FE")]
		public int ping
		{
			[Token(Token = "0x6024D6D")]
			[Address(RVA = "0x1FC2320", Offset = "0x1FC0F20", VA = "0x181FC2320")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170056FF RID: 22271
		// (get) Token: 0x06024D6E RID: 150894 RVA: 0x000C5A00 File Offset: 0x000C3C00
		[Token(Token = "0x170056FF")]
		public DateTime currentTime
		{
			[Token(Token = "0x6024D6E")]
			[Address(RVA = "0x1FC21B0", Offset = "0x1FC0DB0", VA = "0x181FC21B0")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17005700 RID: 22272
		// (get) Token: 0x06024D6F RID: 150895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005700")]
		public AutoChessServiceTeamInfo teamInfo
		{
			[Token(Token = "0x6024D6F")]
			[Address(RVA = "0x1FC2470", Offset = "0x1FC1070", VA = "0x181FC2470")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005701 RID: 22273
		// (get) Token: 0x06024D70 RID: 150896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005701")]
		public AutoChessServiceBattleInfo battleInfo
		{
			[Token(Token = "0x6024D70")]
			[Address(RVA = "0x1FC2130", Offset = "0x1FC0D30", VA = "0x181FC2130")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024D71 RID: 150897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D71")]
		[Address(RVA = "0x1FC2060", Offset = "0x1FC0C60", VA = "0x181FC2060")]
		private AutoChessService()
		{
		}

		// Token: 0x06024D72 RID: 150898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D72")]
		[Address(RVA = "0x1FC1360", Offset = "0x1FBFF60", VA = "0x181FC1360", Slot = "8")]
		protected override void OnDispose()
		{
		}

		// Token: 0x06024D73 RID: 150899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D73")]
		[Address(RVA = "0x1FC1F10", Offset = "0x1FC0B10", VA = "0x181FC1F10")]
		private void _RefreshStatus()
		{
		}

		// Token: 0x06024D74 RID: 150900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D74")]
		[Address(RVA = "0x1FC1620", Offset = "0x1FC0220", VA = "0x181FC1620", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06024D75 RID: 150901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D75")]
		[Address(RVA = "0x1FC1500", Offset = "0x1FC0100", VA = "0x181FC1500", Slot = "6")]
		protected override void OnFixedUpdate()
		{
		}

		// Token: 0x06024D76 RID: 150902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D76")]
		[Address(RVA = "0x1FC1590", Offset = "0x1FC0190", VA = "0x181FC1590", Slot = "7")]
		protected override void OnGUI()
		{
		}

		// Token: 0x06024D77 RID: 150903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024D77")]
		private T _ChangePhase<T>() where T : AutoChessServicePhase, new()
		{
			return null;
		}

		// Token: 0x06024D78 RID: 150904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024D78")]
		private T _CheckMode<T>() where T : class, IAutoChessServiceMode, new()
		{
			return null;
		}

		// Token: 0x06024D79 RID: 150905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D79")]
		[Address(RVA = "0x1FC1F00", Offset = "0x1FC0B00", VA = "0x181FC1F00")]
		private void <>xLuaBaseProxy_OnUpdate()
		{
		}

		// Token: 0x06024D7A RID: 150906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D7A")]
		[Address(RVA = "0x1FC1EE0", Offset = "0x1FC0AE0", VA = "0x181FC1EE0")]
		private void <>xLuaBaseProxy_OnFixedUpdate()
		{
		}

		// Token: 0x06024D7B RID: 150907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D7B")]
		[Address(RVA = "0x1FC1EF0", Offset = "0x1FC0AF0", VA = "0x181FC1EF0")]
		private void <>xLuaBaseProxy_OnGUI()
		{
		}

		// Token: 0x04033809 RID: 210953
		[Token(Token = "0x4033809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AutoChessServicePhase m_curPhase;

		// Token: 0x0403380A RID: 210954
		[Token(Token = "0x403380A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AutoChessService.Core m_coreImpl;

		// Token: 0x0403380B RID: 210955
		[Token(Token = "0x403380B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IAutoChessServiceMode m_mode;

		// Token: 0x0403380D RID: 210957
		[Token(Token = "0x403380D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0403380E RID: 210958
		[Token(Token = "0x403380E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StartTraining;

		// Token: 0x0403380F RID: 210959
		[Token(Token = "0x403380F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_StartReconnectBattle;

		// Token: 0x04033810 RID: 210960
		[Token(Token = "0x4033810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x04033811 RID: 210961
		[Token(Token = "0x4033811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_SendRequest;

		// Token: 0x04033812 RID: 210962
		[Token(Token = "0x4033812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RentRequestForSend;

		// Token: 0x04033813 RID: 210963
		[Token(Token = "0x4033813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_param;

		// Token: 0x04033814 RID: 210964
		[Token(Token = "0x4033814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_param;

		// Token: 0x04033815 RID: 210965
		[Token(Token = "0x4033815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_setting;

		// Token: 0x04033816 RID: 210966
		[Token(Token = "0x4033816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_ping;

		// Token: 0x04033817 RID: 210967
		[Token(Token = "0x4033817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x04033818 RID: 210968
		[Token(Token = "0x4033818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_teamInfo;

		// Token: 0x04033819 RID: 210969
		[Token(Token = "0x4033819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x0403381A RID: 210970
		[Token(Token = "0x403381A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403381B RID: 210971
		[Token(Token = "0x403381B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDispose;

		// Token: 0x0403381C RID: 210972
		[Token(Token = "0x403381C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RefreshStatus;

		// Token: 0x0403381D RID: 210973
		[Token(Token = "0x403381D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0403381E RID: 210974
		[Token(Token = "0x403381E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x0403381F RID: 210975
		[Token(Token = "0x403381F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnGUI;

		// Token: 0x04033820 RID: 210976
		[Token(Token = "0x4033820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ChangePhase;

		// Token: 0x04033821 RID: 210977
		[Token(Token = "0x4033821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CheckMode;

		// Token: 0x020063CE RID: 25550
		[Token(Token = "0x20063CE")]
		private class Core : IAutoChessServiceCore
		{
			// Token: 0x06024D7C RID: 150908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024D7C")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public Core(AutoChessService service)
			{
			}

			// Token: 0x06024D7D RID: 150909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024D7D")]
			[Address(RVA = "0x1FC3660", Offset = "0x1FC2260", VA = "0x181FC3660", Slot = "5")]
			public void RefreshStatus()
			{
			}

			// Token: 0x17005702 RID: 22274
			// (get) Token: 0x06024D7E RID: 150910 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005702")]
			public IAutoChessServiceStepReceiver stepReceiver
			{
				[Token(Token = "0x6024D7E")]
				[Address(RVA = "0x1FC38A0", Offset = "0x1FC24A0", VA = "0x181FC38A0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06024D7F RID: 150911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024D7F")]
			[Address(RVA = "0x1FC37C0", Offset = "0x1FC23C0", VA = "0x181FC37C0", Slot = "4")]
			public void TriggerEvent(AutoChessServiceEvent evt, [Optional] object args)
			{
			}

			// Token: 0x17005703 RID: 22275
			// (get) Token: 0x06024D80 RID: 150912 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005703")]
			public AutoChessServiceParam serviceParam
			{
				[Token(Token = "0x6024D80")]
				[Address(RVA = "0x1FC3830", Offset = "0x1FC2430", VA = "0x181FC3830", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04033822 RID: 210978
			[Token(Token = "0x4033822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private AutoChessService m_service;
		}

		// Token: 0x020063CF RID: 25551
		[Token(Token = "0x20063CF")]
		public struct Setting
		{
			// Token: 0x04033823 RID: 210979
			[Token(Token = "0x4033823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly AutoChessService.Setting Default;

			// Token: 0x04033824 RID: 210980
			[Token(Token = "0x4033824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int maxRetryTimeInTeam;

			// Token: 0x04033825 RID: 210981
			[Token(Token = "0x4033825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int maxRetryTimeInBattle;

			// Token: 0x04033826 RID: 210982
			[Token(Token = "0x4033826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float delayTimeNeedTip;

			// Token: 0x04033827 RID: 210983
			[Token(Token = "0x4033827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxPlaySpeed;

			// Token: 0x04033828 RID: 210984
			[Token(Token = "0x4033828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public double maxOperatorDelay;

			// Token: 0x04033829 RID: 210985
			[Token(Token = "0x4033829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int maxApplyStepInReset;
		}
	}
}
