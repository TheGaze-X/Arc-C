using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A34 RID: 18996
	[Token(Token = "0x2004A34")]
	public class InformantSelectChoiceItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C924 RID: 117028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C924")]
		[Address(RVA = "0x1617EE0", Offset = "0x1616AE0", VA = "0x181617EE0")]
		public void Render(InformantSelectChoiceItemViewModel model, int selectedChoiceIndex)
		{
		}

		// Token: 0x0601C925 RID: 117029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C925")]
		[Address(RVA = "0x1618250", Offset = "0x1616E50", VA = "0x181618250")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C926 RID: 117030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C926")]
		[Address(RVA = "0x1618160", Offset = "0x1616D60", VA = "0x181618160")]
		public void TutorialOnly_RegisterTutorialGo(int index)
		{
		}

		// Token: 0x0601C927 RID: 117031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C927")]
		[Address(RVA = "0x1617E00", Offset = "0x1616A00", VA = "0x181617E00")]
		public void EventOnChoiceClicked()
		{
		}

		// Token: 0x0601C928 RID: 117032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C928")]
		[Address(RVA = "0x1618360", Offset = "0x1616F60", VA = "0x181618360")]
		public InformantSelectChoiceItem()
		{
		}

		// Token: 0x040257C7 RID: 153543
		[Token(Token = "0x40257C7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x040257C8 RID: 153544
		[Token(Token = "0x40257C8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _choiceBg;

		// Token: 0x040257C9 RID: 153545
		[Token(Token = "0x40257C9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InformantArrowComponent _trustArrow;

		// Token: 0x040257CA RID: 153546
		[Token(Token = "0x40257CA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InformantArrowComponent _attentionArrow;

		// Token: 0x040257CB RID: 153547
		[Token(Token = "0x40257CB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objHotspotForTutorial;

		// Token: 0x040257CC RID: 153548
		[Token(Token = "0x40257CC")]
		[FieldOffset(Offset = "0x48")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x040257CD RID: 153549
		[Token(Token = "0x40257CD")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x040257CE RID: 153550
		[Token(Token = "0x40257CE")]
		[FieldOffset(Offset = "0x54")]
		private int m_choiceIndex;

		// Token: 0x040257CF RID: 153551
		[Token(Token = "0x40257CF")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040257D0 RID: 153552
		[Token(Token = "0x40257D0")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isSelected;

		// Token: 0x040257D1 RID: 153553
		[Token(Token = "0x40257D1")]
		[FieldOffset(Offset = "0x70")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x040257D2 RID: 153554
		[Token(Token = "0x40257D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040257D3 RID: 153555
		[Token(Token = "0x40257D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040257D4 RID: 153556
		[Token(Token = "0x40257D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TutorialOnly_RegisterTutorialGo;

		// Token: 0x040257D5 RID: 153557
		[Token(Token = "0x40257D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnChoiceClicked;

		// Token: 0x040257D6 RID: 153558
		[Token(Token = "0x40257D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
