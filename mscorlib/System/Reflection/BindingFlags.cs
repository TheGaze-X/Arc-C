using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x020004F2 RID: 1266
	[Token(Token = "0x20004F2")]
	[System.Flags]
	public enum BindingFlags
	{
		// Token: 0x0400149B RID: 5275
		[Token(Token = "0x400149B")]
		Default = 0,
		// Token: 0x0400149C RID: 5276
		[Token(Token = "0x400149C")]
		IgnoreCase = 1,
		// Token: 0x0400149D RID: 5277
		[Token(Token = "0x400149D")]
		DeclaredOnly = 2,
		// Token: 0x0400149E RID: 5278
		[Token(Token = "0x400149E")]
		Instance = 4,
		// Token: 0x0400149F RID: 5279
		[Token(Token = "0x400149F")]
		Static = 8,
		// Token: 0x040014A0 RID: 5280
		[Token(Token = "0x40014A0")]
		Public = 16,
		// Token: 0x040014A1 RID: 5281
		[Token(Token = "0x40014A1")]
		NonPublic = 32,
		// Token: 0x040014A2 RID: 5282
		[Token(Token = "0x40014A2")]
		FlattenHierarchy = 64,
		// Token: 0x040014A3 RID: 5283
		[Token(Token = "0x40014A3")]
		InvokeMethod = 256,
		// Token: 0x040014A4 RID: 5284
		[Token(Token = "0x40014A4")]
		CreateInstance = 512,
		// Token: 0x040014A5 RID: 5285
		[Token(Token = "0x40014A5")]
		GetField = 1024,
		// Token: 0x040014A6 RID: 5286
		[Token(Token = "0x40014A6")]
		SetField = 2048,
		// Token: 0x040014A7 RID: 5287
		[Token(Token = "0x40014A7")]
		GetProperty = 4096,
		// Token: 0x040014A8 RID: 5288
		[Token(Token = "0x40014A8")]
		SetProperty = 8192,
		// Token: 0x040014A9 RID: 5289
		[Token(Token = "0x40014A9")]
		PutDispProperty = 16384,
		// Token: 0x040014AA RID: 5290
		[Token(Token = "0x40014AA")]
		PutRefDispProperty = 32768,
		// Token: 0x040014AB RID: 5291
		[Token(Token = "0x40014AB")]
		ExactBinding = 65536,
		// Token: 0x040014AC RID: 5292
		[Token(Token = "0x40014AC")]
		SuppressChangeType = 131072,
		// Token: 0x040014AD RID: 5293
		[Token(Token = "0x40014AD")]
		OptionalParamBinding = 262144,
		// Token: 0x040014AE RID: 5294
		[Token(Token = "0x40014AE")]
		IgnoreReturn = 16777216,
		// Token: 0x040014AF RID: 5295
		[Token(Token = "0x40014AF")]
		DoNotWrapExceptions = 33554432
	}
}
