using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C37 RID: 11319
	[Token(Token = "0x2002C37")]
	public class InputTargetProjectileEmitter : AbstractProjectileEmitter
	{
		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x060131C1 RID: 78273 RVA: 0x000749B8 File Offset: 0x00072BB8
		[Token(Token = "0x170029FE")]
		private bool projectileValid
		{
			[Token(Token = "0x60131C1")]
			[Address(RVA = "0xB1C3D0", Offset = "0xB1AFD0", VA = "0x180B1C3D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x060131C2 RID: 78274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170029FF")]
		private Tile startTile
		{
			[Token(Token = "0x60131C2")]
			[Address(RVA = "0xB1C440", Offset = "0xB1B040", VA = "0x180B1C440")]
			get
			{
				return null;
			}
		}

		// Token: 0x060131C3 RID: 78275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131C3")]
		[Address(RVA = "0xB1B900", Offset = "0xB1A500", VA = "0x180B1B900", Slot = "17")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x060131C4 RID: 78276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131C4")]
		[Address(RVA = "0xB1B9F0", Offset = "0xB1A5F0", VA = "0x180B1B9F0", Slot = "5")]
		public override void Init(AbilityStandard abilityStandard)
		{
		}

		// Token: 0x060131C5 RID: 78277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131C5")]
		[Address(RVA = "0xB1BFE0", Offset = "0xB1ABE0", VA = "0x180B1BFE0", Slot = "13")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060131C6 RID: 78278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131C6")]
		[Address(RVA = "0xB1BAA0", Offset = "0xB1A6A0", VA = "0x180B1BAA0", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x060131C7 RID: 78279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131C7")]
		[Address(RVA = "0xB1BCE0", Offset = "0xB1A8E0", VA = "0x180B1BCE0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x060131C8 RID: 78280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131C8")]
		[Address(RVA = "0xB1C270", Offset = "0xB1AE70", VA = "0x180B1C270")]
		private void _OnDetached()
		{
		}

		// Token: 0x060131C9 RID: 78281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60131C9")]
		[Address(RVA = "0xB1C170", Offset = "0xB1AD70", VA = "0x180B1C170")]
		private IEnumerator _DoCast(Tile start, List<FixedPosition> fixedPositions)
		{
			return null;
		}

		// Token: 0x060131CA RID: 78282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131CA")]
		[Address(RVA = "0xB1C0C0", Offset = "0xB1ACC0", VA = "0x180B1C0C0")]
		private void _ClearCoroutine()
		{
		}

		// Token: 0x060131CB RID: 78283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131CB")]
		[Address(RVA = "0xB1C2D0", Offset = "0xB1AED0", VA = "0x180B1C2D0")]
		public InputTargetProjectileEmitter()
		{
		}

		// Token: 0x060131CC RID: 78284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131CC")]
		[Address(RVA = "0xAE3FD0", Offset = "0xAE2BD0", VA = "0x180AE3FD0")]
		private void <>xLuaBaseProxy_Init(AbilityStandard P0)
		{
		}

		// Token: 0x060131CD RID: 78285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131CD")]
		[Address(RVA = "0xADA600", Offset = "0xAD9200", VA = "0x180ADA600")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x060131CE RID: 78286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131CE")]
		[Address(RVA = "0xAC2A30", Offset = "0xAC1630", VA = "0x180AC2A30")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x060131CF RID: 78287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131CF")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015952 RID: 88402
		[Token(Token = "0x4015952")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _projectileKey;

		// Token: 0x04015953 RID: 88403
		[Token(Token = "0x4015953")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AbilityStandard.Event _emitEvent;

		// Token: 0x04015954 RID: 88404
		[Token(Token = "0x4015954")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _triggerDelta;

		// Token: 0x04015955 RID: 88405
		[Token(Token = "0x4015955")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<FixedPosition> m_fixedPositions;

		// Token: 0x04015956 RID: 88406
		[Token(Token = "0x4015956")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_projectileValid;

		// Token: 0x04015957 RID: 88407
		[Token(Token = "0x4015957")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_startTile;

		// Token: 0x04015958 RID: 88408
		[Token(Token = "0x4015958")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04015959 RID: 88409
		[Token(Token = "0x4015959")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401595A RID: 88410
		[Token(Token = "0x401595A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401595B RID: 88411
		[Token(Token = "0x401595B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x0401595C RID: 88412
		[Token(Token = "0x401595C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401595D RID: 88413
		[Token(Token = "0x401595D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnDetached;

		// Token: 0x0401595E RID: 88414
		[Token(Token = "0x401595E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoCast;

		// Token: 0x0401595F RID: 88415
		[Token(Token = "0x401595F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearCoroutine;

		// Token: 0x04015960 RID: 88416
		[Token(Token = "0x4015960")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
