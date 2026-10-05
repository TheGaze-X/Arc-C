using System;
using Il2CppDummyDll;
using Torappu;
using UnityEngine;
using XLua;

namespace YostarSDKV2
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	public class YostarV2SettingViewAccount : MonoBehaviour, IHotfixable
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x5254E0", Offset = "0x5240E0", VA = "0x1805254E0")]
		public void Render(YostarSDKV2 sdk)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x5250E0", Offset = "0x523CE0", VA = "0x1805250E0")]
		public void EventOnLogOutClicked()
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x525420", Offset = "0x524020", VA = "0x180525420")]
		public void EventOnUserCenterClicked()
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x5252E0", Offset = "0x523EE0", VA = "0x1805252E0")]
		public void EventOnUserAgreementClicked()
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x5251A0", Offset = "0x523DA0", VA = "0x1805251A0")]
		public void EventOnPrivacyPolicyClicked()
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x525560", Offset = "0x524160", VA = "0x180525560")]
		public YostarV2SettingViewAccount()
		{
		}

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x18")]
		private YostarSDKV2 m_sdk;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnLogOutClicked;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnUserCenterClicked;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnUserAgreementClicked;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnPrivacyPolicyClicked;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
