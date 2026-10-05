using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000419 RID: 1049
	[Token(Token = "0x2000419")]
	internal enum BinaryHeaderEnum
	{
		// Token: 0x04001118 RID: 4376
		[Token(Token = "0x4001118")]
		SerializedStreamHeader,
		// Token: 0x04001119 RID: 4377
		[Token(Token = "0x4001119")]
		Object,
		// Token: 0x0400111A RID: 4378
		[Token(Token = "0x400111A")]
		ObjectWithMap,
		// Token: 0x0400111B RID: 4379
		[Token(Token = "0x400111B")]
		ObjectWithMapAssemId,
		// Token: 0x0400111C RID: 4380
		[Token(Token = "0x400111C")]
		ObjectWithMapTyped,
		// Token: 0x0400111D RID: 4381
		[Token(Token = "0x400111D")]
		ObjectWithMapTypedAssemId,
		// Token: 0x0400111E RID: 4382
		[Token(Token = "0x400111E")]
		ObjectString,
		// Token: 0x0400111F RID: 4383
		[Token(Token = "0x400111F")]
		Array,
		// Token: 0x04001120 RID: 4384
		[Token(Token = "0x4001120")]
		MemberPrimitiveTyped,
		// Token: 0x04001121 RID: 4385
		[Token(Token = "0x4001121")]
		MemberReference,
		// Token: 0x04001122 RID: 4386
		[Token(Token = "0x4001122")]
		ObjectNull,
		// Token: 0x04001123 RID: 4387
		[Token(Token = "0x4001123")]
		MessageEnd,
		// Token: 0x04001124 RID: 4388
		[Token(Token = "0x4001124")]
		Assembly,
		// Token: 0x04001125 RID: 4389
		[Token(Token = "0x4001125")]
		ObjectNullMultiple256,
		// Token: 0x04001126 RID: 4390
		[Token(Token = "0x4001126")]
		ObjectNullMultiple,
		// Token: 0x04001127 RID: 4391
		[Token(Token = "0x4001127")]
		ArraySinglePrimitive,
		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001128")]
		ArraySingleObject,
		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		ArraySingleString,
		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x400112A")]
		CrossAppDomainMap,
		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400112B")]
		CrossAppDomainString,
		// Token: 0x0400112C RID: 4396
		[Token(Token = "0x400112C")]
		CrossAppDomainAssembly,
		// Token: 0x0400112D RID: 4397
		[Token(Token = "0x400112D")]
		MethodCall,
		// Token: 0x0400112E RID: 4398
		[Token(Token = "0x400112E")]
		MethodReturn
	}
}
