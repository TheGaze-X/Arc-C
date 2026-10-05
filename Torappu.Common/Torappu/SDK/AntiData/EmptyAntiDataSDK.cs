using System;
using System.Diagnostics;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SDK.AntiData
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	public class EmptyAntiDataSDK : ServiceAntiDataSDK
	{
		// Token: 0x06000A30 RID: 2608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x554F590", Offset = "0x554E190", VA = "0x18554F590", Slot = "6")]
		protected override byte[] GetData1()
		{
			return null;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x554F5F0", Offset = "0x554E1F0", VA = "0x18554F5F0", Slot = "7")]
		protected override byte[] GetData2()
		{
			return null;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0000776C File Offset: 0x0000596C
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x554F6C0", Offset = "0x554E2C0", VA = "0x18554F6C0", Slot = "8")]
		protected override bool IsData4Supported()
		{
			return default(bool);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x554F720", Offset = "0x554E320", VA = "0x18554F720", Slot = "9")]
		protected override void StartScanData4()
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00007784 File Offset: 0x00005984
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x554F520", Offset = "0x554E120", VA = "0x18554F520", Slot = "10")]
		protected override bool CheckData4(uint token)
		{
			return default(bool);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x554F650", Offset = "0x554E250", VA = "0x18554F650", Slot = "11")]
		protected override byte[] GetData4(uint token)
		{
			return null;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x554F960", Offset = "0x554E560", VA = "0x18554F960")]
		[Conditional("UNITY_EDITOR")]
		private static void _EditorOnlyMockBytes(ref byte[] data, float prob, int minLen, int maxLen, bool alphaBetaOnly)
		{
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x554F870", Offset = "0x554E470", VA = "0x18554F870")]
		[Conditional("UNITY_EDITOR")]
		private void _EditorOnlyData4Supported(ref bool enable)
		{
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x554FA00", Offset = "0x554E600", VA = "0x18554FA00")]
		[Conditional("UNITY_EDITOR")]
		private void _EditorOnlyStartScan()
		{
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x554F780", Offset = "0x554E380", VA = "0x18554F780")]
		[Conditional("UNITY_EDITOR")]
		private void _EditorOnlyCheckData4(ref bool ready)
		{
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x554F8E0", Offset = "0x554E4E0", VA = "0x18554F8E0")]
		[Conditional("UNITY_EDITOR")]
		private void _EditorOnlyGetData4(uint token, ref byte[] data)
		{
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x554FA60", Offset = "0x554E660", VA = "0x18554FA60")]
		public EmptyAntiDataSDK()
		{
		}

		// Token: 0x040009F6 RID: 2550
		[Token(Token = "0x40009F6")]
		[FieldOffset(Offset = "0x48")]
		private double m_dataReadyTs;

		// Token: 0x040009F7 RID: 2551
		[Token(Token = "0x40009F7")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate226 __Hotfix0_GetData1;

		// Token: 0x040009F8 RID: 2552
		[Token(Token = "0x40009F8")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate226 __Hotfix0_GetData2;

		// Token: 0x040009F9 RID: 2553
		[Token(Token = "0x40009F9")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate21 __Hotfix0_IsData4Supported;

		// Token: 0x040009FA RID: 2554
		[Token(Token = "0x40009FA")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0_StartScanData4;

		// Token: 0x040009FB RID: 2555
		[Token(Token = "0x40009FB")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate227 __Hotfix0_CheckData4;

		// Token: 0x040009FC RID: 2556
		[Token(Token = "0x40009FC")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate228 __Hotfix0_GetData4;

		// Token: 0x040009FD RID: 2557
		[Token(Token = "0x40009FD")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate229 __Hotfix0__EditorOnlyMockBytes;

		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate230 __Hotfix0__EditorOnlyData4Supported;

		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate1 __Hotfix0__EditorOnlyStartScan;

		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate230 __Hotfix0__EditorOnlyCheckData4;

		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate231 __Hotfix0__EditorOnlyGetData4;

		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
