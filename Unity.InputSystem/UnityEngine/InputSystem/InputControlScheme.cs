using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Serializable]
	public struct InputControlScheme : IEquatable<InputControlScheme>
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000142")]
		public string name
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000143")]
		public string bindingGroup
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
			set
			{
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x17000144")]
		public ReadOnlyArray<InputControlScheme.DeviceRequirement> deviceRequirements
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x5623DF0", Offset = "0x56229F0", VA = "0x185623DF0")]
			get
			{
				return default(ReadOnlyArray<InputControlScheme.DeviceRequirement>);
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x5623CC0", Offset = "0x56228C0", VA = "0x185623CC0")]
		public InputControlScheme(string name, [Optional] IEnumerable<InputControlScheme.DeviceRequirement> devices, [Optional] string bindingGroup)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x5623930", Offset = "0x5622530", VA = "0x185623930")]
		internal void SetNameAndBindingGroup(string name, [Optional] string bindingGroup)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x6000435")]
		public static InputControlScheme? FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, [Optional] InputDevice mustIncludeDevice, bool allowUnsuccesfulMatch = false) where TDevices : IReadOnlyList<InputDevice> where TSchemes : IEnumerable<InputControlScheme>
		{
			return null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x6000436")]
		public static bool FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, out InputControlScheme controlScheme, out InputControlScheme.MatchResult matchResult, [Optional] InputDevice mustIncludeDevice, bool allowUnsuccessfulMatch = false) where TDevices : IReadOnlyList<InputDevice> where TSchemes : IEnumerable<InputControlScheme>
		{
			return default(bool);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x6000437")]
		public static InputControlScheme? FindControlSchemeForDevice<TSchemes>(InputDevice device, TSchemes schemes) where TSchemes : IEnumerable<InputControlScheme>
		{
			return null;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x5623A00", Offset = "0x5622600", VA = "0x185623A00")]
		public bool SupportsDevice(InputDevice device)
		{
			return default(bool);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x6000439")]
		public InputControlScheme.MatchResult PickDevicesFrom<TDevices>(TDevices devices, [Optional] InputDevice favorDevice) where TDevices : IReadOnlyList<InputDevice>
		{
			return default(InputControlScheme.MatchResult);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x5623580", Offset = "0x5622180", VA = "0x185623580", Slot = "4")]
		public bool Equals(InputControlScheme other)
		{
			return default(bool);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x56237A0", Offset = "0x56223A0", VA = "0x1856237A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x5623840", Offset = "0x5622440", VA = "0x185623840", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x5623B30", Offset = "0x5622730", VA = "0x185623B30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x5623E50", Offset = "0x5622A50", VA = "0x185623E50")]
		public static bool operator ==(InputControlScheme left, InputControlScheme right)
		{
			return default(bool);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x5623E80", Offset = "0x5622A80", VA = "0x185623E80")]
		public static bool operator !=(InputControlScheme left, InputControlScheme right)
		{
			return default(bool);
		}

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal string m_Name;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		internal string m_BindingGroup;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal InputControlScheme.DeviceRequirement[] m_DeviceRequirements;

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x200005B")]
		public struct MatchResult : IEnumerable<InputControlScheme.MatchResult.Match>, IEnumerable, IDisposable
		{
			// Token: 0x17000145 RID: 325
			// (get) Token: 0x06000440 RID: 1088 RVA: 0x00003E40 File Offset: 0x00002040
			[Token(Token = "0x17000145")]
			public float score
			{
				[Token(Token = "0x6000440")]
				[Address(RVA = "0x877280", Offset = "0x875E80", VA = "0x180877280")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x06000441 RID: 1089 RVA: 0x00003E58 File Offset: 0x00002058
			[Token(Token = "0x17000146")]
			public bool isSuccessfulMatch
			{
				[Token(Token = "0x6000441")]
				[Address(RVA = "0x4A0D3B0", Offset = "0x4A0BFB0", VA = "0x184A0D3B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x00003E70 File Offset: 0x00002070
			[Token(Token = "0x17000147")]
			public bool hasMissingRequiredDevices
			{
				[Token(Token = "0x6000442")]
				[Address(RVA = "0x263D540", Offset = "0x263C140", VA = "0x18263D540")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x06000443 RID: 1091 RVA: 0x00003E88 File Offset: 0x00002088
			[Token(Token = "0x17000148")]
			public bool hasMissingOptionalDevices
			{
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x562E8F0", Offset = "0x562D4F0", VA = "0x18562E8F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x06000444 RID: 1092 RVA: 0x00003EA0 File Offset: 0x000020A0
			[Token(Token = "0x17000149")]
			public InputControlList<InputDevice> devices
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x562E7C0", Offset = "0x562D3C0", VA = "0x18562E7C0")]
				get
				{
					return default(InputControlList<InputDevice>);
				}
			}

			// Token: 0x1700014A RID: 330
			[Token(Token = "0x1700014A")]
			public InputControlScheme.MatchResult.Match this[int index]
			{
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x562E700", Offset = "0x562D300", VA = "0x18562E700")]
				get
				{
					return default(InputControlScheme.MatchResult.Match);
				}
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x562E650", Offset = "0x562D250", VA = "0x18562E650", Slot = "4")]
			public IEnumerator<InputControlScheme.MatchResult.Match> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x562E6F0", Offset = "0x562D2F0", VA = "0x18562E6F0", Slot = "5")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x562E5F0", Offset = "0x562D1F0", VA = "0x18562E5F0", Slot = "6")]
			public void Dispose()
			{
			}

			// Token: 0x04000215 RID: 533
			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal InputControlScheme.MatchResult.Result m_Result;

			// Token: 0x04000216 RID: 534
			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal float m_Score;

			// Token: 0x04000217 RID: 535
			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal InputControlList<InputDevice> m_Devices;

			// Token: 0x04000218 RID: 536
			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal InputControlList<InputControl> m_Controls;

			// Token: 0x04000219 RID: 537
			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal InputControlScheme.DeviceRequirement[] m_Requirements;

			// Token: 0x0200005C RID: 92
			[Token(Token = "0x200005C")]
			internal enum Result
			{
				// Token: 0x0400021B RID: 539
				[Token(Token = "0x400021B")]
				AllSatisfied,
				// Token: 0x0400021C RID: 540
				[Token(Token = "0x400021C")]
				MissingRequired,
				// Token: 0x0400021D RID: 541
				[Token(Token = "0x400021D")]
				MissingOptional
			}

			// Token: 0x0200005D RID: 93
			[Token(Token = "0x200005D")]
			public struct Match
			{
				// Token: 0x1700014B RID: 331
				// (get) Token: 0x06000449 RID: 1097 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x1700014B")]
				public InputControl control
				{
					[Token(Token = "0x6000449")]
					[Address(RVA = "0x562E900", Offset = "0x562D500", VA = "0x18562E900")]
					get
					{
						return null;
					}
				}

				// Token: 0x1700014C RID: 332
				// (get) Token: 0x0600044A RID: 1098 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x1700014C")]
				public InputDevice device
				{
					[Token(Token = "0x600044A")]
					[Address(RVA = "0x562E940", Offset = "0x562D540", VA = "0x18562E940")]
					get
					{
						return null;
					}
				}

				// Token: 0x1700014D RID: 333
				// (get) Token: 0x0600044B RID: 1099 RVA: 0x00003ED0 File Offset: 0x000020D0
				[Token(Token = "0x1700014D")]
				public int requirementIndex
				{
					[Token(Token = "0x600044B")]
					[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
					get
					{
						return 0;
					}
				}

				// Token: 0x1700014E RID: 334
				// (get) Token: 0x0600044C RID: 1100 RVA: 0x00003EE8 File Offset: 0x000020E8
				[Token(Token = "0x1700014E")]
				public InputControlScheme.DeviceRequirement requirement
				{
					[Token(Token = "0x600044C")]
					[Address(RVA = "0x562E9D0", Offset = "0x562D5D0", VA = "0x18562E9D0")]
					get
					{
						return default(InputControlScheme.DeviceRequirement);
					}
				}

				// Token: 0x1700014F RID: 335
				// (get) Token: 0x0600044D RID: 1101 RVA: 0x00003F00 File Offset: 0x00002100
				[Token(Token = "0x1700014F")]
				public bool isOptional
				{
					[Token(Token = "0x600044D")]
					[Address(RVA = "0x562E990", Offset = "0x562D590", VA = "0x18562E990")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0400021E RID: 542
				[Token(Token = "0x400021E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				internal int m_RequirementIndex;

				// Token: 0x0400021F RID: 543
				[Token(Token = "0x400021F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal InputControlScheme.DeviceRequirement[] m_Requirements;

				// Token: 0x04000220 RID: 544
				[Token(Token = "0x4000220")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal InputControlList<InputControl> m_Controls;
			}

			// Token: 0x0200005E RID: 94
			[Token(Token = "0x200005E")]
			private struct Enumerator : IEnumerator<InputControlScheme.MatchResult.Match>, IEnumerator, IDisposable
			{
				// Token: 0x0600044E RID: 1102 RVA: 0x00003F18 File Offset: 0x00002118
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x561B230", Offset = "0x5619E30", VA = "0x18561B230", Slot = "6")]
				public bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x561B250", Offset = "0x5619E50", VA = "0x18561B250", Slot = "8")]
				public void Reset()
				{
				}

				// Token: 0x17000150 RID: 336
				// (get) Token: 0x06000450 RID: 1104 RVA: 0x00003F30 File Offset: 0x00002130
				[Token(Token = "0x17000150")]
				public InputControlScheme.MatchResult.Match Current
				{
					[Token(Token = "0x6000450")]
					[Address(RVA = "0x561B2D0", Offset = "0x5619ED0", VA = "0x18561B2D0", Slot = "4")]
					get
					{
						return default(InputControlScheme.MatchResult.Match);
					}
				}

				// Token: 0x17000151 RID: 337
				// (get) Token: 0x06000451 RID: 1105 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x17000151")]
				private object Current
				{
					[Token(Token = "0x6000451")]
					[Address(RVA = "0x561B260", Offset = "0x5619E60", VA = "0x18561B260", Slot = "7")]
					get
					{
						return null;
					}
				}

				// Token: 0x06000452 RID: 1106 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
				public void Dispose()
				{
				}

				// Token: 0x04000221 RID: 545
				[Token(Token = "0x4000221")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				internal int m_Index;

				// Token: 0x04000222 RID: 546
				[Token(Token = "0x4000222")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal InputControlScheme.DeviceRequirement[] m_Requirements;

				// Token: 0x04000223 RID: 547
				[Token(Token = "0x4000223")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal InputControlList<InputControl> m_Controls;
			}
		}

		// Token: 0x0200005F RID: 95
		[Token(Token = "0x200005F")]
		[Serializable]
		public struct DeviceRequirement : IEquatable<InputControlScheme.DeviceRequirement>
		{
			// Token: 0x17000152 RID: 338
			// (get) Token: 0x06000453 RID: 1107 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000152")]
			public string controlPath
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000454")]
				[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
				set
				{
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x06000455 RID: 1109 RVA: 0x00003F48 File Offset: 0x00002148
			// (set) Token: 0x06000456 RID: 1110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000153")]
			public bool isOptional
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x561B0C0", Offset = "0x5619CC0", VA = "0x18561B0C0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000456")]
				[Address(RVA = "0x561B210", Offset = "0x5619E10", VA = "0x18561B210")]
				set
				{
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x06000457 RID: 1111 RVA: 0x00003F60 File Offset: 0x00002160
			// (set) Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000154")]
			public bool isAND
			{
				[Token(Token = "0x6000457")]
				[Address(RVA = "0x561B0A0", Offset = "0x5619CA0", VA = "0x18561B0A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x561B1D0", Offset = "0x5619DD0", VA = "0x18561B1D0")]
				set
				{
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x06000459 RID: 1113 RVA: 0x00003F78 File Offset: 0x00002178
			// (set) Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000155")]
			public bool isOR
			{
				[Token(Token = "0x6000459")]
				[Address(RVA = "0x561B0B0", Offset = "0x5619CB0", VA = "0x18561B0B0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x561B1F0", Offset = "0x5619DF0", VA = "0x18561B1F0")]
				set
				{
				}
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x561B000", Offset = "0x5619C00", VA = "0x18561B000", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x00003F90 File Offset: 0x00002190
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x561AD90", Offset = "0x5619990", VA = "0x18561AD90", Slot = "4")]
			public bool Equals(InputControlScheme.DeviceRequirement other)
			{
				return default(bool);
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x00003FA8 File Offset: 0x000021A8
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x561AE10", Offset = "0x5619A10", VA = "0x18561AE10", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x00003FC0 File Offset: 0x000021C0
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x561AEF0", Offset = "0x5619AF0", VA = "0x18561AEF0", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x00003FD8 File Offset: 0x000021D8
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x561B0D0", Offset = "0x5619CD0", VA = "0x18561B0D0")]
			public static bool operator ==(InputControlScheme.DeviceRequirement left, InputControlScheme.DeviceRequirement right)
			{
				return default(bool);
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x00003FF0 File Offset: 0x000021F0
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x561B150", Offset = "0x5619D50", VA = "0x18561B150")]
			public static bool operator !=(InputControlScheme.DeviceRequirement left, InputControlScheme.DeviceRequirement right)
			{
				return default(bool);
			}

			// Token: 0x04000224 RID: 548
			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			internal string m_ControlPath;

			// Token: 0x04000225 RID: 549
			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			internal InputControlScheme.DeviceRequirement.Flags m_Flags;

			// Token: 0x02000060 RID: 96
			[Token(Token = "0x2000060")]
			[Flags]
			internal enum Flags
			{
				// Token: 0x04000227 RID: 551
				[Token(Token = "0x4000227")]
				None = 0,
				// Token: 0x04000228 RID: 552
				[Token(Token = "0x4000228")]
				Optional = 1,
				// Token: 0x04000229 RID: 553
				[Token(Token = "0x4000229")]
				Or = 2
			}
		}

		// Token: 0x02000061 RID: 97
		[Token(Token = "0x2000061")]
		[Serializable]
		internal struct SchemeJson
		{
			// Token: 0x06000461 RID: 1121 RVA: 0x00004008 File Offset: 0x00002208
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x56306F0", Offset = "0x562F2F0", VA = "0x1856306F0")]
			public InputControlScheme ToScheme()
			{
				return default(InputControlScheme);
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x00004020 File Offset: 0x00002220
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x5630210", Offset = "0x562EE10", VA = "0x185630210")]
			public static InputControlScheme.SchemeJson ToJson(InputControlScheme scheme)
			{
				return default(InputControlScheme.SchemeJson);
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x5630420", Offset = "0x562F020", VA = "0x185630420")]
			public static InputControlScheme.SchemeJson[] ToJson(InputControlScheme[] schemes)
			{
				return null;
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x56308B0", Offset = "0x562F4B0", VA = "0x1856308B0")]
			public static InputControlScheme[] ToSchemes(InputControlScheme.SchemeJson[] schemes)
			{
				return null;
			}

			// Token: 0x0400022A RID: 554
			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string bindingGroup;

			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InputControlScheme.SchemeJson.DeviceJson[] devices;

			// Token: 0x02000062 RID: 98
			[Token(Token = "0x2000062")]
			[Serializable]
			public struct DeviceJson
			{
				// Token: 0x06000465 RID: 1125 RVA: 0x00004038 File Offset: 0x00002238
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x561AD30", Offset = "0x5619930", VA = "0x18561AD30")]
				public InputControlScheme.DeviceRequirement ToDeviceEntry()
				{
					return default(InputControlScheme.DeviceRequirement);
				}

				// Token: 0x06000466 RID: 1126 RVA: 0x00004050 File Offset: 0x00002250
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x561ACE0", Offset = "0x56198E0", VA = "0x18561ACE0")]
				public static InputControlScheme.SchemeJson.DeviceJson From(InputControlScheme.DeviceRequirement requirement)
				{
					return default(InputControlScheme.SchemeJson.DeviceJson);
				}

				// Token: 0x0400022D RID: 557
				[Token(Token = "0x400022D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string devicePath;

				// Token: 0x0400022E RID: 558
				[Token(Token = "0x400022E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public bool isOptional;

				// Token: 0x0400022F RID: 559
				[Token(Token = "0x400022F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
				public bool isOR;
			}
		}
	}
}
