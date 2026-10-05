using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace YostarSDKV2
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public class YostarV2DiamondDetailDialog : UICustomDialog<YostarV2DiamondDetailDialog.Options>
	{
		// Token: 0x060002AB RID: 683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x522F50", Offset = "0x521B50", VA = "0x180522F50", Slot = "7")]
		protected override void OnRender(YostarV2DiamondDetailDialog.Options options)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x522EC0", Offset = "0x521AC0", VA = "0x180522EC0")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x523160", Offset = "0x521D60", VA = "0x180523160")]
		public YostarV2DiamondDetailDialog()
		{
		}

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDiamond;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textPayDiamond;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textFreeDiamond;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _btnClose;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIBlurFloatPanel _blurBkg;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000097 RID: 151
		[Token(Token = "0x2000097")]
		public class Options
		{
			// Token: 0x060002AE RID: 686 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x040002F1 RID: 753
			[Token(Token = "0x40002F1")]
			[FieldOffset(Offset = "0x10")]
			public int diamond;

			// Token: 0x040002F2 RID: 754
			[Token(Token = "0x40002F2")]
			[FieldOffset(Offset = "0x14")]
			public int payDiamond;

			// Token: 0x040002F3 RID: 755
			[Token(Token = "0x40002F3")]
			[FieldOffset(Offset = "0x18")]
			public int freeDiamond;
		}
	}
}
