using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003377 RID: 13175
	[Token(Token = "0x2003377")]
	public class UIDamageText : UINumericText
	{
		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0601504B RID: 86091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031F1")]
		protected override string format
		{
			[Token(Token = "0x601504B")]
			[Address(RVA = "0xD6FA80", Offset = "0xD6E680", VA = "0x180D6FA80", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601504C RID: 86092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601504C")]
		[Address(RVA = "0xD6F6C0", Offset = "0xD6E2C0", VA = "0x180D6F6C0", Slot = "9")]
		protected override void SetTweens(float duration)
		{
		}

		// Token: 0x0601504D RID: 86093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601504D")]
		[Address(RVA = "0xD6FA00", Offset = "0xD6E600", VA = "0x180D6FA00")]
		public UIDamageText()
		{
		}

		// Token: 0x0401902E RID: 102446
		[Token(Token = "0x401902E")]
		private const float CRITICAL_FONT_SIZE_SCALE = 1.1f;

		// Token: 0x0401902F RID: 102447
		[Token(Token = "0x401902F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _upOffset;

		// Token: 0x04019030 RID: 102448
		[Token(Token = "0x4019030")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _downOffset;

		// Token: 0x04019031 RID: 102449
		[Token(Token = "0x4019031")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _fontSizeScale;

		// Token: 0x04019032 RID: 102450
		[Token(Token = "0x4019032")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_format;

		// Token: 0x04019033 RID: 102451
		[Token(Token = "0x4019033")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetTweens;

		// Token: 0x04019034 RID: 102452
		[Token(Token = "0x4019034")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
