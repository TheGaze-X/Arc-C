using System;
using System.Runtime.CompilerServices;
using BestHTTP.SocketIO.Transports;
using Il2CppDummyDll;
using PlatformSupport.Collections.ObjectModel;
using PlatformSupport.Collections.Specialized;

namespace BestHTTP.SocketIO
{
	// Token: 0x0200051F RID: 1311
	[Token(Token = "0x200051F")]
	public sealed class SocketOptions
	{
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x00012798 File Offset: 0x00010998
		// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066B")]
		public TransportTypes ConnectWith
		{
			[Token(Token = "0x6002BA2")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return TransportTypes.Polling;
			}
			[Token(Token = "0x6002BA3")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x000127B0 File Offset: 0x000109B0
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066C")]
		public bool Reconnection
		{
			[Token(Token = "0x6002BA4")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002BA5")]
			[Address(RVA = "0x4EAC50", Offset = "0x4E9850", VA = "0x1804EAC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x000127C8 File Offset: 0x000109C8
		// (set) Token: 0x06002BA7 RID: 11175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066D")]
		public int ReconnectionAttempts
		{
			[Token(Token = "0x6002BA6")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002BA7")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x000127E0 File Offset: 0x000109E0
		// (set) Token: 0x06002BA9 RID: 11177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066E")]
		public TimeSpan ReconnectionDelay
		{
			[Token(Token = "0x6002BA8")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002BA9")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x000127F8 File Offset: 0x000109F8
		// (set) Token: 0x06002BAB RID: 11179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066F")]
		public TimeSpan ReconnectionDelayMax
		{
			[Token(Token = "0x6002BAA")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002BAB")]
			[Address(RVA = "0x20339E0", Offset = "0x20325E0", VA = "0x1820339E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x00012810 File Offset: 0x00010A10
		// (set) Token: 0x06002BAD RID: 11181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000670")]
		public float RandomizationFactor
		{
			[Token(Token = "0x6002BAC")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002BAD")]
			[Address(RVA = "0x53DAE10", Offset = "0x53D9A10", VA = "0x1853DAE10")]
			set
			{
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x00012828 File Offset: 0x00010A28
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000671")]
		public TimeSpan Timeout
		{
			[Token(Token = "0x6002BAE")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002BAF")]
			[Address(RVA = "0x1796DB0", Offset = "0x17959B0", VA = "0x181796DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x00012840 File Offset: 0x00010A40
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000672")]
		public bool AutoConnect
		{
			[Token(Token = "0x6002BB0")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002BB1")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000673")]
		public ObservableDictionary<string, string> AdditionalQueryParams
		{
			[Token(Token = "0x6002BB2")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BB3")]
			[Address(RVA = "0x53DACE0", Offset = "0x53D98E0", VA = "0x1853DACE0")]
			set
			{
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x00012858 File Offset: 0x00010A58
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000674")]
		public bool QueryParamsOnlyForHandshake
		{
			[Token(Token = "0x6002BB4")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002BB5")]
			[Address(RVA = "0x150B0D0", Offset = "0x1509CD0", VA = "0x18150B0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB6")]
		[Address(RVA = "0x53DABE0", Offset = "0x53D97E0", VA = "0x1853DABE0")]
		public SocketOptions()
		{
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB7")]
		[Address(RVA = "0x53DA850", Offset = "0x53D9450", VA = "0x1853DA850")]
		internal string BuildQueryParams()
		{
			return null;
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB8")]
		[Address(RVA = "0x509B090", Offset = "0x5099C90", VA = "0x18509B090")]
		private void AdditionalQueryParams_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
		}

		// Token: 0x040018BD RID: 6333
		[Token(Token = "0x40018BD")]
		[FieldOffset(Offset = "0x30")]
		private float randomizationFactor;

		// Token: 0x040018C0 RID: 6336
		[Token(Token = "0x40018C0")]
		[FieldOffset(Offset = "0x48")]
		private ObservableDictionary<string, string> additionalQueryParams;

		// Token: 0x040018C2 RID: 6338
		[Token(Token = "0x40018C2")]
		[FieldOffset(Offset = "0x58")]
		private string BuiltQueryParams;
	}
}
