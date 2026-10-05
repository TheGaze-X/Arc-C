using System;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public class Loger
	{
		// Token: 0x06000165 RID: 357 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x5BE0420", Offset = "0x5BDF020", VA = "0x185BE0420")]
		public static void Log(string log)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x5BE0100", Offset = "0x5BDED00", VA = "0x185BE0100")]
		public static void AliLog(string log)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x5BE0570", Offset = "0x5BDF170", VA = "0x185BE0570")]
		public static void SaveLogsReport(string log)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x5BE05C0", Offset = "0x5BDF1C0", VA = "0x185BE05C0")]
		public static void SetAliLogEnable()
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Loger()
		{
		}

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x0")]
		private static bool logEnable;
	}
}
