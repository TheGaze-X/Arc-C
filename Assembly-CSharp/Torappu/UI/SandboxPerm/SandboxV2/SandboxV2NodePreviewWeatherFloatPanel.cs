using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004278 RID: 17016
	[Token(Token = "0x2004278")]
	public class SandboxV2NodePreviewWeatherFloatPanel : SandboxV2FloatPanel
	{
		// Token: 0x0601A37D RID: 107389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A37D")]
		[Address(RVA = "0x1321830", Offset = "0x1320430", VA = "0x181321830")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A37E RID: 107390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A37E")]
		[Address(RVA = "0x1321580", Offset = "0x1320180", VA = "0x181321580", Slot = "4")]
		protected override void SetShowStatus(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x0601A37F RID: 107391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A37F")]
		[Address(RVA = "0x1321480", Offset = "0x1320080", VA = "0x181321480")]
		public void Render(SandboxV2WeatherData weatherData)
		{
		}

		// Token: 0x0601A380 RID: 107392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A380")]
		[Address(RVA = "0x1321A60", Offset = "0x1320660", VA = "0x181321A60")]
		public void _TutorialOnly_TryRaiseAVGSignal()
		{
		}

		// Token: 0x0601A381 RID: 107393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A381")]
		[Address(RVA = "0x1321B70", Offset = "0x1320770", VA = "0x181321B70")]
		public SandboxV2NodePreviewWeatherFloatPanel()
		{
		}

		// Token: 0x04021305 RID: 135941
		[Token(Token = "0x4021305")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _detailAlphaHandler;

		// Token: 0x04021306 RID: 135942
		[Token(Token = "0x4021306")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _detailPositionHandler;

		// Token: 0x04021307 RID: 135943
		[Token(Token = "0x4021307")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _detailShowPos;

		// Token: 0x04021308 RID: 135944
		[Token(Token = "0x4021308")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _detailHidePos;

		// Token: 0x04021309 RID: 135945
		[Token(Token = "0x4021309")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _weatherEffect;

		// Token: 0x0402130A RID: 135946
		[Token(Token = "0x402130A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _weatherDesc;

		// Token: 0x0402130B RID: 135947
		[Token(Token = "0x402130B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_inited;

		// Token: 0x0402130C RID: 135948
		[Token(Token = "0x402130C")]
		[FieldOffset(Offset = "0x68")]
		private UISwitchTween m_detailShowTween;

		// Token: 0x0402130D RID: 135949
		[Token(Token = "0x402130D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402130E RID: 135950
		[Token(Token = "0x402130E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetShowStatus;

		// Token: 0x0402130F RID: 135951
		[Token(Token = "0x402130F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021310 RID: 135952
		[Token(Token = "0x4021310")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRaiseAVGSignal;

		// Token: 0x04021311 RID: 135953
		[Token(Token = "0x4021311")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
