using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033A5 RID: 13221
	[Token(Token = "0x20033A5")]
	public class UIBattleSandboxCharacterInfoStatusSubPanel : UICharacterInfoStatusSubPanel
	{
		// Token: 0x06015178 RID: 86392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015178")]
		[Address(RVA = "0xD84DC0", Offset = "0xD839C0", VA = "0x180D84DC0", Slot = "4")]
		public override void OnInit(UICharacterInfoPanel parent)
		{
		}

		// Token: 0x06015179 RID: 86393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015179")]
		[Address(RVA = "0xD85400", Offset = "0xD84000", VA = "0x180D85400", Slot = "5")]
		public override void SetData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x0601517A RID: 86394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601517A")]
		[Address(RVA = "0xD860D0", Offset = "0xD84CD0", VA = "0x180D860D0")]
		private void _SetPackedResAmount(int amount)
		{
		}

		// Token: 0x0601517B RID: 86395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601517B")]
		[Address(RVA = "0xD85AA0", Offset = "0xD846A0", VA = "0x180D85AA0", Slot = "6")]
		public override void UpdateData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x0601517C RID: 86396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601517C")]
		[Address(RVA = "0xD86280", Offset = "0xD84E80", VA = "0x180D86280")]
		private void _SetTrapData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x0601517D RID: 86397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601517D")]
		[Address(RVA = "0xD86360", Offset = "0xD84F60", VA = "0x180D86360")]
		private void _UpdateTrapData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x0601517E RID: 86398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601517E")]
		[Address(RVA = "0xD85FE0", Offset = "0xD84BE0", VA = "0x180D85FE0")]
		private void _ActiveSelf(bool setActive = false)
		{
		}

		// Token: 0x0601517F RID: 86399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601517F")]
		[Address(RVA = "0xD86440", Offset = "0xD85040", VA = "0x180D86440")]
		public UIBattleSandboxCharacterInfoStatusSubPanel()
		{
		}

		// Token: 0x06015180 RID: 86400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015180")]
		[Address(RVA = "0xCEF9B0", Offset = "0xCEE5B0", VA = "0x180CEF9B0")]
		private void <>xLuaBaseProxy_OnInit(UICharacterInfoPanel P0)
		{
		}

		// Token: 0x06015181 RID: 86401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015181")]
		[Address(RVA = "0xCEF9C0", Offset = "0xCEE5C0", VA = "0x180CEF9C0")]
		private void <>xLuaBaseProxy_SetData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x06015182 RID: 86402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015182")]
		[Address(RVA = "0xCEF9F0", Offset = "0xCEE5F0", VA = "0x180CEF9F0")]
		private void <>xLuaBaseProxy_UpdateData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x040191CA RID: 102858
		[Token(Token = "0x40191CA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Sandbox")]
		private UICharacterInfoSubPanel _trapSubPanelPrefab;

		// Token: 0x040191CB RID: 102859
		[Token(Token = "0x40191CB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Sandbox Packed Res")]
		private Text _packedResAmount;

		// Token: 0x040191CC RID: 102860
		[Token(Token = "0x40191CC")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Sandbox Packed Res")]
		private Text _maxPackedResAmount;

		// Token: 0x040191CD RID: 102861
		[Token(Token = "0x40191CD")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Sandbox Packed Res")]
		private Color _noResItemColor;

		// Token: 0x040191CE RID: 102862
		[Token(Token = "0x40191CE")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Sandbox Packed Res")]
		private Color _haveResItemColor;

		// Token: 0x040191CF RID: 102863
		[Token(Token = "0x40191CF")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Sandbox Packed Res")]
		private UIBattleSandboxResItem _sandboxResItemPrefab;

		// Token: 0x040191D0 RID: 102864
		[Token(Token = "0x40191D0")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Sandbox Packed Res")]
		private GameObject _sandboxNoResItem;

		// Token: 0x040191D1 RID: 102865
		[Token(Token = "0x40191D1")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Sandbox Packed Res")]
		private Transform _sandboxResItemTransform;

		// Token: 0x040191D2 RID: 102866
		[Token(Token = "0x40191D2")]
		[FieldOffset(Offset = "0x100")]
		private int[] m_resInPack;

		// Token: 0x040191D3 RID: 102867
		[Token(Token = "0x40191D3")]
		[FieldOffset(Offset = "0x108")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x040191D4 RID: 102868
		[Token(Token = "0x40191D4")]
		[FieldOffset(Offset = "0x110")]
		private List<UIBattleSandboxResItem> m_resItemList;

		// Token: 0x040191D5 RID: 102869
		[Token(Token = "0x40191D5")]
		[FieldOffset(Offset = "0x118")]
		private UICharacterInfoSubPanel m_trapStatusSubPanel;

		// Token: 0x040191D6 RID: 102870
		[Token(Token = "0x40191D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040191D7 RID: 102871
		[Token(Token = "0x40191D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040191D8 RID: 102872
		[Token(Token = "0x40191D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetPackedResAmount;

		// Token: 0x040191D9 RID: 102873
		[Token(Token = "0x40191D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040191DA RID: 102874
		[Token(Token = "0x40191DA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetTrapData;

		// Token: 0x040191DB RID: 102875
		[Token(Token = "0x40191DB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateTrapData;

		// Token: 0x040191DC RID: 102876
		[Token(Token = "0x40191DC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ActiveSelf;

		// Token: 0x040191DD RID: 102877
		[Token(Token = "0x40191DD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
