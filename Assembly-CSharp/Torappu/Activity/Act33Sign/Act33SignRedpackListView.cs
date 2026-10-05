using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act33Sign
{
	// Token: 0x02007483 RID: 29827
	[Token(Token = "0x2007483")]
	public class Act33SignRedpackListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A112 RID: 172306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A112")]
		[Address(RVA = "0x25C1460", Offset = "0x25C0060", VA = "0x1825C1460")]
		private void _RenderList(Act33SignRedpackViewModel viewModel)
		{
		}

		// Token: 0x0602A113 RID: 172307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A113")]
		[Address(RVA = "0x25C10B0", Offset = "0x25BFCB0", VA = "0x1825C10B0")]
		public void CloseView()
		{
		}

		// Token: 0x0602A114 RID: 172308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A114")]
		[Address(RVA = "0x25C1260", Offset = "0x25BFE60", VA = "0x1825C1260")]
		public void Show(Act33SignRedpackViewModel viewModel)
		{
		}

		// Token: 0x0602A115 RID: 172309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A115")]
		[Address(RVA = "0x25C1110", Offset = "0x25BFD10", VA = "0x1825C1110")]
		public void Hide()
		{
		}

		// Token: 0x0602A116 RID: 172310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A116")]
		[Address(RVA = "0x25C17A0", Offset = "0x25C03A0", VA = "0x1825C17A0")]
		public Act33SignRedpackListView()
		{
		}

		// Token: 0x0403C5F9 RID: 247289
		[Token(Token = "0x403C5F9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _redpackContent;

		// Token: 0x0403C5FA RID: 247290
		[Token(Token = "0x403C5FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403C5FB RID: 247291
		[Token(Token = "0x403C5FB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIBlurFloatPanel _blurPanel;

		// Token: 0x0403C5FC RID: 247292
		[Token(Token = "0x403C5FC")]
		[FieldOffset(Offset = "0x30")]
		private Act33SignRedpackListAdapter m_adapter;

		// Token: 0x0403C5FD RID: 247293
		[Token(Token = "0x403C5FD")]
		private const float ALPHA_ONE = 1f;

		// Token: 0x0403C5FE RID: 247294
		[Token(Token = "0x403C5FE")]
		private const float ALPHA_ZERO = 0f;

		// Token: 0x0403C5FF RID: 247295
		[Token(Token = "0x403C5FF")]
		private const float TWEEN_DURATION = 0.13f;

		// Token: 0x0403C600 RID: 247296
		[Token(Token = "0x403C600")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RenderList;

		// Token: 0x0403C601 RID: 247297
		[Token(Token = "0x403C601")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CloseView;

		// Token: 0x0403C602 RID: 247298
		[Token(Token = "0x403C602")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403C603 RID: 247299
		[Token(Token = "0x403C603")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0403C604 RID: 247300
		[Token(Token = "0x403C604")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
