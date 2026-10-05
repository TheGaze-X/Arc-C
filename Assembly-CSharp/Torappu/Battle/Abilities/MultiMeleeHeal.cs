using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AD6 RID: 10966
	[Token(Token = "0x2002AD6")]
	public class MultiMeleeHeal : Heal
	{
		// Token: 0x06012474 RID: 74868 RVA: 0x0006FFD8 File Offset: 0x0006E1D8
		[Token(Token = "0x6012474")]
		[Address(RVA = "0xA57960", Offset = "0xA56560", VA = "0x180A57960", Slot = "87")]
		protected override bool CheckAnotherSpell(int spellCnt)
		{
			return default(bool);
		}

		// Token: 0x06012475 RID: 74869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012475")]
		[Address(RVA = "0xA579D0", Offset = "0xA565D0", VA = "0x180A579D0", Slot = "91")]
		protected override void DoEmitAudioSignalForSpellOn()
		{
		}

		// Token: 0x06012476 RID: 74870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012476")]
		[Address(RVA = "0xA57B40", Offset = "0xA56740", VA = "0x180A57B40", Slot = "77")]
		protected override IEnumerator OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x06012477 RID: 74871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012477")]
		[Address(RVA = "0xA57BF0", Offset = "0xA567F0", VA = "0x180A57BF0")]
		public MultiMeleeHeal()
		{
		}

		// Token: 0x06012478 RID: 74872 RVA: 0x0006FFF0 File Offset: 0x0006E1F0
		[Token(Token = "0x6012478")]
		[Address(RVA = "0xA1FD00", Offset = "0xA1E900", VA = "0x180A1FD00")]
		private bool <>xLuaBaseProxy_CheckAnotherSpell(int P0)
		{
			return default(bool);
		}

		// Token: 0x06012479 RID: 74873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012479")]
		[Address(RVA = "0xA275A0", Offset = "0xA261A0", VA = "0x180A275A0")]
		private void <>xLuaBaseProxy_DoEmitAudioSignalForSpellOn()
		{
		}

		// Token: 0x0601247A RID: 74874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601247A")]
		[Address(RVA = "0xA1FD60", Offset = "0xA1E960", VA = "0x180A1FD60")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForTriggerDelta()
		{
			return null;
		}

		// Token: 0x04014AB6 RID: 84662
		[Token(Token = "0x4014AB6")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[Group("Multi")]
		private int _additionalTimes;

		// Token: 0x04014AB7 RID: 84663
		[Token(Token = "0x4014AB7")]
		[FieldOffset(Offset = "0x1FC")]
		[SerializeField]
		[Group("Multi")]
		private float _triggerDelta;

		// Token: 0x04014AB8 RID: 84664
		[Token(Token = "0x4014AB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckAnotherSpell;

		// Token: 0x04014AB9 RID: 84665
		[Token(Token = "0x4014AB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoEmitAudioSignalForSpellOn;

		// Token: 0x04014ABA RID: 84666
		[Token(Token = "0x4014ABA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnWaitForTriggerDelta;

		// Token: 0x04014ABB RID: 84667
		[Token(Token = "0x4014ABB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
