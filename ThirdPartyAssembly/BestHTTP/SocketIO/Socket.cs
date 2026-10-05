using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.SocketIO.Events;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO
{
	// Token: 0x0200051C RID: 1308
	[Token(Token = "0x200051C")]
	public sealed class Socket : ISocket
	{
		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B51 RID: 11089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000658")]
		public SocketManager Manager
		{
			[Token(Token = "0x6002B50")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B51")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B53 RID: 11091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000659")]
		public string Namespace
		{
			[Token(Token = "0x6002B52")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B53")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002B54 RID: 11092 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B55 RID: 11093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065A")]
		public string Id
		{
			[Token(Token = "0x6002B54")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B55")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002B56 RID: 11094 RVA: 0x000126C0 File Offset: 0x000108C0
		// (set) Token: 0x06002B57 RID: 11095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065B")]
		public bool IsOpen
		{
			[Token(Token = "0x6002B56")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002B57")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06002B58 RID: 11096 RVA: 0x000126D8 File Offset: 0x000108D8
		// (set) Token: 0x06002B59 RID: 11097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065C")]
		public bool AutoDecodePayload
		{
			[Token(Token = "0x6002B58")]
			[Address(RVA = "0x1636A10", Offset = "0x1635610", VA = "0x181636A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002B59")]
			[Address(RVA = "0x1636A20", Offset = "0x1635620", VA = "0x181636A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5A")]
		[Address(RVA = "0x53DCB50", Offset = "0x53DB750", VA = "0x1853DCB50")]
		internal Socket(string nsp, SocketManager manager)
		{
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5B")]
		[Address(RVA = "0x53DB830", Offset = "0x53DA430", VA = "0x1853DB830", Slot = "4")]
		private void Open()
		{
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5C")]
		[Address(RVA = "0x53DBB40", Offset = "0x53DA740", VA = "0x1853DBB40")]
		public void Disconnect()
		{
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B5D")]
		[Address(RVA = "0x53DAE90", Offset = "0x53D9A90", VA = "0x1853DAE90", Slot = "5")]
		private void Disconnect(bool remove)
		{
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5E")]
		[Address(RVA = "0x53DC570", Offset = "0x53DB170", VA = "0x1853DC570")]
		public Socket Emit(string eventName, params object[] args)
		{
			return null;
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5F")]
		[Address(RVA = "0x53DBEF0", Offset = "0x53DAAF0", VA = "0x1853DBEF0")]
		public Socket Emit(string eventName, SocketIOAckCallback callback, params object[] args)
		{
			return null;
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B60")]
		[Address(RVA = "0x53DBB90", Offset = "0x53DA790", VA = "0x1853DBB90")]
		public Socket EmitAck(Packet originalPacket, params object[] args)
		{
			return null;
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B61")]
		[Address(RVA = "0x53DC930", Offset = "0x53DB530", VA = "0x1853DC930")]
		public void On(string eventName, SocketIOCallback callback)
		{
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B62")]
		[Address(RVA = "0x53DC800", Offset = "0x53DB400", VA = "0x1853DC800")]
		public void On(SocketIOEventTypes type, SocketIOCallback callback)
		{
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B63")]
		[Address(RVA = "0x53DC970", Offset = "0x53DB570", VA = "0x1853DC970")]
		public void On(string eventName, SocketIOCallback callback, bool autoDecodePayload)
		{
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B64")]
		[Address(RVA = "0x53DC890", Offset = "0x53DB490", VA = "0x1853DC890")]
		public void On(SocketIOEventTypes type, SocketIOCallback callback, bool autoDecodePayload)
		{
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B65")]
		[Address(RVA = "0x53DCA70", Offset = "0x53DB670", VA = "0x1853DCA70")]
		public void Once(string eventName, SocketIOCallback callback)
		{
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B66")]
		[Address(RVA = "0x53DC9D0", Offset = "0x53DB5D0", VA = "0x1853DC9D0")]
		public void Once(SocketIOEventTypes type, SocketIOCallback callback)
		{
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B67")]
		[Address(RVA = "0x53DC9A0", Offset = "0x53DB5A0", VA = "0x1853DC9A0")]
		public void Once(string eventName, SocketIOCallback callback, bool autoDecodePayload)
		{
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B68")]
		[Address(RVA = "0x53DCAB0", Offset = "0x53DB6B0", VA = "0x1853DCAB0")]
		public void Once(SocketIOEventTypes type, SocketIOCallback callback, bool autoDecodePayload)
		{
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B69")]
		[Address(RVA = "0x53DC6A0", Offset = "0x53DB2A0", VA = "0x1853DC6A0")]
		public void Off()
		{
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6A")]
		[Address(RVA = "0x53DC6C0", Offset = "0x53DB2C0", VA = "0x1853DC6C0")]
		public void Off(string eventName)
		{
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6B")]
		[Address(RVA = "0x53DC610", Offset = "0x53DB210", VA = "0x1853DC610")]
		public void Off(SocketIOEventTypes type)
		{
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6C")]
		[Address(RVA = "0x53DC680", Offset = "0x53DB280", VA = "0x1853DC680")]
		public void Off(string eventName, SocketIOCallback callback)
		{
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x53DC590", Offset = "0x53DB190", VA = "0x1853DC590")]
		public void Off(SocketIOEventTypes type, SocketIOCallback callback)
		{
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x53DB290", Offset = "0x53D9E90", VA = "0x1853DB290", Slot = "6")]
		private void OnPacket(Packet packet)
		{
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B6F")]
		[Address(RVA = "0x53DB1A0", Offset = "0x53D9DA0", VA = "0x1853DB1A0", Slot = "7")]
		private void EmitEvent(SocketIOEventTypes type, params object[] args)
		{
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B70")]
		[Address(RVA = "0x53DB230", Offset = "0x53D9E30", VA = "0x1853DB230", Slot = "8")]
		private void EmitEvent(string eventName, params object[] args)
		{
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B71")]
		[Address(RVA = "0x53DB080", Offset = "0x53D9C80", VA = "0x1853DB080", Slot = "9")]
		private void EmitError(SocketIOErrors errCode, string msg)
		{
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B72")]
		[Address(RVA = "0x53DC6E0", Offset = "0x53DB2E0", VA = "0x1853DC6E0")]
		private void OnTransportOpen(Socket socket, Packet packet, params object[] args)
		{
		}

		// Token: 0x04001899 RID: 6297
		[Token(Token = "0x4001899")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, SocketIOAckCallback> AckCallbacks;

		// Token: 0x0400189A RID: 6298
		[Token(Token = "0x400189A")]
		[FieldOffset(Offset = "0x38")]
		private EventTable EventCallbacks;

		// Token: 0x0400189B RID: 6299
		[Token(Token = "0x400189B")]
		[FieldOffset(Offset = "0x40")]
		private List<object> arguments;
	}
}
