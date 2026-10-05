using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Config
{
	// Token: 0x02000246 RID: 582
	[Token(Token = "0x2000246")]
	public class ABTestInterface : Singleton<ABTestInterface>
	{
		// Token: 0x06000D3C RID: 3388 RVA: 0x00008744 File Offset: 0x00006944
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x557C740", Offset = "0x557B340", VA = "0x18557C740")]
		public static bool CheckEnabledByDeviceID(string key, int rate)
		{
			return default(bool);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0000875C File Offset: 0x0000695C
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x557C7E0", Offset = "0x557B3E0", VA = "0x18557C7E0")]
		private bool _CheckEnabledByDeviceIDImpl(string key, int rate)
		{
			return default(bool);
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x557C9B0", Offset = "0x557B5B0", VA = "0x18557C9B0")]
		private ABTestInterface()
		{
		}

		// Token: 0x04000D63 RID: 3427
		[Token(Token = "0x4000D63")]
		private const int FULL_RATE = 10000;

		// Token: 0x04000D64 RID: 3428
		[Token(Token = "0x4000D64")]
		private const int PRIME_SALT = 40009;

		// Token: 0x04000D65 RID: 3429
		[Token(Token = "0x4000D65")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, ABTestInterface.Cache> m_caches;

		// Token: 0x04000D66 RID: 3430
		[Token(Token = "0x4000D66")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate247 __Hotfix0_CheckEnabledByDeviceID;

		// Token: 0x04000D67 RID: 3431
		[Token(Token = "0x4000D67")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate274 __Hotfix0__CheckEnabledByDeviceIDImpl;

		// Token: 0x04000D68 RID: 3432
		[Token(Token = "0x4000D68")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000247 RID: 583
		[Token(Token = "0x2000247")]
		private class Cache
		{
			// Token: 0x06000D3F RID: 3391 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000D3F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Cache()
			{
			}

			// Token: 0x04000D69 RID: 3433
			[Token(Token = "0x4000D69")]
			[FieldOffset(Offset = "0x10")]
			public int rate;

			// Token: 0x04000D6A RID: 3434
			[Token(Token = "0x4000D6A")]
			[FieldOffset(Offset = "0x14")]
			public bool enabled;
		}
	}
}
