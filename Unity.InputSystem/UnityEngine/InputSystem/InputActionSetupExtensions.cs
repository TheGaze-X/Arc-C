using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public static class InputActionSetupExtensions
	{
		// Token: 0x06000290 RID: 656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x55EA130", Offset = "0x55E8D30", VA = "0x1855EA130")]
		public static InputActionMap AddActionMap(this InputActionAsset asset, string name)
		{
			return null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x55E9DF0", Offset = "0x55E89F0", VA = "0x1855E9DF0")]
		public static void AddActionMap(this InputActionAsset asset, InputActionMap map)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x55ECAC0", Offset = "0x55EB6C0", VA = "0x1855ECAC0")]
		public static void RemoveActionMap(this InputActionAsset asset, InputActionMap map)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x55ECC70", Offset = "0x55EB870", VA = "0x1855ECC70")]
		public static void RemoveActionMap(this InputActionAsset asset, string nameOrId)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x55EA340", Offset = "0x55E8F40", VA = "0x1855EA340")]
		public static InputAction AddAction(this InputActionMap map, string name, InputActionType type = InputActionType.Value, [Optional] string binding, [Optional] string interactions, [Optional] string processors, [Optional] string groups, [Optional] string expectedControlLayout)
		{
			return null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x55ECED0", Offset = "0x55EBAD0", VA = "0x1855ECED0")]
		public static void RemoveAction(this InputAction action)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x55ED2D0", Offset = "0x55EBED0", VA = "0x1855ED2D0")]
		public static void RemoveAction(this InputActionAsset asset, string nameOrId)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x55EA980", Offset = "0x55E9580", VA = "0x1855EA980")]
		public static InputActionSetupExtensions.BindingSyntax AddBinding(this InputAction action, string path, [Optional] string interactions, [Optional] string processors, [Optional] string groups)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x55EAF20", Offset = "0x55E9B20", VA = "0x1855EAF20")]
		public static InputActionSetupExtensions.BindingSyntax AddBinding(this InputAction action, InputControl control)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x55EAC60", Offset = "0x55E9860", VA = "0x1855EAC60")]
		public static InputActionSetupExtensions.BindingSyntax AddBinding(this InputAction action, [Optional] InputBinding binding)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x55EAFE0", Offset = "0x55E9BE0", VA = "0x1855EAFE0")]
		public static InputActionSetupExtensions.BindingSyntax AddBinding(this InputActionMap actionMap, string path, [Optional] string interactions, [Optional] string groups, [Optional] string action, [Optional] string processors)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x55EB260", Offset = "0x55E9E60", VA = "0x1855EB260")]
		public static InputActionSetupExtensions.BindingSyntax AddBinding(this InputActionMap actionMap, string path, InputAction action, [Optional] string interactions, [Optional] string groups)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x55EAB70", Offset = "0x55E9770", VA = "0x1855EAB70")]
		public static InputActionSetupExtensions.BindingSyntax AddBinding(this InputActionMap actionMap, string path, Guid action, [Optional] string interactions, [Optional] string groups)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x55EADA0", Offset = "0x55E99A0", VA = "0x1855EADA0")]
		public static InputActionSetupExtensions.BindingSyntax AddBinding(this InputActionMap actionMap, InputBinding binding)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x55EB430", Offset = "0x55EA030", VA = "0x1855EB430")]
		public static InputActionSetupExtensions.CompositeSyntax AddCompositeBinding(this InputAction action, string composite, [Optional] string interactions, [Optional] string processors)
		{
			return default(InputActionSetupExtensions.CompositeSyntax);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x55EA7B0", Offset = "0x55E93B0", VA = "0x1855EA7B0")]
		private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex = -1)
		{
			return 0;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x55EC4D0", Offset = "0x55EB0D0", VA = "0x1855EC4D0")]
		public static InputActionSetupExtensions.BindingSyntax ChangeBinding(this InputAction action, int index)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x55EC1F0", Offset = "0x55EADF0", VA = "0x1855EC1F0")]
		public static InputActionSetupExtensions.BindingSyntax ChangeBinding(this InputAction action, string name)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x55EC0A0", Offset = "0x55EACA0", VA = "0x1855EC0A0")]
		public static InputActionSetupExtensions.BindingSyntax ChangeBinding(this InputActionMap actionMap, int index)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x55EBCF0", Offset = "0x55EA8F0", VA = "0x1855EBCF0")]
		public static InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(this InputAction action, string id)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x55EBE30", Offset = "0x55EAA30", VA = "0x1855EBE30")]
		public static InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(this InputAction action, Guid id)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x55EBBB0", Offset = "0x55EA7B0", VA = "0x1855EBBB0")]
		public static InputActionSetupExtensions.BindingSyntax ChangeBindingWithGroup(this InputAction action, string group)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x55EBF60", Offset = "0x55EAB60", VA = "0x1855EBF60")]
		public static InputActionSetupExtensions.BindingSyntax ChangeBindingWithPath(this InputAction action, string path)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x55EC2C0", Offset = "0x55EAEC0", VA = "0x1855EC2C0")]
		public static InputActionSetupExtensions.BindingSyntax ChangeBinding(this InputAction action, InputBinding match)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x55EC5A0", Offset = "0x55EB1A0", VA = "0x1855EC5A0")]
		public static InputActionSetupExtensions.BindingSyntax ChangeCompositeBinding(this InputAction action, string compositeName)
		{
			return default(InputActionSetupExtensions.BindingSyntax);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x55ED570", Offset = "0x55EC170", VA = "0x1855ED570")]
		public static void Rename(this InputAction action, string newName)
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x55EB650", Offset = "0x55EA250", VA = "0x1855EB650")]
		public static void AddControlScheme(this InputActionAsset asset, InputControlScheme controlScheme)
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x55EB9B0", Offset = "0x55EA5B0", VA = "0x1855EB9B0")]
		public static InputActionSetupExtensions.ControlSchemeSyntax AddControlScheme(this InputActionAsset asset, string name)
		{
			return default(InputActionSetupExtensions.ControlSchemeSyntax);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x55ED410", Offset = "0x55EC010", VA = "0x1855ED410")]
		public static void RemoveControlScheme(this InputActionAsset asset, string name)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x55ED850", Offset = "0x55EC450", VA = "0x1855ED850")]
		public static InputControlScheme WithBindingGroup(this InputControlScheme scheme, string bindingGroup)
		{
			return default(InputControlScheme);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x55ED9B0", Offset = "0x55EC5B0", VA = "0x1855ED9B0")]
		public static InputControlScheme WithDevice(this InputControlScheme scheme, string controlPath, bool required)
		{
			return default(InputControlScheme);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x55EDD20", Offset = "0x55EC920", VA = "0x1855EDD20")]
		public static InputControlScheme WithRequiredDevice(this InputControlScheme scheme, string controlPath)
		{
			return default(InputControlScheme);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x55EDBD0", Offset = "0x55EC7D0", VA = "0x1855EDBD0")]
		public static InputControlScheme WithOptionalDevice(this InputControlScheme scheme, string controlPath)
		{
			return default(InputControlScheme);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x55EC970", Offset = "0x55EB570", VA = "0x1855EC970")]
		public static InputControlScheme OrWithRequiredDevice(this InputControlScheme scheme, string controlPath)
		{
			return default(InputControlScheme);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x55EC820", Offset = "0x55EB420", VA = "0x1855EC820")]
		public static InputControlScheme OrWithOptionalDevice(this InputControlScheme scheme, string controlPath)
		{
			return default(InputControlScheme);
		}

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		public struct BindingSyntax
		{
			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060002B3 RID: 691 RVA: 0x00002E68 File Offset: 0x00001068
			[Token(Token = "0x170000D6")]
			public bool valid
			{
				[Token(Token = "0x60002B3")]
				[Address(RVA = "0x55E8250", Offset = "0x55E6E50", VA = "0x1855E8250")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060002B4 RID: 692 RVA: 0x00002E80 File Offset: 0x00001080
			[Token(Token = "0x170000D7")]
			public int bindingIndex
			{
				[Token(Token = "0x60002B4")]
				[Address(RVA = "0x55E8090", Offset = "0x55E6C90", VA = "0x1855E8090")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060002B5 RID: 693 RVA: 0x00002E98 File Offset: 0x00001098
			[Token(Token = "0x170000D8")]
			public InputBinding binding
			{
				[Token(Token = "0x60002B5")]
				[Address(RVA = "0x55E8120", Offset = "0x55E6D20", VA = "0x1855E8120")]
				get
				{
					return default(InputBinding);
				}
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x55E8040", Offset = "0x55E6C40", VA = "0x1855E8040")]
			internal BindingSyntax(InputActionMap map, int bindingIndexInMap, [Optional] InputAction action)
			{
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x00002EB0 File Offset: 0x000010B0
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x55E78F0", Offset = "0x55E64F0", VA = "0x1855E78F0")]
			public InputActionSetupExtensions.BindingSyntax WithName(string name)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x00002EC8 File Offset: 0x000010C8
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x55E7A30", Offset = "0x55E6630", VA = "0x1855E7A30")]
			public InputActionSetupExtensions.BindingSyntax WithPath(string path)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x00002EE0 File Offset: 0x000010E0
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x55E6F50", Offset = "0x55E5B50", VA = "0x1855E6F50")]
			public InputActionSetupExtensions.BindingSyntax WithGroup(string group)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002BA RID: 698 RVA: 0x00002EF8 File Offset: 0x000010F8
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x55E7180", Offset = "0x55E5D80", VA = "0x1855E7180")]
			public InputActionSetupExtensions.BindingSyntax WithGroups(string groups)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002BB RID: 699 RVA: 0x00002F10 File Offset: 0x00001110
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x55E7420", Offset = "0x55E6020", VA = "0x1855E7420")]
			public InputActionSetupExtensions.BindingSyntax WithInteraction(string interaction)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002BC RID: 700 RVA: 0x00002F28 File Offset: 0x00001128
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x55E7650", Offset = "0x55E6250", VA = "0x1855E7650")]
			public InputActionSetupExtensions.BindingSyntax WithInteractions(string interactions)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002BD RID: 701 RVA: 0x00002F40 File Offset: 0x00001140
			[Token(Token = "0x60002BD")]
			public InputActionSetupExtensions.BindingSyntax WithInteraction<TInteraction>() where TInteraction : IInputInteraction
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002BE RID: 702 RVA: 0x00002F58 File Offset: 0x00001158
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x55E7B70", Offset = "0x55E6770", VA = "0x1855E7B70")]
			public InputActionSetupExtensions.BindingSyntax WithProcessor(string processor)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002BF RID: 703 RVA: 0x00002F70 File Offset: 0x00001170
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x55E7DA0", Offset = "0x55E69A0", VA = "0x1855E7DA0")]
			public InputActionSetupExtensions.BindingSyntax WithProcessors(string processors)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002C0 RID: 704 RVA: 0x00002F88 File Offset: 0x00001188
			[Token(Token = "0x60002C0")]
			public InputActionSetupExtensions.BindingSyntax WithProcessor<TProcessor>()
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002C1 RID: 705 RVA: 0x00002FA0 File Offset: 0x000011A0
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x55E6D30", Offset = "0x55E5930", VA = "0x1855E6D30")]
			public InputActionSetupExtensions.BindingSyntax Triggering(InputAction action)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002C2 RID: 706 RVA: 0x00002FB8 File Offset: 0x000011B8
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x55E6B70", Offset = "0x55E5770", VA = "0x1855E6B70")]
			public InputActionSetupExtensions.BindingSyntax To(InputBinding binding)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002C3 RID: 707 RVA: 0x00002FD0 File Offset: 0x000011D0
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x55E68F0", Offset = "0x55E54F0", VA = "0x1855E68F0")]
			public InputActionSetupExtensions.BindingSyntax NextBinding()
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x00002FE8 File Offset: 0x000011E8
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x55E6A30", Offset = "0x55E5630", VA = "0x1855E6A30")]
			public InputActionSetupExtensions.BindingSyntax PreviousBinding()
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002C5 RID: 709 RVA: 0x00003000 File Offset: 0x00001200
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x55E6970", Offset = "0x55E5570", VA = "0x1855E6970")]
			public InputActionSetupExtensions.BindingSyntax NextPartBinding(string partName)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x00003018 File Offset: 0x00001218
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x55E6AB0", Offset = "0x55E56B0", VA = "0x1855E6AB0")]
			public InputActionSetupExtensions.BindingSyntax PreviousPartBinding(string partName)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x00003030 File Offset: 0x00001230
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x55E6930", Offset = "0x55E5530", VA = "0x1855E6930")]
			public InputActionSetupExtensions.BindingSyntax NextCompositeBinding([Optional] string compositeName)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x00003048 File Offset: 0x00001248
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x55E6A70", Offset = "0x55E5670", VA = "0x1855E6A70")]
			public InputActionSetupExtensions.BindingSyntax PreviousCompositeBinding([Optional] string compositeName)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x00003060 File Offset: 0x00001260
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x55E67B0", Offset = "0x55E53B0", VA = "0x1855E67B0")]
			private InputActionSetupExtensions.BindingSyntax Iterate(bool next)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002CA RID: 714 RVA: 0x00003078 File Offset: 0x00001278
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x55E63F0", Offset = "0x55E4FF0", VA = "0x1855E63F0")]
			private InputActionSetupExtensions.BindingSyntax IterateCompositeBinding(bool next, string compositeName)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002CB RID: 715 RVA: 0x00003090 File Offset: 0x00001290
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x55E6590", Offset = "0x55E5190", VA = "0x1855E6590")]
			private InputActionSetupExtensions.BindingSyntax IteratePartBinding(bool next, string partName)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x55E5F00", Offset = "0x55E4B00", VA = "0x1855E5F00")]
			public void Erase()
			{
			}

			// Token: 0x060002CD RID: 717 RVA: 0x000030A8 File Offset: 0x000012A8
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x55E6120", Offset = "0x55E4D20", VA = "0x1855E6120")]
			public InputActionSetupExtensions.BindingSyntax InsertPartBinding(string partName, string path)
			{
				return default(InputActionSetupExtensions.BindingSyntax);
			}

			// Token: 0x0400015B RID: 347
			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly InputActionMap m_ActionMap;

			// Token: 0x0400015C RID: 348
			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly InputAction m_Action;

			// Token: 0x0400015D RID: 349
			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal readonly int m_BindingIndexInMap;
		}

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		public struct CompositeSyntax
		{
			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060002CE RID: 718 RVA: 0x000030C0 File Offset: 0x000012C0
			[Token(Token = "0x170000D9")]
			public int bindingIndex
			{
				[Token(Token = "0x60002CE")]
				[Address(RVA = "0x55E84F0", Offset = "0x55E70F0", VA = "0x1855E84F0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x55E84A0", Offset = "0x55E70A0", VA = "0x1855E84A0")]
			internal CompositeSyntax(InputActionMap map, InputAction action, int compositeIndex)
			{
			}

			// Token: 0x060002D0 RID: 720 RVA: 0x000030D8 File Offset: 0x000012D8
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x55E82B0", Offset = "0x55E6EB0", VA = "0x1855E82B0")]
			public InputActionSetupExtensions.CompositeSyntax With(string name, string binding, [Optional] string groups, [Optional] string processors)
			{
				return default(InputActionSetupExtensions.CompositeSyntax);
			}

			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly InputAction m_Action;

			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly InputActionMap m_ActionMap;

			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_BindingIndexInMap;
		}

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		public struct ControlSchemeSyntax
		{
			// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x55E8AC0", Offset = "0x55E76C0", VA = "0x1855E8AC0")]
			internal ControlSchemeSyntax(InputActionAsset asset, int index)
			{
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x55E8A70", Offset = "0x55E7670", VA = "0x1855E8A70")]
			internal ControlSchemeSyntax(InputControlScheme controlScheme)
			{
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x000030F0 File Offset: 0x000012F0
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x55E8880", Offset = "0x55E7480", VA = "0x1855E8880")]
			public InputActionSetupExtensions.ControlSchemeSyntax WithBindingGroup(string bindingGroup)
			{
				return default(InputActionSetupExtensions.ControlSchemeSyntax);
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x00003108 File Offset: 0x00001308
			[Token(Token = "0x60002D4")]
			public InputActionSetupExtensions.ControlSchemeSyntax WithRequiredDevice<TDevice>() where TDevice : InputDevice
			{
				return default(InputActionSetupExtensions.ControlSchemeSyntax);
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x00003120 File Offset: 0x00001320
			[Token(Token = "0x60002D5")]
			public InputActionSetupExtensions.ControlSchemeSyntax WithOptionalDevice<TDevice>() where TDevice : InputDevice
			{
				return default(InputActionSetupExtensions.ControlSchemeSyntax);
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x00003138 File Offset: 0x00001338
			[Token(Token = "0x60002D6")]
			public InputActionSetupExtensions.ControlSchemeSyntax OrWithRequiredDevice<TDevice>() where TDevice : InputDevice
			{
				return default(InputActionSetupExtensions.ControlSchemeSyntax);
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x00003150 File Offset: 0x00001350
			[Token(Token = "0x60002D7")]
			public InputActionSetupExtensions.ControlSchemeSyntax OrWithOptionalDevice<TDevice>() where TDevice : InputDevice
			{
				return default(InputActionSetupExtensions.ControlSchemeSyntax);
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x00003168 File Offset: 0x00001368
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x55E8A20", Offset = "0x55E7620", VA = "0x1855E8A20")]
			public InputActionSetupExtensions.ControlSchemeSyntax WithRequiredDevice(string controlPath)
			{
				return default(InputActionSetupExtensions.ControlSchemeSyntax);
			}

			// Token: 0x060002D9 RID: 729 RVA: 0x00003180 File Offset: 0x00001380
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x55E89D0", Offset = "0x55E75D0", VA = "0x1855E89D0")]
			public InputActionSetupExtensions.ControlSchemeSyntax WithOptionalDevice(string controlPath)
			{
				return default(InputActionSetupExtensions.ControlSchemeSyntax);
			}

			// Token: 0x060002DA RID: 730 RVA: 0x00003198 File Offset: 0x00001398
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x55E8830", Offset = "0x55E7430", VA = "0x1855E8830")]
			public InputActionSetupExtensions.ControlSchemeSyntax OrWithRequiredDevice(string controlPath)
			{
				return default(InputActionSetupExtensions.ControlSchemeSyntax);
			}

			// Token: 0x060002DB RID: 731 RVA: 0x000031B0 File Offset: 0x000013B0
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x55E87E0", Offset = "0x55E73E0", VA = "0x1855E87E0")]
			public InputActionSetupExtensions.ControlSchemeSyntax OrWithOptionalDevice(string controlPath)
			{
				return default(InputActionSetupExtensions.ControlSchemeSyntax);
			}

			// Token: 0x060002DC RID: 732 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60002DC")]
			private string DeviceTypeToControlPath<TDevice>() where TDevice : InputDevice
			{
				return null;
			}

			// Token: 0x060002DD RID: 733 RVA: 0x000031C8 File Offset: 0x000013C8
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x55E8720", Offset = "0x55E7320", VA = "0x1855E8720")]
			public InputControlScheme Done()
			{
				return default(InputControlScheme);
			}

			// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x55E8520", Offset = "0x55E7120", VA = "0x1855E8520")]
			private void AddDeviceEntry(string controlPath, InputControlScheme.DeviceRequirement.Flags flags)
			{
			}

			// Token: 0x04000161 RID: 353
			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly InputActionAsset m_Asset;

			// Token: 0x04000162 RID: 354
			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly int m_ControlSchemeIndex;

			// Token: 0x04000163 RID: 355
			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private InputControlScheme m_ControlScheme;
		}
	}
}
