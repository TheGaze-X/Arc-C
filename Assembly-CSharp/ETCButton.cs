using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200003E")]
[Serializable]
public class ETCButton : ETCBase, IPointerEnterHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
	// Token: 0x060000F2 RID: 242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x4FE130", Offset = "0x4FCD30", VA = "0x1804FE130")]
	public ETCButton()
	{
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x4FD6E0", Offset = "0x4FC2E0", VA = "0x1804FD6E0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x4FDE80", Offset = "0x4FCA80", VA = "0x1804FDE80", Slot = "5")]
	public override void Start()
	{
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x4FE120", Offset = "0x4FCD20", VA = "0x1804FE120", Slot = "10")]
	protected override void UpdateControlState()
	{
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x4FD740", Offset = "0x4FC340", VA = "0x1804FD740", Slot = "13")]
	protected override void DoActionBeforeEndOfFrame()
	{
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x4FD840", Offset = "0x4FC440", VA = "0x1804FD840", Slot = "14")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x4FD770", Offset = "0x4FC370", VA = "0x1804FD770", Slot = "15")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x4FDC30", Offset = "0x4FC830", VA = "0x1804FDC30", Slot = "16")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x4FDA60", Offset = "0x4FC660", VA = "0x1804FDA60", Slot = "17")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x4FDEF0", Offset = "0x4FCAF0", VA = "0x1804FDEF0")]
	private void UpdateButton()
	{
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x4FDE20", Offset = "0x4FCA20", VA = "0x1804FDE20", Slot = "11")]
	protected override void SetVisible(bool forceUnvisible = false)
	{
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x4FD5C0", Offset = "0x4FC1C0", VA = "0x1804FD5C0")]
	private void ApllyState()
	{
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x4FDDD0", Offset = "0x4FC9D0", VA = "0x1804FDDD0", Slot = "12")]
	protected override void SetActivated()
	{
	}

	// Token: 0x0400014D RID: 333
	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public ETCButton.OnDownHandler onDown;

	// Token: 0x0400014E RID: 334
	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public ETCButton.OnPressedHandler onPressed;

	// Token: 0x0400014F RID: 335
	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	public ETCButton.OnPressedValueandler onPressedValue;

	// Token: 0x04000150 RID: 336
	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	public ETCButton.OnUPHandler onUp;

	// Token: 0x04000151 RID: 337
	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0xF8")]
	public ETCAxis axis;

	// Token: 0x04000152 RID: 338
	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x100")]
	public Sprite normalSprite;

	// Token: 0x04000153 RID: 339
	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x108")]
	public Color normalColor;

	// Token: 0x04000154 RID: 340
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x118")]
	public Sprite pressedSprite;

	// Token: 0x04000155 RID: 341
	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x120")]
	public Color pressedColor;

	// Token: 0x04000156 RID: 342
	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x130")]
	private Image cachedImage;

	// Token: 0x04000157 RID: 343
	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x138")]
	private bool isOnPress;

	// Token: 0x04000158 RID: 344
	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x140")]
	private GameObject previousDargObject;

	// Token: 0x04000159 RID: 345
	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x148")]
	private bool isOnTouch;

	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[Serializable]
	public class OnDownHandler : UnityEvent
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnDownHandler()
		{
		}
	}

	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[Serializable]
	public class OnPressedHandler : UnityEvent
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnPressedHandler()
		{
		}
	}

	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[Serializable]
	public class OnPressedValueandler : UnityEvent<float>
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x50BE20", Offset = "0x50AA20", VA = "0x18050BE20")]
		public OnPressedValueandler()
		{
		}
	}

	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[Serializable]
	public class OnUPHandler : UnityEvent
	{
		// Token: 0x06000102 RID: 258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
		public OnUPHandler()
		{
		}
	}
}
