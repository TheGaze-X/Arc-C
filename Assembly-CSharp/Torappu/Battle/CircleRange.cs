using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024C5 RID: 9413
	[Token(Token = "0x20024C5")]
	public class CircleRange : PhysicsRange
	{
		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x0600F235 RID: 62005 RVA: 0x00059328 File Offset: 0x00057528
		[Token(Token = "0x17001F86")]
		public float radius
		{
			[Token(Token = "0x600F235")]
			[Address(RVA = "0x687400", Offset = "0x686000", VA = "0x180687400")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600F236 RID: 62006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F236")]
		[Address(RVA = "0x686DC0", Offset = "0x6859C0", VA = "0x180686DC0", Slot = "17")]
		protected override Collider2D[] FetchColliders(Range.Options options)
		{
			return null;
		}

		// Token: 0x0600F237 RID: 62007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F237")]
		[Address(RVA = "0x687220", Offset = "0x685E20", VA = "0x180687220", Slot = "15")]
		protected override void UpdateExtend(FP extend, bool force)
		{
		}

		// Token: 0x0600F238 RID: 62008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F238")]
		[Address(RVA = "0x686F60", Offset = "0x685B60", VA = "0x180686F60", Slot = "18")]
		protected override void InitCollidersIfNot(Range.Options options)
		{
		}

		// Token: 0x0600F239 RID: 62009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F239")]
		[Address(RVA = "0x6873A0", Offset = "0x685FA0", VA = "0x1806873A0")]
		public CircleRange()
		{
		}

		// Token: 0x0600F23A RID: 62010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F23A")]
		[Address(RVA = "0x682AA0", Offset = "0x6816A0", VA = "0x180682AA0")]
		private Collider2D[] <>xLuaBaseProxy_FetchColliders(Range.Options P0)
		{
			return null;
		}

		// Token: 0x0600F23B RID: 62011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F23B")]
		[Address(RVA = "0x687210", Offset = "0x685E10", VA = "0x180687210")]
		private void <>xLuaBaseProxy_UpdateExtend(FP P0, bool P1)
		{
		}

		// Token: 0x0600F23C RID: 62012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F23C")]
		[Address(RVA = "0x682AF0", Offset = "0x6816F0", VA = "0x180682AF0")]
		private void <>xLuaBaseProxy_InitCollidersIfNot(Range.Options P0)
		{
		}

		// Token: 0x04010C1B RID: 68635
		[Token(Token = "0x4010C1B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _scaleble;

		// Token: 0x04010C1C RID: 68636
		[Token(Token = "0x4010C1C")]
		[FieldOffset(Offset = "0x58")]
		protected CircleCollider2D m_circleCollider;

		// Token: 0x04010C1D RID: 68637
		[Token(Token = "0x4010C1D")]
		[FieldOffset(Offset = "0x60")]
		protected float m_originRadius;

		// Token: 0x04010C1E RID: 68638
		[Token(Token = "0x4010C1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_radius;

		// Token: 0x04010C1F RID: 68639
		[Token(Token = "0x4010C1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FetchColliders;

		// Token: 0x04010C20 RID: 68640
		[Token(Token = "0x4010C20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateExtend;

		// Token: 0x04010C21 RID: 68641
		[Token(Token = "0x4010C21")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitCollidersIfNot;

		// Token: 0x04010C22 RID: 68642
		[Token(Token = "0x4010C22")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
