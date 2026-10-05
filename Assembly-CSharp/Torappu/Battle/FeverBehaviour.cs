using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200244B RID: 9291
	[Token(Token = "0x200244B")]
	public abstract class FeverBehaviour : BasicSkill.Behaviour, Attributes.IAttributesModifier
	{
		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x0600EE37 RID: 60983 RVA: 0x00057588 File Offset: 0x00055788
		[Token(Token = "0x17001EDB")]
		public bool needDisplayFeverCast
		{
			[Token(Token = "0x600EE37")]
			[Address(RVA = "0x649480", Offset = "0x648080", VA = "0x180649480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x0600EE38 RID: 60984 RVA: 0x000575A0 File Offset: 0x000557A0
		[Token(Token = "0x17001EDC")]
		public bool isSelfInFever
		{
			[Token(Token = "0x600EE38")]
			[Address(RVA = "0x649420", Offset = "0x648020", VA = "0x180649420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x0600EE39 RID: 60985 RVA: 0x000575B8 File Offset: 0x000557B8
		[Token(Token = "0x17001EDD")]
		protected virtual bool needInFever
		{
			[Token(Token = "0x600EE39")]
			[Address(RVA = "0x649550", Offset = "0x648150", VA = "0x180649550", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x0600EE3A RID: 60986 RVA: 0x000575D0 File Offset: 0x000557D0
		[Token(Token = "0x17001EDE")]
		protected virtual bool isDirectlyJoinFeverTypeSkill
		{
			[Token(Token = "0x600EE3A")]
			[Address(RVA = "0x6493C0", Offset = "0x647FC0", VA = "0x1806493C0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x0600EE3B RID: 60987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001EDF")]
		protected FeverSystemManager feverManager
		{
			[Token(Token = "0x600EE3B")]
			[Address(RVA = "0x6492F0", Offset = "0x647EF0", VA = "0x1806492F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EE3C RID: 60988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE3C")]
		[Address(RVA = "0x647980", Offset = "0x646580", VA = "0x180647980", Slot = "5")]
		public override void AssignData(Blackboard blackboard)
		{
		}

		// Token: 0x0600EE3D RID: 60989 RVA: 0x000575E8 File Offset: 0x000557E8
		[Token(Token = "0x600EE3D")]
		[Address(RVA = "0x648850", Offset = "0x647450", VA = "0x180648850")]
		private FeverBehaviour.FeverResult _JoinFeverDuringSkill()
		{
			return default(FeverBehaviour.FeverResult);
		}

		// Token: 0x0600EE3E RID: 60990 RVA: 0x00057600 File Offset: 0x00055800
		[Token(Token = "0x600EE3E")]
		[Address(RVA = "0x648A70", Offset = "0x647670", VA = "0x180648A70")]
		private FeverBehaviour.FeverResult _JoinFever()
		{
			return default(FeverBehaviour.FeverResult);
		}

		// Token: 0x0600EE3F RID: 60991 RVA: 0x00057618 File Offset: 0x00055818
		[Token(Token = "0x600EE3F")]
		[Address(RVA = "0x648DD0", Offset = "0x6479D0", VA = "0x180648DD0")]
		private FeverBehaviour.FeverResult _LeaveFever()
		{
			return default(FeverBehaviour.FeverResult);
		}

		// Token: 0x0600EE40 RID: 60992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE40")]
		[Address(RVA = "0x6480D0", Offset = "0x646CD0", VA = "0x1806480D0", Slot = "12")]
		public override void OnOwnerFinish()
		{
		}

		// Token: 0x0600EE41 RID: 60993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE41")]
		[Address(RVA = "0x648190", Offset = "0x646D90", VA = "0x180648190", Slot = "10")]
		public override void OnSkillEnd()
		{
		}

		// Token: 0x0600EE42 RID: 60994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE42")]
		[Address(RVA = "0x648240", Offset = "0x646E40", VA = "0x180648240", Slot = "14")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EE43 RID: 60995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE43")]
		[Address(RVA = "0x647DE0", Offset = "0x6469E0", VA = "0x180647DE0", Slot = "6")]
		public override void OnCastSucceed()
		{
		}

		// Token: 0x0600EE44 RID: 60996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE44")]
		[Address(RVA = "0x647CD0", Offset = "0x6468D0", VA = "0x180647CD0", Slot = "7")]
		public override void OnCastFailed()
		{
		}

		// Token: 0x0600EE45 RID: 60997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE45")]
		[Address(RVA = "0x648570", Offset = "0x647170", VA = "0x180648570")]
		private void _CheckJoinFeverOrTickUseSkill()
		{
		}

		// Token: 0x0600EE46 RID: 60998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE46")]
		[Address(RVA = "0x648D20", Offset = "0x647920", VA = "0x180648D20")]
		private void _LeaveFeverIfNecessary()
		{
		}

		// Token: 0x0600EE47 RID: 60999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE47")]
		[Address(RVA = "0x647C10", Offset = "0x646810", VA = "0x180647C10", Slot = "25")]
		protected virtual void OnBeforeJoinFever(bool isJoinDuringSkill)
		{
		}

		// Token: 0x0600EE48 RID: 61000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE48")]
		[Address(RVA = "0x648070", Offset = "0x646C70", VA = "0x180648070", Slot = "26")]
		protected virtual void OnJoinFeverFail(bool isJoinDuringSkill)
		{
		}

		// Token: 0x0600EE49 RID: 61001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE49")]
		[Address(RVA = "0x647B50", Offset = "0x646750", VA = "0x180647B50", Slot = "27")]
		protected virtual void OnAfterJoinFever(bool isJoinDuringSkill)
		{
		}

		// Token: 0x0600EE4A RID: 61002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE4A")]
		[Address(RVA = "0x647C70", Offset = "0x646870", VA = "0x180647C70", Slot = "28")]
		protected virtual void OnBeforeLeaveFever(bool isJoinDuringSkill)
		{
		}

		// Token: 0x0600EE4B RID: 61003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE4B")]
		[Address(RVA = "0x647BB0", Offset = "0x6467B0", VA = "0x180647BB0", Slot = "29")]
		protected virtual void OnAfterLeaveFever(bool isJoinDuringSkill)
		{
		}

		// Token: 0x0600EE4C RID: 61004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE4C")]
		[Address(RVA = "0x648330", Offset = "0x646F30", VA = "0x180648330")]
		protected void UseSkillByFeverLogic()
		{
		}

		// Token: 0x0600EE4D RID: 61005 RVA: 0x00057630 File Offset: 0x00055830
		[Token(Token = "0x600EE4D")]
		[Address(RVA = "0x648740", Offset = "0x647340", VA = "0x180648740")]
		private bool _IsDuringSkill()
		{
			return default(bool);
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x0600EE4E RID: 61006 RVA: 0x00057648 File Offset: 0x00055848
		[Token(Token = "0x17001EE0")]
		public long attributeMask
		{
			[Token(Token = "0x600EE4E")]
			[Address(RVA = "0x649290", Offset = "0x647E90", VA = "0x180649290", Slot = "16")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x0600EE4F RID: 61007 RVA: 0x00057660 File Offset: 0x00055860
		[Token(Token = "0x17001EE1")]
		public long abnormalFlagMask
		{
			[Token(Token = "0x600EE4F")]
			[Address(RVA = "0x6491D0", Offset = "0x647DD0", VA = "0x1806491D0", Slot = "17")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x0600EE50 RID: 61008 RVA: 0x00057678 File Offset: 0x00055878
		[Token(Token = "0x17001EE2")]
		public long abnormalImmuneMask
		{
			[Token(Token = "0x600EE50")]
			[Address(RVA = "0x649230", Offset = "0x647E30", VA = "0x180649230", Slot = "18")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x0600EE51 RID: 61009 RVA: 0x00057690 File Offset: 0x00055890
		[Token(Token = "0x17001EE3")]
		public long abnormalAntiMask
		{
			[Token(Token = "0x600EE51")]
			[Address(RVA = "0x6490B0", Offset = "0x647CB0", VA = "0x1806490B0", Slot = "19")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x0600EE52 RID: 61010 RVA: 0x000576A8 File Offset: 0x000558A8
		[Token(Token = "0x17001EE4")]
		public long abnormalComboMask
		{
			[Token(Token = "0x600EE52")]
			[Address(RVA = "0x649170", Offset = "0x647D70", VA = "0x180649170", Slot = "20")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x0600EE53 RID: 61011 RVA: 0x000576C0 File Offset: 0x000558C0
		[Token(Token = "0x17001EE5")]
		public long abnormalComboImmuneMask
		{
			[Token(Token = "0x600EE53")]
			[Address(RVA = "0x649110", Offset = "0x647D10", VA = "0x180649110", Slot = "21")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600EE54 RID: 61012 RVA: 0x000576D8 File Offset: 0x000558D8
		[Token(Token = "0x600EE54")]
		[Address(RVA = "0x647A70", Offset = "0x646670", VA = "0x180647A70", Slot = "22")]
		public bool GetValue(AttributeType attributeType, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
		{
			return default(bool);
		}

		// Token: 0x0600EE55 RID: 61013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE55")]
		[Address(RVA = "0x648FE0", Offset = "0x647BE0", VA = "0x180648FE0")]
		protected FeverBehaviour()
		{
		}

		// Token: 0x0600EE56 RID: 61014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE56")]
		[Address(RVA = "0x63F4E0", Offset = "0x63E0E0", VA = "0x18063F4E0")]
		private void <>xLuaBaseProxy_AssignData(Blackboard P0)
		{
		}

		// Token: 0x0600EE57 RID: 61015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE57")]
		[Address(RVA = "0x63F7F0", Offset = "0x63E3F0", VA = "0x18063F7F0")]
		private void <>xLuaBaseProxy_OnOwnerFinish()
		{
		}

		// Token: 0x0600EE58 RID: 61016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE58")]
		[Address(RVA = "0x63F850", Offset = "0x63E450", VA = "0x18063F850")]
		private void <>xLuaBaseProxy_OnSkillEnd()
		{
		}

		// Token: 0x0600EE59 RID: 61017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE59")]
		[Address(RVA = "0x63F910", Offset = "0x63E510", VA = "0x18063F910")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600EE5A RID: 61018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE5A")]
		[Address(RVA = "0x63F730", Offset = "0x63E330", VA = "0x18063F730")]
		private void <>xLuaBaseProxy_OnCastSucceed()
		{
		}

		// Token: 0x0600EE5B RID: 61019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EE5B")]
		[Address(RVA = "0x63F6D0", Offset = "0x63E2D0", VA = "0x18063F6D0")]
		private void <>xLuaBaseProxy_OnCastFailed()
		{
		}

		// Token: 0x04010783 RID: 67459
		[Token(Token = "0x4010783")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _feverKey;

		// Token: 0x04010784 RID: 67460
		[Token(Token = "0x4010784")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _leaveFeverWhenSkillEnd;

		// Token: 0x04010785 RID: 67461
		[Token(Token = "0x4010785")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _skipSkillStateTickJoinFever;

		// Token: 0x04010786 RID: 67462
		[Token(Token = "0x4010786")]
		[FieldOffset(Offset = "0x30")]
		private FeverSystemManager m_feverManager;

		// Token: 0x04010787 RID: 67463
		[Token(Token = "0x4010787")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isJoinDuringSkill;

		// Token: 0x04010788 RID: 67464
		[Token(Token = "0x4010788")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isSelfInFever;

		// Token: 0x04010789 RID: 67465
		[Token(Token = "0x4010789")]
		[FieldOffset(Offset = "0x40")]
		private ObjectPtr<Entity> m_ownerPtr;

		// Token: 0x0401078A RID: 67466
		[Token(Token = "0x401078A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needDisplayFeverCast;

		// Token: 0x0401078B RID: 67467
		[Token(Token = "0x401078B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isSelfInFever;

		// Token: 0x0401078C RID: 67468
		[Token(Token = "0x401078C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_needInFever;

		// Token: 0x0401078D RID: 67469
		[Token(Token = "0x401078D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isDirectlyJoinFeverTypeSkill;

		// Token: 0x0401078E RID: 67470
		[Token(Token = "0x401078E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_feverManager;

		// Token: 0x0401078F RID: 67471
		[Token(Token = "0x401078F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010790 RID: 67472
		[Token(Token = "0x4010790")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__JoinFeverDuringSkill;

		// Token: 0x04010791 RID: 67473
		[Token(Token = "0x4010791")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__JoinFever;

		// Token: 0x04010792 RID: 67474
		[Token(Token = "0x4010792")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LeaveFever;

		// Token: 0x04010793 RID: 67475
		[Token(Token = "0x4010793")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnOwnerFinish;

		// Token: 0x04010794 RID: 67476
		[Token(Token = "0x4010794")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnSkillEnd;

		// Token: 0x04010795 RID: 67477
		[Token(Token = "0x4010795")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04010796 RID: 67478
		[Token(Token = "0x4010796")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnCastSucceed;

		// Token: 0x04010797 RID: 67479
		[Token(Token = "0x4010797")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnCastFailed;

		// Token: 0x04010798 RID: 67480
		[Token(Token = "0x4010798")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckJoinFeverOrTickUseSkill;

		// Token: 0x04010799 RID: 67481
		[Token(Token = "0x4010799")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__LeaveFeverIfNecessary;

		// Token: 0x0401079A RID: 67482
		[Token(Token = "0x401079A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnBeforeJoinFever;

		// Token: 0x0401079B RID: 67483
		[Token(Token = "0x401079B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnJoinFeverFail;

		// Token: 0x0401079C RID: 67484
		[Token(Token = "0x401079C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnAfterJoinFever;

		// Token: 0x0401079D RID: 67485
		[Token(Token = "0x401079D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnBeforeLeaveFever;

		// Token: 0x0401079E RID: 67486
		[Token(Token = "0x401079E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnAfterLeaveFever;

		// Token: 0x0401079F RID: 67487
		[Token(Token = "0x401079F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_UseSkillByFeverLogic;

		// Token: 0x040107A0 RID: 67488
		[Token(Token = "0x40107A0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__IsDuringSkill;

		// Token: 0x040107A1 RID: 67489
		[Token(Token = "0x40107A1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_attributeMask;

		// Token: 0x040107A2 RID: 67490
		[Token(Token = "0x40107A2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

		// Token: 0x040107A3 RID: 67491
		[Token(Token = "0x40107A3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

		// Token: 0x040107A4 RID: 67492
		[Token(Token = "0x40107A4")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

		// Token: 0x040107A5 RID: 67493
		[Token(Token = "0x40107A5")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_abnormalComboMask;

		// Token: 0x040107A6 RID: 67494
		[Token(Token = "0x40107A6")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

		// Token: 0x040107A7 RID: 67495
		[Token(Token = "0x40107A7")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x040107A8 RID: 67496
		[Token(Token = "0x40107A8")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200244C RID: 9292
		[Token(Token = "0x200244C")]
		private struct FeverResult : IHotfixable
		{
			// Token: 0x17001EE6 RID: 7910
			// (get) Token: 0x0600EE5C RID: 61020 RVA: 0x000576F0 File Offset: 0x000558F0
			[Token(Token = "0x17001EE6")]
			public static FeverBehaviour.FeverResult FAIL
			{
				[Token(Token = "0x600EE5C")]
				[Address(RVA = "0x64B010", Offset = "0x649C10", VA = "0x18064B010")]
				get
				{
					return default(FeverBehaviour.FeverResult);
				}
			}

			// Token: 0x17001EE7 RID: 7911
			// (get) Token: 0x0600EE5D RID: 61021 RVA: 0x00057708 File Offset: 0x00055908
			[Token(Token = "0x17001EE7")]
			public static FeverBehaviour.FeverResult SUCCESS
			{
				[Token(Token = "0x600EE5D")]
				[Address(RVA = "0x64B090", Offset = "0x649C90", VA = "0x18064B090")]
				get
				{
					return default(FeverBehaviour.FeverResult);
				}
			}

			// Token: 0x040107A9 RID: 67497
			[Token(Token = "0x40107A9")]
			[FieldOffset(Offset = "0x0")]
			public bool joinSuccess;

			// Token: 0x040107AA RID: 67498
			[Token(Token = "0x40107AA")]
			[FieldOffset(Offset = "0x1")]
			public bool isHandled;

			// Token: 0x040107AB RID: 67499
			[Token(Token = "0x40107AB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_FAIL;

			// Token: 0x040107AC RID: 67500
			[Token(Token = "0x40107AC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_SUCCESS;
		}
	}
}
