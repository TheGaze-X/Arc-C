using System;
using HGSDK.V2;
using Il2CppDummyDll;
using Torappu;
using Torappu.SDK;
using UnityEngine;
using XLua;

namespace HGSDK
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	public class HGSDKRouter : MonoBehaviour, ISDKRouter, IHotfixable
	{
		// Token: 0x0600058E RID: 1422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1029C00", Offset = "0x1028800", VA = "0x181029C00", Slot = "4")]
		public ISDKBase GetSDKInst()
		{
			return null;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1029C60", Offset = "0x1028860", VA = "0x181029C60")]
		public HGSDKRouter()
		{
		}

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Obsolete("HGSDKV1 has been deprecated.")]
		private HGSDK _sdkV1;

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HGSDKV2 _sdkV2;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSDKInst;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
