using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002531 RID: 9521
	[Token(Token = "0x2002531")]
	public class AdvancedSelectorWithTagAndBuffKeyIgnoredHitRange : AdvancedSelectorWithTagAndBuffKey
	{
		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x0600F5AE RID: 62894 RVA: 0x0005B500 File Offset: 0x00059700
		[Token(Token = "0x17002026")]
		protected override bool ignoreHitRange
		{
			[Token(Token = "0x600F5AE")]
			[Address(RVA = "0x6CFAC0", Offset = "0x6CE6C0", VA = "0x1806CFAC0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F5AF RID: 62895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5AF")]
		[Address(RVA = "0x6CFA60", Offset = "0x6CE660", VA = "0x1806CFA60")]
		public AdvancedSelectorWithTagAndBuffKeyIgnoredHitRange()
		{
		}

		// Token: 0x0600F5B0 RID: 62896 RVA: 0x0005B518 File Offset: 0x00059718
		[Token(Token = "0x600F5B0")]
		[Address(RVA = "0x6CDF90", Offset = "0x6CCB90", VA = "0x1806CDF90")]
		private bool <>xLuaBaseProxy_get_ignoreHitRange()
		{
			return default(bool);
		}

		// Token: 0x0401106B RID: 69739
		[Token(Token = "0x401106B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ignoreHitRange;

		// Token: 0x0401106C RID: 69740
		[Token(Token = "0x401106C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
