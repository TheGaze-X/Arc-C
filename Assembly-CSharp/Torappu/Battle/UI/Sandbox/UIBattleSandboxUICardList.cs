using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033C8 RID: 13256
	[Token(Token = "0x20033C8")]
	public class UIBattleSandboxUICardList : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x06015267 RID: 86631 RVA: 0x0008A888 File Offset: 0x00088A88
		[Token(Token = "0x17003233")]
		public int cardListMaxCnt
		{
			[Token(Token = "0x6015267")]
			[Address(RVA = "0xD9F8A0", Offset = "0xD9E4A0", VA = "0x180D9F8A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x06015268 RID: 86632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003234")]
		private GameModeFactory.SandboxGameMode sandboxGameMode
		{
			[Token(Token = "0x6015268")]
			[Address(RVA = "0xD9F910", Offset = "0xD9E510", VA = "0x180D9F910")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015269 RID: 86633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015269")]
		[Address(RVA = "0xD9F100", Offset = "0xD9DD00", VA = "0x180D9F100")]
		private void Update()
		{
		}

		// Token: 0x0601526A RID: 86634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601526A")]
		[Address(RVA = "0xD9ECE0", Offset = "0xD9D8E0", VA = "0x180D9ECE0")]
		public void OnInit(SandboxUIPlugin sandbox, UIController uiCtrl)
		{
		}

		// Token: 0x0601526B RID: 86635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601526B")]
		[Address(RVA = "0xD9F080", Offset = "0xD9DC80", VA = "0x180D9F080")]
		public void UpdateGameInfo()
		{
		}

		// Token: 0x0601526C RID: 86636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601526C")]
		[Address(RVA = "0xD9F1F0", Offset = "0xD9DDF0", VA = "0x180D9F1F0")]
		private void _UpdateInfo()
		{
		}

		// Token: 0x0601526D RID: 86637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601526D")]
		[Address(RVA = "0xD9F3E0", Offset = "0xD9DFE0", VA = "0x180D9F3E0")]
		private void _UpdateTopLine()
		{
		}

		// Token: 0x0601526E RID: 86638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601526E")]
		[Address(RVA = "0xD9EF40", Offset = "0xD9DB40", VA = "0x180D9EF40")]
		public void OnTurnPageClick()
		{
		}

		// Token: 0x0601526F RID: 86639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601526F")]
		[Address(RVA = "0xD9F7B0", Offset = "0xD9E3B0", VA = "0x180D9F7B0")]
		public UIBattleSandboxUICardList()
		{
		}

		// Token: 0x040193AA RID: 103338
		[Token(Token = "0x40193AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalModePart;

		// Token: 0x040193AB RID: 103339
		[Token(Token = "0x40193AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _buildModePart;

		// Token: 0x040193AC RID: 103340
		[Token(Token = "0x40193AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCurPage;

		// Token: 0x040193AD RID: 103341
		[Token(Token = "0x40193AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTotalPage;

		// Token: 0x040193AE RID: 103342
		[Token(Token = "0x40193AE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _cardListMaxCnt;

		// Token: 0x040193AF RID: 103343
		[Token(Token = "0x40193AF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _buttonToggle;

		// Token: 0x040193B0 RID: 103344
		[Token(Token = "0x40193B0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _topLine;

		// Token: 0x040193B1 RID: 103345
		[Token(Token = "0x40193B1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _viewPrefab;

		// Token: 0x040193B2 RID: 103346
		[Token(Token = "0x40193B2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIBattleSandboxDeco _deco;

		// Token: 0x040193B3 RID: 103347
		[Token(Token = "0x40193B3")]
		[FieldOffset(Offset = "0x60")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x040193B4 RID: 103348
		[Token(Token = "0x40193B4")]
		[FieldOffset(Offset = "0x68")]
		private List<GameObject> m_listViews;

		// Token: 0x040193B5 RID: 103349
		[Token(Token = "0x40193B5")]
		[FieldOffset(Offset = "0x70")]
		private UIController m_uiCtrl;

		// Token: 0x040193B6 RID: 103350
		[Token(Token = "0x40193B6")]
		[FieldOffset(Offset = "0x78")]
		private int m_curPage;

		// Token: 0x040193B7 RID: 103351
		[Token(Token = "0x40193B7")]
		[FieldOffset(Offset = "0x7C")]
		private int m_totalPage;

		// Token: 0x040193B8 RID: 103352
		[Token(Token = "0x40193B8")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedcurPage;

		// Token: 0x040193B9 RID: 103353
		[Token(Token = "0x40193B9")]
		[FieldOffset(Offset = "0x84")]
		private int m_cachedTotalPage;

		// Token: 0x040193BA RID: 103354
		[Token(Token = "0x40193BA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 CardListOffsetMax;

		// Token: 0x040193BB RID: 103355
		[Token(Token = "0x40193BB")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 CardListOffsetMin;

		// Token: 0x040193BC RID: 103356
		[Token(Token = "0x40193BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cardListMaxCnt;

		// Token: 0x040193BD RID: 103357
		[Token(Token = "0x40193BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_sandboxGameMode;

		// Token: 0x040193BE RID: 103358
		[Token(Token = "0x40193BE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040193BF RID: 103359
		[Token(Token = "0x40193BF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040193C0 RID: 103360
		[Token(Token = "0x40193C0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x040193C1 RID: 103361
		[Token(Token = "0x40193C1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateInfo;

		// Token: 0x040193C2 RID: 103362
		[Token(Token = "0x40193C2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateTopLine;

		// Token: 0x040193C3 RID: 103363
		[Token(Token = "0x40193C3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTurnPageClick;

		// Token: 0x040193C4 RID: 103364
		[Token(Token = "0x40193C4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
