using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D58 RID: 15704
	[Token(Token = "0x2003D58")]
	public class TemplateShopCommonRightViewHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601875B RID: 100187 RVA: 0x0009A728 File Offset: 0x00098928
		[Token(Token = "0x601875B")]
		[Address(RVA = "0x10F1A20", Offset = "0x10F0620", VA = "0x1810F1A20")]
		public int GetBuyCount()
		{
			return 0;
		}

		// Token: 0x0601875C RID: 100188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601875C")]
		[Address(RVA = "0x10F1B40", Offset = "0x10F0740", VA = "0x1810F1B40")]
		public void RenderFirstTime()
		{
		}

		// Token: 0x0601875D RID: 100189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601875D")]
		[Address(RVA = "0x10F1BF0", Offset = "0x10F07F0", VA = "0x1810F1BF0")]
		public void Render(TemplateCommonShopGoodViewModel shopViewModel, bool isReplicate = false, int availCount = 0, [Optional] ItemBundle item)
		{
		}

		// Token: 0x0601875E RID: 100190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601875E")]
		[Address(RVA = "0x10F1DB0", Offset = "0x10F09B0", VA = "0x1810F1DB0")]
		public TemplateShopCommonRightViewHolder()
		{
		}

		// Token: 0x0401DF2A RID: 122666
		[Token(Token = "0x401DF2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TemplateShopCommonRightComplexView _complexView;

		// Token: 0x0401DF2B RID: 122667
		[Token(Token = "0x401DF2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TemplateShopCommonRightSingleView _singleView;

		// Token: 0x0401DF2C RID: 122668
		[Token(Token = "0x401DF2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TemplateCommonShopGoodViewModel m_cacheViewModel;

		// Token: 0x0401DF2D RID: 122669
		[Token(Token = "0x401DF2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBuyCount;

		// Token: 0x0401DF2E RID: 122670
		[Token(Token = "0x401DF2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderFirstTime;

		// Token: 0x0401DF2F RID: 122671
		[Token(Token = "0x401DF2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DF30 RID: 122672
		[Token(Token = "0x401DF30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
