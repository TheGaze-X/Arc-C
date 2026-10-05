using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007248 RID: 29256
	[Token(Token = "0x2007248")]
	public class Act5D1RuneUnlockState : PopupFloatState
	{
		// Token: 0x0602975C RID: 169820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602975C")]
		[Address(RVA = "0x24D0990", Offset = "0x24CF590", VA = "0x1824D0990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602975D RID: 169821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602975D")]
		[Address(RVA = "0x24D0370", Offset = "0x24CEF70", VA = "0x1824D0370", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602975E RID: 169822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602975E")]
		[Address(RVA = "0x24D0450", Offset = "0x24CF050", VA = "0x1824D0450", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602975F RID: 169823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602975F")]
		[Address(RVA = "0x24D0720", Offset = "0x24CF320", VA = "0x1824D0720")]
		private void _CheckAvailInfo()
		{
		}

		// Token: 0x06029760 RID: 169824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029760")]
		[Address(RVA = "0x24D0080", Offset = "0x24CEC80", VA = "0x1824D0080", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029761 RID: 169825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029761")]
		[Address(RVA = "0x24D00E0", Offset = "0x24CECE0", VA = "0x1824D00E0")]
		public void OnClick()
		{
		}

		// Token: 0x06029762 RID: 169826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029762")]
		[Address(RVA = "0x24D0A90", Offset = "0x24CF690", VA = "0x1824D0A90")]
		public Act5D1RuneUnlockState()
		{
		}

		// Token: 0x06029765 RID: 169829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029765")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06029766 RID: 169830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029766")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403B3C1 RID: 242625
		[Token(Token = "0x403B3C1")]
		[FieldOffset(Offset = "0x70")]
		private Act5D1RuneUnlockStateBean _stateBean;

		// Token: 0x0403B3C2 RID: 242626
		[Token(Token = "0x403B3C2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _priceText;

		// Token: 0x0403B3C3 RID: 242627
		[Token(Token = "0x403B3C3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act5D1RuneShowObj _showObj;

		// Token: 0x0403B3C4 RID: 242628
		[Token(Token = "0x403B3C4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403B3C5 RID: 242629
		[Token(Token = "0x403B3C5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _availPart;

		// Token: 0x0403B3C6 RID: 242630
		[Token(Token = "0x403B3C6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _notAvailPart;

		// Token: 0x0403B3C7 RID: 242631
		[Token(Token = "0x403B3C7")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Button _unlockBtn;

		// Token: 0x0403B3C8 RID: 242632
		[Token(Token = "0x403B3C8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Act5D1ResourceBar _resourceBar;

		// Token: 0x0403B3C9 RID: 242633
		[Token(Token = "0x403B3C9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Act5D1RuneUnlockNotify _notify;

		// Token: 0x0403B3CA RID: 242634
		[Token(Token = "0x403B3CA")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _price;

		// Token: 0x0403B3CB RID: 242635
		[Token(Token = "0x403B3CB")]
		[FieldOffset(Offset = "0xC0")]
		private Act5D1RuneShowObj m_showObj;

		// Token: 0x0403B3CC RID: 242636
		[Token(Token = "0x403B3CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B3CD RID: 242637
		[Token(Token = "0x403B3CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B3CE RID: 242638
		[Token(Token = "0x403B3CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403B3CF RID: 242639
		[Token(Token = "0x403B3CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckAvailInfo;

		// Token: 0x0403B3D0 RID: 242640
		[Token(Token = "0x403B3D0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B3D1 RID: 242641
		[Token(Token = "0x403B3D1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403B3D2 RID: 242642
		[Token(Token = "0x403B3D2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
