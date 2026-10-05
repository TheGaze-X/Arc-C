using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000471 RID: 1137
	[Token(Token = "0x2000471")]
	[System.AttributeUsage(System.AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	public sealed class FieldOffsetAttribute : System.Attribute
	{
		// Token: 0x06002232 RID: 8754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002232")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public FieldOffsetAttribute(int offset)
		{
		}

		// Token: 0x0400139F RID: 5023
		[Token(Token = "0x400139F")]
		[FieldOffset(Offset = "0x10")]
		internal int _val;
	}
}
