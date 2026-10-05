using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002999 RID: 10649
	[Token(Token = "0x2002999")]
	public class HitBehaviour : Projectile.Behaviour
	{
		// Token: 0x170026E8 RID: 9960
		// (get) Token: 0x06011A02 RID: 72194 RVA: 0x0006C438 File Offset: 0x0006A638
		[Token(Token = "0x170026E8")]
		protected int currentFoundTargetNum
		{
			[Token(Token = "0x6011A02")]
			[Address(RVA = "0x9764E0", Offset = "0x9750E0", VA = "0x1809764E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06011A03 RID: 72195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A03")]
		[Address(RVA = "0x974D00", Offset = "0x973900", VA = "0x180974D00", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011A04 RID: 72196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A04")]
		[Address(RVA = "0x975210", Offset = "0x973E10", VA = "0x180975210", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x06011A05 RID: 72197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A05")]
		[Address(RVA = "0x975660", Offset = "0x974260", VA = "0x180975660", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011A06 RID: 72198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A06")]
		[Address(RVA = "0x974B80", Offset = "0x973780", VA = "0x180974B80", Slot = "15")]
		protected virtual void DealHitTarget(Entity target, bool force)
		{
		}

		// Token: 0x06011A07 RID: 72199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A07")]
		[Address(RVA = "0x975FE0", Offset = "0x974BE0", VA = "0x180975FE0")]
		private void _DoTargetEnter(IPtrObject obj)
		{
		}

		// Token: 0x06011A08 RID: 72200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A08")]
		[Address(RVA = "0x976240", Offset = "0x974E40", VA = "0x180976240")]
		private void _DoTargetExit(IPtrObject obj)
		{
		}

		// Token: 0x06011A09 RID: 72201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A09")]
		[Address(RVA = "0x975AE0", Offset = "0x9746E0", VA = "0x180975AE0")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		// Token: 0x06011A0A RID: 72202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A0A")]
		[Address(RVA = "0x975DC0", Offset = "0x9749C0", VA = "0x180975DC0")]
		private void OnTriggerExit2D(Collider2D collision)
		{
		}

		// Token: 0x06011A0B RID: 72203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A0B")]
		[Address(RVA = "0x974AC0", Offset = "0x9736C0", VA = "0x180974AC0")]
		public static void ClearStaticMethods()
		{
		}

		// Token: 0x06011A0C RID: 72204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A0C")]
		[Address(RVA = "0x976450", Offset = "0x975050", VA = "0x180976450")]
		public HitBehaviour()
		{
		}

		// Token: 0x06011A0E RID: 72206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A0E")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011A0F RID: 72207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A0F")]
		[Address(RVA = "0x970BF0", Offset = "0x96F7F0", VA = "0x180970BF0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x06011A10 RID: 72208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A10")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013BAA RID: 80810
		[Token(Token = "0x4013BAA")]
		[FieldOffset(Offset = "0x0")]
		private static List<Entity> s_sharedList;

		// Token: 0x04013BAB RID: 80811
		[Token(Token = "0x4013BAB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TargetOptions _targetOptions;

		// Token: 0x04013BAC RID: 80812
		[Token(Token = "0x4013BAC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _goThroughWall;

		// Token: 0x04013BAD RID: 80813
		[Token(Token = "0x4013BAD")]
		[FieldOffset(Offset = "0x89")]
		[SerializeField]
		protected bool _onlyCheckHitWhenReachTarget;

		// Token: 0x04013BAE RID: 80814
		[Token(Token = "0x4013BAE")]
		[FieldOffset(Offset = "0x8A")]
		[SerializeField]
		protected bool _onlyCheckHitWhenStop;

		// Token: 0x04013BAF RID: 80815
		[Token(Token = "0x4013BAF")]
		[FieldOffset(Offset = "0x8B")]
		[SerializeField]
		protected bool _canFlyThroughTheDeathArea;

		// Token: 0x04013BB0 RID: 80816
		[Token(Token = "0x4013BB0")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private bool _exceptTraceTarget;

		// Token: 0x04013BB1 RID: 80817
		[Token(Token = "0x4013BB1")]
		[FieldOffset(Offset = "0x8D")]
		[SerializeField]
		private bool _overridePurposeMaskWithTargetOptions;

		// Token: 0x04013BB2 RID: 80818
		[Token(Token = "0x4013BB2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Tooltip("We use |Range| only to initialize the colliders.")]
		protected Range _rangeToLoad;

		// Token: 0x04013BB3 RID: 80819
		[Token(Token = "0x4013BB3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _ignoreCamouflage;

		// Token: 0x04013BB4 RID: 80820
		[Token(Token = "0x4013BB4")]
		[FieldOffset(Offset = "0x99")]
		[SerializeField]
		private bool _ignoreRangeScale;

		// Token: 0x04013BB5 RID: 80821
		[Token(Token = "0x4013BB5")]
		[FieldOffset(Offset = "0x9A")]
		[SerializeField]
		private bool _exceptSource;

		// Token: 0x04013BB6 RID: 80822
		[Token(Token = "0x4013BB6")]
		[FieldOffset(Offset = "0x9B")]
		[SerializeField]
		private bool _mergeTraceTargetMotion;

		// Token: 0x04013BB7 RID: 80823
		[Token(Token = "0x4013BB7")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		protected bool _markReachedOnlyWhenTargetEnter;

		// Token: 0x04013BB8 RID: 80824
		[Token(Token = "0x4013BB8")]
		[FieldOffset(Offset = "0x9D")]
		private bool m_goThroughWall;

		// Token: 0x04013BB9 RID: 80825
		[Token(Token = "0x4013BB9")]
		[FieldOffset(Offset = "0xA0")]
		protected int m_layerMask;

		// Token: 0x04013BBA RID: 80826
		[Token(Token = "0x4013BBA")]
		[FieldOffset(Offset = "0xA4")]
		private MotionMask m_originTargetMotion;

		// Token: 0x04013BBB RID: 80827
		[Token(Token = "0x4013BBB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentFoundTargetNum;

		// Token: 0x04013BBC RID: 80828
		[Token(Token = "0x4013BBC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013BBD RID: 80829
		[Token(Token = "0x4013BBD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013BBE RID: 80830
		[Token(Token = "0x4013BBE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013BBF RID: 80831
		[Token(Token = "0x4013BBF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DealHitTarget;

		// Token: 0x04013BC0 RID: 80832
		[Token(Token = "0x4013BC0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoTargetEnter;

		// Token: 0x04013BC1 RID: 80833
		[Token(Token = "0x4013BC1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DoTargetExit;

		// Token: 0x04013BC2 RID: 80834
		[Token(Token = "0x4013BC2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTriggerEnter2D;

		// Token: 0x04013BC3 RID: 80835
		[Token(Token = "0x4013BC3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTriggerExit2D;

		// Token: 0x04013BC4 RID: 80836
		[Token(Token = "0x4013BC4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ClearStaticMethods;

		// Token: 0x04013BC5 RID: 80837
		[Token(Token = "0x4013BC5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
