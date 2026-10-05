using System;
using Il2CppDummyDll;

namespace JetBrains.Annotations
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[Flags]
	public enum ImplicitUseKindFlags
	{
		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		Default = 7,
		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		Access = 1,
		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		Assign = 2,
		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		InstantiatedWithFixedConstructorSignature = 4,
		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		InstantiatedNoFixedConstructorSignature = 8
	}
}
