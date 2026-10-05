using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO.Events
{
	// Token: 0x0200052A RID: 1322
	[Token(Token = "0x200052A")]
	internal sealed class EventTable
	{
		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000688")]
		private Socket Socket
		{
			[Token(Token = "0x6002BFD")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BFE")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BFF")]
		[Address(RVA = "0x53EA490", Offset = "0x53E9090", VA = "0x1853EA490")]
		public EventTable(Socket socket)
		{
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C00")]
		[Address(RVA = "0x53E9F40", Offset = "0x53E8B40", VA = "0x1853E9F40")]
		public void Register(string eventName, SocketIOCallback callback, bool onlyOnce, bool autoDecodePayload)
		{
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C01")]
		[Address(RVA = "0x53EA340", Offset = "0x53E8F40", VA = "0x1853EA340")]
		public void Unregister(string eventName)
		{
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C02")]
		[Address(RVA = "0x53EA3A0", Offset = "0x53E8FA0", VA = "0x1853EA3A0")]
		public void Unregister(string eventName, SocketIOCallback callback)
		{
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C03")]
		[Address(RVA = "0x53E9CC0", Offset = "0x53E88C0", VA = "0x1853E9CC0")]
		public void Call(string eventName, Packet packet, params object[] args)
		{
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C04")]
		[Address(RVA = "0x53E99F0", Offset = "0x53E85F0", VA = "0x1853E99F0")]
		public void Call(Packet packet)
		{
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C05")]
		[Address(RVA = "0x53E9E90", Offset = "0x53E8A90", VA = "0x1853E9E90")]
		public void Clear()
		{
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00012978 File Offset: 0x00010B78
		[Token(Token = "0x6002C06")]
		[Address(RVA = "0x53EA220", Offset = "0x53E8E20", VA = "0x1853EA220")]
		private bool ShouldDecodePayload(string eventName)
		{
			return default(bool);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x00012990 File Offset: 0x00010B90
		[Token(Token = "0x6002C07")]
		[Address(RVA = "0x53E9EE0", Offset = "0x53E8AE0", VA = "0x1853E9EE0")]
		private bool HasSubsciber(string eventName)
		{
			return default(bool);
		}

		// Token: 0x040018E9 RID: 6377
		[Token(Token = "0x40018E9")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, List<EventDescriptor>> Table;
	}
}
