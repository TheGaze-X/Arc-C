using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000462 RID: 1122
	[Token(Token = "0x2000462")]
	[System.AttributeUsage(System.AttributeTargets.Class, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComDefaultInterfaceAttribute : System.Attribute
	{
		// Token: 0x06002223 RID: 8739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002223")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public ComDefaultInterfaceAttribute(System.Type defaultInterface)
		{
		}

		// Token: 0x04001331 RID: 4913
		[Token(Token = "0x4001331")]
		[FieldOffset(Offset = "0x10")]
		internal System.Type _val;
	}
}
