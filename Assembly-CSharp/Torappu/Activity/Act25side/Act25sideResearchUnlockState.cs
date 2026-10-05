using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007503 RID: 29955
	[Token(Token = "0x2007503")]
	public class Act25sideResearchUnlockState : PopupFloatState, IHotfixable
	{
		// Token: 0x0602A39C RID: 172956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A39C")]
		[Address(RVA = "0x25E9570", Offset = "0x25E8170", VA = "0x1825E9570", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A39D RID: 172957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A39D")]
		[Address(RVA = "0x25E96E0", Offset = "0x25E82E0", VA = "0x1825E96E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A39E RID: 172958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A39E")]
		[Address(RVA = "0x25E9C20", Offset = "0x25E8820", VA = "0x1825E9C20")]
		private void _PlayAnim()
		{
		}

		// Token: 0x0602A39F RID: 172959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A39F")]
		[Address(RVA = "0x25E9DD0", Offset = "0x25E89D0", VA = "0x1825E9DD0")]
		private void _UpdateProperty()
		{
		}

		// Token: 0x0602A3A0 RID: 172960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3A0")]
		[Address(RVA = "0x25E99C0", Offset = "0x25E85C0", VA = "0x1825E99C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A3A1 RID: 172961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3A1")]
		[Address(RVA = "0x25E95D0", Offset = "0x25E81D0", VA = "0x1825E95D0")]
		public void OnDismiss()
		{
		}

		// Token: 0x0602A3A2 RID: 172962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3A2")]
		[Address(RVA = "0x25E9EB0", Offset = "0x25E8AB0", VA = "0x1825E9EB0")]
		public Act25sideResearchUnlockState()
		{
		}

		// Token: 0x0602A3A3 RID: 172963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3A3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403CACE RID: 248526
		[Token(Token = "0x403CACE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act25sideResearchUnlockView _view;

		// Token: 0x0403CACF RID: 248527
		[Token(Token = "0x403CACF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403CAD0 RID: 248528
		[Token(Token = "0x403CAD0")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0403CAD1 RID: 248529
		[Token(Token = "0x403CAD1")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedActId;

		// Token: 0x0403CAD2 RID: 248530
		[Token(Token = "0x403CAD2")]
		[FieldOffset(Offset = "0x98")]
		private Act25sideResearchUnlockStateBean m_stateBean;

		// Token: 0x0403CAD3 RID: 248531
		[Token(Token = "0x403CAD3")]
		[FieldOffset(Offset = "0xA0")]
		private Act25sideResearchUnlockProperty m_prop;

		// Token: 0x0403CAD4 RID: 248532
		[Token(Token = "0x403CAD4")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_cachedTween;

		// Token: 0x0403CAD5 RID: 248533
		[Token(Token = "0x403CAD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403CAD6 RID: 248534
		[Token(Token = "0x403CAD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403CAD7 RID: 248535
		[Token(Token = "0x403CAD7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0403CAD8 RID: 248536
		[Token(Token = "0x403CAD8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateProperty;

		// Token: 0x0403CAD9 RID: 248537
		[Token(Token = "0x403CAD9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CADA RID: 248538
		[Token(Token = "0x403CADA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDismiss;

		// Token: 0x0403CADB RID: 248539
		[Token(Token = "0x403CADB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
