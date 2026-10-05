using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022C9 RID: 8905
	[Token(Token = "0x20022C9")]
	public class Act41SideManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x0600E022 RID: 57378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C24")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E022")]
			[Address(RVA = "0x366B990", Offset = "0x366A590", VA = "0x18366B990", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E023 RID: 57379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E023")]
		[Address(RVA = "0x366A500", Offset = "0x3669100", VA = "0x18366A500", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600E024 RID: 57380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E024")]
		[Address(RVA = "0x366AE00", Offset = "0x3669A00", VA = "0x18366AE00")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E025 RID: 57381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E025")]
		[Address(RVA = "0x366B1E0", Offset = "0x3669DE0", VA = "0x18366B1E0")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E026 RID: 57382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E026")]
		[Address(RVA = "0x366A740", Offset = "0x3669340", VA = "0x18366A740", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E027 RID: 57383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E027")]
		[Address(RVA = "0x366A670", Offset = "0x3669270", VA = "0x18366A670")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600E028 RID: 57384 RVA: 0x00051648 File Offset: 0x0004F848
		[Token(Token = "0x600E028")]
		[Address(RVA = "0x366ABD0", Offset = "0x36697D0", VA = "0x18366ABD0")]
		private bool _IsValidCharacter(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600E029 RID: 57385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E029")]
		[Address(RVA = "0x366ACB0", Offset = "0x36698B0", VA = "0x18366ACB0")]
		private void _MarkDirty(object param)
		{
		}

		// Token: 0x0600E02A RID: 57386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E02A")]
		[Address(RVA = "0x366B4F0", Offset = "0x366A0F0", VA = "0x18366B4F0")]
		private void _TickModeChanges()
		{
		}

		// Token: 0x0600E02B RID: 57387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E02B")]
		[Address(RVA = "0x366B6F0", Offset = "0x366A2F0", VA = "0x18366B6F0")]
		public Act41SideManager()
		{
		}

		// Token: 0x0600E02C RID: 57388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E02C")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E02D RID: 57389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E02D")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E02E RID: 57390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E02E")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F40D RID: 62477
		[Token(Token = "0x400F40D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _inSight;

		// Token: 0x0400F40E RID: 62478
		[Token(Token = "0x400F40E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _outOfSight;

		// Token: 0x0400F40F RID: 62479
		[Token(Token = "0x400F40F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _tickFrameCnt;

		// Token: 0x0400F410 RID: 62480
		[Token(Token = "0x400F410")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TargetOptions _targetOptions;

		// Token: 0x0400F411 RID: 62481
		[Token(Token = "0x400F411")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string[] _specialAllowedTag;

		// Token: 0x0400F412 RID: 62482
		[Token(Token = "0x400F412")]
		[FieldOffset(Offset = "0xA8")]
		private ListDict<Character, int> m_unitModeIndexCache;

		// Token: 0x0400F413 RID: 62483
		[Token(Token = "0x400F413")]
		[FieldOffset(Offset = "0xB0")]
		private Act41SideManager.InRangeTilesManager m_tilesManager;

		// Token: 0x0400F414 RID: 62484
		[Token(Token = "0x400F414")]
		[FieldOffset(Offset = "0xB8")]
		private HashSet<Tile> m_cachedInRangeTiles;

		// Token: 0x0400F415 RID: 62485
		[Token(Token = "0x400F415")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F416 RID: 62486
		[Token(Token = "0x400F416")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F417 RID: 62487
		[Token(Token = "0x400F417")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F418 RID: 62488
		[Token(Token = "0x400F418")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400F419 RID: 62489
		[Token(Token = "0x400F419")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F41A RID: 62490
		[Token(Token = "0x400F41A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400F41B RID: 62491
		[Token(Token = "0x400F41B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsValidCharacter;

		// Token: 0x0400F41C RID: 62492
		[Token(Token = "0x400F41C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__MarkDirty;

		// Token: 0x0400F41D RID: 62493
		[Token(Token = "0x400F41D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TickModeChanges;

		// Token: 0x0400F41E RID: 62494
		[Token(Token = "0x400F41E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022CA RID: 8906
		[Token(Token = "0x20022CA")]
		private class InRangeTilesManager : IHotfixable
		{
			// Token: 0x17001C25 RID: 7205
			// (get) Token: 0x0600E02F RID: 57391 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001C25")]
			public HashSet<Tile> inViewTiles
			{
				[Token(Token = "0x600E02F")]
				[Address(RVA = "0x3677E60", Offset = "0x3676A60", VA = "0x183677E60")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600E030 RID: 57392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E030")]
			[Address(RVA = "0x3676C50", Offset = "0x3675850", VA = "0x183676C50")]
			public void Init(uint frameInterval)
			{
			}

			// Token: 0x0600E031 RID: 57393 RVA: 0x00051660 File Offset: 0x0004F860
			[Token(Token = "0x600E031")]
			[Address(RVA = "0x36771F0", Offset = "0x3675DF0", VA = "0x1836771F0")]
			public bool Tick()
			{
				return default(bool);
			}

			// Token: 0x0600E032 RID: 57394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E032")]
			[Address(RVA = "0x3676E80", Offset = "0x3675A80", VA = "0x183676E80")]
			public void OnCharacterBorn(ObjectPtr<Entity> entity)
			{
			}

			// Token: 0x0600E033 RID: 57395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E033")]
			[Address(RVA = "0x3677060", Offset = "0x3675C60", VA = "0x183677060")]
			public void OnCharacterFinish(ObjectPtr<Entity> entity)
			{
			}

			// Token: 0x0600E034 RID: 57396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E034")]
			[Address(RVA = "0x3676CE0", Offset = "0x36758E0", VA = "0x183676CE0")]
			public void MarkDirty(Entity entity)
			{
			}

			// Token: 0x0600E035 RID: 57397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E035")]
			[Address(RVA = "0x3677B40", Offset = "0x3676740", VA = "0x183677B40")]
			private void _EnsureList(Entity character)
			{
			}

			// Token: 0x0600E036 RID: 57398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E036")]
			[Address(RVA = "0x3677660", Offset = "0x3676260", VA = "0x183677660")]
			private void _AppendInRangeTile(Character character, HashSet<Tile> tiles)
			{
			}

			// Token: 0x0600E037 RID: 57399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E037")]
			[Address(RVA = "0x3677CF0", Offset = "0x36768F0", VA = "0x183677CF0")]
			public InRangeTilesManager()
			{
			}

			// Token: 0x0400F41F RID: 62495
			[Token(Token = "0x400F41F")]
			[FieldOffset(Offset = "0x0")]
			private static List<Tile> s_emptyList;

			// Token: 0x0400F420 RID: 62496
			[Token(Token = "0x400F420")]
			[FieldOffset(Offset = "0x10")]
			private uint m_updatedInterval;

			// Token: 0x0400F421 RID: 62497
			[Token(Token = "0x400F421")]
			[FieldOffset(Offset = "0x14")]
			private uint m_lastUpdatedFrame;

			// Token: 0x0400F422 RID: 62498
			[Token(Token = "0x400F422")]
			[FieldOffset(Offset = "0x18")]
			private HashSet<ObjectPtr<Entity>> m_dirtyCharacter;

			// Token: 0x0400F423 RID: 62499
			[Token(Token = "0x400F423")]
			[FieldOffset(Offset = "0x20")]
			private ListDict<Entity, HashSet<Tile>> m_tileInUnitViewRangeBefore;

			// Token: 0x0400F424 RID: 62500
			[Token(Token = "0x400F424")]
			[FieldOffset(Offset = "0x28")]
			private HashSet<Tile> m_inViewTiles;

			// Token: 0x0400F425 RID: 62501
			[Token(Token = "0x400F425")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_inViewTiles;

			// Token: 0x0400F426 RID: 62502
			[Token(Token = "0x400F426")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400F427 RID: 62503
			[Token(Token = "0x400F427")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Tick;

			// Token: 0x0400F428 RID: 62504
			[Token(Token = "0x400F428")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnCharacterBorn;

			// Token: 0x0400F429 RID: 62505
			[Token(Token = "0x400F429")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnCharacterFinish;

			// Token: 0x0400F42A RID: 62506
			[Token(Token = "0x400F42A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_MarkDirty;

			// Token: 0x0400F42B RID: 62507
			[Token(Token = "0x400F42B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__EnsureList;

			// Token: 0x0400F42C RID: 62508
			[Token(Token = "0x400F42C")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__AppendInRangeTile;

			// Token: 0x0400F42D RID: 62509
			[Token(Token = "0x400F42D")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
