using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003283 RID: 12931
	[Token(Token = "0x2003283")]
	public class ProjectileEffect : Effect
	{
		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x06014849 RID: 84041 RVA: 0x00087318 File Offset: 0x00085518
		[Token(Token = "0x17003086")]
		public bool resetMainDir
		{
			[Token(Token = "0x6014849")]
			[Address(RVA = "0xCB50C0", Offset = "0xCB3CC0", VA = "0x180CB50C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x0601484A RID: 84042 RVA: 0x00087330 File Offset: 0x00085530
		[Token(Token = "0x17003087")]
		public override int preloadCnt
		{
			[Token(Token = "0x601484A")]
			[Address(RVA = "0xCB5060", Offset = "0xCB3C60", VA = "0x180CB5060", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x0601484B RID: 84043 RVA: 0x00087348 File Offset: 0x00085548
		[Token(Token = "0x17003088")]
		protected override Effect.SpawnLocation spawnLocation
		{
			[Token(Token = "0x601484B")]
			[Address(RVA = "0xCB5120", Offset = "0xCB3D20", VA = "0x180CB5120", Slot = "10")]
			get
			{
				return Effect.SpawnLocation.NONE;
			}
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x0601484C RID: 84044 RVA: 0x00087360 File Offset: 0x00085560
		[Token(Token = "0x17003089")]
		protected override bool useBodyDirection
		{
			[Token(Token = "0x601484C")]
			[Address(RVA = "0xCB5180", Offset = "0xCB3D80", VA = "0x180CB5180", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x0601484D RID: 84045 RVA: 0x00087378 File Offset: 0x00085578
		[Token(Token = "0x1700308A")]
		protected override bool holdByOwner
		{
			[Token(Token = "0x601484D")]
			[Address(RVA = "0xCB4F00", Offset = "0xCB3B00", VA = "0x180CB4F00", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x0601484E RID: 84046 RVA: 0x00087390 File Offset: 0x00085590
		[Token(Token = "0x1700308B")]
		protected override bool overwriteHeight
		{
			[Token(Token = "0x601484E")]
			[Address(RVA = "0xCB4F60", Offset = "0xCB3B60", VA = "0x180CB4F60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x0601484F RID: 84047 RVA: 0x000873A8 File Offset: 0x000855A8
		[Token(Token = "0x1700308C")]
		protected override float heightOffset
		{
			[Token(Token = "0x601484F")]
			[Address(RVA = "0xCB4EA0", Offset = "0xCB3AA0", VA = "0x180CB4EA0", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x06014850 RID: 84048 RVA: 0x000873C0 File Offset: 0x000855C0
		[Token(Token = "0x1700308D")]
		public override bool allowAutoReuse
		{
			[Token(Token = "0x6014850")]
			[Address(RVA = "0xCB4D40", Offset = "0xCB3940", VA = "0x180CB4D40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x06014851 RID: 84049 RVA: 0x000873D8 File Offset: 0x000855D8
		[Token(Token = "0x1700308E")]
		protected internal override float delayToRecycle
		{
			[Token(Token = "0x6014851")]
			[Address(RVA = "0xCB4E40", Offset = "0xCB3A40", VA = "0x180CB4E40", Slot = "16")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x06014852 RID: 84050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700308F")]
		protected ParticleSystem[] particleSystems
		{
			[Token(Token = "0x6014852")]
			[Address(RVA = "0xCB4FC0", Offset = "0xCB3BC0", VA = "0x180CB4FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x06014853 RID: 84051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003090")]
		protected Animator[] animators
		{
			[Token(Token = "0x6014853")]
			[Address(RVA = "0xCB4DA0", Offset = "0xCB39A0", VA = "0x180CB4DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014854 RID: 84052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014854")]
		[Address(RVA = "0xCB44D0", Offset = "0xCB30D0", VA = "0x180CB44D0", Slot = "23")]
		public override void OnRecycle()
		{
		}

		// Token: 0x06014855 RID: 84053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014855")]
		[Address(RVA = "0xCB3A90", Offset = "0xCB2690", VA = "0x180CB3A90", Slot = "29")]
		protected override void DoPlay()
		{
		}

		// Token: 0x06014856 RID: 84054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014856")]
		[Address(RVA = "0xCB3C00", Offset = "0xCB2800", VA = "0x180CB3C00", Slot = "21")]
		protected override void OnBeforePlay()
		{
		}

		// Token: 0x06014857 RID: 84055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014857")]
		[Address(RVA = "0xCB42B0", Offset = "0xCB2EB0", VA = "0x180CB42B0", Slot = "20")]
		protected override void OnFinish()
		{
		}

		// Token: 0x06014858 RID: 84056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014858")]
		[Address(RVA = "0xCB3B50", Offset = "0xCB2750", VA = "0x180CB3B50")]
		public void ForceApplyPlaybackSpeedMultiplier(float speedMultiplier)
		{
		}

		// Token: 0x06014859 RID: 84057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014859")]
		[Address(RVA = "0xCB43E0", Offset = "0xCB2FE0", VA = "0x180CB43E0")]
		public void OnProjectileHit()
		{
		}

		// Token: 0x0601485A RID: 84058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601485A")]
		[Address(RVA = "0xCB45F0", Offset = "0xCB31F0", VA = "0x180CB45F0", Slot = "30")]
		protected override void UpdatePlaybackSpeed(float playbackSpeed)
		{
		}

		// Token: 0x0601485B RID: 84059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601485B")]
		[Address(RVA = "0xCB49A0", Offset = "0xCB35A0", VA = "0x180CB49A0")]
		private void _ClearPlaybackSpeedSettings()
		{
		}

		// Token: 0x0601485C RID: 84060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601485C")]
		[Address(RVA = "0xCB3A00", Offset = "0xCB2600", VA = "0x180CB3A00", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x0601485D RID: 84061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601485D")]
		[Address(RVA = "0xCB4C30", Offset = "0xCB3830", VA = "0x180CB4C30")]
		public ProjectileEffect()
		{
		}

		// Token: 0x0601485E RID: 84062 RVA: 0x000873F0 File Offset: 0x000855F0
		[Token(Token = "0x601485E")]
		[Address(RVA = "0xCB0830", Offset = "0xCAF430", VA = "0x180CB0830")]
		private bool <>xLuaBaseProxy_get_overwriteHeight()
		{
			return default(bool);
		}

		// Token: 0x0601485F RID: 84063 RVA: 0x00087408 File Offset: 0x00085608
		[Token(Token = "0x601485F")]
		[Address(RVA = "0xCB0820", Offset = "0xCAF420", VA = "0x180CB0820")]
		private float <>xLuaBaseProxy_get_heightOffset()
		{
			return 0f;
		}

		// Token: 0x06014860 RID: 84064 RVA: 0x00087420 File Offset: 0x00085620
		[Token(Token = "0x6014860")]
		[Address(RVA = "0xCB0810", Offset = "0xCAF410", VA = "0x180CB0810")]
		private float <>xLuaBaseProxy_get_delayToRecycle()
		{
			return 0f;
		}

		// Token: 0x06014861 RID: 84065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014861")]
		[Address(RVA = "0xCB3000", Offset = "0xCB1C00", VA = "0x180CB3000")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x06014862 RID: 84066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014862")]
		[Address(RVA = "0xCB2FA0", Offset = "0xCB1BA0", VA = "0x180CB2FA0")]
		private void <>xLuaBaseProxy_DoPlay()
		{
		}

		// Token: 0x06014863 RID: 84067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014863")]
		[Address(RVA = "0xCB1810", Offset = "0xCB0410", VA = "0x180CB1810")]
		private void <>xLuaBaseProxy_OnBeforePlay()
		{
		}

		// Token: 0x06014864 RID: 84068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014864")]
		[Address(RVA = "0xCB1820", Offset = "0xCB0420", VA = "0x180CB1820")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x06014865 RID: 84069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014865")]
		[Address(RVA = "0xCB3010", Offset = "0xCB1C10", VA = "0x180CB3010")]
		private void <>xLuaBaseProxy_UpdatePlaybackSpeed(float P0)
		{
		}

		// Token: 0x06014866 RID: 84070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014866")]
		[Address(RVA = "0xCB2F90", Offset = "0xCB1B90", VA = "0x180CB2F90")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x04018420 RID: 99360
		[Token(Token = "0x4018420")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _resetMainDir;

		// Token: 0x04018421 RID: 99361
		[Token(Token = "0x4018421")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[Inspect("resetMainDir")]
		private SharedConsts.Direction _mainDir;

		// Token: 0x04018422 RID: 99362
		[Token(Token = "0x4018422")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Inspect("resetMainDir")]
		private bool _rotate180Y;

		// Token: 0x04018423 RID: 99363
		[Token(Token = "0x4018423")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[Inspect("resetMainDir")]
		private float _randomAngle;

		// Token: 0x04018424 RID: 99364
		[Token(Token = "0x4018424")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _delayToFinish;

		// Token: 0x04018425 RID: 99365
		[Token(Token = "0x4018425")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private bool _allowAutoReuse;

		// Token: 0x04018426 RID: 99366
		[Token(Token = "0x4018426")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private int _preloadCnt;

		// Token: 0x04018427 RID: 99367
		[Token(Token = "0x4018427")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private bool _flipIfLeft;

		// Token: 0x04018428 RID: 99368
		[Token(Token = "0x4018428")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Transform[] _inactiveOnFinish;

		// Token: 0x04018429 RID: 99369
		[Token(Token = "0x4018429")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private List<Transform> _inactiveOnHit;

		// Token: 0x0401842A RID: 99370
		[Token(Token = "0x401842A")]
		[FieldOffset(Offset = "0xD8")]
		private ParticleSystem m_particleSystem;

		// Token: 0x0401842B RID: 99371
		[Token(Token = "0x401842B")]
		[FieldOffset(Offset = "0xE0")]
		private Animator[] m_animators;

		// Token: 0x0401842C RID: 99372
		[Token(Token = "0x401842C")]
		[FieldOffset(Offset = "0xE8")]
		private ParticleSystem[] m_particleSystems;

		// Token: 0x0401842D RID: 99373
		[Token(Token = "0x401842D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_resetMainDir;

		// Token: 0x0401842E RID: 99374
		[Token(Token = "0x401842E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_preloadCnt;

		// Token: 0x0401842F RID: 99375
		[Token(Token = "0x401842F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_spawnLocation;

		// Token: 0x04018430 RID: 99376
		[Token(Token = "0x4018430")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_useBodyDirection;

		// Token: 0x04018431 RID: 99377
		[Token(Token = "0x4018431")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_holdByOwner;

		// Token: 0x04018432 RID: 99378
		[Token(Token = "0x4018432")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_overwriteHeight;

		// Token: 0x04018433 RID: 99379
		[Token(Token = "0x4018433")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_heightOffset;

		// Token: 0x04018434 RID: 99380
		[Token(Token = "0x4018434")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_allowAutoReuse;

		// Token: 0x04018435 RID: 99381
		[Token(Token = "0x4018435")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_delayToRecycle;

		// Token: 0x04018436 RID: 99382
		[Token(Token = "0x4018436")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_particleSystems;

		// Token: 0x04018437 RID: 99383
		[Token(Token = "0x4018437")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_animators;

		// Token: 0x04018438 RID: 99384
		[Token(Token = "0x4018438")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04018439 RID: 99385
		[Token(Token = "0x4018439")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoPlay;

		// Token: 0x0401843A RID: 99386
		[Token(Token = "0x401843A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnBeforePlay;

		// Token: 0x0401843B RID: 99387
		[Token(Token = "0x401843B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0401843C RID: 99388
		[Token(Token = "0x401843C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ForceApplyPlaybackSpeedMultiplier;

		// Token: 0x0401843D RID: 99389
		[Token(Token = "0x401843D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnProjectileHit;

		// Token: 0x0401843E RID: 99390
		[Token(Token = "0x401843E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_UpdatePlaybackSpeed;

		// Token: 0x0401843F RID: 99391
		[Token(Token = "0x401843F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ClearPlaybackSpeedSettings;

		// Token: 0x04018440 RID: 99392
		[Token(Token = "0x4018440")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04018441 RID: 99393
		[Token(Token = "0x4018441")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
