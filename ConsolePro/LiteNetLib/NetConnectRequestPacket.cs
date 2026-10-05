using System;
using System.Net;
using FlyingWormConsole3.LiteNetLib.Utils;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	internal sealed class NetConnectRequestPacket
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x369B310", Offset = "0x3699F10", VA = "0x18369B310")]
		private NetConnectRequestPacket(long connectionTime, byte connectionNumber, byte[] targetAddress, NetDataReader data)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x369B120", Offset = "0x3699D20", VA = "0x18369B120")]
		public static int GetProtocolId(NetPacket packet)
		{
			return 0;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x369AF20", Offset = "0x3699B20", VA = "0x18369AF20")]
		public static NetConnectRequestPacket FromData(NetPacket packet)
		{
			return null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x369B180", Offset = "0x3699D80", VA = "0x18369B180")]
		public static NetPacket Make(NetDataWriter connectData, SocketAddress addressBytes, long connectId)
		{
			return null;
		}

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		public const int HeaderSize = 14;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x10")]
		public readonly long ConnectionTime;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x18")]
		public readonly byte ConnectionNumber;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x20")]
		public readonly byte[] TargetAddress;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x28")]
		public readonly NetDataReader Data;
	}
}
