using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F23 RID: 16163
	[Token(Token = "0x2003F23")]
	public class SiracusaCharSelectState : PopupFadeState, ISiracusaReplaceable
	{
		// Token: 0x06019189 RID: 102793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019189")]
		[Address(RVA = "0x11C9DA0", Offset = "0x11C89A0", VA = "0x1811C9DA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601918A RID: 102794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601918A")]
		[Address(RVA = "0x11C9D40", Offset = "0x11C8940", VA = "0x1811C9D40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601918B RID: 102795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601918B")]
		[Address(RVA = "0x11C9AA0", Offset = "0x11C86A0", VA = "0x1811C9AA0", Slot = "27")]
		protected sealed override void DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x0601918C RID: 102796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601918C")]
		[Address(RVA = "0x11C9BF0", Offset = "0x11C87F0", VA = "0x1811C9BF0", Slot = "28")]
		protected sealed override void DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x0601918D RID: 102797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601918D")]
		[Address(RVA = "0x11CA540", Offset = "0x11C9140", VA = "0x1811CA540")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601918E RID: 102798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601918E")]
		[Address(RVA = "0x11CAAA0", Offset = "0x11C96A0", VA = "0x1811CAAA0")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x0601918F RID: 102799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601918F")]
		[Address(RVA = "0x11CAF40", Offset = "0x11C9B40", VA = "0x1811CAF40")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x06019190 RID: 102800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019190")]
		[Address(RVA = "0x11CA930", Offset = "0x11C9530", VA = "0x1811CA930")]
		private void _OnCancel()
		{
		}

		// Token: 0x06019191 RID: 102801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019191")]
		[Address(RVA = "0x11CA100", Offset = "0x11C8D00", VA = "0x1811CA100")]
		private void _EventOnCharSelectChange(string charCardId)
		{
		}

		// Token: 0x06019192 RID: 102802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019192")]
		[Address(RVA = "0x11CA200", Offset = "0x11C8E00", VA = "0x1811CA200")]
		private void _EventOnQuitCharCard()
		{
		}

		// Token: 0x06019193 RID: 102803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019193")]
		[Address(RVA = "0x11CA4C0", Offset = "0x11C90C0", VA = "0x1811CA4C0")]
		private void _EventOnSelectCharCard(string charCardId)
		{
		}

		// Token: 0x06019194 RID: 102804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019194")]
		[Address(RVA = "0x11CA260", Offset = "0x11C8E60", VA = "0x1811CA260")]
		private void _EventOnReview(string charCardId)
		{
		}

		// Token: 0x06019195 RID: 102805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019195")]
		[Address(RVA = "0x11CB000", Offset = "0x11C9C00", VA = "0x1811CB000")]
		private void _SelectCharCard(string charCardId)
		{
		}

		// Token: 0x06019196 RID: 102806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019196")]
		[Address(RVA = "0x11CABD0", Offset = "0x11C97D0", VA = "0x1811CABD0")]
		private void _OnSelectCharCardResponse(bool isUnload, string charCardId)
		{
		}

		// Token: 0x06019197 RID: 102807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019197")]
		[Address(RVA = "0x11CB2F0", Offset = "0x11C9EF0", VA = "0x1811CB2F0")]
		public SiracusaCharSelectState()
		{
		}

		// Token: 0x06019198 RID: 102808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019198")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06019199 RID: 102809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019199")]
		[Address(RVA = "0xF80770", Offset = "0xF7F370", VA = "0x180F80770")]
		private void <>xLuaBaseProxy_DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x0601919A RID: 102810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601919A")]
		[Address(RVA = "0xF807A0", Offset = "0xF7F3A0", VA = "0x180F807A0")]
		private void <>xLuaBaseProxy_DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x0401F0F1 RID: 127217
		[Token(Token = "0x401F0F1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401F0F2 RID: 127218
		[Token(Token = "0x401F0F2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SiracusaCharSelectView _view;

		// Token: 0x0401F0F3 RID: 127219
		[Token(Token = "0x401F0F3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AnimationWrapper _enterAnimWrapper;

		// Token: 0x0401F0F4 RID: 127220
		[Token(Token = "0x401F0F4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _rectTopBlocker;

		// Token: 0x0401F0F5 RID: 127221
		[Token(Token = "0x401F0F5")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x0401F0F6 RID: 127222
		[Token(Token = "0x401F0F6")]
		[FieldOffset(Offset = "0x98")]
		private SiracusaCharSelectProperty m_charSelectProperty;

		// Token: 0x0401F0F7 RID: 127223
		[Token(Token = "0x401F0F7")]
		[FieldOffset(Offset = "0xA0")]
		private string m_groupId;

		// Token: 0x0401F0F8 RID: 127224
		[Token(Token = "0x401F0F8")]
		private const string ENTRY_ANIM = "siracusa_char_select_entry";

		// Token: 0x0401F0F9 RID: 127225
		[Token(Token = "0x401F0F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401F0FA RID: 127226
		[Token(Token = "0x401F0FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401F0FB RID: 127227
		[Token(Token = "0x401F0FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateBeforeTransStart;

		// Token: 0x0401F0FC RID: 127228
		[Token(Token = "0x401F0FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateWenTransEnd;

		// Token: 0x0401F0FD RID: 127229
		[Token(Token = "0x401F0FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F0FE RID: 127230
		[Token(Token = "0x401F0FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x0401F0FF RID: 127231
		[Token(Token = "0x401F0FF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x0401F100 RID: 127232
		[Token(Token = "0x401F100")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnCancel;

		// Token: 0x0401F101 RID: 127233
		[Token(Token = "0x401F101")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnCharSelectChange;

		// Token: 0x0401F102 RID: 127234
		[Token(Token = "0x401F102")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnQuitCharCard;

		// Token: 0x0401F103 RID: 127235
		[Token(Token = "0x401F103")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnSelectCharCard;

		// Token: 0x0401F104 RID: 127236
		[Token(Token = "0x401F104")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnReview;

		// Token: 0x0401F105 RID: 127237
		[Token(Token = "0x401F105")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SelectCharCard;

		// Token: 0x0401F106 RID: 127238
		[Token(Token = "0x401F106")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnSelectCharCardResponse;

		// Token: 0x0401F107 RID: 127239
		[Token(Token = "0x401F107")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
