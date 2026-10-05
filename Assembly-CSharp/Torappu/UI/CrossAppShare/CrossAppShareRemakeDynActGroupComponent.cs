using System;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058F8 RID: 22776
	[Token(Token = "0x20058F8")]
	public class CrossAppShareRemakeDynActGroupComponent : CrossAppShareRemakeBaseComponent<CrossAppShareCharActResDynModel>
	{
		// Token: 0x0602133B RID: 135995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602133B")]
		[Address(RVA = "0x1B76AC0", Offset = "0x1B756C0", VA = "0x181B76AC0", Slot = "5")]
		protected override void ApplyTypedModel(CrossAppShareCharActResDynModel model, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602133C RID: 135996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602133C")]
		[Address(RVA = "0x1B76BC0", Offset = "0x1B757C0", VA = "0x181B76BC0")]
		public CrossAppShareRemakeDynActGroupComponent()
		{
		}

		// Token: 0x0402D397 RID: 185239
		[Token(Token = "0x402D397")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActivityDynamicResGroup _resGroup;

		// Token: 0x0402D398 RID: 185240
		[Token(Token = "0x402D398")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyTypedModel;

		// Token: 0x0402D399 RID: 185241
		[Token(Token = "0x402D399")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
