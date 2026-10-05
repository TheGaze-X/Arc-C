using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A55 RID: 19029
	[Token(Token = "0x2004A55")]
	public class HotUpdateProgressPanel : DataBinder<HotUpdateProgressProperty>
	{
		// Token: 0x0601C99F RID: 117151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C99F")]
		[Address(RVA = "0x160CA20", Offset = "0x160B620", VA = "0x18160CA20", Slot = "7")]
		public override void OnValueChanged(HotUpdateProgressProperty property)
		{
		}

		// Token: 0x0601C9A0 RID: 117152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9A0")]
		[Address(RVA = "0x160CC50", Offset = "0x160B850", VA = "0x18160CC50")]
		private void Update()
		{
		}

		// Token: 0x0601C9A1 RID: 117153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9A1")]
		[Address(RVA = "0x160D180", Offset = "0x160BD80", VA = "0x18160D180")]
		private void _UpdateResourceInfo(float curProg, HotUpdateProgressModel.Progress progress)
		{
		}

		// Token: 0x0601C9A2 RID: 117154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9A2")]
		[Address(RVA = "0x160CFC0", Offset = "0x160BBC0", VA = "0x18160CFC0")]
		private void _UpdateProgressInfo(float curProg)
		{
		}

		// Token: 0x0601C9A3 RID: 117155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9A3")]
		[Address(RVA = "0x160CF30", Offset = "0x160BB30", VA = "0x18160CF30")]
		private void _UpdateIcon(HotUpdateProgressModel.IconType iconType)
		{
		}

		// Token: 0x0601C9A4 RID: 117156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C9A4")]
		[Address(RVA = "0x160D3C0", Offset = "0x160BFC0", VA = "0x18160D3C0")]
		public HotUpdateProgressPanel()
		{
		}

		// Token: 0x040258CF RID: 153807
		[Token(Token = "0x40258CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Progress")]
		private GameObject _panelProgress;

		// Token: 0x040258D0 RID: 153808
		[Token(Token = "0x40258D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Progress")]
		private Image _progressBar;

		// Token: 0x040258D1 RID: 153809
		[Token(Token = "0x40258D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Progress")]
		private Text _textTitle;

		// Token: 0x040258D2 RID: 153810
		[Token(Token = "0x40258D2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Progress")]
		private float _textLength;

		// Token: 0x040258D3 RID: 153811
		[Token(Token = "0x40258D3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Info")]
		private GameObject _iconLoading;

		// Token: 0x040258D4 RID: 153812
		[Token(Token = "0x40258D4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Info")]
		private GameObject _iconDownload;

		// Token: 0x040258D5 RID: 153813
		[Token(Token = "0x40258D5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Info")]
		private Text _textInfo;

		// Token: 0x040258D6 RID: 153814
		[Token(Token = "0x40258D6")]
		[FieldOffset(Offset = "0x58")]
		private HotUpdateProgressModel.Progress m_progress;

		// Token: 0x040258D7 RID: 153815
		[Token(Token = "0x40258D7")]
		[FieldOffset(Offset = "0x60")]
		private string m_titleFormatCache;

		// Token: 0x040258D8 RID: 153816
		[Token(Token = "0x40258D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040258D9 RID: 153817
		[Token(Token = "0x40258D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040258DA RID: 153818
		[Token(Token = "0x40258DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateResourceInfo;

		// Token: 0x040258DB RID: 153819
		[Token(Token = "0x40258DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateProgressInfo;

		// Token: 0x040258DC RID: 153820
		[Token(Token = "0x40258DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateIcon;

		// Token: 0x040258DD RID: 153821
		[Token(Token = "0x40258DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
