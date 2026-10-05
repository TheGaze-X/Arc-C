using System;
using Il2CppDummyDll;

namespace YoStar.SDK.Extension
{
	// Token: 0x02000228 RID: 552
	[Token(Token = "0x2000228")]
	public static class EnumExtensions
	{
		// Token: 0x06000E40 RID: 3648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E40")]
		public static T GetEnum<T>(this string name) where T : Enum
		{
			return null;
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E41")]
		public static T GetEnum<T>(this int value) where T : Enum
		{
			return null;
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E42")]
		public static string GetEnumName<T>(this T value) where T : Enum
		{
			return null;
		}
	}
}
