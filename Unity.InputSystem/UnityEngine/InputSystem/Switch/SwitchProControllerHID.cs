using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Switch.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Switch
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	[InputControlLayout(stateType = typeof(SwitchProControllerHIDInputState), displayName = "Switch Pro Controller")]
	public class SwitchProControllerHID : Gamepad, IInputStateCallbackReceiver, IEventPreProcessor
	{
		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A4")]
		[InputControl(name = "capture", displayName = "Capture")]
		public ButtonControl captureButton
		{
			[Token(Token = "0x6000DB8")]
			[Address(RVA = "0x55DCE60", Offset = "0x55DBA60", VA = "0x1855DCE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DB9")]
			[Address(RVA = "0x55DCEC0", Offset = "0x55DBAC0", VA = "0x1855DCEC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A5")]
		[InputControl(name = "home", displayName = "Home")]
		public ButtonControl homeButton
		{
			[Token(Token = "0x6000DBA")]
			[Address(RVA = "0x55DCE80", Offset = "0x55DBA80", VA = "0x1855DCE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DBB")]
			[Address(RVA = "0x55DCEF0", Offset = "0x55DBAF0", VA = "0x1855DCEF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x56CA530", Offset = "0x56C9130", VA = "0x1856CA530", Slot = "18")]
		protected override void OnAdded()
		{
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x56CA130", Offset = "0x56C8D30", VA = "0x1856CA130")]
		private void HandshakeRestart()
		{
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x56CA1B0", Offset = "0x56C8DB0", VA = "0x1856CA1B0")]
		private void HandshakeTick()
		{
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x56CA640", Offset = "0x56C9240", VA = "0x1856CA640", Slot = "30")]
		public void OnNextUpdate()
		{
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0x56CA650", Offset = "0x56C9250", VA = "0x1856CA650", Slot = "31")]
		public void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "32")]
		public bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset)
		{
			return default(bool);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0x56CA7E0", Offset = "0x56C93E0", VA = "0x1856CA7E0", Slot = "33")]
		public bool PreProcessEvent(InputEventPtr eventPtr)
		{
			return default(bool);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public SwitchProControllerHID()
		{
		}

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType[] s_HandshakeSequence;

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private int m_HandshakeStepIndex;

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private double m_HandshakeTimer;

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		internal const byte JitterMaskLow = 120;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		internal const byte JitterMaskHigh = 135;

		// Token: 0x0200011F RID: 287
		[Token(Token = "0x200011F")]
		[StructLayout(2)]
		private struct SwitchInputOnlyReport
		{
			// Token: 0x06000DC5 RID: 3525 RVA: 0x00006BA0 File Offset: 0x00004DA0
			[Token(Token = "0x6000DC5")]
			[Address(RVA = "0x56C98D0", Offset = "0x56C84D0", VA = "0x1856C98D0")]
			[MethodImpl(256)]
			public SwitchProControllerHIDInputState ToHIDInputReport()
			{
				return default(SwitchProControllerHIDInputState);
			}

			// Token: 0x04000693 RID: 1683
			[Token(Token = "0x4000693")]
			public const int kSize = 7;

			// Token: 0x04000694 RID: 1684
			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte buttons0;

			// Token: 0x04000695 RID: 1685
			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte buttons1;

			// Token: 0x04000696 RID: 1686
			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte hat;

			// Token: 0x04000697 RID: 1687
			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte leftX;

			// Token: 0x04000698 RID: 1688
			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte leftY;

			// Token: 0x04000699 RID: 1689
			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte rightX;

			// Token: 0x0400069A RID: 1690
			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte rightY;
		}

		// Token: 0x02000120 RID: 288
		[Token(Token = "0x2000120")]
		[StructLayout(2)]
		private struct SwitchSimpleInputReport
		{
			// Token: 0x06000DC6 RID: 3526 RVA: 0x00006BB8 File Offset: 0x00004DB8
			[Token(Token = "0x6000DC6")]
			[Address(RVA = "0x56CAAB0", Offset = "0x56C96B0", VA = "0x1856CAAB0")]
			[MethodImpl(256)]
			public SwitchProControllerHIDInputState ToHIDInputReport()
			{
				return default(SwitchProControllerHIDInputState);
			}

			// Token: 0x0400069B RID: 1691
			[Token(Token = "0x400069B")]
			public const int kSize = 12;

			// Token: 0x0400069C RID: 1692
			[Token(Token = "0x400069C")]
			public const byte ExpectedReportId = 63;

			// Token: 0x0400069D RID: 1693
			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte reportId;

			// Token: 0x0400069E RID: 1694
			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte buttons0;

			// Token: 0x0400069F RID: 1695
			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public byte buttons1;

			// Token: 0x040006A0 RID: 1696
			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte hat;

			// Token: 0x040006A1 RID: 1697
			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public ushort leftX;

			// Token: 0x040006A2 RID: 1698
			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public ushort leftY;

			// Token: 0x040006A3 RID: 1699
			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ushort rightX;

			// Token: 0x040006A4 RID: 1700
			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public ushort rightY;
		}

		// Token: 0x02000121 RID: 289
		[Token(Token = "0x2000121")]
		[StructLayout(2)]
		private struct SwitchFullInputReport
		{
			// Token: 0x06000DC7 RID: 3527 RVA: 0x00006BD0 File Offset: 0x00004DD0
			[Token(Token = "0x6000DC7")]
			[Address(RVA = "0x56C9570", Offset = "0x56C8170", VA = "0x1856C9570")]
			[MethodImpl(256)]
			public SwitchProControllerHIDInputState ToHIDInputReport()
			{
				return default(SwitchProControllerHIDInputState);
			}

			// Token: 0x040006A5 RID: 1701
			[Token(Token = "0x40006A5")]
			public const int kSize = 25;

			// Token: 0x040006A6 RID: 1702
			[Token(Token = "0x40006A6")]
			public const byte ExpectedReportId = 48;

			// Token: 0x040006A7 RID: 1703
			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte reportId;

			// Token: 0x040006A8 RID: 1704
			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public byte buttons0;

			// Token: 0x040006A9 RID: 1705
			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte buttons1;

			// Token: 0x040006AA RID: 1706
			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte buttons2;

			// Token: 0x040006AB RID: 1707
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte left0;

			// Token: 0x040006AC RID: 1708
			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public byte left1;

			// Token: 0x040006AD RID: 1709
			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public byte left2;

			// Token: 0x040006AE RID: 1710
			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public byte right0;

			// Token: 0x040006AF RID: 1711
			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public byte right1;

			// Token: 0x040006B0 RID: 1712
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			public byte right2;
		}

		// Token: 0x02000122 RID: 290
		[Token(Token = "0x2000122")]
		[StructLayout(2)]
		private struct SwitchHIDGenericInputReport
		{
			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00006BE8 File Offset: 0x00004DE8
			[Token(Token = "0x170003A6")]
			public static FourCC Format
			{
				[Token(Token = "0x6000DC8")]
				[Address(RVA = "0x56C9890", Offset = "0x56C8490", VA = "0x1856C9890")]
				get
				{
					return default(FourCC);
				}
			}

			// Token: 0x040006B1 RID: 1713
			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte reportId;
		}

		// Token: 0x02000123 RID: 291
		[Token(Token = "0x2000123")]
		[StructLayout(2)]
		internal struct SwitchMagicOutputReport
		{
			// Token: 0x040006B2 RID: 1714
			[Token(Token = "0x40006B2")]
			public const int kSize = 49;

			// Token: 0x040006B3 RID: 1715
			[Token(Token = "0x40006B3")]
			public const byte ExpectedReplyInputReportId = 129;

			// Token: 0x040006B4 RID: 1716
			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte reportType;

			// Token: 0x040006B5 RID: 1717
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public byte commandId;

			// Token: 0x02000124 RID: 292
			[Token(Token = "0x2000124")]
			internal enum ReportType
			{
				// Token: 0x040006B7 RID: 1719
				[Token(Token = "0x40006B7")]
				Magic = 128
			}

			// Token: 0x02000125 RID: 293
			[Token(Token = "0x2000125")]
			public enum CommandIdType
			{
				// Token: 0x040006B9 RID: 1721
				[Token(Token = "0x40006B9")]
				Status = 1,
				// Token: 0x040006BA RID: 1722
				[Token(Token = "0x40006BA")]
				Handshake,
				// Token: 0x040006BB RID: 1723
				[Token(Token = "0x40006BB")]
				Highspeed,
				// Token: 0x040006BC RID: 1724
				[Token(Token = "0x40006BC")]
				ForceUSB
			}
		}

		// Token: 0x02000126 RID: 294
		[Token(Token = "0x2000126")]
		[StructLayout(2)]
		internal struct SwitchMagicOutputHIDBluetooth : IInputDeviceCommandInfo
		{
			// Token: 0x170003A7 RID: 935
			// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00006C00 File Offset: 0x00004E00
			[Token(Token = "0x170003A7")]
			public static FourCC Type
			{
				[Token(Token = "0x6000DC9")]
				[Address(RVA = "0x56C9CB0", Offset = "0x56C88B0", VA = "0x1856C9CB0")]
				get
				{
					return default(FourCC);
				}
			}

			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00006C18 File Offset: 0x00004E18
			[Token(Token = "0x170003A8")]
			public FourCC typeStatic
			{
				[Token(Token = "0x6000DCA")]
				[Address(RVA = "0x56C9CF0", Offset = "0x56C88F0", VA = "0x1856C9CF0", Slot = "4")]
				get
				{
					return default(FourCC);
				}
			}

			// Token: 0x06000DCB RID: 3531 RVA: 0x00006C30 File Offset: 0x00004E30
			[Token(Token = "0x6000DCB")]
			[Address(RVA = "0x56C9BF0", Offset = "0x56C87F0", VA = "0x1856C9BF0")]
			public static SwitchProControllerHID.SwitchMagicOutputHIDBluetooth Create(SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType type)
			{
				return default(SwitchProControllerHID.SwitchMagicOutputHIDBluetooth);
			}

			// Token: 0x040006BD RID: 1725
			[Token(Token = "0x40006BD")]
			public const int kSize = 57;

			// Token: 0x040006BE RID: 1726
			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputDeviceCommand baseCommand;

			// Token: 0x040006BF RID: 1727
			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public SwitchProControllerHID.SwitchMagicOutputReport report;
		}

		// Token: 0x02000127 RID: 295
		[Token(Token = "0x2000127")]
		[StructLayout(2)]
		internal struct SwitchMagicOutputHIDUSB : IInputDeviceCommandInfo
		{
			// Token: 0x170003A9 RID: 937
			// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00006C48 File Offset: 0x00004E48
			[Token(Token = "0x170003A9")]
			public static FourCC Type
			{
				[Token(Token = "0x6000DCC")]
				[Address(RVA = "0x56C9CB0", Offset = "0x56C88B0", VA = "0x1856C9CB0")]
				get
				{
					return default(FourCC);
				}
			}

			// Token: 0x170003AA RID: 938
			// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00006C60 File Offset: 0x00004E60
			[Token(Token = "0x170003AA")]
			public FourCC typeStatic
			{
				[Token(Token = "0x6000DCD")]
				[Address(RVA = "0x56C9CF0", Offset = "0x56C88F0", VA = "0x1856C9CF0", Slot = "4")]
				get
				{
					return default(FourCC);
				}
			}

			// Token: 0x06000DCE RID: 3534 RVA: 0x00006C78 File Offset: 0x00004E78
			[Token(Token = "0x6000DCE")]
			[Address(RVA = "0x56C9D30", Offset = "0x56C8930", VA = "0x1856C9D30")]
			public static SwitchProControllerHID.SwitchMagicOutputHIDUSB Create(SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType type)
			{
				return default(SwitchProControllerHID.SwitchMagicOutputHIDUSB);
			}

			// Token: 0x040006C0 RID: 1728
			[Token(Token = "0x40006C0")]
			public const int kSize = 72;

			// Token: 0x040006C1 RID: 1729
			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputDeviceCommand baseCommand;

			// Token: 0x040006C2 RID: 1730
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public SwitchProControllerHID.SwitchMagicOutputReport report;
		}
	}
}
