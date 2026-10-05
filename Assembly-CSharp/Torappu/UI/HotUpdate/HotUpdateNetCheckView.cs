using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A7F RID: 19071
	[Token(Token = "0x2004A7F")]
	public class HotUpdateNetCheckView : UICustomDialog<HotUpdateNetCheckView.Options>, IHotfixable
	{
		// Token: 0x0601CA9F RID: 117407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CA9F")]
		[Address(RVA = "0x1623010", Offset = "0x1621C10", VA = "0x181623010", Slot = "7")]
		protected override void OnRender(HotUpdateNetCheckView.Options options)
		{
		}

		// Token: 0x0601CAA0 RID: 117408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAA0")]
		[Address(RVA = "0x1622F70", Offset = "0x1621B70", VA = "0x181622F70")]
		public void EventOnCopyClicked()
		{
		}

		// Token: 0x0601CAA1 RID: 117409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAA1")]
		[Address(RVA = "0x1622F00", Offset = "0x1621B00", VA = "0x181622F00")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x0601CAA2 RID: 117410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAA2")]
		[Address(RVA = "0x1623170", Offset = "0x1621D70", VA = "0x181623170")]
		public HotUpdateNetCheckView()
		{
		}

		// Token: 0x040259DC RID: 154076
		[Token(Token = "0x40259DC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textInfo;

		// Token: 0x040259DD RID: 154077
		[Token(Token = "0x40259DD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x040259DE RID: 154078
		[Token(Token = "0x40259DE")]
		[FieldOffset(Offset = "0x50")]
		private Action m_onDialogClosed;

		// Token: 0x040259DF RID: 154079
		[Token(Token = "0x40259DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040259E0 RID: 154080
		[Token(Token = "0x40259E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnCopyClicked;

		// Token: 0x040259E1 RID: 154081
		[Token(Token = "0x40259E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x040259E2 RID: 154082
		[Token(Token = "0x40259E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A80 RID: 19072
		[Token(Token = "0x2004A80")]
		public struct Options
		{
			// Token: 0x040259E3 RID: 154083
			[Token(Token = "0x40259E3")]
			[FieldOffset(Offset = "0x0")]
			public Action onDialogClosed;
		}
	}
}
