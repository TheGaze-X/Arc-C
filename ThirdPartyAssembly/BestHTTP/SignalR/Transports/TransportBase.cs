using System;
using System.Runtime.CompilerServices;
using BestHTTP.SignalR.JsonEncoders;
using BestHTTP.SignalR.Messages;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Transports
{
	// Token: 0x02000543 RID: 1347
	[Token(Token = "0x2000543")]
	public abstract class TransportBase
	{
		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002CC7 RID: 11463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006AE")]
		public string Name
		{
			[Token(Token = "0x6002CC6")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CC7")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06002CC8 RID: 11464
		[Token(Token = "0x170006AF")]
		public abstract bool SupportsKeepAlive { [Token(Token = "0x6002CC8")] get; }

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06002CC9 RID: 11465
		[Token(Token = "0x170006B0")]
		public abstract TransportTypes Type { [Token(Token = "0x6002CC9")] get; }

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002CCB RID: 11467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B1")]
		public IConnection Connection
		{
			[Token(Token = "0x6002CCA")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002CCB")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x00012BE8 File Offset: 0x00010DE8
		// (set) Token: 0x06002CCD RID: 11469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B2")]
		public TransportStates State
		{
			[Token(Token = "0x6002CCC")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return TransportStates.Initial;
			}
			[Token(Token = "0x6002CCD")]
			[Address(RVA = "0x53F8690", Offset = "0x53F7290", VA = "0x1853F8690")]
			protected set
			{
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06002CCE RID: 11470 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002CCF RID: 11471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000014")]
		public event OnTransportStateChangedDelegate OnStateChanged
		{
			[Token(Token = "0x6002CCE")]
			[Address(RVA = "0x53F8550", Offset = "0x53F7150", VA = "0x1853F8550")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002CCF")]
			[Address(RVA = "0x53F85F0", Offset = "0x53F71F0", VA = "0x1853F85F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD0")]
		[Address(RVA = "0x53F84D0", Offset = "0x53F70D0", VA = "0x1853F84D0")]
		public TransportBase(string name, Connection connection)
		{
		}

		// Token: 0x06002CD1 RID: 11473
		[Token(Token = "0x6002CD1")]
		public abstract void Connect();

		// Token: 0x06002CD2 RID: 11474
		[Token(Token = "0x6002CD2")]
		public abstract void Stop();

		// Token: 0x06002CD3 RID: 11475
		[Token(Token = "0x6002CD3")]
		protected abstract void SendImpl(string json);

		// Token: 0x06002CD4 RID: 11476
		[Token(Token = "0x6002CD4")]
		protected abstract void Started();

		// Token: 0x06002CD5 RID: 11477
		[Token(Token = "0x6002CD5")]
		protected abstract void Aborted();

		// Token: 0x06002CD6 RID: 11478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD6")]
		[Address(RVA = "0x53F74C0", Offset = "0x53F60C0", VA = "0x1853F74C0")]
		protected void OnConnected()
		{
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD7")]
		[Address(RVA = "0x53F8190", Offset = "0x53F6D90", VA = "0x1853F8190")]
		protected void Start()
		{
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD8")]
		[Address(RVA = "0x53F7580", Offset = "0x53F6180", VA = "0x1853F7580")]
		private void OnStartRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD9")]
		[Address(RVA = "0x53F6E30", Offset = "0x53F5A30", VA = "0x1853F6E30", Slot = "11")]
		public virtual void Abort()
		{
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CDA")]
		[Address(RVA = "0x53F6D90", Offset = "0x53F5990", VA = "0x1853F6D90")]
		protected void AbortFinished()
		{
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CDB")]
		[Address(RVA = "0x53F6FE0", Offset = "0x53F5BE0", VA = "0x1853F6FE0")]
		private void OnAbortRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CDC")]
		[Address(RVA = "0x53F7FF0", Offset = "0x53F6BF0", VA = "0x1853F7FF0")]
		public void Send(string jsonStr)
		{
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CDD")]
		[Address(RVA = "0x53F7EB0", Offset = "0x53F6AB0", VA = "0x1853F7EB0")]
		public void Reconnect()
		{
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CDE")]
		[Address(RVA = "0x53F7B40", Offset = "0x53F6740", VA = "0x1853F7B40")]
		public static IServerMessage Parse(IJsonEncoder encoder, string json)
		{
			return null;
		}

		// Token: 0x04001953 RID: 6483
		[Token(Token = "0x4001953")]
		private const int MaxRetryCount = 5;

		// Token: 0x04001956 RID: 6486
		[Token(Token = "0x4001956")]
		[FieldOffset(Offset = "0x20")]
		public TransportStates _state;
	}
}
