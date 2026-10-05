using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004803 RID: 18435
	[Token(Token = "0x2004803")]
	public class MonopolyMapNodeItemModel : IHotfixable
	{
		// Token: 0x0601BE0C RID: 114188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE0C")]
		[Address(RVA = "0x1540E10", Offset = "0x153FA10", VA = "0x181540E10")]
		public void LoadPlayerNodeData(string actId, string stageId, int nodeIndex, PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyStageNode playerNode)
		{
		}

		// Token: 0x0601BE0D RID: 114189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE0D")]
		[Address(RVA = "0x1540F80", Offset = "0x153FB80", VA = "0x181540F80")]
		public MonopolyMapNodeItemModel()
		{
		}

		// Token: 0x0402451B RID: 148763
		[Token(Token = "0x402451B")]
		[FieldOffset(Offset = "0x10")]
		public int nodeIndex;

		// Token: 0x0402451C RID: 148764
		[Token(Token = "0x402451C")]
		[FieldOffset(Offset = "0x18")]
		public string resourceId;

		// Token: 0x0402451D RID: 148765
		[Token(Token = "0x402451D")]
		[FieldOffset(Offset = "0x20")]
		public int resourceBasicCount;

		// Token: 0x0402451E RID: 148766
		[Token(Token = "0x402451E")]
		[FieldOffset(Offset = "0x24")]
		public int buffRate;

		// Token: 0x0402451F RID: 148767
		[Token(Token = "0x402451F")]
		[FieldOffset(Offset = "0x28")]
		public bool isNodeLock;

		// Token: 0x04024520 RID: 148768
		[Token(Token = "0x4024520")]
		[FieldOffset(Offset = "0x29")]
		public bool hasChest;

		// Token: 0x04024521 RID: 148769
		[Token(Token = "0x4024521")]
		[FieldOffset(Offset = "0x30")]
		public string nodeIconId;

		// Token: 0x04024522 RID: 148770
		[Token(Token = "0x4024522")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadPlayerNodeData;

		// Token: 0x04024523 RID: 148771
		[Token(Token = "0x4024523")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
