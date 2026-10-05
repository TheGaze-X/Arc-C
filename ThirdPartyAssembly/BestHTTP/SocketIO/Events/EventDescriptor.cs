using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO.Events
{
	// Token: 0x02000528 RID: 1320
	[Token(Token = "0x2000528")]
	internal sealed class EventDescriptor
	{
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002BF2 RID: 11250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000685")]
		public List<SocketIOCallback> Callbacks
		{
			[Token(Token = "0x6002BF1")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BF2")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x00012930 File Offset: 0x00010B30
		// (set) Token: 0x06002BF4 RID: 11252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000686")]
		public bool OnlyOnce
		{
			[Token(Token = "0x6002BF3")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002BF4")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x00012948 File Offset: 0x00010B48
		// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000687")]
		public bool AutoDecodePayload
		{
			[Token(Token = "0x6002BF5")]
			[Address(RVA = "0x54A770", Offset = "0x549370", VA = "0x18054A770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002BF6")]
			[Address(RVA = "0x54A790", Offset = "0x549390", VA = "0x18054A790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BF7")]
		[Address(RVA = "0x53E8C80", Offset = "0x53E7880", VA = "0x1853E8C80")]
		public EventDescriptor(bool onlyOnce, bool autoDecodePayload, SocketIOCallback callback)
		{
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BF8")]
		[Address(RVA = "0x53E8990", Offset = "0x53E7590", VA = "0x1853E8990")]
		public void Call(Socket socket, Packet packet, params object[] args)
		{
		}

		// Token: 0x040018DD RID: 6365
		[Token(Token = "0x40018DD")]
		[FieldOffset(Offset = "0x20")]
		private SocketIOCallback[] CallbackArray;
	}
}
