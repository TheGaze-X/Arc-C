using System;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Messages
{
	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	public sealed class KeepAliveMessage : IServerMessage
	{
		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x00012C30 File Offset: 0x00010E30
		[Token(Token = "0x170006B7")]
		private MessageTypes Type
		{
			[Token(Token = "0x6002CEF")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
			get
			{
				return MessageTypes.KeepAlive;
			}
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		private void Parse(object data)
		{
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public KeepAliveMessage()
		{
		}
	}
}
