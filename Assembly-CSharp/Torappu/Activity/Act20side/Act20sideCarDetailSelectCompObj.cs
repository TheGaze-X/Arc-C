using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007656 RID: 30294
	[Token(Token = "0x2007656")]
	public class Act20sideCarDetailSelectCompObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006436 RID: 25654
		// (get) Token: 0x0602A9CF RID: 174543 RVA: 0x000D9440 File Offset: 0x000D7640
		[Token(Token = "0x17006436")]
		public CartComponents.CartAccessoryPos pos
		{
			[Token(Token = "0x602A9CF")]
			[Address(RVA = "0x2651520", Offset = "0x2650120", VA = "0x182651520")]
			get
			{
				return CartComponents.CartAccessoryPos.NONE;
			}
		}

		// Token: 0x0602A9D0 RID: 174544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9D0")]
		[Address(RVA = "0x2651130", Offset = "0x264FD30", VA = "0x182651130")]
		public void OnClickPos()
		{
		}

		// Token: 0x0602A9D1 RID: 174545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9D1")]
		[Address(RVA = "0x26510B0", Offset = "0x264FCB0", VA = "0x1826510B0")]
		public void ApplySelectState(CartComponents.CartAccessoryPos pos)
		{
		}

		// Token: 0x0602A9D2 RID: 174546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9D2")]
		[Address(RVA = "0x2651200", Offset = "0x264FE00", VA = "0x182651200")]
		public void Render(string compId)
		{
		}

		// Token: 0x0602A9D3 RID: 174547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9D3")]
		[Address(RVA = "0x26514C0", Offset = "0x26500C0", VA = "0x1826514C0")]
		public Act20sideCarDetailSelectCompObj()
		{
		}

		// Token: 0x0403D5C4 RID: 251332
		[Token(Token = "0x403D5C4")]
		private const float DELTA_TIME = 0.2f;

		// Token: 0x0403D5C5 RID: 251333
		[Token(Token = "0x403D5C5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0403D5C6 RID: 251334
		[Token(Token = "0x403D5C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectPart;

		// Token: 0x0403D5C7 RID: 251335
		[Token(Token = "0x403D5C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _havePart;

		// Token: 0x0403D5C8 RID: 251336
		[Token(Token = "0x403D5C8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _notHavePart;

		// Token: 0x0403D5C9 RID: 251337
		[Token(Token = "0x403D5C9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CartComponents.CartAccessoryPos _pos;

		// Token: 0x0403D5CA RID: 251338
		[Token(Token = "0x403D5CA")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public AccessPosEvent clickEvent;

		// Token: 0x0403D5CB RID: 251339
		[Token(Token = "0x403D5CB")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_switchTween;

		// Token: 0x0403D5CC RID: 251340
		[Token(Token = "0x403D5CC")]
		[FieldOffset(Offset = "0x50")]
		private float m_boolFlag;

		// Token: 0x0403D5CD RID: 251341
		[Token(Token = "0x403D5CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pos;

		// Token: 0x0403D5CE RID: 251342
		[Token(Token = "0x403D5CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickPos;

		// Token: 0x0403D5CF RID: 251343
		[Token(Token = "0x403D5CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplySelectState;

		// Token: 0x0403D5D0 RID: 251344
		[Token(Token = "0x403D5D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D5D1 RID: 251345
		[Token(Token = "0x403D5D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
