using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C03 RID: 19459
	[Token(Token = "0x2004C03")]
	[CreateAssetMenu(menuName = "Torappu/UI/Business/HomeBg/HomeBackgroundAssetsWrapper")]
	public class HomeBackgroundAssetsWrapper : ScriptableObject, IHotfixable
	{
		// Token: 0x0601D3B6 RID: 119734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3B6")]
		[Address(RVA = "0x16C6D10", Offset = "0x16C5910", VA = "0x1816C6D10")]
		public HomeBackgroundAssetsWrapper()
		{
		}

		// Token: 0x04026696 RID: 157334
		[Token(Token = "0x4026696")]
		[FieldOffset(Offset = "0x18")]
		public GameObject effectCamera;

		// Token: 0x04026697 RID: 157335
		[Token(Token = "0x4026697")]
		[FieldOffset(Offset = "0x20")]
		public GameObject effectFront;

		// Token: 0x04026698 RID: 157336
		[Token(Token = "0x4026698")]
		[FieldOffset(Offset = "0x28")]
		public GameObject effectBg;

		// Token: 0x04026699 RID: 157337
		[Token(Token = "0x4026699")]
		[FieldOffset(Offset = "0x30")]
		public GameObject playerView;

		// Token: 0x0402669A RID: 157338
		[Token(Token = "0x402669A")]
		[FieldOffset(Offset = "0x38")]
		public List<BackgroundFormAssetWrapper> backgroundForms;

		// Token: 0x0402669B RID: 157339
		[Token(Token = "0x402669B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
