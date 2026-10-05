using System;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000360 RID: 864
	[Token(Token = "0x2000360")]
	[System.Serializable]
	internal class EnvoyInfo : IEnvoyInfo
	{
		// Token: 0x06001C65 RID: 7269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C65")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public EnvoyInfo(System.Runtime.Remoting.Messaging.IMessageSink sinks)
		{
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000338")]
		public System.Runtime.Remoting.Messaging.IMessageSink EnvoySinks
		{
			[Token(Token = "0x6001C66")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F45 RID: 3909
		[Token(Token = "0x4000F45")]
		[FieldOffset(Offset = "0x10")]
		private System.Runtime.Remoting.Messaging.IMessageSink envoySinks;
	}
}
