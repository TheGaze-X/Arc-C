using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	[NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
	public class PlayerPrefs
	{
		// Token: 0x060008A5 RID: 2213
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x5950310", Offset = "0x594EF10", VA = "0x185950310")]
		[NativeMethod("SetInt")]
		[MethodImpl(4096)]
		private static extern bool TrySetInt(string key, int value);

		// Token: 0x060008A6 RID: 2214
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x59502C0", Offset = "0x594EEC0", VA = "0x1859502C0")]
		[NativeMethod("SetFloat")]
		[MethodImpl(4096)]
		private static extern bool TrySetFloat(string key, float value);

		// Token: 0x060008A7 RID: 2215
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x5950350", Offset = "0x594EF50", VA = "0x185950350")]
		[NativeMethod("SetString")]
		[MethodImpl(4096)]
		private static extern bool TrySetSetString(string key, string value);

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x5950180", Offset = "0x594ED80", VA = "0x185950180")]
		public static void SetInt(string key, int value)
		{
		}

		// Token: 0x060008A9 RID: 2217
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x594FF70", Offset = "0x594EB70", VA = "0x18594FF70")]
		[MethodImpl(4096)]
		public static extern int GetInt(string key, int defaultValue);

		// Token: 0x060008AA RID: 2218 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x594FF30", Offset = "0x594EB30", VA = "0x18594FF30")]
		public static int GetInt(string key)
		{
			return 0;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x59500E0", Offset = "0x594ECE0", VA = "0x1859500E0")]
		public static void SetFloat(string key, float value)
		{
		}

		// Token: 0x060008AC RID: 2220
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x594FEE0", Offset = "0x594EAE0", VA = "0x18594FEE0")]
		[MethodImpl(4096)]
		public static extern float GetFloat(string key, float defaultValue);

		// Token: 0x060008AD RID: 2221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x5950220", Offset = "0x594EE20", VA = "0x185950220")]
		public static void SetString(string key, string value)
		{
		}

		// Token: 0x060008AE RID: 2222
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x5950020", Offset = "0x594EC20", VA = "0x185950020")]
		[MethodImpl(4096)]
		public static extern string GetString(string key, string defaultValue);

		// Token: 0x060008AF RID: 2223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x594FFB0", Offset = "0x594EBB0", VA = "0x18594FFB0")]
		public static string GetString(string key)
		{
			return null;
		}

		// Token: 0x060008B0 RID: 2224
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x5950070", Offset = "0x594EC70", VA = "0x185950070")]
		[MethodImpl(4096)]
		public static extern bool HasKey(string key);

		// Token: 0x060008B1 RID: 2225
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x594FEA0", Offset = "0x594EAA0", VA = "0x18594FEA0")]
		[MethodImpl(4096)]
		public static extern void DeleteKey(string key);

		// Token: 0x060008B2 RID: 2226
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x594FE70", Offset = "0x594EA70", VA = "0x18594FE70")]
		[NativeMethod("DeleteAllWithCallback")]
		[MethodImpl(4096)]
		public static extern void DeleteAll();

		// Token: 0x060008B3 RID: 2227
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x59500B0", Offset = "0x594ECB0", VA = "0x1859500B0")]
		[NativeMethod("Sync")]
		[MethodImpl(4096)]
		public static extern void Save();
	}
}
