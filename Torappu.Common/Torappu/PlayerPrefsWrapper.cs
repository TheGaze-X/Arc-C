using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	public static class PlayerPrefsWrapper
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000062")]
		public static IPlayerDataLink s_playerDataLink
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x5500990", Offset = "0x54FF590", VA = "0x185500990")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x55009D0", Offset = "0x54FF5D0", VA = "0x1855009D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x5500930", Offset = "0x54FF530", VA = "0x185500930")]
		private static string _GetUid()
		{
			return null;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004D1")]
		public static void SaveCommonData<T>(string key, T obj, bool autoSave = true)
		{
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x5500370", Offset = "0x54FEF70", VA = "0x185500370")]
		public static void DeleteCommonData(string key)
		{
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D3")]
		public static T GetCommonData<T>(string key) where T : new()
		{
			return null;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000572C File Offset: 0x0000392C
		[Token(Token = "0x60004D4")]
		public static bool TryToGetCommonData<T>(string key, out T value) where T : new()
		{
			return default(bool);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x5500380", Offset = "0x54FEF80", VA = "0x185500380")]
		public static void DeleteUserKey(string key)
		{
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x5500430", Offset = "0x54FF030", VA = "0x185500430")]
		public static void DeleteUserKey(string uid, string key)
		{
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004D7")]
		public static void SaveUserData<T>(string key, T obj, bool autoSave = true)
		{
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004D8")]
		public static void SaveUserData<T>(string uid, string key, T obj, bool autoSave = true)
		{
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004D9")]
		public static T GetUserData<T>(string key) where T : new()
		{
			return null;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DA")]
		public static T GetUserData<T>(string uid, string key) where T : new()
		{
			return null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00005744 File Offset: 0x00003944
		[Token(Token = "0x60004DB")]
		public static bool TryToGetUserData<T>(string key, out T value) where T : new()
		{
			return default(bool);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000575C File Offset: 0x0000395C
		[Token(Token = "0x60004DC")]
		public static bool TryToGetUserData<T>(string uid, string key, out T value) where T : new()
		{
			return default(bool);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x5500800", Offset = "0x54FF400", VA = "0x185500800")]
		public static void SetUserString(string key, string value)
		{
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x55008C0", Offset = "0x54FF4C0", VA = "0x1855008C0")]
		public static void SetUserString(string uid, string key, string value)
		{
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x55005C0", Offset = "0x54FF1C0", VA = "0x1855005C0")]
		public static string GetUserString(string key)
		{
			return null;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x5500670", Offset = "0x54FF270", VA = "0x185500670")]
		public static string GetUserString(string uid, string key)
		{
			return null;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x55006D0", Offset = "0x54FF2D0", VA = "0x1855006D0")]
		public static void SetUserInt(string key, int value)
		{
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x5500790", Offset = "0x54FF390", VA = "0x185500790")]
		public static void SetUserInt(string uid, string key, int value)
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00005774 File Offset: 0x00003974
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x5500500", Offset = "0x54FF100", VA = "0x185500500")]
		public static int GetUserInt(string key, int defaultValue)
		{
			return 0;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000578C File Offset: 0x0000398C
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x5500490", Offset = "0x54FF090", VA = "0x185500490")]
		public static int GetUserInt(string uid, string key, int defaultValue)
		{
			return 0;
		}

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		private const string USER_DOMAIN_KEY = "{0}#{1}";
	}
}
