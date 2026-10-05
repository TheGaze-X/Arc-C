using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200327C RID: 12924
	[Token(Token = "0x200327C")]
	public class TriggerAnimatorWhenContainsBuff : Effect.Behaviour
	{
		// Token: 0x060147E9 RID: 83945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147E9")]
		[Address(RVA = "0xCC08E0", Offset = "0xCBF4E0", VA = "0x180CC08E0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060147EA RID: 83946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147EA")]
		[Address(RVA = "0xCC09B0", Offset = "0xCBF5B0", VA = "0x180CC09B0")]
		private void Update()
		{
		}

		// Token: 0x060147EB RID: 83947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147EB")]
		[Address(RVA = "0xCC0BB0", Offset = "0xCBF7B0", VA = "0x180CC0BB0")]
		public TriggerAnimatorWhenContainsBuff()
		{
		}

		// Token: 0x060147EC RID: 83948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147EC")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x040183AA RID: 99242
		[Token(Token = "0x40183AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x040183AB RID: 99243
		[Token(Token = "0x40183AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _animatorDefaultName;

		// Token: 0x040183AC RID: 99244
		[Token(Token = "0x40183AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _animatorTriggerName;

		// Token: 0x040183AD RID: 99245
		[Token(Token = "0x40183AD")]
		[FieldOffset(Offset = "0x38")]
		private Animator m_animator;

		// Token: 0x040183AE RID: 99246
		[Token(Token = "0x40183AE")]
		[FieldOffset(Offset = "0x40")]
		private int m_triggerAnimatorID;

		// Token: 0x040183AF RID: 99247
		[Token(Token = "0x40183AF")]
		[FieldOffset(Offset = "0x44")]
		private int m_defaultAnimatorID;

		// Token: 0x040183B0 RID: 99248
		[Token(Token = "0x40183B0")]
		[FieldOffset(Offset = "0x48")]
		private FP m_checkTime;

		// Token: 0x040183B1 RID: 99249
		[Token(Token = "0x40183B1")]
		private const float m_checkInterval = 0.3f;

		// Token: 0x040183B2 RID: 99250
		[Token(Token = "0x40183B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040183B3 RID: 99251
		[Token(Token = "0x40183B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040183B4 RID: 99252
		[Token(Token = "0x40183B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
