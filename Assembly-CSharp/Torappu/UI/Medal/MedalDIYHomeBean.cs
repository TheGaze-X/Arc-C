using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200491F RID: 18719
	[Token(Token = "0x200491F")]
	public class MedalDIYHomeBean : IStateBean, IHotfixable
	{
		// Token: 0x0601C38E RID: 115598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C38E")]
		[Address(RVA = "0x15AD600", Offset = "0x15AC200", VA = "0x1815AD600")]
		public void UpdateStatus(MedalDIYViewModel model)
		{
		}

		// Token: 0x0601C38F RID: 115599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C38F")]
		[Address(RVA = "0x15AD770", Offset = "0x15AC370", VA = "0x1815AD770")]
		public MedalDIYHomeBean()
		{
		}

		// Token: 0x04024E98 RID: 151192
		[Token(Token = "0x4024E98")]
		[FieldOffset(Offset = "0x10")]
		public HashSet<string> selectedMedalIds;

		// Token: 0x04024E99 RID: 151193
		[Token(Token = "0x4024E99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x04024E9A RID: 151194
		[Token(Token = "0x4024E9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
