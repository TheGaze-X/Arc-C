using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x0200341E RID: 13342
	[Token(Token = "0x200341E")]
	public class UICooperateSailBoatWaterFlowPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015527 RID: 87335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015527")]
		[Address(RVA = "0xDDAE80", Offset = "0xDD9A80", VA = "0x180DDAE80")]
		public void UpdateWaterForce(int level, BoatDirection waterDir)
		{
		}

		// Token: 0x06015528 RID: 87336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015528")]
		[Address(RVA = "0xDDB330", Offset = "0xDD9F30", VA = "0x180DDB330")]
		public UICooperateSailBoatWaterFlowPanel()
		{
		}

		// Token: 0x04019800 RID: 104448
		[Token(Token = "0x4019800")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _fastBg;

		// Token: 0x04019801 RID: 104449
		[Token(Token = "0x4019801")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _slowBg;

		// Token: 0x04019802 RID: 104450
		[Token(Token = "0x4019802")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _directionStop;

		// Token: 0x04019803 RID: 104451
		[Token(Token = "0x4019803")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _maskShowStop;

		// Token: 0x04019804 RID: 104452
		[Token(Token = "0x4019804")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<UICooperateSailBoatWaterFlowPanel.WaterFlowAnimation> _dirAnimations;

		// Token: 0x04019805 RID: 104453
		[Token(Token = "0x4019805")]
		[FieldOffset(Offset = "0x48")]
		private int m_waterForceLevel;

		// Token: 0x04019806 RID: 104454
		[Token(Token = "0x4019806")]
		[FieldOffset(Offset = "0x4C")]
		private BoatDirection m_waterForceDir;

		// Token: 0x04019807 RID: 104455
		[Token(Token = "0x4019807")]
		[FieldOffset(Offset = "0x50")]
		private UICooperateSailBoatWaterFlowItem m_lastWaterFlowItem;

		// Token: 0x04019808 RID: 104456
		[Token(Token = "0x4019808")]
		private const int FAST_MODE_START_LEVEL = 3;

		// Token: 0x04019809 RID: 104457
		[Token(Token = "0x4019809")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateWaterForce;

		// Token: 0x0401980A RID: 104458
		[Token(Token = "0x401980A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200341F RID: 13343
		[Token(Token = "0x200341F")]
		[Serializable]
		private struct WaterFlowAnimation
		{
			// Token: 0x0401980B RID: 104459
			[Token(Token = "0x401980B")]
			[FieldOffset(Offset = "0x0")]
			public BoatDirection direction;

			// Token: 0x0401980C RID: 104460
			[Token(Token = "0x401980C")]
			[FieldOffset(Offset = "0x8")]
			public UICooperateSailBoatWaterFlowItem dirItem;
		}
	}
}
