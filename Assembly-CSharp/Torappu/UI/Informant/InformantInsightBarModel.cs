using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A12 RID: 18962
	[Token(Token = "0x2004A12")]
	public class InformantInsightBarModel : IHotfixable
	{
		// Token: 0x0601C887 RID: 116871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C887")]
		[Address(RVA = "0x15FC0E0", Offset = "0x15FACE0", VA = "0x1815FC0E0")]
		public void LoadInsightData(InformantInsightBarModel.LoadParam param)
		{
		}

		// Token: 0x0601C888 RID: 116872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C888")]
		[Address(RVA = "0x15FC1D0", Offset = "0x15FADD0", VA = "0x1815FC1D0")]
		private void _LoadBasicPart(string actId)
		{
		}

		// Token: 0x0601C889 RID: 116873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C889")]
		[Address(RVA = "0x15FC5B0", Offset = "0x15FB1B0", VA = "0x1815FC5B0")]
		private void _LoadDivLinePart(string actId, bool showDivLine)
		{
		}

		// Token: 0x0601C88A RID: 116874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C88A")]
		[Address(RVA = "0x15FC3E0", Offset = "0x15FAFE0", VA = "0x1815FC3E0")]
		private void _LoadChoiceEffect(string actId, string choiceId)
		{
		}

		// Token: 0x0601C88B RID: 116875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C88B")]
		[Address(RVA = "0x15FC840", Offset = "0x15FB440", VA = "0x1815FC840")]
		public InformantInsightBarModel()
		{
		}

		// Token: 0x04025683 RID: 153219
		[Token(Token = "0x4025683")]
		[FieldOffset(Offset = "0x10")]
		public InformantInsightParam patience;

		// Token: 0x04025684 RID: 153220
		[Token(Token = "0x4025684")]
		[FieldOffset(Offset = "0x18")]
		public InformantInsightBarModel.SliderItemModel trust;

		// Token: 0x04025685 RID: 153221
		[Token(Token = "0x4025685")]
		[FieldOffset(Offset = "0x20")]
		public InformantInsightBarModel.SliderItemModel attention;

		// Token: 0x04025686 RID: 153222
		[Token(Token = "0x4025686")]
		[FieldOffset(Offset = "0x28")]
		public bool showDivLine;

		// Token: 0x04025687 RID: 153223
		[Token(Token = "0x4025687")]
		[FieldOffset(Offset = "0x29")]
		public bool showChoiceDiff;

		// Token: 0x04025688 RID: 153224
		[Token(Token = "0x4025688")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadInsightData;

		// Token: 0x04025689 RID: 153225
		[Token(Token = "0x4025689")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadBasicPart;

		// Token: 0x0402568A RID: 153226
		[Token(Token = "0x402568A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadDivLinePart;

		// Token: 0x0402568B RID: 153227
		[Token(Token = "0x402568B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadChoiceEffect;

		// Token: 0x0402568C RID: 153228
		[Token(Token = "0x402568C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A13 RID: 18963
		[Token(Token = "0x2004A13")]
		public struct LoadParam
		{
			// Token: 0x0402568D RID: 153229
			[Token(Token = "0x402568D")]
			[FieldOffset(Offset = "0x0")]
			public string actId;

			// Token: 0x0402568E RID: 153230
			[Token(Token = "0x402568E")]
			[FieldOffset(Offset = "0x8")]
			public bool showDivLine;

			// Token: 0x0402568F RID: 153231
			[Token(Token = "0x402568F")]
			[FieldOffset(Offset = "0x10")]
			public string choiceId;
		}

		// Token: 0x02004A14 RID: 18964
		[Token(Token = "0x2004A14")]
		public class SliderItemModel : IHotfixable
		{
			// Token: 0x0601C88C RID: 116876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C88C")]
			[Address(RVA = "0x1606E90", Offset = "0x1605A90", VA = "0x181606E90")]
			public SliderItemModel()
			{
			}

			// Token: 0x04025690 RID: 153232
			[Token(Token = "0x4025690")]
			[FieldOffset(Offset = "0x10")]
			public int current;

			// Token: 0x04025691 RID: 153233
			[Token(Token = "0x4025691")]
			[FieldOffset(Offset = "0x14")]
			public int barMax;

			// Token: 0x04025692 RID: 153234
			[Token(Token = "0x4025692")]
			[FieldOffset(Offset = "0x18")]
			public InformantInsightParam state;

			// Token: 0x04025693 RID: 153235
			[Token(Token = "0x4025693")]
			[FieldOffset(Offset = "0x1C")]
			public int rc;

			// Token: 0x04025694 RID: 153236
			[Token(Token = "0x4025694")]
			[FieldOffset(Offset = "0x20")]
			public int max;

			// Token: 0x04025695 RID: 153237
			[Token(Token = "0x4025695")]
			[FieldOffset(Offset = "0x24")]
			public int valueWithChoice;

			// Token: 0x04025696 RID: 153238
			[Token(Token = "0x4025696")]
			[FieldOffset(Offset = "0x28")]
			public int choiceArrowNum;

			// Token: 0x04025697 RID: 153239
			[Token(Token = "0x4025697")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
