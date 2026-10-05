using System;
using Il2CppDummyDll;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020005AE RID: 1454
	[Token(Token = "0x20005AE")]
	[System.Flags]
	public enum EventKeywords : long
	{
		// Token: 0x04001953 RID: 6483
		[Token(Token = "0x4001953")]
		None = 0L,
		// Token: 0x04001954 RID: 6484
		[Token(Token = "0x4001954")]
		All = -1L,
		// Token: 0x04001955 RID: 6485
		[Token(Token = "0x4001955")]
		MicrosoftTelemetry = 562949953421312L,
		// Token: 0x04001956 RID: 6486
		[Token(Token = "0x4001956")]
		WdiContext = 562949953421312L,
		// Token: 0x04001957 RID: 6487
		[Token(Token = "0x4001957")]
		WdiDiagnostic = 1125899906842624L,
		// Token: 0x04001958 RID: 6488
		[Token(Token = "0x4001958")]
		Sqm = 2251799813685248L,
		// Token: 0x04001959 RID: 6489
		[Token(Token = "0x4001959")]
		AuditFailure = 4503599627370496L,
		// Token: 0x0400195A RID: 6490
		[Token(Token = "0x400195A")]
		AuditSuccess = 9007199254740992L,
		// Token: 0x0400195B RID: 6491
		[Token(Token = "0x400195B")]
		CorrelationHint = 4503599627370496L,
		// Token: 0x0400195C RID: 6492
		[Token(Token = "0x400195C")]
		EventLogClassic = 36028797018963968L
	}
}
