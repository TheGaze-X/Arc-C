using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.Grocery;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act27side
{
	// Token: 0x020074B7 RID: 29879
	[Token(Token = "0x20074B7")]
	public class Act27sideEntryGroceryPlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x0602A249 RID: 172617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A249")]
		[Address(RVA = "0x25D0D80", Offset = "0x25CF980", VA = "0x1825D0D80", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A24A RID: 172618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A24A")]
		[Address(RVA = "0x25D0FF0", Offset = "0x25CFBF0", VA = "0x1825D0FF0")]
		public void OpenGrocery()
		{
		}

		// Token: 0x0602A24B RID: 172619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A24B")]
		[Address(RVA = "0x25D1270", Offset = "0x25CFE70", VA = "0x1825D1270")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A24C RID: 172620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A24C")]
		[Address(RVA = "0x25D1400", Offset = "0x25D0000", VA = "0x1825D1400")]
		private void _SendNextDayRequestAndOpenGrocery()
		{
		}

		// Token: 0x0602A24D RID: 172621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A24D")]
		[Address(RVA = "0x25D1300", Offset = "0x25CFF00", VA = "0x1825D1300")]
		private void _OnOpenGroceryPage(GroceryNextDayResponse response)
		{
		}

		// Token: 0x0602A24E RID: 172622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A24E")]
		[Address(RVA = "0x25D16C0", Offset = "0x25D02C0", VA = "0x1825D16C0")]
		public Act27sideEntryGroceryPlugin()
		{
		}

		// Token: 0x0403C899 RID: 247961
		[Token(Token = "0x403C899")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _mileStoneTrackPoint;

		// Token: 0x0403C89A RID: 247962
		[Token(Token = "0x403C89A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x0403C89B RID: 247963
		[Token(Token = "0x403C89B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403C89C RID: 247964
		[Token(Token = "0x403C89C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x0403C89D RID: 247965
		[Token(Token = "0x403C89D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelAfterSettle;

		// Token: 0x0403C89E RID: 247966
		[Token(Token = "0x403C89E")]
		[FieldOffset(Offset = "0x50")]
		private string m_actId;

		// Token: 0x0403C89F RID: 247967
		[Token(Token = "0x403C89F")]
		[FieldOffset(Offset = "0x58")]
		private string m_toastDesc;

		// Token: 0x0403C8A0 RID: 247968
		[Token(Token = "0x403C8A0")]
		[FieldOffset(Offset = "0x60")]
		private TrackPointViewProperty m_trackPointProperty;

		// Token: 0x0403C8A1 RID: 247969
		[Token(Token = "0x403C8A1")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0403C8A2 RID: 247970
		[Token(Token = "0x403C8A2")]
		[FieldOffset(Offset = "0x6C")]
		private Act27sideEntryGroceryViewModel.Status m_cachedCurrStatus;

		// Token: 0x0403C8A3 RID: 247971
		[Token(Token = "0x403C8A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C8A4 RID: 247972
		[Token(Token = "0x403C8A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenGrocery;

		// Token: 0x0403C8A5 RID: 247973
		[Token(Token = "0x403C8A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C8A6 RID: 247974
		[Token(Token = "0x403C8A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SendNextDayRequestAndOpenGrocery;

		// Token: 0x0403C8A7 RID: 247975
		[Token(Token = "0x403C8A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnOpenGroceryPage;

		// Token: 0x0403C8A8 RID: 247976
		[Token(Token = "0x403C8A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074B8 RID: 29880
		[Token(Token = "0x20074B8")]
		private class Act27sideGroceryTrackPointModel : GroceryHomeView.MileStoneTrackPointModel, IHotfixable
		{
			// Token: 0x0602A24F RID: 172623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A24F")]
			[Address(RVA = "0x25D1AF0", Offset = "0x25D06F0", VA = "0x1825D1AF0", Slot = "6")]
			public override void UpdateState(object paramObj)
			{
			}

			// Token: 0x0602A250 RID: 172624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A250")]
			[Address(RVA = "0x25D1D50", Offset = "0x25D0950", VA = "0x1825D1D50")]
			public Act27sideGroceryTrackPointModel()
			{
			}

			// Token: 0x0602A251 RID: 172625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A251")]
			[Address(RVA = "0x25D1AE0", Offset = "0x25D06E0", VA = "0x1825D1AE0")]
			private void <>xLuaBaseProxy_UpdateState(object P0)
			{
			}

			// Token: 0x0403C8A9 RID: 247977
			[Token(Token = "0x403C8A9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403C8AA RID: 247978
			[Token(Token = "0x403C8AA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
