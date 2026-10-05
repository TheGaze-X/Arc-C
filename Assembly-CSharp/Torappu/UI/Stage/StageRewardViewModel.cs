using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020068D1 RID: 26833
	[Token(Token = "0x20068D1")]
	public class StageRewardViewModel : IComparable<StageRewardViewModel>
	{
		// Token: 0x0602673A RID: 157498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602673A")]
		[Address(RVA = "0x2186340", Offset = "0x2184F40", VA = "0x182186340")]
		public void LoadData(StageData.DisplayRewards rewardData, [Optional] string timelyDropId, [Optional] string overrideBuffId, bool istimelyDropReplace = false)
		{
		}

		// Token: 0x0602673B RID: 157499 RVA: 0x000CB340 File Offset: 0x000C9540
		[Token(Token = "0x602673B")]
		[Address(RVA = "0x2186210", Offset = "0x2184E10", VA = "0x182186210", Slot = "4")]
		public int CompareTo(StageRewardViewModel other)
		{
			return 0;
		}

		// Token: 0x0602673C RID: 157500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602673C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StageRewardViewModel()
		{
		}

		// Token: 0x040362CA RID: 221898
		[Token(Token = "0x40362CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UIItemViewModel itemModel;

		// Token: 0x040362CB RID: 221899
		[Token(Token = "0x40362CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isOnce;

		// Token: 0x040362CC RID: 221900
		[Token(Token = "0x40362CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isComplete;

		// Token: 0x040362CD RID: 221901
		[Token(Token = "0x40362CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isOverrideDrop;

		// Token: 0x040362CE RID: 221902
		[Token(Token = "0x40362CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string timelyDropId;

		// Token: 0x040362CF RID: 221903
		[Token(Token = "0x40362CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isTimelyDropReplace;

		// Token: 0x040362D0 RID: 221904
		[Token(Token = "0x40362D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string overrideBuffId;

		// Token: 0x040362D1 RID: 221905
		[Token(Token = "0x40362D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public OccPer occPerInfo;
	}
}
