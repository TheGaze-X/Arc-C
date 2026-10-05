using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x020001F7 RID: 503
	[Token(Token = "0x20001F7")]
	[AddComponentMenu("EasyTouch/Quick Enter-Over-Exit")]
	public class QuickEnterOverExist : QuickBase
	{
		// Token: 0x060008E1 RID: 2273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x2532640", Offset = "0x2531240", VA = "0x182532640")]
		public QuickEnterOverExist()
		{
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x25320B0", Offset = "0x2530CB0", VA = "0x1825320B0")]
		private void Awake()
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x2532110", Offset = "0x2530D10", VA = "0x182532110", Slot = "5")]
		public override void OnEnable()
		{
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x2532100", Offset = "0x2530D00", VA = "0x182532100", Slot = "6")]
		public override void OnDisable()
		{
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x2532100", Offset = "0x2530D00", VA = "0x182532100")]
		private void OnDestroy()
		{
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x2532570", Offset = "0x2531170", VA = "0x182532570")]
		private void UnsubscribeEvent()
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x25321E0", Offset = "0x2530DE0", VA = "0x1825321E0")]
		private void On_TouchDown(Gesture gesture)
		{
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x25324E0", Offset = "0x25310E0", VA = "0x1825324E0")]
		private void On_TouchUp(Gesture gesture)
		{
		}

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4000B1D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public QuickEnterOverExist.OnTouchEnter onTouchEnter;

		// Token: 0x04000B1E RID: 2846
		[Token(Token = "0x4000B1E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public QuickEnterOverExist.OnTouchOver onTouchOver;

		// Token: 0x04000B1F RID: 2847
		[Token(Token = "0x4000B1F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public QuickEnterOverExist.OnTouchExit onTouchExit;

		// Token: 0x04000B20 RID: 2848
		[Token(Token = "0x4000B20")]
		[FieldOffset(Offset = "0x88")]
		private bool[] fingerOver;

		// Token: 0x020001F8 RID: 504
		[Token(Token = "0x20001F8")]
		[Serializable]
		public class OnTouchEnter : UnityEvent<Gesture>
		{
			// Token: 0x060008E9 RID: 2281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x252FE60", Offset = "0x252EA60", VA = "0x18252FE60")]
			public OnTouchEnter()
			{
			}
		}

		// Token: 0x020001F9 RID: 505
		[Token(Token = "0x20001F9")]
		[Serializable]
		public class OnTouchOver : UnityEvent<Gesture>
		{
			// Token: 0x060008EA RID: 2282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x252FF20", Offset = "0x252EB20", VA = "0x18252FF20")]
			public OnTouchOver()
			{
			}
		}

		// Token: 0x020001FA RID: 506
		[Token(Token = "0x20001FA")]
		[Serializable]
		public class OnTouchExit : UnityEvent<Gesture>
		{
			// Token: 0x060008EB RID: 2283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x252FEA0", Offset = "0x252EAA0", VA = "0x18252FEA0")]
			public OnTouchExit()
			{
			}
		}
	}
}
