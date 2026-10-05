using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049F5 RID: 18933
	[Token(Token = "0x20049F5")]
	public class InformantChoiceEndViewModel : IHotfixable
	{
		// Token: 0x0601C815 RID: 116757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C815")]
		[Address(RVA = "0x15F3EE0", Offset = "0x15F2AE0", VA = "0x1815F3EE0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601C816 RID: 116758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C816")]
		[Address(RVA = "0x15F3F70", Offset = "0x15F2B70", VA = "0x1815F3F70")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x0601C817 RID: 116759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C817")]
		[Address(RVA = "0x15F4420", Offset = "0x15F3020", VA = "0x1815F4420")]
		public InformantChoiceEndViewModel()
		{
		}

		// Token: 0x0402558A RID: 152970
		[Token(Token = "0x402558A")]
		[FieldOffset(Offset = "0x10")]
		public int enterSeqNum;

		// Token: 0x0402558B RID: 152971
		[Token(Token = "0x402558B")]
		[FieldOffset(Offset = "0x14")]
		public PlayerActivity.PlayerAct44SideActivity.InformantState curState;

		// Token: 0x0402558C RID: 152972
		[Token(Token = "0x402558C")]
		[FieldOffset(Offset = "0x18")]
		public string customerId;

		// Token: 0x0402558D RID: 152973
		[Token(Token = "0x402558D")]
		[FieldOffset(Offset = "0x20")]
		public bool isSpCustomer;

		// Token: 0x0402558E RID: 152974
		[Token(Token = "0x402558E")]
		[FieldOffset(Offset = "0x28")]
		public string tagId;

		// Token: 0x0402558F RID: 152975
		[Token(Token = "0x402558F")]
		[FieldOffset(Offset = "0x30")]
		public string customerName;

		// Token: 0x04025590 RID: 152976
		[Token(Token = "0x4025590")]
		[FieldOffset(Offset = "0x38")]
		public string tagName;

		// Token: 0x04025591 RID: 152977
		[Token(Token = "0x4025591")]
		[FieldOffset(Offset = "0x40")]
		public string customerIllustId;

		// Token: 0x04025592 RID: 152978
		[Token(Token = "0x4025592")]
		[FieldOffset(Offset = "0x48")]
		public string customerDialogText;

		// Token: 0x04025593 RID: 152979
		[Token(Token = "0x4025593")]
		[FieldOffset(Offset = "0x50")]
		public string keeperDialogText;

		// Token: 0x04025594 RID: 152980
		[Token(Token = "0x4025594")]
		[FieldOffset(Offset = "0x58")]
		public bool usedInsight;

		// Token: 0x04025595 RID: 152981
		[Token(Token = "0x4025595")]
		[FieldOffset(Offset = "0x60")]
		public InformantInsightBarModel insightBarModel;

		// Token: 0x04025596 RID: 152982
		[Token(Token = "0x4025596")]
		[FieldOffset(Offset = "0x68")]
		public InformantSelectChoiceItemViewModel lastChoiceModel;

		// Token: 0x04025597 RID: 152983
		[Token(Token = "0x4025597")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04025598 RID: 152984
		[Token(Token = "0x4025598")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04025599 RID: 152985
		[Token(Token = "0x4025599")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
