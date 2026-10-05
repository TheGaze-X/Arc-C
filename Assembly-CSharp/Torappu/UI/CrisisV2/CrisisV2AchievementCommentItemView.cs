using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200598A RID: 22922
	[Token(Token = "0x200598A")]
	public class CrisisV2AchievementCommentItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060216B8 RID: 136888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216B8")]
		[Address(RVA = "0x1BBBDC0", Offset = "0x1BBA9C0", VA = "0x181BBBDC0")]
		public void Render(CrisisV2AchievementCommentViewModel viewModel)
		{
		}

		// Token: 0x060216B9 RID: 136889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216B9")]
		[Address(RVA = "0x1BBBE70", Offset = "0x1BBAA70", VA = "0x181BBBE70")]
		public CrisisV2AchievementCommentItemView()
		{
		}

		// Token: 0x0402D95D RID: 186717
		[Token(Token = "0x402D95D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402D95E RID: 186718
		[Token(Token = "0x402D95E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D95F RID: 186719
		[Token(Token = "0x402D95F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
