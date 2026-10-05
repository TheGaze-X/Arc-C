using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Haptics;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.DualShock
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	[InputControlLayout(displayName = "PlayStation Controller")]
	public class DualShockGamepad : Gamepad, IDualShockHaptics, IDualMotorRumble, IHaptics
	{
		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003EF")]
		[InputControl(name = "buttonWest", displayName = "Square", shortDisplayName = "Square")]
		[InputControl(name = "buttonNorth", displayName = "Triangle", shortDisplayName = "Triangle")]
		[InputControl(name = "buttonEast", displayName = "Circle", shortDisplayName = "Circle")]
		[InputControl(name = "buttonSouth", displayName = "Cross", shortDisplayName = "Cross")]
		[InputControl]
		public ButtonControl touchpadButton
		{
			[Token(Token = "0x6000EAE")]
			[Address(RVA = "0x55DCE60", Offset = "0x55DBA60", VA = "0x1855DCE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EAF")]
			[Address(RVA = "0x55DCEC0", Offset = "0x55DBAC0", VA = "0x1855DCEC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EB1 RID: 3761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F0")]
		[InputControl(name = "start", displayName = "Options")]
		public ButtonControl optionsButton
		{
			[Token(Token = "0x6000EB0")]
			[Address(RVA = "0x55DCE80", Offset = "0x55DBA80", VA = "0x1855DCE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EB1")]
			[Address(RVA = "0x55DCEF0", Offset = "0x55DBAF0", VA = "0x1855DCEF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EB3 RID: 3763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F1")]
		[InputControl(name = "select", displayName = "Share")]
		public ButtonControl shareButton
		{
			[Token(Token = "0x6000EB2")]
			[Address(RVA = "0x50B83F0", Offset = "0x50B6FF0", VA = "0x1850B83F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EB3")]
			[Address(RVA = "0x55DCED0", Offset = "0x55DBAD0", VA = "0x1855DCED0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EB5 RID: 3765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F2")]
		[InputControl(name = "leftShoulder", displayName = "L1", shortDisplayName = "L1")]
		public ButtonControl L1
		{
			[Token(Token = "0x6000EB4")]
			[Address(RVA = "0x55DCE70", Offset = "0x55DBA70", VA = "0x1855DCE70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EB5")]
			[Address(RVA = "0x55DCEE0", Offset = "0x55DBAE0", VA = "0x1855DCEE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EB7 RID: 3767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F3")]
		[InputControl(name = "rightShoulder", displayName = "R1", shortDisplayName = "R1")]
		public ButtonControl R1
		{
			[Token(Token = "0x6000EB6")]
			[Address(RVA = "0x55DCE40", Offset = "0x55DBA40", VA = "0x1855DCE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EB7")]
			[Address(RVA = "0x55DCEA0", Offset = "0x55DBAA0", VA = "0x1855DCEA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F4")]
		[InputControl(name = "leftTrigger", displayName = "L2", shortDisplayName = "L2")]
		public ButtonControl L2
		{
			[Token(Token = "0x6000EB8")]
			[Address(RVA = "0x55DCE20", Offset = "0x55DBA20", VA = "0x1855DCE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EB9")]
			[Address(RVA = "0x4FA2340", Offset = "0x4FA0F40", VA = "0x184FA2340")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F5")]
		[InputControl(name = "rightTrigger", displayName = "R2", shortDisplayName = "R2")]
		public ButtonControl R2
		{
			[Token(Token = "0x6000EBA")]
			[Address(RVA = "0x55DCE30", Offset = "0x55DBA30", VA = "0x1855DCE30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EBB")]
			[Address(RVA = "0x55DCE90", Offset = "0x55DBA90", VA = "0x1855DCE90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F6")]
		[InputControl(name = "leftStickPress", displayName = "L3", shortDisplayName = "L3")]
		public ButtonControl L3
		{
			[Token(Token = "0x6000EBC")]
			[Address(RVA = "0x55DCAF0", Offset = "0x55DB6F0", VA = "0x1855DCAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EBD")]
			[Address(RVA = "0x55DCB10", Offset = "0x55DB710", VA = "0x1855DCB10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EBF RID: 3775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F7")]
		[InputControl(name = "rightStickPress", displayName = "R3", shortDisplayName = "R3")]
		public ButtonControl R3
		{
			[Token(Token = "0x6000EBE")]
			[Address(RVA = "0x55DCB00", Offset = "0x55DB700", VA = "0x1855DCB00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EBF")]
			[Address(RVA = "0x55DCB20", Offset = "0x55DB720", VA = "0x1855DCB20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F8")]
		public new static DualShockGamepad current
		{
			[Token(Token = "0x6000EC0")]
			[Address(RVA = "0x56D25D0", Offset = "0x56D11D0", VA = "0x1856D25D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EC1")]
			[Address(RVA = "0x56D2610", Offset = "0x56D1210", VA = "0x1856D2610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x56D24E0", Offset = "0x56D10E0", VA = "0x1856D24E0", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x56D2540", Offset = "0x56D1140", VA = "0x1856D2540", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x56D23C0", Offset = "0x56D0FC0", VA = "0x1856D23C0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "31")]
		public virtual void SetLightBarColor(Color color)
		{
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public DualShockGamepad()
		{
		}
	}
}
