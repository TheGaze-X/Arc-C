using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Spine.Unity
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	[CreateAssetMenu(menuName = "Spine/EventData Reference Asset", order = 100)]
	public class EventDataReferenceAsset : ScriptableObject
	{
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000175")]
		public EventData EventData
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x4E7A400", Offset = "0x4E79000", VA = "0x184E7A400")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x4E7A230", Offset = "0x4E78E30", VA = "0x184E7A230")]
		public void Initialize()
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x4E7A430", Offset = "0x4E79030", VA = "0x184E7A430")]
		public static implicit operator EventData(EventDataReferenceAsset asset)
		{
			return null;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public EventDataReferenceAsset()
		{
		}

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		private const bool QuietSkeletonData = true;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected SkeletonDataAsset skeletonDataAsset;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x20")]
		[SpineEvent("", "skeletonDataAsset", true, false, false)]
		[SerializeField]
		protected string eventName;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x28")]
		private EventData eventData;
	}
}
