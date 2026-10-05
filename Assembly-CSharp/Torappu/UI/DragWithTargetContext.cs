using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003792 RID: 14226
	[Token(Token = "0x2003792")]
	public class DragWithTargetContext : DragAndPinchWithTargetContext
	{
		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x06016924 RID: 92452 RVA: 0x00091DD0 File Offset: 0x0008FFD0
		[Token(Token = "0x17003608")]
		public sealed override int maxTouchCount
		{
			[Token(Token = "0x6016924")]
			[Address(RVA = "0xEF6700", Offset = "0xEF5300", VA = "0x180EF6700", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x06016925 RID: 92453 RVA: 0x00091DE8 File Offset: 0x0008FFE8
		[Token(Token = "0x17003609")]
		public sealed override TouchHandler.CreateTouchType createTouchType
		{
			[Token(Token = "0x6016925")]
			[Address(RVA = "0xEF66A0", Offset = "0xEF52A0", VA = "0x180EF66A0", Slot = "4")]
			get
			{
				return TouchHandler.CreateTouchType.CREATE_ON_DRAG_BEGIN;
			}
		}

		// Token: 0x06016926 RID: 92454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016926")]
		[Address(RVA = "0xEF6550", Offset = "0xEF5150", VA = "0x180EF6550")]
		public DragWithTargetContext()
		{
		}

		// Token: 0x06016927 RID: 92455 RVA: 0x00091E00 File Offset: 0x00090000
		[Token(Token = "0x6016927")]
		[Address(RVA = "0xEF64F0", Offset = "0xEF50F0", VA = "0x180EF64F0")]
		private int <>xLuaBaseProxy_get_maxTouchCount()
		{
			return 0;
		}

		// Token: 0x06016928 RID: 92456 RVA: 0x00091E18 File Offset: 0x00090018
		[Token(Token = "0x6016928")]
		[Address(RVA = "0xEF6370", Offset = "0xEF4F70", VA = "0x180EF6370")]
		private TouchHandler.CreateTouchType <>xLuaBaseProxy_get_createTouchType()
		{
			return TouchHandler.CreateTouchType.CREATE_ON_DRAG_BEGIN;
		}

		// Token: 0x0401B341 RID: 111425
		[Token(Token = "0x401B341")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_maxTouchCount;

		// Token: 0x0401B342 RID: 111426
		[Token(Token = "0x401B342")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_createTouchType;

		// Token: 0x0401B343 RID: 111427
		[Token(Token = "0x401B343")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
