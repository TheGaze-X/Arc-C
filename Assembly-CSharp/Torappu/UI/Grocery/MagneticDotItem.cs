using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D35 RID: 19765
	[Token(Token = "0x2004D35")]
	public class MagneticDotItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D971 RID: 121201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D971")]
		[Address(RVA = "0x1733900", Offset = "0x1732500", VA = "0x181733900")]
		public void Render(MagneticDotItemViewModel dotInfo)
		{
		}

		// Token: 0x0601D972 RID: 121202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D972")]
		[Address(RVA = "0x17339A0", Offset = "0x17325A0", VA = "0x1817339A0")]
		public MagneticDotItem()
		{
		}

		// Token: 0x0402713B RID: 160059
		[Token(Token = "0x402713B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objDotLight;

		// Token: 0x0402713C RID: 160060
		[Token(Token = "0x402713C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objDotUnLight;

		// Token: 0x0402713D RID: 160061
		[Token(Token = "0x402713D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402713E RID: 160062
		[Token(Token = "0x402713E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
