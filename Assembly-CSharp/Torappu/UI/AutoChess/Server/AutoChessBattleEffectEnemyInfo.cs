using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200642A RID: 25642
	[Token(Token = "0x200642A")]
	public class AutoChessBattleEffectEnemyInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EB3 RID: 151219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EB3")]
		[Address(RVA = "0x1FAFAC0", Offset = "0x1FAE6C0", VA = "0x181FAFAC0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EB4 RID: 151220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EB4")]
		[Address(RVA = "0x1FAFB90", Offset = "0x1FAE790", VA = "0x181FAFB90")]
		public AutoChessBattleEffectEnemyInfo()
		{
		}

		// Token: 0x04033A2A RID: 211498
		[Token(Token = "0x4033A2A")]
		[FieldOffset(Offset = "0x10")]
		public int effectInstId;

		// Token: 0x04033A2B RID: 211499
		[Token(Token = "0x4033A2B")]
		[FieldOffset(Offset = "0x18")]
		public string enemyId;

		// Token: 0x04033A2C RID: 211500
		[Token(Token = "0x4033A2C")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		// Token: 0x04033A2D RID: 211501
		[Token(Token = "0x4033A2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A2E RID: 211502
		[Token(Token = "0x4033A2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
