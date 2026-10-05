using System;
using Il2CppDummyDll;

namespace JetBrains.Annotations
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
	public sealed class MeansImplicitUseAttribute : Attribute
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x5931CF0", Offset = "0x59308F0", VA = "0x185931CF0")]
		public MeansImplicitUseAttribute()
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x4BDC4D0", Offset = "0x4BDB0D0", VA = "0x184BDC4D0")]
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
		}
	}
}
