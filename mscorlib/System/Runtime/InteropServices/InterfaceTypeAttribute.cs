using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000461 RID: 1121
	[Token(Token = "0x2000461")]
	[System.AttributeUsage(System.AttributeTargets.Interface, Inherited = false)]
	[ComVisible(true)]
	public sealed class InterfaceTypeAttribute : System.Attribute
	{
		// Token: 0x06002222 RID: 8738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002222")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public InterfaceTypeAttribute(ComInterfaceType interfaceType)
		{
		}

		// Token: 0x04001330 RID: 4912
		[Token(Token = "0x4001330")]
		[FieldOffset(Offset = "0x10")]
		internal ComInterfaceType _val;
	}
}
