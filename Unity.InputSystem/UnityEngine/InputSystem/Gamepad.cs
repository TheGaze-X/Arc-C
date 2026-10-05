using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Haptics;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	[InputControlLayout(stateType = typeof(GamepadState), isGenericTypeOfDevice = true)]
	public class Gamepad : InputDevice, IDualMotorRumble, IHaptics
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A7")]
		public ButtonControl buttonWest
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A8")]
		public ButtonControl buttonNorth
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x1692AD0", Offset = "0x16916D0", VA = "0x181692AD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A9")]
		public ButtonControl buttonSouth
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x55DCFF0", Offset = "0x55DBBF0", VA = "0x1855DCFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x4E84950", Offset = "0x4E83550", VA = "0x184E84950")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AA")]
		public ButtonControl buttonEast
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x560D480", Offset = "0x560C080", VA = "0x18560D480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x560D490", Offset = "0x560C090", VA = "0x18560D490")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AB")]
		public ButtonControl leftStickButton
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x55CD2F0", Offset = "0x55CBEF0", VA = "0x1855CD2F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AC")]
		public ButtonControl rightStickButton
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x55CD260", Offset = "0x55CBE60", VA = "0x1855CD260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x55CD300", Offset = "0x55CBF00", VA = "0x1855CD300")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AD")]
		public ButtonControl startButton
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x55CD2B0", Offset = "0x55CBEB0", VA = "0x1855CD2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AE")]
		public ButtonControl selectButton
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x1692AE0", Offset = "0x16916E0", VA = "0x181692AE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AF")]
		public DpadControl dpad
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x4FA1B60", Offset = "0x4FA0760", VA = "0x184FA1B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x55CD2C0", Offset = "0x55CBEC0", VA = "0x1855CD2C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B0")]
		public ButtonControl leftShoulder
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x55CD200", Offset = "0x55CBE00", VA = "0x1855CD200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x55CD270", Offset = "0x55CBE70", VA = "0x1855CD270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B1")]
		public ButtonControl rightShoulder
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x55CD2A0", Offset = "0x55CBEA0", VA = "0x1855CD2A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B2")]
		public StickControl leftStick
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x55CD240", Offset = "0x55CBE40", VA = "0x1855CD240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x55CD2D0", Offset = "0x55CBED0", VA = "0x1855CD2D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B3")]
		public StickControl rightStick
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x55CD2E0", Offset = "0x55CBEE0", VA = "0x1855CD2E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B4")]
		public ButtonControl leftTrigger
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x55CD220", Offset = "0x55CBE20", VA = "0x1855CD220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x55CD290", Offset = "0x55CBE90", VA = "0x1855CD290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B5")]
		public ButtonControl rightTrigger
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x55CD210", Offset = "0x55CBE10", VA = "0x1855CD210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x55CD280", Offset = "0x55CBE80", VA = "0x1855CD280")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001B6")]
		public ButtonControl aButton
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x55DCFF0", Offset = "0x55DBBF0", VA = "0x1855DCFF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001B7")]
		public ButtonControl bButton
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x560D480", Offset = "0x560C080", VA = "0x18560D480")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001B8")]
		public ButtonControl xButton
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001B9")]
		public ButtonControl yButton
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001BA")]
		public ButtonControl triangleButton
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001BB")]
		public ButtonControl squareButton
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001BC")]
		public ButtonControl circleButton
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x560D480", Offset = "0x560C080", VA = "0x18560D480")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001BD")]
		public ButtonControl crossButton
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x55DCFF0", Offset = "0x55DBBF0", VA = "0x1855DCFF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BE RID: 446
		[Token(Token = "0x170001BE")]
		public ButtonControl this[GamepadButton button]
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x561B9D0", Offset = "0x561A5D0", VA = "0x18561B9D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BF")]
		public static Gamepad current
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x561BC60", Offset = "0x561A860", VA = "0x18561BC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x561BCA0", Offset = "0x561A8A0", VA = "0x18561BCA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x170001C0")]
		public new static ReadOnlyArray<Gamepad> all
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x561BBF0", Offset = "0x561A7F0", VA = "0x18561BBF0")]
			get
			{
				return default(ReadOnlyArray<Gamepad>);
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x561B390", Offset = "0x5619F90", VA = "0x18561B390", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x561B6F0", Offset = "0x561A2F0", VA = "0x18561B6F0", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x561B750", Offset = "0x561A350", VA = "0x18561B750", Slot = "18")]
		protected override void OnAdded()
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x561B7C0", Offset = "0x561A3C0", VA = "0x18561B7C0", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x561B8D0", Offset = "0x561A4D0", VA = "0x18561B8D0", Slot = "26")]
		public virtual void PauseHaptics()
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x561B910", Offset = "0x561A510", VA = "0x18561B910", Slot = "27")]
		public virtual void ResumeHaptics()
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x561B8F0", Offset = "0x561A4F0", VA = "0x18561B8F0", Slot = "28")]
		public virtual void ResetHaptics()
		{
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x561B930", Offset = "0x561A530", VA = "0x18561B930", Slot = "29")]
		public virtual void SetMotorSpeeds(float lowFrequency, float highFrequency)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x561B960", Offset = "0x561A560", VA = "0x18561B960")]
		public Gamepad()
		{
		}

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x1E8")]
		private DualMotorRumble m_Rumble;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x8")]
		private static int s_GamepadCount;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x10")]
		private static Gamepad[] s_Gamepads;
	}
}
