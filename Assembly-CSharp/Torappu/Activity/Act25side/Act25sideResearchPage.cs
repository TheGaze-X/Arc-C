using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine.Rendering.PostProcessing;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074C0 RID: 29888
	[Token(Token = "0x20074C0")]
	public class Act25sideResearchPage : StateEnginePage, IHotfixable
	{
		// Token: 0x0602A275 RID: 172661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A275")]
		[Address(RVA = "0x25CD970", Offset = "0x25CC570", VA = "0x1825CD970", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602A276 RID: 172662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A276")]
		[Address(RVA = "0x25CDCA0", Offset = "0x25CC8A0", VA = "0x1825CDCA0", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x0602A277 RID: 172663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A277")]
		[Address(RVA = "0x25CDF70", Offset = "0x25CCB70", VA = "0x1825CDF70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A278 RID: 172664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A278")]
		[Address(RVA = "0x25CDA40", Offset = "0x25CC640", VA = "0x1825CDA40")]
		public void OnHarvestRequest()
		{
		}

		// Token: 0x0602A279 RID: 172665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A279")]
		[Address(RVA = "0x25CDFE0", Offset = "0x25CCBE0", VA = "0x1825CDFE0")]
		public Act25sideResearchPage()
		{
		}

		// Token: 0x0602A27B RID: 172667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A27B")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0602A27C RID: 172668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A27C")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x0403C8DC RID: 248028
		[Token(Token = "0x403C8DC")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_isInited;

		// Token: 0x0403C8DD RID: 248029
		[Token(Token = "0x403C8DD")]
		[FieldOffset(Offset = "0xF8")]
		private Grain m_grain;

		// Token: 0x0403C8DE RID: 248030
		[Token(Token = "0x403C8DE")]
		[FieldOffset(Offset = "0x100")]
		private string m_activityId;

		// Token: 0x0403C8DF RID: 248031
		[Token(Token = "0x403C8DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403C8E0 RID: 248032
		[Token(Token = "0x403C8E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x0403C8E1 RID: 248033
		[Token(Token = "0x403C8E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C8E2 RID: 248034
		[Token(Token = "0x403C8E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnHarvestRequest;

		// Token: 0x0403C8E3 RID: 248035
		[Token(Token = "0x403C8E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074C1 RID: 29889
		[Token(Token = "0x20074C1")]
		public class Params : IHotfixable
		{
			// Token: 0x0602A27D RID: 172669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A27D")]
			[Address(RVA = "0x25D4ED0", Offset = "0x25D3AD0", VA = "0x1825D4ED0")]
			public Params()
			{
			}

			// Token: 0x0403C8E4 RID: 248036
			[Token(Token = "0x403C8E4")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403C8E5 RID: 248037
			[Token(Token = "0x403C8E5")]
			[FieldOffset(Offset = "0x18")]
			public Act25sideDailyRefreshResponse dailyRefreshResponse;

			// Token: 0x0403C8E6 RID: 248038
			[Token(Token = "0x403C8E6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
