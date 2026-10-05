using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058ED RID: 22765
	[Token(Token = "0x20058ED")]
	public abstract class CrossAppShareRemakeAdditionBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021314 RID: 135956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021314")]
		[Address(RVA = "0x1B75D90", Offset = "0x1B74990", VA = "0x181B75D90", Slot = "4")]
		public virtual void Render(ICrossAppShareRemakeAdditionBaseModel model)
		{
		}

		// Token: 0x06021315 RID: 135957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021315")]
		[Address(RVA = "0x1B75DF0", Offset = "0x1B749F0", VA = "0x181B75DF0")]
		protected CrossAppShareRemakeAdditionBaseView()
		{
		}

		// Token: 0x0402D366 RID: 185190
		[Token(Token = "0x402D366")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D367 RID: 185191
		[Token(Token = "0x402D367")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
