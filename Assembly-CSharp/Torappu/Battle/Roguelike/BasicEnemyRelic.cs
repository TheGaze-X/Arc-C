using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike
{
	// Token: 0x0200292C RID: 10540
	[Token(Token = "0x200292C")]
	public abstract class BasicEnemyRelic : BasicRelic
	{
		// Token: 0x170026AA RID: 9898
		// (get) Token: 0x0601179D RID: 71581 RVA: 0x0006B880 File Offset: 0x00069A80
		[Token(Token = "0x170026AA")]
		public override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x601179D")]
			[Address(RVA = "0x94E780", Offset = "0x94D380", VA = "0x18094E780", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x0601179E RID: 71582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601179E")]
		[Address(RVA = "0x94E670", Offset = "0x94D270", VA = "0x18094E670", Slot = "7")]
		public override void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x0601179F RID: 71583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601179F")]
		[Address(RVA = "0x94E720", Offset = "0x94D320", VA = "0x18094E720")]
		protected BasicEnemyRelic()
		{
		}

		// Token: 0x060117A0 RID: 71584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117A0")]
		[Address(RVA = "0x94E430", Offset = "0x94D030", VA = "0x18094E430")]
		private void <>xLuaBaseProxy_Preprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040138AD RID: 80045
		[Token(Token = "0x40138AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x040138AE RID: 80046
		[Token(Token = "0x40138AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x040138AF RID: 80047
		[Token(Token = "0x40138AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
