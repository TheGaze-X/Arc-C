using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047B1 RID: 18353
	[Token(Token = "0x20047B1")]
	public class RecalRuneSeasonSelectView : DataBinder<RecalRuneSeasonSelectProperty>
	{
		// Token: 0x17004212 RID: 16914
		// (get) Token: 0x0601BC9E RID: 113822 RVA: 0x000A63E0 File Offset: 0x000A45E0
		[Token(Token = "0x17004212")]
		public float itemShowDuration
		{
			[Token(Token = "0x601BC9E")]
			[Address(RVA = "0x152FFF0", Offset = "0x152EBF0", VA = "0x18152FFF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004213 RID: 16915
		// (set) Token: 0x0601BC9F RID: 113823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004213")]
		public Func<int, float> itemShowSyncer
		{
			[Token(Token = "0x601BC9F")]
			[Address(RVA = "0x15300E0", Offset = "0x152ECE0", VA = "0x1815300E0")]
			set
			{
			}
		}

		// Token: 0x0601BCA0 RID: 113824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCA0")]
		[Address(RVA = "0x152FE60", Offset = "0x152EA60", VA = "0x18152FE60", Slot = "7")]
		public override void OnValueChanged(RecalRuneSeasonSelectProperty property)
		{
		}

		// Token: 0x0601BCA1 RID: 113825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCA1")]
		[Address(RVA = "0x152FF80", Offset = "0x152EB80", VA = "0x18152FF80")]
		public RecalRuneSeasonSelectView()
		{
		}

		// Token: 0x04024245 RID: 148037
		[Token(Token = "0x4024245")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LoopHorizontalScrollRect _seasonRect;

		// Token: 0x04024246 RID: 148038
		[Token(Token = "0x4024246")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RecalRuneSeasonSelectAdapter _seasonAdapter;

		// Token: 0x04024247 RID: 148039
		[Token(Token = "0x4024247")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemShowDuration;

		// Token: 0x04024248 RID: 148040
		[Token(Token = "0x4024248")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemShowSyncer;

		// Token: 0x04024249 RID: 148041
		[Token(Token = "0x4024249")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402424A RID: 148042
		[Token(Token = "0x402424A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
