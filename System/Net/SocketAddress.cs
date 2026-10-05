using System;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002BE RID: 702
	[Token(Token = "0x20002BE")]
	public class SocketAddress
	{
		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x000095D0 File Offset: 0x000077D0
		[Token(Token = "0x17000412")]
		public AddressFamily Family
		{
			[Token(Token = "0x600137C")]
			[Address(RVA = "0x505D110", Offset = "0x505BD10", VA = "0x18505D110")]
			get
			{
				return AddressFamily.Unspecified;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x17000413")]
		public int Size
		{
			[Token(Token = "0x600137D")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000414 RID: 1044
		[Token(Token = "0x17000414")]
		public byte this[int offset]
		{
			[Token(Token = "0x600137E")]
			[Address(RVA = "0x505D150", Offset = "0x505BD50", VA = "0x18505D150")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600137F")]
		[Address(RVA = "0x505CCB0", Offset = "0x505B8B0", VA = "0x18505CCB0")]
		public SocketAddress(AddressFamily family, int size)
		{
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001380")]
		[Address(RVA = "0x505CDE0", Offset = "0x505B9E0", VA = "0x18505CDE0")]
		internal SocketAddress(IPAddress ipAddress)
		{
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001381")]
		[Address(RVA = "0x505CC50", Offset = "0x505B850", VA = "0x18505CC50")]
		internal SocketAddress(IPAddress ipaddress, int port)
		{
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001382")]
		[Address(RVA = "0x505C580", Offset = "0x505B180", VA = "0x18505C580")]
		internal IPAddress GetIPAddress()
		{
			return null;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001383")]
		[Address(RVA = "0x505C7E0", Offset = "0x505B3E0", VA = "0x18505C7E0")]
		internal IPEndPoint GetIPEndPoint()
		{
			return null;
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00009618 File Offset: 0x00007818
		[Token(Token = "0x6001384")]
		[Address(RVA = "0x505C320", Offset = "0x505AF20", VA = "0x18505C320", Slot = "0")]
		public override bool Equals(object comparand)
		{
			return default(bool);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00009630 File Offset: 0x00007830
		[Token(Token = "0x6001385")]
		[Address(RVA = "0x505C470", Offset = "0x505B070", VA = "0x18505C470", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001386")]
		[Address(RVA = "0x505C890", Offset = "0x505B490", VA = "0x18505C890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0x10")]
		internal int m_Size;

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0x18")]
		internal byte[] m_Buffer;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x20")]
		private bool m_changed;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		[FieldOffset(Offset = "0x24")]
		private int m_hash;
	}
}
