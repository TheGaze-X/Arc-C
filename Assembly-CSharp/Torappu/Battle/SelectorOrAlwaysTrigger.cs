using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002570 RID: 9584
	[Token(Token = "0x2002570")]
	public class SelectorOrAlwaysTrigger : SelectorTrigger
	{
		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x0600F74F RID: 63311 RVA: 0x0005C5F8 File Offset: 0x0005A7F8
		[Token(Token = "0x17002072")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F74F")]
			[Address(RVA = "0x7139D0", Offset = "0x7125D0", VA = "0x1807139D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F750 RID: 63312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F750")]
		[Address(RVA = "0x7137E0", Offset = "0x7123E0", VA = "0x1807137E0", Slot = "12")]
		public override void Reset(Entity owner, Ability ability)
		{
		}

		// Token: 0x0600F751 RID: 63313 RVA: 0x0005C610 File Offset: 0x0005A810
		[Token(Token = "0x600F751")]
		[Address(RVA = "0x7138B0", Offset = "0x7124B0", VA = "0x1807138B0", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F752 RID: 63314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F752")]
		[Address(RVA = "0x713970", Offset = "0x712570", VA = "0x180713970")]
		public SelectorOrAlwaysTrigger()
		{
		}

		// Token: 0x0600F753 RID: 63315 RVA: 0x0005C628 File Offset: 0x0005A828
		[Token(Token = "0x600F753")]
		[Address(RVA = "0x6EF7F0", Offset = "0x6EE3F0", VA = "0x1806EF7F0")]
		private bool <>xLuaBaseProxy_get_isReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x0600F754 RID: 63316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F754")]
		[Address(RVA = "0x6F1EB0", Offset = "0x6F0AB0", VA = "0x1806F1EB0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1)
		{
		}

		// Token: 0x0600F755 RID: 63317 RVA: 0x0005C640 File Offset: 0x0005A840
		[Token(Token = "0x600F755")]
		[Address(RVA = "0x6F1EC0", Offset = "0x6F0AC0", VA = "0x1806F1EC0")]
		private bool <>xLuaBaseProxy_Search(bool P0)
		{
			return default(bool);
		}

		// Token: 0x040112BF RID: 70335
		[Token(Token = "0x40112BF")]
		[FieldOffset(Offset = "0x50")]
		private IAlwaysTrigger m_ability;

		// Token: 0x040112C0 RID: 70336
		[Token(Token = "0x40112C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isReadyToTrig;

		// Token: 0x040112C1 RID: 70337
		[Token(Token = "0x40112C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040112C2 RID: 70338
		[Token(Token = "0x40112C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x040112C3 RID: 70339
		[Token(Token = "0x40112C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
