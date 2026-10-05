using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000297 RID: 663
	[Token(Token = "0x2000297")]
	[Flags]
	internal enum FtpMethodFlags
	{
		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x400098E")]
		None = 0,
		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x400098F")]
		IsDownload = 1,
		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4000990")]
		IsUpload = 2,
		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		TakesParameter = 4,
		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		MayTakeParameter = 8,
		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		DoesNotTakeParameter = 16,
		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		ParameterIsDirectory = 32,
		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		ShouldParseForResponseUri = 64,
		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		HasHttpCommand = 128,
		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		MustChangeWorkingDirectoryToPath = 256
	}
}
