using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024D0 RID: 9424
	[Token(Token = "0x20024D0")]
	public class InfiniteLineRange : PhysicsRange
	{
		// Token: 0x0600F2AA RID: 62122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2AA")]
		[Address(RVA = "0x6A82D0", Offset = "0x6A6ED0", VA = "0x1806A82D0", Slot = "17")]
		protected override Collider2D[] FetchColliders(Range.Options options)
		{
			return null;
		}

		// Token: 0x0600F2AB RID: 62123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2AB")]
		[Address(RVA = "0x6A8630", Offset = "0x6A7230", VA = "0x1806A8630")]
		public InfiniteLineRange()
		{
		}

		// Token: 0x0600F2AC RID: 62124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2AC")]
		[Address(RVA = "0x6A8590", Offset = "0x6A7190", VA = "0x1806A8590")]
		private Collider2D[] <>xLuaBaseProxy_FetchColliders(Range.Options P0)
		{
			return null;
		}

		// Token: 0x04010C9A RID: 68762
		[Token(Token = "0x4010C9A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _isHorizontalInfinite;

		// Token: 0x04010C9B RID: 68763
		[Token(Token = "0x4010C9B")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _horizonOffsetFront;

		// Token: 0x04010C9C RID: 68764
		[Token(Token = "0x4010C9C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _horizonSize;

		// Token: 0x04010C9D RID: 68765
		[Token(Token = "0x4010C9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FetchColliders;

		// Token: 0x04010C9E RID: 68766
		[Token(Token = "0x4010C9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
