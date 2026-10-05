using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006419 RID: 25625
	[Token(Token = "0x2006419")]
	public class AutoChessBattlePlayerStaticInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024E8B RID: 151179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E8B")]
		[Address(RVA = "0x1FB0380", Offset = "0x1FAEF80", VA = "0x181FB0380", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024E8C RID: 151180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E8C")]
		[Address(RVA = "0x1FB04D0", Offset = "0x1FAF0D0", VA = "0x181FB04D0")]
		public AutoChessBattlePlayerStaticInfo()
		{
		}

		// Token: 0x0403399C RID: 211356
		[Token(Token = "0x403399C")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x0403399D RID: 211357
		[Token(Token = "0x403399D")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		// Token: 0x0403399E RID: 211358
		[Token(Token = "0x403399E")]
		[FieldOffset(Offset = "0x20")]
		public List<AutoChessBattleSquadSlot> squad;

		// Token: 0x0403399F RID: 211359
		[Token(Token = "0x403399F")]
		[FieldOffset(Offset = "0x28")]
		public string bandId;

		// Token: 0x040339A0 RID: 211360
		[Token(Token = "0x40339A0")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessBattlePlayerCardInfo cardInfo;

		// Token: 0x040339A1 RID: 211361
		[Token(Token = "0x40339A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x040339A2 RID: 211362
		[Token(Token = "0x40339A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
