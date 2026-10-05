using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C37 RID: 7223
	[Token(Token = "0x2001C37")]
	public class BuildingTradingGainingOrderView : MonoBehaviour
	{
		// Token: 0x0600B3BE RID: 46014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3BE")]
		[Address(RVA = "0x32D4330", Offset = "0x32D2F30", VA = "0x1832D4330")]
		public void Render(TradingGainOrderSnapshot snapshot)
		{
		}

		// Token: 0x0600B3BF RID: 46015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3BF")]
		[Address(RVA = "0x32D4770", Offset = "0x32D3370", VA = "0x1832D4770")]
		private void _UpdateCountDown()
		{
		}

		// Token: 0x0600B3C0 RID: 46016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C0")]
		[Address(RVA = "0x32D4680", Offset = "0x32D3280", VA = "0x1832D4680")]
		private void _RenderOnCountDownTick()
		{
		}

		// Token: 0x0600B3C1 RID: 46017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C1")]
		[Address(RVA = "0x32D4660", Offset = "0x32D3260", VA = "0x1832D4660")]
		private void Update()
		{
		}

		// Token: 0x0600B3C2 RID: 46018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C2")]
		[Address(RVA = "0x32D4260", Offset = "0x32D2E60", VA = "0x1832D4260")]
		public void EventOnLaborAccelClicked()
		{
		}

		// Token: 0x0600B3C3 RID: 46019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3C3")]
		[Address(RVA = "0x32D48C0", Offset = "0x32D34C0", VA = "0x1832D48C0")]
		public BuildingTradingGainingOrderView()
		{
		}

		// Token: 0x0400AF3D RID: 44861
		[Token(Token = "0x400AF3D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelWork;

		// Token: 0x0400AF3E RID: 44862
		[Token(Token = "0x400AF3E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelPause;

		// Token: 0x0400AF3F RID: 44863
		[Token(Token = "0x400AF3F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x0400AF40 RID: 44864
		[Token(Token = "0x400AF40")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FillProgressBar _progress;

		// Token: 0x0400AF41 RID: 44865
		[Token(Token = "0x400AF41")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorLocked;

		// Token: 0x0400AF42 RID: 44866
		[Token(Token = "0x400AF42")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIColorGraphic _graphicLaborAccelBtn;

		// Token: 0x0400AF43 RID: 44867
		[Token(Token = "0x400AF43")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelLaborAccelLocked;

		// Token: 0x0400AF44 RID: 44868
		[Token(Token = "0x400AF44")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action onLaborAccelClicked;

		// Token: 0x0400AF45 RID: 44869
		[Token(Token = "0x400AF45")]
		[FieldOffset(Offset = "0x60")]
		private TradingGainOrderSnapshot m_snapshot;

		// Token: 0x0400AF46 RID: 44870
		[Token(Token = "0x400AF46")]
		[FieldOffset(Offset = "0x88")]
		private CountDownTask m_countDown;
	}
}
