using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073FE RID: 29694
	[Token(Token = "0x20073FE")]
	public class Act3D0GachaBoxItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F04 RID: 171780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F04")]
		[Address(RVA = "0x2589930", Offset = "0x2588530", VA = "0x182589930")]
		public void Render(int id, Act3D0GachaBoxInfo info)
		{
		}

		// Token: 0x06029F05 RID: 171781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F05")]
		[Address(RVA = "0x2589870", Offset = "0x2588470", VA = "0x182589870")]
		public void OnFocus(int orderId)
		{
		}

		// Token: 0x06029F06 RID: 171782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F06")]
		[Address(RVA = "0x2589D00", Offset = "0x2588900", VA = "0x182589D00")]
		public Act3D0GachaBoxItem()
		{
		}

		// Token: 0x0403C18F RID: 246159
		[Token(Token = "0x403C18F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _boxImage;

		// Token: 0x0403C190 RID: 246160
		[Token(Token = "0x403C190")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lockedObj;

		// Token: 0x0403C191 RID: 246161
		[Token(Token = "0x403C191")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _outOfStack;

		// Token: 0x0403C192 RID: 246162
		[Token(Token = "0x403C192")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0403C193 RID: 246163
		[Token(Token = "0x403C193")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _shadow;

		// Token: 0x0403C194 RID: 246164
		[Token(Token = "0x403C194")]
		[FieldOffset(Offset = "0x40")]
		private int m_cacheId;

		// Token: 0x0403C195 RID: 246165
		[Token(Token = "0x403C195")]
		private const string ANIM_PARAM = "focusId";

		// Token: 0x0403C196 RID: 246166
		[Token(Token = "0x403C196")]
		private const string START_PARAM = "start";

		// Token: 0x0403C197 RID: 246167
		[Token(Token = "0x403C197")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C198 RID: 246168
		[Token(Token = "0x403C198")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFocus;

		// Token: 0x0403C199 RID: 246169
		[Token(Token = "0x403C199")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
