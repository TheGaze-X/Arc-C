using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200450E RID: 17678
	[Token(Token = "0x200450E")]
	public class RoguelikeCommonOuterBuffSummaryMergeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF83 RID: 110467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF83")]
		[Address(RVA = "0x1421A60", Offset = "0x1420660", VA = "0x181421A60")]
		public void Render(string topicId, RoguelikeCommonOuterBuffSummaryMergedItemModel viewModel)
		{
		}

		// Token: 0x0601AF84 RID: 110468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF84")]
		[Address(RVA = "0x1421C10", Offset = "0x1420810", VA = "0x181421C10")]
		public RoguelikeCommonOuterBuffSummaryMergeItemView()
		{
		}

		// Token: 0x040229E5 RID: 141797
		[Token(Token = "0x40229E5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040229E6 RID: 141798
		[Token(Token = "0x40229E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x040229E7 RID: 141799
		[Token(Token = "0x40229E7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _value;

		// Token: 0x040229E8 RID: 141800
		[Token(Token = "0x40229E8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelValue;

		// Token: 0x040229E9 RID: 141801
		[Token(Token = "0x40229E9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040229EA RID: 141802
		[Token(Token = "0x40229EA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _inactiveSummaryAlpha;

		// Token: 0x040229EB RID: 141803
		[Token(Token = "0x40229EB")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040229EC RID: 141804
		[Token(Token = "0x40229EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040229ED RID: 141805
		[Token(Token = "0x40229ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
