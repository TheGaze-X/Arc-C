using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BE7 RID: 23527
	[Token(Token = "0x2005BE7")]
	public abstract class TemplateShuffleViewModelBase<CharType> : TemplateCharSelectShuffleViewModel where CharType : TemplateCharSelectCardViewModel
	{
		// Token: 0x060221C1 RID: 139713 RVA: 0x000BC5B0 File Offset: 0x000BA7B0
		[Token(Token = "0x60221C1")]
		public sealed override int SortChar(TemplateCharSelectCardViewModel a, TemplateCharSelectCardViewModel b)
		{
			return 0;
		}

		// Token: 0x060221C2 RID: 139714 RVA: 0x000BC5C8 File Offset: 0x000BA7C8
		[Token(Token = "0x60221C2")]
		public sealed override bool FilterChar(TemplateCharSelectCardViewModel charViewModel)
		{
			return default(bool);
		}

		// Token: 0x060221C3 RID: 139715 RVA: 0x000BC5E0 File Offset: 0x000BA7E0
		[Token(Token = "0x60221C3")]
		protected virtual int OnSortChar(CharType a, CharType b)
		{
			return 0;
		}

		// Token: 0x060221C4 RID: 139716 RVA: 0x000BC5F8 File Offset: 0x000BA7F8
		[Token(Token = "0x60221C4")]
		protected virtual bool OnFilterChar(CharType charViewModel)
		{
			return default(bool);
		}

		// Token: 0x060221C5 RID: 139717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60221C5")]
		private CharType _ConvertCharType(TemplateCharSelectCardViewModel charViewModel)
		{
			return null;
		}

		// Token: 0x060221C6 RID: 139718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221C6")]
		private void _LogWrongCharViewModelType(TemplateCharSelectCardViewModel chr)
		{
		}

		// Token: 0x060221C7 RID: 139719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221C7")]
		protected TemplateShuffleViewModelBase()
		{
		}

		// Token: 0x0402EC75 RID: 191605
		[Token(Token = "0x402EC75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SortChar;

		// Token: 0x0402EC76 RID: 191606
		[Token(Token = "0x402EC76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FilterChar;

		// Token: 0x0402EC77 RID: 191607
		[Token(Token = "0x402EC77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnSortChar;

		// Token: 0x0402EC78 RID: 191608
		[Token(Token = "0x402EC78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFilterChar;

		// Token: 0x0402EC79 RID: 191609
		[Token(Token = "0x402EC79")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ConvertCharType;

		// Token: 0x0402EC7A RID: 191610
		[Token(Token = "0x402EC7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LogWrongCharViewModelType;

		// Token: 0x0402EC7B RID: 191611
		[Token(Token = "0x402EC7B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
