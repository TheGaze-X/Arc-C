using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200687E RID: 26750
	[Token(Token = "0x200687E")]
	public class StageMainlineDiffGroupStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06026503 RID: 156931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026503")]
		[Address(RVA = "0x2161D10", Offset = "0x2160910", VA = "0x182161D10")]
		public StageMainlineDiffGroupStateBean()
		{
		}

		// Token: 0x04035F82 RID: 221058
		[Token(Token = "0x4035F82")]
		[FieldOffset(Offset = "0x10")]
		public ZoneViewModel zoneViewModel;

		// Token: 0x04035F83 RID: 221059
		[Token(Token = "0x4035F83")]
		[FieldOffset(Offset = "0x18")]
		public StageDiffGroup selectDiffGroup;

		// Token: 0x04035F84 RID: 221060
		[Token(Token = "0x4035F84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
