using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace XLua.TemplateEngine
{
	// Token: 0x020002F8 RID: 760
	[Token(Token = "0x20002F8")]
	public class Chunk
	{
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060037F5 RID: 14325 RVA: 0x00016C38 File Offset: 0x00014E38
		// (set) Token: 0x060037F6 RID: 14326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700015A")]
		public TokenType Type
		{
			[Token(Token = "0x60037F5")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return TokenType.Code;
			}
			[Token(Token = "0x60037F6")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060037F7 RID: 14327 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060037F8 RID: 14328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700015B")]
		public string Text
		{
			[Token(Token = "0x60037F7")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037F8")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F9")]
		[Address(RVA = "0x3437250", Offset = "0x3435E50", VA = "0x183437250")]
		public Chunk(TokenType type, string text)
		{
		}
	}
}
