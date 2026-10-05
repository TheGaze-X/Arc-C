using System;
using Il2CppDummyDll;

namespace BestHTTP.Logger
{
	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20004D0")]
	public interface ILogger
	{
		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060028BF RID: 10431
		// (set) Token: 0x060028C0 RID: 10432
		[Token(Token = "0x170005DC")]
		Loglevels Level { [Token(Token = "0x60028BF")] get; [Token(Token = "0x60028C0")] set; }

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060028C1 RID: 10433
		// (set) Token: 0x060028C2 RID: 10434
		[Token(Token = "0x170005DD")]
		string FormatVerbose { [Token(Token = "0x60028C1")] get; [Token(Token = "0x60028C2")] set; }

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060028C3 RID: 10435
		// (set) Token: 0x060028C4 RID: 10436
		[Token(Token = "0x170005DE")]
		string FormatInfo { [Token(Token = "0x60028C3")] get; [Token(Token = "0x60028C4")] set; }

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060028C5 RID: 10437
		// (set) Token: 0x060028C6 RID: 10438
		[Token(Token = "0x170005DF")]
		string FormatWarn { [Token(Token = "0x60028C5")] get; [Token(Token = "0x60028C6")] set; }

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060028C7 RID: 10439
		// (set) Token: 0x060028C8 RID: 10440
		[Token(Token = "0x170005E0")]
		string FormatErr { [Token(Token = "0x60028C7")] get; [Token(Token = "0x60028C8")] set; }

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060028C9 RID: 10441
		// (set) Token: 0x060028CA RID: 10442
		[Token(Token = "0x170005E1")]
		string FormatEx { [Token(Token = "0x60028C9")] get; [Token(Token = "0x60028CA")] set; }

		// Token: 0x060028CB RID: 10443
		[Token(Token = "0x60028CB")]
		void Verbose(string division, string verb);

		// Token: 0x060028CC RID: 10444
		[Token(Token = "0x60028CC")]
		void Information(string division, string info);

		// Token: 0x060028CD RID: 10445
		[Token(Token = "0x60028CD")]
		void Warning(string division, string warn);

		// Token: 0x060028CE RID: 10446
		[Token(Token = "0x60028CE")]
		void Error(string division, string err);

		// Token: 0x060028CF RID: 10447
		[Token(Token = "0x60028CF")]
		void Exception(string division, string msg, Exception ex);
	}
}
