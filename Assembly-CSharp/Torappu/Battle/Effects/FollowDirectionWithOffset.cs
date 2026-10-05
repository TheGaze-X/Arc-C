using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200322E RID: 12846
	[Token(Token = "0x200322E")]
	public class FollowDirectionWithOffset : Effect.Behaviour
	{
		// Token: 0x060145F7 RID: 83447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145F7")]
		[Address(RVA = "0xC9D070", Offset = "0xC9BC70", VA = "0x180C9D070", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060145F8 RID: 83448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145F8")]
		[Address(RVA = "0xC9D350", Offset = "0xC9BF50", VA = "0x180C9D350")]
		private void Update()
		{
		}

		// Token: 0x060145F9 RID: 83449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145F9")]
		[Address(RVA = "0xC9CF50", Offset = "0xC9BB50", VA = "0x180C9CF50")]
		private void HoldDirection()
		{
		}

		// Token: 0x060145FA RID: 83450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145FA")]
		[Address(RVA = "0xC9D1D0", Offset = "0xC9BDD0", VA = "0x180C9D1D0")]
		private void UpdateDirection()
		{
		}

		// Token: 0x060145FB RID: 83451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145FB")]
		[Address(RVA = "0xC9D500", Offset = "0xC9C100", VA = "0x180C9D500")]
		public FollowDirectionWithOffset()
		{
		}

		// Token: 0x060145FC RID: 83452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145FC")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x040180A6 RID: 98470
		[Token(Token = "0x40180A6")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 lastDirection;

		// Token: 0x040180A7 RID: 98471
		[Token(Token = "0x40180A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040180A8 RID: 98472
		[Token(Token = "0x40180A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040180A9 RID: 98473
		[Token(Token = "0x40180A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HoldDirection;

		// Token: 0x040180AA RID: 98474
		[Token(Token = "0x40180AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateDirection;

		// Token: 0x040180AB RID: 98475
		[Token(Token = "0x40180AB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
