using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003768 RID: 14184
	[Token(Token = "0x2003768")]
	public class UIStencilCutinCharMaterialChecker : UIStencilDefaultMaterialChecker
	{
		// Token: 0x0601685D RID: 92253 RVA: 0x00091758 File Offset: 0x0008F958
		[Token(Token = "0x601685D")]
		[Address(RVA = "0xF03F50", Offset = "0xF02B50", VA = "0x180F03F50", Slot = "6")]
		public override bool CheckMaterialExclusive(Material baseMat, List<Material> customList)
		{
			return default(bool);
		}

		// Token: 0x0601685E RID: 92254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601685E")]
		[Address(RVA = "0xF04000", Offset = "0xF02C00", VA = "0x180F04000")]
		public UIStencilCutinCharMaterialChecker()
		{
		}

		// Token: 0x0601685F RID: 92255 RVA: 0x00091770 File Offset: 0x0008F970
		[Token(Token = "0x601685F")]
		[Address(RVA = "0xF03FF0", Offset = "0xF02BF0", VA = "0x180F03FF0")]
		private bool <>xLuaBaseProxy_CheckMaterialExclusive(Material P0, List<Material> P1)
		{
			return default(bool);
		}

		// Token: 0x0401B221 RID: 111137
		[Token(Token = "0x401B221")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckMaterialExclusive;

		// Token: 0x0401B222 RID: 111138
		[Token(Token = "0x401B222")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
