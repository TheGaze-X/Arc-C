using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200215D RID: 8541
	[Token(Token = "0x200215D")]
	public class CoroutineSimulator
	{
		// Token: 0x0600D244 RID: 53828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D244")]
		[Address(RVA = "0x3535460", Offset = "0x3534060", VA = "0x183535460")]
		public void SimulateTick()
		{
		}

		// Token: 0x0600D245 RID: 53829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D245")]
		[Address(RVA = "0x35353E0", Offset = "0x3533FE0", VA = "0x1835353E0")]
		public void Reset()
		{
		}

		// Token: 0x0600D246 RID: 53830 RVA: 0x0004BBB8 File Offset: 0x00049DB8
		[Token(Token = "0x600D246")]
		[Address(RVA = "0x35355D0", Offset = "0x35341D0", VA = "0x1835355D0")]
		public CoroutineSimulator.InternalId StartCoroutine(MonoBehaviour mono, IEnumerator routine)
		{
			return default(CoroutineSimulator.InternalId);
		}

		// Token: 0x0600D247 RID: 53831 RVA: 0x0004BBD0 File Offset: 0x00049DD0
		[Token(Token = "0x600D247")]
		[Address(RVA = "0x3535930", Offset = "0x3534530", VA = "0x183535930")]
		public bool StopCoroutine(CoroutineSimulator.InternalId id)
		{
			return default(bool);
		}

		// Token: 0x0600D248 RID: 53832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D248")]
		[Address(RVA = "0x35357E0", Offset = "0x35343E0", VA = "0x1835357E0")]
		public void StopAllCoroutines(MonoBehaviour mono)
		{
		}

		// Token: 0x0600D249 RID: 53833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D249")]
		[Address(RVA = "0x3535A30", Offset = "0x3534630", VA = "0x183535A30")]
		public CoroutineSimulator()
		{
		}

		// Token: 0x0400E0BA RID: 57530
		[Token(Token = "0x400E0BA")]
		[FieldOffset(Offset = "0x10")]
		private ulong m_uidCounter;

		// Token: 0x0400E0BB RID: 57531
		[Token(Token = "0x400E0BB")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<CoroutineSimulator.InternalId, CoroutineSimulator.RuntimeHandler> m_pendingDict;

		// Token: 0x0400E0BC RID: 57532
		[Token(Token = "0x400E0BC")]
		[FieldOffset(Offset = "0x20")]
		private List<CoroutineSimulator.RuntimeHandler> m_pendingList;

		// Token: 0x0400E0BD RID: 57533
		[Token(Token = "0x400E0BD")]
		[FieldOffset(Offset = "0x28")]
		private List<CoroutineSimulator.RuntimeHandler> m_cachedList;

		// Token: 0x0200215E RID: 8542
		[Token(Token = "0x200215E")]
		public struct InternalId : IComparable<CoroutineSimulator.InternalId>
		{
			// Token: 0x1700193A RID: 6458
			// (get) Token: 0x0600D24A RID: 53834 RVA: 0x0004BBE8 File Offset: 0x00049DE8
			[Token(Token = "0x1700193A")]
			public bool isInvalid
			{
				[Token(Token = "0x600D24A")]
				[Address(RVA = "0x1E424B0", Offset = "0x1E410B0", VA = "0x181E424B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600D24B RID: 53835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D24B")]
			[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
			public InternalId(ulong uid_)
			{
			}

			// Token: 0x0600D24C RID: 53836 RVA: 0x0004BC00 File Offset: 0x00049E00
			[Token(Token = "0x600D24C")]
			[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "4")]
			public int CompareTo(CoroutineSimulator.InternalId other)
			{
				return 0;
			}

			// Token: 0x0400E0BE RID: 57534
			[Token(Token = "0x400E0BE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly CoroutineSimulator.InternalId INVALID;

			// Token: 0x0400E0BF RID: 57535
			[Token(Token = "0x400E0BF")]
			[FieldOffset(Offset = "0x0")]
			public ulong uid;
		}

		// Token: 0x0200215F RID: 8543
		[Token(Token = "0x200215F")]
		private class RuntimeHandler
		{
			// Token: 0x1700193B RID: 6459
			// (get) Token: 0x0600D24E RID: 53838 RVA: 0x0004BC18 File Offset: 0x00049E18
			[Token(Token = "0x1700193B")]
			public CoroutineSimulator.InternalId id
			{
				[Token(Token = "0x600D24E")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return default(CoroutineSimulator.InternalId);
				}
			}

			// Token: 0x1700193C RID: 6460
			// (get) Token: 0x0600D24F RID: 53839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700193C")]
			public MonoBehaviour fakeHost
			{
				[Token(Token = "0x600D24F")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600D250 RID: 53840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D250")]
			[Address(RVA = "0x3537470", Offset = "0x3536070", VA = "0x183537470")]
			public RuntimeHandler(CoroutineSimulator.InternalId id, MonoBehaviour fakeHost, IEnumerator routine)
			{
			}

			// Token: 0x0600D251 RID: 53841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D251")]
			[Address(RVA = "0x35373F0", Offset = "0x3535FF0", VA = "0x1835373F0")]
			public void Stop()
			{
			}

			// Token: 0x0600D252 RID: 53842 RVA: 0x0004BC30 File Offset: 0x00049E30
			[Token(Token = "0x600D252")]
			[Address(RVA = "0x3537040", Offset = "0x3535C40", VA = "0x183537040")]
			public bool IsFinished()
			{
				return default(bool);
			}

			// Token: 0x0600D253 RID: 53843 RVA: 0x0004BC48 File Offset: 0x00049E48
			[Token(Token = "0x600D253")]
			[Address(RVA = "0x35370F0", Offset = "0x3535CF0", VA = "0x1835370F0")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0400E0C0 RID: 57536
			[Token(Token = "0x400E0C0")]
			[FieldOffset(Offset = "0x10")]
			private CoroutineSimulator.InternalId m_id;

			// Token: 0x0400E0C1 RID: 57537
			[Token(Token = "0x400E0C1")]
			[FieldOffset(Offset = "0x18")]
			private MonoBehaviour m_fakeHost;

			// Token: 0x0400E0C2 RID: 57538
			[Token(Token = "0x400E0C2")]
			[FieldOffset(Offset = "0x20")]
			private Stack<CoroutineSimulator.RuntimeHandler.Routine> m_routines;

			// Token: 0x02002160 RID: 8544
			[Token(Token = "0x2002160")]
			private struct Routine
			{
				// Token: 0x0600D254 RID: 53844 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D254")]
				[Address(RVA = "0xFEA730", Offset = "0xFE9330", VA = "0x180FEA730")]
				public Routine(IEnumerator enumerator_)
				{
				}

				// Token: 0x0400E0C3 RID: 57539
				[Token(Token = "0x400E0C3")]
				[FieldOffset(Offset = "0x0")]
				public bool firstTouch;

				// Token: 0x0400E0C4 RID: 57540
				[Token(Token = "0x400E0C4")]
				[FieldOffset(Offset = "0x8")]
				public IEnumerator enumerator;
			}
		}
	}
}
