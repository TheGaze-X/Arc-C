using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13D5
{
	// Token: 0x02007A51 RID: 31313
	[Token(Token = "0x2007A51")]
	[ExecuteInEditMode]
	public class Act13D5LineFiller : MonoBehaviour, IHotfixable
	{
		// Token: 0x170066D6 RID: 26326
		// (get) Token: 0x0602BDE3 RID: 179683 RVA: 0x000DD730 File Offset: 0x000DB930
		// (set) Token: 0x0602BDE4 RID: 179684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066D6")]
		[Inspect]
		[RangeValue(0f, 1f)]
		public float fillAmount
		{
			[Token(Token = "0x602BDE3")]
			[Address(RVA = "0x27C8F90", Offset = "0x27C7B90", VA = "0x1827C8F90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x602BDE4")]
			[Address(RVA = "0x27C8FF0", Offset = "0x27C7BF0", VA = "0x1827C8FF0")]
			set
			{
			}
		}

		// Token: 0x0602BDE5 RID: 179685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDE5")]
		[Address(RVA = "0x27C8E20", Offset = "0x27C7A20", VA = "0x1827C8E20")]
		private void _UpdateFillAmount()
		{
		}

		// Token: 0x0602BDE6 RID: 179686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDE6")]
		[Address(RVA = "0x27C8F20", Offset = "0x27C7B20", VA = "0x1827C8F20")]
		public Act13D5LineFiller()
		{
		}

		// Token: 0x0403F876 RID: 260214
		[Token(Token = "0x403F876")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectMask2D _target;

		// Token: 0x0403F877 RID: 260215
		[Token(Token = "0x403F877")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _size;

		// Token: 0x0403F878 RID: 260216
		[Token(Token = "0x403F878")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ReadOnly]
		private float _fillAmount;

		// Token: 0x0403F879 RID: 260217
		[Token(Token = "0x403F879")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Act13D5LineFiller.FillType _fillType;

		// Token: 0x0403F87A RID: 260218
		[Token(Token = "0x403F87A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fillAmount;

		// Token: 0x0403F87B RID: 260219
		[Token(Token = "0x403F87B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_fillAmount;

		// Token: 0x0403F87C RID: 260220
		[Token(Token = "0x403F87C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateFillAmount;

		// Token: 0x0403F87D RID: 260221
		[Token(Token = "0x403F87D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A52 RID: 31314
		[Token(Token = "0x2007A52")]
		public enum FillType
		{
			// Token: 0x0403F87F RID: 260223
			[Token(Token = "0x403F87F")]
			VERTICAL,
			// Token: 0x0403F880 RID: 260224
			[Token(Token = "0x403F880")]
			HORIZONTAL
		}
	}
}
