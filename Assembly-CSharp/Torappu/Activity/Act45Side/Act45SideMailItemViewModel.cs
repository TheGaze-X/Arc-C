using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072E4 RID: 29412
	[Token(Token = "0x20072E4")]
	public class Act45SideMailItemViewModel : IHotfixable
	{
		// Token: 0x060299ED RID: 170477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299ED")]
		[Address(RVA = "0x24FA4A0", Offset = "0x24F90A0", VA = "0x1824FA4A0")]
		public void TryUpdateTimeStr(string timeStrFormat)
		{
		}

		// Token: 0x060299EE RID: 170478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299EE")]
		[Address(RVA = "0x24FA560", Offset = "0x24F9160", VA = "0x1824FA560")]
		public Act45SideMailItemViewModel()
		{
		}

		// Token: 0x0403B87F RID: 243839
		[Token(Token = "0x403B87F")]
		[FieldOffset(Offset = "0x10")]
		public int sortId;

		// Token: 0x0403B880 RID: 243840
		[Token(Token = "0x403B880")]
		[FieldOffset(Offset = "0x18")]
		public string mailFrom;

		// Token: 0x0403B881 RID: 243841
		[Token(Token = "0x403B881")]
		[FieldOffset(Offset = "0x20")]
		public string picId;

		// Token: 0x0403B882 RID: 243842
		[Token(Token = "0x403B882")]
		[FieldOffset(Offset = "0x28")]
		public string mailTitle;

		// Token: 0x0403B883 RID: 243843
		[Token(Token = "0x403B883")]
		[FieldOffset(Offset = "0x30")]
		public string mailContent;

		// Token: 0x0403B884 RID: 243844
		[Token(Token = "0x403B884")]
		[FieldOffset(Offset = "0x38")]
		public string timeStr;

		// Token: 0x0403B885 RID: 243845
		[Token(Token = "0x403B885")]
		[FieldOffset(Offset = "0x40")]
		public bool isUnlocked;

		// Token: 0x0403B886 RID: 243846
		[Token(Token = "0x403B886")]
		[FieldOffset(Offset = "0x41")]
		public bool rewardGot;

		// Token: 0x0403B887 RID: 243847
		[Token(Token = "0x403B887")]
		[FieldOffset(Offset = "0x48")]
		public long sendTime;

		// Token: 0x0403B888 RID: 243848
		[Token(Token = "0x403B888")]
		[FieldOffset(Offset = "0x50")]
		public List<UIItemViewModel> rewards;

		// Token: 0x0403B889 RID: 243849
		[Token(Token = "0x403B889")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryUpdateTimeStr;

		// Token: 0x0403B88A RID: 243850
		[Token(Token = "0x403B88A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
