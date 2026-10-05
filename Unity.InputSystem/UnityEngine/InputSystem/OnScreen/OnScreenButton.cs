using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.OnScreen
{
	// Token: 0x0200012B RID: 299
	[Token(Token = "0x200012B")]
	[AddComponentMenu("Input/On-Screen Button")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/OnScreen.html#on-screen-buttons")]
	public class OnScreenButton : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		// Token: 0x06000DD6 RID: 3542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x56C5DA0", Offset = "0x56C49A0", VA = "0x1856C5DA0", Slot = "9")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x56C5D50", Offset = "0x56C4950", VA = "0x1856C5D50", Slot = "8")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AC")]
		protected override string controlPathInternal
		{
			[Token(Token = "0x6000DD8")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DD9")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public OnScreenButton()
		{
		}

		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x40006E1")]
		[FieldOffset(Offset = "0x30")]
		[InputControl(layout = "Button")]
		[SerializeField]
		private string m_ControlPath;
	}
}
