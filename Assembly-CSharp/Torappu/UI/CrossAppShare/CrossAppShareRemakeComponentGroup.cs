using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058F7 RID: 22775
	[Token(Token = "0x20058F7")]
	public class CrossAppShareRemakeComponentGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021339 RID: 135993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021339")]
		[Address(RVA = "0x1B76290", Offset = "0x1B74E90", VA = "0x181B76290")]
		public void ApplyComponents(Dictionary<string, CrossAppShareComponentBaseModel> compModelDict, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602133A RID: 135994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602133A")]
		[Address(RVA = "0x1B76550", Offset = "0x1B75150", VA = "0x181B76550")]
		public CrossAppShareRemakeComponentGroup()
		{
		}

		// Token: 0x0402D394 RID: 185236
		[Token(Token = "0x402D394")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CrossAppShareRemakeBaseComponent> _elements;

		// Token: 0x0402D395 RID: 185237
		[Token(Token = "0x402D395")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponents;

		// Token: 0x0402D396 RID: 185238
		[Token(Token = "0x402D396")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
