using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.DataCenter
{
	// Token: 0x020026F5 RID: 9973
	[Token(Token = "0x20026F5")]
	public class PlayerModeStateChecker : IHotfixable
	{
		// Token: 0x0601038E RID: 66446 RVA: 0x00062EF8 File Offset: 0x000610F8
		[Token(Token = "0x601038E")]
		[Address(RVA = "0x7EEC10", Offset = "0x7ED810", VA = "0x1807EEC10")]
		public bool IsDirty()
		{
			return default(bool);
		}

		// Token: 0x0601038F RID: 66447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601038F")]
		[Address(RVA = "0x7EEC90", Offset = "0x7ED890", VA = "0x1807EEC90")]
		public PlayerModeStateChecker()
		{
		}

		// Token: 0x04012258 RID: 74328
		[Token(Token = "0x4012258")]
		[FieldOffset(Offset = "0x10")]
		private AutoChessDataCenter.DataChecker m_dataChecker;

		// Token: 0x04012259 RID: 74329
		[Token(Token = "0x4012259")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsDirty;

		// Token: 0x0401225A RID: 74330
		[Token(Token = "0x401225A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
