using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	internal class InputActionState : IInputStateChangeMonitor, ICloneable, IDisposable
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x170000DA")]
		public int totalCompositeCount
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x32FB190", Offset = "0x32F9D90", VA = "0x1832FB190")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x170000DB")]
		public int totalMapCount
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x170000DC")]
		public int totalActionCount
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x150B0C0", Offset = "0x1509CC0", VA = "0x18150B0C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x170000DD")]
		public int totalBindingCount
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x4FA5A00", Offset = "0x4FA4600", VA = "0x184FA5A00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x170000DE")]
		public int totalInteractionCount
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x170000DF")]
		public int totalControlCount
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E0")]
		public unsafe InputActionState.ActionMapIndices* mapIndices
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x22F8850", Offset = "0x22F7450", VA = "0x1822F8850")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E1")]
		public unsafe InputActionState.TriggerState* actionStates
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E2")]
		public unsafe InputActionState.BindingState* bindingStates
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E3")]
		public unsafe InputActionState.InteractionState* interactionStates
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E4")]
		public unsafe int* controlIndexToBindingIndex
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E5")]
		public unsafe ushort* controlGroupingAndComplexity
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E6")]
		public unsafe float* controlMagnitudes
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E7")]
		public unsafe uint* enabledControls
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x170000E8")]
		public bool isProcessingControlStateChange
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x55F67F0", Offset = "0x55F53F0", VA = "0x1855F67F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x55F18E0", Offset = "0x55F04E0", VA = "0x1855F18E0")]
		public void Initialize(InputBindingResolver resolver)
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x55EF260", Offset = "0x55EDE60", VA = "0x1855EF260")]
		private void ComputeControlGroupingIfNecessary()
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x55EEE30", Offset = "0x55EDA30", VA = "0x1855EEE30")]
		public void ClaimDataFrom(InputBindingResolver resolver)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x55F0AE0", Offset = "0x55EF6E0", VA = "0x1855F0AE0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x55F02C0", Offset = "0x55EEEC0", VA = "0x1855F02C0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x55EF7C0", Offset = "0x55EE3C0", VA = "0x1855EF7C0")]
		private void Destroy(bool isFinalizing = false)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x55EEF10", Offset = "0x55EDB10", VA = "0x1855EEF10")]
		public InputActionState Clone()
		{
			return null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x55EEF10", Offset = "0x55EDB10", VA = "0x1855EEF10", Slot = "6")]
		private object Clone()
		{
			return null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x55F26F0", Offset = "0x55F12F0", VA = "0x1855F26F0")]
		private bool IsUsingDevice(InputDevice device)
		{
			return default(bool);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x55EE2B0", Offset = "0x55ECEB0", VA = "0x1855EE2B0")]
		private bool CanUseDevice(InputDevice device)
		{
			return default(bool);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x55F1770", Offset = "0x55F0370", VA = "0x1855F1770")]
		public bool HasEnabledActions()
		{
			return default(bool);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x55F0EB0", Offset = "0x55EFAB0", VA = "0x1855F0EB0")]
		private void FinishBindingCompositeSetups()
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x55F3040", Offset = "0x55F1C40", VA = "0x1855F3040")]
		internal void PrepareForBindingReResolution(bool needFullResolve, ref InputControlList<InputControl> activeControls, ref bool hasEnabledActions)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x55F0FB0", Offset = "0x55EFBB0", VA = "0x1855F0FB0")]
		public void FinishBindingResolution(bool hasEnabledActions, InputActionState.UnmanagedMemory oldMemory, InputControlList<InputControl> activeControls, bool isFullResolve)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x55F57F0", Offset = "0x55F43F0", VA = "0x1855F57F0")]
		private void RestoreActionStatesAfterReResolvingBindings(InputActionState.UnmanagedMemory oldState, InputControlList<InputControl> activeControls, bool isFullResolve)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x55F1FE0", Offset = "0x55F0BE0", VA = "0x1855F1FE0")]
		private bool IsActiveControl(int bindingIndex, int controlIndex)
		{
			return default(bool);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x55F0E40", Offset = "0x55EFA40", VA = "0x1855F0E40")]
		private int FindControlIndexOnBinding(int bindingIndex, InputControl control)
		{
			return 0;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x55F5270", Offset = "0x55F3E70", VA = "0x1855F5270")]
		private void ResetActionStatesDrivenBy(InputDevice device)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x55F1EF0", Offset = "0x55F0AF0", VA = "0x1855F1EF0")]
		private bool IsActionBoundToControlFromDevice(InputDevice device, int actionIndex)
		{
			return default(bool);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x55F5040", Offset = "0x55F3C40", VA = "0x1855F5040")]
		public void ResetActionState(int actionIndex, InputActionPhase toPhase = InputActionPhase.Waiting, bool hardReset = false)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x55F0A60", Offset = "0x55EF660", VA = "0x1855F0A60")]
		public ref InputActionState.TriggerState FetchActionState(InputAction action)
		{
			return null;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x55F0A90", Offset = "0x55EF690", VA = "0x1855F0A90")]
		public InputActionState.ActionMapIndices FetchMapIndices(InputActionMap map)
		{
			return default(InputActionState.ActionMapIndices);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x55F02D0", Offset = "0x55EEED0", VA = "0x1855F02D0")]
		public void EnableAllActions(InputActionMap map)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x55F0780", Offset = "0x55EF380", VA = "0x1855F0780")]
		private void EnableControls(InputActionMap map)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x55F07D0", Offset = "0x55EF3D0", VA = "0x1855F07D0")]
		public void EnableSingleAction(InputAction action)
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x55F04D0", Offset = "0x55EF0D0", VA = "0x1855F04D0")]
		private void EnableControls(InputAction action)
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x55EFBB0", Offset = "0x55EE7B0", VA = "0x1855EFBB0")]
		public void DisableAllActions(InputActionMap map)
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x55F00D0", Offset = "0x55EECD0", VA = "0x1855F00D0")]
		public void DisableControls(InputActionMap map)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x55F0120", Offset = "0x55EED20", VA = "0x1855F0120")]
		public void DisableSingleAction(InputAction action)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x55EFE20", Offset = "0x55EEA20", VA = "0x1855EFE20")]
		private void DisableControls(InputAction action)
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x55F05C0", Offset = "0x55EF1C0", VA = "0x1855F05C0")]
		private void EnableControls(int mapIndex, int controlStartIndex, int numControls)
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x55EFF10", Offset = "0x55EEB10", VA = "0x1855EFF10")]
		private void DisableControls(int mapIndex, int controlStartIndex, int numControls)
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x55F6270", Offset = "0x55F4E70", VA = "0x1855F6270")]
		public void SetInitialStateCheckPending(int actionIndex, bool value = true)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x55F6320", Offset = "0x55F4F20", VA = "0x1855F6320")]
		private unsafe void SetInitialStateCheckPending(InputActionState.BindingState* bindingStatePtr, bool value)
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x55F26B0", Offset = "0x55F12B0", VA = "0x1855F26B0")]
		private bool IsControlEnabled(int controlIndex)
		{
			return default(bool);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x55F6230", Offset = "0x55F4E30", VA = "0x1855F6230")]
		private void SetControlEnabled(int controlIndex, bool state)
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x55F17E0", Offset = "0x55F03E0", VA = "0x1855F17E0")]
		private void HookOnBeforeUpdate()
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x55F66D0", Offset = "0x55F52D0", VA = "0x1855F66D0")]
		private void UnhookOnBeforeUpdate()
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x55F2A50", Offset = "0x55F1650", VA = "0x1855F2A50")]
		private void OnBeforeInitialUpdate()
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x55F6750", Offset = "0x55F5350", VA = "0x1855F6750", Slot = "4")]
		private void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long mapControlAndBindingIndex)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x55F67A0", Offset = "0x55F53A0", VA = "0x1855F67A0", Slot = "5")]
		private void NotifyTimerExpired(InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x55F6690", Offset = "0x55F5290", VA = "0x1855F6690")]
		private long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex)
		{
			return 0L;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x55F63D0", Offset = "0x55F4FD0", VA = "0x1855F63D0")]
		private void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, out int mapIndex, out int controlIndex, out int bindingIndex)
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x55F14E0", Offset = "0x55F00E0", VA = "0x1855F14E0")]
		internal static int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex)
		{
			return 0;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x55F37A0", Offset = "0x55F23A0", VA = "0x1855F37A0")]
		private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, InputEventPtr eventPtr)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x55F3540", Offset = "0x55F2140", VA = "0x1855F3540")]
		private unsafe void ProcessButtonState(ref InputActionState.TriggerState trigger, int actionIndex, InputActionState.BindingState* bindingStatePtr)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x55F6390", Offset = "0x55F4F90", VA = "0x1855F6390")]
		private unsafe static bool ShouldIgnoreInputOnCompositeBinding(InputActionState.BindingState* binding, InputEvent* eventPtr)
		{
			return default(bool);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x55F20F0", Offset = "0x55F0CF0", VA = "0x1855F20F0")]
		private bool IsConflictingInput(ref InputActionState.TriggerState trigger, int actionIndex)
		{
			return default(bool);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x55F1190", Offset = "0x55EFD90", VA = "0x1855F1190")]
		private ushort GetActionBindingStartIndexAndCount(int actionIndex, out ushort bindingCount)
		{
			return 0;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x55F3EF0", Offset = "0x55F2AF0", VA = "0x1855F3EF0")]
		private void ProcessDefaultInteraction(ref InputActionState.TriggerState trigger, int actionIndex)
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x55F4200", Offset = "0x55F2E00", VA = "0x1855F4200")]
		private void ProcessInteractions(ref InputActionState.TriggerState trigger, int interactionStartIndex, int interactionCount)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x55F4450", Offset = "0x55F3050", VA = "0x1855F4450")]
		private void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex)
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x55F6360", Offset = "0x55F4F60", VA = "0x1855F6360")]
		internal void SetTotalTimeoutCompletionTime(float seconds, ref InputActionState.TriggerState trigger)
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x55F6400", Offset = "0x55F5000", VA = "0x1855F6400")]
		internal void StartTimeout(float seconds, ref InputActionState.TriggerState trigger)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x55F65B0", Offset = "0x55F51B0", VA = "0x1855F65B0")]
		private void StopTimeout(int interactionIndex)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x55EE9A0", Offset = "0x55ED5A0", VA = "0x1855EE9A0")]
		internal void ChangePhaseOfInteraction(InputActionPhase newPhase, ref InputActionState.TriggerState trigger, InputActionPhase phaseAfterPerformed = InputActionPhase.Waiting, bool processNextInteractionOnCancel = true)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x55EE760", Offset = "0x55ED360", VA = "0x1855EE760")]
		private bool ChangePhaseOfAction(InputActionPhase newPhase, ref InputActionState.TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled = InputActionPhase.Waiting)
		{
			return default(bool);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x55EE4A0", Offset = "0x55ED0A0", VA = "0x1855EE4A0")]
		private unsafe void ChangePhaseOfActionInternal(int actionIndex, InputActionState.TriggerState* actionState, InputActionPhase newPhase, ref InputActionState.TriggerState trigger)
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x55EE040", Offset = "0x55ECC40", VA = "0x1855EE040")]
		private void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, ref CallbackArray<Action<InputAction.CallbackContext>> listeners, string callbackName)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x55F1200", Offset = "0x55EFE00", VA = "0x1855F1200")]
		private object GetActionOrNoneString(ref InputActionState.TriggerState trigger)
		{
			return null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x55F1350", Offset = "0x55EFF50", VA = "0x1855F1350")]
		internal InputAction GetActionOrNull(int bindingIndex)
		{
			return null;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x55F12C0", Offset = "0x55EFEC0", VA = "0x1855F12C0")]
		internal InputAction GetActionOrNull(ref InputActionState.TriggerState trigger)
		{
			return null;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x55F1570", Offset = "0x55F0170", VA = "0x1855F1570")]
		internal InputControl GetControl(ref InputActionState.TriggerState trigger)
		{
			return null;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x55F15B0", Offset = "0x55F01B0", VA = "0x1855F15B0")]
		private IInputInteraction GetInteractionOrNull(ref InputActionState.TriggerState trigger)
		{
			return null;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x55F13E0", Offset = "0x55EFFE0", VA = "0x1855F13E0")]
		internal int GetBindingIndexInMap(int bindingIndex)
		{
			return 0;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x55F1420", Offset = "0x55F0020", VA = "0x1855F1420")]
		internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap)
		{
			return 0;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x55F1450", Offset = "0x55F0050", VA = "0x1855F1450")]
		internal ref InputActionState.BindingState GetBindingState(int bindingIndex)
		{
			return null;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x55F1460", Offset = "0x55F0060", VA = "0x1855F1460")]
		internal ref InputBinding GetBinding(int bindingIndex)
		{
			return null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x55F11C0", Offset = "0x55EFDC0", VA = "0x1855F11C0")]
		internal InputActionMap GetActionMap(int bindingIndex)
		{
			return null;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x55F5660", Offset = "0x55F4260", VA = "0x1855F5660")]
		private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex)
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x55F5720", Offset = "0x55F4320", VA = "0x1855F5720")]
		private void ResetInteractionState(int interactionIndex)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x55F15F0", Offset = "0x55F01F0", VA = "0x1855F15F0")]
		internal int GetValueSizeInBytes(int bindingIndex, int controlIndex)
		{
			return 0;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x55F16B0", Offset = "0x55F02B0", VA = "0x1855F16B0")]
		internal Type GetValueType(int bindingIndex, int controlIndex)
		{
			return null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x55F2090", Offset = "0x55F0C90", VA = "0x1855F2090")]
		internal static bool IsActuated(ref InputActionState.TriggerState trigger, float threshold = 0f)
		{
			return default(bool);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x55F4D40", Offset = "0x55F3940", VA = "0x1855F4D40")]
		internal unsafe void ReadValue(int bindingIndex, int controlIndex, void* buffer, int bufferSize, bool ignoreComposites = false)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600033B")]
		internal TValue ReadValue<TValue>(int bindingIndex, int controlIndex, bool ignoreComposites = false) where TValue : struct
		{
			return null;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600033C")]
		internal TValue ApplyProcessors<TValue>(int bindingIndex, TValue value, [Optional] InputControl<TValue> controlOfType) where TValue : struct
		{
			return null;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x55F0970", Offset = "0x55EF570", VA = "0x1855F0970")]
		public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber)
		{
			return 0f;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x55F14F0", Offset = "0x55F00F0", VA = "0x1855F14F0")]
		internal double GetCompositePartPressTime(int bindingIndex, int partNumber)
		{
			return 0.0;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600033F")]
		internal unsafe TValue ReadCompositePartValue<TValue, TComparer>(int bindingIndex, int partNumber, bool* buttonValuePtr, out int controlIndex, [Optional] TComparer comparer) where TValue : struct where TComparer : IComparer<TValue>
		{
			return null;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x55F48A0", Offset = "0x55F34A0", VA = "0x1855F48A0")]
		internal unsafe bool ReadCompositePartValue(int bindingIndex, int partNumber, void* buffer, int bufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x55F4770", Offset = "0x55F3370", VA = "0x1855F4770")]
		internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber)
		{
			return null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x55F4B50", Offset = "0x55F3750", VA = "0x1855F4B50")]
		internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites = false)
		{
			return null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x55F49F0", Offset = "0x55F35F0", VA = "0x1855F49F0")]
		internal bool ReadValueAsButton(int bindingIndex, int controlIndex)
		{
			return default(bool);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x55F5FE0", Offset = "0x55F4BE0", VA = "0x1855F5FE0")]
		internal static ISavedState SaveAndResetState()
		{
			return null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x55EDE70", Offset = "0x55ECA70", VA = "0x1855EDE70")]
		private void AddToGlobalList()
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x55F4F40", Offset = "0x55F3B40", VA = "0x1855F4F40")]
		private void RemoveMapFromGlobalList()
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x55EF0E0", Offset = "0x55EDCE0", VA = "0x1855EF0E0")]
		private static void CompactGlobalList()
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x55F2880", Offset = "0x55F1480", VA = "0x1855F2880")]
		internal void NotifyListenersOfActionChange(InputActionChange change)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x55F2970", Offset = "0x55F1570", VA = "0x1855F2970")]
		internal static void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x55F53E0", Offset = "0x55F3FE0", VA = "0x1855F53E0")]
		private static void ResetGlobals()
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x55F0BC0", Offset = "0x55EF7C0", VA = "0x1855F0BC0")]
		internal static int FindAllEnabledActions(List<InputAction> result)
		{
			return 0;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x55F2D10", Offset = "0x55F1910", VA = "0x1855F2D10")]
		internal static void OnDeviceChange(InputDevice device, InputDeviceChange change)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x55EF450", Offset = "0x55EE050", VA = "0x1855EF450")]
		internal static void DeferredResolutionOfBindings()
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x55EFA90", Offset = "0x55EE690", VA = "0x1855EFA90")]
		internal static void DisableAllActions()
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x55EF640", Offset = "0x55EE240", VA = "0x1855EF640")]
		internal static void DestroyAllActionMapStates()
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InputActionState()
		{
		}

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		public const int kInvalidIndex = -1;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InputActionMap[] maps;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputControl[] controls;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IInputInteraction[] interactions;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputProcessor[] processors;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InputBindingComposite[] composites;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int totalProcessorCount;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InputActionState.UnmanagedMemory memory;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool m_OnBeforeUpdateHooked;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool m_OnAfterUpdateHooked;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		private bool m_InProcessControlStateChange;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private InputEventPtr m_CurrentlyProcessingThisEvent;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Action m_OnBeforeUpdateDelegate;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Action m_OnAfterUpdateDelegate;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static InputActionState.GlobalState s_GlobalState;

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		[StructLayout(2)]
		internal struct InteractionState
		{
			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x06000351 RID: 849 RVA: 0x000034C8 File Offset: 0x000016C8
			// (set) Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000E9")]
			public int triggerControlIndex
			{
				[Token(Token = "0x6000351")]
				[Address(RVA = "0x55F8430", Offset = "0x55F7030", VA = "0x1855F8430")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000352")]
				[Address(RVA = "0x55F84A0", Offset = "0x55F70A0", VA = "0x1855F84A0")]
				set
				{
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x06000353 RID: 851 RVA: 0x000034E0 File Offset: 0x000016E0
			// (set) Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000EA")]
			public double startTime
			{
				[Token(Token = "0x6000353")]
				[Address(RVA = "0x4007440", Offset = "0x4006040", VA = "0x184007440")]
				get
				{
					return 0.0;
				}
				[Token(Token = "0x6000354")]
				[Address(RVA = "0x55F8490", Offset = "0x55F7090", VA = "0x1855F8490")]
				set
				{
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x06000355 RID: 853 RVA: 0x000034F8 File Offset: 0x000016F8
			// (set) Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000EB")]
			public double performedTime
			{
				[Token(Token = "0x6000355")]
				[Address(RVA = "0x28615D0", Offset = "0x28601D0", VA = "0x1828615D0")]
				get
				{
					return 0.0;
				}
				[Token(Token = "0x6000356")]
				[Address(RVA = "0x53F4480", Offset = "0x53F3080", VA = "0x1853F4480")]
				set
				{
				}
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x06000357 RID: 855 RVA: 0x00003510 File Offset: 0x00001710
			// (set) Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000EC")]
			public double timerStartTime
			{
				[Token(Token = "0x6000357")]
				[Address(RVA = "0x28614A0", Offset = "0x28600A0", VA = "0x1828614A0")]
				get
				{
					return 0.0;
				}
				[Token(Token = "0x6000358")]
				[Address(RVA = "0x55E5D70", Offset = "0x55E4970", VA = "0x1855E5D70")]
				set
				{
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x06000359 RID: 857 RVA: 0x00003528 File Offset: 0x00001728
			// (set) Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000ED")]
			public float timerDuration
			{
				[Token(Token = "0x6000359")]
				[Address(RVA = "0x877280", Offset = "0x875E80", VA = "0x180877280")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600035A")]
				[Address(RVA = "0x8772B0", Offset = "0x875EB0", VA = "0x1808772B0")]
				set
				{
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x0600035B RID: 859 RVA: 0x00003540 File Offset: 0x00001740
			// (set) Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000EE")]
			public float totalTimeoutCompletionDone
			{
				[Token(Token = "0x600035B")]
				[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600035C")]
				[Address(RVA = "0x73B900", Offset = "0x73A500", VA = "0x18073B900")]
				set
				{
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x0600035D RID: 861 RVA: 0x00003558 File Offset: 0x00001758
			// (set) Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000EF")]
			public float totalTimeoutCompletionTimeRemaining
			{
				[Token(Token = "0x600035D")]
				[Address(RVA = "0x73B8E0", Offset = "0x73A4E0", VA = "0x18073B8E0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600035E")]
				[Address(RVA = "0x73B910", Offset = "0x73A510", VA = "0x18073B910")]
				set
				{
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x0600035F RID: 863 RVA: 0x00003570 File Offset: 0x00001770
			// (set) Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F0")]
			public long timerMonitorIndex
			{
				[Token(Token = "0x600035F")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6000360")]
				[Address(RVA = "0x20339E0", Offset = "0x20325E0", VA = "0x1820339E0")]
				set
				{
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000361 RID: 865 RVA: 0x00003588 File Offset: 0x00001788
			// (set) Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F1")]
			public bool isTimerRunning
			{
				[Token(Token = "0x6000361")]
				[Address(RVA = "0x55F8420", Offset = "0x55F7020", VA = "0x1855F8420")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000362")]
				[Address(RVA = "0x55F8450", Offset = "0x55F7050", VA = "0x1855F8450")]
				set
				{
				}
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x06000363 RID: 867 RVA: 0x000035A0 File Offset: 0x000017A0
			// (set) Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F2")]
			public InputActionPhase phase
			{
				[Token(Token = "0x6000363")]
				[Address(RVA = "0x217A7C0", Offset = "0x21793C0", VA = "0x18217A7C0")]
				get
				{
					return InputActionPhase.Disabled;
				}
				[Token(Token = "0x6000364")]
				[Address(RVA = "0x55F8480", Offset = "0x55F7080", VA = "0x1855F8480")]
				set
				{
				}
			}

			// Token: 0x04000174 RID: 372
			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ushort m_TriggerControlIndex;

			// Token: 0x04000175 RID: 373
			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			private byte m_Phase;

			// Token: 0x04000176 RID: 374
			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			private byte m_Flags;

			// Token: 0x04000177 RID: 375
			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private float m_TimerDuration;

			// Token: 0x04000178 RID: 376
			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private double m_StartTime;

			// Token: 0x04000179 RID: 377
			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private double m_TimerStartTime;

			// Token: 0x0400017A RID: 378
			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private double m_PerformedTime;

			// Token: 0x0400017B RID: 379
			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float m_TotalTimeoutCompletionTimeDone;

			// Token: 0x0400017C RID: 380
			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float m_TotalTimeoutCompletionTimeRemaining;

			// Token: 0x0400017D RID: 381
			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private long m_TimerMonitorIndex;

			// Token: 0x02000043 RID: 67
			[Token(Token = "0x2000043")]
			[Flags]
			private enum Flags
			{
				// Token: 0x0400017F RID: 383
				[Token(Token = "0x400017F")]
				TimerRunning = 1
			}
		}

		// Token: 0x02000044 RID: 68
		[Token(Token = "0x2000044")]
		[StructLayout(2)]
		internal struct BindingState
		{
			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x06000365 RID: 869 RVA: 0x000035B8 File Offset: 0x000017B8
			// (set) Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F3")]
			public int controlStartIndex
			{
				[Token(Token = "0x6000365")]
				[Address(RVA = "0x55E5720", Offset = "0x55E4320", VA = "0x1855E5720")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000366")]
				[Address(RVA = "0x55E5A10", Offset = "0x55E4610", VA = "0x1855E5A10")]
				set
				{
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x06000367 RID: 871 RVA: 0x000035D0 File Offset: 0x000017D0
			// (set) Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F4")]
			public int controlCount
			{
				[Token(Token = "0x6000367")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000368")]
				[Address(RVA = "0x55E5970", Offset = "0x55E4570", VA = "0x1855E5970")]
				set
				{
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x06000369 RID: 873 RVA: 0x000035E8 File Offset: 0x000017E8
			// (set) Token: 0x0600036A RID: 874 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F5")]
			public int interactionStartIndex
			{
				[Token(Token = "0x6000369")]
				[Address(RVA = "0x55E5740", Offset = "0x55E4340", VA = "0x1855E5740")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600036A")]
				[Address(RVA = "0x55E5B80", Offset = "0x55E4780", VA = "0x1855E5B80")]
				set
				{
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x0600036B RID: 875 RVA: 0x00003600 File Offset: 0x00001800
			// (set) Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F6")]
			public int interactionCount
			{
				[Token(Token = "0x600036B")]
				[Address(RVA = "0x217A7B0", Offset = "0x21793B0", VA = "0x18217A7B0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600036C")]
				[Address(RVA = "0x55E5AE0", Offset = "0x55E46E0", VA = "0x1855E5AE0")]
				set
				{
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x0600036D RID: 877 RVA: 0x00003618 File Offset: 0x00001818
			// (set) Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F7")]
			public int processorStartIndex
			{
				[Token(Token = "0x600036D")]
				[Address(RVA = "0x55E57B0", Offset = "0x55E43B0", VA = "0x1855E57B0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600036E")]
				[Address(RVA = "0x55E5E20", Offset = "0x55E4A20", VA = "0x1855E5E20")]
				set
				{
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x0600036F RID: 879 RVA: 0x00003630 File Offset: 0x00001830
			// (set) Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F8")]
			public int processorCount
			{
				[Token(Token = "0x600036F")]
				[Address(RVA = "0x217A7C0", Offset = "0x21793C0", VA = "0x18217A7C0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000370")]
				[Address(RVA = "0x55E5D80", Offset = "0x55E4980", VA = "0x1855E5D80")]
				set
				{
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x06000371 RID: 881 RVA: 0x00003648 File Offset: 0x00001848
			// (set) Token: 0x06000372 RID: 882 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F9")]
			public int actionIndex
			{
				[Token(Token = "0x6000371")]
				[Address(RVA = "0x55E56D0", Offset = "0x55E42D0", VA = "0x1855E56D0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000372")]
				[Address(RVA = "0x55E57E0", Offset = "0x55E43E0", VA = "0x1855E57E0")]
				set
				{
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x06000373 RID: 883 RVA: 0x00003660 File Offset: 0x00001860
			// (set) Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000FA")]
			public int mapIndex
			{
				[Token(Token = "0x6000373")]
				[Address(RVA = "0x4ED7AD0", Offset = "0x4ED66D0", VA = "0x184ED7AD0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000374")]
				[Address(RVA = "0x55E5CC0", Offset = "0x55E48C0", VA = "0x1855E5CC0")]
				set
				{
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000375 RID: 885 RVA: 0x00003678 File Offset: 0x00001878
			// (set) Token: 0x06000376 RID: 886 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000FB")]
			public int compositeOrCompositeBindingIndex
			{
				[Token(Token = "0x6000375")]
				[Address(RVA = "0x55E5700", Offset = "0x55E4300", VA = "0x1855E5700")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000376")]
				[Address(RVA = "0x55E58C0", Offset = "0x55E44C0", VA = "0x1855E58C0")]
				set
				{
				}
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000377 RID: 887 RVA: 0x00003690 File Offset: 0x00001890
			// (set) Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000FC")]
			public int triggerEventIdForComposite
			{
				[Token(Token = "0x6000377")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000378")]
				[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
				set
				{
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x06000379 RID: 889 RVA: 0x000036A8 File Offset: 0x000018A8
			// (set) Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000FD")]
			public double pressTime
			{
				[Token(Token = "0x6000379")]
				[Address(RVA = "0x28614A0", Offset = "0x28600A0", VA = "0x1828614A0")]
				get
				{
					return 0.0;
				}
				[Token(Token = "0x600037A")]
				[Address(RVA = "0x55E5D70", Offset = "0x55E4970", VA = "0x1855E5D70")]
				set
				{
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x0600037B RID: 891 RVA: 0x000036C0 File Offset: 0x000018C0
			// (set) Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000FE")]
			public InputActionState.BindingState.Flags flags
			{
				[Token(Token = "0x600037B")]
				[Address(RVA = "0x33E8C90", Offset = "0x33E7890", VA = "0x1833E8C90")]
				get
				{
					return (InputActionState.BindingState.Flags)0;
				}
				[Token(Token = "0x600037C")]
				[Address(RVA = "0x33E8CA0", Offset = "0x33E78A0", VA = "0x1833E8CA0")]
				set
				{
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x0600037D RID: 893 RVA: 0x000036D8 File Offset: 0x000018D8
			// (set) Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000FF")]
			public bool chainsWithNext
			{
				[Token(Token = "0x600037D")]
				[Address(RVA = "0x55E56F0", Offset = "0x55E42F0", VA = "0x1855E56F0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600037E")]
				[Address(RVA = "0x55E5890", Offset = "0x55E4490", VA = "0x1855E5890")]
				set
				{
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x0600037F RID: 895 RVA: 0x000036F0 File Offset: 0x000018F0
			// (set) Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000100")]
			public bool isEndOfChain
			{
				[Token(Token = "0x600037F")]
				[Address(RVA = "0x55E5770", Offset = "0x55E4370", VA = "0x1855E5770")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000380")]
				[Address(RVA = "0x55E5C60", Offset = "0x55E4860", VA = "0x1855E5C60")]
				set
				{
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000381 RID: 897 RVA: 0x00003708 File Offset: 0x00001908
			[Token(Token = "0x17000101")]
			public bool isPartOfChain
			{
				[Token(Token = "0x6000381")]
				[Address(RVA = "0x55E5780", Offset = "0x55E4380", VA = "0x1855E5780")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x06000382 RID: 898 RVA: 0x00003720 File Offset: 0x00001920
			// (set) Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000102")]
			public bool isComposite
			{
				[Token(Token = "0x6000382")]
				[Address(RVA = "0x55E5760", Offset = "0x55E4360", VA = "0x1855E5760")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000383")]
				[Address(RVA = "0x55E5C30", Offset = "0x55E4830", VA = "0x1855E5C30")]
				set
				{
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000384 RID: 900 RVA: 0x00003738 File Offset: 0x00001938
			// (set) Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000103")]
			public bool isPartOfComposite
			{
				[Token(Token = "0x6000384")]
				[Address(RVA = "0x55E5790", Offset = "0x55E4390", VA = "0x1855E5790")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000385")]
				[Address(RVA = "0x55E5C90", Offset = "0x55E4890", VA = "0x1855E5C90")]
				set
				{
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x06000386 RID: 902 RVA: 0x00003750 File Offset: 0x00001950
			// (set) Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000104")]
			public bool initialStateCheckPending
			{
				[Token(Token = "0x6000386")]
				[Address(RVA = "0x55E5730", Offset = "0x55E4330", VA = "0x1855E5730")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000387")]
				[Address(RVA = "0x55E5AB0", Offset = "0x55E46B0", VA = "0x1855E5AB0")]
				set
				{
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x06000388 RID: 904 RVA: 0x00003768 File Offset: 0x00001968
			// (set) Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000105")]
			public bool wantsInitialStateCheck
			{
				[Token(Token = "0x6000388")]
				[Address(RVA = "0x55E57D0", Offset = "0x55E43D0", VA = "0x1855E57D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000389")]
				[Address(RVA = "0x55E5ED0", Offset = "0x55E4AD0", VA = "0x1855E5ED0")]
				set
				{
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x0600038A RID: 906 RVA: 0x00003780 File Offset: 0x00001980
			// (set) Token: 0x0600038B RID: 907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000106")]
			public int partIndex
			{
				[Token(Token = "0x600038A")]
				[Address(RVA = "0x55E57A0", Offset = "0x55E43A0", VA = "0x1855E57A0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600038B")]
				[Address(RVA = "0x55E5D60", Offset = "0x55E4960", VA = "0x1855E5D60")]
				set
				{
				}
			}

			// Token: 0x04000180 RID: 384
			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private byte m_ControlCount;

			// Token: 0x04000181 RID: 385
			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			private byte m_InteractionCount;

			// Token: 0x04000182 RID: 386
			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			private byte m_ProcessorCount;

			// Token: 0x04000183 RID: 387
			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			private byte m_MapIndex;

			// Token: 0x04000184 RID: 388
			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private byte m_Flags;

			// Token: 0x04000185 RID: 389
			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			private byte m_PartIndex;

			// Token: 0x04000186 RID: 390
			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			private ushort m_ActionIndex;

			// Token: 0x04000187 RID: 391
			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private ushort m_CompositeOrCompositeBindingIndex;

			// Token: 0x04000188 RID: 392
			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			private ushort m_ProcessorStartIndex;

			// Token: 0x04000189 RID: 393
			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private ushort m_InteractionStartIndex;

			// Token: 0x0400018A RID: 394
			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			private ushort m_ControlStartIndex;

			// Token: 0x0400018B RID: 395
			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private double m_PressTime;

			// Token: 0x0400018C RID: 396
			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int m_TriggerEventIdForComposite;

			// Token: 0x0400018D RID: 397
			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int __padding;

			// Token: 0x02000045 RID: 69
			[Token(Token = "0x2000045")]
			[Flags]
			public enum Flags
			{
				// Token: 0x0400018F RID: 399
				[Token(Token = "0x400018F")]
				ChainsWithNext = 1,
				// Token: 0x04000190 RID: 400
				[Token(Token = "0x4000190")]
				EndOfChain = 2,
				// Token: 0x04000191 RID: 401
				[Token(Token = "0x4000191")]
				Composite = 4,
				// Token: 0x04000192 RID: 402
				[Token(Token = "0x4000192")]
				PartOfComposite = 8,
				// Token: 0x04000193 RID: 403
				[Token(Token = "0x4000193")]
				InitialStateCheckPending = 16,
				// Token: 0x04000194 RID: 404
				[Token(Token = "0x4000194")]
				WantsInitialStateCheck = 32
			}
		}

		// Token: 0x02000046 RID: 70
		[Token(Token = "0x2000046")]
		[StructLayout(2)]
		public struct TriggerState
		{
			// Token: 0x17000107 RID: 263
			// (get) Token: 0x0600038C RID: 908 RVA: 0x00003798 File Offset: 0x00001998
			// (set) Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000107")]
			public InputActionPhase phase
			{
				[Token(Token = "0x600038C")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				get
				{
					return InputActionPhase.Disabled;
				}
				[Token(Token = "0x600038D")]
				[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
				set
				{
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x0600038E RID: 910 RVA: 0x000037B0 File Offset: 0x000019B0
			[Token(Token = "0x17000108")]
			public bool isDisabled
			{
				[Token(Token = "0x600038E")]
				[Address(RVA = "0x1A15A50", Offset = "0x1A14650", VA = "0x181A15A50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x0600038F RID: 911 RVA: 0x000037C8 File Offset: 0x000019C8
			[Token(Token = "0x17000109")]
			public bool isWaiting
			{
				[Token(Token = "0x600038F")]
				[Address(RVA = "0x55F85F0", Offset = "0x55F71F0", VA = "0x1855F85F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x06000390 RID: 912 RVA: 0x000037E0 File Offset: 0x000019E0
			[Token(Token = "0x1700010A")]
			public bool isStarted
			{
				[Token(Token = "0x6000390")]
				[Address(RVA = "0x55F85E0", Offset = "0x55F71E0", VA = "0x1855F85E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x06000391 RID: 913 RVA: 0x000037F8 File Offset: 0x000019F8
			[Token(Token = "0x1700010B")]
			public bool isPerformed
			{
				[Token(Token = "0x6000391")]
				[Address(RVA = "0x55F85C0", Offset = "0x55F71C0", VA = "0x1855F85C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000392 RID: 914 RVA: 0x00003810 File Offset: 0x00001A10
			[Token(Token = "0x1700010C")]
			public bool isCanceled
			{
				[Token(Token = "0x6000392")]
				[Address(RVA = "0x55F85A0", Offset = "0x55F71A0", VA = "0x1855F85A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000393 RID: 915 RVA: 0x00003828 File Offset: 0x00001A28
			// (set) Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700010D")]
			public double time
			{
				[Token(Token = "0x6000393")]
				[Address(RVA = "0x4007440", Offset = "0x4006040", VA = "0x184007440")]
				get
				{
					return 0.0;
				}
				[Token(Token = "0x6000394")]
				[Address(RVA = "0x55F8490", Offset = "0x55F7090", VA = "0x1855F8490")]
				set
				{
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000395 RID: 917 RVA: 0x00003840 File Offset: 0x00001A40
			// (set) Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700010E")]
			public double startTime
			{
				[Token(Token = "0x6000395")]
				[Address(RVA = "0x28614A0", Offset = "0x28600A0", VA = "0x1828614A0")]
				get
				{
					return 0.0;
				}
				[Token(Token = "0x6000396")]
				[Address(RVA = "0x55E5D70", Offset = "0x55E4970", VA = "0x1855E5D70")]
				set
				{
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000397 RID: 919 RVA: 0x00003858 File Offset: 0x00001A58
			// (set) Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700010F")]
			public float magnitude
			{
				[Token(Token = "0x6000397")]
				[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000398")]
				[Address(RVA = "0x55F8890", Offset = "0x55F7490", VA = "0x1855F8890")]
				set
				{
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000399 RID: 921 RVA: 0x00003870 File Offset: 0x00001A70
			[Token(Token = "0x17000110")]
			public bool haveMagnitude
			{
				[Token(Token = "0x6000399")]
				[Address(RVA = "0x55F8550", Offset = "0x55F7150", VA = "0x1855F8550")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x0600039A RID: 922 RVA: 0x00003888 File Offset: 0x00001A88
			// (set) Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000111")]
			public int mapIndex
			{
				[Token(Token = "0x600039A")]
				[Address(RVA = "0x217A7C0", Offset = "0x21793C0", VA = "0x18217A7C0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600039B")]
				[Address(RVA = "0x55F88A0", Offset = "0x55F74A0", VA = "0x1855F88A0")]
				set
				{
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x0600039C RID: 924 RVA: 0x000038A0 File Offset: 0x00001AA0
			// (set) Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000112")]
			public int controlIndex
			{
				[Token(Token = "0x600039C")]
				[Address(RVA = "0x55F8520", Offset = "0x55F7120", VA = "0x1855F8520")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600039D")]
				[Address(RVA = "0x55F8680", Offset = "0x55F7280", VA = "0x1855F8680")]
				set
				{
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x0600039E RID: 926 RVA: 0x000038B8 File Offset: 0x00001AB8
			// (set) Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000113")]
			public int bindingIndex
			{
				[Token(Token = "0x600039E")]
				[Address(RVA = "0x3FD84D0", Offset = "0x3FD70D0", VA = "0x183FD84D0")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600039F")]
				[Address(RVA = "0x55F8610", Offset = "0x55F7210", VA = "0x1855F8610")]
				set
				{
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x060003A0 RID: 928 RVA: 0x000038D0 File Offset: 0x00001AD0
			// (set) Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000114")]
			public int interactionIndex
			{
				[Token(Token = "0x60003A0")]
				[Address(RVA = "0x55F8570", Offset = "0x55F7170", VA = "0x1855F8570")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60003A1")]
				[Address(RVA = "0x55F8770", Offset = "0x55F7370", VA = "0x1855F8770")]
				set
				{
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x060003A2 RID: 930 RVA: 0x000038E8 File Offset: 0x00001AE8
			// (set) Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000115")]
			public uint lastPerformedInUpdate
			{
				[Token(Token = "0x60003A2")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x60003A3")]
				[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
				set
				{
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x060003A4 RID: 932 RVA: 0x00003900 File Offset: 0x00001B00
			// (set) Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000116")]
			public uint lastCanceledInUpdate
			{
				[Token(Token = "0x60003A4")]
				[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x60003A5")]
				[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
				set
				{
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x060003A6 RID: 934 RVA: 0x00003918 File Offset: 0x00001B18
			// (set) Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000117")]
			public uint pressedInUpdate
			{
				[Token(Token = "0x60003A6")]
				[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x60003A7")]
				[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
				set
				{
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x060003A8 RID: 936 RVA: 0x00003930 File Offset: 0x00001B30
			// (set) Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000118")]
			public uint releasedInUpdate
			{
				[Token(Token = "0x60003A8")]
				[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x60003A9")]
				[Address(RVA = "0x150B0E0", Offset = "0x1509CE0", VA = "0x18150B0E0")]
				set
				{
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x060003AA RID: 938 RVA: 0x00003948 File Offset: 0x00001B48
			// (set) Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000119")]
			public bool isPassThrough
			{
				[Token(Token = "0x60003AA")]
				[Address(RVA = "0x55F85B0", Offset = "0x55F71B0", VA = "0x1855F85B0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003AB")]
				[Address(RVA = "0x55F8830", Offset = "0x55F7430", VA = "0x1855F8830")]
				set
				{
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x060003AC RID: 940 RVA: 0x00003960 File Offset: 0x00001B60
			// (set) Token: 0x060003AD RID: 941 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700011A")]
			public bool isButton
			{
				[Token(Token = "0x60003AC")]
				[Address(RVA = "0x55F8590", Offset = "0x55F7190", VA = "0x1855F8590")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003AD")]
				[Address(RVA = "0x55F8800", Offset = "0x55F7400", VA = "0x1855F8800")]
				set
				{
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x060003AE RID: 942 RVA: 0x00003978 File Offset: 0x00001B78
			// (set) Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700011B")]
			public bool isPressed
			{
				[Token(Token = "0x60003AE")]
				[Address(RVA = "0x55F85D0", Offset = "0x55F71D0", VA = "0x1855F85D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003AF")]
				[Address(RVA = "0x55F8860", Offset = "0x55F7460", VA = "0x1855F8860")]
				set
				{
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x060003B0 RID: 944 RVA: 0x00003990 File Offset: 0x00001B90
			// (set) Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700011C")]
			public bool mayNeedConflictResolution
			{
				[Token(Token = "0x60003B0")]
				[Address(RVA = "0x55F8600", Offset = "0x55F7200", VA = "0x1855F8600")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003B1")]
				[Address(RVA = "0x55F8910", Offset = "0x55F7510", VA = "0x1855F8910")]
				set
				{
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x060003B2 RID: 946 RVA: 0x000039A8 File Offset: 0x00001BA8
			// (set) Token: 0x060003B3 RID: 947 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700011D")]
			public bool hasMultipleConcurrentActuations
			{
				[Token(Token = "0x60003B2")]
				[Address(RVA = "0x55F8540", Offset = "0x55F7140", VA = "0x1855F8540")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003B3")]
				[Address(RVA = "0x55F8710", Offset = "0x55F7310", VA = "0x1855F8710")]
				set
				{
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x060003B4 RID: 948 RVA: 0x000039C0 File Offset: 0x00001BC0
			// (set) Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700011E")]
			public bool inProcessing
			{
				[Token(Token = "0x60003B4")]
				[Address(RVA = "0x55F8560", Offset = "0x55F7160", VA = "0x1855F8560")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003B5")]
				[Address(RVA = "0x55F8740", Offset = "0x55F7340", VA = "0x1855F8740")]
				set
				{
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x060003B6 RID: 950 RVA: 0x000039D8 File Offset: 0x00001BD8
			// (set) Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700011F")]
			public InputActionState.TriggerState.Flags flags
			{
				[Token(Token = "0x60003B6")]
				[Address(RVA = "0x217A7B0", Offset = "0x21793B0", VA = "0x18217A7B0")]
				get
				{
					return (InputActionState.TriggerState.Flags)0;
				}
				[Token(Token = "0x60003B7")]
				[Address(RVA = "0x3188710", Offset = "0x3187310", VA = "0x183188710")]
				set
				{
				}
			}

			// Token: 0x04000195 RID: 405
			[Token(Token = "0x4000195")]
			public const int kMaxNumMaps = 255;

			// Token: 0x04000196 RID: 406
			[Token(Token = "0x4000196")]
			public const int kMaxNumControls = 65535;

			// Token: 0x04000197 RID: 407
			[Token(Token = "0x4000197")]
			public const int kMaxNumBindings = 65535;

			// Token: 0x04000198 RID: 408
			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private byte m_Phase;

			// Token: 0x04000199 RID: 409
			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			private byte m_Flags;

			// Token: 0x0400019A RID: 410
			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			private byte m_MapIndex;

			// Token: 0x0400019B RID: 411
			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private ushort m_ControlIndex;

			// Token: 0x0400019C RID: 412
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private double m_Time;

			// Token: 0x0400019D RID: 413
			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private double m_StartTime;

			// Token: 0x0400019E RID: 414
			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private ushort m_BindingIndex;

			// Token: 0x0400019F RID: 415
			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			private ushort m_InteractionIndex;

			// Token: 0x040001A0 RID: 416
			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private float m_Magnitude;

			// Token: 0x040001A1 RID: 417
			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private uint m_LastPerformedInUpdate;

			// Token: 0x040001A2 RID: 418
			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private uint m_LastCanceledInUpdate;

			// Token: 0x040001A3 RID: 419
			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private uint m_PressedInUpdate;

			// Token: 0x040001A4 RID: 420
			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private uint m_ReleasedInUpdate;

			// Token: 0x02000047 RID: 71
			[Token(Token = "0x2000047")]
			[Flags]
			public enum Flags
			{
				// Token: 0x040001A6 RID: 422
				[Token(Token = "0x40001A6")]
				HaveMagnitude = 1,
				// Token: 0x040001A7 RID: 423
				[Token(Token = "0x40001A7")]
				PassThrough = 2,
				// Token: 0x040001A8 RID: 424
				[Token(Token = "0x40001A8")]
				MayNeedConflictResolution = 4,
				// Token: 0x040001A9 RID: 425
				[Token(Token = "0x40001A9")]
				HasMultipleConcurrentActuations = 8,
				// Token: 0x040001AA RID: 426
				[Token(Token = "0x40001AA")]
				InProcessing = 16,
				// Token: 0x040001AB RID: 427
				[Token(Token = "0x40001AB")]
				Button = 32,
				// Token: 0x040001AC RID: 428
				[Token(Token = "0x40001AC")]
				Pressed = 64
			}
		}

		// Token: 0x02000048 RID: 72
		[Token(Token = "0x2000048")]
		public struct ActionMapIndices
		{
			// Token: 0x040001AD RID: 429
			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int actionStartIndex;

			// Token: 0x040001AE RID: 430
			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int actionCount;

			// Token: 0x040001AF RID: 431
			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int controlStartIndex;

			// Token: 0x040001B0 RID: 432
			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int controlCount;

			// Token: 0x040001B1 RID: 433
			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int bindingStartIndex;

			// Token: 0x040001B2 RID: 434
			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int bindingCount;

			// Token: 0x040001B3 RID: 435
			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int interactionStartIndex;

			// Token: 0x040001B4 RID: 436
			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int interactionCount;

			// Token: 0x040001B5 RID: 437
			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int processorStartIndex;

			// Token: 0x040001B6 RID: 438
			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int processorCount;

			// Token: 0x040001B7 RID: 439
			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int compositeStartIndex;

			// Token: 0x040001B8 RID: 440
			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int compositeCount;
		}

		// Token: 0x02000049 RID: 73
		[Token(Token = "0x2000049")]
		public struct UnmanagedMemory : IDisposable
		{
			// Token: 0x17000120 RID: 288
			// (get) Token: 0x060003B8 RID: 952 RVA: 0x000039F0 File Offset: 0x00001BF0
			[Token(Token = "0x17000120")]
			public bool isAllocated
			{
				[Token(Token = "0x60003B8")]
				[Address(RVA = "0x4226870", Offset = "0x4225470", VA = "0x184226870")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x060003B9 RID: 953 RVA: 0x00003A08 File Offset: 0x00001C08
			[Token(Token = "0x17000121")]
			public int sizeInBytes
			{
				[Token(Token = "0x60003B9")]
				[Address(RVA = "0x55F95E0", Offset = "0x55F81E0", VA = "0x1855F95E0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x55F9160", Offset = "0x55F7D60", VA = "0x1855F9160")]
			public void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount)
			{
			}

			// Token: 0x060003BB RID: 955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x55F9580", Offset = "0x55F8180", VA = "0x1855F9580", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x55F9420", Offset = "0x55F8020", VA = "0x1855F9420")]
			public void CopyDataFrom(InputActionState.UnmanagedMemory memory)
			{
			}

			// Token: 0x060003BD RID: 957 RVA: 0x00003A20 File Offset: 0x00001C20
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x55F92D0", Offset = "0x55F7ED0", VA = "0x1855F92D0")]
			public InputActionState.UnmanagedMemory Clone()
			{
				return default(InputActionState.UnmanagedMemory);
			}

			// Token: 0x040001B9 RID: 441
			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public unsafe void* basePtr;

			// Token: 0x040001BA RID: 442
			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int mapCount;

			// Token: 0x040001BB RID: 443
			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int actionCount;

			// Token: 0x040001BC RID: 444
			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int interactionCount;

			// Token: 0x040001BD RID: 445
			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int bindingCount;

			// Token: 0x040001BE RID: 446
			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int controlCount;

			// Token: 0x040001BF RID: 447
			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int compositeCount;

			// Token: 0x040001C0 RID: 448
			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public unsafe InputActionState.TriggerState* actionStates;

			// Token: 0x040001C1 RID: 449
			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public unsafe InputActionState.BindingState* bindingStates;

			// Token: 0x040001C2 RID: 450
			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public unsafe InputActionState.InteractionState* interactionStates;

			// Token: 0x040001C3 RID: 451
			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public unsafe float* controlMagnitudes;

			// Token: 0x040001C4 RID: 452
			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public unsafe float* compositeMagnitudes;

			// Token: 0x040001C5 RID: 453
			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public unsafe int* enabledControls;

			// Token: 0x040001C6 RID: 454
			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public unsafe ushort* actionBindingIndicesAndCounts;

			// Token: 0x040001C7 RID: 455
			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public unsafe ushort* actionBindingIndices;

			// Token: 0x040001C8 RID: 456
			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public unsafe int* controlIndexToBindingIndex;

			// Token: 0x040001C9 RID: 457
			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public unsafe ushort* controlGroupingAndComplexity;

			// Token: 0x040001CA RID: 458
			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public bool controlGroupingInitialized;

			// Token: 0x040001CB RID: 459
			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public unsafe InputActionState.ActionMapIndices* mapIndices;
		}

		// Token: 0x0200004A RID: 74
		[Token(Token = "0x200004A")]
		internal struct GlobalState
		{
			// Token: 0x040001CC RID: 460
			[Token(Token = "0x40001CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal InlinedArray<GCHandle> globalList;

			// Token: 0x040001CD RID: 461
			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal CallbackArray<Action<object, InputActionChange>> onActionChange;

			// Token: 0x040001CE RID: 462
			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal CallbackArray<Action<object>> onActionControlsChanged;
		}
	}
}
