using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044BB RID: 17595
	[Token(Token = "0x20044BB")]
	public class RoguelikeTopicChallengeProgress : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AE04 RID: 110084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE04")]
		[Address(RVA = "0x14080C0", Offset = "0x1406CC0", VA = "0x1814080C0")]
		public void InitStyle(string curProgressColor)
		{
		}

		// Token: 0x0601AE05 RID: 110085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE05")]
		[Address(RVA = "0x1408140", Offset = "0x1406D40", VA = "0x181408140")]
		public void Render(int completedTaskCount, int totalTaskCount)
		{
		}

		// Token: 0x0601AE06 RID: 110086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE06")]
		[Address(RVA = "0x1408270", Offset = "0x1406E70", VA = "0x181408270")]
		public RoguelikeTopicChallengeProgress()
		{
		}

		// Token: 0x04022706 RID: 141062
		[Token(Token = "0x4022706")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCompleteProgress;

		// Token: 0x04022707 RID: 141063
		[Token(Token = "0x4022707")]
		[FieldOffset(Offset = "0x20")]
		private string m_colTargetCurProgress;

		// Token: 0x04022708 RID: 141064
		[Token(Token = "0x4022708")]
		[FieldOffset(Offset = "0x28")]
		private readonly string COMPLETE_PROGRESS_STYLE;

		// Token: 0x04022709 RID: 141065
		[Token(Token = "0x4022709")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitStyle;

		// Token: 0x0402270A RID: 141066
		[Token(Token = "0x402270A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402270B RID: 141067
		[Token(Token = "0x402270B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
