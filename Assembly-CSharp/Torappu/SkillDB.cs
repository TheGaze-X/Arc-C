using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005D6 RID: 1494
	[Token(Token = "0x20005D6")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/SkillDB")]
	[Serializable]
	public class SkillDB : SimpleKVTable<SkillDataBundle, SkillDB>
	{
		// Token: 0x06006180 RID: 24960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006180")]
		[Address(RVA = "0x1DF4350", Offset = "0x1DF2F50", VA = "0x181DF4350")]
		public SkillData GetSkillOrDefault(string key, int lvl)
		{
			return null;
		}

		// Token: 0x06006181 RID: 24961 RVA: 0x0002FBF8 File Offset: 0x0002DDF8
		[Token(Token = "0x6006181")]
		[Address(RVA = "0x1DF4700", Offset = "0x1DF3300", VA = "0x181DF4700")]
		public bool TryGetSkill(CharacterData.MainSkill mainSkill, int lvl, out SkillData skillData)
		{
			return default(bool);
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x0002FC10 File Offset: 0x0002DE10
		[Token(Token = "0x6006182")]
		[Address(RVA = "0x1DF4660", Offset = "0x1DF3260", VA = "0x181DF4660")]
		public bool TryGetSkill(string key, int lvl, out SkillData skillData)
		{
			return default(bool);
		}

		// Token: 0x06006183 RID: 24963 RVA: 0x0002FC28 File Offset: 0x0002DE28
		[Token(Token = "0x6006183")]
		[Address(RVA = "0x1DF47B0", Offset = "0x1DF33B0", VA = "0x181DF47B0")]
		private bool _TryGetSkill(string key, int lvl, string overridePrefabKey, out SkillData skillData)
		{
			return default(bool);
		}

		// Token: 0x06006184 RID: 24964 RVA: 0x0002FC40 File Offset: 0x0002DE40
		[Token(Token = "0x6006184")]
		[Address(RVA = "0x1DF4460", Offset = "0x1DF3060", VA = "0x181DF4460")]
		public bool TryGetSkillBundle(string key, out SkillDataBundle skillBundle)
		{
			return default(bool);
		}

		// Token: 0x06006185 RID: 24965 RVA: 0x0002FC58 File Offset: 0x0002DE58
		[Token(Token = "0x6006185")]
		[Address(RVA = "0x1DF4510", Offset = "0x1DF3110", VA = "0x181DF4510")]
		public bool TryGetSkillOverrideRange(string key, int lvl, out string rangeId)
		{
			return default(bool);
		}

		// Token: 0x06006186 RID: 24966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006186")]
		[Address(RVA = "0x1DF48D0", Offset = "0x1DF34D0", VA = "0x181DF48D0")]
		public SkillDB()
		{
		}

		// Token: 0x04002B26 RID: 11046
		[Token(Token = "0x4002B26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSkillOrDefault;

		// Token: 0x04002B27 RID: 11047
		[Token(Token = "0x4002B27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryGetSkill;

		// Token: 0x04002B28 RID: 11048
		[Token(Token = "0x4002B28")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_TryGetSkill;

		// Token: 0x04002B29 RID: 11049
		[Token(Token = "0x4002B29")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryGetSkill;

		// Token: 0x04002B2A RID: 11050
		[Token(Token = "0x4002B2A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryGetSkillBundle;

		// Token: 0x04002B2B RID: 11051
		[Token(Token = "0x4002B2B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryGetSkillOverrideRange;

		// Token: 0x04002B2C RID: 11052
		[Token(Token = "0x4002B2C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
