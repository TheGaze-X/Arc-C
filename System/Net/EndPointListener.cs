using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200030E RID: 782
	[Token(Token = "0x200030E")]
	internal sealed class EndPointListener
	{
		// Token: 0x06001571 RID: 5489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x50700A0", Offset = "0x506ECA0", VA = "0x1850700A0")]
		public EndPointListener(HttpListener listener, IPAddress addr, int port, bool secure)
		{
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000488")]
		internal HttpListener Listener
		{
			[Token(Token = "0x6001572")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x506E290", Offset = "0x506CE90", VA = "0x18506E290")]
		private static void Accept(Socket socket, SocketAsyncEventArgs e, ref Socket accepted)
		{
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x506F190", Offset = "0x506DD90", VA = "0x18506F190")]
		private static void ProcessAccept(SocketAsyncEventArgs args)
		{
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x506F180", Offset = "0x506DD80", VA = "0x18506F180")]
		private static void OnAccept(object sender, SocketAsyncEventArgs e)
		{
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x506F3B0", Offset = "0x506DFB0", VA = "0x18506F3B0")]
		internal void RemoveConnection(HttpConnection conn)
		{
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00009F18 File Offset: 0x00008118
		[Token(Token = "0x6001577")]
		[Address(RVA = "0x506EAA0", Offset = "0x506D6A0", VA = "0x18506EAA0")]
		public bool BindContext(HttpListenerContext context)
		{
			return default(bool);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x5070070", Offset = "0x506EC70", VA = "0x185070070")]
		public void UnbindContext(HttpListenerContext context)
		{
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001579")]
		[Address(RVA = "0x506FB50", Offset = "0x506E750", VA = "0x18506FB50")]
		private HttpListener SearchListener(Uri uri, out ListenerPrefix prefix)
		{
			return null;
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157A")]
		[Address(RVA = "0x506EEA0", Offset = "0x506DAA0", VA = "0x18506EEA0")]
		private HttpListener MatchFromList(string host, string path, ArrayList list, out ListenerPrefix prefix)
		{
			return null;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157B")]
		[Address(RVA = "0x506E830", Offset = "0x506D430", VA = "0x18506E830")]
		private void AddSpecial(ArrayList coll, ListenerPrefix prefix)
		{
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00009F30 File Offset: 0x00008130
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x506FA30", Offset = "0x506E630", VA = "0x18506FA30")]
		private bool RemoveSpecial(ArrayList coll, ListenerPrefix prefix)
		{
			return default(bool);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x506EB20", Offset = "0x506D720", VA = "0x18506EB20")]
		private void CheckIfRemove()
		{
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x506EC30", Offset = "0x506D830", VA = "0x18506EC30")]
		public void Close()
		{
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x506E340", Offset = "0x506CF40", VA = "0x18506E340")]
		public void AddPrefix(ListenerPrefix prefix, HttpListener listener)
		{
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x506F480", Offset = "0x506E080", VA = "0x18506F480")]
		public void RemovePrefix(ListenerPrefix prefix, HttpListener listener)
		{
		}

		// Token: 0x04000BB4 RID: 2996
		[Token(Token = "0x4000BB4")]
		[FieldOffset(Offset = "0x10")]
		private HttpListener listener;

		// Token: 0x04000BB5 RID: 2997
		[Token(Token = "0x4000BB5")]
		[FieldOffset(Offset = "0x18")]
		private IPEndPoint endpoint;

		// Token: 0x04000BB6 RID: 2998
		[Token(Token = "0x4000BB6")]
		[FieldOffset(Offset = "0x20")]
		private Socket sock;

		// Token: 0x04000BB7 RID: 2999
		[Token(Token = "0x4000BB7")]
		[FieldOffset(Offset = "0x28")]
		private Hashtable prefixes;

		// Token: 0x04000BB8 RID: 3000
		[Token(Token = "0x4000BB8")]
		[FieldOffset(Offset = "0x30")]
		private ArrayList unhandled;

		// Token: 0x04000BB9 RID: 3001
		[Token(Token = "0x4000BB9")]
		[FieldOffset(Offset = "0x38")]
		private ArrayList all;

		// Token: 0x04000BBA RID: 3002
		[Token(Token = "0x4000BBA")]
		[FieldOffset(Offset = "0x40")]
		private X509Certificate cert;

		// Token: 0x04000BBB RID: 3003
		[Token(Token = "0x4000BBB")]
		[FieldOffset(Offset = "0x48")]
		private bool secure;

		// Token: 0x04000BBC RID: 3004
		[Token(Token = "0x4000BBC")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<HttpConnection, HttpConnection> unregistered;
	}
}
