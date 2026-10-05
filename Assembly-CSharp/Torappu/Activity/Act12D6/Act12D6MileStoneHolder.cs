using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007B06 RID: 31494
	[Token(Token = "0x2007B06")]
	public class Act12D6MileStoneHolder : MonoBehaviour
	{
		// Token: 0x0602C18C RID: 180620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C18C")]
		[Address(RVA = "0x27F2C40", Offset = "0x27F1840", VA = "0x1827F2C40")]
		public void RefreshInfo(List<Act12D6MileStoneViewModel> viewModelList, int count)
		{
		}

		// Token: 0x0602C18D RID: 180621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C18D")]
		[Address(RVA = "0x27F2D20", Offset = "0x27F1920", VA = "0x1827F2D20")]
		public void RenderInfo(List<Act12D6MileStoneViewModel> viewModelList, int count)
		{
		}

		// Token: 0x0602C18E RID: 180622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C18E")]
		[Address(RVA = "0x27F3180", Offset = "0x27F1D80", VA = "0x1827F3180")]
		private IEnumerator _RefreshTargetState(float index)
		{
			return null;
		}

		// Token: 0x0602C18F RID: 180623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C18F")]
		[Address(RVA = "0x27F3210", Offset = "0x27F1E10", VA = "0x1827F3210")]
		public Act12D6MileStoneHolder()
		{
		}

		// Token: 0x0403FEC2 RID: 261826
		[Token(Token = "0x403FEC2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _title;

		// Token: 0x0403FEC3 RID: 261827
		[Token(Token = "0x403FEC3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LoopVerticalScrollRect _content;

		// Token: 0x0403FEC4 RID: 261828
		[Token(Token = "0x403FEC4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act12D6MileStoneGridAdapter _adapter;

		// Token: 0x0403FEC5 RID: 261829
		[Token(Token = "0x403FEC5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _costText;

		// Token: 0x0403FEC6 RID: 261830
		[Token(Token = "0x403FEC6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _btnFinishAll;

		// Token: 0x0403FEC7 RID: 261831
		[Token(Token = "0x403FEC7")]
		[FieldOffset(Offset = "0x40")]
		private int m_targetIndex;

		// Token: 0x0403FEC8 RID: 261832
		[Token(Token = "0x403FEC8")]
		[FieldOffset(Offset = "0x48")]
		private string m_targetId;

		// Token: 0x0403FEC9 RID: 261833
		[Token(Token = "0x403FEC9")]
		[FieldOffset(Offset = "0x50")]
		private int m_max;

		// Token: 0x0403FECA RID: 261834
		[Token(Token = "0x403FECA")]
		[FieldOffset(Offset = "0x54")]
		private bool m_ableToGetFlag;
	}
}
