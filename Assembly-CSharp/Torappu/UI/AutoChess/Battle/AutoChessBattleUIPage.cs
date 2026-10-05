using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006481 RID: 25729
	[Token(Token = "0x2006481")]
	public class AutoChessBattleUIPage : StateEnginePage, IHotfixable
	{
		// Token: 0x17005738 RID: 22328
		// (get) Token: 0x06024FEC RID: 151532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005738")]
		public string actId
		{
			[Token(Token = "0x6024FEC")]
			[Address(RVA = "0x1FD20E0", Offset = "0x1FD0CE0", VA = "0x181FD20E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024FED RID: 151533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FED")]
		[Address(RVA = "0x1FD1FE0", Offset = "0x1FD0BE0", VA = "0x181FD1FE0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06024FEE RID: 151534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FEE")]
		[Address(RVA = "0x1FD2080", Offset = "0x1FD0C80", VA = "0x181FD2080")]
		public AutoChessBattleUIPage()
		{
		}

		// Token: 0x06024FEF RID: 151535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FEF")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x04033C68 RID: 212072
		[Token(Token = "0x4033C68")]
		[FieldOffset(Offset = "0xF0")]
		private AutoChessBattleUIPage.Params m_params;

		// Token: 0x04033C69 RID: 212073
		[Token(Token = "0x4033C69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04033C6A RID: 212074
		[Token(Token = "0x4033C6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04033C6B RID: 212075
		[Token(Token = "0x4033C6B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006482 RID: 25730
		[Token(Token = "0x2006482")]
		public class Params
		{
			// Token: 0x06024FF0 RID: 151536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FF0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04033C6C RID: 212076
			[Token(Token = "0x4033C6C")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
