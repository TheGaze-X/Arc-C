using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	public class TargetPosCalculator : IHotfixable
	{
		// Token: 0x060008BD RID: 2237 RVA: 0x000070DC File Offset: 0x000052DC
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x5535140", Offset = "0x5533D40", VA = "0x185535140")]
		public bool PrepareSelf(GameObject curTarget, RectTransform transLocal)
		{
			return default(bool);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x000070F4 File Offset: 0x000052F4
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x5535830", Offset = "0x5534430", VA = "0x185535830")]
		private bool _PrepareForNewTarget(GameObject target)
		{
			return default(bool);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0000710C File Offset: 0x0000530C
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x5535AB0", Offset = "0x55346B0", VA = "0x185535AB0")]
		private bool _PrepareForTransLocal(RectTransform transLocal)
		{
			return default(bool);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00007124 File Offset: 0x00005324
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x5534D40", Offset = "0x5533940", VA = "0x185534D40")]
		public Bounds CalcTargetItemBounds()
		{
			return default(Bounds);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0000713C File Offset: 0x0000533C
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x5535370", Offset = "0x5533F70", VA = "0x185535370")]
		private static Bounds _CalcTargetInSameCamera(RectTransform target, RectTransform local)
		{
			return default(Bounds);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00007154 File Offset: 0x00005354
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x5535540", Offset = "0x5534140", VA = "0x185535540")]
		private static Bounds _CalcTargetWithDiffCamera(RectTransform target, Camera targetCamera, RectTransform local, Camera localCamera)
		{
			return default(Bounds);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x5535C10", Offset = "0x5534810", VA = "0x185535C10")]
		public TargetPosCalculator()
		{
		}

		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isTransLocalConformed;

		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		[FieldOffset(Offset = "0x18")]
		private Camera m_selfCamera;

		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_transLocal;

		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0x28")]
		private Camera m_targetCamera;

		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x30")]
		private GameObject m_target;

		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform m_transTarget;

		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x40007FC")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate171 __Hotfix0_PrepareSelf;

		// Token: 0x040007FD RID: 2045
		[Token(Token = "0x40007FD")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate154 __Hotfix0__PrepareForNewTarget;

		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate154 __Hotfix0__PrepareForTransLocal;

		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate100 __Hotfix0_CalcTargetItemBounds;

		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate96 __Hotfix0__CalcTargetInSameCamera;

		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate172 __Hotfix0__CalcTargetWithDiffCamera;

		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
