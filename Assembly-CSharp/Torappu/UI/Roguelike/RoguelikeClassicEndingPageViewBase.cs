using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052AF RID: 21167
	[Token(Token = "0x20052AF")]
	public abstract class RoguelikeClassicEndingPageViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004938 RID: 18744
		// (get) Token: 0x0601F392 RID: 127890
		[Token(Token = "0x17004938")]
		public abstract ViewType viewType { [Token(Token = "0x601F392")] get; }

		// Token: 0x17004939 RID: 18745
		// (set) Token: 0x0601F393 RID: 127891
		[Token(Token = "0x17004939")]
		public abstract Action onBack { [Token(Token = "0x601F393")] set; }

		// Token: 0x1700493A RID: 18746
		// (set) Token: 0x0601F394 RID: 127892
		[Token(Token = "0x1700493A")]
		public abstract Action onForward { [Token(Token = "0x601F394")] set; }

		// Token: 0x1700493B RID: 18747
		// (set) Token: 0x0601F395 RID: 127893
		[Token(Token = "0x1700493B")]
		public abstract Action onConfirm { [Token(Token = "0x601F395")] set; }

		// Token: 0x0601F396 RID: 127894
		[Token(Token = "0x601F396")]
		public abstract RoguelikeClassicEndingPageViewModel ConstructViewModel();

		// Token: 0x0601F397 RID: 127895
		[Token(Token = "0x601F397")]
		public abstract void DoRender(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingPageViewModel viewModel);

		// Token: 0x0601F398 RID: 127896
		[Token(Token = "0x601F398")]
		public abstract void ApplyOutAnim();

		// Token: 0x0601F399 RID: 127897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F399")]
		[Address(RVA = "0x18E3A60", Offset = "0x18E2660", VA = "0x1818E3A60")]
		protected RoguelikeClassicEndingPageViewBase()
		{
		}

		// Token: 0x04029ED9 RID: 171737
		[Token(Token = "0x4029ED9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
