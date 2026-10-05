using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x0200027E RID: 638
	[Token(Token = "0x200027E")]
	internal enum CausalityRelation
	{
		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		AssignDelegate,
		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		Join,
		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		Choice,
		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4000BCD")]
		Cancel,
		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4000BCE")]
		Error
	}
}
