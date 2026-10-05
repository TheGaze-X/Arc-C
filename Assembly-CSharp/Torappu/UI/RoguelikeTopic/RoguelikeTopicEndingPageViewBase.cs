using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044CB RID: 17611
	[Token(Token = "0x20044CB")]
	public abstract class RoguelikeTopicEndingPageViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003FD7 RID: 16343
		// (get) Token: 0x0601AE41 RID: 110145 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AE42 RID: 110146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FD7")]
		public RoguelikeTopicEndingControllerBase controller
		{
			[Token(Token = "0x601AE41")]
			[Address(RVA = "0x140C5E0", Offset = "0x140B1E0", VA = "0x18140C5E0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601AE42")]
			[Address(RVA = "0x140C640", Offset = "0x140B240", VA = "0x18140C640")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003FD8 RID: 16344
		// (get) Token: 0x0601AE43 RID: 110147
		[Token(Token = "0x17003FD8")]
		public abstract Type showType { [Token(Token = "0x601AE43")] get; }

		// Token: 0x0601AE44 RID: 110148
		[Token(Token = "0x601AE44")]
		public abstract void DoRender(RoguelikeTopicEndingPageViewModelBase pageViewModel);

		// Token: 0x0601AE45 RID: 110149
		[Token(Token = "0x601AE45")]
		public abstract void RestVisibilityHide();

		// Token: 0x0601AE46 RID: 110150
		[Token(Token = "0x601AE46")]
		public abstract void OnVisibilityUpdate(bool visible);

		// Token: 0x0601AE47 RID: 110151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE47")]
		[Address(RVA = "0x140C580", Offset = "0x140B180", VA = "0x18140C580")]
		protected RoguelikeTopicEndingPageViewBase()
		{
		}

		// Token: 0x04022761 RID: 141153
		[Token(Token = "0x4022761")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04022762 RID: 141154
		[Token(Token = "0x4022762")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04022763 RID: 141155
		[Token(Token = "0x4022763")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
