using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007598 RID: 30104
	[Token(Token = "0x2007598")]
	public class Act24sideEntryEatViewModel : IHotfixable
	{
		// Token: 0x0602A5EB RID: 173547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5EB")]
		[Address(RVA = "0x26073B0", Offset = "0x2605FB0", VA = "0x1826073B0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602A5EC RID: 173548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5EC")]
		[Address(RVA = "0x26076A0", Offset = "0x26062A0", VA = "0x1826076A0")]
		private void _InitData(string actId)
		{
		}

		// Token: 0x0602A5ED RID: 173549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5ED")]
		[Address(RVA = "0x2607800", Offset = "0x2606400", VA = "0x182607800")]
		public Act24sideEntryEatViewModel()
		{
		}

		// Token: 0x0403CF49 RID: 249673
		[Token(Token = "0x403CF49")]
		[FieldOffset(Offset = "0x10")]
		public bool isHaveChance;

		// Token: 0x0403CF4A RID: 249674
		[Token(Token = "0x403CF4A")]
		[FieldOffset(Offset = "0x11")]
		public bool isHaveBuff;

		// Token: 0x0403CF4B RID: 249675
		[Token(Token = "0x403CF4B")]
		[FieldOffset(Offset = "0x12")]
		public bool timeOut;

		// Token: 0x0403CF4C RID: 249676
		[Token(Token = "0x403CF4C")]
		[FieldOffset(Offset = "0x18")]
		public string upItemId;

		// Token: 0x0403CF4D RID: 249677
		[Token(Token = "0x403CF4D")]
		[FieldOffset(Offset = "0x20")]
		private PlayerActivity.PlayerAct24SideActivity m_actData;

		// Token: 0x0403CF4E RID: 249678
		[Token(Token = "0x403CF4E")]
		[FieldOffset(Offset = "0x28")]
		private long m_endTime;

		// Token: 0x0403CF4F RID: 249679
		[Token(Token = "0x403CF4F")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<string, Act24SideData.MealData> m_actMealData;

		// Token: 0x0403CF50 RID: 249680
		[Token(Token = "0x403CF50")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0403CF51 RID: 249681
		[Token(Token = "0x403CF51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CF52 RID: 249682
		[Token(Token = "0x403CF52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0403CF53 RID: 249683
		[Token(Token = "0x403CF53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
