using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032CC RID: 13004
	[Token(Token = "0x20032CC")]
	public class UICharacterInfoSubPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x06014AC3 RID: 84675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030F5")]
		protected UICharacterInfoPanel parentPanel
		{
			[Token(Token = "0x6014AC3")]
			[Address(RVA = "0xCF25B0", Offset = "0xCF11B0", VA = "0x180CF25B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014AC4 RID: 84676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AC4")]
		[Address(RVA = "0xCF24D0", Offset = "0xCF10D0", VA = "0x180CF24D0", Slot = "4")]
		public virtual void OnInit(UICharacterInfoPanel parent)
		{
		}

		// Token: 0x06014AC5 RID: 84677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AC5")]
		[Address(RVA = "0xCF1410", Offset = "0xCF0010", VA = "0x180CF1410", Slot = "5")]
		public virtual void SetData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014AC6 RID: 84678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AC6")]
		[Address(RVA = "0xCF14A0", Offset = "0xCF00A0", VA = "0x180CF14A0", Slot = "6")]
		public virtual void UpdateData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014AC7 RID: 84679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AC7")]
		[Address(RVA = "0xCF1530", Offset = "0xCF0130", VA = "0x180CF1530", Slot = "7")]
		public virtual void UpdateExtraData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014AC8 RID: 84680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AC8")]
		[Address(RVA = "0xCF2550", Offset = "0xCF1150", VA = "0x180CF2550")]
		public UICharacterInfoSubPanel()
		{
		}

		// Token: 0x04018844 RID: 100420
		[Token(Token = "0x4018844")]
		[FieldOffset(Offset = "0x18")]
		private UICharacterInfoPanel m_parent;

		// Token: 0x04018845 RID: 100421
		[Token(Token = "0x4018845")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_parentPanel;

		// Token: 0x04018846 RID: 100422
		[Token(Token = "0x4018846")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018847 RID: 100423
		[Token(Token = "0x4018847")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04018848 RID: 100424
		[Token(Token = "0x4018848")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04018849 RID: 100425
		[Token(Token = "0x4018849")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateExtraData;

		// Token: 0x0401884A RID: 100426
		[Token(Token = "0x401884A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
