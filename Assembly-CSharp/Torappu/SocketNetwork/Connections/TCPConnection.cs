using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.SocketNetwork.Connections
{
	// Token: 0x020014D5 RID: 5333
	[Token(Token = "0x20014D5")]
	public class TCPConnection : Connection, IDisposable
	{
		// Token: 0x06007B03 RID: 31491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B03")]
		[Address(RVA = "0x2747A60", Offset = "0x2746660", VA = "0x182747A60")]
		public TCPConnection()
		{
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06007B04 RID: 31492 RVA: 0x00036F60 File Offset: 0x00035160
		// (set) Token: 0x06007B05 RID: 31493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EAA")]
		public int connectTimeoutMs
		{
			[Token(Token = "0x6007B04")]
			[Address(RVA = "0x2747BE0", Offset = "0x27467E0", VA = "0x182747BE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007B05")]
			[Address(RVA = "0x2747C40", Offset = "0x2746840", VA = "0x182747C40")]
			set
			{
			}
		}

		// Token: 0x06007B06 RID: 31494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B06")]
		[Address(RVA = "0x2746280", Offset = "0x2744E80", VA = "0x182746280", Slot = "4")]
		protected override void OnStart(IPAddress address, int port)
		{
		}

		// Token: 0x06007B07 RID: 31495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B07")]
		[Address(RVA = "0x2746F10", Offset = "0x2745B10", VA = "0x182746F10")]
		private void _ConnectTimeout(object state)
		{
		}

		// Token: 0x06007B08 RID: 31496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B08")]
		[Address(RVA = "0x2746C40", Offset = "0x2745840", VA = "0x182746C40")]
		private void _ConnectCallback(IAsyncResult result)
		{
		}

		// Token: 0x06007B09 RID: 31497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B09")]
		[Address(RVA = "0x27466E0", Offset = "0x27452E0", VA = "0x1827466E0", Slot = "5")]
		protected override void OnStop()
		{
		}

		// Token: 0x06007B0A RID: 31498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B0A")]
		[Address(RVA = "0x2745E10", Offset = "0x2744A10", VA = "0x182745E10", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06007B0B RID: 31499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B0B")]
		[Address(RVA = "0x2746B40", Offset = "0x2745740", VA = "0x182746B40")]
		private void _CleanConnectState()
		{
		}

		// Token: 0x06007B0C RID: 31500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B0C")]
		[Address(RVA = "0x2746740", Offset = "0x2745340", VA = "0x182746740", Slot = "6")]
		protected override void OnTryToSend()
		{
		}

		// Token: 0x06007B0D RID: 31501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B0D")]
		[Address(RVA = "0x27474A0", Offset = "0x27460A0", VA = "0x1827474A0")]
		private void _SendCallback(IAsyncResult result)
		{
		}

		// Token: 0x06007B0E RID: 31502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B0E")]
		[Address(RVA = "0x27478B0", Offset = "0x27464B0", VA = "0x1827478B0")]
		private void _TryRevData()
		{
		}

		// Token: 0x06007B0F RID: 31503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B0F")]
		[Address(RVA = "0x2747150", Offset = "0x2745D50", VA = "0x182747150")]
		private void _Received(IAsyncResult result)
		{
		}

		// Token: 0x06007B10 RID: 31504 RVA: 0x00036F78 File Offset: 0x00035178
		[Token(Token = "0x6007B10")]
		[Address(RVA = "0x2747030", Offset = "0x2745C30", VA = "0x182747030")]
		private bool _InvalidResult(IAsyncResult result)
		{
			return default(bool);
		}

		// Token: 0x06007B11 RID: 31505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B11")]
		[Address(RVA = "0x27397F0", Offset = "0x27383F0", VA = "0x1827397F0")]
		private void <>xLuaBaseProxy_OnStart(IPAddress P0, int P1)
		{
		}

		// Token: 0x06007B12 RID: 31506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B12")]
		[Address(RVA = "0x2739870", Offset = "0x2738470", VA = "0x182739870")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x06007B13 RID: 31507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B13")]
		[Address(RVA = "0x27398D0", Offset = "0x27384D0", VA = "0x1827398D0")]
		private void <>xLuaBaseProxy_OnTryToSend()
		{
		}

		// Token: 0x0400793A RID: 31034
		[Token(Token = "0x400793A")]
		[FieldOffset(Offset = "0x48")]
		private Socket m_socket;

		// Token: 0x0400793B RID: 31035
		[Token(Token = "0x400793B")]
		[FieldOffset(Offset = "0x50")]
		private readonly ByteArray m_asyncSendBuff;

		// Token: 0x0400793C RID: 31036
		[Token(Token = "0x400793C")]
		[FieldOffset(Offset = "0x58")]
		private readonly ByteArray m_asyncRevBuff;

		// Token: 0x0400793D RID: 31037
		[Token(Token = "0x400793D")]
		[FieldOffset(Offset = "0x60")]
		private readonly AsyncCallback SendCB;

		// Token: 0x0400793E RID: 31038
		[Token(Token = "0x400793E")]
		[FieldOffset(Offset = "0x68")]
		private readonly AsyncCallback RevCB;

		// Token: 0x0400793F RID: 31039
		[Token(Token = "0x400793F")]
		[FieldOffset(Offset = "0x70")]
		private int m_connectTimeoutMs;

		// Token: 0x04007940 RID: 31040
		[Token(Token = "0x4007940")]
		[FieldOffset(Offset = "0x78")]
		private Timer m_connectTimeoutTimer;

		// Token: 0x04007941 RID: 31041
		[Token(Token = "0x4007941")]
		[FieldOffset(Offset = "0x80")]
		private IAsyncResult m_connectAsyncResult;

		// Token: 0x04007942 RID: 31042
		[Token(Token = "0x4007942")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007943 RID: 31043
		[Token(Token = "0x4007943")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_connectTimeoutMs;

		// Token: 0x04007944 RID: 31044
		[Token(Token = "0x4007944")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_connectTimeoutMs;

		// Token: 0x04007945 RID: 31045
		[Token(Token = "0x4007945")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04007946 RID: 31046
		[Token(Token = "0x4007946")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ConnectTimeout;

		// Token: 0x04007947 RID: 31047
		[Token(Token = "0x4007947")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ConnectCallback;

		// Token: 0x04007948 RID: 31048
		[Token(Token = "0x4007948")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x04007949 RID: 31049
		[Token(Token = "0x4007949")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400794A RID: 31050
		[Token(Token = "0x400794A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CleanConnectState;

		// Token: 0x0400794B RID: 31051
		[Token(Token = "0x400794B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTryToSend;

		// Token: 0x0400794C RID: 31052
		[Token(Token = "0x400794C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SendCallback;

		// Token: 0x0400794D RID: 31053
		[Token(Token = "0x400794D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryRevData;

		// Token: 0x0400794E RID: 31054
		[Token(Token = "0x400794E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__Received;

		// Token: 0x0400794F RID: 31055
		[Token(Token = "0x400794F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InvalidResult;
	}
}
