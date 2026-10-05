using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E05 RID: 15877
	[Token(Token = "0x2003E05")]
	public class SquadViewModel : ISquadChecker, IHotfixable
	{
		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x06018B41 RID: 101185 RVA: 0x0009B718 File Offset: 0x00099918
		// (set) Token: 0x06018B42 RID: 101186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003ADF")]
		public int id
		{
			[Token(Token = "0x6018B41")]
			[Address(RVA = "0x114B020", Offset = "0x1149C20", VA = "0x18114B020", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6018B42")]
			[Address(RVA = "0x114B150", Offset = "0x1149D50", VA = "0x18114B150")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x06018B43 RID: 101187 RVA: 0x0009B730 File Offset: 0x00099930
		[Token(Token = "0x17003AE0")]
		public EvolvePhaseAndLevel maxEvolvePhaseAndLevel
		{
			[Token(Token = "0x6018B43")]
			[Address(RVA = "0x114B080", Offset = "0x1149C80", VA = "0x18114B080", Slot = "5")]
			get
			{
				return default(EvolvePhaseAndLevel);
			}
		}

		// Token: 0x06018B44 RID: 101188 RVA: 0x0009B748 File Offset: 0x00099948
		[Token(Token = "0x6018B44")]
		[Address(RVA = "0x1149EF0", Offset = "0x1148AF0", VA = "0x181149EF0", Slot = "6")]
		public bool CheckIfContainedInCurSquad(string charId)
		{
			return default(bool);
		}

		// Token: 0x06018B45 RID: 101189 RVA: 0x0009B760 File Offset: 0x00099960
		[Token(Token = "0x6018B45")]
		[Address(RVA = "0x114A750", Offset = "0x1149350", VA = "0x18114A750", Slot = "7")]
		public bool TryGetMutuallyExclusiveCharInfoInCurSquad(string charId, out string exclusiveInfo, bool ignoreSame = false)
		{
			return default(bool);
		}

		// Token: 0x17003AE1 RID: 15073
		// (get) Token: 0x06018B46 RID: 101190 RVA: 0x0009B778 File Offset: 0x00099978
		// (set) Token: 0x06018B47 RID: 101191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AE1")]
		public int cachedMemberCount
		{
			[Token(Token = "0x6018B46")]
			[Address(RVA = "0x114AFC0", Offset = "0x1149BC0", VA = "0x18114AFC0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6018B47")]
			[Address(RVA = "0x114B0E0", Offset = "0x1149CE0", VA = "0x18114B0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06018B48 RID: 101192 RVA: 0x0009B790 File Offset: 0x00099990
		[Token(Token = "0x6018B48")]
		[Address(RVA = "0x114A070", Offset = "0x1148C70", VA = "0x18114A070")]
		public int CountValidMembers()
		{
			return 0;
		}

		// Token: 0x06018B49 RID: 101193 RVA: 0x0009B7A8 File Offset: 0x000999A8
		[Token(Token = "0x6018B49")]
		[Address(RVA = "0x114AD30", Offset = "0x1149930", VA = "0x18114AD30")]
		private EvolvePhaseAndLevel _CalcEvolveMaxPhaseAndLevel()
		{
			return default(EvolvePhaseAndLevel);
		}

		// Token: 0x06018B4A RID: 101194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B4A")]
		[Address(RVA = "0x1149E70", Offset = "0x1148A70", VA = "0x181149E70")]
		public void ApplySquadName(PlayerSquad playerSquad)
		{
		}

		// Token: 0x06018B4B RID: 101195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B4B")]
		[Address(RVA = "0x114A240", Offset = "0x1148E40", VA = "0x18114A240")]
		public void FillWithPlayerData(PlayerSquad playerSquad)
		{
		}

		// Token: 0x06018B4C RID: 101196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B4C")]
		[Address(RVA = "0x114A530", Offset = "0x1149130", VA = "0x18114A530")]
		public void ShrinkMembers()
		{
		}

		// Token: 0x06018B4D RID: 101197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B4D")]
		[Address(RVA = "0x114A930", Offset = "0x1149530", VA = "0x18114A930")]
		public void UpdateMemberStatus()
		{
		}

		// Token: 0x06018B4E RID: 101198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B4E")]
		[Address(RVA = "0x114AF60", Offset = "0x1149B60", VA = "0x18114AF60")]
		public SquadViewModel()
		{
		}

		// Token: 0x0401E4AD RID: 124077
		[Token(Token = "0x401E4AD")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0401E4AE RID: 124078
		[Token(Token = "0x401E4AE")]
		[FieldOffset(Offset = "0x20")]
		public SquadItemStruct[] members;

		// Token: 0x0401E4B0 RID: 124080
		[Token(Token = "0x401E4B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x0401E4B1 RID: 124081
		[Token(Token = "0x401E4B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_id;

		// Token: 0x0401E4B2 RID: 124082
		[Token(Token = "0x401E4B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxEvolvePhaseAndLevel;

		// Token: 0x0401E4B3 RID: 124083
		[Token(Token = "0x401E4B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfContainedInCurSquad;

		// Token: 0x0401E4B4 RID: 124084
		[Token(Token = "0x401E4B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryGetMutuallyExclusiveCharInfoInCurSquad;

		// Token: 0x0401E4B5 RID: 124085
		[Token(Token = "0x401E4B5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_cachedMemberCount;

		// Token: 0x0401E4B6 RID: 124086
		[Token(Token = "0x401E4B6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_cachedMemberCount;

		// Token: 0x0401E4B7 RID: 124087
		[Token(Token = "0x401E4B7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CountValidMembers;

		// Token: 0x0401E4B8 RID: 124088
		[Token(Token = "0x401E4B8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CalcEvolveMaxPhaseAndLevel;

		// Token: 0x0401E4B9 RID: 124089
		[Token(Token = "0x401E4B9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ApplySquadName;

		// Token: 0x0401E4BA RID: 124090
		[Token(Token = "0x401E4BA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_FillWithPlayerData;

		// Token: 0x0401E4BB RID: 124091
		[Token(Token = "0x401E4BB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ShrinkMembers;

		// Token: 0x0401E4BC RID: 124092
		[Token(Token = "0x401E4BC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateMemberStatus;

		// Token: 0x0401E4BD RID: 124093
		[Token(Token = "0x401E4BD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
