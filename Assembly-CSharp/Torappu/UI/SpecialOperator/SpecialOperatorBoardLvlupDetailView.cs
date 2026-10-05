using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E76 RID: 15990
	[Token(Token = "0x2003E76")]
	public abstract class SpecialOperatorBoardLvlupDetailView<TModel> : SpecialOperatorBoardLvlupDetailViewBase where TModel : SpecialOperatorBoardNodeBase
	{
		// Token: 0x06018DA1 RID: 101793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DA1")]
		public sealed override void OnRender(SpecialOperatorBoardNodeBase nodeData, bool isEnter)
		{
		}

		// Token: 0x06018DA2 RID: 101794
		[Token(Token = "0x6018DA2")]
		public abstract void Render(TModel viewModel, bool fastMode);

		// Token: 0x06018DA3 RID: 101795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DA3")]
		public void OnCommonConfirmClick()
		{
		}

		// Token: 0x06018DA4 RID: 101796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018DA4")]
		protected SpecialOperatorBoardLvlupDetailView()
		{
		}

		// Token: 0x0401E975 RID: 125301
		[Token(Token = "0x401E975")]
		[FieldOffset(Offset = "0x0")]
		private string m_cachedBaseNodeId;

		// Token: 0x0401E976 RID: 125302
		[Token(Token = "0x401E976")]
		[FieldOffset(Offset = "0x0")]
		private UIStateFinder m_baseStateFinder;

		// Token: 0x0401E977 RID: 125303
		[Token(Token = "0x401E977")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401E978 RID: 125304
		[Token(Token = "0x401E978")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCommonConfirmClick;

		// Token: 0x0401E979 RID: 125305
		[Token(Token = "0x401E979")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
