using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.BattleFinish
{
	// Token: 0x020078DF RID: 30943
	[Token(Token = "0x20078DF")]
	public class Act1LockBattleFinishKillPointView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B64A RID: 177738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B64A")]
		[Address(RVA = "0x27552C0", Offset = "0x2753EC0", VA = "0x1827552C0")]
		public void Render(FinalStageEnemyKillPointModel viewModel)
		{
		}

		// Token: 0x0602B64B RID: 177739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B64B")]
		[Address(RVA = "0x2755530", Offset = "0x2754130", VA = "0x182755530")]
		public void ShowImmediately()
		{
		}

		// Token: 0x0602B64C RID: 177740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B64C")]
		[Address(RVA = "0x2755480", Offset = "0x2754080", VA = "0x182755480")]
		public IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x0602B64D RID: 177741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B64D")]
		[Address(RVA = "0x27555A0", Offset = "0x27541A0", VA = "0x1827555A0")]
		public Act1LockBattleFinishKillPointView()
		{
		}

		// Token: 0x0403EC0A RID: 257034
		[Token(Token = "0x403EC0A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403EC0B RID: 257035
		[Token(Token = "0x403EC0B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _animName;

		// Token: 0x0403EC0C RID: 257036
		[Token(Token = "0x403EC0C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _panelSuc;

		// Token: 0x0403EC0D RID: 257037
		[Token(Token = "0x403EC0D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _panelFail;

		// Token: 0x0403EC0E RID: 257038
		[Token(Token = "0x403EC0E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _panelNoInfo;

		// Token: 0x0403EC0F RID: 257039
		[Token(Token = "0x403EC0F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textEnemyNameSuc;

		// Token: 0x0403EC10 RID: 257040
		[Token(Token = "0x403EC10")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textEnemyNameFail;

		// Token: 0x0403EC11 RID: 257041
		[Token(Token = "0x403EC11")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textPoint;

		// Token: 0x0403EC12 RID: 257042
		[Token(Token = "0x403EC12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403EC13 RID: 257043
		[Token(Token = "0x403EC13")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0403EC14 RID: 257044
		[Token(Token = "0x403EC14")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403EC15 RID: 257045
		[Token(Token = "0x403EC15")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
