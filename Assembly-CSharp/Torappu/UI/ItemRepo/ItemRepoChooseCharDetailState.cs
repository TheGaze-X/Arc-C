using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E97 RID: 24215
	[Token(Token = "0x2005E97")]
	public class ItemRepoChooseCharDetailState : PopupFloatState
	{
		// Token: 0x0602314A RID: 143690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602314A")]
		[Address(RVA = "0x1D906B0", Offset = "0x1D8F2B0", VA = "0x181D906B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602314B RID: 143691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602314B")]
		[Address(RVA = "0x1D90DC0", Offset = "0x1D8F9C0", VA = "0x181D90DC0")]
		public void OpenCharacterShow()
		{
		}

		// Token: 0x0602314C RID: 143692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602314C")]
		[Address(RVA = "0x1D90710", Offset = "0x1D8F310", VA = "0x181D90710", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602314D RID: 143693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602314D")]
		[Address(RVA = "0x1D911B0", Offset = "0x1D8FDB0", VA = "0x181D911B0")]
		public static void ShowGacha(GameObject thisObj, List<ItemGet> items, Action onConfirmed)
		{
		}

		// Token: 0x0602314E RID: 143694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602314E")]
		[Address(RVA = "0x1D90EF0", Offset = "0x1D8FAF0", VA = "0x181D90EF0")]
		public void SendBuy()
		{
		}

		// Token: 0x0602314F RID: 143695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602314F")]
		[Address(RVA = "0x1D91750", Offset = "0x1D90350", VA = "0x181D91750")]
		public ItemRepoChooseCharDetailState()
		{
		}

		// Token: 0x06023152 RID: 143698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023152")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04030520 RID: 197920
		[Token(Token = "0x4030520")]
		[FieldOffset(Offset = "0x70")]
		private ItemRepoChooseCharDetailStateBean m_stateBean;

		// Token: 0x04030521 RID: 197921
		[Token(Token = "0x4030521")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _professionImg;

		// Token: 0x04030522 RID: 197922
		[Token(Token = "0x4030522")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _charName;

		// Token: 0x04030523 RID: 197923
		[Token(Token = "0x4030523")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _charTopName;

		// Token: 0x04030524 RID: 197924
		[Token(Token = "0x4030524")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _charRarity;

		// Token: 0x04030525 RID: 197925
		[Token(Token = "0x4030525")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAtlasImage _portrait;

		// Token: 0x04030526 RID: 197926
		[Token(Token = "0x4030526")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _descText;

		// Token: 0x04030527 RID: 197927
		[Token(Token = "0x4030527")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _usageText;

		// Token: 0x04030528 RID: 197928
		[Token(Token = "0x4030528")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _ensureText;

		// Token: 0x04030529 RID: 197929
		[Token(Token = "0x4030529")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403052A RID: 197930
		[Token(Token = "0x403052A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenCharacterShow;

		// Token: 0x0403052B RID: 197931
		[Token(Token = "0x403052B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403052C RID: 197932
		[Token(Token = "0x403052C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowGacha;

		// Token: 0x0403052D RID: 197933
		[Token(Token = "0x403052D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SendBuy;

		// Token: 0x0403052E RID: 197934
		[Token(Token = "0x403052E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
