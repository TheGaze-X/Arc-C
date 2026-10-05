using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004168 RID: 16744
	[Token(Token = "0x2004168")]
	public class SandboxV2DungeonCameraClick : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IHotfixable
	{
		// Token: 0x14000088 RID: 136
		// (add) Token: 0x06019D76 RID: 105846 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06019D77 RID: 105847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000088")]
		public event SandboxV2DungeonCameraClick.OnCameraClickedDelegate OnCameraClicked
		{
			[Token(Token = "0x6019D76")]
			[Address(RVA = "0x12B9010", Offset = "0x12B7C10", VA = "0x1812B9010")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6019D77")]
			[Address(RVA = "0x12B90F0", Offset = "0x12B7CF0", VA = "0x1812B90F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06019D78 RID: 105848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D78")]
		[Address(RVA = "0x12B8E30", Offset = "0x12B7A30", VA = "0x1812B8E30", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06019D79 RID: 105849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D79")]
		[Address(RVA = "0x12B8F50", Offset = "0x12B7B50", VA = "0x1812B8F50", Slot = "6")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06019D7A RID: 105850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D7A")]
		[Address(RVA = "0x12B8EF0", Offset = "0x12B7AF0", VA = "0x1812B8EF0", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06019D7B RID: 105851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D7B")]
		[Address(RVA = "0x12B8FB0", Offset = "0x12B7BB0", VA = "0x1812B8FB0")]
		public SandboxV2DungeonCameraClick()
		{
		}

		// Token: 0x04020756 RID: 132950
		[Token(Token = "0x4020756")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_OnCameraClicked;

		// Token: 0x04020757 RID: 132951
		[Token(Token = "0x4020757")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_OnCameraClicked;

		// Token: 0x04020758 RID: 132952
		[Token(Token = "0x4020758")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPointerClick;

		// Token: 0x04020759 RID: 132953
		[Token(Token = "0x4020759")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPointerUp;

		// Token: 0x0402075A RID: 132954
		[Token(Token = "0x402075A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x0402075B RID: 132955
		[Token(Token = "0x402075B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004169 RID: 16745
		// (Invoke) Token: 0x06019D7D RID: 105853
		[Token(Token = "0x2004169")]
		public delegate void OnCameraClickedDelegate(Vector2 screenPos);
	}
}
