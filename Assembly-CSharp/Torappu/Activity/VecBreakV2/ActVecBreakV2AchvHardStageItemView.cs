using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DBE RID: 28094
	[Token(Token = "0x2006DBE")]
	public class ActVecBreakV2AchvHardStageItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027FFD RID: 163837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FFD")]
		[Address(RVA = "0x2344EF0", Offset = "0x2343AF0", VA = "0x182344EF0")]
		public void Render(ActVecBreakV2AchvHardStageModel stageModel)
		{
		}

		// Token: 0x06027FFE RID: 163838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FFE")]
		[Address(RVA = "0x2345490", Offset = "0x2344090", VA = "0x182345490")]
		public ActVecBreakV2AchvHardStageItemView()
		{
		}

		// Token: 0x04038B65 RID: 232293
		[Token(Token = "0x4038B65")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalPartGO;

		// Token: 0x04038B66 RID: 232294
		[Token(Token = "0x4038B66")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _completePartGO;

		// Token: 0x04038B67 RID: 232295
		[Token(Token = "0x4038B67")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _emptyDecoNormalGO;

		// Token: 0x04038B68 RID: 232296
		[Token(Token = "0x4038B68")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emptyDecoCompleteGO;

		// Token: 0x04038B69 RID: 232297
		[Token(Token = "0x4038B69")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgBossDeco;

		// Token: 0x04038B6A RID: 232298
		[Token(Token = "0x4038B6A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgStageOrder;

		// Token: 0x04038B6B RID: 232299
		[Token(Token = "0x4038B6B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textStageCode;

		// Token: 0x04038B6C RID: 232300
		[Token(Token = "0x4038B6C")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04038B6D RID: 232301
		[Token(Token = "0x4038B6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038B6E RID: 232302
		[Token(Token = "0x4038B6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
