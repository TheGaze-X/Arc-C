using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu
{
	// Token: 0x020008F8 RID: 2296
	[Token(Token = "0x20008F8")]
	public class PlayerCharacter : IHotfixable
	{
		// Token: 0x060065BE RID: 26046 RVA: 0x000307F8 File Offset: 0x0002E9F8
		[Token(Token = "0x60065BE")]
		[Address(RVA = "0x1EF3590", Offset = "0x1EF2190", VA = "0x181EF3590")]
		public int GetFinalSkillLvl(string tmplId, int skillIndex)
		{
			return 0;
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x00030810 File Offset: 0x0002EA10
		[Token(Token = "0x60065BF")]
		[Address(RVA = "0x1EF3340", Offset = "0x1EF1F40", VA = "0x181EF3340")]
		public int GetEquipLvl(string equipId, [Optional] string tmplId)
		{
			return 0;
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C0")]
		[Address(RVA = "0x1EF39E0", Offset = "0x1EF25E0", VA = "0x181EF39E0")]
		public PlayerCharPatch SafeTmpl(string tmplId)
		{
			return null;
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C1")]
		[Address(RVA = "0x1EF3030", Offset = "0x1EF1C30", VA = "0x181EF3030")]
		public PlayerCharSkill[] GetCurSkills()
		{
			return null;
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C2")]
		[Address(RVA = "0x1EF36C0", Offset = "0x1EF22C0", VA = "0x181EF36C0")]
		public PlayerCharSkill[] GetSkills(string tmplId)
		{
			return null;
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x00030828 File Offset: 0x0002EA28
		[Token(Token = "0x60065C3")]
		[Address(RVA = "0x1EF31D0", Offset = "0x1EF1DD0", VA = "0x181EF31D0")]
		public int GetDefaultSkillIndex()
		{
			return 0;
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x00030840 File Offset: 0x0002EA40
		[Token(Token = "0x60065C4")]
		[Address(RVA = "0x1EF3090", Offset = "0x1EF1C90", VA = "0x181EF3090")]
		public int GetDefaultSkillIndexByTmpl(string tmplId)
		{
			return 0;
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C5")]
		[Address(RVA = "0x1EF3780", Offset = "0x1EF2380", VA = "0x181EF3780")]
		public string GetSkinId([Optional] string tmplId)
		{
			return null;
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C6")]
		[Address(RVA = "0x1EF3660", Offset = "0x1EF2260", VA = "0x181EF3660")]
		public Dictionary<string, int> GetMasterDict()
		{
			return null;
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C7")]
		[Address(RVA = "0x1EF34C0", Offset = "0x1EF20C0", VA = "0x181EF34C0")]
		public ListDict<string, PlayerCharEquipInfo> GetEquips([Optional] string tmplId)
		{
			return null;
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C8")]
		[Address(RVA = "0x1EF3270", Offset = "0x1EF1E70", VA = "0x181EF3270")]
		public string GetEquipId([Optional] string tmplId)
		{
			return null;
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x00030858 File Offset: 0x0002EA58
		[Token(Token = "0x60065C9")]
		[Address(RVA = "0x1EF2F10", Offset = "0x1EF1B10", VA = "0x181EF2F10")]
		public int GetCurEquipLevel([Optional] string tmplId)
		{
			return 0;
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x00030870 File Offset: 0x0002EA70
		[Token(Token = "0x60065CA")]
		[Address(RVA = "0x1EF3850", Offset = "0x1EF2450", VA = "0x181EF3850")]
		public VoiceLangType GetVoiceLan([Optional] string tmplId)
		{
			return VoiceLangType.NONE;
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x00030888 File Offset: 0x0002EA88
		[Token(Token = "0x60065CB")]
		[Address(RVA = "0x1EF3940", Offset = "0x1EF2540", VA = "0x181EF3940")]
		public bool IsTmplUnlocked(string tmplId)
		{
			return default(bool);
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x000308A0 File Offset: 0x0002EAA0
		[Token(Token = "0x60065CC")]
		[Address(RVA = "0x1EF38C0", Offset = "0x1EF24C0", VA = "0x181EF38C0")]
		public bool HasMultiTmpls()
		{
			return default(bool);
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065CD")]
		[Address(RVA = "0x1EF3A80", Offset = "0x1EF2680", VA = "0x181EF3A80")]
		public PlayerCharacter ShallowClone()
		{
			return null;
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CE")]
		[Address(RVA = "0x1EF3B60", Offset = "0x1EF2760", VA = "0x181EF3B60")]
		public PlayerCharacter()
		{
		}

		// Token: 0x04003360 RID: 13152
		[Token(Token = "0x4003360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x04003361 RID: 13153
		[Token(Token = "0x4003361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x04003362 RID: 13154
		[Token(Token = "0x4003362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int level;

		// Token: 0x04003363 RID: 13155
		[Token(Token = "0x4003363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int exp;

		// Token: 0x04003364 RID: 13156
		[Token(Token = "0x4003364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EvolvePhase evolvePhase;

		// Token: 0x04003365 RID: 13157
		[Token(Token = "0x4003365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int potentialRank;

		// Token: 0x04003366 RID: 13158
		[Token(Token = "0x4003366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int favorPoint;

		// Token: 0x04003367 RID: 13159
		[Token(Token = "0x4003367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int mainSkillLvl;

		// Token: 0x04003368 RID: 13160
		[Token(Token = "0x4003368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long gainTime;

		// Token: 0x04003369 RID: 13161
		[Token(Token = "0x4003369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CharStarMarkState starMark;

		// Token: 0x0400336A RID: 13162
		[Token(Token = "0x400336A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string currentTmpl;

		// Token: 0x0400336B RID: 13163
		[Token(Token = "0x400336B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ListDict<string, PlayerCharPatch> tmpl;

		// Token: 0x0400336C RID: 13164
		[Token(Token = "0x400336C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[JsonProperty("skills")]
		private PlayerCharSkill[] m_skills;

		// Token: 0x0400336D RID: 13165
		[Token(Token = "0x400336D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[JsonProperty("defaultSkillIndex")]
		private int m_defaultSkillIndex;

		// Token: 0x0400336E RID: 13166
		[Token(Token = "0x400336E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[JsonProperty("skin")]
		private string m_skinId;

		// Token: 0x0400336F RID: 13167
		[Token(Token = "0x400336F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[JsonProperty("currentEquip")]
		private string m_selectEquip;

		// Token: 0x04003370 RID: 13168
		[Token(Token = "0x4003370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[JsonProperty("equip")]
		private ListDict<string, PlayerCharEquipInfo> m_equips;

		// Token: 0x04003371 RID: 13169
		[Token(Token = "0x4003371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[JsonProperty("master")]
		private Dictionary<string, int> m_masterDict;

		// Token: 0x04003372 RID: 13170
		[Token(Token = "0x4003372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[JsonProperty("voiceLan")]
		private VoiceLangType m_voiceLan;

		// Token: 0x04003373 RID: 13171
		[Token(Token = "0x4003373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFinalSkillLvl;

		// Token: 0x04003374 RID: 13172
		[Token(Token = "0x4003374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetEquipLvl;

		// Token: 0x04003375 RID: 13173
		[Token(Token = "0x4003375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SafeTmpl;

		// Token: 0x04003376 RID: 13174
		[Token(Token = "0x4003376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCurSkills;

		// Token: 0x04003377 RID: 13175
		[Token(Token = "0x4003377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSkills;

		// Token: 0x04003378 RID: 13176
		[Token(Token = "0x4003378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDefaultSkillIndex;

		// Token: 0x04003379 RID: 13177
		[Token(Token = "0x4003379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDefaultSkillIndexByTmpl;

		// Token: 0x0400337A RID: 13178
		[Token(Token = "0x400337A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetSkinId;

		// Token: 0x0400337B RID: 13179
		[Token(Token = "0x400337B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetMasterDict;

		// Token: 0x0400337C RID: 13180
		[Token(Token = "0x400337C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetEquips;

		// Token: 0x0400337D RID: 13181
		[Token(Token = "0x400337D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetEquipId;

		// Token: 0x0400337E RID: 13182
		[Token(Token = "0x400337E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetCurEquipLevel;

		// Token: 0x0400337F RID: 13183
		[Token(Token = "0x400337F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetVoiceLan;

		// Token: 0x04003380 RID: 13184
		[Token(Token = "0x4003380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_IsTmplUnlocked;

		// Token: 0x04003381 RID: 13185
		[Token(Token = "0x4003381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HasMultiTmpls;

		// Token: 0x04003382 RID: 13186
		[Token(Token = "0x4003382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ShallowClone;

		// Token: 0x04003383 RID: 13187
		[Token(Token = "0x4003383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020008F9 RID: 2297
		[Token(Token = "0x20008F9")]
		public struct BasicDataBuilder
		{
			// Token: 0x060065CF RID: 26063 RVA: 0x000308B8 File Offset: 0x0002EAB8
			[Token(Token = "0x60065CF")]
			[Address(RVA = "0x1EE6A90", Offset = "0x1EE5690", VA = "0x181EE6A90")]
			public static PlayerCharacter.BasicDataBuilder FromSharedCharacter(SharedCharData sharedCharacter, bool withPotential = false)
			{
				return default(PlayerCharacter.BasicDataBuilder);
			}

			// Token: 0x060065D0 RID: 26064 RVA: 0x000308D0 File Offset: 0x0002EAD0
			[Token(Token = "0x60065D0")]
			[Address(RVA = "0x1EE6B50", Offset = "0x1EE5750", VA = "0x181EE6B50")]
			private static PlayerCharacter.PatchBuilder _GenSkillEquipPatchBuilder(SharedCharData sharedCharacter)
			{
				return default(PlayerCharacter.PatchBuilder);
			}

			// Token: 0x060065D1 RID: 26065 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60065D1")]
			[Address(RVA = "0x1EE6A10", Offset = "0x1EE5610", VA = "0x181EE6A10")]
			public PlayerCharacter BuildTo(PlayerCharacter playerCharacter)
			{
				return null;
			}

			// Token: 0x04003384 RID: 13188
			[Token(Token = "0x4003384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string currentTmpl;

			// Token: 0x04003385 RID: 13189
			[Token(Token = "0x4003385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int mainSkillLvl;

			// Token: 0x04003386 RID: 13190
			[Token(Token = "0x4003386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public EvolvePhase evolvePhase;

			// Token: 0x04003387 RID: 13191
			[Token(Token = "0x4003387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int level;

			// Token: 0x04003388 RID: 13192
			[Token(Token = "0x4003388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string charId;

			// Token: 0x04003389 RID: 13193
			[Token(Token = "0x4003389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int potentialRank;

			// Token: 0x0400338A RID: 13194
			[Token(Token = "0x400338A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PlayerCharacter.PatchBuilder skillEquipBuilder;
		}

		// Token: 0x020008FA RID: 2298
		[Token(Token = "0x20008FA")]
		public struct PatchBuilder
		{
			// Token: 0x060065D2 RID: 26066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065D2")]
			[Address(RVA = "0x1EED170", Offset = "0x1EEBD70", VA = "0x181EED170")]
			public void BuildTo(PlayerCharacter playerChar)
			{
			}

			// Token: 0x0400338B RID: 13195
			[Token(Token = "0x400338B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string skinId;

			// Token: 0x0400338C RID: 13196
			[Token(Token = "0x400338C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int defaultSkillIndex;

			// Token: 0x0400338D RID: 13197
			[Token(Token = "0x400338D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string defaultEquipId;

			// Token: 0x0400338E RID: 13198
			[Token(Token = "0x400338E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayerCharSkill[] skills;

			// Token: 0x0400338F RID: 13199
			[Token(Token = "0x400338F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ListDict<string, PlayerCharEquipInfo> equips;
		}
	}
}
