using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public class InputDevice : InputControl
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x170001C1")]
		public InputDeviceDescription description
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x5627AC0", Offset = "0x56266C0", VA = "0x185627AC0")]
			get
			{
				return default(InputDeviceDescription);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x170001C2")]
		public bool enabled
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x5627B30", Offset = "0x5626730", VA = "0x185627B30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x170001C3")]
		public bool canRunInBackground
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x5627A10", Offset = "0x5626610", VA = "0x185627A10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x170001C4")]
		public bool added
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x56278F0", Offset = "0x56264F0", VA = "0x1856278F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x170001C5")]
		public bool remote
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x5627CA0", Offset = "0x56268A0", VA = "0x185627CA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x170001C6")]
		public bool native
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x5627C90", Offset = "0x5626890", VA = "0x185627C90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x170001C7")]
		public bool updateBeforeRender
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x5627CB0", Offset = "0x56268B0", VA = "0x185627CB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x170001C8")]
		public int deviceId
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x560EBB0", Offset = "0x560D7B0", VA = "0x18560EBB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x170001C9")]
		public double lastUpdateTime
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x5627C40", Offset = "0x5626840", VA = "0x185627C40")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x170001CA")]
		public bool wasUpdatedThisFrame
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x5627D70", Offset = "0x5626970", VA = "0x185627D70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x170001CB")]
		public ReadOnlyArray<InputControl> allControls
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x5627900", Offset = "0x5626500", VA = "0x185627900")]
			get
			{
				return default(ReadOnlyArray<InputControl>);
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001CC")]
		public override Type valueType
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x5627D10", Offset = "0x5626910", VA = "0x185627D10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x170001CD")]
		public override int valueSizeInBytes
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x5627CC0", Offset = "0x56268C0", VA = "0x185627CC0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x170001CE")]
		[Obsolete("Use 'InputSystem.devices' instead. (UnityUpgradable) -> InputSystem.devices", false)]
		public static ReadOnlyArray<InputDevice> all
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x5627960", Offset = "0x5626560", VA = "0x185627960")]
			get
			{
				return default(ReadOnlyArray<InputDevice>);
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x561B960", Offset = "0x561A560", VA = "0x18561B960")]
		public InputDevice()
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x5626B10", Offset = "0x5625710", VA = "0x185626B10", Slot = "7")]
		public unsafe override object ReadValueFromBufferAsObject(void* buffer, int bufferSize)
		{
			return null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x5626B60", Offset = "0x5625760", VA = "0x185626B60", Slot = "8")]
		public unsafe override object ReadValueFromStateAsObject(void* statePtr)
		{
			return null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x5626C60", Offset = "0x5625860", VA = "0x185626C60", Slot = "9")]
		public unsafe override void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x5625E90", Offset = "0x5624A90", VA = "0x185625E90", Slot = "12")]
		public unsafe override bool CompareValue(void* firstStatePtr, void* secondStatePtr)
		{
			return default(bool);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x5626990", Offset = "0x5625590", VA = "0x185626990")]
		internal void NotifyConfigurationChanged()
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public virtual void MakeCurrent()
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "18")]
		protected virtual void OnAdded()
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		protected virtual void OnRemoved()
		{
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		protected virtual void OnConfigurationChanged()
		{
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x6000666")]
		public long ExecuteCommand<TCommand>(ref TCommand command) where TCommand : struct, IInputDeviceCommandInfo
		{
			return 0L;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x5626730", Offset = "0x5625330", VA = "0x185626730", Slot = "21")]
		protected unsafe virtual long ExecuteCommand(InputDeviceCommand* commandPtr)
		{
			return 0L;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x5626A70", Offset = "0x5625670", VA = "0x185626A70")]
		internal bool QueryEnabledStateFromRuntime()
		{
			return default(bool);
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00004EA8 File Offset: 0x000030A8
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CF")]
		internal bool disabledInFrontend
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x5627B00", Offset = "0x5626700", VA = "0x185627B00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x5627DC0", Offset = "0x56269C0", VA = "0x185627DC0")]
			set
			{
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00004EC0 File Offset: 0x000030C0
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D0")]
		internal bool disabledInRuntime
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x5627B10", Offset = "0x5626710", VA = "0x185627B10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x5627DE0", Offset = "0x56269E0", VA = "0x185627DE0")]
			set
			{
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00004ED8 File Offset: 0x000030D8
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D1")]
		internal bool disabledWhileInBackground
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x5627B20", Offset = "0x5626720", VA = "0x185627B20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x5627E10", Offset = "0x5626A10", VA = "0x185627E10")]
			set
			{
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x5626720", Offset = "0x5625320", VA = "0x185626720")]
		internal static uint EncodeStateOffsetToControlMapEntry(uint controlIndex, uint stateOffsetInBits, uint stateSizeInBits)
		{
			return 0U;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x5625FD0", Offset = "0x5624BD0", VA = "0x185625FD0")]
		internal static void DecodeStateOffsetToControlMapEntry(uint entry, out uint controlIndex, out uint stateOffset, out uint stateSize)
		{
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00004F08 File Offset: 0x00003108
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D2")]
		internal bool hasControlsWithDefaultState
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x5627BF0", Offset = "0x56267F0", VA = "0x185627BF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x5627E40", Offset = "0x5626A40", VA = "0x185627E40")]
			set
			{
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00004F20 File Offset: 0x00003120
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D3")]
		internal bool hasDontResetControls
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x5627C00", Offset = "0x5626800", VA = "0x185627C00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x5627E60", Offset = "0x5626A60", VA = "0x185627E60")]
			set
			{
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00004F38 File Offset: 0x00003138
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D4")]
		internal bool hasStateCallbacks
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x5627C30", Offset = "0x5626830", VA = "0x185627C30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x5627EF0", Offset = "0x5626AF0", VA = "0x185627EF0")]
			set
			{
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00004F50 File Offset: 0x00003150
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D5")]
		internal bool hasEventMerger
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x5627C10", Offset = "0x5626810", VA = "0x185627C10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x5627E90", Offset = "0x5626A90", VA = "0x185627E90")]
			set
			{
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00004F68 File Offset: 0x00003168
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D6")]
		internal bool hasEventPreProcessor
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x5627C20", Offset = "0x5626820", VA = "0x185627C20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x5627EC0", Offset = "0x5626AC0", VA = "0x185627EC0")]
			set
			{
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x5625D70", Offset = "0x5624970", VA = "0x185625D70")]
		internal void AddDeviceUsage(InternedString usage)
		{
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x5626E80", Offset = "0x5625A80", VA = "0x185626E80")]
		internal void RemoveDeviceUsage(InternedString usage)
		{
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x5625E20", Offset = "0x5624A20", VA = "0x185625E20")]
		internal void ClearDeviceUsages()
		{
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x5626FC0", Offset = "0x5625BC0", VA = "0x185626FC0")]
		internal bool RequestSync()
		{
			return default(bool);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00004F98 File Offset: 0x00003198
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x5626F50", Offset = "0x5625B50", VA = "0x185626F50")]
		internal bool RequestReset()
		{
			return default(bool);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x56268B0", Offset = "0x56254B0", VA = "0x1856268B0")]
		internal bool ExecuteEnableCommand()
		{
			return default(bool);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x5626850", Offset = "0x5625450", VA = "0x185626850")]
		internal bool ExecuteDisableCommand()
		{
			return default(bool);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x4B244E0", Offset = "0x4B230E0", VA = "0x184B244E0")]
		internal void NotifyAdded()
		{
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x5626A30", Offset = "0x5625630", VA = "0x185626A30")]
		internal void NotifyRemoved()
		{
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000684")]
		internal static TDevice Build<TDevice>([Optional] string layoutName, [Optional] string layoutVariants, [Optional] InputDeviceDescription deviceDescription, bool noPrecompiledLayouts = false) where TDevice : InputDevice
		{
			return null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x5627420", Offset = "0x5626020", VA = "0x185627420")]
		internal unsafe void WriteChangedControlStates(byte* deviceStateBuffer, void* statePtr, uint stateSizeInBytes, uint stateOffsetInDevice)
		{
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x5627580", Offset = "0x5626180", VA = "0x185627580")]
		private unsafe void WritePartialChangedControlStatesInternal(void* statePtr, uint stateSizeInBits, uint stateOffsetInDeviceInBits, byte* deviceStatePtr, InputDevice.ControlBitRangeNode parentNode, uint startOffset)
		{
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x5625FF0", Offset = "0x5624BF0", VA = "0x185625FF0")]
		private void DumpControlBitRangeNode(int nodeIndex, InputDevice.ControlBitRangeNode node, uint startOffset, uint sizeInBits, List<string> output)
		{
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x5626470", Offset = "0x5625070", VA = "0x185626470")]
		private void DumpControlTree(InputDevice.ControlBitRangeNode parentNode, uint startOffset, List<string> output)
		{
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x5626640", Offset = "0x5625240", VA = "0x185626640")]
		internal string DumpControlTree()
		{
			return null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x5627030", Offset = "0x5625C30", VA = "0x185627030")]
		private unsafe void WriteChangedControlStatesInternal(void* statePtr, uint stateSizeInBits, byte* deviceStatePtr, InputDevice.ControlBitRangeNode parentNode, uint startOffset)
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x5626920", Offset = "0x5625520", VA = "0x185626920")]
		private unsafe static bool HasDataChangedInRange(byte* deviceStatePtr, void* statePtr, uint startOffset, uint sizeInBits)
		{
			return default(bool);
		}

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		public const int InvalidDeviceId = 0;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		internal const int kLocalParticipantId = 0;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		internal const int kInvalidDeviceIndex = -1;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal InputDevice.DeviceFlags m_DeviceFlags;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		internal int m_DeviceId;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal int m_ParticipantId;

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		internal int m_DeviceIndex;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		internal InputDeviceDescription m_Description;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal double m_LastUpdateTimeInternal;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal uint m_CurrentUpdateStepCount;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal InternedString[] m_AliasesForEachControl;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal InternedString[] m_UsagesForEachControl;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		internal InputControl[] m_UsageToControl;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		internal InputControl[] m_ChildrenForEachControl;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		internal uint[] m_StateOffsetToControlMap;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		internal InputDevice.ControlBitRangeNode[] m_ControlTreeNodes;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		internal ushort[] m_ControlTreeIndices;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		internal const int kControlIndexBits = 10;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		internal const int kStateOffsetBits = 13;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		internal const int kStateSizeBits = 9;

		// Token: 0x02000086 RID: 134
		[Token(Token = "0x2000086")]
		[Flags]
		[Serializable]
		internal enum DeviceFlags
		{
			// Token: 0x04000300 RID: 768
			[Token(Token = "0x4000300")]
			UpdateBeforeRender = 1,
			// Token: 0x04000301 RID: 769
			[Token(Token = "0x4000301")]
			HasStateCallbacks = 2,
			// Token: 0x04000302 RID: 770
			[Token(Token = "0x4000302")]
			HasControlsWithDefaultState = 4,
			// Token: 0x04000303 RID: 771
			[Token(Token = "0x4000303")]
			HasDontResetControls = 1024,
			// Token: 0x04000304 RID: 772
			[Token(Token = "0x4000304")]
			HasEventMerger = 8192,
			// Token: 0x04000305 RID: 773
			[Token(Token = "0x4000305")]
			HasEventPreProcessor = 16384,
			// Token: 0x04000306 RID: 774
			[Token(Token = "0x4000306")]
			Remote = 8,
			// Token: 0x04000307 RID: 775
			[Token(Token = "0x4000307")]
			Native = 16,
			// Token: 0x04000308 RID: 776
			[Token(Token = "0x4000308")]
			DisabledInFrontend = 32,
			// Token: 0x04000309 RID: 777
			[Token(Token = "0x4000309")]
			DisabledInRuntime = 128,
			// Token: 0x0400030A RID: 778
			[Token(Token = "0x400030A")]
			DisabledWhileInBackground = 256,
			// Token: 0x0400030B RID: 779
			[Token(Token = "0x400030B")]
			DisabledStateHasBeenQueriedFromRuntime = 64,
			// Token: 0x0400030C RID: 780
			[Token(Token = "0x400030C")]
			CanRunInBackground = 2048,
			// Token: 0x0400030D RID: 781
			[Token(Token = "0x400030D")]
			CanRunInBackgroundHasBeenQueried = 4096
		}

		// Token: 0x02000087 RID: 135
		[Token(Token = "0x2000087")]
		internal struct ControlBitRangeNode
		{
			// Token: 0x0600068C RID: 1676 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x561A520", Offset = "0x5619120", VA = "0x18561A520")]
			public ControlBitRangeNode(ushort endOffset)
			{
			}

			// Token: 0x0400030E RID: 782
			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ushort endBitOffset;

			// Token: 0x0400030F RID: 783
			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public short leftChildIndex;

			// Token: 0x04000310 RID: 784
			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public ushort controlStartIndex;

			// Token: 0x04000311 RID: 785
			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte controlCount;
		}
	}
}
