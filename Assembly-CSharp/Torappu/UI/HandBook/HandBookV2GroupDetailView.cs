using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066F0 RID: 26352
	[Token(Token = "0x20066F0")]
	public class HandBookV2GroupDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025D36 RID: 154934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D36")]
		[Address(RVA = "0x20C0550", Offset = "0x20BF150", VA = "0x1820C0550")]
		public void Render(HandBookV2GroupCharViewModel viewModel, Vector3 pos, Vector3 scale)
		{
		}

		// Token: 0x06025D37 RID: 154935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D37")]
		[Address(RVA = "0x20C02E0", Offset = "0x20BEEE0", VA = "0x1820C02E0")]
		public void Render(HandBookV2MapCardView cardView)
		{
		}

		// Token: 0x06025D38 RID: 154936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D38")]
		[Address(RVA = "0x20C0100", Offset = "0x20BED00", VA = "0x1820C0100")]
		public void Refresh(HandBookV2GroupCharViewModel viewModel)
		{
		}

		// Token: 0x06025D39 RID: 154937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D39")]
		[Address(RVA = "0x20C11C0", Offset = "0x20BFDC0", VA = "0x1820C11C0")]
		private IEnumerator _ShowEffect()
		{
			return null;
		}

		// Token: 0x06025D3A RID: 154938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D3A")]
		[Address(RVA = "0x20C0800", Offset = "0x20BF400", VA = "0x1820C0800")]
		public void StartAnimate(HandBookV2MapCardView centerView, HandBookV2GroupCharViewModel viewModel)
		{
		}

		// Token: 0x06025D3B RID: 154939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D3B")]
		[Address(RVA = "0x20C1270", Offset = "0x20BFE70", VA = "0x1820C1270")]
		public HandBookV2GroupDetailView()
		{
		}

		// Token: 0x040352B0 RID: 217776
		[Token(Token = "0x40352B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2MapLineView _lineView;

		// Token: 0x040352B1 RID: 217777
		[Token(Token = "0x40352B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _lineContainer;

		// Token: 0x040352B2 RID: 217778
		[Token(Token = "0x40352B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandBookV2MapCardView _cardView;

		// Token: 0x040352B3 RID: 217779
		[Token(Token = "0x40352B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040352B4 RID: 217780
		[Token(Token = "0x40352B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIHandBookCardEvent _clickEvent;

		// Token: 0x040352B5 RID: 217781
		[Token(Token = "0x40352B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _showDetailButton;

		// Token: 0x040352B6 RID: 217782
		[Token(Token = "0x40352B6")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public bool lockedFlag;

		// Token: 0x040352B7 RID: 217783
		[Token(Token = "0x40352B7")]
		[FieldOffset(Offset = "0x50")]
		private HandBookV2MapCardView m_centerView;

		// Token: 0x040352B8 RID: 217784
		[Token(Token = "0x40352B8")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, HandBookV2GroupDetailView.ViewHolder> m_handBookV2MapCardView;

		// Token: 0x040352B9 RID: 217785
		[Token(Token = "0x40352B9")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, HandBookV2GroupDetailView.ViewHolder> m_hideV2MapCardView;

		// Token: 0x040352BA RID: 217786
		[Token(Token = "0x40352BA")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<int, HandBookV2MapLineView> m_lineViewList;

		// Token: 0x040352BB RID: 217787
		[Token(Token = "0x40352BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040352BC RID: 217788
		[Token(Token = "0x40352BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x040352BD RID: 217789
		[Token(Token = "0x40352BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x040352BE RID: 217790
		[Token(Token = "0x40352BE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowEffect;

		// Token: 0x040352BF RID: 217791
		[Token(Token = "0x40352BF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StartAnimate;

		// Token: 0x040352C0 RID: 217792
		[Token(Token = "0x40352C0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020066F1 RID: 26353
		[Token(Token = "0x20066F1")]
		public class ViewHolder
		{
			// Token: 0x06025D3C RID: 154940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025D3C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x040352C1 RID: 217793
			[Token(Token = "0x40352C1")]
			[FieldOffset(Offset = "0x10")]
			public HandBookV2MapCardView view;

			// Token: 0x040352C2 RID: 217794
			[Token(Token = "0x40352C2")]
			[FieldOffset(Offset = "0x18")]
			public int index;

			// Token: 0x040352C3 RID: 217795
			[Token(Token = "0x40352C3")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 targetPos;

			// Token: 0x040352C4 RID: 217796
			[Token(Token = "0x40352C4")]
			[FieldOffset(Offset = "0x28")]
			public HandBookV2LineViewModel lineViewModel;
		}
	}
}
