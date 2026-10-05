using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YoStar.SDK.LitJson;

namespace YoStar.SDK.Util
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	public class AppUtils
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003D0")]
		public static void MainThreadCall<T0>(CallbackGlobal<T0> callback, T0 p0)
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003D1")]
		public static void MainThreadCall<T0, T1>(CallbackGlobal<T0, T1> callback, T0 p0, T1 p1)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003D2")]
		public static void MainThreadCall<T0, T1, T2>(CallbackGlobal<T0, T1, T2> callback, T0 p0, T1 p1, T2 p2)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x5C04DE0", Offset = "0x5C039E0", VA = "0x185C04DE0")]
		public static string GetVersion()
		{
			return null;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x5C05F30", Offset = "0x5C04B30", VA = "0x185C05F30")]
		public static bool RegexText(string text, string pattern)
		{
			return default(bool);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x5C08170", Offset = "0x5C06D70", VA = "0x185C08170")]
		public static bool ValidPID(string pid)
		{
			return default(bool);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x5C04220", Offset = "0x5C02E20", VA = "0x185C04220")]
		public static string GetStringByKey(JsonData jsonData, string key)
		{
			return null;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x5C05150", Offset = "0x5C03D50", VA = "0x185C05150")]
		public static bool IsValidUrl(string url)
		{
			return default(bool);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x5C037F0", Offset = "0x5C023F0", VA = "0x185C037F0")]
		public static LoginPlatform GetLoginPlatformBy(string platformStr)
		{
			return LoginPlatform.DEVICE;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x5C04A30", Offset = "0x5C03630", VA = "0x185C04A30")]
		public static string GetTitleByAgreement(string agreement)
		{
			return null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x5C01CE0", Offset = "0x5C008E0", VA = "0x185C01CE0")]
		public static void DealMigratePopup(string uid, bool bindEmail)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x5C01170", Offset = "0x5BFFD70", VA = "0x185C01170")]
		public static string AgreementStore(string version)
		{
			return null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x5C06A60", Offset = "0x5C05660", VA = "0x185C06A60")]
		public static bool ShowUserAgreement()
		{
			return default(bool);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x5C06A00", Offset = "0x5C05600", VA = "0x185C06A00")]
		public static bool ShowPrivacyAgreement()
		{
			return default(bool);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x5C069A0", Offset = "0x5C055A0", VA = "0x185C069A0")]
		public static bool ShowCreditInvestigationAgreement()
		{
			return default(bool);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x5C06640", Offset = "0x5C05240", VA = "0x185C06640")]
		private static bool ShowAgreement(string agreement)
		{
			return default(bool);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x5C01030", Offset = "0x5BFFC30", VA = "0x185C01030")]
		public static void AgreeUserAgreement()
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x5C00FD0", Offset = "0x5BFFBD0", VA = "0x185C00FD0")]
		public static void AgreePrivacyAgreement()
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x5C00E10", Offset = "0x5BFFA10", VA = "0x185C00E10")]
		public static void AgreeCreditInvestigationAgreement()
		{
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x5C00E70", Offset = "0x5BFFA70", VA = "0x185C00E70")]
		public static void AgreeMinorsShopAgreement()
		{
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x5C03A70", Offset = "0x5C02670", VA = "0x185C03A70")]
		public static bool GetMinorsShopAgreement()
		{
			return default(bool);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x5C00B00", Offset = "0x5BFF700", VA = "0x185C00B00")]
		private static void AgreeAgreement(string agreement)
		{
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x5C05FC0", Offset = "0x5C04BC0", VA = "0x185C05FC0")]
		public static void RejectAgreementOrCerti()
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x5C07990", Offset = "0x5C06590", VA = "0x185C07990")]
		public static void UserAgeLimit(int code)
		{
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x5C034B0", Offset = "0x5C020B0", VA = "0x185C034B0")]
		public static string GetErrorInfo(int code)
		{
			return null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x5C07FA0", Offset = "0x5C06BA0", VA = "0x185C07FA0")]
		public static bool ValidEmail(string email)
		{
			return default(bool);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x5C07D50", Offset = "0x5C06950", VA = "0x185C07D50")]
		public static bool ValidCodeEmail(string code, string email)
		{
			return default(bool);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x5C05810", Offset = "0x5C04410", VA = "0x185C05810")]
		private static void Log(string msg)
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EC")]
		public static T FromJson<T>(string json, [Optional] T defaultValue)
		{
			return null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003ED")]
		public static T FromObject<T>(object obj)
		{
			return null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x5C071D0", Offset = "0x5C05DD0", VA = "0x185C071D0")]
		public static string ToJson(object obj)
		{
			return null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x5C042C0", Offset = "0x5C02EC0", VA = "0x185C042C0")]
		public static string GetSystemLanguage()
		{
			return null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x5C04D50", Offset = "0x5C03950", VA = "0x185C04D50")]
		public static string GetUID()
		{
			return null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x5C04DF0", Offset = "0x5C039F0", VA = "0x185C04DF0")]
		public static string GetYoStarID()
		{
			return null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x5C01FA0", Offset = "0x5C00BA0", VA = "0x185C01FA0")]
		public static void DelayAction(Action<object> action, [Optional] object param, float delayTime = 0.2f)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x5C070B0", Offset = "0x5C05CB0", VA = "0x185C070B0")]
		public static void ToCpCallbackInLogin(Action<bool> action)
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x5C058C0", Offset = "0x5C044C0", VA = "0x185C058C0")]
		public static string LoginPlatformName(LoginPlatform loginPlatform)
		{
			return null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x5C05A00", Offset = "0x5C04600", VA = "0x185C05A00")]
		public static void OpenWebView(string url, string title = "", bool inter = false)
		{
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x5C06420", Offset = "0x5C05020", VA = "0x185C06420")]
		public static void SetBirthData(string birth)
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x5C02FD0", Offset = "0x5C01BD0", VA = "0x185C02FD0")]
		public static string GetBirthData()
		{
			return null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x5C01900", Offset = "0x5C00500", VA = "0x185C01900")]
		public static void DealClientLang(List<string> langs)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x5C05590", Offset = "0x5C04190", VA = "0x185C05590")]
		private static string LocalLangFromServerLang(string serverLang = "")
		{
			return null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x5C06210", Offset = "0x5C04E10", VA = "0x185C06210")]
		public static string ServerLangFromLocalLang(string localLang = "")
		{
			return null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x5C054C0", Offset = "0x5C040C0", VA = "0x185C054C0")]
		private static string LangFromCurrentArea(string currentArea = "")
		{
			return null;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x5C01090", Offset = "0x5BFFC90", VA = "0x185C01090")]
		public static void AgreementMultiLanguage(bool support)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x5C02D80", Offset = "0x5C01980", VA = "0x185C02D80")]
		public static string GeeTestLanguage()
		{
			return null;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x5C061B0", Offset = "0x5C04DB0", VA = "0x185C061B0")]
		public static string ScrollBarStyleCSS()
		{
			return null;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x5C07390", Offset = "0x5C05F90", VA = "0x185C07390")]
		public static string TrimString(string str)
		{
			return null;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x5C03270", Offset = "0x5C01E70", VA = "0x185C03270")]
		public static string GetCurrencyCodeLocal()
		{
			return null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x5C03120", Offset = "0x5C01D20", VA = "0x185C03120")]
		public static string GetCurrencyCodeLocalSymbol(string code)
		{
			return null;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x5C02820", Offset = "0x5C01420", VA = "0x185C02820")]
		public static string FormatPrice(string price)
		{
			return null;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x5C04E80", Offset = "0x5C03A80", VA = "0x185C04E80")]
		public static bool IsGuest()
		{
			return default(bool);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x5C04F40", Offset = "0x5C03B40", VA = "0x185C04F40")]
		public static bool IsPop(int code, bool pop = false)
		{
			return default(bool);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x5C06AC0", Offset = "0x5C056C0", VA = "0x185C06AC0")]
		public static void StoreLoginHistory(Dictionary<string, object> info, string uid)
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x5C02010", Offset = "0x5C00C10", VA = "0x185C02010")]
		public static void DeleteLoginHistoryByUID(string uid, bool deleteToken = false)
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x5C02560", Offset = "0x5C01160", VA = "0x185C02560")]
		public static void DeleteUID(string deletedUID = "", bool deleteHistory = false)
		{
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x5C06E90", Offset = "0x5C05A90", VA = "0x185C06E90")]
		public static void StoreUserBirth(string birth, string uid)
		{
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x5C05E90", Offset = "0x5C04A90", VA = "0x185C05E90")]
		public static string ReadTokenFrom2_X()
		{
			return null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x5C05EE0", Offset = "0x5C04AE0", VA = "0x185C05EE0")]
		public static string ReadUIDFrom2_X()
		{
			return null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x5C05E50", Offset = "0x5C04A50", VA = "0x185C05E50")]
		public static int ReadLoginPlatformFrom2_X()
		{
			return 0;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x5C015D0", Offset = "0x5C001D0", VA = "0x185C015D0")]
		public static void Clear2_X()
		{
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x5C027F0", Offset = "0x5C013F0", VA = "0x185C027F0")]
		public static string EscapeURL(string content)
		{
			return null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x5C073B0", Offset = "0x5C05FB0", VA = "0x185C073B0")]
		public static string UnEscapeURL(string content)
		{
			return null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002624 File Offset: 0x00000824
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x5C03770", Offset = "0x5C02370", VA = "0x185C03770")]
		public static bool GetLogStatus()
		{
			return default(bool);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x5C06590", Offset = "0x5C05190", VA = "0x185C06590")]
		public static void SetLogStatus(bool isShowLog)
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x5C05D60", Offset = "0x5C04960", VA = "0x185C05D60")]
		public static void PreInit()
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x5C01620", Offset = "0x5C00220", VA = "0x185C01620")]
		public static string ConvertUrl(string url)
		{
			return null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x5C076B0", Offset = "0x5C062B0", VA = "0x185C076B0")]
		private static string UpdateUrlQuery(string url)
		{
			return null;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x5C03BB0", Offset = "0x5C027B0", VA = "0x185C03BB0")]
		public static Dictionary<string, object> GetRequestHeader(string authInfo)
		{
			return null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x5C073E0", Offset = "0x5C05FE0", VA = "0x185C073E0")]
		public static void UpdateServiceType()
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x5C03D10", Offset = "0x5C02910", VA = "0x185C03D10")]
		public static ServiceType GetServiceType()
		{
			return ServiceType.None;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x5C05B20", Offset = "0x5C04720", VA = "0x185C05B20")]
		private static Dictionary<string, string> ParseQueryString(string queryString)
		{
			return null;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x5C011F0", Offset = "0x5BFFDF0", VA = "0x185C011F0")]
		private static string BuildQueryString(Dictionary<string, string> queryParams)
		{
			return null;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x5C01450", Offset = "0x5C00050", VA = "0x185C01450")]
		public static bool CheckCanarySupport()
		{
			return default(bool);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AppUtils()
		{
		}

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string ServiceTypeKey;
	}
}
