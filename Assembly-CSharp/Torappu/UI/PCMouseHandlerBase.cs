using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003746 RID: 14150
	[Token(Token = "0x2003746")]
	public abstract class PCMouseHandlerBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x060167BD RID: 92093
		[Token(Token = "0x60167BD")]
		public abstract string GetId();

		// Token: 0x060167BE RID: 92094
		[Token(Token = "0x60167BE")]
		public abstract void InjectCanvas(Canvas uiCanvas);

		// Token: 0x060167BF RID: 92095
		[Token(Token = "0x60167BF")]
		public abstract void OnMouseMoveEvent();

		// Token: 0x060167C0 RID: 92096
		[Token(Token = "0x60167C0")]
		public abstract void OnMouseUpEvent();

		// Token: 0x060167C1 RID: 92097
		[Token(Token = "0x60167C1")]
		public abstract void OnMouseDownEvent();

		// Token: 0x060167C2 RID: 92098
		[Token(Token = "0x60167C2")]
		public abstract void SetScaler(float scaler);

		// Token: 0x060167C3 RID: 92099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167C3")]
		[Address(RVA = "0xEDBF10", Offset = "0xEDAB10", VA = "0x180EDBF10")]
		protected PCMouseHandlerBase()
		{
		}

		// Token: 0x0401B147 RID: 110919
		[Token(Token = "0x401B147")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
