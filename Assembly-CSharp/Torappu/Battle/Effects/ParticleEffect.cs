using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003280 RID: 12928
	[Token(Token = "0x2003280")]
	public class ParticleEffect : Effect
	{
		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x06014816 RID: 83990 RVA: 0x00087108 File Offset: 0x00085308
		[Token(Token = "0x17003074")]
		public bool isFourDir
		{
			[Token(Token = "0x6014816")]
			[Address(RVA = "0xCB3590", Offset = "0xCB2190", VA = "0x180CB3590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x06014817 RID: 83991 RVA: 0x00087120 File Offset: 0x00085320
		[Token(Token = "0x17003075")]
		public float maxLifeTime
		{
			[Token(Token = "0x6014817")]
			[Address(RVA = "0xCB3660", Offset = "0xCB2260", VA = "0x180CB3660")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x06014818 RID: 83992 RVA: 0x00087138 File Offset: 0x00085338
		[Token(Token = "0x17003076")]
		public override bool allowAutoReuse
		{
			[Token(Token = "0x6014818")]
			[Address(RVA = "0xCB33B0", Offset = "0xCB1FB0", VA = "0x180CB33B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x06014819 RID: 83993 RVA: 0x00087150 File Offset: 0x00085350
		[Token(Token = "0x17003077")]
		public override int preloadCnt
		{
			[Token(Token = "0x6014819")]
			[Address(RVA = "0xCB3820", Offset = "0xCB2420", VA = "0x180CB3820", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x0601481A RID: 83994 RVA: 0x00087168 File Offset: 0x00085368
		[Token(Token = "0x17003078")]
		protected override Effect.SpawnLocation spawnLocation
		{
			[Token(Token = "0x601481A")]
			[Address(RVA = "0xCB38E0", Offset = "0xCB24E0", VA = "0x180CB38E0", Slot = "10")]
			get
			{
				return Effect.SpawnLocation.NONE;
			}
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x0601481B RID: 83995 RVA: 0x00087180 File Offset: 0x00085380
		[Token(Token = "0x17003079")]
		protected override bool useBodyDirection
		{
			[Token(Token = "0x601481B")]
			[Address(RVA = "0xCB3940", Offset = "0xCB2540", VA = "0x180CB3940", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x0601481C RID: 83996 RVA: 0x00087198 File Offset: 0x00085398
		[Token(Token = "0x1700307A")]
		protected override bool holdByOwner
		{
			[Token(Token = "0x601481C")]
			[Address(RVA = "0xCB3530", Offset = "0xCB2130", VA = "0x180CB3530", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x0601481D RID: 83997 RVA: 0x000871B0 File Offset: 0x000853B0
		[Token(Token = "0x1700307B")]
		protected override bool overwriteHeight
		{
			[Token(Token = "0x601481D")]
			[Address(RVA = "0xCB36C0", Offset = "0xCB22C0", VA = "0x180CB36C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x0601481E RID: 83998 RVA: 0x000871C8 File Offset: 0x000853C8
		[Token(Token = "0x1700307C")]
		protected override float heightOffset
		{
			[Token(Token = "0x601481E")]
			[Address(RVA = "0xCB34D0", Offset = "0xCB20D0", VA = "0x180CB34D0", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x0601481F RID: 83999 RVA: 0x000871E0 File Offset: 0x000853E0
		[Token(Token = "0x1700307D")]
		protected override float delayToPlay
		{
			[Token(Token = "0x601481F")]
			[Address(RVA = "0xCB3410", Offset = "0xCB2010", VA = "0x180CB3410", Slot = "15")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x06014820 RID: 84000 RVA: 0x000871F8 File Offset: 0x000853F8
		[Token(Token = "0x1700307E")]
		protected internal override float delayToRecycle
		{
			[Token(Token = "0x6014820")]
			[Address(RVA = "0xCB3470", Offset = "0xCB2070", VA = "0x180CB3470", Slot = "16")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x06014821 RID: 84001 RVA: 0x00087210 File Offset: 0x00085410
		[Token(Token = "0x1700307F")]
		protected override bool randomPlayDelay
		{
			[Token(Token = "0x6014821")]
			[Address(RVA = "0xCB3880", Offset = "0xCB2480", VA = "0x180CB3880", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x06014822 RID: 84002 RVA: 0x00087228 File Offset: 0x00085428
		[Token(Token = "0x17003080")]
		protected override bool usePlaybackSpeed
		{
			[Token(Token = "0x6014822")]
			[Address(RVA = "0xCB39A0", Offset = "0xCB25A0", VA = "0x180CB39A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x06014823 RID: 84003 RVA: 0x00087240 File Offset: 0x00085440
		[Token(Token = "0x17003081")]
		protected override float limitedPlaybackSpeed
		{
			[Token(Token = "0x6014823")]
			[Address(RVA = "0xCB3600", Offset = "0xCB2200", VA = "0x180CB3600", Slot = "19")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x06014824 RID: 84004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003082")]
		protected ParticleSystem particleSystem
		{
			[Token(Token = "0x6014824")]
			[Address(RVA = "0xCB3720", Offset = "0xCB2320", VA = "0x180CB3720")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x06014825 RID: 84005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003083")]
		protected ParticleSystem[] particleSystems
		{
			[Token(Token = "0x6014825")]
			[Address(RVA = "0xCB3780", Offset = "0xCB2380", VA = "0x180CB3780")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014826 RID: 84006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014826")]
		[Address(RVA = "0xCB2AB0", Offset = "0xCB16B0", VA = "0x180CB2AB0", Slot = "20")]
		protected override void OnFinish()
		{
		}

		// Token: 0x06014827 RID: 84007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014827")]
		[Address(RVA = "0xCB1D00", Offset = "0xCB0900", VA = "0x180CB1D00", Slot = "29")]
		protected override void DoPlay()
		{
		}

		// Token: 0x06014828 RID: 84008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014828")]
		[Address(RVA = "0xCB26D0", Offset = "0xCB12D0", VA = "0x180CB26D0", Slot = "21")]
		protected override void OnBeforePlay()
		{
		}

		// Token: 0x06014829 RID: 84009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014829")]
		[Address(RVA = "0xCB1DC0", Offset = "0xCB09C0", VA = "0x180CB1DC0", Slot = "26")]
		public override void FaceTo(Vector3 direction)
		{
		}

		// Token: 0x0601482A RID: 84010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601482A")]
		[Address(RVA = "0xCB2240", Offset = "0xCB0E40", VA = "0x180CB2240", Slot = "27")]
		public override void Flip(bool flip)
		{
		}

		// Token: 0x0601482B RID: 84011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601482B")]
		[Address(RVA = "0xCB3230", Offset = "0xCB1E30", VA = "0x180CB3230")]
		private IEnumerator _CheckIfAlive()
		{
			return null;
		}

		// Token: 0x0601482C RID: 84012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601482C")]
		[Address(RVA = "0xCB3060", Offset = "0xCB1C60", VA = "0x180CB3060", Slot = "30")]
		protected override void UpdatePlaybackSpeed(float playbackSpeed)
		{
		}

		// Token: 0x0601482D RID: 84013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601482D")]
		[Address(RVA = "0xCB2D60", Offset = "0xCB1960", VA = "0x180CB2D60", Slot = "31")]
		protected override void OnPausedUpdated(bool originIsPaused)
		{
		}

		// Token: 0x0601482E RID: 84014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601482E")]
		[Address(RVA = "0xCB29A0", Offset = "0xCB15A0", VA = "0x180CB29A0", Slot = "25")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0601482F RID: 84015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601482F")]
		[Address(RVA = "0xCB1C40", Offset = "0xCB0840", VA = "0x180CB1C40", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x06014830 RID: 84016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014830")]
		[Address(RVA = "0xCB2F00", Offset = "0xCB1B00", VA = "0x180CB2F00", Slot = "23")]
		public override void OnRecycle()
		{
		}

		// Token: 0x06014831 RID: 84017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014831")]
		[Address(RVA = "0xCB32E0", Offset = "0xCB1EE0", VA = "0x180CB32E0")]
		public ParticleEffect()
		{
		}

		// Token: 0x06014832 RID: 84018 RVA: 0x00087258 File Offset: 0x00085458
		[Token(Token = "0x6014832")]
		[Address(RVA = "0xCB0830", Offset = "0xCAF430", VA = "0x180CB0830")]
		private bool <>xLuaBaseProxy_get_overwriteHeight()
		{
			return default(bool);
		}

		// Token: 0x06014833 RID: 84019 RVA: 0x00087270 File Offset: 0x00085470
		[Token(Token = "0x6014833")]
		[Address(RVA = "0xCB0820", Offset = "0xCAF420", VA = "0x180CB0820")]
		private float <>xLuaBaseProxy_get_heightOffset()
		{
			return 0f;
		}

		// Token: 0x06014834 RID: 84020 RVA: 0x00087288 File Offset: 0x00085488
		[Token(Token = "0x6014834")]
		[Address(RVA = "0xCB3020", Offset = "0xCB1C20", VA = "0x180CB3020")]
		private float <>xLuaBaseProxy_get_delayToPlay()
		{
			return 0f;
		}

		// Token: 0x06014835 RID: 84021 RVA: 0x000872A0 File Offset: 0x000854A0
		[Token(Token = "0x6014835")]
		[Address(RVA = "0xCB0810", Offset = "0xCAF410", VA = "0x180CB0810")]
		private float <>xLuaBaseProxy_get_delayToRecycle()
		{
			return 0f;
		}

		// Token: 0x06014836 RID: 84022 RVA: 0x000872B8 File Offset: 0x000854B8
		[Token(Token = "0x6014836")]
		[Address(RVA = "0xCB3040", Offset = "0xCB1C40", VA = "0x180CB3040")]
		private bool <>xLuaBaseProxy_get_randomPlayDelay()
		{
			return default(bool);
		}

		// Token: 0x06014837 RID: 84023 RVA: 0x000872D0 File Offset: 0x000854D0
		[Token(Token = "0x6014837")]
		[Address(RVA = "0xCB3050", Offset = "0xCB1C50", VA = "0x180CB3050")]
		private bool <>xLuaBaseProxy_get_usePlaybackSpeed()
		{
			return default(bool);
		}

		// Token: 0x06014838 RID: 84024 RVA: 0x000872E8 File Offset: 0x000854E8
		[Token(Token = "0x6014838")]
		[Address(RVA = "0xCB3030", Offset = "0xCB1C30", VA = "0x180CB3030")]
		private float <>xLuaBaseProxy_get_limitedPlaybackSpeed()
		{
			return 0f;
		}

		// Token: 0x06014839 RID: 84025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014839")]
		[Address(RVA = "0xCB1820", Offset = "0xCB0420", VA = "0x180CB1820")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0601483A RID: 84026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601483A")]
		[Address(RVA = "0xCB2FA0", Offset = "0xCB1BA0", VA = "0x180CB2FA0")]
		private void <>xLuaBaseProxy_DoPlay()
		{
		}

		// Token: 0x0601483B RID: 84027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601483B")]
		[Address(RVA = "0xCB1810", Offset = "0xCB0410", VA = "0x180CB1810")]
		private void <>xLuaBaseProxy_OnBeforePlay()
		{
		}

		// Token: 0x0601483C RID: 84028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601483C")]
		[Address(RVA = "0xCB2FB0", Offset = "0xCB1BB0", VA = "0x180CB2FB0")]
		private void <>xLuaBaseProxy_FaceTo(Vector3 P0)
		{
		}

		// Token: 0x0601483D RID: 84029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601483D")]
		[Address(RVA = "0xCB2FE0", Offset = "0xCB1BE0", VA = "0x180CB2FE0")]
		private void <>xLuaBaseProxy_Flip(bool P0)
		{
		}

		// Token: 0x0601483E RID: 84030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601483E")]
		[Address(RVA = "0xCB3010", Offset = "0xCB1C10", VA = "0x180CB3010")]
		private void <>xLuaBaseProxy_UpdatePlaybackSpeed(float P0)
		{
		}

		// Token: 0x0601483F RID: 84031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601483F")]
		[Address(RVA = "0xCB1830", Offset = "0xCB0430", VA = "0x180CB1830")]
		private void <>xLuaBaseProxy_OnPausedUpdated(bool P0)
		{
		}

		// Token: 0x06014840 RID: 84032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014840")]
		[Address(RVA = "0xCB2FF0", Offset = "0xCB1BF0", VA = "0x180CB2FF0")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x06014841 RID: 84033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014841")]
		[Address(RVA = "0xCB2F90", Offset = "0xCB1B90", VA = "0x180CB2F90")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x06014842 RID: 84034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014842")]
		[Address(RVA = "0xCB3000", Offset = "0xCB1C00", VA = "0x180CB3000")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x040183DD RID: 99293
		[Token(Token = "0x40183DD")]
		private const string CHILD_NAME_ROTATION_Y = "rotation_y";

		// Token: 0x040183DE RID: 99294
		[Token(Token = "0x40183DE")]
		private const string CHILD_NAME_ROTATION_Z = "rotation_z";

		// Token: 0x040183DF RID: 99295
		[Token(Token = "0x40183DF")]
		private const string CHILD_NAME_STATIC_OFFSET = "static_offset";

		// Token: 0x040183E0 RID: 99296
		[Token(Token = "0x40183E0")]
		private const string CHILD_NAME_FLIP_X = "flip_x";

		// Token: 0x040183E1 RID: 99297
		[Token(Token = "0x40183E1")]
		private const float CHECK_IF_ALIVE_DELTA = 0.5f;

		// Token: 0x040183E2 RID: 99298
		[Token(Token = "0x40183E2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Main", Priority = 0, Expandable = false)]
		private float _delayToPlay;

		// Token: 0x040183E3 RID: 99299
		[Token(Token = "0x40183E3")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[Group("Main")]
		private float _delayToFinish;

		// Token: 0x040183E4 RID: 99300
		[Token(Token = "0x40183E4")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Main")]
		private float _maxLifetime;

		// Token: 0x040183E5 RID: 99301
		[Token(Token = "0x40183E5")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[Group("Main")]
		private bool _randomPlayDelay;

		// Token: 0x040183E6 RID: 99302
		[Token(Token = "0x40183E6")]
		[FieldOffset(Offset = "0xB5")]
		[SerializeField]
		[Group("Main")]
		private bool _allowAutoReuse;

		// Token: 0x040183E7 RID: 99303
		[Token(Token = "0x40183E7")]
		[FieldOffset(Offset = "0xB6")]
		[SerializeField]
		[Group("Main")]
		private bool _usePlaybackSpeed;

		// Token: 0x040183E8 RID: 99304
		[Token(Token = "0x40183E8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Main")]
		private float _limitedPlaybackSpeed;

		// Token: 0x040183E9 RID: 99305
		[Token(Token = "0x40183E9")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[Group("Main")]
		private int _preloadCnt;

		// Token: 0x040183EA RID: 99306
		[Token(Token = "0x40183EA")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Location", Priority = 1)]
		private ParticleEffect.RotateType _rotateType;

		// Token: 0x040183EB RID: 99307
		[Token(Token = "0x40183EB")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[Group("Location")]
		private Effect.SpawnLocation _spawnLocation;

		// Token: 0x040183EC RID: 99308
		[Token(Token = "0x40183EC")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Location")]
		private bool _leftIsDefault;

		// Token: 0x040183ED RID: 99309
		[Token(Token = "0x40183ED")]
		[FieldOffset(Offset = "0xC9")]
		[SerializeField]
		[Group("Location")]
		[Tooltip("If true, this effect will ignore the input |direction| but use the bodyDirection of |target| as the direction.")]
		private bool _useBodyRotation;

		// Token: 0x040183EE RID: 99310
		[Token(Token = "0x40183EE")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[Group("Location")]
		[Inspect("isFourDir")]
		private SharedConsts.Direction _mainDir;

		// Token: 0x040183EF RID: 99311
		[Token(Token = "0x40183EF")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Location")]
		private bool _holdByOwner;

		// Token: 0x040183F0 RID: 99312
		[Token(Token = "0x40183F0")]
		[FieldOffset(Offset = "0xD1")]
		[SerializeField]
		[Group("Advanced", Priority = 2)]
		private bool _overwriteHeight;

		// Token: 0x040183F1 RID: 99313
		[Token(Token = "0x40183F1")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[Group("Advanced")]
		private float _heightOffset;

		// Token: 0x040183F2 RID: 99314
		[Token(Token = "0x40183F2")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		[Group("Debug")]
		private Transform _rotationY;

		// Token: 0x040183F3 RID: 99315
		[Token(Token = "0x40183F3")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		[Group("Debug")]
		private Transform _rotationZ;

		// Token: 0x040183F4 RID: 99316
		[Token(Token = "0x40183F4")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		[Group("Debug")]
		private Transform _flipZ;

		// Token: 0x040183F5 RID: 99317
		[Token(Token = "0x40183F5")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Transform[] _inactiveOnFinish;

		// Token: 0x040183F6 RID: 99318
		[Token(Token = "0x40183F6")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool _isLoop;

		// Token: 0x040183F7 RID: 99319
		[Token(Token = "0x40183F7")]
		[FieldOffset(Offset = "0xF9")]
		[SerializeField]
		private bool _ignoredByParticleEffectManager;

		// Token: 0x040183F8 RID: 99320
		[Token(Token = "0x40183F8")]
		[FieldOffset(Offset = "0x100")]
		private Animator m_animator;

		// Token: 0x040183F9 RID: 99321
		[Token(Token = "0x40183F9")]
		[FieldOffset(Offset = "0x108")]
		private ParticleSystem m_particleSystem;

		// Token: 0x040183FA RID: 99322
		[Token(Token = "0x40183FA")]
		[FieldOffset(Offset = "0x110")]
		private ParticleSystem[] m_particleSystems;

		// Token: 0x040183FB RID: 99323
		[Token(Token = "0x40183FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isFourDir;

		// Token: 0x040183FC RID: 99324
		[Token(Token = "0x40183FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_maxLifeTime;

		// Token: 0x040183FD RID: 99325
		[Token(Token = "0x40183FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_allowAutoReuse;

		// Token: 0x040183FE RID: 99326
		[Token(Token = "0x40183FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_preloadCnt;

		// Token: 0x040183FF RID: 99327
		[Token(Token = "0x40183FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_spawnLocation;

		// Token: 0x04018400 RID: 99328
		[Token(Token = "0x4018400")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_useBodyDirection;

		// Token: 0x04018401 RID: 99329
		[Token(Token = "0x4018401")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_holdByOwner;

		// Token: 0x04018402 RID: 99330
		[Token(Token = "0x4018402")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_overwriteHeight;

		// Token: 0x04018403 RID: 99331
		[Token(Token = "0x4018403")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_heightOffset;

		// Token: 0x04018404 RID: 99332
		[Token(Token = "0x4018404")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_delayToPlay;

		// Token: 0x04018405 RID: 99333
		[Token(Token = "0x4018405")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_delayToRecycle;

		// Token: 0x04018406 RID: 99334
		[Token(Token = "0x4018406")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_randomPlayDelay;

		// Token: 0x04018407 RID: 99335
		[Token(Token = "0x4018407")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_usePlaybackSpeed;

		// Token: 0x04018408 RID: 99336
		[Token(Token = "0x4018408")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_limitedPlaybackSpeed;

		// Token: 0x04018409 RID: 99337
		[Token(Token = "0x4018409")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_particleSystem;

		// Token: 0x0401840A RID: 99338
		[Token(Token = "0x401840A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_particleSystems;

		// Token: 0x0401840B RID: 99339
		[Token(Token = "0x401840B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0401840C RID: 99340
		[Token(Token = "0x401840C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_DoPlay;

		// Token: 0x0401840D RID: 99341
		[Token(Token = "0x401840D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnBeforePlay;

		// Token: 0x0401840E RID: 99342
		[Token(Token = "0x401840E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_FaceTo;

		// Token: 0x0401840F RID: 99343
		[Token(Token = "0x401840F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Flip;

		// Token: 0x04018410 RID: 99344
		[Token(Token = "0x4018410")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CheckIfAlive;

		// Token: 0x04018411 RID: 99345
		[Token(Token = "0x4018411")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_UpdatePlaybackSpeed;

		// Token: 0x04018412 RID: 99346
		[Token(Token = "0x4018412")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnPausedUpdated;

		// Token: 0x04018413 RID: 99347
		[Token(Token = "0x4018413")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04018414 RID: 99348
		[Token(Token = "0x4018414")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04018415 RID: 99349
		[Token(Token = "0x4018415")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04018416 RID: 99350
		[Token(Token = "0x4018416")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003281 RID: 12929
		[Token(Token = "0x2003281")]
		public enum RotateType
		{
			// Token: 0x04018418 RID: 99352
			[Token(Token = "0x4018418")]
			NONE,
			// Token: 0x04018419 RID: 99353
			[Token(Token = "0x4018419")]
			FLIP_TWO_SIDE,
			// Token: 0x0401841A RID: 99354
			[Token(Token = "0x401841A")]
			FOUR_DIRECTION,
			// Token: 0x0401841B RID: 99355
			[Token(Token = "0x401841B")]
			FIXED_DIRECTION,
			// Token: 0x0401841C RID: 99356
			[Token(Token = "0x401841C")]
			ANY_DIR
		}
	}
}
