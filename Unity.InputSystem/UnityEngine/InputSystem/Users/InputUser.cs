using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Users
{
	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000101")]
	public struct InputUser : IEquatable<InputUser>
	{
		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00005FD0 File Offset: 0x000041D0
		[Token(Token = "0x1700033F")]
		public bool valid
		{
			[Token(Token = "0x6000C5F")]
			[Address(RVA = "0x56A4F60", Offset = "0x56A3B60", VA = "0x1856A4F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x00005FE8 File Offset: 0x000041E8
		[Token(Token = "0x17000340")]
		public int index
		{
			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x56A4A90", Offset = "0x56A3690", VA = "0x1856A4A90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x00006000 File Offset: 0x00004200
		[Token(Token = "0x17000341")]
		public uint id
		{
			[Token(Token = "0x6000C61")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x17000342")]
		public InputUserAccountHandle? platformUserAccountHandle
		{
			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x56A4DC0", Offset = "0x56A39C0", VA = "0x1856A4DC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000343")]
		public string platformUserAccountName
		{
			[Token(Token = "0x6000C63")]
			[Address(RVA = "0x56A4EE0", Offset = "0x56A3AE0", VA = "0x1856A4EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000344")]
		public string platformUserAccountId
		{
			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x56A4E60", Offset = "0x56A3A60", VA = "0x1856A4E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x17000345")]
		public ReadOnlyArray<InputDevice> pairedDevices
		{
			[Token(Token = "0x6000C65")]
			[Address(RVA = "0x56A4D00", Offset = "0x56A3900", VA = "0x1856A4D00")]
			get
			{
				return default(ReadOnlyArray<InputDevice>);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x17000346")]
		public ReadOnlyArray<InputDevice> lostDevices
		{
			[Token(Token = "0x6000C66")]
			[Address(RVA = "0x56A4C40", Offset = "0x56A3840", VA = "0x1856A4C40")]
			get
			{
				return default(ReadOnlyArray<InputDevice>);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000347")]
		public IInputActionCollection actions
		{
			[Token(Token = "0x6000C67")]
			[Address(RVA = "0x56A47D0", Offset = "0x56A33D0", VA = "0x1856A47D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x17000348")]
		public InputControlScheme? controlScheme
		{
			[Token(Token = "0x6000C68")]
			[Address(RVA = "0x56A4980", Offset = "0x56A3580", VA = "0x1856A4980")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x17000349")]
		public InputControlScheme.MatchResult controlSchemeMatch
		{
			[Token(Token = "0x6000C69")]
			[Address(RVA = "0x56A48C0", Offset = "0x56A34C0", VA = "0x1856A48C0")]
			get
			{
				return default(InputControlScheme.MatchResult);
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00006090 File Offset: 0x00004290
		[Token(Token = "0x1700034A")]
		public bool hasMissingRequiredDevices
		{
			[Token(Token = "0x6000C6A")]
			[Address(RVA = "0x56A4A10", Offset = "0x56A3610", VA = "0x1856A4A10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x1700034B")]
		public static ReadOnlyArray<InputUser> all
		{
			[Token(Token = "0x6000C6B")]
			[Address(RVA = "0x56A4850", Offset = "0x56A3450", VA = "0x1856A4850")]
			get
			{
				return default(ReadOnlyArray<InputUser>);
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000C6C RID: 3180 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000C6D RID: 3181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001E")]
		public static event Action<InputUser, InputUserChange, InputDevice> onChange
		{
			[Token(Token = "0x6000C6C")]
			[Address(RVA = "0x56A4590", Offset = "0x56A3190", VA = "0x1856A4590")]
			add
			{
			}
			[Token(Token = "0x6000C6D")]
			[Address(RVA = "0x56A4FF0", Offset = "0x56A3BF0", VA = "0x1856A4FF0")]
			remove
			{
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000C6E RID: 3182 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000C6F RID: 3183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400001F")]
		public static event Action<InputControl, InputEventPtr> onUnpairedDeviceUsed
		{
			[Token(Token = "0x6000C6E")]
			[Address(RVA = "0x56A46F0", Offset = "0x56A32F0", VA = "0x1856A46F0")]
			add
			{
			}
			[Token(Token = "0x6000C6F")]
			[Address(RVA = "0x56A5150", Offset = "0x56A3D50", VA = "0x1856A5150")]
			remove
			{
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000C70 RID: 3184 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000C71 RID: 3185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000020")]
		public static event Func<InputDevice, InputEventPtr, bool> onPrefilterUnpairedDeviceActivity
		{
			[Token(Token = "0x6000C70")]
			[Address(RVA = "0x56A4640", Offset = "0x56A3240", VA = "0x1856A4640")]
			add
			{
			}
			[Token(Token = "0x6000C71")]
			[Address(RVA = "0x56A50A0", Offset = "0x56A3CA0", VA = "0x1856A50A0")]
			remove
			{
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x000060C0 File Offset: 0x000042C0
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034C")]
		public static int listenForUnpairedDeviceActivity
		{
			[Token(Token = "0x6000C72")]
			[Address(RVA = "0x56A4C00", Offset = "0x56A3800", VA = "0x1856A4C00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x56A5240", Offset = "0x56A3E40", VA = "0x1856A5240")]
			set
			{
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x56A29B0", Offset = "0x56A15B0", VA = "0x1856A29B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x569F4F0", Offset = "0x569E0F0", VA = "0x18569F4F0")]
		public void AssociateActionsWithUser(IInputActionCollection actions)
		{
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x569EDD0", Offset = "0x569D9D0", VA = "0x18569EDD0")]
		public InputUser.ControlSchemeChangeSyntax ActivateControlScheme(string schemeName)
		{
			return default(InputUser.ControlSchemeChangeSyntax);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x000060F0 File Offset: 0x000042F0
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x56A2C70", Offset = "0x56A1870", VA = "0x1856A2C70")]
		private bool TryFindControlScheme(string schemeName, out InputControlScheme scheme)
		{
			return default(bool);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x569FAE0", Offset = "0x569E6E0", VA = "0x18569FAE0")]
		internal void FindControlScheme(string schemeName, out InputControlScheme scheme)
		{
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00006108 File Offset: 0x00004308
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x569EC10", Offset = "0x569D810", VA = "0x18569EC10")]
		public InputUser.ControlSchemeChangeSyntax ActivateControlScheme(InputControlScheme scheme)
		{
			return default(InputUser.ControlSchemeChangeSyntax);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x569E820", Offset = "0x569D420", VA = "0x18569E820")]
		private void ActivateControlSchemeInternal(int userIndex, InputControlScheme scheme)
		{
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x56A33D0", Offset = "0x56A1FD0", VA = "0x1856A33D0")]
		public void UnpairDevice(InputDevice device)
		{
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x56A34F0", Offset = "0x56A20F0", VA = "0x1856A34F0")]
		public void UnpairDevices()
		{
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x56A2160", Offset = "0x56A0D60", VA = "0x1856A2160")]
		private static void RemoveLostDevicesForUser(int userIndex)
		{
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x56A34C0", Offset = "0x56A20C0", VA = "0x1856A34C0")]
		public void UnpairDevicesAndRemoveUser()
		{
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x56A0200", Offset = "0x569EE00", VA = "0x1856A0200")]
		public static InputControlList<InputDevice> GetUnpairedInputDevices()
		{
			return default(InputControlList<InputDevice>);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x56A0030", Offset = "0x569EC30", VA = "0x1856A0030")]
		public static int GetUnpairedInputDevices(ref InputControlList<InputDevice> list)
		{
			return 0;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00006150 File Offset: 0x00004350
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x569FE80", Offset = "0x569EA80", VA = "0x18569FE80")]
		public static InputUser? FindUserPairedToDevice(InputDevice device)
		{
			return null;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00006168 File Offset: 0x00004368
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x569FC70", Offset = "0x569E870", VA = "0x18569FC70")]
		public static InputUser? FindUserByAccount(InputUserAccountHandle platformUserAccountHandle)
		{
			return null;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x569F950", Offset = "0x569E550", VA = "0x18569F950")]
		public static InputUser CreateUserWithoutPairedDevices()
		{
			return default(InputUser);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x56A1780", Offset = "0x56A0380", VA = "0x1856A1780")]
		public static InputUser PerformPairingWithDevice(InputDevice device, [Optional] InputUser user, InputUserPairingOptions options = InputUserPairingOptions.None)
		{
			return default(InputUser);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x000061B0 File Offset: 0x000043B0
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x56A06D0", Offset = "0x569F2D0", VA = "0x1856A06D0")]
		private static bool InitiateUserAccountSelection(int userIndex, InputDevice device, InputUserPairingOptions options)
		{
			return default(bool);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x000061C8 File Offset: 0x000043C8
		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(InputUser other)
		{
			return default(bool);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x569FA60", Offset = "0x569E660", VA = "0x18569FA60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(InputUser left, InputUser right)
		{
			return default(bool);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x263CB30", Offset = "0x263B730", VA = "0x18263CB30")]
		public static bool operator !=(InputUser left, InputUser right)
		{
			return default(bool);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00006240 File Offset: 0x00004440
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x569F350", Offset = "0x569DF50", VA = "0x18569F350")]
		private static int AddUser()
		{
			return 0;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x56A22D0", Offset = "0x56A0ED0", VA = "0x1856A22D0")]
		private static void RemoveUser(int userIndex)
		{
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x56A08E0", Offset = "0x569F4E0", VA = "0x1856A08E0")]
		private static void Notify(int userIndex, InputUserChange change, InputDevice device)
		{
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00006258 File Offset: 0x00004458
		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x56A2F60", Offset = "0x56A1B60", VA = "0x1856A2F60")]
		private static int TryFindUserIndex(uint userId)
		{
			return 0;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00006270 File Offset: 0x00004470
		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x56A30B0", Offset = "0x56A1CB0", VA = "0x1856A30B0")]
		private static int TryFindUserIndex(InputUserAccountHandle platformHandle)
		{
			return 0;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00006288 File Offset: 0x00004488
		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x56A2FE0", Offset = "0x56A1BE0", VA = "0x1856A2FE0")]
		private static int TryFindUserIndex(InputDevice device)
		{
			return 0;
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x569EE70", Offset = "0x569DA70", VA = "0x18569EE70")]
		private static void AddDeviceToUser(int userIndex, InputDevice device, bool asLostDevice = false, bool dontUpdateControlScheme = false)
		{
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x56A1BD0", Offset = "0x56A07D0", VA = "0x1856A1BD0")]
		private static void RemoveDeviceFromUser(int userIndex, InputDevice device, bool asLostDevice = false)
		{
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x56A3850", Offset = "0x56A2450", VA = "0x1856A3850")]
		private static void UpdateControlSchemeMatch(int userIndex, bool autoPairMissing = false)
		{
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x000062A0 File Offset: 0x000044A0
		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x56A4100", Offset = "0x56A2D00", VA = "0x1856A4100")]
		private static long UpdatePlatformUserAccount(int userIndex, InputDevice device)
		{
			return 0L;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x000062B8 File Offset: 0x000044B8
		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x56A1990", Offset = "0x56A0590", VA = "0x1856A1990")]
		private static long QueryPairedPlatformUserAccount(InputDevice device, out InputUserAccountHandle? platformAccountHandle, out string platformAccountName, out string platformAccountId)
		{
			return 0L;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x000062D0 File Offset: 0x000044D0
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x56A0610", Offset = "0x569F210", VA = "0x1856A0610")]
		private static bool InitiateUserAccountSelectionAtPlatformLevel(InputDevice device)
		{
			return default(bool);
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x56A0B30", Offset = "0x569F730", VA = "0x1856A0B30")]
		private static void OnActionChange(object obj, InputActionChange change)
		{
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x56A0C50", Offset = "0x569F850", VA = "0x1856A0C50")]
		private static void OnDeviceChange(InputDevice device, InputDeviceChange change)
		{
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x000062E8 File Offset: 0x000044E8
		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x569FBC0", Offset = "0x569E7C0", VA = "0x18569FBC0")]
		private static int FindLostDevice(InputDevice device, int startIndex = 0)
		{
			return 0;
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0x56A1300", Offset = "0x569FF00", VA = "0x1856A1300")]
		private static void OnEvent(InputEventPtr eventPtr, InputDevice device)
		{
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x56A2760", Offset = "0x56A1360", VA = "0x1856A2760")]
		internal static ISavedState SaveAndResetState()
		{
			return null;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x56A0260", Offset = "0x569EE60", VA = "0x1856A0260")]
		private static void HookIntoActionChange()
		{
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x56A31C0", Offset = "0x56A1DC0", VA = "0x1856A31C0")]
		private static void UnhookFromActionChange()
		{
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9E")]
		[Address(RVA = "0x56A03A0", Offset = "0x569EFA0", VA = "0x1856A03A0")]
		private static void HookIntoDeviceChange()
		{
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x56A3290", Offset = "0x56A1E90", VA = "0x1856A3290")]
		private static void UnhookFromDeviceChange()
		{
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x56A04D0", Offset = "0x569F0D0", VA = "0x1856A04D0")]
		private static void HookIntoEvents()
		{
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x56A3320", Offset = "0x56A1F20", VA = "0x1856A3320")]
		private static void UnhookFromDeviceStateChange()
		{
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x569F9B0", Offset = "0x569E5B0", VA = "0x18569F9B0")]
		private static void DisposeAndResetGlobalState()
		{
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x56A2690", Offset = "0x56A1290", VA = "0x1856A2690")]
		internal static void ResetGlobals()
		{
		}

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		public const uint InvalidId = 0U;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private uint m_Id;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InputUser.GlobalState s_GlobalState;

		// Token: 0x02000102 RID: 258
		[Token(Token = "0x2000102")]
		public struct ControlSchemeChangeSyntax
		{
			// Token: 0x06000CA4 RID: 3236 RVA: 0x00006300 File Offset: 0x00004500
			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x56B8EF0", Offset = "0x56B7AF0", VA = "0x1856B8EF0")]
			public InputUser.ControlSchemeChangeSyntax AndPairRemainingDevices()
			{
				return default(InputUser.ControlSchemeChangeSyntax);
			}

			// Token: 0x040005BC RID: 1468
			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int m_UserIndex;
		}

		// Token: 0x02000103 RID: 259
		[Token(Token = "0x2000103")]
		[Flags]
		internal enum UserFlags
		{
			// Token: 0x040005BE RID: 1470
			[Token(Token = "0x40005BE")]
			BindToAllDevices = 1,
			// Token: 0x040005BF RID: 1471
			[Token(Token = "0x40005BF")]
			UserAccountSelectionInProgress = 2
		}

		// Token: 0x02000104 RID: 260
		[Token(Token = "0x2000104")]
		private struct UserData
		{
			// Token: 0x040005C0 RID: 1472
			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputUserAccountHandle? platformUserAccountHandle;

			// Token: 0x040005C1 RID: 1473
			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string platformUserAccountName;

			// Token: 0x040005C2 RID: 1474
			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string platformUserAccountId;

			// Token: 0x040005C3 RID: 1475
			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int deviceCount;

			// Token: 0x040005C4 RID: 1476
			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int deviceStartIndex;

			// Token: 0x040005C5 RID: 1477
			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IInputActionCollection actions;

			// Token: 0x040005C6 RID: 1478
			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public InputControlScheme? controlScheme;

			// Token: 0x040005C7 RID: 1479
			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public InputControlScheme.MatchResult controlSchemeMatch;

			// Token: 0x040005C8 RID: 1480
			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public int lostDeviceCount;

			// Token: 0x040005C9 RID: 1481
			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			public int lostDeviceStartIndex;

			// Token: 0x040005CA RID: 1482
			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public InputUser.UserFlags flags;
		}

		// Token: 0x02000105 RID: 261
		[Token(Token = "0x2000105")]
		private struct CompareDevicesByUserAccount : IComparer<InputDevice>
		{
			// Token: 0x06000CA5 RID: 3237 RVA: 0x00006318 File Offset: 0x00004518
			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x56B8C50", Offset = "0x56B7850", VA = "0x1856B8C50", Slot = "4")]
			public int Compare(InputDevice x, InputDevice y)
			{
				return 0;
			}

			// Token: 0x06000CA6 RID: 3238 RVA: 0x00006330 File Offset: 0x00004530
			[Token(Token = "0x6000CA6")]
			[Address(RVA = "0x15A87A0", Offset = "0x15A73A0", VA = "0x1815A87A0")]
			private static InputUserAccountHandle? GetUserAccountHandleForDevice(InputDevice device)
			{
				return null;
			}

			// Token: 0x040005CB RID: 1483
			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputUserAccountHandle platformUserAccountHandle;
		}

		// Token: 0x02000106 RID: 262
		[Token(Token = "0x2000106")]
		private struct OngoingAccountSelection
		{
			// Token: 0x040005CC RID: 1484
			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputDevice device;

			// Token: 0x040005CD RID: 1485
			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint userId;
		}

		// Token: 0x02000107 RID: 263
		[Token(Token = "0x2000107")]
		private struct GlobalState
		{
			// Token: 0x040005CE RID: 1486
			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int pairingStateVersion;

			// Token: 0x040005CF RID: 1487
			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal uint lastUserId;

			// Token: 0x040005D0 RID: 1488
			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int allUserCount;

			// Token: 0x040005D1 RID: 1489
			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int allPairedDeviceCount;

			// Token: 0x040005D2 RID: 1490
			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int allLostDeviceCount;

			// Token: 0x040005D3 RID: 1491
			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal InputUser[] allUsers;

			// Token: 0x040005D4 RID: 1492
			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal InputUser.UserData[] allUserData;

			// Token: 0x040005D5 RID: 1493
			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal InputDevice[] allPairedDevices;

			// Token: 0x040005D6 RID: 1494
			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal InputDevice[] allLostDevices;

			// Token: 0x040005D7 RID: 1495
			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal InlinedArray<InputUser.OngoingAccountSelection> ongoingAccountSelections;

			// Token: 0x040005D8 RID: 1496
			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal CallbackArray<Action<InputUser, InputUserChange, InputDevice>> onChange;

			// Token: 0x040005D9 RID: 1497
			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal CallbackArray<Action<InputControl, InputEventPtr>> onUnpairedDeviceUsed;

			// Token: 0x040005DA RID: 1498
			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			internal CallbackArray<Func<InputDevice, InputEventPtr, bool>> onPreFilterUnpairedDeviceUsed;

			// Token: 0x040005DB RID: 1499
			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			internal Action<object, InputActionChange> actionChangeDelegate;

			// Token: 0x040005DC RID: 1500
			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			internal Action<InputDevice, InputDeviceChange> onDeviceChangeDelegate;

			// Token: 0x040005DD RID: 1501
			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			internal Action<InputEventPtr, InputDevice> onEventDelegate;

			// Token: 0x040005DE RID: 1502
			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			internal bool onActionChangeHooked;

			// Token: 0x040005DF RID: 1503
			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
			internal bool onDeviceChangeHooked;

			// Token: 0x040005E0 RID: 1504
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x162")]
			internal bool onEventHooked;

			// Token: 0x040005E1 RID: 1505
			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
			internal int listenForUnpairedDeviceActivity;
		}
	}
}
