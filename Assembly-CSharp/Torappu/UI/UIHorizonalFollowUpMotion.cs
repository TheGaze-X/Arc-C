using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003708 RID: 14088
	[Token(Token = "0x2003708")]
	public class UIHorizonalFollowUpMotion : MonoBehaviour, IHotfixable
	{
		// Token: 0x060165D1 RID: 91601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165D1")]
		[Address(RVA = "0xED1850", Offset = "0xED0450", VA = "0x180ED1850")]
		private void Update()
		{
		}

		// Token: 0x060165D2 RID: 91602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165D2")]
		[Address(RVA = "0xED1A70", Offset = "0xED0670", VA = "0x180ED1A70")]
		public UIHorizonalFollowUpMotion()
		{
		}

		// Token: 0x0401AE6E RID: 110190
		[Token(Token = "0x401AE6E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _target;

		// Token: 0x0401AE6F RID: 110191
		[Token(Token = "0x401AE6F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _scale;

		// Token: 0x0401AE70 RID: 110192
		[Token(Token = "0x401AE70")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _offset;

		// Token: 0x0401AE71 RID: 110193
		[Token(Token = "0x401AE71")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _delay;

		// Token: 0x0401AE72 RID: 110194
		[Token(Token = "0x401AE72")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform m_trans;

		// Token: 0x0401AE73 RID: 110195
		[Token(Token = "0x401AE73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401AE74 RID: 110196
		[Token(Token = "0x401AE74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
