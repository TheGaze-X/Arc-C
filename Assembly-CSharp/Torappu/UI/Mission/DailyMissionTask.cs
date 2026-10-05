using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x0200488B RID: 18571
	[Token(Token = "0x200488B")]
	public class DailyMissionTask : MonoBehaviour, IHotfixable, IAsyncDataView<MissionViewModel>, IAsyncShowEffect
	{
		// Token: 0x0601C092 RID: 114834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C092")]
		[Address(RVA = "0x1564F90", Offset = "0x1563B90", VA = "0x181564F90")]
		private void _ApplyViewStyle(DailyMissionTask.ViewStyle style)
		{
		}

		// Token: 0x0601C093 RID: 114835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C093")]
		[Address(RVA = "0x1564AB0", Offset = "0x15636B0", VA = "0x181564AB0")]
		public void ApplyReward()
		{
		}

		// Token: 0x0601C094 RID: 114836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C094")]
		[Address(RVA = "0x1564F20", Offset = "0x1563B20", VA = "0x181564F20")]
		public void OnOpenDetailClick()
		{
		}

		// Token: 0x0601C095 RID: 114837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C095")]
		[Address(RVA = "0x1564E40", Offset = "0x1563A40", VA = "0x181564E40", Slot = "5")]
		public void AsyncShow()
		{
		}

		// Token: 0x0601C096 RID: 114838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C096")]
		[Address(RVA = "0x1564B30", Offset = "0x1563730", VA = "0x181564B30", Slot = "4")]
		public void AsyncSetData(MissionViewModel data)
		{
		}

		// Token: 0x0601C097 RID: 114839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C097")]
		[Address(RVA = "0x1565380", Offset = "0x1563F80", VA = "0x181565380")]
		public DailyMissionTask()
		{
		}

		// Token: 0x0402495C RID: 149852
		[Token(Token = "0x402495C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x0402495D RID: 149853
		[Token(Token = "0x402495D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _backgroundGlow;

		// Token: 0x0402495E RID: 149854
		[Token(Token = "0x402495E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _acceptButtonGlow;

		// Token: 0x0402495F RID: 149855
		[Token(Token = "0x402495F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _description;

		// Token: 0x04024960 RID: 149856
		[Token(Token = "0x4024960")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _requireLabelBackground;

		// Token: 0x04024961 RID: 149857
		[Token(Token = "0x4024961")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _requireLabelText;

		// Token: 0x04024962 RID: 149858
		[Token(Token = "0x4024962")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _pointNumberLabel;

		// Token: 0x04024963 RID: 149859
		[Token(Token = "0x4024963")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _pointIconImage;

		// Token: 0x04024964 RID: 149860
		[Token(Token = "0x4024964")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _crossRectTransform;

		// Token: 0x04024965 RID: 149861
		[Token(Token = "0x4024965")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _finished;

		// Token: 0x04024966 RID: 149862
		[Token(Token = "0x4024966")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _unfinished;

		// Token: 0x04024967 RID: 149863
		[Token(Token = "0x4024967")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _accepted;

		// Token: 0x04024968 RID: 149864
		[Token(Token = "0x4024968")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MissionProgressBar _missionState;

		// Token: 0x04024969 RID: 149865
		[Token(Token = "0x4024969")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _progressTarget;

		// Token: 0x0402496A RID: 149866
		[Token(Token = "0x402496A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _progressValue;

		// Token: 0x0402496B RID: 149867
		[Token(Token = "0x402496B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402496C RID: 149868
		[Token(Token = "0x402496C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private DailyMissionTask.ViewStyle normalStyle;

		// Token: 0x0402496D RID: 149869
		[Token(Token = "0x402496D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private DailyMissionTask.ViewStyle completeStyle;

		// Token: 0x0402496E RID: 149870
		[Token(Token = "0x402496E")]
		[FieldOffset(Offset = "0xA8")]
		private MissionViewModel m_dataCache;

		// Token: 0x0402496F RID: 149871
		[Token(Token = "0x402496F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ApplyViewStyle;

		// Token: 0x04024970 RID: 149872
		[Token(Token = "0x4024970")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyReward;

		// Token: 0x04024971 RID: 149873
		[Token(Token = "0x4024971")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnOpenDetailClick;

		// Token: 0x04024972 RID: 149874
		[Token(Token = "0x4024972")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AsyncShow;

		// Token: 0x04024973 RID: 149875
		[Token(Token = "0x4024973")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x04024974 RID: 149876
		[Token(Token = "0x4024974")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200488C RID: 18572
		[Token(Token = "0x200488C")]
		[Serializable]
		public class ViewStyle
		{
			// Token: 0x0601C098 RID: 114840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C098")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewStyle()
			{
			}

			// Token: 0x04024975 RID: 149877
			[Token(Token = "0x4024975")]
			[FieldOffset(Offset = "0x10")]
			public Sprite backgroundSprite;

			// Token: 0x04024976 RID: 149878
			[Token(Token = "0x4024976")]
			[FieldOffset(Offset = "0x18")]
			public Color requireLabelBackgroundColor;

			// Token: 0x04024977 RID: 149879
			[Token(Token = "0x4024977")]
			[FieldOffset(Offset = "0x28")]
			public Color requireLabelTextColor;

			// Token: 0x04024978 RID: 149880
			[Token(Token = "0x4024978")]
			[FieldOffset(Offset = "0x38")]
			public Color descTextColor;

			// Token: 0x04024979 RID: 149881
			[Token(Token = "0x4024979")]
			[FieldOffset(Offset = "0x48")]
			public Color pointIconColor;

			// Token: 0x0402497A RID: 149882
			[Token(Token = "0x402497A")]
			[FieldOffset(Offset = "0x58")]
			public Sprite pointIconSprite;

			// Token: 0x0402497B RID: 149883
			[Token(Token = "0x402497B")]
			[FieldOffset(Offset = "0x60")]
			public Vector2 pointIconAnchoredPos;

			// Token: 0x0402497C RID: 149884
			[Token(Token = "0x402497C")]
			[FieldOffset(Offset = "0x68")]
			public Vector2 pointIconSizeDelta;

			// Token: 0x0402497D RID: 149885
			[Token(Token = "0x402497D")]
			[FieldOffset(Offset = "0x70")]
			public Vector2 crossAnchoredPos;

			// Token: 0x0402497E RID: 149886
			[Token(Token = "0x402497E")]
			[FieldOffset(Offset = "0x78")]
			public Color pointLabelColor;
		}
	}
}
