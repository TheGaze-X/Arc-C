using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064F9 RID: 25849
	[Token(Token = "0x20064F9")]
	public class AutoChessBattleShopCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170057A3 RID: 22435
		// (get) Token: 0x0602523E RID: 152126 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602523F RID: 152127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057A3")]
		public Action<int> onConfirmClick
		{
			[Token(Token = "0x602523E")]
			[Address(RVA = "0x201A080", Offset = "0x2018C80", VA = "0x18201A080")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602523F")]
			[Address(RVA = "0x201A0E0", Offset = "0x2018CE0", VA = "0x18201A0E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06025240 RID: 152128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025240")]
		[Address(RVA = "0x2019380", Offset = "0x2017F80", VA = "0x182019380")]
		public void SetGroup(ExclusiveSelectionGroup grp)
		{
		}

		// Token: 0x06025241 RID: 152129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025241")]
		[Address(RVA = "0x2018500", Offset = "0x2017100", VA = "0x182018500")]
		public void ClearBudyCheck()
		{
		}

		// Token: 0x06025242 RID: 152130 RVA: 0x000C6A80 File Offset: 0x000C4C80
		[Token(Token = "0x6025242")]
		[Address(RVA = "0x2019510", Offset = "0x2018110", VA = "0x182019510")]
		private bool _InitIfNot()
		{
			return default(bool);
		}

		// Token: 0x06025243 RID: 152131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025243")]
		[Address(RVA = "0x2019670", Offset = "0x2018270", VA = "0x182019670")]
		private void _RegisterTutorialGOIfNeed()
		{
		}

		// Token: 0x06025244 RID: 152132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025244")]
		[Address(RVA = "0x2018830", Offset = "0x2017430", VA = "0x182018830")]
		public void RenderView(int slotId, AutoChessBattleShopCardViewModel model, int selectSlot)
		{
		}

		// Token: 0x06025245 RID: 152133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025245")]
		[Address(RVA = "0x2018760", Offset = "0x2017360", VA = "0x182018760")]
		public void PlayRefreshAnim()
		{
		}

		// Token: 0x06025246 RID: 152134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025246")]
		[Address(RVA = "0x2019E30", Offset = "0x2018A30", VA = "0x182019E30")]
		private void _RenderFrozen(AutoChessBattleShopCardViewModel model, bool fastMode)
		{
		}

		// Token: 0x06025247 RID: 152135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025247")]
		[Address(RVA = "0x20197F0", Offset = "0x20183F0", VA = "0x1820197F0")]
		private void _RenderChar(AutoChessBattleShopCardViewModel model)
		{
		}

		// Token: 0x06025248 RID: 152136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025248")]
		[Address(RVA = "0x2019CA0", Offset = "0x20188A0", VA = "0x182019CA0")]
		private void _RenderEquip(AutoChessBattleShopCardViewModel model)
		{
		}

		// Token: 0x06025249 RID: 152137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025249")]
		[Address(RVA = "0x2019400", Offset = "0x2018000", VA = "0x182019400")]
		private Sprite _FindDiffTagSprite(ChessBackupCharDiff diff)
		{
			return null;
		}

		// Token: 0x0602524A RID: 152138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602524A")]
		[Address(RVA = "0x2018630", Offset = "0x2017230", VA = "0x182018630")]
		public void EventOnFirstClick()
		{
		}

		// Token: 0x0602524B RID: 152139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602524B")]
		[Address(RVA = "0x2018570", Offset = "0x2017170", VA = "0x182018570")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x0602524C RID: 152140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602524C")]
		[Address(RVA = "0x2018700", Offset = "0x2017300", VA = "0x182018700")]
		public void EventOnReset(bool isInit)
		{
		}

		// Token: 0x0602524D RID: 152141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602524D")]
		[Address(RVA = "0x201A020", Offset = "0x2018C20", VA = "0x18201A020")]
		public AutoChessBattleShopCardView()
		{
		}

		// Token: 0x04034126 RID: 213286
		[Token(Token = "0x4034126")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _refreshAnim;

		// Token: 0x04034127 RID: 213287
		[Token(Token = "0x4034127")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PrefabWidget _cost;

		// Token: 0x04034128 RID: 213288
		[Token(Token = "0x4034128")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _emptyToggle;

		// Token: 0x04034129 RID: 213289
		[Token(Token = "0x4034129")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _charToggle;

		// Token: 0x0403412A RID: 213290
		[Token(Token = "0x403412A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AutoChessComLevel _level;

		// Token: 0x0403412B RID: 213291
		[Token(Token = "0x403412B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _notEnoughNode;

		// Token: 0x0403412C RID: 213292
		[Token(Token = "0x403412C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _freezeNode;

		// Token: 0x0403412D RID: 213293
		[Token(Token = "0x403412D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _freezeAnim;

		// Token: 0x0403412E RID: 213294
		[Token(Token = "0x403412E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TwoStateToggle _enoughToggle;

		// Token: 0x0403412F RID: 213295
		[Token(Token = "0x403412F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TwoPhaseButtonWidget _twoPhase;

		// Token: 0x04034130 RID: 213296
		[Token(Token = "0x4034130")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _btnClick;

		// Token: 0x04034131 RID: 213297
		[Token(Token = "0x4034131")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _repeatedFxNode;

		// Token: 0x04034132 RID: 213298
		[Token(Token = "0x4034132")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Char")]
		private UIAtlasImage _charIcon;

		// Token: 0x04034133 RID: 213299
		[Token(Token = "0x4034133")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Char")]
		private Image _profIcon;

		// Token: 0x04034134 RID: 213300
		[Token(Token = "0x4034134")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Char")]
		private Image _garrisonIcon;

		// Token: 0x04034135 RID: 213301
		[Token(Token = "0x4034135")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Char")]
		private Text _charName;

		// Token: 0x04034136 RID: 213302
		[Token(Token = "0x4034136")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Char")]
		private SimpleLayoutContent _bondList;

		// Token: 0x04034137 RID: 213303
		[Token(Token = "0x4034137")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Char")]
		private ThreeStateToggle _charLevelFrame;

		// Token: 0x04034138 RID: 213304
		[Token(Token = "0x4034138")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Char")]
		private Image _diffTag;

		// Token: 0x04034139 RID: 213305
		[Token(Token = "0x4034139")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Char")]
		private AutoChessBattleShopCardView.DiffSprite[] _diffSprites;

		// Token: 0x0403413A RID: 213306
		[Token(Token = "0x403413A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Equip")]
		private Image _equipIcon;

		// Token: 0x0403413B RID: 213307
		[Token(Token = "0x403413B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Equip")]
		private Text _equipName;

		// Token: 0x0403413D RID: 213309
		[Token(Token = "0x403413D")]
		[FieldOffset(Offset = "0xE0")]
		private int m_slotId;

		// Token: 0x0403413E RID: 213310
		[Token(Token = "0x403413E")]
		[FieldOffset(Offset = "0xE8")]
		private string m_cachedChessId;

		// Token: 0x0403413F RID: 213311
		[Token(Token = "0x403413F")]
		[FieldOffset(Offset = "0xF0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034140 RID: 213312
		[Token(Token = "0x4034140")]
		[FieldOffset(Offset = "0x100")]
		private AutoChessBattleShopCardView.BondListAdapter m_bondListAdapter;

		// Token: 0x04034141 RID: 213313
		[Token(Token = "0x4034141")]
		[FieldOffset(Offset = "0x108")]
		private Tween m_freezeAnim;

		// Token: 0x04034142 RID: 213314
		[Token(Token = "0x4034142")]
		[FieldOffset(Offset = "0x110")]
		private Tween m_refreshAnim;

		// Token: 0x04034143 RID: 213315
		[Token(Token = "0x4034143")]
		private const int LEVEL_FIVE = 5;

		// Token: 0x04034144 RID: 213316
		[Token(Token = "0x4034144")]
		private const int LEVEL_SIX = 6;

		// Token: 0x04034145 RID: 213317
		[Token(Token = "0x4034145")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onConfirmClick;

		// Token: 0x04034146 RID: 213318
		[Token(Token = "0x4034146")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onConfirmClick;

		// Token: 0x04034147 RID: 213319
		[Token(Token = "0x4034147")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetGroup;

		// Token: 0x04034148 RID: 213320
		[Token(Token = "0x4034148")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ClearBudyCheck;

		// Token: 0x04034149 RID: 213321
		[Token(Token = "0x4034149")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403414A RID: 213322
		[Token(Token = "0x403414A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGOIfNeed;

		// Token: 0x0403414B RID: 213323
		[Token(Token = "0x403414B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403414C RID: 213324
		[Token(Token = "0x403414C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PlayRefreshAnim;

		// Token: 0x0403414D RID: 213325
		[Token(Token = "0x403414D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderFrozen;

		// Token: 0x0403414E RID: 213326
		[Token(Token = "0x403414E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderChar;

		// Token: 0x0403414F RID: 213327
		[Token(Token = "0x403414F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderEquip;

		// Token: 0x04034150 RID: 213328
		[Token(Token = "0x4034150")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__FindDiffTagSprite;

		// Token: 0x04034151 RID: 213329
		[Token(Token = "0x4034151")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnFirstClick;

		// Token: 0x04034152 RID: 213330
		[Token(Token = "0x4034152")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x04034153 RID: 213331
		[Token(Token = "0x4034153")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnReset;

		// Token: 0x04034154 RID: 213332
		[Token(Token = "0x4034154")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064FA RID: 25850
		[Token(Token = "0x20064FA")]
		private class BondListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170057A4 RID: 22436
			// (get) Token: 0x0602524E RID: 152142 RVA: 0x000C6A98 File Offset: 0x000C4C98
			[Token(Token = "0x170057A4")]
			public override int count
			{
				[Token(Token = "0x602524E")]
				[Address(RVA = "0x20252E0", Offset = "0x2023EE0", VA = "0x1820252E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602524F RID: 152143 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602524F")]
			[Address(RVA = "0x2025000", Offset = "0x2023C00", VA = "0x182025000", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06025250 RID: 152144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025250")]
			[Address(RVA = "0x2025280", Offset = "0x2023E80", VA = "0x182025280")]
			public BondListAdapter()
			{
			}

			// Token: 0x04034155 RID: 213333
			[Token(Token = "0x4034155")]
			[FieldOffset(Offset = "0x20")]
			public ILoadAsset assetLoader;

			// Token: 0x04034156 RID: 213334
			[Token(Token = "0x4034156")]
			[FieldOffset(Offset = "0x28")]
			public IList<AutoChessBattleShopBondViewModel> bondList;

			// Token: 0x04034157 RID: 213335
			[Token(Token = "0x4034157")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04034158 RID: 213336
			[Token(Token = "0x4034158")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04034159 RID: 213337
			[Token(Token = "0x4034159")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020064FB RID: 25851
		[Token(Token = "0x20064FB")]
		[Serializable]
		public class DiffSprite
		{
			// Token: 0x06025251 RID: 152145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025251")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DiffSprite()
			{
			}

			// Token: 0x0403415A RID: 213338
			[Token(Token = "0x403415A")]
			[FieldOffset(Offset = "0x10")]
			public ChessBackupCharDiff diff;

			// Token: 0x0403415B RID: 213339
			[Token(Token = "0x403415B")]
			[FieldOffset(Offset = "0x18")]
			public Sprite sprite;
		}
	}
}
