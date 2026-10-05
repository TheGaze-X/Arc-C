using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037D1 RID: 14289
	[Token(Token = "0x20037D1")]
	public class TouchHandler<TContext> : TouchHandler where TContext : TouchHandler.TouchContext
	{
		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x06016A81 RID: 92801 RVA: 0x00092328 File Offset: 0x00090528
		[Token(Token = "0x17003633")]
		protected sealed override TouchHandler.CreateTouchType createTouchType
		{
			[Token(Token = "0x6016A81")]
			get
			{
				return TouchHandler.CreateTouchType.CREATE_ON_DRAG_BEGIN;
			}
		}

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x06016A82 RID: 92802 RVA: 0x00092340 File Offset: 0x00090540
		[Token(Token = "0x17003634")]
		protected sealed override int maxTouchCount
		{
			[Token(Token = "0x6016A82")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06016A83 RID: 92803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A83")]
		public TouchHandler(TContext context)
		{
		}

		// Token: 0x06016A84 RID: 92804 RVA: 0x00092358 File Offset: 0x00090558
		[Token(Token = "0x6016A84")]
		protected sealed override bool TouchSessionCreateInternal()
		{
			return default(bool);
		}

		// Token: 0x06016A85 RID: 92805 RVA: 0x00092370 File Offset: 0x00090570
		[Token(Token = "0x6016A85")]
		protected sealed override bool TouchSessionUpdateInternal()
		{
			return default(bool);
		}

		// Token: 0x06016A86 RID: 92806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A86")]
		protected sealed override void TouchSessionClearInternal()
		{
		}

		// Token: 0x06016A87 RID: 92807 RVA: 0x00092388 File Offset: 0x00090588
		[Token(Token = "0x6016A87")]
		protected sealed override bool TouchCreateInternal(int pointerId, ValueBundle param)
		{
			return default(bool);
		}

		// Token: 0x06016A88 RID: 92808 RVA: 0x000923A0 File Offset: 0x000905A0
		[Token(Token = "0x6016A88")]
		protected sealed override bool TouchMoveInternal(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x06016A89 RID: 92809 RVA: 0x000923B8 File Offset: 0x000905B8
		[Token(Token = "0x6016A89")]
		protected sealed override bool TouchUpdateInternal(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x06016A8A RID: 92810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A8A")]
		protected sealed override void TouchClearInternal(int pointerId)
		{
		}

		// Token: 0x06016A8B RID: 92811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A8B")]
		protected sealed override void OnScrollInternal(Vector2 scrollDelta, ValueBundle param)
		{
		}

		// Token: 0x0401B4F1 RID: 111857
		[Token(Token = "0x401B4F1")]
		[FieldOffset(Offset = "0x0")]
		private TContext m_touchContext;

		// Token: 0x0401B4F2 RID: 111858
		[Token(Token = "0x401B4F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_createTouchType;

		// Token: 0x0401B4F3 RID: 111859
		[Token(Token = "0x401B4F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_maxTouchCount;

		// Token: 0x0401B4F4 RID: 111860
		[Token(Token = "0x401B4F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B4F5 RID: 111861
		[Token(Token = "0x401B4F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TouchSessionCreateInternal;

		// Token: 0x0401B4F6 RID: 111862
		[Token(Token = "0x401B4F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TouchSessionUpdateInternal;

		// Token: 0x0401B4F7 RID: 111863
		[Token(Token = "0x401B4F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TouchSessionClearInternal;

		// Token: 0x0401B4F8 RID: 111864
		[Token(Token = "0x401B4F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TouchCreateInternal;

		// Token: 0x0401B4F9 RID: 111865
		[Token(Token = "0x401B4F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TouchMoveInternal;

		// Token: 0x0401B4FA RID: 111866
		[Token(Token = "0x401B4FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TouchUpdateInternal;

		// Token: 0x0401B4FB RID: 111867
		[Token(Token = "0x401B4FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TouchClearInternal;

		// Token: 0x0401B4FC RID: 111868
		[Token(Token = "0x401B4FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnScrollInternal;
	}
}
