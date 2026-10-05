using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	public sealed class InputRemoting : IObservable<InputRemoting.Message>, IObserver<InputRemoting.Message>
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00005070 File Offset: 0x00003270
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000275")]
		public bool sending
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0xF5B8E0", Offset = "0xF5A4E0", VA = "0x180F5B8E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x2861380", Offset = "0x285FF80", VA = "0x182861380")]
			private set
			{
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x5697380", Offset = "0x5695F80", VA = "0x185697380")]
		internal InputRemoting(InputManager manager, bool startSendingOnConnect = false)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x56969D0", Offset = "0x56955D0", VA = "0x1856969D0")]
		public void StartSending()
		{
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x5696BB0", Offset = "0x56957B0", VA = "0x185696BB0")]
		public void StopSending()
		{
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x5696E80", Offset = "0x5695A80", VA = "0x185696E80", Slot = "5")]
		private void OnNext(InputRemoting.Message msg)
		{
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		private void OnError(Exception error)
		{
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		private void OnCompleted()
		{
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x5696D80", Offset = "0x5695980", VA = "0x185696D80", Slot = "4")]
		public IDisposable Subscribe(IObserver<InputRemoting.Message> observer)
		{
			return null;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x5696690", Offset = "0x5695290", VA = "0x185696690")]
		private void SendInitialMessages()
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x5696210", Offset = "0x5694E10", VA = "0x185696210")]
		private void SendAllGeneratedLayouts()
		{
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x56967D0", Offset = "0x56953D0", VA = "0x1856967D0")]
		private void SendLayout(string layoutName)
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x5696010", Offset = "0x5694C10", VA = "0x185696010")]
		private void SendAllDevices()
		{
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x5696590", Offset = "0x5695190", VA = "0x185696590")]
		private void SendDevice(InputDevice device)
		{
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x5696620", Offset = "0x5695220", VA = "0x185696620")]
		private void SendEvent(InputEventPtr eventPtr, InputDevice device)
		{
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x5696410", Offset = "0x5695010", VA = "0x185696410")]
		private void SendDeviceChange(InputDevice device, InputDeviceChange change)
		{
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x56966B0", Offset = "0x56952B0", VA = "0x1856966B0")]
		private void SendLayoutChange(string layout, InputControlLayoutChange change)
		{
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x5696880", Offset = "0x5695480", VA = "0x185696880")]
		private void Send(InputRemoting.Message msg)
		{
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x5695DE0", Offset = "0x56949E0", VA = "0x185695DE0")]
		private int FindOrCreateSenderRecord(int senderId)
		{
			return 0;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x5695CF0", Offset = "0x56948F0", VA = "0x185695CF0")]
		private static InternedString BuildLayoutNamespace(int senderId)
		{
			return default(InternedString);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x5695D70", Offset = "0x5694970", VA = "0x185695D70")]
		private int FindLocalDeviceId(int remoteDeviceId, int senderIndex)
		{
			return 0;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x56972F0", Offset = "0x5695EF0", VA = "0x1856972F0")]
		private InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex)
		{
			return null;
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000276")]
		internal InputManager manager
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x5695E90", Offset = "0x5694A90", VA = "0x185695E90")]
		public void RemoveRemoteDevices(int participantId)
		{
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600095B")]
		private static byte[] SerializeData<TData>(TData data)
		{
			return null;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600095C")]
		private static TData DeserializeData<TData>(byte[] data)
		{
			return null;
		}

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x10")]
		private InputRemoting.Flags m_Flags;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x18")]
		private InputManager m_LocalManager;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x20")]
		private InputRemoting.Subscriber[] m_Subscribers;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x28")]
		private InputRemoting.RemoteSender[] m_Senders;

		// Token: 0x02000094 RID: 148
		[Token(Token = "0x2000094")]
		public enum MessageType
		{
			// Token: 0x040003D6 RID: 982
			[Token(Token = "0x40003D6")]
			Connect,
			// Token: 0x040003D7 RID: 983
			[Token(Token = "0x40003D7")]
			Disconnect,
			// Token: 0x040003D8 RID: 984
			[Token(Token = "0x40003D8")]
			NewLayout,
			// Token: 0x040003D9 RID: 985
			[Token(Token = "0x40003D9")]
			NewDevice,
			// Token: 0x040003DA RID: 986
			[Token(Token = "0x40003DA")]
			NewEvents,
			// Token: 0x040003DB RID: 987
			[Token(Token = "0x40003DB")]
			RemoveDevice,
			// Token: 0x040003DC RID: 988
			[Token(Token = "0x40003DC")]
			RemoveLayout,
			// Token: 0x040003DD RID: 989
			[Token(Token = "0x40003DD")]
			ChangeUsages,
			// Token: 0x040003DE RID: 990
			[Token(Token = "0x40003DE")]
			StartSending,
			// Token: 0x040003DF RID: 991
			[Token(Token = "0x40003DF")]
			StopSending
		}

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x2000095")]
		public struct Message
		{
			// Token: 0x040003E0 RID: 992
			[Token(Token = "0x40003E0")]
			[FieldOffset(Offset = "0x0")]
			public int participantId;

			// Token: 0x040003E1 RID: 993
			[Token(Token = "0x40003E1")]
			[FieldOffset(Offset = "0x4")]
			public InputRemoting.MessageType type;

			// Token: 0x040003E2 RID: 994
			[Token(Token = "0x40003E2")]
			[FieldOffset(Offset = "0x8")]
			public byte[] data;
		}

		// Token: 0x02000096 RID: 150
		[Token(Token = "0x2000096")]
		[Flags]
		private enum Flags
		{
			// Token: 0x040003E4 RID: 996
			[Token(Token = "0x40003E4")]
			Sending = 1,
			// Token: 0x040003E5 RID: 997
			[Token(Token = "0x40003E5")]
			StartSendingOnConnect = 2
		}

		// Token: 0x02000097 RID: 151
		[Token(Token = "0x2000097")]
		[Serializable]
		internal struct RemoteSender
		{
			// Token: 0x040003E6 RID: 998
			[Token(Token = "0x40003E6")]
			[FieldOffset(Offset = "0x0")]
			public int senderId;

			// Token: 0x040003E7 RID: 999
			[Token(Token = "0x40003E7")]
			[FieldOffset(Offset = "0x8")]
			public InternedString[] layouts;

			// Token: 0x040003E8 RID: 1000
			[Token(Token = "0x40003E8")]
			[FieldOffset(Offset = "0x10")]
			public InputRemoting.RemoteInputDevice[] devices;
		}

		// Token: 0x02000098 RID: 152
		[Token(Token = "0x2000098")]
		[Serializable]
		internal struct RemoteInputDevice
		{
			// Token: 0x040003E9 RID: 1001
			[Token(Token = "0x40003E9")]
			[FieldOffset(Offset = "0x0")]
			public int remoteId;

			// Token: 0x040003EA RID: 1002
			[Token(Token = "0x40003EA")]
			[FieldOffset(Offset = "0x4")]
			public int localId;

			// Token: 0x040003EB RID: 1003
			[Token(Token = "0x40003EB")]
			[FieldOffset(Offset = "0x8")]
			public InputDeviceDescription description;
		}

		// Token: 0x02000099 RID: 153
		[Token(Token = "0x2000099")]
		internal class Subscriber : IDisposable
		{
			// Token: 0x0600095D RID: 2397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x569A250", Offset = "0x5698E50", VA = "0x18569A250", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0600095E RID: 2398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Subscriber()
			{
			}

			// Token: 0x040003EC RID: 1004
			[Token(Token = "0x40003EC")]
			[FieldOffset(Offset = "0x10")]
			public InputRemoting owner;

			// Token: 0x040003ED RID: 1005
			[Token(Token = "0x40003ED")]
			[FieldOffset(Offset = "0x18")]
			public IObserver<InputRemoting.Message> observer;
		}

		// Token: 0x0200009A RID: 154
		[Token(Token = "0x200009A")]
		private static class ConnectMsg
		{
			// Token: 0x0600095F RID: 2399 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x5681CA0", Offset = "0x56808A0", VA = "0x185681CA0")]
			public static void Process(InputRemoting receiver)
			{
			}
		}

		// Token: 0x0200009B RID: 155
		[Token(Token = "0x200009B")]
		private static class StartSendingMsg
		{
			// Token: 0x06000960 RID: 2400 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x5699FC0", Offset = "0x5698BC0", VA = "0x185699FC0")]
			public static void Process(InputRemoting receiver)
			{
			}
		}

		// Token: 0x0200009C RID: 156
		[Token(Token = "0x200009C")]
		private static class StopSendingMsg
		{
			// Token: 0x06000961 RID: 2401 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x569A1E0", Offset = "0x5698DE0", VA = "0x18569A1E0")]
			public static void Process(InputRemoting receiver)
			{
			}
		}

		// Token: 0x0200009D RID: 157
		[Token(Token = "0x200009D")]
		private static class DisconnectMsg
		{
			// Token: 0x06000962 RID: 2402 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x5681CF0", Offset = "0x56808F0", VA = "0x185681CF0")]
			public static void Process(InputRemoting receiver, InputRemoting.Message msg)
			{
			}
		}

		// Token: 0x0200009E RID: 158
		[Token(Token = "0x200009E")]
		private static class NewLayoutMsg
		{
			// Token: 0x06000963 RID: 2403 RVA: 0x000050D0 File Offset: 0x000032D0
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x5698720", Offset = "0x5697320", VA = "0x185698720")]
			public static InputRemoting.Message? Create(InputRemoting sender, string layoutName)
			{
				return null;
			}

			// Token: 0x06000964 RID: 2404 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x56989A0", Offset = "0x56975A0", VA = "0x1856989A0")]
			public static void Process(InputRemoting receiver, InputRemoting.Message msg)
			{
			}

			// Token: 0x0200009F RID: 159
			[Token(Token = "0x200009F")]
			[Serializable]
			public struct Data
			{
				// Token: 0x040003EE RID: 1006
				[Token(Token = "0x40003EE")]
				[FieldOffset(Offset = "0x0")]
				public string name;

				// Token: 0x040003EF RID: 1007
				[Token(Token = "0x40003EF")]
				[FieldOffset(Offset = "0x8")]
				public string layoutJson;

				// Token: 0x040003F0 RID: 1008
				[Token(Token = "0x40003F0")]
				[FieldOffset(Offset = "0x10")]
				public bool isOverride;
			}
		}

		// Token: 0x020000A0 RID: 160
		[Token(Token = "0x20000A0")]
		private static class NewDeviceMsg
		{
			// Token: 0x06000965 RID: 2405 RVA: 0x000050E8 File Offset: 0x000032E8
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x5697A20", Offset = "0x5696620", VA = "0x185697A20")]
			public static InputRemoting.Message Create(InputDevice device)
			{
				return default(InputRemoting.Message);
			}

			// Token: 0x06000966 RID: 2406 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x5697CF0", Offset = "0x56968F0", VA = "0x185697CF0")]
			public static void Process(InputRemoting receiver, InputRemoting.Message msg)
			{
			}

			// Token: 0x020000A1 RID: 161
			[Token(Token = "0x20000A1")]
			[Serializable]
			public struct Data
			{
				// Token: 0x040003F1 RID: 1009
				[Token(Token = "0x40003F1")]
				[FieldOffset(Offset = "0x0")]
				public string name;

				// Token: 0x040003F2 RID: 1010
				[Token(Token = "0x40003F2")]
				[FieldOffset(Offset = "0x8")]
				public string layout;

				// Token: 0x040003F3 RID: 1011
				[Token(Token = "0x40003F3")]
				[FieldOffset(Offset = "0x10")]
				public int deviceId;

				// Token: 0x040003F4 RID: 1012
				[Token(Token = "0x40003F4")]
				[FieldOffset(Offset = "0x18")]
				public string[] usages;

				// Token: 0x040003F5 RID: 1013
				[Token(Token = "0x40003F5")]
				[FieldOffset(Offset = "0x20")]
				public InputDeviceDescription description;
			}
		}

		// Token: 0x020000A3 RID: 163
		[Token(Token = "0x20000A3")]
		private static class NewEventsMsg
		{
			// Token: 0x0600096A RID: 2410 RVA: 0x00005100 File Offset: 0x00003300
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x5698380", Offset = "0x5696F80", VA = "0x185698380")]
			public static InputRemoting.Message CreateResetEvent(InputDevice device, bool isHardReset)
			{
				return default(InputRemoting.Message);
			}

			// Token: 0x0600096B RID: 2411 RVA: 0x00005118 File Offset: 0x00003318
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x56983F0", Offset = "0x5696FF0", VA = "0x1856983F0")]
			public static InputRemoting.Message CreateStateEvent(InputDevice device)
			{
				return default(InputRemoting.Message);
			}

			// Token: 0x0600096C RID: 2412 RVA: 0x00005130 File Offset: 0x00003330
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x56984E0", Offset = "0x56970E0", VA = "0x1856984E0")]
			public unsafe static InputRemoting.Message Create(InputEvent* events, int eventCount)
			{
				return default(InputRemoting.Message);
			}

			// Token: 0x0600096D RID: 2413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x56985D0", Offset = "0x56971D0", VA = "0x1856985D0")]
			public static void Process(InputRemoting receiver, InputRemoting.Message msg)
			{
			}
		}

		// Token: 0x020000A4 RID: 164
		[Token(Token = "0x20000A4")]
		private static class ChangeUsageMsg
		{
			// Token: 0x0600096E RID: 2414 RVA: 0x00005148 File Offset: 0x00003348
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x5681720", Offset = "0x5680320", VA = "0x185681720")]
			public static InputRemoting.Message Create(InputDevice device)
			{
				return default(InputRemoting.Message);
			}

			// Token: 0x0600096F RID: 2415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x5681930", Offset = "0x5680530", VA = "0x185681930")]
			public static void Process(InputRemoting receiver, InputRemoting.Message msg)
			{
			}

			// Token: 0x020000A5 RID: 165
			[Token(Token = "0x20000A5")]
			[Serializable]
			public struct Data
			{
				// Token: 0x040003F8 RID: 1016
				[Token(Token = "0x40003F8")]
				[FieldOffset(Offset = "0x0")]
				public int deviceId;

				// Token: 0x040003F9 RID: 1017
				[Token(Token = "0x40003F9")]
				[FieldOffset(Offset = "0x8")]
				public string[] usages;
			}
		}

		// Token: 0x020000A7 RID: 167
		[Token(Token = "0x20000A7")]
		private static class RemoveDeviceMsg
		{
			// Token: 0x06000973 RID: 2419 RVA: 0x00005160 File Offset: 0x00003360
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x5699D30", Offset = "0x5698930", VA = "0x185699D30")]
			public static InputRemoting.Message Create(InputDevice device)
			{
				return default(InputRemoting.Message);
			}

			// Token: 0x06000974 RID: 2420 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x5699DC0", Offset = "0x56989C0", VA = "0x185699DC0")]
			public static void Process(InputRemoting receiver, InputRemoting.Message msg)
			{
			}
		}
	}
}
