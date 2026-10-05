using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI.Assist
{
	// Token: 0x02001E0A RID: 7690
	[Token(Token = "0x2001E0A")]
	public class AssistReportManuView : MonoBehaviour
	{
		// Token: 0x0600BDD5 RID: 48597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD5")]
		[Address(RVA = "0x33C1580", Offset = "0x33C0180", VA = "0x1833C1580")]
		public void Render(Dictionary<string, BuildingManuFactureItemReport> manuFacture)
		{
		}

		// Token: 0x0600BDD6 RID: 48598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD6")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AssistReportManuView()
		{
		}

		// Token: 0x0400BE8A RID: 48778
		[Token(Token = "0x400BE8A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AssistReportManuTotalItem _totalItem;

		// Token: 0x0400BE8B RID: 48779
		[Token(Token = "0x400BE8B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AssistReportManuPerItem _perItem;

		// Token: 0x0400BE8C RID: 48780
		[Token(Token = "0x400BE8C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _manuContainer;

		// Token: 0x0400BE8D RID: 48781
		[Token(Token = "0x400BE8D")]
		[FieldOffset(Offset = "0x30")]
		private AssistReportManuTotalItem m_goldTotal;

		// Token: 0x0400BE8E RID: 48782
		[Token(Token = "0x400BE8E")]
		[FieldOffset(Offset = "0x38")]
		private AssistReportManuTotalItem m_expTotal;
	}
}
