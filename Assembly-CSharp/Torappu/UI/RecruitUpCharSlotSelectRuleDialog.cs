using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AFB RID: 15099
	[Token(Token = "0x2003AFB")]
	public class RecruitUpCharSlotSelectRuleDialog : UICustomDialog<RecruitUpCharSlotSelectRuleDialog.Options>
	{
		// Token: 0x06017CC3 RID: 97475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CC3")]
		[Address(RVA = "0x100AD30", Offset = "0x1009930", VA = "0x18100AD30", Slot = "7")]
		protected override void OnRender(RecruitUpCharSlotSelectRuleDialog.Options options)
		{
		}

		// Token: 0x06017CC4 RID: 97476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017CC4")]
		[Address(RVA = "0x100AC70", Offset = "0x1009870", VA = "0x18100AC70", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06017CC5 RID: 97477 RVA: 0x00098550 File Offset: 0x00096750
		[Token(Token = "0x6017CC5")]
		[Address(RVA = "0x100ACD0", Offset = "0x10098D0", VA = "0x18100ACD0", Slot = "11")]
		protected override bool IncludeNotificationCamaraForBlur()
		{
			return default(bool);
		}

		// Token: 0x06017CC6 RID: 97478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CC6")]
		[Address(RVA = "0x100AC00", Offset = "0x1009800", VA = "0x18100AC00")]
		public void EventOnDialogClose()
		{
		}

		// Token: 0x06017CC7 RID: 97479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CC7")]
		[Address(RVA = "0x100AFB0", Offset = "0x1009BB0", VA = "0x18100AFB0")]
		public RecruitUpCharSlotSelectRuleDialog()
		{
		}

		// Token: 0x0401CBF2 RID: 117746
		[Token(Token = "0x401CBF2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _poolTypeText;

		// Token: 0x0401CBF3 RID: 117747
		[Token(Token = "0x401CBF3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _poolRuleText;

		// Token: 0x0401CBF4 RID: 117748
		[Token(Token = "0x401CBF4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIRenderTextureImage _blurImage;

		// Token: 0x0401CBF5 RID: 117749
		[Token(Token = "0x401CBF5")]
		[FieldOffset(Offset = "0x68")]
		private RecruitUpCharSlotSelectRuleDialog.Options m_options;

		// Token: 0x0401CBF6 RID: 117750
		[Token(Token = "0x401CBF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401CBF7 RID: 117751
		[Token(Token = "0x401CBF7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401CBF8 RID: 117752
		[Token(Token = "0x401CBF8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IncludeNotificationCamaraForBlur;

		// Token: 0x0401CBF9 RID: 117753
		[Token(Token = "0x401CBF9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnDialogClose;

		// Token: 0x0401CBFA RID: 117754
		[Token(Token = "0x401CBFA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003AFC RID: 15100
		[Token(Token = "0x2003AFC")]
		public struct Options
		{
			// Token: 0x0401CBFB RID: 117755
			[Token(Token = "0x401CBFB")]
			[FieldOffset(Offset = "0x0")]
			public string poolTypeText;

			// Token: 0x0401CBFC RID: 117756
			[Token(Token = "0x401CBFC")]
			[FieldOffset(Offset = "0x8")]
			public string poolRuleText;

			// Token: 0x0401CBFD RID: 117757
			[Token(Token = "0x401CBFD")]
			[FieldOffset(Offset = "0x10")]
			public bool needIncludeNotificationCameraBlur;
		}
	}
}
