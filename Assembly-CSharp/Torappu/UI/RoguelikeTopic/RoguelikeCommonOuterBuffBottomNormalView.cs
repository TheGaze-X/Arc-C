using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044F8 RID: 17656
	[Token(Token = "0x20044F8")]
	public class RoguelikeCommonOuterBuffBottomNormalView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF26 RID: 110374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF26")]
		[Address(RVA = "0x14194C0", Offset = "0x14180C0", VA = "0x1814194C0")]
		public void Render(RoguelikeCommonOuterBuffViewModel viewModel, RoguelikeCommonOuterBuffNormalNodeViewModel nodeViewModel)
		{
		}

		// Token: 0x0601AF27 RID: 110375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF27")]
		[Address(RVA = "0x14199E0", Offset = "0x14185E0", VA = "0x1814199E0")]
		public RoguelikeCommonOuterBuffBottomNormalView()
		{
		}

		// Token: 0x04022926 RID: 141606
		[Token(Token = "0x4022926")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _normalName;

		// Token: 0x04022927 RID: 141607
		[Token(Token = "0x4022927")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _normalDesc;

		// Token: 0x04022928 RID: 141608
		[Token(Token = "0x4022928")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelUpgraded;

		// Token: 0x04022929 RID: 141609
		[Token(Token = "0x4022929")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelUpgrade;

		// Token: 0x0402292A RID: 141610
		[Token(Token = "0x402292A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelNoCost;

		// Token: 0x0402292B RID: 141611
		[Token(Token = "0x402292B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelInGame;

		// Token: 0x0402292C RID: 141612
		[Token(Token = "0x402292C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x0402292D RID: 141613
		[Token(Token = "0x402292D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _enoughCost;

		// Token: 0x0402292E RID: 141614
		[Token(Token = "0x402292E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _notEnoughCost;

		// Token: 0x0402292F RID: 141615
		[Token(Token = "0x402292F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022930 RID: 141616
		[Token(Token = "0x4022930")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
