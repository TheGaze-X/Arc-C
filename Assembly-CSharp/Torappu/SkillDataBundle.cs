using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001323 RID: 4899
	[Token(Token = "0x2001323")]
	[Serializable]
	public class SkillDataBundle : ISkillData
	{
		// Token: 0x060072AE RID: 29358 RVA: 0x00032F58 File Offset: 0x00031158
		[Token(Token = "0x60072AE")]
		[Address(RVA = "0x2211620", Offset = "0x2210220", VA = "0x182211620")]
		public bool TryGetSkill(int skillLevel, string overridePrefabKey, out SkillData data)
		{
			return default(bool);
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x00032F70 File Offset: 0x00031170
		[Token(Token = "0x60072AF")]
		[Address(RVA = "0x2211950", Offset = "0x2210550", VA = "0x182211950")]
		private bool _TryGetInternal(int skillLevel, out SkillDataBundle.LevelData data)
		{
			return default(bool);
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B0")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public string GetSkillId()
		{
			return null;
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B1")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public string GetIconId()
		{
			return null;
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B2")]
		[Address(RVA = "0x22118F0", Offset = "0x22104F0", VA = "0x1822118F0")]
		private string _GetPrefabKey(SkillDataBundle.LevelData level, string overridePrefabKey, out bool isPrefabKeyOverrideen)
		{
			return null;
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072B3")]
		[Address(RVA = "0x2211A20", Offset = "0x2210620", VA = "0x182211A20")]
		public SkillDataBundle()
		{
		}

		// Token: 0x04006CA3 RID: 27811
		[Token(Token = "0x4006CA3")]
		[FieldOffset(Offset = "0x10")]
		public string skillId;

		// Token: 0x04006CA4 RID: 27812
		[Token(Token = "0x4006CA4")]
		[FieldOffset(Offset = "0x18")]
		public string iconId;

		// Token: 0x04006CA5 RID: 27813
		[Token(Token = "0x4006CA5")]
		[FieldOffset(Offset = "0x20")]
		public bool hidden;

		// Token: 0x04006CA6 RID: 27814
		[Token(Token = "0x4006CA6")]
		[FieldOffset(Offset = "0x28")]
		public List<SkillDataBundle.LevelData> levels;

		// Token: 0x02001324 RID: 4900
		[Token(Token = "0x2001324")]
		[Serializable]
		public class LevelData
		{
			// Token: 0x060072B4 RID: 29364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60072B4")]
			[Address(RVA = "0x22079C0", Offset = "0x22065C0", VA = "0x1822079C0")]
			public LevelData()
			{
			}

			// Token: 0x04006CA7 RID: 27815
			[Token(Token = "0x4006CA7")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04006CA8 RID: 27816
			[Token(Token = "0x4006CA8")]
			[FieldOffset(Offset = "0x18")]
			public string rangeId;

			// Token: 0x04006CA9 RID: 27817
			[Token(Token = "0x4006CA9")]
			[FieldOffset(Offset = "0x20")]
			public string description;

			// Token: 0x04006CAA RID: 27818
			[Token(Token = "0x4006CAA")]
			[FieldOffset(Offset = "0x28")]
			public SkillType skillType;

			// Token: 0x04006CAB RID: 27819
			[Token(Token = "0x4006CAB")]
			[FieldOffset(Offset = "0x2C")]
			public SkillDurationType durationType;

			// Token: 0x04006CAC RID: 27820
			[Token(Token = "0x4006CAC")]
			[FieldOffset(Offset = "0x30")]
			public SpData spData;

			// Token: 0x04006CAD RID: 27821
			[Token(Token = "0x4006CAD")]
			[FieldOffset(Offset = "0x38")]
			public string prefabId;

			// Token: 0x04006CAE RID: 27822
			[Token(Token = "0x4006CAE")]
			[FieldOffset(Offset = "0x40")]
			public ObscuredFloat duration;

			// Token: 0x04006CAF RID: 27823
			[Token(Token = "0x4006CAF")]
			[FieldOffset(Offset = "0x58")]
			public Blackboard blackboard;
		}
	}
}
