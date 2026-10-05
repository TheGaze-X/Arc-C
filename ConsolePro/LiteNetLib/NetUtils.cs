using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	public static class NetUtils
	{
		// Token: 0x0600017C RID: 380 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x36AD510", Offset = "0x36AC110", VA = "0x1836AD510")]
		public static IPEndPoint MakeEndPoint(string hostStr, int port)
		{
			return null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x36AD8F0", Offset = "0x36AC4F0", VA = "0x1836AD8F0")]
		public static IPAddress ResolveAddress(string hostStr)
		{
			return null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x36AD860", Offset = "0x36AC460", VA = "0x1836AD860")]
		public static IPAddress ResolveAddress(string hostStr, AddressFamily addressFamily)
		{
			return null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x36ACDE0", Offset = "0x36AB9E0", VA = "0x1836ACDE0")]
		public static List<string> GetLocalIpList(LocalAddrType addrType)
		{
			return null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x36ACE80", Offset = "0x36ABA80", VA = "0x1836ACE80")]
		public static void GetLocalIpList(IList<string> targetList, LocalAddrType addrType)
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x36AD310", Offset = "0x36ABF10", VA = "0x1836AD310")]
		public static string GetLocalIp(LocalAddrType addrType)
		{
			return null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x36AD5B0", Offset = "0x36AC1B0", VA = "0x1836AD5B0")]
		internal static void PrintInterfaceInfos()
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x36AD830", Offset = "0x36AC430", VA = "0x1836AD830")]
		internal static int RelativeSequenceNumber(int number, int expected)
		{
			return 0;
		}

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<string> IpList;
	}
}
