using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002763 RID: 10083
	[Token(Token = "0x2002763")]
	public class AutoChessEffectManager : IHotfixable
	{
		// Token: 0x060106F2 RID: 67314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106F2")]
		[Address(RVA = "0x82A9A0", Offset = "0x8295A0", VA = "0x18082A9A0")]
		public void Start(AutoChessBattleMiscConfig.EffectConfig cfg)
		{
		}

		// Token: 0x060106F3 RID: 67315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106F3")]
		[Address(RVA = "0x82BE70", Offset = "0x82AA70", VA = "0x18082BE70")]
		private void _RegisterEvents()
		{
		}

		// Token: 0x060106F4 RID: 67316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106F4")]
		[Address(RVA = "0x82BB90", Offset = "0x82A790", VA = "0x18082BB90")]
		private void _OnDragUpdated(object arg)
		{
		}

		// Token: 0x060106F5 RID: 67317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106F5")]
		[Address(RVA = "0x82BAD0", Offset = "0x82A6D0", VA = "0x18082BAD0")]
		private void _OnDragPauseHintEffect(object arg)
		{
		}

		// Token: 0x060106F6 RID: 67318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106F6")]
		[Address(RVA = "0x82C240", Offset = "0x82AE40", VA = "0x18082C240")]
		private void _TurnOnHandTileMarkEffect(object arg)
		{
		}

		// Token: 0x060106F7 RID: 67319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106F7")]
		[Address(RVA = "0x82C170", Offset = "0x82AD70", VA = "0x18082C170")]
		private void _TurnOFFHandTileMarkEffect(object arg)
		{
		}

		// Token: 0x060106F8 RID: 67320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106F8")]
		[Address(RVA = "0x82BA40", Offset = "0x82A640", VA = "0x18082BA40")]
		private void _OnDataChanged(object arg)
		{
		}

		// Token: 0x060106F9 RID: 67321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106F9")]
		[Address(RVA = "0x82B680", Offset = "0x82A280", VA = "0x18082B680")]
		private void _OnChessMapChanged()
		{
		}

		// Token: 0x060106FA RID: 67322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106FA")]
		[Address(RVA = "0x82AB30", Offset = "0x829730", VA = "0x18082AB30")]
		private void _EmmitBoundEffect(object arg)
		{
		}

		// Token: 0x060106FB RID: 67323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106FB")]
		[Address(RVA = "0x82AF00", Offset = "0x829B00", VA = "0x18082AF00")]
		private void _EmmitChessUpgradeEffect(object arg)
		{
		}

		// Token: 0x060106FC RID: 67324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106FC")]
		[Address(RVA = "0x82B8E0", Offset = "0x82A4E0", VA = "0x18082B8E0")]
		private void _OnChessNewGained(object arg)
		{
		}

		// Token: 0x060106FD RID: 67325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106FD")]
		[Address(RVA = "0x82AD10", Offset = "0x829910", VA = "0x18082AD10")]
		private void _EmmitChessGainedEffectIfNeed(object arg)
		{
		}

		// Token: 0x060106FE RID: 67326 RVA: 0x000641D0 File Offset: 0x000623D0
		[Token(Token = "0x60106FE")]
		[Address(RVA = "0x82C6D0", Offset = "0x82B2D0", VA = "0x18082C6D0")]
		private bool _ValidateTurnOnHandTileMarkEffect(object arg)
		{
			return default(bool);
		}

		// Token: 0x060106FF RID: 67327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106FF")]
		[Address(RVA = "0x82C2D0", Offset = "0x82AED0", VA = "0x18082C2D0")]
		private void _UpdateDeckMarkEffect()
		{
		}

		// Token: 0x06010700 RID: 67328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010700")]
		[Address(RVA = "0x82B300", Offset = "0x829F00", VA = "0x18082B300")]
		private void _InitInvalideHandTileEffects()
		{
		}

		// Token: 0x06010701 RID: 67329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010701")]
		[Address(RVA = "0x82C8F0", Offset = "0x82B4F0", VA = "0x18082C8F0")]
		public AutoChessEffectManager()
		{
		}

		// Token: 0x04012657 RID: 75351
		[Token(Token = "0x4012657")]
		private const int DEFAULT_COL_MIN = 100000;

		// Token: 0x04012658 RID: 75352
		[Token(Token = "0x4012658")]
		private const int DEFAULT_COL_MAX = -1;

		// Token: 0x04012659 RID: 75353
		[Token(Token = "0x4012659")]
		private const int INVALID_INST_ID = -1;

		// Token: 0x0401265A RID: 75354
		[Token(Token = "0x401265A")]
		[FieldOffset(Offset = "0x10")]
		private AutoChessMapInfoChecker m_mapInfoChecker;

		// Token: 0x0401265B RID: 75355
		[Token(Token = "0x401265B")]
		[FieldOffset(Offset = "0x18")]
		private AutoChessBattleMiscConfig.EffectConfig m_cfg;

		// Token: 0x0401265C RID: 75356
		[Token(Token = "0x401265C")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 m_chessUpgradeEffectShopStartPos;

		// Token: 0x0401265D RID: 75357
		[Token(Token = "0x401265D")]
		[FieldOffset(Offset = "0x30")]
		private Effect m_buildableTileHintEffect;

		// Token: 0x0401265E RID: 75358
		[Token(Token = "0x401265E")]
		[FieldOffset(Offset = "0x38")]
		private Effect m_deckRegionEffect;

		// Token: 0x0401265F RID: 75359
		[Token(Token = "0x401265F")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<GridPosition, Effect> m_invalidHandTileWarningEffectList;

		// Token: 0x04012660 RID: 75360
		[Token(Token = "0x4012660")]
		[FieldOffset(Offset = "0x48")]
		private HashSet<GridPosition> m_posOfNewGainedChess;

		// Token: 0x04012661 RID: 75361
		[Token(Token = "0x4012661")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04012662 RID: 75362
		[Token(Token = "0x4012662")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RegisterEvents;

		// Token: 0x04012663 RID: 75363
		[Token(Token = "0x4012663")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnDragUpdated;

		// Token: 0x04012664 RID: 75364
		[Token(Token = "0x4012664")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnDragPauseHintEffect;

		// Token: 0x04012665 RID: 75365
		[Token(Token = "0x4012665")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TurnOnHandTileMarkEffect;

		// Token: 0x04012666 RID: 75366
		[Token(Token = "0x4012666")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TurnOFFHandTileMarkEffect;

		// Token: 0x04012667 RID: 75367
		[Token(Token = "0x4012667")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnDataChanged;

		// Token: 0x04012668 RID: 75368
		[Token(Token = "0x4012668")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnChessMapChanged;

		// Token: 0x04012669 RID: 75369
		[Token(Token = "0x4012669")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EmmitBoundEffect;

		// Token: 0x0401266A RID: 75370
		[Token(Token = "0x401266A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EmmitChessUpgradeEffect;

		// Token: 0x0401266B RID: 75371
		[Token(Token = "0x401266B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnChessNewGained;

		// Token: 0x0401266C RID: 75372
		[Token(Token = "0x401266C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EmmitChessGainedEffectIfNeed;

		// Token: 0x0401266D RID: 75373
		[Token(Token = "0x401266D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ValidateTurnOnHandTileMarkEffect;

		// Token: 0x0401266E RID: 75374
		[Token(Token = "0x401266E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateDeckMarkEffect;

		// Token: 0x0401266F RID: 75375
		[Token(Token = "0x401266F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitInvalideHandTileEffects;

		// Token: 0x04012670 RID: 75376
		[Token(Token = "0x4012670")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
