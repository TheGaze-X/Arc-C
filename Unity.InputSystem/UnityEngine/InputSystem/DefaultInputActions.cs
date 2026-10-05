using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public class DefaultInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002BB")]
		public InputActionAsset asset
		{
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x569CBE0", Offset = "0x569B7E0", VA = "0x18569CBE0")]
		public DefaultInputActions()
		{
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x569CAD0", Offset = "0x569B6D0", VA = "0x18569CAD0", Slot = "17")]
		public void Dispose()
		{
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00005700 File Offset: 0x00003900
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BC")]
		public InputBinding? bindingMask
		{
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x569D3F0", Offset = "0x569BFF0", VA = "0x18569D3F0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x569D4E0", Offset = "0x569C0E0", VA = "0x18569D4E0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00005718 File Offset: 0x00003918
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BD")]
		public ReadOnlyArray<InputDevice>? devices
		{
			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x569D4A0", Offset = "0x569C0A0", VA = "0x18569D4A0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x569D540", Offset = "0x569C140", VA = "0x18569D540", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00005730 File Offset: 0x00003930
		[Token(Token = "0x170002BE")]
		public ReadOnlyArray<InputControlScheme> controlSchemes
		{
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x569D460", Offset = "0x569C060", VA = "0x18569D460", Slot = "11")]
			get
			{
				return default(ReadOnlyArray<InputControlScheme>);
			}
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00005748 File Offset: 0x00003948
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x569CA90", Offset = "0x569B690", VA = "0x18569CA90", Slot = "12")]
		public bool Contains(InputAction action)
		{
			return default(bool);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x569CBC0", Offset = "0x569B7C0", VA = "0x18569CBC0", Slot = "15")]
		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x569CBC0", Offset = "0x569B7C0", VA = "0x18569CBC0", Slot = "16")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x569CB20", Offset = "0x569B720", VA = "0x18569CB20", Slot = "13")]
		public void Enable()
		{
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x569CAB0", Offset = "0x569B6B0", VA = "0x18569CAB0", Slot = "14")]
		public void Disable()
		{
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002BF")]
		public IEnumerable<InputBinding> bindings
		{
			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x569D440", Offset = "0x569C040", VA = "0x18569D440", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x569CB40", Offset = "0x569B740", VA = "0x18569CB40", Slot = "5")]
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00005760 File Offset: 0x00003960
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x569CB60", Offset = "0x569B760", VA = "0x18569CB60", Slot = "6")]
		public int FindBinding(InputBinding bindingMask, out InputAction action)
		{
			return 0;
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x170002C0")]
		public DefaultInputActions.PlayerActions Player
		{
			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(DefaultInputActions.PlayerActions);
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x170002C1")]
		public DefaultInputActions.UIActions UI
		{
			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(DefaultInputActions.UIActions);
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x170002C2")]
		public InputControlScheme KeyboardMouseScheme
		{
			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x569D180", Offset = "0x569BD80", VA = "0x18569D180")]
			get
			{
				return default(InputControlScheme);
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x000057C0 File Offset: 0x000039C0
		[Token(Token = "0x170002C3")]
		public InputControlScheme GamepadScheme
		{
			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x569CFE0", Offset = "0x569BBE0", VA = "0x18569CFE0")]
			get
			{
				return default(InputControlScheme);
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x170002C4")]
		public InputControlScheme TouchScheme
		{
			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x569D250", Offset = "0x569BE50", VA = "0x18569D250")]
			get
			{
				return default(InputControlScheme);
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x000057F0 File Offset: 0x000039F0
		[Token(Token = "0x170002C5")]
		public InputControlScheme JoystickScheme
		{
			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0x569D0B0", Offset = "0x569BCB0", VA = "0x18569D0B0")]
			get
			{
				return default(InputControlScheme);
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00005808 File Offset: 0x00003A08
		[Token(Token = "0x170002C6")]
		public InputControlScheme XRScheme
		{
			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0x569D320", Offset = "0x569BF20", VA = "0x18569D320")]
			get
			{
				return default(InputControlScheme);
			}
		}

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x18")]
		private readonly InputActionMap m_Player;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x20")]
		private DefaultInputActions.IPlayerActions m_PlayerActionsCallbackInterface;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x28")]
		private readonly InputAction m_Player_Move;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x30")]
		private readonly InputAction m_Player_Look;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x38")]
		private readonly InputAction m_Player_Fire;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x40")]
		private readonly InputActionMap m_UI;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x48")]
		private DefaultInputActions.IUIActions m_UIActionsCallbackInterface;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x50")]
		private readonly InputAction m_UI_Navigate;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x58")]
		private readonly InputAction m_UI_Submit;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x60")]
		private readonly InputAction m_UI_Cancel;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x68")]
		private readonly InputAction m_UI_Point;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x70")]
		private readonly InputAction m_UI_Click;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x78")]
		private readonly InputAction m_UI_ScrollWheel;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x80")]
		private readonly InputAction m_UI_MiddleClick;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x88")]
		private readonly InputAction m_UI_RightClick;

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x90")]
		private readonly InputAction m_UI_TrackedDevicePosition;

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x98")]
		private readonly InputAction m_UI_TrackedDeviceOrientation;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0xA0")]
		private int m_KeyboardMouseSchemeIndex;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0xA4")]
		private int m_GamepadSchemeIndex;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0xA8")]
		private int m_TouchSchemeIndex;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0xAC")]
		private int m_JoystickSchemeIndex;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0xB0")]
		private int m_XRSchemeIndex;

		// Token: 0x020000CA RID: 202
		[Token(Token = "0x20000CA")]
		public struct PlayerActions
		{
			// Token: 0x06000AE7 RID: 2791 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public PlayerActions(DefaultInputActions wrapper)
			{
			}

			// Token: 0x170002C7 RID: 711
			// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002C7")]
			public InputAction Move
			{
				[Token(Token = "0x6000AE8")]
				[Address(RVA = "0x56A5C30", Offset = "0x56A4830", VA = "0x1856A5C30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002C8")]
			public InputAction Look
			{
				[Token(Token = "0x6000AE9")]
				[Address(RVA = "0x56A5C10", Offset = "0x56A4810", VA = "0x1856A5C10")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002C9")]
			public InputAction Fire
			{
				[Token(Token = "0x6000AEA")]
				[Address(RVA = "0x5024990", Offset = "0x5023590", VA = "0x185024990")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000AEB RID: 2795 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x5024A80", Offset = "0x5023680", VA = "0x185024A80")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06000AEC RID: 2796 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x56A5430", Offset = "0x56A4030", VA = "0x1856A5430")]
			public void Enable()
			{
			}

			// Token: 0x06000AED RID: 2797 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x56A5400", Offset = "0x56A4000", VA = "0x1856A5400")]
			public void Disable()
			{
			}

			// Token: 0x170002CA RID: 714
			// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00005820 File Offset: 0x00003A20
			[Token(Token = "0x170002CA")]
			public bool enabled
			{
				[Token(Token = "0x6000AEE")]
				[Address(RVA = "0x56A5C50", Offset = "0x56A4850", VA = "0x1856A5C50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000AEF RID: 2799 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x3BEA040", Offset = "0x3BE8C40", VA = "0x183BEA040")]
			public static implicit operator InputActionMap(DefaultInputActions.PlayerActions set)
			{
				return null;
			}

			// Token: 0x06000AF0 RID: 2800 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x56A5460", Offset = "0x56A4060", VA = "0x1856A5460")]
			public void SetCallbacks(DefaultInputActions.IPlayerActions instance)
			{
			}

			// Token: 0x040004BA RID: 1210
			[Token(Token = "0x40004BA")]
			[FieldOffset(Offset = "0x0")]
			private DefaultInputActions m_Wrapper;
		}

		// Token: 0x020000CB RID: 203
		[Token(Token = "0x20000CB")]
		public struct UIActions
		{
			// Token: 0x06000AF1 RID: 2801 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public UIActions(DefaultInputActions wrapper)
			{
			}

			// Token: 0x170002CB RID: 715
			// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002CB")]
			public InputAction Navigate
			{
				[Token(Token = "0x6000AF2")]
				[Address(RVA = "0x56B4F50", Offset = "0x56B3B50", VA = "0x1856B4F50")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002CC RID: 716
			// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002CC")]
			public InputAction Submit
			{
				[Token(Token = "0x6000AF3")]
				[Address(RVA = "0x56B4FD0", Offset = "0x56B3BD0", VA = "0x1856B4FD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002CD RID: 717
			// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002CD")]
			public InputAction Cancel
			{
				[Token(Token = "0x6000AF4")]
				[Address(RVA = "0x56B4EF0", Offset = "0x56B3AF0", VA = "0x1856B4EF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002CE RID: 718
			// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002CE")]
			public InputAction Point
			{
				[Token(Token = "0x6000AF5")]
				[Address(RVA = "0x56B4F70", Offset = "0x56B3B70", VA = "0x1856B4F70")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002CF RID: 719
			// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002CF")]
			public InputAction Click
			{
				[Token(Token = "0x6000AF6")]
				[Address(RVA = "0x56B4F10", Offset = "0x56B3B10", VA = "0x1856B4F10")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D0 RID: 720
			// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002D0")]
			public InputAction ScrollWheel
			{
				[Token(Token = "0x6000AF7")]
				[Address(RVA = "0x56B4FB0", Offset = "0x56B3BB0", VA = "0x1856B4FB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D1 RID: 721
			// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002D1")]
			public InputAction MiddleClick
			{
				[Token(Token = "0x6000AF8")]
				[Address(RVA = "0x56B4F30", Offset = "0x56B3B30", VA = "0x1856B4F30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D2 RID: 722
			// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002D2")]
			public InputAction RightClick
			{
				[Token(Token = "0x6000AF9")]
				[Address(RVA = "0x56B4F90", Offset = "0x56B3B90", VA = "0x1856B4F90")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D3 RID: 723
			// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002D3")]
			public InputAction TrackedDevicePosition
			{
				[Token(Token = "0x6000AFA")]
				[Address(RVA = "0x56B5010", Offset = "0x56B3C10", VA = "0x1856B5010")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D4 RID: 724
			// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002D4")]
			public InputAction TrackedDeviceOrientation
			{
				[Token(Token = "0x6000AFB")]
				[Address(RVA = "0x56B4FF0", Offset = "0x56B3BF0", VA = "0x1856B4FF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000AFC RID: 2812 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x5024AB0", Offset = "0x50236B0", VA = "0x185024AB0")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06000AFD RID: 2813 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x56B3610", Offset = "0x56B2210", VA = "0x1856B3610")]
			public void Enable()
			{
			}

			// Token: 0x06000AFE RID: 2814 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x56B35E0", Offset = "0x56B21E0", VA = "0x1856B35E0")]
			public void Disable()
			{
			}

			// Token: 0x170002D5 RID: 725
			// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00005838 File Offset: 0x00003A38
			[Token(Token = "0x170002D5")]
			public bool enabled
			{
				[Token(Token = "0x6000AFF")]
				[Address(RVA = "0x56B5030", Offset = "0x56B3C30", VA = "0x1856B5030")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000B00 RID: 2816 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x56B5060", Offset = "0x56B3C60", VA = "0x1856B5060")]
			public static implicit operator InputActionMap(DefaultInputActions.UIActions set)
			{
				return null;
			}

			// Token: 0x06000B01 RID: 2817 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x56B3640", Offset = "0x56B2240", VA = "0x1856B3640")]
			public void SetCallbacks(DefaultInputActions.IUIActions instance)
			{
			}

			// Token: 0x040004BB RID: 1211
			[Token(Token = "0x40004BB")]
			[FieldOffset(Offset = "0x0")]
			private DefaultInputActions m_Wrapper;
		}

		// Token: 0x020000CC RID: 204
		[Token(Token = "0x20000CC")]
		public interface IPlayerActions
		{
			// Token: 0x06000B02 RID: 2818
			[Token(Token = "0x6000B02")]
			void OnMove(InputAction.CallbackContext context);

			// Token: 0x06000B03 RID: 2819
			[Token(Token = "0x6000B03")]
			void OnLook(InputAction.CallbackContext context);

			// Token: 0x06000B04 RID: 2820
			[Token(Token = "0x6000B04")]
			void OnFire(InputAction.CallbackContext context);
		}

		// Token: 0x020000CD RID: 205
		[Token(Token = "0x20000CD")]
		public interface IUIActions
		{
			// Token: 0x06000B05 RID: 2821
			[Token(Token = "0x6000B05")]
			void OnNavigate(InputAction.CallbackContext context);

			// Token: 0x06000B06 RID: 2822
			[Token(Token = "0x6000B06")]
			void OnSubmit(InputAction.CallbackContext context);

			// Token: 0x06000B07 RID: 2823
			[Token(Token = "0x6000B07")]
			void OnCancel(InputAction.CallbackContext context);

			// Token: 0x06000B08 RID: 2824
			[Token(Token = "0x6000B08")]
			void OnPoint(InputAction.CallbackContext context);

			// Token: 0x06000B09 RID: 2825
			[Token(Token = "0x6000B09")]
			void OnClick(InputAction.CallbackContext context);

			// Token: 0x06000B0A RID: 2826
			[Token(Token = "0x6000B0A")]
			void OnScrollWheel(InputAction.CallbackContext context);

			// Token: 0x06000B0B RID: 2827
			[Token(Token = "0x6000B0B")]
			void OnMiddleClick(InputAction.CallbackContext context);

			// Token: 0x06000B0C RID: 2828
			[Token(Token = "0x6000B0C")]
			void OnRightClick(InputAction.CallbackContext context);

			// Token: 0x06000B0D RID: 2829
			[Token(Token = "0x6000B0D")]
			void OnTrackedDevicePosition(InputAction.CallbackContext context);

			// Token: 0x06000B0E RID: 2830
			[Token(Token = "0x6000B0E")]
			void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
		}
	}
}
