using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F01 RID: 16129
	[Token(Token = "0x2003F01")]
	public class SiracusaCharCardBagState : PopupFloatState
	{
		// Token: 0x060190AA RID: 102570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60190AA")]
		[Address(RVA = "0x11AD8E0", Offset = "0x11AC4E0", VA = "0x1811AD8E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060190AB RID: 102571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190AB")]
		[Address(RVA = "0x11AD940", Offset = "0x11AC540", VA = "0x1811AD940", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060190AC RID: 102572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190AC")]
		[Address(RVA = "0x11ADCB0", Offset = "0x11AC8B0", VA = "0x1811ADCB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060190AD RID: 102573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190AD")]
		[Address(RVA = "0x11AD860", Offset = "0x11AC460", VA = "0x1811AD860")]
		public void EventOnClose()
		{
		}

		// Token: 0x060190AE RID: 102574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190AE")]
		[Address(RVA = "0x11ADDD0", Offset = "0x11AC9D0", VA = "0x1811ADDD0")]
		public SiracusaCharCardBagState()
		{
		}

		// Token: 0x060190AF RID: 102575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190AF")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401EF79 RID: 126841
		[Token(Token = "0x401EF79")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SiracusaCharCardBagView _view;

		// Token: 0x0401EF7A RID: 126842
		[Token(Token = "0x401EF7A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0401EF7B RID: 126843
		[Token(Token = "0x401EF7B")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0401EF7C RID: 126844
		[Token(Token = "0x401EF7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401EF7D RID: 126845
		[Token(Token = "0x401EF7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401EF7E RID: 126846
		[Token(Token = "0x401EF7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EF7F RID: 126847
		[Token(Token = "0x401EF7F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x0401EF80 RID: 126848
		[Token(Token = "0x401EF80")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
