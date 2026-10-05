using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using Torappu.Battle.Effects;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200275C RID: 10076
	[Token(Token = "0x200275C")]
	public class AutoChessDummyManager : AutoChessDataCenter.AutoChessDataModelBase, IHotfixable
	{
		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x060106B7 RID: 67255 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060106B8 RID: 67256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170023E2")]
		public Character activeCharacter
		{
			[Token(Token = "0x60106B7")]
			[Address(RVA = "0x82A840", Offset = "0x829440", VA = "0x18082A840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60106B8")]
			[Address(RVA = "0x82A920", Offset = "0x829520", VA = "0x18082A920")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060106B9 RID: 67257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106B9")]
		[Address(RVA = "0x82A690", Offset = "0x829290", VA = "0x18082A690")]
		public AutoChessDummyManager()
		{
		}

		// Token: 0x060106BA RID: 67258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106BA")]
		[Address(RVA = "0x8279C0", Offset = "0x8265C0", VA = "0x1808279C0")]
		public void OnTick()
		{
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x060106BB RID: 67259 RVA: 0x00064140 File Offset: 0x00062340
		[Token(Token = "0x170023E3")]
		public bool isAsyncBuildDone
		{
			[Token(Token = "0x60106BB")]
			[Address(RVA = "0x82A8A0", Offset = "0x8294A0", VA = "0x18082A8A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060106BC RID: 67260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106BC")]
		[Address(RVA = "0x829670", Offset = "0x828270", VA = "0x180829670")]
		private void _InitEffectContiner()
		{
		}

		// Token: 0x060106BD RID: 67261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106BD")]
		[Address(RVA = "0x825D70", Offset = "0x824970", VA = "0x180825D70")]
		public void ClearBuildQueue()
		{
		}

		// Token: 0x060106BE RID: 67262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60106BE")]
		[Address(RVA = "0x826D80", Offset = "0x825980", VA = "0x180826D80")]
		public Character GetCharacter(Tile tile)
		{
			return null;
		}

		// Token: 0x060106BF RID: 67263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60106BF")]
		[Address(RVA = "0x826C90", Offset = "0x825890", VA = "0x180826C90")]
		public Character GetCharacter(GridPosition pos)
		{
			return null;
		}

		// Token: 0x060106C0 RID: 67264 RVA: 0x00064158 File Offset: 0x00062358
		[Token(Token = "0x60106C0")]
		[Address(RVA = "0x825DF0", Offset = "0x8249F0", VA = "0x180825DF0")]
		public bool ContainsKey(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060106C1 RID: 67265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60106C1")]
		[Address(RVA = "0x8271F0", Offset = "0x825DF0", VA = "0x1808271F0")]
		public Tile GetTile(Character character)
		{
			return null;
		}

		// Token: 0x060106C2 RID: 67266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60106C2")]
		[Address(RVA = "0x826FE0", Offset = "0x825BE0", VA = "0x180826FE0")]
		public Tile GetTile(int targetInstId)
		{
			return null;
		}

		// Token: 0x060106C3 RID: 67267 RVA: 0x00064170 File Offset: 0x00062370
		[Token(Token = "0x60106C3")]
		[Address(RVA = "0x825AA0", Offset = "0x8246A0", VA = "0x180825AA0")]
		public bool Add(Tile tile, Character character)
		{
			return default(bool);
		}

		// Token: 0x060106C4 RID: 67268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106C4")]
		[Address(RVA = "0x827CE0", Offset = "0x8268E0", VA = "0x180827CE0")]
		public void RemoveUnhandledDummy()
		{
		}

		// Token: 0x060106C5 RID: 67269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106C5")]
		[Address(RVA = "0x827E90", Offset = "0x826A90", VA = "0x180827E90")]
		public void Remove(Tile tile)
		{
		}

		// Token: 0x060106C6 RID: 67270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106C6")]
		[Address(RVA = "0x82A310", Offset = "0x828F10", VA = "0x18082A310")]
		private void _RefreshDeployStatus()
		{
		}

		// Token: 0x060106C7 RID: 67271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106C7")]
		[Address(RVA = "0x828390", Offset = "0x826F90", VA = "0x180828390")]
		public void SetCharacter(Tile tile, Character character, SharedConsts.Direction dir)
		{
		}

		// Token: 0x060106C8 RID: 67272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106C8")]
		[Address(RVA = "0x829900", Offset = "0x828500", VA = "0x180829900")]
		private void _OnCharacterPlaced(Character character, SharedConsts.Direction dir, Tile tile)
		{
		}

		// Token: 0x060106C9 RID: 67273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106C9")]
		[Address(RVA = "0x829E40", Offset = "0x828A40", VA = "0x180829E40")]
		private void _PlayAudioWhenCharacterPlaced(Character character, bool placeToBattle, bool placeToHand)
		{
		}

		// Token: 0x060106CA RID: 67274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106CA")]
		[Address(RVA = "0x828090", Offset = "0x826C90", VA = "0x180828090")]
		public void SetCharacterDirection(Tile tile, Character character, SharedConsts.Direction dir)
		{
		}

		// Token: 0x060106CB RID: 67275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60106CB")]
		[Address(RVA = "0x82A230", Offset = "0x828E30", VA = "0x18082A230")]
		private IEnumerator _PlayIdleAfterBorn(Character character, AutoChessDataCenter center, FP time)
		{
			return null;
		}

		// Token: 0x060106CC RID: 67276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60106CC")]
		[Address(RVA = "0x827410", Offset = "0x826010", VA = "0x180827410")]
		public Character MarkLeaving(Tile tile)
		{
			return null;
		}

		// Token: 0x060106CD RID: 67277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106CD")]
		[Address(RVA = "0x8276F0", Offset = "0x8262F0", VA = "0x1808276F0")]
		public void MarkReturned(Character character, Tile tile)
		{
		}

		// Token: 0x060106CE RID: 67278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106CE")]
		[Address(RVA = "0x8260C0", Offset = "0x824CC0", VA = "0x1808260C0")]
		public void CreateDummyOnTile(ChessInst chessInst, Tile tile)
		{
		}

		// Token: 0x060106CF RID: 67279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106CF")]
		[Address(RVA = "0x8262D0", Offset = "0x824ED0", VA = "0x1808262D0")]
		public void CreateDummyOnTile(AutoChessUnitQuery query, SharedConsts.Direction direction, Tile tile)
		{
		}

		// Token: 0x060106D0 RID: 67280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106D0")]
		[Address(RVA = "0x829200", Offset = "0x827E00", VA = "0x180829200")]
		private void _DoCreateOnTile(AutoChessUnitQuery query, SharedConsts.Direction dir, Tile tile)
		{
		}

		// Token: 0x060106D1 RID: 67281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60106D1")]
		[Address(RVA = "0x826450", Offset = "0x825050", VA = "0x180826450")]
		public Character CreateDummy(AutoChessUnitQuery query)
		{
			return null;
		}

		// Token: 0x060106D2 RID: 67282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106D2")]
		[Address(RVA = "0x827C10", Offset = "0x826810", VA = "0x180827C10")]
		public void RefreshDummyEffect(Character character, int instId, bool isToken)
		{
		}

		// Token: 0x060106D3 RID: 67283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60106D3")]
		[Address(RVA = "0x825FD0", Offset = "0x824BD0", VA = "0x180825FD0")]
		public Character CreateDeadLikeDummy(BattleCharacterData characterData, Tile tile, SharedConsts.Direction dir)
		{
			return null;
		}

		// Token: 0x060106D4 RID: 67284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106D4")]
		[Address(RVA = "0x8293A0", Offset = "0x827FA0", VA = "0x1808293A0")]
		private void _DoDefaultAnimIfNeed(AutoChessBattleMiscConfig config, Character character)
		{
		}

		// Token: 0x060106D5 RID: 67285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106D5")]
		[Address(RVA = "0x82A5B0", Offset = "0x8291B0", VA = "0x18082A5B0")]
		private void _SwitchToFirstModeIfNeed(AutoChessBattleMiscConfig config, Character character)
		{
		}

		// Token: 0x060106D6 RID: 67286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106D6")]
		[Address(RVA = "0x828F90", Offset = "0x827B90", VA = "0x180828F90")]
		private void _CreateIdleEffectIfNeed(AutoChessBattleMiscConfig config, Character character)
		{
		}

		// Token: 0x060106D7 RID: 67287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106D7")]
		[Address(RVA = "0x828D00", Offset = "0x827900", VA = "0x180828D00")]
		private void _CreateGoldEffectIfNeed(AutoChessBattleMiscConfig config, AutoChessUnitQuery query, Character character)
		{
		}

		// Token: 0x060106D8 RID: 67288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106D8")]
		[Address(RVA = "0x828980", Offset = "0x827580", VA = "0x180828980")]
		private void _CreateEquipComboEffectIfNeed(AutoChessBattleMiscConfig config, int instId, Character character, bool isToken)
		{
		}

		// Token: 0x060106D9 RID: 67289 RVA: 0x00064188 File Offset: 0x00062388
		[Token(Token = "0x60106D9")]
		[Address(RVA = "0x8284A0", Offset = "0x8270A0", VA = "0x1808284A0")]
		private bool _CheckEquipCombo(List<int> equipInstIds)
		{
			return default(bool);
		}

		// Token: 0x060106DA RID: 67290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60106DA")]
		[Address(RVA = "0x8287D0", Offset = "0x8273D0", VA = "0x1808287D0")]
		private Character _CreateDummyChess(AutoChessUnitQuery query)
		{
			return null;
		}

		// Token: 0x060106DB RID: 67291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60106DB")]
		[Address(RVA = "0x8269F0", Offset = "0x8255F0", VA = "0x1808269F0")]
		public IEnumerator FinishAllDummy(float finishTiming)
		{
			return null;
		}

		// Token: 0x060106DC RID: 67292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106DC")]
		[Address(RVA = "0x8266D0", Offset = "0x8252D0", VA = "0x1808266D0")]
		public void FinishAllDummyImmediately()
		{
		}

		// Token: 0x060106DD RID: 67293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106DD")]
		[Address(RVA = "0x826AC0", Offset = "0x8256C0", VA = "0x180826AC0")]
		public void FinishDummyByTile(Tile tile)
		{
		}

		// Token: 0x060106DE RID: 67294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106DE")]
		[Address(RVA = "0x826B70", Offset = "0x825770", VA = "0x180826B70")]
		public void FinishDummy(Character character)
		{
		}

		// Token: 0x060106DF RID: 67295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60106DF")]
		[Address(RVA = "0x8294D0", Offset = "0x8280D0", VA = "0x1808294D0")]
		private void _FinishEffectByEffectGroup(string group, Character character)
		{
		}

		// Token: 0x0401260F RID: 75279
		[Token(Token = "0x401260F")]
		private const int CHAR_INST_ID_OFFSET = 10000;

		// Token: 0x04012610 RID: 75280
		[Token(Token = "0x4012610")]
		private const int TOKEN_INST_ID_OFFSET = 20000;

		// Token: 0x04012611 RID: 75281
		[Token(Token = "0x4012611")]
		private const int TRAP_INST_ID_OFFSET = 30000;

		// Token: 0x04012613 RID: 75283
		[Token(Token = "0x4012613")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, AutoChessDummyManager.CharacterEffectContainer> m_effectContainer;

		// Token: 0x04012614 RID: 75284
		[Token(Token = "0x4012614")]
		[FieldOffset(Offset = "0x28")]
		private List<AutoChessDummyManager.DummyCharacterWrapper> m_dummyCharacters;

		// Token: 0x04012615 RID: 75285
		[Token(Token = "0x4012615")]
		[FieldOffset(Offset = "0x30")]
		private List<Tile> m_tileNeedRemove;

		// Token: 0x04012616 RID: 75286
		[Token(Token = "0x4012616")]
		[FieldOffset(Offset = "0x38")]
		private Queue<AutoChessDummyManager.DummyCreateAction> m_createDummyQueue;

		// Token: 0x04012617 RID: 75287
		[Token(Token = "0x4012617")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activeCharacter;

		// Token: 0x04012618 RID: 75288
		[Token(Token = "0x4012618")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activeCharacter;

		// Token: 0x04012619 RID: 75289
		[Token(Token = "0x4012619")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401261A RID: 75290
		[Token(Token = "0x401261A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401261B RID: 75291
		[Token(Token = "0x401261B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isAsyncBuildDone;

		// Token: 0x0401261C RID: 75292
		[Token(Token = "0x401261C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitEffectContiner;

		// Token: 0x0401261D RID: 75293
		[Token(Token = "0x401261D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClearBuildQueue;

		// Token: 0x0401261E RID: 75294
		[Token(Token = "0x401261E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCharacter;

		// Token: 0x0401261F RID: 75295
		[Token(Token = "0x401261F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_GetCharacter;

		// Token: 0x04012620 RID: 75296
		[Token(Token = "0x4012620")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ContainsKey;

		// Token: 0x04012621 RID: 75297
		[Token(Token = "0x4012621")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetTile;

		// Token: 0x04012622 RID: 75298
		[Token(Token = "0x4012622")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix1_GetTile;

		// Token: 0x04012623 RID: 75299
		[Token(Token = "0x4012623")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Add;

		// Token: 0x04012624 RID: 75300
		[Token(Token = "0x4012624")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RemoveUnhandledDummy;

		// Token: 0x04012625 RID: 75301
		[Token(Token = "0x4012625")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Remove;

		// Token: 0x04012626 RID: 75302
		[Token(Token = "0x4012626")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RefreshDeployStatus;

		// Token: 0x04012627 RID: 75303
		[Token(Token = "0x4012627")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SetCharacter;

		// Token: 0x04012628 RID: 75304
		[Token(Token = "0x4012628")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnCharacterPlaced;

		// Token: 0x04012629 RID: 75305
		[Token(Token = "0x4012629")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PlayAudioWhenCharacterPlaced;

		// Token: 0x0401262A RID: 75306
		[Token(Token = "0x401262A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SetCharacterDirection;

		// Token: 0x0401262B RID: 75307
		[Token(Token = "0x401262B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__PlayIdleAfterBorn;

		// Token: 0x0401262C RID: 75308
		[Token(Token = "0x401262C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_MarkLeaving;

		// Token: 0x0401262D RID: 75309
		[Token(Token = "0x401262D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_MarkReturned;

		// Token: 0x0401262E RID: 75310
		[Token(Token = "0x401262E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CreateDummyOnTile;

		// Token: 0x0401262F RID: 75311
		[Token(Token = "0x401262F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix1_CreateDummyOnTile;

		// Token: 0x04012630 RID: 75312
		[Token(Token = "0x4012630")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__DoCreateOnTile;

		// Token: 0x04012631 RID: 75313
		[Token(Token = "0x4012631")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CreateDummy;

		// Token: 0x04012632 RID: 75314
		[Token(Token = "0x4012632")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_RefreshDummyEffect;

		// Token: 0x04012633 RID: 75315
		[Token(Token = "0x4012633")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_CreateDeadLikeDummy;

		// Token: 0x04012634 RID: 75316
		[Token(Token = "0x4012634")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__DoDefaultAnimIfNeed;

		// Token: 0x04012635 RID: 75317
		[Token(Token = "0x4012635")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__SwitchToFirstModeIfNeed;

		// Token: 0x04012636 RID: 75318
		[Token(Token = "0x4012636")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__CreateIdleEffectIfNeed;

		// Token: 0x04012637 RID: 75319
		[Token(Token = "0x4012637")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__CreateGoldEffectIfNeed;

		// Token: 0x04012638 RID: 75320
		[Token(Token = "0x4012638")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__CreateEquipComboEffectIfNeed;

		// Token: 0x04012639 RID: 75321
		[Token(Token = "0x4012639")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__CheckEquipCombo;

		// Token: 0x0401263A RID: 75322
		[Token(Token = "0x401263A")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__CreateDummyChess;

		// Token: 0x0401263B RID: 75323
		[Token(Token = "0x401263B")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_FinishAllDummy;

		// Token: 0x0401263C RID: 75324
		[Token(Token = "0x401263C")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_FinishAllDummyImmediately;

		// Token: 0x0401263D RID: 75325
		[Token(Token = "0x401263D")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_FinishDummyByTile;

		// Token: 0x0401263E RID: 75326
		[Token(Token = "0x401263E")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_FinishDummy;

		// Token: 0x0401263F RID: 75327
		[Token(Token = "0x401263F")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__FinishEffectByEffectGroup;

		// Token: 0x0200275D RID: 10077
		[Token(Token = "0x200275D")]
		private class CharacterEffectContainer
		{
			// Token: 0x060106E0 RID: 67296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60106E0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharacterEffectContainer()
			{
			}

			// Token: 0x04012640 RID: 75328
			[Token(Token = "0x4012640")]
			public const string GOLDEN_EFFECT_GROUP = "GOLDEN_EFFECT_GROUP";

			// Token: 0x04012641 RID: 75329
			[Token(Token = "0x4012641")]
			public const string IDLE_EFFECT_GROUP = "IDLE_EFFECT_GROUP";

			// Token: 0x04012642 RID: 75330
			[Token(Token = "0x4012642")]
			public const string EQUIP_COMMON_EFFECT_GROUP = "EQUIP_COMMON_EFFECT_GROUP";

			// Token: 0x04012643 RID: 75331
			[Token(Token = "0x4012643")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x04012644 RID: 75332
			[Token(Token = "0x4012644")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<ObjectPtr<Character>, ObjectPtr<Effect>> effect;
		}

		// Token: 0x0200275E RID: 10078
		[Token(Token = "0x200275E")]
		private class DummyCreateAction : IHotfixable
		{
			// Token: 0x060106E1 RID: 67297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60106E1")]
			[Address(RVA = "0x839590", Offset = "0x838190", VA = "0x180839590")]
			public DummyCreateAction()
			{
			}

			// Token: 0x04012645 RID: 75333
			[Token(Token = "0x4012645")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessUnitQuery query;

			// Token: 0x04012646 RID: 75334
			[Token(Token = "0x4012646")]
			[FieldOffset(Offset = "0x28")]
			public Tile targetTile;

			// Token: 0x04012647 RID: 75335
			[Token(Token = "0x4012647")]
			[FieldOffset(Offset = "0x30")]
			public SharedConsts.Direction dir;

			// Token: 0x04012648 RID: 75336
			[Token(Token = "0x4012648")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200275F RID: 10079
		[Token(Token = "0x200275F")]
		private class DummyCharacterWrapper
		{
			// Token: 0x060106E2 RID: 67298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60106E2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DummyCharacterWrapper()
			{
			}

			// Token: 0x04012649 RID: 75337
			[Token(Token = "0x4012649")]
			[FieldOffset(Offset = "0x10")]
			public ObjectPtr<Character> character;

			// Token: 0x0401264A RID: 75338
			[Token(Token = "0x401264A")]
			[FieldOffset(Offset = "0x20")]
			public GridPosition pos;

			// Token: 0x0401264B RID: 75339
			[Token(Token = "0x401264B")]
			[FieldOffset(Offset = "0x28")]
			public bool isLeaving;
		}
	}
}
