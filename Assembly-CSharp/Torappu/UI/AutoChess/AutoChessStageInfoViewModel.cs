using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.AutoChess.Server;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006393 RID: 25491
	[Token(Token = "0x2006393")]
	public class AutoChessStageInfoViewModel : IHotfixable
	{
		// Token: 0x06024C3F RID: 150591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C3F")]
		[Address(RVA = "0x1FAB980", Offset = "0x1FAA580", VA = "0x181FAB980")]
		public void LoadData(string actId, string modeId, string selfUid, List<MsgAutoChessPlayerStatus> playerList)
		{
		}

		// Token: 0x06024C40 RID: 150592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C40")]
		[Address(RVA = "0x1FABB00", Offset = "0x1FAA700", VA = "0x181FABB00")]
		public void RefreshData(List<MsgAutoChessPlayerStatus> playerList)
		{
		}

		// Token: 0x06024C41 RID: 150593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C41")]
		[Address(RVA = "0x1FABC10", Offset = "0x1FAA810", VA = "0x181FABC10")]
		public AutoChessStageInfoViewModel()
		{
		}

		// Token: 0x040335E7 RID: 210407
		[Token(Token = "0x40335E7")]
		[FieldOffset(Offset = "0x10")]
		public string modeId;

		// Token: 0x040335E8 RID: 210408
		[Token(Token = "0x40335E8")]
		[FieldOffset(Offset = "0x18")]
		public string modeName;

		// Token: 0x040335E9 RID: 210409
		[Token(Token = "0x40335E9")]
		[FieldOffset(Offset = "0x20")]
		public Color modeColor;

		// Token: 0x040335EA RID: 210410
		[Token(Token = "0x40335EA")]
		[FieldOffset(Offset = "0x30")]
		public ActAutoChessModeType mode;

		// Token: 0x040335EB RID: 210411
		[Token(Token = "0x40335EB")]
		[FieldOffset(Offset = "0x34")]
		public ActAutoChessModeDifficultyType difficulty;

		// Token: 0x040335EC RID: 210412
		[Token(Token = "0x40335EC")]
		[FieldOffset(Offset = "0x38")]
		public bool isSingleMode;

		// Token: 0x040335ED RID: 210413
		[Token(Token = "0x40335ED")]
		[FieldOffset(Offset = "0x3C")]
		public int confirmedPlayerCount;

		// Token: 0x040335EE RID: 210414
		[Token(Token = "0x40335EE")]
		[FieldOffset(Offset = "0x40")]
		public int totalPlayerCount;

		// Token: 0x040335EF RID: 210415
		[Token(Token = "0x40335EF")]
		[FieldOffset(Offset = "0x44")]
		public bool isConfirmed;

		// Token: 0x040335F0 RID: 210416
		[Token(Token = "0x40335F0")]
		[FieldOffset(Offset = "0x48")]
		private string m_playerUid;

		// Token: 0x040335F1 RID: 210417
		[Token(Token = "0x40335F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040335F2 RID: 210418
		[Token(Token = "0x40335F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040335F3 RID: 210419
		[Token(Token = "0x40335F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
