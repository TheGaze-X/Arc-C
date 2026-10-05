using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x0200728C RID: 29324
	[Token(Token = "0x200728C")]
	public class Act4D0MileStoneHolder : MonoBehaviour
	{
		// Token: 0x06029875 RID: 170101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029875")]
		[Address(RVA = "0x24DCDC0", Offset = "0x24DB9C0", VA = "0x1824DCDC0")]
		public void RefreshInfo(List<Act4D0MileStoneViewModel> viewModelList, int count)
		{
		}

		// Token: 0x06029876 RID: 170102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029876")]
		[Address(RVA = "0x24DCE20", Offset = "0x24DBA20", VA = "0x1824DCE20")]
		public void RenderInfo(List<Act4D0MileStoneViewModel> viewModelList, int count)
		{
		}

		// Token: 0x06029877 RID: 170103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029877")]
		[Address(RVA = "0x24DCC20", Offset = "0x24DB820", VA = "0x1824DCC20")]
		public void DropToChar()
		{
		}

		// Token: 0x06029878 RID: 170104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029878")]
		[Address(RVA = "0x24DD670", Offset = "0x24DC270", VA = "0x1824DD670")]
		private IEnumerator _RefreshTargetState(float index)
		{
			return null;
		}

		// Token: 0x06029879 RID: 170105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029879")]
		[Address(RVA = "0x24DD700", Offset = "0x24DC300", VA = "0x1824DD700")]
		public Act4D0MileStoneHolder()
		{
		}

		// Token: 0x0403B586 RID: 243078
		[Token(Token = "0x403B586")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _title;

		// Token: 0x0403B587 RID: 243079
		[Token(Token = "0x403B587")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LoopVerticalScrollRect _content;

		// Token: 0x0403B588 RID: 243080
		[Token(Token = "0x403B588")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act4D0MileStoneGridAdapter _adapter;

		// Token: 0x0403B589 RID: 243081
		[Token(Token = "0x403B589")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0403B58A RID: 243082
		[Token(Token = "0x403B58A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _costText;

		// Token: 0x0403B58B RID: 243083
		[Token(Token = "0x403B58B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _remainTime;

		// Token: 0x0403B58C RID: 243084
		[Token(Token = "0x403B58C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _skinReward;

		// Token: 0x0403B58D RID: 243085
		[Token(Token = "0x403B58D")]
		[FieldOffset(Offset = "0x4C")]
		private int m_targetIndex;

		// Token: 0x0403B58E RID: 243086
		[Token(Token = "0x403B58E")]
		[FieldOffset(Offset = "0x50")]
		private string m_targetId;

		// Token: 0x0403B58F RID: 243087
		[Token(Token = "0x403B58F")]
		[FieldOffset(Offset = "0x58")]
		private int m_max;
	}
}
