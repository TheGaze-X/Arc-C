using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069EF RID: 27119
	[Token(Token = "0x20069EF")]
	public class ZoneRecordRewardBuffDialog : UICustomDialog<ZoneRecordRewardBuffDialog.Options>
	{
		// Token: 0x06026C80 RID: 158848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C80")]
		[Address(RVA = "0x21E1F50", Offset = "0x21E0B50", VA = "0x1821E1F50", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x06026C81 RID: 158849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C81")]
		[Address(RVA = "0x21E2070", Offset = "0x21E0C70", VA = "0x1821E2070", Slot = "7")]
		protected override void OnRender(ZoneRecordRewardBuffDialog.Options option)
		{
		}

		// Token: 0x06026C82 RID: 158850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C82")]
		[Address(RVA = "0x21E1EF0", Offset = "0x21E0AF0", VA = "0x1821E1EF0", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06026C83 RID: 158851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C83")]
		[Address(RVA = "0x21E1DD0", Offset = "0x21E09D0", VA = "0x1821E1DD0", Slot = "9")]
		protected override void BeforeDestroy()
		{
		}

		// Token: 0x06026C84 RID: 158852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C84")]
		[Address(RVA = "0x21E1E80", Offset = "0x21E0A80", VA = "0x1821E1E80")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x06026C85 RID: 158853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C85")]
		[Address(RVA = "0x21E2620", Offset = "0x21E1220", VA = "0x1821E2620")]
		public ZoneRecordRewardBuffDialog()
		{
		}

		// Token: 0x04036CA7 RID: 224423
		[Token(Token = "0x4036CA7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _outTime;

		// Token: 0x04036CA8 RID: 224424
		[Token(Token = "0x4036CA8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x04036CA9 RID: 224425
		[Token(Token = "0x4036CA9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _itemNameEng;

		// Token: 0x04036CAA RID: 224426
		[Token(Token = "0x4036CAA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _itemDesc;

		// Token: 0x04036CAB RID: 224427
		[Token(Token = "0x4036CAB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _itemHowUse;

		// Token: 0x04036CAC RID: 224428
		[Token(Token = "0x4036CAC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _itemHowGain;

		// Token: 0x04036CAD RID: 224429
		[Token(Token = "0x4036CAD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x04036CAE RID: 224430
		[Token(Token = "0x4036CAE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04036CAF RID: 224431
		[Token(Token = "0x4036CAF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x04036CB0 RID: 224432
		[Token(Token = "0x4036CB0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x04036CB1 RID: 224433
		[Token(Token = "0x4036CB1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04036CB2 RID: 224434
		[Token(Token = "0x4036CB2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04036CB3 RID: 224435
		[Token(Token = "0x4036CB3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04036CB4 RID: 224436
		[Token(Token = "0x4036CB4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BeforeDestroy;

		// Token: 0x04036CB5 RID: 224437
		[Token(Token = "0x4036CB5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x04036CB6 RID: 224438
		[Token(Token = "0x4036CB6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069F0 RID: 27120
		[Token(Token = "0x20069F0")]
		public struct Options
		{
			// Token: 0x04036CB7 RID: 224439
			[Token(Token = "0x4036CB7")]
			[FieldOffset(Offset = "0x0")]
			public ZoneRewardBuffViewModel viewModel;
		}
	}
}
