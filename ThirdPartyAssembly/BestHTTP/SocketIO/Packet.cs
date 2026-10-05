using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.SocketIO.JsonEncoders;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO
{
	// Token: 0x0200051A RID: 1306
	[Token(Token = "0x200051A")]
	public sealed class Packet
	{
		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x000125E8 File Offset: 0x000107E8
		// (set) Token: 0x06002B2A RID: 11050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064D")]
		public TransportEventTypes TransportEvent
		{
			[Token(Token = "0x6002B29")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return TransportEventTypes.Open;
			}
			[Token(Token = "0x6002B2A")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x00012600 File Offset: 0x00010800
		// (set) Token: 0x06002B2C RID: 11052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064E")]
		public SocketIOEventTypes SocketIOEvent
		{
			[Token(Token = "0x6002B2B")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return SocketIOEventTypes.Connect;
			}
			[Token(Token = "0x6002B2C")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x00012618 File Offset: 0x00010818
		// (set) Token: 0x06002B2E RID: 11054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064F")]
		public int AttachmentCount
		{
			[Token(Token = "0x6002B2D")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002B2E")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x00012630 File Offset: 0x00010830
		// (set) Token: 0x06002B30 RID: 11056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000650")]
		public int Id
		{
			[Token(Token = "0x6002B2F")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002B30")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B32 RID: 11058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000651")]
		public string Namespace
		{
			[Token(Token = "0x6002B31")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B32")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002B33 RID: 11059 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B34 RID: 11060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000652")]
		public string Payload
		{
			[Token(Token = "0x6002B33")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B34")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B36 RID: 11062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000653")]
		public string EventName
		{
			[Token(Token = "0x6002B35")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B36")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B38 RID: 11064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000654")]
		public List<byte[]> Attachments
		{
			[Token(Token = "0x6002B37")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B38")]
			[Address(RVA = "0x53D5920", Offset = "0x53D4520", VA = "0x1853D5920")]
			set
			{
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x00012648 File Offset: 0x00010848
		[Token(Token = "0x17000655")]
		public bool HasAllAttachment
		{
			[Token(Token = "0x6002B39")]
			[Address(RVA = "0x53D58D0", Offset = "0x53D44D0", VA = "0x1853D58D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x00012660 File Offset: 0x00010860
		// (set) Token: 0x06002B3B RID: 11067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000656")]
		public bool IsDecoded
		{
			[Token(Token = "0x6002B3A")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002B3B")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B3D RID: 11069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000657")]
		public object[] DecodedArgs
		{
			[Token(Token = "0x6002B3C")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B3D")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3E")]
		[Address(RVA = "0x53D5870", Offset = "0x53D4470", VA = "0x1853D5870")]
		internal Packet()
		{
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3F")]
		[Address(RVA = "0x53D5840", Offset = "0x53D4440", VA = "0x1853D5840")]
		internal Packet(string from)
		{
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B40")]
		[Address(RVA = "0x53D57D0", Offset = "0x53D43D0", VA = "0x1853D57D0")]
		public Packet(TransportEventTypes transportEvent, SocketIOEventTypes packetType, string nsp, string payload, int attachment = 0, int id = 0)
		{
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B41")]
		[Address(RVA = "0x53D4490", Offset = "0x53D3090", VA = "0x1853D4490")]
		public object[] Decode(IJsonEncoder encoder)
		{
			return null;
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B42")]
		[Address(RVA = "0x53D42B0", Offset = "0x53D2EB0", VA = "0x1853D42B0")]
		public string DecodeEventName()
		{
			return null;
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B43")]
		[Address(RVA = "0x53D53E0", Offset = "0x53D3FE0", VA = "0x1853D53E0")]
		public string RemoveEventName(bool removeArrayMarks)
		{
			return null;
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x00012678 File Offset: 0x00010878
		[Token(Token = "0x6002B44")]
		[Address(RVA = "0x53D5360", Offset = "0x53D3F60", VA = "0x1853D5360")]
		public bool ReconstructAttachmentAsIndex()
		{
			return default(bool);
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x00012690 File Offset: 0x00010890
		[Token(Token = "0x6002B45")]
		[Address(RVA = "0x53D52A0", Offset = "0x53D3EA0", VA = "0x1853D52A0")]
		public bool ReconstructAttachmentAsBase64()
		{
			return default(bool);
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B46")]
		[Address(RVA = "0x53D4DA0", Offset = "0x53D39A0", VA = "0x1853D4DA0")]
		internal void Parse(string from)
		{
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B47")]
		[Address(RVA = "0x53D4B90", Offset = "0x53D3790", VA = "0x1853D4B90")]
		internal string Encode()
		{
			return null;
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B48")]
		[Address(RVA = "0x53D4620", Offset = "0x53D3220", VA = "0x1853D4620")]
		internal byte[] EncodeBinary()
		{
			return null;
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B49")]
		[Address(RVA = "0x53D4060", Offset = "0x53D2C60", VA = "0x1853D4060")]
		internal void AddAttachmentFromServer(byte[] data, bool copyFull)
		{
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4A")]
		[Address(RVA = "0x53D4970", Offset = "0x53D3570", VA = "0x1853D4970")]
		private byte[] EncodeData(byte[] data, Packet.PayloadTypes type, byte[] afterHeaderData)
		{
			return null;
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x000126A8 File Offset: 0x000108A8
		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0x53D5060", Offset = "0x53D3C60", VA = "0x1853D5060")]
		private bool PlaceholderReplacer(Action<string, Dictionary<string, object>> onFound)
		{
			return default(bool);
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4D")]
		[Address(RVA = "0x53D41B0", Offset = "0x53D2DB0", VA = "0x1853D41B0")]
		internal Packet Clone()
		{
			return null;
		}

		// Token: 0x04001886 RID: 6278
		[Token(Token = "0x4001886")]
		public const string Placeholder = "_placeholder";

		// Token: 0x0400188E RID: 6286
		[Token(Token = "0x400188E")]
		[FieldOffset(Offset = "0x38")]
		private List<byte[]> attachments;

		// Token: 0x0200051B RID: 1307
		[Token(Token = "0x200051B")]
		private enum PayloadTypes : byte
		{
			// Token: 0x04001892 RID: 6290
			[Token(Token = "0x4001892")]
			Textual,
			// Token: 0x04001893 RID: 6291
			[Token(Token = "0x4001893")]
			Binary
		}
	}
}
