using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006185 RID: 24965
	[Token(Token = "0x2006185")]
	public class BossRushRelicPage : StateEnginePage
	{
		// Token: 0x06024034 RID: 147508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024034")]
		[Address(RVA = "0x1EA5960", Offset = "0x1EA4560", VA = "0x181EA5960", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06024035 RID: 147509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024035")]
		[Address(RVA = "0x1EA5A10", Offset = "0x1EA4610", VA = "0x181EA5A10")]
		public BossRushRelicPage()
		{
		}

		// Token: 0x06024037 RID: 147511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024037")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x04032098 RID: 204952
		[Token(Token = "0x4032098")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04032099 RID: 204953
		[Token(Token = "0x4032099")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006186 RID: 24966
		[Token(Token = "0x2006186")]
		public class Params
		{
			// Token: 0x06024038 RID: 147512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024038")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0403209A RID: 204954
			[Token(Token = "0x403209A")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
