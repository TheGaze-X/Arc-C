using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014CC RID: 5324
	[Token(Token = "0x20014CC")]
	public abstract class ServerProtocolSuite : INetProtocolSuite, IHotfixable
	{
		// Token: 0x06007AD2 RID: 31442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD2")]
		[Address(RVA = "0x2647800", Offset = "0x2646400", VA = "0x182647800")]
		public ServerProtocolSuite()
		{
		}

		// Token: 0x06007AD3 RID: 31443
		[Token(Token = "0x6007AD3")]
		protected abstract void OnRegisterProtocol();

		// Token: 0x06007AD4 RID: 31444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007AD4")]
		public T Get<T>() where T : Protocol, new()
		{
			return null;
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007AD5")]
		[Address(RVA = "0x2647520", Offset = "0x2646120", VA = "0x182647520", Slot = "5")]
		public Protocol Get(NetMsgID id)
		{
			return null;
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x00036E58 File Offset: 0x00035058
		[Token(Token = "0x6007AD6")]
		public NetMsgID GetID<T>() where T : Protocol
		{
			return default(NetMsgID);
		}

		// Token: 0x06007AD7 RID: 31447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007AD7")]
		[Address(RVA = "0x26476F0", Offset = "0x26462F0", VA = "0x1826476F0")]
		private Protocol _GetProtocol(int idx)
		{
			return null;
		}

		// Token: 0x06007AD8 RID: 31448 RVA: 0x00036E70 File Offset: 0x00035070
		[Token(Token = "0x6007AD8")]
		public bool Register<T>(NetMsgID id) where T : Protocol, new()
		{
			return default(bool);
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD9")]
		public void RegisterFrom<TProtoContainer>()
		{
		}

		// Token: 0x040078EF RID: 30959
		[Token(Token = "0x40078EF")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Func<Protocol>> m_creators;

		// Token: 0x040078F0 RID: 30960
		[Token(Token = "0x40078F0")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<Protocol> m_protocols;

		// Token: 0x040078F1 RID: 30961
		[Token(Token = "0x40078F1")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<NetMsgID, int> m_idFinder;

		// Token: 0x040078F2 RID: 30962
		[Token(Token = "0x40078F2")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<Type, int> m_typeFinder;

		// Token: 0x040078F3 RID: 30963
		[Token(Token = "0x40078F3")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<Type, NetMsgID> m_typeIdFinder;

		// Token: 0x040078F4 RID: 30964
		[Token(Token = "0x40078F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040078F5 RID: 30965
		[Token(Token = "0x40078F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Get;

		// Token: 0x040078F6 RID: 30966
		[Token(Token = "0x40078F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_Get;

		// Token: 0x040078F7 RID: 30967
		[Token(Token = "0x40078F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetID;

		// Token: 0x040078F8 RID: 30968
		[Token(Token = "0x40078F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetProtocol;

		// Token: 0x040078F9 RID: 30969
		[Token(Token = "0x40078F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x040078FA RID: 30970
		[Token(Token = "0x40078FA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterFrom;
	}
}
