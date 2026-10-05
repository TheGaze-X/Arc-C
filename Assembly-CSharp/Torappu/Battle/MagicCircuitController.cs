using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002259 RID: 8793
	[Token(Token = "0x2002259")]
	public class MagicCircuitController : MapController
	{
		// Token: 0x0600DCDF RID: 56543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCDF")]
		[Address(RVA = "0x3626440", Offset = "0x3625040", VA = "0x183626440")]
		private void OnTileEnterRoute(Tile tile, SharedConsts.Direction dir)
		{
		}

		// Token: 0x0600DCE0 RID: 56544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCE0")]
		[Address(RVA = "0x3626920", Offset = "0x3625520", VA = "0x183626920")]
		private void OnTileLeaveRoute(Tile tile, SharedConsts.Direction dir)
		{
		}

		// Token: 0x0600DCE1 RID: 56545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCE1")]
		[Address(RVA = "0x3625960", Offset = "0x3624560", VA = "0x183625960")]
		public void OnCharacterEnterRoute(Character character)
		{
		}

		// Token: 0x0600DCE2 RID: 56546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCE2")]
		[Address(RVA = "0x3625B00", Offset = "0x3624700", VA = "0x183625B00")]
		public void OnCharacterLeaveRoute(Character character)
		{
		}

		// Token: 0x0600DCE3 RID: 56547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCE3")]
		[Address(RVA = "0x3625CA0", Offset = "0x36248A0", VA = "0x183625CA0")]
		private void OnEnemyEnterRoute(Enemy enemy)
		{
		}

		// Token: 0x0600DCE4 RID: 56548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCE4")]
		[Address(RVA = "0x3625E40", Offset = "0x3624A40", VA = "0x183625E40")]
		private void OnEnemyLeaveRoute(Enemy enemy)
		{
		}

		// Token: 0x0600DCE5 RID: 56549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCE5")]
		[Address(RVA = "0x3626320", Offset = "0x3624F20", VA = "0x183626320")]
		private void OnReallyTileEnterRoute(MagicCircuitController.MagicCircuitTile tile)
		{
		}

		// Token: 0x0600DCE6 RID: 56550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCE6")]
		[Address(RVA = "0x36263B0", Offset = "0x3624FB0", VA = "0x1836263B0")]
		private void OnReallyTileLeaveRoute(MagicCircuitController.MagicCircuitTile tile)
		{
		}

		// Token: 0x0600DCE7 RID: 56551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCE7")]
		[Address(RVA = "0x3625FE0", Offset = "0x3624BE0", VA = "0x183625FE0")]
		private void OnReallyCharacterEnterRoute(ObjectPtr<Character> character)
		{
		}

		// Token: 0x0600DCE8 RID: 56552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCE8")]
		[Address(RVA = "0x36260B0", Offset = "0x3624CB0", VA = "0x1836260B0")]
		private void OnReallyCharacterLeaveRoute(ObjectPtr<Character> character)
		{
		}

		// Token: 0x0600DCE9 RID: 56553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCE9")]
		[Address(RVA = "0x3626180", Offset = "0x3624D80", VA = "0x183626180")]
		private void OnReallyEnemyEnterRoute(ObjectPtr<Enemy> enemy)
		{
		}

		// Token: 0x0600DCEA RID: 56554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCEA")]
		[Address(RVA = "0x3626250", Offset = "0x3624E50", VA = "0x183626250")]
		private void OnReallyEnemyLeaveRoute(ObjectPtr<Enemy> enemy)
		{
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x0600DCEB RID: 56555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BD1")]
		public MagicCircuitController.MagicCircuitTiles2D magicTiles
		{
			[Token(Token = "0x600DCEB")]
			[Address(RVA = "0x36293D0", Offset = "0x3627FD0", VA = "0x1836293D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DCEC RID: 56556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCEC")]
		[Address(RVA = "0x3628F60", Offset = "0x3627B60", VA = "0x183628F60")]
		public MagicCircuitController()
		{
		}

		// Token: 0x0600DCED RID: 56557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCED")]
		[Address(RVA = "0x3625560", Offset = "0x3624160", VA = "0x183625560", Slot = "5")]
		public override void Init(Map map)
		{
		}

		// Token: 0x0600DCEE RID: 56558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCEE")]
		[Address(RVA = "0x3625470", Offset = "0x3624070", VA = "0x183625470")]
		public void InitParams()
		{
		}

		// Token: 0x0600DCEF RID: 56559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCEF")]
		[Address(RVA = "0x3627860", Offset = "0x3626460", VA = "0x183627860", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x0600DCF0 RID: 56560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCF0")]
		[Address(RVA = "0x3628DB0", Offset = "0x36279B0", VA = "0x183628DB0")]
		private void _StartTileCheckInRoute()
		{
		}

		// Token: 0x0600DCF1 RID: 56561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCF1")]
		[Address(RVA = "0x3628A50", Offset = "0x3627650", VA = "0x183628A50")]
		private void _StartCharacterCheckInRoute()
		{
		}

		// Token: 0x0600DCF2 RID: 56562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCF2")]
		[Address(RVA = "0x3628C00", Offset = "0x3627800", VA = "0x183628C00")]
		private void _StartEnemyCheckInRoute()
		{
		}

		// Token: 0x0600DCF3 RID: 56563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DCF3")]
		[Address(RVA = "0x36283C0", Offset = "0x3626FC0", VA = "0x1836283C0")]
		private IEnumerator _CkeckTileInRoute()
		{
			return null;
		}

		// Token: 0x0600DCF4 RID: 56564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DCF4")]
		[Address(RVA = "0x3628260", Offset = "0x3626E60", VA = "0x183628260")]
		private IEnumerator _CkeckCharacterInRoute()
		{
			return null;
		}

		// Token: 0x0600DCF5 RID: 56565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DCF5")]
		[Address(RVA = "0x3628310", Offset = "0x3626F10", VA = "0x183628310")]
		private IEnumerator _CkeckEnemyInRoute()
		{
			return null;
		}

		// Token: 0x0600DCF6 RID: 56566 RVA: 0x00050A90 File Offset: 0x0004EC90
		[Token(Token = "0x600DCF6")]
		[Address(RVA = "0x36257B0", Offset = "0x36243B0", VA = "0x1836257B0")]
		public bool IsMagicCiruitAffect(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600DCF7 RID: 56567 RVA: 0x00050AA8 File Offset: 0x0004ECA8
		[Token(Token = "0x600DCF7")]
		[Address(RVA = "0x36258C0", Offset = "0x36244C0", VA = "0x1836258C0")]
		public bool IsMagicCiruitSpAffect(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600DCF8 RID: 56568 RVA: 0x00050AC0 File Offset: 0x0004ECC0
		[Token(Token = "0x600DCF8")]
		[Address(RVA = "0x36281C0", Offset = "0x3626DC0", VA = "0x1836281C0")]
		private bool _CanCharacterChangeRouteDir(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600DCF9 RID: 56569 RVA: 0x00050AD8 File Offset: 0x0004ECD8
		[Token(Token = "0x600DCF9")]
		[Address(RVA = "0x36251C0", Offset = "0x3623DC0", VA = "0x1836251C0")]
		public bool GetMagicCiruitNextDir(Character character, ref SharedConsts.Direction curDir)
		{
			return default(bool);
		}

		// Token: 0x0600DCFA RID: 56570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCFA")]
		[Address(RVA = "0x36271C0", Offset = "0x3625DC0", VA = "0x1836271C0")]
		public void RegisterCharacterOnRoute(Character character)
		{
		}

		// Token: 0x0600DCFB RID: 56571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCFB")]
		[Address(RVA = "0x3627CB0", Offset = "0x36268B0", VA = "0x183627CB0")]
		public void UnregisterCharacterOnRoute(Character character)
		{
		}

		// Token: 0x0600DCFC RID: 56572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCFC")]
		[Address(RVA = "0x36288F0", Offset = "0x36274F0", VA = "0x1836288F0")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600DCFD RID: 56573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCFD")]
		[Address(RVA = "0x36286F0", Offset = "0x36272F0", VA = "0x1836286F0")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600DCFE RID: 56574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCFE")]
		[Address(RVA = "0x3628470", Offset = "0x3627070", VA = "0x183628470")]
		private void _OnCharacterChanged(object arg)
		{
		}

		// Token: 0x0600DCFF RID: 56575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCFF")]
		[Address(RVA = "0x3627370", Offset = "0x3625F70", VA = "0x183627370")]
		public void RegisterMagicCircuitRoute(Entity target)
		{
		}

		// Token: 0x0600DD00 RID: 56576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD00")]
		[Address(RVA = "0x3627E60", Offset = "0x3626A60", VA = "0x183627E60")]
		public void UnregisterMagicCircuitRoute(Tile rootTile, SharedConsts.Direction direction)
		{
		}

		// Token: 0x0600DD01 RID: 56577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD01")]
		[Address(RVA = "0x3627680", Offset = "0x3626280", VA = "0x183627680")]
		public void RegisterSpAffectCharacters(Character character, bool isTwoEntriesOnly)
		{
		}

		// Token: 0x0600DD02 RID: 56578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD02")]
		[Address(RVA = "0x3627FF0", Offset = "0x3626BF0", VA = "0x183627FF0")]
		public void UnregisterSpAffectCharacters(Character character)
		{
		}

		// Token: 0x0600DD03 RID: 56579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD03")]
		[Address(RVA = "0x3627080", Offset = "0x3625C80", VA = "0x183627080")]
		public void RefreshAllRoutes()
		{
		}

		// Token: 0x0600DD04 RID: 56580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD04")]
		[Address(RVA = "0x3626E00", Offset = "0x3625A00", VA = "0x183626E00")]
		public void RecheckAllRoutes()
		{
		}

		// Token: 0x0600DD05 RID: 56581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD05")]
		[Address(RVA = "0x3626F40", Offset = "0x3625B40", VA = "0x183626F40")]
		public void RefreshAllRoutesEffect()
		{
		}

		// Token: 0x0600DD06 RID: 56582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DD06")]
		[Address(RVA = "0x3624FB0", Offset = "0x3623BB0", VA = "0x183624FB0")]
		public List<ObjectPtr<Character>> GetCharactersInSameRoute(Character character)
		{
			return null;
		}

		// Token: 0x0600DD07 RID: 56583 RVA: 0x00050AF0 File Offset: 0x0004ECF0
		[Token(Token = "0x600DD07")]
		[Address(RVA = "0x3624D80", Offset = "0x3623980", VA = "0x183624D80")]
		public bool CheckCharacterInMagicCircuit(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600DD08 RID: 56584 RVA: 0x00050B08 File Offset: 0x0004ED08
		[Token(Token = "0x600DD08")]
		[Address(RVA = "0x3624F00", Offset = "0x3623B00", VA = "0x183624F00")]
		public bool CheckEnemyInMagicCircuit(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x0600DD09 RID: 56585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD09")]
		[Address(RVA = "0x3627B50", Offset = "0x3626750", VA = "0x183627B50")]
		public void SetMagicTileObstacle(Entity source, Tile tile, bool isObstacle)
		{
		}

		// Token: 0x0600DD0A RID: 56586 RVA: 0x00050B20 File Offset: 0x0004ED20
		[Token(Token = "0x600DD0A")]
		[Address(RVA = "0x3625670", Offset = "0x3624270", VA = "0x183625670")]
		public bool IsMagicCircuitTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600DD0B RID: 56587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD0B")]
		[Address(RVA = "0x3627C90", Offset = "0x3626890", VA = "0x183627C90")]
		private void <>xLuaBaseProxy_Init(Map P0)
		{
		}

		// Token: 0x0600DD0C RID: 56588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD0C")]
		[Address(RVA = "0x3627CA0", Offset = "0x36268A0", VA = "0x183627CA0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x0400EF3B RID: 61243
		[Token(Token = "0x400EF3B")]
		private const float EFFECT_EDGE_ON_TILE = 0.3f;

		// Token: 0x0400EF3C RID: 61244
		[Token(Token = "0x400EF3C")]
		private const float EFFECT_TAILEDGE_ON_TILE_BLOCK = 0.5f;

		// Token: 0x0400EF3D RID: 61245
		[Token(Token = "0x400EF3D")]
		private const float EFFECT_TAILEDGE_ON_TILE_NOBLOCK = 80f;

		// Token: 0x0400EF3E RID: 61246
		[Token(Token = "0x400EF3E")]
		private const float EFFECT_HEIGHT_ON_HIGHLAND = 0.05f;

		// Token: 0x0400EF3F RID: 61247
		[Token(Token = "0x400EF3F")]
		private const string effectDefaultKey = "trap_028_Leithanien_line_01";

		// Token: 0x0400EF40 RID: 61248
		[Token(Token = "0x400EF40")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ObjectPtr<Character>, int> m_magicCircuitCharacterStatus;

		// Token: 0x0400EF41 RID: 61249
		[Token(Token = "0x400EF41")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<ObjectPtr<Enemy>, int> m_magicCircuitEnemyStatus;

		// Token: 0x0400EF42 RID: 61250
		[Token(Token = "0x400EF42")]
		[FieldOffset(Offset = "0x28")]
		private List<MagicCircuitController.MagicCircuitRoute> m_routes;

		// Token: 0x0400EF43 RID: 61251
		[Token(Token = "0x400EF43")]
		[FieldOffset(Offset = "0x30")]
		private MagicCircuitController.MagicCircuitTiles2D m_Tiles;

		// Token: 0x0400EF44 RID: 61252
		[Token(Token = "0x400EF44")]
		[FieldOffset(Offset = "0x38")]
		private CoroutineId m_tileCheckCoroutine;

		// Token: 0x0400EF45 RID: 61253
		[Token(Token = "0x400EF45")]
		[FieldOffset(Offset = "0x48")]
		private CoroutineId m_characterCheckCoroutine;

		// Token: 0x0400EF46 RID: 61254
		[Token(Token = "0x400EF46")]
		[FieldOffset(Offset = "0x58")]
		private CoroutineId m_enemyCheckCoroutine;

		// Token: 0x0400EF47 RID: 61255
		[Token(Token = "0x400EF47")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<Character, bool> m_magicCircuitSpAffectCharacters;

		// Token: 0x0400EF48 RID: 61256
		[Token(Token = "0x400EF48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTileEnterRoute;

		// Token: 0x0400EF49 RID: 61257
		[Token(Token = "0x400EF49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTileLeaveRoute;

		// Token: 0x0400EF4A RID: 61258
		[Token(Token = "0x400EF4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCharacterEnterRoute;

		// Token: 0x0400EF4B RID: 61259
		[Token(Token = "0x400EF4B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCharacterLeaveRoute;

		// Token: 0x0400EF4C RID: 61260
		[Token(Token = "0x400EF4C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnemyEnterRoute;

		// Token: 0x0400EF4D RID: 61261
		[Token(Token = "0x400EF4D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnemyLeaveRoute;

		// Token: 0x0400EF4E RID: 61262
		[Token(Token = "0x400EF4E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnReallyTileEnterRoute;

		// Token: 0x0400EF4F RID: 61263
		[Token(Token = "0x400EF4F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnReallyTileLeaveRoute;

		// Token: 0x0400EF50 RID: 61264
		[Token(Token = "0x400EF50")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnReallyCharacterEnterRoute;

		// Token: 0x0400EF51 RID: 61265
		[Token(Token = "0x400EF51")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnReallyCharacterLeaveRoute;

		// Token: 0x0400EF52 RID: 61266
		[Token(Token = "0x400EF52")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnReallyEnemyEnterRoute;

		// Token: 0x0400EF53 RID: 61267
		[Token(Token = "0x400EF53")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnReallyEnemyLeaveRoute;

		// Token: 0x0400EF54 RID: 61268
		[Token(Token = "0x400EF54")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_magicTiles;

		// Token: 0x0400EF55 RID: 61269
		[Token(Token = "0x400EF55")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400EF56 RID: 61270
		[Token(Token = "0x400EF56")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400EF57 RID: 61271
		[Token(Token = "0x400EF57")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_InitParams;

		// Token: 0x0400EF58 RID: 61272
		[Token(Token = "0x400EF58")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0400EF59 RID: 61273
		[Token(Token = "0x400EF59")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__StartTileCheckInRoute;

		// Token: 0x0400EF5A RID: 61274
		[Token(Token = "0x400EF5A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__StartCharacterCheckInRoute;

		// Token: 0x0400EF5B RID: 61275
		[Token(Token = "0x400EF5B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__StartEnemyCheckInRoute;

		// Token: 0x0400EF5C RID: 61276
		[Token(Token = "0x400EF5C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CkeckTileInRoute;

		// Token: 0x0400EF5D RID: 61277
		[Token(Token = "0x400EF5D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CkeckCharacterInRoute;

		// Token: 0x0400EF5E RID: 61278
		[Token(Token = "0x400EF5E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CkeckEnemyInRoute;

		// Token: 0x0400EF5F RID: 61279
		[Token(Token = "0x400EF5F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_IsMagicCiruitAffect;

		// Token: 0x0400EF60 RID: 61280
		[Token(Token = "0x400EF60")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_IsMagicCiruitSpAffect;

		// Token: 0x0400EF61 RID: 61281
		[Token(Token = "0x400EF61")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CanCharacterChangeRouteDir;

		// Token: 0x0400EF62 RID: 61282
		[Token(Token = "0x400EF62")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetMagicCiruitNextDir;

		// Token: 0x0400EF63 RID: 61283
		[Token(Token = "0x400EF63")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_RegisterCharacterOnRoute;

		// Token: 0x0400EF64 RID: 61284
		[Token(Token = "0x400EF64")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_UnregisterCharacterOnRoute;

		// Token: 0x0400EF65 RID: 61285
		[Token(Token = "0x400EF65")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400EF66 RID: 61286
		[Token(Token = "0x400EF66")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400EF67 RID: 61287
		[Token(Token = "0x400EF67")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnCharacterChanged;

		// Token: 0x0400EF68 RID: 61288
		[Token(Token = "0x400EF68")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_RegisterMagicCircuitRoute;

		// Token: 0x0400EF69 RID: 61289
		[Token(Token = "0x400EF69")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_UnregisterMagicCircuitRoute;

		// Token: 0x0400EF6A RID: 61290
		[Token(Token = "0x400EF6A")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_RegisterSpAffectCharacters;

		// Token: 0x0400EF6B RID: 61291
		[Token(Token = "0x400EF6B")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_UnregisterSpAffectCharacters;

		// Token: 0x0400EF6C RID: 61292
		[Token(Token = "0x400EF6C")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_RefreshAllRoutes;

		// Token: 0x0400EF6D RID: 61293
		[Token(Token = "0x400EF6D")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_RecheckAllRoutes;

		// Token: 0x0400EF6E RID: 61294
		[Token(Token = "0x400EF6E")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_RefreshAllRoutesEffect;

		// Token: 0x0400EF6F RID: 61295
		[Token(Token = "0x400EF6F")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetCharactersInSameRoute;

		// Token: 0x0400EF70 RID: 61296
		[Token(Token = "0x400EF70")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_CheckCharacterInMagicCircuit;

		// Token: 0x0400EF71 RID: 61297
		[Token(Token = "0x400EF71")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_CheckEnemyInMagicCircuit;

		// Token: 0x0400EF72 RID: 61298
		[Token(Token = "0x400EF72")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_SetMagicTileObstacle;

		// Token: 0x0400EF73 RID: 61299
		[Token(Token = "0x400EF73")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_IsMagicCircuitTile;

		// Token: 0x0200225A RID: 8794
		[Token(Token = "0x200225A")]
		public class MagicCircuitTile : ITileListener, IHotfixable
		{
			// Token: 0x17001BD2 RID: 7122
			// (get) Token: 0x0600DD0D RID: 56589 RVA: 0x00050B38 File Offset: 0x0004ED38
			[Token(Token = "0x17001BD2")]
			public bool isObstacle
			{
				[Token(Token = "0x600DD0D")]
				[Address(RVA = "0x363B6A0", Offset = "0x363A2A0", VA = "0x18363B6A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600DD0E RID: 56590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD0E")]
			[Address(RVA = "0x363B470", Offset = "0x363A070", VA = "0x18363B470")]
			public void SetIsObstacle(Entity entity, bool isObstacle)
			{
			}

			// Token: 0x0600DD0F RID: 56591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD0F")]
			[Address(RVA = "0x363B5A0", Offset = "0x363A1A0", VA = "0x18363B5A0")]
			public MagicCircuitTile(MagicCircuitController _controller, Tile _tile)
			{
			}

			// Token: 0x0600DD10 RID: 56592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD10")]
			[Address(RVA = "0x363B410", Offset = "0x363A010", VA = "0x18363B410", Slot = "4")]
			public void OnLocatedCharacterUpdate(Character character)
			{
			}

			// Token: 0x0600DD11 RID: 56593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD11")]
			[Address(RVA = "0x363B170", Offset = "0x3639D70", VA = "0x18363B170", Slot = "5")]
			public void OnEntityEnter(Entity entity)
			{
			}

			// Token: 0x0600DD12 RID: 56594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD12")]
			[Address(RVA = "0x363B2C0", Offset = "0x3639EC0", VA = "0x18363B2C0", Slot = "6")]
			public void OnEntityLeave(Entity entity)
			{
			}

			// Token: 0x0400EF74 RID: 61300
			[Token(Token = "0x400EF74")]
			[FieldOffset(Offset = "0x10")]
			public bool isEnabled;

			// Token: 0x0400EF75 RID: 61301
			[Token(Token = "0x400EF75")]
			[FieldOffset(Offset = "0x18")]
			private MagicCircuitController m_controller;

			// Token: 0x0400EF76 RID: 61302
			[Token(Token = "0x400EF76")]
			[FieldOffset(Offset = "0x20")]
			public Tile tile;

			// Token: 0x0400EF77 RID: 61303
			[Token(Token = "0x400EF77")]
			[FieldOffset(Offset = "0x28")]
			private ListSet<ObjectPtr<Entity>> m_obstacleTarget;

			// Token: 0x0400EF78 RID: 61304
			[Token(Token = "0x400EF78")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isObstacle;

			// Token: 0x0400EF79 RID: 61305
			[Token(Token = "0x400EF79")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetIsObstacle;

			// Token: 0x0400EF7A RID: 61306
			[Token(Token = "0x400EF7A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400EF7B RID: 61307
			[Token(Token = "0x400EF7B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnLocatedCharacterUpdate;

			// Token: 0x0400EF7C RID: 61308
			[Token(Token = "0x400EF7C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnEntityEnter;

			// Token: 0x0400EF7D RID: 61309
			[Token(Token = "0x400EF7D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnEntityLeave;
		}

		// Token: 0x0200225B RID: 8795
		[Token(Token = "0x200225B")]
		public class MagicCircuitRouteEffect : IHotfixable
		{
			// Token: 0x0600DD13 RID: 56595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD13")]
			[Address(RVA = "0x36381E0", Offset = "0x3636DE0", VA = "0x1836381E0")]
			public MagicCircuitRouteEffect(string _effectKey, Entity _source, List<Vector3> _positions)
			{
			}

			// Token: 0x17001BD3 RID: 7123
			// (get) Token: 0x0600DD14 RID: 56596 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001BD3")]
			protected LineRenderer[] lineRenderers
			{
				[Token(Token = "0x600DD14")]
				[Address(RVA = "0x3638360", Offset = "0x3636F60", VA = "0x183638360")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600DD15 RID: 56597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD15")]
			[Address(RVA = "0x3638030", Offset = "0x3636C30", VA = "0x183638030")]
			public void UpdateSelf()
			{
			}

			// Token: 0x0400EF7E RID: 61310
			[Token(Token = "0x400EF7E")]
			[FieldOffset(Offset = "0x10")]
			public Effect effect;

			// Token: 0x0400EF7F RID: 61311
			[Token(Token = "0x400EF7F")]
			[FieldOffset(Offset = "0x18")]
			private List<Vector3> positions;

			// Token: 0x0400EF80 RID: 61312
			[Token(Token = "0x400EF80")]
			[FieldOffset(Offset = "0x20")]
			private LineRenderer[] m_lineRenderers;

			// Token: 0x0400EF81 RID: 61313
			[Token(Token = "0x400EF81")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400EF82 RID: 61314
			[Token(Token = "0x400EF82")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_lineRenderers;

			// Token: 0x0400EF83 RID: 61315
			[Token(Token = "0x400EF83")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateSelf;
		}

		// Token: 0x0200225C RID: 8796
		[Token(Token = "0x200225C")]
		public class MagicCircuitRoute : IHotfixable
		{
			// Token: 0x17001BD4 RID: 7124
			// (get) Token: 0x0600DD16 RID: 56598 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001BD4")]
			public MagicCircuitController.MagicCircuitRouteEffect routeEffect
			{
				[Token(Token = "0x600DD16")]
				[Address(RVA = "0x363AF40", Offset = "0x3639B40", VA = "0x18363AF40")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600DD17 RID: 56599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD17")]
			[Address(RVA = "0x363AC20", Offset = "0x3639820", VA = "0x18363AC20")]
			public MagicCircuitRoute(MagicCircuitController controller, Entity target)
			{
			}

			// Token: 0x0600DD18 RID: 56600 RVA: 0x00050B50 File Offset: 0x0004ED50
			[Token(Token = "0x600DD18")]
			[Address(RVA = "0x36386C0", Offset = "0x36372C0", VA = "0x1836386C0")]
			public bool IsSameRoute(Tile tile, SharedConsts.Direction dir)
			{
				return default(bool);
			}

			// Token: 0x0600DD19 RID: 56601 RVA: 0x00050B68 File Offset: 0x0004ED68
			[Token(Token = "0x600DD19")]
			[Address(RVA = "0x3638410", Offset = "0x3637010", VA = "0x183638410")]
			public bool ContainsTarget(Character character)
			{
				return default(bool);
			}

			// Token: 0x0600DD1A RID: 56602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DD1A")]
			[Address(RVA = "0x36385D0", Offset = "0x36371D0", VA = "0x1836385D0")]
			public List<ObjectPtr<Character>> GetCharactersInSameRoute(Character character)
			{
				return null;
			}

			// Token: 0x0600DD1B RID: 56603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD1B")]
			[Address(RVA = "0x3638540", Offset = "0x3637140", VA = "0x183638540")]
			public void DeleteSelf()
			{
			}

			// Token: 0x0600DD1C RID: 56604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD1C")]
			[Address(RVA = "0x3639C00", Offset = "0x3638800", VA = "0x183639C00")]
			private void _GenerateLeafTiles(Tile tile, SharedConsts.Direction dir)
			{
			}

			// Token: 0x0600DD1D RID: 56605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD1D")]
			[Address(RVA = "0x36388E0", Offset = "0x36374E0", VA = "0x1836388E0")]
			public void RefreshEffectPositions()
			{
			}

			// Token: 0x0600DD1E RID: 56606 RVA: 0x00050B80 File Offset: 0x0004ED80
			[Token(Token = "0x600DD1E")]
			[Address(RVA = "0x363A300", Offset = "0x3638F00", VA = "0x18363A300")]
			private Vector3 _GetTileEffectPosition(Tile tile, SharedConsts.Direction dir, bool isTailPosition = false)
			{
				return default(Vector3);
			}

			// Token: 0x0600DD1F RID: 56607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD1F")]
			[Address(RVA = "0x36398F0", Offset = "0x36384F0", VA = "0x1836398F0")]
			private void _AddLeafTile(Tile tile, SharedConsts.Direction dir)
			{
			}

			// Token: 0x0600DD20 RID: 56608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DD20")]
			[Address(RVA = "0x363A1A0", Offset = "0x3638DA0", VA = "0x18363A1A0")]
			private Tile _GetNextTile(Tile curTile, ref SharedConsts.Direction curDir)
			{
				return null;
			}

			// Token: 0x0600DD21 RID: 56609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DD21")]
			[Address(RVA = "0x363A020", Offset = "0x3638C20", VA = "0x18363A020")]
			private Tile _GetNextTileNoCheck(Tile curTile, SharedConsts.Direction curDir)
			{
				return null;
			}

			// Token: 0x0600DD22 RID: 56610 RVA: 0x00050B98 File Offset: 0x0004ED98
			[Token(Token = "0x600DD22")]
			[Address(RVA = "0x36394B0", Offset = "0x36380B0", VA = "0x1836394B0")]
			public bool RegisterCharacter(Character character)
			{
				return default(bool);
			}

			// Token: 0x0600DD23 RID: 56611 RVA: 0x00050BB0 File Offset: 0x0004EDB0
			[Token(Token = "0x600DD23")]
			[Address(RVA = "0x3639710", Offset = "0x3638310", VA = "0x183639710")]
			public bool UnregisterCharacter(Character character)
			{
				return default(bool);
			}

			// Token: 0x0600DD24 RID: 56612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD24")]
			[Address(RVA = "0x3639070", Offset = "0x3637C70", VA = "0x183639070")]
			public void RefreshRoute()
			{
			}

			// Token: 0x0600DD25 RID: 56613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD25")]
			[Address(RVA = "0x3638770", Offset = "0x3637370", VA = "0x183638770")]
			public void RecheckRoute()
			{
			}

			// Token: 0x0600DD26 RID: 56614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD26")]
			[Address(RVA = "0x363AA60", Offset = "0x3639660", VA = "0x18363AA60")]
			private void _RemoveLeafTilesFromSource(Tile sourceTile)
			{
			}

			// Token: 0x0600DD27 RID: 56615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD27")]
			[Address(RVA = "0x3639690", Offset = "0x3638290", VA = "0x183639690")]
			public void RemoveLeafTilesFromSource(Tile sourceTile)
			{
			}

			// Token: 0x0600DD28 RID: 56616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD28")]
			[Address(RVA = "0x363A6D0", Offset = "0x36392D0", VA = "0x18363A6D0")]
			private void _OnRemoveLeafTile(KeyValuePair<Tile, SharedConsts.Direction> tileWithDir)
			{
			}

			// Token: 0x0600DD29 RID: 56617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD29")]
			[Address(RVA = "0x363A5B0", Offset = "0x36391B0", VA = "0x18363A5B0")]
			public void _OnCharacterEnterRoute(Character character)
			{
			}

			// Token: 0x0600DD2A RID: 56618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD2A")]
			[Address(RVA = "0x363A640", Offset = "0x3639240", VA = "0x18363A640")]
			public void _OnCharacterLeaveRoute(Character character)
			{
			}

			// Token: 0x0600DD2B RID: 56619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD2B")]
			[Address(RVA = "0x363A900", Offset = "0x3639500", VA = "0x18363A900")]
			public void _OnTileEnterRoute(Tile tile, SharedConsts.Direction dir)
			{
			}

			// Token: 0x0600DD2C RID: 56620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD2C")]
			[Address(RVA = "0x363A9B0", Offset = "0x36395B0", VA = "0x18363A9B0")]
			public void _OnTileLeaveRoute(Tile tile, SharedConsts.Direction dir)
			{
			}

			// Token: 0x0400EF84 RID: 61316
			[Token(Token = "0x400EF84")]
			[FieldOffset(Offset = "0x10")]
			private Tile m_rootTile;

			// Token: 0x0400EF85 RID: 61317
			[Token(Token = "0x400EF85")]
			[FieldOffset(Offset = "0x18")]
			private SharedConsts.Direction m_rootDir;

			// Token: 0x0400EF86 RID: 61318
			[Token(Token = "0x400EF86")]
			[FieldOffset(Offset = "0x20")]
			private List<KeyValuePair<Tile, SharedConsts.Direction>> m_leafTiles;

			// Token: 0x0400EF87 RID: 61319
			[Token(Token = "0x400EF87")]
			[FieldOffset(Offset = "0x28")]
			private List<ObjectPtr<Character>> m_locatedCharacters;

			// Token: 0x0400EF88 RID: 61320
			[Token(Token = "0x400EF88")]
			[FieldOffset(Offset = "0x30")]
			private MagicCircuitController m_controller;

			// Token: 0x0400EF89 RID: 61321
			[Token(Token = "0x400EF89")]
			[FieldOffset(Offset = "0x38")]
			private Dictionary<Tile, Tile> m_leafTilesDict;

			// Token: 0x0400EF8A RID: 61322
			[Token(Token = "0x400EF8A")]
			[FieldOffset(Offset = "0x40")]
			private Entity m_rootTarget;

			// Token: 0x0400EF8B RID: 61323
			[Token(Token = "0x400EF8B")]
			[FieldOffset(Offset = "0x48")]
			private MagicCircuitController.MagicCircuitRouteEffect m_routeEffect;

			// Token: 0x0400EF8C RID: 61324
			[Token(Token = "0x400EF8C")]
			[FieldOffset(Offset = "0x50")]
			private List<Vector3> m_effectPositions;

			// Token: 0x0400EF8D RID: 61325
			[Token(Token = "0x400EF8D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_routeEffect;

			// Token: 0x0400EF8E RID: 61326
			[Token(Token = "0x400EF8E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400EF8F RID: 61327
			[Token(Token = "0x400EF8F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsSameRoute;

			// Token: 0x0400EF90 RID: 61328
			[Token(Token = "0x400EF90")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ContainsTarget;

			// Token: 0x0400EF91 RID: 61329
			[Token(Token = "0x400EF91")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetCharactersInSameRoute;

			// Token: 0x0400EF92 RID: 61330
			[Token(Token = "0x400EF92")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_DeleteSelf;

			// Token: 0x0400EF93 RID: 61331
			[Token(Token = "0x400EF93")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__GenerateLeafTiles;

			// Token: 0x0400EF94 RID: 61332
			[Token(Token = "0x400EF94")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_RefreshEffectPositions;

			// Token: 0x0400EF95 RID: 61333
			[Token(Token = "0x400EF95")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__GetTileEffectPosition;

			// Token: 0x0400EF96 RID: 61334
			[Token(Token = "0x400EF96")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__AddLeafTile;

			// Token: 0x0400EF97 RID: 61335
			[Token(Token = "0x400EF97")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__GetNextTile;

			// Token: 0x0400EF98 RID: 61336
			[Token(Token = "0x400EF98")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__GetNextTileNoCheck;

			// Token: 0x0400EF99 RID: 61337
			[Token(Token = "0x400EF99")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_RegisterCharacter;

			// Token: 0x0400EF9A RID: 61338
			[Token(Token = "0x400EF9A")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_UnregisterCharacter;

			// Token: 0x0400EF9B RID: 61339
			[Token(Token = "0x400EF9B")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_RefreshRoute;

			// Token: 0x0400EF9C RID: 61340
			[Token(Token = "0x400EF9C")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_RecheckRoute;

			// Token: 0x0400EF9D RID: 61341
			[Token(Token = "0x400EF9D")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0__RemoveLeafTilesFromSource;

			// Token: 0x0400EF9E RID: 61342
			[Token(Token = "0x400EF9E")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_RemoveLeafTilesFromSource;

			// Token: 0x0400EF9F RID: 61343
			[Token(Token = "0x400EF9F")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0__OnRemoveLeafTile;

			// Token: 0x0400EFA0 RID: 61344
			[Token(Token = "0x400EFA0")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0__OnCharacterEnterRoute;

			// Token: 0x0400EFA1 RID: 61345
			[Token(Token = "0x400EFA1")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0__OnCharacterLeaveRoute;

			// Token: 0x0400EFA2 RID: 61346
			[Token(Token = "0x400EFA2")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0__OnTileEnterRoute;

			// Token: 0x0400EFA3 RID: 61347
			[Token(Token = "0x400EFA3")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0__OnTileLeaveRoute;
		}

		// Token: 0x0200225D RID: 8797
		[Token(Token = "0x200225D")]
		public class MagicCircuitTiles2D : IHotfixable
		{
			// Token: 0x17001BD5 RID: 7125
			// (get) Token: 0x0600DD2D RID: 56621 RVA: 0x00050BC8 File Offset: 0x0004EDC8
			[Token(Token = "0x17001BD5")]
			public int width
			{
				[Token(Token = "0x600DD2D")]
				[Address(RVA = "0x363BD60", Offset = "0x363A960", VA = "0x18363BD60")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001BD6 RID: 7126
			// (get) Token: 0x0600DD2E RID: 56622 RVA: 0x00050BE0 File Offset: 0x0004EDE0
			[Token(Token = "0x17001BD6")]
			public int height
			{
				[Token(Token = "0x600DD2E")]
				[Address(RVA = "0x363BD00", Offset = "0x363A900", VA = "0x18363BD00")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600DD2F RID: 56623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD2F")]
			[Address(RVA = "0x363B8E0", Offset = "0x363A4E0", VA = "0x18363B8E0")]
			public MagicCircuitTiles2D(int width, int height, MagicCircuitController controller)
			{
			}

			// Token: 0x17001BD7 RID: 7127
			[Token(Token = "0x17001BD7")]
			public MagicCircuitController.MagicCircuitTile this[int row, int col]
			{
				[Token(Token = "0x600DD30")]
				[Address(RVA = "0x363BBC0", Offset = "0x363A7C0", VA = "0x18363BBC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600DD31")]
				[Address(RVA = "0x363BDC0", Offset = "0x363A9C0", VA = "0x18363BDC0")]
				set
				{
				}
			}

			// Token: 0x17001BD8 RID: 7128
			[Token(Token = "0x17001BD8")]
			public MagicCircuitController.MagicCircuitTile this[GridPosition pos]
			{
				[Token(Token = "0x600DD32")]
				[Address(RVA = "0x363BAB0", Offset = "0x363A6B0", VA = "0x18363BAB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600DD33")]
				[Address(RVA = "0x363BF30", Offset = "0x363AB30", VA = "0x18363BF30")]
				set
				{
				}
			}

			// Token: 0x0600DD34 RID: 56628 RVA: 0x00050BF8 File Offset: 0x0004EDF8
			[Token(Token = "0x600DD34")]
			[Address(RVA = "0x363B720", Offset = "0x363A320", VA = "0x18363B720")]
			public bool CheckValid(GridPosition pos)
			{
				return default(bool);
			}

			// Token: 0x0600DD35 RID: 56629 RVA: 0x00050C10 File Offset: 0x0004EE10
			[Token(Token = "0x600DD35")]
			[Address(RVA = "0x363B800", Offset = "0x363A400", VA = "0x18363B800")]
			public bool IsEdge(GridPosition pos)
			{
				return default(bool);
			}

			// Token: 0x0400EFA4 RID: 61348
			[Token(Token = "0x400EFA4")]
			[FieldOffset(Offset = "0x10")]
			private int _width;

			// Token: 0x0400EFA5 RID: 61349
			[Token(Token = "0x400EFA5")]
			[FieldOffset(Offset = "0x14")]
			private int _height;

			// Token: 0x0400EFA6 RID: 61350
			[Token(Token = "0x400EFA6")]
			[FieldOffset(Offset = "0x18")]
			public MagicCircuitController.MagicCircuitTile[] _tiles;

			// Token: 0x0400EFA7 RID: 61351
			[Token(Token = "0x400EFA7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_width;

			// Token: 0x0400EFA8 RID: 61352
			[Token(Token = "0x400EFA8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_height;

			// Token: 0x0400EFA9 RID: 61353
			[Token(Token = "0x400EFA9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400EFAA RID: 61354
			[Token(Token = "0x400EFAA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_Item;

			// Token: 0x0400EFAB RID: 61355
			[Token(Token = "0x400EFAB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_Item;

			// Token: 0x0400EFAC RID: 61356
			[Token(Token = "0x400EFAC")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix1_get_Item;

			// Token: 0x0400EFAD RID: 61357
			[Token(Token = "0x400EFAD")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix1_set_Item;

			// Token: 0x0400EFAE RID: 61358
			[Token(Token = "0x400EFAE")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_CheckValid;

			// Token: 0x0400EFAF RID: 61359
			[Token(Token = "0x400EFAF")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_IsEdge;
		}
	}
}
