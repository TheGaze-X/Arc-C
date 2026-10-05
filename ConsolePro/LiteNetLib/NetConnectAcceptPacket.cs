using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	internal sealed class NetConnectAcceptPacket
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x369AED0", Offset = "0x3699AD0", VA = "0x18369AED0")]
		private NetConnectAcceptPacket(long connectionId, byte connectionNumber, bool isReusedPeer)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x369AD10", Offset = "0x3699910", VA = "0x18369AD10")]
		public static NetConnectAcceptPacket FromData(NetPacket packet)
		{
			return null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x369AE10", Offset = "0x3699A10", VA = "0x18369AE10")]
		public static NetPacket Make(long connectId, byte connectNum, bool reusedPeer)
		{
			return null;
		}

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		public const int Size = 11;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x10")]
		public readonly long ConnectionId;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x18")]
		public readonly byte ConnectionNumber;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x19")]
		public readonly bool IsReusedPeer;
	}
}
