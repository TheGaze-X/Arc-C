using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork
{
	// Token: 0x020014A0 RID: 5280
	[Token(Token = "0x20014A0")]
	[Obsolete]
	public class ProtocolRegistry : INetProtocolSuite, IHotfixable
	{
		// Token: 0x060079F7 RID: 31223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079F7")]
		[Address(RVA = "0x2644720", Offset = "0x2643320", VA = "0x182644720")]
		public ProtocolRegistry()
		{
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F8")]
		public T Get<T>() where T : Protocol, new()
		{
			return null;
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F9")]
		[Address(RVA = "0x2644520", Offset = "0x2643120", VA = "0x182644520", Slot = "5")]
		public Protocol Get(NetMsgID id)
		{
			return null;
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x00036B28 File Offset: 0x00034D28
		[Token(Token = "0x60079FA")]
		public NetMsgID GetID<T>() where T : Protocol
		{
			return default(NetMsgID);
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079FB")]
		[Address(RVA = "0x2644650", Offset = "0x2643250", VA = "0x182644650")]
		private Protocol _GetProtocol(int idx)
		{
			return null;
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x00036B40 File Offset: 0x00034D40
		[Token(Token = "0x60079FC")]
		public bool Register<T>(NetMsgID id) where T : Protocol, new()
		{
			return default(bool);
		}

		// Token: 0x04007802 RID: 30722
		[Token(Token = "0x4007802")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Func<Protocol>> m_creators;

		// Token: 0x04007803 RID: 30723
		[Token(Token = "0x4007803")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<Protocol> m_protocols;

		// Token: 0x04007804 RID: 30724
		[Token(Token = "0x4007804")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<NetMsgID, int> m_idFinder;

		// Token: 0x04007805 RID: 30725
		[Token(Token = "0x4007805")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<Type, int> m_typeFinder;

		// Token: 0x04007806 RID: 30726
		[Token(Token = "0x4007806")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<Type, NetMsgID> m_typeIdFinder;
	}
}
