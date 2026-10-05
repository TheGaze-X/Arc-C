using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003229 RID: 12841
	[Token(Token = "0x2003229")]
	public class FinishEffectIf : Effect.Behaviour, IHotfixable
	{
		// Token: 0x060145DA RID: 83418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145DA")]
		[Address(RVA = "0xC9BF10", Offset = "0xC9AB10", VA = "0x180C9BF10")]
		private void Update()
		{
		}

		// Token: 0x060145DB RID: 83419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145DB")]
		[Address(RVA = "0xC9BE80", Offset = "0xC9AA80", VA = "0x180C9BE80")]
		private void Awake()
		{
		}

		// Token: 0x060145DC RID: 83420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145DC")]
		[Address(RVA = "0xC9C190", Offset = "0xC9AD90", VA = "0x180C9C190")]
		public FinishEffectIf()
		{
		}

		// Token: 0x04018070 RID: 98416
		[Token(Token = "0x4018070")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _finishIfOwnerInvalid;

		// Token: 0x04018071 RID: 98417
		[Token(Token = "0x4018071")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _finishIfCurrentAnimFinish;

		// Token: 0x04018072 RID: 98418
		[Token(Token = "0x4018072")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool _finishIfNotDummy;

		// Token: 0x04018073 RID: 98419
		[Token(Token = "0x4018073")]
		[FieldOffset(Offset = "0x28")]
		private Animator m_animator;

		// Token: 0x04018074 RID: 98420
		[Token(Token = "0x4018074")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018075 RID: 98421
		[Token(Token = "0x4018075")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04018076 RID: 98422
		[Token(Token = "0x4018076")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
