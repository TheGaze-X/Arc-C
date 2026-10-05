using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003277 RID: 12919
	[Token(Token = "0x2003277")]
	public class SwitchAnimatorStateWhenFinish : Effect.Behaviour
	{
		// Token: 0x060147C7 RID: 83911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147C7")]
		[Address(RVA = "0xCB6E30", Offset = "0xCB5A30", VA = "0x180CB6E30", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x060147C8 RID: 83912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147C8")]
		[Address(RVA = "0xCB6DB0", Offset = "0xCB59B0", VA = "0x180CB6DB0")]
		private void Awake()
		{
		}

		// Token: 0x060147C9 RID: 83913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147C9")]
		[Address(RVA = "0xCB6F70", Offset = "0xCB5B70", VA = "0x180CB6F70")]
		public SwitchAnimatorStateWhenFinish()
		{
		}

		// Token: 0x060147CA RID: 83914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60147CA")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04018375 RID: 99189
		[Token(Token = "0x4018375")]
		[FieldOffset(Offset = "0x20")]
		private Animator m_animator;

		// Token: 0x04018376 RID: 99190
		[Token(Token = "0x4018376")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _stateName;

		// Token: 0x04018377 RID: 99191
		[Token(Token = "0x4018377")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018378 RID: 99192
		[Token(Token = "0x4018378")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04018379 RID: 99193
		[Token(Token = "0x4018379")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
