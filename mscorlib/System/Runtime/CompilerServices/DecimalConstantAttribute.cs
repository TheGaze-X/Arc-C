using System;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x2000493")]
	[System.AttributeUsage(System.AttributeTargets.Field | System.AttributeTargets.Parameter, Inherited = false)]
	[System.Serializable]
	public sealed class DecimalConstantAttribute : System.Attribute
	{
		// Token: 0x060022C9 RID: 8905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C9")]
		[Address(RVA = "0x4BD30C0", Offset = "0x4BD1CC0", VA = "0x184BD30C0")]
		[System.CLSCompliant(false)]
		public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low)
		{
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x00013F80 File Offset: 0x00012180
		[Token(Token = "0x17000477")]
		public decimal Value
		{
			[Token(Token = "0x60022CA")]
			[Address(RVA = "0x4E6DD0", Offset = "0x4E59D0", VA = "0x1804E6DD0")]
			get
			{
				return 0m;
			}
		}

		// Token: 0x040013DC RID: 5084
		[Token(Token = "0x40013DC")]
		[FieldOffset(Offset = "0x10")]
		private decimal _dec;
	}
}
