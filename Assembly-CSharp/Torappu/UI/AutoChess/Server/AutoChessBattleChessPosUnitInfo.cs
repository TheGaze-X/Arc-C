using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006428 RID: 25640
	[Token(Token = "0x2006428")]
	public class AutoChessBattleChessPosUnitInfo : IStreamDeserialize, IStreamSerialize, IHotfixable
	{
		// Token: 0x06024EAD RID: 151213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EAD")]
		[Address(RVA = "0x1FAF840", Offset = "0x1FAE440", VA = "0x181FAF840", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EAE RID: 151214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EAE")]
		[Address(RVA = "0x1FAF930", Offset = "0x1FAE530", VA = "0x181FAF930", Slot = "5")]
		public void Write(IStreamWriter to)
		{
		}

		// Token: 0x06024EAF RID: 151215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EAF")]
		[Address(RVA = "0x1FAFA20", Offset = "0x1FAE620", VA = "0x181FAFA20")]
		public AutoChessBattleChessPosUnitInfo()
		{
		}

		// Token: 0x04033A1C RID: 211484
		[Token(Token = "0x4033A1C")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x04033A1D RID: 211485
		[Token(Token = "0x4033A1D")]
		[FieldOffset(Offset = "0x14")]
		public int position;

		// Token: 0x04033A1E RID: 211486
		[Token(Token = "0x4033A1E")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessItemType chessType;

		// Token: 0x04033A1F RID: 211487
		[Token(Token = "0x4033A1F")]
		[FieldOffset(Offset = "0x1C")]
		public SharedConsts.Direction direction;

		// Token: 0x04033A20 RID: 211488
		[Token(Token = "0x4033A20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A21 RID: 211489
		[Token(Token = "0x4033A21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04033A22 RID: 211490
		[Token(Token = "0x4033A22")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
