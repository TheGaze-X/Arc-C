using System;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000491 RID: 1169
	[Token(Token = "0x2000491")]
	[System.AttributeUsage(System.AttributeTargets.Field | System.AttributeTargets.Parameter, Inherited = false)]
	[System.Serializable]
	public abstract class CustomConstantAttribute : System.Attribute
	{
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060022C6 RID: 8902
		[Token(Token = "0x17000475")]
		public abstract object Value { [Token(Token = "0x60022C6")] get; }

		// Token: 0x060022C7 RID: 8903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C7")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected CustomConstantAttribute()
		{
		}
	}
}
