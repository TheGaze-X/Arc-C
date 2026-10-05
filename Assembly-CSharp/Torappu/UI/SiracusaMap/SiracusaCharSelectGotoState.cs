using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F1E RID: 16158
	[Token(Token = "0x2003F1E")]
	public class SiracusaCharSelectGotoState : PopupFloatState, ISiracusaReplaceable
	{
		// Token: 0x06019167 RID: 102759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019167")]
		[Address(RVA = "0x11C6650", Offset = "0x11C5250", VA = "0x1811C6650", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019168 RID: 102760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019168")]
		[Address(RVA = "0x11C63B0", Offset = "0x11C4FB0", VA = "0x1811C63B0", Slot = "27")]
		protected sealed override void DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x06019169 RID: 102761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019169")]
		[Address(RVA = "0x11C6500", Offset = "0x11C5100", VA = "0x1811C6500", Slot = "28")]
		protected sealed override void DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x0601916A RID: 102762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601916A")]
		[Address(RVA = "0x11C66B0", Offset = "0x11C52B0", VA = "0x1811C66B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601916B RID: 102763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601916B")]
		[Address(RVA = "0x11C6350", Offset = "0x11C4F50", VA = "0x1811C6350")]
		public void CloseSelfDirectly()
		{
		}

		// Token: 0x0601916C RID: 102764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601916C")]
		[Address(RVA = "0x11C6860", Offset = "0x11C5460", VA = "0x1811C6860")]
		private void _CloseSelf(bool hasDelay)
		{
		}

		// Token: 0x0601916D RID: 102765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601916D")]
		[Address(RVA = "0x11C6A20", Offset = "0x11C5620", VA = "0x1811C6A20")]
		private IEnumerator _CoCloseSelf(bool hasDelay)
		{
			return null;
		}

		// Token: 0x0601916E RID: 102766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601916E")]
		[Address(RVA = "0x11C6AE0", Offset = "0x11C56E0", VA = "0x1811C6AE0")]
		public SiracusaCharSelectGotoState()
		{
		}

		// Token: 0x0601916F RID: 102767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601916F")]
		[Address(RVA = "0xF80770", Offset = "0xF7F370", VA = "0x180F80770")]
		private void <>xLuaBaseProxy_DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x06019170 RID: 102768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019170")]
		[Address(RVA = "0xF807A0", Offset = "0xF7F3A0", VA = "0x180F807A0")]
		private void <>xLuaBaseProxy_DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x06019171 RID: 102769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019171")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401F0AD RID: 127149
		[Token(Token = "0x401F0AD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SiracusaCharSelectGotoView _view;

		// Token: 0x0401F0AE RID: 127150
		[Token(Token = "0x401F0AE")]
		private const float CLOSE_SELF_DELAY = 4f;

		// Token: 0x0401F0AF RID: 127151
		[Token(Token = "0x401F0AF")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine m_coCloseSelf;

		// Token: 0x0401F0B0 RID: 127152
		[Token(Token = "0x401F0B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401F0B1 RID: 127153
		[Token(Token = "0x401F0B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateBeforeTransStart;

		// Token: 0x0401F0B2 RID: 127154
		[Token(Token = "0x401F0B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateWenTransEnd;

		// Token: 0x0401F0B3 RID: 127155
		[Token(Token = "0x401F0B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401F0B4 RID: 127156
		[Token(Token = "0x401F0B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CloseSelfDirectly;

		// Token: 0x0401F0B5 RID: 127157
		[Token(Token = "0x401F0B5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CloseSelf;

		// Token: 0x0401F0B6 RID: 127158
		[Token(Token = "0x401F0B6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CoCloseSelf;

		// Token: 0x0401F0B7 RID: 127159
		[Token(Token = "0x401F0B7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
