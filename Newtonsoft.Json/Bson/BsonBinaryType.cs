using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	[Preserve]
	internal enum BsonBinaryType : byte
	{
		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		Binary,
		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		Function,
		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
		BinaryOld,
		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
		UuidOld,
		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		Uuid,
		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		Md5,
		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		UserDefined = 128
	}
}
