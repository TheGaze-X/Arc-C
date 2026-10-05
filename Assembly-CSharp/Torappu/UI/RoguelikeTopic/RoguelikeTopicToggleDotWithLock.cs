using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044BF RID: 17599
	[Token(Token = "0x20044BF")]
	public class RoguelikeTopicToggleDotWithLock : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003FCE RID: 16334
		// (get) Token: 0x0601AE0E RID: 110094 RVA: 0x000A38D8 File Offset: 0x000A1AD8
		// (set) Token: 0x0601AE0F RID: 110095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FCE")]
		public bool isOn
		{
			[Token(Token = "0x601AE0E")]
			[Address(RVA = "0x1415640", Offset = "0x1414240", VA = "0x181415640")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601AE0F")]
			[Address(RVA = "0x14156B0", Offset = "0x14142B0", VA = "0x1814156B0")]
			set
			{
			}
		}

		// Token: 0x17003FCF RID: 16335
		// (set) Token: 0x0601AE10 RID: 110096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FCF")]
		public ROGUELIKE_TOPIC_TOGGLE_DOT_STATE toggleState
		{
			[Token(Token = "0x601AE10")]
			[Address(RVA = "0x1415740", Offset = "0x1414340", VA = "0x181415740")]
			set
			{
			}
		}

		// Token: 0x0601AE11 RID: 110097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE11")]
		[Address(RVA = "0x14154E0", Offset = "0x14140E0", VA = "0x1814154E0")]
		public void Init(int dotIndex, int dotsCountPerGroup)
		{
		}

		// Token: 0x0601AE12 RID: 110098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE12")]
		[Address(RVA = "0x14155E0", Offset = "0x14141E0", VA = "0x1814155E0")]
		public RoguelikeTopicToggleDotWithLock()
		{
		}

		// Token: 0x04022718 RID: 141080
		[Token(Token = "0x4022718")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIColorToggle _colorToggle;

		// Token: 0x04022719 RID: 141081
		[Token(Token = "0x4022719")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _lockDotImg;

		// Token: 0x0402271A RID: 141082
		[Token(Token = "0x402271A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _unCompleteDotImg;

		// Token: 0x0402271B RID: 141083
		[Token(Token = "0x402271B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _completeDotImg;

		// Token: 0x0402271C RID: 141084
		[Token(Token = "0x402271C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeTopicToggleDotWithLockPlugin _plugin;

		// Token: 0x0402271D RID: 141085
		[Token(Token = "0x402271D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isOn;

		// Token: 0x0402271E RID: 141086
		[Token(Token = "0x402271E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isOn;

		// Token: 0x0402271F RID: 141087
		[Token(Token = "0x402271F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_toggleState;

		// Token: 0x04022720 RID: 141088
		[Token(Token = "0x4022720")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022721 RID: 141089
		[Token(Token = "0x4022721")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
