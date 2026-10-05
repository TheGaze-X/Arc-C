using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F53 RID: 28499
	[Token(Token = "0x2006F53")]
	public class ActMultiV3ManualTitleSelectState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x06028794 RID: 165780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028794")]
		[Address(RVA = "0x23C7E10", Offset = "0x23C6A10", VA = "0x1823C7E10", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028795 RID: 165781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028795")]
		[Address(RVA = "0x23C7E70", Offset = "0x23C6A70", VA = "0x1823C7E70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028796 RID: 165782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028796")]
		[Address(RVA = "0x23C7FA0", Offset = "0x23C6BA0", VA = "0x1823C7FA0", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028797 RID: 165783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028797")]
		[Address(RVA = "0x23C86F0", Offset = "0x23C72F0", VA = "0x1823C86F0")]
		private void _OnBeginDrag()
		{
		}

		// Token: 0x06028798 RID: 165784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028798")]
		[Address(RVA = "0x23C8DE0", Offset = "0x23C79E0", VA = "0x1823C8DE0")]
		private void _OnEndDrag(ActMultiV3ManualTitleSelectState.TitlePagerSelection selection)
		{
		}

		// Token: 0x06028799 RID: 165785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028799")]
		[Address(RVA = "0x23C87B0", Offset = "0x23C73B0", VA = "0x1823C87B0")]
		private void _OnClickItem(ActMultiV3ManualTitleSelectState.TitlePagerSelection selection)
		{
		}

		// Token: 0x0602879A RID: 165786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602879A")]
		[Address(RVA = "0x23C8920", Offset = "0x23C7520", VA = "0x1823C8920")]
		private void _OnConfirmTitle()
		{
		}

		// Token: 0x0602879B RID: 165787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602879B")]
		[Address(RVA = "0x23C83B0", Offset = "0x23C6FB0", VA = "0x1823C83B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602879C RID: 165788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602879C")]
		[Address(RVA = "0x23C82A0", Offset = "0x23C6EA0", VA = "0x1823C82A0")]
		private string _GetActivityId()
		{
			return null;
		}

		// Token: 0x0602879D RID: 165789 RVA: 0x000D1DD8 File Offset: 0x000CFFD8
		[Token(Token = "0x602879D")]
		[Address(RVA = "0x23C8610", Offset = "0x23C7210", VA = "0x1823C8610")]
		private bool _IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x0602879E RID: 165790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602879E")]
		[Address(RVA = "0x23C9010", Offset = "0x23C7C10", VA = "0x1823C9010")]
		public ActMultiV3ManualTitleSelectState()
		{
		}

		// Token: 0x060287A0 RID: 165792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287A0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403991C RID: 235804
		[Token(Token = "0x403991C")]
		[NonSerialized]
		public const int ON_BEGIN_DRAG = 0;

		// Token: 0x0403991D RID: 235805
		[Token(Token = "0x403991D")]
		[NonSerialized]
		public const int ON_END_DRAG = 1;

		// Token: 0x0403991E RID: 235806
		[Token(Token = "0x403991E")]
		[NonSerialized]
		public const int ON_ITEM_CLICK = 2;

		// Token: 0x0403991F RID: 235807
		[Token(Token = "0x403991F")]
		[NonSerialized]
		public const int ON_CONFIRM_TITLE = 3;

		// Token: 0x04039920 RID: 235808
		[Token(Token = "0x4039920")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActMultiV3ManualTitleSelectView _view;

		// Token: 0x04039921 RID: 235809
		[Token(Token = "0x4039921")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x04039922 RID: 235810
		[Token(Token = "0x4039922")]
		[FieldOffset(Offset = "0x80")]
		private string m_actId;

		// Token: 0x04039923 RID: 235811
		[Token(Token = "0x4039923")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x04039924 RID: 235812
		[Token(Token = "0x4039924")]
		[FieldOffset(Offset = "0x90")]
		private ActMultiV3TitleSelectProperty m_prop;

		// Token: 0x04039925 RID: 235813
		[Token(Token = "0x4039925")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedPrefixId;

		// Token: 0x04039926 RID: 235814
		[Token(Token = "0x4039926")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cachedSuffixId;

		// Token: 0x04039927 RID: 235815
		[Token(Token = "0x4039927")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04039928 RID: 235816
		[Token(Token = "0x4039928")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04039929 RID: 235817
		[Token(Token = "0x4039929")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403992A RID: 235818
		[Token(Token = "0x403992A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnBeginDrag;

		// Token: 0x0403992B RID: 235819
		[Token(Token = "0x403992B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnEndDrag;

		// Token: 0x0403992C RID: 235820
		[Token(Token = "0x403992C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnClickItem;

		// Token: 0x0403992D RID: 235821
		[Token(Token = "0x403992D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnConfirmTitle;

		// Token: 0x0403992E RID: 235822
		[Token(Token = "0x403992E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403992F RID: 235823
		[Token(Token = "0x403992F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetActivityId;

		// Token: 0x04039930 RID: 235824
		[Token(Token = "0x4039930")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__IsStateStable;

		// Token: 0x04039931 RID: 235825
		[Token(Token = "0x4039931")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F54 RID: 28500
		[Token(Token = "0x2006F54")]
		public class TitlePagerSelection
		{
			// Token: 0x060287A1 RID: 165793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60287A1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TitlePagerSelection()
			{
			}

			// Token: 0x04039932 RID: 235826
			[Token(Token = "0x4039932")]
			[FieldOffset(Offset = "0x10")]
			public bool isBack;

			// Token: 0x04039933 RID: 235827
			[Token(Token = "0x4039933")]
			[FieldOffset(Offset = "0x14")]
			public int pageIdx;
		}
	}
}
