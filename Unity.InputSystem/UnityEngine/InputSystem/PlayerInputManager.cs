using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/PlayerInputManager.html")]
	[AddComponentMenu("Input/Player Input Manager")]
	public class PlayerInputManager : MonoBehaviour
	{
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x000059E8 File Offset: 0x00003BE8
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EF")]
		public bool splitScreen
		{
			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x56A8610", Offset = "0x56A7210", VA = "0x1856A8610")]
			set
			{
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x170002F0")]
		public bool maintainAspectRatioInSplitScreen
		{
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0x2419850", Offset = "0x2418450", VA = "0x182419850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x170002F1")]
		public int fixedNumberOfSplitScreens
		{
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0x32FB190", Offset = "0x32F9D90", VA = "0x1832FB190")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00005A30 File Offset: 0x00003C30
		[Token(Token = "0x170002F2")]
		public Rect splitScreenArea
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x157CDD0", Offset = "0x157B9D0", VA = "0x18157CDD0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00005A48 File Offset: 0x00003C48
		[Token(Token = "0x170002F3")]
		public int playerCount
		{
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x56A81C0", Offset = "0x56A6DC0", VA = "0x1856A81C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00005A60 File Offset: 0x00003C60
		[Token(Token = "0x170002F4")]
		public int maxPlayerCount
		{
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00005A78 File Offset: 0x00003C78
		[Token(Token = "0x170002F5")]
		public bool joiningEnabled
		{
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00005A90 File Offset: 0x00003C90
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F6")]
		public PlayerJoinBehavior joinBehavior
		{
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return PlayerJoinBehavior.JoinPlayersWhenButtonIsPressed;
			}
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x56A85C0", Offset = "0x56A71C0", VA = "0x1856A85C0")]
			set
			{
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00005AA8 File Offset: 0x00003CA8
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F7")]
		public InputActionProperty joinAction
		{
			[Token(Token = "0x6000B75")]
			[Address(RVA = "0x2739440", Offset = "0x2738040", VA = "0x182739440")]
			get
			{
				return default(InputActionProperty);
			}
			[Token(Token = "0x6000B76")]
			[Address(RVA = "0x56A8510", Offset = "0x56A7110", VA = "0x1856A8510")]
			set
			{
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00005AC0 File Offset: 0x00003CC0
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F8")]
		public PlayerNotifications notificationBehavior
		{
			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return PlayerNotifications.SendMessages;
			}
			[Token(Token = "0x6000B78")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F9")]
		public PlayerInputManager.PlayerJoinedEvent playerJoinedEvent
		{
			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x56A8210", Offset = "0x56A6E10", VA = "0x1856A8210")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002FA")]
		public PlayerInputManager.PlayerLeftEvent playerLeftEvent
		{
			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x56A82B0", Offset = "0x56A6EB0", VA = "0x1856A82B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000B7B RID: 2939 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B7C RID: 2940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001C")]
		public event Action<PlayerInput> onPlayerJoined
		{
			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0x56A7F10", Offset = "0x56A6B10", VA = "0x1856A7F10")]
			add
			{
			}
			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x56A8350", Offset = "0x56A6F50", VA = "0x1856A8350")]
			remove
			{
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000B7D RID: 2941 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B7E RID: 2942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001D")]
		public event Action<PlayerInput> onPlayerLeft
		{
			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0x56A7FC0", Offset = "0x56A6BC0", VA = "0x1856A7FC0")]
			add
			{
			}
			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0x56A8400", Offset = "0x56A7000", VA = "0x1856A8400")]
			remove
			{
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FB")]
		public GameObject playerPrefab
		{
			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B80")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			set
			{
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FC")]
		public static PlayerInputManager instance
		{
			[Token(Token = "0x6000B81")]
			[Address(RVA = "0x56A8070", Offset = "0x56A6C70", VA = "0x1856A8070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B82")]
			[Address(RVA = "0x56A84B0", Offset = "0x56A70B0", VA = "0x1856A84B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x56A6050", Offset = "0x56A4C50", VA = "0x1856A6050")]
		public void EnableJoining()
		{
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x56A5F60", Offset = "0x56A4B60", VA = "0x1856A5F60")]
		public void DisableJoining()
		{
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x56A6A50", Offset = "0x56A5650", VA = "0x1856A6A50")]
		internal void JoinPlayerFromUI()
		{
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x56A69E0", Offset = "0x56A55E0", VA = "0x1856A69E0")]
		public void JoinPlayerFromAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x56A6750", Offset = "0x56A5350", VA = "0x1856A6750")]
		public void JoinPlayerFromActionIfNotAlreadyJoined(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x56A6AC0", Offset = "0x56A56C0", VA = "0x1856A6AC0")]
		public PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, [Optional] string controlScheme, [Optional] InputDevice pairWithDevice)
		{
			return null;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x56A6CE0", Offset = "0x56A58E0", VA = "0x1856A6CE0")]
		public PlayerInput JoinPlayer(int playerIndex = -1, int splitScreenIndex = -1, [Optional] string controlScheme, params InputDevice[] pairWithDevices)
		{
			return null;
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002FD")]
		internal static string[] messages
		{
			[Token(Token = "0x6000B8A")]
			[Address(RVA = "0x56A80B0", Offset = "0x56A6CB0", VA = "0x1856A80B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x56A5C80", Offset = "0x56A4880", VA = "0x1856A5C80")]
		private bool CheckIfPlayerCanJoin(int playerIndex = -1)
		{
			return default(bool);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x56A76E0", Offset = "0x56A62E0", VA = "0x1856A76E0")]
		private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr eventPtr)
		{
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x56A7270", Offset = "0x56A5E70", VA = "0x1856A7270")]
		private void OnEnable()
		{
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x56A7190", Offset = "0x56A5D90", VA = "0x1856A7190")]
		private void OnDisable()
		{
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x56A77C0", Offset = "0x56A63C0", VA = "0x1856A77C0")]
		private void UpdateSplitScreen()
		{
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x56A6310", Offset = "0x56A4F10", VA = "0x1856A6310")]
		private bool IsDeviceUsableWithPlayerActions(InputDevice device)
		{
			return default(bool);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void ValidateInputActionAsset()
		{
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x56A6F30", Offset = "0x56A5B30", VA = "0x1856A6F30")]
		internal void NotifyPlayerJoined(PlayerInput player)
		{
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x56A7060", Offset = "0x56A5C60", VA = "0x1856A7060")]
		internal void NotifyPlayerLeft(PlayerInput player)
		{
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x56A7EA0", Offset = "0x56A6AA0", VA = "0x1856A7EA0")]
		public PlayerInputManager()
		{
		}

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		public const string PlayerJoinedMessage = "OnPlayerJoined";

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		public const string PlayerLeftMessage = "OnPlayerLeft";

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal PlayerNotifications m_NotificationBehavior;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Set a limit for the maximum number of players who are able to join.")]
		[SerializeField]
		internal int m_MaxPlayerCount;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal bool m_AllowJoining;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		internal PlayerJoinBehavior m_JoinBehavior;

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal PlayerInputManager.PlayerJoinedEvent m_PlayerJoinedEvent;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal PlayerInputManager.PlayerLeftEvent m_PlayerLeftEvent;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal InputActionProperty m_JoinAction;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		internal GameObject m_PlayerPrefab;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		internal bool m_SplitScreen;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		internal bool m_MaintainAspectRatioInSplitScreen;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Explicitly set a fixed number of screens or otherwise allow the screen to be divided automatically to best fit the number of players.")]
		[SerializeField]
		internal int m_FixedNumberOfSplitScreens;

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		internal Rect m_SplitScreenRect;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private bool m_JoinActionDelegateHooked;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[NonSerialized]
		private bool m_UnpairedDeviceUsedDelegateHooked;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private Action<InputAction.CallbackContext> m_JoinActionDelegate;

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private Action<InputControl, InputEventPtr> m_UnpairedDeviceUsedDelegate;

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private CallbackArray<Action<PlayerInput>> m_PlayerJoinedCallbacks;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		private CallbackArray<Action<PlayerInput>> m_PlayerLeftCallbacks;

		// Token: 0x020000D5 RID: 213
		[Token(Token = "0x20000D5")]
		[Serializable]
		public class PlayerJoinedEvent : UnityEvent<PlayerInput>
		{
			// Token: 0x06000B95 RID: 2965 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0x56AF600", Offset = "0x56AE200", VA = "0x1856AF600")]
			public PlayerJoinedEvent()
			{
			}
		}

		// Token: 0x020000D6 RID: 214
		[Token(Token = "0x20000D6")]
		[Serializable]
		public class PlayerLeftEvent : UnityEvent<PlayerInput>
		{
			// Token: 0x06000B96 RID: 2966 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B96")]
			[Address(RVA = "0x56AF640", Offset = "0x56AE240", VA = "0x1856AF640")]
			public PlayerLeftEvent()
			{
			}
		}
	}
}
