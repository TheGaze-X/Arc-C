using System;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C14 RID: 23572
	[Token(Token = "0x2005C14")]
	public class CommonCharSelectCharHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x060222CF RID: 139983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222CF")]
		[Address(RVA = "0x1CA9900", Offset = "0x1CA8500", VA = "0x181CA9900")]
		public void UpdateStatus(int index, TemplateCharSelectCardView.AsyncParam param, AsyncGameObjectLoader loader)
		{
		}

		// Token: 0x060222D0 RID: 139984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222D0")]
		[Address(RVA = "0x1CA9B00", Offset = "0x1CA8700", VA = "0x181CA9B00")]
		public CommonCharSelectCharHolder()
		{
		}

		// Token: 0x0402EDEA RID: 191978
		[Token(Token = "0x402EDEA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0402EDEB RID: 191979
		[Token(Token = "0x402EDEB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private uint _costPerObj;

		// Token: 0x0402EDEC RID: 191980
		[Token(Token = "0x402EDEC")]
		[FieldOffset(Offset = "0x28")]
		private AsyncDataViewHandler<TemplateCharSelectCardView, TemplateCharSelectCardView.AsyncParam> m_handler;

		// Token: 0x0402EDED RID: 191981
		[Token(Token = "0x402EDED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x0402EDEE RID: 191982
		[Token(Token = "0x402EDEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
