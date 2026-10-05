using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023A7 RID: 9127
	[Token(Token = "0x20023A7")]
	[SelectionBase]
	public class Tile : VisualObject, IHotfixable, IPtrObject, IComparable<Tile>
	{
		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x0600E783 RID: 59267 RVA: 0x000545D0 File Offset: 0x000527D0
		[Token(Token = "0x17001D13")]
		protected ObjectPtr<Character> buildSlot
		{
			[Token(Token = "0x600E783")]
			[Address(RVA = "0x5E6FC0", Offset = "0x5E5BC0", VA = "0x1805E6FC0")]
			get
			{
				return default(ObjectPtr<Character>);
			}
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x0600E784 RID: 59268 RVA: 0x000545E8 File Offset: 0x000527E8
		[Token(Token = "0x17001D14")]
		protected int tileBuildSlotsCount
		{
			[Token(Token = "0x600E784")]
			[Address(RVA = "0x5E88B0", Offset = "0x5E74B0", VA = "0x1805E88B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x0600E785 RID: 59269 RVA: 0x00054600 File Offset: 0x00052800
		[Token(Token = "0x17001D15")]
		public MotionMode charBlockMotionMode
		{
			[Token(Token = "0x600E785")]
			[Address(RVA = "0x5E72A0", Offset = "0x5E5EA0", VA = "0x1805E72A0")]
			get
			{
				return MotionMode.WALK;
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x0600E786 RID: 59270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D16")]
		private Tile.TileDynamicPositionController dynamicPositionController
		{
			[Token(Token = "0x600E786")]
			[Address(RVA = "0x5E73B0", Offset = "0x5E5FB0", VA = "0x1805E73B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x0600E787 RID: 59271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D17")]
		public IEnumerator<ObjectPtr<Character>> slotEnumerator
		{
			[Token(Token = "0x600E787")]
			[Address(RVA = "0x5E8830", Offset = "0x5E7430", VA = "0x1805E8830")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x0600E788 RID: 59272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D18")]
		public List<ITileBuildableChecker> extraBuildableCheckers
		{
			[Token(Token = "0x600E788")]
			[Address(RVA = "0x5E78D0", Offset = "0x5E64D0", VA = "0x1805E78D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x0600E789 RID: 59273 RVA: 0x00054618 File Offset: 0x00052818
		// (set) Token: 0x0600E78A RID: 59274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D19")]
		public uint instanceUid
		{
			[Token(Token = "0x600E789")]
			[Address(RVA = "0x5E7CB0", Offset = "0x5E68B0", VA = "0x1805E7CB0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600E78A")]
			[Address(RVA = "0x5E9130", Offset = "0x5E7D30", VA = "0x1805E9130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x0600E78B RID: 59275 RVA: 0x00054630 File Offset: 0x00052830
		[Token(Token = "0x17001D1A")]
		public new float height
		{
			[Token(Token = "0x600E78B")]
			[Address(RVA = "0x5E7AD0", Offset = "0x5E66D0", VA = "0x1805E7AD0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x0600E78C RID: 59276 RVA: 0x00054648 File Offset: 0x00052848
		// (set) Token: 0x0600E78D RID: 59277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D1B")]
		public bool enableOverlap
		{
			[Token(Token = "0x600E78C")]
			[Address(RVA = "0x5E7870", Offset = "0x5E6470", VA = "0x1805E7870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E78D")]
			[Address(RVA = "0x5E8D40", Offset = "0x5E7940", VA = "0x1805E8D40")]
			set
			{
			}
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x0600E78E RID: 59278 RVA: 0x00054660 File Offset: 0x00052860
		// (set) Token: 0x0600E78F RID: 59279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D1C")]
		public bool onlyManuallyOverlap
		{
			[Token(Token = "0x600E78E")]
			[Address(RVA = "0x5E85E0", Offset = "0x5E71E0", VA = "0x1805E85E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E78F")]
			[Address(RVA = "0x5E91A0", Offset = "0x5E7DA0", VA = "0x1805E91A0")]
			set
			{
			}
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x0600E790 RID: 59280 RVA: 0x00054678 File Offset: 0x00052878
		// (set) Token: 0x0600E791 RID: 59281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D1D")]
		public bool blockManuallySpawn
		{
			[Token(Token = "0x600E790")]
			[Address(RVA = "0x5E6F60", Offset = "0x5E5B60", VA = "0x1805E6F60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E791")]
			[Address(RVA = "0x5E8CD0", Offset = "0x5E78D0", VA = "0x1805E8CD0")]
			set
			{
			}
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x0600E792 RID: 59282 RVA: 0x00054690 File Offset: 0x00052890
		[Token(Token = "0x17001D1E")]
		public float locateHeight
		{
			[Token(Token = "0x600E792")]
			[Address(RVA = "0x5E82F0", Offset = "0x5E6EF0", VA = "0x1805E82F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x0600E793 RID: 59283 RVA: 0x000546A8 File Offset: 0x000528A8
		[Token(Token = "0x17001D1F")]
		public float additionalFriction
		{
			[Token(Token = "0x600E793")]
			[Address(RVA = "0x5E6D90", Offset = "0x5E5990", VA = "0x1805E6D90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x0600E794 RID: 59284 RVA: 0x000546C0 File Offset: 0x000528C0
		[Token(Token = "0x17001D20")]
		public bool isEndPosTile
		{
			[Token(Token = "0x600E794")]
			[Address(RVA = "0x5E7D10", Offset = "0x5E6910", VA = "0x1805E7D10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x0600E795 RID: 59285 RVA: 0x000546D8 File Offset: 0x000528D8
		[Token(Token = "0x17001D21")]
		public bool isStartPosTile
		{
			[Token(Token = "0x600E795")]
			[Address(RVA = "0x5E81A0", Offset = "0x5E6DA0", VA = "0x1805E81A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x0600E796 RID: 59286 RVA: 0x000546F0 File Offset: 0x000528F0
		[Token(Token = "0x17001D22")]
		public bool isTelTile
		{
			[Token(Token = "0x600E796")]
			[Address(RVA = "0x5E8230", Offset = "0x5E6E30", VA = "0x1805E8230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x0600E797 RID: 59287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D23")]
		public string tileKey
		{
			[Token(Token = "0x600E797")]
			[Address(RVA = "0x5E8B20", Offset = "0x5E7720", VA = "0x1805E8B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x0600E798 RID: 59288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D24")]
		public string tileName
		{
			[Token(Token = "0x600E798")]
			[Address(RVA = "0x5E8BA0", Offset = "0x5E77A0", VA = "0x1805E8BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x0600E799 RID: 59289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D25")]
		public string tileDescription
		{
			[Token(Token = "0x600E799")]
			[Address(RVA = "0x5E8A00", Offset = "0x5E7600", VA = "0x1805E8A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x0600E79A RID: 59290 RVA: 0x00054708 File Offset: 0x00052908
		[Token(Token = "0x17001D26")]
		public bool buildSlotsOverlapped
		{
			[Token(Token = "0x600E79A")]
			[Address(RVA = "0x5E71D0", Offset = "0x5E5DD0", VA = "0x1805E71D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x0600E79B RID: 59291 RVA: 0x00054720 File Offset: 0x00052920
		[Token(Token = "0x17001D27")]
		public bool buildSlotsOverlappedTwice
		{
			[Token(Token = "0x600E79B")]
			[Address(RVA = "0x5E7160", Offset = "0x5E5D60", VA = "0x1805E7160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x0600E79C RID: 59292 RVA: 0x00054738 File Offset: 0x00052938
		[Token(Token = "0x17001D28")]
		public TileTypesMask TileTypesMask
		{
			[Token(Token = "0x600E79C")]
			[Address(RVA = "0x5E6CD0", Offset = "0x5E58D0", VA = "0x1805E6CD0")]
			get
			{
				return TileTypesMask.NONE;
			}
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x0600E79D RID: 59293 RVA: 0x00054750 File Offset: 0x00052950
		[Token(Token = "0x17001D29")]
		public bool isFunctional
		{
			[Token(Token = "0x600E79D")]
			[Address(RVA = "0x5E7DA0", Offset = "0x5E69A0", VA = "0x1805E7DA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x0600E79E RID: 59294 RVA: 0x00054768 File Offset: 0x00052968
		[Token(Token = "0x17001D2A")]
		public Bounds mapBoundsFromHeight
		{
			[Token(Token = "0x600E79E")]
			[Address(RVA = "0x5E83E0", Offset = "0x5E6FE0", VA = "0x1805E83E0")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x0600E79F RID: 59295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D2B")]
		public TileGraphic graphic
		{
			[Token(Token = "0x600E79F")]
			[Address(RVA = "0x5E7A10", Offset = "0x5E6610", VA = "0x1805E7A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x0600E7A0 RID: 59296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D2C")]
		public List<TileGraphic> allGraphicList
		{
			[Token(Token = "0x600E7A0")]
			[Address(RVA = "0x5E6E50", Offset = "0x5E5A50", VA = "0x1805E6E50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x0600E7A1 RID: 59297 RVA: 0x00054780 File Offset: 0x00052980
		[Token(Token = "0x17001D2D")]
		public BuildableType buildableType
		{
			[Token(Token = "0x600E7A1")]
			[Address(RVA = "0x5E7240", Offset = "0x5E5E40", VA = "0x1805E7240")]
			get
			{
				return BuildableType.NONE;
			}
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x0600E7A2 RID: 59298 RVA: 0x00054798 File Offset: 0x00052998
		[Token(Token = "0x17001D2E")]
		public MotionMask passableMask
		{
			[Token(Token = "0x600E7A2")]
			[Address(RVA = "0x5E8720", Offset = "0x5E7320", VA = "0x1805E8720")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x0600E7A3 RID: 59299 RVA: 0x000547B0 File Offset: 0x000529B0
		[Token(Token = "0x17001D2F")]
		public TileData.HeightType heightType
		{
			[Token(Token = "0x600E7A3")]
			[Address(RVA = "0x5E7A70", Offset = "0x5E6670", VA = "0x1805E7A70")]
			get
			{
				return TileData.HeightType.LOWLAND;
			}
		}

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x0600E7A4 RID: 59300 RVA: 0x000547C8 File Offset: 0x000529C8
		[Token(Token = "0x17001D30")]
		public TileData.HeightType originHeightType
		{
			[Token(Token = "0x600E7A4")]
			[Address(RVA = "0x5E86C0", Offset = "0x5E72C0", VA = "0x1805E86C0")]
			get
			{
				return TileData.HeightType.LOWLAND;
			}
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x0600E7A5 RID: 59301 RVA: 0x000547E0 File Offset: 0x000529E0
		[Token(Token = "0x17001D31")]
		public PlayerSideMask playerSideMask
		{
			[Token(Token = "0x600E7A5")]
			[Address(RVA = "0x5E8780", Offset = "0x5E7380", VA = "0x1805E8780")]
			get
			{
				return PlayerSideMask.ALL;
			}
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x0600E7A6 RID: 59302 RVA: 0x000547F8 File Offset: 0x000529F8
		[Token(Token = "0x17001D32")]
		public MapLayer mapLayer
		{
			[Token(Token = "0x600E7A6")]
			[Address(RVA = "0x5E8520", Offset = "0x5E7120", VA = "0x1805E8520")]
			get
			{
				return MapLayer.LAYER_A;
			}
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x0600E7A7 RID: 59303 RVA: 0x00054810 File Offset: 0x00052A10
		[Token(Token = "0x17001D33")]
		public AdvancedBuildableMask advancedBuildableMask
		{
			[Token(Token = "0x600E7A7")]
			[Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0")]
			get
			{
				return AdvancedBuildableMask.NONE;
			}
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x0600E7A8 RID: 59304 RVA: 0x00054828 File Offset: 0x00052A28
		[Token(Token = "0x17001D34")]
		public Tile.Options options
		{
			[Token(Token = "0x600E7A8")]
			[Address(RVA = "0x5E8640", Offset = "0x5E7240", VA = "0x1805E8640")]
			get
			{
				return default(Tile.Options);
			}
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x0600E7A9 RID: 59305 RVA: 0x00054840 File Offset: 0x00052A40
		[Token(Token = "0x17001D35")]
		public bool isHighland
		{
			[Token(Token = "0x600E7A9")]
			[Address(RVA = "0x5E7F90", Offset = "0x5E6B90", VA = "0x1805E7F90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x0600E7AA RID: 59306 RVA: 0x00054858 File Offset: 0x00052A58
		[Token(Token = "0x17001D36")]
		public bool isLowland
		{
			[Token(Token = "0x600E7AA")]
			[Address(RVA = "0x5E8040", Offset = "0x5E6C40", VA = "0x1805E8040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x0600E7AB RID: 59307 RVA: 0x00054870 File Offset: 0x00052A70
		[Token(Token = "0x17001D37")]
		public bool isHidden
		{
			[Token(Token = "0x600E7AB")]
			[Address(RVA = "0x5E7EE0", Offset = "0x5E6AE0", VA = "0x1805E7EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x0600E7AC RID: 59308 RVA: 0x00054888 File Offset: 0x00052A88
		[Token(Token = "0x17001D38")]
		public bool isMeleeBlockable
		{
			[Token(Token = "0x600E7AC")]
			[Address(RVA = "0x5E80F0", Offset = "0x5E6CF0", VA = "0x1805E80F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x0600E7AD RID: 59309 RVA: 0x000548A0 File Offset: 0x00052AA0
		// (set) Token: 0x0600E7AE RID: 59310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D39")]
		public TileGraphic.HighlightType highlightType
		{
			[Token(Token = "0x600E7AD")]
			[Address(RVA = "0x5E7BB0", Offset = "0x5E67B0", VA = "0x1805E7BB0")]
			get
			{
				return TileGraphic.HighlightType.NONE;
			}
			[Token(Token = "0x600E7AE")]
			[Address(RVA = "0x5E8DB0", Offset = "0x5E79B0", VA = "0x1805E8DB0")]
			set
			{
			}
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x0600E7AF RID: 59311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D3A")]
		private Dictionary<ObjectPtr<Character>, List<TileGraphic>> extraTileGraphic
		{
			[Token(Token = "0x600E7AF")]
			[Address(RVA = "0x5E7930", Offset = "0x5E6530", VA = "0x1805E7930")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x0600E7B0 RID: 59312 RVA: 0x000548B8 File Offset: 0x00052AB8
		[Token(Token = "0x17001D3B")]
		public TileInfoMask tileInfo
		{
			[Token(Token = "0x600E7B0")]
			[Address(RVA = "0x5E8AC0", Offset = "0x5E76C0", VA = "0x1805E8AC0")]
			get
			{
				return (TileInfoMask)0;
			}
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x0600E7B1 RID: 59313 RVA: 0x000548D0 File Offset: 0x00052AD0
		[Token(Token = "0x17001D3C")]
		public virtual int moveCost
		{
			[Token(Token = "0x600E7B1")]
			[Address(RVA = "0x5D2B60", Offset = "0x5D1760", VA = "0x1805D2B60", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x0600E7B2 RID: 59314 RVA: 0x000548E8 File Offset: 0x00052AE8
		[Token(Token = "0x17001D3D")]
		public virtual bool isObstacleLike
		{
			[Token(Token = "0x600E7B2")]
			[Address(RVA = "0x5D2AD0", Offset = "0x5D16D0", VA = "0x1805D2AD0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x0600E7B3 RID: 59315 RVA: 0x00054900 File Offset: 0x00052B00
		[Token(Token = "0x17001D3E")]
		public virtual bool triggerable
		{
			[Token(Token = "0x600E7B3")]
			[Address(RVA = "0x5E8C10", Offset = "0x5E7810", VA = "0x1805E8C10", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x0600E7B4 RID: 59316 RVA: 0x00054918 File Offset: 0x00052B18
		[Token(Token = "0x17001D3F")]
		protected virtual int maxTriggerCnt
		{
			[Token(Token = "0x600E7B4")]
			[Address(RVA = "0x5E8580", Offset = "0x5E7180", VA = "0x1805E8580", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x0600E7B5 RID: 59317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D40")]
		protected TileData data
		{
			[Token(Token = "0x600E7B5")]
			[Address(RVA = "0x5E7350", Offset = "0x5E5F50", VA = "0x1805E7350")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x0600E7B6 RID: 59318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D41")]
		public Blackboard blackboard
		{
			[Token(Token = "0x600E7B6")]
			[Address(RVA = "0x5E6EB0", Offset = "0x5E5AB0", VA = "0x1805E6EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x0600E7B7 RID: 59319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001D42")]
		public virtual Transform effectHolder
		{
			[Token(Token = "0x600E7B7")]
			[Address(RVA = "0x5E7710", Offset = "0x5E6310", VA = "0x1805E7710", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E7B8 RID: 59320 RVA: 0x00054930 File Offset: 0x00052B30
		[Token(Token = "0x600E7B8")]
		[Address(RVA = "0x5DF8E0", Offset = "0x5DE4E0", VA = "0x1805DF8E0", Slot = "15")]
		public int CompareTo(Tile another)
		{
			return 0;
		}

		// Token: 0x0600E7B9 RID: 59321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7B9")]
		[Address(RVA = "0x5E1480", Offset = "0x5E0080", VA = "0x1805E1480", Slot = "21")]
		public virtual void Init(TileData tileData, GridPosition pos)
		{
		}

		// Token: 0x0600E7BA RID: 59322 RVA: 0x00054948 File Offset: 0x00052B48
		[Token(Token = "0x600E7BA")]
		[Address(RVA = "0x5DFA60", Offset = "0x5DE660", VA = "0x1805DFA60")]
		public bool ContainsInfoMask(TileInfoMask infoMask)
		{
			return default(bool);
		}

		// Token: 0x0600E7BB RID: 59323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7BB")]
		[Address(RVA = "0x5DFB30", Offset = "0x5DE730", VA = "0x1805DFB30")]
		public void EnsureBlackboard()
		{
		}

		// Token: 0x0600E7BC RID: 59324 RVA: 0x00054960 File Offset: 0x00052B60
		[Token(Token = "0x600E7BC")]
		[Address(RVA = "0x5DE7C0", Offset = "0x5DD3C0", VA = "0x1805DE7C0")]
		public bool AssignBlackboard(string key, float value)
		{
			return default(bool);
		}

		// Token: 0x0600E7BD RID: 59325 RVA: 0x00054978 File Offset: 0x00052B78
		[Token(Token = "0x600E7BD")]
		[Address(RVA = "0x5DE8B0", Offset = "0x5DD4B0", VA = "0x1805DE8B0")]
		public bool AssignBlackboard(string key, string valueStr)
		{
			return default(bool);
		}

		// Token: 0x0600E7BE RID: 59326 RVA: 0x00054990 File Offset: 0x00052B90
		[Token(Token = "0x600E7BE")]
		[Address(RVA = "0x5E0320", Offset = "0x5DEF20", VA = "0x1805E0320")]
		public float GetBBFloatOrDefault(string key, float defaultvalue)
		{
			return 0f;
		}

		// Token: 0x0600E7BF RID: 59327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7BF")]
		[Address(RVA = "0x5E45F0", Offset = "0x5E31F0", VA = "0x1805E45F0")]
		public void RemoveBlackboardKey(string key)
		{
		}

		// Token: 0x0600E7C0 RID: 59328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7C0")]
		[Address(RVA = "0x5DE720", Offset = "0x5DD320", VA = "0x1805DE720")]
		public void AddListener(ITileListener listener)
		{
		}

		// Token: 0x0600E7C1 RID: 59329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7C1")]
		[Address(RVA = "0x5E4840", Offset = "0x5E3440", VA = "0x1805E4840")]
		public void RemoveListener(ITileListener listener)
		{
		}

		// Token: 0x0600E7C2 RID: 59330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7C2")]
		[Address(RVA = "0x5DE570", Offset = "0x5DD170", VA = "0x1805DE570")]
		public void AddBuildableChecker(ITileBuildableChecker checker)
		{
		}

		// Token: 0x0600E7C3 RID: 59331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7C3")]
		[Address(RVA = "0x5E4670", Offset = "0x5E3270", VA = "0x1805E4670")]
		public void RemoveBuildableChecker(ITileBuildableChecker checker)
		{
		}

		// Token: 0x0600E7C4 RID: 59332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7C4")]
		[Address(RVA = "0x5DE4F0", Offset = "0x5DD0F0", VA = "0x1805DE4F0")]
		public void AddBaseHeight(float offset)
		{
		}

		// Token: 0x0600E7C5 RID: 59333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7C5")]
		[Address(RVA = "0x5DEA30", Offset = "0x5DD630", VA = "0x1805DEA30")]
		public void BindDynamicPositionDeltaProvider(Tile.TileDynamicPositionController.IDynamicPositionDeltaProvider provider)
		{
		}

		// Token: 0x0600E7C6 RID: 59334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7C6")]
		[Address(RVA = "0x5E5B40", Offset = "0x5E4740", VA = "0x1805E5B40")]
		public void UnbindDynamicPositionDeltaProvider(Tile.TileDynamicPositionController.IDynamicPositionDeltaProvider provider)
		{
		}

		// Token: 0x0600E7C7 RID: 59335 RVA: 0x000549A8 File Offset: 0x00052BA8
		[Token(Token = "0x600E7C7")]
		[Address(RVA = "0x5E0470", Offset = "0x5DF070", VA = "0x1805E0470")]
		public Vector3 GetDynamicPositionDelta()
		{
			return default(Vector3);
		}

		// Token: 0x0600E7C8 RID: 59336 RVA: 0x000549C0 File Offset: 0x00052BC0
		[Token(Token = "0x600E7C8")]
		[Address(RVA = "0x5E1D60", Offset = "0x5E0960", VA = "0x1805E1D60")]
		public bool IsPassable(MotionMode mode)
		{
			return default(bool);
		}

		// Token: 0x0600E7C9 RID: 59337 RVA: 0x000549D8 File Offset: 0x00052BD8
		[Token(Token = "0x600E7C9")]
		[Address(RVA = "0x5E1BE0", Offset = "0x5E07E0", VA = "0x1805E1BE0")]
		public bool IsPassableGoTo(MotionMode mode, SharedConsts.Direction direction)
		{
			return default(bool);
		}

		// Token: 0x0600E7CA RID: 59338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7CA")]
		[Address(RVA = "0x5E3640", Offset = "0x5E2240", VA = "0x1805E3640")]
		public void OverwriteBuildableType(BuildableType buildableType)
		{
		}

		// Token: 0x0600E7CB RID: 59339 RVA: 0x000549F0 File Offset: 0x00052BF0
		[Token(Token = "0x600E7CB")]
		[Address(RVA = "0x5DEB10", Offset = "0x5DD710", VA = "0x1805DEB10")]
		public bool CheckBuildable(BattleCharacterData characterData, bool spawnManually)
		{
			return default(bool);
		}

		// Token: 0x0600E7CC RID: 59340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7CC")]
		[Address(RVA = "0x5E35D0", Offset = "0x5E21D0", VA = "0x1805E35D0")]
		public void OverwriteAdvancedBuildableMask(AdvancedBuildableMask advancedBuildMask)
		{
		}

		// Token: 0x0600E7CD RID: 59341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7CD")]
		[Address(RVA = "0x5E3500", Offset = "0x5E2100", VA = "0x1805E3500")]
		public void OverwriteAdvancedBuildableMask(AdvancedBuildableMask advancedBuildMask, bool isAdd, bool checkDefault = false)
		{
		}

		// Token: 0x0600E7CE RID: 59342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7CE")]
		[Address(RVA = "0x5E36C0", Offset = "0x5E22C0", VA = "0x1805E36C0")]
		public void OverwriteObstacleLikeMoveCost(bool flag)
		{
		}

		// Token: 0x0600E7CF RID: 59343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E7CF")]
		[Address(RVA = "0x5E03E0", Offset = "0x5DEFE0", VA = "0x1805E03E0")]
		public Character GetCharacter()
		{
			return null;
		}

		// Token: 0x0600E7D0 RID: 59344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E7D0")]
		[Address(RVA = "0x5E0CC0", Offset = "0x5DF8C0", VA = "0x1805E0CC0")]
		public Token GetTopToken()
		{
			return null;
		}

		// Token: 0x0600E7D1 RID: 59345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E7D1")]
		[Address(RVA = "0x5E0580", Offset = "0x5DF180", VA = "0x1805E0580")]
		public DoubleBufferedList<ObjectPtr<Enemy>> GetEnemies()
		{
			return null;
		}

		// Token: 0x0600E7D2 RID: 59346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E7D2")]
		[Address(RVA = "0x5E05E0", Offset = "0x5DF1E0", VA = "0x1805E05E0")]
		public ReusableList<Entity> GetEntities_DISPOSE()
		{
			return null;
		}

		// Token: 0x0600E7D3 RID: 59347 RVA: 0x00054A08 File Offset: 0x00052C08
		[Token(Token = "0x600E7D3")]
		[Address(RVA = "0x5E1050", Offset = "0x5DFC50", VA = "0x1805E1050")]
		public bool HasWalkEnemy()
		{
			return default(bool);
		}

		// Token: 0x0600E7D4 RID: 59348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7D4")]
		[Address(RVA = "0x5E3830", Offset = "0x5E2430", VA = "0x1805E3830")]
		public void RefreshExtraTileGraphic(bool force = false)
		{
		}

		// Token: 0x0600E7D5 RID: 59349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7D5")]
		[Address(RVA = "0x5DF470", Offset = "0x5DE070", VA = "0x1805DF470")]
		public void ClearCharacterIfExists()
		{
		}

		// Token: 0x0600E7D6 RID: 59350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7D6")]
		[Address(RVA = "0x5DF570", Offset = "0x5DE170", VA = "0x1805DF570")]
		public void ClearCharacterInBuildSlots(Character character)
		{
		}

		// Token: 0x0600E7D7 RID: 59351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7D7")]
		[Address(RVA = "0x5DF370", Offset = "0x5DDF70", VA = "0x1805DF370")]
		public void ClearCharacterIfExistsBeforeReplace(Character character)
		{
		}

		// Token: 0x0600E7D8 RID: 59352 RVA: 0x00054A20 File Offset: 0x00052C20
		[Token(Token = "0x600E7D8")]
		[Address(RVA = "0x5E0A40", Offset = "0x5DF640", VA = "0x1805E0A40")]
		public FixedPosition GetLocatePosition()
		{
			return default(FixedPosition);
		}

		// Token: 0x0600E7D9 RID: 59353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7D9")]
		[Address(RVA = "0x5E2260", Offset = "0x5E0E60", VA = "0x1805E2260")]
		public void OnCharacterFinished(Character character, Entity.FinishReason reason)
		{
		}

		// Token: 0x0600E7DA RID: 59354 RVA: 0x00054A38 File Offset: 0x00052C38
		[Token(Token = "0x600E7DA")]
		[Address(RVA = "0x5E1E30", Offset = "0x5E0A30", VA = "0x1805E1E30")]
		public bool LocateCharacter(Character character, bool spawnManually)
		{
			return default(bool);
		}

		// Token: 0x0600E7DB RID: 59355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7DB")]
		[Address(RVA = "0x5E4230", Offset = "0x5E2E30", VA = "0x1805E4230")]
		public void RegisterCharacter(Character character)
		{
		}

		// Token: 0x0600E7DC RID: 59356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7DC")]
		[Address(RVA = "0x5DE610", Offset = "0x5DD210", VA = "0x1805DE610")]
		public void AddEnemy(Enemy enemy)
		{
		}

		// Token: 0x0600E7DD RID: 59357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7DD")]
		[Address(RVA = "0x5E4710", Offset = "0x5E3310", VA = "0x1805E4710")]
		public void RemoveEnemy(Enemy enemy)
		{
		}

		// Token: 0x0600E7DE RID: 59358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7DE")]
		[Address(RVA = "0x5E5240", Offset = "0x5E3E40", VA = "0x1805E5240")]
		public void SetData(TileData data, GridPosition pos, Map map, MapLayer layer)
		{
		}

		// Token: 0x0600E7DF RID: 59359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7DF")]
		[Address(RVA = "0x5E4930", Offset = "0x5E3530", VA = "0x1805E4930")]
		public void ReplaceGraphicFromScene(IList<TileGraphic> newGraphicList)
		{
		}

		// Token: 0x0600E7E0 RID: 59360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7E0")]
		[Address(RVA = "0x5DF060", Offset = "0x5DDC60", VA = "0x1805DF060")]
		public void ClearAllGraphic()
		{
		}

		// Token: 0x0600E7E1 RID: 59361 RVA: 0x00054A50 File Offset: 0x00052C50
		[Token(Token = "0x600E7E1")]
		[Address(RVA = "0x5E57D0", Offset = "0x5E43D0", VA = "0x1805E57D0")]
		public bool Trigger()
		{
			return default(bool);
		}

		// Token: 0x0600E7E2 RID: 59362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7E2")]
		[Address(RVA = "0x5E6010", Offset = "0x5E4C10", VA = "0x1805E6010")]
		private void _InitDefaultTransformStatus()
		{
		}

		// Token: 0x0600E7E3 RID: 59363 RVA: 0x00054A68 File Offset: 0x00052C68
		[Token(Token = "0x600E7E3")]
		[Address(RVA = "0x5E5910", Offset = "0x5E4510", VA = "0x1805E5910")]
		public bool TryUpdateOptions(Tile.Options newOptions, bool keepCurrentPassableMask, bool ignoreBlockAnyRoutes, bool keepCurrentBuildableType)
		{
			return default(bool);
		}

		// Token: 0x0600E7E4 RID: 59364 RVA: 0x00054A80 File Offset: 0x00052C80
		[Token(Token = "0x600E7E4")]
		[Address(RVA = "0x5E5AD0", Offset = "0x5E46D0", VA = "0x1805E5AD0")]
		public bool TryUpdateTileInfo(TileInfoMask info)
		{
			return default(bool);
		}

		// Token: 0x0600E7E5 RID: 59365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7E5")]
		[Address(RVA = "0x5E4F20", Offset = "0x5E3B20", VA = "0x1805E4F20")]
		public void RestoreOptions()
		{
		}

		// Token: 0x0600E7E6 RID: 59366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7E6")]
		[Address(RVA = "0x5E3F30", Offset = "0x5E2B30", VA = "0x1805E3F30")]
		public void RefreshOptionsOnly(Tile.Options option, Token token)
		{
		}

		// Token: 0x0600E7E7 RID: 59367 RVA: 0x00054A98 File Offset: 0x00052C98
		[Token(Token = "0x600E7E7")]
		[Address(RVA = "0x5E5C20", Offset = "0x5E4820", VA = "0x1805E5C20")]
		public bool VerifyOverlap(bool spawnManually)
		{
			return default(bool);
		}

		// Token: 0x0600E7E8 RID: 59368 RVA: 0x00054AB0 File Offset: 0x00052CB0
		[Token(Token = "0x600E7E8")]
		[Address(RVA = "0x5E5090", Offset = "0x5E3C90", VA = "0x1805E5090")]
		protected MotionMask RewriteOptions(Tile.Options newOptions)
		{
			return MotionMask.NONE;
		}

		// Token: 0x0600E7E9 RID: 59369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7E9")]
		[Address(RVA = "0x5CFB20", Offset = "0x5CE720", VA = "0x1805CFB20", Slot = "22")]
		protected virtual void PreprocessTileOptions(ref Tile.Options tileOptions)
		{
		}

		// Token: 0x0600E7EA RID: 59370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7EA")]
		[Address(RVA = "0x5E3730", Offset = "0x5E2330", VA = "0x1805E3730", Slot = "23")]
		protected virtual void PreloadAssets()
		{
		}

		// Token: 0x0600E7EB RID: 59371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7EB")]
		[Address(RVA = "0x5E5EA0", Offset = "0x5E4AA0", VA = "0x1805E5EA0")]
		private void _InitCollider()
		{
		}

		// Token: 0x0600E7EC RID: 59372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7EC")]
		[Address(RVA = "0x5E3080", Offset = "0x5E1C80", VA = "0x1805E3080", Slot = "24")]
		public virtual void OnGameStart()
		{
		}

		// Token: 0x0600E7ED RID: 59373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7ED")]
		[Address(RVA = "0x5E2F80", Offset = "0x5E1B80", VA = "0x1805E2F80", Slot = "25")]
		public virtual void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x0600E7EE RID: 59374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7EE")]
		[Address(RVA = "0x5E2140", Offset = "0x5E0D40", VA = "0x1805E2140", Slot = "26")]
		protected virtual void OnCharacterEnter(Character newChar, Character oldChar)
		{
		}

		// Token: 0x0600E7EF RID: 59375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7EF")]
		[Address(RVA = "0x5E2640", Offset = "0x5E1240", VA = "0x1805E2640", Slot = "27")]
		protected virtual void OnCharacterLeave(Character character)
		{
		}

		// Token: 0x0600E7F0 RID: 59376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7F0")]
		[Address(RVA = "0x5E31D0", Offset = "0x5E1DD0", VA = "0x1805E31D0", Slot = "28")]
		public virtual void OnRallyPointLikeReborn(Unit unit)
		{
		}

		// Token: 0x0600E7F1 RID: 59377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7F1")]
		[Address(RVA = "0x5E3170", Offset = "0x5E1D70", VA = "0x1805E3170", Slot = "29")]
		public virtual void OnRallyPointLikeFakeDeath(Unit unit)
		{
		}

		// Token: 0x0600E7F2 RID: 59378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7F2")]
		[Address(RVA = "0x5E3230", Offset = "0x5E1E30", VA = "0x1805E3230", Slot = "30")]
		public virtual void OnTokenCategoryChanged(Token token)
		{
		}

		// Token: 0x0600E7F3 RID: 59379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7F3")]
		[Address(RVA = "0x5E2950", Offset = "0x5E1550", VA = "0x1805E2950", Slot = "31")]
		protected virtual void OnEnemyEnter(Enemy enemy)
		{
		}

		// Token: 0x0600E7F4 RID: 59380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7F4")]
		[Address(RVA = "0x5E29E0", Offset = "0x5E15E0", VA = "0x1805E29E0", Slot = "32")]
		protected virtual void OnEnemyLeave(Enemy enemy)
		{
		}

		// Token: 0x0600E7F5 RID: 59381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7F5")]
		[Address(RVA = "0x5E2A70", Offset = "0x5E1670", VA = "0x1805E2A70", Slot = "33")]
		public virtual void OnEnemyMotionModeChanged(Enemy enemy, MotionMode oldMode, MotionMode newMode)
		{
		}

		// Token: 0x0600E7F6 RID: 59382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7F6")]
		[Address(RVA = "0x5E1270", Offset = "0x5DFE70", VA = "0x1805E1270", Slot = "34")]
		public virtual void HoldEffect(string effectKey, Effect effect)
		{
		}

		// Token: 0x0600E7F7 RID: 59383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7F7")]
		[Address(RVA = "0x5DFBE0", Offset = "0x5DE7E0", VA = "0x1805DFBE0", Slot = "35")]
		public virtual void FinishHoldEffect()
		{
		}

		// Token: 0x0600E7F8 RID: 59384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7F8")]
		[Address(RVA = "0x5DFDC0", Offset = "0x5DE9C0", VA = "0x1805DFDC0", Slot = "36")]
		public virtual void FinishSpecifiedHoldEffect(string key)
		{
		}

		// Token: 0x0600E7F9 RID: 59385 RVA: 0x00054AC8 File Offset: 0x00052CC8
		[Token(Token = "0x600E7F9")]
		[Address(RVA = "0x5DEED0", Offset = "0x5DDAD0", VA = "0x1805DEED0", Slot = "37")]
		public virtual bool CheckHasHoldEffect(string effectKey)
		{
			return default(bool);
		}

		// Token: 0x0600E7FA RID: 59386 RVA: 0x00054AE0 File Offset: 0x00052CE0
		[Token(Token = "0x600E7FA")]
		[Address(RVA = "0x5E4020", Offset = "0x5E2C20", VA = "0x1805E4020")]
		protected bool RefreshTileOptionsViaToken(Token token)
		{
			return default(bool);
		}

		// Token: 0x0600E7FB RID: 59387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7FB")]
		[Address(RVA = "0x5E3290", Offset = "0x5E1E90", VA = "0x1805E3290")]
		protected void OnTokenFinished(Token token)
		{
		}

		// Token: 0x0600E7FC RID: 59388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7FC")]
		[Address(RVA = "0x5E4DD0", Offset = "0x5E39D0", VA = "0x1805E4DD0")]
		public void RestoreOptionsOnlyViaToken(Token token)
		{
		}

		// Token: 0x0600E7FD RID: 59389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7FD")]
		[Address(RVA = "0x5E2B00", Offset = "0x5E1700", VA = "0x1805E2B00", Slot = "38")]
		protected virtual void OnEntityEnter(Entity entity)
		{
		}

		// Token: 0x0600E7FE RID: 59390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7FE")]
		[Address(RVA = "0x5E2C90", Offset = "0x5E1890", VA = "0x1805E2C90", Slot = "39")]
		protected virtual void OnEntityLeave(Entity entity)
		{
		}

		// Token: 0x0600E7FF RID: 59391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E7FF")]
		[Address(RVA = "0x5E3410", Offset = "0x5E2010", VA = "0x1805E3410", Slot = "40")]
		protected virtual void OnTrigger()
		{
		}

		// Token: 0x0600E800 RID: 59392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E800")]
		[Address(RVA = "0x5E0F30", Offset = "0x5DFB30", VA = "0x1805E0F30")]
		protected void HandleMapEffect(Effect effect)
		{
		}

		// Token: 0x0600E801 RID: 59393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E801")]
		[Address(RVA = "0x5DFF60", Offset = "0x5DEB60", VA = "0x1805DFF60")]
		public void GenerateTileEffect()
		{
		}

		// Token: 0x0600E802 RID: 59394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E802")]
		[Address(RVA = "0x5DF250", Offset = "0x5DDE50", VA = "0x1805DF250")]
		public void ClearAllTileEffects()
		{
		}

		// Token: 0x0600E803 RID: 59395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E803")]
		[Address(RVA = "0x5E5CB0", Offset = "0x5E48B0", VA = "0x1805E5CB0")]
		private TileAppendInfo _EnsureAppendInfo(bool forceReload = false)
		{
			return null;
		}

		// Token: 0x0600E804 RID: 59396 RVA: 0x00054AF8 File Offset: 0x00052CF8
		[Token(Token = "0x600E804")]
		[Address(RVA = "0x5DECB0", Offset = "0x5DD8B0", VA = "0x1805DECB0")]
		public bool CheckExtraBuildable(BattleCharacterData sourceData)
		{
			return default(bool);
		}

		// Token: 0x0600E805 RID: 59397 RVA: 0x00054B10 File Offset: 0x00052D10
		[Token(Token = "0x600E805")]
		[Address(RVA = "0x5E2E20", Offset = "0x5E1A20", VA = "0x1805E2E20")]
		public bool OnEntityWillBuild(Entity entity, SharedConsts.Direction direction, bool spawnManually)
		{
			return default(bool);
		}

		// Token: 0x0600E806 RID: 59398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E806")]
		[Address(RVA = "0x5E6420", Offset = "0x5E5020", VA = "0x1805E6420")]
		private void _SetPositionDelta(Vector3 pos)
		{
		}

		// Token: 0x0600E807 RID: 59399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E807")]
		[Address(RVA = "0x5DE9A0", Offset = "0x5DD5A0", VA = "0x1805DE9A0")]
		private void Awake()
		{
		}

		// Token: 0x0600E808 RID: 59400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E808")]
		[Address(RVA = "0x5E5770", Offset = "0x5E4370", VA = "0x1805E5770")]
		private void Start()
		{
		}

		// Token: 0x0600E809 RID: 59401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E809")]
		[Address(RVA = "0x5E6960", Offset = "0x5E5560", VA = "0x1805E6960")]
		public Tile()
		{
		}

		// Token: 0x0400FEF6 RID: 65270
		[Token(Token = "0x400FEF6")]
		[FieldOffset(Offset = "0x0")]
		private static uint s_tileInstCounter;

		// Token: 0x0400FEF7 RID: 65271
		[Token(Token = "0x400FEF7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _tileKey;

		// Token: 0x0400FEF8 RID: 65272
		[Token(Token = "0x400FEF8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _height;

		// Token: 0x0400FEF9 RID: 65273
		[Token(Token = "0x400FEF9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _locateHeightOffset;

		// Token: 0x0400FEFA RID: 65274
		[Token(Token = "0x400FEFA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _forceBoxCollider;

		// Token: 0x0400FEFB RID: 65275
		[Token(Token = "0x400FEFB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TileGraphic _graphic;

		// Token: 0x0400FEFC RID: 65276
		[Token(Token = "0x400FEFC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<TileGraphic> _allGraphicList;

		// Token: 0x0400FEFD RID: 65277
		[Token(Token = "0x400FEFD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _effect;

		// Token: 0x0400FEFE RID: 65278
		[Token(Token = "0x400FEFE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _setHoldEffectToEffectHolder;

		// Token: 0x0400FEFF RID: 65279
		[Token(Token = "0x400FEFF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TileData _data;

		// Token: 0x0400FF00 RID: 65280
		[Token(Token = "0x400FF00")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MapLayer _mapLayer;

		// Token: 0x0400FF01 RID: 65281
		[Token(Token = "0x400FF01")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool _injectEnvDmgFlagToBlackboard;

		// Token: 0x0400FF02 RID: 65282
		[Token(Token = "0x400FF02")]
		[FieldOffset(Offset = "0x60")]
		private int m_triggerCnt;

		// Token: 0x0400FF03 RID: 65283
		[Token(Token = "0x400FF03")]
		[FieldOffset(Offset = "0x68")]
		private Blackboard m_blackboard;

		// Token: 0x0400FF04 RID: 65284
		[Token(Token = "0x400FF04")]
		[FieldOffset(Offset = "0x70")]
		private TileData m_data;

		// Token: 0x0400FF05 RID: 65285
		[Token(Token = "0x400FF05")]
		[FieldOffset(Offset = "0x78")]
		private Tile.Options m_originOptions;

		// Token: 0x0400FF06 RID: 65286
		[Token(Token = "0x400FF06")]
		[FieldOffset(Offset = "0x8C")]
		private Tile.Options m_cachedOptions;

		// Token: 0x0400FF07 RID: 65287
		[Token(Token = "0x400FF07")]
		[FieldOffset(Offset = "0xA0")]
		private float m_baseHeight;

		// Token: 0x0400FF08 RID: 65288
		[Token(Token = "0x400FF08")]
		[FieldOffset(Offset = "0xA4")]
		private float m_tokenOverlapHeight;

		// Token: 0x0400FF09 RID: 65289
		[Token(Token = "0x400FF09")]
		[FieldOffset(Offset = "0xA8")]
		private GameObject m_effectHolder;

		// Token: 0x0400FF0A RID: 65290
		[Token(Token = "0x400FF0A")]
		[FieldOffset(Offset = "0xB0")]
		private Tile.TileDynamicPositionController m_dynamicPositionController;

		// Token: 0x0400FF0B RID: 65291
		[Token(Token = "0x400FF0B")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<Transform, Tile.DefaultTransformStatus> m_defaultTransformStatus;

		// Token: 0x0400FF0C RID: 65292
		[Token(Token = "0x400FF0C")]
		[FieldOffset(Offset = "0xC0")]
		private TileAppendInfo m_tileAppendInfo;

		// Token: 0x0400FF0D RID: 65293
		[Token(Token = "0x400FF0D")]
		[FieldOffset(Offset = "0xC8")]
		private TileInfoMask m_tileInfo;

		// Token: 0x0400FF0E RID: 65294
		[Token(Token = "0x400FF0E")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<ObjectPtr<Character>, List<TileGraphic>> m_extraTileGraphic;

		// Token: 0x0400FF0F RID: 65295
		[Token(Token = "0x400FF0F")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_enableOverlap;

		// Token: 0x0400FF10 RID: 65296
		[Token(Token = "0x400FF10")]
		[FieldOffset(Offset = "0xD9")]
		private bool m_onlyManuallyOverlap;

		// Token: 0x0400FF11 RID: 65297
		[Token(Token = "0x400FF11")]
		[FieldOffset(Offset = "0xDA")]
		private bool m_blockManuallySpawn;

		// Token: 0x0400FF12 RID: 65298
		[Token(Token = "0x400FF12")]
		[FieldOffset(Offset = "0xDC")]
		protected float m_additionalFriction;

		// Token: 0x0400FF13 RID: 65299
		[Token(Token = "0x400FF13")]
		[FieldOffset(Offset = "0xE0")]
		private MotionMode m_lastCharMotionMode;

		// Token: 0x0400FF14 RID: 65300
		[Token(Token = "0x400FF14")]
		[FieldOffset(Offset = "0xE4")]
		private TileTypesMask m_tileTypes;

		// Token: 0x0400FF15 RID: 65301
		[Token(Token = "0x400FF15")]
		[FieldOffset(Offset = "0xE8")]
		protected List<Tile.TileEffectSpec> m_tileEffectSpecs;

		// Token: 0x0400FF16 RID: 65302
		[Token(Token = "0x400FF16")]
		[FieldOffset(Offset = "0xF0")]
		protected Tile.SortedDoubleBufferedBuildSlots m_buildSlots;

		// Token: 0x0400FF17 RID: 65303
		[Token(Token = "0x400FF17")]
		[FieldOffset(Offset = "0xF8")]
		protected DoubleBufferedList<ObjectPtr<Enemy>> m_enemies;

		// Token: 0x0400FF18 RID: 65304
		[Token(Token = "0x400FF18")]
		[FieldOffset(Offset = "0x100")]
		private List<ITileListener> m_listeners;

		// Token: 0x0400FF19 RID: 65305
		[Token(Token = "0x400FF19")]
		[FieldOffset(Offset = "0x108")]
		private List<ITileBuildableChecker> m_extraBuildableCheckers;

		// Token: 0x0400FF1A RID: 65306
		[Token(Token = "0x400FF1A")]
		[FieldOffset(Offset = "0x110")]
		private int[] m_gotoDirectionalPassableMask;

		// Token: 0x0400FF1B RID: 65307
		[Token(Token = "0x400FF1B")]
		[FieldOffset(Offset = "0x118")]
		private Tile.Behaviour[] m_behaviours;

		// Token: 0x0400FF1D RID: 65309
		[Token(Token = "0x400FF1D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_buildSlot;

		// Token: 0x0400FF1E RID: 65310
		[Token(Token = "0x400FF1E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_tileBuildSlotsCount;

		// Token: 0x0400FF1F RID: 65311
		[Token(Token = "0x400FF1F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_charBlockMotionMode;

		// Token: 0x0400FF20 RID: 65312
		[Token(Token = "0x400FF20")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_dynamicPositionController;

		// Token: 0x0400FF21 RID: 65313
		[Token(Token = "0x400FF21")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_slotEnumerator;

		// Token: 0x0400FF22 RID: 65314
		[Token(Token = "0x400FF22")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_extraBuildableCheckers;

		// Token: 0x0400FF23 RID: 65315
		[Token(Token = "0x400FF23")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_instanceUid;

		// Token: 0x0400FF24 RID: 65316
		[Token(Token = "0x400FF24")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_instanceUid;

		// Token: 0x0400FF25 RID: 65317
		[Token(Token = "0x400FF25")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_height;

		// Token: 0x0400FF26 RID: 65318
		[Token(Token = "0x400FF26")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_enableOverlap;

		// Token: 0x0400FF27 RID: 65319
		[Token(Token = "0x400FF27")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_enableOverlap;

		// Token: 0x0400FF28 RID: 65320
		[Token(Token = "0x400FF28")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_onlyManuallyOverlap;

		// Token: 0x0400FF29 RID: 65321
		[Token(Token = "0x400FF29")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_onlyManuallyOverlap;

		// Token: 0x0400FF2A RID: 65322
		[Token(Token = "0x400FF2A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_blockManuallySpawn;

		// Token: 0x0400FF2B RID: 65323
		[Token(Token = "0x400FF2B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_blockManuallySpawn;

		// Token: 0x0400FF2C RID: 65324
		[Token(Token = "0x400FF2C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_locateHeight;

		// Token: 0x0400FF2D RID: 65325
		[Token(Token = "0x400FF2D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_additionalFriction;

		// Token: 0x0400FF2E RID: 65326
		[Token(Token = "0x400FF2E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_isEndPosTile;

		// Token: 0x0400FF2F RID: 65327
		[Token(Token = "0x400FF2F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_isStartPosTile;

		// Token: 0x0400FF30 RID: 65328
		[Token(Token = "0x400FF30")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_isTelTile;

		// Token: 0x0400FF31 RID: 65329
		[Token(Token = "0x400FF31")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_tileKey;

		// Token: 0x0400FF32 RID: 65330
		[Token(Token = "0x400FF32")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_tileName;

		// Token: 0x0400FF33 RID: 65331
		[Token(Token = "0x400FF33")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_tileDescription;

		// Token: 0x0400FF34 RID: 65332
		[Token(Token = "0x400FF34")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_buildSlotsOverlapped;

		// Token: 0x0400FF35 RID: 65333
		[Token(Token = "0x400FF35")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_buildSlotsOverlappedTwice;

		// Token: 0x0400FF36 RID: 65334
		[Token(Token = "0x400FF36")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_TileTypesMask;

		// Token: 0x0400FF37 RID: 65335
		[Token(Token = "0x400FF37")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_isFunctional;

		// Token: 0x0400FF38 RID: 65336
		[Token(Token = "0x400FF38")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_mapBoundsFromHeight;

		// Token: 0x0400FF39 RID: 65337
		[Token(Token = "0x400FF39")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0400FF3A RID: 65338
		[Token(Token = "0x400FF3A")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_allGraphicList;

		// Token: 0x0400FF3B RID: 65339
		[Token(Token = "0x400FF3B")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_buildableType;

		// Token: 0x0400FF3C RID: 65340
		[Token(Token = "0x400FF3C")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_passableMask;

		// Token: 0x0400FF3D RID: 65341
		[Token(Token = "0x400FF3D")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_heightType;

		// Token: 0x0400FF3E RID: 65342
		[Token(Token = "0x400FF3E")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_originHeightType;

		// Token: 0x0400FF3F RID: 65343
		[Token(Token = "0x400FF3F")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_playerSideMask;

		// Token: 0x0400FF40 RID: 65344
		[Token(Token = "0x400FF40")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_mapLayer;

		// Token: 0x0400FF41 RID: 65345
		[Token(Token = "0x400FF41")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_advancedBuildableMask;

		// Token: 0x0400FF42 RID: 65346
		[Token(Token = "0x400FF42")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x0400FF43 RID: 65347
		[Token(Token = "0x400FF43")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_isHighland;

		// Token: 0x0400FF44 RID: 65348
		[Token(Token = "0x400FF44")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_isLowland;

		// Token: 0x0400FF45 RID: 65349
		[Token(Token = "0x400FF45")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_isHidden;

		// Token: 0x0400FF46 RID: 65350
		[Token(Token = "0x400FF46")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_isMeleeBlockable;

		// Token: 0x0400FF47 RID: 65351
		[Token(Token = "0x400FF47")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_highlightType;

		// Token: 0x0400FF48 RID: 65352
		[Token(Token = "0x400FF48")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_set_highlightType;

		// Token: 0x0400FF49 RID: 65353
		[Token(Token = "0x400FF49")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_extraTileGraphic;

		// Token: 0x0400FF4A RID: 65354
		[Token(Token = "0x400FF4A")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_tileInfo;

		// Token: 0x0400FF4B RID: 65355
		[Token(Token = "0x400FF4B")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_get_moveCost;

		// Token: 0x0400FF4C RID: 65356
		[Token(Token = "0x400FF4C")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_isObstacleLike;

		// Token: 0x0400FF4D RID: 65357
		[Token(Token = "0x400FF4D")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_get_triggerable;

		// Token: 0x0400FF4E RID: 65358
		[Token(Token = "0x400FF4E")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_get_maxTriggerCnt;

		// Token: 0x0400FF4F RID: 65359
		[Token(Token = "0x400FF4F")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x0400FF50 RID: 65360
		[Token(Token = "0x400FF50")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_get_blackboard;

		// Token: 0x0400FF51 RID: 65361
		[Token(Token = "0x400FF51")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_get_effectHolder;

		// Token: 0x0400FF52 RID: 65362
		[Token(Token = "0x400FF52")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0400FF53 RID: 65363
		[Token(Token = "0x400FF53")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FF54 RID: 65364
		[Token(Token = "0x400FF54")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_ContainsInfoMask;

		// Token: 0x0400FF55 RID: 65365
		[Token(Token = "0x400FF55")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_EnsureBlackboard;

		// Token: 0x0400FF56 RID: 65366
		[Token(Token = "0x400FF56")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_AssignBlackboard;

		// Token: 0x0400FF57 RID: 65367
		[Token(Token = "0x400FF57")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix1_AssignBlackboard;

		// Token: 0x0400FF58 RID: 65368
		[Token(Token = "0x400FF58")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_GetBBFloatOrDefault;

		// Token: 0x0400FF59 RID: 65369
		[Token(Token = "0x400FF59")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_RemoveBlackboardKey;

		// Token: 0x0400FF5A RID: 65370
		[Token(Token = "0x400FF5A")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_AddListener;

		// Token: 0x0400FF5B RID: 65371
		[Token(Token = "0x400FF5B")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_RemoveListener;

		// Token: 0x0400FF5C RID: 65372
		[Token(Token = "0x400FF5C")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_AddBuildableChecker;

		// Token: 0x0400FF5D RID: 65373
		[Token(Token = "0x400FF5D")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_RemoveBuildableChecker;

		// Token: 0x0400FF5E RID: 65374
		[Token(Token = "0x400FF5E")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_AddBaseHeight;

		// Token: 0x0400FF5F RID: 65375
		[Token(Token = "0x400FF5F")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_BindDynamicPositionDeltaProvider;

		// Token: 0x0400FF60 RID: 65376
		[Token(Token = "0x400FF60")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_UnbindDynamicPositionDeltaProvider;

		// Token: 0x0400FF61 RID: 65377
		[Token(Token = "0x400FF61")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_GetDynamicPositionDelta;

		// Token: 0x0400FF62 RID: 65378
		[Token(Token = "0x400FF62")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_IsPassable;

		// Token: 0x0400FF63 RID: 65379
		[Token(Token = "0x400FF63")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_IsPassableGoTo;

		// Token: 0x0400FF64 RID: 65380
		[Token(Token = "0x400FF64")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_OverwriteBuildableType;

		// Token: 0x0400FF65 RID: 65381
		[Token(Token = "0x400FF65")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_CheckBuildable;

		// Token: 0x0400FF66 RID: 65382
		[Token(Token = "0x400FF66")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_OverwriteAdvancedBuildableMask;

		// Token: 0x0400FF67 RID: 65383
		[Token(Token = "0x400FF67")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix1_OverwriteAdvancedBuildableMask;

		// Token: 0x0400FF68 RID: 65384
		[Token(Token = "0x400FF68")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_OverwriteObstacleLikeMoveCost;

		// Token: 0x0400FF69 RID: 65385
		[Token(Token = "0x400FF69")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_GetCharacter;

		// Token: 0x0400FF6A RID: 65386
		[Token(Token = "0x400FF6A")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_GetTopToken;

		// Token: 0x0400FF6B RID: 65387
		[Token(Token = "0x400FF6B")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_GetEnemies;

		// Token: 0x0400FF6C RID: 65388
		[Token(Token = "0x400FF6C")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_GetEntities_DISPOSE;

		// Token: 0x0400FF6D RID: 65389
		[Token(Token = "0x400FF6D")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_HasWalkEnemy;

		// Token: 0x0400FF6E RID: 65390
		[Token(Token = "0x400FF6E")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_RefreshExtraTileGraphic;

		// Token: 0x0400FF6F RID: 65391
		[Token(Token = "0x400FF6F")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_ClearCharacterIfExists;

		// Token: 0x0400FF70 RID: 65392
		[Token(Token = "0x400FF70")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_ClearCharacterInBuildSlots;

		// Token: 0x0400FF71 RID: 65393
		[Token(Token = "0x400FF71")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_ClearCharacterIfExistsBeforeReplace;

		// Token: 0x0400FF72 RID: 65394
		[Token(Token = "0x400FF72")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_GetLocatePosition;

		// Token: 0x0400FF73 RID: 65395
		[Token(Token = "0x400FF73")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_OnCharacterFinished;

		// Token: 0x0400FF74 RID: 65396
		[Token(Token = "0x400FF74")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_LocateCharacter;

		// Token: 0x0400FF75 RID: 65397
		[Token(Token = "0x400FF75")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_RegisterCharacter;

		// Token: 0x0400FF76 RID: 65398
		[Token(Token = "0x400FF76")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_AddEnemy;

		// Token: 0x0400FF77 RID: 65399
		[Token(Token = "0x400FF77")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_RemoveEnemy;

		// Token: 0x0400FF78 RID: 65400
		[Token(Token = "0x400FF78")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0400FF79 RID: 65401
		[Token(Token = "0x400FF79")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_ReplaceGraphicFromScene;

		// Token: 0x0400FF7A RID: 65402
		[Token(Token = "0x400FF7A")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_ClearAllGraphic;

		// Token: 0x0400FF7B RID: 65403
		[Token(Token = "0x400FF7B")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_Trigger;

		// Token: 0x0400FF7C RID: 65404
		[Token(Token = "0x400FF7C")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0__InitDefaultTransformStatus;

		// Token: 0x0400FF7D RID: 65405
		[Token(Token = "0x400FF7D")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_TryUpdateOptions;

		// Token: 0x0400FF7E RID: 65406
		[Token(Token = "0x400FF7E")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_TryUpdateTileInfo;

		// Token: 0x0400FF7F RID: 65407
		[Token(Token = "0x400FF7F")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_RestoreOptions;

		// Token: 0x0400FF80 RID: 65408
		[Token(Token = "0x400FF80")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_RefreshOptionsOnly;

		// Token: 0x0400FF81 RID: 65409
		[Token(Token = "0x400FF81")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_VerifyOverlap;

		// Token: 0x0400FF82 RID: 65410
		[Token(Token = "0x400FF82")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_RewriteOptions;

		// Token: 0x0400FF83 RID: 65411
		[Token(Token = "0x400FF83")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_PreprocessTileOptions;

		// Token: 0x0400FF84 RID: 65412
		[Token(Token = "0x400FF84")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_PreloadAssets;

		// Token: 0x0400FF85 RID: 65413
		[Token(Token = "0x400FF85")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0__InitCollider;

		// Token: 0x0400FF86 RID: 65414
		[Token(Token = "0x400FF86")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0400FF87 RID: 65415
		[Token(Token = "0x400FF87")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x0400FF88 RID: 65416
		[Token(Token = "0x400FF88")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_OnCharacterEnter;

		// Token: 0x0400FF89 RID: 65417
		[Token(Token = "0x400FF89")]
		[FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_OnCharacterLeave;

		// Token: 0x0400FF8A RID: 65418
		[Token(Token = "0x400FF8A")]
		[FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_OnRallyPointLikeReborn;

		// Token: 0x0400FF8B RID: 65419
		[Token(Token = "0x400FF8B")]
		[FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_OnRallyPointLikeFakeDeath;

		// Token: 0x0400FF8C RID: 65420
		[Token(Token = "0x400FF8C")]
		[FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_OnTokenCategoryChanged;

		// Token: 0x0400FF8D RID: 65421
		[Token(Token = "0x400FF8D")]
		[FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_OnEnemyEnter;

		// Token: 0x0400FF8E RID: 65422
		[Token(Token = "0x400FF8E")]
		[FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_OnEnemyLeave;

		// Token: 0x0400FF8F RID: 65423
		[Token(Token = "0x400FF8F")]
		[FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_OnEnemyMotionModeChanged;

		// Token: 0x0400FF90 RID: 65424
		[Token(Token = "0x400FF90")]
		[FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_HoldEffect;

		// Token: 0x0400FF91 RID: 65425
		[Token(Token = "0x400FF91")]
		[FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_FinishHoldEffect;

		// Token: 0x0400FF92 RID: 65426
		[Token(Token = "0x400FF92")]
		[FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_FinishSpecifiedHoldEffect;

		// Token: 0x0400FF93 RID: 65427
		[Token(Token = "0x400FF93")]
		[FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_CheckHasHoldEffect;

		// Token: 0x0400FF94 RID: 65428
		[Token(Token = "0x400FF94")]
		[FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_RefreshTileOptionsViaToken;

		// Token: 0x0400FF95 RID: 65429
		[Token(Token = "0x400FF95")]
		[FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_OnTokenFinished;

		// Token: 0x0400FF96 RID: 65430
		[Token(Token = "0x400FF96")]
		[FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_RestoreOptionsOnlyViaToken;

		// Token: 0x0400FF97 RID: 65431
		[Token(Token = "0x400FF97")]
		[FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_OnEntityEnter;

		// Token: 0x0400FF98 RID: 65432
		[Token(Token = "0x400FF98")]
		[FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_OnEntityLeave;

		// Token: 0x0400FF99 RID: 65433
		[Token(Token = "0x400FF99")]
		[FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400FF9A RID: 65434
		[Token(Token = "0x400FF9A")]
		[FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_HandleMapEffect;

		// Token: 0x0400FF9B RID: 65435
		[Token(Token = "0x400FF9B")]
		[FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_GenerateTileEffect;

		// Token: 0x0400FF9C RID: 65436
		[Token(Token = "0x400FF9C")]
		[FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_ClearAllTileEffects;

		// Token: 0x0400FF9D RID: 65437
		[Token(Token = "0x400FF9D")]
		[FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0__EnsureAppendInfo;

		// Token: 0x0400FF9E RID: 65438
		[Token(Token = "0x400FF9E")]
		[FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_CheckExtraBuildable;

		// Token: 0x0400FF9F RID: 65439
		[Token(Token = "0x400FF9F")]
		[FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_OnEntityWillBuild;

		// Token: 0x0400FFA0 RID: 65440
		[Token(Token = "0x400FFA0")]
		[FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0__SetPositionDelta;

		// Token: 0x0400FFA1 RID: 65441
		[Token(Token = "0x400FFA1")]
		[FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400FFA2 RID: 65442
		[Token(Token = "0x400FFA2")]
		[FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400FFA3 RID: 65443
		[Token(Token = "0x400FFA3")]
		[FieldOffset(Offset = "0x438")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020023A8 RID: 9128
		[Token(Token = "0x20023A8")]
		[Serializable]
		public struct Options
		{
			// Token: 0x0400FFA4 RID: 65444
			[Token(Token = "0x400FFA4")]
			[FieldOffset(Offset = "0x0")]
			public BuildableType buildableType;

			// Token: 0x0400FFA5 RID: 65445
			[Token(Token = "0x400FFA5")]
			[FieldOffset(Offset = "0x4")]
			public MotionMask passableMask;

			// Token: 0x0400FFA6 RID: 65446
			[Token(Token = "0x400FFA6")]
			[FieldOffset(Offset = "0x8")]
			public bool overrideObstacleLikeMoveCost;

			// Token: 0x0400FFA7 RID: 65447
			[Token(Token = "0x400FFA7")]
			[FieldOffset(Offset = "0xC")]
			public AdvancedBuildableMask advancedBuildMask;

			// Token: 0x0400FFA8 RID: 65448
			[Token(Token = "0x400FFA8")]
			[FieldOffset(Offset = "0x10")]
			public TileData.HeightType heightType;
		}

		// Token: 0x020023A9 RID: 9129
		[Token(Token = "0x20023A9")]
		[Serializable]
		public struct TileEffectSpec
		{
			// Token: 0x0600E80A RID: 59402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E80A")]
			[Address(RVA = "0x5DD690", Offset = "0x5DC290", VA = "0x1805DD690")]
			public TileEffectSpec(string key, Effect effectInstance)
			{
			}

			// Token: 0x0400FFA9 RID: 65449
			[Token(Token = "0x400FFA9")]
			[FieldOffset(Offset = "0x0")]
			public string verifyKey;

			// Token: 0x0400FFAA RID: 65450
			[Token(Token = "0x400FFAA")]
			[FieldOffset(Offset = "0x8")]
			public ObjectPtr<Effect> effect;
		}

		// Token: 0x020023AA RID: 9130
		[Token(Token = "0x20023AA")]
		public abstract class Behaviour : MonoBehaviour
		{
			// Token: 0x17001D43 RID: 7491
			// (get) Token: 0x0600E80B RID: 59403 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600E80C RID: 59404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001D43")]
			private protected Tile tile
			{
				[Token(Token = "0x600E80B")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600E80C")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001D44 RID: 7492
			// (get) Token: 0x0600E80D RID: 59405 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001D44")]
			protected Blackboard blackboard
			{
				[Token(Token = "0x600E80D")]
				[Address(RVA = "0x5CEBD0", Offset = "0x5CD7D0", VA = "0x1805CEBD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001D45 RID: 7493
			// (get) Token: 0x0600E80E RID: 59406 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001D45")]
			protected Character character
			{
				[Token(Token = "0x600E80E")]
				[Address(RVA = "0x5CEBF0", Offset = "0x5CD7F0", VA = "0x1805CEBF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600E80F RID: 59407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E80F")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "4")]
			public virtual void Init(Tile tile)
			{
			}

			// Token: 0x0600E810 RID: 59408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E810")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "5")]
			public virtual void ImportInit(Tile tile)
			{
			}

			// Token: 0x0600E811 RID: 59409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E811")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
			public virtual void OnTrigger()
			{
			}

			// Token: 0x0600E812 RID: 59410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E812")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
			public virtual void OnEntityEnter(Entity entity)
			{
			}

			// Token: 0x0600E813 RID: 59411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E813")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
			public virtual void OnEntityLeave(Entity entity)
			{
			}

			// Token: 0x0600E814 RID: 59412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E814")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
			public virtual void OnGameStart()
			{
			}

			// Token: 0x0600E815 RID: 59413 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E815")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
			public virtual void OnGameOver(BattleController.GameResult result)
			{
			}

			// Token: 0x0600E816 RID: 59414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E816")]
			[Address(RVA = "0x5CEBB0", Offset = "0x5CD7B0", VA = "0x1805CEBB0")]
			protected void TrigTile()
			{
			}

			// Token: 0x0600E817 RID: 59415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E817")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
			public virtual void PreloadAssets()
			{
			}

			// Token: 0x0600E818 RID: 59416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E818")]
			[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
			protected Behaviour()
			{
			}
		}

		// Token: 0x020023AB RID: 9131
		[Token(Token = "0x20023AB")]
		public class TileDynamicPositionController : IHotfixable, IUpdateable
		{
			// Token: 0x17001D46 RID: 7494
			// (get) Token: 0x0600E819 RID: 59417 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600E81A RID: 59418 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001D46")]
			private protected Tile tile
			{
				[Token(Token = "0x600E819")]
				[Address(RVA = "0x5DD5B0", Offset = "0x5DC1B0", VA = "0x1805DD5B0")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600E81A")]
				[Address(RVA = "0x5DD610", Offset = "0x5DC210", VA = "0x1805DD610")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001D47 RID: 7495
			// (get) Token: 0x0600E81B RID: 59419 RVA: 0x00054B28 File Offset: 0x00052D28
			[Token(Token = "0x17001D47")]
			public Vector3 dynamicPositionDelta
			{
				[Token(Token = "0x600E81B")]
				[Address(RVA = "0x5DD530", Offset = "0x5DC130", VA = "0x1805DD530")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17001D48 RID: 7496
			// (get) Token: 0x0600E81C RID: 59420 RVA: 0x00054B40 File Offset: 0x00052D40
			[Token(Token = "0x17001D48")]
			public MotionMode charMotionMode
			{
				[Token(Token = "0x600E81C")]
				[Address(RVA = "0x5DD4C0", Offset = "0x5DC0C0", VA = "0x1805DD4C0")]
				get
				{
					return MotionMode.WALK;
				}
			}

			// Token: 0x0600E81D RID: 59421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E81D")]
			[Address(RVA = "0x5DCC30", Offset = "0x5DB830", VA = "0x1805DCC30")]
			public void Init(Tile tile)
			{
			}

			// Token: 0x0600E81E RID: 59422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E81E")]
			[Address(RVA = "0x5DCB90", Offset = "0x5DB790", VA = "0x1805DCB90")]
			public void BindDynamicPositionDeltaProvider(Tile.TileDynamicPositionController.IDynamicPositionDeltaProvider provider)
			{
			}

			// Token: 0x0600E81F RID: 59423 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E81F")]
			[Address(RVA = "0x5DD250", Offset = "0x5DBE50", VA = "0x1805DD250")]
			public void UnbindDynamicPositionDeltaProvider(Tile.TileDynamicPositionController.IDynamicPositionDeltaProvider provider)
			{
			}

			// Token: 0x0600E820 RID: 59424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E820")]
			[Address(RVA = "0x5DCD30", Offset = "0x5DB930", VA = "0x1805DCD30", Slot = "4")]
			public void OnFixedUpdate(FP deltaTime)
			{
			}

			// Token: 0x0600E821 RID: 59425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E821")]
			[Address(RVA = "0x5DD2F0", Offset = "0x5DBEF0", VA = "0x1805DD2F0")]
			public TileDynamicPositionController()
			{
			}

			// Token: 0x0400FFAC RID: 65452
			[Token(Token = "0x400FFAC")]
			private const float HEIGHT_CHANGED_TO_FLY_BLOCK_MOTION_MODE = 0.1f;

			// Token: 0x0400FFAE RID: 65454
			[Token(Token = "0x400FFAE")]
			[FieldOffset(Offset = "0x18")]
			private Vector3 m_toDelta;

			// Token: 0x0400FFAF RID: 65455
			[Token(Token = "0x400FFAF")]
			[FieldOffset(Offset = "0x24")]
			private Vector3 m_fromDelta;

			// Token: 0x0400FFB0 RID: 65456
			[Token(Token = "0x400FFB0")]
			[FieldOffset(Offset = "0x30")]
			private Vector3 m_delta;

			// Token: 0x0400FFB1 RID: 65457
			[Token(Token = "0x400FFB1")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 m_lastDelta;

			// Token: 0x0400FFB2 RID: 65458
			[Token(Token = "0x400FFB2")]
			[FieldOffset(Offset = "0x48")]
			private FP m_lastUpdateTime;

			// Token: 0x0400FFB3 RID: 65459
			[Token(Token = "0x400FFB3")]
			[FieldOffset(Offset = "0x50")]
			private List<Tile.TileDynamicPositionController.IDynamicPositionDeltaProvider> m_dynamicPositionDeltaProviders;

			// Token: 0x0400FFB4 RID: 65460
			[Token(Token = "0x400FFB4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_tile;

			// Token: 0x0400FFB5 RID: 65461
			[Token(Token = "0x400FFB5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_tile;

			// Token: 0x0400FFB6 RID: 65462
			[Token(Token = "0x400FFB6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_dynamicPositionDelta;

			// Token: 0x0400FFB7 RID: 65463
			[Token(Token = "0x400FFB7")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_charMotionMode;

			// Token: 0x0400FFB8 RID: 65464
			[Token(Token = "0x400FFB8")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400FFB9 RID: 65465
			[Token(Token = "0x400FFB9")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BindDynamicPositionDeltaProvider;

			// Token: 0x0400FFBA RID: 65466
			[Token(Token = "0x400FFBA")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_UnbindDynamicPositionDeltaProvider;

			// Token: 0x0400FFBB RID: 65467
			[Token(Token = "0x400FFBB")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnFixedUpdate;

			// Token: 0x0400FFBC RID: 65468
			[Token(Token = "0x400FFBC")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020023AC RID: 9132
			[Token(Token = "0x20023AC")]
			public interface IDynamicPositionDeltaProvider : IHotfixable
			{
				// Token: 0x0600E822 RID: 59426
				[Token(Token = "0x600E822")]
				Vector3 GetDynamicPositionDelta(Tile tile);
			}
		}

		// Token: 0x020023AD RID: 9133
		[Token(Token = "0x20023AD")]
		private class DefaultTransformStatus : IEquatable<Tile.DefaultTransformStatus>
		{
			// Token: 0x17001D49 RID: 7497
			// (get) Token: 0x0600E823 RID: 59427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001D49")]
			[Nullable(1)]
			protected virtual Type EqualityContract
			{
				[Token(Token = "0x600E823")]
				[Address(RVA = "0x5CF970", Offset = "0x5CE570", VA = "0x1805CF970", Slot = "5")]
				[NullableContext(1)]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600E824 RID: 59428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E824")]
			[Address(RVA = "0x5CF920", Offset = "0x5CE520", VA = "0x1805CF920")]
			public DefaultTransformStatus(Transform transform)
			{
			}

			// Token: 0x0600E825 RID: 59429 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600E825")]
			[Address(RVA = "0x5CF740", Offset = "0x5CE340", VA = "0x1805CF740", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0600E826 RID: 59430 RVA: 0x00054B58 File Offset: 0x00052D58
			[Token(Token = "0x600E826")]
			[Address(RVA = "0x5CF6B0", Offset = "0x5CE2B0", VA = "0x1805CF6B0", Slot = "6")]
			[NullableContext(1)]
			protected virtual bool PrintMembers(StringBuilder builder)
			{
				return default(bool);
			}

			// Token: 0x0600E827 RID: 59431 RVA: 0x00054B70 File Offset: 0x00052D70
			[Token(Token = "0x600E827")]
			[Address(RVA = "0x5CFA40", Offset = "0x5CE640", VA = "0x1805CFA40")]
			[NullableContext(2)]
			public static bool operator !=(Tile.DefaultTransformStatus r1, Tile.DefaultTransformStatus r2)
			{
				return default(bool);
			}

			// Token: 0x0600E828 RID: 59432 RVA: 0x00054B88 File Offset: 0x00052D88
			[Token(Token = "0x600E828")]
			[Address(RVA = "0x5CF9D0", Offset = "0x5CE5D0", VA = "0x1805CF9D0")]
			[NullableContext(2)]
			public static bool operator ==(Tile.DefaultTransformStatus r1, Tile.DefaultTransformStatus r2)
			{
				return default(bool);
			}

			// Token: 0x0600E829 RID: 59433 RVA: 0x00054BA0 File Offset: 0x00052DA0
			[Token(Token = "0x600E829")]
			[Address(RVA = "0x5CF580", Offset = "0x5CE180", VA = "0x1805CF580", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x0600E82A RID: 59434 RVA: 0x00054BB8 File Offset: 0x00052DB8
			[Token(Token = "0x600E82A")]
			[Address(RVA = "0x5CF340", Offset = "0x5CDF40", VA = "0x1805CF340", Slot = "0")]
			[NullableContext(2)]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x0600E82B RID: 59435 RVA: 0x00054BD0 File Offset: 0x00052DD0
			[Token(Token = "0x600E82B")]
			[Address(RVA = "0x5CF400", Offset = "0x5CE000", VA = "0x1805CF400", Slot = "7")]
			[NullableContext(2)]
			public virtual bool Equals(Tile.DefaultTransformStatus other)
			{
				return default(bool);
			}

			// Token: 0x0600E82C RID: 59436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600E82C")]
			[Address(RVA = "0x5CF870", Offset = "0x5CE470", VA = "0x1805CF870", Slot = "8")]
			[NullableContext(1)]
			public virtual Tile.DefaultTransformStatus <Clone>$()
			{
				return null;
			}

			// Token: 0x0600E82D RID: 59437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E82D")]
			[Address(RVA = "0x5CF8E0", Offset = "0x5CE4E0", VA = "0x1805CF8E0")]
			protected DefaultTransformStatus([Nullable(1)] Tile.DefaultTransformStatus original)
			{
			}

			// Token: 0x0400FFBD RID: 65469
			[Token(Token = "0x400FFBD")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 position;
		}

		// Token: 0x020023AE RID: 9134
		[Token(Token = "0x20023AE")]
		protected class SortedDoubleBufferedBuildSlots : DoubleBufferedList<ObjectPtr<Character>>
		{
			// Token: 0x0600E82E RID: 59438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E82E")]
			[Address(RVA = "0x5DBAC0", Offset = "0x5DA6C0", VA = "0x1805DBAC0", Slot = "6")]
			public override void Add(ObjectPtr<Character> element)
			{
			}

			// Token: 0x0600E82F RID: 59439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E82F")]
			[Address(RVA = "0x5DBD80", Offset = "0x5DA980", VA = "0x1805DBD80")]
			public void ClearInvalidElementsIfNotLoop()
			{
			}

			// Token: 0x0600E830 RID: 59440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E830")]
			[Address(RVA = "0x5DBEB0", Offset = "0x5DAAB0", VA = "0x1805DBEB0")]
			public SortedDoubleBufferedBuildSlots()
			{
			}

			// Token: 0x0400FFBE RID: 65470
			[Token(Token = "0x400FFBE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Add;

			// Token: 0x0400FFBF RID: 65471
			[Token(Token = "0x400FFBF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ClearInvalidElementsIfNotLoop;

			// Token: 0x0400FFC0 RID: 65472
			[Token(Token = "0x400FFC0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
