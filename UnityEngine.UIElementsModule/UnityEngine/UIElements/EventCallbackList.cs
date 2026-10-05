using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	internal class EventCallbackList
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00006060 File Offset: 0x00004260
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000281")]
		public int trickleDownCallbackCount
		{
			[Token(Token = "0x6000B5D")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B5E")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00006078 File Offset: 0x00004278
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000282")]
		public int bubbleUpCallbackCount
		{
			[Token(Token = "0x6000B5F")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B60")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x5ADCA30", Offset = "0x5ADB630", VA = "0x185ADCA30")]
		public EventCallbackList()
		{
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x5ADCAC0", Offset = "0x5ADB6C0", VA = "0x185ADCAC0")]
		public EventCallbackList(EventCallbackList source)
		{
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00006090 File Offset: 0x00004290
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x5ADC690", Offset = "0x5ADB290", VA = "0x185ADC690")]
		public bool Contains(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			return default(bool);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x5ADC7C0", Offset = "0x5ADB3C0", VA = "0x185ADC7C0")]
		public EventCallbackFunctorBase Find(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			return null;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x5ADC8F0", Offset = "0x5ADB4F0", VA = "0x185ADC8F0")]
		public bool Remove(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			return default(bool);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x5ADC5A0", Offset = "0x5ADB1A0", VA = "0x185ADC5A0")]
		public void Add(EventCallbackFunctorBase item)
		{
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x5ADC450", Offset = "0x5ADB050", VA = "0x185ADC450")]
		public void AddRange(EventCallbackList list)
		{
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x000060C0 File Offset: 0x000042C0
		[Token(Token = "0x17000283")]
		public int Count
		{
			[Token(Token = "0x6000B68")]
			[Address(RVA = "0x5ADCB70", Offset = "0x5ADB770", VA = "0x185ADCB70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000284 RID: 644
		[Token(Token = "0x17000284")]
		public EventCallbackFunctorBase this[int i]
		{
			[Token(Token = "0x6000B69")]
			[Address(RVA = "0x5ADCBB0", Offset = "0x5ADB7B0", VA = "0x185ADCBB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x5ADC620", Offset = "0x5ADB220", VA = "0x185ADC620")]
		public void Clear()
		{
		}

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x10")]
		private List<EventCallbackFunctorBase> m_List;
	}
}
