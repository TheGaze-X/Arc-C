using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003284 RID: 12932
	[Token(Token = "0x2003284")]
	public class SimpleEffect : Effect
	{
		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x06014867 RID: 84071 RVA: 0x00087438 File Offset: 0x00085638
		[Token(Token = "0x17003091")]
		protected internal override float delayToRecycle
		{
			[Token(Token = "0x6014867")]
			[Address(RVA = "0xCB6000", Offset = "0xCB4C00", VA = "0x180CB6000", Slot = "16")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x06014868 RID: 84072 RVA: 0x00087450 File Offset: 0x00085650
		[Token(Token = "0x17003092")]
		public override bool allowAutoReuse
		{
			[Token(Token = "0x6014868")]
			[Address(RVA = "0xCB5FA0", Offset = "0xCB4BA0", VA = "0x180CB5FA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x06014869 RID: 84073 RVA: 0x00087468 File Offset: 0x00085668
		[Token(Token = "0x17003093")]
		public override int preloadCnt
		{
			[Token(Token = "0x6014869")]
			[Address(RVA = "0xCB6180", Offset = "0xCB4D80", VA = "0x180CB6180", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x0601486A RID: 84074 RVA: 0x00087480 File Offset: 0x00085680
		[Token(Token = "0x17003094")]
		protected override Effect.SpawnLocation spawnLocation
		{
			[Token(Token = "0x601486A")]
			[Address(RVA = "0xCB61E0", Offset = "0xCB4DE0", VA = "0x180CB61E0", Slot = "10")]
			get
			{
				return Effect.SpawnLocation.NONE;
			}
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x0601486B RID: 84075 RVA: 0x00087498 File Offset: 0x00085698
		[Token(Token = "0x17003095")]
		protected override bool useBodyDirection
		{
			[Token(Token = "0x601486B")]
			[Address(RVA = "0xCB6240", Offset = "0xCB4E40", VA = "0x180CB6240", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x0601486C RID: 84076 RVA: 0x000874B0 File Offset: 0x000856B0
		[Token(Token = "0x17003096")]
		protected override bool holdByOwner
		{
			[Token(Token = "0x601486C")]
			[Address(RVA = "0xCB60C0", Offset = "0xCB4CC0", VA = "0x180CB60C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x0601486D RID: 84077 RVA: 0x000874C8 File Offset: 0x000856C8
		[Token(Token = "0x17003097")]
		protected override bool overwriteHeight
		{
			[Token(Token = "0x601486D")]
			[Address(RVA = "0xCB6120", Offset = "0xCB4D20", VA = "0x180CB6120", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x0601486E RID: 84078 RVA: 0x000874E0 File Offset: 0x000856E0
		[Token(Token = "0x17003098")]
		protected override float heightOffset
		{
			[Token(Token = "0x601486E")]
			[Address(RVA = "0xCB6060", Offset = "0xCB4C60", VA = "0x180CB6060", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0601486F RID: 84079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601486F")]
		[Address(RVA = "0xCB5E70", Offset = "0xCB4A70", VA = "0x180CB5E70")]
		private IEnumerator _CheckIfAlive()
		{
			return null;
		}

		// Token: 0x06014870 RID: 84080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014870")]
		[Address(RVA = "0xCB5D70", Offset = "0xCB4970", VA = "0x180CB5D70", Slot = "25")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06014871 RID: 84081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014871")]
		[Address(RVA = "0xCB5F20", Offset = "0xCB4B20", VA = "0x180CB5F20")]
		public SimpleEffect()
		{
		}

		// Token: 0x06014872 RID: 84082 RVA: 0x000874F8 File Offset: 0x000856F8
		[Token(Token = "0x6014872")]
		[Address(RVA = "0xCB0810", Offset = "0xCAF410", VA = "0x180CB0810")]
		private float <>xLuaBaseProxy_get_delayToRecycle()
		{
			return 0f;
		}

		// Token: 0x06014873 RID: 84083 RVA: 0x00087510 File Offset: 0x00085710
		[Token(Token = "0x6014873")]
		[Address(RVA = "0xCB0830", Offset = "0xCAF430", VA = "0x180CB0830")]
		private bool <>xLuaBaseProxy_get_overwriteHeight()
		{
			return default(bool);
		}

		// Token: 0x06014874 RID: 84084 RVA: 0x00087528 File Offset: 0x00085728
		[Token(Token = "0x6014874")]
		[Address(RVA = "0xCB0820", Offset = "0xCAF420", VA = "0x180CB0820")]
		private float <>xLuaBaseProxy_get_heightOffset()
		{
			return 0f;
		}

		// Token: 0x06014875 RID: 84085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014875")]
		[Address(RVA = "0xCB2FF0", Offset = "0xCB1BF0", VA = "0x180CB2FF0")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x04018442 RID: 99394
		[Token(Token = "0x4018442")]
		private const float CHECK_IF_ALIVE_DELTA = 0.5f;

		// Token: 0x04018443 RID: 99395
		[Token(Token = "0x4018443")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _allowAutoReuse;

		// Token: 0x04018444 RID: 99396
		[Token(Token = "0x4018444")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private int _preloadCnt;

		// Token: 0x04018445 RID: 99397
		[Token(Token = "0x4018445")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _lifeTime;

		// Token: 0x04018446 RID: 99398
		[Token(Token = "0x4018446")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private Effect.SpawnLocation _spawnLocation;

		// Token: 0x04018447 RID: 99399
		[Token(Token = "0x4018447")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _useBodyRotation;

		// Token: 0x04018448 RID: 99400
		[Token(Token = "0x4018448")]
		[FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool _holdByOwner;

		// Token: 0x04018449 RID: 99401
		[Token(Token = "0x4018449")]
		[FieldOffset(Offset = "0xBA")]
		[SerializeField]
		private bool _overwriteHeight;

		// Token: 0x0401844A RID: 99402
		[Token(Token = "0x401844A")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x0401844B RID: 99403
		[Token(Token = "0x401844B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _delayToFinish;

		// Token: 0x0401844C RID: 99404
		[Token(Token = "0x401844C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_delayToRecycle;

		// Token: 0x0401844D RID: 99405
		[Token(Token = "0x401844D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_allowAutoReuse;

		// Token: 0x0401844E RID: 99406
		[Token(Token = "0x401844E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_preloadCnt;

		// Token: 0x0401844F RID: 99407
		[Token(Token = "0x401844F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_spawnLocation;

		// Token: 0x04018450 RID: 99408
		[Token(Token = "0x4018450")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_useBodyDirection;

		// Token: 0x04018451 RID: 99409
		[Token(Token = "0x4018451")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_holdByOwner;

		// Token: 0x04018452 RID: 99410
		[Token(Token = "0x4018452")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_overwriteHeight;

		// Token: 0x04018453 RID: 99411
		[Token(Token = "0x4018453")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_heightOffset;

		// Token: 0x04018454 RID: 99412
		[Token(Token = "0x4018454")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckIfAlive;

		// Token: 0x04018455 RID: 99413
		[Token(Token = "0x4018455")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04018456 RID: 99414
		[Token(Token = "0x4018456")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
