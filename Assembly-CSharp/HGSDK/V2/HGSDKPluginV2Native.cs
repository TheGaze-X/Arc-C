using System;
using System.Diagnostics;
using Il2CppDummyDll;
using Torappu;
using U8.SDK;
using XLua;

namespace HGSDK.V2
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	public class HGSDKPluginV2Native : HGSDKPluginV2, IHotfixable
	{
		// Token: 0x060005B3 RID: 1459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1029800", Offset = "0x1028400", VA = "0x181029800")]
		public HGSDKPluginV2Native(HGSDKV2 sdk)
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1028DD0", Offset = "0x10279D0", VA = "0x181028DD0", Slot = "17")]
		public override void Login(ExternalPluginLoginParams args)
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1029670", Offset = "0x1028270", VA = "0x181029670")]
		private static void _UpdateLastUsedUserName(string currentName, HGSDKV2 sdk)
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1029310", Offset = "0x1027F10", VA = "0x181029310", Slot = "18")]
		public override void Logout(ExternalPluginLogoutParams args)
		{
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x10293C0", Offset = "0x1027FC0", VA = "0x1810293C0", Slot = "19")]
		public override void Pay(ExternalPluginPayParams args)
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x10295B0", Offset = "0x10281B0", VA = "0x1810295B0")]
		[Conditional("TEST")]
		[Conditional("UNITY_EDITOR")]
		private static void _TestOnlyMockPay(ExternalPluginPayParams args, ref bool isMockPay)
		{
		}

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Login;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateLastUsedUserName;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Logout;

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Pay;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TestOnlyMockPay;
	}
}
