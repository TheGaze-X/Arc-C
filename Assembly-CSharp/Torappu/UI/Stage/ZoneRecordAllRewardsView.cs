using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069DB RID: 27099
	[Token(Token = "0x20069DB")]
	public class ZoneRecordAllRewardsView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026C3C RID: 158780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C3C")]
		[Address(RVA = "0x21DC870", Offset = "0x21DB470", VA = "0x1821DC870")]
		public void RenderView(ZoneRecordGroupViewModel viewModel)
		{
		}

		// Token: 0x06026C3D RID: 158781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C3D")]
		[Address(RVA = "0x21DC990", Offset = "0x21DB590", VA = "0x1821DC990")]
		public ZoneRecordAllRewardsView()
		{
		}

		// Token: 0x04036C13 RID: 224275
		[Token(Token = "0x4036C13")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _easyIcon;

		// Token: 0x04036C14 RID: 224276
		[Token(Token = "0x4036C14")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _normalIcon;

		// Token: 0x04036C15 RID: 224277
		[Token(Token = "0x4036C15")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _toughIcon;

		// Token: 0x04036C16 RID: 224278
		[Token(Token = "0x4036C16")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ZoneRecordAllRewardAdapter _adapter;

		// Token: 0x04036C17 RID: 224279
		[Token(Token = "0x4036C17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04036C18 RID: 224280
		[Token(Token = "0x4036C18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
