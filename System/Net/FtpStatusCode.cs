using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002A9 RID: 681
	[Token(Token = "0x20002A9")]
	public enum FtpStatusCode
	{
		// Token: 0x040009EE RID: 2542
		[Token(Token = "0x40009EE")]
		Undefined,
		// Token: 0x040009EF RID: 2543
		[Token(Token = "0x40009EF")]
		RestartMarker = 110,
		// Token: 0x040009F0 RID: 2544
		[Token(Token = "0x40009F0")]
		ServiceTemporarilyNotAvailable = 120,
		// Token: 0x040009F1 RID: 2545
		[Token(Token = "0x40009F1")]
		DataAlreadyOpen = 125,
		// Token: 0x040009F2 RID: 2546
		[Token(Token = "0x40009F2")]
		OpeningData = 150,
		// Token: 0x040009F3 RID: 2547
		[Token(Token = "0x40009F3")]
		CommandOK = 200,
		// Token: 0x040009F4 RID: 2548
		[Token(Token = "0x40009F4")]
		CommandExtraneous = 202,
		// Token: 0x040009F5 RID: 2549
		[Token(Token = "0x40009F5")]
		DirectoryStatus = 212,
		// Token: 0x040009F6 RID: 2550
		[Token(Token = "0x40009F6")]
		FileStatus,
		// Token: 0x040009F7 RID: 2551
		[Token(Token = "0x40009F7")]
		SystemType = 215,
		// Token: 0x040009F8 RID: 2552
		[Token(Token = "0x40009F8")]
		SendUserCommand = 220,
		// Token: 0x040009F9 RID: 2553
		[Token(Token = "0x40009F9")]
		ClosingControl,
		// Token: 0x040009FA RID: 2554
		[Token(Token = "0x40009FA")]
		ClosingData = 226,
		// Token: 0x040009FB RID: 2555
		[Token(Token = "0x40009FB")]
		EnteringPassive,
		// Token: 0x040009FC RID: 2556
		[Token(Token = "0x40009FC")]
		LoggedInProceed = 230,
		// Token: 0x040009FD RID: 2557
		[Token(Token = "0x40009FD")]
		ServerWantsSecureSession = 234,
		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		FileActionOK = 250,
		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		PathnameCreated = 257,
		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		SendPasswordCommand = 331,
		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		NeedLoginAccount,
		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		FileCommandPending = 350,
		// Token: 0x04000A03 RID: 2563
		[Token(Token = "0x4000A03")]
		ServiceNotAvailable = 421,
		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4000A04")]
		CantOpenData = 425,
		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		ConnectionClosed,
		// Token: 0x04000A06 RID: 2566
		[Token(Token = "0x4000A06")]
		ActionNotTakenFileUnavailableOrBusy = 450,
		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4000A07")]
		ActionAbortedLocalProcessingError,
		// Token: 0x04000A08 RID: 2568
		[Token(Token = "0x4000A08")]
		ActionNotTakenInsufficientSpace,
		// Token: 0x04000A09 RID: 2569
		[Token(Token = "0x4000A09")]
		CommandSyntaxError = 500,
		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4000A0A")]
		ArgumentSyntaxError,
		// Token: 0x04000A0B RID: 2571
		[Token(Token = "0x4000A0B")]
		CommandNotImplemented,
		// Token: 0x04000A0C RID: 2572
		[Token(Token = "0x4000A0C")]
		BadCommandSequence,
		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		NotLoggedIn = 530,
		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		AccountNeeded = 532,
		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		ActionNotTakenFileUnavailable = 550,
		// Token: 0x04000A10 RID: 2576
		[Token(Token = "0x4000A10")]
		ActionAbortedUnknownPageType,
		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4000A11")]
		FileActionAborted,
		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4000A12")]
		ActionNotTakenFilenameNotAllowed
	}
}
