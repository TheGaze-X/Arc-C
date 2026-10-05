using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000553 RID: 1363
	[Token(Token = "0x2000553")]
	public class Follower3D : MonoBehaviour
	{
		// Token: 0x06005AC4 RID: 23236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC4")]
		[Address(RVA = "0x1AEF760", Offset = "0x1AEE360", VA = "0x181AEF760")]
		public void Follow(Transform target, Vector3 offset)
		{
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC5")]
		[Address(RVA = "0x1AEF880", Offset = "0x1AEE480", VA = "0x181AEF880")]
		public void UnFollow(Transform target)
		{
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC6")]
		[Address(RVA = "0x1AEF830", Offset = "0x1AEE430", VA = "0x181AEF830")]
		public void UnFollow()
		{
		}

		// Token: 0x06005AC7 RID: 23239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC7")]
		[Address(RVA = "0x1AEF940", Offset = "0x1AEE540", VA = "0x181AEF940")]
		private void Update()
		{
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x0002EAA0 File Offset: 0x0002CCA0
		[Token(Token = "0x6005AC8")]
		[Address(RVA = "0x1AEFAA0", Offset = "0x1AEE6A0", VA = "0x181AEFAA0")]
		private Vector3 _GetTargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC9")]
		[Address(RVA = "0x1AEFAE0", Offset = "0x1AEE6E0", VA = "0x181AEFAE0")]
		private void _SetPosition(Vector3 pos)
		{
		}

		// Token: 0x06005ACA RID: 23242 RVA: 0x0002EAB8 File Offset: 0x0002CCB8
		[Token(Token = "0x6005ACA")]
		[Address(RVA = "0x1AEF640", Offset = "0x1AEE240", VA = "0x181AEF640")]
		private float _GetValue(float newVal, float oldVal, float threshold)
		{
			return 0f;
		}

		// Token: 0x06005ACB RID: 23243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ACB")]
		[Address(RVA = "0x1AEFB30", Offset = "0x1AEE730", VA = "0x181AEFB30")]
		public Follower3D()
		{
		}

		// Token: 0x04002085 RID: 8325
		[Token(Token = "0x4002085")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 _moveThreshold;

		// Token: 0x04002086 RID: 8326
		[Token(Token = "0x4002086")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _inactiveWhenUnFollow;

		// Token: 0x04002087 RID: 8327
		[Token(Token = "0x4002087")]
		[FieldOffset(Offset = "0x28")]
		[Inspect]
		[ReadOnly]
		private Transform m_target;

		// Token: 0x04002088 RID: 8328
		[Token(Token = "0x4002088")]
		[FieldOffset(Offset = "0x30")]
		[Inspect]
		[ReadOnly]
		private Vector3 m_offset;

		// Token: 0x04002089 RID: 8329
		[Token(Token = "0x4002089")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_lastPos;
	}
}
