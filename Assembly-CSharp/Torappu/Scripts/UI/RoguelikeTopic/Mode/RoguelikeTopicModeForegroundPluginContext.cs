using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.Scripts.UI.RoguelikeTopic.Mode
{
	// Token: 0x020017A1 RID: 6049
	[Token(Token = "0x20017A1")]
	public abstract class RoguelikeTopicModeForegroundPluginContext : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x060098E8 RID: 39144 RVA: 0x0003B880 File Offset: 0x00039A80
		[Token(Token = "0x17001071")]
		public virtual bool isExploreLock
		{
			[Token(Token = "0x60098E8")]
			[Address(RVA = "0x3148390", Offset = "0x3146F90", VA = "0x183148390", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060098E9 RID: 39145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098E9")]
		[Address(RVA = "0x31482D0", Offset = "0x3146ED0", VA = "0x1831482D0", Slot = "5")]
		public virtual void RefreshData(RoguelikeTopicModeViewModel topicModeViewModel)
		{
		}

		// Token: 0x060098EA RID: 39146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098EA")]
		[Address(RVA = "0x3148330", Offset = "0x3146F30", VA = "0x183148330")]
		protected RoguelikeTopicModeForegroundPluginContext()
		{
		}

		// Token: 0x04008EF0 RID: 36592
		[Token(Token = "0x4008EF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isExploreLock;

		// Token: 0x04008EF1 RID: 36593
		[Token(Token = "0x4008EF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04008EF2 RID: 36594
		[Token(Token = "0x4008EF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
