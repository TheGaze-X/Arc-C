using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000464 RID: 1124
	[Token(Token = "0x2000464")]
	[System.AttributeUsage(System.AttributeTargets.Assembly | System.AttributeTargets.Class, Inherited = false)]
	[ComVisible(true)]
	public sealed class ClassInterfaceAttribute : System.Attribute
	{
		// Token: 0x06002224 RID: 8740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002224")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType)
		{
		}

		// Token: 0x04001336 RID: 4918
		[Token(Token = "0x4001336")]
		[FieldOffset(Offset = "0x10")]
		internal ClassInterfaceType _val;
	}
}
