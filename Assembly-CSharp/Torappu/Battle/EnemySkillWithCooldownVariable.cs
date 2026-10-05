using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021FD RID: 8701
	[Token(Token = "0x20021FD")]
	[RequireComponent(typeof(Ability))]
	public class EnemySkillWithCooldownVariable : EnemySkill
	{
		// Token: 0x0600D9F4 RID: 55796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9F4")]
		[Address(RVA = "0x35F3680", Offset = "0x35F2280", VA = "0x1835F3680", Slot = "15")]
		public override void AssignData(LevelData.EnemyData.ESkillData data, Enemy owner)
		{
		}

		// Token: 0x0600D9F5 RID: 55797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9F5")]
		[Address(RVA = "0x35F3890", Offset = "0x35F2490", VA = "0x1835F3890")]
		private void _CollectCooldownList()
		{
		}

		// Token: 0x0600D9F6 RID: 55798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9F6")]
		[Address(RVA = "0x35F3750", Offset = "0x35F2350", VA = "0x1835F3750", Slot = "16")]
		public override void ResetSkillCooldownIfNeeded()
		{
		}

		// Token: 0x0600D9F7 RID: 55799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9F7")]
		[Address(RVA = "0x35F3A50", Offset = "0x35F2650", VA = "0x1835F3A50")]
		public EnemySkillWithCooldownVariable()
		{
		}

		// Token: 0x0600D9F8 RID: 55800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9F8")]
		[Address(RVA = "0x35F3870", Offset = "0x35F2470", VA = "0x1835F3870")]
		private void <>xLuaBaseProxy_AssignData(LevelData.EnemyData.ESkillData P0, Enemy P1)
		{
		}

		// Token: 0x0600D9F9 RID: 55801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9F9")]
		[Address(RVA = "0x35F3880", Offset = "0x35F2480", VA = "0x1835F3880")]
		private void <>xLuaBaseProxy_ResetSkillCooldownIfNeeded()
		{
		}

		// Token: 0x0400EB48 RID: 60232
		[Token(Token = "0x400EB48")]
		[FieldOffset(Offset = "0x90")]
		private List<float> m_cooldownSequenceList;

		// Token: 0x0400EB49 RID: 60233
		[Token(Token = "0x400EB49")]
		[FieldOffset(Offset = "0x98")]
		private int m_currentIndex;

		// Token: 0x0400EB4A RID: 60234
		[Token(Token = "0x400EB4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x0400EB4B RID: 60235
		[Token(Token = "0x400EB4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CollectCooldownList;

		// Token: 0x0400EB4C RID: 60236
		[Token(Token = "0x400EB4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetSkillCooldownIfNeeded;

		// Token: 0x0400EB4D RID: 60237
		[Token(Token = "0x400EB4D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
