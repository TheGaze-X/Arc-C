using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004513 RID: 17683
	[Token(Token = "0x2004513")]
	public class RoguelikeCommonOuterBuffSummaryRawTextItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF91 RID: 110481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF91")]
		[Address(RVA = "0x14228C0", Offset = "0x14214C0", VA = "0x1814228C0")]
		public void Render(int position, RoguelikeCommonOuterBuffSummaryRawTextItemModel viewModel)
		{
		}

		// Token: 0x0601AF92 RID: 110482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF92")]
		[Address(RVA = "0x14229D0", Offset = "0x14215D0", VA = "0x1814229D0")]
		public RoguelikeCommonOuterBuffSummaryRawTextItemView()
		{
		}

		// Token: 0x04022A08 RID: 141832
		[Token(Token = "0x4022A08")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _dot;

		// Token: 0x04022A09 RID: 141833
		[Token(Token = "0x4022A09")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04022A0A RID: 141834
		[Token(Token = "0x4022A0A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04022A0B RID: 141835
		[Token(Token = "0x4022A0B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _inactiveSummaryAlpha;

		// Token: 0x04022A0C RID: 141836
		[Token(Token = "0x4022A0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022A0D RID: 141837
		[Token(Token = "0x4022A0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
