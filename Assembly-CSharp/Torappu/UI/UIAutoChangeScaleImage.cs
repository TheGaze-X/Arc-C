using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039CF RID: 14799
	[Token(Token = "0x20039CF")]
	public class UIAutoChangeScaleImage : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017608 RID: 95752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017608")]
		[Address(RVA = "0xFBBE70", Offset = "0xFBAA70", VA = "0x180FBBE70")]
		public void ToInitScale()
		{
		}

		// Token: 0x06017609 RID: 95753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017609")]
		[Address(RVA = "0xFBBD70", Offset = "0xFBA970", VA = "0x180FBBD70")]
		public void OnValueChanged(Vector2 value)
		{
		}

		// Token: 0x0601760A RID: 95754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601760A")]
		[Address(RVA = "0xFBBF20", Offset = "0xFBAB20", VA = "0x180FBBF20")]
		public UIAutoChangeScaleImage()
		{
		}

		// Token: 0x0401C3C3 RID: 115651
		[Token(Token = "0x401C3C3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _autoChangeScale;

		// Token: 0x0401C3C4 RID: 115652
		[Token(Token = "0x401C3C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minValue;

		// Token: 0x0401C3C5 RID: 115653
		[Token(Token = "0x401C3C5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _maxValue;

		// Token: 0x0401C3C6 RID: 115654
		[Token(Token = "0x401C3C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isHorizon;

		// Token: 0x0401C3C7 RID: 115655
		[Token(Token = "0x401C3C7")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _initValue;

		// Token: 0x0401C3C8 RID: 115656
		[Token(Token = "0x401C3C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ToInitScale;

		// Token: 0x0401C3C9 RID: 115657
		[Token(Token = "0x401C3C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401C3CA RID: 115658
		[Token(Token = "0x401C3CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
