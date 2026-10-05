using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041EC RID: 16876
	[Token(Token = "0x20041EC")]
	public struct SandboxV2BattleStartNodeInfo
	{
		// Token: 0x0601A0A8 RID: 106664 RVA: 0x000A0278 File Offset: 0x0009E478
		[Token(Token = "0x601A0A8")]
		[Address(RVA = "0x12E7370", Offset = "0x12E5F70", VA = "0x1812E7370")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x04020CCA RID: 134346
		[Token(Token = "0x4020CCA")]
		[FieldOffset(Offset = "0x0")]
		public string nodeId;

		// Token: 0x04020CCB RID: 134347
		[Token(Token = "0x4020CCB")]
		[FieldOffset(Offset = "0x8")]
		public string stageId;

		// Token: 0x04020CCC RID: 134348
		[Token(Token = "0x4020CCC")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2NodeType nodeType;

		// Token: 0x04020CCD RID: 134349
		[Token(Token = "0x4020CCD")]
		[FieldOffset(Offset = "0x14")]
		public SandboxV2SeasonType nodeSeasonType;

		// Token: 0x04020CCE RID: 134350
		[Token(Token = "0x4020CCE")]
		[FieldOffset(Offset = "0x18")]
		public string nodeWeatherId;

		// Token: 0x04020CCF RID: 134351
		[Token(Token = "0x4020CCF")]
		[FieldOffset(Offset = "0x20")]
		public string monthlyRushId;

		// Token: 0x04020CD0 RID: 134352
		[Token(Token = "0x4020CD0")]
		[FieldOffset(Offset = "0x28")]
		public SandboxV2Const.SandboxV2BattleBgmType battleBgmType;
	}
}
