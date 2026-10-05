using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.SocketNetwork.Connections;
using XLua;

namespace Torappu.SocketNetwork
{
	// Token: 0x020014A5 RID: 5285
	[Token(Token = "0x20014A5")]
	public class SocketNet : IHotfixable
	{
		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06007A08 RID: 31240 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A09 RID: 31241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E8F")]
		public INetProtocolSuite protocolSuite
		{
			[Token(Token = "0x6007A08")]
			[Address(RVA = "0x264CB40", Offset = "0x264B740", VA = "0x18264CB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007A09")]
			[Address(RVA = "0x264CD20", Offset = "0x264B920", VA = "0x18264CD20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06007A0A RID: 31242 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A0B RID: 31243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E90")]
		public INetMsgProcessor extProcessor
		{
			[Token(Token = "0x6007A0A")]
			[Address(RVA = "0x264CA70", Offset = "0x264B670", VA = "0x18264CA70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007A0B")]
			[Address(RVA = "0x264CCA0", Offset = "0x264B8A0", VA = "0x18264CCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06007A0C RID: 31244 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06007A0D RID: 31245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002E")]
		public event Action<ConnectionState> eStateChanged
		{
			[Token(Token = "0x6007A0C")]
			[Address(RVA = "0x264C900", Offset = "0x264B500", VA = "0x18264C900")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007A0D")]
			[Address(RVA = "0x264CBA0", Offset = "0x264B7A0", VA = "0x18264CBA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06007A0E RID: 31246 RVA: 0x00036B58 File Offset: 0x00034D58
		[Token(Token = "0x17000E91")]
		public int ping
		{
			[Token(Token = "0x6007A0E")]
			[Address(RVA = "0x264CAD0", Offset = "0x264B6D0", VA = "0x18264CAD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A0F")]
		[Address(RVA = "0x264C8A0", Offset = "0x264B4A0", VA = "0x18264C8A0")]
		public SocketNet()
		{
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A10")]
		[Address(RVA = "0x264C4B0", Offset = "0x264B0B0", VA = "0x18264C4B0")]
		public void Init(INetMsgProcessor processor)
		{
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A11")]
		public void Connect<CT>(string host, int port) where CT : Connection, new()
		{
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A12")]
		[Address(RVA = "0x264C440", Offset = "0x264B040", VA = "0x18264C440")]
		public void DisConnect()
		{
		}

		// Token: 0x06007A13 RID: 31251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A13")]
		[Address(RVA = "0x264C530", Offset = "0x264B130", VA = "0x18264C530")]
		public void SendMsg(NetMsg msg)
		{
		}

		// Token: 0x06007A14 RID: 31252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A14")]
		[Address(RVA = "0x264C5C0", Offset = "0x264B1C0", VA = "0x18264C5C0")]
		public void SendMsg(NetMsgID pid)
		{
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06007A15 RID: 31253 RVA: 0x00036B70 File Offset: 0x00034D70
		[Token(Token = "0x17000E92")]
		public bool connected
		{
			[Token(Token = "0x6007A15")]
			[Address(RVA = "0x264CA00", Offset = "0x264B600", VA = "0x18264CA00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007A16 RID: 31254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A16")]
		[Address(RVA = "0x264C660", Offset = "0x264B260", VA = "0x18264C660")]
		public void Update()
		{
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x00036B88 File Offset: 0x00034D88
		[Token(Token = "0x6007A17")]
		[Address(RVA = "0x264C830", Offset = "0x264B430", VA = "0x18264C830")]
		private bool _InternalProcess(NetMsg msg)
		{
			return default(bool);
		}

		// Token: 0x04007809 RID: 30729
		[Token(Token = "0x4007809")]
		[FieldOffset(Offset = "0x10")]
		private Connection m_connection;

		// Token: 0x0400780A RID: 30730
		[Token(Token = "0x400780A")]
		[FieldOffset(Offset = "0x18")]
		private INetMsgProcessor m_processor;

		// Token: 0x0400780E RID: 30734
		[Token(Token = "0x400780E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_protocolSuite;

		// Token: 0x0400780F RID: 30735
		[Token(Token = "0x400780F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_protocolSuite;

		// Token: 0x04007810 RID: 30736
		[Token(Token = "0x4007810")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_extProcessor;

		// Token: 0x04007811 RID: 30737
		[Token(Token = "0x4007811")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_extProcessor;

		// Token: 0x04007812 RID: 30738
		[Token(Token = "0x4007812")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_add_eStateChanged;

		// Token: 0x04007813 RID: 30739
		[Token(Token = "0x4007813")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_remove_eStateChanged;

		// Token: 0x04007814 RID: 30740
		[Token(Token = "0x4007814")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_ping;

		// Token: 0x04007815 RID: 30741
		[Token(Token = "0x4007815")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007816 RID: 30742
		[Token(Token = "0x4007816")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04007817 RID: 30743
		[Token(Token = "0x4007817")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Connect;

		// Token: 0x04007818 RID: 30744
		[Token(Token = "0x4007818")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DisConnect;

		// Token: 0x04007819 RID: 30745
		[Token(Token = "0x4007819")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SendMsg;

		// Token: 0x0400781A RID: 30746
		[Token(Token = "0x400781A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1_SendMsg;

		// Token: 0x0400781B RID: 30747
		[Token(Token = "0x400781B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_connected;

		// Token: 0x0400781C RID: 30748
		[Token(Token = "0x400781C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400781D RID: 30749
		[Token(Token = "0x400781D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InternalProcess;
	}
}
