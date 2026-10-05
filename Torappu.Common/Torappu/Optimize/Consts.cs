using System;
using Il2CppDummyDll;

namespace Torappu.Optimize
{
	// Token: 0x020001F3 RID: 499
	[Token(Token = "0x20001F3")]
	public static class Consts
	{
		// Token: 0x06000BC0 RID: 3008 RVA: 0x00007FC4 File Offset: 0x000061C4
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x5565550", Offset = "0x5564150", VA = "0x185565550")]
		public static bool IsMobilePlatform(string platform)
		{
			return default(bool);
		}

		// Token: 0x04000B7A RID: 2938
		[Token(Token = "0x4000B7A")]
		public const string ALPHA_SUFFIX_NO_EXTENSION = "[alpha]";

		// Token: 0x04000B7B RID: 2939
		[Token(Token = "0x4000B7B")]
		public const string ALPHA_SUFFIX_WITH_EXTENSION = "[alpha].png";

		// Token: 0x04000B7C RID: 2940
		[Token(Token = "0x4000B7C")]
		public const string PLATFORM_ANDROID = "Android";

		// Token: 0x04000B7D RID: 2941
		[Token(Token = "0x4000B7D")]
		public const string PLATFORM_IOS = "iPhone";

		// Token: 0x04000B7E RID: 2942
		[Token(Token = "0x4000B7E")]
		public const string PLATFORM_STANDALONE = "Standalone";

		// Token: 0x04000B7F RID: 2943
		[Token(Token = "0x4000B7F")]
		public const string PLATFORM_OH = "OpenHarmony";

		// Token: 0x04000B80 RID: 2944
		[Token(Token = "0x4000B80")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string[] ALL_PLATFORMS;

		// Token: 0x04000B81 RID: 2945
		[Token(Token = "0x4000B81")]
		public const string CHARACTER_ILLUSTRATION_PREFIX = "illust_";
	}
}
