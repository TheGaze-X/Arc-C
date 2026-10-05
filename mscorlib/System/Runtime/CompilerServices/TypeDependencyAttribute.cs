using System;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004C4 RID: 1220
	[Token(Token = "0x20004C4")]
	[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
	internal sealed class TypeDependencyAttribute : System.Attribute
	{
		// Token: 0x06002352 RID: 9042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002352")]
		[Address(RVA = "0x4BEAC60", Offset = "0x4BE9860", VA = "0x184BEAC60")]
		public TypeDependencyAttribute(string typeName)
		{
		}

		// Token: 0x04001418 RID: 5144
		[Token(Token = "0x4001418")]
		[FieldOffset(Offset = "0x10")]
		private string typeName;
	}
}
