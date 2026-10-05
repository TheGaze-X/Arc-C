using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x20001D6")]
	public class HGSDKSettingNotifyView : UINotifyView<HGSDKSettingNotifyView.Params>
	{
		// Token: 0x0600082C RID: 2092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x252FB20", Offset = "0x252E720", VA = "0x18252FB20", Slot = "9")]
		protected override void Render(HGSDKSettingNotifyView.Params param)
		{
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x252FC30", Offset = "0x252E830", VA = "0x18252FC30")]
		public HGSDKSettingNotifyView()
		{
		}

		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4000A64")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _sucPanel;

		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _sucTextContent;

		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _failPanel;

		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4000A67")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _failTextContent;

		// Token: 0x04000A68 RID: 2664
		[Token(Token = "0x4000A68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4000A69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020001D7 RID: 471
		[Token(Token = "0x20001D7")]
		public class Params : NotifyViewParam
		{
			// Token: 0x0600082E RID: 2094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Params()
			{
			}

			// Token: 0x04000A6A RID: 2666
			[Token(Token = "0x4000A6A")]
			[FieldOffset(Offset = "0x10")]
			public string alertContent;

			// Token: 0x04000A6B RID: 2667
			[Token(Token = "0x4000A6B")]
			[FieldOffset(Offset = "0x18")]
			public bool isSuc;
		}
	}
}
