using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061CA RID: 25034
	[Token(Token = "0x20061CA")]
	public class BossRushStageWaveDropModel : IHotfixable
	{
		// Token: 0x060241F6 RID: 147958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241F6")]
		[Address(RVA = "0x1EE2D10", Offset = "0x1EE1910", VA = "0x181EE2D10")]
		public BossRushStageWaveDropModel()
		{
		}

		// Token: 0x0403237D RID: 205693
		[Token(Token = "0x403237D")]
		[FieldOffset(Offset = "0x10")]
		public int clearWaveCount;

		// Token: 0x0403237E RID: 205694
		[Token(Token = "0x403237E")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle dropInfo;

		// Token: 0x0403237F RID: 205695
		[Token(Token = "0x403237F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
