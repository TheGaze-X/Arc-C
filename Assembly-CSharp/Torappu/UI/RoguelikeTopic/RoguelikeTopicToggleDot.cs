using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044BD RID: 17597
	[Token(Token = "0x20044BD")]
	public class RoguelikeTopicToggleDot : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003FCC RID: 16332
		// (get) Token: 0x0601AE0A RID: 110090 RVA: 0x000A38C0 File Offset: 0x000A1AC0
		// (set) Token: 0x0601AE0B RID: 110091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FCC")]
		public bool isOn
		{
			[Token(Token = "0x601AE0A")]
			[Address(RVA = "0x14158B0", Offset = "0x14144B0", VA = "0x1814158B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601AE0B")]
			[Address(RVA = "0x1415A00", Offset = "0x1414600", VA = "0x181415A00")]
			set
			{
			}
		}

		// Token: 0x17003FCD RID: 16333
		// (set) Token: 0x0601AE0C RID: 110092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FCD")]
		public bool isComplete
		{
			[Token(Token = "0x601AE0C")]
			[Address(RVA = "0x1415920", Offset = "0x1414520", VA = "0x181415920")]
			set
			{
			}
		}

		// Token: 0x0601AE0D RID: 110093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE0D")]
		[Address(RVA = "0x1415850", Offset = "0x1414450", VA = "0x181415850")]
		public RoguelikeTopicToggleDot()
		{
		}

		// Token: 0x0402270D RID: 141069
		[Token(Token = "0x402270D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIColorToggle _colorToggle;

		// Token: 0x0402270E RID: 141070
		[Token(Token = "0x402270E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _dotImg;

		// Token: 0x0402270F RID: 141071
		[Token(Token = "0x402270F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _completeDotImg;

		// Token: 0x04022710 RID: 141072
		[Token(Token = "0x4022710")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isOn;

		// Token: 0x04022711 RID: 141073
		[Token(Token = "0x4022711")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isOn;

		// Token: 0x04022712 RID: 141074
		[Token(Token = "0x4022712")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isComplete;

		// Token: 0x04022713 RID: 141075
		[Token(Token = "0x4022713")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
