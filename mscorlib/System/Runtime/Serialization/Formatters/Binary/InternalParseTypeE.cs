using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200041D RID: 1053
	[Token(Token = "0x200041D")]
	internal enum InternalParseTypeE
	{
		// Token: 0x04001143 RID: 4419
		[Token(Token = "0x4001143")]
		Empty,
		// Token: 0x04001144 RID: 4420
		[Token(Token = "0x4001144")]
		SerializedStreamHeader,
		// Token: 0x04001145 RID: 4421
		[Token(Token = "0x4001145")]
		Object,
		// Token: 0x04001146 RID: 4422
		[Token(Token = "0x4001146")]
		Member,
		// Token: 0x04001147 RID: 4423
		[Token(Token = "0x4001147")]
		ObjectEnd,
		// Token: 0x04001148 RID: 4424
		[Token(Token = "0x4001148")]
		MemberEnd,
		// Token: 0x04001149 RID: 4425
		[Token(Token = "0x4001149")]
		Headers,
		// Token: 0x0400114A RID: 4426
		[Token(Token = "0x400114A")]
		HeadersEnd,
		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x400114B")]
		SerializedStreamHeaderEnd,
		// Token: 0x0400114C RID: 4428
		[Token(Token = "0x400114C")]
		Envelope,
		// Token: 0x0400114D RID: 4429
		[Token(Token = "0x400114D")]
		EnvelopeEnd,
		// Token: 0x0400114E RID: 4430
		[Token(Token = "0x400114E")]
		Body,
		// Token: 0x0400114F RID: 4431
		[Token(Token = "0x400114F")]
		BodyEnd
	}
}
