using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200414D RID: 16717
	[Token(Token = "0x200414D")]
	public class SandboxV2BasementUpgradePreviewGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019D15 RID: 105749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D15")]
		[Address(RVA = "0x12A45A0", Offset = "0x12A31A0", VA = "0x1812A45A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019D16 RID: 105750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D16")]
		[Address(RVA = "0x12A4300", Offset = "0x12A2F00", VA = "0x1812A4300")]
		public void Render(ILoadAsset assetLoader, SandboxV2BasementUpgradePreviewGroupViewModel groupViewModel)
		{
		}

		// Token: 0x06019D17 RID: 105751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D17")]
		[Address(RVA = "0x12A46B0", Offset = "0x12A32B0", VA = "0x1812A46B0")]
		public SandboxV2BasementUpgradePreviewGroupView()
		{
		}

		// Token: 0x0402068F RID: 132751
		[Token(Token = "0x402068F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _groupIcon;

		// Token: 0x04020690 RID: 132752
		[Token(Token = "0x4020690")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _itemContent;

		// Token: 0x04020691 RID: 132753
		[Token(Token = "0x4020691")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _groupTitle;

		// Token: 0x04020692 RID: 132754
		[Token(Token = "0x4020692")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2BasementUpgradePreviewGroupView.UpgradePreviewItemAdapter m_adapter;

		// Token: 0x04020693 RID: 132755
		[Token(Token = "0x4020693")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04020694 RID: 132756
		[Token(Token = "0x4020694")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020695 RID: 132757
		[Token(Token = "0x4020695")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020696 RID: 132758
		[Token(Token = "0x4020696")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200414E RID: 16718
		[Token(Token = "0x200414E")]
		public class UpgradePreviewItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003D85 RID: 15749
			// (get) Token: 0x06019D18 RID: 105752 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06019D19 RID: 105753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003D85")]
			public List<SandboxV2BaseFunctionPreviewData> dataSet
			{
				[Token(Token = "0x6019D18")]
				[Address(RVA = "0x12B6CC0", Offset = "0x12B58C0", VA = "0x1812B6CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6019D19")]
				[Address(RVA = "0x12B6D20", Offset = "0x12B5920", VA = "0x1812B6D20")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17003D86 RID: 15750
			// (get) Token: 0x06019D1A RID: 105754 RVA: 0x0009F690 File Offset: 0x0009D890
			[Token(Token = "0x17003D86")]
			public override int count
			{
				[Token(Token = "0x6019D1A")]
				[Address(RVA = "0x12B6C00", Offset = "0x12B5800", VA = "0x1812B6C00", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019D1B RID: 105755 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019D1B")]
			[Address(RVA = "0x12B69C0", Offset = "0x12B55C0", VA = "0x1812B69C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06019D1C RID: 105756 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019D1C")]
			[Address(RVA = "0x12B6BA0", Offset = "0x12B57A0", VA = "0x1812B6BA0")]
			public UpgradePreviewItemAdapter()
			{
			}

			// Token: 0x04020698 RID: 132760
			[Token(Token = "0x4020698")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x04020699 RID: 132761
			[Token(Token = "0x4020699")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x0402069A RID: 132762
			[Token(Token = "0x402069A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402069B RID: 132763
			[Token(Token = "0x402069B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402069C RID: 132764
			[Token(Token = "0x402069C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
