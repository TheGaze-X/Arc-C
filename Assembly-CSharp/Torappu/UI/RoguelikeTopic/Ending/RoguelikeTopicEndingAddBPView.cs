using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x02004685 RID: 18053
	[Token(Token = "0x2004685")]
	public class RoguelikeTopicEndingAddBPView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B685 RID: 112261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B685")]
		[Address(RVA = "0x14B22D0", Offset = "0x14B0ED0", VA = "0x1814B22D0")]
		public void Flush(string topic, GameSettleBpInfo bpAdd, float addition = 1f, bool needFactor = false, bool alwaysShow = false)
		{
		}

		// Token: 0x0601B686 RID: 112262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B686")]
		[Address(RVA = "0x14B26A0", Offset = "0x14B12A0", VA = "0x1814B26A0")]
		public void PlayShowAnim(float delay)
		{
		}

		// Token: 0x0601B687 RID: 112263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B687")]
		[Address(RVA = "0x14B2810", Offset = "0x14B1410", VA = "0x1814B2810")]
		private void _DoPlay()
		{
		}

		// Token: 0x0601B688 RID: 112264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B688")]
		[Address(RVA = "0x14B2890", Offset = "0x14B1490", VA = "0x1814B2890")]
		public RoguelikeTopicEndingAddBPView()
		{
		}

		// Token: 0x04023708 RID: 145160
		[Token(Token = "0x4023708")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _bpCount;

		// Token: 0x04023709 RID: 145161
		[Token(Token = "0x4023709")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bpImage;

		// Token: 0x0402370A RID: 145162
		[Token(Token = "0x402370A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationWrapper _anim;

		// Token: 0x0402370B RID: 145163
		[Token(Token = "0x402370B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _getNode;

		// Token: 0x0402370C RID: 145164
		[Token(Token = "0x402370C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _fullTint;

		// Token: 0x0402370D RID: 145165
		[Token(Token = "0x402370D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _maxTag;

		// Token: 0x0402370E RID: 145166
		[Token(Token = "0x402370E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Selectable _iconColor;

		// Token: 0x0402370F RID: 145167
		[Token(Token = "0x402370F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _addtionNode;

		// Token: 0x04023710 RID: 145168
		[Token(Token = "0x4023710")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _addtionLabel;

		// Token: 0x04023711 RID: 145169
		[Token(Token = "0x4023711")]
		private const string SHOW_ANIM = "ending_add_bp_show";

		// Token: 0x04023712 RID: 145170
		[Token(Token = "0x4023712")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Flush;

		// Token: 0x04023713 RID: 145171
		[Token(Token = "0x4023713")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayShowAnim;

		// Token: 0x04023714 RID: 145172
		[Token(Token = "0x4023714")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoPlay;

		// Token: 0x04023715 RID: 145173
		[Token(Token = "0x4023715")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
