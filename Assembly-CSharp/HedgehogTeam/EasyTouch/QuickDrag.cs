using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x020001F3 RID: 499
	[Token(Token = "0x20001F3")]
	[AddComponentMenu("EasyTouch/Quick Drag")]
	public class QuickDrag : QuickBase
	{
		// Token: 0x060008D0 RID: 2256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x2532000", Offset = "0x2530C00", VA = "0x182532000")]
		public QuickDrag()
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x2531220", Offset = "0x252FE20", VA = "0x182531220", Slot = "5")]
		public override void OnEnable()
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x2531210", Offset = "0x252FE10", VA = "0x182531210", Slot = "6")]
		public override void OnDisable()
		{
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x2531210", Offset = "0x252FE10", VA = "0x182531210")]
		private void OnDestroy()
		{
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x2531DF0", Offset = "0x25309F0", VA = "0x182531DF0")]
		private void UnsubscribeEvent()
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x25311F0", Offset = "0x252FDF0", VA = "0x1825311F0")]
		private void OnCollisionEnter()
		{
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x2531B70", Offset = "0x2530770", VA = "0x182531B70")]
		private void On_TouchStart(Gesture gesture)
		{
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x2531960", Offset = "0x2530560", VA = "0x182531960")]
		private void On_TouchDown(Gesture gesture)
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x2531CA0", Offset = "0x25308A0", VA = "0x182531CA0")]
		private void On_TouchUp(Gesture gesture)
		{
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x2531470", Offset = "0x2530070", VA = "0x182531470")]
		private void On_DragStart(Gesture gesture)
		{
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x25316F0", Offset = "0x25302F0", VA = "0x1825316F0")]
		private void On_Drag(Gesture gesture)
		{
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x2531430", Offset = "0x2530030", VA = "0x182531430")]
		private void On_DragEnd(Gesture gesture)
		{
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x2530FB0", Offset = "0x252FBB0", VA = "0x182530FB0")]
		private Vector3 GetPositionAxes(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x2531CF0", Offset = "0x25308F0", VA = "0x182531CF0")]
		public void StopDrag()
		{
		}

		// Token: 0x04000B16 RID: 2838
		[Token(Token = "0x4000B16")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public QuickDrag.OnDragStart onDragStart;

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4000B17")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public QuickDrag.OnDrag onDrag;

		// Token: 0x04000B18 RID: 2840
		[Token(Token = "0x4000B18")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public QuickDrag.OnDragEnd onDragEnd;

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4000B19")]
		[FieldOffset(Offset = "0x88")]
		public bool isStopOncollisionEnter;

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 deltaPosition;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		[FieldOffset(Offset = "0x98")]
		private bool isOnDrag;

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4000B1C")]
		[FieldOffset(Offset = "0xA0")]
		private Gesture lastGesture;

		// Token: 0x020001F4 RID: 500
		[Token(Token = "0x20001F4")]
		[Serializable]
		public class OnDragStart : UnityEvent<Gesture>
		{
			// Token: 0x060008DE RID: 2270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x252FCE0", Offset = "0x252E8E0", VA = "0x18252FCE0")]
			public OnDragStart()
			{
			}
		}

		// Token: 0x020001F5 RID: 501
		[Token(Token = "0x20001F5")]
		[Serializable]
		public class OnDrag : UnityEvent<Gesture>
		{
			// Token: 0x060008DF RID: 2271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x252FD20", Offset = "0x252E920", VA = "0x18252FD20")]
			public OnDrag()
			{
			}
		}

		// Token: 0x020001F6 RID: 502
		[Token(Token = "0x20001F6")]
		[Serializable]
		public class OnDragEnd : UnityEvent<Gesture>
		{
			// Token: 0x060008E0 RID: 2272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x252FCA0", Offset = "0x252E8A0", VA = "0x18252FCA0")]
			public OnDragEnd()
			{
			}
		}
	}
}
