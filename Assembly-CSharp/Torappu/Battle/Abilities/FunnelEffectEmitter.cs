using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BEE RID: 11246
	[Token(Token = "0x2002BEE")]
	public class FunnelEffectEmitter : AbstractEffectEmitter
	{
		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x06012FE8 RID: 77800 RVA: 0x000744F0 File Offset: 0x000726F0
		[Token(Token = "0x170029DF")]
		private bool useIdleBackEffect
		{
			[Token(Token = "0x6012FE8")]
			[Address(RVA = "0xAE4D10", Offset = "0xAE3910", VA = "0x180AE4D10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029E0 RID: 10720
		// (get) Token: 0x06012FE9 RID: 77801 RVA: 0x00074508 File Offset: 0x00072708
		[Token(Token = "0x170029E0")]
		private bool useOverloadEffect
		{
			[Token(Token = "0x6012FE9")]
			[Address(RVA = "0xAE4D70", Offset = "0xAE3970", VA = "0x180AE4D70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012FEA RID: 77802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FEA")]
		[Address(RVA = "0xAE31F0", Offset = "0xAE1DF0", VA = "0x180AE31F0", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012FEB RID: 77803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FEB")]
		[Address(RVA = "0xAE3330", Offset = "0xAE1F30", VA = "0x180AE3330", Slot = "5")]
		public override void Init(AbilityStandard ability)
		{
		}

		// Token: 0x06012FEC RID: 77804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FEC")]
		[Address(RVA = "0xAE3FE0", Offset = "0xAE2BE0", VA = "0x180AE3FE0")]
		private void Update()
		{
		}

		// Token: 0x06012FED RID: 77805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FED")]
		[Address(RVA = "0xAE45E0", Offset = "0xAE31E0", VA = "0x180AE45E0")]
		private void _UpdateFace(bool force)
		{
		}

		// Token: 0x06012FEE RID: 77806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FEE")]
		[Address(RVA = "0xAE3410", Offset = "0xAE2010", VA = "0x180AE3410", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012FEF RID: 77807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FEF")]
		[Address(RVA = "0xAE46F0", Offset = "0xAE32F0", VA = "0x180AE46F0")]
		private void _UpdateIdleEffect()
		{
		}

		// Token: 0x06012FF0 RID: 77808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012FF0")]
		[Address(RVA = "0xAE4460", Offset = "0xAE3060", VA = "0x180AE4460")]
		private Effect _PlayEffect(string effectKey)
		{
			return null;
		}

		// Token: 0x06012FF1 RID: 77809 RVA: 0x00074520 File Offset: 0x00072720
		[Token(Token = "0x6012FF1")]
		[Address(RVA = "0xAE4340", Offset = "0xAE2F40", VA = "0x180AE4340")]
		private bool _CheckOwnerOverloadState()
		{
			return default(bool);
		}

		// Token: 0x06012FF2 RID: 77810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FF2")]
		[Address(RVA = "0xAE4BE0", Offset = "0xAE37E0", VA = "0x180AE4BE0")]
		public FunnelEffectEmitter()
		{
		}

		// Token: 0x06012FF3 RID: 77811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FF3")]
		[Address(RVA = "0xAE3FD0", Offset = "0xAE2BD0", VA = "0x180AE3FD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x06012FF4 RID: 77812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FF4")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015735 RID: 87861
		[Token(Token = "0x4015735")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _useIdleBackEffect;

		// Token: 0x04015736 RID: 87862
		[Token(Token = "0x4015736")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] _idleEffect;

		// Token: 0x04015737 RID: 87863
		[Token(Token = "0x4015737")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Inspect("useIdleBackEffect")]
		private string[] _idleBackEffect;

		// Token: 0x04015738 RID: 87864
		[Token(Token = "0x4015738")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] _disappearEffect;

		// Token: 0x04015739 RID: 87865
		[Token(Token = "0x4015739")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string[] _appearEffect;

		// Token: 0x0401573A RID: 87866
		[Token(Token = "0x401573A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _useOverloadEffect;

		// Token: 0x0401573B RID: 87867
		[Token(Token = "0x401573B")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _setActiveFalseWhenPause;

		// Token: 0x0401573C RID: 87868
		[Token(Token = "0x401573C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Inspect("useOverloadEffect")]
		private string[] _overloadIdleEffect;

		// Token: 0x0401573D RID: 87869
		[Token(Token = "0x401573D")]
		[FieldOffset(Offset = "0x58")]
		private bool m_cachedIsBack;

		// Token: 0x0401573E RID: 87870
		[Token(Token = "0x401573E")]
		[FieldOffset(Offset = "0x59")]
		private bool m_isIdle;

		// Token: 0x0401573F RID: 87871
		[Token(Token = "0x401573F")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_isOwnerOverloading;

		// Token: 0x04015740 RID: 87872
		[Token(Token = "0x4015740")]
		[FieldOffset(Offset = "0x60")]
		private Character m_funnelOwner;

		// Token: 0x04015741 RID: 87873
		[Token(Token = "0x4015741")]
		[FieldOffset(Offset = "0x68")]
		private List<ObjectPtr<Effect>> m_idleEffect;

		// Token: 0x04015742 RID: 87874
		[Token(Token = "0x4015742")]
		[FieldOffset(Offset = "0x70")]
		private List<ObjectPtr<Effect>> m_idleBackEffect;

		// Token: 0x04015743 RID: 87875
		[Token(Token = "0x4015743")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useIdleBackEffect;

		// Token: 0x04015744 RID: 87876
		[Token(Token = "0x4015744")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_useOverloadEffect;

		// Token: 0x04015745 RID: 87877
		[Token(Token = "0x4015745")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015746 RID: 87878
		[Token(Token = "0x4015746")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04015747 RID: 87879
		[Token(Token = "0x4015747")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04015748 RID: 87880
		[Token(Token = "0x4015748")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateFace;

		// Token: 0x04015749 RID: 87881
		[Token(Token = "0x4015749")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401574A RID: 87882
		[Token(Token = "0x401574A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateIdleEffect;

		// Token: 0x0401574B RID: 87883
		[Token(Token = "0x401574B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayEffect;

		// Token: 0x0401574C RID: 87884
		[Token(Token = "0x401574C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckOwnerOverloadState;

		// Token: 0x0401574D RID: 87885
		[Token(Token = "0x401574D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
