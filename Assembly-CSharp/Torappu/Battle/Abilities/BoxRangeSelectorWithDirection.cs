using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C44 RID: 11332
	[Token(Token = "0x2002C44")]
	public class BoxRangeSelectorWithDirection : AbilityStandard.Behaviour, IEffectSource
	{
		// Token: 0x06013233 RID: 78387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013233")]
		[Address(RVA = "0xB15440", Offset = "0xB14040", VA = "0x180B15440", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013234 RID: 78388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013234")]
		[Address(RVA = "0xB14EE0", Offset = "0xB13AE0", VA = "0x180B14EE0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013235 RID: 78389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013235")]
		[Address(RVA = "0xB14E40", Offset = "0xB13A40", VA = "0x180B14E40", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06013236 RID: 78390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013236")]
		[Address(RVA = "0xB155C0", Offset = "0xB141C0", VA = "0x180B155C0")]
		public BoxRangeSelectorWithDirection()
		{
		}

		// Token: 0x06013237 RID: 78391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013237")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06013238 RID: 78392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013238")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x040159D4 RID: 88532
		[Token(Token = "0x40159D4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _length;

		// Token: 0x040159D5 RID: 88533
		[Token(Token = "0x40159D5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _width;

		// Token: 0x040159D6 RID: 88534
		[Token(Token = "0x40159D6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _effect;

		// Token: 0x040159D7 RID: 88535
		[Token(Token = "0x40159D7")]
		[FieldOffset(Offset = "0x30")]
		private AbilityStandard m_abilityStandard;

		// Token: 0x040159D8 RID: 88536
		[Token(Token = "0x40159D8")]
		[FieldOffset(Offset = "0x38")]
		private ObjectPtr<Effect> m_effect;

		// Token: 0x040159D9 RID: 88537
		[Token(Token = "0x40159D9")]
		[FieldOffset(Offset = "0x48")]
		private FP m_length;

		// Token: 0x040159DA RID: 88538
		[Token(Token = "0x40159DA")]
		[FieldOffset(Offset = "0x50")]
		private FP m_width;

		// Token: 0x040159DB RID: 88539
		[Token(Token = "0x40159DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040159DC RID: 88540
		[Token(Token = "0x40159DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040159DD RID: 88541
		[Token(Token = "0x40159DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040159DE RID: 88542
		[Token(Token = "0x40159DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
