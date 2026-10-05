using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A21 RID: 31265
	[Token(Token = "0x2007A21")]
	public class Act13sideAnimEmojiView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170066BA RID: 26298
		// (get) Token: 0x0602BD09 RID: 179465 RVA: 0x000DD520 File Offset: 0x000DB720
		[Token(Token = "0x170066BA")]
		public UIAnimationLocation enterAnim
		{
			[Token(Token = "0x602BD09")]
			[Address(RVA = "0x27ABA70", Offset = "0x27AA670", VA = "0x1827ABA70")]
			get
			{
				return default(UIAnimationLocation);
			}
		}

		// Token: 0x0602BD0A RID: 179466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD0A")]
		[Address(RVA = "0x27ABA10", Offset = "0x27AA610", VA = "0x1827ABA10")]
		public Act13sideAnimEmojiView()
		{
		}

		// Token: 0x0403F64D RID: 259661
		[Token(Token = "0x403F64D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403F64E RID: 259662
		[Token(Token = "0x403F64E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enterAnim;

		// Token: 0x0403F64F RID: 259663
		[Token(Token = "0x403F64F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
