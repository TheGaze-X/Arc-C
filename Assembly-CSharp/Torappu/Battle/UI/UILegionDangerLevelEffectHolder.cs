using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003389 RID: 13193
	[Token(Token = "0x2003389")]
	public class UILegionDangerLevelEffectHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601509A RID: 86170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601509A")]
		[Address(RVA = "0xD77930", Offset = "0xD76530", VA = "0x180D77930")]
		public void UpdateLevelEffect(int level)
		{
		}

		// Token: 0x0601509B RID: 86171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601509B")]
		[Address(RVA = "0xD778B0", Offset = "0xD764B0", VA = "0x180D778B0")]
		public void InitEffect(int initLevel)
		{
		}

		// Token: 0x0601509C RID: 86172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601509C")]
		[Address(RVA = "0xD780F0", Offset = "0xD76CF0", VA = "0x180D780F0")]
		private void _PlayUpgradeEffect(int level)
		{
		}

		// Token: 0x0601509D RID: 86173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601509D")]
		[Address(RVA = "0xD77AC0", Offset = "0xD766C0", VA = "0x180D77AC0")]
		private void _ChangeStepEffect(int level)
		{
		}

		// Token: 0x0601509E RID: 86174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601509E")]
		[Address(RVA = "0xD77CB0", Offset = "0xD768B0", VA = "0x180D77CB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601509F RID: 86175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601509F")]
		[Address(RVA = "0xD78200", Offset = "0xD76E00", VA = "0x180D78200")]
		public UILegionDangerLevelEffectHolder()
		{
		}

		// Token: 0x04019099 RID: 102553
		[Token(Token = "0x4019099")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _effectUpgradeLoad;

		// Token: 0x0401909A RID: 102554
		[Token(Token = "0x401909A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<UILegionDangerLevelEffectHolder.StepEffectData> _stepEffects;

		// Token: 0x0401909B RID: 102555
		[Token(Token = "0x401909B")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystem m_effectUpgrade;

		// Token: 0x0401909C RID: 102556
		[Token(Token = "0x401909C")]
		[FieldOffset(Offset = "0x30")]
		private List<UILegionDangerLevelEffectHolder.StepEffectData> m_stepEffectInsts;

		// Token: 0x0401909D RID: 102557
		[Token(Token = "0x401909D")]
		[FieldOffset(Offset = "0x38")]
		private int m_nextStep;

		// Token: 0x0401909E RID: 102558
		[Token(Token = "0x401909E")]
		[FieldOffset(Offset = "0x3C")]
		private int m_lastlevel;

		// Token: 0x0401909F RID: 102559
		[Token(Token = "0x401909F")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_lastSetpEffect;

		// Token: 0x040190A0 RID: 102560
		[Token(Token = "0x40190A0")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isMaxStep;

		// Token: 0x040190A1 RID: 102561
		[Token(Token = "0x40190A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateLevelEffect;

		// Token: 0x040190A2 RID: 102562
		[Token(Token = "0x40190A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitEffect;

		// Token: 0x040190A3 RID: 102563
		[Token(Token = "0x40190A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayUpgradeEffect;

		// Token: 0x040190A4 RID: 102564
		[Token(Token = "0x40190A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ChangeStepEffect;

		// Token: 0x040190A5 RID: 102565
		[Token(Token = "0x40190A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040190A6 RID: 102566
		[Token(Token = "0x40190A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200338A RID: 13194
		[Token(Token = "0x200338A")]
		[Serializable]
		public struct StepEffectData
		{
			// Token: 0x040190A7 RID: 102567
			[Token(Token = "0x40190A7")]
			[FieldOffset(Offset = "0x0")]
			public int step;

			// Token: 0x040190A8 RID: 102568
			[Token(Token = "0x40190A8")]
			[FieldOffset(Offset = "0x8")]
			public GameObject _effect;
		}
	}
}
