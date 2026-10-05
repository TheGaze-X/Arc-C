using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058F5 RID: 22773
	[Token(Token = "0x20058F5")]
	public abstract class CrossAppShareRemakeBaseComponent : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004DEF RID: 19951
		// (get) Token: 0x06021334 RID: 135988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004DEF")]
		public string elementKey
		{
			[Token(Token = "0x6021334")]
			[Address(RVA = "0x1B75EB0", Offset = "0x1B74AB0", VA = "0x181B75EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021335 RID: 135989
		[Token(Token = "0x6021335")]
		public abstract void ApplyComponentModel(CrossAppShareComponentBaseModel model, ILoadAsset iLoadAsset);

		// Token: 0x06021336 RID: 135990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021336")]
		[Address(RVA = "0x1B75E50", Offset = "0x1B74A50", VA = "0x181B75E50")]
		protected CrossAppShareRemakeBaseComponent()
		{
		}

		// Token: 0x0402D38E RID: 185230
		[Token(Token = "0x402D38E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _elementKey;

		// Token: 0x0402D38F RID: 185231
		[Token(Token = "0x402D38F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_elementKey;

		// Token: 0x0402D390 RID: 185232
		[Token(Token = "0x402D390")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
