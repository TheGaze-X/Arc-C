using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200457E RID: 17790
	[Token(Token = "0x200457E")]
	public abstract class RoguelikeTopicModeViewModelExtension : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B15D RID: 110941
		[Token(Token = "0x601B15D")]
		public abstract void Load(RoguelikeTopicModeViewModel mainModel);

		// Token: 0x0601B15E RID: 110942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B15E")]
		[Address(RVA = "0x14391D0", Offset = "0x1437DD0", VA = "0x1814391D0")]
		protected RoguelikeTopicModeViewModelExtension()
		{
		}

		// Token: 0x04022D56 RID: 142678
		[Token(Token = "0x4022D56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
