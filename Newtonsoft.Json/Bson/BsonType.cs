using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200012B RID: 299
	[Token(Token = "0x200012B")]
	[Preserve]
	internal enum BsonType : sbyte
	{
		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		Number = 1,
		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		String,
		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		Object,
		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		Array,
		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		Binary,
		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		Undefined,
		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		Oid,
		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		Boolean,
		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		Date,
		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		Null,
		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		Regex,
		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		Reference,
		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		Code,
		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		Symbol,
		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		CodeWScope,
		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		Integer,
		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		TimeStamp,
		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		Long,
		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		MinKey = -1,
		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		MaxKey = 127
	}
}
