using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B2E RID: 11054
	[Token(Token = "0x2002B2E")]
	public class ArcbankGlobalAuraAbility : GlobalAuraAbility
	{
		// Token: 0x0601286C RID: 75884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601286C")]
		[Address(RVA = "0xA7ABF0", Offset = "0xA797F0", VA = "0x180A7ABF0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x0601286D RID: 75885 RVA: 0x00071910 File Offset: 0x0006FB10
		[Token(Token = "0x601286D")]
		[Address(RVA = "0xA7A8F0", Offset = "0xA794F0", VA = "0x180A7A8F0", Slot = "97")]
		protected override bool DealTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0601286E RID: 75886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601286E")]
		[Address(RVA = "0xA7AD70", Offset = "0xA79970", VA = "0x180A7AD70")]
		public ArcbankGlobalAuraAbility()
		{
		}

		// Token: 0x0601286F RID: 75887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601286F")]
		[Address(RVA = "0xA7AD40", Offset = "0xA79940", VA = "0x180A7AD40")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012870 RID: 75888 RVA: 0x00071928 File Offset: 0x0006FB28
		[Token(Token = "0x6012870")]
		[Address(RVA = "0xA7AD30", Offset = "0xA79930", VA = "0x180A7AD30")]
		private bool <>xLuaBaseProxy_DealTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04014EF9 RID: 85753
		[Token(Token = "0x4014EF9")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private string _blackboardKey;

		// Token: 0x04014EFA RID: 85754
		[Token(Token = "0x4014EFA")]
		[FieldOffset(Offset = "0x188")]
		private Blackboard m_extraBlackboard;

		// Token: 0x04014EFB RID: 85755
		[Token(Token = "0x4014EFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014EFC RID: 85756
		[Token(Token = "0x4014EFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DealTarget;

		// Token: 0x04014EFD RID: 85757
		[Token(Token = "0x4014EFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
