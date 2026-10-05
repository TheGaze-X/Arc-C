using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006435 RID: 25653
	[Token(Token = "0x2006435")]
	public class AutoChessBattleEscapedEnemyInfo : IStreamDeserialize, IStreamSerialize, IHotfixable
	{
		// Token: 0x06024EC9 RID: 151241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EC9")]
		[Address(RVA = "0x1FC54D0", Offset = "0x1FC40D0", VA = "0x181FC54D0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024ECA RID: 151242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ECA")]
		[Address(RVA = "0x1FC55C0", Offset = "0x1FC41C0", VA = "0x181FC55C0", Slot = "5")]
		public void Write(IStreamWriter to)
		{
		}

		// Token: 0x06024ECB RID: 151243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ECB")]
		[Address(RVA = "0x1FC56A0", Offset = "0x1FC42A0", VA = "0x181FC56A0")]
		public AutoChessBattleEscapedEnemyInfo()
		{
		}

		// Token: 0x04033A5D RID: 211549
		[Token(Token = "0x4033A5D")]
		[FieldOffset(Offset = "0x10")]
		public int ownerPlayerIndex;

		// Token: 0x04033A5E RID: 211550
		[Token(Token = "0x4033A5E")]
		[FieldOffset(Offset = "0x18")]
		public string enemyId;

		// Token: 0x04033A5F RID: 211551
		[Token(Token = "0x4033A5F")]
		[FieldOffset(Offset = "0x20")]
		public int enemyInstId;

		// Token: 0x04033A60 RID: 211552
		[Token(Token = "0x4033A60")]
		[FieldOffset(Offset = "0x24")]
		public bool isToken;

		// Token: 0x04033A61 RID: 211553
		[Token(Token = "0x4033A61")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A62 RID: 211554
		[Token(Token = "0x4033A62")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04033A63 RID: 211555
		[Token(Token = "0x4033A63")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
