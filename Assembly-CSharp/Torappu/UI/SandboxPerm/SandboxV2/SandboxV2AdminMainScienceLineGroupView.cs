using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040C7 RID: 16583
	[Token(Token = "0x20040C7")]
	public class SandboxV2AdminMainScienceLineGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019A69 RID: 105065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A69")]
		[Address(RVA = "0x1278220", Offset = "0x1276E20", VA = "0x181278220")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019A6A RID: 105066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A6A")]
		[Address(RVA = "0x1278040", Offset = "0x1276C40", VA = "0x181278040")]
		public void Render(List<SandboxV2ScienceLineSegmentModel> viewModel, SandboxV2AdminMainScienceType scienceType)
		{
		}

		// Token: 0x06019A6B RID: 105067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A6B")]
		[Address(RVA = "0x1278380", Offset = "0x1276F80", VA = "0x181278380")]
		public SandboxV2AdminMainScienceLineGroupView()
		{
		}

		// Token: 0x040200E3 RID: 131299
		[Token(Token = "0x40200E3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x040200E4 RID: 131300
		[Token(Token = "0x40200E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2AdminMainScienceLineItemView _lineItemPrefab;

		// Token: 0x040200E5 RID: 131301
		[Token(Token = "0x40200E5")]
		[FieldOffset(Offset = "0x28")]
		private SandboxV2AdminMainScienceLineGroupView.LineItemAdapter m_adapter;

		// Token: 0x040200E6 RID: 131302
		[Token(Token = "0x40200E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040200E7 RID: 131303
		[Token(Token = "0x40200E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040200E8 RID: 131304
		[Token(Token = "0x40200E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020040C8 RID: 16584
		[Token(Token = "0x20040C8")]
		private class LineItemAdapter : IHotfixable
		{
			// Token: 0x06019A6C RID: 105068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A6C")]
			[Address(RVA = "0x12729E0", Offset = "0x12715E0", VA = "0x1812729E0")]
			public LineItemAdapter(SandboxV2AdminMainScienceLineGroupView closure)
			{
			}

			// Token: 0x06019A6D RID: 105069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A6D")]
			[Address(RVA = "0x1272410", Offset = "0x1271010", VA = "0x181272410")]
			public void RefreshView(List<SandboxV2ScienceLineSegmentModel> viewModelList, SandboxV2AdminMainScienceType selectedType)
			{
			}

			// Token: 0x06019A6E RID: 105070 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019A6E")]
			[Address(RVA = "0x1272730", Offset = "0x1271330", VA = "0x181272730")]
			private SandboxV2AdminMainScienceLineItemView _GetView(int position)
			{
				return null;
			}

			// Token: 0x06019A6F RID: 105071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A6F")]
			[Address(RVA = "0x12727E0", Offset = "0x12713E0", VA = "0x1812727E0")]
			private void _UpdateViewInstance(int position, SandboxV2AdminMainScienceLineItemView view)
			{
			}

			// Token: 0x040200E9 RID: 131305
			[Token(Token = "0x40200E9")]
			[FieldOffset(Offset = "0x10")]
			private SandboxV2AdminMainScienceLineGroupView m_closure;

			// Token: 0x040200EA RID: 131306
			[Token(Token = "0x40200EA")]
			[FieldOffset(Offset = "0x18")]
			private List<SandboxV2AdminMainScienceLineItemView> m_views;

			// Token: 0x040200EB RID: 131307
			[Token(Token = "0x40200EB")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2AdminMainScienceType m_cachedType;

			// Token: 0x040200EC RID: 131308
			[Token(Token = "0x40200EC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040200ED RID: 131309
			[Token(Token = "0x40200ED")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RefreshView;

			// Token: 0x040200EE RID: 131310
			[Token(Token = "0x40200EE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__GetView;

			// Token: 0x040200EF RID: 131311
			[Token(Token = "0x40200EF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__UpdateViewInstance;
		}
	}
}
