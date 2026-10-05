using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using BestHTTP.Extensions;
using BestHTTP.SignalR.Authentication;
using BestHTTP.SignalR.Hubs;
using BestHTTP.SignalR.JsonEncoders;
using BestHTTP.SignalR.Messages;
using BestHTTP.SignalR.Transports;
using Il2CppDummyDll;
using PlatformSupport.Collections.ObjectModel;
using PlatformSupport.Collections.Specialized;

namespace BestHTTP.SignalR
{
	// Token: 0x02000537 RID: 1335
	[Token(Token = "0x2000537")]
	public sealed class Connection : IHeartbeat, IConnection
	{
		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002C38 RID: 11320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068C")]
		public Uri Uri
		{
			[Token(Token = "0x6002C37")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C38")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x000129C0 File Offset: 0x00010BC0
		// (set) Token: 0x06002C3A RID: 11322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068D")]
		public ConnectionStates State
		{
			[Token(Token = "0x6002C39")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return ConnectionStates.Initial;
			}
			[Token(Token = "0x6002C3A")]
			[Address(RVA = "0x53E8830", Offset = "0x53E7430", VA = "0x1853E8830")]
			private set
			{
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002C3C RID: 11324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068E")]
		public NegotiationData NegotiationResult
		{
			[Token(Token = "0x6002C3B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C3C")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002C3E RID: 11326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068F")]
		public Hub[] Hubs
		{
			[Token(Token = "0x6002C3D")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C3E")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002C40 RID: 11328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000690")]
		public TransportBase Transport
		{
			[Token(Token = "0x6002C3F")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C40")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x000129D8 File Offset: 0x00010BD8
		// (set) Token: 0x06002C42 RID: 11330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000691")]
		public ProtocolVersions Protocol
		{
			[Token(Token = "0x6002C41")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return ProtocolVersions.Protocol_2_0;
			}
			[Token(Token = "0x6002C42")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002C44 RID: 11332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000692")]
		public ObservableDictionary<string, string> AdditionalQueryParams
		{
			[Token(Token = "0x6002C43")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C44")]
			[Address(RVA = "0x53E86F0", Offset = "0x53E72F0", VA = "0x1853E86F0")]
			set
			{
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x000129F0 File Offset: 0x00010BF0
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000693")]
		public bool QueryParamsOnlyForHandshake
		{
			[Token(Token = "0x6002C45")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C46")]
			[Address(RVA = "0x16647B0", Offset = "0x16633B0", VA = "0x1816647B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002C48 RID: 11336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000694")]
		public IJsonEncoder JsonEncoder
		{
			[Token(Token = "0x6002C47")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C48")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002C4A RID: 11338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000695")]
		public IAuthenticationProvider AuthenticationProvider
		{
			[Token(Token = "0x6002C49")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C4A")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x00012A08 File Offset: 0x00010C08
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000696")]
		public TimeSpan PingInterval
		{
			[Token(Token = "0x6002C4B")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002C4C")]
			[Address(RVA = "0x35378D0", Offset = "0x35364D0", VA = "0x1835378D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x00012A20 File Offset: 0x00010C20
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000697")]
		public TimeSpan ReconnectDelay
		{
			[Token(Token = "0x6002C4D")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002C4E")]
			[Address(RVA = "0x4A5BFE0", Offset = "0x4A5ABE0", VA = "0x184A5BFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06002C4F RID: 11343 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002C50 RID: 11344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000D")]
		public event OnConnectedDelegate OnConnected
		{
			[Token(Token = "0x6002C4F")]
			[Address(RVA = "0x53E7780", Offset = "0x53E6380", VA = "0x1853E7780")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002C50")]
			[Address(RVA = "0x53E8330", Offset = "0x53E6F30", VA = "0x1853E8330")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06002C51 RID: 11345 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002C52 RID: 11346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000E")]
		public event OnClosedDelegate OnClosed
		{
			[Token(Token = "0x6002C51")]
			[Address(RVA = "0x53E76E0", Offset = "0x53E62E0", VA = "0x1853E76E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002C52")]
			[Address(RVA = "0x53E8290", Offset = "0x53E6E90", VA = "0x1853E8290")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06002C53 RID: 11347 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002C54 RID: 11348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000F")]
		public event OnErrorDelegate OnError
		{
			[Token(Token = "0x6002C53")]
			[Address(RVA = "0x53E7820", Offset = "0x53E6420", VA = "0x1853E7820")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002C54")]
			[Address(RVA = "0x53E83D0", Offset = "0x53E6FD0", VA = "0x1853E83D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06002C55 RID: 11349 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002C56 RID: 11350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000010")]
		public event OnConnectedDelegate OnReconnecting
		{
			[Token(Token = "0x6002C55")]
			[Address(RVA = "0x53E7A00", Offset = "0x53E6600", VA = "0x1853E7A00")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002C56")]
			[Address(RVA = "0x53E85B0", Offset = "0x53E71B0", VA = "0x1853E85B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06002C57 RID: 11351 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002C58 RID: 11352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000011")]
		public event OnConnectedDelegate OnReconnected
		{
			[Token(Token = "0x6002C57")]
			[Address(RVA = "0x53E7960", Offset = "0x53E6560", VA = "0x1853E7960")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002C58")]
			[Address(RVA = "0x53E8510", Offset = "0x53E7110", VA = "0x1853E8510")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06002C59 RID: 11353 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002C5A RID: 11354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000012")]
		public event OnStateChanged OnStateChanged
		{
			[Token(Token = "0x6002C59")]
			[Address(RVA = "0x53E7AA0", Offset = "0x53E66A0", VA = "0x1853E7AA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002C5A")]
			[Address(RVA = "0x53E8650", Offset = "0x53E7250", VA = "0x1853E8650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06002C5B RID: 11355 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002C5C RID: 11356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000013")]
		public event OnNonHubMessageDelegate OnNonHubMessage
		{
			[Token(Token = "0x6002C5B")]
			[Address(RVA = "0x53E78C0", Offset = "0x53E64C0", VA = "0x1853E78C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002C5C")]
			[Address(RVA = "0x53E8470", Offset = "0x53E7070", VA = "0x1853E8470")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002C5E RID: 11358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000698")]
		public OnPrepareRequestDelegate RequestPreparator
		{
			[Token(Token = "0x6002C5D")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C5E")]
			[Address(RVA = "0x789450", Offset = "0x788050", VA = "0x180789450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000699 RID: 1689
		[Token(Token = "0x17000699")]
		public Hub this[int idx]
		{
			[Token(Token = "0x6002C5F")]
			[Address(RVA = "0x5EA350", Offset = "0x5E8F50", VA = "0x1805EA350")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069A RID: 1690
		[Token(Token = "0x1700069A")]
		public Hub this[string hubName]
		{
			[Token(Token = "0x6002C60")]
			[Address(RVA = "0x53E7D70", Offset = "0x53E6970", VA = "0x1853E7D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x00012A38 File Offset: 0x00010C38
		// (set) Token: 0x06002C62 RID: 11362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069B")]
		internal ulong ClientMessageCounter
		{
			[Token(Token = "0x6002C61")]
			[Address(RVA = "0x22F8850", Offset = "0x22F7450", VA = "0x1822F8850")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002C62")]
			[Address(RVA = "0x53E8820", Offset = "0x53E7420", VA = "0x1853E8820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x00012A50 File Offset: 0x00010C50
		[Token(Token = "0x1700069C")]
		private uint Timestamp
		{
			[Token(Token = "0x6002C63")]
			[Address(RVA = "0x53E81E0", Offset = "0x53E6DE0", VA = "0x1853E81E0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069D")]
		private string ConnectionData
		{
			[Token(Token = "0x6002C64")]
			[Address(RVA = "0x53E7B40", Offset = "0x53E6740", VA = "0x1853E7B40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069E")]
		private string QueryParams
		{
			[Token(Token = "0x6002C65")]
			[Address(RVA = "0x53E7E20", Offset = "0x53E6A20", VA = "0x1853E7E20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C66")]
		[Address(RVA = "0x53E72A0", Offset = "0x53E5EA0", VA = "0x1853E72A0")]
		public Connection(Uri uri, params string[] hubNames)
		{
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C67")]
		[Address(RVA = "0x53E7140", Offset = "0x53E5D40", VA = "0x1853E7140")]
		public Connection(Uri uri, params Hub[] hubs)
		{
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C68")]
		[Address(RVA = "0x53E73F0", Offset = "0x53E5FF0", VA = "0x1853E73F0")]
		public Connection(Uri uri)
		{
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C69")]
		[Address(RVA = "0x53E6030", Offset = "0x53E4C30", VA = "0x1853E6030")]
		public void Open()
		{
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6A")]
		[Address(RVA = "0x53E5830", Offset = "0x53E4430", VA = "0x1853E5830")]
		private void OnAuthenticationSucceded(IAuthenticationProvider provider)
		{
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6B")]
		[Address(RVA = "0x53E5750", Offset = "0x53E4350", VA = "0x1853E5750")]
		private void OnAuthenticationFailed(IAuthenticationProvider provider, string reason)
		{
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6C")]
		[Address(RVA = "0x53E6A50", Offset = "0x53E5650", VA = "0x1853E6A50")]
		private void StartImpl()
		{
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6D")]
		[Address(RVA = "0x53E58E0", Offset = "0x53E44E0", VA = "0x1853E58E0")]
		private void OnNegotiationDataReceived(NegotiationData data)
		{
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6E")]
		[Address(RVA = "0x53E5CE0", Offset = "0x53E48E0", VA = "0x1853E5CE0")]
		private void OnNegotiationError(NegotiationData data, string error)
		{
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C6F")]
		[Address(RVA = "0x53E51B0", Offset = "0x53E3DB0", VA = "0x1853E51B0")]
		public void Close()
		{
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C70")]
		[Address(RVA = "0x53E63D0", Offset = "0x53E4FD0", VA = "0x1853E63D0")]
		public void Reconnect()
		{
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x00012A68 File Offset: 0x00010C68
		[Token(Token = "0x6002C71")]
		[Address(RVA = "0x53E6820", Offset = "0x53E5420", VA = "0x1853E6820")]
		public bool Send(object arg)
		{
			return default(bool);
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x00012A80 File Offset: 0x00010C80
		[Token(Token = "0x6002C72")]
		[Address(RVA = "0x53E66F0", Offset = "0x53E52F0", VA = "0x1853E66F0")]
		public bool SendJson(string json)
		{
			return default(bool);
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C73")]
		[Address(RVA = "0x53E4380", Offset = "0x53E2F80", VA = "0x1853E4380", Slot = "9")]
		private void OnMessage(IServerMessage msg)
		{
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C74")]
		[Address(RVA = "0x53E4F40", Offset = "0x53E3B40", VA = "0x1853E4F40", Slot = "10")]
		private void TransportStarted()
		{
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C75")]
		[Address(RVA = "0x53E4DC0", Offset = "0x53E39C0", VA = "0x1853E4DC0", Slot = "11")]
		private void TransportReconnected()
		{
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C76")]
		[Address(RVA = "0x53E4DB0", Offset = "0x53E39B0", VA = "0x1853E4DB0", Slot = "12")]
		private void TransportAborted()
		{
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C77")]
		[Address(RVA = "0x53E4220", Offset = "0x53E2E20", VA = "0x1853E4220", Slot = "13")]
		private void Error(string reason)
		{
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C78")]
		[Address(RVA = "0x53E41C0", Offset = "0x53E2DC0", VA = "0x1853E41C0", Slot = "14")]
		private Uri BuildUri(RequestTypes type)
		{
			return null;
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C79")]
		[Address(RVA = "0x53E3810", Offset = "0x53E2410", VA = "0x1853E3810", Slot = "15")]
		private Uri BuildUri(RequestTypes type, TransportBase transport)
		{
			return null;
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C7A")]
		[Address(RVA = "0x53E4C90", Offset = "0x53E3890", VA = "0x1853E4C90", Slot = "16")]
		private HTTPRequest PrepareRequest(HTTPRequest req, RequestTypes type)
		{
			return null;
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C7B")]
		[Address(RVA = "0x53E4B10", Offset = "0x53E3710", VA = "0x1853E4B10", Slot = "17")]
		private string ParseResponse(string responseStr)
		{
			return null;
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C7C")]
		[Address(RVA = "0x53E2E90", Offset = "0x53E1A90", VA = "0x1853E2E90", Slot = "4")]
		private void OnHeartbeatUpdate(TimeSpan dif)
		{
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C7D")]
		[Address(RVA = "0x53E5670", Offset = "0x53E4270", VA = "0x1853E5670")]
		private void InitOnStart()
		{
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C7E")]
		[Address(RVA = "0x53E54F0", Offset = "0x53E40F0", VA = "0x1853E54F0")]
		private Hub FindHub(ulong msgId)
		{
			return null;
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x00012A98 File Offset: 0x00010C98
		[Token(Token = "0x6002C7F")]
		[Address(RVA = "0x53E6D90", Offset = "0x53E5990", VA = "0x1853E6D90")]
		private bool TryFallbackTransport()
		{
			return default(bool);
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C80")]
		[Address(RVA = "0x53E2E70", Offset = "0x53E1A70", VA = "0x1853E2E70")]
		private void AdditionalQueryParams_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C81")]
		[Address(RVA = "0x53E61D0", Offset = "0x53E4DD0", VA = "0x1853E61D0")]
		private void Ping()
		{
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C82")]
		[Address(RVA = "0x53E5D30", Offset = "0x53E4930", VA = "0x1853E5D30")]
		private void OnPingRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x040018F0 RID: 6384
		[Token(Token = "0x40018F0")]
		[FieldOffset(Offset = "0x0")]
		public static IJsonEncoder DefaultEncoder;

		// Token: 0x040018F2 RID: 6386
		[Token(Token = "0x40018F2")]
		[FieldOffset(Offset = "0x18")]
		private ConnectionStates _state;

		// Token: 0x040018F7 RID: 6391
		[Token(Token = "0x40018F7")]
		[FieldOffset(Offset = "0x40")]
		private ObservableDictionary<string, string> additionalQueryParams;

		// Token: 0x04001905 RID: 6405
		[Token(Token = "0x4001905")]
		[FieldOffset(Offset = "0xB0")]
		internal object SyncRoot;

		// Token: 0x04001907 RID: 6407
		[Token(Token = "0x4001907")]
		[FieldOffset(Offset = "0xC0")]
		private readonly string[] ClientProtocols;

		// Token: 0x04001908 RID: 6408
		[Token(Token = "0x4001908")]
		[FieldOffset(Offset = "0xC8")]
		private ulong RequestCounter;

		// Token: 0x04001909 RID: 6409
		[Token(Token = "0x4001909")]
		[FieldOffset(Offset = "0xD0")]
		private MultiMessage LastReceivedMessage;

		// Token: 0x0400190A RID: 6410
		[Token(Token = "0x400190A")]
		[FieldOffset(Offset = "0xD8")]
		private string GroupsToken;

		// Token: 0x0400190B RID: 6411
		[Token(Token = "0x400190B")]
		[FieldOffset(Offset = "0xE0")]
		private List<IServerMessage> BufferedMessages;

		// Token: 0x0400190C RID: 6412
		[Token(Token = "0x400190C")]
		[FieldOffset(Offset = "0xE8")]
		private DateTime LastMessageReceivedAt;

		// Token: 0x0400190D RID: 6413
		[Token(Token = "0x400190D")]
		[FieldOffset(Offset = "0xF0")]
		private DateTime ReconnectStartedAt;

		// Token: 0x0400190E RID: 6414
		[Token(Token = "0x400190E")]
		[FieldOffset(Offset = "0xF8")]
		private DateTime ReconnectDelayStartedAt;

		// Token: 0x0400190F RID: 6415
		[Token(Token = "0x400190F")]
		[FieldOffset(Offset = "0x100")]
		private bool ReconnectStarted;

		// Token: 0x04001910 RID: 6416
		[Token(Token = "0x4001910")]
		[FieldOffset(Offset = "0x108")]
		private DateTime LastPingSentAt;

		// Token: 0x04001911 RID: 6417
		[Token(Token = "0x4001911")]
		[FieldOffset(Offset = "0x110")]
		private HTTPRequest PingRequest;

		// Token: 0x04001912 RID: 6418
		[Token(Token = "0x4001912")]
		[FieldOffset(Offset = "0x118")]
		private DateTime? TransportConnectionStartedAt;

		// Token: 0x04001913 RID: 6419
		[Token(Token = "0x4001913")]
		[FieldOffset(Offset = "0x128")]
		private StringBuilder queryBuilder;

		// Token: 0x04001914 RID: 6420
		[Token(Token = "0x4001914")]
		[FieldOffset(Offset = "0x130")]
		private string BuiltConnectionData;

		// Token: 0x04001915 RID: 6421
		[Token(Token = "0x4001915")]
		[FieldOffset(Offset = "0x138")]
		private string BuiltQueryParams;

		// Token: 0x04001916 RID: 6422
		[Token(Token = "0x4001916")]
		[FieldOffset(Offset = "0x140")]
		private SupportedProtocols NextProtocolToTry;
	}
}
