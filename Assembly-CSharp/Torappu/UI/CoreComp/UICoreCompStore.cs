using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CoreComp
{
	// Token: 0x02005A61 RID: 23137
	[Token(Token = "0x2005A61")]
	public class UICoreCompStore<TComp> : SingletonInScene<UICoreCompStore<TComp>> where TComp : MonoBehaviour
	{
		// Token: 0x06021AB5 RID: 137909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AB5")]
		private UICoreCompStore()
		{
		}

		// Token: 0x06021AB6 RID: 137910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AB6")]
		public void Register(TComp comp)
		{
		}

		// Token: 0x06021AB7 RID: 137911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AB7")]
		public void Unregister(TComp comp)
		{
		}

		// Token: 0x06021AB8 RID: 137912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021AB8")]
		public TComp FindCompFrom(Transform current)
		{
			return null;
		}

		// Token: 0x0402E071 RID: 188529
		[Token(Token = "0x402E071")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, WeakReference> m_store;

		// Token: 0x0402E072 RID: 188530
		[Token(Token = "0x402E072")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402E073 RID: 188531
		[Token(Token = "0x402E073")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x0402E074 RID: 188532
		[Token(Token = "0x402E074")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Unregister;

		// Token: 0x0402E075 RID: 188533
		[Token(Token = "0x402E075")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FindCompFrom;
	}
}
