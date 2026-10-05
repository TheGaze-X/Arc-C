using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200759A RID: 30106
	[Token(Token = "0x200759A")]
	public class Act24sideEntryHuntWikiViewModel : IHotfixable
	{
		// Token: 0x0602A5F1 RID: 173553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5F1")]
		[Address(RVA = "0x2607860", Offset = "0x2606460", VA = "0x182607860")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602A5F2 RID: 173554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5F2")]
		[Address(RVA = "0x2607C10", Offset = "0x2606810", VA = "0x182607C10")]
		public Act24sideEntryHuntWikiViewModel()
		{
		}

		// Token: 0x0403CF5A RID: 249690
		[Token(Token = "0x403CF5A")]
		[FieldOffset(Offset = "0x10")]
		public bool isHaveNew;

		// Token: 0x0403CF5B RID: 249691
		[Token(Token = "0x403CF5B")]
		[FieldOffset(Offset = "0x11")]
		public bool isHaveReward;

		// Token: 0x0403CF5C RID: 249692
		[Token(Token = "0x403CF5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CF5D RID: 249693
		[Token(Token = "0x403CF5D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
