using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003BE RID: 958
	[Token(Token = "0x20003BE")]
	internal class ArgInfo
	{
		// Token: 0x06001E53 RID: 7763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E53")]
		[Address(RVA = "0x4B6E520", Offset = "0x4B6D120", VA = "0x184B6E520")]
		public ArgInfo(System.Reflection.MethodBase method, ArgInfoType type)
		{
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x4B6E420", Offset = "0x4B6D020", VA = "0x184B6E420")]
		public object[] GetInOutArgs(object[] args)
		{
			return null;
		}

		// Token: 0x04001016 RID: 4118
		[Token(Token = "0x4001016")]
		[FieldOffset(Offset = "0x10")]
		private int[] _paramMap;

		// Token: 0x04001017 RID: 4119
		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0x18")]
		private int _inoutArgCount;

		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0x20")]
		private System.Reflection.MethodBase _method;
	}
}
