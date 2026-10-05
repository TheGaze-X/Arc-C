using System;
using Il2CppDummyDll;
using Torappu.Resource;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Loading
{
	// Token: 0x020049EE RID: 18926
	[Token(Token = "0x20049EE")]
	public class CommonLoadingController : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700436A RID: 17258
		// (get) Token: 0x0601C7F6 RID: 116726 RVA: 0x000A88E8 File Offset: 0x000A6AE8
		[Token(Token = "0x1700436A")]
		public bool isShowing
		{
			[Token(Token = "0x601C7F6")]
			[Address(RVA = "0x15F32B0", Offset = "0x15F1EB0", VA = "0x1815F32B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601C7F7 RID: 116727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C7F7")]
		[Address(RVA = "0x15F3090", Offset = "0x15F1C90", VA = "0x1815F3090")]
		private string _GetLoadingIllustId(string illustId)
		{
			return null;
		}

		// Token: 0x0601C7F8 RID: 116728 RVA: 0x000A8900 File Offset: 0x000A6B00
		[Token(Token = "0x601C7F8")]
		[Address(RVA = "0x15F3170", Offset = "0x15F1D70", VA = "0x1815F3170")]
		private TipData.Category _GetTipCategoryMask()
		{
			return TipData.Category.NONE;
		}

		// Token: 0x0601C7F9 RID: 116729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7F9")]
		[Address(RVA = "0x15F2D40", Offset = "0x15F1940", VA = "0x1815F2D40")]
		public void Show(string loadingIllust)
		{
		}

		// Token: 0x0601C7FA RID: 116730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7FA")]
		[Address(RVA = "0x15F2C80", Offset = "0x15F1880", VA = "0x1815F2C80")]
		public void Hide()
		{
		}

		// Token: 0x0601C7FB RID: 116731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C7FB")]
		[Address(RVA = "0x15F3210", Offset = "0x15F1E10", VA = "0x1815F3210")]
		public CommonLoadingController()
		{
		}

		// Token: 0x04025550 RID: 152912
		[Token(Token = "0x4025550")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _illust;

		// Token: 0x04025551 RID: 152913
		[Token(Token = "0x4025551")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UITipsHolder _tipsHolder;

		// Token: 0x04025552 RID: 152914
		[Token(Token = "0x4025552")]
		[FieldOffset(Offset = "0x28")]
		private DirectAssetLoader m_assetLoader;

		// Token: 0x04025553 RID: 152915
		[Token(Token = "0x4025553")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isShowing;

		// Token: 0x04025554 RID: 152916
		[Token(Token = "0x4025554")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShowing;

		// Token: 0x04025555 RID: 152917
		[Token(Token = "0x4025555")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetLoadingIllustId;

		// Token: 0x04025556 RID: 152918
		[Token(Token = "0x4025556")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetTipCategoryMask;

		// Token: 0x04025557 RID: 152919
		[Token(Token = "0x4025557")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04025558 RID: 152920
		[Token(Token = "0x4025558")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04025559 RID: 152921
		[Token(Token = "0x4025559")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
