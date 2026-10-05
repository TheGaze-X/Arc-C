using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004551 RID: 17745
	[Token(Token = "0x2004551")]
	public class GameSettleOuterInfo
	{
		// Token: 0x0601B0A9 RID: 110761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0A9")]
		[Address(RVA = "0x142F4F0", Offset = "0x142E0F0", VA = "0x18142F4F0")]
		public GameSettleOuterInfo()
		{
		}

		// Token: 0x04022BE0 RID: 142304
		[Token(Token = "0x4022BE0")]
		[FieldOffset(Offset = "0x10")]
		public GameSettleMission mission;

		// Token: 0x04022BE1 RID: 142305
		[Token(Token = "0x4022BE1")]
		[FieldOffset(Offset = "0x18")]
		public GameSettleBpInfo missionBp;

		// Token: 0x04022BE2 RID: 142306
		[Token(Token = "0x4022BE2")]
		[FieldOffset(Offset = "0x20")]
		public GameSettleBpInfo relicBp;

		// Token: 0x04022BE3 RID: 142307
		[Token(Token = "0x4022BE3")]
		[FieldOffset(Offset = "0x28")]
		public GameSettleBpInfo totemBp;

		// Token: 0x04022BE4 RID: 142308
		[Token(Token = "0x4022BE4")]
		[FieldOffset(Offset = "0x30")]
		public GameSettleBpInfo fragmentBp;

		// Token: 0x04022BE5 RID: 142309
		[Token(Token = "0x4022BE5")]
		[FieldOffset(Offset = "0x38")]
		public GameSettleBpInfo copperBp;

		// Token: 0x04022BE6 RID: 142310
		[Token(Token = "0x4022BE6")]
		[FieldOffset(Offset = "0x40")]
		public List<string> relicUnlock;

		// Token: 0x04022BE7 RID: 142311
		[Token(Token = "0x4022BE7")]
		[FieldOffset(Offset = "0x48")]
		public List<string> totemUnlock;

		// Token: 0x04022BE8 RID: 142312
		[Token(Token = "0x4022BE8")]
		[FieldOffset(Offset = "0x50")]
		public List<string> fragmentUnlock;

		// Token: 0x04022BE9 RID: 142313
		[Token(Token = "0x4022BE9")]
		[FieldOffset(Offset = "0x58")]
		public List<string> copperUnlock;

		// Token: 0x04022BEA RID: 142314
		[Token(Token = "0x4022BEA")]
		[FieldOffset(Offset = "0x60")]
		public int gp;

		// Token: 0x04022BEB RID: 142315
		[Token(Token = "0x4022BEB")]
		[FieldOffset(Offset = "0x68")]
		public List<GameSettleSPOperatorInfo> spOperatorInfo;

		// Token: 0x04022BEC RID: 142316
		[Token(Token = "0x4022BEC")]
		[FieldOffset(Offset = "0x70")]
		public List<ItemBundle> items;
	}
}
