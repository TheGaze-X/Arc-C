using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002813 RID: 10259
	[Token(Token = "0x2002813")]
	public class DialogDecisionButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x0601111A RID: 69914 RVA: 0x00069300 File Offset: 0x00067500
		// (set) Token: 0x0601111B RID: 69915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025A1")]
		public int optionIndex
		{
			[Token(Token = "0x601111A")]
			[Address(RVA = "0x8F3410", Offset = "0x8F2010", VA = "0x1808F3410")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601111B")]
			[Address(RVA = "0x8F3470", Offset = "0x8F2070", VA = "0x1808F3470")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x0601111C RID: 69916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025A2")]
		public Button optionButton
		{
			[Token(Token = "0x601111C")]
			[Address(RVA = "0x8F33B0", Offset = "0x8F1FB0", VA = "0x1808F33B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601111D RID: 69917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601111D")]
		[Address(RVA = "0x8F3080", Offset = "0x8F1C80", VA = "0x1808F3080")]
		public void UpdateData(BattleDialogOption option)
		{
		}

		// Token: 0x0601111E RID: 69918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601111E")]
		[Address(RVA = "0x8F2D60", Offset = "0x8F1960", VA = "0x1808F2D60")]
		public void Hide(bool fast = false)
		{
		}

		// Token: 0x0601111F RID: 69919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601111F")]
		[Address(RVA = "0x8F2F90", Offset = "0x8F1B90", VA = "0x1808F2F90")]
		private void OnDestroy()
		{
		}

		// Token: 0x06011120 RID: 69920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011120")]
		[Address(RVA = "0x8F3350", Offset = "0x8F1F50", VA = "0x1808F3350")]
		public DialogDecisionButton()
		{
		}

		// Token: 0x040131E9 RID: 78313
		[Token(Token = "0x40131E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _optionText;

		// Token: 0x040131EA RID: 78314
		[Token(Token = "0x40131EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _optionButton;

		// Token: 0x040131EB RID: 78315
		[Token(Token = "0x40131EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeTime;

		// Token: 0x040131EC RID: 78316
		[Token(Token = "0x40131EC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Ease _easeType;

		// Token: 0x040131ED RID: 78317
		[Token(Token = "0x40131ED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Graphic[] _fade;

		// Token: 0x040131EF RID: 78319
		[Token(Token = "0x40131EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_optionIndex;

		// Token: 0x040131F0 RID: 78320
		[Token(Token = "0x40131F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_optionIndex;

		// Token: 0x040131F1 RID: 78321
		[Token(Token = "0x40131F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_optionButton;

		// Token: 0x040131F2 RID: 78322
		[Token(Token = "0x40131F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040131F3 RID: 78323
		[Token(Token = "0x40131F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040131F4 RID: 78324
		[Token(Token = "0x40131F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040131F5 RID: 78325
		[Token(Token = "0x40131F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
