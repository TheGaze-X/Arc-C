using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	internal enum LazyState
	{
		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		NoneViaConstructor,
		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		NoneViaFactory,
		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		NoneException,
		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		PublicationOnlyViaConstructor,
		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		PublicationOnlyViaFactory,
		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		PublicationOnlyWait,
		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		PublicationOnlyException,
		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		ExecutionAndPublicationViaConstructor,
		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		ExecutionAndPublicationViaFactory,
		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		ExecutionAndPublicationException
	}
}
