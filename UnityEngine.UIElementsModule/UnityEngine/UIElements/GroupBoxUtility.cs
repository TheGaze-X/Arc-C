using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	internal static class GroupBoxUtility
	{
		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		public static void RegisterGroupBoxOptionCallbacks<T>(this T option) where T : VisualElement, IGroupBoxOption
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		public static void OnOptionSelected<T>(this T selectedOption) where T : VisualElement, IGroupBoxOption
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x5A318E0", Offset = "0x5A304E0", VA = "0x185A318E0")]
		private static void OnOptionAttachToPanel(AttachToPanelEvent evt)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x5A31B50", Offset = "0x5A30750", VA = "0x185A31B50")]
		private static void OnOptionDetachFromPanel(DetachFromPanelEvent evt)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x5A312D0", Offset = "0x5A2FED0", VA = "0x185A312D0")]
		private static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox)
		{
			return null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x5A31810", Offset = "0x5A30410", VA = "0x185A31810")]
		private static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x5A31CD0", Offset = "0x5A308D0", VA = "0x185A31CD0")]
		private static void OnPanelDestroyed(BaseVisualElementPanel panel)
		{
		}

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<IGroupBox, IGroupManager> s_GroupManagers;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<IGroupBoxOption, IGroupManager> s_GroupOptionManagerCache;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Type k_GenericGroupBoxType;
	}
}
