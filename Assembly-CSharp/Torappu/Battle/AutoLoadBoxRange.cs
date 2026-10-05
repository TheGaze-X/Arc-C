using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024C2 RID: 9410
	[Token(Token = "0x20024C2")]
	public class AutoLoadBoxRange : PhysicsRange
	{
		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x0600F220 RID: 61984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F85")]
		public string loadedRangeId
		{
			[Token(Token = "0x600F220")]
			[Address(RVA = "0x6846E0", Offset = "0x6832E0", VA = "0x1806846E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F221 RID: 61985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F221")]
		[Address(RVA = "0x684310", Offset = "0x682F10", VA = "0x180684310", Slot = "17")]
		protected override Collider2D[] FetchColliders(Range.Options options)
		{
			return null;
		}

		// Token: 0x0600F222 RID: 61986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F222")]
		[Address(RVA = "0x6845C0", Offset = "0x6831C0", VA = "0x1806845C0", Slot = "18")]
		protected override void InitCollidersIfNot(Range.Options options)
		{
		}

		// Token: 0x0600F223 RID: 61987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F223")]
		[Address(RVA = "0x683F50", Offset = "0x682B50", VA = "0x180683F50")]
		protected Collider2D[] FetchCollidersByRangeId(string rangeId, Range.Options options)
		{
			return null;
		}

		// Token: 0x0600F224 RID: 61988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F224")]
		[Address(RVA = "0x6843D0", Offset = "0x682FD0", VA = "0x1806843D0")]
		protected void InitColliderIfNotByRangeId(string rangeId, Range.Options options)
		{
		}

		// Token: 0x0600F225 RID: 61989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F225")]
		[Address(RVA = "0x684680", Offset = "0x683280", VA = "0x180684680")]
		public AutoLoadBoxRange()
		{
		}

		// Token: 0x0600F226 RID: 61990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F226")]
		[Address(RVA = "0x682AA0", Offset = "0x6816A0", VA = "0x180682AA0")]
		private Collider2D[] <>xLuaBaseProxy_FetchColliders(Range.Options P0)
		{
			return null;
		}

		// Token: 0x0600F227 RID: 61991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F227")]
		[Address(RVA = "0x682AF0", Offset = "0x6816F0", VA = "0x180682AF0")]
		private void <>xLuaBaseProxy_InitCollidersIfNot(Range.Options P0)
		{
		}

		// Token: 0x04010C0B RID: 68619
		[Token(Token = "0x4010C0B")]
		[FieldOffset(Offset = "0x50")]
		[Inspect]
		[ReadOnly]
		protected string m_loadedRangeId;

		// Token: 0x04010C0C RID: 68620
		[Token(Token = "0x4010C0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loadedRangeId;

		// Token: 0x04010C0D RID: 68621
		[Token(Token = "0x4010C0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FetchColliders;

		// Token: 0x04010C0E RID: 68622
		[Token(Token = "0x4010C0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitCollidersIfNot;

		// Token: 0x04010C0F RID: 68623
		[Token(Token = "0x4010C0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FetchCollidersByRangeId;

		// Token: 0x04010C10 RID: 68624
		[Token(Token = "0x4010C10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitColliderIfNotByRangeId;

		// Token: 0x04010C11 RID: 68625
		[Token(Token = "0x4010C11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
