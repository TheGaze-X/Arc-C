using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	[AddComponentMenu("EasyTouch/Quick Tap")]
	public class QuickTap : QuickBase
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x25341C0", Offset = "0x2532DC0", VA = "0x1825341C0")]
		public QuickTap()
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x25340F0", Offset = "0x2532CF0", VA = "0x1825340F0")]
		private void Update()
		{
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x2533F50", Offset = "0x2532B50", VA = "0x182533F50")]
		private void DoAction(Gesture gesture)
		{
		}

		// Token: 0x04000B4C RID: 2892
		[Token(Token = "0x4000B4C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public QuickTap.OnTap onTap;

		// Token: 0x04000B4D RID: 2893
		[Token(Token = "0x4000B4D")]
		[FieldOffset(Offset = "0x78")]
		public QuickTap.ActionTriggering actionTriggering;

		// Token: 0x04000B4E RID: 2894
		[Token(Token = "0x4000B4E")]
		[FieldOffset(Offset = "0x80")]
		private Gesture currentGesture;

		// Token: 0x02000207 RID: 519
		[Token(Token = "0x2000207")]
		[Serializable]
		public class OnTap : UnityEvent<Gesture>
		{
			// Token: 0x0600090B RID: 2315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x252FE20", Offset = "0x252EA20", VA = "0x18252FE20")]
			public OnTap()
			{
			}
		}

		// Token: 0x02000208 RID: 520
		[Token(Token = "0x2000208")]
		public enum ActionTriggering
		{
			// Token: 0x04000B50 RID: 2896
			[Token(Token = "0x4000B50")]
			Simple_Tap,
			// Token: 0x04000B51 RID: 2897
			[Token(Token = "0x4000B51")]
			Double_Tap
		}
	}
}
