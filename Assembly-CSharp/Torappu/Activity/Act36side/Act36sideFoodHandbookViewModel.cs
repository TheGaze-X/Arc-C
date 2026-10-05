using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007452 RID: 29778
	[Token(Token = "0x2007452")]
	public class Act36sideFoodHandbookViewModel : IHotfixable
	{
		// Token: 0x0602A045 RID: 172101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A045")]
		[Address(RVA = "0x259DE50", Offset = "0x259CA50", VA = "0x18259DE50")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602A046 RID: 172102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A046")]
		[Address(RVA = "0x259E7D0", Offset = "0x259D3D0", VA = "0x18259E7D0")]
		public void RefreshData()
		{
		}

		// Token: 0x0602A047 RID: 172103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A047")]
		[Address(RVA = "0x259EC70", Offset = "0x259D870", VA = "0x18259EC70")]
		public void SelectTab(Act36sideFoodHandbookTabType selectedTabType)
		{
		}

		// Token: 0x0602A048 RID: 172104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A048")]
		[Address(RVA = "0x259EE10", Offset = "0x259DA10", VA = "0x18259EE10")]
		public void SelectTokenItem(string selectedTokenId)
		{
		}

		// Token: 0x0602A049 RID: 172105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A049")]
		[Address(RVA = "0x259EF80", Offset = "0x259DB80", VA = "0x18259EF80")]
		public Act36sideFoodHandbookViewModel()
		{
		}

		// Token: 0x0403C430 RID: 246832
		[Token(Token = "0x403C430")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, Act36sideFoodHandbookEnemyItemModel> enemyDict;

		// Token: 0x0403C431 RID: 246833
		[Token(Token = "0x403C431")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, Act36sideFoodHandbookTokenItemModel> tokenDict;

		// Token: 0x0403C432 RID: 246834
		[Token(Token = "0x403C432")]
		[FieldOffset(Offset = "0x20")]
		public Act36sideFoodHandbookTabType currentActiveTab;

		// Token: 0x0403C433 RID: 246835
		[Token(Token = "0x403C433")]
		[FieldOffset(Offset = "0x24")]
		public int unlockedItemNum;

		// Token: 0x0403C434 RID: 246836
		[Token(Token = "0x403C434")]
		[FieldOffset(Offset = "0x28")]
		public int totalItemNum;

		// Token: 0x0403C435 RID: 246837
		[Token(Token = "0x403C435")]
		[FieldOffset(Offset = "0x30")]
		public string selectedTokenId;

		// Token: 0x0403C436 RID: 246838
		[Token(Token = "0x403C436")]
		[FieldOffset(Offset = "0x38")]
		public PlayerActivity.PlayerAct36SideActivity.RewardState rewardState;

		// Token: 0x0403C437 RID: 246839
		[Token(Token = "0x403C437")]
		[FieldOffset(Offset = "0x40")]
		public string activityId;

		// Token: 0x0403C438 RID: 246840
		[Token(Token = "0x403C438")]
		[FieldOffset(Offset = "0x48")]
		public string unfinishToast;

		// Token: 0x0403C439 RID: 246841
		[Token(Token = "0x403C439")]
		[FieldOffset(Offset = "0x50")]
		public bool isEnemyTabShowNew;

		// Token: 0x0403C43A RID: 246842
		[Token(Token = "0x403C43A")]
		[FieldOffset(Offset = "0x51")]
		public bool isTokenTabShowNew;

		// Token: 0x0403C43B RID: 246843
		[Token(Token = "0x403C43B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403C43C RID: 246844
		[Token(Token = "0x403C43C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403C43D RID: 246845
		[Token(Token = "0x403C43D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectTab;

		// Token: 0x0403C43E RID: 246846
		[Token(Token = "0x403C43E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SelectTokenItem;

		// Token: 0x0403C43F RID: 246847
		[Token(Token = "0x403C43F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
