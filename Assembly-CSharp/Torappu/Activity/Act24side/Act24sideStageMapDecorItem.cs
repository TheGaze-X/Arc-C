using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075A0 RID: 30112
	[Token(Token = "0x20075A0")]
	public class Act24sideStageMapDecorItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A5FB RID: 173563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5FB")]
		[Address(RVA = "0x261A240", Offset = "0x2618E40", VA = "0x18261A240")]
		public void Render(Act24sideMeldingSmallItemViewModel viewModel, ILoadAsset assetLoader, string actId)
		{
		}

		// Token: 0x0602A5FC RID: 173564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5FC")]
		[Address(RVA = "0x261A390", Offset = "0x2618F90", VA = "0x18261A390")]
		public Act24sideStageMapDecorItem()
		{
		}

		// Token: 0x0403CF62 RID: 249698
		[Token(Token = "0x403CF62")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act24sideMeldingSmallItemView _viewPrefab;

		// Token: 0x0403CF63 RID: 249699
		[Token(Token = "0x403CF63")]
		[FieldOffset(Offset = "0x20")]
		private Act24sideMeldingSmallItemView m_viewObj;

		// Token: 0x0403CF64 RID: 249700
		[Token(Token = "0x403CF64")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CF65 RID: 249701
		[Token(Token = "0x403CF65")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
