using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003383 RID: 13187
	[Token(Token = "0x2003383")]
	public class UIHealText : UINumericText
	{
		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x06015086 RID: 86150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031F8")]
		protected override string format
		{
			[Token(Token = "0x6015086")]
			[Address(RVA = "0xD740C0", Offset = "0xD72CC0", VA = "0x180D740C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015087 RID: 86151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015087")]
		[Address(RVA = "0xD73E20", Offset = "0xD72A20", VA = "0x180D73E20", Slot = "9")]
		protected override void SetTweens(float duration)
		{
		}

		// Token: 0x06015088 RID: 86152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015088")]
		[Address(RVA = "0xD74050", Offset = "0xD72C50", VA = "0x180D74050")]
		public UIHealText()
		{
		}

		// Token: 0x0401907E RID: 102526
		[Token(Token = "0x401907E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _floatOffset;

		// Token: 0x0401907F RID: 102527
		[Token(Token = "0x401907F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_format;

		// Token: 0x04019080 RID: 102528
		[Token(Token = "0x4019080")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetTweens;

		// Token: 0x04019081 RID: 102529
		[Token(Token = "0x4019081")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
