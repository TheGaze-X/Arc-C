using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200327A RID: 12922
	[Token(Token = "0x200327A")]
	public class SyncEffectScaleWithAuraRangeRadius : Effect.Behaviour
	{
		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x060147DB RID: 83931 RVA: 0x00086EE0 File Offset: 0x000850E0
		[Token(Token = "0x17003062")]
		public bool applyMaxScale
		{
			[Token(Token = "0x60147DB")]
			[Address(RVA = "0xCC03D0", Offset = "0xCBEFD0", VA = "0x180CC03D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060147DC RID: 83932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147DC")]
		[Address(RVA = "0xCBFEC0", Offset = "0xCBEAC0", VA = "0x180CBFEC0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060147DD RID: 83933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147DD")]
		[Address(RVA = "0xCBFDC0", Offset = "0xCBE9C0", VA = "0x180CBFDC0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060147DE RID: 83934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147DE")]
		[Address(RVA = "0xCC0200", Offset = "0xCBEE00", VA = "0x180CC0200")]
		private void Update()
		{
		}

		// Token: 0x060147DF RID: 83935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147DF")]
		[Address(RVA = "0xCC0360", Offset = "0xCBEF60", VA = "0x180CC0360")]
		public SyncEffectScaleWithAuraRangeRadius()
		{
		}

		// Token: 0x060147E0 RID: 83936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147E0")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x060147E1 RID: 83937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147E1")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04018395 RID: 99221
		[Token(Token = "0x4018395")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _effectOriginRadius;

		// Token: 0x04018396 RID: 99222
		[Token(Token = "0x4018396")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _abilityName;

		// Token: 0x04018397 RID: 99223
		[Token(Token = "0x4018397")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _updateWhenTick;

		// Token: 0x04018398 RID: 99224
		[Token(Token = "0x4018398")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _revertWhenFinish;

		// Token: 0x04018399 RID: 99225
		[Token(Token = "0x4018399")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool _applyMaxScale;

		// Token: 0x0401839A RID: 99226
		[Token(Token = "0x401839A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Inspect("applyMaxScale")]
		private float _maxScale;

		// Token: 0x0401839B RID: 99227
		[Token(Token = "0x401839B")]
		[FieldOffset(Offset = "0x38")]
		private bool m_active;

		// Token: 0x0401839C RID: 99228
		[Token(Token = "0x401839C")]
		[FieldOffset(Offset = "0x40")]
		private AuraAbility m_aura;

		// Token: 0x0401839D RID: 99229
		[Token(Token = "0x401839D")]
		[FieldOffset(Offset = "0x48")]
		private float m_scale;

		// Token: 0x0401839E RID: 99230
		[Token(Token = "0x401839E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_applyMaxScale;

		// Token: 0x0401839F RID: 99231
		[Token(Token = "0x401839F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040183A0 RID: 99232
		[Token(Token = "0x40183A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040183A1 RID: 99233
		[Token(Token = "0x40183A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040183A2 RID: 99234
		[Token(Token = "0x40183A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
