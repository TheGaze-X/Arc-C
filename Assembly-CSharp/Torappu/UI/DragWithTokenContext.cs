using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037D4 RID: 14292
	[Token(Token = "0x20037D4")]
	public class DragWithTokenContext : DragContext
	{
		// Token: 0x06016AA1 RID: 92833 RVA: 0x00092508 File Offset: 0x00090708
		[Token(Token = "0x6016AA1")]
		[Address(RVA = "0xF06100", Offset = "0xF04D00", VA = "0x180F06100", Slot = "6")]
		public sealed override bool TouchCreate(int pointerId, ValueBundle param)
		{
			return default(bool);
		}

		// Token: 0x06016AA2 RID: 92834 RVA: 0x00092520 File Offset: 0x00090720
		[Token(Token = "0x6016AA2")]
		[Address(RVA = "0xF06350", Offset = "0xF04F50", VA = "0x180F06350", Slot = "8")]
		public sealed override bool TouchUpdate(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x06016AA3 RID: 92835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AA3")]
		[Address(RVA = "0xF06020", Offset = "0xF04C20", VA = "0x180F06020", Slot = "9")]
		public sealed override void TouchClear(int pointerId)
		{
		}

		// Token: 0x06016AA4 RID: 92836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AA4")]
		[Address(RVA = "0xF05F90", Offset = "0xF04B90", VA = "0x180F05F90", Slot = "13")]
		public sealed override void OnScrollInternal(Vector2 scrollDelta, ValueBundle param)
		{
		}

		// Token: 0x06016AA5 RID: 92837 RVA: 0x00092538 File Offset: 0x00090738
		[Token(Token = "0x6016AA5")]
		[Address(RVA = "0xF05DA0", Offset = "0xF049A0", VA = "0x180F05DA0", Slot = "14")]
		protected virtual bool DragBeginInternal(ValueBundle param)
		{
			return default(bool);
		}

		// Token: 0x06016AA6 RID: 92838 RVA: 0x00092550 File Offset: 0x00090750
		[Token(Token = "0x6016AA6")]
		[Address(RVA = "0xF05E80", Offset = "0xF04A80", VA = "0x180F05E80", Slot = "15")]
		protected virtual bool DragUpdateInternal()
		{
			return default(bool);
		}

		// Token: 0x06016AA7 RID: 92839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AA7")]
		[Address(RVA = "0xF05E20", Offset = "0xF04A20", VA = "0x180F05E20", Slot = "16")]
		protected virtual void DragClearInternal()
		{
		}

		// Token: 0x06016AA8 RID: 92840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016AA8")]
		[Address(RVA = "0xF05EE0", Offset = "0xF04AE0", VA = "0x180F05EE0", Slot = "17")]
		protected virtual RectTransform GetTokenInst(RectTransform tokenContainer, Vector2 touchPos, ValueBundle param)
		{
			return null;
		}

		// Token: 0x06016AA9 RID: 92841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AA9")]
		[Address(RVA = "0xF06670", Offset = "0xF05270", VA = "0x180F06670")]
		public DragWithTokenContext()
		{
		}

		// Token: 0x06016AAA RID: 92842 RVA: 0x00092568 File Offset: 0x00090768
		[Token(Token = "0x6016AAA")]
		[Address(RVA = "0xF05900", Offset = "0xF04500", VA = "0x180F05900")]
		private bool <>xLuaBaseProxy_TouchCreate(int P0, ValueBundle P1)
		{
			return default(bool);
		}

		// Token: 0x06016AAB RID: 92843 RVA: 0x00092580 File Offset: 0x00090780
		[Token(Token = "0x6016AAB")]
		[Address(RVA = "0xF06660", Offset = "0xF05260", VA = "0x180F06660")]
		private bool <>xLuaBaseProxy_TouchUpdate(int P0)
		{
			return default(bool);
		}

		// Token: 0x06016AAC RID: 92844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AAC")]
		[Address(RVA = "0xF058A0", Offset = "0xF044A0", VA = "0x180F058A0")]
		private void <>xLuaBaseProxy_TouchClear(int P0)
		{
		}

		// Token: 0x0401B50F RID: 111887
		[Token(Token = "0x401B50F")]
		private const float OFFSET_DECREASE_SPEED = 0.16666667f;

		// Token: 0x0401B510 RID: 111888
		[Token(Token = "0x401B510")]
		[FieldOffset(Offset = "0x18")]
		private int m_tickCountSinceDragStart;

		// Token: 0x0401B511 RID: 111889
		[Token(Token = "0x401B511")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform targetToken;

		// Token: 0x0401B512 RID: 111890
		[Token(Token = "0x401B512")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 targetStartPos;

		// Token: 0x0401B513 RID: 111891
		[Token(Token = "0x401B513")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 dragStartScreenOffset;

		// Token: 0x0401B514 RID: 111892
		[Token(Token = "0x401B514")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TouchCreate;

		// Token: 0x0401B515 RID: 111893
		[Token(Token = "0x401B515")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TouchUpdate;

		// Token: 0x0401B516 RID: 111894
		[Token(Token = "0x401B516")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TouchClear;

		// Token: 0x0401B517 RID: 111895
		[Token(Token = "0x401B517")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnScrollInternal;

		// Token: 0x0401B518 RID: 111896
		[Token(Token = "0x401B518")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DragBeginInternal;

		// Token: 0x0401B519 RID: 111897
		[Token(Token = "0x401B519")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DragUpdateInternal;

		// Token: 0x0401B51A RID: 111898
		[Token(Token = "0x401B51A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DragClearInternal;

		// Token: 0x0401B51B RID: 111899
		[Token(Token = "0x401B51B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetTokenInst;

		// Token: 0x0401B51C RID: 111900
		[Token(Token = "0x401B51C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
