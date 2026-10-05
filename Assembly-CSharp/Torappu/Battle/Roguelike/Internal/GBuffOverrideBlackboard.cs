using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002967 RID: 10599
	[Token(Token = "0x2002967")]
	public class GBuffOverrideBlackboard : BasicRelic
	{
		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x060118CF RID: 71887 RVA: 0x0006BDC0 File Offset: 0x00069FC0
		[Token(Token = "0x170026C0")]
		public override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x60118CF")]
			[Address(RVA = "0x954360", Offset = "0x952F60", VA = "0x180954360", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x060118D0 RID: 71888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118D0")]
		[Address(RVA = "0x954040", Offset = "0x952C40", VA = "0x180954040", Slot = "8")]
		public override void LatePreprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x060118D1 RID: 71889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118D1")]
		[Address(RVA = "0x954300", Offset = "0x952F00", VA = "0x180954300")]
		public GBuffOverrideBlackboard()
		{
		}

		// Token: 0x060118D2 RID: 71890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118D2")]
		[Address(RVA = "0x9542F0", Offset = "0x952EF0", VA = "0x1809542F0")]
		private void <>xLuaBaseProxy_LatePreprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040139D5 RID: 80341
		[Token(Token = "0x40139D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x040139D6 RID: 80342
		[Token(Token = "0x40139D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LatePreprocess;

		// Token: 0x040139D7 RID: 80343
		[Token(Token = "0x40139D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
