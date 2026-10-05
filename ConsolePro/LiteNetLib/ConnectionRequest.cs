using System;
using System.Net;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib.Utils;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class ConnectionRequest
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002084 File Offset: 0x00000284
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		internal ConnectionRequestResult Result
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			[CompilerGenerated]
			get
			{
				return ConnectionRequestResult.None;
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x3698490", Offset = "0x3697090", VA = "0x183698490")]
		private bool TryActivate()
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x36984C0", Offset = "0x36970C0", VA = "0x1836984C0")]
		internal void UpdateRequest(NetConnectRequestPacket connRequest)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x36984F0", Offset = "0x36970F0", VA = "0x1836984F0")]
		internal ConnectionRequest(long connectionId, byte connectionNumber, NetDataReader netDataReader, IPEndPoint endPoint, NetManager listener)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x3697E90", Offset = "0x3696A90", VA = "0x183697E90")]
		public NetPeer AcceptIfKey(string key)
		{
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x3697FC0", Offset = "0x3696BC0", VA = "0x183697FC0")]
		public NetPeer Accept()
		{
			return null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x3698310", Offset = "0x3696F10", VA = "0x183698310")]
		public void Reject(byte[] rejectData, int start, int length, bool force)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3698400", Offset = "0x3697000", VA = "0x183698400")]
		public void Reject(byte[] rejectData, int start, int length)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3698020", Offset = "0x3696C20", VA = "0x183698020")]
		public void RejectForce(byte[] rejectData, int start, int length)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3698130", Offset = "0x3696D30", VA = "0x183698130")]
		public void RejectForce()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x36980B0", Offset = "0x3696CB0", VA = "0x1836980B0")]
		public void RejectForce(byte[] rejectData)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3698190", Offset = "0x3696D90", VA = "0x183698190")]
		public void RejectForce(NetDataWriter rejectData)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x36983A0", Offset = "0x3696FA0", VA = "0x1836983A0")]
		public void Reject()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3698210", Offset = "0x3696E10", VA = "0x183698210")]
		public void Reject(byte[] rejectData)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3698290", Offset = "0x3696E90", VA = "0x183698290")]
		public void Reject(NetDataWriter rejectData)
		{
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		private readonly NetManager _listener;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		private int _used;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x20")]
		public readonly NetDataReader Data;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x30")]
		internal long ConnectionTime;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x38")]
		internal byte ConnectionNumber;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x40")]
		public readonly IPEndPoint RemoteEndPoint;
	}
}
