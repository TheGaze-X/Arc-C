using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003219 RID: 12825
	[Token(Token = "0x2003219")]
	[RequireComponent(typeof(Animator))]
	public class SetAnimatorBoolByCondition : Effect.Behaviour
	{
		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x0601458F RID: 83343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003032")]
		private Animator animator
		{
			[Token(Token = "0x601458F")]
			[Address(RVA = "0xC948B0", Offset = "0xC934B0", VA = "0x180C948B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014590 RID: 83344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014590")]
		[Address(RVA = "0xC944B0", Offset = "0xC930B0", VA = "0x180C944B0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014591 RID: 83345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014591")]
		[Address(RVA = "0xC945C0", Offset = "0xC931C0", VA = "0x180C945C0")]
		private void Update()
		{
		}

		// Token: 0x06014592 RID: 83346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014592")]
		[Address(RVA = "0xC94700", Offset = "0xC93300", VA = "0x180C94700")]
		private void _UpdateAnimator()
		{
		}

		// Token: 0x06014593 RID: 83347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014593")]
		[Address(RVA = "0xC94410", Offset = "0xC93010", VA = "0x180C94410", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x06014594 RID: 83348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014594")]
		[Address(RVA = "0xC94810", Offset = "0xC93410", VA = "0x180C94810")]
		public SetAnimatorBoolByCondition()
		{
		}

		// Token: 0x06014595 RID: 83349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014595")]
		[Address(RVA = "0xC82030", Offset = "0xC80C30", VA = "0x180C82030")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x06014596 RID: 83350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014596")]
		[Address(RVA = "0xC81FD0", Offset = "0xC80BD0", VA = "0x180C81FD0")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04017FEE RID: 98286
		[Token(Token = "0x4017FEE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _paramName;

		// Token: 0x04017FEF RID: 98287
		[Token(Token = "0x4017FEF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimatorBoolSource _source;

		// Token: 0x04017FF0 RID: 98288
		[Token(Token = "0x4017FF0")]
		[FieldOffset(Offset = "0x30")]
		private Animator m_animator;

		// Token: 0x04017FF1 RID: 98289
		[Token(Token = "0x4017FF1")]
		[FieldOffset(Offset = "0x38")]
		private bool m_cachedValue;

		// Token: 0x04017FF2 RID: 98290
		[Token(Token = "0x4017FF2")]
		[FieldOffset(Offset = "0x39")]
		private bool m_hasPlayed;

		// Token: 0x04017FF3 RID: 98291
		[Token(Token = "0x4017FF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animator;

		// Token: 0x04017FF4 RID: 98292
		[Token(Token = "0x4017FF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04017FF5 RID: 98293
		[Token(Token = "0x4017FF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04017FF6 RID: 98294
		[Token(Token = "0x4017FF6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateAnimator;

		// Token: 0x04017FF7 RID: 98295
		[Token(Token = "0x4017FF7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04017FF8 RID: 98296
		[Token(Token = "0x4017FF8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
