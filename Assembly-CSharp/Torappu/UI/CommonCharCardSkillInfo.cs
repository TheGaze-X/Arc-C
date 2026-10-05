using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035A6 RID: 13734
	[Token(Token = "0x20035A6")]
	public class CommonCharCardSkillInfo : ICharSkillInfo, ICharacterInfo, IHotfixable
	{
		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x06015D6F RID: 89455 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015D70 RID: 89456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003435")]
		public string skillId
		{
			[Token(Token = "0x6015D6F")]
			[Address(RVA = "0xE5C940", Offset = "0xE5B540", VA = "0x180E5C940", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015D70")]
			[Address(RVA = "0xE5CAF0", Offset = "0xE5B6F0", VA = "0x180E5CAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x06015D71 RID: 89457 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015D72 RID: 89458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003436")]
		public string defaultSkillId
		{
			[Token(Token = "0x6015D71")]
			[Address(RVA = "0xE5C880", Offset = "0xE5B480", VA = "0x180E5C880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015D72")]
			[Address(RVA = "0xE5CA00", Offset = "0xE5B600", VA = "0x180E5CA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x06015D73 RID: 89459 RVA: 0x0008E3C8 File Offset: 0x0008C5C8
		// (set) Token: 0x06015D74 RID: 89460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003437")]
		public int mainSkillLvl
		{
			[Token(Token = "0x6015D73")]
			[Address(RVA = "0xE5C8E0", Offset = "0xE5B4E0", VA = "0x180E5C8E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6015D74")]
			[Address(RVA = "0xE5CA80", Offset = "0xE5B680", VA = "0x180E5CA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x06015D75 RID: 89461 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015D76 RID: 89462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003438")]
		public ListDict<string, PlayerCharSkill> skills
		{
			[Token(Token = "0x6015D75")]
			[Address(RVA = "0xE5C9A0", Offset = "0xE5B5A0", VA = "0x180E5C9A0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015D76")]
			[Address(RVA = "0xE5CB70", Offset = "0xE5B770", VA = "0x180E5CB70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D77 RID: 89463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D77")]
		[Address(RVA = "0xE5C720", Offset = "0xE5B320", VA = "0x180E5C720", Slot = "9")]
		public virtual void SetSkillId(string newSkillId)
		{
		}

		// Token: 0x06015D78 RID: 89464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D78")]
		[Address(RVA = "0xE5C7A0", Offset = "0xE5B3A0", VA = "0x180E5C7A0", Slot = "10")]
		public virtual void SetSkillMainLvl(int newMainSkillLvl)
		{
		}

		// Token: 0x06015D79 RID: 89465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D79")]
		[Address(RVA = "0xE5C820", Offset = "0xE5B420", VA = "0x180E5C820")]
		public CommonCharCardSkillInfo()
		{
		}

		// Token: 0x0401A460 RID: 107616
		[Token(Token = "0x401A460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_skillId;

		// Token: 0x0401A461 RID: 107617
		[Token(Token = "0x401A461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_skillId;

		// Token: 0x0401A462 RID: 107618
		[Token(Token = "0x401A462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_defaultSkillId;

		// Token: 0x0401A463 RID: 107619
		[Token(Token = "0x401A463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_defaultSkillId;

		// Token: 0x0401A464 RID: 107620
		[Token(Token = "0x401A464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_mainSkillLvl;

		// Token: 0x0401A465 RID: 107621
		[Token(Token = "0x401A465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_mainSkillLvl;

		// Token: 0x0401A466 RID: 107622
		[Token(Token = "0x401A466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_skills;

		// Token: 0x0401A467 RID: 107623
		[Token(Token = "0x401A467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_skills;

		// Token: 0x0401A468 RID: 107624
		[Token(Token = "0x401A468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetSkillId;

		// Token: 0x0401A469 RID: 107625
		[Token(Token = "0x401A469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetSkillMainLvl;

		// Token: 0x0401A46A RID: 107626
		[Token(Token = "0x401A46A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020035A7 RID: 13735
		[Token(Token = "0x20035A7")]
		public struct DefaultSkillInfoPatchBuilder : ICharInfoPatchBuilder<CommonCharCardSkillInfo>, IHotfixable
		{
			// Token: 0x17003439 RID: 13369
			// (get) Token: 0x06015D7A RID: 89466 RVA: 0x0008E3E0 File Offset: 0x0008C5E0
			[Token(Token = "0x17003439")]
			public bool isEmpty
			{
				[Token(Token = "0x6015D7A")]
				[Address(RVA = "0xE6FC60", Offset = "0xE6E860", VA = "0x180E6FC60", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06015D7B RID: 89467 RVA: 0x0008E3F8 File Offset: 0x0008C5F8
			[Token(Token = "0x6015D7B")]
			[Address(RVA = "0xE6F3C0", Offset = "0xE6DFC0", VA = "0x180E6F3C0")]
			public CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder SetSkills(ListDict<string, PlayerCharSkill> sourceSkills)
			{
				return default(CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder);
			}

			// Token: 0x06015D7C RID: 89468 RVA: 0x0008E410 File Offset: 0x0008C610
			[Token(Token = "0x6015D7C")]
			[Address(RVA = "0xE6F5E0", Offset = "0xE6E1E0", VA = "0x180E6F5E0")]
			private CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder _CloneSkills(IList<PlayerCharSkill> sourceSkills)
			{
				return default(CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder);
			}

			// Token: 0x06015D7D RID: 89469 RVA: 0x0008E428 File Offset: 0x0008C628
			[Token(Token = "0x6015D7D")]
			[Address(RVA = "0xE6F8E0", Offset = "0xE6E4E0", VA = "0x180E6F8E0")]
			private CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder _GenSkillsFromMainSkill(IList<CharacterData.MainSkill> sourceSkills, int specializeLevel)
			{
				return default(CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder);
			}

			// Token: 0x06015D7E RID: 89470 RVA: 0x0008E440 File Offset: 0x0008C640
			[Token(Token = "0x6015D7E")]
			[Address(RVA = "0xE6E9D0", Offset = "0xE6D5D0", VA = "0x180E6E9D0")]
			public bool GetSkillDataById(string targetSkillId, out PlayerCharSkill charSkill)
			{
				return default(bool);
			}

			// Token: 0x06015D7F RID: 89471 RVA: 0x0008E458 File Offset: 0x0008C658
			[Token(Token = "0x6015D7F")]
			[Address(RVA = "0xE6EB10", Offset = "0xE6D710", VA = "0x180E6EB10")]
			public bool GetSkillDataByIndex(int targetSkillIndex, out string targetSkillId, out PlayerCharSkill charSkill)
			{
				return default(bool);
			}

			// Token: 0x06015D80 RID: 89472 RVA: 0x0008E470 File Offset: 0x0008C670
			[Token(Token = "0x6015D80")]
			[Address(RVA = "0xE6E910", Offset = "0xE6D510", VA = "0x180E6E910")]
			public int GetSkillCount()
			{
				return 0;
			}

			// Token: 0x06015D81 RID: 89473 RVA: 0x0008E488 File Offset: 0x0008C688
			[Token(Token = "0x6015D81")]
			[Address(RVA = "0xE6F0A0", Offset = "0xE6DCA0", VA = "0x180E6F0A0")]
			public static CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder ParseFromPlayerCharacter(PlayerCharacter playerChar, [Optional] string overrideTmplId)
			{
				return default(CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder);
			}

			// Token: 0x06015D82 RID: 89474 RVA: 0x0008E4A0 File Offset: 0x0008C6A0
			[Token(Token = "0x6015D82")]
			[Address(RVA = "0xE6EC70", Offset = "0xE6D870", VA = "0x180E6EC70")]
			public static CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder ParseFromCharData(CharQuery charQuery, int mainSkillLvl, int specializeLevel, EvolvePhase evolvePhase, int level, int defaultSkillIndex = 0)
			{
				return default(CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder);
			}

			// Token: 0x06015D83 RID: 89475 RVA: 0x0008E4B8 File Offset: 0x0008C6B8
			[Token(Token = "0x6015D83")]
			[Address(RVA = "0xE6F260", Offset = "0xE6DE60", VA = "0x180E6F260")]
			public static CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder ParseFromSkillInfo(ICharSkillInfo sourceSkillInfo)
			{
				return default(CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder);
			}

			// Token: 0x06015D84 RID: 89476 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015D84")]
			[Address(RVA = "0xE6E560", Offset = "0xE6D160", VA = "0x180E6E560", Slot = "5")]
			public CommonCharCardSkillInfo BuildTo(CommonCharCardSkillInfo characterInfo)
			{
				return null;
			}

			// Token: 0x0401A46B RID: 107627
			[Token(Token = "0x401A46B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string skillId;

			// Token: 0x0401A46C RID: 107628
			[Token(Token = "0x401A46C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string defaultSkillId;

			// Token: 0x0401A46D RID: 107629
			[Token(Token = "0x401A46D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int mainSkillLvl;

			// Token: 0x0401A46E RID: 107630
			[Token(Token = "0x401A46E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly ListDict<string, PlayerCharSkill> s_skills;

			// Token: 0x0401A46F RID: 107631
			[Token(Token = "0x401A46F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x0401A470 RID: 107632
			[Token(Token = "0x401A470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetSkills;

			// Token: 0x0401A471 RID: 107633
			[Token(Token = "0x401A471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__CloneSkills;

			// Token: 0x0401A472 RID: 107634
			[Token(Token = "0x401A472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GenSkillsFromMainSkill;

			// Token: 0x0401A473 RID: 107635
			[Token(Token = "0x401A473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetSkillDataById;

			// Token: 0x0401A474 RID: 107636
			[Token(Token = "0x401A474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetSkillDataByIndex;

			// Token: 0x0401A475 RID: 107637
			[Token(Token = "0x401A475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetSkillCount;

			// Token: 0x0401A476 RID: 107638
			[Token(Token = "0x401A476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_ParseFromPlayerCharacter;

			// Token: 0x0401A477 RID: 107639
			[Token(Token = "0x401A477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_ParseFromCharData;

			// Token: 0x0401A478 RID: 107640
			[Token(Token = "0x401A478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_ParseFromSkillInfo;

			// Token: 0x0401A479 RID: 107641
			[Token(Token = "0x401A479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_BuildTo;
		}
	}
}
