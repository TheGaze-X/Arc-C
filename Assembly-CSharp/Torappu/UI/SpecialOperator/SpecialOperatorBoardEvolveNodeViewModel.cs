using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E93 RID: 16019
	[Token(Token = "0x2003E93")]
	public class SpecialOperatorBoardEvolveNodeViewModel : SpecialOperatorBoardNodeBase, ISpecialOperatorBoardEvolveItemViewModel
	{
		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x06018E08 RID: 101896 RVA: 0x0009C468 File Offset: 0x0009A668
		[Token(Token = "0x17003B5C")]
		public override bool isUnlocked
		{
			[Token(Token = "0x6018E08")]
			[Address(RVA = "0x1186C60", Offset = "0x1185860", VA = "0x181186C60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x06018E09 RID: 101897 RVA: 0x0009C480 File Offset: 0x0009A680
		// (set) Token: 0x06018E0A RID: 101898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B5D")]
		public override bool unlockTaskMeet
		{
			[Token(Token = "0x6018E09")]
			[Address(RVA = "0x1186CC0", Offset = "0x11858C0", VA = "0x181186CC0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018E0A")]
			[Address(RVA = "0x1186D90", Offset = "0x1185990", VA = "0x181186D90", Slot = "8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x06018E0B RID: 101899 RVA: 0x0009C498 File Offset: 0x0009A698
		// (set) Token: 0x06018E0C RID: 101900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B5E")]
		public override bool evolveLevelMeet
		{
			[Token(Token = "0x6018E0B")]
			[Address(RVA = "0x1186C00", Offset = "0x1185800", VA = "0x181186C00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018E0C")]
			[Address(RVA = "0x1186D20", Offset = "0x1185920", VA = "0x181186D20", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06018E0D RID: 101901 RVA: 0x0009C4B0 File Offset: 0x0009A6B0
		[Token(Token = "0x6018E0D")]
		[Address(RVA = "0x1186730", Offset = "0x1185330", VA = "0x181186730", Slot = "13")]
		public SpecialOperatorBoardEvolveItemType GetItemType()
		{
			return SpecialOperatorBoardEvolveItemType.LINE;
		}

		// Token: 0x06018E0E RID: 101902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E0E")]
		[Address(RVA = "0x1186790", Offset = "0x1185390", VA = "0x181186790", Slot = "9")]
		protected override void OnInitData()
		{
		}

		// Token: 0x06018E0F RID: 101903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E0F")]
		[Address(RVA = "0x1186910", Offset = "0x1185510", VA = "0x181186910", Slot = "10")]
		public override void RefreshData(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06018E10 RID: 101904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E10")]
		[Address(RVA = "0x1186BA0", Offset = "0x11857A0", VA = "0x181186BA0")]
		public SpecialOperatorBoardEvolveNodeViewModel()
		{
		}

		// Token: 0x0401EA63 RID: 125539
		[Token(Token = "0x401EA63")]
		[FieldOffset(Offset = "0x40")]
		public bool m_isUnlocked;

		// Token: 0x0401EA64 RID: 125540
		[Token(Token = "0x401EA64")]
		[FieldOffset(Offset = "0x44")]
		public EvolvePhase toEvolvePhase;

		// Token: 0x0401EA65 RID: 125541
		[Token(Token = "0x401EA65")]
		[FieldOffset(Offset = "0x48")]
		public int toLevelMax;

		// Token: 0x0401EA66 RID: 125542
		[Token(Token = "0x401EA66")]
		[FieldOffset(Offset = "0x4C")]
		public EvolvePhase curEvolvePhase;

		// Token: 0x0401EA67 RID: 125543
		[Token(Token = "0x401EA67")]
		[FieldOffset(Offset = "0x50")]
		public int curLevel;

		// Token: 0x0401EA68 RID: 125544
		[Token(Token = "0x401EA68")]
		[FieldOffset(Offset = "0x54")]
		public EvolvePhase unlockEvolvePhase;

		// Token: 0x0401EA69 RID: 125545
		[Token(Token = "0x401EA69")]
		[FieldOffset(Offset = "0x58")]
		public int unlockLevel;

		// Token: 0x0401EA6A RID: 125546
		[Token(Token = "0x401EA6A")]
		[FieldOffset(Offset = "0x60")]
		public string unlockTaskId;

		// Token: 0x0401EA6B RID: 125547
		[Token(Token = "0x401EA6B")]
		[FieldOffset(Offset = "0x68")]
		public string unlockCondDesc;

		// Token: 0x0401EA6C RID: 125548
		[Token(Token = "0x401EA6C")]
		[FieldOffset(Offset = "0x70")]
		public SpecialOperatorConditionViewType unlockCondType;

		// Token: 0x0401EA6D RID: 125549
		[Token(Token = "0x401EA6D")]
		[FieldOffset(Offset = "0x74")]
		public int unlockTaskProgress;

		// Token: 0x0401EA6E RID: 125550
		[Token(Token = "0x401EA6E")]
		[FieldOffset(Offset = "0x78")]
		public int unlockTaskTarget;

		// Token: 0x0401EA6F RID: 125551
		[Token(Token = "0x401EA6F")]
		[FieldOffset(Offset = "0x80")]
		public List<SpecialOperatorBoardEvolveNodeViewModel.Feature> features;

		// Token: 0x0401EA72 RID: 125554
		[Token(Token = "0x401EA72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isUnlocked;

		// Token: 0x0401EA73 RID: 125555
		[Token(Token = "0x401EA73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_unlockTaskMeet;

		// Token: 0x0401EA74 RID: 125556
		[Token(Token = "0x401EA74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_unlockTaskMeet;

		// Token: 0x0401EA75 RID: 125557
		[Token(Token = "0x401EA75")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_evolveLevelMeet;

		// Token: 0x0401EA76 RID: 125558
		[Token(Token = "0x401EA76")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_evolveLevelMeet;

		// Token: 0x0401EA77 RID: 125559
		[Token(Token = "0x401EA77")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetItemType;

		// Token: 0x0401EA78 RID: 125560
		[Token(Token = "0x401EA78")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInitData;

		// Token: 0x0401EA79 RID: 125561
		[Token(Token = "0x401EA79")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401EA7A RID: 125562
		[Token(Token = "0x401EA7A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E94 RID: 16020
		[Token(Token = "0x2003E94")]
		public enum MissionState
		{
			// Token: 0x0401EA7C RID: 125564
			[Token(Token = "0x401EA7C")]
			LOCK,
			// Token: 0x0401EA7D RID: 125565
			[Token(Token = "0x401EA7D")]
			CAN_SUBMIT,
			// Token: 0x0401EA7E RID: 125566
			[Token(Token = "0x401EA7E")]
			UNLOCK
		}

		// Token: 0x02003E95 RID: 16021
		[Token(Token = "0x2003E95")]
		public enum FeatureType
		{
			// Token: 0x0401EA80 RID: 125568
			[Token(Token = "0x401EA80")]
			BASIC,
			// Token: 0x0401EA81 RID: 125569
			[Token(Token = "0x401EA81")]
			ADDTIONAL_DESC_FEATURE,
			// Token: 0x0401EA82 RID: 125570
			[Token(Token = "0x401EA82")]
			RANGE_FEATURE
		}

		// Token: 0x02003E96 RID: 16022
		[Token(Token = "0x2003E96")]
		public class Feature
		{
			// Token: 0x06018E11 RID: 101905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018E11")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Feature()
			{
			}

			// Token: 0x0401EA83 RID: 125571
			[Token(Token = "0x401EA83")]
			[FieldOffset(Offset = "0x10")]
			public SpecialOperatorBoardEvolveNodeViewModel.FeatureType type;

			// Token: 0x0401EA84 RID: 125572
			[Token(Token = "0x401EA84")]
			[FieldOffset(Offset = "0x18")]
			public string desc;

			// Token: 0x0401EA85 RID: 125573
			[Token(Token = "0x401EA85")]
			[FieldOffset(Offset = "0x20")]
			public string prevRangeId;

			// Token: 0x0401EA86 RID: 125574
			[Token(Token = "0x401EA86")]
			[FieldOffset(Offset = "0x28")]
			public string rangeId;
		}
	}
}
