using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007525 RID: 29989
	[Token(Token = "0x2007525")]
	public class Act25sideResearchConfirmViewModel : IHotfixable
	{
		// Token: 0x0602A41C RID: 173084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A41C")]
		[Address(RVA = "0x25E3360", Offset = "0x25E1F60", VA = "0x1825E3360")]
		public void LoadData(string actId, string areaId)
		{
		}

		// Token: 0x0602A41D RID: 173085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A41D")]
		[Address(RVA = "0x25E3570", Offset = "0x25E2170", VA = "0x1825E3570")]
		public Act25sideResearchConfirmViewModel()
		{
		}

		// Token: 0x0403CC02 RID: 248834
		[Token(Token = "0x403CC02")]
		[FieldOffset(Offset = "0x10")]
		public string areaId;

		// Token: 0x0403CC03 RID: 248835
		[Token(Token = "0x403CC03")]
		[FieldOffset(Offset = "0x18")]
		public string areaName;

		// Token: 0x0403CC04 RID: 248836
		[Token(Token = "0x403CC04")]
		[FieldOffset(Offset = "0x20")]
		public int dailyAddCount;

		// Token: 0x0403CC05 RID: 248837
		[Token(Token = "0x403CC05")]
		[FieldOffset(Offset = "0x24")]
		public int currentCount;

		// Token: 0x0403CC06 RID: 248838
		[Token(Token = "0x403CC06")]
		[FieldOffset(Offset = "0x28")]
		public int costCount;

		// Token: 0x0403CC07 RID: 248839
		[Token(Token = "0x403CC07")]
		[FieldOffset(Offset = "0x2C")]
		public bool isNotOpen;

		// Token: 0x0403CC08 RID: 248840
		[Token(Token = "0x403CC08")]
		[FieldOffset(Offset = "0x2D")]
		public bool isNotEnoughCount;

		// Token: 0x0403CC09 RID: 248841
		[Token(Token = "0x403CC09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CC0A RID: 248842
		[Token(Token = "0x403CC0A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
