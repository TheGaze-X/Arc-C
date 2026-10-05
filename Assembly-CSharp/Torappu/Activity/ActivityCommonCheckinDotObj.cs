using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006DA5 RID: 28069
	[Token(Token = "0x2006DA5")]
	public class ActivityCommonCheckinDotObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027F9C RID: 163740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F9C")]
		[Address(RVA = "0x2335DA0", Offset = "0x23349A0", VA = "0x182335DA0")]
		public void SetClickListener(int index, Action<int> onClick)
		{
		}

		// Token: 0x06027F9D RID: 163741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F9D")]
		[Address(RVA = "0x2335ED0", Offset = "0x2334AD0", VA = "0x182335ED0")]
		public void SetImageAndColor(Sprite sprite, Color color)
		{
		}

		// Token: 0x06027F9E RID: 163742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F9E")]
		[Address(RVA = "0x2335D30", Offset = "0x2334930", VA = "0x182335D30")]
		public void EventOnClick()
		{
		}

		// Token: 0x06027F9F RID: 163743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F9F")]
		[Address(RVA = "0x2335FF0", Offset = "0x2334BF0", VA = "0x182335FF0")]
		public ActivityCommonCheckinDotObj()
		{
		}

		// Token: 0x04038A7C RID: 232060
		[Token(Token = "0x4038A7C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _image;

		// Token: 0x04038A7D RID: 232061
		[Token(Token = "0x4038A7D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _button;

		// Token: 0x04038A7E RID: 232062
		[Token(Token = "0x4038A7E")]
		[FieldOffset(Offset = "0x28")]
		private int m_index;

		// Token: 0x04038A7F RID: 232063
		[Token(Token = "0x4038A7F")]
		[FieldOffset(Offset = "0x30")]
		private Action<int> m_onClick;

		// Token: 0x04038A80 RID: 232064
		[Token(Token = "0x4038A80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetClickListener;

		// Token: 0x04038A81 RID: 232065
		[Token(Token = "0x4038A81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetImageAndColor;

		// Token: 0x04038A82 RID: 232066
		[Token(Token = "0x4038A82")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04038A83 RID: 232067
		[Token(Token = "0x4038A83")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
