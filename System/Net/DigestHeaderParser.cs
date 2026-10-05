using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2000309")]
	internal class DigestHeaderParser
	{
		// Token: 0x0600153E RID: 5438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600153E")]
		[Address(RVA = "0x506BD70", Offset = "0x506A970", VA = "0x18506BD70")]
		public DigestHeaderParser(string header)
		{
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047A")]
		public string Realm
		{
			[Token(Token = "0x600153F")]
			[Address(RVA = "0x35EEE60", Offset = "0x35EDA60", VA = "0x1835EEE60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047B")]
		public string Opaque
		{
			[Token(Token = "0x6001540")]
			[Address(RVA = "0x4C2FA60", Offset = "0x4C2E660", VA = "0x184C2FA60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047C")]
		public string Nonce
		{
			[Token(Token = "0x6001541")]
			[Address(RVA = "0x4C2FAC0", Offset = "0x4C2E6C0", VA = "0x184C2FAC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047D")]
		public string Algorithm
		{
			[Token(Token = "0x6001542")]
			[Address(RVA = "0x4C2FAF0", Offset = "0x4C2E6F0", VA = "0x184C2FAF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047E")]
		public string QOP
		{
			[Token(Token = "0x6001543")]
			[Address(RVA = "0x4C2FB20", Offset = "0x4C2E720", VA = "0x184C2FB20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00009EB8 File Offset: 0x000080B8
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x506B880", Offset = "0x506A480", VA = "0x18506B880")]
		public bool Parse()
		{
			return default(bool);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001545")]
		[Address(RVA = "0x506BA90", Offset = "0x506A690", VA = "0x18506BA90")]
		private void SkipWhitespace()
		{
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001546")]
		[Address(RVA = "0x506B530", Offset = "0x506A130", VA = "0x18506B530")]
		private string GetKey()
		{
			return null;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00009ED0 File Offset: 0x000080D0
		[Token(Token = "0x6001547")]
		[Address(RVA = "0x506B610", Offset = "0x506A210", VA = "0x18506B610")]
		private bool GetKeywordAndValue(out string key, out string value)
		{
			return default(bool);
		}

		// Token: 0x04000BA8 RID: 2984
		[Token(Token = "0x4000BA8")]
		[FieldOffset(Offset = "0x10")]
		private string header;

		// Token: 0x04000BA9 RID: 2985
		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x18")]
		private int length;

		// Token: 0x04000BAA RID: 2986
		[Token(Token = "0x4000BAA")]
		[FieldOffset(Offset = "0x1C")]
		private int pos;

		// Token: 0x04000BAB RID: 2987
		[Token(Token = "0x4000BAB")]
		[FieldOffset(Offset = "0x0")]
		private static string[] keywords;

		// Token: 0x04000BAC RID: 2988
		[Token(Token = "0x4000BAC")]
		[FieldOffset(Offset = "0x20")]
		private string[] values;
	}
}
