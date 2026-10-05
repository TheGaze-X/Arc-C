using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044F9 RID: 17657
	[Token(Token = "0x20044F9")]
	public class RoguelikeCommonOuterBuffBottomView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF28 RID: 110376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF28")]
		[Address(RVA = "0x1419AC0", Offset = "0x14186C0", VA = "0x181419AC0")]
		public void Render(RoguelikeCommonOuterBuffViewModel viewModel, RoguelikeCommonOuterBuffNodeBaseViewModel nodeViewModel)
		{
		}

		// Token: 0x0601AF29 RID: 110377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF29")]
		[Address(RVA = "0x1419A40", Offset = "0x1418640", VA = "0x181419A40")]
		public void OnConfirmUpgrade()
		{
		}

		// Token: 0x0601AF2A RID: 110378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF2A")]
		[Address(RVA = "0x1419CC0", Offset = "0x14188C0", VA = "0x181419CC0")]
		public RoguelikeCommonOuterBuffBottomView()
		{
		}

		// Token: 0x04022931 RID: 141617
		[Token(Token = "0x4022931")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeCommonOuterBuffBottomIconView _iconView;

		// Token: 0x04022932 RID: 141618
		[Token(Token = "0x4022932")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x04022933 RID: 141619
		[Token(Token = "0x4022933")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _difficultPanel;

		// Token: 0x04022934 RID: 141620
		[Token(Token = "0x4022934")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeCommonOuterBuffBottomDifficultyView _diffView;

		// Token: 0x04022935 RID: 141621
		[Token(Token = "0x4022935")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeCommonOuterBuffBottomNormalView _normalView;

		// Token: 0x04022936 RID: 141622
		[Token(Token = "0x4022936")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<string> onConfirmUpgrade;

		// Token: 0x04022937 RID: 141623
		[Token(Token = "0x4022937")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04022938 RID: 141624
		[Token(Token = "0x4022938")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeCommonOuterBuffNodeBaseViewModel m_cachedNodeViewModel;

		// Token: 0x04022939 RID: 141625
		[Token(Token = "0x4022939")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402293A RID: 141626
		[Token(Token = "0x402293A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnConfirmUpgrade;

		// Token: 0x0402293B RID: 141627
		[Token(Token = "0x402293B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
