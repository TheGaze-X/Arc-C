using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02007012 RID: 28690
	[Token(Token = "0x2007012")]
	public class ActMultiV3TrainingRoomBillboardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006020 RID: 24608
		// (get) Token: 0x06028B8E RID: 166798 RVA: 0x000D2C48 File Offset: 0x000D0E48
		[Token(Token = "0x17006020")]
		public UIAnimationLocation animShow
		{
			[Token(Token = "0x6028B8E")]
			[Address(RVA = "0x2415480", Offset = "0x2414080", VA = "0x182415480")]
			get
			{
				return default(UIAnimationLocation);
			}
		}

		// Token: 0x06028B8F RID: 166799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B8F")]
		[Address(RVA = "0x2415420", Offset = "0x2414020", VA = "0x182415420")]
		public ActMultiV3TrainingRoomBillboardView()
		{
		}

		// Token: 0x0403A0F8 RID: 237816
		[Token(Token = "0x403A0F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0403A0F9 RID: 237817
		[Token(Token = "0x403A0F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animShow;

		// Token: 0x0403A0FA RID: 237818
		[Token(Token = "0x403A0FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
