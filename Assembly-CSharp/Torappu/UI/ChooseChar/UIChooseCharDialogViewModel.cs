using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A33 RID: 23091
	[Token(Token = "0x2005A33")]
	public class UIChooseCharDialogViewModel : IHotfixable
	{
		// Token: 0x17004EEC RID: 20204
		// (get) Token: 0x060219EF RID: 137711 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060219F0 RID: 137712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004EEC")]
		public List<UIChooseCharDialogCharItemViewModel> ownedCharList
		{
			[Token(Token = "0x60219EF")]
			[Address(RVA = "0x1C12980", Offset = "0x1C11580", VA = "0x181C12980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60219F0")]
			[Address(RVA = "0x1C12A60", Offset = "0x1C11660", VA = "0x181C12A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004EED RID: 20205
		// (get) Token: 0x060219F1 RID: 137713 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060219F2 RID: 137714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004EED")]
		public List<UIChooseCharDialogCharItemViewModel> notOwnedCharList
		{
			[Token(Token = "0x60219F1")]
			[Address(RVA = "0x1C12920", Offset = "0x1C11520", VA = "0x181C12920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60219F2")]
			[Address(RVA = "0x1C129E0", Offset = "0x1C115E0", VA = "0x181C129E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004EEE RID: 20206
		// (get) Token: 0x060219F3 RID: 137715 RVA: 0x000BAE28 File Offset: 0x000B9028
		[Token(Token = "0x17004EEE")]
		public bool hasOwnedChars
		{
			[Token(Token = "0x60219F3")]
			[Address(RVA = "0x1C12860", Offset = "0x1C11460", VA = "0x181C12860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004EEF RID: 20207
		// (get) Token: 0x060219F4 RID: 137716 RVA: 0x000BAE40 File Offset: 0x000B9040
		[Token(Token = "0x17004EEF")]
		public bool hasNotOwnedChars
		{
			[Token(Token = "0x60219F4")]
			[Address(RVA = "0x1C127A0", Offset = "0x1C113A0", VA = "0x181C127A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060219F5 RID: 137717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219F5")]
		[Address(RVA = "0x1C121C0", Offset = "0x1C10DC0", VA = "0x181C121C0")]
		public void LoadData(List<string> charIdList)
		{
		}

		// Token: 0x060219F6 RID: 137718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219F6")]
		[Address(RVA = "0x1C125E0", Offset = "0x1C111E0", VA = "0x181C125E0")]
		private void _SortCharList(List<UIChooseCharDialogCharItemViewModel> viewModelList)
		{
		}

		// Token: 0x060219F7 RID: 137719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219F7")]
		[Address(RVA = "0x1C12740", Offset = "0x1C11340", VA = "0x181C12740")]
		public UIChooseCharDialogViewModel()
		{
		}

		// Token: 0x0402DF99 RID: 188313
		[Token(Token = "0x402DF99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ownedCharList;

		// Token: 0x0402DF9A RID: 188314
		[Token(Token = "0x402DF9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_ownedCharList;

		// Token: 0x0402DF9B RID: 188315
		[Token(Token = "0x402DF9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_notOwnedCharList;

		// Token: 0x0402DF9C RID: 188316
		[Token(Token = "0x402DF9C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_notOwnedCharList;

		// Token: 0x0402DF9D RID: 188317
		[Token(Token = "0x402DF9D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_hasOwnedChars;

		// Token: 0x0402DF9E RID: 188318
		[Token(Token = "0x402DF9E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_hasNotOwnedChars;

		// Token: 0x0402DF9F RID: 188319
		[Token(Token = "0x402DF9F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402DFA0 RID: 188320
		[Token(Token = "0x402DFA0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SortCharList;

		// Token: 0x0402DFA1 RID: 188321
		[Token(Token = "0x402DFA1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
