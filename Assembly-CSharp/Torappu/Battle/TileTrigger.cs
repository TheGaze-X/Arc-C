using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002576 RID: 9590
	[Token(Token = "0x2002576")]
	[RequireComponent(typeof(TileSelector))]
	public class TileTrigger : TargetTrigger
	{
		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x0600F782 RID: 63362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700207F")]
		public override Entity target
		{
			[Token(Token = "0x600F782")]
			[Address(RVA = "0x716B60", Offset = "0x715760", VA = "0x180716B60", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x0600F783 RID: 63363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002080")]
		protected Entity owner
		{
			[Token(Token = "0x600F783")]
			[Address(RVA = "0x716AF0", Offset = "0x7156F0", VA = "0x180716AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F784 RID: 63364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F784")]
		[Address(RVA = "0x7167A0", Offset = "0x7153A0", VA = "0x1807167A0", Slot = "12")]
		public override void Reset(Entity owner, Ability ability)
		{
		}

		// Token: 0x0600F785 RID: 63365 RVA: 0x0005C7A8 File Offset: 0x0005A9A8
		[Token(Token = "0x600F785")]
		[Address(RVA = "0x7168D0", Offset = "0x7154D0", VA = "0x1807168D0", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F786 RID: 63366 RVA: 0x0005C7C0 File Offset: 0x0005A9C0
		[Token(Token = "0x600F786")]
		[Address(RVA = "0x716690", Offset = "0x715290", VA = "0x180716690", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F787 RID: 63367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F787")]
		[Address(RVA = "0x716610", Offset = "0x715210", VA = "0x180716610")]
		private void Awake()
		{
		}

		// Token: 0x0600F788 RID: 63368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F788")]
		[Address(RVA = "0x716730", Offset = "0x715330", VA = "0x180716730")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600F789 RID: 63369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F789")]
		[Address(RVA = "0x716A00", Offset = "0x715600", VA = "0x180716A00")]
		public TileTrigger()
		{
		}

		// Token: 0x0600F78A RID: 63370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F78A")]
		[Address(RVA = "0x6F3400", Offset = "0x6F2000", VA = "0x1806F3400")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1)
		{
		}

		// Token: 0x040112FB RID: 70395
		[Token(Token = "0x40112FB")]
		private const int SEARCH_TARGET_TICK = 5;

		// Token: 0x040112FC RID: 70396
		[Token(Token = "0x40112FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _minTileNum;

		// Token: 0x040112FD RID: 70397
		[Token(Token = "0x40112FD")]
		[FieldOffset(Offset = "0x28")]
		private TileSelector m_selector;

		// Token: 0x040112FE RID: 70398
		[Token(Token = "0x40112FE")]
		[FieldOffset(Offset = "0x30")]
		private CompoundPeriodicTicker m_findTargetTicker;

		// Token: 0x040112FF RID: 70399
		[Token(Token = "0x40112FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x04011300 RID: 70400
		[Token(Token = "0x4011300")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x04011301 RID: 70401
		[Token(Token = "0x4011301")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011302 RID: 70402
		[Token(Token = "0x4011302")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x04011303 RID: 70403
		[Token(Token = "0x4011303")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04011304 RID: 70404
		[Token(Token = "0x4011304")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04011305 RID: 70405
		[Token(Token = "0x4011305")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x04011306 RID: 70406
		[Token(Token = "0x4011306")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
