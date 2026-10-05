using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public class SDKInterfaceWIN : U8SDKInterface
	{
		// Token: 0x06000218 RID: 536 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x4A177B0", Offset = "0x4A163B0", VA = "0x184A177B0")]
		public SDKInterfaceWIN()
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x4A15610", Offset = "0x4A14210", VA = "0x184A15610", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000278C File Offset: 0x0000098C
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x4A152D0", Offset = "0x4A13ED0", VA = "0x184A152D0")]
		public int AddAction(Action<string> action)
		{
			return 0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x4A15420", Offset = "0x4A14020", VA = "0x184A15420")]
		[MonoPInvokeCallback(typeof(SDKInterfaceWIN.DataCallback))]
		public static void DataActionCallback(int index, string paramValue)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x4A150E0", Offset = "0x4A13CE0", VA = "0x184A150E0")]
		[MonoPInvokeCallback(typeof(SDKInterfaceWIN.DataCallback))]
		public static void ASyncDataActionCallback(int index, string paramValue)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x4A175B0", Offset = "0x4A161B0", VA = "0x184A175B0")]
		[MonoPInvokeCallback(typeof(SDKInterfaceWIN.U8SDKSendMessageCallback))]
		public static void U8SDKSendMessage(string methodName, string paramValue)
		{
		}

		// Token: 0x0600021E RID: 542
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x4A15AC0", Offset = "0x4A146C0", VA = "0x184A15AC0")]
		[PreserveSig]
		public static extern void HGU8SDKInitLibrary(string windowText, long windowHandle);

		// Token: 0x0600021F RID: 543
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x4A16240", Offset = "0x4A14E40", VA = "0x184A16240")]
		[PreserveSig]
		public static extern int HGU8SDKSetUserDataPath(string path);

		// Token: 0x06000220 RID: 544
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x4A16450", Offset = "0x4A15050", VA = "0x184A16450")]
		[PreserveSig]
		public static extern void HGU8SDKUnInitLibrary();

		// Token: 0x06000221 RID: 545
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x4A15A20", Offset = "0x4A14620", VA = "0x184A15A20")]
		[PreserveSig]
		public static extern void HGU8SDKInitDatacallback(SDKInterfaceWIN.DataCallback Callback, SDKInterfaceWIN.DataCallback asyncCallback);

		// Token: 0x06000222 RID: 546
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x4A15B60", Offset = "0x4A14760", VA = "0x184A15B60")]
		[PreserveSig]
		public static extern void HGU8SDKInitSendMessage(SDKInterfaceWIN.U8SDKSendMessageCallback callback);

		// Token: 0x06000223 RID: 547
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x4A15BF0", Offset = "0x4A147F0", VA = "0x184A15BF0")]
		[PreserveSig]
		public static extern void HGU8SDKInit();

		// Token: 0x06000224 RID: 548
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x4A164C0", Offset = "0x4A150C0", VA = "0x184A164C0")]
		[PreserveSig]
		public static extern void HGU8SDKV2Init(string env);

		// Token: 0x06000225 RID: 549
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x4A15FA0", Offset = "0x4A14BA0", VA = "0x184A15FA0")]
		[PreserveSig]
		public static extern void HGU8SDKLogin();

		// Token: 0x06000226 RID: 550
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x4A15F10", Offset = "0x4A14B10", VA = "0x184A15F10")]
		[PreserveSig]
		public static extern void HGU8SDKLoginCustom(string json);

		// Token: 0x06000227 RID: 551
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x4A163E0", Offset = "0x4A14FE0", VA = "0x184A163E0")]
		[PreserveSig]
		public static extern void HGU8SDKSwitchLogin();

		// Token: 0x06000228 RID: 552
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x4A16010", Offset = "0x4A14C10", VA = "0x184A16010")]
		[PreserveSig]
		public static extern int HGU8SDKLogout();

		// Token: 0x06000229 RID: 553
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x4A162E0", Offset = "0x4A14EE0", VA = "0x184A162E0")]
		[PreserveSig]
		public static extern int HGU8SDKShowAccountCenter();

		// Token: 0x0600022A RID: 554
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x4A16080", Offset = "0x4A14C80", VA = "0x184A16080")]
		[PreserveSig]
		public static extern void HGU8SDKPay(string json);

		// Token: 0x0600022B RID: 555
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x4A16350", Offset = "0x4A14F50", VA = "0x184A16350")]
		[PreserveSig]
		public static extern void HGU8SDKSubmitGameData(string json);

		// Token: 0x0600022C RID: 556
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x4A15D40", Offset = "0x4A14940", VA = "0x184A15D40")]
		[PreserveSig]
		public static extern int HGU8SDKIsSupportExit();

		// Token: 0x0600022D RID: 557
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x4A15CD0", Offset = "0x4A148D0", VA = "0x184A15CD0")]
		[PreserveSig]
		public static extern int HGU8SDKIsSupportAccountCenter();

		// Token: 0x0600022E RID: 558
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x4A15DB0", Offset = "0x4A149B0", VA = "0x184A15DB0")]
		[PreserveSig]
		public static extern int HGU8SDKIsSupportLogin();

		// Token: 0x0600022F RID: 559
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x4A15E20", Offset = "0x4A14A20", VA = "0x184A15E20")]
		[PreserveSig]
		public static extern int HGU8SDKIsSupportLogout();

		// Token: 0x06000230 RID: 560
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x4A159A0", Offset = "0x4A145A0", VA = "0x184A159A0")]
		[PreserveSig]
		public static extern void HGU8SDKGetSDKMeta(int index);

		// Token: 0x06000231 RID: 561
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x4A16110", Offset = "0x4A14D10", VA = "0x184A16110")]
		[PreserveSig]
		public static extern void HGU8SDKSetData(int code, string paramJson);

		// Token: 0x06000232 RID: 562
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x4A158F0", Offset = "0x4A144F0", VA = "0x184A158F0")]
		[PreserveSig]
		public static extern void HGU8SDKGetData(int code, string paramJson, int index);

		// Token: 0x06000233 RID: 563
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x4A15C60", Offset = "0x4A14860", VA = "0x184A15C60")]
		[PreserveSig]
		public static extern int HGU8SDKIsNativePlugin();

		// Token: 0x06000234 RID: 564
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x4A15E90", Offset = "0x4A14A90", VA = "0x184A15E90")]
		[PreserveSig]
		public static extern void HGU8SDKLoadExtraConfig(int index);

		// Token: 0x06000235 RID: 565
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x4A161B0", Offset = "0x4A14DB0", VA = "0x184A161B0")]
		[PreserveSig]
		public static extern void HGU8SDKSetGameVersion(string version);

		// Token: 0x06000236 RID: 566 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x4A16910", Offset = "0x4A15510", VA = "0x184A16910", Slot = "4")]
		protected override string LoadExtraConfig()
		{
			return null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x4A17620", Offset = "0x4A16220", VA = "0x184A17620", Slot = "5")]
		protected override void V2Init(string env)
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x4A16550", Offset = "0x4A15150", VA = "0x184A16550", Slot = "6")]
		protected override void Init()
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x4A16D00", Offset = "0x4A15900", VA = "0x184A16D00", Slot = "7")]
		protected override void Login()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000027A4 File Offset: 0x000009A4
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x4A16DA0", Offset = "0x4A159A0", VA = "0x184A16DA0", Slot = "10")]
		protected override bool Logout()
		{
			return default(bool);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x4A16C40", Offset = "0x4A15840", VA = "0x184A16C40", Slot = "8")]
		protected override void LoginCustom(string customData)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x4A17510", Offset = "0x4A16110", VA = "0x184A17510", Slot = "9")]
		protected override void SwitchLogin()
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x4A173F0", Offset = "0x4A15FF0", VA = "0x184A173F0", Slot = "12")]
		public override void SubmitGameDataNative(U8ExtraGameData data)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x4A16F20", Offset = "0x4A15B20", VA = "0x184A16F20", Slot = "19")]
		public override void SetDataNative(int type, string paramJson)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x4A15740", Offset = "0x4A14340", VA = "0x184A15740", Slot = "20")]
		public override string GetDataNative(int type, string paramJson)
		{
			return null;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000027BC File Offset: 0x000009BC
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x4A17350", Offset = "0x4A15F50", VA = "0x184A17350", Slot = "11")]
		public override bool ShowAccountCenter()
		{
			return default(bool);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000027D4 File Offset: 0x000009D4
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "13")]
		public override bool SDKExit()
		{
			return default(bool);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x4A16E40", Offset = "0x4A15A40", VA = "0x184A16E40", Slot = "14")]
		protected override void Pay(U8PayParams data)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x4A16730", Offset = "0x4A15330", VA = "0x184A16730", Slot = "15")]
		public override bool IsSupportExit()
		{
			return default(bool);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x4A16690", Offset = "0x4A15290", VA = "0x184A16690", Slot = "16")]
		public override bool IsSupportAccountCenter()
		{
			return default(bool);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x4A167D0", Offset = "0x4A153D0", VA = "0x184A167D0", Slot = "18")]
		public override bool IsSupportLogin()
		{
			return default(bool);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x4A16870", Offset = "0x4A15470", VA = "0x184A16870", Slot = "17")]
		public override bool IsSupportLogout()
		{
			return default(bool);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x4A16A90", Offset = "0x4A15690", VA = "0x184A16A90", Slot = "21")]
		protected override SDKMeta LoadSDKMeta()
		{
			return null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x4A165F0", Offset = "0x4A151F0", VA = "0x184A165F0", Slot = "22")]
		protected override bool IsNativePlugin()
		{
			return default(bool);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x4A17250", Offset = "0x4A15E50", VA = "0x184A17250", Slot = "23")]
		public override void SetGameVersion(string version)
		{
		}

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int actionIndex;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<int, Action<string>> dictAction;

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x0600024C RID: 588
		[Token(Token = "0x2000073")]
		public delegate void DataCallback(int index, string paramValue);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000250 RID: 592
		[Token(Token = "0x2000074")]
		public delegate void U8SDKSendMessageCallback(string methodName, string paramValue);
	}
}
