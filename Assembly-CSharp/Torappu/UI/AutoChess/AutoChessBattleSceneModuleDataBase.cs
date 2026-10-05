using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062AA RID: 25258
	[Token(Token = "0x20062AA")]
	public abstract class AutoChessBattleSceneModuleDataBase : IHotfixable
	{
		// Token: 0x06024682 RID: 149122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024682")]
		[Address(RVA = "0x1F3A040", Offset = "0x1F38C40", VA = "0x181F3A040")]
		protected void UpdateSeqNum()
		{
		}

		// Token: 0x06024683 RID: 149123 RVA: 0x000C41D0 File Offset: 0x000C23D0
		[Token(Token = "0x6024683")]
		[Address(RVA = "0x1F39FE0", Offset = "0x1F38BE0", VA = "0x181F39FE0")]
		public bool CheckAndRefresh()
		{
			return default(bool);
		}

		// Token: 0x06024684 RID: 149124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024684")]
		[Address(RVA = "0x1F3A0A0", Offset = "0x1F38CA0", VA = "0x181F3A0A0")]
		protected AutoChessBattleSceneModuleDataBase()
		{
		}

		// Token: 0x04032A9E RID: 207518
		[Token(Token = "0x4032A9E")]
		[FieldOffset(Offset = "0x10")]
		private int m_realSeqNum;

		// Token: 0x04032A9F RID: 207519
		[Token(Token = "0x4032A9F")]
		[FieldOffset(Offset = "0x14")]
		private int m_currentSeqNum;

		// Token: 0x04032AA0 RID: 207520
		[Token(Token = "0x4032AA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateSeqNum;

		// Token: 0x04032AA1 RID: 207521
		[Token(Token = "0x4032AA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckAndRefresh;

		// Token: 0x04032AA2 RID: 207522
		[Token(Token = "0x4032AA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
