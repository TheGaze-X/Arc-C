using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006355 RID: 25429
	[Token(Token = "0x2006355")]
	public class AutoChessShopTopView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024B0A RID: 150282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B0A")]
		[Address(RVA = "0x1F8D740", Offset = "0x1F8C340", VA = "0x181F8D740")]
		public void Render(AutoChessShopStatus shopStatus, int curAssistCnt, int maxCanAssistCnt, int notTopicCharCnt, AutoChessShopQuickEditType quickEditType)
		{
		}

		// Token: 0x06024B0B RID: 150283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B0B")]
		[Address(RVA = "0x1F8DB10", Offset = "0x1F8C710", VA = "0x181F8DB10")]
		public void TutorialOnly_RegisterTutorialGo()
		{
		}

		// Token: 0x06024B0C RID: 150284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B0C")]
		[Address(RVA = "0x1F8DC00", Offset = "0x1F8C800", VA = "0x181F8DC00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024B0D RID: 150285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B0D")]
		[Address(RVA = "0x1F8D500", Offset = "0x1F8C100", VA = "0x181F8D500")]
		public void OnClickAssistBtn()
		{
		}

		// Token: 0x06024B0E RID: 150286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B0E")]
		[Address(RVA = "0x1F8D6A0", Offset = "0x1F8C2A0", VA = "0x181F8D6A0")]
		public void OnClickQuickSetBtn()
		{
		}

		// Token: 0x06024B0F RID: 150287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B0F")]
		[Address(RVA = "0x1F8D5A0", Offset = "0x1F8C1A0", VA = "0x181F8D5A0")]
		public void OnClickEditTypeToggle()
		{
		}

		// Token: 0x06024B10 RID: 150288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B10")]
		[Address(RVA = "0x1F8DE00", Offset = "0x1F8CA00", VA = "0x181F8DE00")]
		public AutoChessShopTopView()
		{
		}

		// Token: 0x04033392 RID: 209810
		[Token(Token = "0x4033392")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasListInfoPart;

		// Token: 0x04033393 RID: 209811
		[Token(Token = "0x4033393")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objAssistCheck;

		// Token: 0x04033394 RID: 209812
		[Token(Token = "0x4033394")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objAssistMask;

		// Token: 0x04033395 RID: 209813
		[Token(Token = "0x4033395")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _btnAssist;

		// Token: 0x04033396 RID: 209814
		[Token(Token = "0x4033396")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtAssistInfo;

		// Token: 0x04033397 RID: 209815
		[Token(Token = "0x4033397")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasQuickSetPart;

		// Token: 0x04033398 RID: 209816
		[Token(Token = "0x4033398")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _editTypeSwitchAnim;

		// Token: 0x04033399 RID: 209817
		[Token(Token = "0x4033399")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0403339A RID: 209818
		[Token(Token = "0x403339A")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403339B RID: 209819
		[Token(Token = "0x403339B")]
		[FieldOffset(Offset = "0x70")]
		private FadeSwitchTween m_tweenListInfoPart;

		// Token: 0x0403339C RID: 209820
		[Token(Token = "0x403339C")]
		[FieldOffset(Offset = "0x78")]
		private FadeSwitchTween m_tweenQuickSetPart;

		// Token: 0x0403339D RID: 209821
		[Token(Token = "0x403339D")]
		[FieldOffset(Offset = "0x80")]
		private AnimationSwitchTween m_editTypeSwitchTween;

		// Token: 0x0403339E RID: 209822
		[Token(Token = "0x403339E")]
		[FieldOffset(Offset = "0x88")]
		private AutoChessShopQuickEditType m_cachedQuickEditType;

		// Token: 0x0403339F RID: 209823
		[Token(Token = "0x403339F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040333A0 RID: 209824
		[Token(Token = "0x40333A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TutorialOnly_RegisterTutorialGo;

		// Token: 0x040333A1 RID: 209825
		[Token(Token = "0x40333A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040333A2 RID: 209826
		[Token(Token = "0x40333A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickAssistBtn;

		// Token: 0x040333A3 RID: 209827
		[Token(Token = "0x40333A3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickQuickSetBtn;

		// Token: 0x040333A4 RID: 209828
		[Token(Token = "0x40333A4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickEditTypeToggle;

		// Token: 0x040333A5 RID: 209829
		[Token(Token = "0x40333A5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
