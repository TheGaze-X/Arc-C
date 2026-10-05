using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public class OverrideStandaloneCanvasScalerInfo : MonoBehaviour, IHotfixable
	{
		// Token: 0x060007EB RID: 2027 RVA: 0x00006BCC File Offset: 0x00004DCC
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x5531980", Offset = "0x5530580", VA = "0x185531980")]
		public float GetScalerFactor()
		{
			return 0f;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x55319E0", Offset = "0x55305E0", VA = "0x1855319E0")]
		public OverrideStandaloneCanvasScalerInfo()
		{
		}

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _scalerFactor;

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate23 __Hotfix0_GetScalerFactor;

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
