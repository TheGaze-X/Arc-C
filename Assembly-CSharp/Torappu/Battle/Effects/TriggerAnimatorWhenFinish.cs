using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200327D RID: 12925
	[Token(Token = "0x200327D")]
	public class TriggerAnimatorWhenFinish : Effect.Behaviour
	{
		// Token: 0x060147ED RID: 83949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147ED")]
		[Address(RVA = "0xCC0CE0", Offset = "0xCBF8E0", VA = "0x180CC0CE0", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060147EE RID: 83950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147EE")]
		[Address(RVA = "0xCC0C40", Offset = "0xCBF840", VA = "0x180CC0C40")]
		private void Awake()
		{
		}

		// Token: 0x060147EF RID: 83951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147EF")]
		[Address(RVA = "0xCC0EB0", Offset = "0xCBFAB0", VA = "0x180CC0EB0")]
		public TriggerAnimatorWhenFinish()
		{
		}

		// Token: 0x060147F1 RID: 83953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147F1")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x040183B5 RID: 99253
		[Token(Token = "0x40183B5")]
		[FieldOffset(Offset = "0x20")]
		private Animator m_animator;

		// Token: 0x040183B6 RID: 99254
		[Token(Token = "0x40183B6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int s_onFinish;

		// Token: 0x040183B7 RID: 99255
		[Token(Token = "0x40183B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040183B8 RID: 99256
		[Token(Token = "0x40183B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040183B9 RID: 99257
		[Token(Token = "0x40183B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
