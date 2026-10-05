using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006976 RID: 26998
	[Token(Token = "0x2006976")]
	public class StagePreviewReplayView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026A3E RID: 158270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A3E")]
		[Address(RVA = "0x21BAA10", Offset = "0x21B9610", VA = "0x1821BAA10")]
		public void InitData(List<StoryData> storyList, string stageId)
		{
		}

		// Token: 0x06026A3F RID: 158271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A3F")]
		[Address(RVA = "0x21BA990", Offset = "0x21B9590", VA = "0x1821BA990")]
		public void FadeOut()
		{
		}

		// Token: 0x06026A40 RID: 158272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A40")]
		[Address(RVA = "0x21BAD50", Offset = "0x21B9950", VA = "0x1821BAD50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026A41 RID: 158273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A41")]
		[Address(RVA = "0x21BAE60", Offset = "0x21B9A60", VA = "0x1821BAE60")]
		public StagePreviewReplayView()
		{
		}

		// Token: 0x040368BA RID: 223418
		[Token(Token = "0x40368BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StagePreviewReplayViewObject _upPart;

		// Token: 0x040368BB RID: 223419
		[Token(Token = "0x40368BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StagePreviewReplayViewObject _downPart;

		// Token: 0x040368BC RID: 223420
		[Token(Token = "0x40368BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _controlAnimator;

		// Token: 0x040368BD RID: 223421
		[Token(Token = "0x40368BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x040368BE RID: 223422
		[Token(Token = "0x40368BE")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x040368BF RID: 223423
		[Token(Token = "0x40368BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040368C0 RID: 223424
		[Token(Token = "0x40368C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FadeOut;

		// Token: 0x040368C1 RID: 223425
		[Token(Token = "0x40368C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040368C2 RID: 223426
		[Token(Token = "0x40368C2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
