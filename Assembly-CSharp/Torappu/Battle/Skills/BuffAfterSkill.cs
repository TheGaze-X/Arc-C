using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Skills
{
	// Token: 0x020028AC RID: 10412
	[Token(Token = "0x20028AC")]
	public class BuffAfterSkill : BasicSkill.Behaviour, IEffectSource, IBuffSource
	{
		// Token: 0x06011507 RID: 70919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011507")]
		[Address(RVA = "0x91D6C0", Offset = "0x91C2C0", VA = "0x18091D6C0", Slot = "9")]
		public override void OnSkillStart()
		{
		}

		// Token: 0x06011508 RID: 70920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011508")]
		[Address(RVA = "0x91D520", Offset = "0x91C120", VA = "0x18091D520", Slot = "10")]
		public override void OnSkillEnd()
		{
		}

		// Token: 0x06011509 RID: 70921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011509")]
		[Address(RVA = "0x91D4B0", Offset = "0x91C0B0", VA = "0x18091D4B0", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601150A RID: 70922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601150A")]
		[Address(RVA = "0x91D420", Offset = "0x91C020", VA = "0x18091D420", Slot = "17")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0601150B RID: 70923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601150B")]
		[Address(RVA = "0x91D790", Offset = "0x91C390", VA = "0x18091D790")]
		public BuffAfterSkill()
		{
		}

		// Token: 0x0601150C RID: 70924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601150C")]
		[Address(RVA = "0x91D780", Offset = "0x91C380", VA = "0x18091D780")]
		private void <>xLuaBaseProxy_OnSkillStart()
		{
		}

		// Token: 0x0601150D RID: 70925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601150D")]
		[Address(RVA = "0x91D770", Offset = "0x91C370", VA = "0x18091D770")]
		private void <>xLuaBaseProxy_OnSkillEnd()
		{
		}

		// Token: 0x04013583 RID: 79235
		[Token(Token = "0x4013583")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x04013584 RID: 79236
		[Token(Token = "0x4013584")]
		[FieldOffset(Offset = "0x28")]
		private bool m_waitForSkillEnd;

		// Token: 0x04013585 RID: 79237
		[Token(Token = "0x4013585")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnSkillStart;

		// Token: 0x04013586 RID: 79238
		[Token(Token = "0x4013586")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSkillEnd;

		// Token: 0x04013587 RID: 79239
		[Token(Token = "0x4013587")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013588 RID: 79240
		[Token(Token = "0x4013588")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04013589 RID: 79241
		[Token(Token = "0x4013589")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
