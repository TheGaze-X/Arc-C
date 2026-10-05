using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052B3 RID: 21171
	[Token(Token = "0x20052B3")]
	public abstract class RoguelikeClassicEndingTopView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700493E RID: 18750
		// (set) Token: 0x0601F3A8 RID: 127912
		[Token(Token = "0x1700493E")]
		public abstract Action onShowReport { [Token(Token = "0x601F3A8")] set; }

		// Token: 0x1700493F RID: 18751
		// (get) Token: 0x0601F3A9 RID: 127913
		[Token(Token = "0x1700493F")]
		protected abstract string showAnimName { [Token(Token = "0x601F3A9")] get; }

		// Token: 0x0601F3AA RID: 127914
		[Token(Token = "0x601F3AA")]
		protected abstract void Render(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingViewModel viewModel);

		// Token: 0x0601F3AB RID: 127915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3AB")]
		[Address(RVA = "0x18F6FF0", Offset = "0x18F5BF0", VA = "0x1818F6FF0")]
		public void DoRender(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingViewModel endingViewModel)
		{
		}

		// Token: 0x0601F3AC RID: 127916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3AC")]
		[Address(RVA = "0x18F7260", Offset = "0x18F5E60", VA = "0x1818F7260")]
		private void _ClearCacheTween()
		{
		}

		// Token: 0x0601F3AD RID: 127917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F3AD")]
		[Address(RVA = "0x18F71B0", Offset = "0x18F5DB0", VA = "0x1818F71B0")]
		private IEnumerator _ApplyInAnim()
		{
			return null;
		}

		// Token: 0x0601F3AE RID: 127918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3AE")]
		[Address(RVA = "0x18F72D0", Offset = "0x18F5ED0", VA = "0x1818F72D0")]
		protected RoguelikeClassicEndingTopView()
		{
		}

		// Token: 0x04029EE9 RID: 171753
		[Token(Token = "0x4029EE9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected UIAtlasImage _imageTitle;

		// Token: 0x04029EEA RID: 171754
		[Token(Token = "0x4029EEA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04029EEB RID: 171755
		[Token(Token = "0x4029EEB")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasRendered;

		// Token: 0x04029EEC RID: 171756
		[Token(Token = "0x4029EEC")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_cacheTween;

		// Token: 0x04029EED RID: 171757
		[Token(Token = "0x4029EED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x04029EEE RID: 171758
		[Token(Token = "0x4029EEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ClearCacheTween;

		// Token: 0x04029EEF RID: 171759
		[Token(Token = "0x4029EEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyInAnim;

		// Token: 0x04029EF0 RID: 171760
		[Token(Token = "0x4029EF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
