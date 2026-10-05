using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039DD RID: 14813
	[Token(Token = "0x20039DD")]
	public class UIColorToggle : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x0601764D RID: 95821 RVA: 0x000964B0 File Offset: 0x000946B0
		// (set) Token: 0x0601764E RID: 95822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700380A")]
		public bool isOn
		{
			[Token(Token = "0x601764D")]
			[Address(RVA = "0xFBDD20", Offset = "0xFBC920", VA = "0x180FBDD20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601764E")]
			[Address(RVA = "0xFBDD80", Offset = "0xFBC980", VA = "0x180FBDD80")]
			set
			{
			}
		}

		// Token: 0x0601764F RID: 95823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601764F")]
		[Address(RVA = "0xFBDA00", Offset = "0xFBC600", VA = "0x180FBDA00")]
		public void SetTarget(Graphic target)
		{
		}

		// Token: 0x06017650 RID: 95824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017650")]
		[Address(RVA = "0xFBDBE0", Offset = "0xFBC7E0", VA = "0x180FBDBE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017651 RID: 95825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017651")]
		[Address(RVA = "0xFBDAD0", Offset = "0xFBC6D0", VA = "0x180FBDAD0")]
		protected void UpdateImages()
		{
		}

		// Token: 0x06017652 RID: 95826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017652")]
		[Address(RVA = "0xFBD8B0", Offset = "0xFBC4B0", VA = "0x180FBD8B0")]
		private void Awake()
		{
		}

		// Token: 0x06017653 RID: 95827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017653")]
		[Address(RVA = "0xFBD9A0", Offset = "0xFBC5A0", VA = "0x180FBD9A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06017654 RID: 95828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017654")]
		[Address(RVA = "0xFBDCA0", Offset = "0xFBC8A0", VA = "0x180FBDCA0")]
		public UIColorToggle()
		{
		}

		// Token: 0x0401C407 RID: 115719
		[Token(Token = "0x401C407")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Graphic _target;

		// Token: 0x0401C408 RID: 115720
		[Token(Token = "0x401C408")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _onColor;

		// Token: 0x0401C409 RID: 115721
		[Token(Token = "0x401C409")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _offColor;

		// Token: 0x0401C40A RID: 115722
		[Token(Token = "0x401C40A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _duration;

		// Token: 0x0401C40B RID: 115723
		[Token(Token = "0x401C40B")]
		[FieldOffset(Offset = "0x48")]
		private Graphic m_target;

		// Token: 0x0401C40C RID: 115724
		[Token(Token = "0x401C40C")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isOn;

		// Token: 0x0401C40D RID: 115725
		[Token(Token = "0x401C40D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isOn;

		// Token: 0x0401C40E RID: 115726
		[Token(Token = "0x401C40E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isOn;

		// Token: 0x0401C40F RID: 115727
		[Token(Token = "0x401C40F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetTarget;

		// Token: 0x0401C410 RID: 115728
		[Token(Token = "0x401C410")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C411 RID: 115729
		[Token(Token = "0x401C411")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateImages;

		// Token: 0x0401C412 RID: 115730
		[Token(Token = "0x401C412")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401C413 RID: 115731
		[Token(Token = "0x401C413")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401C414 RID: 115732
		[Token(Token = "0x401C414")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
