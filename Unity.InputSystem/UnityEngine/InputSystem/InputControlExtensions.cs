using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public static class InputControlExtensions
	{
		// Token: 0x06000550 RID: 1360 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000550")]
		public static TControl FindInParentChain<TControl>(this InputControl control) where TControl : InputControl
		{
			return null;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x5620420", Offset = "0x561F020", VA = "0x185620420")]
		public static bool IsPressed(this InputControl control, float buttonPressPoint = 0f)
		{
			return default(bool);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x5620240", Offset = "0x561EE40", VA = "0x185620240")]
		public static bool IsActuated(this InputControl control, float threshold = 0f)
		{
			return default(bool);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x5620610", Offset = "0x561F210", VA = "0x185620610")]
		public static object ReadValueAsObject(this InputControl control)
		{
			return null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x56207A0", Offset = "0x561F3A0", VA = "0x1856207A0")]
		public unsafe static void ReadValueIntoBuffer(this InputControl control, void* buffer, int bufferSize)
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x5620540", Offset = "0x561F140", VA = "0x185620540")]
		public static object ReadDefaultValueAsObject(this InputControl control)
		{
			return null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000556")]
		public static TValue ReadValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent) where TValue : struct
		{
			return null;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x6000557")]
		public static bool ReadValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) where TValue : struct
		{
			return default(bool);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x56206C0", Offset = "0x561F2C0", VA = "0x1856206C0")]
		public static object ReadValueFromEventAsObject(this InputControl control, InputEventPtr inputEvent)
		{
			return null;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000559")]
		public static TValue ReadUnprocessedValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr eventPtr) where TValue : struct
		{
			return null;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x600055A")]
		public static bool ReadUnprocessedValueFromEvent<TValue>(this InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) where TValue : struct
		{
			return default(bool);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x5620EA0", Offset = "0x561FAA0", VA = "0x185620EA0")]
		public static void WriteValueFromObjectIntoEvent(this InputControl control, InputEventPtr eventPtr, object value)
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x5620F60", Offset = "0x561FB60", VA = "0x185620F60")]
		public unsafe static void WriteValueIntoState(this InputControl control, void* statePtr)
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055D")]
		public unsafe static void WriteValueIntoState<TValue>(this InputControl control, TValue value, void* statePtr) where TValue : struct
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055E")]
		public unsafe static void WriteValueIntoState<TValue>(this InputControl<TValue> control, TValue value, void* statePtr) where TValue : struct
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055F")]
		public unsafe static void WriteValueIntoState<TValue>(this InputControl<TValue> control, void* statePtr) where TValue : struct
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000560")]
		public static void WriteValueIntoState<TValue, TState>(this InputControl<TValue> control, TValue value, ref TState state) where TValue : struct where TState : struct, IInputStateTypeInfo
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000561")]
		public static void WriteValueIntoEvent<TValue>(this InputControl control, TValue value, InputEventPtr eventPtr) where TValue : struct
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000562")]
		public static void WriteValueIntoEvent<TValue>(this InputControl<TValue> control, TValue value, InputEventPtr eventPtr) where TValue : struct
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x561F4B0", Offset = "0x561E0B0", VA = "0x18561F4B0")]
		public unsafe static void CopyState(this InputDevice device, void* buffer, int bufferSizeInBytes)
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000564")]
		public static void CopyState<TState>(this InputDevice device, out TState state) where TState : struct, IInputStateTypeInfo
		{
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x561EFE0", Offset = "0x561DBE0", VA = "0x18561EFE0")]
		public static bool CheckStateIsAtDefault(this InputControl control)
		{
			return default(bool);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x561EEC0", Offset = "0x561DAC0", VA = "0x18561EEC0")]
		public unsafe static bool CheckStateIsAtDefault(this InputControl control, void* statePtr, [Optional] void* maskPtr)
		{
			return default(bool);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x561EC10", Offset = "0x561D810", VA = "0x18561EC10")]
		public static bool CheckStateIsAtDefaultIgnoringNoise(this InputControl control)
		{
			return default(bool);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x561ED70", Offset = "0x561D970", VA = "0x18561ED70")]
		public unsafe static bool CheckStateIsAtDefaultIgnoringNoise(this InputControl control, void* statePtr)
		{
			return default(bool);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x561F100", Offset = "0x561DD00", VA = "0x18561F100")]
		public unsafe static bool CompareStateIgnoringNoise(this InputControl control, void* statePtr)
		{
			return default(bool);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x561F340", Offset = "0x561DF40", VA = "0x18561F340")]
		public unsafe static bool CompareState(this InputControl control, void* firstStatePtr, void* secondStatePtr, [Optional] void* maskPtr)
		{
			return default(bool);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x561F230", Offset = "0x561DE30", VA = "0x18561F230")]
		public unsafe static bool CompareState(this InputControl control, void* statePtr, [Optional] void* maskPtr)
		{
			return default(bool);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x5620150", Offset = "0x561ED50", VA = "0x185620150")]
		public unsafe static bool HasValueChangeInState(this InputControl control, void* statePtr)
		{
			return default(bool);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x5620020", Offset = "0x561EC20", VA = "0x185620020")]
		public static bool HasValueChangeInEvent(this InputControl control, InputEventPtr eventPtr)
		{
			return default(bool);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x561FF00", Offset = "0x561EB00", VA = "0x18561FF00")]
		public unsafe static void* GetStatePtrFromStateEvent(this InputControl control, InputEventPtr eventPtr)
		{
			return null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x561FC50", Offset = "0x561E850", VA = "0x18561FC50")]
		internal unsafe static void* GetStatePtrFromStateEventUnchecked(this InputControl control, InputEventPtr eventPtr, FourCC eventType)
		{
			return null;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x56208A0", Offset = "0x561F4A0", VA = "0x1856208A0")]
		public static bool ResetToDefaultStateInEvent(this InputControl control, InputEventPtr eventPtr)
		{
			return default(bool);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000571")]
		public static void QueueValueChange<TValue>(this InputControl<TValue> control, TValue value, double time = -1.0) where TValue : struct
		{
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x561E620", Offset = "0x561D220", VA = "0x18561E620")]
		public unsafe static void AccumulateValueInEvent(this InputControl<float> control, void* currentStatePtr, InputEventPtr newState)
		{
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x561E730", Offset = "0x561D330", VA = "0x18561E730")]
		internal unsafe static void AccumulateValueInEvent(this InputControl<Vector2> control, void* currentStatePtr, InputEventPtr newState)
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000574")]
		public static void FindControlsRecursive<TControl>(this InputControl parent, IList<TControl> controls, Func<TControl, bool> predicate) where TControl : InputControl
		{
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x561E860", Offset = "0x561D460", VA = "0x18561E860")]
		internal static string BuildPath(this InputControl control, string deviceLayout, [Optional] StringBuilder builder)
		{
			return null;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x561F6A0", Offset = "0x561E2A0", VA = "0x18561F6A0")]
		public static InputControlExtensions.InputEventControlCollection EnumerateControls(this InputEventPtr eventPtr, InputControlExtensions.Enumerate flags, [Optional] InputDevice device, float magnitudeThreshold = 0f)
		{
			return default(InputControlExtensions.InputEventControlCollection);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x561F650", Offset = "0x561E250", VA = "0x18561F650")]
		public static InputControlExtensions.InputEventControlCollection EnumerateChangedControls(this InputEventPtr eventPtr, [Optional] InputDevice device, float magnitudeThreshold = 0f)
		{
			return default(InputControlExtensions.InputEventControlCollection);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x5620000", Offset = "0x561EC00", VA = "0x185620000")]
		public static bool HasButtonPress(this InputEventPtr eventPtr, float magnitude = -1f, bool buttonControlsOnly = true)
		{
			return default(bool);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x561FA10", Offset = "0x561E610", VA = "0x18561FA10")]
		public static InputControl GetFirstButtonPressOrNull(this InputEventPtr eventPtr, float magnitude = -1f, bool buttonControlsOnly = true)
		{
			return null;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x561F970", Offset = "0x561E570", VA = "0x18561F970")]
		public static IEnumerable<InputControl> GetAllButtonPresses(this InputEventPtr eventPtr, float magnitude = -1f, bool buttonControlsOnly = true)
		{
			return null;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x5620DA0", Offset = "0x561F9A0", VA = "0x185620DA0")]
		public static InputControlExtensions.ControlBuilder Setup(this InputControl control)
		{
			return default(InputControlExtensions.ControlBuilder);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x5620AB0", Offset = "0x561F6B0", VA = "0x185620AB0")]
		public static InputControlExtensions.DeviceBuilder Setup(this InputDevice device, int controlCount, int usageCount, int aliasCount)
		{
			return default(InputControlExtensions.DeviceBuilder);
		}

		// Token: 0x02000070 RID: 112
		[Token(Token = "0x2000070")]
		[Flags]
		public enum Enumerate
		{
			// Token: 0x04000284 RID: 644
			[Token(Token = "0x4000284")]
			IgnoreControlsInDefaultState = 1,
			// Token: 0x04000285 RID: 645
			[Token(Token = "0x4000285")]
			IgnoreControlsInCurrentState = 2,
			// Token: 0x04000286 RID: 646
			[Token(Token = "0x4000286")]
			IncludeSyntheticControls = 4,
			// Token: 0x04000287 RID: 647
			[Token(Token = "0x4000287")]
			IncludeNoisyControls = 8,
			// Token: 0x04000288 RID: 648
			[Token(Token = "0x4000288")]
			IncludeNonLeafControls = 16
		}

		// Token: 0x02000071 RID: 113
		[Token(Token = "0x2000071")]
		public struct InputEventControlCollection : IEnumerable<InputControl>, IEnumerable
		{
			// Token: 0x17000190 RID: 400
			// (get) Token: 0x0600057D RID: 1405 RVA: 0x000046F8 File Offset: 0x000028F8
			[Token(Token = "0x17000190")]
			public InputEventPtr eventPtr
			{
				[Token(Token = "0x600057D")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
				get
				{
					return default(InputEventPtr);
				}
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x00004710 File Offset: 0x00002910
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x5627F10", Offset = "0x5626B10", VA = "0x185627F10")]
			public InputControlExtensions.InputEventControlEnumerator GetEnumerator()
			{
				return default(InputControlExtensions.InputEventControlEnumerator);
			}

			// Token: 0x0600057F RID: 1407 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x5627F70", Offset = "0x5626B70", VA = "0x185627F70", Slot = "4")]
			private IEnumerator<InputControl> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000580 RID: 1408 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x5628070", Offset = "0x5626C70", VA = "0x185628070", Slot = "5")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000289 RID: 649
			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal InputDevice m_Device;

			// Token: 0x0400028A RID: 650
			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal InputEventPtr m_EventPtr;

			// Token: 0x0400028B RID: 651
			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal InputControlExtensions.Enumerate m_Flags;

			// Token: 0x0400028C RID: 652
			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal float m_MagnitudeThreshold;
		}

		// Token: 0x02000072 RID: 114
		[Token(Token = "0x2000072")]
		public struct InputEventControlEnumerator : IEnumerator<InputControl>, IEnumerator, IDisposable
		{
			// Token: 0x06000581 RID: 1409 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x5628AC0", Offset = "0x56276C0", VA = "0x185628AC0")]
			internal InputEventControlEnumerator(InputEventPtr eventPtr, InputDevice device, InputControlExtensions.Enumerate flags, float magnitudeThreshold = 0f)
			{
			}

			// Token: 0x06000582 RID: 1410 RVA: 0x00004728 File Offset: 0x00002928
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x56281A0", Offset = "0x5626DA0", VA = "0x1856281A0")]
			private bool CheckDefault(uint numBits)
			{
				return default(bool);
			}

			// Token: 0x06000583 RID: 1411 RVA: 0x00004740 File Offset: 0x00002940
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x5628170", Offset = "0x5626D70", VA = "0x185628170")]
			private bool CheckCurrent(uint numBits)
			{
				return default(bool);
			}

			// Token: 0x06000584 RID: 1412 RVA: 0x00004758 File Offset: 0x00002958
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x56281E0", Offset = "0x5626DE0", VA = "0x1856281E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000585 RID: 1413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x5628660", Offset = "0x5627260", VA = "0x185628660", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x06000586 RID: 1414 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x56281D0", Offset = "0x5626DD0", VA = "0x1856281D0", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x06000587 RID: 1415 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000191")]
			public InputControl Current
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x06000588 RID: 1416 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000192")]
			private object Current
			{
				[Token(Token = "0x6000588")]
				[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400028D RID: 653
			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private InputControlExtensions.Enumerate m_Flags;

			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly InputDevice m_Device;

			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly uint[] m_StateOffsetToControlIndex;

			// Token: 0x04000290 RID: 656
			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int m_StateOffsetToControlIndexLength;

			// Token: 0x04000291 RID: 657
			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly InputControl[] m_AllControls;

			// Token: 0x04000292 RID: 658
			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private unsafe byte* m_DefaultState;

			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private unsafe byte* m_CurrentState;

			// Token: 0x04000294 RID: 660
			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private unsafe byte* m_NoiseMask;

			// Token: 0x04000295 RID: 661
			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private InputEventPtr m_EventPtr;

			// Token: 0x04000296 RID: 662
			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private InputControl m_CurrentControl;

			// Token: 0x04000297 RID: 663
			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int m_CurrentIndexInStateOffsetToControlIndexMap;

			// Token: 0x04000298 RID: 664
			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private uint m_CurrentControlStateBitOffset;

			// Token: 0x04000299 RID: 665
			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private unsafe byte* m_EventState;

			// Token: 0x0400029A RID: 666
			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private uint m_CurrentBitOffset;

			// Token: 0x0400029B RID: 667
			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private uint m_EndBitOffset;

			// Token: 0x0400029C RID: 668
			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private float m_MagnitudeThreshold;
		}

		// Token: 0x02000073 RID: 115
		[Token(Token = "0x2000073")]
		public struct ControlBuilder
		{
			// Token: 0x17000193 RID: 403
			// (get) Token: 0x06000589 RID: 1417 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600058A RID: 1418 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000193")]
			public InputControl control
			{
				[Token(Token = "0x6000589")]
				[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x600058A")]
				[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x0600058B RID: 1419 RVA: 0x00004770 File Offset: 0x00002970
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x561A530", Offset = "0x5619130", VA = "0x18561A530")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder At(InputDevice device, int index)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x0600058C RID: 1420 RVA: 0x00004788 File Offset: 0x00002988
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x561A910", Offset = "0x5619510", VA = "0x18561A910")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder WithParent(InputControl parent)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x0600058D RID: 1421 RVA: 0x000047A0 File Offset: 0x000029A0
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x561A8B0", Offset = "0x56194B0", VA = "0x18561A8B0")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder WithName(string name)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x0600058E RID: 1422 RVA: 0x000047B8 File Offset: 0x000029B8
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x561A7C0", Offset = "0x56193C0", VA = "0x18561A7C0")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder WithDisplayName(string displayName)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x0600058F RID: 1423 RVA: 0x000047D0 File Offset: 0x000029D0
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x561A940", Offset = "0x5619540", VA = "0x18561A940")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder WithShortDisplayName(string shortDisplayName)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x06000590 RID: 1424 RVA: 0x000047E8 File Offset: 0x000029E8
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x561A830", Offset = "0x5619430", VA = "0x18561A830")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder WithLayout(InternedString layout)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x06000591 RID: 1425 RVA: 0x00004800 File Offset: 0x00002A00
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x561A9E0", Offset = "0x56195E0", VA = "0x18561A9E0")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder WithUsages(int startIndex, int count)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x06000592 RID: 1426 RVA: 0x00004818 File Offset: 0x00002A18
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x561A720", Offset = "0x5619320", VA = "0x18561A720")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder WithAliases(int startIndex, int count)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x06000593 RID: 1427 RVA: 0x00004830 File Offset: 0x00002A30
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x561A750", Offset = "0x5619350", VA = "0x18561A750")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder WithChildren(int startIndex, int count)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x06000594 RID: 1428 RVA: 0x00004848 File Offset: 0x00002A48
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x561A9B0", Offset = "0x56195B0", VA = "0x18561A9B0")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder WithStateBlock(InputStateBlock stateBlock)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x06000595 RID: 1429 RVA: 0x00004860 File Offset: 0x00002A60
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x561A780", Offset = "0x5619380", VA = "0x18561A780")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder WithDefaultState(PrimitiveValue value)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x06000596 RID: 1430 RVA: 0x00004878 File Offset: 0x00002A78
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x561A870", Offset = "0x5619470", VA = "0x18561A870")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder WithMinAndMax(PrimitiveValue min, PrimitiveValue max)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x06000597 RID: 1431 RVA: 0x00004890 File Offset: 0x00002A90
			[Token(Token = "0x6000597")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder WithProcessor<TProcessor, TValue>(TProcessor processor) where TProcessor : InputProcessor<TValue> where TValue : struct
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x06000598 RID: 1432 RVA: 0x000048A8 File Offset: 0x00002AA8
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x561A6B0", Offset = "0x56192B0", VA = "0x18561A6B0")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder IsNoisy(bool value)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x06000599 RID: 1433 RVA: 0x000048C0 File Offset: 0x00002AC0
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x561A6E0", Offset = "0x56192E0", VA = "0x18561A6E0")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder IsSynthetic(bool value)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x0600059A RID: 1434 RVA: 0x000048D8 File Offset: 0x00002AD8
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x561A5F0", Offset = "0x56191F0", VA = "0x18561A5F0")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder DontReset(bool value)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x0600059B RID: 1435 RVA: 0x000048F0 File Offset: 0x00002AF0
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x561A670", Offset = "0x5619270", VA = "0x18561A670")]
			[MethodImpl(256)]
			public InputControlExtensions.ControlBuilder IsButton(bool value)
			{
				return default(InputControlExtensions.ControlBuilder);
			}

			// Token: 0x0600059C RID: 1436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x561A650", Offset = "0x5619250", VA = "0x18561A650")]
			[MethodImpl(256)]
			public void Finish()
			{
			}
		}

		// Token: 0x02000074 RID: 116
		[Token(Token = "0x2000074")]
		public struct DeviceBuilder
		{
			// Token: 0x17000194 RID: 404
			// (get) Token: 0x0600059D RID: 1437 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600059E RID: 1438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000194")]
			public InputDevice device
			{
				[Token(Token = "0x600059D")]
				[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x600059E")]
				[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			// Token: 0x0600059F RID: 1439 RVA: 0x00004908 File Offset: 0x00002B08
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x561A8B0", Offset = "0x56194B0", VA = "0x18561A8B0")]
			[MethodImpl(256)]
			public InputControlExtensions.DeviceBuilder WithName(string name)
			{
				return default(InputControlExtensions.DeviceBuilder);
			}

			// Token: 0x060005A0 RID: 1440 RVA: 0x00004920 File Offset: 0x00002B20
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x561A7C0", Offset = "0x56193C0", VA = "0x18561A7C0")]
			[MethodImpl(256)]
			public InputControlExtensions.DeviceBuilder WithDisplayName(string displayName)
			{
				return default(InputControlExtensions.DeviceBuilder);
			}

			// Token: 0x060005A1 RID: 1441 RVA: 0x00004938 File Offset: 0x00002B38
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x561A940", Offset = "0x5619540", VA = "0x18561A940")]
			[MethodImpl(256)]
			public InputControlExtensions.DeviceBuilder WithShortDisplayName(string shortDisplayName)
			{
				return default(InputControlExtensions.DeviceBuilder);
			}

			// Token: 0x060005A2 RID: 1442 RVA: 0x00004950 File Offset: 0x00002B50
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x561A830", Offset = "0x5619430", VA = "0x18561A830")]
			[MethodImpl(256)]
			public InputControlExtensions.DeviceBuilder WithLayout(InternedString layout)
			{
				return default(InputControlExtensions.DeviceBuilder);
			}

			// Token: 0x060005A3 RID: 1443 RVA: 0x00004968 File Offset: 0x00002B68
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x561A750", Offset = "0x5619350", VA = "0x18561A750")]
			[MethodImpl(256)]
			public InputControlExtensions.DeviceBuilder WithChildren(int startIndex, int count)
			{
				return default(InputControlExtensions.DeviceBuilder);
			}

			// Token: 0x060005A4 RID: 1444 RVA: 0x00004980 File Offset: 0x00002B80
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x561A9B0", Offset = "0x56195B0", VA = "0x18561A9B0")]
			[MethodImpl(256)]
			public InputControlExtensions.DeviceBuilder WithStateBlock(InputStateBlock stateBlock)
			{
				return default(InputControlExtensions.DeviceBuilder);
			}

			// Token: 0x060005A5 RID: 1445 RVA: 0x00004998 File Offset: 0x00002B98
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x561A6B0", Offset = "0x56192B0", VA = "0x18561A6B0")]
			[MethodImpl(256)]
			public InputControlExtensions.DeviceBuilder IsNoisy(bool value)
			{
				return default(InputControlExtensions.DeviceBuilder);
			}

			// Token: 0x060005A6 RID: 1446 RVA: 0x000049B0 File Offset: 0x00002BB0
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x561ABC0", Offset = "0x56197C0", VA = "0x18561ABC0")]
			[MethodImpl(256)]
			public InputControlExtensions.DeviceBuilder WithControlUsage(int controlIndex, InternedString usage, InputControl control)
			{
				return default(InputControlExtensions.DeviceBuilder);
			}

			// Token: 0x060005A7 RID: 1447 RVA: 0x000049C8 File Offset: 0x00002BC8
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x561AA10", Offset = "0x5619610", VA = "0x18561AA10")]
			[MethodImpl(256)]
			public InputControlExtensions.DeviceBuilder WithControlAlias(int controlIndex, InternedString alias)
			{
				return default(InputControlExtensions.DeviceBuilder);
			}

			// Token: 0x060005A8 RID: 1448 RVA: 0x000049E0 File Offset: 0x00002BE0
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x561ACB0", Offset = "0x56198B0", VA = "0x18561ACB0")]
			[MethodImpl(256)]
			public InputControlExtensions.DeviceBuilder WithStateOffsetToControlIndexMap(uint[] map)
			{
				return default(InputControlExtensions.DeviceBuilder);
			}

			// Token: 0x060005A9 RID: 1449 RVA: 0x000049F8 File Offset: 0x00002BF8
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x561AA70", Offset = "0x5619670", VA = "0x18561AA70")]
			[MethodImpl(256)]
			public InputControlExtensions.DeviceBuilder WithControlTree(byte[] controlTreeNodes, ushort[] controlTreeIndicies)
			{
				return default(InputControlExtensions.DeviceBuilder);
			}

			// Token: 0x060005AA RID: 1450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x561A650", Offset = "0x5619250", VA = "0x18561A650")]
			[MethodImpl(256)]
			public void Finish()
			{
			}
		}
	}
}
