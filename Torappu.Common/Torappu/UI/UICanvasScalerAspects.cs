using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	public class UICanvasScalerAspects : CanvasScalerAspects, IHotfixable
	{
		// Token: 0x060007ED RID: 2029 RVA: 0x00006BE4 File Offset: 0x00004DE4
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x553FD00", Offset = "0x553E900", VA = "0x18553FD00")]
		private bool _HasStandaloneCanvasScalerInfo(CanvasScaler scaler, out bool result)
		{
			return default(bool);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00006BFC File Offset: 0x00004DFC
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x553FB90", Offset = "0x553E790", VA = "0x18553FB90")]
		private bool _HasOverrideStandaloneCanvasScalerInfo(CanvasScaler scaler, out float result)
		{
			return default(bool);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00006C14 File Offset: 0x00004E14
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x553F260", Offset = "0x553DE60", VA = "0x18553F260")]
		public float CalcFactorFloat(CanvasScaler scaler)
		{
			return 0f;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00006C2C File Offset: 0x00004E2C
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x553FAC0", Offset = "0x553E6C0", VA = "0x18553FAC0", Slot = "4")]
		public Vector2 ReferenceResolutionAfterScalerGetter(CanvasScaler scaler)
		{
			return default(Vector2);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x553F530", Offset = "0x553E130", VA = "0x18553F530", Slot = "5")]
		public void HandleOnEnable(CanvasScaler scaler)
		{
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x553F0C0", Offset = "0x553DCC0", VA = "0x18553F0C0")]
		public static void BindToUGUI()
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00006C44 File Offset: 0x00004E44
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x553FEC0", Offset = "0x553EAC0", VA = "0x18553FEC0", Slot = "6")]
		public bool isViewportSizeMatch(CanvasScaler scaler)
		{
			return default(bool);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x553F810", Offset = "0x553E410", VA = "0x18553F810", Slot = "7")]
		public void HandleScaleWithScreenSize(CanvasScaler scaler)
		{
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x553FE40", Offset = "0x553EA40", VA = "0x18553FE40")]
		public UICanvasScalerAspects()
		{
		}

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x0")]
		public static float DEFAULT_VALUE;

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x8")]
		public static UICanvasScalerAspects s_instance;

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate151 __Hotfix0__HasStandaloneCanvasScalerInfo;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate152 __Hotfix0__HasOverrideStandaloneCanvasScalerInfo;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate137 __Hotfix0_CalcFactorFloat;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate153 __Hotfix0_ReferenceResolutionAfterScalerGetter;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate0 __Hotfix0_HandleOnEnable;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate14 __Hotfix0_BindToUGUI;

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate154 __Hotfix0_isViewportSizeMatch;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate0 __Hotfix0_HandleScaleWithScreenSize;

		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
