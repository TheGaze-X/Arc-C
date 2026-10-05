using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004256 RID: 16982
	[Token(Token = "0x2004256")]
	public class SandboxV2LineView : MonoBehaviour, IAsyncDataView<SandboxV2LineView.RenderParam>, IAsyncShowEffect, IHotfixable
	{
		// Token: 0x0601A2CF RID: 107215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2CF")]
		[Address(RVA = "0x131CEE0", Offset = "0x131BAE0", VA = "0x18131CEE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A2D0 RID: 107216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2D0")]
		[Address(RVA = "0x131D2F0", Offset = "0x131BEF0", VA = "0x18131D2F0")]
		private void _OnRecycle()
		{
		}

		// Token: 0x0601A2D1 RID: 107217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2D1")]
		[Address(RVA = "0x131CA50", Offset = "0x131B650", VA = "0x18131CA50", Slot = "4")]
		public void AsyncSetData(SandboxV2LineView.RenderParam param)
		{
		}

		// Token: 0x0601A2D2 RID: 107218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2D2")]
		[Address(RVA = "0x131D040", Offset = "0x131BC40", VA = "0x18131D040")]
		private void _LineTo(Vector2 srcPos, Vector2 dstPos)
		{
		}

		// Token: 0x0601A2D3 RID: 107219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2D3")]
		[Address(RVA = "0x131CE80", Offset = "0x131BA80", VA = "0x18131CE80", Slot = "5")]
		public void AsyncShow()
		{
		}

		// Token: 0x0601A2D4 RID: 107220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2D4")]
		[Address(RVA = "0x131D360", Offset = "0x131BF60", VA = "0x18131D360")]
		public SandboxV2LineView()
		{
		}

		// Token: 0x0402115F RID: 135519
		[Token(Token = "0x402115F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgLine;

		// Token: 0x04021160 RID: 135520
		[Token(Token = "0x4021160")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _disabledColor;

		// Token: 0x04021161 RID: 135521
		[Token(Token = "0x4021161")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _showHandler;

		// Token: 0x04021162 RID: 135522
		[Token(Token = "0x4021162")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04021163 RID: 135523
		[Token(Token = "0x4021163")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x04021164 RID: 135524
		[Token(Token = "0x4021164")]
		[FieldOffset(Offset = "0x50")]
		private SandboxV2EnterAnimTween m_enterAnimTween;

		// Token: 0x04021165 RID: 135525
		[Token(Token = "0x4021165")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_showTween;

		// Token: 0x04021166 RID: 135526
		[Token(Token = "0x4021166")]
		[FieldOffset(Offset = "0x60")]
		private bool m_asyncShown;

		// Token: 0x04021167 RID: 135527
		[Token(Token = "0x4021167")]
		[FieldOffset(Offset = "0x68")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonConstructChecker;

		// Token: 0x04021168 RID: 135528
		[Token(Token = "0x4021168")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonChangeChecker;

		// Token: 0x04021169 RID: 135529
		[Token(Token = "0x4021169")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_enterAnimChecker;

		// Token: 0x0402116A RID: 135530
		[Token(Token = "0x402116A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402116B RID: 135531
		[Token(Token = "0x402116B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnRecycle;

		// Token: 0x0402116C RID: 135532
		[Token(Token = "0x402116C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x0402116D RID: 135533
		[Token(Token = "0x402116D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LineTo;

		// Token: 0x0402116E RID: 135534
		[Token(Token = "0x402116E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AsyncShow;

		// Token: 0x0402116F RID: 135535
		[Token(Token = "0x402116F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004257 RID: 16983
		[Token(Token = "0x2004257")]
		public struct RenderParam
		{
			// Token: 0x04021170 RID: 135536
			[Token(Token = "0x4021170")]
			[FieldOffset(Offset = "0x0")]
			public string lineId;

			// Token: 0x04021171 RID: 135537
			[Token(Token = "0x4021171")]
			[FieldOffset(Offset = "0x8")]
			public SandboxV2DungeonViewModel dungeonViewModel;
		}
	}
}
