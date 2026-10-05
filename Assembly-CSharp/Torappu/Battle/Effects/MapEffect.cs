using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200327F RID: 12927
	[Token(Token = "0x200327F")]
	public class MapEffect : Effect, ITileListener
	{
		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x060147FE RID: 83966 RVA: 0x00087000 File Offset: 0x00085200
		[Token(Token = "0x1700306B")]
		protected internal override float delayToRecycle
		{
			[Token(Token = "0x60147FE")]
			[Address(RVA = "0xCB1940", Offset = "0xCB0540", VA = "0x180CB1940", Slot = "16")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x060147FF RID: 83967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700306C")]
		public Tile tile
		{
			[Token(Token = "0x60147FF")]
			[Address(RVA = "0xCB1B80", Offset = "0xCB0780", VA = "0x180CB1B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x06014800 RID: 83968 RVA: 0x00087018 File Offset: 0x00085218
		[Token(Token = "0x1700306D")]
		public override bool allowAutoReuse
		{
			[Token(Token = "0x6014800")]
			[Address(RVA = "0xCB18E0", Offset = "0xCB04E0", VA = "0x180CB18E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x06014801 RID: 83969 RVA: 0x00087030 File Offset: 0x00085230
		[Token(Token = "0x1700306E")]
		public override int preloadCnt
		{
			[Token(Token = "0x6014801")]
			[Address(RVA = "0xCB1AC0", Offset = "0xCB06C0", VA = "0x180CB1AC0", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x06014802 RID: 83970 RVA: 0x00087048 File Offset: 0x00085248
		[Token(Token = "0x1700306F")]
		protected override Effect.SpawnLocation spawnLocation
		{
			[Token(Token = "0x6014802")]
			[Address(RVA = "0xCB1B20", Offset = "0xCB0720", VA = "0x180CB1B20", Slot = "10")]
			get
			{
				return Effect.SpawnLocation.NONE;
			}
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x06014803 RID: 83971 RVA: 0x00087060 File Offset: 0x00085260
		[Token(Token = "0x17003070")]
		protected override bool useBodyDirection
		{
			[Token(Token = "0x6014803")]
			[Address(RVA = "0xCB1BE0", Offset = "0xCB07E0", VA = "0x180CB1BE0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x06014804 RID: 83972 RVA: 0x00087078 File Offset: 0x00085278
		[Token(Token = "0x17003071")]
		protected override bool holdByOwner
		{
			[Token(Token = "0x6014804")]
			[Address(RVA = "0xCB1A00", Offset = "0xCB0600", VA = "0x180CB1A00", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x06014805 RID: 83973 RVA: 0x00087090 File Offset: 0x00085290
		[Token(Token = "0x17003072")]
		protected override bool overwriteHeight
		{
			[Token(Token = "0x6014805")]
			[Address(RVA = "0xCB1A60", Offset = "0xCB0660", VA = "0x180CB1A60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x06014806 RID: 83974 RVA: 0x000870A8 File Offset: 0x000852A8
		[Token(Token = "0x17003073")]
		protected override float heightOffset
		{
			[Token(Token = "0x6014806")]
			[Address(RVA = "0xCB19A0", Offset = "0xCB05A0", VA = "0x180CB19A0", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06014807 RID: 83975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014807")]
		[Address(RVA = "0xCB1560", Offset = "0xCB0160", VA = "0x180CB1560")]
		public void Play(MapEffectData data)
		{
		}

		// Token: 0x06014808 RID: 83976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014808")]
		[Address(RVA = "0xCB1150", Offset = "0xCAFD50", VA = "0x180CB1150", Slot = "21")]
		protected override void OnBeforePlay()
		{
		}

		// Token: 0x06014809 RID: 83977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014809")]
		[Address(RVA = "0xCB1310", Offset = "0xCAFF10", VA = "0x180CB1310", Slot = "20")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0601480A RID: 83978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601480A")]
		[Address(RVA = "0xCB14B0", Offset = "0xCB00B0", VA = "0x180CB14B0", Slot = "31")]
		protected override void OnPausedUpdated(bool originIsPaused)
		{
		}

		// Token: 0x0601480B RID: 83979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601480B")]
		[Address(RVA = "0xCB1720", Offset = "0xCB0320", VA = "0x180CB1720")]
		public void SetTile(Tile tile)
		{
		}

		// Token: 0x0601480C RID: 83980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601480C")]
		[Address(RVA = "0xCB1400", Offset = "0xCB0000", VA = "0x180CB1400", Slot = "33")]
		public void OnLocatedCharacterUpdate(Character character)
		{
		}

		// Token: 0x0601480D RID: 83981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601480D")]
		[Address(RVA = "0xCB1250", Offset = "0xCAFE50", VA = "0x180CB1250", Slot = "34")]
		public void OnEntityEnter(Entity entity)
		{
		}

		// Token: 0x0601480E RID: 83982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601480E")]
		[Address(RVA = "0xCB12B0", Offset = "0xCAFEB0", VA = "0x180CB12B0", Slot = "35")]
		public void OnEntityLeave(Entity entity)
		{
		}

		// Token: 0x0601480F RID: 83983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601480F")]
		[Address(RVA = "0xCB1840", Offset = "0xCB0440", VA = "0x180CB1840")]
		public MapEffect()
		{
		}

		// Token: 0x06014810 RID: 83984 RVA: 0x000870C0 File Offset: 0x000852C0
		[Token(Token = "0x6014810")]
		[Address(RVA = "0xCB0810", Offset = "0xCAF410", VA = "0x180CB0810")]
		private float <>xLuaBaseProxy_get_delayToRecycle()
		{
			return 0f;
		}

		// Token: 0x06014811 RID: 83985 RVA: 0x000870D8 File Offset: 0x000852D8
		[Token(Token = "0x6014811")]
		[Address(RVA = "0xCB0830", Offset = "0xCAF430", VA = "0x180CB0830")]
		private bool <>xLuaBaseProxy_get_overwriteHeight()
		{
			return default(bool);
		}

		// Token: 0x06014812 RID: 83986 RVA: 0x000870F0 File Offset: 0x000852F0
		[Token(Token = "0x6014812")]
		[Address(RVA = "0xCB0820", Offset = "0xCAF420", VA = "0x180CB0820")]
		private float <>xLuaBaseProxy_get_heightOffset()
		{
			return 0f;
		}

		// Token: 0x06014813 RID: 83987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014813")]
		[Address(RVA = "0xCB1810", Offset = "0xCB0410", VA = "0x180CB1810")]
		private void <>xLuaBaseProxy_OnBeforePlay()
		{
		}

		// Token: 0x06014814 RID: 83988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014814")]
		[Address(RVA = "0xCB1820", Offset = "0xCB0420", VA = "0x180CB1820")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x06014815 RID: 83989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014815")]
		[Address(RVA = "0xCB1830", Offset = "0xCB0430", VA = "0x180CB1830")]
		private void <>xLuaBaseProxy_OnPausedUpdated(bool P0)
		{
		}

		// Token: 0x040183C6 RID: 99270
		[Token(Token = "0x40183C6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Vector3 _spawnMapOffset;

		// Token: 0x040183C7 RID: 99271
		[Token(Token = "0x40183C7")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private bool _pauseIfTileIsLocated;

		// Token: 0x040183C8 RID: 99272
		[Token(Token = "0x40183C8")]
		[FieldOffset(Offset = "0xB5")]
		[SerializeField]
		private bool _forceZeroHeight;

		// Token: 0x040183C9 RID: 99273
		[Token(Token = "0x40183C9")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _delayToFinish;

		// Token: 0x040183CA RID: 99274
		[Token(Token = "0x40183CA")]
		[FieldOffset(Offset = "0xC0")]
		private Tile m_tile;

		// Token: 0x040183CB RID: 99275
		[Token(Token = "0x40183CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_delayToRecycle;

		// Token: 0x040183CC RID: 99276
		[Token(Token = "0x40183CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_tile;

		// Token: 0x040183CD RID: 99277
		[Token(Token = "0x40183CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_allowAutoReuse;

		// Token: 0x040183CE RID: 99278
		[Token(Token = "0x40183CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_preloadCnt;

		// Token: 0x040183CF RID: 99279
		[Token(Token = "0x40183CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_spawnLocation;

		// Token: 0x040183D0 RID: 99280
		[Token(Token = "0x40183D0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_useBodyDirection;

		// Token: 0x040183D1 RID: 99281
		[Token(Token = "0x40183D1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_holdByOwner;

		// Token: 0x040183D2 RID: 99282
		[Token(Token = "0x40183D2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_overwriteHeight;

		// Token: 0x040183D3 RID: 99283
		[Token(Token = "0x40183D3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_heightOffset;

		// Token: 0x040183D4 RID: 99284
		[Token(Token = "0x40183D4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x040183D5 RID: 99285
		[Token(Token = "0x40183D5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBeforePlay;

		// Token: 0x040183D6 RID: 99286
		[Token(Token = "0x40183D6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x040183D7 RID: 99287
		[Token(Token = "0x40183D7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnPausedUpdated;

		// Token: 0x040183D8 RID: 99288
		[Token(Token = "0x40183D8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetTile;

		// Token: 0x040183D9 RID: 99289
		[Token(Token = "0x40183D9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnLocatedCharacterUpdate;

		// Token: 0x040183DA RID: 99290
		[Token(Token = "0x40183DA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnEntityEnter;

		// Token: 0x040183DB RID: 99291
		[Token(Token = "0x40183DB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnEntityLeave;

		// Token: 0x040183DC RID: 99292
		[Token(Token = "0x40183DC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
