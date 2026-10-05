using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044AB RID: 17579
	[Token(Token = "0x20044AB")]
	public class RoguelikeTopicChallengeEndingTaskView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601ADAF RID: 109999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADAF")]
		[Address(RVA = "0x1403A80", Offset = "0x1402680", VA = "0x181403A80")]
		public void Render(string taskDesc, float progress, bool complete)
		{
		}

		// Token: 0x0601ADB0 RID: 110000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADB0")]
		[Address(RVA = "0x1403BB0", Offset = "0x14027B0", VA = "0x181403BB0")]
		public RoguelikeTopicChallengeEndingTaskView()
		{
		}

		// Token: 0x04022660 RID: 140896
		[Token(Token = "0x4022660")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider _progressSlider;

		// Token: 0x04022661 RID: 140897
		[Token(Token = "0x4022661")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _taskDescText;

		// Token: 0x04022662 RID: 140898
		[Token(Token = "0x4022662")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _incompletePanel;

		// Token: 0x04022663 RID: 140899
		[Token(Token = "0x4022663")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _completePanel;

		// Token: 0x04022664 RID: 140900
		[Token(Token = "0x4022664")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022665 RID: 140901
		[Token(Token = "0x4022665")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
