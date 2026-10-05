using System;
using System.Diagnostics;
using System.Threading;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SocketNetwork.Connections
{
	// Token: 0x020014D0 RID: 5328
	[Token(Token = "0x20014D0")]
	public class HeartBeat : IHotfixable
	{
		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06007AED RID: 31469 RVA: 0x00036ED0 File Offset: 0x000350D0
		[Token(Token = "0x17000EA9")]
		public int ping
		{
			[Token(Token = "0x6007AED")]
			[Address(RVA = "0x273C130", Offset = "0x273AD30", VA = "0x18273C130")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007AEE RID: 31470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AEE")]
		[Address(RVA = "0x273C070", Offset = "0x273AC70", VA = "0x18273C070")]
		public HeartBeat(Connection connection)
		{
		}

		// Token: 0x06007AEF RID: 31471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AEF")]
		[Address(RVA = "0x273BD70", Offset = "0x273A970", VA = "0x18273BD70")]
		private void _SetDeterminate(int ping)
		{
		}

		// Token: 0x06007AF0 RID: 31472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF0")]
		[Address(RVA = "0x273B750", Offset = "0x273A350", VA = "0x18273B750")]
		public void Start()
		{
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF1")]
		[Address(RVA = "0x273B8D0", Offset = "0x273A4D0", VA = "0x18273B8D0")]
		public void Stop()
		{
		}

		// Token: 0x06007AF2 RID: 31474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF2")]
		[Address(RVA = "0x273B970", Offset = "0x273A570", VA = "0x18273B970")]
		private void _Beat()
		{
		}

		// Token: 0x06007AF3 RID: 31475 RVA: 0x00036EE8 File Offset: 0x000350E8
		[Token(Token = "0x6007AF3")]
		[Address(RVA = "0x273B640", Offset = "0x273A240", VA = "0x18273B640")]
		public bool ProcHeartBeatRet(NetMsg msg)
		{
			return default(bool);
		}

		// Token: 0x06007AF4 RID: 31476 RVA: 0x00036F00 File Offset: 0x00035100
		[Token(Token = "0x6007AF4")]
		[Address(RVA = "0x273BD00", Offset = "0x273A900", VA = "0x18273BD00")]
		private long _GetTicks()
		{
			return 0L;
		}

		// Token: 0x06007AF5 RID: 31477 RVA: 0x00036F18 File Offset: 0x00035118
		[Token(Token = "0x6007AF5")]
		[Address(RVA = "0x273BC50", Offset = "0x273A850", VA = "0x18273BC50")]
		private double _GetMiliSecond()
		{
			return 0.0;
		}

		// Token: 0x06007AF6 RID: 31478 RVA: 0x00036F30 File Offset: 0x00035130
		[Token(Token = "0x6007AF6")]
		[Address(RVA = "0x273BEA0", Offset = "0x273AAA0", VA = "0x18273BEA0")]
		private double _Ticks2Ms(long ticks)
		{
			return 0.0;
		}

		// Token: 0x06007AF7 RID: 31479 RVA: 0x00036F48 File Offset: 0x00035148
		[Token(Token = "0x6007AF7")]
		[Address(RVA = "0x273BF60", Offset = "0x273AB60", VA = "0x18273BF60")]
		private double _Ticks2Sec(long ticks)
		{
			return 0.0;
		}

		// Token: 0x06007AF8 RID: 31480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007AF8")]
		[Address(RVA = "0x273BDE0", Offset = "0x273A9E0", VA = "0x18273BDE0")]
		private Stopwatch _StopWatch()
		{
			return null;
		}

		// Token: 0x0400791D RID: 31005
		[Token(Token = "0x400791D")]
		public const int INTERVAL = 3000;

		// Token: 0x0400791E RID: 31006
		[Token(Token = "0x400791E")]
		[FieldOffset(Offset = "0x10")]
		private readonly Connection m_connection;

		// Token: 0x0400791F RID: 31007
		[Token(Token = "0x400791F")]
		[FieldOffset(Offset = "0x18")]
		private uint m_beatCnt;

		// Token: 0x04007920 RID: 31008
		[Token(Token = "0x4007920")]
		[FieldOffset(Offset = "0x20")]
		private Thread m_beatThread;

		// Token: 0x04007921 RID: 31009
		[Token(Token = "0x4007921")]
		[FieldOffset(Offset = "0x28")]
		private Stopwatch m_watch;

		// Token: 0x04007922 RID: 31010
		[Token(Token = "0x4007922")]
		[FieldOffset(Offset = "0x30")]
		private int m_ping;

		// Token: 0x04007923 RID: 31011
		[Token(Token = "0x4007923")]
		[FieldOffset(Offset = "0x38")]
		private long m_lastRetTick;

		// Token: 0x04007924 RID: 31012
		[Token(Token = "0x4007924")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ping;

		// Token: 0x04007925 RID: 31013
		[Token(Token = "0x4007925")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007926 RID: 31014
		[Token(Token = "0x4007926")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetDeterminate;

		// Token: 0x04007927 RID: 31015
		[Token(Token = "0x4007927")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04007928 RID: 31016
		[Token(Token = "0x4007928")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x04007929 RID: 31017
		[Token(Token = "0x4007929")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Beat;

		// Token: 0x0400792A RID: 31018
		[Token(Token = "0x400792A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ProcHeartBeatRet;

		// Token: 0x0400792B RID: 31019
		[Token(Token = "0x400792B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetTicks;

		// Token: 0x0400792C RID: 31020
		[Token(Token = "0x400792C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetMiliSecond;

		// Token: 0x0400792D RID: 31021
		[Token(Token = "0x400792D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__Ticks2Ms;

		// Token: 0x0400792E RID: 31022
		[Token(Token = "0x400792E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__Ticks2Sec;

		// Token: 0x0400792F RID: 31023
		[Token(Token = "0x400792F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__StopWatch;

		// Token: 0x020014D1 RID: 5329
		// (Invoke) Token: 0x06007AFA RID: 31482
		[Token(Token = "0x20014D1")]
		private delegate int PingCalculator();
	}
}
