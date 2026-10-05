using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.BattleFinish;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DF1 RID: 28145
	[Token(Token = "0x2006DF1")]
	public class ActVecBreakV2OffenseBattleFinishView : DynBattleFinishView
	{
		// Token: 0x06028127 RID: 164135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028127")]
		[Address(RVA = "0x2354330", Offset = "0x2352F30", VA = "0x182354330", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06028128 RID: 164136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028128")]
		[Address(RVA = "0x23545F0", Offset = "0x23531F0", VA = "0x1823545F0", Slot = "7")]
		public override IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x06028129 RID: 164137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028129")]
		[Address(RVA = "0x2354710", Offset = "0x2353310", VA = "0x182354710")]
		private void _OnNextClick()
		{
		}

		// Token: 0x0602812A RID: 164138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602812A")]
		[Address(RVA = "0x23546B0", Offset = "0x23532B0", VA = "0x1823546B0")]
		private void _OnCloseClick()
		{
		}

		// Token: 0x0602812B RID: 164139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602812B")]
		[Address(RVA = "0x2354770", Offset = "0x2353370", VA = "0x182354770")]
		private void _PlaySoundEffect()
		{
		}

		// Token: 0x0602812C RID: 164140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602812C")]
		[Address(RVA = "0x2354860", Offset = "0x2353460", VA = "0x182354860")]
		public ActVecBreakV2OffenseBattleFinishView()
		{
		}

		// Token: 0x0602812E RID: 164142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602812E")]
		[Address(RVA = "0x17E4700", Offset = "0x17E3300", VA = "0x1817E4700")]
		private IEnumerator <>xLuaBaseProxy_ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x04038D90 RID: 232848
		[Token(Token = "0x4038D90")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActVecBreakV2OffenseBattleFinishAnimationView _normalAnimViewPrefab;

		// Token: 0x04038D91 RID: 232849
		[Token(Token = "0x4038D91")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActVecBreakV2OffenseBattleFinishAnimationView _hardAnimViewPrefab;

		// Token: 0x04038D92 RID: 232850
		[Token(Token = "0x4038D92")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _viewHolder;

		// Token: 0x04038D93 RID: 232851
		[Token(Token = "0x4038D93")]
		[FieldOffset(Offset = "0x38")]
		private bool m_confirmFirstStep;

		// Token: 0x04038D94 RID: 232852
		[Token(Token = "0x4038D94")]
		[FieldOffset(Offset = "0x40")]
		private ActVecBreakV2OffenseBattleFinishAnimationView m_animView;

		// Token: 0x04038D95 RID: 232853
		[Token(Token = "0x4038D95")]
		[FieldOffset(Offset = "0x48")]
		private ActVecBreakV2OffenseBattleFinishViewModel m_viewModel;

		// Token: 0x04038D96 RID: 232854
		[Token(Token = "0x4038D96")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04038D97 RID: 232855
		[Token(Token = "0x4038D97")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x04038D98 RID: 232856
		[Token(Token = "0x4038D98")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnNextClick;

		// Token: 0x04038D99 RID: 232857
		[Token(Token = "0x4038D99")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCloseClick;

		// Token: 0x04038D9A RID: 232858
		[Token(Token = "0x4038D9A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlaySoundEffect;

		// Token: 0x04038D9B RID: 232859
		[Token(Token = "0x4038D9B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
