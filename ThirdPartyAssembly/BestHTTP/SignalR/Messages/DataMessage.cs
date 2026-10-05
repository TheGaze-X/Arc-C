using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Messages
{
	// Token: 0x0200054A RID: 1354
	[Token(Token = "0x200054A")]
	public sealed class DataMessage : IServerMessage
	{
		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[Token(Token = "0x170006BF")]
		private MessageTypes Type
		{
			[Token(Token = "0x6002D01")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
			get
			{
				return MessageTypes.KeepAlive;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D03 RID: 11523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C0")]
		public object Data
		{
			[Token(Token = "0x6002D02")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D03")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D04")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "5")]
		private void Parse(object data)
		{
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D05")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DataMessage()
		{
		}
	}
}
