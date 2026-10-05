using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu
{
	// Token: 0x02001055 RID: 4181
	[Token(Token = "0x2001055")]
	[Serializable]
	public class SharedCharData : IHotfixable
	{
		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06006DBD RID: 28093 RVA: 0x00031D88 File Offset: 0x0002FF88
		// (set) Token: 0x06006DBE RID: 28094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D1A")]
		[JsonIgnore]
		public int FBOnly_skillIndex
		{
			[Token(Token = "0x6006DBD")]
			[Address(RVA = "0x21160B0", Offset = "0x2114CB0", VA = "0x1821160B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006DBE")]
			[Address(RVA = "0x21162D0", Offset = "0x2114ED0", VA = "0x1821162D0")]
			set
			{
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06006DBF RID: 28095 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006DC0 RID: 28096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D1B")]
		[JsonIgnore]
		public string FBOnly_skinId
		{
			[Token(Token = "0x6006DBF")]
			[Address(RVA = "0x2116170", Offset = "0x2114D70", VA = "0x182116170")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006DC0")]
			[Address(RVA = "0x21163C0", Offset = "0x2114FC0", VA = "0x1821163C0")]
			set
			{
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06006DC1 RID: 28097 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006DC2 RID: 28098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D1C")]
		[JsonIgnore]
		public SharedCharData.SharedCharSkillData[] FBOnly_skills
		{
			[Token(Token = "0x6006DC1")]
			[Address(RVA = "0x2116110", Offset = "0x2114D10", VA = "0x182116110")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006DC2")]
			[Address(RVA = "0x2116340", Offset = "0x2114F40", VA = "0x182116340")]
			set
			{
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06006DC3 RID: 28099 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006DC4 RID: 28100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D1D")]
		[JsonIgnore]
		public string FBOnly_currentEquip
		{
			[Token(Token = "0x6006DC3")]
			[Address(RVA = "0x2115FF0", Offset = "0x2114BF0", VA = "0x182115FF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006DC4")]
			[Address(RVA = "0x21161D0", Offset = "0x2114DD0", VA = "0x1821161D0")]
			set
			{
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06006DC5 RID: 28101 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006DC6 RID: 28102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D1E")]
		[JsonIgnore]
		public ListDict<string, SharedCharData.CharEquipInfo> FBOnly_equip
		{
			[Token(Token = "0x6006DC5")]
			[Address(RVA = "0x2116050", Offset = "0x2114C50", VA = "0x182116050")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006DC6")]
			[Address(RVA = "0x2116250", Offset = "0x2114E50", VA = "0x182116250")]
			set
			{
			}
		}

		// Token: 0x06006DC7 RID: 28103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DC7")]
		[Address(RVA = "0x2115A00", Offset = "0x2114600", VA = "0x182115A00")]
		public SharedCharData.TmplData SafeTmpl(string tmplId)
		{
			return null;
		}

		// Token: 0x06006DC8 RID: 28104 RVA: 0x00031DA0 File Offset: 0x0002FFA0
		[Token(Token = "0x6006DC8")]
		[Address(RVA = "0x2115760", Offset = "0x2114360", VA = "0x182115760")]
		public int GetSkillIndex(bool forceFriendSet = false)
		{
			return 0;
		}

		// Token: 0x06006DC9 RID: 28105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DC9")]
		[Address(RVA = "0x21158C0", Offset = "0x21144C0", VA = "0x1821158C0")]
		public string GetSkinId()
		{
			return null;
		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCA")]
		[Address(RVA = "0x2115830", Offset = "0x2114430", VA = "0x182115830")]
		public SharedCharData.SharedCharSkillData[] GetSkills()
		{
			return null;
		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCB")]
		[Address(RVA = "0x2115630", Offset = "0x2114230", VA = "0x182115630")]
		public SharedCharData.SharedCharSkillData GetSelectSkill(bool forceFriendSet = false)
		{
			return null;
		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x00031DB8 File Offset: 0x0002FFB8
		[Token(Token = "0x6006DCC")]
		[Address(RVA = "0x2115950", Offset = "0x2114550", VA = "0x182115950")]
		public bool HaveEquip()
		{
			return default(bool);
		}

		// Token: 0x06006DCD RID: 28109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCD")]
		[Address(RVA = "0x21152A0", Offset = "0x2113EA0", VA = "0x1821152A0")]
		public ListDict<string, SharedCharData.CharEquipInfo> GetEquips()
		{
			return null;
		}

		// Token: 0x06006DCE RID: 28110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCE")]
		[Address(RVA = "0x2115330", Offset = "0x2113F30", VA = "0x182115330")]
		public string GetSelectEquipId(bool forceFriendSet = false)
		{
			return null;
		}

		// Token: 0x06006DCF RID: 28111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCF")]
		[Address(RVA = "0x2115430", Offset = "0x2114030", VA = "0x182115430")]
		public SharedCharData.CharEquipInfo GetSelectEquipInfo(bool forceFriendSet = false)
		{
			return null;
		}

		// Token: 0x06006DD0 RID: 28112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD0")]
		[Address(RVA = "0x2115C40", Offset = "0x2114840", VA = "0x182115C40")]
		public void SetSelectEquipId(string equipId)
		{
		}

		// Token: 0x06006DD1 RID: 28113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD1")]
		[Address(RVA = "0x2115B70", Offset = "0x2114770", VA = "0x182115B70")]
		public void SetOverrideSkillIndex(int index)
		{
		}

		// Token: 0x06006DD2 RID: 28114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD2")]
		[Address(RVA = "0x2115AA0", Offset = "0x21146A0", VA = "0x182115AA0")]
		public void SetOverrideEquipId(string equip)
		{
		}

		// Token: 0x06006DD3 RID: 28115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD3")]
		[Address(RVA = "0x21150E0", Offset = "0x2113CE0", VA = "0x1821150E0")]
		public void ApplyModifiedCharData()
		{
		}

		// Token: 0x06006DD4 RID: 28116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD4")]
		private static T _SafeGet<T>(IList<T> list, int index, [Optional] T defaultVal)
		{
			return null;
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x00031DD0 File Offset: 0x0002FFD0
		[Token(Token = "0x6006DD5")]
		[Address(RVA = "0x2115E50", Offset = "0x2114A50", VA = "0x182115E50")]
		private int _TryGetOverrideSkillIndex(bool forceFriendSet = false)
		{
			return 0;
		}

		// Token: 0x06006DD6 RID: 28118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD6")]
		[Address(RVA = "0x2115DB0", Offset = "0x21149B0", VA = "0x182115DB0")]
		private string _TryGetOverrideEquipId(bool forceFriendSet = false)
		{
			return null;
		}

		// Token: 0x06006DD7 RID: 28119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD7")]
		[Address(RVA = "0x2115D10", Offset = "0x2114910", VA = "0x182115D10")]
		private void _SetSelectedSkillIndex(int index)
		{
		}

		// Token: 0x06006DD8 RID: 28120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD8")]
		[Address(RVA = "0x2115ED0", Offset = "0x2114AD0", VA = "0x182115ED0")]
		public SharedCharData()
		{
		}

		// Token: 0x040058D8 RID: 22744
		[Token(Token = "0x40058D8")]
		private const int INVALID_SKILL_INDEX = -1;

		// Token: 0x040058D9 RID: 22745
		[Token(Token = "0x40058D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x040058DA RID: 22746
		[Token(Token = "0x40058DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int potentialRank;

		// Token: 0x040058DB RID: 22747
		[Token(Token = "0x40058DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[JsonProperty("skillIndex")]
		private int m_skillIndex;

		// Token: 0x040058DC RID: 22748
		[Token(Token = "0x40058DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[JsonProperty("skinId")]
		private string m_skinId;

		// Token: 0x040058DD RID: 22749
		[Token(Token = "0x40058DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[JsonProperty("skills")]
		private SharedCharData.SharedCharSkillData[] m_skills;

		// Token: 0x040058DE RID: 22750
		[Token(Token = "0x40058DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[JsonProperty("currentEquip")]
		private string m_selectEquip;

		// Token: 0x040058DF RID: 22751
		[Token(Token = "0x40058DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[JsonProperty("equip")]
		private ListDict<string, SharedCharData.CharEquipInfo> m_equips;

		// Token: 0x040058E0 RID: 22752
		[Token(Token = "0x40058E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int mainSkillLvl;

		// Token: 0x040058E1 RID: 22753
		[Token(Token = "0x40058E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int evolvePhase;

		// Token: 0x040058E2 RID: 22754
		[Token(Token = "0x40058E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int level;

		// Token: 0x040058E3 RID: 22755
		[Token(Token = "0x40058E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int favorPoint;

		// Token: 0x040058E4 RID: 22756
		[Token(Token = "0x40058E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Dictionary<string, int> crisisRecord;

		// Token: 0x040058E5 RID: 22757
		[Token(Token = "0x40058E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Dictionary<string, int> crisisV2Record;

		// Token: 0x040058E6 RID: 22758
		[Token(Token = "0x40058E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string currentTmpl;

		// Token: 0x040058E7 RID: 22759
		[Token(Token = "0x40058E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ListDict<string, SharedCharData.TmplData> tmpl;

		// Token: 0x040058E8 RID: 22760
		[Token(Token = "0x40058E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[JsonIgnore]
		public int overrideSkillIndex;

		// Token: 0x040058E9 RID: 22761
		[Token(Token = "0x40058E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[JsonIgnore]
		public string overrideEquipId;

		// Token: 0x040058EA RID: 22762
		[Token(Token = "0x40058EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_FBOnly_skillIndex;

		// Token: 0x040058EB RID: 22763
		[Token(Token = "0x40058EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_FBOnly_skillIndex;

		// Token: 0x040058EC RID: 22764
		[Token(Token = "0x40058EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_FBOnly_skinId;

		// Token: 0x040058ED RID: 22765
		[Token(Token = "0x40058ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_FBOnly_skinId;

		// Token: 0x040058EE RID: 22766
		[Token(Token = "0x40058EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_FBOnly_skills;

		// Token: 0x040058EF RID: 22767
		[Token(Token = "0x40058EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_FBOnly_skills;

		// Token: 0x040058F0 RID: 22768
		[Token(Token = "0x40058F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_FBOnly_currentEquip;

		// Token: 0x040058F1 RID: 22769
		[Token(Token = "0x40058F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_FBOnly_currentEquip;

		// Token: 0x040058F2 RID: 22770
		[Token(Token = "0x40058F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_FBOnly_equip;

		// Token: 0x040058F3 RID: 22771
		[Token(Token = "0x40058F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_FBOnly_equip;

		// Token: 0x040058F4 RID: 22772
		[Token(Token = "0x40058F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SafeTmpl;

		// Token: 0x040058F5 RID: 22773
		[Token(Token = "0x40058F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetSkillIndex;

		// Token: 0x040058F6 RID: 22774
		[Token(Token = "0x40058F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetSkinId;

		// Token: 0x040058F7 RID: 22775
		[Token(Token = "0x40058F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetSkills;

		// Token: 0x040058F8 RID: 22776
		[Token(Token = "0x40058F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetSelectSkill;

		// Token: 0x040058F9 RID: 22777
		[Token(Token = "0x40058F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_HaveEquip;

		// Token: 0x040058FA RID: 22778
		[Token(Token = "0x40058FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetEquips;

		// Token: 0x040058FB RID: 22779
		[Token(Token = "0x40058FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetSelectEquipId;

		// Token: 0x040058FC RID: 22780
		[Token(Token = "0x40058FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetSelectEquipInfo;

		// Token: 0x040058FD RID: 22781
		[Token(Token = "0x40058FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SetSelectEquipId;

		// Token: 0x040058FE RID: 22782
		[Token(Token = "0x40058FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetOverrideSkillIndex;

		// Token: 0x040058FF RID: 22783
		[Token(Token = "0x40058FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SetOverrideEquipId;

		// Token: 0x04005900 RID: 22784
		[Token(Token = "0x4005900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ApplyModifiedCharData;

		// Token: 0x04005901 RID: 22785
		[Token(Token = "0x4005901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SafeGet;

		// Token: 0x04005902 RID: 22786
		[Token(Token = "0x4005902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__TryGetOverrideSkillIndex;

		// Token: 0x04005903 RID: 22787
		[Token(Token = "0x4005903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__TryGetOverrideEquipId;

		// Token: 0x04005904 RID: 22788
		[Token(Token = "0x4005904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__SetSelectedSkillIndex;

		// Token: 0x04005905 RID: 22789
		[Token(Token = "0x4005905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001056 RID: 4182
		[Token(Token = "0x2001056")]
		[Serializable]
		public class SharedCharSkillData
		{
			// Token: 0x06006DD9 RID: 28121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DD9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SharedCharSkillData()
			{
			}

			// Token: 0x04005906 RID: 22790
			[Token(Token = "0x4005906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string skillId;

			// Token: 0x04005907 RID: 22791
			[Token(Token = "0x4005907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int specializeLevel;
		}

		// Token: 0x02001057 RID: 4183
		[Token(Token = "0x2001057")]
		[Serializable]
		public class TmplData
		{
			// Token: 0x06006DDA RID: 28122 RVA: 0x00031DE8 File Offset: 0x0002FFE8
			[Token(Token = "0x6006DDA")]
			[Address(RVA = "0x21171A0", Offset = "0x2115DA0", VA = "0x1821171A0")]
			public int TryGetOverrideSkillIndex(bool forceFriendSet = false)
			{
				return 0;
			}

			// Token: 0x06006DDB RID: 28123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006DDB")]
			[Address(RVA = "0x2117170", Offset = "0x2115D70", VA = "0x182117170")]
			public string TryGetOverrideEquipId(bool forceFriendSet = false)
			{
				return null;
			}

			// Token: 0x06006DDC RID: 28124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DDC")]
			[Address(RVA = "0x21171B0", Offset = "0x2115DB0", VA = "0x1821171B0")]
			public TmplData()
			{
			}

			// Token: 0x04005908 RID: 22792
			[Token(Token = "0x4005908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int skillIndex;

			// Token: 0x04005909 RID: 22793
			[Token(Token = "0x4005909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string skinId;

			// Token: 0x0400590A RID: 22794
			[Token(Token = "0x400590A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SharedCharData.SharedCharSkillData[] skills;

			// Token: 0x0400590B RID: 22795
			[Token(Token = "0x400590B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[JsonProperty("currentEquip")]
			public string selectEquip;

			// Token: 0x0400590C RID: 22796
			[Token(Token = "0x400590C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[JsonProperty("equip")]
			public ListDict<string, SharedCharData.CharEquipInfo> equips;

			// Token: 0x0400590D RID: 22797
			[Token(Token = "0x400590D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[JsonIgnore]
			public int overrideSkillIndex;

			// Token: 0x0400590E RID: 22798
			[Token(Token = "0x400590E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[JsonIgnore]
			public string overrideEquipId;
		}

		// Token: 0x02001058 RID: 4184
		[Token(Token = "0x2001058")]
		[Serializable]
		public class CharEquipInfo
		{
			// Token: 0x06006DDD RID: 28125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DDD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharEquipInfo()
			{
			}

			// Token: 0x0400590F RID: 22799
			[Token(Token = "0x400590F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool locked;

			// Token: 0x04005910 RID: 22800
			[Token(Token = "0x4005910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int level;
		}

		// Token: 0x02001059 RID: 4185
		[Token(Token = "0x2001059")]
		public struct TmplModifier
		{
			// Token: 0x06006DDE RID: 28126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DDE")]
			[Address(RVA = "0x21172A0", Offset = "0x2115EA0", VA = "0x1821172A0")]
			public void SetSkills(SharedCharData.SharedCharSkillData[] skills)
			{
			}

			// Token: 0x06006DDF RID: 28127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DDF")]
			[Address(RVA = "0x2117210", Offset = "0x2115E10", VA = "0x182117210")]
			public void ApplyTo(SharedCharData data)
			{
			}

			// Token: 0x04005911 RID: 22801
			[Token(Token = "0x4005911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int skillIndex;

			// Token: 0x04005912 RID: 22802
			[Token(Token = "0x4005912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private SharedCharData.SharedCharSkillData[] m_skills;

			// Token: 0x04005913 RID: 22803
			[Token(Token = "0x4005913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool m_isSkillsChanged;
		}
	}
}
