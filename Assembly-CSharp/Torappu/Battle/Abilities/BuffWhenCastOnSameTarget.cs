using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BE1 RID: 11233
	[Token(Token = "0x2002BE1")]
	public class BuffWhenCastOnSameTarget : AbilityStandard.Behaviour, IEffectSource, IBuffSource
	{
		// Token: 0x06012F80 RID: 77696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F80")]
		[Address(RVA = "0xADE5F0", Offset = "0xADD1F0", VA = "0x180ADE5F0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012F81 RID: 77697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F81")]
		[Address(RVA = "0xADE4D0", Offset = "0xADD0D0", VA = "0x180ADE4D0", Slot = "17")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012F82 RID: 77698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F82")]
		[Address(RVA = "0xADE580", Offset = "0xADD180", VA = "0x180ADE580", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012F83 RID: 77699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F83")]
		[Address(RVA = "0xADE890", Offset = "0xADD490", VA = "0x180ADE890")]
		public BuffWhenCastOnSameTarget()
		{
		}

		// Token: 0x06012F84 RID: 77700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F84")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x040156A1 RID: 87713
		[Token(Token = "0x40156A1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuffData[] _buffsWhenCastOnSameTarget;

		// Token: 0x040156A2 RID: 87714
		[Token(Token = "0x40156A2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuffData[] _buffsWhenSwitchTarget;

		// Token: 0x040156A3 RID: 87715
		[Token(Token = "0x40156A3")]
		[FieldOffset(Offset = "0x30")]
		private ObjectPtr<Entity> m_validCastTarget;

		// Token: 0x040156A4 RID: 87716
		[Token(Token = "0x40156A4")]
		[FieldOffset(Offset = "0x40")]
		private ObjectPtr<Entity> m_lastCastTarget;

		// Token: 0x040156A5 RID: 87717
		[Token(Token = "0x40156A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040156A6 RID: 87718
		[Token(Token = "0x40156A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x040156A7 RID: 87719
		[Token(Token = "0x40156A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040156A8 RID: 87720
		[Token(Token = "0x40156A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
