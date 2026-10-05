using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.BattleFinish
{
	// Token: 0x020078E2 RID: 30946
	[Token(Token = "0x20078E2")]
	public class Act1LockBattleFinishTotalPointView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700659F RID: 26015
		// (get) Token: 0x0602B657 RID: 177751 RVA: 0x000DBBD0 File Offset: 0x000D9DD0
		// (set) Token: 0x0602B658 RID: 177752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700659F")]
		public bool isShowing
		{
			[Token(Token = "0x602B657")]
			[Address(RVA = "0x2755C10", Offset = "0x2754810", VA = "0x182755C10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602B658")]
			[Address(RVA = "0x2755C70", Offset = "0x2754870", VA = "0x182755C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602B659 RID: 177753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B659")]
		[Address(RVA = "0x27556B0", Offset = "0x27542B0", VA = "0x1827556B0")]
		public void Render(FinalStagePointModel viewModel)
		{
		}

		// Token: 0x0602B65A RID: 177754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B65A")]
		[Address(RVA = "0x27559E0", Offset = "0x27545E0", VA = "0x1827559E0")]
		public void ShowImmediately()
		{
		}

		// Token: 0x0602B65B RID: 177755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B65B")]
		[Address(RVA = "0x2755930", Offset = "0x2754530", VA = "0x182755930")]
		public IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x0602B65C RID: 177756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B65C")]
		[Address(RVA = "0x2755600", Offset = "0x2754200", VA = "0x182755600")]
		public IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x0602B65D RID: 177757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B65D")]
		[Address(RVA = "0x2755BB0", Offset = "0x27547B0", VA = "0x182755BB0")]
		public Act1LockBattleFinishTotalPointView()
		{
		}

		// Token: 0x0403EC1A RID: 257050
		[Token(Token = "0x403EC1A")]
		private const float FADE_TIME = 0.2f;

		// Token: 0x0403EC1B RID: 257051
		[Token(Token = "0x403EC1B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403EC1C RID: 257052
		[Token(Token = "0x403EC1C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _animClearPoint;

		// Token: 0x0403EC1D RID: 257053
		[Token(Token = "0x403EC1D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _animTotalPoint;

		// Token: 0x0403EC1E RID: 257054
		[Token(Token = "0x403EC1E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403EC1F RID: 257055
		[Token(Token = "0x403EC1F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textClearPoint;

		// Token: 0x0403EC20 RID: 257056
		[Token(Token = "0x403EC20")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textTotalPoint;

		// Token: 0x0403EC21 RID: 257057
		[Token(Token = "0x403EC21")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private EasyInstancePool _enemyKillPoints;

		// Token: 0x0403EC23 RID: 257059
		[Token(Token = "0x403EC23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShowing;

		// Token: 0x0403EC24 RID: 257060
		[Token(Token = "0x403EC24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isShowing;

		// Token: 0x0403EC25 RID: 257061
		[Token(Token = "0x403EC25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403EC26 RID: 257062
		[Token(Token = "0x403EC26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0403EC27 RID: 257063
		[Token(Token = "0x403EC27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403EC28 RID: 257064
		[Token(Token = "0x403EC28")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403EC29 RID: 257065
		[Token(Token = "0x403EC29")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
