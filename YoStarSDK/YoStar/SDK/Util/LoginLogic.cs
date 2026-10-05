using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.Util
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	public class LoginLogic
	{
		// Token: 0x06000449 RID: 1097 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x5C0D570", Offset = "0x5C0C170", VA = "0x185C0D570")]
		public static void Login(bool isAuto = false)
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x5C0D280", Offset = "0x5C0BE80", VA = "0x185C0D280")]
		private static void ContinueLogin(bool isAuto)
		{
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x5C0E620", Offset = "0x5C0D220", VA = "0x185C0E620")]
		public static void RetrieveAccountContinueLogin(bool continueLogin, bool isAuto = false)
		{
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x5C0DFE0", Offset = "0x5C0CBE0", VA = "0x185C0DFE0")]
		private static void RetrieveAccountContinueLogin(bool continueLogin, Action<string> callback)
		{
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x5C0D9B0", Offset = "0x5C0C5B0", VA = "0x185C0D9B0")]
		public static void QunhunMigrate(string channel, long uid2, string token)
		{
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x5C0E700", Offset = "0x5C0D300", VA = "0x185C0E700")]
		public static void ShowLoginView(bool showBack = false)
		{
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x5C0EBB0", Offset = "0x5C0D7B0", VA = "0x185C0EBB0")]
		private static void TokenMigration()
		{
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x5C0E850", Offset = "0x5C0D450", VA = "0x185C0E850")]
		private static void StoreUIDToHistory(Dictionary<string, object> responseResult)
		{
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoginLogic()
		{
		}

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x0")]
		private static string OpenedRetrieveAccountWeb;
	}
}
