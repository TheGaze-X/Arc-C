using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044D8 RID: 17624
	[Token(Token = "0x20044D8")]
	public abstract class RoguelikeTopicNormalModeViewPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AE94 RID: 110228
		[Token(Token = "0x601AE94")]
		public abstract void Init(RoguelikeTopicNormalModeView view);

		// Token: 0x0601AE95 RID: 110229
		[Token(Token = "0x601AE95")]
		public abstract void Render(RoguelikeTopicModeViewModel viewModel);

		// Token: 0x0601AE96 RID: 110230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE96")]
		[Address(RVA = "0x1414180", Offset = "0x1412D80", VA = "0x181414180")]
		protected RoguelikeTopicNormalModeViewPlugin()
		{
		}

		// Token: 0x040227D3 RID: 141267
		[Token(Token = "0x40227D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
