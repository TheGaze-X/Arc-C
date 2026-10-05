using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.BackPress
{
	// Token: 0x02005C2A RID: 23594
	[Token(Token = "0x2005C2A")]
	public class UIBackPressBinder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022344 RID: 140100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022344")]
		[Address(RVA = "0x1CB3CC0", Offset = "0x1CB28C0", VA = "0x181CB3CC0")]
		private void Start()
		{
		}

		// Token: 0x06022345 RID: 140101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022345")]
		[Address(RVA = "0x1CB3E00", Offset = "0x1CB2A00", VA = "0x181CB3E00")]
		private void _OnBackPressed()
		{
		}

		// Token: 0x06022346 RID: 140102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022346")]
		[Address(RVA = "0x1CB3E70", Offset = "0x1CB2A70", VA = "0x181CB3E70")]
		public UIBackPressBinder()
		{
		}

		// Token: 0x0402EEB9 RID: 192185
		[Token(Token = "0x402EEB9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _transform;

		// Token: 0x0402EEBA RID: 192186
		[Token(Token = "0x402EEBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Otherwise would do raycast to pivot.")]
		private bool _raycastToWorldCenter;

		// Token: 0x0402EEBB RID: 192187
		[Token(Token = "0x402EEBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent _onBackPress;

		// Token: 0x0402EEBC RID: 192188
		[Token(Token = "0x402EEBC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0402EEBD RID: 192189
		[Token(Token = "0x402EEBD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnBackPressed;

		// Token: 0x0402EEBE RID: 192190
		[Token(Token = "0x402EEBE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
