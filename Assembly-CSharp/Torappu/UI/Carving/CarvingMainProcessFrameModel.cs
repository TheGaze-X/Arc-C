using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006041 RID: 24641
	[Token(Token = "0x2006041")]
	public class CarvingMainProcessFrameModel : IHotfixable
	{
		// Token: 0x06023A23 RID: 145955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A23")]
		[Address(RVA = "0x1E4DE70", Offset = "0x1E4CA70", VA = "0x181E4DE70")]
		public void LoadFrame(Act35SideData actData, CarvingProcessFrame frame)
		{
		}

		// Token: 0x06023A24 RID: 145956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A24")]
		[Address(RVA = "0x1E4E230", Offset = "0x1E4CE30", VA = "0x181E4E230")]
		public CarvingMainProcessFrameModel()
		{
		}

		// Token: 0x0403157E RID: 202110
		[Token(Token = "0x403157E")]
		[FieldOffset(Offset = "0x10")]
		public string card;

		// Token: 0x0403157F RID: 202111
		[Token(Token = "0x403157F")]
		[FieldOffset(Offset = "0x18")]
		public List<CarvingMaterialModel> outputList;

		// Token: 0x04031580 RID: 202112
		[Token(Token = "0x4031580")]
		[FieldOffset(Offset = "0x20")]
		public int score;

		// Token: 0x04031581 RID: 202113
		[Token(Token = "0x4031581")]
		[FieldOffset(Offset = "0x24")]
		public CarvingMainProcessFrameModel.ProcessFrameType frameType;

		// Token: 0x04031582 RID: 202114
		[Token(Token = "0x4031582")]
		[FieldOffset(Offset = "0x28")]
		public bool isTriggerBonus;

		// Token: 0x04031583 RID: 202115
		[Token(Token = "0x4031583")]
		[FieldOffset(Offset = "0x2C")]
		public int cardBounceSeq;

		// Token: 0x04031584 RID: 202116
		[Token(Token = "0x4031584")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadFrame;

		// Token: 0x04031585 RID: 202117
		[Token(Token = "0x4031585")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006042 RID: 24642
		[Token(Token = "0x2006042")]
		public enum ProcessFrameType
		{
			// Token: 0x04031587 RID: 202119
			[Token(Token = "0x4031587")]
			APPLY_CARD,
			// Token: 0x04031588 RID: 202120
			[Token(Token = "0x4031588")]
			RETURN_MATERIAL,
			// Token: 0x04031589 RID: 202121
			[Token(Token = "0x4031589")]
			ON_SETTLE_BUFF,
			// Token: 0x0403158A RID: 202122
			[Token(Token = "0x403158A")]
			ENTER,
			// Token: 0x0403158B RID: 202123
			[Token(Token = "0x403158B")]
			TASK,
			// Token: 0x0403158C RID: 202124
			[Token(Token = "0x403158C")]
			BONUS
		}
	}
}
