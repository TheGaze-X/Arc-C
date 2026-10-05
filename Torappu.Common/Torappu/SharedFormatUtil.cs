using System;
using System.Text;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public class SharedFormatUtil : IHotfixable
	{
		// Token: 0x06000162 RID: 354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x54EE4E0", Offset = "0x54ED0E0", VA = "0x1854EE4E0")]
		public static string SharedFormatRichTextFromData(string richText)
		{
			return null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x54ED830", Offset = "0x54EC430", VA = "0x1854ED830")]
		protected static string FormatRichTextTag(SharedFormatUtil.LightStringStream stream, string tag, SharedFormatUtil.RichTextTagHandler tagHandler)
		{
			return null;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x54ED6D0", Offset = "0x54EC2D0", VA = "0x1854ED6D0")]
		protected static bool CheckIfStartTag(string tag)
		{
			return default(bool);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x54EDCD0", Offset = "0x54EC8D0", VA = "0x1854EDCD0")]
		protected static bool RichTextConvertTagsHandler(string startTag, string endTag, StringBuilder content, out string result)
		{
			return default(bool);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x54EE280", Offset = "0x54ECE80", VA = "0x1854EE280")]
		protected static bool RichTextIgnoreTagsHandler(string startTag, string endTag, StringBuilder content, out string result)
		{
			return default(bool);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x54EE6F0", Offset = "0x54ED2F0", VA = "0x1854EE6F0")]
		public SharedFormatUtil()
		{
		}

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		protected const long NUMBER_MONEY_SIZE = 1000000L;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		protected const string NUMBER_MONEY_MAX = "999999+";

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		protected const long NUMBER_UNIT_SIZE = 1000L;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		protected const string NUMBER_UNIT_MAX = "999+";

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		protected const char NON_BREAKING_SPACE = '\u00a0';

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		protected const string AVG_SPLIT_CONTENT_TAG_PREFIX = "p=";

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate19 __Hotfix0_SharedFormatRichTextFromData;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate20 __Hotfix0_FormatRichTextTag;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate21 __Hotfix0_CheckIfStartTag;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate22 __Hotfix0_RichTextConvertTagsHandler;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate22 __Hotfix0_RichTextIgnoreTagsHandler;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x06000169 RID: 361
		[Token(Token = "0x2000073")]
		protected delegate bool RichTextTagHandler(string startTag, string endTag, StringBuilder content, out string result);

		// Token: 0x02000074 RID: 116
		[Token(Token = "0x2000074")]
		protected class LightStringStream
		{
			// Token: 0x0600016C RID: 364 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LightStringStream()
			{
			}

			// Token: 0x0600016D RID: 365 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x54E44E0", Offset = "0x54E30E0", VA = "0x1854E44E0")]
			public LightStringStream(string source)
			{
			}

			// Token: 0x0600016E RID: 366 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x54E4480", Offset = "0x54E3080", VA = "0x1854E4480")]
			public SharedFormatUtil.LightStringStream Reset(string source)
			{
				return null;
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600016F RID: 367 RVA: 0x00002C54 File Offset: 0x00000E54
			[Token(Token = "0x1700001F")]
			public bool isEnd
			{
				[Token(Token = "0x600016F")]
				[Address(RVA = "0x54E4540", Offset = "0x54E3140", VA = "0x1854E4540")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000170 RID: 368 RVA: 0x00002C6C File Offset: 0x00000E6C
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x54E43E0", Offset = "0x54E2FE0", VA = "0x1854E43E0")]
			public char Peek()
			{
				return '\0';
			}

			// Token: 0x06000171 RID: 369 RVA: 0x00002C84 File Offset: 0x00000E84
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x54E4440", Offset = "0x54E3040", VA = "0x1854E4440")]
			public char Read()
			{
				return '\0';
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000172 RID: 370 RVA: 0x00002C9C File Offset: 0x00000E9C
			[Token(Token = "0x17000020")]
			public int head
			{
				[Token(Token = "0x6000172")]
				[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000173 RID: 371 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x54E4410", Offset = "0x54E3010", VA = "0x1854E4410")]
			public string Range(int start, int end)
			{
				return null;
			}

			// Token: 0x04000312 RID: 786
			[Token(Token = "0x4000312")]
			[FieldOffset(Offset = "0x10")]
			private string m_source;

			// Token: 0x04000313 RID: 787
			[Token(Token = "0x4000313")]
			[FieldOffset(Offset = "0x18")]
			private int m_length;

			// Token: 0x04000314 RID: 788
			[Token(Token = "0x4000314")]
			[FieldOffset(Offset = "0x1C")]
			private int m_head;
		}
	}
}
