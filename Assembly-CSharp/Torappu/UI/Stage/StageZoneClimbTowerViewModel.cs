using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200679C RID: 26524
	[Token(Token = "0x200679C")]
	public class StageZoneClimbTowerViewModel : IHotfixable
	{
		// Token: 0x060260A9 RID: 155817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260A9")]
		[Address(RVA = "0x211D240", Offset = "0x211BE40", VA = "0x18211D240")]
		public void LoadData()
		{
		}

		// Token: 0x060260AA RID: 155818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260AA")]
		[Address(RVA = "0x211D6D0", Offset = "0x211C2D0", VA = "0x18211D6D0")]
		public StageZoneClimbTowerViewModel()
		{
		}

		// Token: 0x0403586F RID: 219247
		[Token(Token = "0x403586F")]
		[FieldOffset(Offset = "0x10")]
		public bool isValid;

		// Token: 0x04035870 RID: 219248
		[Token(Token = "0x4035870")]
		[FieldOffset(Offset = "0x14")]
		public int lowerItemCurrFee;

		// Token: 0x04035871 RID: 219249
		[Token(Token = "0x4035871")]
		[FieldOffset(Offset = "0x18")]
		public int lowerItemTotalFee;

		// Token: 0x04035872 RID: 219250
		[Token(Token = "0x4035872")]
		[FieldOffset(Offset = "0x1C")]
		public int higherItemCurrFee;

		// Token: 0x04035873 RID: 219251
		[Token(Token = "0x4035873")]
		[FieldOffset(Offset = "0x20")]
		public int higherItemTotalFee;

		// Token: 0x04035874 RID: 219252
		[Token(Token = "0x4035874")]
		[FieldOffset(Offset = "0x28")]
		public string feeCountDownStr;

		// Token: 0x04035875 RID: 219253
		[Token(Token = "0x4035875")]
		[FieldOffset(Offset = "0x30")]
		public string itemGroupName;

		// Token: 0x04035876 RID: 219254
		[Token(Token = "0x4035876")]
		[FieldOffset(Offset = "0x38")]
		public string seasonId;

		// Token: 0x04035877 RID: 219255
		[Token(Token = "0x4035877")]
		[FieldOffset(Offset = "0x40")]
		public long seasonRemainSeconds;

		// Token: 0x04035878 RID: 219256
		[Token(Token = "0x4035878")]
		[FieldOffset(Offset = "0x48")]
		public string seasonRemainTimeStr;

		// Token: 0x04035879 RID: 219257
		[Token(Token = "0x4035879")]
		[FieldOffset(Offset = "0x50")]
		public string seasonName;

		// Token: 0x0403587A RID: 219258
		[Token(Token = "0x403587A")]
		[FieldOffset(Offset = "0x58")]
		public int seasonNum;

		// Token: 0x0403587B RID: 219259
		[Token(Token = "0x403587B")]
		[FieldOffset(Offset = "0x60")]
		public string lockedToast;

		// Token: 0x0403587C RID: 219260
		[Token(Token = "0x403587C")]
		[FieldOffset(Offset = "0x68")]
		public string towerId;

		// Token: 0x0403587D RID: 219261
		[Token(Token = "0x403587D")]
		[FieldOffset(Offset = "0x70")]
		public string towerName;

		// Token: 0x0403587E RID: 219262
		[Token(Token = "0x403587E")]
		[FieldOffset(Offset = "0x78")]
		public string towerSubName;

		// Token: 0x0403587F RID: 219263
		[Token(Token = "0x403587F")]
		[FieldOffset(Offset = "0x80")]
		public bool isInBattle;

		// Token: 0x04035880 RID: 219264
		[Token(Token = "0x4035880")]
		[FieldOffset(Offset = "0x81")]
		public bool isHard;

		// Token: 0x04035881 RID: 219265
		[Token(Token = "0x4035881")]
		[FieldOffset(Offset = "0x82")]
		public bool isUnlock;

		// Token: 0x04035882 RID: 219266
		[Token(Token = "0x4035882")]
		[FieldOffset(Offset = "0x83")]
		public bool isTrainTowerFinish;

		// Token: 0x04035883 RID: 219267
		[Token(Token = "0x4035883")]
		[FieldOffset(Offset = "0x84")]
		public bool showSeasonBtn;

		// Token: 0x04035884 RID: 219268
		[Token(Token = "0x4035884")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035885 RID: 219269
		[Token(Token = "0x4035885")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
