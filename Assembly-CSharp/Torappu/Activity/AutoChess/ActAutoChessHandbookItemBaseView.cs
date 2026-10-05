using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.DynTargetTween;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200711A RID: 28954
	[Token(Token = "0x200711A")]
	public abstract class ActAutoChessHandbookItemBaseView<TItemModel> : MonoBehaviour, IHotfixable where TItemModel : ActAutoChessHandbookItemModelBase
	{
		// Token: 0x06029218 RID: 168472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029218")]
		public void Render(TItemModel model, string selectedItemId, bool isFastMode)
		{
		}

		// Token: 0x06029219 RID: 168473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029219")]
		public void EventOnItemClicked()
		{
		}

		// Token: 0x0602921A RID: 168474
		[Token(Token = "0x602921A")]
		public abstract void OnRender(TItemModel model);

		// Token: 0x0602921B RID: 168475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602921B")]
		protected virtual void PrepareSelectSwitchTween(ref DynTargetSwitchTween current)
		{
		}

		// Token: 0x0602921C RID: 168476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602921C")]
		protected ActAutoChessHandbookItemBaseView()
		{
		}

		// Token: 0x0403ABC0 RID: 240576
		[Token(Token = "0x403ABC0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Image _imgIcon;

		// Token: 0x0403ABC1 RID: 240577
		[Token(Token = "0x403ABC1")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0403ABC2 RID: 240578
		[Token(Token = "0x403ABC2")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x0403ABC3 RID: 240579
		[Token(Token = "0x403ABC3")]
		[FieldOffset(Offset = "0x0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403ABC4 RID: 240580
		[Token(Token = "0x403ABC4")]
		[FieldOffset(Offset = "0x0")]
		private string m_cachedItemId;

		// Token: 0x0403ABC5 RID: 240581
		[Token(Token = "0x403ABC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403ABC6 RID: 240582
		[Token(Token = "0x403ABC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnItemClicked;

		// Token: 0x0403ABC7 RID: 240583
		[Token(Token = "0x403ABC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PrepareSelectSwitchTween;

		// Token: 0x0403ABC8 RID: 240584
		[Token(Token = "0x403ABC8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
