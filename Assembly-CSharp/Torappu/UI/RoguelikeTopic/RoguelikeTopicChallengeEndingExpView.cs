using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044A8 RID: 17576
	[Token(Token = "0x20044A8")]
	public class RoguelikeTopicChallengeEndingExpView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AD97 RID: 109975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD97")]
		[Address(RVA = "0x1402290", Offset = "0x1400E90", VA = "0x181402290")]
		public void Render(int level, int exp, bool isNewRecord)
		{
		}

		// Token: 0x0601AD98 RID: 109976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD98")]
		[Address(RVA = "0x14023D0", Offset = "0x1400FD0", VA = "0x1814023D0")]
		public RoguelikeTopicChallengeEndingExpView()
		{
		}

		// Token: 0x04022630 RID: 140848
		[Token(Token = "0x4022630")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x04022631 RID: 140849
		[Token(Token = "0x4022631")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _expText;

		// Token: 0x04022632 RID: 140850
		[Token(Token = "0x4022632")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _newRecordPanel;

		// Token: 0x04022633 RID: 140851
		[Token(Token = "0x4022633")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022634 RID: 140852
		[Token(Token = "0x4022634")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
