using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200322C RID: 12844
	[Token(Token = "0x200322C")]
	public class FollowCamera : Effect.Behaviour
	{
		// Token: 0x060145E8 RID: 83432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145E8")]
		[Address(RVA = "0xC9CC20", Offset = "0xC9B820", VA = "0x180C9CC20", Slot = "4")]
		public override void Init(Effect effect)
		{
		}

		// Token: 0x060145E9 RID: 83433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145E9")]
		[Address(RVA = "0xC9CCE0", Offset = "0xC9B8E0", VA = "0x180C9CCE0")]
		private void Update()
		{
		}

		// Token: 0x060145EA RID: 83434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145EA")]
		[Address(RVA = "0xC9CD40", Offset = "0xC9B940", VA = "0x180C9CD40")]
		private void _FollowCamera()
		{
		}

		// Token: 0x060145EB RID: 83435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145EB")]
		[Address(RVA = "0xC9CEF0", Offset = "0xC9BAF0", VA = "0x180C9CEF0")]
		public FollowCamera()
		{
		}

		// Token: 0x060145EC RID: 83436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145EC")]
		[Address(RVA = "0xC9CCD0", Offset = "0xC9B8D0", VA = "0x180C9CCD0")]
		private void <>xLuaBaseProxy_Init(Effect P0)
		{
		}

		// Token: 0x0401808A RID: 98442
		[Token(Token = "0x401808A")]
		[FieldOffset(Offset = "0x20")]
		private CameraController.CameraPosition m_lastPos;

		// Token: 0x0401808B RID: 98443
		[Token(Token = "0x401808B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401808C RID: 98444
		[Token(Token = "0x401808C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401808D RID: 98445
		[Token(Token = "0x401808D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__FollowCamera;

		// Token: 0x0401808E RID: 98446
		[Token(Token = "0x401808E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
