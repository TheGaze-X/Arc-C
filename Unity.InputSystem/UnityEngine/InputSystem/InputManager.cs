using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	internal class InputManager
	{
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x17000298")]
		public ReadOnlyArray<InputDevice> devices
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x5695570", Offset = "0x5694170", VA = "0x185695570")]
			get
			{
				return default(ReadOnlyArray<InputDevice>);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x17000299")]
		public TypeTable processors
		{
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return default(TypeTable);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x1700029A")]
		public TypeTable interactions
		{
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return default(TypeTable);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x1700029B")]
		public TypeTable composites
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return default(TypeTable);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x1700029C")]
		public InputMetrics metrics
		{
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x5695650", Offset = "0x5694250", VA = "0x185695650")]
			get
			{
				return default(InputMetrics);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029D")]
		public InputSettings settings
		{
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x5695800", Offset = "0x5694400", VA = "0x185695800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x5695BC0", Offset = "0x56947C0", VA = "0x185695BC0")]
			set
			{
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x000052E0 File Offset: 0x000034E0
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029E")]
		public InputUpdateType updateMask
		{
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x538F7E0", Offset = "0x538E3E0", VA = "0x18538F7E0")]
			get
			{
				return InputUpdateType.None;
			}
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x5695CD0", Offset = "0x56948D0", VA = "0x185695CD0")]
			set
			{
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x000052F8 File Offset: 0x000034F8
		[Token(Token = "0x1700029F")]
		public InputUpdateType defaultUpdateType
		{
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x5695550", Offset = "0x5694150", VA = "0x185695550")]
			get
			{
				return InputUpdateType.None;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00005310 File Offset: 0x00003510
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A0")]
		public float pollingFrequency
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x4F1EB0", Offset = "0x4F0AB0", VA = "0x1804F1EB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x5695AE0", Offset = "0x56946E0", VA = "0x185695AE0")]
			set
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000A1B RID: 2587 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A1C RID: 2588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000F")]
		public event Action<InputDevice, InputDeviceChange> onDeviceChange
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x5695310", Offset = "0x5693F10", VA = "0x185695310")]
			add
			{
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x56958B0", Offset = "0x56944B0", VA = "0x1856958B0")]
			remove
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000A1D RID: 2589 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A1E RID: 2590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000010")]
		public event Action<InputDevice, InputEventPtr> onDeviceStateChange
		{
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x56953B0", Offset = "0x5693FB0", VA = "0x1856953B0")]
			add
			{
			}
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x5695950", Offset = "0x5694550", VA = "0x185695950")]
			remove
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000A1F RID: 2591 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A20 RID: 2592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000011")]
		public event InputDeviceCommandDelegate onDeviceCommand
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x5695360", Offset = "0x5693F60", VA = "0x185695360")]
			add
			{
			}
			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x5695900", Offset = "0x5694500", VA = "0x185695900")]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000A21 RID: 2593 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A22 RID: 2594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000012")]
		public event InputDeviceFindControlLayoutDelegate onFindControlLayoutForDevice
		{
			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x5695450", Offset = "0x5694050", VA = "0x185695450")]
			add
			{
			}
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x56959F0", Offset = "0x56945F0", VA = "0x1856959F0")]
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000A23 RID: 2595 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A24 RID: 2596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000013")]
		public event Action<string, InputControlLayoutChange> onLayoutChange
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x56954B0", Offset = "0x56940B0", VA = "0x1856954B0")]
			add
			{
			}
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x5695A40", Offset = "0x5694640", VA = "0x185695A40")]
			remove
			{
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000A25 RID: 2597 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A26 RID: 2598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000014")]
		public event Action<InputEventPtr, InputDevice> onEvent
		{
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x5695400", Offset = "0x5694000", VA = "0x185695400")]
			add
			{
			}
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x56959A0", Offset = "0x56945A0", VA = "0x1856959A0")]
			remove
			{
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000A27 RID: 2599 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A28 RID: 2600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000015")]
		public event Action onBeforeUpdate
		{
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x56952B0", Offset = "0x5693EB0", VA = "0x1856952B0")]
			add
			{
			}
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x5695860", Offset = "0x5694460", VA = "0x185695860")]
			remove
			{
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000A29 RID: 2601 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A2A RID: 2602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000016")]
		public event Action onAfterUpdate
		{
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x5695260", Offset = "0x5693E60", VA = "0x185695260")]
			add
			{
			}
			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x5695810", Offset = "0x5694410", VA = "0x185695810")]
			remove
			{
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A2C RID: 2604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000017")]
		public event Action onSettingsChange
		{
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x5695500", Offset = "0x5694100", VA = "0x185695500")]
			add
			{
			}
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x5695A90", Offset = "0x5694690", VA = "0x185695A90")]
			remove
			{
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x170002A1")]
		public bool isProcessingEvents
		{
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x5695640", Offset = "0x5694240", VA = "0x185695640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00005340 File Offset: 0x00003540
		[Token(Token = "0x170002A2")]
		private bool gameIsPlaying
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00005358 File Offset: 0x00003558
		[Token(Token = "0x170002A3")]
		private bool gameHasFocus
		{
			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x56955D0", Offset = "0x56941D0", VA = "0x1856955D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00005370 File Offset: 0x00003570
		[Token(Token = "0x170002A4")]
		private bool gameShouldGetInputRegardlessOfFocus
		{
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x5695610", Offset = "0x5694210", VA = "0x185695610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x5691640", Offset = "0x5690240", VA = "0x185691640")]
		public void RegisterControlLayout(string name, Type type)
		{
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x5691DA0", Offset = "0x56909A0", VA = "0x185691DA0")]
		public void RegisterControlLayout(string json, [Optional] string name, bool isOverride = false)
		{
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x5691030", Offset = "0x568FC30", VA = "0x185691030")]
		public void RegisterControlLayoutBuilder(Func<InputControlLayout> method, string name, [Optional] string baseLayout)
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x568FC60", Offset = "0x568E860", VA = "0x18568FC60")]
		private void PerformLayoutPostRegistration(InternedString layoutName, InlinedArray<InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout = false, bool isOverride = false)
		{
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A35")]
		public void RegisterPrecompiledLayout<TDevice>(string metadata) where TDevice : InputDevice, new()
		{
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x5690E50", Offset = "0x568FA50", VA = "0x185690E50")]
		private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout = false)
		{
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00005388 File Offset: 0x00003588
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x568DA40", Offset = "0x568C640", VA = "0x18568DA40")]
		private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout)
		{
			return default(bool);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x000053A0 File Offset: 0x000035A0
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x568DB50", Offset = "0x568C750", VA = "0x18568DB50")]
		private bool IsControlUsingLayout(InputControl control, InternedString layout)
		{
			return default(bool);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x56914A0", Offset = "0x56900A0", VA = "0x1856914A0")]
		public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher)
		{
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x5691250", Offset = "0x568FE50", VA = "0x185691250")]
		public void RegisterControlLayoutMatcher(Type type, InputDeviceMatcher matcher)
		{
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x5690BA0", Offset = "0x568F7A0", VA = "0x185690BA0")]
		private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher)
		{
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x5690A10", Offset = "0x568F610", VA = "0x185690A10")]
		private void RecreateDevice(InputDevice oldDevice, InternedString newLayout)
		{
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x5688790", Offset = "0x5687390", VA = "0x185688790")]
		private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout)
		{
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x5692330", Offset = "0x5690F30", VA = "0x185692330")]
		public void RemoveControlLayout(string name)
		{
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x56941A0", Offset = "0x5692DA0", VA = "0x1856941A0")]
		public InputControlLayout TryLoadControlLayout(Type type)
		{
			return null;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x5694170", Offset = "0x5692D70", VA = "0x185694170")]
		public InputControlLayout TryLoadControlLayout(InternedString name)
		{
			return null;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000053B8 File Offset: 0x000035B8
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x5693B20", Offset = "0x5692720", VA = "0x185693B20")]
		public InternedString TryFindMatchingControlLayout(ref InputDeviceDescription deviceDescription, int deviceId = 0)
		{
			return default(InternedString);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x568AFE0", Offset = "0x5689BE0", VA = "0x18568AFE0")]
		private InternedString FindOrRegisterDeviceLayoutForType(Type type)
		{
			return default(InternedString);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x568DC50", Offset = "0x568C850", VA = "0x18568DC50")]
		private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName)
		{
			return default(bool);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x568DD90", Offset = "0x568C990", VA = "0x18568DD90")]
		public IEnumerable<string> ListControlLayouts([Optional] string basedOn)
		{
			return null;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x6000A45")]
		public int GetControls<TControl>(string path, ref InputControlList<TControl> controls) where TControl : InputControl
		{
			return 0;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x56937C0", Offset = "0x56923C0", VA = "0x1856937C0")]
		public void SetDeviceUsage(InputDevice device, InternedString usage)
		{
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x5688E00", Offset = "0x5687A00", VA = "0x185688E00")]
		public void AddDeviceUsage(InputDevice device, InternedString usage)
		{
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x56926D0", Offset = "0x56912D0", VA = "0x1856926D0")]
		public void RemoveDeviceUsage(InputDevice device, InternedString usage)
		{
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x568DFE0", Offset = "0x568CBE0", VA = "0x18568DFE0")]
		private void NotifyUsageChanged(InputDevice device)
		{
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x56892E0", Offset = "0x5687EE0", VA = "0x1856892E0")]
		public InputDevice AddDevice(Type type, [Optional] string name)
		{
			return null;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x56894A0", Offset = "0x56880A0", VA = "0x1856894A0")]
		public InputDevice AddDevice(string layout, [Optional] string name, [Optional] InternedString variants)
		{
			return null;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x5689DA0", Offset = "0x56889A0", VA = "0x185689DA0")]
		private InputDevice AddDevice(InternedString layout, int deviceId, [Optional] string deviceName, [Optional] InputDeviceDescription deviceDescription, InputDevice.DeviceFlags deviceFlags = (InputDevice.DeviceFlags)0, [Optional] InternedString variants)
		{
			return null;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x5689620", Offset = "0x5688220", VA = "0x185689620")]
		public void AddDevice(InputDevice device)
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x5689F80", Offset = "0x5688B80", VA = "0x185689F80")]
		public InputDevice AddDevice(InputDeviceDescription description)
		{
			return null;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x5689080", Offset = "0x5687C80", VA = "0x185689080")]
		public InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, [Optional] string deviceName, int deviceId = 0, InputDevice.DeviceFlags deviceFlags = (InputDevice.DeviceFlags)0)
		{
			return null;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x5688F80", Offset = "0x5687B80", VA = "0x185688F80")]
		public InputDevice AddDevice(InputDeviceDescription description, InternedString layout, [Optional] string deviceName, int deviceId = 0, InputDevice.DeviceFlags deviceFlags = (InputDevice.DeviceFlags)0)
		{
			return null;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x5692850", Offset = "0x5691450", VA = "0x185692850")]
		public void RemoveDevice(InputDevice device, bool keepOnListOfAvailableDevices = false)
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x568B640", Offset = "0x568A240", VA = "0x18568B640")]
		public void FlushDisconnectedDevices()
		{
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x5693290", Offset = "0x5691E90", VA = "0x185693290")]
		public void ResetDevice(InputDevice device, bool alsoResetDontResetControls = false, [Optional] bool? issueResetCommand)
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x5693FB0", Offset = "0x5692BB0", VA = "0x185693FB0")]
		public InputDevice TryGetDevice(string nameOrLayout)
		{
			return null;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x568B690", Offset = "0x568A290", VA = "0x18568B690")]
		public InputDevice GetDevice(string nameOrLayout)
		{
			return null;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x5694100", Offset = "0x5692D00", VA = "0x185694100")]
		public InputDevice TryGetDevice(Type layoutType)
		{
			return null;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x5693F30", Offset = "0x5692B30", VA = "0x185693F30")]
		public InputDevice TryGetDeviceById(int id)
		{
			return null;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x568B740", Offset = "0x568A340", VA = "0x18568B740")]
		public int GetUnsupportedDevices(List<InputDeviceDescription> descriptions)
		{
			return 0;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x568ABF0", Offset = "0x56897F0", VA = "0x18568ABF0")]
		public void EnableOrDisableDevice(InputDevice device, bool enable, InputManager.DeviceDisableScope scope = InputManager.DeviceDisableScope.Everywhere)
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x5690640", Offset = "0x568F240", VA = "0x185690640")]
		private unsafe void QueueEvent(InputEvent* eventPtr)
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x5690750", Offset = "0x568F350", VA = "0x185690750")]
		public void QueueEvent(InputEventPtr ptr)
		{
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5C")]
		public void QueueEvent<TEvent>(ref TEvent inputEvent) where TEvent : struct, IInputEventTypeInfo
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x5694F90", Offset = "0x5693B90", VA = "0x185694F90")]
		public void Update()
		{
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x5694EA0", Offset = "0x5693AA0", VA = "0x185694EA0")]
		public void Update(InputUpdateType updateType)
		{
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x568D030", Offset = "0x568BC30", VA = "0x18568D030")]
		internal void Initialize(IInputRuntime runtime, InputSettings settings)
		{
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x568AAE0", Offset = "0x56896E0", VA = "0x18568AAE0")]
		internal void Destroy()
		{
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x568B930", Offset = "0x568A530", VA = "0x18568B930")]
		internal void InitializeData()
		{
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x568D650", Offset = "0x568C250", VA = "0x18568D650")]
		internal void InstallRuntime(IInputRuntime runtime)
		{
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x568D3C0", Offset = "0x568BFC0", VA = "0x18568D3C0")]
		internal void InstallGlobals()
		{
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x56946D0", Offset = "0x56932D0", VA = "0x1856946D0")]
		internal void UninstallGlobals()
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x568DE20", Offset = "0x568CA20", VA = "0x18568DE20")]
		private void MakeDeviceNameUnique(InputDevice device)
		{
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x56931D0", Offset = "0x5691DD0", VA = "0x1856931D0")]
		private static void ResetControlPathsRecursive(InputControl control)
		{
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x568A900", Offset = "0x5689500", VA = "0x18568A900")]
		private void AssignUniqueDeviceId(InputDevice device)
		{
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x5690860", Offset = "0x568F460", VA = "0x185690860")]
		private void ReallocateStateBuffers()
		{
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x568CAF0", Offset = "0x568B6F0", VA = "0x18568CAF0")]
		private void InitializeDefaultState(InputDevice device)
		{
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x568CCE0", Offset = "0x568B8E0", VA = "0x18568CCE0")]
		private void InitializeDeviceState(InputDevice device)
		{
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x568E5D0", Offset = "0x568D1D0", VA = "0x18568E5D0")]
		private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor)
		{
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x5694460", Offset = "0x5693060", VA = "0x185694460")]
		private InputDevice TryMatchDisconnectedDevice(string deviceDescriptor)
		{
			return null;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x568D300", Offset = "0x568BF00", VA = "0x18568D300")]
		private void InstallBeforeUpdateHookIfNecessary()
		{
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void RestoreDevicesAfterDomainReloadIfNecessary()
		{
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void WarnAboutDevicesFailingToRecreateAfterDomainReload()
		{
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x568E0A0", Offset = "0x568CCA0", VA = "0x18568E0A0")]
		private void OnBeforeUpdate(InputUpdateType updateType)
		{
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x568A200", Offset = "0x5688E00", VA = "0x18568A200")]
		internal void ApplySettings()
		{
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00005430 File Offset: 0x00003630
		[Token(Token = "0x6000A72")]
		internal long ExecuteGlobalCommand<TCommand>(ref TCommand command) where TCommand : struct, IInputDeviceCommandInfo
		{
			return 0L;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x5688B90", Offset = "0x5687790", VA = "0x185688B90")]
		internal void AddAvailableDevicesThatAreNowRecognized()
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00005448 File Offset: 0x00003648
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x5693970", Offset = "0x5692570", VA = "0x185693970")]
		private bool ShouldRunDeviceInBackground(InputDevice device)
		{
			return default(bool);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x568E220", Offset = "0x568CE20", VA = "0x18568E220")]
		internal void OnFocusChanged(bool focus)
		{
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00005460 File Offset: 0x00003660
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x56939B0", Offset = "0x56925B0", VA = "0x1856939B0")]
		internal bool ShouldRunUpdate(InputUpdateType updateType)
		{
			return default(bool);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x568EBC0", Offset = "0x568D7C0", VA = "0x18568EBC0")]
		private void OnUpdate(InputUpdateType updateType, ref InputEventBuffer eventBuffer)
		{
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x568D9E0", Offset = "0x568C5E0", VA = "0x18568D9E0")]
		private void InvokeAfterUpdateCallback(InputUpdateType updateType)
		{
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x568ABE0", Offset = "0x56897E0", VA = "0x18568ABE0")]
		internal void DontMakeCurrentlyUpdatingDeviceCurrent()
		{
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x5694920", Offset = "0x5693520", VA = "0x185694920")]
		internal unsafe bool UpdateState(InputDevice device, InputEvent* eventPtr, InputUpdateType updateType)
		{
			return default(bool);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00005490 File Offset: 0x00003690
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x5694A90", Offset = "0x5693690", VA = "0x185694A90")]
		internal unsafe bool UpdateState(InputDevice device, InputUpdateType updateType, void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, [Optional] InputEventPtr eventPtr)
		{
			return default(bool);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x5695090", Offset = "0x5693C90", VA = "0x185695090")]
		private unsafe void WriteStateChange(InputStateBuffers.DoubleBuffers buffers, int deviceIndex, ref InputStateBlock deviceStateBlock, uint stateOffsetInDevice, void* statePtr, uint stateSizeInBytes, bool flippedBuffers)
		{
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000054A8 File Offset: 0x000036A8
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x568B590", Offset = "0x568A190", VA = "0x18568B590")]
		private bool FlipBuffersForDeviceIfNecessary(InputDevice device, InputUpdateType updateType)
		{
			return default(bool);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x568A0D0", Offset = "0x5688CD0", VA = "0x18568A0D0")]
		public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex)
		{
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x5693090", Offset = "0x5691C90", VA = "0x185693090")]
		private void RemoveStateChangeMonitors(InputDevice device)
		{
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x5692F10", Offset = "0x5691B10", VA = "0x185692F10")]
		public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex)
		{
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x5689FE0", Offset = "0x5688BE0", VA = "0x185689FE0")]
		public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex)
		{
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x5692DE0", Offset = "0x56919E0", VA = "0x185692DE0")]
		public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex)
		{
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x5693AD0", Offset = "0x56926D0", VA = "0x185693AD0")]
		private void SortStateChangeMonitorsIfNecessary(int deviceIndex)
		{
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x56939D0", Offset = "0x56925D0", VA = "0x1856939D0")]
		public void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor)
		{
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x568B490", Offset = "0x568A090", VA = "0x18568B490")]
		public void FireStateChangeNotifications()
		{
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x000054C0 File Offset: 0x000036C0
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x5690380", Offset = "0x568EF80", VA = "0x185690380")]
		private unsafe bool ProcessStateChangeMonitors(int deviceIndex, void* newStateFromEvent, void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes)
		{
			return default(bool);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x568B0D0", Offset = "0x5689CD0", VA = "0x18568B0D0")]
		internal unsafe void FireStateChangeNotifications(int deviceIndex, double internalTime, InputEvent* eventPtr)
		{
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x5690180", Offset = "0x568ED80", VA = "0x185690180")]
		private void ProcessStateChangeMonitorTimeouts()
		{
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InputManager()
		{
		}

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int m_LayoutRegistrationVersion;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float m_PollingFrequency;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal InputControlLayout.Collection m_Layouts;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TypeTable m_Processors;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TypeTable m_Interactions;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TypeTable m_Composites;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int m_DevicesCount;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private InputDevice[] m_Devices;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<int, InputDevice> m_DevicesById;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal int m_AvailableDeviceCount;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal InputManager.AvailableDevice[] m_AvailableDevices;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal int m_DisconnectedDevicesCount;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal InputDevice[] m_DisconnectedDevices;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal InputUpdateType m_UpdateMask;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private InputUpdateType m_CurrentUpdate;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal InputStateBuffers m_StateBuffers;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private CallbackArray<Action<InputDevice, InputDeviceChange>> m_DeviceChangeListeners;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private CallbackArray<Action<InputDevice, InputEventPtr>> m_DeviceStateChangeListeners;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private CallbackArray<InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		internal CallbackArray<InputDeviceCommandDelegate> m_DeviceCommandCallbacks;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private CallbackArray<Action<string, InputControlLayoutChange>> m_LayoutChangeListeners;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private CallbackArray<Action<InputEventPtr, InputDevice>> m_EventListeners;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private CallbackArray<Action> m_BeforeUpdateListeners;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private CallbackArray<Action> m_AfterUpdateListeners;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private CallbackArray<Action> m_SettingsChangedListeners;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private bool m_NativeBeforeUpdateHooked;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B1")]
		private bool m_HaveDevicesWithStateCallbackReceivers;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B2")]
		private bool m_HasFocus;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private InputEventStream m_InputEventStream;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private int m_DeviceFindExecuteCommandDeviceId;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		internal IInputRuntime m_Runtime;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		internal InputMetrics m_Metrics;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		internal InputSettings m_Settings;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		private bool m_ShouldMakeCurrentlyUpdatingDeviceCurrent;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		internal InputManager.StateChangeMonitorsForDevice[] m_StateChangeMonitors;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		private InlinedArray<InputManager.StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts;

		// Token: 0x020000BD RID: 189
		[Token(Token = "0x20000BD")]
		internal enum DeviceDisableScope
		{
			// Token: 0x0400045D RID: 1117
			[Token(Token = "0x400045D")]
			Everywhere,
			// Token: 0x0400045E RID: 1118
			[Token(Token = "0x400045E")]
			InFrontendOnly,
			// Token: 0x0400045F RID: 1119
			[Token(Token = "0x400045F")]
			TemporaryWhilePlayerIsInBackground
		}

		// Token: 0x020000BE RID: 190
		[Token(Token = "0x20000BE")]
		[Serializable]
		internal struct AvailableDevice
		{
			// Token: 0x04000460 RID: 1120
			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputDeviceDescription description;

			// Token: 0x04000461 RID: 1121
			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int deviceId;

			// Token: 0x04000462 RID: 1122
			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool isNative;

			// Token: 0x04000463 RID: 1123
			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool isRemoved;
		}

		// Token: 0x020000BF RID: 191
		[Token(Token = "0x20000BF")]
		private struct StateChangeMonitorTimeout
		{
			// Token: 0x04000464 RID: 1124
			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputControl control;

			// Token: 0x04000465 RID: 1125
			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public double time;

			// Token: 0x04000466 RID: 1126
			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IInputStateChangeMonitor monitor;

			// Token: 0x04000467 RID: 1127
			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long monitorIndex;

			// Token: 0x04000468 RID: 1128
			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int timerIndex;
		}

		// Token: 0x020000C0 RID: 192
		[Token(Token = "0x20000C0")]
		internal struct StateChangeMonitorListener
		{
			// Token: 0x04000469 RID: 1129
			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputControl control;

			// Token: 0x0400046A RID: 1130
			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public IInputStateChangeMonitor monitor;

			// Token: 0x0400046B RID: 1131
			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long monitorIndex;

			// Token: 0x0400046C RID: 1132
			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint groupIndex;
		}

		// Token: 0x020000C1 RID: 193
		[Token(Token = "0x20000C1")]
		internal struct StateChangeMonitorsForDevice
		{
			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x06000A8B RID: 2699 RVA: 0x000054F0 File Offset: 0x000036F0
			[Token(Token = "0x170002A5")]
			public int count
			{
				[Token(Token = "0x6000A8B")]
				[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000A8C RID: 2700 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x56B0470", Offset = "0x56AF070", VA = "0x1856B0470")]
			public void Add(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex)
			{
			}

			// Token: 0x06000A8D RID: 2701 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x56B0810", Offset = "0x56AF410", VA = "0x1856B0810")]
			public void Remove(IInputStateChangeMonitor monitor, long monitorIndex, bool deferRemoval)
			{
			}

			// Token: 0x06000A8E RID: 2702 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x56B0650", Offset = "0x56AF250", VA = "0x1856B0650")]
			public void Clear()
			{
			}

			// Token: 0x06000A8F RID: 2703 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x56B06E0", Offset = "0x56AF2E0", VA = "0x1856B06E0")]
			public void CompactArrays()
			{
			}

			// Token: 0x06000A90 RID: 2704 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x56B0740", Offset = "0x56AF340", VA = "0x1856B0740")]
			private void RemoveAt(int i)
			{
			}

			// Token: 0x06000A91 RID: 2705 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x56B08C0", Offset = "0x56AF4C0", VA = "0x1856B08C0")]
			public void SortMonitorsByIndex()
			{
			}

			// Token: 0x0400046D RID: 1133
			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MemoryHelpers.BitRegion[] memoryRegions;

			// Token: 0x0400046E RID: 1134
			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InputManager.StateChangeMonitorListener[] listeners;

			// Token: 0x0400046F RID: 1135
			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicBitfield signalled;

			// Token: 0x04000470 RID: 1136
			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool needToUpdateOrderingOfMonitors;

			// Token: 0x04000471 RID: 1137
			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool needToCompactArrays;
		}
	}
}
