using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000574 RID: 1396
	[Token(Token = "0x2000574")]
	public static class ObscuredPrefs
	{
		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002EA4 RID: 11940 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EA3 RID: 11939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E5")]
		public static string CryptoKey
		{
			[Token(Token = "0x6002EA4")]
			[Address(RVA = "0x540A360", Offset = "0x5408F60", VA = "0x18540A360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EA3")]
			[Address(RVA = "0x540A660", Offset = "0x5409260", VA = "0x18540A660")]
			set
			{
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EA6 RID: 11942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E6")]
		public static string DeviceId
		{
			[Token(Token = "0x6002EA5")]
			[Address(RVA = "0x540A590", Offset = "0x5409190", VA = "0x18540A590")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EA6")]
			[Address(RVA = "0x540A770", Offset = "0x5409370", VA = "0x18540A770")]
			set
			{
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EA8 RID: 11944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E7")]
		[Obsolete("This property is obsolete, please use DeviceId instead.")]
		internal static string DeviceID
		{
			[Token(Token = "0x6002EA7")]
			[Address(RVA = "0x540A490", Offset = "0x5409090", VA = "0x18540A490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EA8")]
			[Address(RVA = "0x540A6D0", Offset = "0x54092D0", VA = "0x18540A6D0")]
			set
			{
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x00013BF0 File Offset: 0x00011DF0
		[Token(Token = "0x170006E8")]
		private static uint DeviceIdHash
		{
			[Token(Token = "0x6002EA9")]
			[Address(RVA = "0x540A4D0", Offset = "0x54090D0", VA = "0x18540A4D0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAA")]
		[Address(RVA = "0x54069D0", Offset = "0x54055D0", VA = "0x1854069D0")]
		public static void ForceLockToDeviceInit()
		{
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAB")]
		[Address(RVA = "0x5409810", Offset = "0x5408410", VA = "0x185409810")]
		[Obsolete("This method is obsolete, use property CryptoKey instead")]
		internal static void SetNewCryptoKey(string newKey)
		{
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EAC")]
		[Address(RVA = "0x5409650", Offset = "0x5408250", VA = "0x185409650")]
		public static void SetInt(string key, int value)
		{
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x00013C08 File Offset: 0x00011E08
		[Token(Token = "0x6002EAD")]
		[Address(RVA = "0x5407B70", Offset = "0x5406770", VA = "0x185407B70")]
		public static int GetInt(string key)
		{
			return 0;
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00013C20 File Offset: 0x00011E20
		[Token(Token = "0x6002EAE")]
		[Address(RVA = "0x54078F0", Offset = "0x54064F0", VA = "0x1854078F0")]
		public static int GetInt(string key, int defaultValue)
		{
			return 0;
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAF")]
		[Address(RVA = "0x54060C0", Offset = "0x5404CC0", VA = "0x1854060C0")]
		public static string EncryptIntValue(string key, int value)
		{
			return null;
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x00013C38 File Offset: 0x00011E38
		[Token(Token = "0x6002EB0")]
		[Address(RVA = "0x5403A90", Offset = "0x5402690", VA = "0x185403A90")]
		public static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
		{
			return 0;
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB1")]
		[Address(RVA = "0x5409DC0", Offset = "0x54089C0", VA = "0x185409DC0")]
		public static void SetUInt(string key, uint value)
		{
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x00013C50 File Offset: 0x00011E50
		[Token(Token = "0x6002EB2")]
		[Address(RVA = "0x54085C0", Offset = "0x54071C0", VA = "0x1854085C0")]
		public static uint GetUInt(string key)
		{
			return 0U;
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x00013C68 File Offset: 0x00011E68
		[Token(Token = "0x6002EB3")]
		[Address(RVA = "0x54086B0", Offset = "0x54072B0", VA = "0x1854086B0")]
		public static uint GetUInt(string key, uint defaultValue)
		{
			return 0U;
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB4")]
		[Address(RVA = "0x5406670", Offset = "0x5405270", VA = "0x185406670")]
		public static string EncryptUIntValue(string key, uint value)
		{
			return null;
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x00013C80 File Offset: 0x00011E80
		[Token(Token = "0x6002EB5")]
		[Address(RVA = "0x54046E0", Offset = "0x54032E0", VA = "0x1854046E0")]
		public static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			return 0U;
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB6")]
		[Address(RVA = "0x5409CC0", Offset = "0x54088C0", VA = "0x185409CC0")]
		public static void SetString(string key, string value)
		{
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB7")]
		[Address(RVA = "0x5408560", Offset = "0x5407160", VA = "0x185408560")]
		public static string GetString(string key)
		{
			return null;
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB8")]
		[Address(RVA = "0x54082F0", Offset = "0x5406EF0", VA = "0x1854082F0")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB9")]
		[Address(RVA = "0x54065C0", Offset = "0x54051C0", VA = "0x1854065C0")]
		public static string EncryptStringValue(string key, string value)
		{
			return null;
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBA")]
		[Address(RVA = "0x5404590", Offset = "0x5403190", VA = "0x185404590")]
		public static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			return null;
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EBB")]
		[Address(RVA = "0x5409560", Offset = "0x5408160", VA = "0x185409560")]
		public static void SetFloat(string key, float value)
		{
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x00013C98 File Offset: 0x00011E98
		[Token(Token = "0x6002EBC")]
		[Address(RVA = "0x5407610", Offset = "0x5406210", VA = "0x185407610")]
		public static float GetFloat(string key)
		{
			return 0f;
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x00013CB0 File Offset: 0x00011EB0
		[Token(Token = "0x6002EBD")]
		[Address(RVA = "0x5407660", Offset = "0x5406260", VA = "0x185407660")]
		public static float GetFloat(string key, float defaultValue)
		{
			return 0f;
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBE")]
		[Address(RVA = "0x5406020", Offset = "0x5404C20", VA = "0x185406020")]
		public static string EncryptFloatValue(string key, float value)
		{
			return null;
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x00013CC8 File Offset: 0x00011EC8
		[Token(Token = "0x6002EBF")]
		[Address(RVA = "0x5403920", Offset = "0x5402520", VA = "0x185403920")]
		public static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
		{
			return 0f;
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC0")]
		[Address(RVA = "0x5409470", Offset = "0x5408070", VA = "0x185409470")]
		public static void SetDouble(string key, double value)
		{
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x00013CE0 File Offset: 0x00011EE0
		[Token(Token = "0x6002EC1")]
		[Address(RVA = "0x5407370", Offset = "0x5405F70", VA = "0x185407370")]
		public static double GetDouble(string key)
		{
			return 0.0;
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x00013CF8 File Offset: 0x00011EF8
		[Token(Token = "0x6002EC2")]
		[Address(RVA = "0x5407460", Offset = "0x5406060", VA = "0x185407460")]
		public static double GetDouble(string key, double defaultValue)
		{
			return 0.0;
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC3")]
		[Address(RVA = "0x5405F80", Offset = "0x5404B80", VA = "0x185405F80")]
		private static string EncryptDoubleValue(string key, double value)
		{
			return null;
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00013D10 File Offset: 0x00011F10
		[Token(Token = "0x6002EC4")]
		[Address(RVA = "0x54036F0", Offset = "0x54022F0", VA = "0x1854036F0")]
		private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			return 0.0;
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC5")]
		[Address(RVA = "0x5409280", Offset = "0x5407E80", VA = "0x185409280")]
		public static void SetDecimal(string key, decimal value)
		{
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00013D28 File Offset: 0x00011F28
		[Token(Token = "0x6002EC6")]
		[Address(RVA = "0x54070C0", Offset = "0x5405CC0", VA = "0x1854070C0")]
		public static decimal GetDecimal(string key)
		{
			return 0m;
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x00013D40 File Offset: 0x00011F40
		[Token(Token = "0x6002EC7")]
		[Address(RVA = "0x5407210", Offset = "0x5405E10", VA = "0x185407210")]
		public static decimal GetDecimal(string key, decimal defaultValue)
		{
			return 0m;
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC8")]
		[Address(RVA = "0x5405D00", Offset = "0x5404900", VA = "0x185405D00")]
		private static string EncryptDecimalValue(string key, decimal value)
		{
			return null;
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x00013D58 File Offset: 0x00011F58
		[Token(Token = "0x6002EC9")]
		[Address(RVA = "0x5403450", Offset = "0x5402050", VA = "0x185403450")]
		private static decimal DecryptDecimalValue(string key, string encryptedInput, decimal defaultValue)
		{
			return 0m;
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ECA")]
		[Address(RVA = "0x5409730", Offset = "0x5408330", VA = "0x185409730")]
		public static void SetLong(string key, long value)
		{
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x00013D70 File Offset: 0x00011F70
		[Token(Token = "0x6002ECB")]
		[Address(RVA = "0x5407BC0", Offset = "0x54067C0", VA = "0x185407BC0")]
		public static long GetLong(string key)
		{
			return 0L;
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x00013D88 File Offset: 0x00011F88
		[Token(Token = "0x6002ECC")]
		[Address(RVA = "0x5407CB0", Offset = "0x54068B0", VA = "0x185407CB0")]
		public static long GetLong(string key, long defaultValue)
		{
			return 0L;
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECD")]
		[Address(RVA = "0x5406250", Offset = "0x5404E50", VA = "0x185406250")]
		private static string EncryptLongValue(string key, long value)
		{
			return null;
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x00013DA0 File Offset: 0x00011FA0
		[Token(Token = "0x6002ECE")]
		[Address(RVA = "0x5403C00", Offset = "0x5402800", VA = "0x185403C00")]
		private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			return 0L;
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ECF")]
		[Address(RVA = "0x5409EA0", Offset = "0x5408AA0", VA = "0x185409EA0")]
		public static void SetULong(string key, ulong value)
		{
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x00013DB8 File Offset: 0x00011FB8
		[Token(Token = "0x6002ED0")]
		[Address(RVA = "0x5408850", Offset = "0x5407450", VA = "0x185408850")]
		public static ulong GetULong(string key)
		{
			return 0UL;
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00013DD0 File Offset: 0x00011FD0
		[Token(Token = "0x6002ED1")]
		[Address(RVA = "0x5408780", Offset = "0x5407380", VA = "0x185408780")]
		public static ulong GetULong(string key, ulong defaultValue)
		{
			return 0UL;
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED2")]
		[Address(RVA = "0x5406700", Offset = "0x5405300", VA = "0x185406700")]
		private static string EncryptULongValue(string key, ulong value)
		{
			return null;
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x00013DE8 File Offset: 0x00011FE8
		[Token(Token = "0x6002ED3")]
		[Address(RVA = "0x5404900", Offset = "0x5403500", VA = "0x185404900")]
		private static ulong DecryptULongValue(string key, string encryptedInput, ulong defaultValue)
		{
			return 0UL;
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED4")]
		[Address(RVA = "0x5408FC0", Offset = "0x5407BC0", VA = "0x185408FC0")]
		public static void SetBool(string key, bool value)
		{
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00013E00 File Offset: 0x00012000
		[Token(Token = "0x6002ED5")]
		[Address(RVA = "0x5406AE0", Offset = "0x54056E0", VA = "0x185406AE0")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x00013E18 File Offset: 0x00012018
		[Token(Token = "0x6002ED6")]
		[Address(RVA = "0x5406BD0", Offset = "0x54057D0", VA = "0x185406BD0")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED7")]
		[Address(RVA = "0x5405810", Offset = "0x5404410", VA = "0x185405810")]
		private static string EncryptBoolValue(string key, bool value)
		{
			return null;
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00013E30 File Offset: 0x00012030
		[Token(Token = "0x6002ED8")]
		[Address(RVA = "0x5402B90", Offset = "0x5401790", VA = "0x185402B90")]
		private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			return default(bool);
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED9")]
		[Address(RVA = "0x54090B0", Offset = "0x5407CB0", VA = "0x1854090B0")]
		public static void SetByteArray(string key, byte[] value)
		{
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDA")]
		[Address(RVA = "0x5406D90", Offset = "0x5405990", VA = "0x185406D90")]
		public static byte[] GetByteArray(string key)
		{
			return null;
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDB")]
		[Address(RVA = "0x5406CA0", Offset = "0x54058A0", VA = "0x185406CA0")]
		public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			return null;
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDC")]
		[Address(RVA = "0x54058A0", Offset = "0x54044A0", VA = "0x1854058A0")]
		private static string EncryptByteArrayValue(string key, byte[] value)
		{
			return null;
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDD")]
		[Address(RVA = "0x5402DC0", Offset = "0x54019C0", VA = "0x185402DC0")]
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			return null;
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDE")]
		[Address(RVA = "0x5402B20", Offset = "0x5401720", VA = "0x185402B20")]
		private static byte[] ConstructByteArray(byte value, int length)
		{
			return null;
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDF")]
		[Address(RVA = "0x5409F80", Offset = "0x5408B80", VA = "0x185409F80")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x00013E48 File Offset: 0x00012048
		[Token(Token = "0x6002EE0")]
		[Address(RVA = "0x5408A20", Offset = "0x5407620", VA = "0x185408A20")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x00013E60 File Offset: 0x00012060
		[Token(Token = "0x6002EE1")]
		[Address(RVA = "0x5408940", Offset = "0x5407540", VA = "0x185408940")]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EE2")]
		[Address(RVA = "0x5406790", Offset = "0x5405390", VA = "0x185406790")]
		private static string EncryptVector2Value(string key, Vector2 value)
		{
			return null;
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x00013E78 File Offset: 0x00012078
		[Token(Token = "0x6002EE3")]
		[Address(RVA = "0x5404B20", Offset = "0x5403720", VA = "0x185404B20")]
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EE4")]
		[Address(RVA = "0x540A0E0", Offset = "0x5408CE0", VA = "0x18540A0E0")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x00013E90 File Offset: 0x00012090
		[Token(Token = "0x6002EE5")]
		[Address(RVA = "0x5408C50", Offset = "0x5407850", VA = "0x185408C50")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x00013EA8 File Offset: 0x000120A8
		[Token(Token = "0x6002EE6")]
		[Address(RVA = "0x5408B50", Offset = "0x5407750", VA = "0x185408B50")]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EE7")]
		[Address(RVA = "0x5406890", Offset = "0x5405490", VA = "0x185406890")]
		private static string EncryptVector3Value(string key, Vector3 value)
		{
			return null;
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x00013EC0 File Offset: 0x000120C0
		[Token(Token = "0x6002EE8")]
		[Address(RVA = "0x5404E90", Offset = "0x5403A90", VA = "0x185404E90")]
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EE9")]
		[Address(RVA = "0x54098B0", Offset = "0x54084B0", VA = "0x1854098B0")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x00013ED8 File Offset: 0x000120D8
		[Token(Token = "0x6002EEA")]
		[Address(RVA = "0x5407E70", Offset = "0x5406A70", VA = "0x185407E70")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00013EF0 File Offset: 0x000120F0
		[Token(Token = "0x6002EEB")]
		[Address(RVA = "0x5407D80", Offset = "0x5406980", VA = "0x185407D80")]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EEC")]
		[Address(RVA = "0x54062E0", Offset = "0x5404EE0", VA = "0x1854062E0")]
		private static string EncryptQuaternionValue(string key, Quaternion value)
		{
			return null;
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x00013F08 File Offset: 0x00012108
		[Token(Token = "0x6002EED")]
		[Address(RVA = "0x5403E20", Offset = "0x5402A20", VA = "0x185403E20")]
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EEE")]
		[Address(RVA = "0x5409170", Offset = "0x5407D70", VA = "0x185409170")]
		public static void SetColor(string key, Color32 value)
		{
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x00013F20 File Offset: 0x00012120
		[Token(Token = "0x6002EEF")]
		[Address(RVA = "0x5406EC0", Offset = "0x5405AC0", VA = "0x185406EC0")]
		public static Color32 GetColor(string key)
		{
			return default(Color32);
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x00013F38 File Offset: 0x00012138
		[Token(Token = "0x6002EF0")]
		[Address(RVA = "0x5406FD0", Offset = "0x5405BD0", VA = "0x185406FD0")]
		public static Color32 GetColor(string key, Color32 defaultValue)
		{
			return default(Color32);
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF1")]
		[Address(RVA = "0x5405900", Offset = "0x5404500", VA = "0x185405900")]
		private static string EncryptColorValue(string key, uint value)
		{
			return null;
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EF2")]
		[Address(RVA = "0x5409AE0", Offset = "0x54086E0", VA = "0x185409AE0")]
		public static void SetRect(string key, Rect value)
		{
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x00013F50 File Offset: 0x00012150
		[Token(Token = "0x6002EF3")]
		[Address(RVA = "0x54080B0", Offset = "0x5406CB0", VA = "0x1854080B0")]
		public static Rect GetRect(string key)
		{
			return default(Rect);
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x00013F68 File Offset: 0x00012168
		[Token(Token = "0x6002EF4")]
		[Address(RVA = "0x5408200", Offset = "0x5406E00", VA = "0x185408200")]
		public static Rect GetRect(string key, Rect defaultValue)
		{
			return default(Rect);
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF5")]
		[Address(RVA = "0x5406440", Offset = "0x5405040", VA = "0x185406440")]
		private static string EncryptRectValue(string key, Rect value)
		{
			return null;
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x00013F80 File Offset: 0x00012180
		[Token(Token = "0x6002EF6")]
		[Address(RVA = "0x54042A0", Offset = "0x5402EA0", VA = "0x1854042A0")]
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			return default(Rect);
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EF7")]
		[Address(RVA = "0x5409A70", Offset = "0x5408670", VA = "0x185409A70")]
		public static void SetRawValue(string key, string encryptedValue)
		{
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF8")]
		[Address(RVA = "0x5408050", Offset = "0x5406C50", VA = "0x185408050")]
		public static string GetRawValue(string key)
		{
			return null;
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x00013F98 File Offset: 0x00012198
		[Token(Token = "0x6002EF9")]
		[Address(RVA = "0x5407FB0", Offset = "0x5406BB0", VA = "0x185407FB0")]
		public static ObscuredPrefs.DataType GetRawValueType(string value)
		{
			return ObscuredPrefs.DataType.Unknown;
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFA")]
		[Address(RVA = "0x5406150", Offset = "0x5404D50", VA = "0x185406150")]
		public static string EncryptKey(string key)
		{
			return null;
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x00013FB0 File Offset: 0x000121B0
		[Token(Token = "0x6002EFB")]
		[Address(RVA = "0x5408DC0", Offset = "0x54079C0", VA = "0x185408DC0")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EFC")]
		[Address(RVA = "0x54052A0", Offset = "0x5403EA0", VA = "0x1854052A0")]
		public static void DeleteKey(string key)
		{
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EFD")]
		[Address(RVA = "0x5405290", Offset = "0x5403E90", VA = "0x185405290")]
		public static void DeleteAll()
		{
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EFE")]
		[Address(RVA = "0x5408EF0", Offset = "0x5407AF0", VA = "0x185408EF0")]
		public static void Save()
		{
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFF")]
		[Address(RVA = "0x5407530", Offset = "0x5406130", VA = "0x185407530")]
		private static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			return null;
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F00")]
		[Address(RVA = "0x5405990", Offset = "0x5404590", VA = "0x185405990")]
		private static string EncryptData(string key, byte[] cleanBytes, ObscuredPrefs.DataType type)
		{
			return null;
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F01")]
		[Address(RVA = "0x5402FC0", Offset = "0x5401BC0", VA = "0x185402FC0")]
		internal static byte[] DecryptData(string key, string encryptedInput)
		{
			return null;
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x00013FC8 File Offset: 0x000121C8
		[Token(Token = "0x6002F02")]
		[Address(RVA = "0x5402A60", Offset = "0x5401660", VA = "0x185402A60")]
		private static uint CalculateChecksum(string input)
		{
			return 0U;
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F03")]
		[Address(RVA = "0x5408F00", Offset = "0x5407B00", VA = "0x185408F00")]
		private static void SavesTampered()
		{
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F04")]
		[Address(RVA = "0x5408E30", Offset = "0x5407A30", VA = "0x185408E30")]
		private static void PossibleForeignSavesDetected()
		{
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F05")]
		[Address(RVA = "0x5407300", Offset = "0x5405F00", VA = "0x185407300")]
		private static string GetDeviceId()
		{
			return null;
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F06")]
		[Address(RVA = "0x5405EA0", Offset = "0x5404AA0", VA = "0x185405EA0")]
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
		{
			return null;
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F07")]
		[Address(RVA = "0x5405480", Offset = "0x5404080", VA = "0x185405480")]
		private static string DeprecatedDecryptValue(string value)
		{
			return null;
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F08")]
		[Address(RVA = "0x5405320", Offset = "0x5403F20", VA = "0x185405320")]
		private static string DeprecatedCalculateChecksum(string input)
		{
			return null;
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E9")]
		private static string DeprecatedDeviceId
		{
			[Token(Token = "0x6002F09")]
			[Address(RVA = "0x540A3B0", Offset = "0x5408FB0", VA = "0x18540A3B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040019FB RID: 6651
		[Token(Token = "0x40019FB")]
		private const byte Version = 2;

		// Token: 0x040019FC RID: 6652
		[Token(Token = "0x40019FC")]
		private const string RawNotFound = "{not_found}";

		// Token: 0x040019FD RID: 6653
		[Token(Token = "0x40019FD")]
		private const string DataSeparator = "|";

		// Token: 0x040019FE RID: 6654
		[Token(Token = "0x40019FE")]
		[FieldOffset(Offset = "0x0")]
		private static bool foreignSavesReported;

		// Token: 0x040019FF RID: 6655
		[Token(Token = "0x40019FF")]
		[FieldOffset(Offset = "0x8")]
		private static string cryptoKey;

		// Token: 0x04001A00 RID: 6656
		[Token(Token = "0x4001A00")]
		[FieldOffset(Offset = "0x10")]
		private static string deviceId;

		// Token: 0x04001A01 RID: 6657
		[Token(Token = "0x4001A01")]
		[FieldOffset(Offset = "0x18")]
		private static uint deviceIdHash;

		// Token: 0x04001A02 RID: 6658
		[Token(Token = "0x4001A02")]
		[FieldOffset(Offset = "0x20")]
		public static Action onAlterationDetected;

		// Token: 0x04001A03 RID: 6659
		[Token(Token = "0x4001A03")]
		[FieldOffset(Offset = "0x28")]
		public static bool preservePlayerPrefs;

		// Token: 0x04001A04 RID: 6660
		[Token(Token = "0x4001A04")]
		[FieldOffset(Offset = "0x30")]
		public static Action onPossibleForeignSavesDetected;

		// Token: 0x04001A05 RID: 6661
		[Token(Token = "0x4001A05")]
		[FieldOffset(Offset = "0x38")]
		public static ObscuredPrefs.DeviceLockLevel lockToDevice;

		// Token: 0x04001A06 RID: 6662
		[Token(Token = "0x4001A06")]
		[FieldOffset(Offset = "0x39")]
		public static bool readForeignSaves;

		// Token: 0x04001A07 RID: 6663
		[Token(Token = "0x4001A07")]
		[FieldOffset(Offset = "0x3A")]
		public static bool emergencyMode;

		// Token: 0x04001A08 RID: 6664
		[Token(Token = "0x4001A08")]
		private const char DEPRECATED_RAW_SEPARATOR = ':';

		// Token: 0x04001A09 RID: 6665
		[Token(Token = "0x4001A09")]
		[FieldOffset(Offset = "0x40")]
		private static string deprecatedDeviceId;

		// Token: 0x02000575 RID: 1397
		[Token(Token = "0x2000575")]
		public enum DataType : byte
		{
			// Token: 0x04001A0B RID: 6667
			[Token(Token = "0x4001A0B")]
			Unknown,
			// Token: 0x04001A0C RID: 6668
			[Token(Token = "0x4001A0C")]
			Int = 5,
			// Token: 0x04001A0D RID: 6669
			[Token(Token = "0x4001A0D")]
			UInt = 10,
			// Token: 0x04001A0E RID: 6670
			[Token(Token = "0x4001A0E")]
			String = 15,
			// Token: 0x04001A0F RID: 6671
			[Token(Token = "0x4001A0F")]
			Float = 20,
			// Token: 0x04001A10 RID: 6672
			[Token(Token = "0x4001A10")]
			Double = 25,
			// Token: 0x04001A11 RID: 6673
			[Token(Token = "0x4001A11")]
			Decimal = 27,
			// Token: 0x04001A12 RID: 6674
			[Token(Token = "0x4001A12")]
			Long = 30,
			// Token: 0x04001A13 RID: 6675
			[Token(Token = "0x4001A13")]
			ULong = 32,
			// Token: 0x04001A14 RID: 6676
			[Token(Token = "0x4001A14")]
			Bool = 35,
			// Token: 0x04001A15 RID: 6677
			[Token(Token = "0x4001A15")]
			ByteArray = 40,
			// Token: 0x04001A16 RID: 6678
			[Token(Token = "0x4001A16")]
			Vector2 = 45,
			// Token: 0x04001A17 RID: 6679
			[Token(Token = "0x4001A17")]
			Vector3 = 50,
			// Token: 0x04001A18 RID: 6680
			[Token(Token = "0x4001A18")]
			Quaternion = 55,
			// Token: 0x04001A19 RID: 6681
			[Token(Token = "0x4001A19")]
			Color = 60,
			// Token: 0x04001A1A RID: 6682
			[Token(Token = "0x4001A1A")]
			Rect = 65
		}

		// Token: 0x02000576 RID: 1398
		[Token(Token = "0x2000576")]
		public enum DeviceLockLevel : byte
		{
			// Token: 0x04001A1C RID: 6684
			[Token(Token = "0x4001A1C")]
			None,
			// Token: 0x04001A1D RID: 6685
			[Token(Token = "0x4001A1D")]
			Soft,
			// Token: 0x04001A1E RID: 6686
			[Token(Token = "0x4001A1E")]
			Strict
		}
	}
}
