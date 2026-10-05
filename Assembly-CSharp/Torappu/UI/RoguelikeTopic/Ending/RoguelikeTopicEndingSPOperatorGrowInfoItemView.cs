using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x0200468E RID: 18062
	[Token(Token = "0x200468E")]
	public class RoguelikeTopicEndingSPOperatorGrowInfoItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B6A7 RID: 112295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6A7")]
		[Address(RVA = "0x14B69F0", Offset = "0x14B55F0", VA = "0x1814B69F0")]
		public void Render(RoguelikeTopicEndingSPOperatorGrowInfoItemViewModel model)
		{
		}

		// Token: 0x0601B6A8 RID: 112296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6A8")]
		[Address(RVA = "0x14B6AE0", Offset = "0x14B56E0", VA = "0x1814B6AE0")]
		public RoguelikeTopicEndingSPOperatorGrowInfoItemView()
		{
		}

		// Token: 0x04023753 RID: 145235
		[Token(Token = "0x4023753")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _nodeActiveVariant;

		// Token: 0x04023754 RID: 145236
		[Token(Token = "0x4023754")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _evolveUnlockVariant;

		// Token: 0x04023755 RID: 145237
		[Token(Token = "0x4023755")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _evolveActiveVariant;

		// Token: 0x04023756 RID: 145238
		[Token(Token = "0x4023756")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _descText;

		// Token: 0x04023757 RID: 145239
		[Token(Token = "0x4023757")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023758 RID: 145240
		[Token(Token = "0x4023758")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
