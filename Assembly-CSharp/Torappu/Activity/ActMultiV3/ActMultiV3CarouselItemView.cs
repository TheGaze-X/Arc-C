using System;
using Il2CppDummyDll;
using Torappu.UI.Common;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FAE RID: 28590
	[Token(Token = "0x2006FAE")]
	public class ActMultiV3CarouselItemView : UICommonCarouselItem
	{
		// Token: 0x060289AF RID: 166319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289AF")]
		[Address(RVA = "0x23EC1F0", Offset = "0x23EADF0", VA = "0x1823EC1F0")]
		public void Render(string hintStr, TextGenerator textGenerator)
		{
		}

		// Token: 0x060289B0 RID: 166320 RVA: 0x000D2618 File Offset: 0x000D0818
		[Token(Token = "0x60289B0")]
		[Address(RVA = "0x23EC190", Offset = "0x23EAD90", VA = "0x1823EC190", Slot = "4")]
		public override float GetWidth()
		{
			return 0f;
		}

		// Token: 0x060289B1 RID: 166321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289B1")]
		[Address(RVA = "0x23EC2E0", Offset = "0x23EAEE0", VA = "0x1823EC2E0")]
		public ActMultiV3CarouselItemView()
		{
		}

		// Token: 0x04039D6E RID: 236910
		[Token(Token = "0x4039D6E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textHint;

		// Token: 0x04039D6F RID: 236911
		[Token(Token = "0x4039D6F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _headerWidth;

		// Token: 0x04039D70 RID: 236912
		[Token(Token = "0x4039D70")]
		[FieldOffset(Offset = "0x28")]
		private string m_cacheStr;

		// Token: 0x04039D71 RID: 236913
		[Token(Token = "0x4039D71")]
		[FieldOffset(Offset = "0x30")]
		private float m_hintWidth;

		// Token: 0x04039D72 RID: 236914
		[Token(Token = "0x4039D72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039D73 RID: 236915
		[Token(Token = "0x4039D73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetWidth;

		// Token: 0x04039D74 RID: 236916
		[Token(Token = "0x4039D74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
