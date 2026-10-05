using System;
using Il2CppDummyDll;
using Torappu;
using UnityEngine;
using XLua;

namespace YostarSDKV2
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	public class YostarV2SettingViewOthers : MonoBehaviour, IHotfixable
	{
		// Token: 0x060002DC RID: 732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x525740", Offset = "0x524340", VA = "0x180525740")]
		public void Render(YostarSDKV2 sdk)
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x525680", Offset = "0x524280", VA = "0x180525680")]
		public void EventOnDiamondDetailClicked()
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x5255C0", Offset = "0x5241C0", VA = "0x1805255C0")]
		public void EventOnCustomerCenterClicked()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x5257C0", Offset = "0x5243C0", VA = "0x1805257C0")]
		public YostarV2SettingViewOthers()
		{
		}

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x18")]
		private YostarSDKV2 m_sdk;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnDiamondDetailClicked;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnCustomerCenterClicked;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
