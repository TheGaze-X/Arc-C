using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052C8 RID: 21192
	[Token(Token = "0x20052C8")]
	public abstract class RoguelikeEndingViewModel : IHotfixable
	{
		// Token: 0x0601F415 RID: 128021
		[Token(Token = "0x601F415")]
		public abstract void LoadData(string topicId);

		// Token: 0x0601F416 RID: 128022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F416")]
		[Address(RVA = "0x18F9E40", Offset = "0x18F8A40", VA = "0x1818F9E40")]
		protected RoguelikeEndingViewModel()
		{
		}

		// Token: 0x04029FA6 RID: 171942
		[Token(Token = "0x4029FA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
