using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004710 RID: 18192
	[Token(Token = "0x2004710")]
	public class RecruitUpCharSlotSelectDialog : UICustomDialog<RecruitUpCharSlotSelectDialog.Options>
	{
		// Token: 0x0601B947 RID: 112967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B947")]
		[Address(RVA = "0x14EDE40", Offset = "0x14ECA40", VA = "0x1814EDE40", Slot = "7")]
		protected override void OnRender(RecruitUpCharSlotSelectDialog.Options options)
		{
		}

		// Token: 0x0601B948 RID: 112968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B948")]
		[Address(RVA = "0x14EDDE0", Offset = "0x14EC9E0", VA = "0x1814EDDE0", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601B949 RID: 112969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B949")]
		[Address(RVA = "0x14EE200", Offset = "0x14ECE00", VA = "0x1814EE200")]
		private void _EventOnSelectCharCardClick(int index)
		{
		}

		// Token: 0x0601B94A RID: 112970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B94A")]
		[Address(RVA = "0x14EE4D0", Offset = "0x14ED0D0", VA = "0x1814EE4D0")]
		private void _OpenChooseCharDialog(int index, RecruitUpCharSlotSelectViewModel.RecruitCharSlotCardDetail charSlotCardDetail)
		{
		}

		// Token: 0x0601B94B RID: 112971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B94B")]
		[Address(RVA = "0x14EE2B0", Offset = "0x14ECEB0", VA = "0x1814EE2B0")]
		private void _OnChooseCharFinished(int index, string charId)
		{
		}

		// Token: 0x0601B94C RID: 112972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B94C")]
		[Address(RVA = "0x14EE780", Offset = "0x14ED380", VA = "0x1814EE780")]
		private void _SendChoosePoolUpRequest(Dictionary<int, List<string>> charDict)
		{
		}

		// Token: 0x0601B94D RID: 112973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B94D")]
		[Address(RVA = "0x14EDBE0", Offset = "0x14EC7E0", VA = "0x1814EDBE0")]
		public void EventOnDetailBtnClick()
		{
		}

		// Token: 0x0601B94E RID: 112974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B94E")]
		[Address(RVA = "0x14EDD70", Offset = "0x14EC970", VA = "0x1814EDD70")]
		public void EventOnDialogClose()
		{
		}

		// Token: 0x0601B94F RID: 112975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B94F")]
		[Address(RVA = "0x14ED620", Offset = "0x14EC220", VA = "0x1814ED620")]
		public void EventOnConfirmBtnClick()
		{
		}

		// Token: 0x0601B950 RID: 112976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B950")]
		[Address(RVA = "0x14EE9B0", Offset = "0x14ED5B0", VA = "0x1814EE9B0")]
		public RecruitUpCharSlotSelectDialog()
		{
		}

		// Token: 0x04023B9E RID: 146334
		[Token(Token = "0x4023B9E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x04023B9F RID: 146335
		[Token(Token = "0x4023B9F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RecruitUpCharSlotSelectDialogView _dialogView;

		// Token: 0x04023BA0 RID: 146336
		[Token(Token = "0x4023BA0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _cancelBtn;

		// Token: 0x04023BA1 RID: 146337
		[Token(Token = "0x4023BA1")]
		[FieldOffset(Offset = "0x80")]
		private RecruitUpCharSlotSelectDialog.Options m_options;

		// Token: 0x04023BA2 RID: 146338
		[Token(Token = "0x4023BA2")]
		[FieldOffset(Offset = "0xB0")]
		private RecruitUpCharSlotSelectViewProperty m_property;

		// Token: 0x04023BA3 RID: 146339
		[Token(Token = "0x4023BA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04023BA4 RID: 146340
		[Token(Token = "0x4023BA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04023BA5 RID: 146341
		[Token(Token = "0x4023BA5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnSelectCharCardClick;

		// Token: 0x04023BA6 RID: 146342
		[Token(Token = "0x4023BA6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OpenChooseCharDialog;

		// Token: 0x04023BA7 RID: 146343
		[Token(Token = "0x4023BA7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnChooseCharFinished;

		// Token: 0x04023BA8 RID: 146344
		[Token(Token = "0x4023BA8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendChoosePoolUpRequest;

		// Token: 0x04023BA9 RID: 146345
		[Token(Token = "0x4023BA9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnDetailBtnClick;

		// Token: 0x04023BAA RID: 146346
		[Token(Token = "0x4023BAA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnDialogClose;

		// Token: 0x04023BAB RID: 146347
		[Token(Token = "0x4023BAB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnConfirmBtnClick;

		// Token: 0x04023BAC RID: 146348
		[Token(Token = "0x4023BAC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004711 RID: 18193
		[Token(Token = "0x2004711")]
		public struct Options
		{
			// Token: 0x04023BAD RID: 146349
			[Token(Token = "0x4023BAD")]
			[FieldOffset(Offset = "0x0")]
			public string gachaPoolId;

			// Token: 0x04023BAE RID: 146350
			[Token(Token = "0x4023BAE")]
			[FieldOffset(Offset = "0x8")]
			public List<string> rarity6CharIdList;

			// Token: 0x04023BAF RID: 146351
			[Token(Token = "0x4023BAF")]
			[FieldOffset(Offset = "0x10")]
			public List<string> rarity5CharIdList;

			// Token: 0x04023BB0 RID: 146352
			[Token(Token = "0x4023BB0")]
			[FieldOffset(Offset = "0x18")]
			public Action onConfirm;

			// Token: 0x04023BB1 RID: 146353
			[Token(Token = "0x4023BB1")]
			[FieldOffset(Offset = "0x20")]
			public string selectRulePoolTypeText;

			// Token: 0x04023BB2 RID: 146354
			[Token(Token = "0x4023BB2")]
			[FieldOffset(Offset = "0x28")]
			public string selectRulePoolRuleText;
		}
	}
}
