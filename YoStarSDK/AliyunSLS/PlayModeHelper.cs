using System;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class PlayModeHelper
	{
		// Token: 0x0600008C RID: 140 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x5BE1D00", Offset = "0x5BE0900", VA = "0x185BE1D00")]
		public static bool isInPlayMode()
		{
			return default(bool);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayModeHelper()
		{
		}

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x0")]
		private static PlayModeHelper instance;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x8")]
		private static bool sInPlayMode;
	}
}
