using System;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x0200039C RID: 924
	[Token(Token = "0x200039C")]
	[System.Serializable]
	internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver
	{
		// Token: 0x06001DD9 RID: 7641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD9")]
		[Address(RVA = "0x4B7B010", Offset = "0x4B79C10", VA = "0x184B7B010")]
		internal static void RegisterCrossAppDomainChannel()
		{
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700037C")]
		public virtual string ChannelName
		{
			[Token(Token = "0x6001DDA")]
			[Address(RVA = "0x4B7B2D0", Offset = "0x4B79ED0", VA = "0x184B7B2D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x00012CC0 File Offset: 0x00010EC0
		[Token(Token = "0x1700037D")]
		public virtual int ChannelPriority
		{
			[Token(Token = "0x6001DDB")]
			[Address(RVA = "0x13A8070", Offset = "0x13A6C70", VA = "0x1813A8070", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700037E")]
		public virtual object ChannelData
		{
			[Token(Token = "0x6001DDC")]
			[Address(RVA = "0x4B7B1E0", Offset = "0x4B79DE0", VA = "0x184B7B1E0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DDD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
		public virtual void StartListening(object data)
		{
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DDE")]
		[Address(RVA = "0x4B7AE70", Offset = "0x4B79A70", VA = "0x184B7AE70", Slot = "13")]
		public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object data, out string uri)
		{
			return null;
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DDF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrossAppDomainChannel()
		{
		}

		// Token: 0x04000FE3 RID: 4067
		[Token(Token = "0x4000FE3")]
		[FieldOffset(Offset = "0x0")]
		private static object s_lock;
	}
}
