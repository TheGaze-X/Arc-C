using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007751 RID: 30545
	[Token(Token = "0x2007751")]
	public class Act1VHalfidlePlotCardGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AE7B RID: 175739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE7B")]
		[Address(RVA = "0x26B85F0", Offset = "0x26B71F0", VA = "0x1826B85F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AE7C RID: 175740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE7C")]
		[Address(RVA = "0x26B83A0", Offset = "0x26B6FA0", VA = "0x1826B83A0")]
		public void Renderer(Act1VHalfIdlePlotSquadGroupViewModel viewModel)
		{
		}

		// Token: 0x0602AE7D RID: 175741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE7D")]
		[Address(RVA = "0x26B8120", Offset = "0x26B6D20", VA = "0x1826B8120")]
		public void EventOnPlotSquadCardClick(string plotId)
		{
		}

		// Token: 0x0602AE7E RID: 175742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE7E")]
		[Address(RVA = "0x26B8260", Offset = "0x26B6E60", VA = "0x1826B8260")]
		public void RegisterTutorialGO(Act1VHalfIdlePlotType plotType)
		{
		}

		// Token: 0x0602AE7F RID: 175743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE7F")]
		[Address(RVA = "0x26B8700", Offset = "0x26B7300", VA = "0x1826B8700")]
		public Act1VHalfidlePlotCardGroupView()
		{
		}

		// Token: 0x0403DDE4 RID: 253412
		[Token(Token = "0x403DDE4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _typeIcon;

		// Token: 0x0403DDE5 RID: 253413
		[Token(Token = "0x403DDE5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _cardContent;

		// Token: 0x0403DDE6 RID: 253414
		[Token(Token = "0x403DDE6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _cardGroupGO;

		// Token: 0x0403DDE7 RID: 253415
		[Token(Token = "0x403DDE7")]
		[FieldOffset(Offset = "0x30")]
		private bool m_inited;

		// Token: 0x0403DDE8 RID: 253416
		[Token(Token = "0x403DDE8")]
		[FieldOffset(Offset = "0x38")]
		private Act1VHalfIdlePlotCardGroupAdapter m_cardAdapter;

		// Token: 0x0403DDE9 RID: 253417
		[Token(Token = "0x403DDE9")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DDEA RID: 253418
		[Token(Token = "0x403DDEA")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403DDEB RID: 253419
		[Token(Token = "0x403DDEB")]
		[FieldOffset(Offset = "0x60")]
		private ILoadAsset m_assetLoader;

		// Token: 0x0403DDEC RID: 253420
		[Token(Token = "0x403DDEC")]
		[FieldOffset(Offset = "0x68")]
		private Act1VHalfIdlePlotType m_cachedPlotType;

		// Token: 0x0403DDED RID: 253421
		[Token(Token = "0x403DDED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DDEE RID: 253422
		[Token(Token = "0x403DDEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Renderer;

		// Token: 0x0403DDEF RID: 253423
		[Token(Token = "0x403DDEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnPlotSquadCardClick;

		// Token: 0x0403DDF0 RID: 253424
		[Token(Token = "0x403DDF0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403DDF1 RID: 253425
		[Token(Token = "0x403DDF1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
