using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067EA RID: 26602
	[Token(Token = "0x20067EA")]
	public class ZoneHomeClimbTowerToDoModel : ZoneHomeToDoItemModel
	{
		// Token: 0x06026214 RID: 156180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026214")]
		[Address(RVA = "0x21434B0", Offset = "0x21420B0", VA = "0x1821434B0")]
		public static ZoneHomeClimbTowerToDoModel LoadData()
		{
			return null;
		}

		// Token: 0x06026215 RID: 156181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026215")]
		[Address(RVA = "0x2143740", Offset = "0x2142340", VA = "0x182143740")]
		private static ZoneHomeClimbTowerToDoModel.ClimbTowerModel _LoadTowerModel()
		{
			return null;
		}

		// Token: 0x06026216 RID: 156182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026216")]
		[Address(RVA = "0x21437A0", Offset = "0x21423A0", VA = "0x1821437A0")]
		private static ZoneHomeClimbTowerToDoModel.ClimbTowerModel _TryLoadCurrentModel()
		{
			return null;
		}

		// Token: 0x06026217 RID: 156183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026217")]
		[Address(RVA = "0x2143990", Offset = "0x2142590", VA = "0x182143990")]
		private static ZoneHomeClimbTowerToDoModel.ClimbTowerModel _TryLoadOfferModel()
		{
			return null;
		}

		// Token: 0x06026218 RID: 156184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026218")]
		[Address(RVA = "0x2143DB0", Offset = "0x21429B0", VA = "0x182143DB0")]
		public ZoneHomeClimbTowerToDoModel()
		{
		}

		// Token: 0x04035B32 RID: 219954
		[Token(Token = "0x4035B32")]
		[FieldOffset(Offset = "0x38")]
		public ZoneHomeClimbTowerToDoModel.ClimbTowerModel towerModel;

		// Token: 0x04035B33 RID: 219955
		[Token(Token = "0x4035B33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035B34 RID: 219956
		[Token(Token = "0x4035B34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadTowerModel;

		// Token: 0x04035B35 RID: 219957
		[Token(Token = "0x4035B35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryLoadCurrentModel;

		// Token: 0x04035B36 RID: 219958
		[Token(Token = "0x4035B36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryLoadOfferModel;

		// Token: 0x04035B37 RID: 219959
		[Token(Token = "0x4035B37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020067EB RID: 26603
		[Token(Token = "0x20067EB")]
		public class FeeModel
		{
			// Token: 0x06026219 RID: 156185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026219")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FeeModel()
			{
			}

			// Token: 0x04035B38 RID: 219960
			[Token(Token = "0x4035B38")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x04035B39 RID: 219961
			[Token(Token = "0x4035B39")]
			[FieldOffset(Offset = "0x18")]
			public int currentNum;

			// Token: 0x04035B3A RID: 219962
			[Token(Token = "0x4035B3A")]
			[FieldOffset(Offset = "0x1C")]
			public int totalNum;

			// Token: 0x04035B3B RID: 219963
			[Token(Token = "0x4035B3B")]
			[FieldOffset(Offset = "0x20")]
			public float progress;

			// Token: 0x04035B3C RID: 219964
			[Token(Token = "0x4035B3C")]
			[FieldOffset(Offset = "0x28")]
			public string itemName;
		}

		// Token: 0x020067EC RID: 26604
		[Token(Token = "0x20067EC")]
		public class ClimbTowerModel
		{
			// Token: 0x0602621A RID: 156186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602621A")]
			[Address(RVA = "0x2130CA0", Offset = "0x212F8A0", VA = "0x182130CA0")]
			public ClimbTowerModel()
			{
			}

			// Token: 0x04035B3D RID: 219965
			[Token(Token = "0x4035B3D")]
			[FieldOffset(Offset = "0x10")]
			public string seasonId;

			// Token: 0x04035B3E RID: 219966
			[Token(Token = "0x4035B3E")]
			[FieldOffset(Offset = "0x18")]
			public string towerId;

			// Token: 0x04035B3F RID: 219967
			[Token(Token = "0x4035B3F")]
			[FieldOffset(Offset = "0x20")]
			public bool isInBattle;

			// Token: 0x04035B40 RID: 219968
			[Token(Token = "0x4035B40")]
			[FieldOffset(Offset = "0x28")]
			public string towerName;

			// Token: 0x04035B41 RID: 219969
			[Token(Token = "0x4035B41")]
			[FieldOffset(Offset = "0x30")]
			public bool isHardBattle;

			// Token: 0x04035B42 RID: 219970
			[Token(Token = "0x4035B42")]
			[FieldOffset(Offset = "0x38")]
			public ZoneHomeClimbTowerToDoModel.FeeModel lowerItem;

			// Token: 0x04035B43 RID: 219971
			[Token(Token = "0x4035B43")]
			[FieldOffset(Offset = "0x40")]
			public ZoneHomeClimbTowerToDoModel.FeeModel higherItem;
		}
	}
}
