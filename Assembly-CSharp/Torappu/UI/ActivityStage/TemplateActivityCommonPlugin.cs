using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C77 RID: 27767
	[Token(Token = "0x2006C77")]
	public abstract class TemplateActivityCommonPlugin : MonoBehaviour, IBaseActViewBinder, IHotfixable
	{
		// Token: 0x17005DA9 RID: 23977
		// (get) Token: 0x06027A17 RID: 162327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DA9")]
		public string bindParam
		{
			[Token(Token = "0x6027A17")]
			[Address(RVA = "0x22CB560", Offset = "0x22CA160", VA = "0x1822CB560")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005DAA RID: 23978
		// (get) Token: 0x06027A18 RID: 162328 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027A19 RID: 162329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005DAA")]
		private protected IBaseActHandler actController
		{
			[Token(Token = "0x6027A18")]
			[Address(RVA = "0x22CB500", Offset = "0x22CA100", VA = "0x1822CB500")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6027A19")]
			[Address(RVA = "0x22CB5C0", Offset = "0x22CA1C0", VA = "0x1822CB5C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06027A1A RID: 162330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A1A")]
		[Address(RVA = "0x22CB3F0", Offset = "0x22C9FF0", VA = "0x1822CB3F0")]
		public void BindController(IBaseActHandler pController)
		{
		}

		// Token: 0x06027A1B RID: 162331
		[Token(Token = "0x6027A1B")]
		public abstract void OnViewModelRefresh(TemplateActivityViewModel viewModel);

		// Token: 0x06027A1C RID: 162332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A1C")]
		[Address(RVA = "0x22CB4A0", Offset = "0x22CA0A0", VA = "0x1822CB4A0")]
		protected TemplateActivityCommonPlugin()
		{
		}

		// Token: 0x04038346 RID: 230214
		[Token(Token = "0x4038346")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _bindParam;

		// Token: 0x04038348 RID: 230216
		[Token(Token = "0x4038348")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindParam;

		// Token: 0x04038349 RID: 230217
		[Token(Token = "0x4038349")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_actController;

		// Token: 0x0403834A RID: 230218
		[Token(Token = "0x403834A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_actController;

		// Token: 0x0403834B RID: 230219
		[Token(Token = "0x403834B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x0403834C RID: 230220
		[Token(Token = "0x403834C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
