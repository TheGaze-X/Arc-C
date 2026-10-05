using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200326A RID: 12906
	[Token(Token = "0x200326A")]
	public class SwitchableEffectByBuffStackCnt : Effect.Behaviour, IEffectSource, IHookEffectBehaviour
	{
		// Token: 0x06014775 RID: 83829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014775")]
		[Address(RVA = "0xCBA610", Offset = "0xCB9210", VA = "0x180CBA610", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014776 RID: 83830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014776")]
		[Address(RVA = "0xCBA450", Offset = "0xCB9050", VA = "0x180CBA450", Slot = "10")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06014777 RID: 83831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014777")]
		[Address(RVA = "0xCBA4F0", Offset = "0xCB90F0", VA = "0x180CBA4F0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014778 RID: 83832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014778")]
		[Address(RVA = "0xCBA690", Offset = "0xCB9290", VA = "0x180CBA690")]
		private void Update()
		{
		}

		// Token: 0x06014779 RID: 83833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014779")]
		[Address(RVA = "0xCBA820", Offset = "0xCB9420", VA = "0x180CBA820")]
		private void _UpdateEffectWithBuffCnt()
		{
		}

		// Token: 0x0601477A RID: 83834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601477A")]
		[Address(RVA = "0xCBA740", Offset = "0xCB9340", VA = "0x180CBA740")]
		private void _FinishStackEffect()
		{
		}

		// Token: 0x0601477B RID: 83835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601477B")]
		[Address(RVA = "0xCBA3F0", Offset = "0xCB8FF0", VA = "0x180CBA3F0", Slot = "11")]
		public void ChangeEffectsExt(string ext)
		{
		}

		// Token: 0x0601477C RID: 83836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601477C")]
		[Address(RVA = "0xCBAB40", Offset = "0xCB9740", VA = "0x180CBAB40")]
		public SwitchableEffectByBuffStackCnt()
		{
		}

		// Token: 0x0601477D RID: 83837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601477D")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0601477E RID: 83838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601477E")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x040182FD RID: 99069
		[Token(Token = "0x40182FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x040182FE RID: 99070
		[Token(Token = "0x40182FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _effect;

		// Token: 0x040182FF RID: 99071
		[Token(Token = "0x40182FF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _stackCnt;

		// Token: 0x04018300 RID: 99072
		[Token(Token = "0x4018300")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private CompareType _compareType;

		// Token: 0x04018301 RID: 99073
		[Token(Token = "0x4018301")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _updateInterval;

		// Token: 0x04018302 RID: 99074
		[Token(Token = "0x4018302")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _updateOnPlay;

		// Token: 0x04018303 RID: 99075
		[Token(Token = "0x4018303")]
		[FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool _onlyUpdateOnPlay;

		// Token: 0x04018304 RID: 99076
		[Token(Token = "0x4018304")]
		[FieldOffset(Offset = "0x40")]
		private float m_updateInterval;

		// Token: 0x04018305 RID: 99077
		[Token(Token = "0x4018305")]
		[FieldOffset(Offset = "0x48")]
		private ObjectPtr<Effect> m_stackEffect;

		// Token: 0x04018306 RID: 99078
		[Token(Token = "0x4018306")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018307 RID: 99079
		[Token(Token = "0x4018307")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04018308 RID: 99080
		[Token(Token = "0x4018308")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018309 RID: 99081
		[Token(Token = "0x4018309")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401830A RID: 99082
		[Token(Token = "0x401830A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateEffectWithBuffCnt;

		// Token: 0x0401830B RID: 99083
		[Token(Token = "0x401830B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FinishStackEffect;

		// Token: 0x0401830C RID: 99084
		[Token(Token = "0x401830C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ChangeEffectsExt;

		// Token: 0x0401830D RID: 99085
		[Token(Token = "0x401830D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
