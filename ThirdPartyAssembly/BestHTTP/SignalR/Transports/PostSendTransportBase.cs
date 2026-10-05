using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Transports
{
	// Token: 0x0200053F RID: 1343
	[Token(Token = "0x200053F")]
	public abstract class PostSendTransportBase : TransportBase
	{
		// Token: 0x06002CB0 RID: 11440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB0")]
		[Address(RVA = "0x53F4250", Offset = "0x53F2E50", VA = "0x1853F4250")]
		public PostSendTransportBase(string name, Connection con)
		{
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB1")]
		[Address(RVA = "0x53F40B0", Offset = "0x53F2CB0", VA = "0x1853F40B0", Slot = "8")]
		protected override void SendImpl(string json)
		{
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB2")]
		[Address(RVA = "0x53F3D50", Offset = "0x53F2950", VA = "0x1853F3D50")]
		private void OnSendRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x0400194F RID: 6479
		[Token(Token = "0x400194F")]
		[FieldOffset(Offset = "0x30")]
		protected List<HTTPRequest> sendRequestQueue;
	}
}
