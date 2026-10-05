using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A07 RID: 23047
	[Token(Token = "0x2005A07")]
	public class CrisisResourceBarHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021947 RID: 137543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021947")]
		[Address(RVA = "0x1C03BF0", Offset = "0x1C027F0", VA = "0x181C03BF0")]
		public void InitAndBind()
		{
		}

		// Token: 0x06021948 RID: 137544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021948")]
		[Address(RVA = "0x1C03F10", Offset = "0x1C02B10", VA = "0x181C03F10")]
		public void UnBind()
		{
		}

		// Token: 0x06021949 RID: 137545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021949")]
		[Address(RVA = "0x1C03EB0", Offset = "0x1C02AB0", VA = "0x181C03EB0")]
		private void OnEnable()
		{
		}

		// Token: 0x0602194A RID: 137546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602194A")]
		[Address(RVA = "0x1C03DE0", Offset = "0x1C029E0", VA = "0x181C03DE0")]
		private void OnDisable()
		{
		}

		// Token: 0x0602194B RID: 137547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602194B")]
		[Address(RVA = "0x1C03FB0", Offset = "0x1C02BB0", VA = "0x181C03FB0")]
		public CrisisResourceBarHolder()
		{
		}

		// Token: 0x0402DE33 RID: 187955
		[Token(Token = "0x402DE33")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0402DE34 RID: 187956
		[Token(Token = "0x402DE34")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrisisResourceBar _resourceBar;

		// Token: 0x0402DE35 RID: 187957
		[Token(Token = "0x402DE35")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CrisisResourceBar.Option _option;

		// Token: 0x0402DE36 RID: 187958
		[Token(Token = "0x402DE36")]
		[FieldOffset(Offset = "0x30")]
		private CrisisResourceBar m_resourceBar;

		// Token: 0x0402DE37 RID: 187959
		[Token(Token = "0x402DE37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitAndBind;

		// Token: 0x0402DE38 RID: 187960
		[Token(Token = "0x402DE38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UnBind;

		// Token: 0x0402DE39 RID: 187961
		[Token(Token = "0x402DE39")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402DE3A RID: 187962
		[Token(Token = "0x402DE3A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0402DE3B RID: 187963
		[Token(Token = "0x402DE3B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
