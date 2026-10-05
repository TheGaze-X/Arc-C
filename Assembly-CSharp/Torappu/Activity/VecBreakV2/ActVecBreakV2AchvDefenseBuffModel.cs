using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DC5 RID: 28101
	[Token(Token = "0x2006DC5")]
	public class ActVecBreakV2AchvDefenseBuffModel : IHotfixable
	{
		// Token: 0x17005E9D RID: 24221
		// (get) Token: 0x0602803F RID: 163903 RVA: 0x000D0638 File Offset: 0x000CE838
		// (set) Token: 0x06028040 RID: 163904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E9D")]
		public ActVecBreakV2AchvDefenseBuffModel.BuffState buffState
		{
			[Token(Token = "0x602803F")]
			[Address(RVA = "0x2344C50", Offset = "0x2343850", VA = "0x182344C50")]
			[CompilerGenerated]
			get
			{
				return ActVecBreakV2AchvDefenseBuffModel.BuffState.NONE;
			}
			[Token(Token = "0x6028040")]
			[Address(RVA = "0x2344E10", Offset = "0x2343A10", VA = "0x182344E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E9E RID: 24222
		// (get) Token: 0x06028041 RID: 163905 RVA: 0x000D0650 File Offset: 0x000CE850
		// (set) Token: 0x06028042 RID: 163906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E9E")]
		public int sortId
		{
			[Token(Token = "0x6028041")]
			[Address(RVA = "0x2344CB0", Offset = "0x23438B0", VA = "0x182344CB0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028042")]
			[Address(RVA = "0x2344E80", Offset = "0x2343A80", VA = "0x182344E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E9F RID: 24223
		// (get) Token: 0x06028043 RID: 163907 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028044 RID: 163908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E9F")]
		public string buffId
		{
			[Token(Token = "0x6028043")]
			[Address(RVA = "0x2344BF0", Offset = "0x23437F0", VA = "0x182344BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028044")]
			[Address(RVA = "0x2344D90", Offset = "0x2343990", VA = "0x182344D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005EA0 RID: 24224
		// (get) Token: 0x06028045 RID: 163909 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028046 RID: 163910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EA0")]
		public string buffIconId
		{
			[Token(Token = "0x6028045")]
			[Address(RVA = "0x2344B90", Offset = "0x2343790", VA = "0x182344B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028046")]
			[Address(RVA = "0x2344D10", Offset = "0x2343910", VA = "0x182344D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028047 RID: 163911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028047")]
		[Address(RVA = "0x2344720", Offset = "0x2343320", VA = "0x182344720")]
		public void LoadData(string stageId, long currTs, ActVecBreakV2DefenseBasicData defenseData, ActVecBreakV2Data actData, VecBreakV2StageInfo stageInfo)
		{
		}

		// Token: 0x06028048 RID: 163912 RVA: 0x000D0668 File Offset: 0x000CE868
		[Token(Token = "0x6028048")]
		[Address(RVA = "0x2344A60", Offset = "0x2343660", VA = "0x182344A60")]
		private ActVecBreakV2AchvDefenseBuffModel.BuffState _CalcBuffState(ActVecBreakV2DefenseBasicData defenseData, ActVecBreakV2DefenseDetailData detailData, VecBreakV2StageInfo stageInfo, long currTs)
		{
			return ActVecBreakV2AchvDefenseBuffModel.BuffState.NONE;
		}

		// Token: 0x06028049 RID: 163913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028049")]
		[Address(RVA = "0x2344B30", Offset = "0x2343730", VA = "0x182344B30")]
		public ActVecBreakV2AchvDefenseBuffModel()
		{
		}

		// Token: 0x04038BC9 RID: 232393
		[Token(Token = "0x4038BC9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffState;

		// Token: 0x04038BCA RID: 232394
		[Token(Token = "0x4038BCA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_buffState;

		// Token: 0x04038BCB RID: 232395
		[Token(Token = "0x4038BCB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04038BCC RID: 232396
		[Token(Token = "0x4038BCC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x04038BCD RID: 232397
		[Token(Token = "0x4038BCD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_buffId;

		// Token: 0x04038BCE RID: 232398
		[Token(Token = "0x4038BCE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_buffId;

		// Token: 0x04038BCF RID: 232399
		[Token(Token = "0x4038BCF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_buffIconId;

		// Token: 0x04038BD0 RID: 232400
		[Token(Token = "0x4038BD0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_buffIconId;

		// Token: 0x04038BD1 RID: 232401
		[Token(Token = "0x4038BD1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038BD2 RID: 232402
		[Token(Token = "0x4038BD2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CalcBuffState;

		// Token: 0x04038BD3 RID: 232403
		[Token(Token = "0x4038BD3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006DC6 RID: 28102
		[Token(Token = "0x2006DC6")]
		public enum BuffState
		{
			// Token: 0x04038BD5 RID: 232405
			[Token(Token = "0x4038BD5")]
			NONE,
			// Token: 0x04038BD6 RID: 232406
			[Token(Token = "0x4038BD6")]
			CLOSED,
			// Token: 0x04038BD7 RID: 232407
			[Token(Token = "0x4038BD7")]
			OPEN,
			// Token: 0x04038BD8 RID: 232408
			[Token(Token = "0x4038BD8")]
			COMPLETE
		}
	}
}
