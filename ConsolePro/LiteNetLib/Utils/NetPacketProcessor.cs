using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	public class NetPacketProcessor
	{
		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x36B0210", Offset = "0x36AEE10", VA = "0x1836B0210")]
		public NetPacketProcessor()
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x36B0310", Offset = "0x36AEF10", VA = "0x1836B0310")]
		public NetPacketProcessor(int maxStringLength)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000222")]
		protected virtual ulong GetHash<T>()
		{
			return 0UL;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x36AFF50", Offset = "0x36AEB50", VA = "0x1836AFF50", Slot = "5")]
		protected virtual NetPacketProcessor.SubscribeDelegate GetCallbackFromData(NetDataReader reader)
		{
			return null;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		protected virtual void WriteHash<T>(NetDataWriter writer)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		public void RegisterNestedType<T>() where T : struct, INetSerializable
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		public void RegisterNestedType<T>(Action<NetDataWriter, T> writeDelegate, Func<NetDataReader, T> readDelegate)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000227")]
		public void RegisterNestedType<T>(Func<T> constructor) where T : class, INetSerializable
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x36B00B0", Offset = "0x36AECB0", VA = "0x1836B00B0")]
		public void ReadAllPackets(NetDataReader reader)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x36B0020", Offset = "0x36AEC20", VA = "0x1836B0020")]
		public void ReadAllPackets(NetDataReader reader, object userData)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x36B0130", Offset = "0x36AED30", VA = "0x1836B0130")]
		public void ReadPacket(NetDataReader reader)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		public void Send<T>(NetPeer peer, T packet, DeliveryMethod options) where T : class, new()
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		public void SendNetSerializable<T>(NetPeer peer, T packet, DeliveryMethod options) where T : INetSerializable
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		public void Send<T>(NetManager manager, T packet, DeliveryMethod options) where T : class, new()
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		public void SendNetSerializable<T>(NetManager manager, T packet, DeliveryMethod options) where T : INetSerializable
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		public void Write<T>(NetDataWriter writer, T packet) where T : class, new()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		public void WriteNetSerializable<T>(NetDataWriter writer, T packet) where T : INetSerializable
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000231")]
		public byte[] Write<T>(T packet) where T : class, new()
		{
			return null;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000232")]
		public byte[] WriteNetSerializable<T>(T packet) where T : INetSerializable
		{
			return null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x36B01A0", Offset = "0x36AEDA0", VA = "0x1836B01A0")]
		public void ReadPacket(NetDataReader reader, object userData)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		public void Subscribe<T>(Action<T> onReceive, Func<T> packetConstructor) where T : class, new()
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		public void Subscribe<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor) where T : class, new()
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000236")]
		public void SubscribeReusable<T>(Action<T> onReceive) where T : class, new()
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000237")]
		public void SubscribeReusable<T, TUserData>(Action<T, TUserData> onReceive) where T : class, new()
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		public void SubscribeNetSerializable<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor) where T : INetSerializable
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		public void SubscribeNetSerializable<T>(Action<T> onReceive, Func<T> packetConstructor) where T : INetSerializable
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		public void SubscribeNetSerializable<T, TUserData>(Action<T, TUserData> onReceive) where T : INetSerializable, new()
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		public void SubscribeNetSerializable<T>(Action<T> onReceive) where T : INetSerializable, new()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x600023C")]
		public bool RemoveSubscription<T>()
		{
			return default(bool);
		}

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x10")]
		private readonly NetSerializer _netSerializer;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<ulong, NetPacketProcessor.SubscribeDelegate> _callbacks;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x20")]
		private readonly NetDataWriter _netDataWriter;

		// Token: 0x0200004A RID: 74
		[Token(Token = "0x200004A")]
		private static class HashCache<T>
		{
			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ulong Id;
		}

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600023F RID: 575
		[Token(Token = "0x200004B")]
		protected delegate void SubscribeDelegate(NetDataReader reader, object userData);
	}
}
