using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037D3 RID: 14291
	[Token(Token = "0x20037D3")]
	public class SimpleDragContext : DragContext
	{
		// Token: 0x06016A96 RID: 92822 RVA: 0x00092478 File Offset: 0x00090678
		[Token(Token = "0x6016A96")]
		[Address(RVA = "0xF07160", Offset = "0xF05D60", VA = "0x180F07160", Slot = "6")]
		public sealed override bool TouchCreate(int pointerId, ValueBundle param)
		{
			return default(bool);
		}

		// Token: 0x06016A97 RID: 92823 RVA: 0x00092490 File Offset: 0x00090690
		[Token(Token = "0x6016A97")]
		[Address(RVA = "0xF07260", Offset = "0xF05E60", VA = "0x180F07260", Slot = "8")]
		public sealed override bool TouchUpdate(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x06016A98 RID: 92824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A98")]
		[Address(RVA = "0xF070A0", Offset = "0xF05CA0", VA = "0x180F070A0", Slot = "9")]
		public sealed override void TouchClear(int pointerId)
		{
		}

		// Token: 0x06016A99 RID: 92825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A99")]
		[Address(RVA = "0xF07010", Offset = "0xF05C10", VA = "0x180F07010", Slot = "13")]
		public sealed override void OnScrollInternal(Vector2 scrollDelta, ValueBundle param)
		{
		}

		// Token: 0x06016A9A RID: 92826 RVA: 0x000924A8 File Offset: 0x000906A8
		[Token(Token = "0x6016A9A")]
		[Address(RVA = "0xF06ED0", Offset = "0xF05AD0", VA = "0x180F06ED0", Slot = "14")]
		protected virtual bool DragBeginInternal(ValueBundle param)
		{
			return default(bool);
		}

		// Token: 0x06016A9B RID: 92827 RVA: 0x000924C0 File Offset: 0x000906C0
		[Token(Token = "0x6016A9B")]
		[Address(RVA = "0xF06FB0", Offset = "0xF05BB0", VA = "0x180F06FB0", Slot = "15")]
		protected virtual bool DragUpdateInternal()
		{
			return default(bool);
		}

		// Token: 0x06016A9C RID: 92828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A9C")]
		[Address(RVA = "0xF06F50", Offset = "0xF05B50", VA = "0x180F06F50", Slot = "16")]
		protected virtual void DragClearInternal()
		{
		}

		// Token: 0x06016A9D RID: 92829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A9D")]
		[Address(RVA = "0xF07310", Offset = "0xF05F10", VA = "0x180F07310")]
		public SimpleDragContext()
		{
		}

		// Token: 0x06016A9E RID: 92830 RVA: 0x000924D8 File Offset: 0x000906D8
		[Token(Token = "0x6016A9E")]
		[Address(RVA = "0xF05900", Offset = "0xF04500", VA = "0x180F05900")]
		private bool <>xLuaBaseProxy_TouchCreate(int P0, ValueBundle P1)
		{
			return default(bool);
		}

		// Token: 0x06016A9F RID: 92831 RVA: 0x000924F0 File Offset: 0x000906F0
		[Token(Token = "0x6016A9F")]
		[Address(RVA = "0xF06660", Offset = "0xF05260", VA = "0x180F06660")]
		private bool <>xLuaBaseProxy_TouchUpdate(int P0)
		{
			return default(bool);
		}

		// Token: 0x06016AA0 RID: 92832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AA0")]
		[Address(RVA = "0xF058A0", Offset = "0xF044A0", VA = "0x180F058A0")]
		private void <>xLuaBaseProxy_TouchClear(int P0)
		{
		}

		// Token: 0x0401B507 RID: 111879
		[Token(Token = "0x401B507")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TouchCreate;

		// Token: 0x0401B508 RID: 111880
		[Token(Token = "0x401B508")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TouchUpdate;

		// Token: 0x0401B509 RID: 111881
		[Token(Token = "0x401B509")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TouchClear;

		// Token: 0x0401B50A RID: 111882
		[Token(Token = "0x401B50A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnScrollInternal;

		// Token: 0x0401B50B RID: 111883
		[Token(Token = "0x401B50B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DragBeginInternal;

		// Token: 0x0401B50C RID: 111884
		[Token(Token = "0x401B50C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DragUpdateInternal;

		// Token: 0x0401B50D RID: 111885
		[Token(Token = "0x401B50D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DragClearInternal;

		// Token: 0x0401B50E RID: 111886
		[Token(Token = "0x401B50E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
