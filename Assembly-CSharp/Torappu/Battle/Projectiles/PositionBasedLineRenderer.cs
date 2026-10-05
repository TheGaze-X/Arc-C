using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029A2 RID: 10658
	[Token(Token = "0x20029A2")]
	public class PositionBasedLineRenderer : Projectile.Behaviour, IEffectSource
	{
		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x06011A58 RID: 72280 RVA: 0x0006C480 File Offset: 0x0006A680
		[Token(Token = "0x170026EB")]
		public bool useMuzzlePointOffset
		{
			[Token(Token = "0x6011A58")]
			[Address(RVA = "0x97C4C0", Offset = "0x97B0C0", VA = "0x18097C4C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x06011A59 RID: 72281 RVA: 0x0006C498 File Offset: 0x0006A698
		[Token(Token = "0x170026EC")]
		public bool stopToNearestHitTarget
		{
			[Token(Token = "0x6011A59")]
			[Address(RVA = "0x97C460", Offset = "0x97B060", VA = "0x18097C460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011A5A RID: 72282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A5A")]
		[Address(RVA = "0x97B280", Offset = "0x979E80", VA = "0x18097B280", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011A5B RID: 72283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A5B")]
		[Address(RVA = "0x97BAD0", Offset = "0x97A6D0", VA = "0x18097BAD0", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x06011A5C RID: 72284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A5C")]
		[Address(RVA = "0x97BD30", Offset = "0x97A930", VA = "0x18097BD30", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x06011A5D RID: 72285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A5D")]
		[Address(RVA = "0x97BDA0", Offset = "0x97A9A0", VA = "0x18097BDA0", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011A5E RID: 72286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A5E")]
		[Address(RVA = "0x97BE90", Offset = "0x97AA90", VA = "0x18097BE90", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011A5F RID: 72287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A5F")]
		[Address(RVA = "0x97BF10", Offset = "0x97AB10", VA = "0x18097BF10")]
		private void _ApplyLineRenderPositions()
		{
		}

		// Token: 0x06011A60 RID: 72288 RVA: 0x0006C4B0 File Offset: 0x0006A6B0
		[Token(Token = "0x6011A60")]
		[Address(RVA = "0x97C270", Offset = "0x97AE70", VA = "0x18097C270")]
		private bool _CheckRallyPointInactive(RallyPoint rally)
		{
			return default(bool);
		}

		// Token: 0x06011A61 RID: 72289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A61")]
		[Address(RVA = "0x97B1E0", Offset = "0x979DE0", VA = "0x18097B1E0", Slot = "15")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06011A62 RID: 72290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A62")]
		[Address(RVA = "0x97C330", Offset = "0x97AF30", VA = "0x18097C330")]
		public PositionBasedLineRenderer()
		{
		}

		// Token: 0x06011A63 RID: 72291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A63")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011A64 RID: 72292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A64")]
		[Address(RVA = "0x966560", Offset = "0x965160", VA = "0x180966560")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x06011A65 RID: 72293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A65")]
		[Address(RVA = "0x970BF0", Offset = "0x96F7F0", VA = "0x180970BF0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x06011A66 RID: 72294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A66")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x06011A67 RID: 72295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A67")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013C25 RID: 80933
		[Token(Token = "0x4013C25")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _mainEffect;

		// Token: 0x04013C26 RID: 80934
		[Token(Token = "0x4013C26")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 _startWorldOffset;

		// Token: 0x04013C27 RID: 80935
		[Token(Token = "0x4013C27")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector3 _endWorldOffset;

		// Token: 0x04013C28 RID: 80936
		[Token(Token = "0x4013C28")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 _endWorldOffsetWhenNotHit;

		// Token: 0x04013C29 RID: 80937
		[Token(Token = "0x4013C29")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool _stopToNearestHitTarget;

		// Token: 0x04013C2A RID: 80938
		[Token(Token = "0x4013C2A")]
		[FieldOffset(Offset = "0x55")]
		[SerializeField]
		[Inspect("stopToNearestHitTarget")]
		private bool _excludeInactiveRallyPoint;

		// Token: 0x04013C2B RID: 80939
		[Token(Token = "0x4013C2B")]
		[FieldOffset(Offset = "0x56")]
		[SerializeField]
		private bool _useMuzzlePointOffset;

		// Token: 0x04013C2C RID: 80940
		[Token(Token = "0x4013C2C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Inspect("useMuzzlePointOffset")]
		private Vector3 _extraOffsetLeft;

		// Token: 0x04013C2D RID: 80941
		[Token(Token = "0x4013C2D")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[Inspect("useMuzzlePointOffset")]
		private Vector3 _extraOffsetRight;

		// Token: 0x04013C2E RID: 80942
		[Token(Token = "0x4013C2E")]
		[FieldOffset(Offset = "0x70")]
		private ObjectPtr<Entity> m_nearestHitTarget;

		// Token: 0x04013C2F RID: 80943
		[Token(Token = "0x4013C2F")]
		[FieldOffset(Offset = "0x80")]
		private ObjectPtr<Effect> m_mainEffect;

		// Token: 0x04013C30 RID: 80944
		[Token(Token = "0x4013C30")]
		[FieldOffset(Offset = "0x90")]
		private LineRenderer[] m_lineRenderers;

		// Token: 0x04013C31 RID: 80945
		[Token(Token = "0x4013C31")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 m_startMountPoint;

		// Token: 0x04013C32 RID: 80946
		[Token(Token = "0x4013C32")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 m_endMountPoint;

		// Token: 0x04013C33 RID: 80947
		[Token(Token = "0x4013C33")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3[] m_positions;

		// Token: 0x04013C34 RID: 80948
		[Token(Token = "0x4013C34")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isProjectileReached;

		// Token: 0x04013C35 RID: 80949
		[Token(Token = "0x4013C35")]
		[FieldOffset(Offset = "0xBC")]
		private Vector3 m_startWorldOffset;

		// Token: 0x04013C36 RID: 80950
		[Token(Token = "0x4013C36")]
		[FieldOffset(Offset = "0xC8")]
		private Vector3 m_endWorldOffset;

		// Token: 0x04013C37 RID: 80951
		[Token(Token = "0x4013C37")]
		[FieldOffset(Offset = "0xD4")]
		private Vector3 m_endWorldOffsetWhenNotHit;

		// Token: 0x04013C38 RID: 80952
		[Token(Token = "0x4013C38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useMuzzlePointOffset;

		// Token: 0x04013C39 RID: 80953
		[Token(Token = "0x4013C39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stopToNearestHitTarget;

		// Token: 0x04013C3A RID: 80954
		[Token(Token = "0x4013C3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013C3B RID: 80955
		[Token(Token = "0x4013C3B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04013C3C RID: 80956
		[Token(Token = "0x4013C3C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013C3D RID: 80957
		[Token(Token = "0x4013C3D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013C3E RID: 80958
		[Token(Token = "0x4013C3E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013C3F RID: 80959
		[Token(Token = "0x4013C3F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ApplyLineRenderPositions;

		// Token: 0x04013C40 RID: 80960
		[Token(Token = "0x4013C40")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckRallyPointInactive;

		// Token: 0x04013C41 RID: 80961
		[Token(Token = "0x4013C41")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013C42 RID: 80962
		[Token(Token = "0x4013C42")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
