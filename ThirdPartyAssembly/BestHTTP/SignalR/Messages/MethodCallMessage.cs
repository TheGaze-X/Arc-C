using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Messages
{
	// Token: 0x0200054B RID: 1355
	[Token(Token = "0x200054B")]
	public sealed class MethodCallMessage : IServerMessage
	{
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x00012CC0 File Offset: 0x00010EC0
		[Token(Token = "0x170006C1")]
		private MessageTypes Type
		{
			[Token(Token = "0x6002D06")]
			[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "4")]
			get
			{
				return MessageTypes.KeepAlive;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002D07 RID: 11527 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D08 RID: 11528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C2")]
		public string Hub
		{
			[Token(Token = "0x6002D07")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D08")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D0A RID: 11530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C3")]
		public string Method
		{
			[Token(Token = "0x6002D09")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D0A")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C4")]
		public object[] Arguments
		{
			[Token(Token = "0x6002D0B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D0C")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D0E RID: 11534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C5")]
		public IDictionary<string, object> State
		{
			[Token(Token = "0x6002D0D")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D0E")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0F")]
		[Address(RVA = "0x53EDF50", Offset = "0x53ECB50", VA = "0x1853EDF50", Slot = "5")]
		private void Parse(object data)
		{
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D10")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MethodCallMessage()
		{
		}
	}
}
