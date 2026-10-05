using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Torappu.SDK.AntiData;
using XLua;

namespace Torappu.SDK
{
	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	public class ServiceMetaSDK : IHotfixable
	{
		// Token: 0x06000A00 RID: 2560 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x555C910", Offset = "0x555B510", VA = "0x18555C910")]
		public static void InitOrReset(List<string> antiDataServices)
		{
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x555C560", Offset = "0x555B160", VA = "0x18555C560")]
		public static JObject AchieveServiceMetaAsJObject(string serviceCode)
		{
			return null;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x555CDE0", Offset = "0x555B9E0", VA = "0x18555CDE0")]
		public static void MarkServiceSucceed(string serviceCode)
		{
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x555CEB0", Offset = "0x555BAB0", VA = "0x18555CEB0")]
		private static string _EncodeBytes(byte[] data)
		{
			return null;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x555D0B0", Offset = "0x555BCB0", VA = "0x18555D0B0")]
		public ServiceMetaSDK()
		{
		}

		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x40009B0")]
		private const string KEY_ANTI_DATA = "anti_data";

		// Token: 0x040009B1 RID: 2481
		[Token(Token = "0x40009B1")]
		private const string KEY_DATA1 = "data1";

		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x40009B2")]
		private const string KEY_DATA2 = "data2";

		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x40009B3")]
		private const string KEY_DATA4 = "data4";

		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0x0")]
		private static ServiceAntiDataSDK s_antiDataSDK;

		// Token: 0x040009B5 RID: 2485
		[Token(Token = "0x40009B5")]
		[FieldOffset(Offset = "0x8")]
		private static readonly HashSet<string> s_antiDataServices;

		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x40009B6")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 __Hotfix0_InitOrReset;

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate223 __Hotfix0_AchieveServiceMetaAsJObject;

		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 __Hotfix0_MarkServiceSucceed;

		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate19 __Hotfix0__EncodeBytes;

		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
