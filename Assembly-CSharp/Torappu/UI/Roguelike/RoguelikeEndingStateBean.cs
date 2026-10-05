using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052C7 RID: 21191
	[Token(Token = "0x20052C7")]
	public class RoguelikeEndingStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601F413 RID: 128019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F413")]
		[Address(RVA = "0x18F8A00", Offset = "0x18F7600", VA = "0x1818F8A00")]
		public void LoadData(RoguelikeEndingControllerBase controller)
		{
		}

		// Token: 0x0601F414 RID: 128020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F414")]
		[Address(RVA = "0x18F8C10", Offset = "0x18F7810", VA = "0x1818F8C10")]
		public RoguelikeEndingStateBean()
		{
		}

		// Token: 0x04029FA1 RID: 171937
		[Token(Token = "0x4029FA1")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeEndingViewModel viewModel;

		// Token: 0x04029FA2 RID: 171938
		[Token(Token = "0x4029FA2")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x04029FA3 RID: 171939
		[Token(Token = "0x4029FA3")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicMode mode;

		// Token: 0x04029FA4 RID: 171940
		[Token(Token = "0x4029FA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029FA5 RID: 171941
		[Token(Token = "0x4029FA5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
