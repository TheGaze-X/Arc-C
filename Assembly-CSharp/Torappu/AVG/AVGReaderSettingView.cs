using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F3F RID: 7999
	[Token(Token = "0x2001F3F")]
	public class AVGReaderSettingView : MonoBehaviour, IAVGDataSubscriber<AVGStoryCache>, IHotfixable
	{
		// Token: 0x0600C6DA RID: 50906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6DA")]
		[Address(RVA = "0x34847A0", Offset = "0x34833A0", VA = "0x1834847A0")]
		public void SetClosure(AVGReaderSettingDialog closure)
		{
		}

		// Token: 0x0600C6DB RID: 50907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6DB")]
		[Address(RVA = "0x3484860", Offset = "0x3483460", VA = "0x183484860")]
		private void _BindEvent()
		{
		}

		// Token: 0x0600C6DC RID: 50908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6DC")]
		[Address(RVA = "0x3484A80", Offset = "0x3483680", VA = "0x183484A80")]
		private void _RenderWidgetStatus(AVGStoryCache viewModel)
		{
		}

		// Token: 0x0600C6DD RID: 50909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6DD")]
		[Address(RVA = "0x3484700", Offset = "0x3483300", VA = "0x183484700", Slot = "4")]
		public void OnValueChanged(AVGStoryCache cache)
		{
		}

		// Token: 0x0600C6DE RID: 50910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6DE")]
		[Address(RVA = "0x3484D00", Offset = "0x3483900", VA = "0x183484D00")]
		public AVGReaderSettingView()
		{
		}

		// Token: 0x0400CC68 RID: 52328
		[Token(Token = "0x400CC68")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ToggleGroupWatcher _fontSetting;

		// Token: 0x0400CC69 RID: 52329
		[Token(Token = "0x400CC69")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ToggleGroupWatcher _lineSpaceSetting;

		// Token: 0x0400CC6A RID: 52330
		[Token(Token = "0x400CC6A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ToggleGroupWatcher _bgAlphaSetting;

		// Token: 0x0400CC6B RID: 52331
		[Token(Token = "0x400CC6B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _showAvatarToggle;

		// Token: 0x0400CC6C RID: 52332
		[Token(Token = "0x400CC6C")]
		[FieldOffset(Offset = "0x38")]
		private AVGReaderSettingDialog m_closure;

		// Token: 0x0400CC6D RID: 52333
		[Token(Token = "0x400CC6D")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0400CC6E RID: 52334
		[Token(Token = "0x400CC6E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetClosure;

		// Token: 0x0400CC6F RID: 52335
		[Token(Token = "0x400CC6F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__BindEvent;

		// Token: 0x0400CC70 RID: 52336
		[Token(Token = "0x400CC70")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderWidgetStatus;

		// Token: 0x0400CC71 RID: 52337
		[Token(Token = "0x400CC71")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400CC72 RID: 52338
		[Token(Token = "0x400CC72")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
