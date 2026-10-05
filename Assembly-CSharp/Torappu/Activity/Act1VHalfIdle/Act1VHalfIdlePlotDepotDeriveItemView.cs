using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007756 RID: 30550
	[Token(Token = "0x2007756")]
	public class Act1VHalfIdlePlotDepotDeriveItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AE91 RID: 175761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE91")]
		[Address(RVA = "0x26B07D0", Offset = "0x26AF3D0", VA = "0x1826B07D0")]
		public void Render(Act1VHalfidlePlotViewModel viewModel, string selectedPlotId)
		{
		}

		// Token: 0x0602AE92 RID: 175762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE92")]
		[Address(RVA = "0x26B06D0", Offset = "0x26AF2D0", VA = "0x1826B06D0")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x0602AE93 RID: 175763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE93")]
		[Address(RVA = "0x26B0AB0", Offset = "0x26AF6B0", VA = "0x1826B0AB0")]
		public Act1VHalfIdlePlotDepotDeriveItemView()
		{
		}

		// Token: 0x0403DE2C RID: 253484
		[Token(Token = "0x403DE2C")]
		[FieldOffset(Offset = "0x0")]
		private static float UNSELECTED_CANVAS_ALPHA;

		// Token: 0x0403DE2D RID: 253485
		[Token(Token = "0x403DE2D")]
		[FieldOffset(Offset = "0x4")]
		private static float SELECETD_CANVAS_ALPHA;

		// Token: 0x0403DE2E RID: 253486
		[Token(Token = "0x403DE2E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x0403DE2F RID: 253487
		[Token(Token = "0x403DE2F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalObj;

		// Token: 0x0403DE30 RID: 253488
		[Token(Token = "0x403DE30")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedObj;

		// Token: 0x0403DE31 RID: 253489
		[Token(Token = "0x403DE31")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403DE32 RID: 253490
		[Token(Token = "0x403DE32")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _rarityIcon;

		// Token: 0x0403DE33 RID: 253491
		[Token(Token = "0x403DE33")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403DE34 RID: 253492
		[Token(Token = "0x403DE34")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<string> onItemClicked;

		// Token: 0x0403DE35 RID: 253493
		[Token(Token = "0x403DE35")]
		[FieldOffset(Offset = "0x50")]
		private Act1VHalfidlePlotViewModel m_viewModel;

		// Token: 0x0403DE36 RID: 253494
		[Token(Token = "0x403DE36")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedPlotId;

		// Token: 0x0403DE37 RID: 253495
		[Token(Token = "0x403DE37")]
		[FieldOffset(Offset = "0x60")]
		private UICompDialogFinder m_compDialogFinder;

		// Token: 0x0403DE38 RID: 253496
		[Token(Token = "0x403DE38")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedActId;

		// Token: 0x0403DE39 RID: 253497
		[Token(Token = "0x403DE39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DE3A RID: 253498
		[Token(Token = "0x403DE3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x0403DE3B RID: 253499
		[Token(Token = "0x403DE3B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
