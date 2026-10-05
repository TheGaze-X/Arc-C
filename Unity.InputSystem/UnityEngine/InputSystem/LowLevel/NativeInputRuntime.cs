using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x20001C8")]
	internal class NativeInputRuntime : IInputRuntime
	{
		// Token: 0x060010E3 RID: 4323 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x56F6750", Offset = "0x56F5350", VA = "0x1856F6750", Slot = "4")]
		public int AllocateDeviceId()
		{
			return 0;
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x56F6950", Offset = "0x56F5550", VA = "0x1856F6950", Slot = "5")]
		public void Update(InputUpdateType updateType)
		{
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x56F68F0", Offset = "0x56F54F0", VA = "0x1856F68F0", Slot = "6")]
		public unsafe void QueueEvent(InputEvent* ptr)
		{
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00008CE8 File Offset: 0x00006EE8
		[Token(Token = "0x60010E6")]
		[Address(RVA = "0x56F6790", Offset = "0x56F5390", VA = "0x1856F6790", Slot = "7")]
		public unsafe long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr)
		{
			return 0L;
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D5")]
		public InputUpdateDelegate onUpdate
		{
			[Token(Token = "0x60010E7")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010E8")]
			[Address(RVA = "0x56F70A0", Offset = "0x56F5CA0", VA = "0x1856F70A0", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D6")]
		public Action<InputUpdateType> onBeforeUpdate
		{
			[Token(Token = "0x60010E9")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010EA")]
			[Address(RVA = "0x56F6BF0", Offset = "0x56F57F0", VA = "0x1856F6BF0", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D7")]
		public Func<InputUpdateType, bool> onShouldRunUpdate
		{
			[Token(Token = "0x60010EB")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010EC")]
			[Address(RVA = "0x56F6E70", Offset = "0x56F5A70", VA = "0x1856F6E70", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D8")]
		public Action<int, string> onDeviceDiscovered
		{
			[Token(Token = "0x60010ED")]
			[Address(RVA = "0x56F6B30", Offset = "0x56F5730", VA = "0x1856F6B30", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010EE")]
			[Address(RVA = "0x56F6D40", Offset = "0x56F5940", VA = "0x1856F6D40", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D9")]
		public Action onShutdown
		{
			[Token(Token = "0x60010EF")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010F0")]
			[Address(RVA = "0x56F6FC0", Offset = "0x56F5BC0", VA = "0x1856F6FC0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004DA")]
		public Action<bool> onPlayerFocusChanged
		{
			[Token(Token = "0x60010F1")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010F2")]
			[Address(RVA = "0x56F6D90", Offset = "0x56F5990", VA = "0x1856F6D90", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x00008D00 File Offset: 0x00006F00
		[Token(Token = "0x170004DB")]
		public bool isPlayerFocused
		{
			[Token(Token = "0x60010F3")]
			[Address(RVA = "0x56F6B20", Offset = "0x56F5720", VA = "0x1856F6B20", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00008D18 File Offset: 0x00006F18
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004DC")]
		public float pollingFrequency
		{
			[Token(Token = "0x60010F4")]
			[Address(RVA = "0xFB13C0", Offset = "0xFAFFC0", VA = "0x180FB13C0", Slot = "21")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60010F5")]
			[Address(RVA = "0x56F71F0", Offset = "0x56F5DF0", VA = "0x1856F71F0", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00008D30 File Offset: 0x00006F30
		[Token(Token = "0x170004DD")]
		public double currentTime
		{
			[Token(Token = "0x60010F6")]
			[Address(RVA = "0x56F6AD0", Offset = "0x56F56D0", VA = "0x1856F6AD0", Slot = "23")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x00008D48 File Offset: 0x00006F48
		[Token(Token = "0x170004DE")]
		public double currentTimeForFixedUpdate
		{
			[Token(Token = "0x60010F7")]
			[Address(RVA = "0x56F6A30", Offset = "0x56F5630", VA = "0x1856F6A30", Slot = "24")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x170004DF")]
		public double currentTimeOffsetToRealtimeSinceStartup
		{
			[Token(Token = "0x60010F8")]
			[Address(RVA = "0x56F6A90", Offset = "0x56F5690", VA = "0x1856F6A90", Slot = "26")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x00008D78 File Offset: 0x00006F78
		[Token(Token = "0x170004E0")]
		public float unscaledGameTime
		{
			[Token(Token = "0x60010F9")]
			[Address(RVA = "0x56F6BE0", Offset = "0x56F57E0", VA = "0x1856F6BE0", Slot = "25")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x00008D90 File Offset: 0x00006F90
		// (set) Token: 0x060010FB RID: 4347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E1")]
		public bool runInBackground
		{
			[Token(Token = "0x60010FA")]
			[Address(RVA = "0x56F6B70", Offset = "0x56F5770", VA = "0x1856F6B70", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010FB")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0", Slot = "28")]
			set
			{
			}
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FC")]
		[Address(RVA = "0x11AB120", Offset = "0x11A9D20", VA = "0x1811AB120")]
		private void OnShutdown()
		{
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00008DA8 File Offset: 0x00006FA8
		[Token(Token = "0x60010FD")]
		[Address(RVA = "0x56F68B0", Offset = "0x56F54B0", VA = "0x1856F68B0")]
		private bool OnWantsToShutdown()
		{
			return default(bool);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FE")]
		[Address(RVA = "0x56F6880", Offset = "0x56F5480", VA = "0x1856F6880")]
		private void OnFocusChanged(bool focus)
		{
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x00008DC0 File Offset: 0x00006FC0
		[Token(Token = "0x170004E2")]
		public Vector2 screenSize
		{
			[Token(Token = "0x60010FF")]
			[Address(RVA = "0x56F6BA0", Offset = "0x56F57A0", VA = "0x1856F6BA0", Slot = "29")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00008DD8 File Offset: 0x00006FD8
		[Token(Token = "0x170004E3")]
		public ScreenOrientation screenOrientation
		{
			[Token(Token = "0x6001100")]
			[Address(RVA = "0x56F6B90", Offset = "0x56F5790", VA = "0x1856F6B90", Slot = "30")]
			get
			{
				return ScreenOrientation.Unknown;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[Token(Token = "0x170004E4")]
		public bool isInBatchMode
		{
			[Token(Token = "0x6001101")]
			[Address(RVA = "0x56F6B10", Offset = "0x56F5710", VA = "0x1856F6B10", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001102")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void RegisterAnalyticsEvent(string name, int maxPerHour, int maxPropertiesPerEvent)
		{
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001103")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void SendAnalyticsEvent(string name, object data)
		{
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001104")]
		[Address(RVA = "0x56F6A20", Offset = "0x56F5620", VA = "0x1856F6A20")]
		public NativeInputRuntime()
		{
		}

		// Token: 0x04000A23 RID: 2595
		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x0")]
		public static readonly NativeInputRuntime instance;

		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x10")]
		private bool m_RunInBackground;

		// Token: 0x04000A25 RID: 2597
		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x18")]
		private Action m_ShutdownMethod;

		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		[FieldOffset(Offset = "0x20")]
		private InputUpdateDelegate m_OnUpdate;

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x28")]
		private Action<InputUpdateType> m_OnBeforeUpdate;

		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		[FieldOffset(Offset = "0x30")]
		private Func<InputUpdateType, bool> m_OnShouldRunUpdate;

		// Token: 0x04000A29 RID: 2601
		[Token(Token = "0x4000A29")]
		[FieldOffset(Offset = "0x38")]
		private float m_PollingFrequency;

		// Token: 0x04000A2A RID: 2602
		[Token(Token = "0x4000A2A")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_DidCallOnShutdown;

		// Token: 0x04000A2B RID: 2603
		[Token(Token = "0x4000A2B")]
		[FieldOffset(Offset = "0x40")]
		private Action<bool> m_FocusChangedMethod;
	}
}
