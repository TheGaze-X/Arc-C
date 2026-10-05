using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001DA RID: 474
	[Token(Token = "0x20001DA")]
	public class InputStateHistory<TValue> : InputStateHistory, IReadOnlyList<InputStateHistory<TValue>.Record>, IEnumerable<InputStateHistory<TValue>.Record>, IEnumerable, IReadOnlyCollection<InputStateHistory<TValue>.Record> where TValue : struct
	{
		// Token: 0x06001194 RID: 4500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001194")]
		public InputStateHistory([Optional] int? maxStateSizeInBytes)
		{
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001195")]
		public InputStateHistory(InputControl<TValue> control)
		{
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001196")]
		public InputStateHistory(string path)
		{
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001197")]
		protected override void Finalize()
		{
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x6001198")]
		public InputStateHistory<TValue>.Record AddRecord(InputStateHistory<TValue>.Record record)
		{
			return default(InputStateHistory<TValue>.Record);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x6001199")]
		public InputStateHistory<TValue>.Record RecordStateChange(InputControl<TValue> control, TValue value, double time = -1.0)
		{
			return default(InputStateHistory<TValue>.Record);
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600119A")]
		public new IEnumerator<InputStateHistory<TValue>.Record> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600119B")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000509 RID: 1289
		[Token(Token = "0x17000509")]
		public InputStateHistory<TValue>.Record this[int index]
		{
			[Token(Token = "0x600119C")]
			get
			{
				return default(InputStateHistory<TValue>.Record);
			}
			[Token(Token = "0x600119D")]
			set
			{
			}
		}

		// Token: 0x020001DB RID: 475
		[Token(Token = "0x20001DB")]
		private struct Enumerator : IEnumerator<InputStateHistory<TValue>.Record>, IEnumerator, IDisposable
		{
			// Token: 0x0600119E RID: 4510 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600119E")]
			public Enumerator(InputStateHistory<TValue> history)
			{
			}

			// Token: 0x0600119F RID: 4511 RVA: 0x000092D0 File Offset: 0x000074D0
			[Token(Token = "0x600119F")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060011A0 RID: 4512 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011A0")]
			public void Reset()
			{
			}

			// Token: 0x1700050A RID: 1290
			// (get) Token: 0x060011A1 RID: 4513 RVA: 0x000092E8 File Offset: 0x000074E8
			[Token(Token = "0x1700050A")]
			public InputStateHistory<TValue>.Record Current
			{
				[Token(Token = "0x60011A1")]
				get
				{
					return default(InputStateHistory<TValue>.Record);
				}
			}

			// Token: 0x1700050B RID: 1291
			// (get) Token: 0x060011A2 RID: 4514 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700050B")]
			private object Current
			{
				[Token(Token = "0x60011A2")]
				get
				{
					return null;
				}
			}

			// Token: 0x060011A3 RID: 4515 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011A3")]
			public void Dispose()
			{
			}

			// Token: 0x04000A85 RID: 2693
			[Token(Token = "0x4000A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly InputStateHistory<TValue> m_History;

			// Token: 0x04000A86 RID: 2694
			[Token(Token = "0x4000A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int m_Index;
		}

		// Token: 0x020001DC RID: 476
		[Token(Token = "0x20001DC")]
		public new struct Record : IEquatable<InputStateHistory<TValue>.Record>
		{
			// Token: 0x1700050C RID: 1292
			// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700050C")]
			internal unsafe InputStateHistory.RecordHeader* header
			{
				[Token(Token = "0x60011A4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700050D RID: 1293
			// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00009300 File Offset: 0x00007500
			[Token(Token = "0x1700050D")]
			internal int recordIndex
			{
				[Token(Token = "0x60011A5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700050E RID: 1294
			// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00009318 File Offset: 0x00007518
			[Token(Token = "0x1700050E")]
			public bool valid
			{
				[Token(Token = "0x60011A6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700050F RID: 1295
			// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700050F")]
			public InputStateHistory<TValue> owner
			{
				[Token(Token = "0x60011A7")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000510 RID: 1296
			// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00009330 File Offset: 0x00007530
			[Token(Token = "0x17000510")]
			public int index
			{
				[Token(Token = "0x60011A8")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000511 RID: 1297
			// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00009348 File Offset: 0x00007548
			[Token(Token = "0x17000511")]
			public double time
			{
				[Token(Token = "0x60011A9")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x17000512 RID: 1298
			// (get) Token: 0x060011AA RID: 4522 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000512")]
			public InputControl<TValue> control
			{
				[Token(Token = "0x60011AA")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000513 RID: 1299
			// (get) Token: 0x060011AB RID: 4523 RVA: 0x00009360 File Offset: 0x00007560
			[Token(Token = "0x17000513")]
			public InputStateHistory<TValue>.Record next
			{
				[Token(Token = "0x60011AB")]
				get
				{
					return default(InputStateHistory<TValue>.Record);
				}
			}

			// Token: 0x17000514 RID: 1300
			// (get) Token: 0x060011AC RID: 4524 RVA: 0x00009378 File Offset: 0x00007578
			[Token(Token = "0x17000514")]
			public InputStateHistory<TValue>.Record previous
			{
				[Token(Token = "0x60011AC")]
				get
				{
					return default(InputStateHistory<TValue>.Record);
				}
			}

			// Token: 0x060011AD RID: 4525 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011AD")]
			internal unsafe Record(InputStateHistory<TValue> owner, int index, InputStateHistory.RecordHeader* header)
			{
			}

			// Token: 0x060011AE RID: 4526 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011AE")]
			internal Record(InputStateHistory<TValue> owner, int index)
			{
			}

			// Token: 0x060011AF RID: 4527 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60011AF")]
			public TValue ReadValue()
			{
				return null;
			}

			// Token: 0x060011B0 RID: 4528 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60011B0")]
			public unsafe void* GetUnsafeMemoryPtr()
			{
				return null;
			}

			// Token: 0x060011B1 RID: 4529 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60011B1")]
			internal unsafe void* GetUnsafeMemoryPtrUnchecked()
			{
				return null;
			}

			// Token: 0x060011B2 RID: 4530 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60011B2")]
			public unsafe void* GetUnsafeExtraMemoryPtr()
			{
				return null;
			}

			// Token: 0x060011B3 RID: 4531 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60011B3")]
			internal unsafe void* GetUnsafeExtraMemoryPtrUnchecked()
			{
				return null;
			}

			// Token: 0x060011B4 RID: 4532 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011B4")]
			public void CopyFrom(InputStateHistory<TValue>.Record record)
			{
			}

			// Token: 0x060011B5 RID: 4533 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011B5")]
			private void CheckValid()
			{
			}

			// Token: 0x060011B6 RID: 4534 RVA: 0x00009390 File Offset: 0x00007590
			[Token(Token = "0x60011B6")]
			public bool Equals(InputStateHistory<TValue>.Record other)
			{
				return default(bool);
			}

			// Token: 0x060011B7 RID: 4535 RVA: 0x000093A8 File Offset: 0x000075A8
			[Token(Token = "0x60011B7")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x060011B8 RID: 4536 RVA: 0x000093C0 File Offset: 0x000075C0
			[Token(Token = "0x60011B8")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x060011B9 RID: 4537 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60011B9")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000A87 RID: 2695
			[Token(Token = "0x4000A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly InputStateHistory<TValue> m_Owner;

			// Token: 0x04000A88 RID: 2696
			[Token(Token = "0x4000A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int m_IndexPlusOne;

			// Token: 0x04000A89 RID: 2697
			[Token(Token = "0x4000A89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private uint m_Version;
		}
	}
}
