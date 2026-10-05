using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035DA RID: 13786
	[Token(Token = "0x20035DA")]
	public abstract class CommonSquadSingleSquadViewModel : ISquadChecker, IHotfixable
	{
		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x06015EFB RID: 89851 RVA: 0x0008EB78 File Offset: 0x0008CD78
		// (set) Token: 0x06015EFC RID: 89852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170034BD")]
		public int id
		{
			[Token(Token = "0x6015EFB")]
			[Address(RVA = "0xE78930", Offset = "0xE77530", VA = "0x180E78930", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6015EFC")]
			[Address(RVA = "0xE78A60", Offset = "0xE77660", VA = "0x180E78A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x06015EFD RID: 89853 RVA: 0x0008EB90 File Offset: 0x0008CD90
		[Token(Token = "0x170034BE")]
		public EvolvePhaseAndLevel maxEvolvePhaseAndLevel
		{
			[Token(Token = "0x6015EFD")]
			[Address(RVA = "0xE78990", Offset = "0xE77590", VA = "0x180E78990", Slot = "5")]
			get
			{
				return default(EvolvePhaseAndLevel);
			}
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x06015EFE RID: 89854 RVA: 0x0008EBA8 File Offset: 0x0008CDA8
		[Token(Token = "0x170034BF")]
		public int membersCount
		{
			[Token(Token = "0x6015EFE")]
			[Address(RVA = "0xE789F0", Offset = "0xE775F0", VA = "0x180E789F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x06015EFF RID: 89855 RVA: 0x0008EBC0 File Offset: 0x0008CDC0
		[Token(Token = "0x170034C0")]
		public virtual int availMembers
		{
			[Token(Token = "0x6015EFF")]
			[Address(RVA = "0xE78800", Offset = "0xE77400", VA = "0x180E78800", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06015F00 RID: 89856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F00")]
		[Address(RVA = "0xE780E0", Offset = "0xE76CE0", VA = "0x180E780E0")]
		public CommonSquadSingleSquadViewModel SetMembers(ICommonSquadChar[] newMembers)
		{
			return null;
		}

		// Token: 0x06015F01 RID: 89857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F01")]
		[Address(RVA = "0xE77F80", Offset = "0xE76B80", VA = "0x180E77F80")]
		public void SetMember(int index, ICommonSquadChar newMember)
		{
		}

		// Token: 0x06015F02 RID: 89858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015F02")]
		[Address(RVA = "0xE77EF0", Offset = "0xE76AF0", VA = "0x180E77EF0")]
		public ICommonSquadChar GetMember(int index)
		{
			return null;
		}

		// Token: 0x06015F03 RID: 89859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F03")]
		[Address(RVA = "0xE77BD0", Offset = "0xE767D0", VA = "0x180E77BD0")]
		public void ClearTargetMember(int index)
		{
		}

		// Token: 0x06015F04 RID: 89860 RVA: 0x0008EBD8 File Offset: 0x0008CDD8
		[Token(Token = "0x6015F04")]
		[Address(RVA = "0xE77AC0", Offset = "0xE766C0", VA = "0x180E77AC0", Slot = "6")]
		public bool CheckIfContainedInCurSquad(string charId)
		{
			return default(bool);
		}

		// Token: 0x06015F05 RID: 89861 RVA: 0x0008EBF0 File Offset: 0x0008CDF0
		[Token(Token = "0x6015F05")]
		[Address(RVA = "0xE785A0", Offset = "0xE771A0", VA = "0x180E785A0", Slot = "7")]
		public bool TryGetMutuallyExclusiveCharInfoInCurSquad(string charId, out string exclusiveInfo, bool ignoreSame = false)
		{
			return default(bool);
		}

		// Token: 0x06015F06 RID: 89862 RVA: 0x0008EC08 File Offset: 0x0008CE08
		[Token(Token = "0x6015F06")]
		[Address(RVA = "0xE783A0", Offset = "0xE76FA0", VA = "0x180E783A0")]
		public bool TryGetMutuallyExclusiveCharInfoInCurSquadWithIgnoreIndex(string charId, out string exclusiveInfo, bool ignoreSame = false, int ignoreIndex = -1)
		{
			return default(bool);
		}

		// Token: 0x06015F07 RID: 89863 RVA: 0x0008EC20 File Offset: 0x0008CE20
		[Token(Token = "0x6015F07")]
		[Address(RVA = "0xE77DA0", Offset = "0xE769A0", VA = "0x180E77DA0")]
		public int FindIndexByInstId(int instId)
		{
			return 0;
		}

		// Token: 0x06015F08 RID: 89864 RVA: 0x0008EC38 File Offset: 0x0008CE38
		[Token(Token = "0x6015F08")]
		[Address(RVA = "0xE77C80", Offset = "0xE76880", VA = "0x180E77C80")]
		public int FindFirstEmptyMemberIndex()
		{
			return 0;
		}

		// Token: 0x06015F09 RID: 89865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F09")]
		[Address(RVA = "0xE78640", Offset = "0xE77240", VA = "0x180E78640", Slot = "9")]
		public virtual void UpdateMemberStatus(DataBundle updateDataInput)
		{
		}

		// Token: 0x06015F0A RID: 89866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F0A")]
		[Address(RVA = "0xE781B0", Offset = "0xE76DB0", VA = "0x180E781B0")]
		public void ShrinkMembers()
		{
		}

		// Token: 0x06015F0B RID: 89867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F0B")]
		[Address(RVA = "0xE787A0", Offset = "0xE773A0", VA = "0x180E787A0")]
		protected CommonSquadSingleSquadViewModel()
		{
		}

		// Token: 0x0401A5ED RID: 108013
		[Token(Token = "0x401A5ED")]
		[FieldOffset(Offset = "0x18")]
		protected ICommonSquadChar[] members;

		// Token: 0x0401A5EE RID: 108014
		[Token(Token = "0x401A5EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x0401A5EF RID: 108015
		[Token(Token = "0x401A5EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_id;

		// Token: 0x0401A5F0 RID: 108016
		[Token(Token = "0x401A5F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxEvolvePhaseAndLevel;

		// Token: 0x0401A5F1 RID: 108017
		[Token(Token = "0x401A5F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_membersCount;

		// Token: 0x0401A5F2 RID: 108018
		[Token(Token = "0x401A5F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_availMembers;

		// Token: 0x0401A5F3 RID: 108019
		[Token(Token = "0x401A5F3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetMembers;

		// Token: 0x0401A5F4 RID: 108020
		[Token(Token = "0x401A5F4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetMember;

		// Token: 0x0401A5F5 RID: 108021
		[Token(Token = "0x401A5F5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetMember;

		// Token: 0x0401A5F6 RID: 108022
		[Token(Token = "0x401A5F6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ClearTargetMember;

		// Token: 0x0401A5F7 RID: 108023
		[Token(Token = "0x401A5F7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfContainedInCurSquad;

		// Token: 0x0401A5F8 RID: 108024
		[Token(Token = "0x401A5F8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryGetMutuallyExclusiveCharInfoInCurSquad;

		// Token: 0x0401A5F9 RID: 108025
		[Token(Token = "0x401A5F9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryGetMutuallyExclusiveCharInfoInCurSquadWithIgnoreIndex;

		// Token: 0x0401A5FA RID: 108026
		[Token(Token = "0x401A5FA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_FindIndexByInstId;

		// Token: 0x0401A5FB RID: 108027
		[Token(Token = "0x401A5FB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_FindFirstEmptyMemberIndex;

		// Token: 0x0401A5FC RID: 108028
		[Token(Token = "0x401A5FC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdateMemberStatus;

		// Token: 0x0401A5FD RID: 108029
		[Token(Token = "0x401A5FD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ShrinkMembers;

		// Token: 0x0401A5FE RID: 108030
		[Token(Token = "0x401A5FE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
