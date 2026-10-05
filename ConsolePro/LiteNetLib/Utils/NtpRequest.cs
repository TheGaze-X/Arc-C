using System;
using System.Net;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	internal sealed class NtpRequest
	{
		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x36B1E60", Offset = "0x36B0A60", VA = "0x1836B1E60")]
		public NtpRequest(IPEndPoint endPoint)
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x17000048")]
		public bool NeedToKill
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x36B1EA0", Offset = "0x36B0AA0", VA = "0x1836B1EA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x36B1D70", Offset = "0x36B0970", VA = "0x1836B1D70")]
		public bool Send(NetSocket socket, int time)
		{
			return default(bool);
		}

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		private const int ResendTimer = 1000;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		private const int KillTimer = 10000;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		public const int DefaultPort = 123;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x10")]
		private readonly IPEndPoint _ntpEndPoint;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x18")]
		private int _resendTime;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x1C")]
		private int _killTime;
	}
}
