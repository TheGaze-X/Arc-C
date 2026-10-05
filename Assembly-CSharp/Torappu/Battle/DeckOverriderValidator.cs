using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200257C RID: 9596
	[Token(Token = "0x200257C")]
	public class DeckOverriderValidator : TargetValidator
	{
		// Token: 0x0600F7A1 RID: 63393 RVA: 0x0005C940 File Offset: 0x0005AB40
		[Token(Token = "0x600F7A1")]
		[Address(RVA = "0x709310", Offset = "0x707F10", VA = "0x180709310", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7A2 RID: 63394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7A2")]
		[Address(RVA = "0x7093C0", Offset = "0x707FC0", VA = "0x1807093C0")]
		public DeckOverriderValidator()
		{
		}

		// Token: 0x0600F7A3 RID: 63395 RVA: 0x0005C958 File Offset: 0x0005AB58
		[Token(Token = "0x600F7A3")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401132A RID: 70442
		[Token(Token = "0x401132A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x0401132B RID: 70443
		[Token(Token = "0x401132B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
