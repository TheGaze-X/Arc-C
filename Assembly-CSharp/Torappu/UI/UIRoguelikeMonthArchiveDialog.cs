using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A98 RID: 15000
	[Token(Token = "0x2003A98")]
	public class UIRoguelikeMonthArchiveDialog : UICustomDialog<UIRoguelikeMonthArchiveDialog.Options>
	{
		// Token: 0x06017B50 RID: 97104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B50")]
		[Address(RVA = "0xFF69A0", Offset = "0xFF55A0", VA = "0x180FF69A0", Slot = "7")]
		protected override void OnRender(UIRoguelikeMonthArchiveDialog.Options options)
		{
		}

		// Token: 0x06017B51 RID: 97105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B51")]
		[Address(RVA = "0xFF6930", Offset = "0xFF5530", VA = "0x180FF6930")]
		public void OnCancelClicked()
		{
		}

		// Token: 0x06017B52 RID: 97106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B52")]
		[Address(RVA = "0xFF6B80", Offset = "0xFF5780", VA = "0x180FF6B80")]
		public UIRoguelikeMonthArchiveDialog()
		{
		}

		// Token: 0x0401C9B9 RID: 117177
		[Token(Token = "0x401C9B9")]
		private const string ANIM_NAME = "month_archive";

		// Token: 0x0401C9BA RID: 117178
		[Token(Token = "0x401C9BA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _archieveDesc;

		// Token: 0x0401C9BB RID: 117179
		[Token(Token = "0x401C9BB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationWrapper _animation;

		// Token: 0x0401C9BC RID: 117180
		[Token(Token = "0x401C9BC")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_tween;

		// Token: 0x0401C9BD RID: 117181
		[Token(Token = "0x401C9BD")]
		[FieldOffset(Offset = "0x68")]
		private Action m_onConfirm;

		// Token: 0x0401C9BE RID: 117182
		[Token(Token = "0x401C9BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401C9BF RID: 117183
		[Token(Token = "0x401C9BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCancelClicked;

		// Token: 0x0401C9C0 RID: 117184
		[Token(Token = "0x401C9C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003A99 RID: 15001
		[Token(Token = "0x2003A99")]
		public struct Options
		{
			// Token: 0x0401C9C1 RID: 117185
			[Token(Token = "0x401C9C1")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0401C9C2 RID: 117186
			[Token(Token = "0x401C9C2")]
			[FieldOffset(Offset = "0x8")]
			public string chatDesc;

			// Token: 0x0401C9C3 RID: 117187
			[Token(Token = "0x401C9C3")]
			[FieldOffset(Offset = "0x10")]
			public Action onConfirm;
		}
	}
}
