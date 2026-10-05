using System;
using System.Runtime.Remoting.Activation;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003C9 RID: 969
	[Token(Token = "0x20003C9")]
	internal class ConstructionCallDictionary : MessageDictionary
	{
		// Token: 0x06001E9E RID: 7838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x4B778B0", Offset = "0x4B764B0", VA = "0x184B778B0")]
		public ConstructionCallDictionary(System.Runtime.Remoting.Activation.IConstructionCallMessage message)
		{
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x4B76E90", Offset = "0x4B75A90", VA = "0x184B76E90", Slot = "21")]
		protected override object GetMethodProperty(string key)
		{
			return null;
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA0")]
		[Address(RVA = "0x4B771D0", Offset = "0x4B75DD0", VA = "0x184B771D0", Slot = "22")]
		protected override void SetMethodProperty(string key, object value)
		{
		}

		// Token: 0x04001045 RID: 4165
		[Token(Token = "0x4001045")]
		[FieldOffset(Offset = "0x0")]
		public static string[] InternalKeys;
	}
}
