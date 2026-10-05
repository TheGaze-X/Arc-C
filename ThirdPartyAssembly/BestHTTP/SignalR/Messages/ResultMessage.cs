using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Messages
{
	// Token: 0x0200054C RID: 1356
	[Token(Token = "0x200054C")]
	public sealed class ResultMessage : IServerMessage, IHubMessage
	{
		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x00012CD8 File Offset: 0x00010ED8
		[Token(Token = "0x170006C6")]
		private MessageTypes Type
		{
			[Token(Token = "0x6002D11")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "4")]
			get
			{
				return MessageTypes.KeepAlive;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002D12 RID: 11538 RVA: 0x00012CF0 File Offset: 0x00010EF0
		// (set) Token: 0x06002D13 RID: 11539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C7")]
		public ulong InvocationId
		{
			[Token(Token = "0x6002D12")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002D13")]
			[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D15 RID: 11541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C8")]
		public object ReturnValue
		{
			[Token(Token = "0x6002D14")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D15")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D17 RID: 11543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C9")]
		public IDictionary<string, object> State
		{
			[Token(Token = "0x6002D16")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D17")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D18")]
		[Address(RVA = "0x53F4490", Offset = "0x53F3090", VA = "0x1853F4490", Slot = "5")]
		private void Parse(object data)
		{
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D19")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ResultMessage()
		{
		}
	}
}
