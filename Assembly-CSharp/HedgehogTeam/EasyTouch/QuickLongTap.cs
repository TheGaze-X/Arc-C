using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x020001FB RID: 507
	[Token(Token = "0x20001FB")]
	[AddComponentMenu("EasyTouch/Quick LongTap")]
	public class QuickLongTap : QuickBase
	{
		// Token: 0x060008EC RID: 2284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x2532AC0", Offset = "0x25316C0", VA = "0x182532AC0")]
		public QuickLongTap()
		{
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x2532910", Offset = "0x2531510", VA = "0x182532910")]
		private void Update()
		{
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x2532710", Offset = "0x2531310", VA = "0x182532710")]
		private void DoAction(Gesture gesture)
		{
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x2532780", Offset = "0x2531380", VA = "0x182532780")]
		private bool IsOverMe(Gesture gesture)
		{
			return default(bool);
		}

		// Token: 0x04000B21 RID: 2849
		[Token(Token = "0x4000B21")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public QuickLongTap.OnLongTap onLongTap;

		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0x78")]
		public QuickLongTap.ActionTriggering actionTriggering;

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0x80")]
		private Gesture currentGesture;

		// Token: 0x020001FC RID: 508
		[Token(Token = "0x20001FC")]
		[Serializable]
		public class OnLongTap : UnityEvent<Gesture>
		{
			// Token: 0x060008F0 RID: 2288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x252FD60", Offset = "0x252E960", VA = "0x18252FD60")]
			public OnLongTap()
			{
			}
		}

		// Token: 0x020001FD RID: 509
		[Token(Token = "0x20001FD")]
		public enum ActionTriggering
		{
			// Token: 0x04000B25 RID: 2853
			[Token(Token = "0x4000B25")]
			Start,
			// Token: 0x04000B26 RID: 2854
			[Token(Token = "0x4000B26")]
			InProgress,
			// Token: 0x04000B27 RID: 2855
			[Token(Token = "0x4000B27")]
			End
		}
	}
}
