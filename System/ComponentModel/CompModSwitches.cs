using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000200 RID: 512
	[Token(Token = "0x2000200")]
	internal static class CompModSwitches
	{
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CD")]
		public static BooleanSwitch CommonDesignerServices
		{
			[Token(Token = "0x6000D73")]
			[Address(RVA = "0x5157FF0", Offset = "0x5156BF0", VA = "0x185157FF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CE")]
		public static TraceSwitch EventLog
		{
			[Token(Token = "0x6000D74")]
			[Address(RVA = "0x51580D0", Offset = "0x5156CD0", VA = "0x1851580D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0x0")]
		private static BooleanSwitch commonDesignerServices;

		// Token: 0x04000782 RID: 1922
		[Token(Token = "0x4000782")]
		[FieldOffset(Offset = "0x8")]
		private static TraceSwitch eventLog;
	}
}
