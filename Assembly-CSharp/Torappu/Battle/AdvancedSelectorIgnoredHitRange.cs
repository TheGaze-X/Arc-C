using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200252C RID: 9516
	[Token(Token = "0x200252C")]
	public class AdvancedSelectorIgnoredHitRange : AdvancedSelector
	{
		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x0600F59E RID: 62878 RVA: 0x0005B488 File Offset: 0x00059688
		[Token(Token = "0x17002024")]
		protected override bool ignoreHitRange
		{
			[Token(Token = "0x600F59E")]
			[Address(RVA = "0x6CE000", Offset = "0x6CCC00", VA = "0x1806CE000", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F59F RID: 62879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F59F")]
		[Address(RVA = "0x6CDFA0", Offset = "0x6CCBA0", VA = "0x1806CDFA0")]
		public AdvancedSelectorIgnoredHitRange()
		{
		}

		// Token: 0x0600F5A0 RID: 62880 RVA: 0x0005B4A0 File Offset: 0x000596A0
		[Token(Token = "0x600F5A0")]
		[Address(RVA = "0x6CDF90", Offset = "0x6CCB90", VA = "0x1806CDF90")]
		private bool <>xLuaBaseProxy_get_ignoreHitRange()
		{
			return default(bool);
		}

		// Token: 0x04011052 RID: 69714
		[Token(Token = "0x4011052")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ignoreHitRange;

		// Token: 0x04011053 RID: 69715
		[Token(Token = "0x4011053")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
