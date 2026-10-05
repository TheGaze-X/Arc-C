using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003CA RID: 970
	[Token(Token = "0x20003CA")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.CLSCompliant(false)]
	[System.Serializable]
	public class ConstructionResponse : MethodResponse, System.Runtime.Remoting.Activation.IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage
	{
		// Token: 0x06001EA2 RID: 7842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA2")]
		[Address(RVA = "0x4B782A0", Offset = "0x4B76EA0", VA = "0x184B782A0")]
		internal ConstructionResponse(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg)
		{
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA3")]
		[Address(RVA = "0x4B782D0", Offset = "0x4B76ED0", VA = "0x184B782D0")]
		internal ConstructionResponse(System.Exception e, IMethodCallMessage msg)
		{
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0x4B782E0", Offset = "0x4B76EE0", VA = "0x184B782E0")]
		internal ConstructionResponse(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003BD")]
		public override System.Collections.IDictionary Properties
		{
			[Token(Token = "0x6001EA5")]
			[Address(RVA = "0x4B78300", Offset = "0x4B76F00", VA = "0x184B78300", Slot = "22")]
			get
			{
				return null;
			}
		}
	}
}
