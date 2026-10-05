using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A34 RID: 14900
	[Token(Token = "0x2003A34")]
	[RequireComponent(typeof(Toggle))]
	public class UISwitchToggle : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x06017844 RID: 96324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003856")]
		protected Toggle toggle
		{
			[Token(Token = "0x6017844")]
			[Address(RVA = "0xFD5670", Offset = "0xFD4270", VA = "0x180FD5670")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x06017845 RID: 96325 RVA: 0x00096E70 File Offset: 0x00095070
		// (set) Token: 0x06017846 RID: 96326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003857")]
		public virtual bool isOn
		{
			[Token(Token = "0x6017845")]
			[Address(RVA = "0xFD5600", Offset = "0xFD4200", VA = "0x180FD5600", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017846")]
			[Address(RVA = "0xFD5710", Offset = "0xFD4310", VA = "0x180FD5710", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x06017847 RID: 96327 RVA: 0x00096E88 File Offset: 0x00095088
		[Token(Token = "0x17003858")]
		public virtual bool interactable
		{
			[Token(Token = "0x6017847")]
			[Address(RVA = "0xFD5560", Offset = "0xFD4160", VA = "0x180FD5560", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06017848 RID: 96328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017848")]
		[Address(RVA = "0xFD5100", Offset = "0xFD3D00", VA = "0x180FD5100", Slot = "7")]
		public virtual void SetInteractable(bool val, bool force = false)
		{
		}

		// Token: 0x06017849 RID: 96329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017849")]
		[Address(RVA = "0xFD5490", Offset = "0xFD4090", VA = "0x180FD5490")]
		private void _OnToggled(bool isOn)
		{
		}

		// Token: 0x0601784A RID: 96330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601784A")]
		[Address(RVA = "0xFD5310", Offset = "0xFD3F10", VA = "0x180FD5310")]
		private void _InitToggle()
		{
		}

		// Token: 0x0601784B RID: 96331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601784B")]
		[Address(RVA = "0xFD51D0", Offset = "0xFD3DD0", VA = "0x180FD51D0")]
		protected void UpdateImages()
		{
		}

		// Token: 0x0601784C RID: 96332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601784C")]
		[Address(RVA = "0xFD5090", Offset = "0xFD3C90", VA = "0x180FD5090")]
		private void Awake()
		{
		}

		// Token: 0x0601784D RID: 96333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601784D")]
		[Address(RVA = "0xFD5500", Offset = "0xFD4100", VA = "0x180FD5500")]
		public UISwitchToggle()
		{
		}

		// Token: 0x0401C665 RID: 116325
		[Token(Token = "0x401C665")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Graphic _offImage;

		// Token: 0x0401C666 RID: 116326
		[Token(Token = "0x401C666")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Graphic _onImage;

		// Token: 0x0401C667 RID: 116327
		[Token(Token = "0x401C667")]
		[FieldOffset(Offset = "0x28")]
		private Toggle m_toggle;

		// Token: 0x0401C668 RID: 116328
		[Token(Token = "0x401C668")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_toggle;

		// Token: 0x0401C669 RID: 116329
		[Token(Token = "0x401C669")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isOn;

		// Token: 0x0401C66A RID: 116330
		[Token(Token = "0x401C66A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isOn;

		// Token: 0x0401C66B RID: 116331
		[Token(Token = "0x401C66B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_interactable;

		// Token: 0x0401C66C RID: 116332
		[Token(Token = "0x401C66C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetInteractable;

		// Token: 0x0401C66D RID: 116333
		[Token(Token = "0x401C66D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnToggled;

		// Token: 0x0401C66E RID: 116334
		[Token(Token = "0x401C66E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitToggle;

		// Token: 0x0401C66F RID: 116335
		[Token(Token = "0x401C66F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateImages;

		// Token: 0x0401C670 RID: 116336
		[Token(Token = "0x401C670")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401C671 RID: 116337
		[Token(Token = "0x401C671")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
