using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033B4 RID: 13236
	[Token(Token = "0x20033B4")]
	public class UIBattleSandboxTrapInfoStatusSubPanel : UICharacterInfoStatusSubPanel
	{
		// Token: 0x060151F3 RID: 86515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151F3")]
		[Address(RVA = "0xD96380", Offset = "0xD94F80", VA = "0x180D96380", Slot = "4")]
		public override void OnInit(UICharacterInfoPanel parent)
		{
		}

		// Token: 0x060151F4 RID: 86516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151F4")]
		[Address(RVA = "0xD96520", Offset = "0xD95120", VA = "0x180D96520", Slot = "5")]
		public override void SetData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x060151F5 RID: 86517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151F5")]
		[Address(RVA = "0xD96920", Offset = "0xD95520", VA = "0x180D96920", Slot = "6")]
		public override void UpdateData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x060151F6 RID: 86518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151F6")]
		[Address(RVA = "0xD96AC0", Offset = "0xD956C0", VA = "0x180D96AC0")]
		public UIBattleSandboxTrapInfoStatusSubPanel()
		{
		}

		// Token: 0x060151F7 RID: 86519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151F7")]
		[Address(RVA = "0xCEF9B0", Offset = "0xCEE5B0", VA = "0x180CEF9B0")]
		private void <>xLuaBaseProxy_OnInit(UICharacterInfoPanel P0)
		{
		}

		// Token: 0x060151F8 RID: 86520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151F8")]
		[Address(RVA = "0xCEF9C0", Offset = "0xCEE5C0", VA = "0x180CEF9C0")]
		private void <>xLuaBaseProxy_SetData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x060151F9 RID: 86521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60151F9")]
		[Address(RVA = "0xCEF9F0", Offset = "0xCEE5F0", VA = "0x180CEF9F0")]
		private void <>xLuaBaseProxy_UpdateData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x040192D2 RID: 103122
		[Token(Token = "0x40192D2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Sandbox")]
		private Text _trapResName;

		// Token: 0x040192D3 RID: 103123
		[Token(Token = "0x40192D3")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Sandbox")]
		private GameObject _trapResPanel;

		// Token: 0x040192D4 RID: 103124
		[Token(Token = "0x40192D4")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Sandbox")]
		private UIBattleSandboxResItem _trapResItem;

		// Token: 0x040192D5 RID: 103125
		[Token(Token = "0x40192D5")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Sandbox Config")]
		private Sprite _buildingTrapIcon;

		// Token: 0x040192D6 RID: 103126
		[Token(Token = "0x40192D6")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Sandbox Config")]
		private Sprite _resTrapIcon;

		// Token: 0x040192D7 RID: 103127
		[Token(Token = "0x40192D7")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Sandbox Config")]
		private Sprite _NPCTrapIcon;

		// Token: 0x040192D8 RID: 103128
		[Token(Token = "0x40192D8")]
		[FieldOffset(Offset = "0xE0")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x040192D9 RID: 103129
		[Token(Token = "0x40192D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040192DA RID: 103130
		[Token(Token = "0x40192DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040192DB RID: 103131
		[Token(Token = "0x40192DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040192DC RID: 103132
		[Token(Token = "0x40192DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
