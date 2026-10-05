using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SDK.AntiData
{
	// Token: 0x020001B6 RID: 438
	[Token(Token = "0x20001B6")]
	public class ACEAntiDataSDK : ServiceAntiDataSDK
	{
		// Token: 0x06000A26 RID: 2598 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x5548F60", Offset = "0x5547B60", VA = "0x185548F60", Slot = "5")]
		protected override void OnEnterGame()
		{
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x5548C90", Offset = "0x5547890", VA = "0x185548C90", Slot = "6")]
		protected override byte[] GetData1()
		{
			return null;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x5548D20", Offset = "0x5547920", VA = "0x185548D20", Slot = "7")]
		protected override byte[] GetData2()
		{
			return null;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00007724 File Offset: 0x00005924
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x5548ED0", Offset = "0x5547AD0", VA = "0x185548ED0")]
		public static bool IsEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0000773C File Offset: 0x0000593C
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x5548E70", Offset = "0x5547A70", VA = "0x185548E70", Slot = "8")]
		protected override bool IsData4Supported()
		{
			return default(bool);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x5549100", Offset = "0x5547D00", VA = "0x185549100", Slot = "9")]
		protected override void StartScanData4()
		{
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00007754 File Offset: 0x00005954
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x5548C10", Offset = "0x5547810", VA = "0x185548C10", Slot = "10")]
		protected override bool CheckData4(uint token)
		{
			return default(bool);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x5548DB0", Offset = "0x55479B0", VA = "0x185548DB0", Slot = "11")]
		protected override byte[] GetData4(uint token)
		{
			return null;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x5549180", Offset = "0x5547D80", VA = "0x185549180")]
		public ACEAntiDataSDK()
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x5549170", Offset = "0x5547D70", VA = "0x185549170")]
		private void <>xLuaBaseProxy_OnEnterGame()
		{
		}

		// Token: 0x040009EC RID: 2540
		[Token(Token = "0x40009EC")]
		private const string NON_PROD_UID_FORMAT = "TEST_{0}";

		// Token: 0x040009ED RID: 2541
		[Token(Token = "0x40009ED")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnEnterGame;

		// Token: 0x040009EE RID: 2542
		[Token(Token = "0x40009EE")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate226 __Hotfix0_GetData1;

		// Token: 0x040009EF RID: 2543
		[Token(Token = "0x40009EF")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate226 __Hotfix0_GetData2;

		// Token: 0x040009F0 RID: 2544
		[Token(Token = "0x40009F0")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate8 __Hotfix0_IsEnabled;

		// Token: 0x040009F1 RID: 2545
		[Token(Token = "0x40009F1")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate21 __Hotfix0_IsData4Supported;

		// Token: 0x040009F2 RID: 2546
		[Token(Token = "0x40009F2")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0_StartScanData4;

		// Token: 0x040009F3 RID: 2547
		[Token(Token = "0x40009F3")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate227 __Hotfix0_CheckData4;

		// Token: 0x040009F4 RID: 2548
		[Token(Token = "0x40009F4")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate228 __Hotfix0_GetData4;

		// Token: 0x040009F5 RID: 2549
		[Token(Token = "0x40009F5")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
