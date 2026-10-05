using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003DB RID: 987
	[Token(Token = "0x20003DB")]
	internal class MethodReturnDictionary : MessageDictionary
	{
		// Token: 0x06001F1F RID: 7967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0x4BA07D0", Offset = "0x4B9F3D0", VA = "0x184BA07D0")]
		public MethodReturnDictionary(IMethodReturnMessage message)
		{
		}

		// Token: 0x0400106E RID: 4206
		[Token(Token = "0x400106E")]
		[FieldOffset(Offset = "0x0")]
		public static string[] InternalReturnKeys;

		// Token: 0x0400106F RID: 4207
		[Token(Token = "0x400106F")]
		[FieldOffset(Offset = "0x8")]
		public static string[] InternalExceptionKeys;
	}
}
