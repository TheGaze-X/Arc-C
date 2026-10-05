using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002964 RID: 10596
	[Token(Token = "0x2002964")]
	public class GBuffStack : BasicRelic
	{
		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x060118C3 RID: 71875 RVA: 0x0006BD78 File Offset: 0x00069F78
		[Token(Token = "0x170026BD")]
		public override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x60118C3")]
			[Address(RVA = "0x954A40", Offset = "0x953640", VA = "0x180954A40", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x060118C4 RID: 71876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118C4")]
		[Address(RVA = "0x954730", Offset = "0x953330", VA = "0x180954730", Slot = "7")]
		public override void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x060118C5 RID: 71877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118C5")]
		[Address(RVA = "0x9549E0", Offset = "0x9535E0", VA = "0x1809549E0")]
		public GBuffStack()
		{
		}

		// Token: 0x060118C6 RID: 71878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118C6")]
		[Address(RVA = "0x94E430", Offset = "0x94D030", VA = "0x18094E430")]
		private void <>xLuaBaseProxy_Preprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040139CC RID: 80332
		[Token(Token = "0x40139CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x040139CD RID: 80333
		[Token(Token = "0x40139CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x040139CE RID: 80334
		[Token(Token = "0x40139CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
