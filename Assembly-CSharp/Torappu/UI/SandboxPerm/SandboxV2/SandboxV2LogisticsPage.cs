using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004334 RID: 17204
	[Token(Token = "0x2004334")]
	public class SandboxV2LogisticsPage : StateEnginePage
	{
		// Token: 0x0601A6DB RID: 108251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6DB")]
		[Address(RVA = "0x138BDF0", Offset = "0x138A9F0", VA = "0x18138BDF0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601A6DC RID: 108252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6DC")]
		[Address(RVA = "0x138BE70", Offset = "0x138AA70", VA = "0x18138BE70")]
		public SandboxV2LogisticsPage()
		{
		}

		// Token: 0x0601A6DD RID: 108253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6DD")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0402195C RID: 137564
		[Token(Token = "0x402195C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402195D RID: 137565
		[Token(Token = "0x402195D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004335 RID: 17205
		[Token(Token = "0x2004335")]
		public class Param
		{
			// Token: 0x0601A6DE RID: 108254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A6DE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0402195E RID: 137566
			[Token(Token = "0x402195E")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402195F RID: 137567
			[Token(Token = "0x402195F")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2LogisticsVisitMode visitMode;
		}
	}
}
