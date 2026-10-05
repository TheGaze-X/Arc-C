using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[Serializable]
	internal struct MarkerList : ISerializationCallbackReceiver
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600027C RID: 636 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x170000BB")]
		public List<IMarker> markers
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x58EA390", Offset = "0x58E8F90", VA = "0x1858EA390")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x58EA650", Offset = "0x58E9250", VA = "0x1858EA650")]
		public MarkerList(int capacity)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x58E9C90", Offset = "0x58E8890", VA = "0x1858E9C90")]
		public void Add(ScriptableObject item)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00003704 File Offset: 0x00001904
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x58EA3D0", Offset = "0x58E8FD0", VA = "0x1858EA3D0")]
		public bool Remove(IMarker item)
		{
			return default(bool);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000371C File Offset: 0x0000191C
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x58EA5A0", Offset = "0x58E91A0", VA = "0x1858EA5A0")]
		public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty)
		{
			return default(bool);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x58E9F70", Offset = "0x58E8B70", VA = "0x1858E9F70")]
		public void Clear()
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00003734 File Offset: 0x00001934
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x58E9FD0", Offset = "0x58E8BD0", VA = "0x1858E9FD0")]
		public bool Contains(ScriptableObject item)
		{
			return default(bool);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x58EA390", Offset = "0x58E8F90", VA = "0x1858EA390")]
		public IEnumerable<IMarker> GetMarkers()
		{
			return null;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000374C File Offset: 0x0000194C
		[Token(Token = "0x170000BC")]
		public int Count
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x58EA730", Offset = "0x58E9330", VA = "0x1858EA730")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000BD RID: 189
		[Token(Token = "0x170000BD")]
		public IMarker this[int idx]
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x58EA780", Offset = "0x58E9380", VA = "0x1858EA780")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
		public List<ScriptableObject> GetRawMarkerList()
		{
			return null;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x58EA030", Offset = "0x58E8C30", VA = "0x1858EA030")]
		public IMarker CreateMarker(Type type, double time, TrackAsset owner)
		{
			return null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00003764 File Offset: 0x00001964
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x58EA3B0", Offset = "0x58E8FB0", VA = "0x1858EA3B0")]
		public bool HasNotifications()
		{
			return default(bool);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600028A")]
		[Address(RVA = "0xF3CBA0", Offset = "0xF3B7A0", VA = "0x180F3CBA0", Slot = "5")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x58E9D20", Offset = "0x58E8920", VA = "0x1858E9D20")]
		private void BuildCache()
		{
		}

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private List<ScriptableObject> m_Objects;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x8")]
		[HideInInspector]
		[NonSerialized]
		private List<IMarker> m_Cache;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x10")]
		private bool m_CacheDirty;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x11")]
		private bool m_HasNotifications;
	}
}
