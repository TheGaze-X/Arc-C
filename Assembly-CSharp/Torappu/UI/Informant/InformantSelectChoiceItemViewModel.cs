using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A37 RID: 18999
	[Token(Token = "0x2004A37")]
	public class InformantSelectChoiceItemViewModel : IHotfixable
	{
		// Token: 0x0601C935 RID: 117045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C935")]
		[Address(RVA = "0x1617C10", Offset = "0x1616810", VA = "0x181617C10")]
		public void LoadData(string actId, string choiceId, int choiceIndex)
		{
		}

		// Token: 0x0601C936 RID: 117046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C936")]
		[Address(RVA = "0x1617DA0", Offset = "0x16169A0", VA = "0x181617DA0")]
		public InformantSelectChoiceItemViewModel()
		{
		}

		// Token: 0x04025807 RID: 153607
		[Token(Token = "0x4025807")]
		[FieldOffset(Offset = "0x10")]
		public string choiceId;

		// Token: 0x04025808 RID: 153608
		[Token(Token = "0x4025808")]
		[FieldOffset(Offset = "0x18")]
		public int choiceIndex;

		// Token: 0x04025809 RID: 153609
		[Token(Token = "0x4025809")]
		[FieldOffset(Offset = "0x20")]
		public string choicePicId;

		// Token: 0x0402580A RID: 153610
		[Token(Token = "0x402580A")]
		[FieldOffset(Offset = "0x28")]
		public int trustValue;

		// Token: 0x0402580B RID: 153611
		[Token(Token = "0x402580B")]
		[FieldOffset(Offset = "0x2C")]
		public int attentionValue;

		// Token: 0x0402580C RID: 153612
		[Token(Token = "0x402580C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402580D RID: 153613
		[Token(Token = "0x402580D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
