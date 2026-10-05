using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200531F RID: 21279
	[Token(Token = "0x200531F")]
	public class RoguelikeTopicInnerTaskTaskItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F656 RID: 128598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F656")]
		[Address(RVA = "0x191EE00", Offset = "0x191DA00", VA = "0x18191EE00")]
		public void Render(RoguelikeTopicInnerTaskTaskItem.RenderParam param)
		{
		}

		// Token: 0x0601F657 RID: 128599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F657")]
		[Address(RVA = "0x191F280", Offset = "0x191DE80", VA = "0x18191F280")]
		public RoguelikeTopicInnerTaskTaskItem()
		{
		}

		// Token: 0x0402A350 RID: 172880
		[Token(Token = "0x402A350")]
		private const int PROGRESS_BAR_TOTAL_WIDTH = 302;

		// Token: 0x0402A351 RID: 172881
		[Token(Token = "0x402A351")]
		private const int PROGRESS_BAR_HEIGHT = 6;

		// Token: 0x0402A352 RID: 172882
		[Token(Token = "0x402A352")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textTask;

		// Token: 0x0402A353 RID: 172883
		[Token(Token = "0x402A353")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasTask;

		// Token: 0x0402A354 RID: 172884
		[Token(Token = "0x402A354")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgCurrentProgress;

		// Token: 0x0402A355 RID: 172885
		[Token(Token = "0x402A355")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A356 RID: 172886
		[Token(Token = "0x402A356")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005320 RID: 21280
		[Token(Token = "0x2005320")]
		public struct RenderParam
		{
			// Token: 0x0402A357 RID: 172887
			[Token(Token = "0x402A357")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeTopicInnerTaskViewModel viewModel;

			// Token: 0x0402A358 RID: 172888
			[Token(Token = "0x402A358")]
			[FieldOffset(Offset = "0x8")]
			public int index;

			// Token: 0x0402A359 RID: 172889
			[Token(Token = "0x402A359")]
			[FieldOffset(Offset = "0xC")]
			public Color taskThemeColor;

			// Token: 0x0402A35A RID: 172890
			[Token(Token = "0x402A35A")]
			[FieldOffset(Offset = "0x1C")]
			public Color taskCurColor;
		}
	}
}
