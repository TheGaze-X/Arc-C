using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061B3 RID: 25011
	[Token(Token = "0x20061B3")]
	public class BossRushStageChooseItemModel : IHotfixable
	{
		// Token: 0x17005526 RID: 21798
		// (get) Token: 0x06024176 RID: 147830 RVA: 0x000C31B0 File Offset: 0x000C13B0
		[Token(Token = "0x17005526")]
		public bool isStageGroupComplete
		{
			[Token(Token = "0x6024176")]
			[Address(RVA = "0x1EC3770", Offset = "0x1EC2370", VA = "0x181EC3770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005527 RID: 21799
		// (get) Token: 0x06024177 RID: 147831 RVA: 0x000C31C8 File Offset: 0x000C13C8
		[Token(Token = "0x17005527")]
		public bool isNormalStageComplete
		{
			[Token(Token = "0x6024177")]
			[Address(RVA = "0x1EC3670", Offset = "0x1EC2270", VA = "0x181EC3670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005528 RID: 21800
		// (get) Token: 0x06024178 RID: 147832 RVA: 0x000C31E0 File Offset: 0x000C13E0
		[Token(Token = "0x17005528")]
		public bool isSpComplete
		{
			[Token(Token = "0x6024178")]
			[Address(RVA = "0x1EC36F0", Offset = "0x1EC22F0", VA = "0x181EC36F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005529 RID: 21801
		// (get) Token: 0x06024179 RID: 147833 RVA: 0x000C31F8 File Offset: 0x000C13F8
		[Token(Token = "0x17005529")]
		public int completeStageCount
		{
			[Token(Token = "0x6024179")]
			[Address(RVA = "0x1EC3600", Offset = "0x1EC2200", VA = "0x181EC3600")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602417A RID: 147834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602417A")]
		[Address(RVA = "0x1EC31D0", Offset = "0x1EC1DD0", VA = "0x181EC31D0")]
		public void LoadData(ActivityBossRushData.BossRushStageGroupData data)
		{
		}

		// Token: 0x0602417B RID: 147835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602417B")]
		[Address(RVA = "0x1EC32F0", Offset = "0x1EC1EF0", VA = "0x181EC32F0")]
		private void _UpdateStageGroupStatus()
		{
		}

		// Token: 0x0602417C RID: 147836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602417C")]
		[Address(RVA = "0x1EC3550", Offset = "0x1EC2150", VA = "0x181EC3550")]
		public BossRushStageChooseItemModel()
		{
		}

		// Token: 0x04032281 RID: 205441
		[Token(Token = "0x4032281")]
		[FieldOffset(Offset = "0x10")]
		public string stageGroupId;

		// Token: 0x04032282 RID: 205442
		[Token(Token = "0x4032282")]
		[FieldOffset(Offset = "0x18")]
		public string stageGroupName;

		// Token: 0x04032283 RID: 205443
		[Token(Token = "0x4032283")]
		[FieldOffset(Offset = "0x20")]
		public string stageUnlockCond;

		// Token: 0x04032284 RID: 205444
		[Token(Token = "0x4032284")]
		[FieldOffset(Offset = "0x28")]
		public bool isLocked;

		// Token: 0x04032285 RID: 205445
		[Token(Token = "0x4032285")]
		[FieldOffset(Offset = "0x2C")]
		public int sortId;

		// Token: 0x04032286 RID: 205446
		[Token(Token = "0x4032286")]
		[FieldOffset(Offset = "0x30")]
		public bool isHardStage;

		// Token: 0x04032287 RID: 205447
		[Token(Token = "0x4032287")]
		[FieldOffset(Offset = "0x34")]
		public int normalStageCount;

		// Token: 0x04032288 RID: 205448
		[Token(Token = "0x4032288")]
		[FieldOffset(Offset = "0x38")]
		public int waveCount;

		// Token: 0x04032289 RID: 205449
		[Token(Token = "0x4032289")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<ActivityBossRushData.BossRushStageType, string> m_stageIdMap;

		// Token: 0x0403228A RID: 205450
		[Token(Token = "0x403228A")]
		[FieldOffset(Offset = "0x48")]
		private HashSet<ActivityBossRushData.BossRushStageType> m_completeStageSet;

		// Token: 0x0403228B RID: 205451
		[Token(Token = "0x403228B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isStageGroupComplete;

		// Token: 0x0403228C RID: 205452
		[Token(Token = "0x403228C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isNormalStageComplete;

		// Token: 0x0403228D RID: 205453
		[Token(Token = "0x403228D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isSpComplete;

		// Token: 0x0403228E RID: 205454
		[Token(Token = "0x403228E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_completeStageCount;

		// Token: 0x0403228F RID: 205455
		[Token(Token = "0x403228F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032290 RID: 205456
		[Token(Token = "0x4032290")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateStageGroupStatus;

		// Token: 0x04032291 RID: 205457
		[Token(Token = "0x4032291")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
