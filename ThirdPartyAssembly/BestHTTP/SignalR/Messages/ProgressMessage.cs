using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Messages
{
	// Token: 0x0200054E RID: 1358
	[Token(Token = "0x200054E")]
	public sealed class ProgressMessage : IServerMessage, IHubMessage
	{
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x00012D50 File Offset: 0x00010F50
		[Token(Token = "0x170006D1")]
		private MessageTypes Type
		{
			[Token(Token = "0x6002D29")]
			[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "4")]
			get
			{
				return MessageTypes.KeepAlive;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002D2A RID: 11562 RVA: 0x00012D68 File Offset: 0x00010F68
		// (set) Token: 0x06002D2B RID: 11563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D2")]
		public ulong InvocationId
		{
			[Token(Token = "0x6002D2A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002D2B")]
			[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06002D2C RID: 11564 RVA: 0x00012D80 File Offset: 0x00010F80
		// (set) Token: 0x06002D2D RID: 11565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D3")]
		public double Progress
		{
			[Token(Token = "0x6002D2C")]
			[Address(RVA = "0x28615D0", Offset = "0x28601D0", VA = "0x1828615D0")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6002D2D")]
			[Address(RVA = "0x53F4480", Offset = "0x53F3080", VA = "0x1853F4480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2E")]
		[Address(RVA = "0x53F4300", Offset = "0x53F2F00", VA = "0x1853F4300", Slot = "5")]
		private void Parse(object data)
		{
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D2F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ProgressMessage()
		{
		}
	}
}
