using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	[InputControlLayout(stateType = typeof(JoystickState), isGenericTypeOfDevice = true)]
	public class Joystick : InputDevice
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D7")]
		public ButtonControl trigger
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x4E84340", Offset = "0x4E82F40", VA = "0x184E84340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x55DD000", Offset = "0x55DBC00", VA = "0x1855DD000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D8")]
		public StickControl stick
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1692AD0", Offset = "0x16916D0", VA = "0x181692AD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D9")]
		public AxisControl twist
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x55DCFF0", Offset = "0x55DBBF0", VA = "0x1855DCFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x4E84950", Offset = "0x4E83550", VA = "0x184E84950")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DA")]
		public Vector2Control hatswitch
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x560D480", Offset = "0x560C080", VA = "0x18560D480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x560D490", Offset = "0x560C090", VA = "0x18560D490")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DB")]
		public static Joystick current
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x562E550", Offset = "0x562D150", VA = "0x18562E550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x562E590", Offset = "0x562D190", VA = "0x18562E590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00004FF8 File Offset: 0x000031F8
		[Token(Token = "0x170001DC")]
		public new static ReadOnlyArray<Joystick> all
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x562E4E0", Offset = "0x562D0E0", VA = "0x18562E4E0")]
			get
			{
				return default(ReadOnlyArray<Joystick>);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x562E1E0", Offset = "0x562CDE0", VA = "0x18562E1E0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x562E300", Offset = "0x562CF00", VA = "0x18562E300", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x562E360", Offset = "0x562CF60", VA = "0x18562E360", Slot = "18")]
		protected override void OnAdded()
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x562E3D0", Offset = "0x562CFD0", VA = "0x18562E3D0", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x561B960", Offset = "0x561A560", VA = "0x18561B960")]
		public Joystick()
		{
		}

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x8")]
		private static int s_JoystickCount;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x10")]
		private static Joystick[] s_Joysticks;
	}
}
