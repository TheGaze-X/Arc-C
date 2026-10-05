using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.Users;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	[DisallowMultipleComponent]
	[AddComponentMenu("Input/Player Input")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/PlayerInput.html")]
	public class PlayerInput : MonoBehaviour
	{
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x170002D7")]
		public bool inputIsActive
		{
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x12905D0", Offset = "0x128F1D0", VA = "0x1812905D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x170002D8")]
		[Obsolete("Use inputIsActive instead.")]
		public bool active
		{
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x12905D0", Offset = "0x128F1D0", VA = "0x1812905D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x170002D9")]
		public int playerIndex
		{
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x12905A0", Offset = "0x128F1A0", VA = "0x1812905A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x170002DA")]
		public int splitScreenIndex
		{
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x4A559F0", Offset = "0x4A545F0", VA = "0x184A559F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DB")]
		public InputActionAsset actions
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x56AE920", Offset = "0x56AD520", VA = "0x1856AE920")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x56AF270", Offset = "0x56ADE70", VA = "0x1856AF270")]
			set
			{
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002DC")]
		public string currentControlScheme
		{
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x56AEAA0", Offset = "0x56AD6A0", VA = "0x1856AEAA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DD")]
		public string defaultControlScheme
		{
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			set
			{
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x000058C8 File Offset: 0x00003AC8
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DE")]
		public bool neverAutoSwitchControlSchemes
		{
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x56AF3F0", Offset = "0x56ADFF0", VA = "0x1856AF3F0")]
			set
			{
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DF")]
		public InputActionMap currentActionMap
		{
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x56AF380", Offset = "0x56ADF80", VA = "0x1856AF380")]
			set
			{
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E0")]
		public string defaultActionMap
		{
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			set
			{
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x000058E0 File Offset: 0x00003AE0
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E1")]
		public PlayerNotifications notificationBehavior
		{
			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return PlayerNotifications.SendMessages;
			}
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x56AF430", Offset = "0x56AE030", VA = "0x1856AF430")]
			set
			{
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x000058F8 File Offset: 0x00003AF8
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E2")]
		public ReadOnlyArray<PlayerInput.ActionEvent> actionEvents
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x56AE8C0", Offset = "0x56AD4C0", VA = "0x1856AE8C0")]
			get
			{
				return default(ReadOnlyArray<PlayerInput.ActionEvent>);
			}
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x56AF1F0", Offset = "0x56ADDF0", VA = "0x1856AF1F0")]
			set
			{
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002E3")]
		public PlayerInput.DeviceLostEvent deviceLostEvent
		{
			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x56AEB80", Offset = "0x56AD780", VA = "0x1856AEB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002E4")]
		public PlayerInput.DeviceRegainedEvent deviceRegainedEvent
		{
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x56AEC20", Offset = "0x56AD820", VA = "0x1856AEC20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002E5")]
		public PlayerInput.ControlsChangedEvent controlsChangedEvent
		{
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x56AEA00", Offset = "0x56AD600", VA = "0x1856AEA00")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000B29 RID: 2857 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B2A RID: 2858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000018")]
		public event Action<InputAction.CallbackContext> onActionTriggered
		{
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x56AE600", Offset = "0x56AD200", VA = "0x1856AE600")]
			add
			{
			}
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x56AEF30", Offset = "0x56ADB30", VA = "0x1856AEF30")]
			remove
			{
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000B2B RID: 2859 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000019")]
		public event Action<PlayerInput> onDeviceLost
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x56AE760", Offset = "0x56AD360", VA = "0x1856AE760")]
			add
			{
			}
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x56AF090", Offset = "0x56ADC90", VA = "0x1856AF090")]
			remove
			{
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000B2D RID: 2861 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B2E RID: 2862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001A")]
		public event Action<PlayerInput> onDeviceRegained
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x56AE810", Offset = "0x56AD410", VA = "0x1856AE810")]
			add
			{
			}
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x56AF140", Offset = "0x56ADD40", VA = "0x1856AF140")]
			remove
			{
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000B2F RID: 2863 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B30 RID: 2864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001B")]
		public event Action<PlayerInput> onControlsChanged
		{
			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0x56AE6B0", Offset = "0x56AD2B0", VA = "0x1856AE6B0")]
			add
			{
			}
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x56AEFE0", Offset = "0x56ADBE0", VA = "0x1856AEFE0")]
			remove
			{
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E6")]
		public Camera camera
		{
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
			set
			{
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E7")]
		public InputSystemUIInputModule uiInputModule
		{
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0x56AF480", Offset = "0x56AE080", VA = "0x1856AF480")]
			set
			{
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x170002E8")]
		public InputUser user
		{
			[Token(Token = "0x6000B35")]
			[Address(RVA = "0x7CEE30", Offset = "0x7CDA30", VA = "0x1807CEE30")]
			get
			{
				return default(InputUser);
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x170002E9")]
		public ReadOnlyArray<InputDevice> devices
		{
			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x56AECC0", Offset = "0x56AD8C0", VA = "0x1856AECC0")]
			get
			{
				return default(ReadOnlyArray<InputDevice>);
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00005940 File Offset: 0x00003B40
		[Token(Token = "0x170002EA")]
		public bool hasMissingRequiredDevices
		{
			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x56AED20", Offset = "0x56AD920", VA = "0x1856AED20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x170002EB")]
		public static ReadOnlyArray<PlayerInput> all
		{
			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x56AE970", Offset = "0x56AD570", VA = "0x1856AE970")]
			get
			{
				return default(ReadOnlyArray<PlayerInput>);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x170002EC")]
		public static bool isSinglePlayer
		{
			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x56AEE20", Offset = "0x56ADA20", VA = "0x1856AEE20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B3A")]
		public TDevice GetDevice<TDevice>() where TDevice : InputDevice
		{
			return null;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x56A88C0", Offset = "0x56A74C0", VA = "0x1856A88C0")]
		public void ActivateInput()
		{
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x56A99B0", Offset = "0x56A85B0", VA = "0x1856A99B0")]
		public void DeactivateInput()
		{
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x56A99B0", Offset = "0x56A85B0", VA = "0x1856A99B0")]
		[Obsolete("Use DeactivateInput instead.")]
		public void PassivateInput()
		{
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x56AD8D0", Offset = "0x56AC4D0", VA = "0x1856AD8D0")]
		public bool SwitchCurrentControlScheme(params InputDevice[] devices)
		{
			return default(bool);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x56ADB40", Offset = "0x56AC740", VA = "0x1856ADB40")]
		public void SwitchCurrentControlScheme(string controlScheme, params InputDevice[] devices)
		{
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x56AD730", Offset = "0x56AC330", VA = "0x1856AD730")]
		public void SwitchCurrentActionMap(string mapNameOrId)
		{
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x56A9FA0", Offset = "0x56A8BA0", VA = "0x1856A9FA0")]
		public static PlayerInput GetPlayerByIndex(int playerIndex)
		{
			return null;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x56A9DD0", Offset = "0x56A89D0", VA = "0x1856A9DD0")]
		public static PlayerInput FindFirstPairedToDevice(InputDevice device)
		{
			return null;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x56AAE30", Offset = "0x56A9A30", VA = "0x1856AAE30")]
		public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, [Optional] string controlScheme, int splitScreenIndex = -1, [Optional] InputDevice pairWithDevice)
		{
			return null;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x56AAC50", Offset = "0x56A9850", VA = "0x1856AAC50")]
		public static PlayerInput Instantiate(GameObject prefab, int playerIndex = -1, [Optional] string controlScheme, int splitScreenIndex = -1, params InputDevice[] pairWithDevices)
		{
			return null;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x56A9A40", Offset = "0x56A8640", VA = "0x1856A9A40")]
		private static PlayerInput DoInstantiate(GameObject prefab)
		{
			return null;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x56AA4A0", Offset = "0x56A90A0", VA = "0x1856AA4A0")]
		private void InitializeActions()
		{
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x56AE220", Offset = "0x56ACE20", VA = "0x1856AE220")]
		private void UninitializeActions()
		{
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x56AAAA0", Offset = "0x56A96A0", VA = "0x1856AAAA0")]
		private void InstallOnActionTriggeredHook()
		{
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x56AE440", Offset = "0x56AD040", VA = "0x1856AE440")]
		private void UninstallOnActionTriggeredHook()
		{
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x56AAFF0", Offset = "0x56A9BF0", VA = "0x1856AAFF0")]
		private void OnActionTriggered(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x56A96B0", Offset = "0x56A82B0", VA = "0x1856A96B0")]
		private void CacheMessageNames()
		{
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void ClearCaches()
		{
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x56A8C90", Offset = "0x56A7890", VA = "0x1856A8C90")]
		private void AssignUserAndDevices()
		{
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x56AA390", Offset = "0x56A8F90", VA = "0x1856AA390")]
		private bool HaveBindingForDevice(InputDevice device)
		{
			return default(bool);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x56AE140", Offset = "0x56ACD40", VA = "0x1856AE140")]
		private void UnassignUserAndDevices()
		{
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x56ADD10", Offset = "0x56AC910", VA = "0x1856ADD10")]
		private bool TryToActivateControlScheme(InputControlScheme controlScheme)
		{
			return default(bool);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x56A8970", Offset = "0x56A7570", VA = "0x1856A8970")]
		private void AssignPlayerIndex()
		{
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x56AB850", Offset = "0x56AA450", VA = "0x1856AB850")]
		private void OnEnable()
		{
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x56AC940", Offset = "0x56AB540", VA = "0x1856AC940")]
		private void StartListeningForUnpairedDeviceActivity()
		{
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x56ACC90", Offset = "0x56AB890", VA = "0x1856ACC90")]
		private void StopListeningForUnpairedDeviceActivity()
		{
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x56AC860", Offset = "0x56AB460", VA = "0x1856AC860")]
		private void StartListeningForDeviceChanges()
		{
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x56ACC20", Offset = "0x56AB820", VA = "0x1856ACC20")]
		private void StopListeningForDeviceChanges()
		{
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x56AB360", Offset = "0x56A9F60", VA = "0x1856AB360")]
		private void OnDisable()
		{
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x56A99E0", Offset = "0x56A85E0", VA = "0x1856A99E0")]
		public void DebugLogAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x56AA190", Offset = "0x56A8D90", VA = "0x1856AA190")]
		private void HandleDeviceLost()
		{
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x56AA290", Offset = "0x56A8E90", VA = "0x1856AA290")]
		private void HandleDeviceRegained()
		{
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x56AA090", Offset = "0x56A8C90", VA = "0x1856AA090")]
		private void HandleControlsChanged()
		{
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x56AC6D0", Offset = "0x56AB2D0", VA = "0x1856AC6D0")]
		private static void OnUserChange(InputUser user, InputUserChange change, InputDevice device)
		{
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x56ABE30", Offset = "0x56AAA30", VA = "0x1856ABE30")]
		private static bool OnPreFilterUnpairedDeviceUsed(InputDevice device, InputEventPtr eventPtr)
		{
			return default(bool);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x56ABFB0", Offset = "0x56AABB0", VA = "0x1856ABFB0")]
		private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr)
		{
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x56AB240", Offset = "0x56A9E40", VA = "0x1856AB240")]
		private void OnDeviceChange(InputDevice device, InputDeviceChange change)
		{
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x56ACE90", Offset = "0x56ABA90", VA = "0x1856ACE90")]
		private void SwitchControlSchemeInternal(ref InputControlScheme controlScheme, params InputDevice[] devices)
		{
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x56AE5E0", Offset = "0x56AD1E0", VA = "0x1856AE5E0")]
		public PlayerInput()
		{
		}

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		public const string DeviceLostMessage = "OnDeviceLost";

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		public const string DeviceRegainedMessage = "OnDeviceRegained";

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		public const string ControlsChangedMessage = "OnControlsChanged";

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Input actions associated with the player.")]
		internal InputActionAsset m_Actions;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Determine how notifications should be sent when an input-related event associated with the player happens.")]
		internal PlayerNotifications m_NotificationBehavior;

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("UI InputModule that should have it's input actions synchronized to this PlayerInput's actions.")]
		internal InputSystemUIInputModule m_UIInputModule;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Event that is triggered when the PlayerInput loses a paired device (e.g. its battery runs out).")]
		internal PlayerInput.DeviceLostEvent m_DeviceLostEvent;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal PlayerInput.DeviceRegainedEvent m_DeviceRegainedEvent;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		internal PlayerInput.ControlsChangedEvent m_ControlsChangedEvent;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal PlayerInput.ActionEvent[] m_ActionEvents;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		internal bool m_NeverAutoSwitchControlSchemes;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		internal string m_DefaultControlScheme;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		internal string m_DefaultActionMap;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		internal int m_SplitScreenIndex;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Reference to the player's view camera. Note that this is only required when using split-screen and/or per-player UIs. Otherwise it is safe to leave this property uninitialized.")]
		[SerializeField]
		internal Camera m_Camera;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private InputValue m_InputValueObject;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[NonSerialized]
		internal InputActionMap m_CurrentActionMap;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private int m_PlayerIndex;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[NonSerialized]
		private bool m_InputActive;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[NonSerialized]
		private bool m_Enabled;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E")]
		[NonSerialized]
		internal bool m_ActionsInitialized;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[NonSerialized]
		private Dictionary<string, string> m_ActionMessageNames;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[NonSerialized]
		private InputUser m_InputUser;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		private Action<InputAction.CallbackContext> m_ActionTriggeredDelegate;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		private CallbackArray<Action<PlayerInput>> m_DeviceLostCallbacks;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[NonSerialized]
		private CallbackArray<Action<PlayerInput>> m_DeviceRegainedCallbacks;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[NonSerialized]
		private CallbackArray<Action<PlayerInput>> m_ControlsChangedCallbacks;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[NonSerialized]
		private CallbackArray<Action<InputAction.CallbackContext>> m_ActionTriggeredCallbacks;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[NonSerialized]
		private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate;

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[NonSerialized]
		private Func<InputDevice, InputEventPtr, bool> m_PreFilterUnpairedDeviceUsedDelegate;

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[NonSerialized]
		private bool m_OnUnpairedDeviceUsedHooked;

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[NonSerialized]
		private Action<InputDevice, InputDeviceChange> m_DeviceChangeDelegate;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[NonSerialized]
		private bool m_OnDeviceChangeHooked;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static int s_AllActivePlayersCount;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static PlayerInput[] s_AllActivePlayers;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Action<InputUser, InputUserChange, InputDevice> s_UserChangeDelegate;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int s_InitPairWithDevicesCount;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static InputDevice[] s_InitPairWithDevices;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static int s_InitPlayerIndex;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static int s_InitSplitScreenIndex;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string s_InitControlScheme;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal static bool s_DestroyIfDeviceSetupUnsuccessful;

		// Token: 0x020000D0 RID: 208
		[Token(Token = "0x20000D0")]
		[Serializable]
		public class ActionEvent : UnityEvent<InputAction.CallbackContext>
		{
			// Token: 0x170002ED RID: 749
			// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002ED")]
			public string actionId
			{
				[Token(Token = "0x6000B63")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002EE RID: 750
			// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002EE")]
			public string actionName
			{
				[Token(Token = "0x6000B64")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000B65 RID: 2917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x569C020", Offset = "0x569AC20", VA = "0x18569C020")]
			public ActionEvent()
			{
			}

			// Token: 0x06000B66 RID: 2918 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x569C060", Offset = "0x569AC60", VA = "0x18569C060")]
			public ActionEvent(InputAction action)
			{
			}

			// Token: 0x06000B67 RID: 2919 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B67")]
			[Address(RVA = "0x569C2B0", Offset = "0x569AEB0", VA = "0x18569C2B0")]
			public ActionEvent(Guid actionGUID, [Optional] string name)
			{
			}

			// Token: 0x040004E7 RID: 1255
			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			private string m_ActionId;

			// Token: 0x040004E8 RID: 1256
			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[SerializeField]
			private string m_ActionName;
		}

		// Token: 0x020000D1 RID: 209
		[Token(Token = "0x20000D1")]
		[Serializable]
		public class DeviceLostEvent : UnityEvent<PlayerInput>
		{
			// Token: 0x06000B68 RID: 2920 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B68")]
			[Address(RVA = "0x569D580", Offset = "0x569C180", VA = "0x18569D580")]
			public DeviceLostEvent()
			{
			}
		}

		// Token: 0x020000D2 RID: 210
		[Token(Token = "0x20000D2")]
		[Serializable]
		public class DeviceRegainedEvent : UnityEvent<PlayerInput>
		{
			// Token: 0x06000B69 RID: 2921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B69")]
			[Address(RVA = "0x569D5C0", Offset = "0x569C1C0", VA = "0x18569D5C0")]
			public DeviceRegainedEvent()
			{
			}
		}

		// Token: 0x020000D3 RID: 211
		[Token(Token = "0x20000D3")]
		[Serializable]
		public class ControlsChangedEvent : UnityEvent<PlayerInput>
		{
			// Token: 0x06000B6A RID: 2922 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x569CA50", Offset = "0x569B650", VA = "0x18569CA50")]
			public ControlsChangedEvent()
			{
			}
		}
	}
}
