using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002521 RID: 9505
	[Token(Token = "0x2002521")]
	[RequireComponent(typeof(Range))]
	public abstract class RangeSelector : TargetSelector
	{
		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x0600F554 RID: 62804
		[Token(Token = "0x1700200C")]
		public abstract SideType targetSide { [Token(Token = "0x600F554")] get; }

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x0600F555 RID: 62805
		[Token(Token = "0x1700200D")]
		public abstract MotionMask targetMotion { [Token(Token = "0x600F555")] get; }

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x0600F556 RID: 62806
		[Token(Token = "0x1700200E")]
		public abstract EntityCategory targetCategory { [Token(Token = "0x600F556")] get; }

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x0600F557 RID: 62807
		[Token(Token = "0x1700200F")]
		public abstract bool ignoreTargetFree { [Token(Token = "0x600F557")] get; }

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x0600F558 RID: 62808 RVA: 0x0005B1A0 File Offset: 0x000593A0
		[Token(Token = "0x17002010")]
		protected virtual bool ignoreAllyTargetFree
		{
			[Token(Token = "0x600F558")]
			[Address(RVA = "0x6D9530", Offset = "0x6D8130", VA = "0x1806D9530", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x0600F559 RID: 62809 RVA: 0x0005B1B8 File Offset: 0x000593B8
		[Token(Token = "0x17002011")]
		protected virtual bool ignoreHealFree
		{
			[Token(Token = "0x600F559")]
			[Address(RVA = "0x6D9590", Offset = "0x6D8190", VA = "0x1806D9590", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x0600F55A RID: 62810 RVA: 0x0005B1D0 File Offset: 0x000593D0
		[Token(Token = "0x17002012")]
		protected virtual bool onlyIgnoreSomeOfTargetFreeCase
		{
			[Token(Token = "0x600F55A")]
			[Address(RVA = "0x6D95F0", Offset = "0x6D81F0", VA = "0x1806D95F0", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x0600F55B RID: 62811 RVA: 0x0005B1E8 File Offset: 0x000593E8
		[Token(Token = "0x17002013")]
		protected virtual AbnormalFlag abnormalFlag
		{
			[Token(Token = "0x600F55B")]
			[Address(RVA = "0x6D9470", Offset = "0x6D8070", VA = "0x1806D9470", Slot = "32")]
			get
			{
				return AbnormalFlag.STUNNED;
			}
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x0600F55C RID: 62812 RVA: 0x0005B200 File Offset: 0x00059400
		[Token(Token = "0x17002014")]
		protected virtual AbnormalCombo abnormalCombo
		{
			[Token(Token = "0x600F55C")]
			[Address(RVA = "0x6D9410", Offset = "0x6D8010", VA = "0x1806D9410", Slot = "33")]
			get
			{
				return AbnormalCombo.SLEEPING;
			}
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x0600F55D RID: 62813 RVA: 0x0005B218 File Offset: 0x00059418
		[Token(Token = "0x17002015")]
		protected virtual ProfessionCategory professionMask
		{
			[Token(Token = "0x600F55D")]
			[Address(RVA = "0x6D9650", Offset = "0x6D8250", VA = "0x1806D9650", Slot = "34")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x0600F55E RID: 62814 RVA: 0x0005B230 File Offset: 0x00059430
		[Token(Token = "0x17002016")]
		protected virtual bool checkUnitType
		{
			[Token(Token = "0x600F55E")]
			[Address(RVA = "0x6D94D0", Offset = "0x6D80D0", VA = "0x1806D94D0", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x0600F55F RID: 62815 RVA: 0x0005B248 File Offset: 0x00059448
		[Token(Token = "0x17002017")]
		protected virtual UnitTypeMask unitTypeMask
		{
			[Token(Token = "0x600F55F")]
			[Address(RVA = "0x6D98B0", Offset = "0x6D84B0", VA = "0x1806D98B0", Slot = "36")]
			get
			{
				return UnitTypeMask.NONE;
			}
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x0600F560 RID: 62816 RVA: 0x0005B260 File Offset: 0x00059460
		[Token(Token = "0x17002018")]
		public TargetOptions targetOptions
		{
			[Token(Token = "0x600F560")]
			[Address(RVA = "0x6D97E0", Offset = "0x6D83E0", VA = "0x1806D97E0")]
			get
			{
				return default(TargetOptions);
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x0600F561 RID: 62817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002019")]
		public Range range
		{
			[Token(Token = "0x600F561")]
			[Address(RVA = "0x6D96B0", Offset = "0x6D82B0", VA = "0x1806D96B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x0600F562 RID: 62818 RVA: 0x0005B278 File Offset: 0x00059478
		[Token(Token = "0x1700201A")]
		protected override ActionPurposeMask sourcePurposeMask
		{
			[Token(Token = "0x600F562")]
			[Address(RVA = "0x6D9710", Offset = "0x6D8310", VA = "0x1806D9710", Slot = "11")]
			get
			{
				return ActionPurposeMask.NONE;
			}
		}

		// Token: 0x0600F563 RID: 62819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F563")]
		[Address(RVA = "0x6D8B80", Offset = "0x6D7780", VA = "0x1806D8B80", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F564 RID: 62820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F564")]
		[Address(RVA = "0x6D8A80", Offset = "0x6D7680", VA = "0x1806D8A80", Slot = "24")]
		public override void OnAbilityExtendUpdated(FP extend)
		{
		}

		// Token: 0x0600F565 RID: 62821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F565")]
		[Address(RVA = "0x6D86D0", Offset = "0x6D72D0", VA = "0x1806D86D0", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F566 RID: 62822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F566")]
		[Address(RVA = "0x6D8940", Offset = "0x6D7540", VA = "0x1806D8940", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F567 RID: 62823 RVA: 0x0005B290 File Offset: 0x00059490
		[Token(Token = "0x600F567")]
		[Address(RVA = "0x6D8630", Offset = "0x6D7230", VA = "0x1806D8630", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F568 RID: 62824 RVA: 0x0005B2A8 File Offset: 0x000594A8
		[Token(Token = "0x600F568")]
		[Address(RVA = "0x6D8580", Offset = "0x6D7180", VA = "0x1806D8580", Slot = "15")]
		public override bool CheckTargetInOriginRange(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F569 RID: 62825 RVA: 0x0005B2C0 File Offset: 0x000594C0
		[Token(Token = "0x600F569")]
		[Address(RVA = "0x6D1E70", Offset = "0x6D0A70", VA = "0x1806D1E70", Slot = "18")]
		public override bool VerifyTarget(List<Entity> candidates)
		{
			return default(bool);
		}

		// Token: 0x0600F56A RID: 62826
		[Token(Token = "0x600F56A")]
		protected abstract void OnPostFilter(List<Entity> candidates);

		// Token: 0x0600F56B RID: 62827
		[Token(Token = "0x600F56B")]
		protected abstract void OnPostFilter(List<Tile> candidates);

		// Token: 0x0600F56C RID: 62828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F56C")]
		[Address(RVA = "0x6D8500", Offset = "0x6D7100", VA = "0x1806D8500", Slot = "39")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600F56D RID: 62829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F56D")]
		[Address(RVA = "0x6D9310", Offset = "0x6D7F10", VA = "0x1806D9310")]
		protected RangeSelector()
		{
		}

		// Token: 0x0600F56E RID: 62830 RVA: 0x0005B2D8 File Offset: 0x000594D8
		[Token(Token = "0x600F56E")]
		[Address(RVA = "0x6D92B0", Offset = "0x6D7EB0", VA = "0x1806D92B0")]
		private ActionPurposeMask <>xLuaBaseProxy_get_sourcePurposeMask()
		{
			return ActionPurposeMask.NONE;
		}

		// Token: 0x0600F56F RID: 62831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F56F")]
		[Address(RVA = "0x6B8B20", Offset = "0x6B7720", VA = "0x1806B8B20")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F570 RID: 62832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F570")]
		[Address(RVA = "0x6D9240", Offset = "0x6D7E40", VA = "0x1806D9240")]
		private void <>xLuaBaseProxy_OnAbilityExtendUpdated(FP P0)
		{
		}

		// Token: 0x0600F571 RID: 62833 RVA: 0x0005B2F0 File Offset: 0x000594F0
		[Token(Token = "0x600F571")]
		[Address(RVA = "0x6D91B0", Offset = "0x6D7DB0", VA = "0x1806D91B0")]
		private bool <>xLuaBaseProxy_CheckTargetInOriginRange(ILocatable P0)
		{
			return default(bool);
		}

		// Token: 0x0600F572 RID: 62834 RVA: 0x0005B308 File Offset: 0x00059508
		[Token(Token = "0x600F572")]
		[Address(RVA = "0x6D92A0", Offset = "0x6D7EA0", VA = "0x1806D92A0")]
		private bool <>xLuaBaseProxy_VerifyTarget(List<Entity> P0)
		{
			return default(bool);
		}

		// Token: 0x04010FFA RID: 69626
		[Token(Token = "0x4010FFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Range m_range;

		// Token: 0x04010FFB RID: 69627
		[Token(Token = "0x4010FFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected TargetOptions m_targetOptions;

		// Token: 0x04010FFC RID: 69628
		[Token(Token = "0x4010FFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected List<int> m_ExtraLogIds;

		// Token: 0x04010FFD RID: 69629
		[Token(Token = "0x4010FFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ignoreAllyTargetFree;

		// Token: 0x04010FFE RID: 69630
		[Token(Token = "0x4010FFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_ignoreHealFree;

		// Token: 0x04010FFF RID: 69631
		[Token(Token = "0x4010FFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onlyIgnoreSomeOfTargetFreeCase;

		// Token: 0x04011000 RID: 69632
		[Token(Token = "0x4011000")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_abnormalFlag;

		// Token: 0x04011001 RID: 69633
		[Token(Token = "0x4011001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_abnormalCombo;

		// Token: 0x04011002 RID: 69634
		[Token(Token = "0x4011002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_professionMask;

		// Token: 0x04011003 RID: 69635
		[Token(Token = "0x4011003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_checkUnitType;

		// Token: 0x04011004 RID: 69636
		[Token(Token = "0x4011004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_unitTypeMask;

		// Token: 0x04011005 RID: 69637
		[Token(Token = "0x4011005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_targetOptions;

		// Token: 0x04011006 RID: 69638
		[Token(Token = "0x4011006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_range;

		// Token: 0x04011007 RID: 69639
		[Token(Token = "0x4011007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_sourcePurposeMask;

		// Token: 0x04011008 RID: 69640
		[Token(Token = "0x4011008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011009 RID: 69641
		[Token(Token = "0x4011009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnAbilityExtendUpdated;

		// Token: 0x0401100A RID: 69642
		[Token(Token = "0x401100A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x0401100B RID: 69643
		[Token(Token = "0x401100B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x0401100C RID: 69644
		[Token(Token = "0x401100C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x0401100D RID: 69645
		[Token(Token = "0x401100D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckTargetInOriginRange;

		// Token: 0x0401100E RID: 69646
		[Token(Token = "0x401100E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_VerifyTarget;

		// Token: 0x0401100F RID: 69647
		[Token(Token = "0x401100F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04011010 RID: 69648
		[Token(Token = "0x4011010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
