using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000228 RID: 552
	[Token(Token = "0x2000228")]
	public sealed class InputActionTrace : IEnumerable<InputActionTrace.ActionEventPtr>, IEnumerable, IDisposable
	{
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x0000A758 File Offset: 0x00008958
		[Token(Token = "0x170005BA")]
		public InputEventBuffer buffer
		{
			[Token(Token = "0x600140B")]
			[Address(RVA = "0x55FEC80", Offset = "0x55FD880", VA = "0x1855FEC80")]
			get
			{
				return default(InputEventBuffer);
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x170005BB")]
		public int count
		{
			[Token(Token = "0x600140C")]
			[Address(RVA = "0x4D1DE30", Offset = "0x4D1CA30", VA = "0x184D1DE30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InputActionTrace()
		{
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140E")]
		[Address(RVA = "0x55FE9D0", Offset = "0x55FD5D0", VA = "0x1855FE9D0")]
		public InputActionTrace(InputAction action)
		{
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x55FEB30", Offset = "0x55FD730", VA = "0x1855FEB30")]
		public InputActionTrace(InputActionMap actionMap)
		{
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001410")]
		[Address(RVA = "0x55FDC20", Offset = "0x55FC820", VA = "0x1855FDC20")]
		public void SubscribeToAll()
		{
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001411")]
		[Address(RVA = "0x55FE4E0", Offset = "0x55FD0E0", VA = "0x1855FE4E0")]
		public void UnsubscribeFromAll()
		{
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001412")]
		[Address(RVA = "0x55FE000", Offset = "0x55FCC00", VA = "0x1855FE000")]
		public void SubscribeTo(InputAction action)
		{
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001413")]
		[Address(RVA = "0x55FDEC0", Offset = "0x55FCAC0", VA = "0x1855FDEC0")]
		public void SubscribeTo(InputActionMap actionMap)
		{
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001414")]
		[Address(RVA = "0x55FE7C0", Offset = "0x55FD3C0", VA = "0x1855FE7C0")]
		public void UnsubscribeFrom(InputAction action)
		{
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001415")]
		[Address(RVA = "0x55FE8E0", Offset = "0x55FD4E0", VA = "0x1855FE8E0")]
		public void UnsubscribeFrom(InputActionMap actionMap)
		{
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001416")]
		[Address(RVA = "0x55FDA60", Offset = "0x55FC660", VA = "0x1855FDA60")]
		public void RecordAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001417")]
		[Address(RVA = "0x55FD2D0", Offset = "0x55FBED0", VA = "0x1855FD2D0")]
		public void Clear()
		{
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001418")]
		[Address(RVA = "0x55FD540", Offset = "0x55FC140", VA = "0x1855FD540", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001419")]
		[Address(RVA = "0x55FE160", Offset = "0x55FCD60", VA = "0x1855FE160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141A")]
		[Address(RVA = "0x55FD520", Offset = "0x55FC120", VA = "0x1855FD520", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141B")]
		[Address(RVA = "0x55FD410", Offset = "0x55FC010", VA = "0x1855FD410")]
		private void DisposeInternal()
		{
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600141C")]
		[Address(RVA = "0x55FD5A0", Offset = "0x55FC1A0", VA = "0x1855FD5A0", Slot = "4")]
		public IEnumerator<InputActionTrace.ActionEventPtr> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600141D")]
		[Address(RVA = "0x55FE150", Offset = "0x55FCD50", VA = "0x1855FE150", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141E")]
		[Address(RVA = "0x55FD650", Offset = "0x55FC250", VA = "0x1855FD650")]
		private void HookOnActionChange()
		{
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141F")]
		[Address(RVA = "0x55FE470", Offset = "0x55FD070", VA = "0x1855FE470")]
		private void UnhookOnActionChange()
		{
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001420")]
		[Address(RVA = "0x55FD730", Offset = "0x55FC330", VA = "0x1855FD730")]
		private void OnActionChange(object actionOrMapOrAsset, InputActionChange change)
		{
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001421")]
		[Address(RVA = "0x55FD320", Offset = "0x55FBF20", VA = "0x1855FD320")]
		private void CloneActionStateBeforeBindingsChange(InputActionMap actionMap)
		{
		}

		// Token: 0x04000BE8 RID: 3048
		[Token(Token = "0x4000BE8")]
		[FieldOffset(Offset = "0x10")]
		private bool m_SubscribedToAll;

		// Token: 0x04000BE9 RID: 3049
		[Token(Token = "0x4000BE9")]
		[FieldOffset(Offset = "0x11")]
		private bool m_OnActionChangeHooked;

		// Token: 0x04000BEA RID: 3050
		[Token(Token = "0x4000BEA")]
		[FieldOffset(Offset = "0x18")]
		private InlinedArray<InputAction> m_SubscribedActions;

		// Token: 0x04000BEB RID: 3051
		[Token(Token = "0x4000BEB")]
		[FieldOffset(Offset = "0x30")]
		private InlinedArray<InputActionMap> m_SubscribedActionMaps;

		// Token: 0x04000BEC RID: 3052
		[Token(Token = "0x4000BEC")]
		[FieldOffset(Offset = "0x48")]
		private InputEventBuffer m_EventBuffer;

		// Token: 0x04000BED RID: 3053
		[Token(Token = "0x4000BED")]
		[FieldOffset(Offset = "0x68")]
		private InlinedArray<InputActionState> m_ActionMapStates;

		// Token: 0x04000BEE RID: 3054
		[Token(Token = "0x4000BEE")]
		[FieldOffset(Offset = "0x80")]
		private InlinedArray<InputActionState> m_ActionMapStateClones;

		// Token: 0x04000BEF RID: 3055
		[Token(Token = "0x4000BEF")]
		[FieldOffset(Offset = "0x98")]
		private Action<InputAction.CallbackContext> m_CallbackDelegate;

		// Token: 0x04000BF0 RID: 3056
		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0xA0")]
		private Action<object, InputActionChange> m_ActionChangeDelegate;

		// Token: 0x02000229 RID: 553
		[Token(Token = "0x2000229")]
		public struct ActionEventPtr
		{
			// Token: 0x170005BC RID: 1468
			// (get) Token: 0x06001422 RID: 5154 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170005BC")]
			public InputAction action
			{
				[Token(Token = "0x6001422")]
				[Address(RVA = "0x55FA080", Offset = "0x55F8C80", VA = "0x1855FA080")]
				get
				{
					return null;
				}
			}

			// Token: 0x170005BD RID: 1469
			// (get) Token: 0x06001423 RID: 5155 RVA: 0x0000A788 File Offset: 0x00008988
			[Token(Token = "0x170005BD")]
			public InputActionPhase phase
			{
				[Token(Token = "0x6001423")]
				[Address(RVA = "0x55FA180", Offset = "0x55F8D80", VA = "0x1855FA180")]
				get
				{
					return InputActionPhase.Disabled;
				}
			}

			// Token: 0x170005BE RID: 1470
			// (get) Token: 0x06001424 RID: 5156 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170005BE")]
			public InputControl control
			{
				[Token(Token = "0x6001424")]
				[Address(RVA = "0x55FA0B0", Offset = "0x55F8CB0", VA = "0x1855FA0B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170005BF RID: 1471
			// (get) Token: 0x06001425 RID: 5157 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170005BF")]
			public IInputInteraction interaction
			{
				[Token(Token = "0x6001425")]
				[Address(RVA = "0x55FA120", Offset = "0x55F8D20", VA = "0x1855FA120")]
				get
				{
					return null;
				}
			}

			// Token: 0x170005C0 RID: 1472
			// (get) Token: 0x06001426 RID: 5158 RVA: 0x0000A7A0 File Offset: 0x000089A0
			[Token(Token = "0x170005C0")]
			public double time
			{
				[Token(Token = "0x6001426")]
				[Address(RVA = "0x55FA1A0", Offset = "0x55F8DA0", VA = "0x1855FA1A0")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x170005C1 RID: 1473
			// (get) Token: 0x06001427 RID: 5159 RVA: 0x0000A7B8 File Offset: 0x000089B8
			[Token(Token = "0x170005C1")]
			public double startTime
			{
				[Token(Token = "0x6001427")]
				[Address(RVA = "0x55FA190", Offset = "0x55F8D90", VA = "0x1855FA190")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x170005C2 RID: 1474
			// (get) Token: 0x06001428 RID: 5160 RVA: 0x0000A7D0 File Offset: 0x000089D0
			[Token(Token = "0x170005C2")]
			public double duration
			{
				[Token(Token = "0x6001428")]
				[Address(RVA = "0x55FA0F0", Offset = "0x55F8CF0", VA = "0x1855FA0F0")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x170005C3 RID: 1475
			// (get) Token: 0x06001429 RID: 5161 RVA: 0x0000A7E8 File Offset: 0x000089E8
			[Token(Token = "0x170005C3")]
			public int valueSizeInBytes
			{
				[Token(Token = "0x6001429")]
				[Address(RVA = "0x55FA1C0", Offset = "0x55F8DC0", VA = "0x1855FA1C0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600142A RID: 5162 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600142A")]
			[Address(RVA = "0x55F9810", Offset = "0x55F8410", VA = "0x1855F9810")]
			public object ReadValueAsObject()
			{
				return null;
			}

			// Token: 0x0600142B RID: 5163 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600142B")]
			[Address(RVA = "0x55F9AE0", Offset = "0x55F86E0", VA = "0x1855F9AE0")]
			public unsafe void ReadValue(void* buffer, int bufferSize)
			{
			}

			// Token: 0x0600142C RID: 5164 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600142C")]
			public TValue ReadValue<TValue>() where TValue : struct
			{
				return null;
			}

			// Token: 0x0600142D RID: 5165 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600142D")]
			[Address(RVA = "0x55F9BF0", Offset = "0x55F87F0", VA = "0x1855F9BF0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000BF1 RID: 3057
			[Token(Token = "0x4000BF1")]
			[FieldOffset(Offset = "0x0")]
			internal InputActionState m_State;

			// Token: 0x04000BF2 RID: 3058
			[Token(Token = "0x4000BF2")]
			[FieldOffset(Offset = "0x8")]
			internal unsafe ActionEvent* m_Ptr;
		}

		// Token: 0x0200022A RID: 554
		[Token(Token = "0x200022A")]
		private struct Enumerator : IEnumerator<InputActionTrace.ActionEventPtr>, IEnumerator, IDisposable
		{
			// Token: 0x0600142E RID: 5166 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600142E")]
			[Address(RVA = "0x55FCA30", Offset = "0x55FB630", VA = "0x1855FCA30")]
			public Enumerator(InputActionTrace trace)
			{
			}

			// Token: 0x0600142F RID: 5167 RVA: 0x0000A800 File Offset: 0x00008A00
			[Token(Token = "0x600142F")]
			[Address(RVA = "0x55FC910", Offset = "0x55FB510", VA = "0x1855FC910", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06001430 RID: 5168 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001430")]
			[Address(RVA = "0x55FC970", Offset = "0x55FB570", VA = "0x1855FC970", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x06001431 RID: 5169 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001431")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x170005C4 RID: 1476
			// (get) Token: 0x06001432 RID: 5170 RVA: 0x0000A818 File Offset: 0x00008A18
			[Token(Token = "0x170005C4")]
			public InputActionTrace.ActionEventPtr Current
			{
				[Token(Token = "0x6001432")]
				[Address(RVA = "0x55FCA80", Offset = "0x55FB680", VA = "0x1855FCA80", Slot = "4")]
				get
				{
					return default(InputActionTrace.ActionEventPtr);
				}
			}

			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x06001433 RID: 5171 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170005C5")]
			private object Current
			{
				[Token(Token = "0x6001433")]
				[Address(RVA = "0x55FC980", Offset = "0x55FB580", VA = "0x1855FC980", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04000BF3 RID: 3059
			[Token(Token = "0x4000BF3")]
			[FieldOffset(Offset = "0x0")]
			private readonly InputActionTrace m_Trace;

			// Token: 0x04000BF4 RID: 3060
			[Token(Token = "0x4000BF4")]
			[FieldOffset(Offset = "0x8")]
			private unsafe readonly ActionEvent* m_Buffer;

			// Token: 0x04000BF5 RID: 3061
			[Token(Token = "0x4000BF5")]
			[FieldOffset(Offset = "0x10")]
			private readonly int m_EventCount;

			// Token: 0x04000BF6 RID: 3062
			[Token(Token = "0x4000BF6")]
			[FieldOffset(Offset = "0x18")]
			private unsafe ActionEvent* m_CurrentEvent;

			// Token: 0x04000BF7 RID: 3063
			[Token(Token = "0x4000BF7")]
			[FieldOffset(Offset = "0x20")]
			private int m_CurrentIndex;
		}
	}
}
