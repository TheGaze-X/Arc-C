using System;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.OnScreen
{
	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	public abstract class OnScreenControl : MonoBehaviour
	{
		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AD")]
		public string controlPath
		{
			[Token(Token = "0x6000DDB")]
			[Address(RVA = "0x4568380", Offset = "0x4566F80", VA = "0x184568380")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DDC")]
			[Address(RVA = "0x56C6D80", Offset = "0x56C5980", VA = "0x1856C6D80")]
			set
			{
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003AE")]
		public InputControl control
		{
			[Token(Token = "0x6000DDD")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000DDE RID: 3550
		// (set) Token: 0x06000DDF RID: 3551
		[Token(Token = "0x170003AF")]
		protected abstract string controlPathInternal { [Token(Token = "0x6000DDE")] get; [Token(Token = "0x6000DDF")] set; }

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x56C6140", Offset = "0x56C4D40", VA = "0x1856C6140")]
		private void SetupInputControl()
		{
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE1")]
		protected void SendValueToControl<TValue>(TValue value) where TValue : struct
		{
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x56C6070", Offset = "0x56C4C70", VA = "0x1856C6070")]
		protected void SentDefaultValueToControl()
		{
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x56C6060", Offset = "0x56C4C60", VA = "0x1856C6060", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x56C5DE0", Offset = "0x56C49E0", VA = "0x1856C5DE0", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected OnScreenControl()
		{
		}

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		[FieldOffset(Offset = "0x18")]
		private InputControl m_Control;

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x20")]
		private OnScreenControl m_NextControlOnDevice;

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x28")]
		private InputEventPtr m_InputEventPtr;

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x0")]
		private static InlinedArray<OnScreenControl.OnScreenDeviceInfo> s_OnScreenDevices;

		// Token: 0x0200012D RID: 301
		[Token(Token = "0x200012D")]
		private struct OnScreenDeviceInfo
		{
			// Token: 0x06000DE6 RID: 3558 RVA: 0x00006CC0 File Offset: 0x00004EC0
			[Token(Token = "0x6000DE6")]
			[Address(RVA = "0x56C6DE0", Offset = "0x56C59E0", VA = "0x1856C6DE0")]
			public OnScreenControl.OnScreenDeviceInfo AddControl(OnScreenControl control)
			{
				return default(OnScreenControl.OnScreenDeviceInfo);
			}

			// Token: 0x06000DE7 RID: 3559 RVA: 0x00006CD8 File Offset: 0x00004ED8
			[Token(Token = "0x6000DE7")]
			[Address(RVA = "0x56C6F10", Offset = "0x56C5B10", VA = "0x1856C6F10")]
			public OnScreenControl.OnScreenDeviceInfo RemoveControl(OnScreenControl control)
			{
				return default(OnScreenControl.OnScreenDeviceInfo);
			}

			// Token: 0x06000DE8 RID: 3560 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DE8")]
			[Address(RVA = "0x56C6E60", Offset = "0x56C5A60", VA = "0x1856C6E60")]
			public void Destroy()
			{
			}

			// Token: 0x040006E6 RID: 1766
			[Token(Token = "0x40006E6")]
			[FieldOffset(Offset = "0x0")]
			public InputEventPtr eventPtr;

			// Token: 0x040006E7 RID: 1767
			[Token(Token = "0x40006E7")]
			[FieldOffset(Offset = "0x8")]
			public NativeArray<byte> buffer;

			// Token: 0x040006E8 RID: 1768
			[Token(Token = "0x40006E8")]
			[FieldOffset(Offset = "0x18")]
			public InputDevice device;

			// Token: 0x040006E9 RID: 1769
			[Token(Token = "0x40006E9")]
			[FieldOffset(Offset = "0x20")]
			public OnScreenControl firstControl;
		}
	}
}
