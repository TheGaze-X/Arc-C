using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066FF RID: 26367
	[Token(Token = "0x20066FF")]
	public class HandBookV2MapGroupBackView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025D7A RID: 155002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D7A")]
		[Address(RVA = "0x20C6CB0", Offset = "0x20C58B0", VA = "0x1820C6CB0")]
		public void RenderView(HandBookV2GroupCharViewModel viewModel, string mainGroup)
		{
		}

		// Token: 0x06025D7B RID: 155003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D7B")]
		[Address(RVA = "0x20C6DE0", Offset = "0x20C59E0", VA = "0x1820C6DE0")]
		public void RenderView(HandBookV2GroupColorBlockViewModel viewModel, string mainGroup)
		{
		}

		// Token: 0x06025D7C RID: 155004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D7C")]
		[Address(RVA = "0x20C6F10", Offset = "0x20C5B10", VA = "0x1820C6F10")]
		public HandBookV2MapGroupBackView()
		{
		}

		// Token: 0x0403533D RID: 217917
		[Token(Token = "0x403533D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2MapDotView _dotView;

		// Token: 0x0403533E RID: 217918
		[Token(Token = "0x403533E")]
		[FieldOffset(Offset = "0x20")]
		private HandBookV2GroupCharViewModel m_viewModel;

		// Token: 0x0403533F RID: 217919
		[Token(Token = "0x403533F")]
		[FieldOffset(Offset = "0x28")]
		private HandBookV2GroupColorBlockViewModel m_colorViewModel;

		// Token: 0x04035340 RID: 217920
		[Token(Token = "0x4035340")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04035341 RID: 217921
		[Token(Token = "0x4035341")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_RenderView;

		// Token: 0x04035342 RID: 217922
		[Token(Token = "0x4035342")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
