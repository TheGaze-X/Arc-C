using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.XInput
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	[InputControlLayout(displayName = "Xbox Controller")]
	public class XInputController : Gamepad
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033A")]
		[InputControl(name = "buttonSouth", displayName = "A")]
		[InputControl(name = "buttonEast", displayName = "B")]
		[InputControl(name = "buttonWest", displayName = "X")]
		[InputControl(name = "buttonNorth", displayName = "Y")]
		[InputControl(name = "leftShoulder", displayName = "Left Bumper", shortDisplayName = "LB")]
		[InputControl(name = "leftTrigger", shortDisplayName = "LT")]
		[InputControl(name = "rightTrigger", shortDisplayName = "RT")]
		[InputControl(name = "start", displayName = "Menu", alias = "menu")]
		[InputControl(name = "rightShoulder", displayName = "Right Bumper", shortDisplayName = "RB")]
		[InputControl(name = "select", displayName = "View", alias = "view")]
		public ButtonControl menu
		{
			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x55DCE60", Offset = "0x55DBA60", VA = "0x1855DCE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C53")]
			[Address(RVA = "0x55DCEC0", Offset = "0x55DBAC0", VA = "0x1855DCEC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033B")]
		public ButtonControl view
		{
			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x55DCE80", Offset = "0x55DBA80", VA = "0x1855DCE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x55DCEF0", Offset = "0x55DBAF0", VA = "0x1855DCEF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00005F70 File Offset: 0x00004170
		[Token(Token = "0x1700033C")]
		public XInputController.DeviceSubType subType
		{
			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x56B5210", Offset = "0x56B3E10", VA = "0x1856B5210")]
			get
			{
				return XInputController.DeviceSubType.Unknown;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00005F88 File Offset: 0x00004188
		[Token(Token = "0x1700033D")]
		public XInputController.DeviceFlags flags
		{
			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x56B51D0", Offset = "0x56B3DD0", VA = "0x1856B51D0")]
			get
			{
				return (XInputController.DeviceFlags)0;
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x56B50F0", Offset = "0x56B3CF0", VA = "0x1856B50F0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x56B5140", Offset = "0x56B3D40", VA = "0x1856B5140")]
		private void ParseCapabilities()
		{
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public XInputController()
		{
		}

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x200")]
		private bool m_HaveParsedCapabilities;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x204")]
		private XInputController.DeviceSubType m_SubType;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x208")]
		private XInputController.DeviceFlags m_Flags;

		// Token: 0x020000F9 RID: 249
		[Token(Token = "0x20000F9")]
		internal enum DeviceType
		{
			// Token: 0x0400058D RID: 1421
			[Token(Token = "0x400058D")]
			Gamepad
		}

		// Token: 0x020000FA RID: 250
		[Token(Token = "0x20000FA")]
		public enum DeviceSubType
		{
			// Token: 0x0400058F RID: 1423
			[Token(Token = "0x400058F")]
			Unknown,
			// Token: 0x04000590 RID: 1424
			[Token(Token = "0x4000590")]
			Gamepad,
			// Token: 0x04000591 RID: 1425
			[Token(Token = "0x4000591")]
			Wheel,
			// Token: 0x04000592 RID: 1426
			[Token(Token = "0x4000592")]
			ArcadeStick,
			// Token: 0x04000593 RID: 1427
			[Token(Token = "0x4000593")]
			FlightStick,
			// Token: 0x04000594 RID: 1428
			[Token(Token = "0x4000594")]
			DancePad,
			// Token: 0x04000595 RID: 1429
			[Token(Token = "0x4000595")]
			Guitar,
			// Token: 0x04000596 RID: 1430
			[Token(Token = "0x4000596")]
			GuitarAlternate,
			// Token: 0x04000597 RID: 1431
			[Token(Token = "0x4000597")]
			DrumKit,
			// Token: 0x04000598 RID: 1432
			[Token(Token = "0x4000598")]
			GuitarBass = 11,
			// Token: 0x04000599 RID: 1433
			[Token(Token = "0x4000599")]
			ArcadePad = 19
		}

		// Token: 0x020000FB RID: 251
		[Token(Token = "0x20000FB")]
		[Flags]
		public new enum DeviceFlags
		{
			// Token: 0x0400059B RID: 1435
			[Token(Token = "0x400059B")]
			ForceFeedbackSupported = 1,
			// Token: 0x0400059C RID: 1436
			[Token(Token = "0x400059C")]
			Wireless = 2,
			// Token: 0x0400059D RID: 1437
			[Token(Token = "0x400059D")]
			VoiceSupported = 4,
			// Token: 0x0400059E RID: 1438
			[Token(Token = "0x400059E")]
			PluginModulesSupported = 8,
			// Token: 0x0400059F RID: 1439
			[Token(Token = "0x400059F")]
			NoNavigation = 16
		}

		// Token: 0x020000FC RID: 252
		[Token(Token = "0x20000FC")]
		[Serializable]
		internal struct Capabilities
		{
			// Token: 0x040005A0 RID: 1440
			[Token(Token = "0x40005A0")]
			[FieldOffset(Offset = "0x0")]
			public XInputController.DeviceType type;

			// Token: 0x040005A1 RID: 1441
			[Token(Token = "0x40005A1")]
			[FieldOffset(Offset = "0x4")]
			public XInputController.DeviceSubType subType;

			// Token: 0x040005A2 RID: 1442
			[Token(Token = "0x40005A2")]
			[FieldOffset(Offset = "0x8")]
			public XInputController.DeviceFlags flags;
		}
	}
}
