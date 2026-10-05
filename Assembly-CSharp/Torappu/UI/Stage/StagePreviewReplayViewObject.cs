using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Stage
{
	// Token: 0x02006977 RID: 26999
	[Token(Token = "0x2006977")]
	public class StagePreviewReplayViewObject : MonoBehaviour
	{
		// Token: 0x06026A42 RID: 158274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A42")]
		[Address(RVA = "0x21BA840", Offset = "0x21B9440", VA = "0x1821BA840")]
		public void Render(StoryData storyData, string stageId)
		{
		}

		// Token: 0x06026A43 RID: 158275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A43")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StagePreviewReplayViewObject()
		{
		}

		// Token: 0x040368C3 RID: 223427
		[Token(Token = "0x40368C3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _missionText;

		// Token: 0x040368C4 RID: 223428
		[Token(Token = "0x40368C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _timeText;
	}
}
