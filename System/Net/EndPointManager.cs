using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200030F RID: 783
	[Token(Token = "0x200030F")]
	internal sealed class EndPointManager
	{
		// Token: 0x06001581 RID: 5505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x5070340", Offset = "0x506EF40", VA = "0x185070340")]
		public static void AddListener(HttpListener listener)
		{
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x5070960", Offset = "0x506F560", VA = "0x185070960")]
		public static void AddPrefix(string prefix, HttpListener listener)
		{
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x5070780", Offset = "0x506F380", VA = "0x185070780")]
		private static void AddPrefixInternal(string p, HttpListener listener)
		{
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001584")]
		[Address(RVA = "0x5070A60", Offset = "0x506F660", VA = "0x185070A60")]
		private static EndPointListener GetEPListener(string host, int port, HttpListener listener, bool secure)
		{
			return null;
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001585")]
		[Address(RVA = "0x5070F80", Offset = "0x506FB80", VA = "0x185070F80")]
		public static void RemoveEndPoint(EndPointListener epl, IPEndPoint ep)
		{
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x5071260", Offset = "0x506FE60", VA = "0x185071260")]
		public static void RemoveListener(HttpListener listener)
		{
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x5071650", Offset = "0x5070250", VA = "0x185071650")]
		public static void RemovePrefix(string prefix, HttpListener listener)
		{
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x5071510", Offset = "0x5070110", VA = "0x185071510")]
		private static void RemovePrefixInternal(string prefix, HttpListener listener)
		{
		}

		// Token: 0x04000BBD RID: 3005
		[Token(Token = "0x4000BBD")]
		[FieldOffset(Offset = "0x0")]
		private static Hashtable ip_to_endpoints;
	}
}
