using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200775F RID: 30559
	[Token(Token = "0x200775F")]
	public class Act1VHalfidlePlotFilterPanelView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AEBE RID: 175806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEBE")]
		[Address(RVA = "0x26B9900", Offset = "0x26B8500", VA = "0x1826B9900")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AEBF RID: 175807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEBF")]
		[Address(RVA = "0x26B9350", Offset = "0x26B7F50", VA = "0x1826B9350")]
		public void Render(Act1VHalfIdlePlotDepotViewModel viewModel)
		{
		}

		// Token: 0x0602AEC0 RID: 175808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEC0")]
		[Address(RVA = "0x26B9260", Offset = "0x26B7E60", VA = "0x1826B9260")]
		public void EventOnFilterPanelButtonClick()
		{
		}

		// Token: 0x0602AEC1 RID: 175809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEC1")]
		[Address(RVA = "0x26B9A60", Offset = "0x26B8660", VA = "0x1826B9A60")]
		public Act1VHalfidlePlotFilterPanelView()
		{
		}

		// Token: 0x0403DE9E RID: 253598
		[Token(Token = "0x403DE9E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1VHalfidlePlotFilterToggleItemView[] _toggles;

		// Token: 0x0403DE9F RID: 253599
		[Token(Token = "0x403DE9F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _btnName;

		// Token: 0x0403DEA0 RID: 253600
		[Token(Token = "0x403DEA0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasFilterPanel;

		// Token: 0x0403DEA1 RID: 253601
		[Token(Token = "0x403DEA1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _rectFilterPanel;

		// Token: 0x0403DEA2 RID: 253602
		[Token(Token = "0x403DEA2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _showPos;

		// Token: 0x0403DEA3 RID: 253603
		[Token(Token = "0x403DEA3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _hidePos;

		// Token: 0x0403DEA4 RID: 253604
		[Token(Token = "0x403DEA4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _arrowShow;

		// Token: 0x0403DEA5 RID: 253605
		[Token(Token = "0x403DEA5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _arrowHide;

		// Token: 0x0403DEA6 RID: 253606
		[Token(Token = "0x403DEA6")]
		[FieldOffset(Offset = "0x58")]
		private string m_actId;

		// Token: 0x0403DEA7 RID: 253607
		[Token(Token = "0x403DEA7")]
		[FieldOffset(Offset = "0x60")]
		private UISwitchTween m_pnlShowTween;

		// Token: 0x0403DEA8 RID: 253608
		[Token(Token = "0x403DEA8")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x0403DEA9 RID: 253609
		[Token(Token = "0x403DEA9")]
		[FieldOffset(Offset = "0x70")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0403DEAA RID: 253610
		[Token(Token = "0x403DEAA")]
		[FieldOffset(Offset = "0x80")]
		private bool m_cachedFilterPanelShow;

		// Token: 0x0403DEAB RID: 253611
		[Token(Token = "0x403DEAB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DEAC RID: 253612
		[Token(Token = "0x403DEAC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DEAD RID: 253613
		[Token(Token = "0x403DEAD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnFilterPanelButtonClick;

		// Token: 0x0403DEAE RID: 253614
		[Token(Token = "0x403DEAE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
