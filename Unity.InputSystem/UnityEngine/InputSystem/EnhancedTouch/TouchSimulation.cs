using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.EnhancedTouch
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	[AddComponentMenu("Input/Debug/Touch Simulation")]
	[ExecuteInEditMode]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/Touch.html#touch-simulation")]
	public class TouchSimulation : MonoBehaviour, IInputStateChangeMonitor
	{
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003ED")]
		public Touchscreen simulatedTouchscreen
		{
			[Token(Token = "0x6000E9B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E9C")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003EE")]
		public static TouchSimulation instance
		{
			[Token(Token = "0x6000E9D")]
			[Address(RVA = "0x56E1AA0", Offset = "0x56E06A0", VA = "0x1856E1AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x56E04E0", Offset = "0x56DF0E0", VA = "0x1856E04E0")]
		public static void Enable()
		{
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x56E0410", Offset = "0x56DF010", VA = "0x1856E0410")]
		public static void Disable()
		{
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x56E0320", Offset = "0x56DEF20", VA = "0x1856E0320")]
		public static void Destroy()
		{
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x56E01B0", Offset = "0x56DEDB0", VA = "0x1856E01B0")]
		protected void AddPointer(Pointer pointer)
		{
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x56E1440", Offset = "0x56E0040", VA = "0x1856E1440")]
		protected void RemovePointer(Pointer pointer)
		{
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x56E0E60", Offset = "0x56DFA60", VA = "0x1856E0E60")]
		private void OnEvent(InputEventPtr eventPtr, InputDevice device)
		{
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x56E0690", Offset = "0x56DF290", VA = "0x1856E0690")]
		private void OnDeviceChange(InputDevice device, InputDeviceChange change)
		{
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x56E0A70", Offset = "0x56DF670", VA = "0x1856E0A70")]
		protected void OnEnable()
		{
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x56E0900", Offset = "0x56DF500", VA = "0x1856E0900")]
		protected void OnDisable()
		{
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x56E1630", Offset = "0x56E0230", VA = "0x1856E1630")]
		private void UpdateTouch(int touchIndex, int pointerIndex, TouchPhase phase, [Optional] InputEventPtr eventPtr)
		{
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		private void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex)
		{
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		private void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex)
		{
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		protected void InstallStateChangeMonitors(int startIndex = 0)
		{
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		protected void OnSourceControlChangedValue(InputControl control, double time, InputEventPtr eventPtr, long sourceDeviceAndButtonIndex)
		{
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		protected void UninstallStateChangeMonitors(int startIndex = 0)
		{
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x56E1A90", Offset = "0x56E0690", VA = "0x1856E1A90")]
		public TouchSimulation()
		{
		}

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private int m_NumPointers;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private Pointer[] m_Pointers;

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		private Vector2[] m_CurrentPositions;

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private int[] m_CurrentDisplayIndices;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private ButtonControl[] m_Touches;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private int m_LastTouchId;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[NonSerialized]
		private int m_PrimaryTouchIndex;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private Action<InputDevice, InputDeviceChange> m_OnDeviceChange;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private Action<InputEventPtr, InputDevice> m_OnEvent;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static TouchSimulation s_Instance;
	}
}
