using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[Serializable]
	public class Cookie
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x17000011")]
		public bool IsValid
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x5BB31A0", Offset = "0x5BB1DA0", VA = "0x185BB31A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x5BB3050", Offset = "0x5BB1C50", VA = "0x185BB3050")]
		public static Cookie[] ArrayFromJson(string serializedCookies)
		{
			return null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x5BB30E0", Offset = "0x5BB1CE0", VA = "0x185BB30E0")]
		public static Cookie FromJson(string serializedCookie)
		{
			return null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x56B5700", Offset = "0x56B4300", VA = "0x1856B5700")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x56B5700", Offset = "0x56B4300", VA = "0x1856B5700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x5BB3150", Offset = "0x5BB1D50", VA = "0x185BB3150")]
		public Cookie()
		{
		}

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x18")]
		public string Value;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x20")]
		public string Domain;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x28")]
		public string Path;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x30")]
		public int ExpirationDate;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x34")]
		public bool HttpOnly;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x35")]
		public bool Secure;
	}
}
