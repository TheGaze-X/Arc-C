using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005633 RID: 22067
	[Token(Token = "0x2005633")]
	public class RL05SpZoneLeaveNotify : RoguelikeAnimNotify
	{
		// Token: 0x17004BCB RID: 19403
		// (get) Token: 0x06020622 RID: 132642 RVA: 0x000B5AD0 File Offset: 0x000B3CD0
		[Token(Token = "0x17004BCB")]
		public override RoguelikeCustomNotifyType notifyType
		{
			[Token(Token = "0x6020622")]
			[Address(RVA = "0x1A7FEC0", Offset = "0x1A7EAC0", VA = "0x181A7FEC0", Slot = "4")]
			get
			{
				return RoguelikeCustomNotifyType.NONE;
			}
		}

		// Token: 0x06020623 RID: 132643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020623")]
		[Address(RVA = "0x1A7FDA0", Offset = "0x1A7E9A0", VA = "0x181A7FDA0", Slot = "7")]
		protected override void Render(ValueBundle options)
		{
		}

		// Token: 0x06020624 RID: 132644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020624")]
		[Address(RVA = "0x1A7FE60", Offset = "0x1A7EA60", VA = "0x181A7FE60")]
		public RL05SpZoneLeaveNotify()
		{
		}

		// Token: 0x0402BD72 RID: 179570
		[Token(Token = "0x402BD72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_notifyType;

		// Token: 0x0402BD73 RID: 179571
		[Token(Token = "0x402BD73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BD74 RID: 179572
		[Token(Token = "0x402BD74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
