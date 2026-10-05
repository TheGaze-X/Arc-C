using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037D2 RID: 14290
	[Token(Token = "0x20037D2")]
	public abstract class DragContext : TouchHandler.TouchContext
	{
		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x06016A8C RID: 92812 RVA: 0x000923D0 File Offset: 0x000905D0
		[Token(Token = "0x17003635")]
		public sealed override TouchHandler.CreateTouchType createTouchType
		{
			[Token(Token = "0x6016A8C")]
			[Address(RVA = "0xF05CE0", Offset = "0xF048E0", VA = "0x180F05CE0", Slot = "4")]
			get
			{
				return TouchHandler.CreateTouchType.CREATE_ON_DRAG_BEGIN;
			}
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x06016A8D RID: 92813 RVA: 0x000923E8 File Offset: 0x000905E8
		[Token(Token = "0x17003636")]
		public sealed override int maxTouchCount
		{
			[Token(Token = "0x6016A8D")]
			[Address(RVA = "0xF05D40", Offset = "0xF04940", VA = "0x180F05D40", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06016A8E RID: 92814 RVA: 0x00092400 File Offset: 0x00090600
		[Token(Token = "0x6016A8E")]
		[Address(RVA = "0xF05900", Offset = "0xF04500", VA = "0x180F05900", Slot = "6")]
		public override bool TouchCreate(int pointerId, ValueBundle param)
		{
			return default(bool);
		}

		// Token: 0x06016A8F RID: 92815 RVA: 0x00092418 File Offset: 0x00090618
		[Token(Token = "0x6016A8F")]
		[Address(RVA = "0xF059C0", Offset = "0xF045C0", VA = "0x180F059C0", Slot = "7")]
		public sealed override bool TouchMove(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x06016A90 RID: 92816 RVA: 0x00092430 File Offset: 0x00090630
		[Token(Token = "0x6016A90")]
		[Address(RVA = "0xF05B90", Offset = "0xF04790", VA = "0x180F05B90", Slot = "8")]
		public override bool TouchUpdate(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x06016A91 RID: 92817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A91")]
		[Address(RVA = "0xF058A0", Offset = "0xF044A0", VA = "0x180F058A0", Slot = "9")]
		public override void TouchClear(int pointerId)
		{
		}

		// Token: 0x06016A92 RID: 92818 RVA: 0x00092448 File Offset: 0x00090648
		[Token(Token = "0x6016A92")]
		[Address(RVA = "0xF05AD0", Offset = "0xF046D0", VA = "0x180F05AD0", Slot = "10")]
		public sealed override bool TouchSessionCreate()
		{
			return default(bool);
		}

		// Token: 0x06016A93 RID: 92819 RVA: 0x00092460 File Offset: 0x00090660
		[Token(Token = "0x6016A93")]
		[Address(RVA = "0xF05B30", Offset = "0xF04730", VA = "0x180F05B30", Slot = "11")]
		public sealed override bool TouchSessionUpdate()
		{
			return default(bool);
		}

		// Token: 0x06016A94 RID: 92820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A94")]
		[Address(RVA = "0xF05A70", Offset = "0xF04670", VA = "0x180F05A70", Slot = "12")]
		public sealed override void TouchSessionClear()
		{
		}

		// Token: 0x06016A95 RID: 92821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A95")]
		[Address(RVA = "0xF05C40", Offset = "0xF04840", VA = "0x180F05C40")]
		protected DragContext()
		{
		}

		// Token: 0x0401B4FD RID: 111869
		[Token(Token = "0x401B4FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_createTouchType;

		// Token: 0x0401B4FE RID: 111870
		[Token(Token = "0x401B4FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_maxTouchCount;

		// Token: 0x0401B4FF RID: 111871
		[Token(Token = "0x401B4FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TouchCreate;

		// Token: 0x0401B500 RID: 111872
		[Token(Token = "0x401B500")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TouchMove;

		// Token: 0x0401B501 RID: 111873
		[Token(Token = "0x401B501")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TouchUpdate;

		// Token: 0x0401B502 RID: 111874
		[Token(Token = "0x401B502")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TouchClear;

		// Token: 0x0401B503 RID: 111875
		[Token(Token = "0x401B503")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TouchSessionCreate;

		// Token: 0x0401B504 RID: 111876
		[Token(Token = "0x401B504")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TouchSessionUpdate;

		// Token: 0x0401B505 RID: 111877
		[Token(Token = "0x401B505")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TouchSessionClear;

		// Token: 0x0401B506 RID: 111878
		[Token(Token = "0x401B506")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
