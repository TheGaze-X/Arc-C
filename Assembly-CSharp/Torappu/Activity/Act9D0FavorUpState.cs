using System;
using Il2CppDummyDll;
using Torappu.Activity.Act9D0;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D41 RID: 27969
	[Token(Token = "0x2006D41")]
	public class Act9D0FavorUpState : PopupFloatState
	{
		// Token: 0x06027DD0 RID: 163280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DD0")]
		[Address(RVA = "0x22EDDA0", Offset = "0x22EC9A0", VA = "0x1822EDDA0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027DD1 RID: 163281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DD1")]
		[Address(RVA = "0x22EDE00", Offset = "0x22ECA00", VA = "0x1822EDE00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06027DD2 RID: 163282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DD2")]
		[Address(RVA = "0x22EDF80", Offset = "0x22ECB80", VA = "0x1822EDF80", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06027DD3 RID: 163283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DD3")]
		[Address(RVA = "0x22EDCF0", Offset = "0x22EC8F0", VA = "0x1822EDCF0")]
		public void EventOnBackgroundClicked()
		{
		}

		// Token: 0x06027DD4 RID: 163284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DD4")]
		[Address(RVA = "0x22EE0C0", Offset = "0x22ECCC0", VA = "0x1822EE0C0")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x06027DD5 RID: 163285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DD5")]
		[Address(RVA = "0x22EE1E0", Offset = "0x22ECDE0", VA = "0x1822EE1E0")]
		public Act9D0FavorUpState()
		{
		}

		// Token: 0x06027DD7 RID: 163287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DD7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06027DD8 RID: 163288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DD8")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04038833 RID: 231475
		[Token(Token = "0x4038833")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act9D0FavorUpView _view;

		// Token: 0x04038834 RID: 231476
		[Token(Token = "0x4038834")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04038835 RID: 231477
		[Token(Token = "0x4038835")]
		[FieldOffset(Offset = "0x80")]
		private CommonTopMenu m_topMenu;

		// Token: 0x04038836 RID: 231478
		[Token(Token = "0x4038836")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04038837 RID: 231479
		[Token(Token = "0x4038837")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04038838 RID: 231480
		[Token(Token = "0x4038838")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04038839 RID: 231481
		[Token(Token = "0x4038839")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackgroundClicked;

		// Token: 0x0403883A RID: 231482
		[Token(Token = "0x403883A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0403883B RID: 231483
		[Token(Token = "0x403883B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
