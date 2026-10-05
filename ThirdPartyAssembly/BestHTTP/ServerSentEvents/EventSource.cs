using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.Extensions;
using Il2CppDummyDll;

namespace BestHTTP.ServerSentEvents
{
	// Token: 0x020004C7 RID: 1223
	[Token(Token = "0x20004C7")]
	public class EventSource : IHeartbeat
	{
		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C0")]
		public Uri Uri
		{
			[Token(Token = "0x6002843")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002844")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x00011340 File Offset: 0x0000F540
		// (set) Token: 0x06002846 RID: 10310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C1")]
		public States State
		{
			[Token(Token = "0x6002845")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return States.Initial;
			}
			[Token(Token = "0x6002846")]
			[Address(RVA = "0x53A2770", Offset = "0x53A1370", VA = "0x1853A2770")]
			private set
			{
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x00011358 File Offset: 0x0000F558
		// (set) Token: 0x06002848 RID: 10312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C2")]
		public TimeSpan ReconnectionTime
		{
			[Token(Token = "0x6002847")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002848")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600284A RID: 10314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C3")]
		public string LastEventId
		{
			[Token(Token = "0x6002849")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600284A")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600284B RID: 10315 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600284C RID: 10316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C4")]
		public HTTPRequest InternalRequest
		{
			[Token(Token = "0x600284B")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600284C")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600284D RID: 10317 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600284E RID: 10318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000007")]
		public event OnGeneralEventDelegate OnOpen
		{
			[Token(Token = "0x600284D")]
			[Address(RVA = "0x53A21D0", Offset = "0x53A0DD0", VA = "0x1853A21D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600284E")]
			[Address(RVA = "0x53A2590", Offset = "0x53A1190", VA = "0x1853A2590")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600284F RID: 10319 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002850 RID: 10320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000008")]
		public event OnMessageDelegate OnMessage
		{
			[Token(Token = "0x600284F")]
			[Address(RVA = "0x53A2130", Offset = "0x53A0D30", VA = "0x1853A2130")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002850")]
			[Address(RVA = "0x53A24F0", Offset = "0x53A10F0", VA = "0x1853A24F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06002851 RID: 10321 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002852 RID: 10322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000009")]
		public event OnErrorDelegate OnError
		{
			[Token(Token = "0x6002851")]
			[Address(RVA = "0x53A2090", Offset = "0x53A0C90", VA = "0x1853A2090")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002852")]
			[Address(RVA = "0x53A2450", Offset = "0x53A1050", VA = "0x1853A2450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06002853 RID: 10323 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002854 RID: 10324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000A")]
		public event OnRetryDelegate OnRetry
		{
			[Token(Token = "0x6002853")]
			[Address(RVA = "0x53A2270", Offset = "0x53A0E70", VA = "0x1853A2270")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002854")]
			[Address(RVA = "0x53A2630", Offset = "0x53A1230", VA = "0x1853A2630")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06002855 RID: 10325 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002856 RID: 10326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000B")]
		public event OnGeneralEventDelegate OnClosed
		{
			[Token(Token = "0x6002855")]
			[Address(RVA = "0x53A1FF0", Offset = "0x53A0BF0", VA = "0x1853A1FF0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002856")]
			[Address(RVA = "0x53A23B0", Offset = "0x53A0FB0", VA = "0x1853A23B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06002857 RID: 10327 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002858 RID: 10328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000C")]
		public event OnStateChangedDelegate OnStateChanged
		{
			[Token(Token = "0x6002857")]
			[Address(RVA = "0x53A2310", Offset = "0x53A0F10", VA = "0x1853A2310")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002858")]
			[Address(RVA = "0x53A26D0", Offset = "0x53A12D0", VA = "0x1853A26D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002859")]
		[Address(RVA = "0x53A1D90", Offset = "0x53A0990", VA = "0x1853A1D90")]
		public EventSource(Uri uri)
		{
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285A")]
		[Address(RVA = "0x53A1B10", Offset = "0x53A0710", VA = "0x1853A1B10")]
		public void Open()
		{
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285B")]
		[Address(RVA = "0x53A1040", Offset = "0x539FC40", VA = "0x1853A1040")]
		public void Close()
		{
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285C")]
		[Address(RVA = "0x53A1A50", Offset = "0x53A0650", VA = "0x1853A1A50")]
		public void On(string eventName, OnEventDelegate action)
		{
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285D")]
		[Address(RVA = "0x53A1090", Offset = "0x539FC90", VA = "0x1853A1090")]
		public void Off(string eventName)
		{
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285E")]
		[Address(RVA = "0x53A0E70", Offset = "0x539FA70", VA = "0x1853A0E70")]
		private void CallOnError(string error, string msg)
		{
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x00011370 File Offset: 0x0000F570
		[Token(Token = "0x600285F")]
		[Address(RVA = "0x53A0F60", Offset = "0x539FB60", VA = "0x1853A0F60")]
		private bool CallOnRetry()
		{
			return default(bool);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002860")]
		[Address(RVA = "0x53A1C90", Offset = "0x53A0890", VA = "0x1853A1C90")]
		private void SetClosed(string msg)
		{
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002861")]
		[Address(RVA = "0x53A1BB0", Offset = "0x53A07B0", VA = "0x1853A1BB0")]
		private void Retry()
		{
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002862")]
		[Address(RVA = "0x53A1790", Offset = "0x53A0390", VA = "0x1853A1790")]
		private void OnUpgraded(HTTPRequest originalRequest, HTTPResponse response)
		{
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002863")]
		[Address(RVA = "0x53A1390", Offset = "0x539FF90", VA = "0x1853A1390")]
		private void OnRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002864")]
		[Address(RVA = "0x53A10F0", Offset = "0x539FCF0", VA = "0x1853A10F0")]
		private void OnMessageReceived(EventSourceResponse resp, Message message)
		{
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002865")]
		[Address(RVA = "0x53A0CD0", Offset = "0x539F8D0", VA = "0x1853A0CD0", Slot = "4")]
		private void OnHeartbeatUpdate(TimeSpan dif)
		{
		}

		// Token: 0x04001659 RID: 5721
		[Token(Token = "0x4001659")]
		[FieldOffset(Offset = "0x18")]
		private States _state;

		// Token: 0x04001663 RID: 5731
		[Token(Token = "0x4001663")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, OnEventDelegate> EventTable;

		// Token: 0x04001664 RID: 5732
		[Token(Token = "0x4001664")]
		[FieldOffset(Offset = "0x70")]
		private byte RetryCount;

		// Token: 0x04001665 RID: 5733
		[Token(Token = "0x4001665")]
		[FieldOffset(Offset = "0x78")]
		private DateTime RetryCalled;
	}
}
