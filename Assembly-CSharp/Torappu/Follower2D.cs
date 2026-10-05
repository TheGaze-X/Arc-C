using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000552 RID: 1362
	[Token(Token = "0x2000552")]
	public class Follower2D : MonoBehaviour
	{
		// Token: 0x06005ABA RID: 23226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABA")]
		[Address(RVA = "0x1AEF1F0", Offset = "0x1AEDDF0", VA = "0x181AEF1F0")]
		public void Follow(Transform target, Vector2 offset)
		{
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABB")]
		[Address(RVA = "0x1AEF3E0", Offset = "0x1AEDFE0", VA = "0x181AEF3E0")]
		public void UnFollow(Transform target)
		{
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABC")]
		[Address(RVA = "0x1AEF4A0", Offset = "0x1AEE0A0", VA = "0x181AEF4A0")]
		public void UnFollow()
		{
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABD")]
		[Address(RVA = "0x1AEF4F0", Offset = "0x1AEE0F0", VA = "0x181AEF4F0")]
		public void UpdatePosition()
		{
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x0002EA70 File Offset: 0x0002CC70
		[Token(Token = "0x6005ABE")]
		[Address(RVA = "0x1AEF600", Offset = "0x1AEE200", VA = "0x181AEF600")]
		private Vector2 _GetTargetPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABF")]
		[Address(RVA = "0x1AEF660", Offset = "0x1AEE260", VA = "0x181AEF660")]
		private void _SetPosition(Vector2 pos)
		{
		}

		// Token: 0x06005AC0 RID: 23232 RVA: 0x0002EA88 File Offset: 0x0002CC88
		[Token(Token = "0x6005AC0")]
		[Address(RVA = "0x1AEF640", Offset = "0x1AEE240", VA = "0x181AEF640")]
		private float _GetValue(float newVal, float oldVal, float threshold)
		{
			return 0f;
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC1")]
		[Address(RVA = "0x1AEF4F0", Offset = "0x1AEE0F0", VA = "0x181AEF4F0")]
		private void Update()
		{
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC2")]
		[Address(RVA = "0x1AEF2A0", Offset = "0x1AEDEA0", VA = "0x181AEF2A0")]
		private void Start()
		{
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC3")]
		[Address(RVA = "0x1AEF700", Offset = "0x1AEE300", VA = "0x181AEF700")]
		public Follower2D()
		{
		}

		// Token: 0x0400207E RID: 8318
		[Token(Token = "0x400207E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector2 _moveThreshold;

		// Token: 0x0400207F RID: 8319
		[Token(Token = "0x400207F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _inactiveWhenUnFollow;

		// Token: 0x04002080 RID: 8320
		[Token(Token = "0x4002080")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _followOnce;

		// Token: 0x04002081 RID: 8321
		[Token(Token = "0x4002081")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _targetOnStart;

		// Token: 0x04002082 RID: 8322
		[Token(Token = "0x4002082")]
		[FieldOffset(Offset = "0x30")]
		[Inspect]
		[ReadOnly]
		private Transform m_target;

		// Token: 0x04002083 RID: 8323
		[Token(Token = "0x4002083")]
		[FieldOffset(Offset = "0x38")]
		[Inspect]
		[ReadOnly]
		private Vector2 m_offset;

		// Token: 0x04002084 RID: 8324
		[Token(Token = "0x4002084")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 m_lastPos;
	}
}
