using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000452 RID: 1106
	[Token(Token = "0x2000452")]
	[System.Flags]
	[System.Serializable]
	internal enum MessageEnum
	{
		// Token: 0x04001303 RID: 4867
		[Token(Token = "0x4001303")]
		NoArgs = 1,
		// Token: 0x04001304 RID: 4868
		[Token(Token = "0x4001304")]
		ArgsInline = 2,
		// Token: 0x04001305 RID: 4869
		[Token(Token = "0x4001305")]
		ArgsIsArray = 4,
		// Token: 0x04001306 RID: 4870
		[Token(Token = "0x4001306")]
		ArgsInArray = 8,
		// Token: 0x04001307 RID: 4871
		[Token(Token = "0x4001307")]
		NoContext = 16,
		// Token: 0x04001308 RID: 4872
		[Token(Token = "0x4001308")]
		ContextInline = 32,
		// Token: 0x04001309 RID: 4873
		[Token(Token = "0x4001309")]
		ContextInArray = 64,
		// Token: 0x0400130A RID: 4874
		[Token(Token = "0x400130A")]
		MethodSignatureInArray = 128,
		// Token: 0x0400130B RID: 4875
		[Token(Token = "0x400130B")]
		PropertyInArray = 256,
		// Token: 0x0400130C RID: 4876
		[Token(Token = "0x400130C")]
		NoReturnValue = 512,
		// Token: 0x0400130D RID: 4877
		[Token(Token = "0x400130D")]
		ReturnValueVoid = 1024,
		// Token: 0x0400130E RID: 4878
		[Token(Token = "0x400130E")]
		ReturnValueInline = 2048,
		// Token: 0x0400130F RID: 4879
		[Token(Token = "0x400130F")]
		ReturnValueInArray = 4096,
		// Token: 0x04001310 RID: 4880
		[Token(Token = "0x4001310")]
		ExceptionInArray = 8192,
		// Token: 0x04001311 RID: 4881
		[Token(Token = "0x4001311")]
		GenericMethod = 32768
	}
}
