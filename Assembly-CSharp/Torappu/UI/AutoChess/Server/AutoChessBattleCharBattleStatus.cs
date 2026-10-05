using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200643C RID: 25660
	[Token(Token = "0x200643C")]
	public class AutoChessBattleCharBattleStatus : IStreamDeserialize, IStreamSerialize, IHotfixable
	{
		// Token: 0x06024ED9 RID: 151257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ED9")]
		[Address(RVA = "0x1FC5200", Offset = "0x1FC3E00", VA = "0x181FC5200", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EDA RID: 151258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EDA")]
		[Address(RVA = "0x1FC52D0", Offset = "0x1FC3ED0", VA = "0x181FC52D0", Slot = "5")]
		public void Write(IStreamWriter to)
		{
		}

		// Token: 0x06024EDB RID: 151259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EDB")]
		[Address(RVA = "0x1FC5430", Offset = "0x1FC4030", VA = "0x181FC5430")]
		public AutoChessBattleCharBattleStatus()
		{
		}

		// Token: 0x04033A86 RID: 211590
		[Token(Token = "0x4033A86")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x04033A87 RID: 211591
		[Token(Token = "0x4033A87")]
		[FieldOffset(Offset = "0x14")]
		public int hp;

		// Token: 0x04033A88 RID: 211592
		[Token(Token = "0x4033A88")]
		[FieldOffset(Offset = "0x18")]
		public int tech;

		// Token: 0x04033A89 RID: 211593
		[Token(Token = "0x4033A89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A8A RID: 211594
		[Token(Token = "0x4033A8A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04033A8B RID: 211595
		[Token(Token = "0x4033A8B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
