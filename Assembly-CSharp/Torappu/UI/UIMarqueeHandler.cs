using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.MsgSubscription;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003484 RID: 13444
	[Token(Token = "0x2003484")]
	public class UIMarqueeHandler : IHotfixable
	{
		// Token: 0x0601572C RID: 87852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601572C")]
		[Address(RVA = "0xDF2400", Offset = "0xDF1000", VA = "0x180DF2400")]
		public IEnumerator Show(UpdateSubMsg msg, Action callBackAction)
		{
			return null;
		}

		// Token: 0x0601572D RID: 87853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601572D")]
		[Address(RVA = "0xDF2390", Offset = "0xDF0F90", VA = "0x180DF2390")]
		public void OnFinishAlert()
		{
		}

		// Token: 0x0601572E RID: 87854 RVA: 0x0008BF80 File Offset: 0x0008A180
		[Token(Token = "0x601572E")]
		[Address(RVA = "0xDF2690", Offset = "0xDF1290", VA = "0x180DF2690")]
		private bool _OpenMarqueeDialog(UpdateSubMsg msg)
		{
			return default(bool);
		}

		// Token: 0x0601572F RID: 87855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601572F")]
		[Address(RVA = "0xDF2A60", Offset = "0xDF1660", VA = "0x180DF2A60")]
		private void _TickUpdate(UpdateSubMsg msg)
		{
		}

		// Token: 0x06015730 RID: 87856 RVA: 0x0008BF98 File Offset: 0x0008A198
		[Token(Token = "0x6015730")]
		[Address(RVA = "0xDF2510", Offset = "0xDF1110", VA = "0x180DF2510")]
		private static bool _IsUpdateSubMsgValid(UpdateSubMsg msg)
		{
			return default(bool);
		}

		// Token: 0x06015731 RID: 87857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015731")]
		[Address(RVA = "0xDF2E20", Offset = "0xDF1A20", VA = "0x180DF2E20")]
		public UIMarqueeHandler()
		{
		}

		// Token: 0x04019AD4 RID: 105172
		[Token(Token = "0x4019AD4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<string> DONTSHOW_SCENE_LIST;

		// Token: 0x04019AD5 RID: 105173
		[Token(Token = "0x4019AD5")]
		private const float CONST_INIT_DURATION = 10000f;

		// Token: 0x04019AD6 RID: 105174
		[Token(Token = "0x4019AD6")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShowing;

		// Token: 0x04019AD7 RID: 105175
		[Token(Token = "0x4019AD7")]
		[FieldOffset(Offset = "0x11")]
		private bool m_isWaiting;

		// Token: 0x04019AD8 RID: 105176
		[Token(Token = "0x4019AD8")]
		[FieldOffset(Offset = "0x18")]
		private UpdateSubMsg m_cacheMsg;

		// Token: 0x04019AD9 RID: 105177
		[Token(Token = "0x4019AD9")]
		[FieldOffset(Offset = "0x20")]
		private string m_cacheSceneName;

		// Token: 0x04019ADA RID: 105178
		[Token(Token = "0x4019ADA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04019ADB RID: 105179
		[Token(Token = "0x4019ADB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinishAlert;

		// Token: 0x04019ADC RID: 105180
		[Token(Token = "0x4019ADC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OpenMarqueeDialog;

		// Token: 0x04019ADD RID: 105181
		[Token(Token = "0x4019ADD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TickUpdate;

		// Token: 0x04019ADE RID: 105182
		[Token(Token = "0x4019ADE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsUpdateSubMsgValid;

		// Token: 0x04019ADF RID: 105183
		[Token(Token = "0x4019ADF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
