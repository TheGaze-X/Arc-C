using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003233 RID: 12851
	[Token(Token = "0x2003233")]
	public class FollowTileHeight : Effect.Behaviour
	{
		// Token: 0x0601460F RID: 83471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601460F")]
		[Address(RVA = "0xC9F350", Offset = "0xC9DF50", VA = "0x180C9F350", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014610 RID: 83472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014610")]
		[Address(RVA = "0xC9F3C0", Offset = "0xC9DFC0", VA = "0x180C9F3C0")]
		private void Update()
		{
		}

		// Token: 0x06014611 RID: 83473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014611")]
		[Address(RVA = "0xC9F420", Offset = "0xC9E020", VA = "0x180C9F420")]
		private void _UpdateHeight(bool force = false)
		{
		}

		// Token: 0x06014612 RID: 83474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014612")]
		[Address(RVA = "0xC9F6F0", Offset = "0xC9E2F0", VA = "0x180C9F6F0")]
		public FollowTileHeight()
		{
		}

		// Token: 0x06014613 RID: 83475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014613")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x040180C8 RID: 98504
		[Token(Token = "0x40180C8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _followTileHeightSpeed;

		// Token: 0x040180C9 RID: 98505
		[Token(Token = "0x40180C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040180CA RID: 98506
		[Token(Token = "0x40180CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040180CB RID: 98507
		[Token(Token = "0x40180CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateHeight;

		// Token: 0x040180CC RID: 98508
		[Token(Token = "0x40180CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
