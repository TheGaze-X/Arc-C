using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003329 RID: 13097
	[Token(Token = "0x2003329")]
	public class UIFollower : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x06014D77 RID: 85367 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014D78 RID: 85368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003167")]
		protected Transform target
		{
			[Token(Token = "0x6014D77")]
			[Address(RVA = "0xD4BA30", Offset = "0xD4A630", VA = "0x180D4BA30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6014D78")]
			[Address(RVA = "0xD4BA90", Offset = "0xD4A690", VA = "0x180D4BA90")]
			set
			{
			}
		}

		// Token: 0x06014D79 RID: 85369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D79")]
		[Address(RVA = "0xD4B1A0", Offset = "0xD49DA0", VA = "0x180D4B1A0")]
		public void Follow(Transform target, Vector2 offset)
		{
		}

		// Token: 0x06014D7A RID: 85370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D7A")]
		[Address(RVA = "0xD4B330", Offset = "0xD49F30", VA = "0x180D4B330")]
		public void UnFollow(Transform target)
		{
		}

		// Token: 0x06014D7B RID: 85371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D7B")]
		[Address(RVA = "0xD4B290", Offset = "0xD49E90", VA = "0x180D4B290")]
		public void UnFollow()
		{
		}

		// Token: 0x06014D7C RID: 85372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D7C")]
		[Address(RVA = "0xD4B470", Offset = "0xD4A070", VA = "0x180D4B470", Slot = "4")]
		public virtual void Update()
		{
		}

		// Token: 0x06014D7D RID: 85373 RVA: 0x00088D88 File Offset: 0x00086F88
		[Token(Token = "0x6014D7D")]
		[Address(RVA = "0xD4B590", Offset = "0xD4A190", VA = "0x180D4B590")]
		private Vector2 _GetTargetPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06014D7E RID: 85374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D7E")]
		[Address(RVA = "0xD4B880", Offset = "0xD4A480", VA = "0x180D4B880")]
		private void _SetPosition(Vector2 pos)
		{
		}

		// Token: 0x06014D7F RID: 85375 RVA: 0x00088DA0 File Offset: 0x00086FA0
		[Token(Token = "0x6014D7F")]
		[Address(RVA = "0xD4B7D0", Offset = "0xD4A3D0", VA = "0x180D4B7D0")]
		private float _GetValue(float newVal, float oldVal, float threshold)
		{
			return 0f;
		}

		// Token: 0x06014D80 RID: 85376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D80")]
		[Address(RVA = "0xD4B990", Offset = "0xD4A590", VA = "0x180D4B990")]
		public UIFollower()
		{
		}

		// Token: 0x04018C71 RID: 101489
		[Token(Token = "0x4018C71")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector2 _moveThreshold;

		// Token: 0x04018C72 RID: 101490
		[Token(Token = "0x4018C72")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _inactiveWhenUnFollow;

		// Token: 0x04018C73 RID: 101491
		[Token(Token = "0x4018C73")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _targetInGameSpace;

		// Token: 0x04018C74 RID: 101492
		[Token(Token = "0x4018C74")]
		[FieldOffset(Offset = "0x28")]
		[Inspect]
		[ReadOnly]
		private Transform m_target;

		// Token: 0x04018C75 RID: 101493
		[Token(Token = "0x4018C75")]
		[FieldOffset(Offset = "0x30")]
		[Inspect]
		[ReadOnly]
		private Vector2 m_offset;

		// Token: 0x04018C76 RID: 101494
		[Token(Token = "0x4018C76")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 m_lastPos;

		// Token: 0x04018C77 RID: 101495
		[Token(Token = "0x4018C77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x04018C78 RID: 101496
		[Token(Token = "0x4018C78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_target;

		// Token: 0x04018C79 RID: 101497
		[Token(Token = "0x4018C79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Follow;

		// Token: 0x04018C7A RID: 101498
		[Token(Token = "0x4018C7A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UnFollow;

		// Token: 0x04018C7B RID: 101499
		[Token(Token = "0x4018C7B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_UnFollow;

		// Token: 0x04018C7C RID: 101500
		[Token(Token = "0x4018C7C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018C7D RID: 101501
		[Token(Token = "0x4018C7D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetTargetPosition;

		// Token: 0x04018C7E RID: 101502
		[Token(Token = "0x4018C7E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetPosition;

		// Token: 0x04018C7F RID: 101503
		[Token(Token = "0x4018C7F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetValue;

		// Token: 0x04018C80 RID: 101504
		[Token(Token = "0x4018C80")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
