using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200370B RID: 14091
	[Token(Token = "0x200370B")]
	public class UIGuidebookController : SingletonMonoBehaviour<UIGuidebookController>, ISingletonNotAutoCreate
	{
		// Token: 0x060165D9 RID: 91609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165D9")]
		[Address(RVA = "0xECF130", Offset = "0xECDD30", VA = "0x180ECF130")]
		public static void AddListener(UIGuidebookController.IGuidebookListener listener)
		{
		}

		// Token: 0x060165DA RID: 91610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165DA")]
		[Address(RVA = "0xECF470", Offset = "0xECE070", VA = "0x180ECF470")]
		public static void RemoveListener(UIGuidebookController.IGuidebookListener listener)
		{
		}

		// Token: 0x060165DB RID: 91611 RVA: 0x00090CA8 File Offset: 0x0008EEA8
		[Token(Token = "0x60165DB")]
		[Address(RVA = "0xECF240", Offset = "0xECDE40", VA = "0x180ECF240")]
		public static bool GuideOnlyNotifyAutoShow(UIGuideTarget target, string subsignal)
		{
			return default(bool);
		}

		// Token: 0x060165DC RID: 91612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165DC")]
		[Address(RVA = "0xECF560", Offset = "0xECE160", VA = "0x180ECF560")]
		public UIGuidebookController()
		{
		}

		// Token: 0x0401AE7A RID: 110202
		[Token(Token = "0x401AE7A")]
		[FieldOffset(Offset = "0x18")]
		private List<UIGuidebookController.IGuidebookListener> m_listeners;

		// Token: 0x0401AE7B RID: 110203
		[Token(Token = "0x401AE7B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AddListener;

		// Token: 0x0401AE7C RID: 110204
		[Token(Token = "0x401AE7C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RemoveListener;

		// Token: 0x0401AE7D RID: 110205
		[Token(Token = "0x401AE7D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GuideOnlyNotifyAutoShow;

		// Token: 0x0401AE7E RID: 110206
		[Token(Token = "0x401AE7E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200370C RID: 14092
		[Token(Token = "0x200370C")]
		public interface IGuidebookListener
		{
			// Token: 0x060165DD RID: 91613
			[Token(Token = "0x60165DD")]
			bool OnAutoShow(UIGuideTarget target, string subsignal);
		}
	}
}
