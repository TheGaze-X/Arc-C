using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002E4 RID: 740
	[Token(Token = "0x20002E4")]
	internal class CookieTokenizer
	{
		// Token: 0x06001476 RID: 5238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x5050880", Offset = "0x504F480", VA = "0x185050880")]
		internal CookieTokenizer(string tokenStream)
		{
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x00009A50 File Offset: 0x00007C50
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000453")]
		internal bool EndOfCookie
		{
			[Token(Token = "0x6001477")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001478")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			set
			{
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x00009A68 File Offset: 0x00007C68
		[Token(Token = "0x17000454")]
		internal bool Eof
		{
			[Token(Token = "0x6001479")]
			[Address(RVA = "0x50508D0", Offset = "0x504F4D0", VA = "0x1850508D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000455")]
		internal string Name
		{
			[Token(Token = "0x600147A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600147B")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x00009A80 File Offset: 0x00007C80
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000456")]
		internal bool Quoted
		{
			[Token(Token = "0x600147C")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600147D")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			set
			{
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x00009A98 File Offset: 0x00007C98
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000457")]
		internal CookieToken Token
		{
			[Token(Token = "0x600147E")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return CookieToken.Nothing;
			}
			[Token(Token = "0x600147F")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			set
			{
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000458")]
		internal string Value
		{
			[Token(Token = "0x6001480")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001481")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x504FAC0", Offset = "0x504E6C0", VA = "0x18504FAC0")]
		internal string Extract()
		{
			return null;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00009AB0 File Offset: 0x00007CB0
		[Token(Token = "0x6001483")]
		[Address(RVA = "0x504FB40", Offset = "0x504E740", VA = "0x18504FB40")]
		internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals)
		{
			return CookieToken.Nothing;
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x00009AC8 File Offset: 0x00007CC8
		[Token(Token = "0x6001484")]
		[Address(RVA = "0x504FD90", Offset = "0x504E990", VA = "0x18504FD90")]
		internal CookieToken Next(bool first, bool parseResponseCookies)
		{
			return CookieToken.Nothing;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001485")]
		[Address(RVA = "0x5050060", Offset = "0x504EC60", VA = "0x185050060")]
		internal void Reset()
		{
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00009AE0 File Offset: 0x00007CE0
		[Token(Token = "0x6001486")]
		[Address(RVA = "0x50500E0", Offset = "0x504ECE0", VA = "0x1850500E0")]
		internal CookieToken TokenFromName(bool parseResponseCookies)
		{
			return CookieToken.Nothing;
		}

		// Token: 0x04000B35 RID: 2869
		[Token(Token = "0x4000B35")]
		[FieldOffset(Offset = "0x10")]
		private bool m_eofCookie;

		// Token: 0x04000B36 RID: 2870
		[Token(Token = "0x4000B36")]
		[FieldOffset(Offset = "0x14")]
		private int m_index;

		// Token: 0x04000B37 RID: 2871
		[Token(Token = "0x4000B37")]
		[FieldOffset(Offset = "0x18")]
		private int m_length;

		// Token: 0x04000B38 RID: 2872
		[Token(Token = "0x4000B38")]
		[FieldOffset(Offset = "0x20")]
		private string m_name;

		// Token: 0x04000B39 RID: 2873
		[Token(Token = "0x4000B39")]
		[FieldOffset(Offset = "0x28")]
		private bool m_quoted;

		// Token: 0x04000B3A RID: 2874
		[Token(Token = "0x4000B3A")]
		[FieldOffset(Offset = "0x2C")]
		private int m_start;

		// Token: 0x04000B3B RID: 2875
		[Token(Token = "0x4000B3B")]
		[FieldOffset(Offset = "0x30")]
		private CookieToken m_token;

		// Token: 0x04000B3C RID: 2876
		[Token(Token = "0x4000B3C")]
		[FieldOffset(Offset = "0x34")]
		private int m_tokenLength;

		// Token: 0x04000B3D RID: 2877
		[Token(Token = "0x4000B3D")]
		[FieldOffset(Offset = "0x38")]
		private string m_tokenStream;

		// Token: 0x04000B3E RID: 2878
		[Token(Token = "0x4000B3E")]
		[FieldOffset(Offset = "0x40")]
		private string m_value;

		// Token: 0x04000B3F RID: 2879
		[Token(Token = "0x4000B3F")]
		[FieldOffset(Offset = "0x0")]
		private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes;

		// Token: 0x04000B40 RID: 2880
		[Token(Token = "0x4000B40")]
		[FieldOffset(Offset = "0x8")]
		private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes;

		// Token: 0x020002E5 RID: 741
		[Token(Token = "0x20002E5")]
		private struct RecognizedAttribute
		{
			// Token: 0x06001488 RID: 5256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001488")]
			[Address(RVA = "0x21178B0", Offset = "0x21164B0", VA = "0x1821178B0")]
			internal RecognizedAttribute(string name, CookieToken token)
			{
			}

			// Token: 0x17000459 RID: 1113
			// (get) Token: 0x06001489 RID: 5257 RVA: 0x00009AF8 File Offset: 0x00007CF8
			[Token(Token = "0x17000459")]
			internal CookieToken Token
			{
				[Token(Token = "0x6001489")]
				[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
				get
				{
					return CookieToken.Nothing;
				}
			}

			// Token: 0x0600148A RID: 5258 RVA: 0x00009B10 File Offset: 0x00007D10
			[Token(Token = "0x600148A")]
			[Address(RVA = "0x505C260", Offset = "0x505AE60", VA = "0x18505C260")]
			internal bool IsEqualTo(string value)
			{
				return default(bool);
			}

			// Token: 0x04000B41 RID: 2881
			[Token(Token = "0x4000B41")]
			[FieldOffset(Offset = "0x0")]
			private string m_name;

			// Token: 0x04000B42 RID: 2882
			[Token(Token = "0x4000B42")]
			[FieldOffset(Offset = "0x8")]
			private CookieToken m_token;
		}
	}
}
