using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.MsgSubscription;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003486 RID: 13446
	[Token(Token = "0x2003486")]
	public class UIMarqueeUtil : Singleton<UIMarqueeUtil>
	{
		// Token: 0x06015739 RID: 87865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015739")]
		[Address(RVA = "0xDF3730", Offset = "0xDF2330", VA = "0x180DF3730")]
		private UIMarqueeUtil()
		{
		}

		// Token: 0x0601573A RID: 87866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601573A")]
		[Address(RVA = "0xDF34E0", Offset = "0xDF20E0", VA = "0x180DF34E0")]
		private void _OnSceneChanged(string fromSceneName, string toSceneName)
		{
		}

		// Token: 0x0601573B RID: 87867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601573B")]
		[Address(RVA = "0xDF2EA0", Offset = "0xDF1AA0", VA = "0x180DF2EA0")]
		public void OnRegister()
		{
		}

		// Token: 0x0601573C RID: 87868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601573C")]
		[Address(RVA = "0xDF3200", Offset = "0xDF1E00", VA = "0x180DF3200")]
		private void _OnCoroutineClose()
		{
		}

		// Token: 0x0601573D RID: 87869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601573D")]
		[Address(RVA = "0xDF32C0", Offset = "0xDF1EC0", VA = "0x180DF32C0")]
		private void _OnHandlerMsg(UpdateSubMsg msg)
		{
		}

		// Token: 0x04019AE5 RID: 105189
		[Token(Token = "0x4019AE5")]
		[FieldOffset(Offset = "0x10")]
		private List<ISubMsgCenter> m_centers;

		// Token: 0x04019AE6 RID: 105190
		[Token(Token = "0x4019AE6")]
		[FieldOffset(Offset = "0x18")]
		private UIMarqueeHandler m_marqueeHandler;

		// Token: 0x04019AE7 RID: 105191
		[Token(Token = "0x4019AE7")]
		[FieldOffset(Offset = "0x20")]
		private IEnumerator m_showCoroutine;

		// Token: 0x04019AE8 RID: 105192
		[Token(Token = "0x4019AE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04019AE9 RID: 105193
		[Token(Token = "0x4019AE9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnSceneChanged;

		// Token: 0x04019AEA RID: 105194
		[Token(Token = "0x4019AEA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x04019AEB RID: 105195
		[Token(Token = "0x4019AEB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCoroutineClose;

		// Token: 0x04019AEC RID: 105196
		[Token(Token = "0x4019AEC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnHandlerMsg;
	}
}
