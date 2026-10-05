using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.DataBind
{
	// Token: 0x0200148F RID: 5263
	[Token(Token = "0x200148F")]
	public abstract class DataBinder : MonoBehaviour, IHotfixable, IDataBinder
	{
		// Token: 0x060079B0 RID: 31152
		[Token(Token = "0x60079B0")]
		public abstract Type GetPropertyType();

		// Token: 0x060079B1 RID: 31153
		[Token(Token = "0x60079B1")]
		public abstract void OnValueChanged(object property);

		// Token: 0x060079B2 RID: 31154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079B2")]
		[Address(RVA = "0x2637430", Offset = "0x2636030", VA = "0x182637430")]
		protected DataBinder()
		{
		}

		// Token: 0x040077D0 RID: 30672
		[Token(Token = "0x40077D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected BindPosition m_bindPosition;

		// Token: 0x040077D1 RID: 30673
		[Token(Token = "0x40077D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
