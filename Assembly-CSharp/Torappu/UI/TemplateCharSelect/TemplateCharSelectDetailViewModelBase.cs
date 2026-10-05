using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BDC RID: 23516
	[Token(Token = "0x2005BDC")]
	public abstract class TemplateCharSelectDetailViewModelBase<CharType> : TemplateCharSelectDetailViewModel where CharType : TemplateCharSelectCardViewModel
	{
		// Token: 0x06022189 RID: 139657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022189")]
		public sealed override void UpdateWithChar(TemplateCharSelectCardViewModel charModel, bool forceUpdate)
		{
		}

		// Token: 0x0602218A RID: 139658
		[Token(Token = "0x602218A")]
		protected abstract void OnUpdateWithChar(CharType charType, bool forceUpdate);

		// Token: 0x0602218B RID: 139659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602218B")]
		public CharType GetTargetChar()
		{
			return null;
		}

		// Token: 0x0602218C RID: 139660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602218C")]
		public CharType CheckTargetChar()
		{
			return null;
		}

		// Token: 0x0602218D RID: 139661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602218D")]
		protected TemplateCharSelectDetailViewModelBase()
		{
		}

		// Token: 0x0402EC4D RID: 191565
		[Token(Token = "0x402EC4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateWithChar;

		// Token: 0x0402EC4E RID: 191566
		[Token(Token = "0x402EC4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetTargetChar;

		// Token: 0x0402EC4F RID: 191567
		[Token(Token = "0x402EC4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckTargetChar;

		// Token: 0x0402EC50 RID: 191568
		[Token(Token = "0x402EC50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
