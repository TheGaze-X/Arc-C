using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004805 RID: 18437
	[Token(Token = "0x2004805")]
	public class MonopolyMissionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BE14 RID: 114196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE14")]
		[Address(RVA = "0x1544090", Offset = "0x1542C90", VA = "0x181544090")]
		private void _PlayMissionItemEffect(MonopolyEventType eventType, bool isNewMission, bool isCombo, bool fastMode)
		{
		}

		// Token: 0x0601BE15 RID: 114197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE15")]
		[Address(RVA = "0x1544710", Offset = "0x1543310", VA = "0x181544710")]
		private void _RenderCombo(bool fastMode)
		{
		}

		// Token: 0x0601BE16 RID: 114198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE16")]
		[Address(RVA = "0x1544F30", Offset = "0x1543B30", VA = "0x181544F30")]
		private void _RenderProgress(bool isNewMission, bool fastMode)
		{
		}

		// Token: 0x0601BE17 RID: 114199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE17")]
		[Address(RVA = "0x1544940", Offset = "0x1543540", VA = "0x181544940")]
		private void _RenderCompleteStatus(bool isNewMission)
		{
		}

		// Token: 0x0601BE18 RID: 114200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE18")]
		[Address(RVA = "0x1544B20", Offset = "0x1543720", VA = "0x181544B20")]
		private void _RenderMaterialViewContent()
		{
		}

		// Token: 0x0601BE19 RID: 114201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE19")]
		[Address(RVA = "0x1544D50", Offset = "0x1543950", VA = "0x181544D50")]
		private void _RenderPreviewTag(bool isGameAction, bool fastMode)
		{
		}

		// Token: 0x0601BE1A RID: 114202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE1A")]
		[Address(RVA = "0x1544C20", Offset = "0x1543820", VA = "0x181544C20")]
		private void _RenderPreviewProgress(bool fastMode)
		{
		}

		// Token: 0x0601BE1B RID: 114203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE1B")]
		[Address(RVA = "0x1543EB0", Offset = "0x1542AB0", VA = "0x181543EB0")]
		public void Render(MonopolyMissionItemViewModel missionItemViewModel, MonopolyMissionViewModel missionViewModel, bool fastMode, bool isGameAction, MonopolyEventType gameActionType)
		{
		}

		// Token: 0x0601BE1C RID: 114204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE1C")]
		[Address(RVA = "0x1545070", Offset = "0x1543C70", VA = "0x181545070")]
		public MonopolyMissionItemView()
		{
		}

		// Token: 0x04024531 RID: 148785
		[Token(Token = "0x4024531")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textMissionScore;

		// Token: 0x04024532 RID: 148786
		[Token(Token = "0x4024532")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x04024533 RID: 148787
		[Token(Token = "0x4024533")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animComplete;

		// Token: 0x04024534 RID: 148788
		[Token(Token = "0x4024534")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MonopolyMissionMaterialItemView[] _materialItemViews;

		// Token: 0x04024535 RID: 148789
		[Token(Token = "0x4024535")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedMissionId;

		// Token: 0x04024536 RID: 148790
		[Token(Token = "0x4024536")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedComboSeqNum;

		// Token: 0x04024537 RID: 148791
		[Token(Token = "0x4024537")]
		[FieldOffset(Offset = "0x58")]
		private MonopolyMissionViewModel m_cachedMissionViewModel;

		// Token: 0x04024538 RID: 148792
		[Token(Token = "0x4024538")]
		[FieldOffset(Offset = "0x60")]
		private MonopolyMissionItemViewModel m_cachedMissionItemViewModel;

		// Token: 0x04024539 RID: 148793
		[Token(Token = "0x4024539")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_newMissionTween;

		// Token: 0x0402453A RID: 148794
		[Token(Token = "0x402453A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__PlayMissionItemEffect;

		// Token: 0x0402453B RID: 148795
		[Token(Token = "0x402453B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCombo;

		// Token: 0x0402453C RID: 148796
		[Token(Token = "0x402453C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderProgress;

		// Token: 0x0402453D RID: 148797
		[Token(Token = "0x402453D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCompleteStatus;

		// Token: 0x0402453E RID: 148798
		[Token(Token = "0x402453E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderMaterialViewContent;

		// Token: 0x0402453F RID: 148799
		[Token(Token = "0x402453F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderPreviewTag;

		// Token: 0x04024540 RID: 148800
		[Token(Token = "0x4024540")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderPreviewProgress;

		// Token: 0x04024541 RID: 148801
		[Token(Token = "0x4024541")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024542 RID: 148802
		[Token(Token = "0x4024542")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
