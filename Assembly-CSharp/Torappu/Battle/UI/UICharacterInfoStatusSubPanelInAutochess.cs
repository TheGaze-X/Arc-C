using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032C9 RID: 13001
	[Token(Token = "0x20032C9")]
	public class UICharacterInfoStatusSubPanelInAutochess : UICharacterInfoStatusSubPanel
	{
		// Token: 0x06014AB5 RID: 84661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AB5")]
		[Address(RVA = "0xCEF200", Offset = "0xCEDE00", VA = "0x180CEF200", Slot = "4")]
		public override void OnInit(UICharacterInfoPanel parent)
		{
		}

		// Token: 0x06014AB6 RID: 84662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AB6")]
		[Address(RVA = "0xCEF3C0", Offset = "0xCEDFC0", VA = "0x180CEF3C0", Slot = "5")]
		public override void SetData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014AB7 RID: 84663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AB7")]
		[Address(RVA = "0xCEFA20", Offset = "0xCEE620", VA = "0x180CEFA20", Slot = "6")]
		public override void UpdateData(ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode, Deck.Card card)
		{
		}

		// Token: 0x06014AB8 RID: 84664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AB8")]
		[Address(RVA = "0xCEFED0", Offset = "0xCEEAD0", VA = "0x180CEFED0")]
		private void _SetCampIcon(string bondId, Image image, Text text)
		{
		}

		// Token: 0x06014AB9 RID: 84665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014AB9")]
		[Address(RVA = "0xCF0040", Offset = "0xCEEC40", VA = "0x180CF0040")]
		public UICharacterInfoStatusSubPanelInAutochess()
		{
		}

		// Token: 0x06014ABA RID: 84666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ABA")]
		[Address(RVA = "0xCEF9B0", Offset = "0xCEE5B0", VA = "0x180CEF9B0")]
		private void <>xLuaBaseProxy_OnInit(UICharacterInfoPanel P0)
		{
		}

		// Token: 0x06014ABB RID: 84667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ABB")]
		[Address(RVA = "0xCEF9C0", Offset = "0xCEE5C0", VA = "0x180CEF9C0")]
		private void <>xLuaBaseProxy_SetData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x06014ABC RID: 84668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ABC")]
		[Address(RVA = "0xCEF9F0", Offset = "0xCEE5F0", VA = "0x180CEF9F0")]
		private void <>xLuaBaseProxy_UpdateData(ObjectPtr<Character> P0, UICharacterInfoPanel.ModeType P1, Deck.Card P2)
		{
		}

		// Token: 0x04018825 RID: 100389
		[Token(Token = "0x4018825")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Status")]
		private Text _costLabel;

		// Token: 0x04018826 RID: 100390
		[Token(Token = "0x4018826")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Status")]
		private Image _chessLvlIcon;

		// Token: 0x04018827 RID: 100391
		[Token(Token = "0x4018827")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Camp")]
		private Image _basicCampIcon;

		// Token: 0x04018828 RID: 100392
		[Token(Token = "0x4018828")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Camp")]
		private Text _basicCampText;

		// Token: 0x04018829 RID: 100393
		[Token(Token = "0x4018829")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Camp")]
		private Image[] _extraCampIcons;

		// Token: 0x0401882A RID: 100394
		[Token(Token = "0x401882A")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Camp")]
		private Text[] _extraCampTexts;

		// Token: 0x0401882B RID: 100395
		[Token(Token = "0x401882B")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Camp")]
		private Image _campGroupBkgImg;

		// Token: 0x0401882C RID: 100396
		[Token(Token = "0x401882C")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Camp")]
		private Color _campGroupBkgImgColorWhenNotEmpty;

		// Token: 0x0401882D RID: 100397
		[Token(Token = "0x401882D")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Camp")]
		private Color _campGroupBkgImgColorWhenEmpty;

		// Token: 0x0401882E RID: 100398
		[Token(Token = "0x401882E")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Status")]
		private Sprite[] _chessLevelSprites;

		// Token: 0x0401882F RID: 100399
		[Token(Token = "0x401882F")]
		[FieldOffset(Offset = "0x110")]
		private List<string> m_bondIds;

		// Token: 0x04018830 RID: 100400
		[Token(Token = "0x4018830")]
		[FieldOffset(Offset = "0x118")]
		private ObjectPtr<Character> m_cachedCharacterPtr;

		// Token: 0x04018831 RID: 100401
		[Token(Token = "0x4018831")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018832 RID: 100402
		[Token(Token = "0x4018832")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04018833 RID: 100403
		[Token(Token = "0x4018833")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04018834 RID: 100404
		[Token(Token = "0x4018834")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetCampIcon;

		// Token: 0x04018835 RID: 100405
		[Token(Token = "0x4018835")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
