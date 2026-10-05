using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x0200468B RID: 18059
	[Token(Token = "0x200468B")]
	public class RoguelikeTopicEndingGpView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B69D RID: 112285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B69D")]
		[Address(RVA = "0x14B3B10", Offset = "0x14B2710", VA = "0x1814B3B10")]
		public void Flush(RoguelikeTopicEndingBpAndGpView.Model model)
		{
		}

		// Token: 0x0601B69E RID: 112286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B69E")]
		[Address(RVA = "0x14B3FF0", Offset = "0x14B2BF0", VA = "0x1814B3FF0")]
		private void _SetGP(int v)
		{
		}

		// Token: 0x0601B69F RID: 112287 RVA: 0x000A5258 File Offset: 0x000A3458
		[Token(Token = "0x601B69F")]
		[Address(RVA = "0x14B3F90", Offset = "0x14B2B90", VA = "0x1814B3F90")]
		private int _GetGP()
		{
			return 0;
		}

		// Token: 0x0601B6A0 RID: 112288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6A0")]
		[Address(RVA = "0x14B40E0", Offset = "0x14B2CE0", VA = "0x1814B40E0")]
		public RoguelikeTopicEndingGpView()
		{
		}

		// Token: 0x0402373D RID: 145213
		[Token(Token = "0x402373D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _gpIcon;

		// Token: 0x0402373E RID: 145214
		[Token(Token = "0x402373E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _gpName;

		// Token: 0x0402373F RID: 145215
		[Token(Token = "0x402373F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _gpCount;

		// Token: 0x04023740 RID: 145216
		[Token(Token = "0x4023740")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _tweenGpDur;

		// Token: 0x04023741 RID: 145217
		[Token(Token = "0x4023741")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_gpTween;

		// Token: 0x04023742 RID: 145218
		[Token(Token = "0x4023742")]
		[FieldOffset(Offset = "0x40")]
		private int m_tempGp;

		// Token: 0x04023743 RID: 145219
		[Token(Token = "0x4023743")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Flush;

		// Token: 0x04023744 RID: 145220
		[Token(Token = "0x4023744")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetGP;

		// Token: 0x04023745 RID: 145221
		[Token(Token = "0x4023745")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetGP;

		// Token: 0x04023746 RID: 145222
		[Token(Token = "0x4023746")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
