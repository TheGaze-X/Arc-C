using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200256C RID: 9580
	[Token(Token = "0x200256C")]
	public class LegionFindLibraryCardTrigger : TargetTrigger
	{
		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x0600F737 RID: 63287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700206C")]
		public override Entity target
		{
			[Token(Token = "0x600F737")]
			[Address(RVA = "0x710A40", Offset = "0x70F640", VA = "0x180710A40", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x0600F738 RID: 63288 RVA: 0x0005C4D8 File Offset: 0x0005A6D8
		[Token(Token = "0x1700206D")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F738")]
			[Address(RVA = "0x7109E0", Offset = "0x70F5E0", VA = "0x1807109E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x0600F739 RID: 63289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700206E")]
		private GameModeFactory.LegionGameMode gameMode
		{
			[Token(Token = "0x600F739")]
			[Address(RVA = "0x710860", Offset = "0x70F460", VA = "0x180710860")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F73A RID: 63290 RVA: 0x0005C4F0 File Offset: 0x0005A6F0
		[Token(Token = "0x600F73A")]
		[Address(RVA = "0x710410", Offset = "0x70F010", VA = "0x180710410", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F73B RID: 63291 RVA: 0x0005C508 File Offset: 0x0005A708
		[Token(Token = "0x600F73B")]
		[Address(RVA = "0x7103A0", Offset = "0x70EFA0", VA = "0x1807103A0", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F73C RID: 63292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F73C")]
		[Address(RVA = "0x710740", Offset = "0x70F340", VA = "0x180710740")]
		public LegionFindLibraryCardTrigger()
		{
		}

		// Token: 0x0600F73D RID: 63293 RVA: 0x0005C520 File Offset: 0x0005A720
		[Token(Token = "0x600F73D")]
		[Address(RVA = "0x6EF7F0", Offset = "0x6EE3F0", VA = "0x1806EF7F0")]
		private bool <>xLuaBaseProxy_get_isReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x040112A4 RID: 70308
		[Token(Token = "0x40112A4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _cardKey;

		// Token: 0x040112A5 RID: 70309
		[Token(Token = "0x40112A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LegionCardLibraryType _findType;

		// Token: 0x040112A6 RID: 70310
		[Token(Token = "0x40112A6")]
		[FieldOffset(Offset = "0x30")]
		private GameModeFactory.LegionGameMode m_gameMode;

		// Token: 0x040112A7 RID: 70311
		[Token(Token = "0x40112A7")]
		[FieldOffset(Offset = "0x38")]
		private List<Deck.Card> m_allCards;

		// Token: 0x040112A8 RID: 70312
		[Token(Token = "0x40112A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x040112A9 RID: 70313
		[Token(Token = "0x40112A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isReadyToTrig;

		// Token: 0x040112AA RID: 70314
		[Token(Token = "0x40112AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x040112AB RID: 70315
		[Token(Token = "0x40112AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x040112AC RID: 70316
		[Token(Token = "0x40112AC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x040112AD RID: 70317
		[Token(Token = "0x40112AD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
