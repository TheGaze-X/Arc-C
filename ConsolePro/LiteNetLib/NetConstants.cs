using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public static class NetConstants
	{
		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		public const int DefaultWindowSize = 64;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		public const int SocketBufferSize = 1048576;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		public const int SocketTTL = 255;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		public const int HeaderSize = 1;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		public const int ChanneledHeaderSize = 4;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		public const int FragmentHeaderSize = 6;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		public const int FragmentedHeaderTotalSize = 10;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		public const ushort MaxSequence = 32768;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		public const ushort HalfMaxSequence = 16384;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		internal const int ProtocolId = 11;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		internal const int MaxUdpHeaderSize = 68;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int[] PossibleMtu;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int MaxPacketSize;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		public const byte MaxConnectionNumber = 4;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		public const int PacketPoolSize = 1000;
	}
}
