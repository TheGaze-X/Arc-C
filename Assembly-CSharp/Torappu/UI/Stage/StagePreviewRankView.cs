using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Stage
{
	// Token: 0x02006975 RID: 26997
	[Token(Token = "0x2006975")]
	public class StagePreviewRankView : MonoBehaviour
	{
		// Token: 0x06026A3C RID: 158268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A3C")]
		[Address(RVA = "0x21B4910", Offset = "0x21B3510", VA = "0x1821B4910")]
		public void Render(PlayerStageState stageState, bool hasHardToShow, StageViewModel hardStageModel)
		{
		}

		// Token: 0x06026A3D RID: 158269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A3D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StagePreviewRankView()
		{
		}

		// Token: 0x040368B8 RID: 223416
		[Token(Token = "0x40368B8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle[] _rankViews;

		// Token: 0x040368B9 RID: 223417
		[Token(Token = "0x40368B9")]
		private const int HARDSTAR = 3;
	}
}
