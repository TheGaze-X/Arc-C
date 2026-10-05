using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A35 RID: 23093
	[Token(Token = "0x2005A35")]
	public class UIChooseCharDialogCharItemViewModel : ICommonChooseCharCardViewModel, IHotfixable
	{
		// Token: 0x060219FB RID: 137723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60219FB")]
		[Address(RVA = "0x1C11FE0", Offset = "0x1C10BE0", VA = "0x181C11FE0", Slot = "4")]
		public string GetCharId()
		{
			return null;
		}

		// Token: 0x060219FC RID: 137724 RVA: 0x000BAE70 File Offset: 0x000B9070
		[Token(Token = "0x60219FC")]
		[Address(RVA = "0x1C12100", Offset = "0x1C10D00", VA = "0x181C12100", Slot = "5")]
		public bool IsOwned()
		{
			return default(bool);
		}

		// Token: 0x060219FD RID: 137725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60219FD")]
		[Address(RVA = "0x1C11F80", Offset = "0x1C10B80", VA = "0x181C11F80", Slot = "6")]
		public CharacterData GetCharData()
		{
			return null;
		}

		// Token: 0x060219FE RID: 137726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60219FE")]
		[Address(RVA = "0x1C12040", Offset = "0x1C10C40", VA = "0x181C12040", Slot = "7")]
		public PlayerCharacter GetPlayerCharacter()
		{
			return null;
		}

		// Token: 0x060219FF RID: 137727 RVA: 0x000BAE88 File Offset: 0x000B9088
		[Token(Token = "0x60219FF")]
		[Address(RVA = "0x1C120A0", Offset = "0x1C10CA0", VA = "0x181C120A0", Slot = "8")]
		public bool IsClickable()
		{
			return default(bool);
		}

		// Token: 0x06021A00 RID: 137728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A00")]
		[Address(RVA = "0x1C12160", Offset = "0x1C10D60", VA = "0x181C12160")]
		public UIChooseCharDialogCharItemViewModel()
		{
		}

		// Token: 0x0402DFA4 RID: 188324
		[Token(Token = "0x402DFA4")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x0402DFA5 RID: 188325
		[Token(Token = "0x402DFA5")]
		[FieldOffset(Offset = "0x18")]
		public CharacterData characterData;

		// Token: 0x0402DFA6 RID: 188326
		[Token(Token = "0x402DFA6")]
		[FieldOffset(Offset = "0x20")]
		public PlayerCharacter playerCharacter;

		// Token: 0x0402DFA7 RID: 188327
		[Token(Token = "0x402DFA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCharId;

		// Token: 0x0402DFA8 RID: 188328
		[Token(Token = "0x402DFA8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsOwned;

		// Token: 0x0402DFA9 RID: 188329
		[Token(Token = "0x402DFA9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCharData;

		// Token: 0x0402DFAA RID: 188330
		[Token(Token = "0x402DFAA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPlayerCharacter;

		// Token: 0x0402DFAB RID: 188331
		[Token(Token = "0x402DFAB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsClickable;

		// Token: 0x0402DFAC RID: 188332
		[Token(Token = "0x402DFAC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
