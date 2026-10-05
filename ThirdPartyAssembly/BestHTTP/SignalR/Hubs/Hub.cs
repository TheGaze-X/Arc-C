using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using BestHTTP.SignalR.Messages;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Hubs
{
	// Token: 0x02000554 RID: 1364
	[Token(Token = "0x2000554")]
	public class Hub : IHub
	{
		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D4")]
		public string Name
		{
			[Token(Token = "0x6002D44")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D45")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D5")]
		public Dictionary<string, object> State
		{
			[Token(Token = "0x6002D46")]
			[Address(RVA = "0x53ECD90", Offset = "0x53EB990", VA = "0x1853ECD90")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06002D47 RID: 11591 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002D48 RID: 11592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000015")]
		public event OnMethodCallDelegate OnMethodCall
		{
			[Token(Token = "0x6002D47")]
			[Address(RVA = "0x53ECCF0", Offset = "0x53EB8F0", VA = "0x1853ECCF0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002D48")]
			[Address(RVA = "0x53ECE20", Offset = "0x53EBA20", VA = "0x1853ECE20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D4A RID: 11594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D6")]
		private Connection Connection
		{
			[Token(Token = "0x6002D49")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D4A")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4B")]
		[Address(RVA = "0x53ECB80", Offset = "0x53EB780", VA = "0x1853ECB80")]
		public Hub(string name)
		{
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4C")]
		[Address(RVA = "0x53ECB90", Offset = "0x53EB790", VA = "0x1853ECB90")]
		public Hub(string name, Connection manager)
		{
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4D")]
		[Address(RVA = "0x53ECB10", Offset = "0x53EB710", VA = "0x1853ECB10")]
		public void On(string method, OnMethodCallCallbackDelegate callback)
		{
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D4E")]
		[Address(RVA = "0x53ECAB0", Offset = "0x53EB6B0", VA = "0x1853ECAB0")]
		public void Off(string method)
		{
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x00012D98 File Offset: 0x00010F98
		[Token(Token = "0x6002D4F")]
		[Address(RVA = "0x53EC440", Offset = "0x53EB040", VA = "0x1853EC440")]
		public bool Call(string method, params object[] args)
		{
			return default(bool);
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x00012DB0 File Offset: 0x00010FB0
		[Token(Token = "0x6002D50")]
		[Address(RVA = "0x53EC410", Offset = "0x53EB010", VA = "0x1853EC410")]
		public bool Call(string method, OnMethodResultDelegate onResult, params object[] args)
		{
			return default(bool);
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x00012DC8 File Offset: 0x00010FC8
		[Token(Token = "0x6002D51")]
		[Address(RVA = "0x53EC7C0", Offset = "0x53EB3C0", VA = "0x1853EC7C0")]
		public bool Call(string method, OnMethodResultDelegate onResult, OnMethodFailedDelegate onResultError, params object[] args)
		{
			return default(bool);
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x00012DE0 File Offset: 0x00010FE0
		[Token(Token = "0x6002D52")]
		[Address(RVA = "0x53EC470", Offset = "0x53EB070", VA = "0x1853EC470")]
		public bool Call(string method, OnMethodResultDelegate onResult, OnMethodProgressDelegate onProgress, params object[] args)
		{
			return default(bool);
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x00012DF8 File Offset: 0x00010FF8
		[Token(Token = "0x6002D53")]
		[Address(RVA = "0x53EC4A0", Offset = "0x53EB0A0", VA = "0x1853EC4A0")]
		public bool Call(string method, OnMethodResultDelegate onResult, OnMethodFailedDelegate onResultError, OnMethodProgressDelegate onProgress, params object[] args)
		{
			return default(bool);
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x00012E10 File Offset: 0x00011010
		[Token(Token = "0x6002D54")]
		[Address(RVA = "0x53EB2D0", Offset = "0x53E9ED0", VA = "0x1853EB2D0", Slot = "6")]
		private bool Call(ClientMessage msg)
		{
			return default(bool);
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x00012E28 File Offset: 0x00011028
		[Token(Token = "0x6002D55")]
		[Address(RVA = "0x53EB520", Offset = "0x53EA120", VA = "0x1853EB520", Slot = "7")]
		private bool HasSentMessageId(ulong id)
		{
			return default(bool);
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D56")]
		[Address(RVA = "0x53EB4D0", Offset = "0x53EA0D0", VA = "0x1853EB4D0", Slot = "8")]
		private void Close()
		{
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D57")]
		[Address(RVA = "0x53EBB10", Offset = "0x53EA710", VA = "0x1853EBB10", Slot = "9")]
		private void OnMethod(MethodCallMessage msg)
		{
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D58")]
		[Address(RVA = "0x53EB580", Offset = "0x53EA180", VA = "0x1853EB580", Slot = "10")]
		private void OnMessage(IServerMessage msg)
		{
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D59")]
		[Address(RVA = "0x53EC7F0", Offset = "0x53EB3F0", VA = "0x1853EC7F0")]
		private void MergeState(IDictionary<string, object> state)
		{
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5A")]
		[Address(RVA = "0x53EBE60", Offset = "0x53EAA60", VA = "0x1853EBE60")]
		private string BuildMessage(ClientMessage msg)
		{
			return null;
		}

		// Token: 0x04001977 RID: 6519
		[Token(Token = "0x4001977")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, object> state;

		// Token: 0x04001979 RID: 6521
		[Token(Token = "0x4001979")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<ulong, ClientMessage> SentMessages;

		// Token: 0x0400197A RID: 6522
		[Token(Token = "0x400197A")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, OnMethodCallCallbackDelegate> MethodTable;

		// Token: 0x0400197B RID: 6523
		[Token(Token = "0x400197B")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder builder;
	}
}
