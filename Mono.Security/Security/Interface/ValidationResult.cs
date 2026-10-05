using System;
using Il2CppDummyDll;

namespace Mono.Security.Interface
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class ValidationResult
	{
		// Token: 0x06000144 RID: 324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x4AA7D50", Offset = "0x4AA6950", VA = "0x184AA7D50")]
		public ValidationResult(bool trusted, bool user_denied, int error_code, MonoSslPolicyErrors? policy_errors)
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x17000060")]
		public bool Trusted
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x17000061")]
		public bool UserDenied
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x10")]
		private bool trusted;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x11")]
		private bool user_denied;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x14")]
		private int error_code;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x18")]
		private MonoSslPolicyErrors? policy_errors;
	}
}
