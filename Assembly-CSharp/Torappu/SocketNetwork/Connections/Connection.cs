using System;
using System.Collections.Generic;
using System.Net;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.SocketNetwork.Connections
{
	// Token: 0x020014CE RID: 5326
	[Token(Token = "0x20014CE")]
	public abstract class Connection : IHotfixable
	{
		// Token: 0x06007ADD RID: 31453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ADD")]
		[Address(RVA = "0x273A8C0", Offset = "0x27394C0", VA = "0x18273A8C0")]
		protected Connection()
		{
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ADE")]
		[Address(RVA = "0x2739930", Offset = "0x2738530", VA = "0x182739930")]
		public void SendMsg(NetMsg msg)
		{
		}

		// Token: 0x06007ADF RID: 31455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007ADF")]
		[Address(RVA = "0x27395B0", Offset = "0x27381B0", VA = "0x1827395B0")]
		public NetMsg GetReceivedMsg()
		{
			return null;
		}

		// Token: 0x06007AE0 RID: 31456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AE0")]
		[Address(RVA = "0x2739A70", Offset = "0x2738670", VA = "0x182739A70")]
		public void Start(string host, int port)
		{
		}

		// Token: 0x06007AE1 RID: 31457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AE1")]
		[Address(RVA = "0x2739BA0", Offset = "0x27387A0", VA = "0x182739BA0")]
		public void Stop()
		{
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06007AE2 RID: 31458 RVA: 0x00036E88 File Offset: 0x00035088
		[Token(Token = "0x17000EA7")]
		public ConnectionState state
		{
			[Token(Token = "0x6007AE2")]
			[Address(RVA = "0x273AC00", Offset = "0x2739800", VA = "0x18273AC00")]
			get
			{
				return ConnectionState.NULL;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06007AE3 RID: 31459 RVA: 0x00036EA0 File Offset: 0x000350A0
		[Token(Token = "0x17000EA8")]
		public int ping
		{
			[Token(Token = "0x6007AE3")]
			[Address(RVA = "0x273AB60", Offset = "0x2739760", VA = "0x18273AB60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007AE4 RID: 31460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007AE4")]
		[Address(RVA = "0x273A240", Offset = "0x2738E40", VA = "0x18273A240")]
		protected NetMsg _GetWaitingSendMsg()
		{
			return null;
		}

		// Token: 0x06007AE5 RID: 31461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AE5")]
		[Address(RVA = "0x273A750", Offset = "0x2739350", VA = "0x18273A750")]
		protected void _SaveReceivedData(byte[] data, int offset, int size)
		{
		}

		// Token: 0x06007AE6 RID: 31462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AE6")]
		[Address(RVA = "0x273A370", Offset = "0x2738F70", VA = "0x18273A370")]
		private void _ParseReceivedMsg()
		{
		}

		// Token: 0x06007AE7 RID: 31463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AE7")]
		[Address(RVA = "0x2739770", Offset = "0x2738370", VA = "0x182739770")]
		public void HeartNoResponse()
		{
		}

		// Token: 0x06007AE8 RID: 31464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AE8")]
		[Address(RVA = "0x2739E90", Offset = "0x2738A90", VA = "0x182739E90")]
		protected void _ChangeState(ConnectionState newState, int socketError, string error)
		{
		}

		// Token: 0x06007AE9 RID: 31465 RVA: 0x00036EB8 File Offset: 0x000350B8
		[Token(Token = "0x6007AE9")]
		[Address(RVA = "0x2739650", Offset = "0x2738250", VA = "0x182739650")]
		public ConnectionState GetStateChange()
		{
			return ConnectionState.NULL;
		}

		// Token: 0x06007AEA RID: 31466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AEA")]
		[Address(RVA = "0x27397F0", Offset = "0x27383F0", VA = "0x1827397F0", Slot = "4")]
		protected virtual void OnStart(IPAddress address, int port)
		{
		}

		// Token: 0x06007AEB RID: 31467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AEB")]
		[Address(RVA = "0x2739870", Offset = "0x2738470", VA = "0x182739870", Slot = "5")]
		protected virtual void OnStop()
		{
		}

		// Token: 0x06007AEC RID: 31468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AEC")]
		[Address(RVA = "0x27398D0", Offset = "0x27384D0", VA = "0x1827398D0", Slot = "6")]
		protected virtual void OnTryToSend()
		{
		}

		// Token: 0x040078FD RID: 30973
		[Token(Token = "0x40078FD")]
		protected const int REV_BUFF_SIZE = 131072;

		// Token: 0x040078FE RID: 30974
		[Token(Token = "0x40078FE")]
		[FieldOffset(Offset = "0x10")]
		private readonly ByteArray m_revBuffer;

		// Token: 0x040078FF RID: 30975
		[Token(Token = "0x40078FF")]
		[FieldOffset(Offset = "0x18")]
		private readonly Queue<NetMsg> m_sendQueue;

		// Token: 0x04007900 RID: 30976
		[Token(Token = "0x4007900")]
		[FieldOffset(Offset = "0x20")]
		private readonly Queue<NetMsg> m_receivedQueue;

		// Token: 0x04007901 RID: 30977
		[Token(Token = "0x4007901")]
		[FieldOffset(Offset = "0x28")]
		private ConnectionState m_state;

		// Token: 0x04007902 RID: 30978
		[Token(Token = "0x4007902")]
		[FieldOffset(Offset = "0x30")]
		private readonly Queue<ConnectionState> m_pathOfStateChange;

		// Token: 0x04007903 RID: 30979
		[Token(Token = "0x4007903")]
		[FieldOffset(Offset = "0x38")]
		private readonly HeartBeat m_beat;

		// Token: 0x04007904 RID: 30980
		[Token(Token = "0x4007904")]
		[FieldOffset(Offset = "0x40")]
		private readonly object m_asyncLock;

		// Token: 0x04007905 RID: 30981
		[Token(Token = "0x4007905")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007906 RID: 30982
		[Token(Token = "0x4007906")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SendMsg;

		// Token: 0x04007907 RID: 30983
		[Token(Token = "0x4007907")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetReceivedMsg;

		// Token: 0x04007908 RID: 30984
		[Token(Token = "0x4007908")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04007909 RID: 30985
		[Token(Token = "0x4007909")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400790A RID: 30986
		[Token(Token = "0x400790A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400790B RID: 30987
		[Token(Token = "0x400790B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_ping;

		// Token: 0x0400790C RID: 30988
		[Token(Token = "0x400790C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetWaitingSendMsg;

		// Token: 0x0400790D RID: 30989
		[Token(Token = "0x400790D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SaveReceivedData;

		// Token: 0x0400790E RID: 30990
		[Token(Token = "0x400790E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ParseReceivedMsg;

		// Token: 0x0400790F RID: 30991
		[Token(Token = "0x400790F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HeartNoResponse;

		// Token: 0x04007910 RID: 30992
		[Token(Token = "0x4007910")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ChangeState;

		// Token: 0x04007911 RID: 30993
		[Token(Token = "0x4007911")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetStateChange;

		// Token: 0x04007912 RID: 30994
		[Token(Token = "0x4007912")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04007913 RID: 30995
		[Token(Token = "0x4007913")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x04007914 RID: 30996
		[Token(Token = "0x4007914")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnTryToSend;
	}
}
