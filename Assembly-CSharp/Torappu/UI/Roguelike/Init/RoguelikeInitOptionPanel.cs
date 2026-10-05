using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057E6 RID: 22502
	[Token(Token = "0x20057E6")]
	public class RoguelikeInitOptionPanel : RoguelikeInitStepPanel<RoguelikeInitOptionContext>
	{
		// Token: 0x06020E7F RID: 134783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020E7F")]
		[Address(RVA = "0x1B3DCE0", Offset = "0x1B3C8E0", VA = "0x181B3DCE0")]
		private RoguelikeInitOption _CreateOption()
		{
			return null;
		}

		// Token: 0x06020E80 RID: 134784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E80")]
		[Address(RVA = "0x1B3D410", Offset = "0x1B3C010", VA = "0x181B3D410", Slot = "8")]
		protected override void OnUpdateContext(bool isNew)
		{
		}

		// Token: 0x06020E81 RID: 134785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E81")]
		[Address(RVA = "0x1B3E1E0", Offset = "0x1B3CDE0", VA = "0x181B3E1E0")]
		private void _SetOptionActive(int idx)
		{
		}

		// Token: 0x06020E82 RID: 134786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E82")]
		[Address(RVA = "0x1B3E080", Offset = "0x1B3CC80", VA = "0x181B3E080")]
		private void _SetAllOptionActive(Func<RoguelikeInitOption, bool> pred)
		{
		}

		// Token: 0x06020E83 RID: 134787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E83")]
		[Address(RVA = "0x1B3DFC0", Offset = "0x1B3CBC0", VA = "0x181B3DFC0")]
		private void _EventOptionSelectResponse(int idx)
		{
		}

		// Token: 0x06020E84 RID: 134788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E84")]
		[Address(RVA = "0x1B3D2C0", Offset = "0x1B3BEC0", VA = "0x181B3D2C0")]
		public void EventBackgroundPressed()
		{
		}

		// Token: 0x06020E85 RID: 134789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E85")]
		[Address(RVA = "0x1B3D7E0", Offset = "0x1B3C3E0", VA = "0x181B3D7E0")]
		private void Update()
		{
		}

		// Token: 0x06020E86 RID: 134790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E86")]
		[Address(RVA = "0x1B3D930", Offset = "0x1B3C530", VA = "0x181B3D930")]
		private void _Adjust()
		{
		}

		// Token: 0x06020E87 RID: 134791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E87")]
		[Address(RVA = "0x1B3E2D0", Offset = "0x1B3CED0", VA = "0x181B3E2D0")]
		public RoguelikeInitOptionPanel()
		{
		}

		// Token: 0x0402CB8A RID: 183178
		[Token(Token = "0x402CB8A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x0402CB8B RID: 183179
		[Token(Token = "0x402CB8B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402CB8C RID: 183180
		[Token(Token = "0x402CB8C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _scrollViewport;

		// Token: 0x0402CB8D RID: 183181
		[Token(Token = "0x402CB8D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _rightHintThreshold;

		// Token: 0x0402CB8E RID: 183182
		[Token(Token = "0x402CB8E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _rightHintPanel;

		// Token: 0x0402CB8F RID: 183183
		[Token(Token = "0x402CB8F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _supportHint;

		// Token: 0x0402CB90 RID: 183184
		[Token(Token = "0x402CB90")]
		[FieldOffset(Offset = "0x68")]
		private ItemPool<RoguelikeInitOption> m_options;

		// Token: 0x0402CB91 RID: 183185
		[Token(Token = "0x402CB91")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CreateOption;

		// Token: 0x0402CB92 RID: 183186
		[Token(Token = "0x402CB92")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpdateContext;

		// Token: 0x0402CB93 RID: 183187
		[Token(Token = "0x402CB93")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetOptionActive;

		// Token: 0x0402CB94 RID: 183188
		[Token(Token = "0x402CB94")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetAllOptionActive;

		// Token: 0x0402CB95 RID: 183189
		[Token(Token = "0x402CB95")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOptionSelectResponse;

		// Token: 0x0402CB96 RID: 183190
		[Token(Token = "0x402CB96")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventBackgroundPressed;

		// Token: 0x0402CB97 RID: 183191
		[Token(Token = "0x402CB97")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402CB98 RID: 183192
		[Token(Token = "0x402CB98")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Adjust;

		// Token: 0x0402CB99 RID: 183193
		[Token(Token = "0x402CB99")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
