using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002946 RID: 10566
	[Token(Token = "0x2002946")]
	public class LInsertTokenInst : BasicLevelPredefineRelic
	{
		// Token: 0x0601185E RID: 71774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601185E")]
		[Address(RVA = "0x956330", Offset = "0x954F30", VA = "0x180956330", Slot = "7")]
		public override void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x0601185F RID: 71775 RVA: 0x0006BD30 File Offset: 0x00069F30
		[Token(Token = "0x601185F")]
		[Address(RVA = "0x9564D0", Offset = "0x9550D0", VA = "0x1809564D0")]
		private bool _CheckGridPosValid(RelicLevelPredefinedData predefines, GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x06011860 RID: 71776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011860")]
		[Address(RVA = "0x956890", Offset = "0x955490", VA = "0x180956890")]
		public LInsertTokenInst()
		{
		}

		// Token: 0x06011861 RID: 71777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011861")]
		[Address(RVA = "0x94E430", Offset = "0x94D030", VA = "0x18094E430")]
		private void <>xLuaBaseProxy_Preprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x04013978 RID: 80248
		[Token(Token = "0x4013978")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x04013979 RID: 80249
		[Token(Token = "0x4013979")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckGridPosValid;

		// Token: 0x0401397A RID: 80250
		[Token(Token = "0x401397A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
