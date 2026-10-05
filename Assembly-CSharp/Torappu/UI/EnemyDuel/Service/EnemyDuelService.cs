using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service.Mode;
using Torappu.UI.EnemyDuel.Service.Phase;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200505F RID: 20575
	[Token(Token = "0x200505F")]
	public class EnemyDuelService : IDisposable, IHotfixable
	{
		// Token: 0x1700472F RID: 18223
		// (get) Token: 0x0601E7FE RID: 124926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700472F")]
		public static EnemyDuelService status
		{
			[Token(Token = "0x601E7FE")]
			[Address(RVA = "0x1849DB0", Offset = "0x18489B0", VA = "0x181849DB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004730 RID: 18224
		// (get) Token: 0x0601E7FF RID: 124927 RVA: 0x000AE9C0 File Offset: 0x000ACBC0
		[Token(Token = "0x17004730")]
		public static bool started
		{
			[Token(Token = "0x601E7FF")]
			[Address(RVA = "0x1849D60", Offset = "0x1848960", VA = "0x181849D60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601E800 RID: 124928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E800")]
		[Address(RVA = "0x1848B60", Offset = "0x1847760", VA = "0x181848B60")]
		public static void StartMulti(TeamJoinEntry entry, EnemyDuelServiceParam param)
		{
		}

		// Token: 0x0601E801 RID: 124929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E801")]
		[Address(RVA = "0x1848D70", Offset = "0x1847970", VA = "0x181848D70")]
		public static void StartSingle(SingleBattleEntry entry, EnemyDuelServiceParam param)
		{
		}

		// Token: 0x0601E802 RID: 124930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E802")]
		[Address(RVA = "0x1848E60", Offset = "0x1847A60", VA = "0x181848E60")]
		public static void Stop()
		{
		}

		// Token: 0x0601E803 RID: 124931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E803")]
		[Address(RVA = "0x18488F0", Offset = "0x18474F0", VA = "0x1818488F0")]
		public static void RegisterListener(EnemyDuelServiceEvent evt, EventPool.EventCallbackDelegate cb)
		{
		}

		// Token: 0x0601E804 RID: 124932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E804")]
		[Address(RVA = "0x1848620", Offset = "0x1847220", VA = "0x181848620")]
		public static void CancelListener(EnemyDuelServiceEvent evt, EventPool.EventCallbackDelegate cb)
		{
		}

		// Token: 0x0601E805 RID: 124933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E805")]
		[Address(RVA = "0x18489E0", Offset = "0x18475E0", VA = "0x1818489E0")]
		public static void SendRequest(EnemyDuelServiceRequest request)
		{
		}

		// Token: 0x0601E806 RID: 124934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E806")]
		[Address(RVA = "0x18494F0", Offset = "0x18480F0", VA = "0x1818494F0")]
		private static EnemyDuelService _Setup()
		{
			return null;
		}

		// Token: 0x17004731 RID: 18225
		// (get) Token: 0x0601E807 RID: 124935 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E808 RID: 124936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004731")]
		public EnemyDuelServiceParam param
		{
			[Token(Token = "0x601E807")]
			[Address(RVA = "0x1849BB0", Offset = "0x18487B0", VA = "0x181849BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601E808")]
			[Address(RVA = "0x1849EE0", Offset = "0x1848AE0", VA = "0x181849EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004732 RID: 18226
		// (get) Token: 0x0601E809 RID: 124937 RVA: 0x000AE9D8 File Offset: 0x000ACBD8
		[Token(Token = "0x17004732")]
		public EnemyDuelService.Setting setting
		{
			[Token(Token = "0x601E809")]
			[Address(RVA = "0x1849C90", Offset = "0x1848890", VA = "0x181849C90")]
			get
			{
				return default(EnemyDuelService.Setting);
			}
		}

		// Token: 0x17004733 RID: 18227
		// (get) Token: 0x0601E80A RID: 124938 RVA: 0x000AE9F0 File Offset: 0x000ACBF0
		[Token(Token = "0x17004733")]
		public int ping
		{
			[Token(Token = "0x601E80A")]
			[Address(RVA = "0x1849C10", Offset = "0x1848810", VA = "0x181849C10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004734 RID: 18228
		// (get) Token: 0x0601E80B RID: 124939 RVA: 0x000AEA08 File Offset: 0x000ACC08
		[Token(Token = "0x17004734")]
		public DateTime currentTime
		{
			[Token(Token = "0x601E80B")]
			[Address(RVA = "0x18499B0", Offset = "0x18485B0", VA = "0x1818499B0")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17004735 RID: 18229
		// (get) Token: 0x0601E80C RID: 124940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004735")]
		public EnemyDuelServiceBattleInfo battleInfo
		{
			[Token(Token = "0x601E80C")]
			[Address(RVA = "0x1849930", Offset = "0x1848530", VA = "0x181849930")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004736 RID: 18230
		// (get) Token: 0x0601E80D RID: 124941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004736")]
		public EnemyDuelServiceTeamInfo teamInfo
		{
			[Token(Token = "0x601E80D")]
			[Address(RVA = "0x1849E60", Offset = "0x1848A60", VA = "0x181849E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004737 RID: 18231
		// (get) Token: 0x0601E80E RID: 124942 RVA: 0x000AEA20 File Offset: 0x000ACC20
		[Token(Token = "0x17004737")]
		public bool isMulti
		{
			[Token(Token = "0x601E80E")]
			[Address(RVA = "0x1849AC0", Offset = "0x18486C0", VA = "0x181849AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601E80F RID: 124943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E80F")]
		[Address(RVA = "0x18497D0", Offset = "0x18483D0", VA = "0x1818497D0")]
		private EnemyDuelService()
		{
		}

		// Token: 0x0601E810 RID: 124944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E810")]
		[Address(RVA = "0x1848710", Offset = "0x1847310", VA = "0x181848710", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0601E811 RID: 124945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E811")]
		[Address(RVA = "0x18491E0", Offset = "0x1847DE0", VA = "0x1818491E0")]
		private void _HandleSceneChanged(string from, string to)
		{
		}

		// Token: 0x0601E812 RID: 124946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E812")]
		[Address(RVA = "0x1849370", Offset = "0x1847F70", VA = "0x181849370")]
		private void _RefreshStatus()
		{
		}

		// Token: 0x0601E813 RID: 124947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E813")]
		[Address(RVA = "0x1849750", Offset = "0x1848350", VA = "0x181849750")]
		private void _Update()
		{
		}

		// Token: 0x0601E814 RID: 124948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E814")]
		[Address(RVA = "0x1849150", Offset = "0x1847D50", VA = "0x181849150")]
		private void _FixedUpdate()
		{
		}

		// Token: 0x0601E815 RID: 124949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E815")]
		[Address(RVA = "0x18492E0", Offset = "0x1847EE0", VA = "0x1818492E0")]
		private void _OnGUI()
		{
		}

		// Token: 0x0601E816 RID: 124950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E816")]
		private T _ChangePhase<T>() where T : EnemyDuelServicePhase, new()
		{
			return null;
		}

		// Token: 0x0601E817 RID: 124951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E817")]
		private T _CheckMode<T>() where T : class, IEnemyDuelServiceMode, new()
		{
			return null;
		}

		// Token: 0x04028D97 RID: 167319
		[Token(Token = "0x4028D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static EnemyDuelService s_instance;

		// Token: 0x04028D98 RID: 167320
		[Token(Token = "0x4028D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private EnemyDuelServicePhase m_curPhase;

		// Token: 0x04028D99 RID: 167321
		[Token(Token = "0x4028D99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private EnemyDuelService.Core m_coreImpl;

		// Token: 0x04028D9A RID: 167322
		[Token(Token = "0x4028D9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IEnemyDuelServiceMode m_mode;

		// Token: 0x04028D9B RID: 167323
		[Token(Token = "0x4028D9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private EventPool<EnemyDuelServiceEvent> m_eventPool;

		// Token: 0x04028D9D RID: 167325
		[Token(Token = "0x4028D9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x04028D9E RID: 167326
		[Token(Token = "0x4028D9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_started;

		// Token: 0x04028D9F RID: 167327
		[Token(Token = "0x4028D9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_StartMulti;

		// Token: 0x04028DA0 RID: 167328
		[Token(Token = "0x4028DA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StartSingle;

		// Token: 0x04028DA1 RID: 167329
		[Token(Token = "0x4028DA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x04028DA2 RID: 167330
		[Token(Token = "0x4028DA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterListener;

		// Token: 0x04028DA3 RID: 167331
		[Token(Token = "0x4028DA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CancelListener;

		// Token: 0x04028DA4 RID: 167332
		[Token(Token = "0x4028DA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x04028DA5 RID: 167333
		[Token(Token = "0x4028DA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__Setup;

		// Token: 0x04028DA6 RID: 167334
		[Token(Token = "0x4028DA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_param;

		// Token: 0x04028DA7 RID: 167335
		[Token(Token = "0x4028DA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_param;

		// Token: 0x04028DA8 RID: 167336
		[Token(Token = "0x4028DA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_setting;

		// Token: 0x04028DA9 RID: 167337
		[Token(Token = "0x4028DA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_ping;

		// Token: 0x04028DAA RID: 167338
		[Token(Token = "0x4028DAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x04028DAB RID: 167339
		[Token(Token = "0x4028DAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x04028DAC RID: 167340
		[Token(Token = "0x4028DAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_teamInfo;

		// Token: 0x04028DAD RID: 167341
		[Token(Token = "0x4028DAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_isMulti;

		// Token: 0x04028DAE RID: 167342
		[Token(Token = "0x4028DAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04028DAF RID: 167343
		[Token(Token = "0x4028DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04028DB0 RID: 167344
		[Token(Token = "0x4028DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__HandleSceneChanged;

		// Token: 0x04028DB1 RID: 167345
		[Token(Token = "0x4028DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RefreshStatus;

		// Token: 0x04028DB2 RID: 167346
		[Token(Token = "0x4028DB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__Update;

		// Token: 0x04028DB3 RID: 167347
		[Token(Token = "0x4028DB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__FixedUpdate;

		// Token: 0x04028DB4 RID: 167348
		[Token(Token = "0x4028DB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnGUI;

		// Token: 0x04028DB5 RID: 167349
		[Token(Token = "0x4028DB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ChangePhase;

		// Token: 0x04028DB6 RID: 167350
		[Token(Token = "0x4028DB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckMode;

		// Token: 0x02005060 RID: 20576
		[Token(Token = "0x2005060")]
		private class Core : IEnemyDuelServiceCore
		{
			// Token: 0x0601E818 RID: 124952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E818")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public Core(EnemyDuelService service)
			{
			}

			// Token: 0x0601E819 RID: 124953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E819")]
			[Address(RVA = "0x1837EF0", Offset = "0x1836AF0", VA = "0x181837EF0", Slot = "5")]
			public void RefreshStatus()
			{
			}

			// Token: 0x0601E81A RID: 124954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E81A")]
			[Address(RVA = "0x1838290", Offset = "0x1836E90", VA = "0x181838290", Slot = "4")]
			public void TriggerEvent(EnemyDuelServiceEvent evt, [Optional] object args)
			{
			}

			// Token: 0x0601E81B RID: 124955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E81B")]
			[Address(RVA = "0x1838080", Offset = "0x1836C80", VA = "0x181838080", Slot = "6")]
			public void RevStep(EnemyDuelServiceStepData step)
			{
			}

			// Token: 0x04028DB7 RID: 167351
			[Token(Token = "0x4028DB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private EnemyDuelService m_service;
		}

		// Token: 0x02005061 RID: 20577
		[Token(Token = "0x2005061")]
		private class Driver : SingletonMonoBehaviour<EnemyDuelService.Driver>
		{
			// Token: 0x0601E81C RID: 124956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E81C")]
			[Address(RVA = "0x1838B70", Offset = "0x1837770", VA = "0x181838B70", Slot = "4")]
			protected override void OnInit()
			{
			}

			// Token: 0x0601E81D RID: 124957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E81D")]
			[Address(RVA = "0x1838C00", Offset = "0x1837800", VA = "0x181838C00")]
			private void Update()
			{
			}

			// Token: 0x0601E81E RID: 124958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E81E")]
			[Address(RVA = "0x18388D0", Offset = "0x18374D0", VA = "0x1818388D0")]
			private void FixedUpdate()
			{
			}

			// Token: 0x0601E81F RID: 124959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E81F")]
			[Address(RVA = "0x1838A80", Offset = "0x1837680", VA = "0x181838A80")]
			private void OnGUI()
			{
			}

			// Token: 0x0601E820 RID: 124960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E820")]
			[Address(RVA = "0x1838A20", Offset = "0x1837620", VA = "0x181838A20")]
			private void OnApplicationQuit()
			{
			}

			// Token: 0x0601E821 RID: 124961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E821")]
			[Address(RVA = "0x1838830", Offset = "0x1837430", VA = "0x181838830")]
			public static void DestroyDriver()
			{
			}

			// Token: 0x0601E822 RID: 124962 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E822")]
			[Address(RVA = "0x18389C0", Offset = "0x18375C0", VA = "0x1818389C0")]
			public void InitIfNot()
			{
			}

			// Token: 0x0601E823 RID: 124963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E823")]
			[Address(RVA = "0x1838CE0", Offset = "0x18378E0", VA = "0x181838CE0")]
			public Driver()
			{
			}

			// Token: 0x04028DB8 RID: 167352
			[Token(Token = "0x4028DB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x04028DB9 RID: 167353
			[Token(Token = "0x4028DB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Update;

			// Token: 0x04028DBA RID: 167354
			[Token(Token = "0x4028DBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_FixedUpdate;

			// Token: 0x04028DBB RID: 167355
			[Token(Token = "0x4028DBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnGUI;

			// Token: 0x04028DBC RID: 167356
			[Token(Token = "0x4028DBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnApplicationQuit;

			// Token: 0x04028DBD RID: 167357
			[Token(Token = "0x4028DBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_DestroyDriver;

			// Token: 0x04028DBE RID: 167358
			[Token(Token = "0x4028DBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_InitIfNot;

			// Token: 0x04028DBF RID: 167359
			[Token(Token = "0x4028DBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005062 RID: 20578
		[Token(Token = "0x2005062")]
		public struct Setting
		{
			// Token: 0x04028DC0 RID: 167360
			[Token(Token = "0x4028DC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly EnemyDuelService.Setting Default;

			// Token: 0x04028DC1 RID: 167361
			[Token(Token = "0x4028DC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int maxRetryTimeInMatchRoom;

			// Token: 0x04028DC2 RID: 167362
			[Token(Token = "0x4028DC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int maxRetryTimeInTeamRoom;

			// Token: 0x04028DC3 RID: 167363
			[Token(Token = "0x4028DC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int maxRetryTimeInBattle;

			// Token: 0x04028DC4 RID: 167364
			[Token(Token = "0x4028DC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int settleRetryTime;

			// Token: 0x04028DC5 RID: 167365
			[Token(Token = "0x4028DC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float delayTimeNeedTip;

			// Token: 0x04028DC6 RID: 167366
			[Token(Token = "0x4028DC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maxPlaySpeed;

			// Token: 0x04028DC7 RID: 167367
			[Token(Token = "0x4028DC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public double maxOperatorDelay;
		}
	}
}
