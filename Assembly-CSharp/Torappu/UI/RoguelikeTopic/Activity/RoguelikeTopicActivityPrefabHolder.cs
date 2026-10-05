using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity
{
	// Token: 0x02004698 RID: 18072
	[Token(Token = "0x2004698")]
	public class RoguelikeTopicActivityPrefabHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B6C6 RID: 112326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B6C6")]
		[Address(RVA = "0x14B1980", Offset = "0x14B0580", VA = "0x1814B1980")]
		public RoguelikeTopicActivityEntryComp GetEntryComp()
		{
			return null;
		}

		// Token: 0x0601B6C7 RID: 112327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B6C7")]
		[Address(RVA = "0x14B1920", Offset = "0x14B0520", VA = "0x1814B1920")]
		public RoguelikeTopicActivityPanel GetActivityPanel()
		{
			return null;
		}

		// Token: 0x0601B6C8 RID: 112328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6C8")]
		[Address(RVA = "0x14B19E0", Offset = "0x14B05E0", VA = "0x1814B19E0")]
		public RoguelikeTopicActivityPrefabHolder()
		{
		}

		// Token: 0x04023793 RID: 145299
		[Token(Token = "0x4023793")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeTopicActivityEntryComp _entryComp;

		// Token: 0x04023794 RID: 145300
		[Token(Token = "0x4023794")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeTopicActivityPanel _activityPanel;

		// Token: 0x04023795 RID: 145301
		[Token(Token = "0x4023795")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEntryComp;

		// Token: 0x04023796 RID: 145302
		[Token(Token = "0x4023796")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetActivityPanel;

		// Token: 0x04023797 RID: 145303
		[Token(Token = "0x4023797")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
