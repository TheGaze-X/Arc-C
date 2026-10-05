using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045DF RID: 17887
	[Token(Token = "0x20045DF")]
	public class Rl03OuterBuffSummaryRawTextItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B330 RID: 111408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B330")]
		[Address(RVA = "0x1469D60", Offset = "0x1468960", VA = "0x181469D60")]
		public void Render(int position, Rl03OuterBuffSummaryRawTextItemModel viewModel)
		{
		}

		// Token: 0x0601B331 RID: 111409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B331")]
		[Address(RVA = "0x1469E70", Offset = "0x1468A70", VA = "0x181469E70")]
		public Rl03OuterBuffSummaryRawTextItemView()
		{
		}

		// Token: 0x040230E4 RID: 143588
		[Token(Token = "0x40230E4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _dot;

		// Token: 0x040230E5 RID: 143589
		[Token(Token = "0x40230E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x040230E6 RID: 143590
		[Token(Token = "0x40230E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040230E7 RID: 143591
		[Token(Token = "0x40230E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040230E8 RID: 143592
		[Token(Token = "0x40230E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
