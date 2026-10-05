using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078D8 RID: 30936
	[Token(Token = "0x20078D8")]
	public class Act1LockStageViewModel : IHotfixable
	{
		// Token: 0x17006594 RID: 26004
		// (get) Token: 0x0602B61D RID: 177693 RVA: 0x000DBB10 File Offset: 0x000D9D10
		[Token(Token = "0x17006594")]
		public int interlockCount
		{
			[Token(Token = "0x602B61D")]
			[Address(RVA = "0x2759F70", Offset = "0x2758B70", VA = "0x182759F70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006595 RID: 26005
		// (get) Token: 0x0602B61E RID: 177694 RVA: 0x000DBB28 File Offset: 0x000D9D28
		[Token(Token = "0x17006595")]
		public int totalApCost
		{
			[Token(Token = "0x602B61E")]
			[Address(RVA = "0x275A060", Offset = "0x2758C60", VA = "0x18275A060")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602B61F RID: 177695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B61F")]
		[Address(RVA = "0x2759700", Offset = "0x2758300", VA = "0x182759700")]
		public void LoadStageData(string stageid)
		{
		}

		// Token: 0x0602B620 RID: 177696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B620")]
		[Address(RVA = "0x2759800", Offset = "0x2758400", VA = "0x182759800")]
		public void RefreshData()
		{
		}

		// Token: 0x0602B621 RID: 177697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B621")]
		[Address(RVA = "0x2759C40", Offset = "0x2758840", VA = "0x182759C40")]
		private void _UpdateInterLockData()
		{
		}

		// Token: 0x0602B622 RID: 177698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B622")]
		[Address(RVA = "0x27598F0", Offset = "0x27584F0", VA = "0x1827598F0")]
		private void _UpdateFinalStageData()
		{
		}

		// Token: 0x0602B623 RID: 177699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B623")]
		[Address(RVA = "0x2759D70", Offset = "0x2758970", VA = "0x182759D70")]
		private void _UpdateInterlockList()
		{
		}

		// Token: 0x0602B624 RID: 177700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B624")]
		[Address(RVA = "0x2759ED0", Offset = "0x2758AD0", VA = "0x182759ED0")]
		public Act1LockStageViewModel()
		{
		}

		// Token: 0x0403EBC5 RID: 256965
		[Token(Token = "0x403EBC5")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x0403EBC6 RID: 256966
		[Token(Token = "0x403EBC6")]
		[FieldOffset(Offset = "0x18")]
		public ActivityInterlockData.StageAdditionData additionData;

		// Token: 0x0403EBC7 RID: 256967
		[Token(Token = "0x403EBC7")]
		[FieldOffset(Offset = "0x20")]
		public StageViewModel normalStageViewModel;

		// Token: 0x0403EBC8 RID: 256968
		[Token(Token = "0x403EBC8")]
		[FieldOffset(Offset = "0x28")]
		public int assistCount;

		// Token: 0x0403EBC9 RID: 256969
		[Token(Token = "0x403EBC9")]
		[FieldOffset(Offset = "0x2C")]
		public bool useSpAssist;

		// Token: 0x0403EBCA RID: 256970
		[Token(Token = "0x403EBCA")]
		[FieldOffset(Offset = "0x30")]
		public List<InterlockSquadModel> interlockSquadList;

		// Token: 0x0403EBCB RID: 256971
		[Token(Token = "0x403EBCB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_interlockCount;

		// Token: 0x0403EBCC RID: 256972
		[Token(Token = "0x403EBCC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_totalApCost;

		// Token: 0x0403EBCD RID: 256973
		[Token(Token = "0x403EBCD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadStageData;

		// Token: 0x0403EBCE RID: 256974
		[Token(Token = "0x403EBCE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403EBCF RID: 256975
		[Token(Token = "0x403EBCF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateInterLockData;

		// Token: 0x0403EBD0 RID: 256976
		[Token(Token = "0x403EBD0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateFinalStageData;

		// Token: 0x0403EBD1 RID: 256977
		[Token(Token = "0x403EBD1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateInterlockList;

		// Token: 0x0403EBD2 RID: 256978
		[Token(Token = "0x403EBD2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
