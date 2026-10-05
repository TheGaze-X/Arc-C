using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Messages
{
	// Token: 0x02000549 RID: 1353
	[Token(Token = "0x2000549")]
	public sealed class MultiMessage : IServerMessage
	{
		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x00012C48 File Offset: 0x00010E48
		[Token(Token = "0x170006B8")]
		private MessageTypes Type
		{
			[Token(Token = "0x6002CF2")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "4")]
			get
			{
				return MessageTypes.KeepAlive;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B9")]
		public string MessageId
		{
			[Token(Token = "0x6002CF3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CF4")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x00012C60 File Offset: 0x00010E60
		// (set) Token: 0x06002CF6 RID: 11510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006BA")]
		public bool IsInitialization
		{
			[Token(Token = "0x6002CF5")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CF6")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006BB")]
		public string GroupsToken
		{
			[Token(Token = "0x6002CF7")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CF8")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x00012C78 File Offset: 0x00010E78
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006BC")]
		public bool ShouldReconnect
		{
			[Token(Token = "0x6002CF9")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CFA")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x00012C90 File Offset: 0x00010E90
		// (set) Token: 0x06002CFC RID: 11516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006BD")]
		public TimeSpan? PollDelay
		{
			[Token(Token = "0x6002CFB")]
			[Address(RVA = "0x4ED6A0", Offset = "0x4EC2A0", VA = "0x1804ED6A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CFC")]
			[Address(RVA = "0x4EEA20", Offset = "0x4ED620", VA = "0x1804EEA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006BE")]
		public List<IServerMessage> Data
		{
			[Token(Token = "0x6002CFD")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CFE")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFF")]
		[Address(RVA = "0x53EE3A0", Offset = "0x53ECFA0", VA = "0x1853EE3A0", Slot = "5")]
		private void Parse(object data)
		{
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D00")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MultiMessage()
		{
		}
	}
}
