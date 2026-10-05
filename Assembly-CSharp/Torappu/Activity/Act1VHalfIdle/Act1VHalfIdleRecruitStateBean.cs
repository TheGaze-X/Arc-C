using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077F3 RID: 30707
	[Token(Token = "0x20077F3")]
	public class Act1VHalfIdleRecruitStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602B147 RID: 176455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B147")]
		[Address(RVA = "0x26E0990", Offset = "0x26DF590", VA = "0x1826E0990")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602B148 RID: 176456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B148")]
		[Address(RVA = "0x26E06D0", Offset = "0x26DF2D0", VA = "0x1826E06D0")]
		public GachaViewModel GetGachaViewModelByIdx(int idx)
		{
			return null;
		}

		// Token: 0x0602B149 RID: 176457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B149")]
		[Address(RVA = "0x26E0780", Offset = "0x26DF380", VA = "0x1826E0780")]
		public GachaViewModel GetGachaViewModel(string tabId)
		{
			return null;
		}

		// Token: 0x0602B14A RID: 176458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B14A")]
		[Address(RVA = "0x26E0830", Offset = "0x26DF430", VA = "0x1826E0830")]
		public GachaViewModel GetNextGachaViewModel(int sortId, Act1VHalfIdleGachaPoolType poolType)
		{
			return null;
		}

		// Token: 0x0602B14B RID: 176459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B14B")]
		[Address(RVA = "0x26E0F40", Offset = "0x26DFB40", VA = "0x1826E0F40")]
		public Act1VHalfIdleRecruitStateBean()
		{
		}

		// Token: 0x0403E3F3 RID: 254963
		[Token(Token = "0x403E3F3")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, GachaViewModel> gachaViewModelList;

		// Token: 0x0403E3F4 RID: 254964
		[Token(Token = "0x403E3F4")]
		[FieldOffset(Offset = "0x18")]
		public string actId;

		// Token: 0x0403E3F5 RID: 254965
		[Token(Token = "0x403E3F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403E3F6 RID: 254966
		[Token(Token = "0x403E3F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetGachaViewModelByIdx;

		// Token: 0x0403E3F7 RID: 254967
		[Token(Token = "0x403E3F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetGachaViewModel;

		// Token: 0x0403E3F8 RID: 254968
		[Token(Token = "0x403E3F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetNextGachaViewModel;

		// Token: 0x0403E3F9 RID: 254969
		[Token(Token = "0x403E3F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
