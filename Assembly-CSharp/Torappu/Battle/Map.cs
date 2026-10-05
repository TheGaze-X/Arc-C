using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Rendering;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200235B RID: 9051
	[Token(Token = "0x200235B")]
	public class Map : SingletonMonoBehaviour<Map>, ISingletonNotAutoCreate, ILuaCallCSharp, IHotfixable
	{
		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x0600E512 RID: 58642 RVA: 0x00052C50 File Offset: 0x00050E50
		[Token(Token = "0x17001CA8")]
		public bool isMultiLayerMap
		{
			[Token(Token = "0x600E512")]
			[Address(RVA = "0x5A3220", Offset = "0x5A1E20", VA = "0x1805A3220")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x0600E513 RID: 58643 RVA: 0x00052C68 File Offset: 0x00050E68
		[Token(Token = "0x17001CA9")]
		public bool isMagicCircuitMap
		{
			[Token(Token = "0x600E513")]
			[Address(RVA = "0x5A30B0", Offset = "0x5A1CB0", VA = "0x1805A30B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x0600E514 RID: 58644 RVA: 0x00052C80 File Offset: 0x00050E80
		[Token(Token = "0x17001CAA")]
		public float tileMoveTime
		{
			[Token(Token = "0x600E514")]
			[Address(RVA = "0x5A36B0", Offset = "0x5A22B0", VA = "0x1805A36B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x0600E515 RID: 58645 RVA: 0x00052C98 File Offset: 0x00050E98
		[Token(Token = "0x17001CAB")]
		public Ease tileMoveEase
		{
			[Token(Token = "0x600E515")]
			[Address(RVA = "0x5A3640", Offset = "0x5A2240", VA = "0x1805A3640")]
			get
			{
				return Ease.Unset;
			}
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x0600E516 RID: 58646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CAC")]
		public Tile[] tiles
		{
			[Token(Token = "0x600E516")]
			[Address(RVA = "0x5A37E0", Offset = "0x5A23E0", VA = "0x1805A37E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x0600E517 RID: 58647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CAD")]
		public List<Tile> endPosTiles
		{
			[Token(Token = "0x600E517")]
			[Address(RVA = "0x5A2D60", Offset = "0x5A1960", VA = "0x1805A2D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x0600E518 RID: 58648 RVA: 0x00052CB0 File Offset: 0x00050EB0
		[Token(Token = "0x17001CAE")]
		public int width
		{
			[Token(Token = "0x600E518")]
			[Address(RVA = "0x5A3860", Offset = "0x5A2460", VA = "0x1805A3860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x0600E519 RID: 58649 RVA: 0x00052CC8 File Offset: 0x00050EC8
		[Token(Token = "0x17001CAF")]
		public int height
		{
			[Token(Token = "0x600E519")]
			[Address(RVA = "0x5A3030", Offset = "0x5A1C30", VA = "0x1805A3030")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x0600E51A RID: 58650 RVA: 0x00052CE0 File Offset: 0x00050EE0
		[Token(Token = "0x17001CB0")]
		public bool isValid
		{
			[Token(Token = "0x600E51A")]
			[Address(RVA = "0x5A32B0", Offset = "0x5A1EB0", VA = "0x1805A32B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x0600E51B RID: 58651 RVA: 0x00052CF8 File Offset: 0x00050EF8
		[Token(Token = "0x17001CB1")]
		public bool buildableDirty
		{
			[Token(Token = "0x600E51B")]
			[Address(RVA = "0x5A2810", Offset = "0x5A1410", VA = "0x1805A2810")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x0600E51C RID: 58652 RVA: 0x00052D10 File Offset: 0x00050F10
		[Token(Token = "0x17001CB2")]
		public CameraViewLevel cameraView
		{
			[Token(Token = "0x600E51C")]
			[Address(RVA = "0x5A2A20", Offset = "0x5A1620", VA = "0x1805A2A20")]
			get
			{
				return CameraViewLevel.DEFAULT;
			}
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x0600E51D RID: 58653 RVA: 0x00052D28 File Offset: 0x00050F28
		[Token(Token = "0x17001CB3")]
		public Vector3? cameraWorldPos
		{
			[Token(Token = "0x600E51D")]
			[Address(RVA = "0x5A2AF0", Offset = "0x5A16F0", VA = "0x1805A2AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x0600E51E RID: 58654 RVA: 0x00052D40 File Offset: 0x00050F40
		[Token(Token = "0x17001CB4")]
		public Vector3 cameraFocusPos
		{
			[Token(Token = "0x600E51E")]
			[Address(RVA = "0x5A2890", Offset = "0x5A1490", VA = "0x1805A2890")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x0600E51F RID: 58655 RVA: 0x00052D58 File Offset: 0x00050F58
		[Token(Token = "0x17001CB5")]
		public int battleAreaStartCol
		{
			[Token(Token = "0x600E51F")]
			[Address(RVA = "0x5A2640", Offset = "0x5A1240", VA = "0x1805A2640")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x0600E520 RID: 58656 RVA: 0x00052D70 File Offset: 0x00050F70
		[Token(Token = "0x17001CB6")]
		public int battleAreaEndCol
		{
			[Token(Token = "0x600E520")]
			[Address(RVA = "0x5A2470", Offset = "0x5A1070", VA = "0x1805A2470")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x0600E521 RID: 58657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CB7")]
		public Transform anchorTransform
		{
			[Token(Token = "0x600E521")]
			[Address(RVA = "0x5A23B0", Offset = "0x5A0FB0", VA = "0x1805A23B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x0600E522 RID: 58658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CB8")]
		protected Transform tilesContainer
		{
			[Token(Token = "0x600E522")]
			[Address(RVA = "0x5A3720", Offset = "0x5A2320", VA = "0x1805A3720")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x0600E523 RID: 58659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CB9")]
		public Transform graphicContainer
		{
			[Token(Token = "0x600E523")]
			[Address(RVA = "0x5A2EF0", Offset = "0x5A1AF0", VA = "0x1805A2EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CBA RID: 7354
		[Token(Token = "0x17001CBA")]
		public Tile this[GridPosition pos]
		{
			[Token(Token = "0x600E524")]
			[Address(RVA = "0x5A2300", Offset = "0x5A0F00", VA = "0x1805A2300")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CBB RID: 7355
		[Token(Token = "0x17001CBB")]
		public Tile this[int row, int col]
		{
			[Token(Token = "0x600E525")]
			[Address(RVA = "0x5A2240", Offset = "0x5A0E40", VA = "0x1805A2240")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x0600E526 RID: 58662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CBC")]
		public MapGraphic graphic
		{
			[Token(Token = "0x600E526")]
			[Address(RVA = "0x5A2FB0", Offset = "0x5A1BB0", VA = "0x1805A2FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x0600E527 RID: 58663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CBD")]
		public MapThemeController themeController
		{
			[Token(Token = "0x600E527")]
			[Address(RVA = "0x5A35C0", Offset = "0x5A21C0", VA = "0x1805A35C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x0600E528 RID: 58664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CBE")]
		public NightMapController nightMapController
		{
			[Token(Token = "0x600E528")]
			[Address(RVA = "0x5A34B0", Offset = "0x5A20B0", VA = "0x1805A34B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x0600E529 RID: 58665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CBF")]
		public MagicCircuitController magicCircuitController
		{
			[Token(Token = "0x600E529")]
			[Address(RVA = "0x5A3340", Offset = "0x5A1F40", VA = "0x1805A3340")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x0600E52A RID: 58666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CC0")]
		public System.Random random
		{
			[Token(Token = "0x600E52A")]
			[Address(RVA = "0x5A3540", Offset = "0x5A2140", VA = "0x1805A3540")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x0600E52B RID: 58667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CC1")]
		public string mapTheme
		{
			[Token(Token = "0x600E52B")]
			[Address(RVA = "0x5A33D0", Offset = "0x5A1FD0", VA = "0x1805A33D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x0600E52C RID: 58668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CC2")]
		public MapData data
		{
			[Token(Token = "0x600E52C")]
			[Address(RVA = "0x5A2CE0", Offset = "0x5A18E0", VA = "0x1805A2CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E52D RID: 58669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E52D")]
		[Address(RVA = "0x59C230", Offset = "0x59AE30", VA = "0x18059C230")]
		public void Init(MapData mapData, LevelData levelData, IList<GridPosition> tilesDisallowToLocate, string themeId)
		{
		}

		// Token: 0x0600E52E RID: 58670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E52E")]
		[Address(RVA = "0x59D170", Offset = "0x59BD70", VA = "0x18059D170")]
		public void ResetSeed(int newSeed)
		{
		}

		// Token: 0x0600E52F RID: 58671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E52F")]
		[Address(RVA = "0x59C190", Offset = "0x59AD90", VA = "0x18059C190")]
		public void InitRouteAndPassableMap(LevelData levelData)
		{
		}

		// Token: 0x0600E530 RID: 58672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E530")]
		[Address(RVA = "0x59D470", Offset = "0x59C070", VA = "0x18059D470")]
		public void SetBuildableDirty(bool isDirty)
		{
		}

		// Token: 0x0600E531 RID: 58673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E531")]
		[Address(RVA = "0x598130", Offset = "0x596D30", VA = "0x180598130")]
		public void ClearAllRoutes()
		{
		}

		// Token: 0x0600E532 RID: 58674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E532")]
		[Address(RVA = "0x59CDF0", Offset = "0x59B9F0", VA = "0x18059CDF0")]
		public void ReplaceAllRoutes(RouteData[] newRoutes, RouteData[] newExtraRoutes)
		{
		}

		// Token: 0x0600E533 RID: 58675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E533")]
		[Address(RVA = "0x59ECC0", Offset = "0x59D8C0", VA = "0x18059ECC0")]
		public void UpdateAllRoutes()
		{
		}

		// Token: 0x0600E534 RID: 58676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E534")]
		[Address(RVA = "0x59F1B0", Offset = "0x59DDB0", VA = "0x18059F1B0")]
		public void UpdateRoutes(MotionMode motionMode)
		{
		}

		// Token: 0x0600E535 RID: 58677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E535")]
		[Address(RVA = "0x59EB40", Offset = "0x59D740", VA = "0x18059EB40")]
		public void UpdateAllRoutesOffset(Vector2 offset)
		{
		}

		// Token: 0x0600E536 RID: 58678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E536")]
		[Address(RVA = "0x5A1340", Offset = "0x59FF40", VA = "0x1805A1340")]
		private void _ProcessRoutes(Route[] routes, Vector2 offset)
		{
		}

		// Token: 0x0600E537 RID: 58679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E537")]
		private void _ProcessRoutes<T>(ListDict<T, Route> routes, Vector2 offset)
		{
		}

		// Token: 0x0600E538 RID: 58680 RVA: 0x00052D88 File Offset: 0x00050F88
		[Token(Token = "0x600E538")]
		[Address(RVA = "0x5974A0", Offset = "0x5960A0", VA = "0x1805974A0")]
		public bool CheckAllRoutesReachable(bool avoidObstacleLike)
		{
			return default(bool);
		}

		// Token: 0x0600E539 RID: 58681 RVA: 0x00052DA0 File Offset: 0x00050FA0
		[Token(Token = "0x600E539")]
		[Address(RVA = "0x597B40", Offset = "0x596740", VA = "0x180597B40")]
		public bool CheckReachable(MotionMode motionMode, GridPosition posFrom, GridPosition posTo, bool avoidObstacleLike)
		{
			return default(bool);
		}

		// Token: 0x0600E53A RID: 58682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E53A")]
		[Address(RVA = "0x59A220", Offset = "0x598E20", VA = "0x18059A220")]
		public bool[,] GetPassableMap(MotionMode motionMode)
		{
			return null;
		}

		// Token: 0x0600E53B RID: 58683 RVA: 0x00052DB8 File Offset: 0x00050FB8
		[Token(Token = "0x600E53B")]
		[Address(RVA = "0x597A30", Offset = "0x596630", VA = "0x180597A30")]
		public bool CheckPassable(MotionMode motionMode, GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600E53C RID: 58684 RVA: 0x00052DD0 File Offset: 0x00050FD0
		[Token(Token = "0x600E53C")]
		[Address(RVA = "0x597860", Offset = "0x596460", VA = "0x180597860")]
		public bool CheckObstacleLikeOrUnpassable(MotionMode motionMode, GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600E53D RID: 58685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E53D")]
		[Address(RVA = "0x59F070", Offset = "0x59DC70", VA = "0x18059F070")]
		public void UpdatePassableMap(Tile tile)
		{
		}

		// Token: 0x0600E53E RID: 58686 RVA: 0x00052DE8 File Offset: 0x00050FE8
		[Token(Token = "0x600E53E")]
		[Address(RVA = "0x59DBA0", Offset = "0x59C7A0", VA = "0x18059DBA0")]
		public bool TryGetInitialLOrR(GridPosition pos, out SharedConsts.Direction direction)
		{
			return default(bool);
		}

		// Token: 0x0600E53F RID: 58687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E53F")]
		[Address(RVA = "0x59B670", Offset = "0x59A270", VA = "0x18059B670")]
		public void ImportData(MapData mapData, BattleFactory factory, bool force, bool includeGraphic, bool updateAnchor, bool attachGraphic = false)
		{
		}

		// Token: 0x0600E540 RID: 58688 RVA: 0x00052E00 File Offset: 0x00051000
		[Token(Token = "0x600E540")]
		[Address(RVA = "0x5984E0", Offset = "0x5970E0", VA = "0x1805984E0")]
		public int FilterTiles(IDrawableRange range, Action<Tile> cb)
		{
			return 0;
		}

		// Token: 0x0600E541 RID: 58689 RVA: 0x00052E18 File Offset: 0x00051018
		[Token(Token = "0x600E541")]
		[Address(RVA = "0x5982F0", Offset = "0x596EF0", VA = "0x1805982F0")]
		public int FilterTiles(IList<IDrawableRange> ranges, Action<Tile> cb)
		{
			return 0;
		}

		// Token: 0x0600E542 RID: 58690 RVA: 0x00052E30 File Offset: 0x00051030
		[Token(Token = "0x600E542")]
		[Address(RVA = "0x59A970", Offset = "0x599570", VA = "0x18059A970")]
		public float GetTileHeight(TileData.HeightType heightTile)
		{
			return 0f;
		}

		// Token: 0x0600E543 RID: 58691 RVA: 0x00052E48 File Offset: 0x00051048
		[Token(Token = "0x600E543")]
		[Address(RVA = "0x59D830", Offset = "0x59C430", VA = "0x18059D830")]
		public bool TryGetCameraView(out Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x0600E544 RID: 58692 RVA: 0x00052E60 File Offset: 0x00051060
		[Token(Token = "0x600E544")]
		[Address(RVA = "0x5977A0", Offset = "0x5963A0", VA = "0x1805977A0")]
		public bool CheckHasTag(string tag)
		{
			return default(bool);
		}

		// Token: 0x0600E545 RID: 58693 RVA: 0x00052E78 File Offset: 0x00051078
		[Token(Token = "0x600E545")]
		[Address(RVA = "0x599C40", Offset = "0x598840", VA = "0x180599C40")]
		public int GetMapLayerCount()
		{
			return 0;
		}

		// Token: 0x0600E546 RID: 58694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E546")]
		[Address(RVA = "0x5A0060", Offset = "0x59EC60", VA = "0x1805A0060")]
		private void _InitMapLayers()
		{
		}

		// Token: 0x0600E547 RID: 58695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E547")]
		[Address(RVA = "0x5A0810", Offset = "0x59F410", VA = "0x1805A0810")]
		private void _InitSceneEffects()
		{
		}

		// Token: 0x0600E548 RID: 58696 RVA: 0x00052E90 File Offset: 0x00051090
		[Token(Token = "0x600E548")]
		[Address(RVA = "0x5981F0", Offset = "0x596DF0", VA = "0x1805981F0")]
		private int Comparison(BaseSceneEffect x, BaseSceneEffect y)
		{
			return 0;
		}

		// Token: 0x0600E549 RID: 58697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E549")]
		[Address(RVA = "0x5A1450", Offset = "0x5A0050", VA = "0x1805A1450")]
		private void _ProcessSpineShaderReplace(BaseSceneEffect sceneEffect)
		{
		}

		// Token: 0x0600E54A RID: 58698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E54A")]
		[Address(RVA = "0x59FBB0", Offset = "0x59E7B0", VA = "0x18059FBB0")]
		private void _InitControllerByTags()
		{
		}

		// Token: 0x0600E54B RID: 58699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E54B")]
		[Address(RVA = "0x59F9F0", Offset = "0x59E5F0", VA = "0x18059F9F0")]
		private static MapController _CreateController(MapTags tag)
		{
			return null;
		}

		// Token: 0x0600E54C RID: 58700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E54C")]
		[Address(RVA = "0x5994E0", Offset = "0x5980E0", VA = "0x1805994E0")]
		public BaseSceneEffect GetFirstSceneEffect(Predicate<BaseSceneEffect> predicate)
		{
			return null;
		}

		// Token: 0x0600E54D RID: 58701 RVA: 0x00052EA8 File Offset: 0x000510A8
		[Token(Token = "0x600E54D")]
		[Address(RVA = "0x599A20", Offset = "0x598620", VA = "0x180599A20")]
		public Vector3 GetLayerCenters(MapLayer layer)
		{
			return default(Vector3);
		}

		// Token: 0x0600E54E RID: 58702 RVA: 0x00052EC0 File Offset: 0x000510C0
		[Token(Token = "0x600E54E")]
		[Address(RVA = "0x599900", Offset = "0x598500", VA = "0x180599900")]
		public Vector3 GetLayerCenters(PlayerSide playerSide)
		{
			return default(Vector3);
		}

		// Token: 0x0600E54F RID: 58703 RVA: 0x00052ED8 File Offset: 0x000510D8
		[Token(Token = "0x600E54F")]
		[Address(RVA = "0x59A360", Offset = "0x598F60", VA = "0x18059A360")]
		public PlayerSide GetPlayerSide(MapLayer mapLayer)
		{
			return PlayerSide.DEFAULT;
		}

		// Token: 0x0600E550 RID: 58704 RVA: 0x00052EF0 File Offset: 0x000510F0
		[Token(Token = "0x600E550")]
		[Address(RVA = "0x59A2C0", Offset = "0x598EC0", VA = "0x18059A2C0")]
		public MapLayer GetPlayerLayer(PlayerSide playerSide)
		{
			return MapLayer.LAYER_A;
		}

		// Token: 0x0600E551 RID: 58705 RVA: 0x00052F08 File Offset: 0x00051108
		[Token(Token = "0x600E551")]
		[Address(RVA = "0x59DD00", Offset = "0x59C900", VA = "0x18059DD00")]
		public bool TryGetNextLayersTile(Tile inTile, out Tile outTile)
		{
			return default(bool);
		}

		// Token: 0x0600E552 RID: 58706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E552")]
		[Address(RVA = "0x5973C0", Offset = "0x595FC0", VA = "0x1805973C0")]
		public void AddTileUpdateable(IUpdateable tileItem)
		{
		}

		// Token: 0x0600E553 RID: 58707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E553")]
		[Address(RVA = "0x59C800", Offset = "0x59B400", VA = "0x18059C800")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x0600E554 RID: 58708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E554")]
		[Address(RVA = "0x59C690", Offset = "0x59B290", VA = "0x18059C690")]
		public void OnBattleFinish(object arg)
		{
		}

		// Token: 0x0600E555 RID: 58709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E555")]
		[Address(RVA = "0x59D210", Offset = "0x59BE10", VA = "0x18059D210")]
		public void Reset()
		{
		}

		// Token: 0x0600E556 RID: 58710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E556")]
		[Address(RVA = "0x5A0D10", Offset = "0x59F910", VA = "0x1805A0D10")]
		private void _InitTilesAndWidgets(MapData mapData, IList<GridPosition> tilesDisallowToLocate)
		{
		}

		// Token: 0x0600E557 RID: 58711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E557")]
		[Address(RVA = "0x5A0330", Offset = "0x59EF30", VA = "0x1805A0330")]
		private void _InitRoutesAndPassableMaps(RouteData[] routesData, RouteData[] extraRoutesData)
		{
		}

		// Token: 0x0600E558 RID: 58712 RVA: 0x00052F20 File Offset: 0x00051120
		[Token(Token = "0x600E558")]
		[Address(RVA = "0x5A1A20", Offset = "0x5A0620", VA = "0x1805A1A20")]
		private bool _VerifyData(MapData mapData)
		{
			return default(bool);
		}

		// Token: 0x0600E559 RID: 58713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E559")]
		[Address(RVA = "0x59C9C0", Offset = "0x59B5C0", VA = "0x18059C9C0")]
		public void RefreshMeshThemeConfig()
		{
		}

		// Token: 0x0600E55A RID: 58714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E55A")]
		[Address(RVA = "0x598890", Offset = "0x597490", VA = "0x180598890")]
		public Route GenerateRuntimeRoute(uint key, RouteData data)
		{
			return null;
		}

		// Token: 0x0600E55B RID: 58715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E55B")]
		[Address(RVA = "0x598A50", Offset = "0x597650", VA = "0x180598A50")]
		public Route GenerateRuntimeRoute(RouteData data)
		{
			return null;
		}

		// Token: 0x0600E55C RID: 58716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E55C")]
		[Address(RVA = "0x598790", Offset = "0x597390", VA = "0x180598790")]
		public Route GenerateRuntimeRoute(RouteData data, IPathFinding pathFinding)
		{
			return null;
		}

		// Token: 0x0600E55D RID: 58717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E55D")]
		[Address(RVA = "0x59EA60", Offset = "0x59D660", VA = "0x18059EA60")]
		public void TryRemoveRuntimeRoute(uint key)
		{
		}

		// Token: 0x0600E55E RID: 58718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E55E")]
		[Address(RVA = "0x598B40", Offset = "0x597740", VA = "0x180598B40")]
		public Route GenerateRuntimeTraceRoute(GridPosition tracePosition, MotionMode motionMode)
		{
			return null;
		}

		// Token: 0x0600E55F RID: 58719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E55F")]
		[Address(RVA = "0x598650", Offset = "0x597250", VA = "0x180598650")]
		public Route GenerateRuntimeExtraRoute(GridPosition gridPosition, RouteData routeData)
		{
			return null;
		}

		// Token: 0x0600E560 RID: 58720 RVA: 0x00052F38 File Offset: 0x00051138
		[Token(Token = "0x600E560")]
		[Address(RVA = "0x59CCF0", Offset = "0x59B8F0", VA = "0x18059CCF0")]
		public bool RemoveRuntimeExtraRoute(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x0600E561 RID: 58721 RVA: 0x00052F50 File Offset: 0x00051150
		[Token(Token = "0x600E561")]
		[Address(RVA = "0x59D500", Offset = "0x59C100", VA = "0x18059D500")]
		public bool TryCalculatePathFindingDistance(MotionMode motionMode, GridPosition targetPos, GridPosition startPos, out int distance)
		{
			return default(bool);
		}

		// Token: 0x0600E562 RID: 58722 RVA: 0x00052F68 File Offset: 0x00051168
		[Token(Token = "0x600E562")]
		[Address(RVA = "0x59C580", Offset = "0x59B180", VA = "0x18059C580")]
		public Vector3 MapToWorldPosition(Vector2 mapPosition)
		{
			return default(Vector3);
		}

		// Token: 0x0600E563 RID: 58723 RVA: 0x00052F80 File Offset: 0x00051180
		[Token(Token = "0x600E563")]
		[Address(RVA = "0x59F900", Offset = "0x59E500", VA = "0x18059F900")]
		public Vector2 WorldToMapPosition(Vector3 worldPosition)
		{
			return default(Vector2);
		}

		// Token: 0x0600E564 RID: 58724 RVA: 0x00052F98 File Offset: 0x00051198
		[Token(Token = "0x600E564")]
		[Address(RVA = "0x59C490", Offset = "0x59B090", VA = "0x18059C490")]
		public Vector3 MapToWorldPositionV3(Vector3 mapPosition)
		{
			return default(Vector3);
		}

		// Token: 0x0600E565 RID: 58725 RVA: 0x00052FB0 File Offset: 0x000511B0
		[Token(Token = "0x600E565")]
		[Address(RVA = "0x59AC00", Offset = "0x599800", VA = "0x18059AC00")]
		public Vector3 GetTilesCenterWorldPosition(IList<GridPosition> tiles)
		{
			return default(Vector3);
		}

		// Token: 0x0600E566 RID: 58726 RVA: 0x00052FC8 File Offset: 0x000511C8
		[Token(Token = "0x600E566")]
		[Address(RVA = "0x59E840", Offset = "0x59D440", VA = "0x18059E840")]
		public bool TryGetWorldPositionByGridPosition(GridPosition gridPos, out Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x0600E567 RID: 58727 RVA: 0x00052FE0 File Offset: 0x000511E0
		[Token(Token = "0x600E567")]
		[Address(RVA = "0x59F730", Offset = "0x59E330", VA = "0x18059F730")]
		public GridPosition WorldToGridPosition(Vector3 worldPosition)
		{
			return default(GridPosition);
		}

		// Token: 0x0600E568 RID: 58728 RVA: 0x00052FF8 File Offset: 0x000511F8
		[Token(Token = "0x600E568")]
		[Address(RVA = "0x59DA80", Offset = "0x59C680", VA = "0x18059DA80")]
		public bool TryGetGridPosByWorldPosition(Vector3 worldPos, out GridPosition gridPos)
		{
			return default(bool);
		}

		// Token: 0x0600E569 RID: 58729 RVA: 0x00053010 File Offset: 0x00051210
		[Token(Token = "0x600E569")]
		[Address(RVA = "0x59F810", Offset = "0x59E410", VA = "0x18059F810")]
		public Vector3 WorldToMapPositionV3(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		// Token: 0x0600E56A RID: 58730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E56A")]
		[Address(RVA = "0x59A620", Offset = "0x599220", VA = "0x18059A620")]
		public Tile GetTileByScreenPos(Vector2 screenPos, out Vector2 mapPos)
		{
			return null;
		}

		// Token: 0x0600E56B RID: 58731 RVA: 0x00053028 File Offset: 0x00051228
		[Token(Token = "0x600E56B")]
		[Address(RVA = "0x599CD0", Offset = "0x5988D0", VA = "0x180599CD0")]
		public bool GetMapPosByScreenPos(Vector2 screenPos, out Vector2 mapPos)
		{
			return default(bool);
		}

		// Token: 0x0600E56C RID: 58732 RVA: 0x00053040 File Offset: 0x00051240
		[Token(Token = "0x600E56C")]
		[Address(RVA = "0x59C3A0", Offset = "0x59AFA0", VA = "0x18059C3A0")]
		public bool IsPosOutOfScreen(Vector2 screenPos)
		{
			return default(bool);
		}

		// Token: 0x0600E56D RID: 58733 RVA: 0x00053058 File Offset: 0x00051258
		[Token(Token = "0x600E56D")]
		[Address(RVA = "0x59B250", Offset = "0x599E50", VA = "0x18059B250")]
		public bool GetWorldPosByScreenPos(Vector2 screenPos, out Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x0600E56E RID: 58734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E56E")]
		[Address(RVA = "0x59CB40", Offset = "0x59B740", VA = "0x18059CB40")]
		public void RegisterTileBind(string key, Tile tile)
		{
		}

		// Token: 0x0600E56F RID: 58735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E56F")]
		[Address(RVA = "0x5A1680", Offset = "0x5A0280", VA = "0x1805A1680")]
		private void _ProcessTileBind()
		{
		}

		// Token: 0x0600E570 RID: 58736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E570")]
		[Address(RVA = "0x599080", Offset = "0x597C80", VA = "0x180599080")]
		public List<Tile> GetBindingTiles(Tile tile)
		{
			return null;
		}

		// Token: 0x0600E571 RID: 58737 RVA: 0x00053070 File Offset: 0x00051270
		[Token(Token = "0x600E571")]
		[Address(RVA = "0x597700", Offset = "0x596300", VA = "0x180597700")]
		public bool CheckGridValid(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600E572 RID: 58738 RVA: 0x00053088 File Offset: 0x00051288
		[Token(Token = "0x600E572")]
		[Address(RVA = "0x597CE0", Offset = "0x5968E0", VA = "0x180597CE0")]
		public bool CheckTileValid(int row, int col)
		{
			return default(bool);
		}

		// Token: 0x0600E573 RID: 58739 RVA: 0x000530A0 File Offset: 0x000512A0
		[Token(Token = "0x600E573")]
		[Address(RVA = "0x597F00", Offset = "0x596B00", VA = "0x180597F00")]
		public bool CheckWithinLayerRect(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E574 RID: 58740 RVA: 0x000530B8 File Offset: 0x000512B8
		[Token(Token = "0x600E574")]
		[Address(RVA = "0x59E310", Offset = "0x59CF10", VA = "0x18059E310")]
		public bool TryGetTile(GridPosition pos, out Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E575 RID: 58741 RVA: 0x000530D0 File Offset: 0x000512D0
		[Token(Token = "0x600E575")]
		[Address(RVA = "0x59E630", Offset = "0x59D230", VA = "0x18059E630")]
		public bool TryGetTiles(IDrawableRange range, List<Tile> updateTiles)
		{
			return default(bool);
		}

		// Token: 0x0600E576 RID: 58742 RVA: 0x000530E8 File Offset: 0x000512E8
		[Token(Token = "0x600E576")]
		[Address(RVA = "0x59E420", Offset = "0x59D020", VA = "0x18059E420")]
		public bool TryGetTilesByOrigin(IDrawableRange range, List<Tile> updateTiles)
		{
			return default(bool);
		}

		// Token: 0x0600E577 RID: 58743 RVA: 0x00053100 File Offset: 0x00051300
		[Token(Token = "0x600E577")]
		[Address(RVA = "0x59D930", Offset = "0x59C530", VA = "0x18059D930")]
		public bool TryGetCharacterByPos(GridPosition pos, out Character character)
		{
			return default(bool);
		}

		// Token: 0x0600E578 RID: 58744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E578")]
		[Address(RVA = "0x59AB50", Offset = "0x599750", VA = "0x18059AB50")]
		public Tile GetTile(int row, int col)
		{
			return null;
		}

		// Token: 0x0600E579 RID: 58745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E579")]
		[Address(RVA = "0x59AAC0", Offset = "0x5996C0", VA = "0x18059AAC0")]
		public Tile GetTile(GridPosition pos)
		{
			return null;
		}

		// Token: 0x0600E57A RID: 58746 RVA: 0x00053118 File Offset: 0x00051318
		[Token(Token = "0x600E57A")]
		[Address(RVA = "0x59E000", Offset = "0x59CC00", VA = "0x18059E000")]
		public bool TryGetTargetBehindTile(Entity entity, out Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E57B RID: 58747 RVA: 0x00053130 File Offset: 0x00051330
		[Token(Token = "0x600E57B")]
		[Address(RVA = "0x59D6A0", Offset = "0x59C2A0", VA = "0x18059D6A0")]
		public bool TryGetAroundTileByDirection(Vector2 curMapPos, SharedConsts.Direction direction, out Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E57C RID: 58748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E57C")]
		[Address(RVA = "0x59A510", Offset = "0x599110", VA = "0x18059A510")]
		public Route GetRouteOrNull(int index, bool isExtraRoute)
		{
			return null;
		}

		// Token: 0x0600E57D RID: 58749 RVA: 0x00053148 File Offset: 0x00051348
		[Token(Token = "0x600E57D")]
		[Address(RVA = "0x59A430", Offset = "0x599030", VA = "0x18059A430")]
		public int GetRouteIndex(Route route)
		{
			return 0;
		}

		// Token: 0x0600E57E RID: 58750 RVA: 0x00053160 File Offset: 0x00051360
		[Token(Token = "0x600E57E")]
		[Address(RVA = "0x599400", Offset = "0x598000", VA = "0x180599400")]
		public int GetExtraRouteIndex(Route route)
		{
			return 0;
		}

		// Token: 0x0600E57F RID: 58751 RVA: 0x00053178 File Offset: 0x00051378
		[Token(Token = "0x600E57F")]
		[Address(RVA = "0x599650", Offset = "0x598250", VA = "0x180599650")]
		public int GetGotoDirectionalPassableMask(GridPosition pos, MotionMode motion)
		{
			return 0;
		}

		// Token: 0x0600E580 RID: 58752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E580")]
		public ControllerT GetMapController<ControllerT>(MapTags tag) where ControllerT : MapController
		{
			return null;
		}

		// Token: 0x0600E581 RID: 58753 RVA: 0x00053190 File Offset: 0x00051390
		[Token(Token = "0x600E581")]
		[Address(RVA = "0x599170", Offset = "0x597D70", VA = "0x180599170")]
		public Vector2 GetDirectionToGoBackFromInvalidPos(GridPosition pos)
		{
			return default(Vector2);
		}

		// Token: 0x0600E582 RID: 58754 RVA: 0x000531A8 File Offset: 0x000513A8
		[Token(Token = "0x600E582")]
		[Address(RVA = "0x599E10", Offset = "0x598A10", VA = "0x180599E10")]
		public GridPosition? GetNearestEndPointTile(GridPosition sourcePos, MotionMode motionMode, out Route route, bool avoidObstacleLike = true)
		{
			return null;
		}

		// Token: 0x0600E583 RID: 58755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E583")]
		[Address(RVA = "0x598E50", Offset = "0x597A50", VA = "0x180598E50")]
		public static void GetAdjacentTilesEnemies(Tile tile, List<ObjectPtr<Enemy>> enemies)
		{
		}

		// Token: 0x0600E584 RID: 58756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E584")]
		[Address(RVA = "0x5A18E0", Offset = "0x5A04E0", VA = "0x1805A18E0")]
		private void _UpdateAnchorToCenter()
		{
		}

		// Token: 0x0600E585 RID: 58757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E585")]
		[Address(RVA = "0x59FAE0", Offset = "0x59E6E0", VA = "0x18059FAE0")]
		private Tile _CreateTile(TileData tileData, BattleFactory factory)
		{
			return null;
		}

		// Token: 0x0600E586 RID: 58758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E586")]
		[Address(RVA = "0x5A1DF0", Offset = "0x5A09F0", VA = "0x1805A1DF0")]
		public Map()
		{
		}

		// Token: 0x0400FCA6 RID: 64678
		[Token(Token = "0x400FCA6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _anchorTransform;

		// Token: 0x0400FCA7 RID: 64679
		[Token(Token = "0x400FCA7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _tilesContainer;

		// Token: 0x0400FCA8 RID: 64680
		[Token(Token = "0x400FCA8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _graphicContainer;

		// Token: 0x0400FCA9 RID: 64681
		[Token(Token = "0x400FCA9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Map.Tiles2D _tiles;

		// Token: 0x0400FCAA RID: 64682
		[Token(Token = "0x400FCAA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MapData.Edge[] _blockedEdges;

		// Token: 0x0400FCAB RID: 64683
		[Token(Token = "0x400FCAB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DeathArea _deathArea;

		// Token: 0x0400FCAC RID: 64684
		[Token(Token = "0x400FCAC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MapGraphic _graphic;

		// Token: 0x0400FCAD RID: 64685
		[Token(Token = "0x400FCAD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _tileMoveTime;

		// Token: 0x0400FCAE RID: 64686
		[Token(Token = "0x400FCAE")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Ease _tileMoveEase;

		// Token: 0x0400FCAF RID: 64687
		[Token(Token = "0x400FCAF")]
		[FieldOffset(Offset = "0x58")]
		private MapData m_data;

		// Token: 0x0400FCB0 RID: 64688
		[Token(Token = "0x400FCB0")]
		[FieldOffset(Offset = "0x60")]
		private MapWidget[] m_widgets;

		// Token: 0x0400FCB1 RID: 64689
		[Token(Token = "0x400FCB1")]
		[FieldOffset(Offset = "0x68")]
		private bool[][,] m_passableMaps;

		// Token: 0x0400FCB2 RID: 64690
		[Token(Token = "0x400FCB2")]
		[FieldOffset(Offset = "0x70")]
		private Route[] m_routes;

		// Token: 0x0400FCB3 RID: 64691
		[Token(Token = "0x400FCB3")]
		[FieldOffset(Offset = "0x78")]
		private Route[] m_extraRoutes;

		// Token: 0x0400FCB4 RID: 64692
		[Token(Token = "0x400FCB4")]
		[FieldOffset(Offset = "0x80")]
		private ListDict<uint, Route> m_runtimeRoutes;

		// Token: 0x0400FCB5 RID: 64693
		[Token(Token = "0x400FCB5")]
		[FieldOffset(Offset = "0x88")]
		private ListDict<GridPosition, Route> m_runtimeTraceRoutes;

		// Token: 0x0400FCB6 RID: 64694
		[Token(Token = "0x400FCB6")]
		[FieldOffset(Offset = "0x90")]
		private readonly ListDict<GridPosition, Route> m_runtimeExtraRoutes;

		// Token: 0x0400FCB7 RID: 64695
		[Token(Token = "0x400FCB7")]
		[FieldOffset(Offset = "0x98")]
		private RaycastHit[] m_hitResults;

		// Token: 0x0400FCB8 RID: 64696
		[Token(Token = "0x400FCB8")]
		[FieldOffset(Offset = "0xA0")]
		private List<IUpdateable> m_updateableTiles;

		// Token: 0x0400FCB9 RID: 64697
		[Token(Token = "0x400FCB9")]
		[FieldOffset(Offset = "0xA8")]
		private System.Random m_random;

		// Token: 0x0400FCBA RID: 64698
		[Token(Token = "0x400FCBA")]
		[FieldOffset(Offset = "0xB0")]
		private IPathFinding m_pathFinding;

		// Token: 0x0400FCBB RID: 64699
		[Token(Token = "0x400FCBB")]
		[FieldOffset(Offset = "0xB8")]
		private MapThemeController m_themeController;

		// Token: 0x0400FCBC RID: 64700
		[Token(Token = "0x400FCBC")]
		[FieldOffset(Offset = "0xC0")]
		private ListDict<MapTags, MapController> m_mapControllers;

		// Token: 0x0400FCBD RID: 64701
		[Token(Token = "0x400FCBD")]
		[FieldOffset(Offset = "0xC8")]
		private readonly ListDict<string, List<Tile>> m_bindKeyToTilesDict;

		// Token: 0x0400FCBE RID: 64702
		[Token(Token = "0x400FCBE")]
		[FieldOffset(Offset = "0xD0")]
		private readonly ListDict<Tile, List<Tile>> m_tileToBindingTilesDict;

		// Token: 0x0400FCBF RID: 64703
		[Token(Token = "0x400FCBF")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_buildableDirty;

		// Token: 0x0400FCC0 RID: 64704
		[Token(Token = "0x400FCC0")]
		[FieldOffset(Offset = "0xE0")]
		private readonly List<Rect> m_mapLayerRects;

		// Token: 0x0400FCC1 RID: 64705
		[Token(Token = "0x400FCC1")]
		[FieldOffset(Offset = "0xE8")]
		private readonly List<Vector3> m_mapLayerCenters;

		// Token: 0x0400FCC2 RID: 64706
		[Token(Token = "0x400FCC2")]
		[FieldOffset(Offset = "0xF0")]
		private BaseSceneEffect[] m_sceneEffects;

		// Token: 0x0400FCC3 RID: 64707
		[Token(Token = "0x400FCC3")]
		[FieldOffset(Offset = "0xF8")]
		private readonly List<Tile> m_endTiles;

		// Token: 0x0400FCC4 RID: 64708
		[Token(Token = "0x400FCC4")]
		private const string BLOCKED_EDGE_PREFAB = "edge";

		// Token: 0x0400FCC5 RID: 64709
		[Token(Token = "0x400FCC5")]
		private const float RAYCAST_THICKNESS_HALF = 0.005f;

		// Token: 0x0400FCC6 RID: 64710
		[Token(Token = "0x400FCC6")]
		[FieldOffset(Offset = "0x0")]
		private static Plane s_highlandPlane;

		// Token: 0x0400FCC7 RID: 64711
		[Token(Token = "0x400FCC7")]
		[FieldOffset(Offset = "0x10")]
		private static Plane s_lowlandPlane;

		// Token: 0x0400FCC8 RID: 64712
		[Token(Token = "0x400FCC8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isMultiLayerMap;

		// Token: 0x0400FCC9 RID: 64713
		[Token(Token = "0x400FCC9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isMagicCircuitMap;

		// Token: 0x0400FCCA RID: 64714
		[Token(Token = "0x400FCCA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_tileMoveTime;

		// Token: 0x0400FCCB RID: 64715
		[Token(Token = "0x400FCCB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_tileMoveEase;

		// Token: 0x0400FCCC RID: 64716
		[Token(Token = "0x400FCCC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_tiles;

		// Token: 0x0400FCCD RID: 64717
		[Token(Token = "0x400FCCD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_endPosTiles;

		// Token: 0x0400FCCE RID: 64718
		[Token(Token = "0x400FCCE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_width;

		// Token: 0x0400FCCF RID: 64719
		[Token(Token = "0x400FCCF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_height;

		// Token: 0x0400FCD0 RID: 64720
		[Token(Token = "0x400FCD0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x0400FCD1 RID: 64721
		[Token(Token = "0x400FCD1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_buildableDirty;

		// Token: 0x0400FCD2 RID: 64722
		[Token(Token = "0x400FCD2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_cameraView;

		// Token: 0x0400FCD3 RID: 64723
		[Token(Token = "0x400FCD3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_cameraWorldPos;

		// Token: 0x0400FCD4 RID: 64724
		[Token(Token = "0x400FCD4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_cameraFocusPos;

		// Token: 0x0400FCD5 RID: 64725
		[Token(Token = "0x400FCD5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_battleAreaStartCol;

		// Token: 0x0400FCD6 RID: 64726
		[Token(Token = "0x400FCD6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_battleAreaEndCol;

		// Token: 0x0400FCD7 RID: 64727
		[Token(Token = "0x400FCD7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_anchorTransform;

		// Token: 0x0400FCD8 RID: 64728
		[Token(Token = "0x400FCD8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_tilesContainer;

		// Token: 0x0400FCD9 RID: 64729
		[Token(Token = "0x400FCD9")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_graphicContainer;

		// Token: 0x0400FCDA RID: 64730
		[Token(Token = "0x400FCDA")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_Item;

		// Token: 0x0400FCDB RID: 64731
		[Token(Token = "0x400FCDB")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix1_get_Item;

		// Token: 0x0400FCDC RID: 64732
		[Token(Token = "0x400FCDC")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0400FCDD RID: 64733
		[Token(Token = "0x400FCDD")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_themeController;

		// Token: 0x0400FCDE RID: 64734
		[Token(Token = "0x400FCDE")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_nightMapController;

		// Token: 0x0400FCDF RID: 64735
		[Token(Token = "0x400FCDF")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_magicCircuitController;

		// Token: 0x0400FCE0 RID: 64736
		[Token(Token = "0x400FCE0")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_random;

		// Token: 0x0400FCE1 RID: 64737
		[Token(Token = "0x400FCE1")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_mapTheme;

		// Token: 0x0400FCE2 RID: 64738
		[Token(Token = "0x400FCE2")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x0400FCE3 RID: 64739
		[Token(Token = "0x400FCE3")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FCE4 RID: 64740
		[Token(Token = "0x400FCE4")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_ResetSeed;

		// Token: 0x0400FCE5 RID: 64741
		[Token(Token = "0x400FCE5")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_InitRouteAndPassableMap;

		// Token: 0x0400FCE6 RID: 64742
		[Token(Token = "0x400FCE6")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_SetBuildableDirty;

		// Token: 0x0400FCE7 RID: 64743
		[Token(Token = "0x400FCE7")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_ClearAllRoutes;

		// Token: 0x0400FCE8 RID: 64744
		[Token(Token = "0x400FCE8")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_ReplaceAllRoutes;

		// Token: 0x0400FCE9 RID: 64745
		[Token(Token = "0x400FCE9")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_UpdateAllRoutes;

		// Token: 0x0400FCEA RID: 64746
		[Token(Token = "0x400FCEA")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_UpdateRoutes;

		// Token: 0x0400FCEB RID: 64747
		[Token(Token = "0x400FCEB")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_UpdateAllRoutesOffset;

		// Token: 0x0400FCEC RID: 64748
		[Token(Token = "0x400FCEC")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__ProcessRoutes;

		// Token: 0x0400FCED RID: 64749
		[Token(Token = "0x400FCED")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix1__ProcessRoutes;

		// Token: 0x0400FCEE RID: 64750
		[Token(Token = "0x400FCEE")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_CheckAllRoutesReachable;

		// Token: 0x0400FCEF RID: 64751
		[Token(Token = "0x400FCEF")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_CheckReachable;

		// Token: 0x0400FCF0 RID: 64752
		[Token(Token = "0x400FCF0")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_GetPassableMap;

		// Token: 0x0400FCF1 RID: 64753
		[Token(Token = "0x400FCF1")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_CheckPassable;

		// Token: 0x0400FCF2 RID: 64754
		[Token(Token = "0x400FCF2")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_CheckObstacleLikeOrUnpassable;

		// Token: 0x0400FCF3 RID: 64755
		[Token(Token = "0x400FCF3")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_UpdatePassableMap;

		// Token: 0x0400FCF4 RID: 64756
		[Token(Token = "0x400FCF4")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_TryGetInitialLOrR;

		// Token: 0x0400FCF5 RID: 64757
		[Token(Token = "0x400FCF5")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_ImportData;

		// Token: 0x0400FCF6 RID: 64758
		[Token(Token = "0x400FCF6")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_FilterTiles;

		// Token: 0x0400FCF7 RID: 64759
		[Token(Token = "0x400FCF7")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix1_FilterTiles;

		// Token: 0x0400FCF8 RID: 64760
		[Token(Token = "0x400FCF8")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_GetTileHeight;

		// Token: 0x0400FCF9 RID: 64761
		[Token(Token = "0x400FCF9")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_TryGetCameraView;

		// Token: 0x0400FCFA RID: 64762
		[Token(Token = "0x400FCFA")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_CheckHasTag;

		// Token: 0x0400FCFB RID: 64763
		[Token(Token = "0x400FCFB")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_GetMapLayerCount;

		// Token: 0x0400FCFC RID: 64764
		[Token(Token = "0x400FCFC")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__InitMapLayers;

		// Token: 0x0400FCFD RID: 64765
		[Token(Token = "0x400FCFD")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__InitSceneEffects;

		// Token: 0x0400FCFE RID: 64766
		[Token(Token = "0x400FCFE")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_Comparison;

		// Token: 0x0400FCFF RID: 64767
		[Token(Token = "0x400FCFF")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__ProcessSpineShaderReplace;

		// Token: 0x0400FD00 RID: 64768
		[Token(Token = "0x400FD00")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__InitControllerByTags;

		// Token: 0x0400FD01 RID: 64769
		[Token(Token = "0x400FD01")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__CreateController;

		// Token: 0x0400FD02 RID: 64770
		[Token(Token = "0x400FD02")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_GetFirstSceneEffect;

		// Token: 0x0400FD03 RID: 64771
		[Token(Token = "0x400FD03")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_GetLayerCenters;

		// Token: 0x0400FD04 RID: 64772
		[Token(Token = "0x400FD04")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix1_GetLayerCenters;

		// Token: 0x0400FD05 RID: 64773
		[Token(Token = "0x400FD05")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_GetPlayerSide;

		// Token: 0x0400FD06 RID: 64774
		[Token(Token = "0x400FD06")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_GetPlayerLayer;

		// Token: 0x0400FD07 RID: 64775
		[Token(Token = "0x400FD07")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_TryGetNextLayersTile;

		// Token: 0x0400FD08 RID: 64776
		[Token(Token = "0x400FD08")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_AddTileUpdateable;

		// Token: 0x0400FD09 RID: 64777
		[Token(Token = "0x400FD09")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x0400FD0A RID: 64778
		[Token(Token = "0x400FD0A")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_OnBattleFinish;

		// Token: 0x0400FD0B RID: 64779
		[Token(Token = "0x400FD0B")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0400FD0C RID: 64780
		[Token(Token = "0x400FD0C")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0__InitTilesAndWidgets;

		// Token: 0x0400FD0D RID: 64781
		[Token(Token = "0x400FD0D")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0__InitRoutesAndPassableMaps;

		// Token: 0x0400FD0E RID: 64782
		[Token(Token = "0x400FD0E")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0__VerifyData;

		// Token: 0x0400FD0F RID: 64783
		[Token(Token = "0x400FD0F")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_RefreshMeshThemeConfig;

		// Token: 0x0400FD10 RID: 64784
		[Token(Token = "0x400FD10")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_GenerateRuntimeRoute;

		// Token: 0x0400FD11 RID: 64785
		[Token(Token = "0x400FD11")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix1_GenerateRuntimeRoute;

		// Token: 0x0400FD12 RID: 64786
		[Token(Token = "0x400FD12")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix2_GenerateRuntimeRoute;

		// Token: 0x0400FD13 RID: 64787
		[Token(Token = "0x400FD13")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_TryRemoveRuntimeRoute;

		// Token: 0x0400FD14 RID: 64788
		[Token(Token = "0x400FD14")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_GenerateRuntimeTraceRoute;

		// Token: 0x0400FD15 RID: 64789
		[Token(Token = "0x400FD15")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_GenerateRuntimeExtraRoute;

		// Token: 0x0400FD16 RID: 64790
		[Token(Token = "0x400FD16")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_RemoveRuntimeExtraRoute;

		// Token: 0x0400FD17 RID: 64791
		[Token(Token = "0x400FD17")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_TryCalculatePathFindingDistance;

		// Token: 0x0400FD18 RID: 64792
		[Token(Token = "0x400FD18")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_MapToWorldPosition;

		// Token: 0x0400FD19 RID: 64793
		[Token(Token = "0x400FD19")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_WorldToMapPosition;

		// Token: 0x0400FD1A RID: 64794
		[Token(Token = "0x400FD1A")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_MapToWorldPositionV3;

		// Token: 0x0400FD1B RID: 64795
		[Token(Token = "0x400FD1B")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_GetTilesCenterWorldPosition;

		// Token: 0x0400FD1C RID: 64796
		[Token(Token = "0x400FD1C")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_TryGetWorldPositionByGridPosition;

		// Token: 0x0400FD1D RID: 64797
		[Token(Token = "0x400FD1D")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_WorldToGridPosition;

		// Token: 0x0400FD1E RID: 64798
		[Token(Token = "0x400FD1E")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_TryGetGridPosByWorldPosition;

		// Token: 0x0400FD1F RID: 64799
		[Token(Token = "0x400FD1F")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_WorldToMapPositionV3;

		// Token: 0x0400FD20 RID: 64800
		[Token(Token = "0x400FD20")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_GetTileByScreenPos;

		// Token: 0x0400FD21 RID: 64801
		[Token(Token = "0x400FD21")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_GetMapPosByScreenPos;

		// Token: 0x0400FD22 RID: 64802
		[Token(Token = "0x400FD22")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_IsPosOutOfScreen;

		// Token: 0x0400FD23 RID: 64803
		[Token(Token = "0x400FD23")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_GetWorldPosByScreenPos;

		// Token: 0x0400FD24 RID: 64804
		[Token(Token = "0x400FD24")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_RegisterTileBind;

		// Token: 0x0400FD25 RID: 64805
		[Token(Token = "0x400FD25")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0__ProcessTileBind;

		// Token: 0x0400FD26 RID: 64806
		[Token(Token = "0x400FD26")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_GetBindingTiles;

		// Token: 0x0400FD27 RID: 64807
		[Token(Token = "0x400FD27")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_CheckGridValid;

		// Token: 0x0400FD28 RID: 64808
		[Token(Token = "0x400FD28")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_CheckTileValid;

		// Token: 0x0400FD29 RID: 64809
		[Token(Token = "0x400FD29")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_CheckWithinLayerRect;

		// Token: 0x0400FD2A RID: 64810
		[Token(Token = "0x400FD2A")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_TryGetTile;

		// Token: 0x0400FD2B RID: 64811
		[Token(Token = "0x400FD2B")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_TryGetTiles;

		// Token: 0x0400FD2C RID: 64812
		[Token(Token = "0x400FD2C")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_TryGetTilesByOrigin;

		// Token: 0x0400FD2D RID: 64813
		[Token(Token = "0x400FD2D")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_TryGetCharacterByPos;

		// Token: 0x0400FD2E RID: 64814
		[Token(Token = "0x400FD2E")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_GetTile;

		// Token: 0x0400FD2F RID: 64815
		[Token(Token = "0x400FD2F")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix1_GetTile;

		// Token: 0x0400FD30 RID: 64816
		[Token(Token = "0x400FD30")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_TryGetTargetBehindTile;

		// Token: 0x0400FD31 RID: 64817
		[Token(Token = "0x400FD31")]
		[FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_TryGetAroundTileByDirection;

		// Token: 0x0400FD32 RID: 64818
		[Token(Token = "0x400FD32")]
		[FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_GetRouteOrNull;

		// Token: 0x0400FD33 RID: 64819
		[Token(Token = "0x400FD33")]
		[FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_GetRouteIndex;

		// Token: 0x0400FD34 RID: 64820
		[Token(Token = "0x400FD34")]
		[FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_GetExtraRouteIndex;

		// Token: 0x0400FD35 RID: 64821
		[Token(Token = "0x400FD35")]
		[FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_GetGotoDirectionalPassableMask;

		// Token: 0x0400FD36 RID: 64822
		[Token(Token = "0x400FD36")]
		[FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_GetMapController;

		// Token: 0x0400FD37 RID: 64823
		[Token(Token = "0x400FD37")]
		[FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_GetDirectionToGoBackFromInvalidPos;

		// Token: 0x0400FD38 RID: 64824
		[Token(Token = "0x400FD38")]
		[FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_GetNearestEndPointTile;

		// Token: 0x0400FD39 RID: 64825
		[Token(Token = "0x400FD39")]
		[FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_GetAdjacentTilesEnemies;

		// Token: 0x0400FD3A RID: 64826
		[Token(Token = "0x400FD3A")]
		[FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0__UpdateAnchorToCenter;

		// Token: 0x0400FD3B RID: 64827
		[Token(Token = "0x400FD3B")]
		[FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0__CreateTile;

		// Token: 0x0400FD3C RID: 64828
		[Token(Token = "0x400FD3C")]
		[FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200235C RID: 9052
		[Token(Token = "0x200235C")]
		[Serializable]
		public class Tiles2D
		{
			// Token: 0x17001CC3 RID: 7363
			// (get) Token: 0x0600E588 RID: 58760 RVA: 0x000531C0 File Offset: 0x000513C0
			[Token(Token = "0x17001CC3")]
			[Inspect]
			[ReadOnly]
			public int width
			{
				[Token(Token = "0x600E588")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001CC4 RID: 7364
			// (get) Token: 0x0600E589 RID: 58761 RVA: 0x000531D8 File Offset: 0x000513D8
			[Token(Token = "0x17001CC4")]
			[Inspect]
			[ReadOnly]
			public int height
			{
				[Token(Token = "0x600E589")]
				[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001CC5 RID: 7365
			[Token(Token = "0x17001CC5")]
			public Tile this[int row, int col]
			{
				[Token(Token = "0x600E58A")]
				[Address(RVA = "0x5CB350", Offset = "0x5C9F50", VA = "0x1805CB350")]
				get
				{
					return null;
				}
				[Token(Token = "0x600E58B")]
				[Address(RVA = "0x5CB3F0", Offset = "0x5C9FF0", VA = "0x1805CB3F0")]
				set
				{
				}
			}

			// Token: 0x0600E58C RID: 58764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E58C")]
			[Address(RVA = "0x5CB2D0", Offset = "0x5C9ED0", VA = "0x1805CB2D0")]
			public Tiles2D(int width, int height)
			{
			}

			// Token: 0x0600E58D RID: 58765 RVA: 0x000531F0 File Offset: 0x000513F0
			[Token(Token = "0x600E58D")]
			[Address(RVA = "0x5CB220", Offset = "0x5C9E20", VA = "0x1805CB220")]
			public bool CheckValid(GridPosition pos)
			{
				return default(bool);
			}

			// Token: 0x0600E58E RID: 58766 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600E58E")]
			[Address(RVA = "0x5CB240", Offset = "0x5C9E40", VA = "0x1805CB240", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400FD3D RID: 64829
			[Token(Token = "0x400FD3D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public Tile[] _tiles;

			// Token: 0x0400FD3E RID: 64830
			[Token(Token = "0x400FD3E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[HideInInspector]
			private int _width;

			// Token: 0x0400FD3F RID: 64831
			[Token(Token = "0x400FD3F")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[HideInInspector]
			private int _height;
		}
	}
}
