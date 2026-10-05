using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C16 RID: 23574
	[Token(Token = "0x2005C16")]
	public class CommonCharSelectPoolViewBase<ModelType> : TemplateCharSelectPoolViewBase<ModelType> where ModelType : CommonCharSelectPoolViewModel, new()
	{
		// Token: 0x060222D2 RID: 139986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222D2")]
		public override void RenderViewModel(TemplateCharSelectMainViewModel mainViewModel)
		{
		}

		// Token: 0x060222D3 RID: 139987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222D3")]
		private void _ScrollFocusTo(int focusIndex, int allCount)
		{
		}

		// Token: 0x060222D4 RID: 139988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222D4")]
		public void EventOnCharClick(int instId)
		{
		}

		// Token: 0x060222D5 RID: 139989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222D5")]
		public CommonCharSelectPoolViewBase()
		{
		}

		// Token: 0x0402EDF0 RID: 191984
		[Token(Token = "0x402EDF0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private CommonCharSelectAdapter _adapter;

		// Token: 0x0402EDF1 RID: 191985
		[Token(Token = "0x402EDF1")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private LoopScrollRect _scrollRect;

		// Token: 0x0402EDF2 RID: 191986
		[Token(Token = "0x402EDF2")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0402EDF3 RID: 191987
		[Token(Token = "0x402EDF3")]
		private const int VER_LINE_PER = 2;

		// Token: 0x0402EDF4 RID: 191988
		[Token(Token = "0x402EDF4")]
		private const int ADAPTER_START = 3;

		// Token: 0x0402EDF5 RID: 191989
		[Token(Token = "0x402EDF5")]
		[FieldOffset(Offset = "0x0")]
		private int m_focusSeq;

		// Token: 0x0402EDF6 RID: 191990
		[Token(Token = "0x402EDF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderViewModel;

		// Token: 0x0402EDF7 RID: 191991
		[Token(Token = "0x402EDF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ScrollFocusTo;

		// Token: 0x0402EDF8 RID: 191992
		[Token(Token = "0x402EDF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnCharClick;

		// Token: 0x0402EDF9 RID: 191993
		[Token(Token = "0x402EDF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
