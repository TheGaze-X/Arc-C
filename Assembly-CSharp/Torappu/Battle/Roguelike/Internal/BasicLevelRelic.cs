using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002938 RID: 10552
	[Token(Token = "0x2002938")]
	public class BasicLevelRelic : BasicRelic
	{
		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x06011834 RID: 71732 RVA: 0x0006BD00 File Offset: 0x00069F00
		[Token(Token = "0x170026BA")]
		public override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x6011834")]
			[Address(RVA = "0x94E900", Offset = "0x94D500", VA = "0x18094E900", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x06011835 RID: 71733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011835")]
		[Address(RVA = "0x94E8A0", Offset = "0x94D4A0", VA = "0x18094E8A0")]
		public BasicLevelRelic()
		{
		}

		// Token: 0x0401395A RID: 80218
		[Token(Token = "0x401395A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x0401395B RID: 80219
		[Token(Token = "0x401395B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
