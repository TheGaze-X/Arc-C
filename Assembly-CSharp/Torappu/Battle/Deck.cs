using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021C3 RID: 8643
	[Token(Token = "0x20021C3")]
	public class Deck : IHotfixable, IComparer<Deck.Card>, IComparer<Deck.DeckAruaWrapper>
	{
		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x0600D7B2 RID: 55218 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D7B1 RID: 55217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A47")]
		public List<DeckModifier> deckModifiers
		{
			[Token(Token = "0x600D7B2")]
			[Address(RVA = "0x35D3690", Offset = "0x35D2290", VA = "0x1835D3690")]
			get
			{
				return null;
			}
			[Token(Token = "0x600D7B1")]
			[Address(RVA = "0x35D3A50", Offset = "0x35D2650", VA = "0x1835D3A50")]
			set
			{
			}
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x0600D7B4 RID: 55220 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D7B3 RID: 55219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A48")]
		public List<Deck.Card.RuntimeCostModifier> deckLikeRuntimeCostModifiers
		{
			[Token(Token = "0x600D7B4")]
			[Address(RVA = "0x35D35D0", Offset = "0x35D21D0", VA = "0x1835D35D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600D7B3")]
			[Address(RVA = "0x35D3950", Offset = "0x35D2550", VA = "0x1835D3950")]
			set
			{
			}
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x0600D7B6 RID: 55222 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D7B5 RID: 55221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A49")]
		public List<Deck.Card.MiscSettingModifier> deckMiscModifier
		{
			[Token(Token = "0x600D7B6")]
			[Address(RVA = "0x35D3630", Offset = "0x35D2230", VA = "0x1835D3630")]
			get
			{
				return null;
			}
			[Token(Token = "0x600D7B5")]
			[Address(RVA = "0x35D39D0", Offset = "0x35D25D0", VA = "0x1835D39D0")]
			set
			{
			}
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x0600D7B7 RID: 55223 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D7B8 RID: 55224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A4A")]
		public Deck.Card[] cards
		{
			[Token(Token = "0x600D7B7")]
			[Address(RVA = "0x35D3570", Offset = "0x35D2170", VA = "0x1835D3570")]
			get
			{
				return null;
			}
			[Token(Token = "0x600D7B8")]
			[Address(RVA = "0x35D38D0", Offset = "0x35D24D0", VA = "0x1835D38D0")]
			set
			{
			}
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x0600D7B9 RID: 55225 RVA: 0x0004DF70 File Offset: 0x0004C170
		// (set) Token: 0x0600D7BA RID: 55226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A4B")]
		public int initCostUp
		{
			[Token(Token = "0x600D7B9")]
			[Address(RVA = "0x35D3750", Offset = "0x35D2350", VA = "0x1835D3750")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600D7BA")]
			[Address(RVA = "0x35D3B40", Offset = "0x35D2740", VA = "0x1835D3B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x0600D7BB RID: 55227 RVA: 0x0004DF88 File Offset: 0x0004C188
		// (set) Token: 0x0600D7BC RID: 55228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A4C")]
		public int initCharacterLimitUp
		{
			[Token(Token = "0x600D7BB")]
			[Address(RVA = "0x35D36F0", Offset = "0x35D22F0", VA = "0x1835D36F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600D7BC")]
			[Address(RVA = "0x35D3AD0", Offset = "0x35D26D0", VA = "0x1835D3AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x0600D7BD RID: 55229 RVA: 0x0004DFA0 File Offset: 0x0004C1A0
		// (set) Token: 0x0600D7BE RID: 55230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A4D")]
		public Deck.Options options
		{
			[Token(Token = "0x600D7BD")]
			[Address(RVA = "0x35D3810", Offset = "0x35D2410", VA = "0x1835D3810")]
			[CompilerGenerated]
			get
			{
				return default(Deck.Options);
			}
			[Token(Token = "0x600D7BE")]
			[Address(RVA = "0x35D3BB0", Offset = "0x35D27B0", VA = "0x1835D3BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x0600D7BF RID: 55231 RVA: 0x0004DFB8 File Offset: 0x0004C1B8
		// (set) Token: 0x0600D7C0 RID: 55232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A4E")]
		public PlayerSide playerSide
		{
			[Token(Token = "0x600D7BF")]
			[Address(RVA = "0x35D3870", Offset = "0x35D2470", VA = "0x1835D3870")]
			[CompilerGenerated]
			get
			{
				return PlayerSide.DEFAULT;
			}
			[Token(Token = "0x600D7C0")]
			[Address(RVA = "0x35D3C30", Offset = "0x35D2830", VA = "0x1835D3C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600D7C1 RID: 55233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7C1")]
		[Address(RVA = "0x35D2DB0", Offset = "0x35D19B0", VA = "0x1835D2DB0")]
		public Deck(BattlePlayerData playerData, Deck.Options options, PlayerSide playerSide)
		{
		}

		// Token: 0x0600D7C2 RID: 55234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7C2")]
		private void _PreprocessOverrideableModifiers<T>(List<T> modifiers) where T : IOverrideableDeckModifier
		{
		}

		// Token: 0x0600D7C3 RID: 55235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7C3")]
		[Address(RVA = "0x35D0100", Offset = "0x35CED00", VA = "0x1835D0100")]
		public void PreprocessDeck()
		{
		}

		// Token: 0x0600D7C4 RID: 55236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7C4")]
		[Address(RVA = "0x35D06D0", Offset = "0x35CF2D0", VA = "0x1835D06D0")]
		public void RechargeToken(uint uid, int count, Deck.Card.RechargeTiming timing, bool refreshRemainingCnt = false)
		{
		}

		// Token: 0x0600D7C5 RID: 55237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7C5")]
		[Address(RVA = "0x35D0890", Offset = "0x35CF490", VA = "0x1835D0890")]
		public void RechargeToken(string key, int count, Deck.Card.RechargeTiming timing, bool refreshRemainingCnt = false)
		{
		}

		// Token: 0x0600D7C6 RID: 55238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7C6")]
		[Address(RVA = "0x35D0FE0", Offset = "0x35CFBE0", VA = "0x1835D0FE0")]
		public void RefreshTokenDeployAndDeckStackCnt(uint uid, int maxDeployCntAddition, int maxDeckStackCntAddition)
		{
		}

		// Token: 0x0600D7C7 RID: 55239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7C7")]
		[Address(RVA = "0x35CEFA0", Offset = "0x35CDBA0", VA = "0x1835CEFA0")]
		public void ForceRechargeToken(string key, int count, Deck.Card.RechargeTiming timing)
		{
		}

		// Token: 0x0600D7C8 RID: 55240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7C8")]
		[Address(RVA = "0x35CEDE0", Offset = "0x35CD9E0", VA = "0x1835CEDE0")]
		public void ForceRechargeToken(uint uid, int count, Deck.Card.RechargeTiming timing, bool refreshRemainingCnt = false)
		{
		}

		// Token: 0x0600D7C9 RID: 55241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7C9")]
		[Address(RVA = "0x35D0B00", Offset = "0x35CF700", VA = "0x1835D0B00")]
		public void RecycleCard(uint instanceUid)
		{
		}

		// Token: 0x0600D7CA RID: 55242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7CA")]
		[Address(RVA = "0x35D0E50", Offset = "0x35CFA50", VA = "0x1835D0E50")]
		public void RecycleTokenCard(uint instanceUid)
		{
		}

		// Token: 0x0600D7CB RID: 55243 RVA: 0x0004DFD0 File Offset: 0x0004C1D0
		[Token(Token = "0x600D7CB")]
		[Address(RVA = "0x35D21B0", Offset = "0x35D0DB0", VA = "0x1835D21B0")]
		public bool TryGetTokenCardIndex(uint uid, out int index)
		{
			return default(bool);
		}

		// Token: 0x0600D7CC RID: 55244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D7CC")]
		[Address(RVA = "0x35D2440", Offset = "0x35D1040", VA = "0x1835D2440")]
		private RectTransform _LoadCardEffectPluginIfNot(string name)
		{
			return null;
		}

		// Token: 0x0600D7CD RID: 55245 RVA: 0x0004DFE8 File Offset: 0x0004C1E8
		[Token(Token = "0x600D7CD")]
		[Address(RVA = "0x35D1650", Offset = "0x35D0250", VA = "0x1835D1650")]
		public bool SpawnCharacterOrToken(uint uid, SharedConsts.Direction direction, Tile tile, bool strict, bool spawnManually, bool freely, bool ignoreAdvancedBuildableMask = false)
		{
			return default(bool);
		}

		// Token: 0x0600D7CE RID: 55246 RVA: 0x0004E000 File Offset: 0x0004C200
		[Token(Token = "0x600D7CE")]
		[Address(RVA = "0x35D1510", Offset = "0x35D0110", VA = "0x1835D1510")]
		public bool SpawnCharacterOrToken(uint uid, SharedConsts.Direction direction, Tile tile, bool strict, bool spawnManually, bool freely, bool ignoreAdvancedBuildableMask, out Character characterOrToken)
		{
			return default(bool);
		}

		// Token: 0x0600D7CF RID: 55247 RVA: 0x0004E018 File Offset: 0x0004C218
		[Token(Token = "0x600D7CF")]
		[Address(RVA = "0x35D1CD0", Offset = "0x35D08D0", VA = "0x1835D1CD0")]
		public bool SpawnTokenFreely(string key, Character host, SharedConsts.Direction direction, Tile tile, bool strict, bool spawnManually, bool refreshCooldown, out Character charOrToken, bool ignoreAdvancedBuildableMask = false, bool forceSpawn = false, bool dontUpdateState = false)
		{
			return default(bool);
		}

		// Token: 0x0600D7D0 RID: 55248 RVA: 0x0004E030 File Offset: 0x0004C230
		[Token(Token = "0x600D7D0")]
		[Address(RVA = "0x35D1790", Offset = "0x35D0390", VA = "0x1835D1790")]
		public bool SpawnCharacterOrToken(Deck.Card card, SharedConsts.Direction direction, Tile tile, bool strict, bool spawnManually, bool freely, out Character charOrToken, bool ignoreAdvancedBuildableMask = false, bool forceSpawn = false, bool ignoreHostAlive = false, bool forceReduceRemainingCnt = false, bool dontUpdateState = false)
		{
			return default(bool);
		}

		// Token: 0x0600D7D1 RID: 55249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7D1")]
		[Address(RVA = "0x35D2300", Offset = "0x35D0F00", VA = "0x1835D2300")]
		private void _DealWithOverlapLike(Deck.Card card, bool freely)
		{
		}

		// Token: 0x0600D7D2 RID: 55250 RVA: 0x0004E048 File Offset: 0x0004C248
		[Token(Token = "0x600D7D2")]
		[Address(RVA = "0x35CD970", Offset = "0x35CC570", VA = "0x1835CD970")]
		public bool ActivateHiddenCard(string alias, string hiddenKey, out Deck.Card card)
		{
			return default(bool);
		}

		// Token: 0x0600D7D3 RID: 55251 RVA: 0x0004E060 File Offset: 0x0004C260
		[Token(Token = "0x600D7D3")]
		[Address(RVA = "0x35CD740", Offset = "0x35CC340", VA = "0x1835CD740")]
		public bool ActivateHiddenCard(Deck.Card card, string hiddenKey)
		{
			return default(bool);
		}

		// Token: 0x0600D7D4 RID: 55252 RVA: 0x0004E078 File Offset: 0x0004C278
		[Token(Token = "0x600D7D4")]
		[Address(RVA = "0x35CF200", Offset = "0x35CDE00", VA = "0x1835CF200")]
		public bool HideCard(Deck.Card card, string hideKey)
		{
			return default(bool);
		}

		// Token: 0x0600D7D5 RID: 55253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7D5")]
		[Address(RVA = "0x35CFAA0", Offset = "0x35CE6A0", VA = "0x1835CFAA0")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x0600D7D6 RID: 55254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D7D6")]
		[Address(RVA = "0x35CED20", Offset = "0x35CD920", VA = "0x1835CED20")]
		public Deck.Card FindCard(uint uid)
		{
			return null;
		}

		// Token: 0x0600D7D7 RID: 55255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D7D7")]
		[Address(RVA = "0x35CEB10", Offset = "0x35CD710", VA = "0x1835CEB10")]
		public Deck.Card FindCardById(string id)
		{
			return null;
		}

		// Token: 0x0600D7D8 RID: 55256 RVA: 0x0004E090 File Offset: 0x0004C290
		[Token(Token = "0x600D7D8")]
		[Address(RVA = "0x35CE6A0", Offset = "0x35CD2A0", VA = "0x1835CE6A0")]
		public bool FindAllCardById(string id, List<Deck.Card> resultList)
		{
			return default(bool);
		}

		// Token: 0x0600D7D9 RID: 55257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D7D9")]
		[Address(RVA = "0x35CE900", Offset = "0x35CD500", VA = "0x1835CE900")]
		public Deck.Card FindCardByAlias(string alias)
		{
			return null;
		}

		// Token: 0x0600D7DA RID: 55258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7DA")]
		[Address(RVA = "0x35D27C0", Offset = "0x35D13C0", VA = "0x1835D27C0")]
		private void _PostProcessDeckModifiers(IList<DeckModifier> deckModifiers)
		{
		}

		// Token: 0x0600D7DB RID: 55259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7DB")]
		[Address(RVA = "0x35D2550", Offset = "0x35D1150", VA = "0x1835D2550")]
		private void _PostProcessDeckLikeRuntimeCostModifiers(IList<Deck.Card.RuntimeCostModifier> decklikeRuntimeCostModifiers)
		{
		}

		// Token: 0x0600D7DC RID: 55260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7DC")]
		[Address(RVA = "0x35D2990", Offset = "0x35D1590", VA = "0x1835D2990")]
		private void _PostProcessDeckRuntimeMiscModifiers(IList<Deck.Card.MiscSettingModifier> deckMiscModifiers)
		{
		}

		// Token: 0x0600D7DD RID: 55261 RVA: 0x0004E0A8 File Offset: 0x0004C2A8
		[Token(Token = "0x600D7DD")]
		[Address(RVA = "0x35D2BF0", Offset = "0x35D17F0", VA = "0x1835D2BF0")]
		private bool _TryGetToken(Deck.Card card, out Deck.TokenCard token)
		{
			return default(bool);
		}

		// Token: 0x0600D7DE RID: 55262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7DE")]
		[Address(RVA = "0x35CF9C0", Offset = "0x35CE5C0", VA = "0x1835CF9C0")]
		public void OnDeckSorted()
		{
		}

		// Token: 0x0600D7DF RID: 55263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7DF")]
		[Address(RVA = "0x35CF6E0", Offset = "0x35CE2E0", VA = "0x1835CF6E0")]
		public void OnCardListChanged(Deck.Card newCard)
		{
		}

		// Token: 0x0600D7E0 RID: 55264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E0")]
		[Address(RVA = "0x35CF450", Offset = "0x35CE050", VA = "0x1835CF450")]
		public void OnCardCostChanged(Deck.Card card)
		{
		}

		// Token: 0x0600D7E1 RID: 55265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E1")]
		[Address(RVA = "0x35CF890", Offset = "0x35CE490", VA = "0x1835CF890")]
		public void OnCardRecycle(Deck.Card card)
		{
		}

		// Token: 0x0600D7E2 RID: 55266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E2")]
		[Address(RVA = "0x35CF580", Offset = "0x35CE180", VA = "0x1835CF580")]
		public void OnCardEffectChanged(Deck.Card card)
		{
		}

		// Token: 0x0600D7E3 RID: 55267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E3")]
		[Address(RVA = "0x35CF3C0", Offset = "0x35CDFC0", VA = "0x1835CF3C0")]
		public void OnCardAppearanceChangedE(Deck.Card card)
		{
		}

		// Token: 0x0600D7E4 RID: 55268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E4")]
		[Address(RVA = "0x35CF4F0", Offset = "0x35CE0F0", VA = "0x1835CF4F0")]
		public void OnCardDrawn(Deck.Card card)
		{
		}

		// Token: 0x0600D7E5 RID: 55269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E5")]
		[Address(RVA = "0x35CFDF0", Offset = "0x35CE9F0", VA = "0x1835CFDF0")]
		public void OnPlayCardAnim(Deck.Card card, string animName)
		{
		}

		// Token: 0x0600D7E6 RID: 55270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E6")]
		[Address(RVA = "0x35CF910", Offset = "0x35CE510", VA = "0x1835CF910")]
		public void OnCardSpawn(GridPosition pos, SharedConsts.Direction dir, Deck.Card card)
		{
		}

		// Token: 0x0600D7E7 RID: 55271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E7")]
		[Address(RVA = "0x35CF610", Offset = "0x35CE210", VA = "0x1835CF610")]
		public void OnCardGetOffHand(Deck.Card card)
		{
		}

		// Token: 0x0600D7E8 RID: 55272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E8")]
		[Address(RVA = "0x35CF7C0", Offset = "0x35CE3C0", VA = "0x1835CF7C0")]
		public void OnCardPutInHand(Deck.Card card)
		{
		}

		// Token: 0x0600D7E9 RID: 55273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7E9")]
		[Address(RVA = "0x35CFE90", Offset = "0x35CEA90", VA = "0x1835CFE90")]
		public void OnReset()
		{
		}

		// Token: 0x0600D7EA RID: 55274 RVA: 0x0004E0C0 File Offset: 0x0004C2C0
		[Token(Token = "0x600D7EA")]
		[Address(RVA = "0x35CE3A0", Offset = "0x35CCFA0", VA = "0x1835CE3A0", Slot = "4")]
		public int Compare(Deck.Card lhs, Deck.Card rhs)
		{
			return 0;
		}

		// Token: 0x0600D7EB RID: 55275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7EB")]
		[Address(RVA = "0x35CDA30", Offset = "0x35CC630", VA = "0x1835CDA30")]
		public void AddDeckAura(IDeckAura aura)
		{
		}

		// Token: 0x0600D7EC RID: 55276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7EC")]
		[Address(RVA = "0x35D1180", Offset = "0x35CFD80", VA = "0x1835D1180")]
		public void RemoveDeckAura(IDeckAura aura)
		{
		}

		// Token: 0x0600D7ED RID: 55277 RVA: 0x0004E0D8 File Offset: 0x0004C2D8
		[Token(Token = "0x600D7ED")]
		[Address(RVA = "0x35CE260", Offset = "0x35CCE60", VA = "0x1835CE260", Slot = "5")]
		public int Compare(Deck.DeckAruaWrapper x, Deck.DeckAruaWrapper y)
		{
			return 0;
		}

		// Token: 0x0600D7EE RID: 55278 RVA: 0x0004E0F0 File Offset: 0x0004C2F0
		[Token(Token = "0x600D7EE")]
		[Address(RVA = "0x35D2100", Offset = "0x35D0D00", VA = "0x1835D2100")]
		public bool TryGetOverrideRawCostData(uint cardUid, out int overrideCost)
		{
			return default(bool);
		}

		// Token: 0x0600D7EF RID: 55279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7EF")]
		[Address(RVA = "0x35CDF20", Offset = "0x35CCB20", VA = "0x1835CDF20")]
		public void AddRawCostOverrider(string buffKey, Deck.DeckRawCostOverrideData overriders)
		{
		}

		// Token: 0x0600D7F0 RID: 55280 RVA: 0x0004E108 File Offset: 0x0004C308
		[Token(Token = "0x600D7F0")]
		[Address(RVA = "0x35CF320", Offset = "0x35CDF20", VA = "0x1835CF320")]
		public bool IsAttachedFrame()
		{
			return default(bool);
		}

		// Token: 0x0600D7F1 RID: 55281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7F1")]
		[Address(RVA = "0x35D1470", Offset = "0x35D0070", VA = "0x1835D1470")]
		public void RemoveRawCostOverriderDataByCardUid(uint cardUid)
		{
		}

		// Token: 0x0600D7F2 RID: 55282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D7F2")]
		[Address(RVA = "0x35CE0B0", Offset = "0x35CCCB0", VA = "0x1835CE0B0")]
		public void ClearRawCost()
		{
		}

		// Token: 0x0600D7F3 RID: 55283 RVA: 0x0004E120 File Offset: 0x0004C320
		[Token(Token = "0x600D7F3")]
		[Address(RVA = "0x35CE030", Offset = "0x35CCC30", VA = "0x1835CE030")]
		public bool AllowOverrideRawCost()
		{
			return default(bool);
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x0600D7F4 RID: 55284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A4F")]
		public Deck.DeckManagedCardBuffController managedCardBuffController
		{
			[Token(Token = "0x600D7F4")]
			[Address(RVA = "0x35D37B0", Offset = "0x35D23B0", VA = "0x1835D37B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400E840 RID: 59456
		[Token(Token = "0x400E840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<Deck.Card[]> onCardListChanged;

		// Token: 0x0400E841 RID: 59457
		[Token(Token = "0x400E841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<Deck.Card> onCardCostChanged;

		// Token: 0x0400E842 RID: 59458
		[Token(Token = "0x400E842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<Deck.Card> onCardEffectChanged;

		// Token: 0x0400E843 RID: 59459
		[Token(Token = "0x400E843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<Deck.Card> onCardAppearanceChangedE;

		// Token: 0x0400E844 RID: 59460
		[Token(Token = "0x400E844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<GridPosition, SharedConsts.Direction, Deck.Card> onCardSpawn;

		// Token: 0x0400E845 RID: 59461
		[Token(Token = "0x400E845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<Deck.Card, string> onPlayCardAnim;

		// Token: 0x0400E846 RID: 59462
		[Token(Token = "0x400E846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<uint, Deck.Card> m_cardMap;

		// Token: 0x0400E847 RID: 59463
		[Token(Token = "0x400E847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<uint, Deck.TokenCard> m_tokenMap;

		// Token: 0x0400E848 RID: 59464
		[Token(Token = "0x400E848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Deck.Card[] m_cards;

		// Token: 0x0400E849 RID: 59465
		[Token(Token = "0x400E849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Deck.SpawnDetailsTracker m_spawnDetailsTracker;

		// Token: 0x0400E84A RID: 59466
		[Token(Token = "0x400E84A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_needUpdateDeckAura;

		// Token: 0x0400E84B RID: 59467
		[Token(Token = "0x400E84B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<DeckModifier> m_deckModifiers;

		// Token: 0x0400E84C RID: 59468
		[Token(Token = "0x400E84C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<Deck.Card.RuntimeCostModifier> m_deckLikeRuntimeCostModifiers;

		// Token: 0x0400E84D RID: 59469
		[Token(Token = "0x400E84D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<Deck.Card.MiscSettingModifier> m_deckMiscModifier;

		// Token: 0x0400E84E RID: 59470
		[Token(Token = "0x400E84E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<string, RectTransform> m_loadedCardEffectPlugins;

		// Token: 0x0400E84F RID: 59471
		[Token(Token = "0x400E84F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_shouldSortThisFrame;

		// Token: 0x0400E854 RID: 59476
		[Token(Token = "0x400E854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<Deck.DeckAruaWrapper> m_deckAuras;

		// Token: 0x0400E855 RID: 59477
		[Token(Token = "0x400E855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool m_isInDeckAuraLock;

		// Token: 0x0400E856 RID: 59478
		[Token(Token = "0x400E856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool m_shouldSortDeckAfterCostChange;

		// Token: 0x0400E857 RID: 59479
		[Token(Token = "0x400E857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Deck.DeckRawCostOverrideManager m_rawCostOverrideManager;

		// Token: 0x0400E858 RID: 59480
		[Token(Token = "0x400E858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Deck.DeckManagedCardBuffController m_managedCardBuffController;

		// Token: 0x0400E859 RID: 59481
		[Token(Token = "0x400E859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_deckModifiers;

		// Token: 0x0400E85A RID: 59482
		[Token(Token = "0x400E85A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_deckModifiers;

		// Token: 0x0400E85B RID: 59483
		[Token(Token = "0x400E85B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_deckLikeRuntimeCostModifiers;

		// Token: 0x0400E85C RID: 59484
		[Token(Token = "0x400E85C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_deckLikeRuntimeCostModifiers;

		// Token: 0x0400E85D RID: 59485
		[Token(Token = "0x400E85D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_deckMiscModifier;

		// Token: 0x0400E85E RID: 59486
		[Token(Token = "0x400E85E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_deckMiscModifier;

		// Token: 0x0400E85F RID: 59487
		[Token(Token = "0x400E85F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_cards;

		// Token: 0x0400E860 RID: 59488
		[Token(Token = "0x400E860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_cards;

		// Token: 0x0400E861 RID: 59489
		[Token(Token = "0x400E861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_initCostUp;

		// Token: 0x0400E862 RID: 59490
		[Token(Token = "0x400E862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_initCostUp;

		// Token: 0x0400E863 RID: 59491
		[Token(Token = "0x400E863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_initCharacterLimitUp;

		// Token: 0x0400E864 RID: 59492
		[Token(Token = "0x400E864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_initCharacterLimitUp;

		// Token: 0x0400E865 RID: 59493
		[Token(Token = "0x400E865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x0400E866 RID: 59494
		[Token(Token = "0x400E866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_options;

		// Token: 0x0400E867 RID: 59495
		[Token(Token = "0x400E867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_playerSide;

		// Token: 0x0400E868 RID: 59496
		[Token(Token = "0x400E868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_playerSide;

		// Token: 0x0400E869 RID: 59497
		[Token(Token = "0x400E869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400E86A RID: 59498
		[Token(Token = "0x400E86A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__PreprocessOverrideableModifiers;

		// Token: 0x0400E86B RID: 59499
		[Token(Token = "0x400E86B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_PreprocessDeck;

		// Token: 0x0400E86C RID: 59500
		[Token(Token = "0x400E86C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_RechargeToken;

		// Token: 0x0400E86D RID: 59501
		[Token(Token = "0x400E86D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix1_RechargeToken;

		// Token: 0x0400E86E RID: 59502
		[Token(Token = "0x400E86E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_RefreshTokenDeployAndDeckStackCnt;

		// Token: 0x0400E86F RID: 59503
		[Token(Token = "0x400E86F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ForceRechargeToken;

		// Token: 0x0400E870 RID: 59504
		[Token(Token = "0x400E870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix1_ForceRechargeToken;

		// Token: 0x0400E871 RID: 59505
		[Token(Token = "0x400E871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_RecycleCard;

		// Token: 0x0400E872 RID: 59506
		[Token(Token = "0x400E872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_RecycleTokenCard;

		// Token: 0x0400E873 RID: 59507
		[Token(Token = "0x400E873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_TryGetTokenCardIndex;

		// Token: 0x0400E874 RID: 59508
		[Token(Token = "0x400E874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__LoadCardEffectPluginIfNot;

		// Token: 0x0400E875 RID: 59509
		[Token(Token = "0x400E875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_SpawnCharacterOrToken;

		// Token: 0x0400E876 RID: 59510
		[Token(Token = "0x400E876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix1_SpawnCharacterOrToken;

		// Token: 0x0400E877 RID: 59511
		[Token(Token = "0x400E877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_SpawnTokenFreely;

		// Token: 0x0400E878 RID: 59512
		[Token(Token = "0x400E878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix2_SpawnCharacterOrToken;

		// Token: 0x0400E879 RID: 59513
		[Token(Token = "0x400E879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__DealWithOverlapLike;

		// Token: 0x0400E87A RID: 59514
		[Token(Token = "0x400E87A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_ActivateHiddenCard;

		// Token: 0x0400E87B RID: 59515
		[Token(Token = "0x400E87B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix1_ActivateHiddenCard;

		// Token: 0x0400E87C RID: 59516
		[Token(Token = "0x400E87C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_HideCard;

		// Token: 0x0400E87D RID: 59517
		[Token(Token = "0x400E87D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x0400E87E RID: 59518
		[Token(Token = "0x400E87E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_FindCard;

		// Token: 0x0400E87F RID: 59519
		[Token(Token = "0x400E87F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_FindCardById;

		// Token: 0x0400E880 RID: 59520
		[Token(Token = "0x400E880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_FindAllCardById;

		// Token: 0x0400E881 RID: 59521
		[Token(Token = "0x400E881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_FindCardByAlias;

		// Token: 0x0400E882 RID: 59522
		[Token(Token = "0x400E882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__PostProcessDeckModifiers;

		// Token: 0x0400E883 RID: 59523
		[Token(Token = "0x400E883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__PostProcessDeckLikeRuntimeCostModifiers;

		// Token: 0x0400E884 RID: 59524
		[Token(Token = "0x400E884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__PostProcessDeckRuntimeMiscModifiers;

		// Token: 0x0400E885 RID: 59525
		[Token(Token = "0x400E885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__TryGetToken;

		// Token: 0x0400E886 RID: 59526
		[Token(Token = "0x400E886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_OnDeckSorted;

		// Token: 0x0400E887 RID: 59527
		[Token(Token = "0x400E887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_OnCardListChanged;

		// Token: 0x0400E888 RID: 59528
		[Token(Token = "0x400E888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_OnCardCostChanged;

		// Token: 0x0400E889 RID: 59529
		[Token(Token = "0x400E889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_OnCardRecycle;

		// Token: 0x0400E88A RID: 59530
		[Token(Token = "0x400E88A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_OnCardEffectChanged;

		// Token: 0x0400E88B RID: 59531
		[Token(Token = "0x400E88B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_OnCardAppearanceChangedE;

		// Token: 0x0400E88C RID: 59532
		[Token(Token = "0x400E88C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_OnCardDrawn;

		// Token: 0x0400E88D RID: 59533
		[Token(Token = "0x400E88D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_OnPlayCardAnim;

		// Token: 0x0400E88E RID: 59534
		[Token(Token = "0x400E88E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_OnCardSpawn;

		// Token: 0x0400E88F RID: 59535
		[Token(Token = "0x400E88F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_OnCardGetOffHand;

		// Token: 0x0400E890 RID: 59536
		[Token(Token = "0x400E890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_OnCardPutInHand;

		// Token: 0x0400E891 RID: 59537
		[Token(Token = "0x400E891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400E892 RID: 59538
		[Token(Token = "0x400E892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x0400E893 RID: 59539
		[Token(Token = "0x400E893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_AddDeckAura;

		// Token: 0x0400E894 RID: 59540
		[Token(Token = "0x400E894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_RemoveDeckAura;

		// Token: 0x0400E895 RID: 59541
		[Token(Token = "0x400E895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix1_Compare;

		// Token: 0x0400E896 RID: 59542
		[Token(Token = "0x400E896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_TryGetOverrideRawCostData;

		// Token: 0x0400E897 RID: 59543
		[Token(Token = "0x400E897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_AddRawCostOverrider;

		// Token: 0x0400E898 RID: 59544
		[Token(Token = "0x400E898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_IsAttachedFrame;

		// Token: 0x0400E899 RID: 59545
		[Token(Token = "0x400E899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_RemoveRawCostOverriderDataByCardUid;

		// Token: 0x0400E89A RID: 59546
		[Token(Token = "0x400E89A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_ClearRawCost;

		// Token: 0x0400E89B RID: 59547
		[Token(Token = "0x400E89B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_AllowOverrideRawCost;

		// Token: 0x0400E89C RID: 59548
		[Token(Token = "0x400E89C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_get_managedCardBuffController;

		// Token: 0x020021C4 RID: 8644
		[Token(Token = "0x20021C4")]
		public class DeckAruaWrapper : IHotfixable
		{
			// Token: 0x17001A50 RID: 6736
			// (get) Token: 0x0600D7F5 RID: 55285 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A50")]
			public string overrideId
			{
				[Token(Token = "0x600D7F5")]
				[Address(RVA = "0x35CD5B0", Offset = "0x35CC1B0", VA = "0x1835CD5B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001A51 RID: 6737
			// (get) Token: 0x0600D7F6 RID: 55286 RVA: 0x0004E138 File Offset: 0x0004C338
			[Token(Token = "0x17001A51")]
			public int priority
			{
				[Token(Token = "0x600D7F6")]
				[Address(RVA = "0x35CD6C0", Offset = "0x35CC2C0", VA = "0x1835CD6C0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600D7F7 RID: 55287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D7F7")]
			[Address(RVA = "0x35CD530", Offset = "0x35CC130", VA = "0x1835CD530")]
			public DeckAruaWrapper(IDeckAura aura)
			{
			}

			// Token: 0x0400E89D RID: 59549
			[Token(Token = "0x400E89D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IDeckAura deckAura;

			// Token: 0x0400E89E RID: 59550
			[Token(Token = "0x400E89E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isActive;

			// Token: 0x0400E89F RID: 59551
			[Token(Token = "0x400E89F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_overrideId;

			// Token: 0x0400E8A0 RID: 59552
			[Token(Token = "0x400E8A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_priority;

			// Token: 0x0400E8A1 RID: 59553
			[Token(Token = "0x400E8A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020021C5 RID: 8645
		[Token(Token = "0x20021C5")]
		public abstract class Card : IHotfixable
		{
			// Token: 0x17001A52 RID: 6738
			// (get) Token: 0x0600D7F8 RID: 55288 RVA: 0x0004E150 File Offset: 0x0004C350
			// (set) Token: 0x0600D7F9 RID: 55289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A52")]
			public Deck.Card.ComboState comboState
			{
				[Token(Token = "0x600D7F8")]
				[Address(RVA = "0x35C75D0", Offset = "0x35C61D0", VA = "0x1835C75D0")]
				[CompilerGenerated]
				get
				{
					return Deck.Card.ComboState.NONE;
				}
				[Token(Token = "0x600D7F9")]
				[Address(RVA = "0x35C9380", Offset = "0x35C7F80", VA = "0x1835C9380")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001A53 RID: 6739
			// (get) Token: 0x0600D7FA RID: 55290 RVA: 0x0004E168 File Offset: 0x0004C368
			// (set) Token: 0x0600D7FB RID: 55291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A53")]
			public bool comboStateNotChanged
			{
				[Token(Token = "0x600D7FA")]
				[Address(RVA = "0x35C7570", Offset = "0x35C6170", VA = "0x1835C7570")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600D7FB")]
				[Address(RVA = "0x35C9310", Offset = "0x35C7F10", VA = "0x1835C9310")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001A54 RID: 6740
			// (get) Token: 0x0600D7FC RID: 55292 RVA: 0x0004E180 File Offset: 0x0004C380
			// (set) Token: 0x0600D7FD RID: 55293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A54")]
			public Deck.Card.AdvancedCardBuildState advancedBuildState
			{
				[Token(Token = "0x600D7FC")]
				[Address(RVA = "0x35C7260", Offset = "0x35C5E60", VA = "0x1835C7260")]
				[CompilerGenerated]
				get
				{
					return Deck.Card.AdvancedCardBuildState.DEFAULT;
				}
				[Token(Token = "0x600D7FD")]
				[Address(RVA = "0x35C9220", Offset = "0x35C7E20", VA = "0x1835C9220")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001A55 RID: 6741
			// (get) Token: 0x0600D7FE RID: 55294 RVA: 0x0004E198 File Offset: 0x0004C398
			// (set) Token: 0x0600D7FF RID: 55295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A55")]
			public Deck.Card.State state
			{
				[Token(Token = "0x600D7FE")]
				[Address(RVA = "0x35C9150", Offset = "0x35C7D50", VA = "0x1835C9150")]
				[CompilerGenerated]
				get
				{
					return Deck.Card.State.NONE;
				}
				[Token(Token = "0x600D7FF")]
				[Address(RVA = "0x35C9460", Offset = "0x35C8060", VA = "0x1835C9460")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001A56 RID: 6742
			// (get) Token: 0x0600D800 RID: 55296 RVA: 0x0004E1B0 File Offset: 0x0004C3B0
			[Token(Token = "0x17001A56")]
			public uint uniqueId
			{
				[Token(Token = "0x600D800")]
				[Address(RVA = "0x35C91B0", Offset = "0x35C7DB0", VA = "0x1835C91B0")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x17001A57 RID: 6743
			// (get) Token: 0x0600D801 RID: 55297
			[Token(Token = "0x17001A57")]
			public abstract bool isInfinity { [Token(Token = "0x600D801")] get; }

			// Token: 0x17001A58 RID: 6744
			// (get) Token: 0x0600D802 RID: 55298
			[Token(Token = "0x17001A58")]
			public abstract bool isFull { [Token(Token = "0x600D802")] get; }

			// Token: 0x17001A59 RID: 6745
			// (get) Token: 0x0600D803 RID: 55299 RVA: 0x0004E1C8 File Offset: 0x0004C3C8
			[Token(Token = "0x17001A59")]
			public virtual bool ignoreExcludeFromBattle
			{
				[Token(Token = "0x600D803")]
				[Address(RVA = "0x35C7990", Offset = "0x35C6590", VA = "0x1835C7990", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A5A RID: 6746
			// (get) Token: 0x0600D804 RID: 55300 RVA: 0x0004E1E0 File Offset: 0x0004C3E0
			[Token(Token = "0x17001A5A")]
			public virtual bool notShowInDeck
			{
				[Token(Token = "0x600D804")]
				[Address(RVA = "0x35C8440", Offset = "0x35C7040", VA = "0x1835C8440", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A5B RID: 6747
			// (get) Token: 0x0600D805 RID: 55301 RVA: 0x0004E1F8 File Offset: 0x0004C3F8
			[Token(Token = "0x17001A5B")]
			public virtual bool asRewardCardInLegionMode
			{
				[Token(Token = "0x600D805")]
				[Address(RVA = "0x35C72C0", Offset = "0x35C5EC0", VA = "0x1835C72C0", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A5C RID: 6748
			// (get) Token: 0x0600D806 RID: 55302 RVA: 0x0004E210 File Offset: 0x0004C410
			[Token(Token = "0x17001A5C")]
			public int remainingCnt
			{
				[Token(Token = "0x600D806")]
				[Address(RVA = "0x35C8D20", Offset = "0x35C7920", VA = "0x1835C8D20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001A5D RID: 6749
			// (get) Token: 0x0600D807 RID: 55303 RVA: 0x0004E228 File Offset: 0x0004C428
			[Token(Token = "0x17001A5D")]
			public bool isPredefined
			{
				[Token(Token = "0x600D807")]
				[Address(RVA = "0x35C80F0", Offset = "0x35C6CF0", VA = "0x1835C80F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A5E RID: 6750
			// (get) Token: 0x0600D808 RID: 55304 RVA: 0x0004E240 File Offset: 0x0004C440
			// (set) Token: 0x0600D809 RID: 55305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A5E")]
			public bool isSkillRangeToggled
			{
				[Token(Token = "0x600D808")]
				[Address(RVA = "0x35C8370", Offset = "0x35C6F70", VA = "0x1835C8370")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600D809")]
				[Address(RVA = "0x35C93F0", Offset = "0x35C7FF0", VA = "0x1835C93F0")]
				set
				{
				}
			}

			// Token: 0x17001A5F RID: 6751
			// (get) Token: 0x0600D80A RID: 55306 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A5F")]
			public List<UICardEffectHolder.CardEffectPlugin> cardEffectPlugins
			{
				[Token(Token = "0x600D80A")]
				[Address(RVA = "0x35C7510", Offset = "0x35C6110", VA = "0x1835C7510")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001A60 RID: 6752
			// (get) Token: 0x0600D80B RID: 55307 RVA: 0x0004E258 File Offset: 0x0004C458
			[Token(Token = "0x17001A60")]
			public bool respawnValid
			{
				[Token(Token = "0x600D80B")]
				[Address(RVA = "0x35C8FE0", Offset = "0x35C7BE0", VA = "0x1835C8FE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A61 RID: 6753
			// (get) Token: 0x0600D80C RID: 55308 RVA: 0x0004E270 File Offset: 0x0004C470
			[Token(Token = "0x17001A61")]
			public FP respawnProgress
			{
				[Token(Token = "0x600D80C")]
				[Address(RVA = "0x35C8DB0", Offset = "0x35C79B0", VA = "0x1835C8DB0")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x17001A62 RID: 6754
			// (get) Token: 0x0600D80D RID: 55309 RVA: 0x0004E288 File Offset: 0x0004C488
			[Token(Token = "0x17001A62")]
			public FP respawnRemainingTime
			{
				[Token(Token = "0x600D80D")]
				[Address(RVA = "0x35C8EE0", Offset = "0x35C7AE0", VA = "0x1835C8EE0")]
				get
				{
					return default(FP);
				}
			}

			// Token: 0x17001A63 RID: 6755
			// (get) Token: 0x0600D80E RID: 55310 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A63")]
			public BattleCharacterData data
			{
				[Token(Token = "0x600D80E")]
				[Address(RVA = "0x35C7770", Offset = "0x35C6370", VA = "0x1835C7770")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001A64 RID: 6756
			// (get) Token: 0x0600D80F RID: 55311 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A64")]
			public BattleCharacterData dataToShow
			{
				[Token(Token = "0x600D80F")]
				[Address(RVA = "0x35C7700", Offset = "0x35C6300", VA = "0x1835C7700")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001A65 RID: 6757
			// (get) Token: 0x0600D810 RID: 55312 RVA: 0x0004E2A0 File Offset: 0x0004C4A0
			[Token(Token = "0x17001A65")]
			public bool isMockAppearance
			{
				[Token(Token = "0x600D810")]
				[Address(RVA = "0x35C8090", Offset = "0x35C6C90", VA = "0x1835C8090")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A66 RID: 6758
			// (get) Token: 0x0600D811 RID: 55313 RVA: 0x0004E2B8 File Offset: 0x0004C4B8
			[Token(Token = "0x17001A66")]
			public BuildCondition buildCondition
			{
				[Token(Token = "0x600D811")]
				[Address(RVA = "0x35C7380", Offset = "0x35C5F80", VA = "0x1835C7380")]
				get
				{
					return default(BuildCondition);
				}
			}

			// Token: 0x17001A67 RID: 6759
			// (get) Token: 0x0600D812 RID: 55314 RVA: 0x0004E2D0 File Offset: 0x0004C4D0
			[Token(Token = "0x17001A67")]
			public PlayerSide playerSide
			{
				[Token(Token = "0x600D812")]
				[Address(RVA = "0x35C8620", Offset = "0x35C7220", VA = "0x1835C8620")]
				get
				{
					return PlayerSide.DEFAULT;
				}
			}

			// Token: 0x17001A68 RID: 6760
			// (get) Token: 0x0600D813 RID: 55315 RVA: 0x0004E2E8 File Offset: 0x0004C4E8
			[Token(Token = "0x17001A68")]
			public virtual int rawCost
			{
				[Token(Token = "0x600D813")]
				[Address(RVA = "0x35C87D0", Offset = "0x35C73D0", VA = "0x1835C87D0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001A69 RID: 6761
			// (get) Token: 0x0600D814 RID: 55316 RVA: 0x0004E300 File Offset: 0x0004C500
			[Token(Token = "0x17001A69")]
			public int rawCostData
			{
				[Token(Token = "0x600D814")]
				[Address(RVA = "0x35C86C0", Offset = "0x35C72C0", VA = "0x1835C86C0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001A6A RID: 6762
			// (get) Token: 0x0600D815 RID: 55317 RVA: 0x0004E318 File Offset: 0x0004C518
			[Token(Token = "0x17001A6A")]
			public virtual int cost
			{
				[Token(Token = "0x600D815")]
				[Address(RVA = "0x35C7630", Offset = "0x35C6230", VA = "0x1835C7630", Slot = "10")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001A6B RID: 6763
			// (get) Token: 0x0600D816 RID: 55318 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A6B")]
			public string key
			{
				[Token(Token = "0x600D816")]
				[Address(RVA = "0x35C83D0", Offset = "0x35C6FD0", VA = "0x1835C83D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001A6C RID: 6764
			// (get) Token: 0x0600D817 RID: 55319 RVA: 0x0004E330 File Offset: 0x0004C530
			[Token(Token = "0x17001A6C")]
			public EvolvePhase evolvePhase
			{
				[Token(Token = "0x600D817")]
				[Address(RVA = "0x35C7920", Offset = "0x35C6520", VA = "0x1835C7920")]
				get
				{
					return EvolvePhase.PHASE_0;
				}
			}

			// Token: 0x17001A6D RID: 6765
			// (get) Token: 0x0600D818 RID: 55320
			[Token(Token = "0x17001A6D")]
			public abstract Deck.Card.CardPolicy cardPolicy { [Token(Token = "0x600D818")] get; }

			// Token: 0x17001A6E RID: 6766
			// (get) Token: 0x0600D819 RID: 55321 RVA: 0x0004E348 File Offset: 0x0004C548
			[Token(Token = "0x17001A6E")]
			public virtual bool isHidden
			{
				[Token(Token = "0x600D819")]
				[Address(RVA = "0x35C7D60", Offset = "0x35C6960", VA = "0x1835C7D60", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A6F RID: 6767
			// (get) Token: 0x0600D81A RID: 55322 RVA: 0x0004E360 File Offset: 0x0004C560
			[Token(Token = "0x17001A6F")]
			public virtual bool isHiddenExcludeInternal
			{
				[Token(Token = "0x600D81A")]
				[Address(RVA = "0x35C7BF0", Offset = "0x35C67F0", VA = "0x1835C7BF0", Slot = "13")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A70 RID: 6768
			// (get) Token: 0x0600D81B RID: 55323 RVA: 0x0004E378 File Offset: 0x0004C578
			[Token(Token = "0x17001A70")]
			public virtual bool isHiddenByCardState
			{
				[Token(Token = "0x600D81B")]
				[Address(RVA = "0x35C7B20", Offset = "0x35C6720", VA = "0x1835C7B20", Slot = "14")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A71 RID: 6769
			// (get) Token: 0x0600D81C RID: 55324 RVA: 0x0004E390 File Offset: 0x0004C590
			[Token(Token = "0x17001A71")]
			public bool isAvailable
			{
				[Token(Token = "0x600D81C")]
				[Address(RVA = "0x35C79F0", Offset = "0x35C65F0", VA = "0x1835C79F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A72 RID: 6770
			// (get) Token: 0x0600D81D RID: 55325 RVA: 0x0004E3A8 File Offset: 0x0004C5A8
			[Token(Token = "0x17001A72")]
			public virtual bool isShowInCardList
			{
				[Token(Token = "0x600D81D")]
				[Address(RVA = "0x35C8160", Offset = "0x35C6D60", VA = "0x1835C8160", Slot = "15")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A73 RID: 6771
			// (get) Token: 0x0600D81E RID: 55326 RVA: 0x0004E3C0 File Offset: 0x0004C5C0
			[Token(Token = "0x17001A73")]
			public bool isInHand
			{
				[Token(Token = "0x600D81E")]
				[Address(RVA = "0x35C7E80", Offset = "0x35C6A80", VA = "0x1835C7E80")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A74 RID: 6772
			// (get) Token: 0x0600D81F RID: 55327 RVA: 0x0004E3D8 File Offset: 0x0004C5D8
			[Token(Token = "0x17001A74")]
			public bool isShow
			{
				[Token(Token = "0x600D81F")]
				[Address(RVA = "0x35C8220", Offset = "0x35C6E20", VA = "0x1835C8220")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A75 RID: 6773
			// (get) Token: 0x0600D820 RID: 55328 RVA: 0x0004E3F0 File Offset: 0x0004C5F0
			[Token(Token = "0x17001A75")]
			public virtual bool readyToSpawn
			{
				[Token(Token = "0x600D820")]
				[Address(RVA = "0x35C8BE0", Offset = "0x35C77E0", VA = "0x1835C8BE0", Slot = "16")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A76 RID: 6774
			// (get) Token: 0x0600D821 RID: 55329 RVA: 0x0004E408 File Offset: 0x0004C608
			[Token(Token = "0x17001A76")]
			public virtual bool readyToSpawnWithoutCheckCost
			{
				[Token(Token = "0x600D821")]
				[Address(RVA = "0x35C8B20", Offset = "0x35C7720", VA = "0x1835C8B20", Slot = "17")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A77 RID: 6775
			// (get) Token: 0x0600D822 RID: 55330 RVA: 0x0004E420 File Offset: 0x0004C620
			[Token(Token = "0x17001A77")]
			public virtual bool isMaxDeployed
			{
				[Token(Token = "0x600D822")]
				[Address(RVA = "0x35C8030", Offset = "0x35C6C30", VA = "0x1835C8030", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A78 RID: 6776
			// (get) Token: 0x0600D823 RID: 55331 RVA: 0x0004E438 File Offset: 0x0004C638
			[Token(Token = "0x17001A78")]
			public bool occupiedRemainingCharacterCnt
			{
				[Token(Token = "0x600D823")]
				[Address(RVA = "0x35C84A0", Offset = "0x35C70A0", VA = "0x1835C84A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A79 RID: 6777
			// (get) Token: 0x0600D824 RID: 55332 RVA: 0x0004E450 File Offset: 0x0004C650
			[Token(Token = "0x17001A79")]
			public bool dontOccupyDeployCnt
			{
				[Token(Token = "0x600D824")]
				[Address(RVA = "0x35C7860", Offset = "0x35C6460", VA = "0x1835C7860")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A7A RID: 6778
			// (get) Token: 0x0600D825 RID: 55333 RVA: 0x0004E468 File Offset: 0x0004C668
			[Token(Token = "0x17001A7A")]
			public bool dontOccupyMaxDeployCnt
			{
				[Token(Token = "0x600D825")]
				[Address(RVA = "0x35C78C0", Offset = "0x35C64C0", VA = "0x1835C78C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A7B RID: 6779
			// (get) Token: 0x0600D826 RID: 55334 RVA: 0x0004E480 File Offset: 0x0004C680
			[Token(Token = "0x17001A7B")]
			public bool overflowOccupiedCnt
			{
				[Token(Token = "0x600D826")]
				[Address(RVA = "0x35C8510", Offset = "0x35C7110", VA = "0x1835C8510")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A7C RID: 6780
			// (get) Token: 0x0600D827 RID: 55335 RVA: 0x0004E498 File Offset: 0x0004C698
			[Token(Token = "0x17001A7C")]
			public AdditionalBuildCondition additionalBuildCondition
			{
				[Token(Token = "0x600D827")]
				[Address(RVA = "0x35C71E0", Offset = "0x35C5DE0", VA = "0x1835C71E0")]
				get
				{
					return default(AdditionalBuildCondition);
				}
			}

			// Token: 0x17001A7D RID: 6781
			// (get) Token: 0x0600D828 RID: 55336 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D829 RID: 55337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A7D")]
			[HideInInspector]
			public Deck.Card.ObscuredAttributesSnapshot attributes
			{
				[Token(Token = "0x600D828")]
				[Address(RVA = "0x35C7320", Offset = "0x35C5F20", VA = "0x1835C7320")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600D829")]
				[Address(RVA = "0x35C9290", Offset = "0x35C7E90", VA = "0x1835C9290")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001A7E RID: 6782
			// (get) Token: 0x0600D82A RID: 55338 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A7E")]
			public SkillData skill
			{
				[Token(Token = "0x600D82A")]
				[Address(RVA = "0x35C90A0", Offset = "0x35C7CA0", VA = "0x1835C90A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001A7F RID: 6783
			// (get) Token: 0x0600D82B RID: 55339 RVA: 0x0004E4B0 File Offset: 0x0004C6B0
			[Token(Token = "0x17001A7F")]
			public bool isHiddenInternal
			{
				[Token(Token = "0x600D82B")]
				[Address(RVA = "0x35C7CC0", Offset = "0x35C68C0", VA = "0x1835C7CC0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A80 RID: 6784
			// (get) Token: 0x0600D82C RID: 55340 RVA: 0x0004E4C8 File Offset: 0x0004C6C8
			[Token(Token = "0x17001A80")]
			public ValueTuple<List<DeckBuff>, List<Blackboard>> deckBuffOnBorn
			{
				[Token(Token = "0x600D82C")]
				[Address(RVA = "0x35C77D0", Offset = "0x35C63D0", VA = "0x1835C77D0")]
				get
				{
					return default(ValueTuple<List<DeckBuff>, List<Blackboard>>);
				}
			}

			// Token: 0x17001A81 RID: 6785
			// (get) Token: 0x0600D82D RID: 55341
			[Token(Token = "0x17001A81")]
			protected abstract int initialCnt { [Token(Token = "0x600D82D")] get; }

			// Token: 0x0600D82E RID: 55342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D82E")]
			[Address(RVA = "0x35C4BC0", Offset = "0x35C37C0", VA = "0x1835C4BC0")]
			public void UpdateDeckAttributeData(AttributesCalculator.Input input)
			{
			}

			// Token: 0x0600D82F RID: 55343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D82F")]
			[Address(RVA = "0x35C6A90", Offset = "0x35C5690", VA = "0x1835C6A90")]
			public Card(BattleCharacterData data, Deck deck)
			{
			}

			// Token: 0x0600D830 RID: 55344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D830")]
			[Address(RVA = "0x35C21F0", Offset = "0x35C0DF0", VA = "0x1835C21F0", Slot = "20")]
			public virtual void Init(IList<DeckModifier> deckModifiers)
			{
			}

			// Token: 0x0600D831 RID: 55345
			[Token(Token = "0x600D831")]
			public abstract bool TouchPrefab(Action<Character> cb);

			// Token: 0x0600D832 RID: 55346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D832")]
			[Address(RVA = "0x35C40C0", Offset = "0x35C2CC0", VA = "0x1835C40C0")]
			public void SetHidden(bool value, string hiddenKey)
			{
			}

			// Token: 0x0600D833 RID: 55347 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D833")]
			[Address(RVA = "0x35C4170", Offset = "0x35C2D70", VA = "0x1835C4170")]
			public Character SpawnPrefab(SharedConsts.Direction direction, Tile tile, bool spawnManually, Deck.SpawnDetailsTracker spawnDetailsTracker)
			{
				return null;
			}

			// Token: 0x0600D834 RID: 55348
			[Token(Token = "0x600D834")]
			public abstract Character CreateDummy(AdditionalBuildCondition additionalBuildCondition, bool useOutline = false);

			// Token: 0x0600D835 RID: 55349 RVA: 0x0004E4E0 File Offset: 0x0004C6E0
			[Token(Token = "0x600D835")]
			[Address(RVA = "0x35C0390", Offset = "0x35BEF90", VA = "0x1835C0390", Slot = "23")]
			public virtual bool CheckBuildable(Tile tile, bool checkHost, bool spawnManually, bool ignoreAdvancedBuildableMask = false)
			{
				return default(bool);
			}

			// Token: 0x0600D836 RID: 55350 RVA: 0x0004E4F8 File Offset: 0x0004C6F8
			[Token(Token = "0x600D836")]
			[Address(RVA = "0x35C1510", Offset = "0x35C0110", VA = "0x1835C1510")]
			public bool Draw(bool freely, bool forceReduceRemainingCnt = false, bool dontUpdateState = false)
			{
				return default(bool);
			}

			// Token: 0x0600D837 RID: 55351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D837")]
			[Address(RVA = "0x35C3710", Offset = "0x35C2310", VA = "0x1835C3710", Slot = "24")]
			public virtual void Recharge(int cnt, Deck.Card.RechargeTiming timing, bool refreshRemainingCnt = false)
			{
			}

			// Token: 0x0600D838 RID: 55352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D838")]
			[Address(RVA = "0x35C3ED0", Offset = "0x35C2AD0", VA = "0x1835C3ED0")]
			public void ResetRespawnTime(bool waitFirstPeriod = false)
			{
			}

			// Token: 0x0600D839 RID: 55353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D839")]
			[Address(RVA = "0x35C27B0", Offset = "0x35C13B0", VA = "0x1835C27B0", Slot = "25")]
			public virtual void OnRecycle()
			{
			}

			// Token: 0x0600D83A RID: 55354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D83A")]
			[Address(RVA = "0x35C3600", Offset = "0x35C2200", VA = "0x1835C3600")]
			public void ProcessDeckModifier(DeckModifier modifier)
			{
			}

			// Token: 0x0600D83B RID: 55355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D83B")]
			[Address(RVA = "0x35C6110", Offset = "0x35C4D10", VA = "0x1835C6110")]
			private void _UpdateCardBuff()
			{
			}

			// Token: 0x0600D83C RID: 55356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D83C")]
			[Address(RVA = "0x35C00E0", Offset = "0x35BECE0", VA = "0x1835C00E0")]
			public void AddDeckBuff(DeckBuff deckBuff, Blackboard nullableBlackboard)
			{
			}

			// Token: 0x0600D83D RID: 55357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D83D")]
			[Address(RVA = "0x35BFFE0", Offset = "0x35BEBE0", VA = "0x1835BFFE0")]
			public void AddDeckBuffWithKey(DeckBuff deckBuff, Blackboard nullableBlackboard, string buffKey)
			{
			}

			// Token: 0x0600D83E RID: 55358 RVA: 0x0004E510 File Offset: 0x0004C710
			[Token(Token = "0x600D83E")]
			[Address(RVA = "0x35C0AF0", Offset = "0x35BF6F0", VA = "0x1835C0AF0")]
			public bool ContainsDeckBuff(string buffKey)
			{
				return default(bool);
			}

			// Token: 0x0600D83F RID: 55359 RVA: 0x0004E528 File Offset: 0x0004C728
			[Token(Token = "0x600D83F")]
			[Address(RVA = "0x35C2160", Offset = "0x35C0D60", VA = "0x1835C2160")]
			public int GetDeckBuffCountByBuffKey(string buffKey)
			{
				return 0;
			}

			// Token: 0x0600D840 RID: 55360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D840")]
			[Address(RVA = "0x35C1EB0", Offset = "0x35C0AB0", VA = "0x1835C1EB0")]
			public void FinishDeckBuffByKey(string buffKey)
			{
			}

			// Token: 0x0600D841 RID: 55361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D841")]
			[Address(RVA = "0x35C1F40", Offset = "0x35C0B40", VA = "0x1835C1F40")]
			public void FinishDeckBuffsOnSpawned(Deck.Card.AdvancedCardBuildState state)
			{
			}

			// Token: 0x0600D842 RID: 55362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D842")]
			[Address(RVA = "0x35C5120", Offset = "0x35C3D20", VA = "0x1835C5120")]
			private void _OnDeckBuffAdded(Deck.Card.DeckBuffWrapper deckBuff)
			{
			}

			// Token: 0x0600D843 RID: 55363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D843")]
			[Address(RVA = "0x35C69B0", Offset = "0x35C55B0", VA = "0x1835C69B0")]
			private void _UpdateCardEffectType(Deck.Card.CardEffectType effectType, bool isRemove = false)
			{
			}

			// Token: 0x0600D844 RID: 55364 RVA: 0x0004E540 File Offset: 0x0004C740
			[Token(Token = "0x600D844")]
			[Address(RVA = "0x35C0730", Offset = "0x35BF330", VA = "0x1835C0730")]
			public bool CheckEffectType(Deck.Card.CardEffectType effectType)
			{
				return default(bool);
			}

			// Token: 0x0600D845 RID: 55365 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D845")]
			[Address(RVA = "0x35C0DC0", Offset = "0x35BF9C0", VA = "0x1835C0DC0")]
			public Deck.Card.CardBuff CreateCardBuff(string key, Deck.Card.CardBuff.LifeType lifeType, [Optional] string cardAnimOnPlay, params Deck.Card.CardBuffModifier[] modifiers)
			{
				return null;
			}

			// Token: 0x0600D846 RID: 55366 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D846")]
			[Address(RVA = "0x35C0B80", Offset = "0x35BF780", VA = "0x1835C0B80")]
			public Deck.Card.CardBuff CreateCardBuffByBuff(Buff sourceBuff, Deck.Card.CardBuff.LifeType lifeType, string key, string cardAnimOnPlay, params Deck.Card.CardBuffModifier[] modifiers)
			{
				return null;
			}

			// Token: 0x0600D847 RID: 55367 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D847")]
			[Address(RVA = "0x35C0CA0", Offset = "0x35BF8A0", VA = "0x1835C0CA0")]
			public Deck.Card.CardBuff CreateCardBuffByCard(Deck.Card sourceCard, Deck.Card.CardBuff.LifeType lifeType, string key, [Optional] string cardAnimOnPlay, params Deck.Card.CardBuffModifier[] modifiers)
			{
				return null;
			}

			// Token: 0x0600D848 RID: 55368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D848")]
			[Address(RVA = "0x35BFEC0", Offset = "0x35BEAC0", VA = "0x1835BFEC0")]
			public void AddCardBuff(Deck.Card.CardBuff cardBuff)
			{
			}

			// Token: 0x0600D849 RID: 55369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D849")]
			[Address(RVA = "0x35C3CA0", Offset = "0x35C28A0", VA = "0x1835C3CA0")]
			public void RemoveCardBuff(Deck.Card.CardBuff cardBuff)
			{
			}

			// Token: 0x0600D84A RID: 55370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D84A")]
			[Address(RVA = "0x35C3A60", Offset = "0x35C2660", VA = "0x1835C3A60")]
			public void RemoveCardBuffByKey(string key)
			{
			}

			// Token: 0x0600D84B RID: 55371 RVA: 0x0004E558 File Offset: 0x0004C758
			[Token(Token = "0x600D84B")]
			[Address(RVA = "0x35C0970", Offset = "0x35BF570", VA = "0x1835C0970")]
			public bool ContainsCardBuff(string key)
			{
				return default(bool);
			}

			// Token: 0x0600D84C RID: 55372 RVA: 0x0004E570 File Offset: 0x0004C770
			[Token(Token = "0x600D84C")]
			[Address(RVA = "0x35C07C0", Offset = "0x35BF3C0", VA = "0x1835C07C0")]
			public bool ContainsCardBuffFromSpecificSource(string key, uint sourceUid)
			{
				return default(bool);
			}

			// Token: 0x0600D84D RID: 55373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D84D")]
			[Address(RVA = "0x35C1A00", Offset = "0x35C0600", VA = "0x1835C1A00")]
			public void FinishCardBuffByOwner(Buff owner)
			{
			}

			// Token: 0x0600D84E RID: 55374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D84E")]
			[Address(RVA = "0x35C18A0", Offset = "0x35C04A0", VA = "0x1835C18A0")]
			public void FinishCardBuffByKey(string key)
			{
			}

			// Token: 0x0600D84F RID: 55375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D84F")]
			[Address(RVA = "0x35C16E0", Offset = "0x35C02E0", VA = "0x1835C16E0")]
			public void FinishCardBuffByCard(Deck.Card sourceCard)
			{
			}

			// Token: 0x0600D850 RID: 55376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D850")]
			[Address(RVA = "0x35C1B50", Offset = "0x35C0750", VA = "0x1835C1B50")]
			public void FinishCardBuffsOnSpawned()
			{
			}

			// Token: 0x0600D851 RID: 55377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D851")]
			[Address(RVA = "0x35C2CE0", Offset = "0x35C18E0", VA = "0x1835C2CE0", Slot = "26")]
			protected virtual void OnSpawned(Character inst, SharedConsts.Direction direction, GridPosition gridPos, bool spawnManually)
			{
			}

			// Token: 0x0600D852 RID: 55378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D852")]
			[Address(RVA = "0x35C2BA0", Offset = "0x35C17A0", VA = "0x1835C2BA0")]
			protected void OnSpawnOperationSucceed(Character inst, SharedConsts.Direction direction, GridPosition gridPos, bool spawnManually)
			{
			}

			// Token: 0x0600D853 RID: 55379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D853")]
			[Address(RVA = "0x35C2670", Offset = "0x35C1270", VA = "0x1835C2670")]
			public void OnCardPutInHand()
			{
			}

			// Token: 0x0600D854 RID: 55380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D854")]
			[Address(RVA = "0x35C2600", Offset = "0x35C1200", VA = "0x1835C2600")]
			public void OnCardGetOffHand()
			{
			}

			// Token: 0x0600D855 RID: 55381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D855")]
			[Address(RVA = "0x35C5050", Offset = "0x35C3C50", VA = "0x1835C5050")]
			private void _ApplyAttributeModifier(Attributes.IAttributesModifier modifier, bool isApply)
			{
			}

			// Token: 0x0600D856 RID: 55382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D856")]
			[Address(RVA = "0x35C4E90", Offset = "0x35C3A90", VA = "0x1835C4E90")]
			private void _AffectDeckBuff(Deck.Card.DeckBuffWrapper deckBuff)
			{
			}

			// Token: 0x0600D857 RID: 55383 RVA: 0x0004E588 File Offset: 0x0004C788
			[Token(Token = "0x600D857")]
			[Address(RVA = "0x35C1FD0", Offset = "0x35C0BD0", VA = "0x1835C1FD0")]
			public int GetCardBuffStackCount(string stackKey)
			{
				return 0;
			}

			// Token: 0x0600D858 RID: 55384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D858")]
			[Address(RVA = "0x35C24C0", Offset = "0x35C10C0", VA = "0x1835C24C0")]
			public void MockAppearance(BattleCharacterData dataToShow)
			{
			}

			// Token: 0x0600D859 RID: 55385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D859")]
			[Address(RVA = "0x35C2560", Offset = "0x35C1160", VA = "0x1835C2560")]
			public void ModifyRespawnParameters(int respawnCostMultCnt, FP respawnCostMultiplier, FP respawnCostMaxMultiplier)
			{
			}

			// Token: 0x0600D85A RID: 55386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D85A")]
			[Address(RVA = "0x35C26E0", Offset = "0x35C12E0", VA = "0x1835C26E0", Slot = "27")]
			protected virtual void OnFetchDataFromPrefab(Character character)
			{
			}

			// Token: 0x0600D85B RID: 55387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D85B")]
			[Address(RVA = "0x35C0310", Offset = "0x35BEF10", VA = "0x1835C0310")]
			public void ChangeStateManually(Deck.Card.State newState)
			{
			}

			// Token: 0x0600D85C RID: 55388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D85C")]
			[Address(RVA = "0x35C01D0", Offset = "0x35BEDD0", VA = "0x1835C01D0")]
			public void BindCardBuffWithEffectPlugin(Deck.Card.CardBuff cardBuff, string pluginName)
			{
			}

			// Token: 0x0600D85D RID: 55389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D85D")]
			[Address(RVA = "0x35BFC70", Offset = "0x35BE870", VA = "0x1835BFC70")]
			public RectTransform AddCardBuffEffectPluginIfNot(string pluginName)
			{
				return null;
			}

			// Token: 0x0600D85E RID: 55390 RVA: 0x0004E5A0 File Offset: 0x0004C7A0
			[Token(Token = "0x600D85E")]
			[Address(RVA = "0x35C3B80", Offset = "0x35C2780", VA = "0x1835C3B80")]
			public bool RemoveCardBuffEffectPlugin(string pluginName)
			{
				return default(bool);
			}

			// Token: 0x0600D85F RID: 55391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D85F")]
			[Address(RVA = "0x35C3830", Offset = "0x35C2430", VA = "0x1835C3830")]
			public void RefreshEffectPluginParent(Transform parent)
			{
			}

			// Token: 0x0600D860 RID: 55392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D860")]
			[Address(RVA = "0x35C2F30", Offset = "0x35C1B30", VA = "0x1835C2F30")]
			public void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600D861 RID: 55393
			[Token(Token = "0x600D861")]
			protected abstract Character SpawnInternal(SharedConsts.Direction direction, Tile tile, bool spawnManually, Deck.SpawnDetailsTracker spawnDetailsTracker);

			// Token: 0x0600D862 RID: 55394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D862")]
			[Address(RVA = "0x35C0EC0", Offset = "0x35BFAC0", VA = "0x1835C0EC0")]
			protected void DealDummyTalent(BasicTalent talent, IList<DeckModifier> deckModifiers, IList<Deck.Card.RuntimeCostModifier> runtimeCostModifiers, IList<Deck.Card.MiscSettingModifier> miscModifier)
			{
			}

			// Token: 0x0600D863 RID: 55395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D863")]
			[Address(RVA = "0x35C5CC0", Offset = "0x35C48C0", VA = "0x1835C5CC0")]
			private void _PreprocessRunes(Character character)
			{
			}

			// Token: 0x0600D864 RID: 55396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D864")]
			[Address(RVA = "0x35C5550", Offset = "0x35C4150", VA = "0x1835C5550")]
			private void _PreprocessCharCost(IList<DeckModifier> deckModifiers)
			{
			}

			// Token: 0x0600D865 RID: 55397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D865")]
			[Address(RVA = "0x35C57B0", Offset = "0x35C43B0", VA = "0x1835C57B0")]
			private void _PreprocessDeckBuffs(Character character, IList<DeckModifier> deckModifiers)
			{
			}

			// Token: 0x0600D866 RID: 55398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D866")]
			[Address(RVA = "0x35C5260", Offset = "0x35C3E60", VA = "0x1835C5260")]
			private static void _PostCheckCntBalanced(Character character, List<DeckBuff> deckBuffList, List<Blackboard> blackboardList)
			{
			}

			// Token: 0x0600D867 RID: 55399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D867")]
			[Address(RVA = "0x35C4050", Offset = "0x35C2C50", VA = "0x1835C4050")]
			public void SetExcludeFromBattle(bool isExcluded)
			{
			}

			// Token: 0x0600D868 RID: 55400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D868")]
			[Address(RVA = "0x35C2A40", Offset = "0x35C1640", VA = "0x1835C2A40", Slot = "29")]
			public virtual void OnReset()
			{
			}

			// Token: 0x0600D869 RID: 55401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D869")]
			[Address(RVA = "0x35C5E00", Offset = "0x35C4A00", VA = "0x1835C5E00")]
			private void _ResetData()
			{
			}

			// Token: 0x0400E8A2 RID: 59554
			[Token(Token = "0x400E8A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			protected Deck m_deck;

			// Token: 0x0400E8A3 RID: 59555
			[Token(Token = "0x400E8A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			protected int m_remainingCnt;

			// Token: 0x0400E8A4 RID: 59556
			[Token(Token = "0x400E8A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private BattleCharacterData m_data;

			// Token: 0x0400E8A5 RID: 59557
			[Token(Token = "0x400E8A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			protected BattleCharacterData m_dataToShow;

			// Token: 0x0400E8A6 RID: 59558
			[Token(Token = "0x400E8A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private PeriodicTimer m_respawnTimer;

			// Token: 0x0400E8A7 RID: 59559
			[Token(Token = "0x400E8A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool m_fallbackHiddenInternal;

			// Token: 0x0400E8A8 RID: 59560
			[Token(Token = "0x400E8A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private EnableStateWithKey m_hiddenBy;

			// Token: 0x0400E8A9 RID: 59561
			[Token(Token = "0x400E8A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			protected bool m_originOccupiedRemainingCharacterCnt;

			// Token: 0x0400E8AA RID: 59562
			[Token(Token = "0x400E8AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private BuildCondition m_originBuildableCondition;

			// Token: 0x0400E8AB RID: 59563
			[Token(Token = "0x400E8AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			protected bool m_dontOccupyDeployCnt;

			// Token: 0x0400E8AC RID: 59564
			[Token(Token = "0x400E8AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
			protected bool m_dontOccupyMaxDeployCnt;

			// Token: 0x0400E8AD RID: 59565
			[Token(Token = "0x400E8AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			protected AdditionalBuildCondition m_additionalBuildCondition;

			// Token: 0x0400E8AE RID: 59566
			[Token(Token = "0x400E8AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			protected BuildCondition m_buildCondition;

			// Token: 0x0400E8AF RID: 59567
			[Token(Token = "0x400E8AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private bool m_isSkillRangeToggled;

			// Token: 0x0400E8B0 RID: 59568
			[Token(Token = "0x400E8B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
			private bool m_isExcludedFromBattle;

			// Token: 0x0400E8B1 RID: 59569
			[Token(Token = "0x400E8B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			protected Deck.Card.DeckBuffContainer m_deckBuffContainer;

			// Token: 0x0400E8B2 RID: 59570
			[Token(Token = "0x400E8B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			protected List<Deck.Card.CardBuff> m_cardBuffs;

			// Token: 0x0400E8B3 RID: 59571
			[Token(Token = "0x400E8B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			protected List<Deck.Card.CardBuff> m_timeLimitedCardBuffs;

			// Token: 0x0400E8B4 RID: 59572
			[Token(Token = "0x400E8B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private short[] m_cardEffectTypeCounter;

			// Token: 0x0400E8B5 RID: 59573
			[Token(Token = "0x400E8B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private int m_respawnCostMultCnt;

			// Token: 0x0400E8B6 RID: 59574
			[Token(Token = "0x400E8B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			private bool m_addRespawnCostMultCnt;

			// Token: 0x0400E8B7 RID: 59575
			[Token(Token = "0x400E8B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private FP m_respawnCostMaxMultiplier;

			// Token: 0x0400E8B8 RID: 59576
			[Token(Token = "0x400E8B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private FP m_respawnCostMultiplier;

			// Token: 0x0400E8B9 RID: 59577
			[Token(Token = "0x400E8B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			protected int m_queuedRespawnCnt;

			// Token: 0x0400E8BA RID: 59578
			[Token(Token = "0x400E8BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			protected ListSet<Deck.Card.RuntimeCostModifier> m_runtimeCostModifiers;

			// Token: 0x0400E8BB RID: 59579
			[Token(Token = "0x400E8BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			protected ListSet<Deck.Card.RuntimeRespawnTimeModifier> m_runtimeRespawnTimeModifiers;

			// Token: 0x0400E8BC RID: 59580
			[Token(Token = "0x400E8BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			protected List<ICardModifier> m_cardModifiers;

			// Token: 0x0400E8BD RID: 59581
			[Token(Token = "0x400E8BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			protected List<UICardEffectHolder.CardEffectPlugin> m_cardEffectPlugins;

			// Token: 0x0400E8BE RID: 59582
			[Token(Token = "0x400E8BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			protected Dictionary<Deck.Card.CardBuff, string> m_cardEffectPluginsInCardBuff;

			// Token: 0x0400E8BF RID: 59583
			[Token(Token = "0x400E8BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			protected Dictionary<string, RectTransform> m_runTimeCardEffectPlugins;

			// Token: 0x0400E8C0 RID: 59584
			[Token(Token = "0x400E8C0")]
			private const int CARD_EFFECT_NUM = 13;

			// Token: 0x0400E8C5 RID: 59589
			[Token(Token = "0x400E8C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			protected int m_costDelta;

			// Token: 0x0400E8C6 RID: 59590
			[Token(Token = "0x400E8C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			protected FP m_rawCostScale;

			// Token: 0x0400E8C7 RID: 59591
			[Token(Token = "0x400E8C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			private FP m_newRespawnTimePeriod;

			// Token: 0x0400E8C8 RID: 59592
			[Token(Token = "0x400E8C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private bool m_notValidToBuildByCardBuff;

			// Token: 0x0400E8C9 RID: 59593
			[Token(Token = "0x400E8C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A9")]
			private bool m_respawnDisabled;

			// Token: 0x0400E8CA RID: 59594
			[Token(Token = "0x400E8CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AA")]
			private bool m_respawnTimerStopped;

			// Token: 0x0400E8CB RID: 59595
			[Token(Token = "0x400E8CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AB")]
			public bool ignoreRespawningState;

			// Token: 0x0400E8CD RID: 59597
			[Token(Token = "0x400E8CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_comboState;

			// Token: 0x0400E8CE RID: 59598
			[Token(Token = "0x400E8CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_comboState;

			// Token: 0x0400E8CF RID: 59599
			[Token(Token = "0x400E8CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_comboStateNotChanged;

			// Token: 0x0400E8D0 RID: 59600
			[Token(Token = "0x400E8D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_comboStateNotChanged;

			// Token: 0x0400E8D1 RID: 59601
			[Token(Token = "0x400E8D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_advancedBuildState;

			// Token: 0x0400E8D2 RID: 59602
			[Token(Token = "0x400E8D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_advancedBuildState;

			// Token: 0x0400E8D3 RID: 59603
			[Token(Token = "0x400E8D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_state;

			// Token: 0x0400E8D4 RID: 59604
			[Token(Token = "0x400E8D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_state;

			// Token: 0x0400E8D5 RID: 59605
			[Token(Token = "0x400E8D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_uniqueId;

			// Token: 0x0400E8D6 RID: 59606
			[Token(Token = "0x400E8D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_ignoreExcludeFromBattle;

			// Token: 0x0400E8D7 RID: 59607
			[Token(Token = "0x400E8D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_notShowInDeck;

			// Token: 0x0400E8D8 RID: 59608
			[Token(Token = "0x400E8D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_asRewardCardInLegionMode;

			// Token: 0x0400E8D9 RID: 59609
			[Token(Token = "0x400E8D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_remainingCnt;

			// Token: 0x0400E8DA RID: 59610
			[Token(Token = "0x400E8DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_isPredefined;

			// Token: 0x0400E8DB RID: 59611
			[Token(Token = "0x400E8DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_isSkillRangeToggled;

			// Token: 0x0400E8DC RID: 59612
			[Token(Token = "0x400E8DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_set_isSkillRangeToggled;

			// Token: 0x0400E8DD RID: 59613
			[Token(Token = "0x400E8DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_cardEffectPlugins;

			// Token: 0x0400E8DE RID: 59614
			[Token(Token = "0x400E8DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_respawnValid;

			// Token: 0x0400E8DF RID: 59615
			[Token(Token = "0x400E8DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_get_respawnProgress;

			// Token: 0x0400E8E0 RID: 59616
			[Token(Token = "0x400E8E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_get_respawnRemainingTime;

			// Token: 0x0400E8E1 RID: 59617
			[Token(Token = "0x400E8E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_get_data;

			// Token: 0x0400E8E2 RID: 59618
			[Token(Token = "0x400E8E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_get_dataToShow;

			// Token: 0x0400E8E3 RID: 59619
			[Token(Token = "0x400E8E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_get_isMockAppearance;

			// Token: 0x0400E8E4 RID: 59620
			[Token(Token = "0x400E8E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_get_buildCondition;

			// Token: 0x0400E8E5 RID: 59621
			[Token(Token = "0x400E8E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_get_playerSide;

			// Token: 0x0400E8E6 RID: 59622
			[Token(Token = "0x400E8E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_get_rawCost;

			// Token: 0x0400E8E7 RID: 59623
			[Token(Token = "0x400E8E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_get_rawCostData;

			// Token: 0x0400E8E8 RID: 59624
			[Token(Token = "0x400E8E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_get_cost;

			// Token: 0x0400E8E9 RID: 59625
			[Token(Token = "0x400E8E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_get_key;

			// Token: 0x0400E8EA RID: 59626
			[Token(Token = "0x400E8EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_get_evolvePhase;

			// Token: 0x0400E8EB RID: 59627
			[Token(Token = "0x400E8EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_get_isHidden;

			// Token: 0x0400E8EC RID: 59628
			[Token(Token = "0x400E8EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_get_isHiddenExcludeInternal;

			// Token: 0x0400E8ED RID: 59629
			[Token(Token = "0x400E8ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_get_isHiddenByCardState;

			// Token: 0x0400E8EE RID: 59630
			[Token(Token = "0x400E8EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_get_isAvailable;

			// Token: 0x0400E8EF RID: 59631
			[Token(Token = "0x400E8EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0_get_isShowInCardList;

			// Token: 0x0400E8F0 RID: 59632
			[Token(Token = "0x400E8F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_get_isInHand;

			// Token: 0x0400E8F1 RID: 59633
			[Token(Token = "0x400E8F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0400E8F2 RID: 59634
			[Token(Token = "0x400E8F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_get_readyToSpawn;

			// Token: 0x0400E8F3 RID: 59635
			[Token(Token = "0x400E8F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0_get_readyToSpawnWithoutCheckCost;

			// Token: 0x0400E8F4 RID: 59636
			[Token(Token = "0x400E8F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0_get_isMaxDeployed;

			// Token: 0x0400E8F5 RID: 59637
			[Token(Token = "0x400E8F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0_get_occupiedRemainingCharacterCnt;

			// Token: 0x0400E8F6 RID: 59638
			[Token(Token = "0x400E8F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0_get_dontOccupyDeployCnt;

			// Token: 0x0400E8F7 RID: 59639
			[Token(Token = "0x400E8F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0_get_dontOccupyMaxDeployCnt;

			// Token: 0x0400E8F8 RID: 59640
			[Token(Token = "0x400E8F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0_get_overflowOccupiedCnt;

			// Token: 0x0400E8F9 RID: 59641
			[Token(Token = "0x400E8F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0_get_additionalBuildCondition;

			// Token: 0x0400E8FA RID: 59642
			[Token(Token = "0x400E8FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0_get_attributes;

			// Token: 0x0400E8FB RID: 59643
			[Token(Token = "0x400E8FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private static DelegateBridge __Hotfix0_set_attributes;

			// Token: 0x0400E8FC RID: 59644
			[Token(Token = "0x400E8FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private static DelegateBridge __Hotfix0_get_skill;

			// Token: 0x0400E8FD RID: 59645
			[Token(Token = "0x400E8FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private static DelegateBridge __Hotfix0_get_isHiddenInternal;

			// Token: 0x0400E8FE RID: 59646
			[Token(Token = "0x400E8FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private static DelegateBridge __Hotfix0_get_deckBuffOnBorn;

			// Token: 0x0400E8FF RID: 59647
			[Token(Token = "0x400E8FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			private static DelegateBridge __Hotfix0_UpdateDeckAttributeData;

			// Token: 0x0400E900 RID: 59648
			[Token(Token = "0x400E900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400E901 RID: 59649
			[Token(Token = "0x400E901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400E902 RID: 59650
			[Token(Token = "0x400E902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private static DelegateBridge __Hotfix0_SetHidden;

			// Token: 0x0400E903 RID: 59651
			[Token(Token = "0x400E903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			private static DelegateBridge __Hotfix0_SpawnPrefab;

			// Token: 0x0400E904 RID: 59652
			[Token(Token = "0x400E904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private static DelegateBridge __Hotfix0_CheckBuildable;

			// Token: 0x0400E905 RID: 59653
			[Token(Token = "0x400E905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private static DelegateBridge __Hotfix0_Draw;

			// Token: 0x0400E906 RID: 59654
			[Token(Token = "0x400E906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private static DelegateBridge __Hotfix0_Recharge;

			// Token: 0x0400E907 RID: 59655
			[Token(Token = "0x400E907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private static DelegateBridge __Hotfix0_ResetRespawnTime;

			// Token: 0x0400E908 RID: 59656
			[Token(Token = "0x400E908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private static DelegateBridge __Hotfix0_OnRecycle;

			// Token: 0x0400E909 RID: 59657
			[Token(Token = "0x400E909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private static DelegateBridge __Hotfix0_ProcessDeckModifier;

			// Token: 0x0400E90A RID: 59658
			[Token(Token = "0x400E90A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private static DelegateBridge __Hotfix0__UpdateCardBuff;

			// Token: 0x0400E90B RID: 59659
			[Token(Token = "0x400E90B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private static DelegateBridge __Hotfix0_AddDeckBuff;

			// Token: 0x0400E90C RID: 59660
			[Token(Token = "0x400E90C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private static DelegateBridge __Hotfix0_AddDeckBuffWithKey;

			// Token: 0x0400E90D RID: 59661
			[Token(Token = "0x400E90D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private static DelegateBridge __Hotfix0_ContainsDeckBuff;

			// Token: 0x0400E90E RID: 59662
			[Token(Token = "0x400E90E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private static DelegateBridge __Hotfix0_GetDeckBuffCountByBuffKey;

			// Token: 0x0400E90F RID: 59663
			[Token(Token = "0x400E90F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private static DelegateBridge __Hotfix0_FinishDeckBuffByKey;

			// Token: 0x0400E910 RID: 59664
			[Token(Token = "0x400E910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private static DelegateBridge __Hotfix0_FinishDeckBuffsOnSpawned;

			// Token: 0x0400E911 RID: 59665
			[Token(Token = "0x400E911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private static DelegateBridge __Hotfix0__OnDeckBuffAdded;

			// Token: 0x0400E912 RID: 59666
			[Token(Token = "0x400E912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
			private static DelegateBridge __Hotfix0__UpdateCardEffectType;

			// Token: 0x0400E913 RID: 59667
			[Token(Token = "0x400E913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
			private static DelegateBridge __Hotfix0_CheckEffectType;

			// Token: 0x0400E914 RID: 59668
			[Token(Token = "0x400E914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
			private static DelegateBridge __Hotfix0_CreateCardBuff;

			// Token: 0x0400E915 RID: 59669
			[Token(Token = "0x400E915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
			private static DelegateBridge __Hotfix0_CreateCardBuffByBuff;

			// Token: 0x0400E916 RID: 59670
			[Token(Token = "0x400E916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
			private static DelegateBridge __Hotfix0_CreateCardBuffByCard;

			// Token: 0x0400E917 RID: 59671
			[Token(Token = "0x400E917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
			private static DelegateBridge __Hotfix0_AddCardBuff;

			// Token: 0x0400E918 RID: 59672
			[Token(Token = "0x400E918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
			private static DelegateBridge __Hotfix0_RemoveCardBuff;

			// Token: 0x0400E919 RID: 59673
			[Token(Token = "0x400E919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
			private static DelegateBridge __Hotfix0_RemoveCardBuffByKey;

			// Token: 0x0400E91A RID: 59674
			[Token(Token = "0x400E91A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
			private static DelegateBridge __Hotfix0_ContainsCardBuff;

			// Token: 0x0400E91B RID: 59675
			[Token(Token = "0x400E91B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
			private static DelegateBridge __Hotfix0_ContainsCardBuffFromSpecificSource;

			// Token: 0x0400E91C RID: 59676
			[Token(Token = "0x400E91C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
			private static DelegateBridge __Hotfix0_FinishCardBuffByOwner;

			// Token: 0x0400E91D RID: 59677
			[Token(Token = "0x400E91D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
			private static DelegateBridge __Hotfix0_FinishCardBuffByKey;

			// Token: 0x0400E91E RID: 59678
			[Token(Token = "0x400E91E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
			private static DelegateBridge __Hotfix0_FinishCardBuffByCard;

			// Token: 0x0400E91F RID: 59679
			[Token(Token = "0x400E91F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
			private static DelegateBridge __Hotfix0_FinishCardBuffsOnSpawned;

			// Token: 0x0400E920 RID: 59680
			[Token(Token = "0x400E920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
			private static DelegateBridge __Hotfix0_OnSpawned;

			// Token: 0x0400E921 RID: 59681
			[Token(Token = "0x400E921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
			private static DelegateBridge __Hotfix0_OnSpawnOperationSucceed;

			// Token: 0x0400E922 RID: 59682
			[Token(Token = "0x400E922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
			private static DelegateBridge __Hotfix0_OnCardPutInHand;

			// Token: 0x0400E923 RID: 59683
			[Token(Token = "0x400E923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
			private static DelegateBridge __Hotfix0_OnCardGetOffHand;

			// Token: 0x0400E924 RID: 59684
			[Token(Token = "0x400E924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
			private static DelegateBridge __Hotfix0__ApplyAttributeModifier;

			// Token: 0x0400E925 RID: 59685
			[Token(Token = "0x400E925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
			private static DelegateBridge __Hotfix0__AffectDeckBuff;

			// Token: 0x0400E926 RID: 59686
			[Token(Token = "0x400E926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
			private static DelegateBridge __Hotfix0_GetCardBuffStackCount;

			// Token: 0x0400E927 RID: 59687
			[Token(Token = "0x400E927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
			private static DelegateBridge __Hotfix0_MockAppearance;

			// Token: 0x0400E928 RID: 59688
			[Token(Token = "0x400E928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
			private static DelegateBridge __Hotfix0_ModifyRespawnParameters;

			// Token: 0x0400E929 RID: 59689
			[Token(Token = "0x400E929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
			private static DelegateBridge __Hotfix0_OnFetchDataFromPrefab;

			// Token: 0x0400E92A RID: 59690
			[Token(Token = "0x400E92A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
			private static DelegateBridge __Hotfix0_ChangeStateManually;

			// Token: 0x0400E92B RID: 59691
			[Token(Token = "0x400E92B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
			private static DelegateBridge __Hotfix0_BindCardBuffWithEffectPlugin;

			// Token: 0x0400E92C RID: 59692
			[Token(Token = "0x400E92C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
			private static DelegateBridge __Hotfix0_AddCardBuffEffectPluginIfNot;

			// Token: 0x0400E92D RID: 59693
			[Token(Token = "0x400E92D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
			private static DelegateBridge __Hotfix0_RemoveCardBuffEffectPlugin;

			// Token: 0x0400E92E RID: 59694
			[Token(Token = "0x400E92E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
			private static DelegateBridge __Hotfix0_RefreshEffectPluginParent;

			// Token: 0x0400E92F RID: 59695
			[Token(Token = "0x400E92F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x0400E930 RID: 59696
			[Token(Token = "0x400E930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
			private static DelegateBridge __Hotfix0_DealDummyTalent;

			// Token: 0x0400E931 RID: 59697
			[Token(Token = "0x400E931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
			private static DelegateBridge __Hotfix0__PreprocessRunes;

			// Token: 0x0400E932 RID: 59698
			[Token(Token = "0x400E932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
			private static DelegateBridge __Hotfix0__PreprocessCharCost;

			// Token: 0x0400E933 RID: 59699
			[Token(Token = "0x400E933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
			private static DelegateBridge __Hotfix0__PreprocessDeckBuffs;

			// Token: 0x0400E934 RID: 59700
			[Token(Token = "0x400E934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
			private static DelegateBridge __Hotfix0__PostCheckCntBalanced;

			// Token: 0x0400E935 RID: 59701
			[Token(Token = "0x400E935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
			private static DelegateBridge __Hotfix0_SetExcludeFromBattle;

			// Token: 0x0400E936 RID: 59702
			[Token(Token = "0x400E936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
			private static DelegateBridge __Hotfix0_OnReset;

			// Token: 0x0400E937 RID: 59703
			[Token(Token = "0x400E937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
			private static DelegateBridge __Hotfix0__ResetData;

			// Token: 0x020021C6 RID: 8646
			[Token(Token = "0x20021C6")]
			public class DeckBuffContainer : IHotfixable
			{
				// Token: 0x17001A82 RID: 6786
				// (get) Token: 0x0600D86B RID: 55403 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17001A82")]
				private ObjectPool<Deck.Card.DeckBuffWrapper> pool
				{
					[Token(Token = "0x600D86B")]
					[Address(RVA = "0x35DE640", Offset = "0x35DD240", VA = "0x1835DE640")]
					get
					{
						return null;
					}
				}

				// Token: 0x0600D86C RID: 55404 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D86C")]
				[Address(RVA = "0x35DD260", Offset = "0x35DBE60", VA = "0x1835DD260")]
				public void Init(Deck.Card card)
				{
				}

				// Token: 0x0600D86D RID: 55405 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D86D")]
				[Address(RVA = "0x35DD810", Offset = "0x35DC410", VA = "0x1835DD810")]
				public void Reset()
				{
				}

				// Token: 0x0600D86E RID: 55406 RVA: 0x0004E5B8 File Offset: 0x0004C7B8
				[Token(Token = "0x600D86E")]
				[Address(RVA = "0x35DCF70", Offset = "0x35DBB70", VA = "0x1835DCF70")]
				public ValueTuple<List<DeckBuff>, List<Blackboard>> GetDeckBuffDatasOnBorn()
				{
					return default(ValueTuple<List<DeckBuff>, List<Blackboard>>);
				}

				// Token: 0x0600D86F RID: 55407 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D86F")]
				[Address(RVA = "0x35DC2F0", Offset = "0x35DAEF0", VA = "0x1835DC2F0")]
				public void AddRange(IList<DeckBuff> deckBuffList, IList<Blackboard> blackboardList)
				{
				}

				// Token: 0x0600D870 RID: 55408 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D870")]
				[Address(RVA = "0x35DC160", Offset = "0x35DAD60", VA = "0x1835DC160")]
				public void AddDeckBuff(DeckBuff deckBuff, Blackboard blackboard)
				{
				}

				// Token: 0x0600D871 RID: 55409 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D871")]
				[Address(RVA = "0x35DBFC0", Offset = "0x35DABC0", VA = "0x1835DBFC0")]
				public void AddDeckBuffWithKey(DeckBuff deckBuff, Blackboard blackboard, string overrideBuffKey)
				{
				}

				// Token: 0x0600D872 RID: 55410 RVA: 0x0004E5D0 File Offset: 0x0004C7D0
				[Token(Token = "0x600D872")]
				[Address(RVA = "0x35DCC40", Offset = "0x35DB840", VA = "0x1835DCC40")]
				public int GetDeckBuffCountByBuffKey(string buffKey)
				{
					return 0;
				}

				// Token: 0x0600D873 RID: 55411 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D873")]
				[Address(RVA = "0x35DC950", Offset = "0x35DB550", VA = "0x1835DC950")]
				public void FinishDeckBuffByKey(string key)
				{
				}

				// Token: 0x0600D874 RID: 55412 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D874")]
				[Address(RVA = "0x35DCB10", Offset = "0x35DB710", VA = "0x1835DCB10")]
				public void FinishDeckBuffsOnSpawned(Deck.Card.AdvancedCardBuildState state)
				{
				}

				// Token: 0x0600D875 RID: 55413 RVA: 0x0004E5E8 File Offset: 0x0004C7E8
				[Token(Token = "0x600D875")]
				[Address(RVA = "0x35DC7A0", Offset = "0x35DB3A0", VA = "0x1835DC7A0")]
				public bool ContainsDeckBuff(string key)
				{
					return default(bool);
				}

				// Token: 0x0600D876 RID: 55414 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D876")]
				[Address(RVA = "0x35DD6F0", Offset = "0x35DC2F0", VA = "0x1835DD6F0")]
				public void PreprocessDeckBuffsCardEffectType()
				{
				}

				// Token: 0x0600D877 RID: 55415 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D877")]
				[Address(RVA = "0x35DD4F0", Offset = "0x35DC0F0", VA = "0x1835DD4F0")]
				public void OnCardPutInHand()
				{
				}

				// Token: 0x0600D878 RID: 55416 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D878")]
				[Address(RVA = "0x35DD2F0", Offset = "0x35DBEF0", VA = "0x1835DD2F0")]
				public void OnCardGetOffHand()
				{
				}

				// Token: 0x0600D879 RID: 55417 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D879")]
				[Address(RVA = "0x35DE370", Offset = "0x35DCF70", VA = "0x1835DE370")]
				private void _RemoveDeckBuff(int index)
				{
				}

				// Token: 0x0600D87A RID: 55418 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D87A")]
				[Address(RVA = "0x35DD940", Offset = "0x35DC540", VA = "0x1835DD940")]
				private void _DoUpdateAttributeModifier(Deck.Card.DeckBuffWrapper wrapper, bool isAdd)
				{
				}

				// Token: 0x0600D87B RID: 55419 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D87B")]
				[Address(RVA = "0x35DE570", Offset = "0x35DD170", VA = "0x1835DE570")]
				public DeckBuffContainer()
				{
				}

				// Token: 0x0400E938 RID: 59704
				[Token(Token = "0x400E938")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static PriorityQueue<Deck.Card.DeckBuffWrapper> s_deckBuffsByPriority;

				// Token: 0x0400E939 RID: 59705
				[Token(Token = "0x400E939")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private List<Deck.Card.DeckBuffWrapper> m_deckBuffs;

				// Token: 0x0400E93A RID: 59706
				[Token(Token = "0x400E93A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Deck.Card m_card;

				// Token: 0x0400E93B RID: 59707
				[Token(Token = "0x400E93B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private ObjectPool<Deck.Card.DeckBuffWrapper> m_pool;

				// Token: 0x0400E93C RID: 59708
				[Token(Token = "0x400E93C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_get_pool;

				// Token: 0x0400E93D RID: 59709
				[Token(Token = "0x400E93D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_Init;

				// Token: 0x0400E93E RID: 59710
				[Token(Token = "0x400E93E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_Reset;

				// Token: 0x0400E93F RID: 59711
				[Token(Token = "0x400E93F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_GetDeckBuffDatasOnBorn;

				// Token: 0x0400E940 RID: 59712
				[Token(Token = "0x400E940")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_AddRange;

				// Token: 0x0400E941 RID: 59713
				[Token(Token = "0x400E941")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_AddDeckBuff;

				// Token: 0x0400E942 RID: 59714
				[Token(Token = "0x400E942")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_AddDeckBuffWithKey;

				// Token: 0x0400E943 RID: 59715
				[Token(Token = "0x400E943")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_GetDeckBuffCountByBuffKey;

				// Token: 0x0400E944 RID: 59716
				[Token(Token = "0x400E944")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_FinishDeckBuffByKey;

				// Token: 0x0400E945 RID: 59717
				[Token(Token = "0x400E945")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_FinishDeckBuffsOnSpawned;

				// Token: 0x0400E946 RID: 59718
				[Token(Token = "0x400E946")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0_ContainsDeckBuff;

				// Token: 0x0400E947 RID: 59719
				[Token(Token = "0x400E947")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0_PreprocessDeckBuffsCardEffectType;

				// Token: 0x0400E948 RID: 59720
				[Token(Token = "0x400E948")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0_OnCardPutInHand;

				// Token: 0x0400E949 RID: 59721
				[Token(Token = "0x400E949")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0_OnCardGetOffHand;

				// Token: 0x0400E94A RID: 59722
				[Token(Token = "0x400E94A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private static DelegateBridge __Hotfix0__RemoveDeckBuff;

				// Token: 0x0400E94B RID: 59723
				[Token(Token = "0x400E94B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private static DelegateBridge __Hotfix0__DoUpdateAttributeModifier;

				// Token: 0x0400E94C RID: 59724
				[Token(Token = "0x400E94C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020021C7 RID: 8647
			[Token(Token = "0x20021C7")]
			public class DeckBuffWrapper : IHotfixable, IReusableObject, IReusable, IPtrObject, Attributes.IAttributesModifier, IComparable<Deck.Card.DeckBuffWrapper>
			{
				// Token: 0x0600D87D RID: 55421 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D87D")]
				[Address(RVA = "0x35DEBF0", Offset = "0x35DD7F0", VA = "0x1835DEBF0")]
				public static Deck.Card.DeckBuffWrapper Create()
				{
					return null;
				}

				// Token: 0x17001A83 RID: 6787
				// (get) Token: 0x0600D87E RID: 55422 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17001A83")]
				public BuffData buff
				{
					[Token(Token = "0x600D87E")]
					[Address(RVA = "0x35DF8B0", Offset = "0x35DE4B0", VA = "0x1835DF8B0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17001A84 RID: 6788
				// (get) Token: 0x0600D87F RID: 55423 RVA: 0x0004E600 File Offset: 0x0004C800
				[Token(Token = "0x17001A84")]
				public bool showToastWhenAffect
				{
					[Token(Token = "0x600D87F")]
					[Address(RVA = "0x35DFB60", Offset = "0x35DE760", VA = "0x1835DFB60")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17001A85 RID: 6789
				// (get) Token: 0x0600D880 RID: 55424 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17001A85")]
				public string buffKey
				{
					[Token(Token = "0x600D880")]
					[Address(RVA = "0x35DF810", Offset = "0x35DE410", VA = "0x1835DF810")]
					get
					{
						return null;
					}
				}

				// Token: 0x17001A86 RID: 6790
				// (get) Token: 0x0600D881 RID: 55425 RVA: 0x0004E618 File Offset: 0x0004C818
				[Token(Token = "0x17001A86")]
				public BuffData.OverrideType overrideType
				{
					[Token(Token = "0x600D881")]
					[Address(RVA = "0x35DFAF0", Offset = "0x35DE6F0", VA = "0x1835DFAF0")]
					get
					{
						return BuffData.OverrideType.DEFAULT;
					}
				}

				// Token: 0x17001A87 RID: 6791
				// (get) Token: 0x0600D882 RID: 55426 RVA: 0x0004E630 File Offset: 0x0004C830
				[Token(Token = "0x17001A87")]
				public Deck.Card.DeckBuffLifeType lifeType
				{
					[Token(Token = "0x600D882")]
					[Address(RVA = "0x35DFA90", Offset = "0x35DE690", VA = "0x1835DFA90")]
					get
					{
						return Deck.Card.DeckBuffLifeType.ALL_THE_TIME;
					}
				}

				// Token: 0x17001A88 RID: 6792
				// (get) Token: 0x0600D883 RID: 55427 RVA: 0x0004E648 File Offset: 0x0004C848
				[Token(Token = "0x17001A88")]
				public bool checkAffectInDeckAndDummy
				{
					[Token(Token = "0x600D883")]
					[Address(RVA = "0x35DF970", Offset = "0x35DE570", VA = "0x1835DF970")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17001A89 RID: 6793
				// (get) Token: 0x0600D884 RID: 55428 RVA: 0x0004E660 File Offset: 0x0004C860
				[Token(Token = "0x17001A89")]
				public bool checkAffectInHand
				{
					[Token(Token = "0x600D884")]
					[Address(RVA = "0x35DF9D0", Offset = "0x35DE5D0", VA = "0x1835DF9D0")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17001A8A RID: 6794
				// (get) Token: 0x0600D885 RID: 55429 RVA: 0x0004E678 File Offset: 0x0004C878
				[Token(Token = "0x17001A8A")]
				public bool checkAffectGetOffHand
				{
					[Token(Token = "0x600D885")]
					[Address(RVA = "0x35DF910", Offset = "0x35DE510", VA = "0x1835DF910")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0600D886 RID: 55430 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D886")]
				[Address(RVA = "0x35DF110", Offset = "0x35DDD10", VA = "0x1835DF110")]
				public void Init(DeckBuff buffData, Blackboard externalBlackboard)
				{
				}

				// Token: 0x0600D887 RID: 55431 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D887")]
				[Address(RVA = "0x35DF280", Offset = "0x35DDE80", VA = "0x1835DF280", Slot = "4")]
				public void OnAllocate()
				{
				}

				// Token: 0x0600D888 RID: 55432 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D888")]
				[Address(RVA = "0x35DF2F0", Offset = "0x35DDEF0", VA = "0x1835DF2F0", Slot = "5")]
				public void OnRecycle()
				{
				}

				// Token: 0x17001A8B RID: 6795
				// (get) Token: 0x0600D889 RID: 55433 RVA: 0x0004E690 File Offset: 0x0004C890
				[Token(Token = "0x17001A8B")]
				public uint instanceUid
				{
					[Token(Token = "0x600D889")]
					[Address(RVA = "0x35DFA30", Offset = "0x35DE630", VA = "0x1835DFA30", Slot = "6")]
					get
					{
						return 0U;
					}
				}

				// Token: 0x0600D88A RID: 55434 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D88A")]
				[Address(RVA = "0x35DF360", Offset = "0x35DDF60", VA = "0x1835DF360")]
				private void Reset()
				{
				}

				// Token: 0x17001A8C RID: 6796
				// (get) Token: 0x0600D88B RID: 55435 RVA: 0x0004E6A8 File Offset: 0x0004C8A8
				[Token(Token = "0x17001A8C")]
				public long abnormalFlagMask
				{
					[Token(Token = "0x600D88B")]
					[Address(RVA = "0x35DF5B0", Offset = "0x35DE1B0", VA = "0x1835DF5B0", Slot = "8")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17001A8D RID: 6797
				// (get) Token: 0x0600D88C RID: 55436 RVA: 0x0004E6C0 File Offset: 0x0004C8C0
				[Token(Token = "0x17001A8D")]
				public long abnormalImmuneMask
				{
					[Token(Token = "0x600D88C")]
					[Address(RVA = "0x35DF610", Offset = "0x35DE210", VA = "0x1835DF610", Slot = "9")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17001A8E RID: 6798
				// (get) Token: 0x0600D88D RID: 55437 RVA: 0x0004E6D8 File Offset: 0x0004C8D8
				[Token(Token = "0x17001A8E")]
				public long abnormalAntiMask
				{
					[Token(Token = "0x600D88D")]
					[Address(RVA = "0x35DF490", Offset = "0x35DE090", VA = "0x1835DF490", Slot = "10")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17001A8F RID: 6799
				// (get) Token: 0x0600D88E RID: 55438 RVA: 0x0004E6F0 File Offset: 0x0004C8F0
				[Token(Token = "0x17001A8F")]
				public long abnormalComboMask
				{
					[Token(Token = "0x600D88E")]
					[Address(RVA = "0x35DF550", Offset = "0x35DE150", VA = "0x1835DF550", Slot = "11")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17001A90 RID: 6800
				// (get) Token: 0x0600D88F RID: 55439 RVA: 0x0004E708 File Offset: 0x0004C908
				[Token(Token = "0x17001A90")]
				public long abnormalComboImmuneMask
				{
					[Token(Token = "0x600D88F")]
					[Address(RVA = "0x35DF4F0", Offset = "0x35DE0F0", VA = "0x1835DF4F0", Slot = "12")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x17001A91 RID: 6801
				// (get) Token: 0x0600D890 RID: 55440 RVA: 0x0004E720 File Offset: 0x0004C920
				[Token(Token = "0x17001A91")]
				public long attributeMask
				{
					[Token(Token = "0x600D890")]
					[Address(RVA = "0x35DF670", Offset = "0x35DE270", VA = "0x1835DF670", Slot = "7")]
					get
					{
						return 0L;
					}
				}

				// Token: 0x0600D891 RID: 55441 RVA: 0x0004E738 File Offset: 0x0004C938
				[Token(Token = "0x600D891")]
				[Address(RVA = "0x35DECB0", Offset = "0x35DD8B0", VA = "0x1835DECB0", Slot = "13")]
				public bool GetValue(AttributeType attributeType, out FP addition, out FP multiplier, out FP finalAddition, out FP finalScaler)
				{
					return default(bool);
				}

				// Token: 0x0600D892 RID: 55442 RVA: 0x0004E750 File Offset: 0x0004C950
				[Token(Token = "0x600D892")]
				[Address(RVA = "0x35DEB00", Offset = "0x35DD700", VA = "0x1835DEB00", Slot = "14")]
				public int CompareTo(Deck.Card.DeckBuffWrapper other)
				{
					return 0;
				}

				// Token: 0x0600D893 RID: 55443 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D893")]
				[Address(RVA = "0x35DF430", Offset = "0x35DE030", VA = "0x1835DF430")]
				public DeckBuffWrapper()
				{
				}

				// Token: 0x0400E94D RID: 59725
				[Token(Token = "0x400E94D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public DeckBuff data;

				// Token: 0x0400E94E RID: 59726
				[Token(Token = "0x400E94E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public Blackboard blackboard;

				// Token: 0x0400E94F RID: 59727
				[Token(Token = "0x400E94F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public int stackCnt;

				// Token: 0x0400E950 RID: 59728
				[Token(Token = "0x400E950")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public string overrideBuffKey;

				// Token: 0x0400E951 RID: 59729
				[Token(Token = "0x400E951")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static uint s_globalCounter;

				// Token: 0x0400E952 RID: 59730
				[Token(Token = "0x400E952")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private uint m_instanceUid;

				// Token: 0x0400E953 RID: 59731
				[Token(Token = "0x400E953")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_Create;

				// Token: 0x0400E954 RID: 59732
				[Token(Token = "0x400E954")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_buff;

				// Token: 0x0400E955 RID: 59733
				[Token(Token = "0x400E955")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_showToastWhenAffect;

				// Token: 0x0400E956 RID: 59734
				[Token(Token = "0x400E956")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_buffKey;

				// Token: 0x0400E957 RID: 59735
				[Token(Token = "0x400E957")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_overrideType;

				// Token: 0x0400E958 RID: 59736
				[Token(Token = "0x400E958")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_get_lifeType;

				// Token: 0x0400E959 RID: 59737
				[Token(Token = "0x400E959")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_get_checkAffectInDeckAndDummy;

				// Token: 0x0400E95A RID: 59738
				[Token(Token = "0x400E95A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_get_checkAffectInHand;

				// Token: 0x0400E95B RID: 59739
				[Token(Token = "0x400E95B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge __Hotfix0_get_checkAffectGetOffHand;

				// Token: 0x0400E95C RID: 59740
				[Token(Token = "0x400E95C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_Init;

				// Token: 0x0400E95D RID: 59741
				[Token(Token = "0x400E95D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0_OnAllocate;

				// Token: 0x0400E95E RID: 59742
				[Token(Token = "0x400E95E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0_OnRecycle;

				// Token: 0x0400E95F RID: 59743
				[Token(Token = "0x400E95F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0_get_instanceUid;

				// Token: 0x0400E960 RID: 59744
				[Token(Token = "0x400E960")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0_Reset;

				// Token: 0x0400E961 RID: 59745
				[Token(Token = "0x400E961")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private static DelegateBridge __Hotfix0_get_abnormalFlagMask;

				// Token: 0x0400E962 RID: 59746
				[Token(Token = "0x400E962")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private static DelegateBridge __Hotfix0_get_abnormalImmuneMask;

				// Token: 0x0400E963 RID: 59747
				[Token(Token = "0x400E963")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private static DelegateBridge __Hotfix0_get_abnormalAntiMask;

				// Token: 0x0400E964 RID: 59748
				[Token(Token = "0x400E964")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private static DelegateBridge __Hotfix0_get_abnormalComboMask;

				// Token: 0x0400E965 RID: 59749
				[Token(Token = "0x400E965")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
				private static DelegateBridge __Hotfix0_get_abnormalComboImmuneMask;

				// Token: 0x0400E966 RID: 59750
				[Token(Token = "0x400E966")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
				private static DelegateBridge __Hotfix0_get_attributeMask;

				// Token: 0x0400E967 RID: 59751
				[Token(Token = "0x400E967")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				private static DelegateBridge __Hotfix0_GetValue;

				// Token: 0x0400E968 RID: 59752
				[Token(Token = "0x400E968")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
				private static DelegateBridge __Hotfix0_CompareTo;

				// Token: 0x0400E969 RID: 59753
				[Token(Token = "0x400E969")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020021C8 RID: 8648
			[Token(Token = "0x20021C8")]
			public enum CardPolicy
			{
				// Token: 0x0400E96B RID: 59755
				[Token(Token = "0x400E96B")]
				DEFAULT,
				// Token: 0x0400E96C RID: 59756
				[Token(Token = "0x400E96C")]
				UNIQUE,
				// Token: 0x0400E96D RID: 59757
				[Token(Token = "0x400E96D")]
				QUEUED
			}

			// Token: 0x020021C9 RID: 8649
			[Token(Token = "0x20021C9")]
			public enum State
			{
				// Token: 0x0400E96F RID: 59759
				[Token(Token = "0x400E96F")]
				NONE,
				// Token: 0x0400E970 RID: 59760
				[Token(Token = "0x400E970")]
				READY,
				// Token: 0x0400E971 RID: 59761
				[Token(Token = "0x400E971")]
				USING,
				// Token: 0x0400E972 RID: 59762
				[Token(Token = "0x400E972")]
				RESPAWNING,
				// Token: 0x0400E973 RID: 59763
				[Token(Token = "0x400E973")]
				QUEUING
			}

			// Token: 0x020021CA RID: 8650
			[Token(Token = "0x20021CA")]
			public enum ComboState
			{
				// Token: 0x0400E975 RID: 59765
				[Token(Token = "0x400E975")]
				NONE,
				// Token: 0x0400E976 RID: 59766
				[Token(Token = "0x400E976")]
				READY
			}

			// Token: 0x020021CB RID: 8651
			[Token(Token = "0x20021CB")]
			public enum DeckBuffLifeType
			{
				// Token: 0x0400E978 RID: 59768
				[Token(Token = "0x400E978")]
				ALL_THE_TIME,
				// Token: 0x0400E979 RID: 59769
				[Token(Token = "0x400E979")]
				UNTIL_NEXT_SPAWN
			}

			// Token: 0x020021CC RID: 8652
			[Token(Token = "0x20021CC")]
			public enum CardEffectType
			{
				// Token: 0x0400E97B RID: 59771
				[Token(Token = "0x400E97B")]
				NONE,
				// Token: 0x0400E97C RID: 59772
				[Token(Token = "0x400E97C")]
				DURANCE,
				// Token: 0x0400E97D RID: 59773
				[Token(Token = "0x400E97D")]
				UNDEPLOYABLE,
				// Token: 0x0400E97E RID: 59774
				[Token(Token = "0x400E97E")]
				TAUNT,
				// Token: 0x0400E97F RID: 59775
				[Token(Token = "0x400E97F")]
				DEVOURED,
				// Token: 0x0400E980 RID: 59776
				[Token(Token = "0x400E980")]
				MUTATION,
				// Token: 0x0400E981 RID: 59777
				[Token(Token = "0x400E981")]
				MHWRBG,
				// Token: 0x0400E982 RID: 59778
				[Token(Token = "0x400E982")]
				WTRMAN_DISTURB,
				// Token: 0x0400E983 RID: 59779
				[Token(Token = "0x400E983")]
				CHOSEN_ONE,
				// Token: 0x0400E984 RID: 59780
				[Token(Token = "0x400E984")]
				ASCENSION,
				// Token: 0x0400E985 RID: 59781
				[Token(Token = "0x400E985")]
				ANGEL2,
				// Token: 0x0400E986 RID: 59782
				[Token(Token = "0x400E986")]
				RL5_RELIC_CARDG,
				// Token: 0x0400E987 RID: 59783
				[Token(Token = "0x400E987")]
				RL5_CANDLE,
				// Token: 0x0400E988 RID: 59784
				[Token(Token = "0x400E988")]
				E_NUM
			}

			// Token: 0x020021CD RID: 8653
			[Token(Token = "0x20021CD")]
			[Flags]
			public enum AdvancedCardBuildState
			{
				// Token: 0x0400E98A RID: 59786
				[Token(Token = "0x400E98A")]
				DEFAULT = 0,
				// Token: 0x0400E98B RID: 59787
				[Token(Token = "0x400E98B")]
				IN_SPECIAL_BUILD = 1
			}

			// Token: 0x020021CE RID: 8654
			[Token(Token = "0x20021CE")]
			public enum RechargeTiming
			{
				// Token: 0x0400E98D RID: 59789
				[Token(Token = "0x400E98D")]
				NORMAL,
				// Token: 0x0400E98E RID: 59790
				[Token(Token = "0x400E98E")]
				ON_FINISH
			}

			// Token: 0x020021CF RID: 8655
			[Token(Token = "0x20021CF")]
			public class ObscuredAttributesSnapshot
			{
				// Token: 0x17001A92 RID: 6802
				// (get) Token: 0x0600D894 RID: 55444 RVA: 0x0004E768 File Offset: 0x0004C968
				[Token(Token = "0x17001A92")]
				public ObscuredInt maxHp
				{
					[Token(Token = "0x600D894")]
					[Address(RVA = "0x35E5590", Offset = "0x35E4190", VA = "0x1835E5590")]
					get
					{
						return default(ObscuredInt);
					}
				}

				// Token: 0x17001A93 RID: 6803
				// (get) Token: 0x0600D895 RID: 55445 RVA: 0x0004E780 File Offset: 0x0004C980
				[Token(Token = "0x17001A93")]
				public ObscuredInt atk
				{
					[Token(Token = "0x600D895")]
					[Address(RVA = "0x35E51D0", Offset = "0x35E3DD0", VA = "0x1835E51D0")]
					get
					{
						return default(ObscuredInt);
					}
				}

				// Token: 0x17001A94 RID: 6804
				// (get) Token: 0x0600D896 RID: 55446 RVA: 0x0004E798 File Offset: 0x0004C998
				[Token(Token = "0x17001A94")]
				public ObscuredInt def
				{
					[Token(Token = "0x600D896")]
					[Address(RVA = "0x35E5380", Offset = "0x35E3F80", VA = "0x1835E5380")]
					get
					{
						return default(ObscuredInt);
					}
				}

				// Token: 0x17001A95 RID: 6805
				// (get) Token: 0x0600D897 RID: 55447 RVA: 0x0004E7B0 File Offset: 0x0004C9B0
				[Token(Token = "0x17001A95")]
				public ObscuredFP magicResistance
				{
					[Token(Token = "0x600D897")]
					[Address(RVA = "0x35E5410", Offset = "0x35E4010", VA = "0x1835E5410")]
					get
					{
						return default(ObscuredFP);
					}
				}

				// Token: 0x17001A96 RID: 6806
				// (get) Token: 0x0600D898 RID: 55448 RVA: 0x0004E7C8 File Offset: 0x0004C9C8
				[Token(Token = "0x17001A96")]
				public ObscuredInt cost
				{
					[Token(Token = "0x600D898")]
					[Address(RVA = "0x35E52F0", Offset = "0x35E3EF0", VA = "0x1835E52F0")]
					get
					{
						return default(ObscuredInt);
					}
				}

				// Token: 0x17001A97 RID: 6807
				// (get) Token: 0x0600D899 RID: 55449 RVA: 0x0004E7E0 File Offset: 0x0004C9E0
				[Token(Token = "0x17001A97")]
				public ObscuredInt blockCnt
				{
					[Token(Token = "0x600D899")]
					[Address(RVA = "0x35E5260", Offset = "0x35E3E60", VA = "0x1835E5260")]
					get
					{
						return default(ObscuredInt);
					}
				}

				// Token: 0x17001A98 RID: 6808
				// (get) Token: 0x0600D89A RID: 55450 RVA: 0x0004E7F8 File Offset: 0x0004C9F8
				[Token(Token = "0x17001A98")]
				public ObscuredInt respawnTime
				{
					[Token(Token = "0x600D89A")]
					[Address(RVA = "0x35E5620", Offset = "0x35E4220", VA = "0x1835E5620")]
					get
					{
						return default(ObscuredInt);
					}
				}

				// Token: 0x17001A99 RID: 6809
				// (get) Token: 0x0600D89B RID: 55451 RVA: 0x0004E810 File Offset: 0x0004CA10
				[Token(Token = "0x17001A99")]
				public ObscuredInt maxDeployCount
				{
					[Token(Token = "0x600D89B")]
					[Address(RVA = "0x35E5500", Offset = "0x35E4100", VA = "0x1835E5500")]
					get
					{
						return default(ObscuredInt);
					}
				}

				// Token: 0x17001A9A RID: 6810
				// (get) Token: 0x0600D89C RID: 55452 RVA: 0x0004E828 File Offset: 0x0004CA28
				[Token(Token = "0x17001A9A")]
				public ObscuredInt maxDeckStackCnt
				{
					[Token(Token = "0x600D89C")]
					[Address(RVA = "0x35E5470", Offset = "0x35E4070", VA = "0x1835E5470")]
					get
					{
						return default(ObscuredInt);
					}
				}

				// Token: 0x17001A9B RID: 6811
				// (get) Token: 0x0600D89D RID: 55453 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17001A9B")]
				public Attributes attributes
				{
					[Token(Token = "0x600D89D")]
					[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
					get
					{
						return null;
					}
				}

				// Token: 0x0600D89E RID: 55454 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D89E")]
				[Address(RVA = "0x35E5100", Offset = "0x35E3D00", VA = "0x1835E5100")]
				public ObscuredAttributesSnapshot(Attributes attributes)
				{
				}

				// Token: 0x0600D89F RID: 55455 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D89F")]
				[Address(RVA = "0x35E4F60", Offset = "0x35E3B60", VA = "0x1835E4F60")]
				public void CopyFrom(Attributes attr, bool exceptCost)
				{
				}

				// Token: 0x0600D8A0 RID: 55456 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8A0")]
				[Address(RVA = "0x35E5010", Offset = "0x35E3C10", VA = "0x1835E5010")]
				public void ModifyCost(int value)
				{
				}

				// Token: 0x0600D8A1 RID: 55457 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8A1")]
				[Address(RVA = "0x35E4EF0", Offset = "0x35E3AF0", VA = "0x1835E4EF0")]
				public void ApplyModifier(Attributes.IAttributesModifier modifier)
				{
				}

				// Token: 0x0600D8A2 RID: 55458 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8A2")]
				[Address(RVA = "0x35E5090", Offset = "0x35E3C90", VA = "0x1835E5090")]
				public void RemoveModifier(Attributes.IAttributesModifier modifier)
				{
				}

				// Token: 0x0400E98F RID: 59791
				[Token(Token = "0x400E98F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Attributes m_attributes;
			}

			// Token: 0x020021D0 RID: 8656
			[Token(Token = "0x20021D0")]
			public abstract class CardBuffModifier : IOverrideableDeckModifier
			{
				// Token: 0x17001A9C RID: 6812
				// (get) Token: 0x0600D8A3 RID: 55459 RVA: 0x0004E840 File Offset: 0x0004CA40
				// (set) Token: 0x0600D8A4 RID: 55460 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17001A9C")]
				public Deck.Card.CardBuff.ModifierType type
				{
					[Token(Token = "0x600D8A3")]
					[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
					[CompilerGenerated]
					get
					{
						return Deck.Card.CardBuff.ModifierType.NONE;
					}
					[Token(Token = "0x600D8A4")]
					[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
					[CompilerGenerated]
					private set
					{
					}
				}

				// Token: 0x17001A9D RID: 6813
				// (get) Token: 0x0600D8A5 RID: 55461 RVA: 0x0004E858 File Offset: 0x0004CA58
				// (set) Token: 0x0600D8A6 RID: 55462 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17001A9D")]
				public bool overrideValid
				{
					[Token(Token = "0x600D8A5")]
					[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0", Slot = "4")]
					[CompilerGenerated]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x600D8A6")]
					[Address(RVA = "0x4EAC50", Offset = "0x4E9850", VA = "0x1804EAC50", Slot = "5")]
					[CompilerGenerated]
					set
					{
					}
				}

				// Token: 0x0600D8A7 RID: 55463 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8A7")]
				[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
				public CardBuffModifier(Deck.Card.CardBuff.ModifierType type)
				{
				}

				// Token: 0x17001A9E RID: 6814
				// (get) Token: 0x0600D8A8 RID: 55464 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17001A9E")]
				public virtual string overrideKey
				{
					[Token(Token = "0x600D8A8")]
					[Address(RVA = "0x35DA190", Offset = "0x35D8D90", VA = "0x1835DA190", Slot = "8")]
					get
					{
						return null;
					}
				}

				// Token: 0x17001A9F RID: 6815
				// (get) Token: 0x0600D8A9 RID: 55465 RVA: 0x0004E870 File Offset: 0x0004CA70
				[Token(Token = "0x17001A9F")]
				public virtual FP overridePriority
				{
					[Token(Token = "0x600D8A9")]
					[Address(RVA = "0x35DA1D0", Offset = "0x35D8DD0", VA = "0x1835DA1D0", Slot = "9")]
					get
					{
						return default(FP);
					}
				}

				// Token: 0x17001AA0 RID: 6816
				// (get) Token: 0x0600D8AA RID: 55466 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17001AA0")]
				public virtual string cardBuffKey
				{
					[Token(Token = "0x600D8AA")]
					[Address(RVA = "0x35DA150", Offset = "0x35D8D50", VA = "0x1835DA150", Slot = "10")]
					get
					{
						return null;
					}
				}

				// Token: 0x0600D8AB RID: 55467 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D8AB")]
				public T As<T>() where T : Deck.Card.CardBuffModifier
				{
					return null;
				}

				// Token: 0x0600D8AC RID: 55468 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8AC")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
				public virtual void ApplyFirstPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}

				// Token: 0x0600D8AD RID: 55469 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8AD")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
				public virtual void ApplySecondPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}

				// Token: 0x0600D8AE RID: 55470 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8AE")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
				public virtual void ApplyModifierFinalPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}
			}

			// Token: 0x020021D1 RID: 8657
			[Token(Token = "0x20021D1")]
			public class RuntimeCostModifier : Deck.Card.CardBuffModifier
			{
				// Token: 0x0600D8AF RID: 55471 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8AF")]
				[Address(RVA = "0x35EC820", Offset = "0x35EB420", VA = "0x1835EC820")]
				public RuntimeCostModifier(int value, FP scale)
				{
				}

				// Token: 0x17001AA1 RID: 6817
				// (get) Token: 0x0600D8B0 RID: 55472 RVA: 0x0004E888 File Offset: 0x0004CA88
				[Token(Token = "0x17001AA1")]
				public int value
				{
					[Token(Token = "0x600D8B0")]
					[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
					get
					{
						return 0;
					}
				}

				// Token: 0x17001AA2 RID: 6818
				// (get) Token: 0x0600D8B1 RID: 55473 RVA: 0x0004E8A0 File Offset: 0x0004CAA0
				[Token(Token = "0x17001AA2")]
				public FP scale
				{
					[Token(Token = "0x600D8B1")]
					[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
					get
					{
						return default(FP);
					}
				}

				// Token: 0x0600D8B2 RID: 55474 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D8B2")]
				[Address(RVA = "0x35EC650", Offset = "0x35EB250", VA = "0x1835EC650")]
				public static Deck.Card.RuntimeCostModifier CreateRuntimeModifier(int value, FP scale)
				{
					return null;
				}

				// Token: 0x0600D8B3 RID: 55475 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D8B3")]
				[Address(RVA = "0x35EC6D0", Offset = "0x35EB2D0", VA = "0x1835EC6D0")]
				public static Deck.Card.RuntimeCostModifier CreateRuntimeModifier(Blackboard blackboard)
				{
					return null;
				}

				// Token: 0x0600D8B4 RID: 55476 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8B4")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
				public virtual void Preprocess(Deck deck)
				{
				}

				// Token: 0x0600D8B5 RID: 55477 RVA: 0x0004E8B8 File Offset: 0x0004CAB8
				[Token(Token = "0x600D8B5")]
				[Address(RVA = "0x35E0530", Offset = "0x35DF130", VA = "0x1835E0530", Slot = "15")]
				public virtual bool TryGetCostDelta(Deck.Card card, out int costDelta)
				{
					return default(bool);
				}

				// Token: 0x0600D8B6 RID: 55478 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8B6")]
				[Address(RVA = "0x35EC5D0", Offset = "0x35EB1D0", VA = "0x1835EC5D0", Slot = "11")]
				public override void ApplyFirstPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}

				// Token: 0x0400E992 RID: 59794
				[Token(Token = "0x400E992")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private int m_value;

				// Token: 0x0400E993 RID: 59795
				[Token(Token = "0x400E993")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private FP m_rawCostScale;
			}

			// Token: 0x020021D2 RID: 8658
			[Token(Token = "0x20021D2")]
			public class RuntimeRespawnTimeModifier : Deck.Card.CardBuffModifier
			{
				// Token: 0x0600D8B7 RID: 55479 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8B7")]
				[Address(RVA = "0x35ED040", Offset = "0x35EBC40", VA = "0x1835ED040")]
				public RuntimeRespawnTimeModifier()
				{
				}

				// Token: 0x17001AA3 RID: 6819
				// (get) Token: 0x0600D8B8 RID: 55480 RVA: 0x0004E8D0 File Offset: 0x0004CAD0
				[Token(Token = "0x17001AA3")]
				public FP value
				{
					[Token(Token = "0x600D8B8")]
					[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
					get
					{
						return default(FP);
					}
				}

				// Token: 0x17001AA4 RID: 6820
				// (get) Token: 0x0600D8B9 RID: 55481 RVA: 0x0004E8E8 File Offset: 0x0004CAE8
				[Token(Token = "0x17001AA4")]
				public bool isRatio
				{
					[Token(Token = "0x600D8B9")]
					[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17001AA5 RID: 6821
				// (get) Token: 0x0600D8BA RID: 55482 RVA: 0x0004E900 File Offset: 0x0004CB00
				[Token(Token = "0x17001AA5")]
				public bool disabled
				{
					[Token(Token = "0x600D8BA")]
					[Address(RVA = "0x4FD480", Offset = "0x4FC080", VA = "0x1804FD480")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17001AA6 RID: 6822
				// (get) Token: 0x0600D8BB RID: 55483 RVA: 0x0004E918 File Offset: 0x0004CB18
				[Token(Token = "0x17001AA6")]
				private bool respawnStopped
				{
					[Token(Token = "0x600D8BB")]
					[Address(RVA = "0x1694D40", Offset = "0x1693940", VA = "0x181694D40")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17001AA7 RID: 6823
				// (get) Token: 0x0600D8BC RID: 55484 RVA: 0x0004E930 File Offset: 0x0004CB30
				[Token(Token = "0x17001AA7")]
				public bool addRespawnCostMultCnt
				{
					[Token(Token = "0x600D8BC")]
					[Address(RVA = "0x35ED060", Offset = "0x35EBC60", VA = "0x1835ED060")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0600D8BD RID: 55485 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D8BD")]
				[Address(RVA = "0x35ECB60", Offset = "0x35EB760", VA = "0x1835ECB60")]
				public static Deck.Card.RuntimeRespawnTimeModifier CreateRuntimeModifier(FP value, bool isRatio, bool disabled, bool addRespawnCostMultCnt, bool respawnStopped, FP minValue, FP maxValue, bool isOverride = false)
				{
					return null;
				}

				// Token: 0x0600D8BE RID: 55486 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D8BE")]
				[Address(RVA = "0x35ECAD0", Offset = "0x35EB6D0", VA = "0x1835ECAD0")]
				public static Deck.Card.RuntimeRespawnTimeModifier CreateRuntimeModifierRespawnCostMultCnt()
				{
					return null;
				}

				// Token: 0x0600D8BF RID: 55487 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D8BF")]
				[Address(RVA = "0x35ECC20", Offset = "0x35EB820", VA = "0x1835ECC20")]
				public static Deck.Card.RuntimeRespawnTimeModifier CreateRuntimeModifier(FP value, bool isRatio, bool disabled, bool addRespawnCostMultCnt, bool respawnStopped, bool isOverride = false)
				{
					return null;
				}

				// Token: 0x0600D8C0 RID: 55488 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D8C0")]
				[Address(RVA = "0x35ECD10", Offset = "0x35EB910", VA = "0x1835ECD10")]
				public static Deck.Card.RuntimeRespawnTimeModifier CreateRuntimeModifier(Blackboard blackboard, bool isRatio)
				{
					return null;
				}

				// Token: 0x0600D8C1 RID: 55489 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8C1")]
				[Address(RVA = "0x35EC860", Offset = "0x35EB460", VA = "0x1835EC860", Slot = "11")]
				public override void ApplyFirstPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}

				// Token: 0x0600D8C2 RID: 55490 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8C2")]
				[Address(RVA = "0x35ECA50", Offset = "0x35EB650", VA = "0x1835ECA50", Slot = "12")]
				public override void ApplySecondPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}

				// Token: 0x0600D8C3 RID: 55491 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8C3")]
				[Address(RVA = "0x35EC910", Offset = "0x35EB510", VA = "0x1835EC910", Slot = "13")]
				public override void ApplyModifierFinalPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}

				// Token: 0x0400E994 RID: 59796
				[Token(Token = "0x400E994")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private FP m_value;

				// Token: 0x0400E995 RID: 59797
				[Token(Token = "0x400E995")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private bool m_isOverride;

				// Token: 0x0400E996 RID: 59798
				[Token(Token = "0x400E996")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private FP m_minValue;

				// Token: 0x0400E997 RID: 59799
				[Token(Token = "0x400E997")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private FP m_maxValue;

				// Token: 0x0400E998 RID: 59800
				[Token(Token = "0x400E998")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private bool m_isRatio;

				// Token: 0x0400E999 RID: 59801
				[Token(Token = "0x400E999")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
				private bool m_disabled;

				// Token: 0x0400E99A RID: 59802
				[Token(Token = "0x400E99A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
				private bool m_respawnStopped;

				// Token: 0x0400E99B RID: 59803
				[Token(Token = "0x400E99B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
				private bool m_addRespawnCostMultCnt;
			}

			// Token: 0x020021D3 RID: 8659
			[Token(Token = "0x20021D3")]
			public class RemainingRespawnTimeModifier : Deck.Card.CardBuffModifier
			{
				// Token: 0x0600D8C4 RID: 55492 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8C4")]
				[Address(RVA = "0x35EC5B0", Offset = "0x35EB1B0", VA = "0x1835EC5B0")]
				private RemainingRespawnTimeModifier()
				{
				}

				// Token: 0x17001AA8 RID: 6824
				// (get) Token: 0x0600D8C5 RID: 55493 RVA: 0x0004E948 File Offset: 0x0004CB48
				[Token(Token = "0x17001AA8")]
				public FP respawnTimeMaxMult
				{
					[Token(Token = "0x600D8C5")]
					[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
					get
					{
						return default(FP);
					}
				}

				// Token: 0x17001AA9 RID: 6825
				// (get) Token: 0x0600D8C6 RID: 55494 RVA: 0x0004E960 File Offset: 0x0004CB60
				[Token(Token = "0x17001AA9")]
				public FP value
				{
					[Token(Token = "0x600D8C6")]
					[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
					get
					{
						return default(FP);
					}
				}

				// Token: 0x17001AAA RID: 6826
				// (get) Token: 0x0600D8C7 RID: 55495 RVA: 0x0004E978 File Offset: 0x0004CB78
				[Token(Token = "0x17001AAA")]
				public bool isRatio
				{
					[Token(Token = "0x600D8C7")]
					[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0600D8C8 RID: 55496 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D8C8")]
				[Address(RVA = "0x35EC530", Offset = "0x35EB130", VA = "0x1835EC530")]
				public static Deck.Card.RemainingRespawnTimeModifier CreateRuntimeModifier(FP value, bool isRatio)
				{
					return null;
				}

				// Token: 0x0600D8C9 RID: 55497 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D8C9")]
				[Address(RVA = "0x35EC2D0", Offset = "0x35EAED0", VA = "0x1835EC2D0")]
				public static Deck.Card.RemainingRespawnTimeModifier CreateRuntimeModifierByMaxMult(FP value)
				{
					return null;
				}

				// Token: 0x0600D8CA RID: 55498 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D8CA")]
				[Address(RVA = "0x35EC380", Offset = "0x35EAF80", VA = "0x1835EC380")]
				public static Deck.Card.RemainingRespawnTimeModifier CreateRuntimeModifier(Blackboard blackboard, bool isRatio)
				{
					return null;
				}

				// Token: 0x0600D8CB RID: 55499 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8CB")]
				[Address(RVA = "0x35EC0A0", Offset = "0x35EACA0", VA = "0x1835EC0A0", Slot = "11")]
				public override void ApplyFirstPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}

				// Token: 0x0600D8CC RID: 55500 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8CC")]
				[Address(RVA = "0x35EC1F0", Offset = "0x35EADF0", VA = "0x1835EC1F0", Slot = "12")]
				public override void ApplySecondPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}

				// Token: 0x0400E99C RID: 59804
				[Token(Token = "0x400E99C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private FP m_respawnTimeMaxMult;

				// Token: 0x0400E99D RID: 59805
				[Token(Token = "0x400E99D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private FP m_value;

				// Token: 0x0400E99E RID: 59806
				[Token(Token = "0x400E99E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private bool m_isRatio;
			}

			// Token: 0x020021D4 RID: 8660
			[Token(Token = "0x20021D4")]
			public class MiscSettingModifier : Deck.Card.CardBuffModifier
			{
				// Token: 0x0600D8CD RID: 55501 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8CD")]
				[Address(RVA = "0x35E4E40", Offset = "0x35E3A40", VA = "0x1835E4E40")]
				public MiscSettingModifier()
				{
				}

				// Token: 0x0600D8CE RID: 55502 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8CE")]
				[Address(RVA = "0x35E4E60", Offset = "0x35E3A60", VA = "0x1835E4E60")]
				public MiscSettingModifier(bool dontOccupyDeployCnt, AdditionalBuildCondition additionalBuildCondition, bool ignoreRespawningState, bool dontOccupyMaxDeployCnt, bool notValidToBuild)
				{
				}

				// Token: 0x17001AAB RID: 6827
				// (get) Token: 0x0600D8CF RID: 55503 RVA: 0x0004E990 File Offset: 0x0004CB90
				[Token(Token = "0x17001AAB")]
				public bool dontOccupyDeployCnt
				{
					[Token(Token = "0x600D8CF")]
					[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17001AAC RID: 6828
				// (get) Token: 0x0600D8D0 RID: 55504 RVA: 0x0004E9A8 File Offset: 0x0004CBA8
				[Token(Token = "0x17001AAC")]
				public bool dontOccupyMaxDeployCnt
				{
					[Token(Token = "0x600D8D0")]
					[Address(RVA = "0x54A770", Offset = "0x549370", VA = "0x18054A770")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17001AAD RID: 6829
				// (get) Token: 0x0600D8D1 RID: 55505 RVA: 0x0004E9C0 File Offset: 0x0004CBC0
				[Token(Token = "0x17001AAD")]
				public bool ignoreRespawningState
				{
					[Token(Token = "0x600D8D1")]
					[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17001AAE RID: 6830
				// (get) Token: 0x0600D8D2 RID: 55506 RVA: 0x0004E9D8 File Offset: 0x0004CBD8
				[Token(Token = "0x17001AAE")]
				public AdditionalBuildCondition additionalBuildCondition
				{
					[Token(Token = "0x600D8D2")]
					[Address(RVA = "0x35E4ED0", Offset = "0x35E3AD0", VA = "0x1835E4ED0")]
					get
					{
						return default(AdditionalBuildCondition);
					}
				}

				// Token: 0x0600D8D3 RID: 55507 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D8D3")]
				[Address(RVA = "0x35E4B70", Offset = "0x35E3770", VA = "0x1835E4B70")]
				public static Deck.Card.MiscSettingModifier CreateRuntimeModifier(Blackboard blackboard)
				{
					return null;
				}

				// Token: 0x0600D8D4 RID: 55508 RVA: 0x0004E9F0 File Offset: 0x0004CBF0
				[Token(Token = "0x600D8D4")]
				[Address(RVA = "0x35E4E30", Offset = "0x35E3A30", VA = "0x1835E4E30", Slot = "14")]
				public virtual bool IsTriggered(Deck.Card card, out Deck.Card.CardBuff.LifeType lifeType)
				{
					return default(bool);
				}

				// Token: 0x0600D8D5 RID: 55509 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8D5")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
				public virtual void Preprocess(Deck deck)
				{
				}

				// Token: 0x0600D8D6 RID: 55510 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8D6")]
				[Address(RVA = "0x35E4AB0", Offset = "0x35E36B0", VA = "0x1835E4AB0", Slot = "11")]
				public override void ApplyFirstPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}

				// Token: 0x0400E99F RID: 59807
				[Token(Token = "0x400E99F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private bool m_dontOccupyDeployCnt;

				// Token: 0x0400E9A0 RID: 59808
				[Token(Token = "0x400E9A0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
				private bool m_dontOccupyMaxDeployCnt;

				// Token: 0x0400E9A1 RID: 59809
				[Token(Token = "0x400E9A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
				private bool m_notValidToBuild;

				// Token: 0x0400E9A2 RID: 59810
				[Token(Token = "0x400E9A2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private AdditionalBuildCondition m_additionalBuildCondition;

				// Token: 0x0400E9A3 RID: 59811
				[Token(Token = "0x400E9A3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private bool m_ignoreRespawningState;

				// Token: 0x0400E9A4 RID: 59812
				[Token(Token = "0x400E9A4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
				public Deck.Card.AdvancedCardBuildState advancedCardBuildState;
			}

			// Token: 0x020021D5 RID: 8661
			[Token(Token = "0x20021D5")]
			public class CardBuff : IHotfixable
			{
				// Token: 0x17001AAF RID: 6831
				// (get) Token: 0x0600D8D7 RID: 55511 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x0600D8D8 RID: 55512 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x17001AAF")]
				public string cardAnimOnPlay
				{
					[Token(Token = "0x600D8D7")]
					[Address(RVA = "0x35DAE00", Offset = "0x35D9A00", VA = "0x1835DAE00")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Token(Token = "0x600D8D8")]
					[Address(RVA = "0x35DB090", Offset = "0x35D9C90", VA = "0x1835DB090")]
					[CompilerGenerated]
					private set
					{
					}
				}

				// Token: 0x17001AB0 RID: 6832
				// (get) Token: 0x0600D8D9 RID: 55513 RVA: 0x0004EA08 File Offset: 0x0004CC08
				[Token(Token = "0x17001AB0")]
				public Deck.Card.CardBuff.LifeType lifeType
				{
					[Token(Token = "0x600D8D9")]
					[Address(RVA = "0x35DAEC0", Offset = "0x35D9AC0", VA = "0x1835DAEC0")]
					get
					{
						return Deck.Card.CardBuff.LifeType.UNTIL_NEXT_SPAWN;
					}
				}

				// Token: 0x17001AB1 RID: 6833
				// (get) Token: 0x0600D8DA RID: 55514 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17001AB1")]
				public string key
				{
					[Token(Token = "0x600D8DA")]
					[Address(RVA = "0x35DAE60", Offset = "0x35D9A60", VA = "0x1835DAE60")]
					get
					{
						return null;
					}
				}

				// Token: 0x17001AB2 RID: 6834
				// (get) Token: 0x0600D8DB RID: 55515 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17001AB2")]
				public string stackKey
				{
					[Token(Token = "0x600D8DB")]
					[Address(RVA = "0x35DB030", Offset = "0x35D9C30", VA = "0x1835DB030")]
					get
					{
						return null;
					}
				}

				// Token: 0x17001AB3 RID: 6835
				// (get) Token: 0x0600D8DC RID: 55516 RVA: 0x0004EA20 File Offset: 0x0004CC20
				[Token(Token = "0x17001AB3")]
				public uint sourceCardUid
				{
					[Token(Token = "0x600D8DC")]
					[Address(RVA = "0x35DAFD0", Offset = "0x35D9BD0", VA = "0x1835DAFD0")]
					get
					{
						return 0U;
					}
				}

				// Token: 0x17001AB4 RID: 6836
				// (get) Token: 0x0600D8DD RID: 55517 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17001AB4")]
				public Buff owner
				{
					[Token(Token = "0x600D8DD")]
					[Address(RVA = "0x35DAF20", Offset = "0x35D9B20", VA = "0x1835DAF20")]
					get
					{
						return null;
					}
				}

				// Token: 0x0600D8DE RID: 55518 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8DE")]
				[Address(RVA = "0x35DA680", Offset = "0x35D9280", VA = "0x1835DA680")]
				public CardBuff(string key, Deck.Card.CardBuff.LifeType lifeType, [Optional] string cardAnimOnPlay, params Deck.Card.CardBuffModifier[] modifiers)
				{
				}

				// Token: 0x0600D8DF RID: 55519 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8DF")]
				[Address(RVA = "0x35DA8C0", Offset = "0x35D94C0", VA = "0x1835DA8C0")]
				public CardBuff(Deck.Card sourceCard, Deck.Card.CardBuff.LifeType lifeType, [Optional] string key, [Optional] string cardAnimOnPlay, params Deck.Card.CardBuffModifier[] modifiers)
				{
				}

				// Token: 0x0600D8E0 RID: 55520 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8E0")]
				[Address(RVA = "0x35DAB50", Offset = "0x35D9750", VA = "0x1835DAB50")]
				public CardBuff(Buff sourceBuff, Deck.Card.CardBuff.LifeType lifeType, [Optional] string key, [Optional] string cardAnimOnPlay, params Deck.Card.CardBuffModifier[] modifiers)
				{
				}

				// Token: 0x0600D8E1 RID: 55521 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8E1")]
				[Address(RVA = "0x35DA310", Offset = "0x35D8F10", VA = "0x1835DA310")]
				public void ApplyModifiersFirstPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}

				// Token: 0x0600D8E2 RID: 55522 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8E2")]
				[Address(RVA = "0x35DA400", Offset = "0x35D9000", VA = "0x1835DA400")]
				public void ApplyModifiersSecondPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}

				// Token: 0x0600D8E3 RID: 55523 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8E3")]
				[Address(RVA = "0x35DA220", Offset = "0x35D8E20", VA = "0x1835DA220")]
				public void ApplyModifierFinalPass(Deck.Card card, ref Deck.Card.CardBuff.CardBuffOptions options)
				{
				}

				// Token: 0x0600D8E4 RID: 55524 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D8E4")]
				[Address(RVA = "0x35DA610", Offset = "0x35D9210", VA = "0x1835DA610")]
				public void SetRemainingTime(FP remainingTime)
				{
				}

				// Token: 0x0600D8E5 RID: 55525 RVA: 0x0004EA38 File Offset: 0x0004CC38
				[Token(Token = "0x600D8E5")]
				[Address(RVA = "0x35DA4F0", Offset = "0x35D90F0", VA = "0x1835DA4F0")]
				public bool OnTick(FP deltaTime)
				{
					return default(bool);
				}

				// Token: 0x0400E9A5 RID: 59813
				[Token(Token = "0x400E9A5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Deck.Card.CardBuff.LifeType m_lifeType;

				// Token: 0x0400E9A6 RID: 59814
				[Token(Token = "0x400E9A6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private ObjectPtr<Buff> m_owner;

				// Token: 0x0400E9A7 RID: 59815
				[Token(Token = "0x400E9A7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private uint m_sourceCardUid;

				// Token: 0x0400E9A8 RID: 59816
				[Token(Token = "0x400E9A8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private Deck.Card.CardBuffModifier[] m_modifiers;

				// Token: 0x0400E9AA RID: 59818
				[Token(Token = "0x400E9AA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private string m_key;

				// Token: 0x0400E9AB RID: 59819
				[Token(Token = "0x400E9AB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private string m_stackKey;

				// Token: 0x0400E9AC RID: 59820
				[Token(Token = "0x400E9AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private FP m_remainingTime;

				// Token: 0x0400E9AD RID: 59821
				[Token(Token = "0x400E9AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_get_cardAnimOnPlay;

				// Token: 0x0400E9AE RID: 59822
				[Token(Token = "0x400E9AE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_set_cardAnimOnPlay;

				// Token: 0x0400E9AF RID: 59823
				[Token(Token = "0x400E9AF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_get_lifeType;

				// Token: 0x0400E9B0 RID: 59824
				[Token(Token = "0x400E9B0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_get_key;

				// Token: 0x0400E9B1 RID: 59825
				[Token(Token = "0x400E9B1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_get_stackKey;

				// Token: 0x0400E9B2 RID: 59826
				[Token(Token = "0x400E9B2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_get_sourceCardUid;

				// Token: 0x0400E9B3 RID: 59827
				[Token(Token = "0x400E9B3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_get_owner;

				// Token: 0x0400E9B4 RID: 59828
				[Token(Token = "0x400E9B4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x0400E9B5 RID: 59829
				[Token(Token = "0x400E9B5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private static DelegateBridge _c__Hotfix1_ctor;

				// Token: 0x0400E9B6 RID: 59830
				[Token(Token = "0x400E9B6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private static DelegateBridge _c__Hotfix2_ctor;

				// Token: 0x0400E9B7 RID: 59831
				[Token(Token = "0x400E9B7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private static DelegateBridge __Hotfix0_ApplyModifiersFirstPass;

				// Token: 0x0400E9B8 RID: 59832
				[Token(Token = "0x400E9B8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private static DelegateBridge __Hotfix0_ApplyModifiersSecondPass;

				// Token: 0x0400E9B9 RID: 59833
				[Token(Token = "0x400E9B9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private static DelegateBridge __Hotfix0_ApplyModifierFinalPass;

				// Token: 0x0400E9BA RID: 59834
				[Token(Token = "0x400E9BA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private static DelegateBridge __Hotfix0_SetRemainingTime;

				// Token: 0x0400E9BB RID: 59835
				[Token(Token = "0x400E9BB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private static DelegateBridge __Hotfix0_OnTick;

				// Token: 0x020021D6 RID: 8662
				[Token(Token = "0x20021D6")]
				public enum LifeType
				{
					// Token: 0x0400E9BD RID: 59837
					[Token(Token = "0x400E9BD")]
					UNTIL_NEXT_SPAWN,
					// Token: 0x0400E9BE RID: 59838
					[Token(Token = "0x400E9BE")]
					HOLD_BY_BUFF,
					// Token: 0x0400E9BF RID: 59839
					[Token(Token = "0x400E9BF")]
					ALL_THE_TIME,
					// Token: 0x0400E9C0 RID: 59840
					[Token(Token = "0x400E9C0")]
					UNTIL_NEXT_SPAWN_SYNC_WITH_BUFF,
					// Token: 0x0400E9C1 RID: 59841
					[Token(Token = "0x400E9C1")]
					IMMEDIATELY,
					// Token: 0x0400E9C2 RID: 59842
					[Token(Token = "0x400E9C2")]
					UNTIL_NEXT_SPAWN_DECK_TRIGGER_ONCE,
					// Token: 0x0400E9C3 RID: 59843
					[Token(Token = "0x400E9C3")]
					LIMITED
				}

				// Token: 0x020021D7 RID: 8663
				[Token(Token = "0x20021D7")]
				public enum ModifierType
				{
					// Token: 0x0400E9C5 RID: 59845
					[Token(Token = "0x400E9C5")]
					NONE,
					// Token: 0x0400E9C6 RID: 59846
					[Token(Token = "0x400E9C6")]
					RUNTIME_COST,
					// Token: 0x0400E9C7 RID: 59847
					[Token(Token = "0x400E9C7")]
					RUNTIME_RESPAWN_TIME,
					// Token: 0x0400E9C8 RID: 59848
					[Token(Token = "0x400E9C8")]
					REMAINING_RESPAWN_TIME,
					// Token: 0x0400E9C9 RID: 59849
					[Token(Token = "0x400E9C9")]
					MISC,
					// Token: 0x0400E9CA RID: 59850
					[Token(Token = "0x400E9CA")]
					APPEARANCE,
					// Token: 0x0400E9CB RID: 59851
					[Token(Token = "0x400E9CB")]
					E_NUM
				}

				// Token: 0x020021D8 RID: 8664
				[Token(Token = "0x20021D8")]
				public struct CardBuffOptions
				{
					// Token: 0x0400E9CC RID: 59852
					[Token(Token = "0x400E9CC")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
					public FP respawnTime;

					// Token: 0x0400E9CD RID: 59853
					[Token(Token = "0x400E9CD")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
					public bool respawnDisabled;

					// Token: 0x0400E9CE RID: 59854
					[Token(Token = "0x400E9CE")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public FP respawnTimeMaxMult;

					// Token: 0x0400E9CF RID: 59855
					[Token(Token = "0x400E9CF")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public int costDelta;

					// Token: 0x0400E9D0 RID: 59856
					[Token(Token = "0x400E9D0")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public FP rawCostScale;

					// Token: 0x0400E9D1 RID: 59857
					[Token(Token = "0x400E9D1")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
					public bool addRespawnCostMultCnt;

					// Token: 0x0400E9D2 RID: 59858
					[Token(Token = "0x400E9D2")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
					public bool dontOccupyDeployCnt;

					// Token: 0x0400E9D3 RID: 59859
					[Token(Token = "0x400E9D3")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
					public bool notValidToBuildByCardBuff;

					// Token: 0x0400E9D4 RID: 59860
					[Token(Token = "0x400E9D4")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
					public bool dontOccupyMaxDeployCnt;

					// Token: 0x0400E9D5 RID: 59861
					[Token(Token = "0x400E9D5")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
					public AdditionalBuildCondition additionalBuildCondition;

					// Token: 0x0400E9D6 RID: 59862
					[Token(Token = "0x400E9D6")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
					public FP remainingRespawnTime;

					// Token: 0x0400E9D7 RID: 59863
					[Token(Token = "0x400E9D7")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
					public BattleCharacterData appearanceData;

					// Token: 0x0400E9D8 RID: 59864
					[Token(Token = "0x400E9D8")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
					public bool ignoreRespawningState;

					// Token: 0x0400E9D9 RID: 59865
					[Token(Token = "0x400E9D9")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
					public bool respawnTimerStopped;

					// Token: 0x0400E9DA RID: 59866
					[Token(Token = "0x400E9DA")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
					public Deck.Card.AdvancedCardBuildState advancedCardBuildState;
				}
			}
		}

		// Token: 0x020021DD RID: 8669
		[Token(Token = "0x20021DD")]
		public class CharacterCard : Deck.Card
		{
			// Token: 0x17001AB5 RID: 6837
			// (get) Token: 0x0600D8EE RID: 55534 RVA: 0x0004EA50 File Offset: 0x0004CC50
			[Token(Token = "0x17001AB5")]
			public override bool isInfinity
			{
				[Token(Token = "0x600D8EE")]
				[Address(RVA = "0x35DB6F0", Offset = "0x35DA2F0", VA = "0x1835DB6F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001AB6 RID: 6838
			// (get) Token: 0x0600D8EF RID: 55535 RVA: 0x0004EA68 File Offset: 0x0004CC68
			[Token(Token = "0x17001AB6")]
			public override bool isFull
			{
				[Token(Token = "0x600D8EF")]
				[Address(RVA = "0x35DB690", Offset = "0x35DA290", VA = "0x1835DB690", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001AB7 RID: 6839
			// (get) Token: 0x0600D8F0 RID: 55536 RVA: 0x0004EA80 File Offset: 0x0004CC80
			[Token(Token = "0x17001AB7")]
			protected override int initialCnt
			{
				[Token(Token = "0x600D8F0")]
				[Address(RVA = "0x35DB630", Offset = "0x35DA230", VA = "0x1835DB630", Slot = "19")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001AB8 RID: 6840
			// (get) Token: 0x0600D8F1 RID: 55537 RVA: 0x0004EA98 File Offset: 0x0004CC98
			[Token(Token = "0x17001AB8")]
			public override Deck.Card.CardPolicy cardPolicy
			{
				[Token(Token = "0x600D8F1")]
				[Address(RVA = "0x35DB5D0", Offset = "0x35DA1D0", VA = "0x1835DB5D0", Slot = "11")]
				get
				{
					return Deck.Card.CardPolicy.DEFAULT;
				}
			}

			// Token: 0x0600D8F2 RID: 55538 RVA: 0x0004EAB0 File Offset: 0x0004CCB0
			[Token(Token = "0x600D8F2")]
			[Address(RVA = "0x35DB460", Offset = "0x35DA060", VA = "0x1835DB460", Slot = "21")]
			public override bool TouchPrefab(Action<Character> cb)
			{
				return default(bool);
			}

			// Token: 0x0600D8F3 RID: 55539 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D8F3")]
			[Address(RVA = "0x35DB380", Offset = "0x35D9F80", VA = "0x1835DB380", Slot = "28")]
			protected override Character SpawnInternal(SharedConsts.Direction direction, Tile tile, bool spawnManually, Deck.SpawnDetailsTracker spawnDetailsTracker)
			{
				return null;
			}

			// Token: 0x0600D8F4 RID: 55540 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D8F4")]
			[Address(RVA = "0x35DB280", Offset = "0x35D9E80", VA = "0x1835DB280", Slot = "22")]
			public override Character CreateDummy(AdditionalBuildCondition additionalBuildCondition, bool useOutline = false)
			{
				return null;
			}

			// Token: 0x0600D8F5 RID: 55541 RVA: 0x0004EAC8 File Offset: 0x0004CCC8
			[Token(Token = "0x600D8F5")]
			[Address(RVA = "0x35DB110", Offset = "0x35D9D10", VA = "0x1835DB110", Slot = "23")]
			public override bool CheckBuildable(Tile tile, bool checkHost, bool spawnManually, bool ignoreAdvancedBuildableMask = false)
			{
				return default(bool);
			}

			// Token: 0x0600D8F6 RID: 55542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D8F6")]
			[Address(RVA = "0x35DB540", Offset = "0x35DA140", VA = "0x1835DB540")]
			public CharacterCard(BattleCharacterData data, Deck deck)
			{
			}

			// Token: 0x0600D8F7 RID: 55543 RVA: 0x0004EAE0 File Offset: 0x0004CCE0
			[Token(Token = "0x600D8F7")]
			[Address(RVA = "0x35DB520", Offset = "0x35DA120", VA = "0x1835DB520")]
			private bool <>xLuaBaseProxy_CheckBuildable(Tile P0, bool P1, bool P2, bool P3)
			{
				return default(bool);
			}

			// Token: 0x0400E9E3 RID: 59875
			[Token(Token = "0x400E9E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isInfinity;

			// Token: 0x0400E9E4 RID: 59876
			[Token(Token = "0x400E9E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isFull;

			// Token: 0x0400E9E5 RID: 59877
			[Token(Token = "0x400E9E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_initialCnt;

			// Token: 0x0400E9E6 RID: 59878
			[Token(Token = "0x400E9E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_cardPolicy;

			// Token: 0x0400E9E7 RID: 59879
			[Token(Token = "0x400E9E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_TouchPrefab;

			// Token: 0x0400E9E8 RID: 59880
			[Token(Token = "0x400E9E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_SpawnInternal;

			// Token: 0x0400E9E9 RID: 59881
			[Token(Token = "0x400E9E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CreateDummy;

			// Token: 0x0400E9EA RID: 59882
			[Token(Token = "0x400E9EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_CheckBuildable;

			// Token: 0x0400E9EB RID: 59883
			[Token(Token = "0x400E9EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020021DE RID: 8670
		[Token(Token = "0x20021DE")]
		public class TokenCard : Deck.Card
		{
			// Token: 0x17001AB9 RID: 6841
			// (get) Token: 0x0600D8F8 RID: 55544 RVA: 0x0004EAF8 File Offset: 0x0004CCF8
			[Token(Token = "0x17001AB9")]
			public override Deck.Card.CardPolicy cardPolicy
			{
				[Token(Token = "0x600D8F8")]
				[Address(RVA = "0x35F08F0", Offset = "0x35EF4F0", VA = "0x1835F08F0", Slot = "11")]
				get
				{
					return Deck.Card.CardPolicy.DEFAULT;
				}
			}

			// Token: 0x17001ABA RID: 6842
			// (get) Token: 0x0600D8F9 RID: 55545 RVA: 0x0004EB10 File Offset: 0x0004CD10
			[Token(Token = "0x17001ABA")]
			public override bool isInfinity
			{
				[Token(Token = "0x600D8F9")]
				[Address(RVA = "0x35F0C80", Offset = "0x35EF880", VA = "0x1835F0C80", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001ABB RID: 6843
			// (get) Token: 0x0600D8FA RID: 55546 RVA: 0x0004EB28 File Offset: 0x0004CD28
			[Token(Token = "0x17001ABB")]
			public override bool ignoreExcludeFromBattle
			{
				[Token(Token = "0x600D8FA")]
				[Address(RVA = "0x35F0A20", Offset = "0x35EF620", VA = "0x1835F0A20", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001ABC RID: 6844
			// (get) Token: 0x0600D8FB RID: 55547 RVA: 0x0004EB40 File Offset: 0x0004CD40
			[Token(Token = "0x17001ABC")]
			public override bool notShowInDeck
			{
				[Token(Token = "0x600D8FB")]
				[Address(RVA = "0x35F0F00", Offset = "0x35EFB00", VA = "0x1835F0F00", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001ABD RID: 6845
			// (get) Token: 0x0600D8FC RID: 55548 RVA: 0x0004EB58 File Offset: 0x0004CD58
			[Token(Token = "0x17001ABD")]
			public override bool asRewardCardInLegionMode
			{
				[Token(Token = "0x600D8FC")]
				[Address(RVA = "0x35F0890", Offset = "0x35EF490", VA = "0x1835F0890", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001ABE RID: 6846
			// (get) Token: 0x0600D8FD RID: 55549 RVA: 0x0004EB70 File Offset: 0x0004CD70
			[Token(Token = "0x17001ABE")]
			public override bool isFull
			{
				[Token(Token = "0x600D8FD")]
				[Address(RVA = "0x35F0AF0", Offset = "0x35EF6F0", VA = "0x1835F0AF0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001ABF RID: 6847
			// (get) Token: 0x0600D8FE RID: 55550 RVA: 0x0004EB88 File Offset: 0x0004CD88
			[Token(Token = "0x17001ABF")]
			public override bool isHiddenByCardState
			{
				[Token(Token = "0x600D8FE")]
				[Address(RVA = "0x35F0C00", Offset = "0x35EF800", VA = "0x1835F0C00", Slot = "14")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001AC0 RID: 6848
			// (get) Token: 0x0600D8FF RID: 55551 RVA: 0x0004EBA0 File Offset: 0x0004CDA0
			[Token(Token = "0x17001AC0")]
			public override bool readyToSpawn
			{
				[Token(Token = "0x600D8FF")]
				[Address(RVA = "0x35F1090", Offset = "0x35EFC90", VA = "0x1835F1090", Slot = "16")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001AC1 RID: 6849
			// (get) Token: 0x0600D900 RID: 55552 RVA: 0x0004EBB8 File Offset: 0x0004CDB8
			[Token(Token = "0x17001AC1")]
			public override bool readyToSpawnWithoutCheckCost
			{
				[Token(Token = "0x600D900")]
				[Address(RVA = "0x35F0FD0", Offset = "0x35EFBD0", VA = "0x1835F0FD0", Slot = "17")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001AC2 RID: 6850
			// (get) Token: 0x0600D901 RID: 55553 RVA: 0x0004EBD0 File Offset: 0x0004CDD0
			[Token(Token = "0x17001AC2")]
			public override int cost
			{
				[Token(Token = "0x600D901")]
				[Address(RVA = "0x35F0950", Offset = "0x35EF550", VA = "0x1835F0950", Slot = "10")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001AC3 RID: 6851
			// (get) Token: 0x0600D902 RID: 55554 RVA: 0x0004EBE8 File Offset: 0x0004CDE8
			[Token(Token = "0x17001AC3")]
			public override int rawCost
			{
				[Token(Token = "0x600D902")]
				[Address(RVA = "0x35F0F70", Offset = "0x35EFB70", VA = "0x1835F0F70", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001AC4 RID: 6852
			// (get) Token: 0x0600D903 RID: 55555 RVA: 0x0004EC00 File Offset: 0x0004CE00
			[Token(Token = "0x17001AC4")]
			public override bool isMaxDeployed
			{
				[Token(Token = "0x600D903")]
				[Address(RVA = "0x35F0CE0", Offset = "0x35EF8E0", VA = "0x1835F0CE0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001AC5 RID: 6853
			// (get) Token: 0x0600D904 RID: 55556 RVA: 0x0004EC18 File Offset: 0x0004CE18
			[Token(Token = "0x17001AC5")]
			public bool hostIsAlive
			{
				[Token(Token = "0x600D904")]
				[Address(RVA = "0x35F09C0", Offset = "0x35EF5C0", VA = "0x1835F09C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001AC6 RID: 6854
			// (get) Token: 0x0600D905 RID: 55557 RVA: 0x0004EC30 File Offset: 0x0004CE30
			[Token(Token = "0x17001AC6")]
			protected override int initialCnt
			{
				[Token(Token = "0x600D905")]
				[Address(RVA = "0x35F0A80", Offset = "0x35EF680", VA = "0x1835F0A80", Slot = "19")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001AC7 RID: 6855
			// (get) Token: 0x0600D906 RID: 55558 RVA: 0x0004EC48 File Offset: 0x0004CE48
			// (set) Token: 0x0600D907 RID: 55559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001AC7")]
			private protected ObscuredInt maxDeployCnt
			{
				[Token(Token = "0x600D906")]
				[Address(RVA = "0x35F0E80", Offset = "0x35EFA80", VA = "0x1835F0E80")]
				[CompilerGenerated]
				protected get
				{
					return default(ObscuredInt);
				}
				[Token(Token = "0x600D907")]
				[Address(RVA = "0x35F11E0", Offset = "0x35EFDE0", VA = "0x1835F11E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001AC8 RID: 6856
			// (get) Token: 0x0600D908 RID: 55560 RVA: 0x0004EC60 File Offset: 0x0004CE60
			// (set) Token: 0x0600D909 RID: 55561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001AC8")]
			public ObscuredInt maxDeckStackCnt
			{
				[Token(Token = "0x600D908")]
				[Address(RVA = "0x35F0E00", Offset = "0x35EFA00", VA = "0x1835F0E00")]
				[CompilerGenerated]
				get
				{
					return default(ObscuredInt);
				}
				[Token(Token = "0x600D909")]
				[Address(RVA = "0x35F1150", Offset = "0x35EFD50", VA = "0x1835F1150")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600D90A RID: 55562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D90A")]
			[Address(RVA = "0x35F07E0", Offset = "0x35EF3E0", VA = "0x1835F07E0")]
			public TokenCard(BattleCharacterData data, Deck deck)
			{
			}

			// Token: 0x0600D90B RID: 55563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D90B")]
			[Address(RVA = "0x35EF4E0", Offset = "0x35EE0E0", VA = "0x1835EF4E0", Slot = "20")]
			public override void Init(IList<DeckModifier> deckModifiers)
			{
			}

			// Token: 0x0600D90C RID: 55564 RVA: 0x0004EC78 File Offset: 0x0004CE78
			[Token(Token = "0x600D90C")]
			[Address(RVA = "0x35F0610", Offset = "0x35EF210", VA = "0x1835F0610", Slot = "21")]
			public override bool TouchPrefab(Action<Character> cb)
			{
				return default(bool);
			}

			// Token: 0x0600D90D RID: 55565 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D90D")]
			[Address(RVA = "0x35F0530", Offset = "0x35EF130", VA = "0x1835F0530", Slot = "28")]
			protected override Character SpawnInternal(SharedConsts.Direction direction, Tile tile, bool spawnManually, Deck.SpawnDetailsTracker spawnDetailsTracker)
			{
				return null;
			}

			// Token: 0x0600D90E RID: 55566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D90E")]
			[Address(RVA = "0x35EEF10", Offset = "0x35EDB10", VA = "0x1835EEF10", Slot = "22")]
			public override Character CreateDummy(AdditionalBuildCondition additionalBuildCondition, bool useOutline = false)
			{
				return null;
			}

			// Token: 0x0600D90F RID: 55567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D90F")]
			[Address(RVA = "0x35EFFE0", Offset = "0x35EEBE0", VA = "0x1835EFFE0", Slot = "24")]
			public override void Recharge(int cnt, Deck.Card.RechargeTiming timing, bool refreshRemainingCnt = false)
			{
			}

			// Token: 0x0600D910 RID: 55568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D910")]
			[Address(RVA = "0x35EF080", Offset = "0x35EDC80", VA = "0x1835EF080")]
			public void ForceRecharge(int cnt, Deck.Card.RechargeTiming timing, bool refreshRemainingCnt = false)
			{
			}

			// Token: 0x0600D911 RID: 55569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D911")]
			[Address(RVA = "0x35F0260", Offset = "0x35EEE60", VA = "0x1835F0260")]
			public void RefreshTokenDeployAndDeckStackCnt(int maxDeployCntAddition, int maxDeployStackCntAddition)
			{
			}

			// Token: 0x0600D912 RID: 55570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D912")]
			[Address(RVA = "0x35EFDB0", Offset = "0x35EE9B0", VA = "0x1835EFDB0")]
			public void OnHostSpawned()
			{
			}

			// Token: 0x0600D913 RID: 55571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D913")]
			[Address(RVA = "0x35EFD50", Offset = "0x35EE950", VA = "0x1835EFD50")]
			public void OnHostRecycled()
			{
			}

			// Token: 0x0600D914 RID: 55572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D914")]
			[Address(RVA = "0x35EFF20", Offset = "0x35EEB20", VA = "0x1835EFF20", Slot = "26")]
			protected override void OnSpawned(Character inst, SharedConsts.Direction direction, GridPosition gridPos, bool spawnManually)
			{
			}

			// Token: 0x0600D915 RID: 55573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D915")]
			[Address(RVA = "0x35EFE10", Offset = "0x35EEA10", VA = "0x1835EFE10", Slot = "25")]
			public override void OnRecycle()
			{
			}

			// Token: 0x0600D916 RID: 55574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D916")]
			[Address(RVA = "0x35EFB30", Offset = "0x35EE730", VA = "0x1835EFB30", Slot = "27")]
			protected override void OnFetchDataFromPrefab(Character character)
			{
			}

			// Token: 0x0600D917 RID: 55575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D917")]
			[Address(RVA = "0x35EFE90", Offset = "0x35EEA90", VA = "0x1835EFE90", Slot = "29")]
			public override void OnReset()
			{
			}

			// Token: 0x0600D918 RID: 55576 RVA: 0x0004EC90 File Offset: 0x0004CE90
			[Token(Token = "0x600D918")]
			[Address(RVA = "0x35F0770", Offset = "0x35EF370", VA = "0x1835F0770")]
			private bool <>xLuaBaseProxy_get_ignoreExcludeFromBattle()
			{
				return default(bool);
			}

			// Token: 0x0600D919 RID: 55577 RVA: 0x0004ECA8 File Offset: 0x0004CEA8
			[Token(Token = "0x600D919")]
			[Address(RVA = "0x35F07A0", Offset = "0x35EF3A0", VA = "0x1835F07A0")]
			private bool <>xLuaBaseProxy_get_notShowInDeck()
			{
				return default(bool);
			}

			// Token: 0x0600D91A RID: 55578 RVA: 0x0004ECC0 File Offset: 0x0004CEC0
			[Token(Token = "0x600D91A")]
			[Address(RVA = "0x35F0750", Offset = "0x35EF350", VA = "0x1835F0750")]
			private bool <>xLuaBaseProxy_get_asRewardCardInLegionMode()
			{
				return default(bool);
			}

			// Token: 0x0600D91B RID: 55579 RVA: 0x0004ECD8 File Offset: 0x0004CED8
			[Token(Token = "0x600D91B")]
			[Address(RVA = "0x35F0780", Offset = "0x35EF380", VA = "0x1835F0780")]
			private bool <>xLuaBaseProxy_get_isHiddenByCardState()
			{
				return default(bool);
			}

			// Token: 0x0600D91C RID: 55580 RVA: 0x0004ECF0 File Offset: 0x0004CEF0
			[Token(Token = "0x600D91C")]
			[Address(RVA = "0x35F07D0", Offset = "0x35EF3D0", VA = "0x1835F07D0")]
			private bool <>xLuaBaseProxy_get_readyToSpawn()
			{
				return default(bool);
			}

			// Token: 0x0600D91D RID: 55581 RVA: 0x0004ED08 File Offset: 0x0004CF08
			[Token(Token = "0x600D91D")]
			[Address(RVA = "0x35F07C0", Offset = "0x35EF3C0", VA = "0x1835F07C0")]
			private bool <>xLuaBaseProxy_get_readyToSpawnWithoutCheckCost()
			{
				return default(bool);
			}

			// Token: 0x0600D91E RID: 55582 RVA: 0x0004ED20 File Offset: 0x0004CF20
			[Token(Token = "0x600D91E")]
			[Address(RVA = "0x35F0760", Offset = "0x35EF360", VA = "0x1835F0760")]
			private int <>xLuaBaseProxy_get_cost()
			{
				return 0;
			}

			// Token: 0x0600D91F RID: 55583 RVA: 0x0004ED38 File Offset: 0x0004CF38
			[Token(Token = "0x600D91F")]
			[Address(RVA = "0x35F07B0", Offset = "0x35EF3B0", VA = "0x1835F07B0")]
			private int <>xLuaBaseProxy_get_rawCost()
			{
				return 0;
			}

			// Token: 0x0600D920 RID: 55584 RVA: 0x0004ED50 File Offset: 0x0004CF50
			[Token(Token = "0x600D920")]
			[Address(RVA = "0x35F0790", Offset = "0x35EF390", VA = "0x1835F0790")]
			private bool <>xLuaBaseProxy_get_isMaxDeployed()
			{
				return default(bool);
			}

			// Token: 0x0600D921 RID: 55585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D921")]
			[Address(RVA = "0x35F06E0", Offset = "0x35EF2E0", VA = "0x1835F06E0")]
			private void <>xLuaBaseProxy_Init(IList<DeckModifier> P0)
			{
			}

			// Token: 0x0600D922 RID: 55586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D922")]
			[Address(RVA = "0x35F0740", Offset = "0x35EF340", VA = "0x1835F0740")]
			private void <>xLuaBaseProxy_Recharge(int P0, Deck.Card.RechargeTiming P1, bool P2)
			{
			}

			// Token: 0x0600D923 RID: 55587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D923")]
			[Address(RVA = "0x35F0720", Offset = "0x35EF320", VA = "0x1835F0720")]
			private void <>xLuaBaseProxy_OnSpawned(Character P0, SharedConsts.Direction P1, GridPosition P2, bool P3)
			{
			}

			// Token: 0x0600D924 RID: 55588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D924")]
			[Address(RVA = "0x35F0700", Offset = "0x35EF300", VA = "0x1835F0700")]
			private void <>xLuaBaseProxy_OnRecycle()
			{
			}

			// Token: 0x0600D925 RID: 55589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D925")]
			[Address(RVA = "0x35F06F0", Offset = "0x35EF2F0", VA = "0x1835F06F0")]
			private void <>xLuaBaseProxy_OnFetchDataFromPrefab(Character P0)
			{
			}

			// Token: 0x0600D926 RID: 55590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D926")]
			[Address(RVA = "0x35F0710", Offset = "0x35EF310", VA = "0x1835F0710")]
			private void <>xLuaBaseProxy_OnReset()
			{
			}

			// Token: 0x0400E9EC RID: 59884
			[Token(Token = "0x400E9EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Deck.Card.CardPolicy m_cardPolicy;

			// Token: 0x0400E9ED RID: 59885
			[Token(Token = "0x400E9ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private bool m_hostIsAlive;

			// Token: 0x0400E9EE RID: 59886
			[Token(Token = "0x400E9EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private int m_spawnedCnt;

			// Token: 0x0400E9EF RID: 59887
			[Token(Token = "0x400E9EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private bool m_rechargeOnlyOnce;

			// Token: 0x0400E9F0 RID: 59888
			[Token(Token = "0x400E9F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private int m_rechargeCnt;

			// Token: 0x0400E9F1 RID: 59889
			[Token(Token = "0x400E9F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private bool m_isInfinity;

			// Token: 0x0400E9F2 RID: 59890
			[Token(Token = "0x400E9F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
			private bool m_ignoreExcludeFromBattle;

			// Token: 0x0400E9F3 RID: 59891
			[Token(Token = "0x400E9F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
			private bool m_notShowInDeck;

			// Token: 0x0400E9F4 RID: 59892
			[Token(Token = "0x400E9F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
			private bool m_asRewardCardInLegionMode;

			// Token: 0x0400E9F5 RID: 59893
			[Token(Token = "0x400E9F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private bool m_isRallyPoint;

			// Token: 0x0400E9F8 RID: 59896
			[Token(Token = "0x400E9F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_cardPolicy;

			// Token: 0x0400E9F9 RID: 59897
			[Token(Token = "0x400E9F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isInfinity;

			// Token: 0x0400E9FA RID: 59898
			[Token(Token = "0x400E9FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_ignoreExcludeFromBattle;

			// Token: 0x0400E9FB RID: 59899
			[Token(Token = "0x400E9FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_notShowInDeck;

			// Token: 0x0400E9FC RID: 59900
			[Token(Token = "0x400E9FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_asRewardCardInLegionMode;

			// Token: 0x0400E9FD RID: 59901
			[Token(Token = "0x400E9FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_isFull;

			// Token: 0x0400E9FE RID: 59902
			[Token(Token = "0x400E9FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_isHiddenByCardState;

			// Token: 0x0400E9FF RID: 59903
			[Token(Token = "0x400E9FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_readyToSpawn;

			// Token: 0x0400EA00 RID: 59904
			[Token(Token = "0x400EA00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_readyToSpawnWithoutCheckCost;

			// Token: 0x0400EA01 RID: 59905
			[Token(Token = "0x400EA01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_cost;

			// Token: 0x0400EA02 RID: 59906
			[Token(Token = "0x400EA02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_rawCost;

			// Token: 0x0400EA03 RID: 59907
			[Token(Token = "0x400EA03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_isMaxDeployed;

			// Token: 0x0400EA04 RID: 59908
			[Token(Token = "0x400EA04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_hostIsAlive;

			// Token: 0x0400EA05 RID: 59909
			[Token(Token = "0x400EA05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_initialCnt;

			// Token: 0x0400EA06 RID: 59910
			[Token(Token = "0x400EA06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_maxDeployCnt;

			// Token: 0x0400EA07 RID: 59911
			[Token(Token = "0x400EA07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_set_maxDeployCnt;

			// Token: 0x0400EA08 RID: 59912
			[Token(Token = "0x400EA08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_maxDeckStackCnt;

			// Token: 0x0400EA09 RID: 59913
			[Token(Token = "0x400EA09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_set_maxDeckStackCnt;

			// Token: 0x0400EA0A RID: 59914
			[Token(Token = "0x400EA0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400EA0B RID: 59915
			[Token(Token = "0x400EA0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400EA0C RID: 59916
			[Token(Token = "0x400EA0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_TouchPrefab;

			// Token: 0x0400EA0D RID: 59917
			[Token(Token = "0x400EA0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_SpawnInternal;

			// Token: 0x0400EA0E RID: 59918
			[Token(Token = "0x400EA0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_CreateDummy;

			// Token: 0x0400EA0F RID: 59919
			[Token(Token = "0x400EA0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_Recharge;

			// Token: 0x0400EA10 RID: 59920
			[Token(Token = "0x400EA10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_ForceRecharge;

			// Token: 0x0400EA11 RID: 59921
			[Token(Token = "0x400EA11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_RefreshTokenDeployAndDeckStackCnt;

			// Token: 0x0400EA12 RID: 59922
			[Token(Token = "0x400EA12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_OnHostSpawned;

			// Token: 0x0400EA13 RID: 59923
			[Token(Token = "0x400EA13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_OnHostRecycled;

			// Token: 0x0400EA14 RID: 59924
			[Token(Token = "0x400EA14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_OnSpawned;

			// Token: 0x0400EA15 RID: 59925
			[Token(Token = "0x400EA15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_OnRecycle;

			// Token: 0x0400EA16 RID: 59926
			[Token(Token = "0x400EA16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_OnFetchDataFromPrefab;

			// Token: 0x0400EA17 RID: 59927
			[Token(Token = "0x400EA17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_OnReset;
		}

		// Token: 0x020021DF RID: 8671
		[Token(Token = "0x20021DF")]
		public class DeckRawCostOverrideManager : IHotfixable
		{
			// Token: 0x17001AC9 RID: 6857
			// (get) Token: 0x0600D927 RID: 55591 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001AC9")]
			public string deckRawCostOverriderKey
			{
				[Token(Token = "0x600D927")]
				[Address(RVA = "0x35E0CD0", Offset = "0x35DF8D0", VA = "0x1835E0CD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001ACA RID: 6858
			// (get) Token: 0x0600D928 RID: 55592 RVA: 0x0004ED68 File Offset: 0x0004CF68
			[Token(Token = "0x17001ACA")]
			public uint attachedFrame
			{
				[Token(Token = "0x600D928")]
				[Address(RVA = "0x35E0C70", Offset = "0x35DF870", VA = "0x1835E0C70")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x0600D929 RID: 55593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D929")]
			[Address(RVA = "0x35E07E0", Offset = "0x35DF3E0", VA = "0x1835E07E0")]
			public void Init(Deck deck)
			{
			}

			// Token: 0x0600D92A RID: 55594 RVA: 0x0004ED80 File Offset: 0x0004CF80
			[Token(Token = "0x600D92A")]
			[Address(RVA = "0x35E09E0", Offset = "0x35DF5E0", VA = "0x1835E09E0")]
			public bool TryGetOverrideRawCostData(uint cardUid, out int overrideCostData)
			{
				return default(bool);
			}

			// Token: 0x0600D92B RID: 55595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D92B")]
			[Address(RVA = "0x35E0910", Offset = "0x35DF510", VA = "0x1835E0910")]
			public void Reset()
			{
			}

			// Token: 0x0600D92C RID: 55596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D92C")]
			[Address(RVA = "0x35E0710", Offset = "0x35DF310", VA = "0x1835E0710")]
			public void Apply(string deckRawCostOverriderKey, Deck.DeckRawCostOverrideData deckRawCostOverrider)
			{
			}

			// Token: 0x0600D92D RID: 55597 RVA: 0x0004ED98 File Offset: 0x0004CF98
			[Token(Token = "0x600D92D")]
			[Address(RVA = "0x35E0860", Offset = "0x35DF460", VA = "0x1835E0860")]
			public bool RemoveRawCostOverriderDataByCardUid(uint cardUid)
			{
				return default(bool);
			}

			// Token: 0x0600D92E RID: 55598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D92E")]
			[Address(RVA = "0x35E0B60", Offset = "0x35DF760", VA = "0x1835E0B60")]
			public DeckRawCostOverrideManager()
			{
			}

			// Token: 0x0400EA18 RID: 59928
			[Token(Token = "0x400EA18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Deck m_deck;

			// Token: 0x0400EA19 RID: 59929
			[Token(Token = "0x400EA19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Deck.DeckRawCostOverrideData data;

			// Token: 0x0400EA1A RID: 59930
			[Token(Token = "0x400EA1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private string m_deckRawCostOverriderKey;

			// Token: 0x0400EA1B RID: 59931
			[Token(Token = "0x400EA1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private uint m_attachedFrame;

			// Token: 0x0400EA1C RID: 59932
			[Token(Token = "0x400EA1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_deckRawCostOverriderKey;

			// Token: 0x0400EA1D RID: 59933
			[Token(Token = "0x400EA1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_attachedFrame;

			// Token: 0x0400EA1E RID: 59934
			[Token(Token = "0x400EA1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400EA1F RID: 59935
			[Token(Token = "0x400EA1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_TryGetOverrideRawCostData;

			// Token: 0x0400EA20 RID: 59936
			[Token(Token = "0x400EA20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x0400EA21 RID: 59937
			[Token(Token = "0x400EA21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Apply;

			// Token: 0x0400EA22 RID: 59938
			[Token(Token = "0x400EA22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_RemoveRawCostOverriderDataByCardUid;

			// Token: 0x0400EA23 RID: 59939
			[Token(Token = "0x400EA23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020021E0 RID: 8672
		[Token(Token = "0x20021E0")]
		public class DeckRawCostOverrideData
		{
			// Token: 0x0600D92F RID: 55599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D92F")]
			[Address(RVA = "0x35E0630", Offset = "0x35DF230", VA = "0x1835E0630")]
			public void Reset()
			{
			}

			// Token: 0x0600D930 RID: 55600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D930")]
			[Address(RVA = "0x35E0680", Offset = "0x35DF280", VA = "0x1835E0680")]
			public DeckRawCostOverrideData()
			{
			}

			// Token: 0x0400EA24 RID: 59940
			[Token(Token = "0x400EA24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ListDict<uint, int> overrideCardUidSourceCost;

			// Token: 0x0400EA25 RID: 59941
			[Token(Token = "0x400EA25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int minCost;
		}

		// Token: 0x020021E1 RID: 8673
		[Token(Token = "0x20021E1")]
		public struct Options
		{
			// Token: 0x0400EA26 RID: 59942
			[Token(Token = "0x400EA26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string[] excludeCharIdList;
		}

		// Token: 0x020021E2 RID: 8674
		[Token(Token = "0x20021E2")]
		public class DeckManagedCardBuffController : IHotfixable
		{
			// Token: 0x0600D931 RID: 55601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D931")]
			[Address(RVA = "0x35E0070", Offset = "0x35DEC70", VA = "0x1835E0070")]
			public void RegisterCardBuff(Deck.Card card, Deck.Card.CardBuff cardBuff)
			{
			}

			// Token: 0x0600D932 RID: 55602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D932")]
			[Address(RVA = "0x35E01C0", Offset = "0x35DEDC0", VA = "0x1835E01C0")]
			public void RegisterComboDrawCardBuff(Deck.Card card, Deck.Card.CardBuff cardBuff, DeckSelector selector, bool excludeTokenAndTrap)
			{
			}

			// Token: 0x0600D933 RID: 55603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D933")]
			[Address(RVA = "0x35DFF20", Offset = "0x35DEB20", VA = "0x1835DFF20")]
			public void OnCardDrawn(Deck.Card card)
			{
			}

			// Token: 0x0600D934 RID: 55604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D934")]
			[Address(RVA = "0x35DFD80", Offset = "0x35DE980", VA = "0x1835DFD80")]
			public void Init()
			{
			}

			// Token: 0x0600D935 RID: 55605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D935")]
			[Address(RVA = "0x35E03B0", Offset = "0x35DEFB0", VA = "0x1835E03B0")]
			public DeckManagedCardBuffController()
			{
			}

			// Token: 0x0400EA27 RID: 59943
			[Token(Token = "0x400EA27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly List<Deck.DeckManagedCardBuffController.ManagedCardBuff> m_allTimeCardBuffs;

			// Token: 0x0400EA28 RID: 59944
			[Token(Token = "0x400EA28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly List<Deck.DeckManagedCardBuffController.ManagedComboDrawCardBuff> m_comboDrawCardBuffs;

			// Token: 0x0400EA29 RID: 59945
			[Token(Token = "0x400EA29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RegisterCardBuff;

			// Token: 0x0400EA2A RID: 59946
			[Token(Token = "0x400EA2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RegisterComboDrawCardBuff;

			// Token: 0x0400EA2B RID: 59947
			[Token(Token = "0x400EA2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnCardDrawn;

			// Token: 0x0400EA2C RID: 59948
			[Token(Token = "0x400EA2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400EA2D RID: 59949
			[Token(Token = "0x400EA2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020021E3 RID: 8675
			[Token(Token = "0x20021E3")]
			public enum ManageType
			{
				// Token: 0x0400EA2F RID: 59951
				[Token(Token = "0x400EA2F")]
				ALL_THE_TIME,
				// Token: 0x0400EA30 RID: 59952
				[Token(Token = "0x400EA30")]
				COMBO_DRAW
			}

			// Token: 0x020021E4 RID: 8676
			[Token(Token = "0x20021E4")]
			private class ManagedCardBuff : IHotfixable
			{
				// Token: 0x0600D936 RID: 55606 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D936")]
				[Address(RVA = "0x35E4700", Offset = "0x35E3300", VA = "0x1835E4700")]
				public void AddCardBuffToOwner()
				{
				}

				// Token: 0x0600D937 RID: 55607 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D937")]
				[Address(RVA = "0x35E4770", Offset = "0x35E3370", VA = "0x1835E4770")]
				public void RemoveCardBuffFromOwner()
				{
				}

				// Token: 0x0600D938 RID: 55608 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D938")]
				[Address(RVA = "0x35E47E0", Offset = "0x35E33E0", VA = "0x1835E47E0")]
				public ManagedCardBuff()
				{
				}

				// Token: 0x0400EA31 RID: 59953
				[Token(Token = "0x400EA31")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Deck.Card owner;

				// Token: 0x0400EA32 RID: 59954
				[Token(Token = "0x400EA32")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Deck.Card.CardBuff cardBuff;

				// Token: 0x0400EA33 RID: 59955
				[Token(Token = "0x400EA33")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_AddCardBuffToOwner;

				// Token: 0x0400EA34 RID: 59956
				[Token(Token = "0x400EA34")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_RemoveCardBuffFromOwner;

				// Token: 0x0400EA35 RID: 59957
				[Token(Token = "0x400EA35")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x020021E5 RID: 8677
			[Token(Token = "0x20021E5")]
			private class ManagedComboDrawCardBuff : Deck.DeckManagedCardBuffController.ManagedCardBuff
			{
				// Token: 0x0600D939 RID: 55609 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D939")]
				[Address(RVA = "0x35E4840", Offset = "0x35E3440", VA = "0x1835E4840")]
				public void OnCardDrawn(Deck.Card card)
				{
				}

				// Token: 0x0600D93A RID: 55610 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D93A")]
				[Address(RVA = "0x35E4A10", Offset = "0x35E3610", VA = "0x1835E4A10")]
				public ManagedComboDrawCardBuff()
				{
				}

				// Token: 0x0400EA36 RID: 59958
				[Token(Token = "0x400EA36")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public DeckSelector selector;

				// Token: 0x0400EA37 RID: 59959
				[Token(Token = "0x400EA37")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public bool excludeTokenAndTrap;

				// Token: 0x0400EA38 RID: 59960
				[Token(Token = "0x400EA38")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
				private bool m_isActive;

				// Token: 0x0400EA39 RID: 59961
				[Token(Token = "0x400EA39")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_OnCardDrawn;

				// Token: 0x0400EA3A RID: 59962
				[Token(Token = "0x400EA3A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}

		// Token: 0x020021E6 RID: 8678
		[Token(Token = "0x20021E6")]
		public class SpawnDetailsTracker : IHotfixable
		{
			// Token: 0x0600D93B RID: 55611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D93B")]
			[Address(RVA = "0x35EE350", Offset = "0x35ECF50", VA = "0x1835EE350")]
			public void Reset()
			{
			}

			// Token: 0x0600D93C RID: 55612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D93C")]
			[Address(RVA = "0x35EE3B0", Offset = "0x35ECFB0", VA = "0x1835EE3B0")]
			public SpawnDetailsTracker()
			{
			}

			// Token: 0x0400EA3B RID: 59963
			[Token(Token = "0x400EA3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isSpawnOperationSucceed;

			// Token: 0x0400EA3C RID: 59964
			[Token(Token = "0x400EA3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public Deck.SpawnDetailsTracker.OverlapLikeOperationDetail overlapLikeOperationDetail;

			// Token: 0x0400EA3D RID: 59965
			[Token(Token = "0x400EA3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x0400EA3E RID: 59966
			[Token(Token = "0x400EA3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020021E7 RID: 8679
			[Token(Token = "0x20021E7")]
			public struct OverlapLikeOperationDetail
			{
				// Token: 0x0400EA3F RID: 59967
				[Token(Token = "0x400EA3F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public bool isOverlapLikeOperation;

				// Token: 0x0400EA40 RID: 59968
				[Token(Token = "0x400EA40")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
				public bool ignoreRespawn;
			}
		}
	}
}
