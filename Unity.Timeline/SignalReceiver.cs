using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public class SignalReceiver : MonoBehaviour, INotificationReceiver
	{
		// Token: 0x0600029C RID: 668 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x58EC9A0", Offset = "0x58EB5A0", VA = "0x1858EC9A0", Slot = "4")]
		public void OnNotify(Playable origin, INotification notification, object context)
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x58EC2C0", Offset = "0x58EAEC0", VA = "0x1858EC2C0")]
		public void AddReaction(SignalAsset asset, UnityEvent reaction)
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000037DC File Offset: 0x000019DC
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x58EC250", Offset = "0x58EAE50", VA = "0x1858EC250")]
		public int AddEmptyReaction(UnityEvent reaction)
		{
			return 0;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x58ECBD0", Offset = "0x58EB7D0", VA = "0x1858ECBD0")]
		public void Remove(SignalAsset asset)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x4A52E10", Offset = "0x4A51A10", VA = "0x184A52E10")]
		public IEnumerable<SignalAsset> GetRegisteredSignals()
		{
			return null;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x58EC8A0", Offset = "0x58EB4A0", VA = "0x1858EC8A0")]
		public UnityEvent GetReaction(SignalAsset key)
		{
			return null;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000037F4 File Offset: 0x000019F4
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x58EC790", Offset = "0x58EB390", VA = "0x1858EC790")]
		public int Count()
		{
			return 0;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x58EC500", Offset = "0x58EB100", VA = "0x1858EC500")]
		public void ChangeSignalAtIndex(int idx, SignalAsset newKey)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x58ECAD0", Offset = "0x58EB6D0", VA = "0x1858ECAD0")]
		public void RemoveAtIndex(int idx)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x58EC430", Offset = "0x58EB030", VA = "0x1858EC430")]
		public void ChangeReactionAtIndex(int idx, UnityEvent reaction)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x58EC7E0", Offset = "0x58EB3E0", VA = "0x1858EC7E0")]
		public UnityEvent GetReactionAtIndex(int idx)
		{
			return null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x58EC8E0", Offset = "0x58EB4E0", VA = "0x1858EC8E0")]
		public SignalAsset GetSignalAssetAtIndex(int idx)
		{
			return null;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void OnEnable()
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x58ECD20", Offset = "0x58EB920", VA = "0x1858ECD20")]
		public SignalReceiver()
		{
		}

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SignalReceiver.EventKeyValue m_Events;

		// Token: 0x02000048 RID: 72
		[Token(Token = "0x2000048")]
		[Serializable]
		private class EventKeyValue
		{
			// Token: 0x060002AA RID: 682 RVA: 0x0000380C File Offset: 0x00001A0C
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x58E97A0", Offset = "0x58E83A0", VA = "0x1858E97A0")]
			public bool TryGetValue(SignalAsset key, out UnityEvent value)
			{
				return default(bool);
			}

			// Token: 0x060002AB RID: 683 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x58E95E0", Offset = "0x58E81E0", VA = "0x1858E95E0")]
			public void Append(SignalAsset key, UnityEvent value)
			{
			}

			// Token: 0x060002AC RID: 684 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x58E9720", Offset = "0x58E8320", VA = "0x1858E9720")]
			public void Remove(int idx)
			{
			}

			// Token: 0x060002AD RID: 685 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x58E9670", Offset = "0x58E8270", VA = "0x1858E9670")]
			public void Remove(SignalAsset key)
			{
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x060002AE RID: 686 RVA: 0x000021E6 File Offset: 0x000003E6
			[Token(Token = "0x170000C4")]
			public List<SignalAsset> signals
			{
				[Token(Token = "0x60002AE")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x060002AF RID: 687 RVA: 0x000021E6 File Offset: 0x000003E6
			[Token(Token = "0x170000C5")]
			public List<UnityEvent> events
			{
				[Token(Token = "0x60002AF")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x060002B0 RID: 688 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x58E9860", Offset = "0x58E8460", VA = "0x1858E9860")]
			public EventKeyValue()
			{
			}

			// Token: 0x0400012C RID: 300
			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private List<SignalAsset> m_Signals;

			// Token: 0x0400012D RID: 301
			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x18")]
			[CustomSignalEventDrawer]
			[SerializeField]
			private List<UnityEvent> m_Events;
		}
	}
}
