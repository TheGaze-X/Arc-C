using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200045F RID: 1119
	[Token(Token = "0x200045F")]
	[ComVisible(true)]
	[System.AttributeUsage(System.AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	public sealed class UnmanagedFunctionPointerAttribute : System.Attribute
	{
		// Token: 0x06002221 RID: 8737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002221")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
		{
		}

		// Token: 0x0400132A RID: 4906
		[Token(Token = "0x400132A")]
		[FieldOffset(Offset = "0x10")]
		private CallingConvention m_callingConvention;
	}
}
