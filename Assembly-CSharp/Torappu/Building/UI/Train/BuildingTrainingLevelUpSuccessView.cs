using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Train
{
	// Token: 0x02001C12 RID: 7186
	[Token(Token = "0x2001C12")]
	public class BuildingTrainingLevelUpSuccessView : MonoBehaviour
	{
		// Token: 0x0600B333 RID: 45875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B333")]
		[Address(RVA = "0x32DE2D0", Offset = "0x32DCED0", VA = "0x1832DE2D0")]
		public void OnSetData(string skillID, int specLvl)
		{
		}

		// Token: 0x0600B334 RID: 45876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B334")]
		[Address(RVA = "0x32DE2B0", Offset = "0x32DCEB0", VA = "0x1832DE2B0")]
		public void ClosePanel()
		{
		}

		// Token: 0x0600B335 RID: 45877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B335")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingTrainingLevelUpSuccessView()
		{
		}

		// Token: 0x0400AE67 RID: 44647
		[Token(Token = "0x400AE67")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _skillIcon;

		// Token: 0x0400AE68 RID: 44648
		[Token(Token = "0x400AE68")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _specLvl;

		// Token: 0x0400AE69 RID: 44649
		[Token(Token = "0x400AE69")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _specFinalLvl;

		// Token: 0x0400AE6A RID: 44650
		[Token(Token = "0x400AE6A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0400AE6B RID: 44651
		[Token(Token = "0x400AE6B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIBlurFloatPanel _floatPanel;

		// Token: 0x0400AE6C RID: 44652
		[Token(Token = "0x400AE6C")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;
	}
}
