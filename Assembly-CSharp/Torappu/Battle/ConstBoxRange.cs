using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024C7 RID: 9415
	[Token(Token = "0x20024C7")]
	public class ConstBoxRange : AutoLoadBoxRange
	{
		// Token: 0x0600F24C RID: 62028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F24C")]
		[Address(RVA = "0x688F40", Offset = "0x687B40", VA = "0x180688F40", Slot = "17")]
		protected override Collider2D[] FetchColliders(Range.Options options)
		{
			return null;
		}

		// Token: 0x0600F24D RID: 62029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F24D")]
		[Address(RVA = "0x688FD0", Offset = "0x687BD0", VA = "0x180688FD0", Slot = "18")]
		protected override void InitCollidersIfNot(Range.Options options)
		{
		}

		// Token: 0x0600F24E RID: 62030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F24E")]
		[Address(RVA = "0x689070", Offset = "0x687C70", VA = "0x180689070")]
		public ConstBoxRange()
		{
		}

		// Token: 0x0600F24F RID: 62031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F24F")]
		[Address(RVA = "0x6819E0", Offset = "0x6805E0", VA = "0x1806819E0")]
		private Collider2D[] <>xLuaBaseProxy_FetchColliders(Range.Options P0)
		{
			return null;
		}

		// Token: 0x0600F250 RID: 62032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F250")]
		[Address(RVA = "0x681A20", Offset = "0x680620", VA = "0x180681A20")]
		private void <>xLuaBaseProxy_InitCollidersIfNot(Range.Options P0)
		{
		}

		// Token: 0x04010C2E RID: 68654
		[Token(Token = "0x4010C2E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _rangeId;

		// Token: 0x04010C2F RID: 68655
		[Token(Token = "0x4010C2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FetchColliders;

		// Token: 0x04010C30 RID: 68656
		[Token(Token = "0x4010C30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitCollidersIfNot;

		// Token: 0x04010C31 RID: 68657
		[Token(Token = "0x4010C31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
