using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x02005903 RID: 22787
	[Token(Token = "0x2005903")]
	public abstract class CrossAppShareStartBaseLayoutElement : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004DF1 RID: 19953
		// (get) Token: 0x06021352 RID: 136018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004DF1")]
		public string elementKey
		{
			[Token(Token = "0x6021352")]
			[Address(RVA = "0x1B9AED0", Offset = "0x1B99AD0", VA = "0x181B9AED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021353 RID: 136019
		[Token(Token = "0x6021353")]
		public abstract CrossAppShareElementModelCollector GetElementModelCollector();

		// Token: 0x06021354 RID: 136020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021354")]
		[Address(RVA = "0x1B9AE70", Offset = "0x1B99A70", VA = "0x181B9AE70")]
		protected CrossAppShareStartBaseLayoutElement()
		{
		}

		// Token: 0x0402D3BA RID: 185274
		[Token(Token = "0x402D3BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _elementKey;

		// Token: 0x0402D3BB RID: 185275
		[Token(Token = "0x402D3BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_elementKey;

		// Token: 0x0402D3BC RID: 185276
		[Token(Token = "0x402D3BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
