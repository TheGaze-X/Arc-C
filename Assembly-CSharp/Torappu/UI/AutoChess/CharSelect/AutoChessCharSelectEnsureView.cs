using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063C3 RID: 25539
	[Token(Token = "0x20063C3")]
	public class AutoChessCharSelectEnsureView : TemplateCharSelectEnsureView
	{
		// Token: 0x06024D2C RID: 150828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D2C")]
		[Address(RVA = "0x1FB8B10", Offset = "0x1FB7710", VA = "0x181FB8B10")]
		public void EventOnClear()
		{
		}

		// Token: 0x06024D2D RID: 150829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D2D")]
		[Address(RVA = "0x1FB8BA0", Offset = "0x1FB77A0", VA = "0x181FB8BA0")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x06024D2E RID: 150830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D2E")]
		[Address(RVA = "0x1FB8C30", Offset = "0x1FB7830", VA = "0x181FB8C30", Slot = "10")]
		protected override void OnRenderViewModel(TemplateCharSelectMainViewModel templateModel)
		{
		}

		// Token: 0x06024D2F RID: 150831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D2F")]
		[Address(RVA = "0x1FB8E90", Offset = "0x1FB7A90", VA = "0x181FB8E90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024D30 RID: 150832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D30")]
		[Address(RVA = "0x1FB8F60", Offset = "0x1FB7B60", VA = "0x181FB8F60")]
		public AutoChessCharSelectEnsureView()
		{
		}

		// Token: 0x06024D31 RID: 150833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D31")]
		[Address(RVA = "0x1CACD40", Offset = "0x1CAB940", VA = "0x181CACD40")]
		private void <>xLuaBaseProxy_OnRenderViewModel(TemplateCharSelectMainViewModel P0)
		{
		}

		// Token: 0x040337B5 RID: 210869
		[Token(Token = "0x40337B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _clearBtn;

		// Token: 0x040337B6 RID: 210870
		[Token(Token = "0x40337B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _shuffleAnimation;

		// Token: 0x040337B7 RID: 210871
		[Token(Token = "0x40337B7")]
		[FieldOffset(Offset = "0x48")]
		private AnimationSwitchTween m_shuffleTween;

		// Token: 0x040337B8 RID: 210872
		[Token(Token = "0x40337B8")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040337B9 RID: 210873
		[Token(Token = "0x40337B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnClear;

		// Token: 0x040337BA RID: 210874
		[Token(Token = "0x40337BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x040337BB RID: 210875
		[Token(Token = "0x40337BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRenderViewModel;

		// Token: 0x040337BC RID: 210876
		[Token(Token = "0x40337BC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040337BD RID: 210877
		[Token(Token = "0x40337BD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
