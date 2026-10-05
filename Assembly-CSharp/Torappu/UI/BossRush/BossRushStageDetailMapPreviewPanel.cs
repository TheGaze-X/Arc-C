using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061BB RID: 25019
	[Token(Token = "0x20061BB")]
	public class BossRushStageDetailMapPreviewPanel : DataBinder<BossRushStageDetailProperty>, IHotfixable
	{
		// Token: 0x17005532 RID: 21810
		// (get) Token: 0x060241A6 RID: 147878 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060241A7 RID: 147879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005532")]
		public Action<bool> onMapPreviewPanelClick
		{
			[Token(Token = "0x60241A6")]
			[Address(RVA = "0x1EC7950", Offset = "0x1EC6550", VA = "0x181EC7950")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60241A7")]
			[Address(RVA = "0x1EC79B0", Offset = "0x1EC65B0", VA = "0x181EC79B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060241A8 RID: 147880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241A8")]
		[Address(RVA = "0x1EC7560", Offset = "0x1EC6160", VA = "0x181EC7560", Slot = "7")]
		public override void OnValueChanged(BossRushStageDetailProperty property)
		{
		}

		// Token: 0x060241A9 RID: 147881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241A9")]
		[Address(RVA = "0x1EC7490", Offset = "0x1EC6090", VA = "0x181EC7490")]
		public void OnClick()
		{
		}

		// Token: 0x060241AA RID: 147882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241AA")]
		[Address(RVA = "0x1EC77C0", Offset = "0x1EC63C0", VA = "0x181EC77C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060241AB RID: 147883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241AB")]
		[Address(RVA = "0x1EC78E0", Offset = "0x1EC64E0", VA = "0x181EC78E0")]
		public BossRushStageDetailMapPreviewPanel()
		{
		}

		// Token: 0x040322E9 RID: 205545
		[Token(Token = "0x40322E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgPreview;

		// Token: 0x040322EA RID: 205546
		[Token(Token = "0x40322EA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIReentrantFloatPanel _panel;

		// Token: 0x040322EC RID: 205548
		[Token(Token = "0x40322EC")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x040322ED RID: 205549
		[Token(Token = "0x40322ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onMapPreviewPanelClick;

		// Token: 0x040322EE RID: 205550
		[Token(Token = "0x40322EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onMapPreviewPanelClick;

		// Token: 0x040322EF RID: 205551
		[Token(Token = "0x40322EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040322F0 RID: 205552
		[Token(Token = "0x40322F0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040322F1 RID: 205553
		[Token(Token = "0x40322F1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040322F2 RID: 205554
		[Token(Token = "0x40322F2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
