using System;
using System.Collections;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x0200039D RID: 925
	[Token(Token = "0x200039D")]
	[MonoTODO("Handle domain unloading?")]
	internal class CrossAppDomainSink : System.Runtime.Remoting.Messaging.IMessageSink
	{
		// Token: 0x06001DE1 RID: 7649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE1")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		internal CrossAppDomainSink(int domainID)
		{
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DE2")]
		[Address(RVA = "0x4B7B4A0", Offset = "0x4B7A0A0", VA = "0x184B7B4A0")]
		internal static CrossAppDomainSink GetSink(int domainID)
		{
			return null;
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x00012CD8 File Offset: 0x00010ED8
		[Token(Token = "0x1700037F")]
		internal int TargetDomainId
		{
			[Token(Token = "0x6001DE3")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00012CF0 File Offset: 0x00010EF0
		[Token(Token = "0x6001DE4")]
		[Address(RVA = "0x4B7B810", Offset = "0x4B7A410", VA = "0x184B7B810")]
		private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg)
		{
			return default(CrossAppDomainSink.ProcessMessageRes);
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DE5")]
		[Address(RVA = "0x4B7BA20", Offset = "0x4B7A620", VA = "0x184B7BA20", Slot = "6")]
		public virtual System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msgRequest)
		{
			return null;
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DE6")]
		[Address(RVA = "0x4B7B3B0", Offset = "0x4B79FB0", VA = "0x184B7B3B0", Slot = "7")]
		public virtual System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage reqMsg, System.Runtime.Remoting.Messaging.IMessageSink replySink)
		{
			return null;
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE7")]
		[Address(RVA = "0x4B7B910", Offset = "0x4B7A510", VA = "0x184B7B910")]
		public void SendAsyncMessage(object data)
		{
		}

		// Token: 0x04000FE4 RID: 4068
		[Token(Token = "0x4000FE4")]
		[FieldOffset(Offset = "0x0")]
		private static System.Collections.Hashtable s_sinks;

		// Token: 0x04000FE5 RID: 4069
		[Token(Token = "0x4000FE5")]
		[FieldOffset(Offset = "0x8")]
		private static System.Reflection.MethodInfo processMessageMethod;

		// Token: 0x04000FE6 RID: 4070
		[Token(Token = "0x4000FE6")]
		[FieldOffset(Offset = "0x10")]
		private int _domainID;

		// Token: 0x0200039E RID: 926
		[Token(Token = "0x200039E")]
		private struct ProcessMessageRes
		{
			// Token: 0x04000FE7 RID: 4071
			[Token(Token = "0x4000FE7")]
			[FieldOffset(Offset = "0x0")]
			public byte[] arrResponse;

			// Token: 0x04000FE8 RID: 4072
			[Token(Token = "0x4000FE8")]
			[FieldOffset(Offset = "0x8")]
			public CADMethodReturnMessage cadMrm;
		}
	}
}
