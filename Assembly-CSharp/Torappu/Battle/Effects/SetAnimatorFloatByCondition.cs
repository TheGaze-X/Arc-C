using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200321A RID: 12826
	[Token(Token = "0x200321A")]
	[RequireComponent(typeof(Animator))]
	public class SetAnimatorFloatByCondition : Effect.Behaviour
	{
		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x06014597 RID: 83351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003033")]
		private Animator animator
		{
			[Token(Token = "0x6014597")]
			[Address(RVA = "0xCACC90", Offset = "0xCAB890", VA = "0x180CACC90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014598 RID: 83352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014598")]
		[Address(RVA = "0xCAC7F0", Offset = "0xCAB3F0", VA = "0x180CAC7F0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014599 RID: 83353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014599")]
		[Address(RVA = "0xCAC900", Offset = "0xCAB500", VA = "0x180CAC900")]
		private void Update()
		{
		}

		// Token: 0x0601459A RID: 83354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601459A")]
		[Address(RVA = "0xCACAB0", Offset = "0xCAB6B0", VA = "0x180CACAB0")]
		private void _UpdateAnimator()
		{
		}

		// Token: 0x0601459B RID: 83355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601459B")]
		[Address(RVA = "0xCAC790", Offset = "0xCAB390", VA = "0x180CAC790", Slot = "6")]
		public override void OnFinish()
		{
		}

		// Token: 0x0601459C RID: 83356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601459C")]
		[Address(RVA = "0xCACC30", Offset = "0xCAB830", VA = "0x180CACC30")]
		public SetAnimatorFloatByCondition()
		{
		}

		// Token: 0x0601459D RID: 83357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601459D")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0601459E RID: 83358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601459E")]
		[Address(RVA = "0xC99150", Offset = "0xC97D50", VA = "0x180C99150")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x04017FF9 RID: 98297
		[Token(Token = "0x4017FF9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _paramName;

		// Token: 0x04017FFA RID: 98298
		[Token(Token = "0x4017FFA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimatorFloatSource _source;

		// Token: 0x04017FFB RID: 98299
		[Token(Token = "0x4017FFB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _isInt;

		// Token: 0x04017FFC RID: 98300
		[Token(Token = "0x4017FFC")]
		[FieldOffset(Offset = "0x38")]
		private Animator m_animator;

		// Token: 0x04017FFD RID: 98301
		[Token(Token = "0x4017FFD")]
		[FieldOffset(Offset = "0x40")]
		private float m_cachedValue;

		// Token: 0x04017FFE RID: 98302
		[Token(Token = "0x4017FFE")]
		[FieldOffset(Offset = "0x44")]
		private bool m_hasPlayed;

		// Token: 0x04017FFF RID: 98303
		[Token(Token = "0x4017FFF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animator;

		// Token: 0x04018000 RID: 98304
		[Token(Token = "0x4018000")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018001 RID: 98305
		[Token(Token = "0x4018001")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018002 RID: 98306
		[Token(Token = "0x4018002")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateAnimator;

		// Token: 0x04018003 RID: 98307
		[Token(Token = "0x4018003")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x04018004 RID: 98308
		[Token(Token = "0x4018004")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
