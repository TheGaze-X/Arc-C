using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.Logger
{
	// Token: 0x020004CE RID: 1230
	[Token(Token = "0x20004CE")]
	public class DefaultLogger : ILogger
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x000114F0 File Offset: 0x0000F6F0
		// (set) Token: 0x060028AE RID: 10414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D6")]
		public Loglevels Level
		{
			[Token(Token = "0x60028AD")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return Loglevels.All;
			}
			[Token(Token = "0x60028AE")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D7")]
		public string FormatVerbose
		{
			[Token(Token = "0x60028AF")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028B0")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D8")]
		public string FormatInfo
		{
			[Token(Token = "0x60028B1")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028B2")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D9")]
		public string FormatWarn
		{
			[Token(Token = "0x60028B3")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028B4")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DA")]
		public string FormatErr
		{
			[Token(Token = "0x60028B5")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028B6")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DB")]
		public string FormatEx
		{
			[Token(Token = "0x60028B7")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028B8")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028B9")]
		[Address(RVA = "0x539F820", Offset = "0x539E420", VA = "0x18539F820")]
		public DefaultLogger()
		{
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BA")]
		[Address(RVA = "0x539F700", Offset = "0x539E300", VA = "0x18539F700", Slot = "16")]
		public void Verbose(string division, string verb)
		{
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BB")]
		[Address(RVA = "0x539F670", Offset = "0x539E270", VA = "0x18539F670", Slot = "17")]
		public void Information(string division, string info)
		{
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BC")]
		[Address(RVA = "0x539F790", Offset = "0x539E390", VA = "0x18539F790", Slot = "18")]
		public void Warning(string division, string warn)
		{
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BD")]
		[Address(RVA = "0x539F240", Offset = "0x539DE40", VA = "0x18539F240", Slot = "19")]
		public void Error(string division, string err)
		{
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BE")]
		[Address(RVA = "0x539F2D0", Offset = "0x539DED0", VA = "0x18539F2D0", Slot = "20")]
		public void Exception(string division, string msg, Exception ex)
		{
		}
	}
}
