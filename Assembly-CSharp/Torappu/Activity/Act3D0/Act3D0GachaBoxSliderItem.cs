using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007403 RID: 29699
	[Token(Token = "0x2007403")]
	public class Act3D0GachaBoxSliderItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F1F RID: 171807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F1F")]
		[Address(RVA = "0x258B650", Offset = "0x258A250", VA = "0x18258B650")]
		public void OnFocus(int orderId)
		{
		}

		// Token: 0x06029F20 RID: 171808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F20")]
		[Address(RVA = "0x258B6E0", Offset = "0x258A2E0", VA = "0x18258B6E0")]
		public Act3D0GachaBoxSliderItem()
		{
		}

		// Token: 0x0403C1DC RID: 246236
		[Token(Token = "0x403C1DC")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public int order;

		// Token: 0x0403C1DD RID: 246237
		[Token(Token = "0x403C1DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _gachaBoxImg;

		// Token: 0x0403C1DE RID: 246238
		[Token(Token = "0x403C1DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFocus;

		// Token: 0x0403C1DF RID: 246239
		[Token(Token = "0x403C1DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
