using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004760 RID: 18272
	[Token(Token = "0x2004760")]
	public class RecruitGachaLimitView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BAB0 RID: 113328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAB0")]
		[Address(RVA = "0x1515B90", Offset = "0x1514790", VA = "0x181515B90")]
		public RecruitGachaLimitView()
		{
		}

		// Token: 0x04023EDE RID: 147166
		[Token(Token = "0x4023EDE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("link")]
		private Image _tktImage;

		// Token: 0x04023EDF RID: 147167
		[Token(Token = "0x4023EDF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("link")]
		private Button _shopBtn;

		// Token: 0x04023EE0 RID: 147168
		[Token(Token = "0x4023EE0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("link")]
		private Button _recruitFreeBtn;

		// Token: 0x04023EE1 RID: 147169
		[Token(Token = "0x4023EE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004761 RID: 18273
		[Token(Token = "0x2004761")]
		public struct InputData
		{
			// Token: 0x04023EE2 RID: 147170
			[Token(Token = "0x4023EE2")]
			[FieldOffset(Offset = "0x0")]
			public Sprite ticketSprite;

			// Token: 0x04023EE3 RID: 147171
			[Token(Token = "0x4023EE3")]
			[FieldOffset(Offset = "0x8")]
			public UnityAction shopAction;

			// Token: 0x04023EE4 RID: 147172
			[Token(Token = "0x4023EE4")]
			[FieldOffset(Offset = "0x10")]
			public UnityAction recruitFreeAction;
		}
	}
}
