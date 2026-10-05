using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SDK.AntiData
{
	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	public abstract class ServiceAntiDataSDK : IDisposable, IHotfixable
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x000076AC File Offset: 0x000058AC
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000ED")]
		public bool isDisposed
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x555C3C0", Offset = "0x555AFC0", VA = "0x18555C3C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x555C4D0", Offset = "0x555B0D0", VA = "0x18555C4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x000076C4 File Offset: 0x000058C4
		[Token(Token = "0x170000EE")]
		public bool isInGame
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x555C440", Offset = "0x555B040", VA = "0x18555C440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x555C2E0", Offset = "0x555AEE0", VA = "0x18555C2E0")]
		public ServiceAntiDataSDK()
		{
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x555BB80", Offset = "0x555A780", VA = "0x18555BB80")]
		private void _Init()
		{
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x000076DC File Offset: 0x000058DC
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x555AE90", Offset = "0x5559A90", VA = "0x18555AE90")]
		public bool ConsumeData(string serviceCode, out ServiceAntiDataSDK.AntiData antiData)
		{
			return default(bool);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x555B630", Offset = "0x555A230", VA = "0x18555B630")]
		public void MarkServiceSucceed(string serviceCode)
		{
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x555B3C0", Offset = "0x5559FC0", VA = "0x18555B3C0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x555B810", Offset = "0x555A410", VA = "0x18555B810", Slot = "5")]
		protected virtual void OnEnterGame()
		{
		}

		// Token: 0x06000A0F RID: 2575
		[Token(Token = "0x6000A0F")]
		protected abstract byte[] GetData1();

		// Token: 0x06000A10 RID: 2576
		[Token(Token = "0x6000A10")]
		protected abstract byte[] GetData2();

		// Token: 0x06000A11 RID: 2577
		[Token(Token = "0x6000A11")]
		protected abstract bool IsData4Supported();

		// Token: 0x06000A12 RID: 2578
		[Token(Token = "0x6000A12")]
		protected abstract void StartScanData4();

		// Token: 0x06000A13 RID: 2579
		[Token(Token = "0x6000A13")]
		protected abstract bool CheckData4(uint token);

		// Token: 0x06000A14 RID: 2580
		[Token(Token = "0x6000A14")]
		protected abstract byte[] GetData4(uint token);

		// Token: 0x06000A15 RID: 2581 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x555BF20", Offset = "0x555AB20", VA = "0x18555BF20")]
		private void _OnTick(float timeDelta)
		{
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x555BD80", Offset = "0x555A980", VA = "0x18555BD80")]
		private void _OnGameInOut(bool isEnterGame)
		{
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x555B8B0", Offset = "0x555A4B0", VA = "0x18555B8B0")]
		protected void ResumeRetriveData1()
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x555B9A0", Offset = "0x555A5A0", VA = "0x18555B9A0")]
		protected void StopRetriveData1()
		{
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x555B170", Offset = "0x5559D70", VA = "0x18555B170")]
		protected List<string> ConvertData1FromCache()
		{
			return null;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x555B4F0", Offset = "0x555A0F0", VA = "0x18555B4F0")]
		protected static string EncodeBytes(byte[] data)
		{
			return null;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000076F4 File Offset: 0x000058F4
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x555B5C0", Offset = "0x555A1C0", VA = "0x18555B5C0")]
		protected static uint GetData4Token()
		{
			return 0U;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x555BA60", Offset = "0x555A660", VA = "0x18555BA60")]
		[Conditional("TEST")]
		protected static void TestOnlyLogData(string desc, byte[] data)
		{
		}

		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		public const float DATA1_INTERVAL = 3f;

		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		public const int DATA1_MAX_COUNT = 100;

		// Token: 0x040009BD RID: 2493
		[Token(Token = "0x40009BD")]
		public const float DATA2_INTERVAL = 180f;

		// Token: 0x040009BE RID: 2494
		[Token(Token = "0x40009BE")]
		public const float DATA4_INTERVAL = 1f;

		// Token: 0x040009BF RID: 2495
		[Token(Token = "0x40009BF")]
		public const float DATA4_TIMEOUT = 30f;

		// Token: 0x040009C0 RID: 2496
		[Token(Token = "0x40009C0")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly ServiceAntiDataSDK.Data4Status s_data4Status;

		// Token: 0x040009C1 RID: 2497
		[Token(Token = "0x40009C1")]
		[FieldOffset(Offset = "0x10")]
		private TickFunction m_tick;

		// Token: 0x040009C2 RID: 2498
		[Token(Token = "0x40009C2")]
		[FieldOffset(Offset = "0x18")]
		private GameInOutObserver m_gameInOut;

		// Token: 0x040009C3 RID: 2499
		[Token(Token = "0x40009C3")]
		[FieldOffset(Offset = "0x20")]
		private float m_data1Countdown;

		// Token: 0x040009C4 RID: 2500
		[Token(Token = "0x40009C4")]
		[FieldOffset(Offset = "0x28")]
		private ScaledStopwatch m_data2Timer;

		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x40009C5")]
		[FieldOffset(Offset = "0x38")]
		private List<byte[]> m_data1Cache;

		// Token: 0x040009C7 RID: 2503
		[Token(Token = "0x40009C7")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_isDisposed;

		// Token: 0x040009C8 RID: 2504
		[Token(Token = "0x40009C8")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate6 __Hotfix0_set_isDisposed;

		// Token: 0x040009C9 RID: 2505
		[Token(Token = "0x40009C9")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_isInGame;

		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x40009CA")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x040009CB RID: 2507
		[Token(Token = "0x40009CB")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0__Init;

		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x40009CC")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate224 __Hotfix0_ConsumeData;

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate0 __Hotfix0_MarkServiceSucceed;

		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x40009CE")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Dispose;

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnEnterGame;

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate24 __Hotfix0__OnTick;

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate6 __Hotfix0__OnGameInOut;

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ResumeRetriveData1;

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate1 __Hotfix0_StopRetriveData1;

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate53 __Hotfix0_ConvertData1FromCache;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate19 __Hotfix0_EncodeBytes;

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x40009D6")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate225 __Hotfix0_GetData4Token;

		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x40009D7")]
		[FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate0 __Hotfix0_TestOnlyLogData;

		// Token: 0x020001B2 RID: 434
		[Token(Token = "0x20001B2")]
		public struct AntiData
		{
			// Token: 0x06000A1E RID: 2590 RVA: 0x0000770C File Offset: 0x0000590C
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x5549DE0", Offset = "0x55489E0", VA = "0x185549DE0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x040009D8 RID: 2520
			[Token(Token = "0x40009D8")]
			[FieldOffset(Offset = "0x0")]
			public List<string> data1;

			// Token: 0x040009D9 RID: 2521
			[Token(Token = "0x40009D9")]
			[FieldOffset(Offset = "0x8")]
			public string data2;

			// Token: 0x040009DA RID: 2522
			[Token(Token = "0x40009DA")]
			[FieldOffset(Offset = "0x10")]
			public string data4;
		}

		// Token: 0x020001B3 RID: 435
		[Token(Token = "0x20001B3")]
		protected enum Data4State
		{
			// Token: 0x040009DC RID: 2524
			[Token(Token = "0x40009DC")]
			NONE,
			// Token: 0x040009DD RID: 2525
			[Token(Token = "0x40009DD")]
			SCANNING,
			// Token: 0x040009DE RID: 2526
			[Token(Token = "0x40009DE")]
			READY_TO_UPLOAD,
			// Token: 0x040009DF RID: 2527
			[Token(Token = "0x40009DF")]
			UPLOADING,
			// Token: 0x040009E0 RID: 2528
			[Token(Token = "0x40009E0")]
			FINISH
		}

		// Token: 0x020001B4 RID: 436
		[Token(Token = "0x20001B4")]
		private struct Data4Cache
		{
			// Token: 0x040009E1 RID: 2529
			[Token(Token = "0x40009E1")]
			[FieldOffset(Offset = "0x0")]
			public string uid;

			// Token: 0x040009E2 RID: 2530
			[Token(Token = "0x40009E2")]
			[FieldOffset(Offset = "0x8")]
			public uint token;

			// Token: 0x040009E3 RID: 2531
			[Token(Token = "0x40009E3")]
			[FieldOffset(Offset = "0x10")]
			public string uploadCode;

			// Token: 0x040009E4 RID: 2532
			[Token(Token = "0x40009E4")]
			[FieldOffset(Offset = "0x18")]
			public byte[] data4;

			// Token: 0x040009E5 RID: 2533
			[Token(Token = "0x40009E5")]
			[FieldOffset(Offset = "0x20")]
			public ServiceAntiDataSDK sdk;

			// Token: 0x040009E6 RID: 2534
			[Token(Token = "0x40009E6")]
			[FieldOffset(Offset = "0x28")]
			public double lastCheckDataTs;
		}

		// Token: 0x020001B5 RID: 437
		[Token(Token = "0x20001B5")]
		protected class Data4Status
		{
			// Token: 0x06000A1F RID: 2591 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x554DF00", Offset = "0x554CB00", VA = "0x18554DF00")]
			public void NotifyEnterGame(ServiceAntiDataSDK sdkInst)
			{
			}

			// Token: 0x06000A20 RID: 2592 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x554E1C0", Offset = "0x554CDC0", VA = "0x18554E1C0")]
			public void NotifyServiceResp(string serviceCode)
			{
			}

			// Token: 0x06000A21 RID: 2593 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x554DE90", Offset = "0x554CA90", VA = "0x18554DE90")]
			public byte[] ConsumeData4(string serviceCode)
			{
				return null;
			}

			// Token: 0x06000A22 RID: 2594 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x554E300", Offset = "0x554CF00", VA = "0x18554E300")]
			public void Tick(float timeDelta)
			{
			}

			// Token: 0x06000A23 RID: 2595 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x554E520", Offset = "0x554D120", VA = "0x18554E520")]
			private void _SetState(ServiceAntiDataSDK.Data4State target)
			{
			}

			// Token: 0x06000A24 RID: 2596 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x554E480", Offset = "0x554D080", VA = "0x18554E480")]
			private void _OnStateChanged(ServiceAntiDataSDK.Data4State prev, ServiceAntiDataSDK.Data4State curr)
			{
			}

			// Token: 0x06000A25 RID: 2597 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x554E5C0", Offset = "0x554D1C0", VA = "0x18554E5C0")]
			public Data4Status()
			{
			}

			// Token: 0x040009E7 RID: 2535
			[Token(Token = "0x40009E7")]
			[FieldOffset(Offset = "0x10")]
			private ServiceAntiDataSDK m_activeInst;

			// Token: 0x040009E8 RID: 2536
			[Token(Token = "0x40009E8")]
			[FieldOffset(Offset = "0x18")]
			private ServiceAntiDataSDK.Data4State m_state;

			// Token: 0x040009E9 RID: 2537
			[Token(Token = "0x40009E9")]
			[FieldOffset(Offset = "0x20")]
			private ServiceAntiDataSDK.Data4Cache m_cache;

			// Token: 0x040009EA RID: 2538
			[Token(Token = "0x40009EA")]
			[FieldOffset(Offset = "0x50")]
			private double m_startScanTs;

			// Token: 0x040009EB RID: 2539
			[Token(Token = "0x40009EB")]
			[FieldOffset(Offset = "0x58")]
			private ListSet<string> m_uploadedUIDs;
		}
	}
}
