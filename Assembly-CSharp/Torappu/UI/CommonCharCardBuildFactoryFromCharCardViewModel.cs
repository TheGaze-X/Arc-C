using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035A1 RID: 13729
	[Token(Token = "0x20035A1")]
	public struct CommonCharCardBuildFactoryFromCharCardViewModel<TChar> : ICharCardBuildFactory<TChar>, IHotfixable where TChar : class, ICharacterCardViewModel, new()
	{
		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x06015D56 RID: 89430 RVA: 0x0008E290 File Offset: 0x0008C490
		[Token(Token = "0x1700342D")]
		public bool isEmpty
		{
			[Token(Token = "0x6015D56")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x06015D57 RID: 89431 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015D58 RID: 89432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700342E")]
		public CharacterCardViewModel charCardViewModel
		{
			[Token(Token = "0x6015D57")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6015D58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D59 RID: 89433 RVA: 0x0008E2A8 File Offset: 0x0008C4A8
		[Token(Token = "0x6015D59")]
		public static CommonCharCardBuildFactoryFromCharCardViewModel<TChar> CreateFactory(CharacterCardViewModel charCardViewModel)
		{
			return default(CommonCharCardBuildFactoryFromCharCardViewModel<TChar>);
		}

		// Token: 0x06015D5A RID: 89434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D5A")]
		public void BuildTo(TChar targetChar)
		{
		}

		// Token: 0x06015D5B RID: 89435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015D5B")]
		public TChar BuildNew()
		{
			return null;
		}

		// Token: 0x0401A43D RID: 107581
		[Token(Token = "0x401A43D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0401A43E RID: 107582
		[Token(Token = "0x401A43E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charCardViewModel;

		// Token: 0x0401A43F RID: 107583
		[Token(Token = "0x401A43F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_charCardViewModel;

		// Token: 0x0401A440 RID: 107584
		[Token(Token = "0x401A440")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateFactory;

		// Token: 0x0401A441 RID: 107585
		[Token(Token = "0x401A441")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BuildTo;

		// Token: 0x0401A442 RID: 107586
		[Token(Token = "0x401A442")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BuildNew;
	}
}
