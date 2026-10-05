using System;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004A5 RID: 1189
	[Token(Token = "0x20004A5")]
	[System.CLSCompliant(false)]
	[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Event | System.AttributeTargets.Parameter | System.AttributeTargets.ReturnValue)]
	public sealed class TupleElementNamesAttribute : System.Attribute
	{
		// Token: 0x060022E8 RID: 8936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E8")]
		[Address(RVA = "0x4BE9E70", Offset = "0x4BE8A70", VA = "0x184BE9E70")]
		public TupleElementNamesAttribute(string[] transformNames)
		{
		}

		// Token: 0x040013E4 RID: 5092
		[Token(Token = "0x40013E4")]
		[FieldOffset(Offset = "0x10")]
		private readonly string[] _transformNames;
	}
}
