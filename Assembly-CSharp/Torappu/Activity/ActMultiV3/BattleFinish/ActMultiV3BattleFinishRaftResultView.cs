using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x02007095 RID: 28821
	[Token(Token = "0x2007095")]
	public class ActMultiV3BattleFinishRaftResultView : ActMultiV3BattleFinishResultViewBase
	{
		// Token: 0x170060E7 RID: 24807
		// (get) Token: 0x06028F24 RID: 167716 RVA: 0x000D3A70 File Offset: 0x000D1C70
		[Token(Token = "0x170060E7")]
		public override ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028F24")]
			[Address(RVA = "0x24505A0", Offset = "0x244F1A0", VA = "0x1824505A0", Slot = "4")]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
		}

		// Token: 0x06028F25 RID: 167717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F25")]
		[Address(RVA = "0x2450390", Offset = "0x244EF90", VA = "0x182450390", Slot = "5")]
		protected override void OnRender()
		{
		}

		// Token: 0x06028F26 RID: 167718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F26")]
		[Address(RVA = "0x2450500", Offset = "0x244F100", VA = "0x182450500")]
		public ActMultiV3BattleFinishRaftResultView()
		{
		}

		// Token: 0x0403A6FB RID: 239355
		[Token(Token = "0x403A6FB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _scoreText;

		// Token: 0x0403A6FC RID: 239356
		[Token(Token = "0x403A6FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x0403A6FD RID: 239357
		[Token(Token = "0x403A6FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403A6FE RID: 239358
		[Token(Token = "0x403A6FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
