using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032E1 RID: 13025
	[Token(Token = "0x20032E1")]
	public class UIBattleLoadingDecor : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x06014B51 RID: 84817 RVA: 0x000880E0 File Offset: 0x000862E0
		[Token(Token = "0x17003107")]
		public bool hideOriginDecor
		{
			[Token(Token = "0x6014B51")]
			[Address(RVA = "0xD20C90", Offset = "0xD1F890", VA = "0x180D20C90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x06014B52 RID: 84818 RVA: 0x000880F8 File Offset: 0x000862F8
		[Token(Token = "0x17003108")]
		public bool hideCover
		{
			[Token(Token = "0x6014B52")]
			[Address(RVA = "0xD20C30", Offset = "0xD1F830", VA = "0x180D20C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014B53 RID: 84819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B53")]
		[Address(RVA = "0xD20820", Offset = "0xD1F420", VA = "0x180D20820")]
		public void Render(BattleStageInfo stageInfo)
		{
		}

		// Token: 0x06014B54 RID: 84820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B54")]
		[Address(RVA = "0xD20750", Offset = "0xD1F350", VA = "0x180D20750")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014B55 RID: 84821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B55")]
		[Address(RVA = "0xD20B80", Offset = "0xD1F780", VA = "0x180D20B80")]
		public UIBattleLoadingDecor()
		{
		}

		// Token: 0x04018984 RID: 100740
		[Token(Token = "0x4018984")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIStageInfo _stageInfo;

		// Token: 0x04018985 RID: 100741
		[Token(Token = "0x4018985")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _hideOriginDecor;

		// Token: 0x04018986 RID: 100742
		[Token(Token = "0x4018986")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _hideCover;

		// Token: 0x04018987 RID: 100743
		[Token(Token = "0x4018987")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UITipsHolderForBattle _tipsHolder;

		// Token: 0x04018988 RID: 100744
		[Token(Token = "0x4018988")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation[] _loopAnims;

		// Token: 0x04018989 RID: 100745
		[Token(Token = "0x4018989")]
		[FieldOffset(Offset = "0x38")]
		private List<Tween> m_animTweens;

		// Token: 0x0401898A RID: 100746
		[Token(Token = "0x401898A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hideOriginDecor;

		// Token: 0x0401898B RID: 100747
		[Token(Token = "0x401898B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hideCover;

		// Token: 0x0401898C RID: 100748
		[Token(Token = "0x401898C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401898D RID: 100749
		[Token(Token = "0x401898D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401898E RID: 100750
		[Token(Token = "0x401898E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
