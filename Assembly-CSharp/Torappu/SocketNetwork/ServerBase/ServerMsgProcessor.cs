using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014CB RID: 5323
	[Token(Token = "0x20014CB")]
	public class ServerMsgProcessor : INetMsgProcessor, IHotfixable
	{
		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06007ACA RID: 31434 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007ACB RID: 31435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EA5")]
		public IServerLogRule logRule
		{
			[Token(Token = "0x6007ACA")]
			[Address(RVA = "0x2647360", Offset = "0x2645F60", VA = "0x182647360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007ACB")]
			[Address(RVA = "0x2647420", Offset = "0x2646020", VA = "0x182647420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06007ACC RID: 31436 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007ACD RID: 31437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EA6")]
		public Action<NetMsgID> msgParseErrListener
		{
			[Token(Token = "0x6007ACC")]
			[Address(RVA = "0x26473C0", Offset = "0x2645FC0", VA = "0x1826473C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6007ACD")]
			[Address(RVA = "0x26474A0", Offset = "0x26460A0", VA = "0x1826474A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06007ACE RID: 31438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ACE")]
		[Address(RVA = "0x26472E0", Offset = "0x2645EE0", VA = "0x1826472E0")]
		public ServerMsgProcessor(INetProtocolSuite protocolSuit)
		{
		}

		// Token: 0x06007ACF RID: 31439 RVA: 0x00036E28 File Offset: 0x00035028
		[Token(Token = "0x6007ACF")]
		[Address(RVA = "0x2646DF0", Offset = "0x26459F0", VA = "0x182646DF0", Slot = "4")]
		public bool ProcMsg(NetMsg msg)
		{
			return default(bool);
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x00036E40 File Offset: 0x00035040
		[Token(Token = "0x6007AD0")]
		[Address(RVA = "0x2647000", Offset = "0x2645C00", VA = "0x182647000")]
		public bool ProcMsg(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD1")]
		[Address(RVA = "0x2647120", Offset = "0x2645D20", VA = "0x182647120")]
		public void Register(NetMsgID id, ProtocolHandler handler)
		{
		}

		// Token: 0x040078E3 RID: 30947
		[Token(Token = "0x40078E3")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<uint, ProtocolHandler> m_handles;

		// Token: 0x040078E4 RID: 30948
		[Token(Token = "0x40078E4")]
		[FieldOffset(Offset = "0x18")]
		private readonly INetProtocolSuite m_protocols;

		// Token: 0x040078E7 RID: 30951
		[Token(Token = "0x40078E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_logRule;

		// Token: 0x040078E8 RID: 30952
		[Token(Token = "0x40078E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_logRule;

		// Token: 0x040078E9 RID: 30953
		[Token(Token = "0x40078E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_msgParseErrListener;

		// Token: 0x040078EA RID: 30954
		[Token(Token = "0x40078EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_msgParseErrListener;

		// Token: 0x040078EB RID: 30955
		[Token(Token = "0x40078EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040078EC RID: 30956
		[Token(Token = "0x40078EC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ProcMsg;

		// Token: 0x040078ED RID: 30957
		[Token(Token = "0x40078ED")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_ProcMsg;

		// Token: 0x040078EE RID: 30958
		[Token(Token = "0x40078EE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Register;
	}
}
