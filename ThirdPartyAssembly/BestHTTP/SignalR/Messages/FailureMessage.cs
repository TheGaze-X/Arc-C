using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Messages
{
	// Token: 0x0200054D RID: 1357
	[Token(Token = "0x200054D")]
	public sealed class FailureMessage : IServerMessage, IHubMessage
	{
		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x00012D08 File Offset: 0x00010F08
		[Token(Token = "0x170006CA")]
		private MessageTypes Type
		{
			[Token(Token = "0x6002D1A")]
			[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "4")]
			get
			{
				return MessageTypes.KeepAlive;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x00012D20 File Offset: 0x00010F20
		// (set) Token: 0x06002D1C RID: 11548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CB")]
		public ulong InvocationId
		{
			[Token(Token = "0x6002D1B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002D1C")]
			[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x00012D38 File Offset: 0x00010F38
		// (set) Token: 0x06002D1E RID: 11550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CC")]
		public bool IsHubError
		{
			[Token(Token = "0x6002D1D")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002D1E")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D20 RID: 11552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CD")]
		public string ErrorMessage
		{
			[Token(Token = "0x6002D1F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D20")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D22 RID: 11554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CE")]
		public IDictionary<string, object> AdditionalData
		{
			[Token(Token = "0x6002D21")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D22")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CF")]
		public string StackTrace
		{
			[Token(Token = "0x6002D23")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D24")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002D25 RID: 11557 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D26 RID: 11558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D0")]
		public IDictionary<string, object> State
		{
			[Token(Token = "0x6002D25")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D26")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D27")]
		[Address(RVA = "0x53EA530", Offset = "0x53E9130", VA = "0x1853EA530", Slot = "5")]
		private void Parse(object data)
		{
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D28")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FailureMessage()
		{
		}
	}
}
