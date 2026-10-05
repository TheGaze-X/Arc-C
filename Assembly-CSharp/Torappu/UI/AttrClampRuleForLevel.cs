using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003589 RID: 13705
	[Token(Token = "0x2003589")]
	public struct AttrClampRuleForLevel : ISingleInfoClampRule, IHotfixable
	{
		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x06015CE1 RID: 89313 RVA: 0x0008DED0 File Offset: 0x0008C0D0
		// (set) Token: 0x06015CE2 RID: 89314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033F3")]
		public CharQuery charQuery
		{
			[Token(Token = "0x6015CE1")]
			[Address(RVA = "0xE5ADF0", Offset = "0xE599F0", VA = "0x180E5ADF0")]
			[CompilerGenerated]
			readonly get
			{
				return default(CharQuery);
			}
			[Token(Token = "0x6015CE2")]
			[Address(RVA = "0xE5B110", Offset = "0xE59D10", VA = "0x180E5B110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x06015CE3 RID: 89315 RVA: 0x0008DEE8 File Offset: 0x0008C0E8
		// (set) Token: 0x06015CE4 RID: 89316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033F4")]
		public int level
		{
			[Token(Token = "0x6015CE3")]
			[Address(RVA = "0xE5AF90", Offset = "0xE59B90", VA = "0x180E5AF90")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6015CE4")]
			[Address(RVA = "0xE5B2E0", Offset = "0xE59EE0", VA = "0x180E5B2E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x06015CE5 RID: 89317 RVA: 0x0008DF00 File Offset: 0x0008C100
		// (set) Token: 0x06015CE6 RID: 89318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033F5")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x6015CE5")]
			[Address(RVA = "0xE5AE90", Offset = "0xE59A90", VA = "0x180E5AE90")]
			[CompilerGenerated]
			readonly get
			{
				return EvolvePhase.PHASE_0;
			}
			[Token(Token = "0x6015CE6")]
			[Address(RVA = "0xE5B1C0", Offset = "0xE59DC0", VA = "0x180E5B1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x06015CE7 RID: 89319 RVA: 0x0008DF18 File Offset: 0x0008C118
		// (set) Token: 0x06015CE8 RID: 89320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033F6")]
		public int potentialRank
		{
			[Token(Token = "0x6015CE7")]
			[Address(RVA = "0xE5B010", Offset = "0xE59C10", VA = "0x180E5B010")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6015CE8")]
			[Address(RVA = "0xE5B370", Offset = "0xE59F70", VA = "0x180E5B370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x06015CE9 RID: 89321 RVA: 0x0008DF30 File Offset: 0x0008C130
		// (set) Token: 0x06015CEA RID: 89322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033F7")]
		public int favorPoint
		{
			[Token(Token = "0x6015CE9")]
			[Address(RVA = "0xE5AF10", Offset = "0xE59B10", VA = "0x180E5AF10")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6015CEA")]
			[Address(RVA = "0xE5B250", Offset = "0xE59E50", VA = "0x180E5B250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x06015CEB RID: 89323 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015CEC RID: 89324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033F8")]
		public List<CharacterData.UniqueEquipPair> uniEquipQueries
		{
			[Token(Token = "0x6015CEB")]
			[Address(RVA = "0xE5B090", Offset = "0xE59C90", VA = "0x180E5B090")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6015CEC")]
			[Address(RVA = "0xE5B400", Offset = "0xE5A000", VA = "0x180E5B400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015CED RID: 89325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015CED")]
		[Address(RVA = "0xE5AC20", Offset = "0xE59820", VA = "0x180E5AC20")]
		public AttrClampRuleForLevel(CharQuery charQuery, int level, EvolvePhase evolvePhase, int potentialRank, int favorPoint, List<CharacterData.UniqueEquipPair> uniEquipQueries)
		{
		}

		// Token: 0x06015CEE RID: 89326 RVA: 0x0008DF48 File Offset: 0x0008C148
		[Token(Token = "0x6015CEE")]
		[Address(RVA = "0xE5AA20", Offset = "0xE59620", VA = "0x180E5AA20")]
		public BasicCharInfoModel.DefaultAttrInfoPatchBuilder DoClamp(BasicCharInfoModel.DefaultAttrInfoPatchBuilder infoPatchBuilder)
		{
			return default(BasicCharInfoModel.DefaultAttrInfoPatchBuilder);
		}

		// Token: 0x0401A3D5 RID: 107477
		[Token(Token = "0x401A3D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x0401A3D6 RID: 107478
		[Token(Token = "0x401A3D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charQuery;

		// Token: 0x0401A3D7 RID: 107479
		[Token(Token = "0x401A3D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0401A3D8 RID: 107480
		[Token(Token = "0x401A3D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_level;

		// Token: 0x0401A3D9 RID: 107481
		[Token(Token = "0x401A3D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x0401A3DA RID: 107482
		[Token(Token = "0x401A3DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_evolvePhase;

		// Token: 0x0401A3DB RID: 107483
		[Token(Token = "0x401A3DB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_potentialRank;

		// Token: 0x0401A3DC RID: 107484
		[Token(Token = "0x401A3DC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_potentialRank;

		// Token: 0x0401A3DD RID: 107485
		[Token(Token = "0x401A3DD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_favorPoint;

		// Token: 0x0401A3DE RID: 107486
		[Token(Token = "0x401A3DE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_favorPoint;

		// Token: 0x0401A3DF RID: 107487
		[Token(Token = "0x401A3DF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_uniEquipQueries;

		// Token: 0x0401A3E0 RID: 107488
		[Token(Token = "0x401A3E0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_uniEquipQueries;

		// Token: 0x0401A3E1 RID: 107489
		[Token(Token = "0x401A3E1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A3E2 RID: 107490
		[Token(Token = "0x401A3E2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoClamp;
	}
}
