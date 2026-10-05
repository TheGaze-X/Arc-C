using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000364 RID: 868
	[Token(Token = "0x2000364")]
	internal abstract class Identity
	{
		// Token: 0x06001C6B RID: 7275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C6B")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public Identity(string objectUri)
		{
		}

		// Token: 0x06001C6C RID: 7276
		[Token(Token = "0x6001C6C")]
		public abstract ObjRef CreateObjRef(System.Type requestedType);

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033C")]
		public System.Runtime.Remoting.Messaging.IMessageSink ChannelSink
		{
			[Token(Token = "0x6001C6D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C6E")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700033D")]
		public System.Runtime.Remoting.Messaging.IMessageSink EnvoySink
		{
			[Token(Token = "0x6001C6F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001C71 RID: 7281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033E")]
		public string ObjectUri
		{
			[Token(Token = "0x6001C70")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C71")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x000128E8 File Offset: 0x00010AE8
		[Token(Token = "0x1700033F")]
		public bool IsConnected
		{
			[Token(Token = "0x6001C72")]
			[Address(RVA = "0x1028420", Offset = "0x1027020", VA = "0x181028420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x00012900 File Offset: 0x00010B00
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000340")]
		public bool Disposed
		{
			[Token(Token = "0x6001C73")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C74")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			set
			{
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000341")]
		public DynamicPropertyCollection ClientDynamicProperties
		{
			[Token(Token = "0x6001C75")]
			[Address(RVA = "0x4B5F100", Offset = "0x4B5DD00", VA = "0x184B5F100")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00012918 File Offset: 0x00010B18
		[Token(Token = "0x17000342")]
		public bool HasServerDynamicSinks
		{
			[Token(Token = "0x6001C76")]
			[Address(RVA = "0x4B5F180", Offset = "0x4B5DD80", VA = "0x184B5F180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C77")]
		[Address(RVA = "0x4B5F000", Offset = "0x4B5DC00", VA = "0x184B5F000")]
		public void NotifyClientDynamicSinks(bool start, System.Runtime.Remoting.Messaging.IMessage req_msg, bool client_site, bool async)
		{
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C78")]
		[Address(RVA = "0x4B5F080", Offset = "0x4B5DC80", VA = "0x184B5F080")]
		public void NotifyServerDynamicSinks(bool start, System.Runtime.Remoting.Messaging.IMessage req_msg, bool client_site, bool async)
		{
		}

		// Token: 0x04000F46 RID: 3910
		[Token(Token = "0x4000F46")]
		[FieldOffset(Offset = "0x10")]
		protected string _objectUri;

		// Token: 0x04000F47 RID: 3911
		[Token(Token = "0x4000F47")]
		[FieldOffset(Offset = "0x18")]
		protected System.Runtime.Remoting.Messaging.IMessageSink _channelSink;

		// Token: 0x04000F48 RID: 3912
		[Token(Token = "0x4000F48")]
		[FieldOffset(Offset = "0x20")]
		protected System.Runtime.Remoting.Messaging.IMessageSink _envoySink;

		// Token: 0x04000F49 RID: 3913
		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0x28")]
		private DynamicPropertyCollection _clientDynamicProperties;

		// Token: 0x04000F4A RID: 3914
		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0x30")]
		private DynamicPropertyCollection _serverDynamicProperties;

		// Token: 0x04000F4B RID: 3915
		[Token(Token = "0x4000F4B")]
		[FieldOffset(Offset = "0x38")]
		protected ObjRef _objRef;

		// Token: 0x04000F4C RID: 3916
		[Token(Token = "0x4000F4C")]
		[FieldOffset(Offset = "0x40")]
		private bool _disposed;
	}
}
