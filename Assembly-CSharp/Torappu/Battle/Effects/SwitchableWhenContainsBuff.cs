using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003274 RID: 12916
	[Token(Token = "0x2003274")]
	public class SwitchableWhenContainsBuff : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x060147B5 RID: 83893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147B5")]
		[Address(RVA = "0xCBE590", Offset = "0xCBD190", VA = "0x180CBE590", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060147B6 RID: 83894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147B6")]
		[Address(RVA = "0xCBE400", Offset = "0xCBD000", VA = "0x180CBE400", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x060147B7 RID: 83895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147B7")]
		[Address(RVA = "0xCBE4A0", Offset = "0xCBD0A0", VA = "0x180CBE4A0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060147B8 RID: 83896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147B8")]
		[Address(RVA = "0xCBE3A0", Offset = "0xCBCFA0", VA = "0x180CBE3A0", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x060147B9 RID: 83897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147B9")]
		[Address(RVA = "0xCBE810", Offset = "0xCBD410", VA = "0x180CBE810")]
		public SwitchableWhenContainsBuff()
		{
		}

		// Token: 0x060147BA RID: 83898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147BA")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060147BB RID: 83899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147BB")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0401835E RID: 99166
		[Token(Token = "0x401835E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> _buffKeys;

		// Token: 0x0401835F RID: 99167
		[Token(Token = "0x401835F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _hookEffect;

		// Token: 0x04018360 RID: 99168
		[Token(Token = "0x4018360")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useFaceto;

		// Token: 0x04018361 RID: 99169
		[Token(Token = "0x4018361")]
		[FieldOffset(Offset = "0x38")]
		private ObjectPtr<Effect> m_hookEffect;

		// Token: 0x04018362 RID: 99170
		[Token(Token = "0x4018362")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018363 RID: 99171
		[Token(Token = "0x4018363")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018364 RID: 99172
		[Token(Token = "0x4018364")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018365 RID: 99173
		[Token(Token = "0x4018365")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x04018366 RID: 99174
		[Token(Token = "0x4018366")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
