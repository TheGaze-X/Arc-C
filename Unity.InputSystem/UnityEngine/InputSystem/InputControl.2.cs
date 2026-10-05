using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public abstract class InputControl<TValue> : InputControl where TValue : struct
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700018B")]
		public override Type valueType
		{
			[Token(Token = "0x6000535")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x1700018C")]
		public override int valueSizeInBytes
		{
			[Token(Token = "0x6000536")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700018D")]
		public ref TValue value
		{
			[Token(Token = "0x6000537")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700018E")]
		internal ref TValue unprocessedValue
		{
			[Token(Token = "0x6000538")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000539")]
		public TValue ReadValue()
		{
			return null;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053A")]
		public TValue ReadValueFromPreviousFrame()
		{
			return null;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053B")]
		public TValue ReadDefaultValue()
		{
			return null;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053C")]
		public unsafe TValue ReadValueFromState(void* statePtr)
		{
			return null;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053D")]
		public unsafe TValue ReadValueFromStateWithCaching(void* statePtr)
		{
			return null;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053E")]
		public unsafe TValue ReadUnprocessedValueFromStateWithCaching(void* statePtr)
		{
			return null;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600053F")]
		public TValue ReadUnprocessedValue()
		{
			return null;
		}

		// Token: 0x06000540 RID: 1344
		[Token(Token = "0x6000540")]
		public unsafe abstract TValue ReadUnprocessedValueFromState(void* statePtr);

		// Token: 0x06000541 RID: 1345 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000541")]
		public unsafe override object ReadValueFromStateAsObject(void* statePtr)
		{
			return null;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000542")]
		public unsafe override void ReadValueFromStateIntoBuffer(void* statePtr, void* bufferPtr, int bufferSize)
		{
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000543")]
		public unsafe override void WriteValueFromBufferIntoState(void* bufferPtr, int bufferSize, void* statePtr)
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000544")]
		public unsafe override void WriteValueFromObjectIntoState(object value, void* statePtr)
		{
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000545")]
		public unsafe virtual void WriteValueIntoState(TValue value, void* statePtr)
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000546")]
		public unsafe override object ReadValueFromBufferAsObject(void* buffer, int bufferSize)
		{
			return null;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x6000547")]
		private static bool CompareValue(ref TValue firstValue, ref TValue secondValue)
		{
			return default(bool);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x6000548")]
		public unsafe override bool CompareValue(void* firstStatePtr, void* secondStatePtr)
		{
			return default(bool);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000549")]
		[MethodImpl(256)]
		public TValue ProcessValue(TValue value)
		{
			return null;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054A")]
		[MethodImpl(256)]
		public void ProcessValue(ref TValue value)
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600054B")]
		internal TProcessor TryGetProcessor<TProcessor>() where TProcessor : InputProcessor<TValue>
		{
			return null;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054C")]
		internal override void AddProcessor(object processor)
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054D")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700018F")]
		internal InputProcessor<TValue>[] processors
		{
			[Token(Token = "0x600054E")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054F")]
		protected InputControl()
		{
		}

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x0")]
		internal InlinedArray<InputProcessor<TValue>> m_ProcessorStack;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x0")]
		private TValue m_CachedValue;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x0")]
		private TValue m_UnprocessedCachedValue;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x0")]
		internal bool evaluateProcessorsEveryRead;
	}
}
