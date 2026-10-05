using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002939 RID: 10553
	[Token(Token = "0x2002939")]
	public class BasicLevelPredefineRelic : BasicRelic
	{
		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x06011836 RID: 71734 RVA: 0x0006BD18 File Offset: 0x00069F18
		[Token(Token = "0x170026BB")]
		public override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x6011836")]
			[Address(RVA = "0x94E840", Offset = "0x94D440", VA = "0x18094E840", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x06011837 RID: 71735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011837")]
		[Address(RVA = "0x94E7E0", Offset = "0x94D3E0", VA = "0x18094E7E0")]
		public BasicLevelPredefineRelic()
		{
		}

		// Token: 0x0401395C RID: 80220
		[Token(Token = "0x401395C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x0401395D RID: 80221
		[Token(Token = "0x401395D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
