using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork;
using Torappu.SocketNetwork.Connections;
using XLua;

namespace Torappu.Common.UnifiedService
{
	// Token: 0x020016E1 RID: 5857
	[Token(Token = "0x20016E1")]
	public class UnifiedServiceNetCoreTCP : UnifiedServiceNetCore, INetMsgProcessor, IHotfixable
	{
		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06009458 RID: 37976 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009459 RID: 37977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FE0")]
		public Action<NetMsgID> msgParseErrListener
		{
			[Token(Token = "0x6009458")]
			[Address(RVA = "0x2B41190", Offset = "0x2B3FD90", VA = "0x182B41190")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6009459")]
			[Address(RVA = "0x2B411F0", Offset = "0x2B3FDF0", VA = "0x182B411F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600945A RID: 37978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600945A")]
		[Address(RVA = "0x2B408C0", Offset = "0x2B3F4C0", VA = "0x182B408C0", Slot = "5")]
		protected override void OnConnectTo(string host, int port)
		{
		}

		// Token: 0x0600945B RID: 37979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600945B")]
		[Address(RVA = "0x2B40A40", Offset = "0x2B3F640", VA = "0x182B40A40", Slot = "6")]
		protected override void OnDisConnect()
		{
		}

		// Token: 0x0600945C RID: 37980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600945C")]
		[Address(RVA = "0x2B40AC0", Offset = "0x2B3F6C0", VA = "0x182B40AC0", Slot = "4")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600945D RID: 37981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600945D")]
		[Address(RVA = "0x2B40E80", Offset = "0x2B3FA80", VA = "0x182B40E80")]
		private void _NetStateChanged(ConnectionState state)
		{
		}

		// Token: 0x0600945E RID: 37982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600945E")]
		public void RegisterProtocol<ProtocolDelaration>() where ProtocolDelaration : IProtocolDeclaration, new()
		{
		}

		// Token: 0x0600945F RID: 37983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600945F")]
		public void SetCmdProcessor<ProtocolType>(NetMsgID id, UnifiedServiceNetCoreTCP.ProtocolProcFunc<ProtocolType> procFunc) where ProtocolType : Protocol
		{
		}

		// Token: 0x06009460 RID: 37984 RVA: 0x00039D80 File Offset: 0x00037F80
		[Token(Token = "0x6009460")]
		[Address(RVA = "0x2B40B30", Offset = "0x2B3F730", VA = "0x182B40B30", Slot = "7")]
		public bool ProcMsg(NetMsg msg)
		{
			return default(bool);
		}

		// Token: 0x06009461 RID: 37985 RVA: 0x00039D98 File Offset: 0x00037F98
		[Token(Token = "0x6009461")]
		[Address(RVA = "0x2B40F20", Offset = "0x2B3FB20", VA = "0x182B40F20")]
		private bool _ProcMsg(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06009462 RID: 37986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009462")]
		[Address(RVA = "0x2B410A0", Offset = "0x2B3FCA0", VA = "0x182B410A0")]
		public UnifiedServiceNetCoreTCP()
		{
		}

		// Token: 0x06009463 RID: 37987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009463")]
		[Address(RVA = "0x2B40E20", Offset = "0x2B3FA20", VA = "0x182B40E20")]
		private void <>xLuaBaseProxy_OnUpdate()
		{
		}

		// Token: 0x04008A5E RID: 35422
		[Token(Token = "0x4008A5E")]
		[FieldOffset(Offset = "0x20")]
		private SocketNet m_socket;

		// Token: 0x04008A5F RID: 35423
		[Token(Token = "0x4008A5F")]
		[FieldOffset(Offset = "0x28")]
		private ProtocolRegistry m_protocolSuite;

		// Token: 0x04008A60 RID: 35424
		[Token(Token = "0x4008A60")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<NetMsgID, UnifiedServiceNetCoreTCP.ICmdProcessor> m_cmdProcessors;

		// Token: 0x04008A62 RID: 35426
		[Token(Token = "0x4008A62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_msgParseErrListener;

		// Token: 0x04008A63 RID: 35427
		[Token(Token = "0x4008A63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_msgParseErrListener;

		// Token: 0x04008A64 RID: 35428
		[Token(Token = "0x4008A64")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConnectTo;

		// Token: 0x04008A65 RID: 35429
		[Token(Token = "0x4008A65")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDisConnect;

		// Token: 0x04008A66 RID: 35430
		[Token(Token = "0x4008A66")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04008A67 RID: 35431
		[Token(Token = "0x4008A67")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__NetStateChanged;

		// Token: 0x04008A68 RID: 35432
		[Token(Token = "0x4008A68")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterProtocol;

		// Token: 0x04008A69 RID: 35433
		[Token(Token = "0x4008A69")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetCmdProcessor;

		// Token: 0x04008A6A RID: 35434
		[Token(Token = "0x4008A6A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ProcMsg;

		// Token: 0x04008A6B RID: 35435
		[Token(Token = "0x4008A6B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ProcMsg;

		// Token: 0x04008A6C RID: 35436
		[Token(Token = "0x4008A6C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020016E2 RID: 5858
		// (Invoke) Token: 0x06009465 RID: 37989
		[Token(Token = "0x20016E2")]
		public delegate bool ProtocolProcFunc<ProtocolType>(ProtocolType protocol);

		// Token: 0x020016E3 RID: 5859
		[Token(Token = "0x20016E3")]
		private interface ICmdProcessor
		{
			// Token: 0x06009468 RID: 37992
			[Token(Token = "0x6009468")]
			bool ProcCmd(Protocol protocol);
		}

		// Token: 0x020016E4 RID: 5860
		[Token(Token = "0x20016E4")]
		private class CmdProcessor<ProtocolType> : UnifiedServiceNetCoreTCP.ICmdProcessor where ProtocolType : Protocol
		{
			// Token: 0x06009469 RID: 37993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009469")]
			public CmdProcessor(UnifiedServiceNetCoreTCP.ProtocolProcFunc<ProtocolType> proc)
			{
			}

			// Token: 0x0600946A RID: 37994 RVA: 0x00039DB0 File Offset: 0x00037FB0
			[Token(Token = "0x600946A")]
			public bool ProcCmd(Protocol protocol)
			{
				return default(bool);
			}

			// Token: 0x04008A6D RID: 35437
			[Token(Token = "0x4008A6D")]
			[FieldOffset(Offset = "0x0")]
			private UnifiedServiceNetCoreTCP.ProtocolProcFunc<ProtocolType> m_proc;
		}
	}
}
