using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001DAA RID: 7594
	[Token(Token = "0x2001DAA")]
	public class BuildingManufactRemainCountView : DataBinder<MRoomViewPropety>
	{
		// Token: 0x0600BB42 RID: 47938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB42")]
		[Address(RVA = "0x3393C00", Offset = "0x3392800", VA = "0x183393C00", Slot = "7")]
		public override void OnValueChanged(MRoomViewPropety property)
		{
		}

		// Token: 0x0600BB43 RID: 47939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB43")]
		[Address(RVA = "0x3394010", Offset = "0x3392C10", VA = "0x183394010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600BB44 RID: 47940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB44")]
		[Address(RVA = "0x3394570", Offset = "0x3393170", VA = "0x183394570")]
		private void _RenderNormal(MRoomViewModel viewModel)
		{
		}

		// Token: 0x0600BB45 RID: 47941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB45")]
		[Address(RVA = "0x3394450", Offset = "0x3393050", VA = "0x183394450")]
		private void _RenderEdit(MRoomViewModel viewModel)
		{
		}

		// Token: 0x0600BB46 RID: 47942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB46")]
		[Address(RVA = "0x3394760", Offset = "0x3393360", VA = "0x183394760")]
		private void _UpdateCountDown(MRoomViewModel viewModel, ManufactSnapshot snapshot)
		{
		}

		// Token: 0x0600BB47 RID: 47943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB47")]
		[Address(RVA = "0x33949E0", Offset = "0x33935E0", VA = "0x1833949E0")]
		private void _UpdateSecond(CountDownTask.TickValue value)
		{
		}

		// Token: 0x0600BB48 RID: 47944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB48")]
		[Address(RVA = "0x3394390", Offset = "0x3392F90", VA = "0x183394390")]
		private void _OnPlusClicked()
		{
		}

		// Token: 0x0600BB49 RID: 47945 RVA: 0x00045E70 File Offset: 0x00044070
		[Token(Token = "0x600BB49")]
		[Address(RVA = "0x33943F0", Offset = "0x3392FF0", VA = "0x1833943F0")]
		private bool _OnPlusLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0600BB4A RID: 47946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB4A")]
		[Address(RVA = "0x33942D0", Offset = "0x3392ED0", VA = "0x1833942D0")]
		private void _OnMinusClicked()
		{
		}

		// Token: 0x0600BB4B RID: 47947 RVA: 0x00045E88 File Offset: 0x00044088
		[Token(Token = "0x600BB4B")]
		[Address(RVA = "0x3394330", Offset = "0x3392F30", VA = "0x183394330")]
		private bool _OnMinusLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0600BB4C RID: 47948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB4C")]
		[Address(RVA = "0x3393AD0", Offset = "0x33926D0", VA = "0x183393AD0")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0600BB4D RID: 47949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB4D")]
		[Address(RVA = "0x3393A60", Offset = "0x3392660", VA = "0x183393A60")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x0600BB4E RID: 47950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB4E")]
		[Address(RVA = "0x3393B40", Offset = "0x3392740", VA = "0x183393B40")]
		public void EventOnMaxClicked()
		{
		}

		// Token: 0x0600BB4F RID: 47951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB4F")]
		[Address(RVA = "0x3393BA0", Offset = "0x33927A0", VA = "0x183393BA0")]
		public void EventOnMinClicked()
		{
		}

		// Token: 0x0600BB50 RID: 47952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB50")]
		[Address(RVA = "0x3394250", Offset = "0x3392E50", VA = "0x183394250")]
		private void _InvokeCountChanged(int delta)
		{
		}

		// Token: 0x0600BB51 RID: 47953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB51")]
		[Address(RVA = "0x3393FA0", Offset = "0x3392BA0", VA = "0x183393FA0")]
		private void Update()
		{
		}

		// Token: 0x0600BB52 RID: 47954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB52")]
		[Address(RVA = "0x3394A80", Offset = "0x3393680", VA = "0x183394A80")]
		public BuildingManufactRemainCountView()
		{
		}

		// Token: 0x0400BAD5 RID: 47829
		[Token(Token = "0x400BAD5")]
		private const int LONG_PRESS_DELTA = 5;

		// Token: 0x0400BAD6 RID: 47830
		[Token(Token = "0x400BAD6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _panelChange;

		// Token: 0x0400BAD7 RID: 47831
		[Token(Token = "0x400BAD7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0400BAD8 RID: 47832
		[Token(Token = "0x400BAD8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FillProgressBar _progress;

		// Token: 0x0400BAD9 RID: 47833
		[Token(Token = "0x400BAD9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UILongPressButton _btnPlus;

		// Token: 0x0400BADA RID: 47834
		[Token(Token = "0x400BADA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UILongPressButton _btnMinus;

		// Token: 0x0400BADB RID: 47835
		[Token(Token = "0x400BADB")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_panelChangeSwitch;

		// Token: 0x0400BADC RID: 47836
		[Token(Token = "0x400BADC")]
		[FieldOffset(Offset = "0x50")]
		private CountDownTask m_countDown;

		// Token: 0x0400BADD RID: 47837
		[Token(Token = "0x400BADD")]
		[FieldOffset(Offset = "0x58")]
		private float m_secPerItem;

		// Token: 0x0400BADE RID: 47838
		[Token(Token = "0x400BADE")]
		[FieldOffset(Offset = "0x5C")]
		private int m_remainSec;

		// Token: 0x0400BADF RID: 47839
		[Token(Token = "0x400BADF")]
		[FieldOffset(Offset = "0x60")]
		private bool m_inited;

		// Token: 0x0400BAE0 RID: 47840
		[Token(Token = "0x400BAE0")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public BuildingManufactRemainCountView.Listener listeners;

		// Token: 0x0400BAE1 RID: 47841
		[Token(Token = "0x400BAE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BAE2 RID: 47842
		[Token(Token = "0x400BAE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400BAE3 RID: 47843
		[Token(Token = "0x400BAE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderNormal;

		// Token: 0x0400BAE4 RID: 47844
		[Token(Token = "0x400BAE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderEdit;

		// Token: 0x0400BAE5 RID: 47845
		[Token(Token = "0x400BAE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateCountDown;

		// Token: 0x0400BAE6 RID: 47846
		[Token(Token = "0x400BAE6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateSecond;

		// Token: 0x0400BAE7 RID: 47847
		[Token(Token = "0x400BAE7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnPlusClicked;

		// Token: 0x0400BAE8 RID: 47848
		[Token(Token = "0x400BAE8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnPlusLongPressed;

		// Token: 0x0400BAE9 RID: 47849
		[Token(Token = "0x400BAE9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnMinusClicked;

		// Token: 0x0400BAEA RID: 47850
		[Token(Token = "0x400BAEA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnMinusLongPressed;

		// Token: 0x0400BAEB RID: 47851
		[Token(Token = "0x400BAEB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x0400BAEC RID: 47852
		[Token(Token = "0x400BAEC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x0400BAED RID: 47853
		[Token(Token = "0x400BAED")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnMaxClicked;

		// Token: 0x0400BAEE RID: 47854
		[Token(Token = "0x400BAEE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnMinClicked;

		// Token: 0x0400BAEF RID: 47855
		[Token(Token = "0x400BAEF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InvokeCountChanged;

		// Token: 0x0400BAF0 RID: 47856
		[Token(Token = "0x400BAF0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400BAF1 RID: 47857
		[Token(Token = "0x400BAF1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001DAB RID: 7595
		[Token(Token = "0x2001DAB")]
		public struct Listener
		{
			// Token: 0x0400BAF2 RID: 47858
			[Token(Token = "0x400BAF2")]
			[FieldOffset(Offset = "0x0")]
			public Action<int> onChangeCount;

			// Token: 0x0400BAF3 RID: 47859
			[Token(Token = "0x400BAF3")]
			[FieldOffset(Offset = "0x8")]
			public Action onConfirmChange;

			// Token: 0x0400BAF4 RID: 47860
			[Token(Token = "0x400BAF4")]
			[FieldOffset(Offset = "0x10")]
			public Action onCancelChange;
		}
	}
}
