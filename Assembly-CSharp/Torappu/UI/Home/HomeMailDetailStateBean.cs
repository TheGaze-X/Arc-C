using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BA6 RID: 19366
	[Token(Token = "0x2004BA6")]
	public class HomeMailDetailStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x0601D1FD RID: 119293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1FD")]
		[Address(RVA = "0x169D650", Offset = "0x169C250", VA = "0x18169D650")]
		public HomeMailDetailStateBean()
		{
		}

		// Token: 0x04026377 RID: 156535
		[Token(Token = "0x4026377")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public MailItemViewModel viewModel;

		// Token: 0x04026378 RID: 156536
		[Token(Token = "0x4026378")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public HomeMailIndex detailMailId;

		// Token: 0x04026379 RID: 156537
		[Token(Token = "0x4026379")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public GetMetaInfoListResponse cacheResponse;

		// Token: 0x0402637A RID: 156538
		[Token(Token = "0x402637A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
