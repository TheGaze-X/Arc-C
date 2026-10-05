using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003858 RID: 14424
	[Token(Token = "0x2003858")]
	public class UIRectTransformFitter : MonoBehaviour
	{
		// Token: 0x06016D98 RID: 93592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D98")]
		[Address(RVA = "0xF4C390", Offset = "0xF4AF90", VA = "0x180F4C390")]
		public void Update()
		{
		}

		// Token: 0x06016D99 RID: 93593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D99")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIRectTransformFitter()
		{
		}

		// Token: 0x0401B8E7 RID: 112871
		[Token(Token = "0x401B8E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _targetRect;

		// Token: 0x0401B8E8 RID: 112872
		[Token(Token = "0x401B8E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _padding;
	}
}
